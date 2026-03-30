Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Collections.Generic

Public Class frm_perakende_odeme
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    Public Shared KolaysoftToken As String = Nothing
    Public Shared KolaysoftTokenAlinmaZamani As DateTime = Date.MinValue
    Public Shared KolaysoftCihazListesi As New List(Of String)
    Public Shared KolaysoftFirmaId As String = ""
    Private SonFaturaIcerigi As String = ""
    Private _sonOdemeID As String = ""
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private _veresiyeTahsilatBusy As Boolean = False
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
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnOdemeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOdemeSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOdemeKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOdemeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMakbuzNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnTaksitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIadeAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbMuhasebeyeIslendimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKasaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTAHSILAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPesinat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsYaziIle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_borc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_odenen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_paraustu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ortvade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents ds_odeme As System.Data.DataSet
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
    Friend WithEvents sec_sOdemeSekli As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kisayol_odeme As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_secilen_sayi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colsAlisVerisYapanAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAlisVerisYapanSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_tutar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colGECIKME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perakende_odeme))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem3 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colGECIKME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musterino = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_odeme = New System.Windows.Forms.ContextMenu()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.ds_odeme = New System.Data.DataSet()
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnOdemeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOdemeSekli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sOdemeSekli = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colnOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOdemeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_tutar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sDovizCinsi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.collDovizTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMakbuzNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOdemeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnTaksitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIadeAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbMuhasebeyeIslendimi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_secilen = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_ortvade = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_paraustu = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_odenen = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_secilen_sayi = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_borc = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTAHSILAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPesinat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYaziIle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisVerisYapanAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisVerisYapanSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colGECIKME
        '
        Me.colGECIKME.Caption = "Gün"
        Me.colGECIKME.FieldName = "GECIKME"
        Me.colGECIKME.Name = "colGECIKME"
        Me.colGECIKME.Visible = True
        Me.colGECIKME.VisibleIndex = 11
        Me.colGECIKME.Width = 64
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txt_musterino)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1468, 80)
        Me.PanelControl1.TabIndex = 2
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(509, 33)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(0, 19)
        Me.LabelControl8.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(437, 33)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 19)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Müşteri:"
        '
        'txt_musterino
        '
        Me.txt_musterino.EditValue = "0"
        Me.txt_musterino.Location = New System.Drawing.Point(253, 26)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_musterino.Properties.Appearance.Options.UseFont = True
        Me.txt_musterino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musterino.Properties.NullText = "[MüşteriNo]"
        Me.txt_musterino.Size = New System.Drawing.Size(174, 30)
        ToolTipTitleItem1.Text = "Müşteri No"
        ToolTipItem1.LeftIndent = 6
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txt_musterino.SuperTip = SuperToolTip1
        Me.txt_musterino.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ödeme İşlemi Ekranı."
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(163, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "MüşteriNo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 522)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1468, 62)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1332, 14)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(126, 35)
        ToolTipTitleItem2.Text = "Vazgeç"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Ödeme İşleminden Vazgeçip Müşteri Ekranına Dönmek için Kullanılır."
        ToolTipTitleItem3.LeftIndent = 6
        ToolTipTitleItem3.Text = "F3"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        Me.SimpleButton2.SuperTip = SuperToolTip2
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1197, 14)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(135, 35)
        ToolTipTitleItem4.Text = "Kaydet"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = resources.GetString("ToolTipItem3.Text")
        ToolTipTitleItem5.LeftIndent = 6
        ToolTipTitleItem5.Text = "F2"
        SuperToolTip3.Items.Add(ToolTipTitleItem4)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip3.Items.Add(ToolTipTitleItem5)
        Me.SimpleButton1.SuperTip = SuperToolTip3
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Kaydet F2"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarSubItem1, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Taksitleri Yazdır,Ctrl+P"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem1.Name = "BarButtonItem1"
        ToolTipTitleItem6.Text = "Taksitleri Yazdır"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Taksitler Bölümünde Yer Alan Taksitlerin Yazıcı Çıktısını Almanıza Yardımcı Olur." &
    ""
        SuperToolTip4.Items.Add(ToolTipTitleItem6)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.BarButtonItem1.SuperTip = SuperToolTip4
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Satışı Göster,F7"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        ToolTipTitleItem7.Text = "Satışı Göster"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Taksitler Bölümünde Seçili Olan Kaydın Satış Kaydını Ekrana Getirir. Gelen Ekrand" &
    "an Satış Detaylarına Ulaşabilirsiniz."
        ToolTipTitleItem8.LeftIndent = 6
        ToolTipTitleItem8.Text = "F7"
        SuperToolTip5.Items.Add(ToolTipTitleItem7)
        SuperToolTip5.Items.Add(ToolTipItem5)
        SuperToolTip5.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip5.Items.Add(ToolTipTitleItem8)
        Me.BarButtonItem2.SuperTip = SuperToolTip5
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Kaydet,F2"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        ToolTipTitleItem9.Text = "Kaydet"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = resources.GetString("ToolTipItem6.Text")
        ToolTipTitleItem10.LeftIndent = 6
        ToolTipTitleItem10.Text = "F2"
        SuperToolTip6.Items.Add(ToolTipTitleItem9)
        SuperToolTip6.Items.Add(ToolTipItem6)
        SuperToolTip6.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip6.Items.Add(ToolTipTitleItem10)
        Me.BarButtonItem3.SuperTip = SuperToolTip6
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Vazgeç,F3"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        ToolTipTitleItem11.Text = "Vazgeç"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Ödeme İşleminden Vazgeçip Müşteri Ekranına Dönmek için Kullanılır."
        ToolTipTitleItem12.LeftIndent = 6
        ToolTipTitleItem12.Text = "F3"
        SuperToolTip7.Items.Add(ToolTipTitleItem11)
        SuperToolTip7.Items.Add(ToolTipItem7)
        SuperToolTip7.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip7.Items.Add(ToolTipTitleItem12)
        Me.BarButtonItem4.SuperTip = SuperToolTip7
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Raporlar"
        Me.BarSubItem1.Id = 4
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Önizle"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Dizayn"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Yazdır"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1468, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 584)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1468, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 584)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1468, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 584)
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl6)
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1468, 442)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.GroupControl2)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(2, 276)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1068, 164)
        Me.PanelControl6.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1064, 160)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Müşteriden Alınan Ödeme Buraya Girilir."
        Me.ToolTipController1.SetTitle(Me.GroupControl2, "Ödeme Alma")
        Me.ToolTipController1.SetToolTip(Me.GroupControl2, resources.GetString("GroupControl2.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.GroupControl2, DevExpress.Utils.ToolTipIconType.Information)
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_odeme
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_odeme
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 29)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sOdemeSekli, Me.sec_sDovizCinsi, Me.sec_tutar})
        Me.GridControl2.Size = New System.Drawing.Size(1060, 129)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_odeme
        '
        Me.kisayol_odeme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem21, Me.MenuItem20})
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem24.Text = "Tamam"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem25.Text = "Vazgec"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 3
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem17.Text = "Satır Ekle"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 4
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Satır Düzelt"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem19.Text = "Satır Sil"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 7
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem20.Text = "Taksitleri Seç"
        '
        'ds_odeme
        '
        Me.ds_odeme.DataSetName = "NewDataSet"
        Me.ds_odeme.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_odeme.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nOdemeID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "nAlisverisID"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sOdemeSekli"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "nOdemeKodu"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "dteOdemeTarihi"
        Me.DataColumn6.ColumnName = "dteOdemeTarihi"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "dteValorTarihi"
        Me.DataColumn7.DataType = GetType(Date)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lOdemeTutar"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sDovizCinsi"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "lDovizTutar"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lMakbuzNo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lOdemeNo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nTaksitID"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "nIadeAlisverisID"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nKasaNo"
        Me.DataColumn16.DataType = GetType(Long)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sKartNo"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sKullaniciAdi"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "dteKayitTarihi"
        Me.DataColumn19.DataType = GetType(Date)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sMagaza"
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnOdemeID, Me.colnAlisverisID, Me.colsOdemeSekli, Me.colnOdemeKodu, Me.colsKasiyerRumuzu, Me.coldteOdemeTarihi, Me.coldteValorTarihi, Me.collOdemeTutar, Me.colsDovizCinsi, Me.collDovizTutar, Me.collMakbuzNo, Me.collOdemeNo, Me.colnTaksitID, Me.colnIadeAlisverisID, Me.colbMuhasebeyeIslendimi, Me.colnKasaNo, Me.colsKartNo, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colsMagaza})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colnOdemeID
        '
        Me.colnOdemeID.Caption = "Ödeme ID"
        Me.colnOdemeID.FieldName = "nOdemeID"
        Me.colnOdemeID.Name = "colnOdemeID"
        Me.colnOdemeID.OptionsColumn.AllowEdit = False
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "Alışveriş ID"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        Me.colnAlisverisID.OptionsColumn.AllowEdit = False
        '
        'colsOdemeSekli
        '
        Me.colsOdemeSekli.Caption = "Ödeme Şekli"
        Me.colsOdemeSekli.ColumnEdit = Me.sec_sOdemeSekli
        Me.colsOdemeSekli.FieldName = "sOdemeSekli"
        Me.colsOdemeSekli.Name = "colsOdemeSekli"
        Me.colsOdemeSekli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", "{0} Kayıt")})
        Me.colsOdemeSekli.Visible = True
        Me.colsOdemeSekli.VisibleIndex = 0
        Me.colsOdemeSekli.Width = 125
        '
        'sec_sOdemeSekli
        '
        Me.sec_sOdemeSekli.AutoHeight = False
        Me.sec_sOdemeSekli.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeSekli.DisplayMember = "sOdemeSekli"
        Me.sec_sOdemeSekli.Name = "sec_sOdemeSekli"
        Me.sec_sOdemeSekli.NullText = "[ÖdemeŞekli]"
        Me.sec_sOdemeSekli.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sOdemeSekli.ValueMember = "sOdemeSekli"
        '
        'colnOdemeKodu
        '
        Me.colnOdemeKodu.Caption = "Ödeme Kodu"
        Me.colnOdemeKodu.FieldName = "nOdemeKodu"
        Me.colnOdemeKodu.Name = "colnOdemeKodu"
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "KasiyerRumuzu"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.OptionsColumn.AllowEdit = False
        '
        'coldteOdemeTarihi
        '
        Me.coldteOdemeTarihi.Caption = "OdemeTarihi"
        Me.coldteOdemeTarihi.FieldName = "dteOdemeTarihi"
        Me.coldteOdemeTarihi.Name = "coldteOdemeTarihi"
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        '
        'collOdemeTutar
        '
        Me.collOdemeTutar.Caption = "Ödeme Tutarı"
        Me.collOdemeTutar.ColumnEdit = Me.sec_tutar
        Me.collOdemeTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00##}")})
        Me.collOdemeTutar.Visible = True
        Me.collOdemeTutar.VisibleIndex = 1
        Me.collOdemeTutar.Width = 139
        '
        'sec_tutar
        '
        Me.sec_tutar.AutoHeight = False
        Me.sec_tutar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tutar.DisplayFormat.FormatString = "#,0.00"
        Me.sec_tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_tutar.EditFormat.FormatString = "#,0.00##"
        Me.sec_tutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_tutar.Name = "sec_tutar"
        Me.sec_tutar.NullText = "0.00"
        Me.sec_tutar.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi.ColumnEdit = Me.sec_sDovizCinsi
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'sec_sDovizCinsi
        '
        Me.sec_sDovizCinsi.AutoHeight = False
        Me.sec_sDovizCinsi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDovizCinsi.DisplayMember = "sDovizCinsi"
        Me.sec_sDovizCinsi.Name = "sec_sDovizCinsi"
        Me.sec_sDovizCinsi.NullText = "[Doviz]"
        Me.sec_sDovizCinsi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sDovizCinsi.ValueMember = "sDovizCinsi"
        '
        'collDovizTutar
        '
        Me.collDovizTutar.Caption = "Döviz Tutar"
        Me.collDovizTutar.ColumnEdit = Me.sec_tutar
        Me.collDovizTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizTutar.FieldName = "lDovizTutar"
        Me.collDovizTutar.Name = "collDovizTutar"
        Me.collDovizTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizTutar", "{0:#,0.00##}")})
        '
        'collMakbuzNo
        '
        Me.collMakbuzNo.Caption = "MakbuzNo"
        Me.collMakbuzNo.FieldName = "lMakbuzNo"
        Me.collMakbuzNo.Name = "collMakbuzNo"
        '
        'collOdemeNo
        '
        Me.collOdemeNo.Caption = "OdemeNo"
        Me.collOdemeNo.FieldName = "lOdemeNo"
        Me.collOdemeNo.Name = "collOdemeNo"
        '
        'colnTaksitID
        '
        Me.colnTaksitID.Caption = "TaksitID"
        Me.colnTaksitID.FieldName = "nTaksitID"
        Me.colnTaksitID.Name = "colnTaksitID"
        Me.colnTaksitID.OptionsColumn.AllowEdit = False
        '
        'colnIadeAlisverisID
        '
        Me.colnIadeAlisverisID.Caption = "IadeAlisverisID"
        Me.colnIadeAlisverisID.FieldName = "nIadeAlisverisID"
        Me.colnIadeAlisverisID.Name = "colnIadeAlisverisID"
        Me.colnIadeAlisverisID.OptionsColumn.AllowEdit = False
        '
        'colbMuhasebeyeIslendimi
        '
        Me.colbMuhasebeyeIslendimi.Caption = "Muhasebeye İşlendimi"
        Me.colbMuhasebeyeIslendimi.FieldName = "bMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.Name = "colbMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.OptionsColumn.AllowEdit = False
        '
        'colnKasaNo
        '
        Me.colnKasaNo.Caption = "KasaNo"
        Me.colnKasaNo.FieldName = "nKasaNo"
        Me.colnKasaNo.Name = "colnKasaNo"
        Me.colnKasaNo.OptionsColumn.AllowEdit = False
        '
        'colsKartNo
        '
        Me.colsKartNo.Caption = "KartNo"
        Me.colsKartNo.FieldName = "sKartNo"
        Me.colsKartNo.Name = "colsKartNo"
        Me.colsKartNo.Visible = True
        Me.colsKartNo.VisibleIndex = 2
        Me.colsKartNo.Width = 296
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanıcı Adı"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Mağaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.OptionsColumn.AllowEdit = False
        '
        'PanelControl5
        '
        Me.PanelControl5.Appearance.BackColor = System.Drawing.Color.Black
        Me.PanelControl5.Appearance.Options.UseBackColor = True
        Me.PanelControl5.Controls.Add(Me.lbl_secilen)
        Me.PanelControl5.Controls.Add(Me.LabelControl4)
        Me.PanelControl5.Controls.Add(Me.lbl_ortvade)
        Me.PanelControl5.Controls.Add(Me.LabelControl11)
        Me.PanelControl5.Controls.Add(Me.lbl_gun)
        Me.PanelControl5.Controls.Add(Me.LabelControl9)
        Me.PanelControl5.Controls.Add(Me.lbl_paraustu)
        Me.PanelControl5.Controls.Add(Me.LabelControl7)
        Me.PanelControl5.Controls.Add(Me.lbl_odenen)
        Me.PanelControl5.Controls.Add(Me.LabelControl5)
        Me.PanelControl5.Controls.Add(Me.lbl_secilen_sayi)
        Me.PanelControl5.Controls.Add(Me.LabelControl3)
        Me.PanelControl5.Controls.Add(Me.lbl_borc)
        Me.PanelControl5.Controls.Add(Me.LabelControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl5.Location = New System.Drawing.Point(1070, 276)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(396, 164)
        Me.PanelControl5.TabIndex = 1
        '
        'lbl_secilen
        '
        Me.lbl_secilen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen.Location = New System.Drawing.Point(179, 51)
        Me.lbl_secilen.Name = "lbl_secilen"
        Me.lbl_secilen.Size = New System.Drawing.Size(20, 21)
        Me.lbl_secilen.TabIndex = 22
        Me.lbl_secilen.Text = "%"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(27, 50)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(98, 21)
        Me.LabelControl4.TabIndex = 21
        Me.LabelControl4.Text = "SeçilenTutar:"
        '
        'lbl_ortvade
        '
        Me.lbl_ortvade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ortvade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_ortvade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_ortvade.Location = New System.Drawing.Point(179, 126)
        Me.lbl_ortvade.Name = "lbl_ortvade"
        Me.lbl_ortvade.Size = New System.Drawing.Size(20, 21)
        Me.lbl_ortvade.TabIndex = 20
        Me.lbl_ortvade.Text = "%"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(13, 124)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(112, 21)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "OrtalamaVade:"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(179, 107)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(20, 21)
        Me.lbl_gun.TabIndex = 18
        Me.lbl_gun.Text = "%"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(21, 106)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(104, 21)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "OrtalamaGün:"
        '
        'lbl_paraustu
        '
        Me.lbl_paraustu.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_paraustu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_paraustu.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_paraustu.Location = New System.Drawing.Point(179, 89)
        Me.lbl_paraustu.Name = "lbl_paraustu"
        Me.lbl_paraustu.Size = New System.Drawing.Size(20, 21)
        Me.lbl_paraustu.TabIndex = 16
        Me.lbl_paraustu.Text = "%"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(51, 87)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(73, 21)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "ParaÜstü:"
        '
        'lbl_odenen
        '
        Me.lbl_odenen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_odenen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_odenen.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_odenen.Location = New System.Drawing.Point(179, 70)
        Me.lbl_odenen.Name = "lbl_odenen"
        Me.lbl_odenen.Size = New System.Drawing.Size(20, 21)
        Me.lbl_odenen.TabIndex = 14
        Me.lbl_odenen.Text = "%"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(61, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 21)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Ödenen:"
        '
        'lbl_secilen_sayi
        '
        Me.lbl_secilen_sayi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen_sayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen_sayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen_sayi.Location = New System.Drawing.Point(179, 33)
        Me.lbl_secilen_sayi.Name = "lbl_secilen_sayi"
        Me.lbl_secilen_sayi.Size = New System.Drawing.Size(20, 21)
        Me.lbl_secilen_sayi.TabIndex = 12
        Me.lbl_secilen_sayi.Text = "%"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(24, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 21)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "SeçilenTaksit:"
        '
        'lbl_borc
        '
        Me.lbl_borc.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_borc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_borc.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_borc.Location = New System.Drawing.Point(179, 14)
        Me.lbl_borc.Name = "lbl_borc"
        Me.lbl_borc.Size = New System.Drawing.Size(20, 21)
        Me.lbl_borc.TabIndex = 10
        Me.lbl_borc.Text = "%"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(29, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 21)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Toplam Borç:"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GroupControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1464, 274)
        Me.PanelControl4.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.Panelstatus)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1460, 270)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Müşteri Taksitleri..."
        Me.ToolTipController1.SetTitle(Me.GroupControl1, "Taksitler")
        Me.ToolTipController1.SetToolTip(Me.GroupControl1, resources.GetString("GroupControl1.ToolTip"))
        Me.ToolTipController1.SetToolTipIconType(Me.GroupControl1, DevExpress.Utils.ToolTipIconType.Application)
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(235, 78)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(1007, 152)
        Me.Panelstatus.TabIndex = 5
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(16, 104)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(969, 26)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(13, 70)
        Me.barlabel2.Name = "barlabel2"
        Me.barlabel2.Size = New System.Drawing.Size(80, 21)
        Me.barlabel2.TabIndex = 2
        Me.barlabel2.Text = "barlabel2"
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(13, 4)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(69, 21)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(13, 31)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(968, 26)
        Me.bar.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 29)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1456, 239)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem16, Me.MenuItem23, Me.MenuItem22, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem27, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem16.Text = "Satışı Göster"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 3
        Me.MenuItem23.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem22.Text = "Ödemeleri Seç"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 6
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 7
        Me.MenuItem2.Text = "Başlık Değiştir"
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
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        Me.MenuItem10.Text = "-"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 11
        Me.MenuItem27.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 12
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 13
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 14
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 15
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 16
        Me.MenuItem8.Text = "Satırları Kapat"
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
        Me.MenuItem9.Text = "Ekranı Kapla"
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
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colkodu, Me.colTUTAR, Me.colTAHSILAT, Me.colKALAN, Me.colAY, Me.colYIL, Me.coldteTarihi, Me.colsFisTipi, Me.coldteFaturaTarihi, Me.collFaturaNo, Me.collToplamMiktar, Me.collPesinat, Me.collNetTutar, Me.colsYaziIle, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colsAdi, Me.colsSoyadi, Me.colGECIKME, Me.colsAlisVerisYapanAdi, Me.colsAlisVerisYapanSoyadi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(590, 408, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colGECIKME
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Me.colTUTAR, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", Me.colTAHSILAT, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Me.colKALAN, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Me.coldteTarihi, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lToplamMiktar", Nothing, "{0:#,0.##} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lNetTutar", Nothing, "ToplamTutar : {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "Kalan  {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "Tutarı  : {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müşteri No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.Width = 73
        '
        'colkodu
        '
        Me.colkodu.Caption = "Müşteri Kodu"
        Me.colkodu.FieldName = "kodu"
        Me.colkodu.Name = "colkodu"
        Me.colkodu.Width = 45
        '
        'colTUTAR
        '
        Me.colTUTAR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTUTAR.AppearanceCell.Options.UseFont = True
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 8
        Me.colTUTAR.Width = 55
        '
        'colTAHSILAT
        '
        Me.colTAHSILAT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTAHSILAT.AppearanceCell.Options.UseFont = True
        Me.colTAHSILAT.Caption = "Ödenen"
        Me.colTAHSILAT.FieldName = "TAHSILAT"
        Me.colTAHSILAT.Name = "colTAHSILAT"
        Me.colTAHSILAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", "{0:#,0.00}")})
        Me.colTAHSILAT.Visible = True
        Me.colTAHSILAT.VisibleIndex = 9
        '
        'colKALAN
        '
        Me.colKALAN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colKALAN.AppearanceCell.Options.UseFont = True
        Me.colKALAN.Caption = "Kalan"
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.00}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 10
        Me.colKALAN.Width = 80
        '
        'colAY
        '
        Me.colAY.Caption = "Ay"
        Me.colAY.DisplayFormat.FormatString = "m"
        Me.colAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAY.FieldName = "dteTarihi"
        Me.colAY.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
        Me.colAY.Name = "colAY"
        Me.colAY.Width = 72
        '
        'colYIL
        '
        Me.colYIL.Caption = "Yıl"
        Me.colYIL.FieldName = "YIL"
        Me.colYIL.Name = "colYIL"
        Me.colYIL.Width = 37
        '
        'coldteTarihi
        '
        Me.coldteTarihi.Caption = "Vade"
        Me.coldteTarihi.DisplayFormat.FormatString = "D"
        Me.coldteTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", "{0} Kayıt")})
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 7
        Me.coldteTarihi.Width = 121
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "Fiş Tipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 0
        Me.colsFisTipi.Width = 46
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 66
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "FaturaNo"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 2
        Me.collFaturaNo.Width = 63
        '
        'collToplamMiktar
        '
        Me.collToplamMiktar.Caption = "Miktar"
        Me.collToplamMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collToplamMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamMiktar.FieldName = "lToplamMiktar"
        Me.collToplamMiktar.Name = "collToplamMiktar"
        Me.collToplamMiktar.Visible = True
        Me.collToplamMiktar.VisibleIndex = 3
        Me.collToplamMiktar.Width = 41
        '
        'collPesinat
        '
        Me.collPesinat.Caption = "Peşinat"
        Me.collPesinat.FieldName = "lPesinat"
        Me.collPesinat.Name = "collPesinat"
        Me.collPesinat.Visible = True
        Me.collPesinat.VisibleIndex = 4
        Me.collPesinat.Width = 52
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Tutar"
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 5
        Me.collNetTutar.Width = 47
        '
        'colsYaziIle
        '
        Me.colsYaziIle.Caption = "Yazıyla"
        Me.colsYaziIle.FieldName = "sYaziIle"
        Me.colsYaziIle.Name = "colsYaziIle"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "KasaNo"
        Me.GridColumn1.FieldName = "nKasaNo"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Saat"
        Me.GridColumn2.DisplayFormat.FormatString = "HH:mm:ss"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "dteKayitTarihi"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 54
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "AlışVeriş No"
        Me.GridColumn3.FieldName = "nAlisverisID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "MüşteriAd"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Width = 31
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "MüşteriSoyad"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Width = 38
        '
        'colsAlisVerisYapanAdi
        '
        Me.colsAlisVerisYapanAdi.Caption = "Av.Yapan Adı"
        Me.colsAlisVerisYapanAdi.FieldName = "sAlisverisYapanAdi"
        Me.colsAlisVerisYapanAdi.Name = "colsAlisVerisYapanAdi"
        '
        'colsAlisVerisYapanSoyadi
        '
        Me.colsAlisVerisYapanSoyadi.Caption = "Av.Yapan Soyadı"
        Me.colsAlisVerisYapanSoyadi.FieldName = "sAlisverisYapanSoyadi"
        Me.colsAlisVerisYapanSoyadi.Name = "colsAlisVerisYapanSoyadi"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Taksit Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "CRM-Müşteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTipController1
        '
        Me.ToolTipController1.ShowBeak = True
        Me.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "FIRMAKODU"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ADI"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "SOYADI"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "BELGENO"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "TARIH"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "MIKTAR"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "TUTAR"
        Me.DataColumn27.DataType = GetType(Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "ALISVERISNO"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "IZAHAT"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "VADEFARKI"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "MAGAZA"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "KASIYER"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "GIRIS"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "YAZI"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "DOGUMTARIHI"
        Me.DataColumn35.DataType = GetType(Date)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "EVLILIKTARIHI"
        Me.DataColumn36.DataType = GetType(Date)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "YAZDIRMA"
        Me.DataColumn37.DataType = GetType(Long)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "MEKTUPSAYISI"
        Me.DataColumn38.DataType = GetType(Long)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "SONSATISTARIHI"
        Me.DataColumn39.DataType = GetType(Date)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "SONTAHSILATTARIHI"
        Me.DataColumn40.DataType = GetType(Date)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "SATISTUTARI"
        Me.DataColumn41.DataType = GetType(Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "SATISMIKTARI"
        Me.DataColumn42.DataType = GetType(Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "IADETUTARI"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "IADEMIKTARI"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "TOPLAMSATISTUTARI"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "TOPLAMSATISMIKTARI"
        Me.DataColumn46.DataType = GetType(Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "TOPLAMPESINAT"
        Me.DataColumn47.DataType = GetType(Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "TOPLAMTAKSIT"
        Me.DataColumn48.DataType = GetType(Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "GECIKENILKTAKSITTARIHI"
        Me.DataColumn49.DataType = GetType(Date)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "GECIKENILKTAKSITTUTARI"
        Me.DataColumn50.DataType = GetType(Decimal)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "TOPLAMTAHSILAT"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "TOPLAMKALAN"
        Me.DataColumn52.DataType = GetType(Decimal)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "GECIKMISKALAN"
        Me.DataColumn53.DataType = GetType(Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "GECIKMISTAKSIT"
        Me.DataColumn54.DataType = GetType(Decimal)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "KALANTAKSITSAYISI"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "SATISSAYISI"
        Me.DataColumn56.DataType = GetType(Long)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "IADESAYISI"
        Me.DataColumn57.DataType = GetType(Long)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "SONSATISTUTARI"
        Me.DataColumn58.DataType = GetType(Decimal)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "SONTAHSILATTUTARI"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "GUNUNDE"
        Me.DataColumn60.DataType = GetType(Long)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "ERKEN"
        Me.DataColumn61.DataType = GetType(Long)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "GECIKMIS"
        Me.DataColumn62.DataType = GetType(Long)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "TOPLAM"
        Me.DataColumn63.DataType = GetType(Long)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "STATUS"
        Me.DataColumn64.DataType = GetType(Boolean)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "KAYIT"
        Me.DataColumn65.DataType = GetType(Date)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "SOZLESME"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "ISTIHBARAT"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "nMusteriID"
        Me.DataColumn68.DataType = GetType(Long)
        '
        'frm_perakende_odeme
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1468, 619)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_perakende_odeme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ödeme"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sKasiyerRumuzu
    Public sKasiyer As String
    Public nKasaNo As Int64
    Public nMusteriID As Int64
    Public lKodu As String
    Public sMusteri As String
    Public dteFisTarihi As DateTime
    Public sMagaza As String
    Public nOdemeKodu As Integer = 2
    Dim lMakbuzno As Int64 = 0
    Dim ds_taksit As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim dr As DataRow
    Dim dr_odeme As DataRow
    Dim dr_taksit As DataRow
    Dim toplam As Decimal = 0
    Dim lToplamTutar As Decimal = 0
    'Taksit Kontrol Satırlar
    Dim ds_taksit_kalan As DataSet
    Dim ds_taksitler As DataSet
    Dim ds_satislar As DataSet
    Dim ds_satislar_detayli As DataSet
    Dim ds_tahsilatlar As DataSet
    Dim ds_odemeler As DataSet
    Dim ds_stok_fisi As DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim status As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub veriYukle()
        Dim dr2 As DataRow = DataSet1.Tables(0).NewRow
        dr2("FIRMAKODU") = lKodu
        dr2("STATUS") = "False"
        dr2("nMusteriID") = nMusteriID
        DataSet1.Tables(0).Rows.Add(dr2)
        ds_taksit = tbTaksit(nMusteriID)
        ds_odeme.Clear()
        If ds_taksit.Tables(0).Rows.Count >= 0 Then
            dataload_tbOdemeSekli()
            dataload_tbDovizCinsi()
            GridControl1.DataMember = Nothing
            GridControl1.DataSource = ds_taksit.Tables(0)
            GridControl1.Focus()
            GridControl1.Select()
            Try
                gorunum_yukle()
            Catch ex As Exception
            End Try
            toplam_hesapla()
            GridControl2.DataMember = Nothing
            GridControl2.DataSource = ds_odeme.Tables(0)
            GridView2.FocusedRowHandle = 1
            dr_taksit = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Try
                pesinat_satir_ekle(dr_taksit("KALAN"))
            Catch ex As Exception
                pesinat_satir_ekle(0)
            End Try
            status = True
            Dim dr1 As DataRow
            Dim sayi As Integer = 0
            For Each dr1 In ds_taksit.Tables(0).Rows
                If dr1("dteTarihi") <= dteFisTarihi Then
                    GridView1.SelectRow(sayi)
                End If
                sayi += 1
            Next
            dr1 = Nothing
            sayi = Nothing
            GroupControl2.Focus()
            GroupControl2.Select()
            GridControl2.Focus()
            GridControl2.Select()
            GridView2.FocusedColumn = collOdemeTutar
        ElseIf nOdemeKodu = 2 Then
            XtraMessageBox.Show(Sorgu_sDil("Müşterinin Acik Borcu Gozukmemektedir...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        ElseIf nOdemeKodu = 4 Then
            GroupControl1.Visible = False
        End If
    End Sub
    Private Sub frm_perakende_odeme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        veriYukle()
        'txt_musterino.Text = lKodu
        'musteri_kontrol()
    End Sub
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        toplam = 0
        For Each dr In ds_taksit.Tables(0).Rows
            toplam += dr("KALAN")
        Next
        lbl_borc.Text = toplam
        dr = Nothing
    End Sub
    Private Sub odeme_hesapla()
        Dim dr As DataRow
        Dim tbOdeme_toplam As Decimal = 0
        For Each dr In ds_odeme.Tables(0).Rows
            tbOdeme_toplam += dr("lOdemeTutar")
        Next
        lbl_odenen.Text = tbOdeme_toplam
        If tbOdeme_toplam > toplam Then
            lbl_paraustu.Text = tbOdeme_toplam - toplam
        Else
            lbl_paraustu.Text = 0
        End If
        dr = Nothing
    End Sub
    Private Sub tbOdeme_hesapla()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("lOdemeTutar") = 0 Then
                dr("lOdemeTutar") = 0.01
            End If
            dr.EndEdit()
            'tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        End If
    End Sub
    Private Sub giris_hesapla()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim tutar = 0
        Dim vade
        Dim dr As DataRow
        Dim gun As Decimal = 0
        Dim tutarvade As Decimal = 0
        Dim ortvade As Decimal = 0
        Dim ortgun As Decimal = 0
        Dim dr2 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If GridView2.RowCount = 0 Then
            pesinat_satir_ekle(dr2("KALAN"))
            GridControl2.Focus()
            GridControl2.Select()
            GridView1.FocusedRowHandle = 1
        End If
        dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                tutar = tutar + dr("KALAN")
                Try
                    gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteTarihi"))
                Catch ex As Exception
                    gun = 0
                End Try
                tutarvade = tutarvade + (dr("KALAN") * gun)
            Next
        End If
        Try
            ortvade = tutarvade / tutar
            lbl_secilen_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            lbl_odenen.Text = FormatNumber(tutar, 2)
            dr_odeme("lOdemeTutar") = tutar
            lbl_paraustu.Text = "0.00"
            lbl_gun.Text = CInt(ortvade)
            lbl_ortvade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_secilen_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            dr_odeme("lOdemeTutar") = tutar
            lbl_odenen.Text = FormatNumber(tutar, 2)
            lbl_paraustu.Text = "0.00"
            lbl_gun.Text = CInt(ortvade)
            lbl_ortvade.Text = ""
        End Try
        dr2 = Nothing
        dr = Nothing
        s = Nothing
        i = Nothing
        tutar = Nothing
        vade = Nothing
        gun = Nothing
    End Sub
    Public Function tbTaksit(ByVal nMusteriID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi,tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo,tbAlisVeris.nAlisverisID, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID,tbMusteri.sAdi, tbMusteri.sSoyadi,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo,tbAlisVeris.nAlisverisID,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi, tbMusteri.sSoyadi,  tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbTaksit.dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "DATATABLE1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_tbOdemeSekli()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbOdemeSekli Order by sOdemeSekli ")).Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nOdemeID, '" & sDepo & "', ''), 0) + 1 AS nOdemeID FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') ORDER BY dteOdemeTarihi DESC, nOdemeID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo,0) + 1 lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=2 ORDER BY lMakbuzNo DESC")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lMakbuzNo), 0) + 1 AS lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=2 ORDER BY lMakbuzNo DESC")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lOdemeNo1,0)+1 FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lOdemeNo1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
    Private Sub pesinat_satir_ekle(ByVal lKalanTutar As Decimal)
        'pesinat_satir_info()
        Dim dr As DataRow = ds_odeme.Tables(0).NewRow
        Dim nOdemeID = ""  'Trim(sMagaza) + sorgu_nOdemeID(sMagaza).ToString
        lMakbuzno = 0
        dr("nOdemeID") = nOdemeID
        dr("nAlisverisID") = ""
        dr("sOdemeSekli") = "N   "
        dr("nOdemeKodu") = 2
        dr("sKasiyerRumuzu") = sKasiyerRumuzu
        dr("dteOdemeTarihi") = dteFisTarihi
        dr("dteValorTarihi") = dteFisTarihi
        dr("lOdemeTutar") = lKalanTutar
        dr("sDovizCinsi") = ""
        dr("lDovizTutar") = 0
        dr("lMakbuzNo") = lMakbuzno
        dr("lOdemeNo") = lMakbuzno
        dr("nTaksitID") = ""
        dr("nIadeAlisverisID") = ""
        dr("bMuhasebeyeIslendimi") = 0
        dr("nKasaNo") = nKasaNo
        If nOdemeKodu = 4 Then
            dr("sKartNo") = "Pesinat\"
        Else
            dr("sKartNo") = ""
        End If
        dr("sKullaniciAdi") = kullaniciadi
        dr("dteKayitTarihi") = Now
        dr("sMagaza") = sMagaza
        'tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        ds_odeme.Tables(0).Rows.Add(dr)
        nOdemeID = Nothing
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbOdeme (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('" & nOdemeID & "', '" & nAlisverisID & "', '" & sOdemeSekli & "', " & nOdemeKodu & ", '" & sKasiyerRumuzu & "', '" & dteOdemeTarihi & "', '" & dteValorTarihi & "', " & lOdemeTutar & ", '" & sDovizCinsi & "', " & lDovizTutar & ", " & lMakbuzNo & ", " & lOdemeNo & ", '" & nTaksitID & "', '" & nIadeAlisverisID & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKartNo & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_nAlisVerisID_lSayi(ByVal nAlisVerisID As String) As Integer
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        Dim kayitsayisi
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisVerisID), 0) AS nKayit FROM         tbAlisVeris WHERE     (nAlisverisID = '" & nAlisVerisID & "')")
        kayitsayisi = 0
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "') UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = '" & nAlisVerisID & "') as Kapatma")
        kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub tbAlisVeris_kaydet_yeni(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal sOdemeKodu As String, ByVal lNetTutar As Decimal, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Integer, ByVal nKasaNo As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVeris (nAlisverisID, sFisTipi, dteFaturaTarihi, nGirisCikis, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAlisverisYapanAdi, sAlisverisYapanSoyadi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, sOdemeKodu, lNetTutar, sHareketTipi, bMuhasebeyeIslendimi, nKasaNo, sKullaniciAdi, dteKayitTarihi, sYaziIle) VALUES     ('" & nAlisverisID & "', '" & sFisTipi & "', '" & dteFaturaTarihi & "', " & nGirisCikis & ", '" & lFaturaNo & "', " & nMusteriID & ", '" & sMagaza & "', '" & sKasiyerRumuzu & "', '" & sAlisverisYapanAdi & "', '" & sAlisverisYapanSoyadi & "', " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & nDipIskontoYuzdesi & ", " & lDipIskontoTutari & ", " & nKdvOrani1 & ", " & lKdvMatrahi1 & ", " & lKdv1 & ", " & nKdvOrani2 & ", " & lKdvMatrahi2 & ", " & lKdv2 & ", " & nKdvOrani3 & ", " & lKdvMatrahi3 & ", " & lKdv3 & ", " & nKdvOrani4 & ", " & lKdvMatrahi4 & ", " & lKdv4 & ", " & nKdvOrani5 & ", " & lKdvMatrahi5 & ", " & lKdv5 & ", " & lPesinat & ", " & nVadeFarkiYuzdesi & ", " & nVadeKdvOrani & ", " & lVadeKdvMatrahi & ", " & lVadeKdv & ", " & lVadeFarki & ", '" & sOdemeKodu & "', " & lNetTutar & ", '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKullaniciAdi & "',  '" & dteKayitTarihi & "', '" & sYaziIle & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub pesinat_satir_sil()
        If GridView2.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satırı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                'tbOdeme_kaydet_sil(dr("nOdemeID"))
                ds_odeme.Tables(0).Rows.Remove(dr)
                GridControl2.Focus()
                GridControl2.Select()
                If GridView2.RowCount > 0 Then
                    GridView2.SelectRow(GridView2.FocusedRowHandle)
                End If
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        stok_satis_detay()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If status = True Then
            Try
                giris_hesapla()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            tbOdeme_hesapla()
            odeme_hesapla()
        End If
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        pesinat_satir_ekle(0)
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        pesinat_satir_sil()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub tbOdeme_ekle_Pesinat()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim tutar As Decimal = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lOdemeTutar As Decimal = 0
        Dim lKur As Decimal = 0
        Dim lDovizTutar As Decimal = 0
        Dim nOdemeID As Int64 = 0
        lMakbuzno = sorgu_lMakbuzNo(sMagaza)
        lToplamTutar = 0
        'seçilenleri aktar 
        For Each dr1 In ds_odeme.Tables(0).Rows
            lOdemeTutar = dr1("lOdemeTutar")
            tutar = lOdemeTutar
            If Trim(dr1("sDovizCinsi")) <> "" Then
                lKur = dr1("lOdemeTutar") / dr1("lDovizTutar")
            Else
                lKur = 0
            End If
            nOdemeID = sorgu_nOdemeID(sMagaza)
            dr1("dteKayitTarihi") = Now
            If lKur <> 0 Then
                lDovizTutar = tutar / lKur
            Else
                lDovizTutar = 0
            End If
            If sorgu_nAlisVerisID_lSayi("") = 0 Then
                tbAlisVeris_kaydet_yeni("", "KS", dteFisTarihi, 3, lMakbuzno, nMusteriID, sMagaza, sKasiyerRumuzu, "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, sHareketTipi, 0, nKasaNo, kullaniciadi, Now, "")
            End If
            tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, "", dr1("sOdemeSekli"), 1, dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteValorTarihi"), tutar, dr1("sDovizCinsi"), lDovizTutar, lMakbuzno, lMakbuzno, "", dr1("nIadeAlisVerisID"), 0, dr1("nKasaNo"), nMusteriID, dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
            tbAvSirano_degistir(2, nOdemeID, sMagaza)
            lMakbuzNo_degistir(lMakbuzno, sMagaza)
            lOdemeTutar = 0
        Next
        If lOdemeTutar > 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Para Üstü: ", sDil) & FormatNumber(lOdemeTutar, 2), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr = Nothing
        dr1 = Nothing
        lOdemeTutar = Nothing
        nOdemeID = Nothing
    End Sub
    Private Sub tbOdeme_ekle()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim tutar As Decimal = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lOdemeTutar As Decimal = 0
        Dim lKur As Decimal = 0
        Dim lDovizTutar As Decimal = 0
        Dim nOdemeID As Int64 = 0
        lMakbuzno = sorgu_lMakbuzNo(sMagaza)
        lToplamTutar = 0
        'seçilenleri aktar 
        For Each dr1 In ds_odeme.Tables(0).Rows
            lOdemeTutar = dr1("lOdemeTutar")
            If Trim(dr1("sDovizCinsi")) <> "" Then
                lKur = dr1("lOdemeTutar") / dr1("lDovizTutar")
            Else
                lKur = 0
            End If
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If dr("KALAN") > 0 And lOdemeTutar > 0 Then
                        If lOdemeTutar > dr("KALAN") Then
                            tutar = dr("KALAN")
                            lOdemeTutar -= dr("KALAN")
                            dr("KALAN") = 0
                        ElseIf lOdemeTutar = dr("KALAN") Then
                            tutar = dr("KALAN")
                            lOdemeTutar -= dr("KALAN")
                            dr("KALAN") = 0
                        ElseIf lOdemeTutar < dr("KALAN") Then
                            tutar = lOdemeTutar 'dr("KALAN") - lOdemeTutar
                            lOdemeTutar = 0
                            dr("KALAN") = dr("KALAN") - lOdemeTutar
                        End If
                        lToplamTutar += tutar
                        nOdemeID = sorgu_nOdemeID(sMagaza)
                        dr1("dteKayitTarihi") = Now
                        If lKur <> 0 Then
                            lDovizTutar = tutar / lKur
                        Else
                            lDovizTutar = 0
                        End If
                        tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr("nAlisVerisID"), dr1("sOdemeSekli"), dr1("nOdemeKodu"), dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteValorTarihi"), tutar, dr1("sDovizCinsi"), lDovizTutar, lMakbuzno, lMakbuzno, dr("nTaksitID"), dr1("nIadeAlisVerisID"), dr1("bMuhasebeyeIslendimi"), dr1("nKasaNo"), dr1("sKartNo"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
                        tbAvSirano_degistir(2, nOdemeID, sMagaza)
                        lMakbuzNo_degistir(lMakbuzno, sMagaza)
                    End If
                Next
            End If
        Next
        If lOdemeTutar > 0 Then
            dr1 = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            For Each dr In ds_taksit.Tables(0).Rows
                If dr("KALAN") > 0 And lOdemeTutar > 0 Then
                    If lOdemeTutar > dr("KALAN") Then
                        tutar = dr("KALAN")
                        lOdemeTutar -= dr("KALAN")
                        dr("KALAN") = 0
                    ElseIf lOdemeTutar = dr("KALAN") Then
                        tutar = dr("KALAN")
                        lOdemeTutar -= dr("KALAN")
                        dr("KALAN") = 0
                    ElseIf lOdemeTutar < dr("KALAN") Then
                        tutar = lOdemeTutar 'dr("KALAN") - lOdemeTutar
                        lOdemeTutar = 0
                        dr("KALAN") = dr("KALAN") - lOdemeTutar
                    End If
                    lToplamTutar += tutar
                    nOdemeID = sorgu_nOdemeID(sMagaza)
                    'dr1("dteKayitTarihi") = Now
                    If lKur <> 0 Then
                        lDovizTutar = tutar / lKur
                    Else
                        lDovizTutar = 0
                    End If
                    tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr("nAlisVerisID"), dr1("sOdemeSekli"), dr1("nOdemeKodu"), dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteValorTarihi"), tutar, dr1("sDovizCinsi"), lDovizTutar, lMakbuzno, lMakbuzno, dr("nTaksitID"), dr1("nIadeAlisVerisID"), dr1("bMuhasebeyeIslendimi"), dr1("nKasaNo"), dr1("sKartNo"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
                    tbAvSirano_degistir(2, nOdemeID, sMagaza)
                    lMakbuzNo_degistir(lMakbuzno, sMagaza)
                End If
            Next
        End If
        If lOdemeTutar > 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Para Üstü: ", sDil) & FormatNumber(lOdemeTutar, 2), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr = Nothing
        dr1 = Nothing
        lOdemeTutar = Nothing
        nOdemeID = Nothing
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim dr3 As DataRow = DataSet1.Tables(0).Rows(0)
        If dr3("STATUS") = "False" Then
            'taksit_kontrol_satirlar()
        Else
        End If
        Dim sFile As String = ""
        Dim izahat As String = "OD"
        Dim termal As String = ""
        OpenFileDialog1.Filter = "EtiketDosyaları(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        izahat = "OD"
        Try
            termal = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("TermalOdeme").ToString
        Catch ex As Exception
            termal = False
        End Try
        If termal = True Then
            sFile = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme_termal.frx"
        Else
            sFile = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme.frx"
        End If
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_Odeme As DataSet
        Dim ds_TaksitKalan As DataSet
        Dim ds_Kampanya As DataSet
        Dim ds_Anons As DataSet
        Dim DS_Toplam As DataSet
        ds_Odeme = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         vwParekendeOdeme WHERE     (MakbuzNo = '" & lMakbuzno & "') AND (Tarihi = '" & dteFisTarihi & "') AND (Fis_Musteri_Kodu = '" & lKodu & "')"), "TAHSILAT")
        ds_TaksitKalan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU,tbAlisveris.nAlisverisID, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi,tbAlisveris.nAlisverisID) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi "), "KalanTaksit")
        DS_Toplam = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sum(tutari) as nToplamTutar FROM vwParekendeOdeme WHERE (MakbuzNo = " & lMakbuzno & ") AND  (Fis_Musteri_Kodu = " & lKodu & ") "), "TOPLAM")
        ds_Kampanya = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ATBLDOKUMKAMPANYA", "KAMPANYA")
        ds_Anons = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ATBLDOKUMANONS", "ANONS")
        Try
            report.RegisterData(ds_Odeme)
            report.RegisterData(ds_TaksitKalan)
            report.RegisterData(DS_Toplam)
            report.RegisterData(ds_Kampanya)
            report.RegisterData(ds_Anons)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("BelgeTipi", "Tahsilat")
            report.SetParameterValue("lKodu", lKodu)
            report.SetParameterValue("dteOdemeTarihi", dteFisTarihi)
        Catch ex As Exception
        End Try
        Dim sontahsilattarihi 'As DateTime
        Dim sontahsilattutari As Decimal
        Dim sonsatistarihi 'As DateTime
        Dim sonsatistutari As Decimal
        Dim gecikmistaksitsayisi As Int64
        Dim gecikmistaksittutari As Decimal
        Dim toplamkalantaksitsayisi As Int64
        Dim toplamkalantaksittutari As Decimal = 0
        Dim gecikmisodeme As Int64 = 0
        Dim gunundeodeme As Int64 = 0
        Dim erkenodeme As Int64 = 0
        Dim odemesayisi As Int64 = 0
        Dim dr2 As DataRow = DataSet1.Tables(0).Rows(0)
        gecikmistaksitsayisi = sorgu_sayi(dr2("GECIKMISTAKSIT"), 0)
        gecikmistaksittutari = sorgu_sayi(dr2("GECIKMISKALAN"), 0)
        sonsatistutari = sorgu_sayi(dr2("SONSATISTUTARI"), 0)
        'If sec_analiz.Checked = True Then
        sonsatistarihi = sorgu_tarih(dr2("SONSATISTARIHI"), "01/01/1900")
        sontahsilattarihi = sorgu_tarih(dr2("SONTAHSILATTARIHI"), "01/01/1900")
        'Else
        '    sonsatistarihi = "01/01/1900"
        '    sontahsilattarihi = "01/01/1900"
        'End If
        sontahsilattutari = sorgu_sayi(dr2("SONTAHSILATTUTARI"), 0)
        toplamkalantaksitsayisi = sorgu_sayi(dr2("KALANTAKSITSAYISI"), 0)
        toplamkalantaksittutari = sorgu_sayi(dr2("TOPLAMKALAN"), 0)
        Try
            gecikmisodeme = dr2("GECIKMIS")
            gunundeodeme = dr2("GUNUNDE")
            erkenodeme = dr2("ERKEN")
            odemesayisi = dr2("TOPLAM")
        Catch ex As Exception
            gecikmisodeme = 0
            gunundeodeme = 0
            erkenodeme = 0
            odemesayisi = 0
        End Try
        report.SetParameterValue("GecikmisTaksitSayisi", "" & gecikmistaksitsayisi & "")
        report.SetParameterValue("GecikmisTaksitTutari", "" & gecikmistaksittutari & "")
        report.SetParameterValue("SonTahsilatTutari", "" & sontahsilattutari & "")
        report.SetParameterValue("SonSatisTutari", "" & sonsatistutari & "")
        report.SetParameterValue("SonTahsilatTarihi", "" & sontahsilattarihi & "")
        report.SetParameterValue("SonSatisTarihi", "" & sonsatistarihi & "")
        report.SetParameterValue("KalanTaksitSayisi", "" & toplamkalantaksitsayisi & "")
        report.SetParameterValue("KalanTaksitTutari", "" & toplamkalantaksittutari & "")
        report.SetParameterValue("GecikmisOdeme", "" & gecikmisodeme & "")
        report.SetParameterValue("GunundeOdeme", "" & gunundeodeme & "")
        report.SetParameterValue("ErkenOdeme", "" & erkenodeme & "")
        report.SetParameterValue("ToplamOdeme", "" & odemesayisi & "")
        Dim ara As String
        Try
            ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
        Catch ex As Exception
            ara = ""
        End Try
        'MsgBox(ara)
        Dim adi As String = ""
        Dim soyadi As String = ""
        Dim x
        If CStr(ara.ToString) <> "" Then
            x = (ara).IndexOf(",", 1, (ara.Length - 1))
            If x = -1 Then
                adi = ara
            Else
                adi = (ara).Substring(0, x)
                soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                If IsNumeric(ara) Then
                Else
                End If
            End If
        End If
        If termal = True Then
            Try
                adi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterTermal").ToString
            Catch ex As Exception
                adi = ""
            End Try
        Else
            If adi.ToString <> "" Then
                report.PrintSettings.Printer = adi
            End If
        End If
        If adi.ToString <> "" Then
            report.PrintSettings.Printer = adi
        End If
        report.ScriptLanguage = Language.Vb
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 1 Then
            report.Design()
        ElseIf nIslem = 2 Then
            report.Print()
        End If
        report.Dispose()
        report = Nothing
        ds_Odeme = Nothing
        ds_TaksitKalan = Nothing
        dr2 = Nothing
    End Sub
    Private Sub raporla1(ByVal islem As Integer)
        Dim file As String = ""
        Dim dr As DataRow
        Dim musterino As Int64
        Dim sontahsilattarihi = "01/01/1900" 'As DateTime
        Dim sontahsilattutari As Decimal
        Dim sonsatistarihi = "01/01/1900" 'As DateTime
        Dim sonsatistutari As Decimal
        Dim gecikmistaksitsayisi As Int64
        Dim gecikmistaksittutari As Decimal
        Dim toplamkalantaksitsayisi As Int64
        Dim toplamkalantaksittutari As Decimal = 0
        Dim gecikmisodeme As Int64 = 0
        Dim gunundeodeme As Int64 = 0
        Dim erkenodeme As Int64 = 0
        Dim odemesayisi As Int64 = 0
        Dim izahat As String
        Dim satir_kontrol As String = ""
        Dim tarih As DateTime
        Dim belgeno As String
        Dim musterikodu As String
        Dim miktar As Decimal
        Dim tutar As Decimal
        Dim termal As Boolean = False
        OpenFileDialog1.Filter = "EtiketDosyaları(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        izahat = "OD"
        Try
            termal = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("TermalOdeme").ToString
        Catch ex As Exception
            termal = False
        End Try
        If termal = True Then
            file = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme_termal.fr3"
        Else
            file = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme.fr3"
        End If
        'file = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme.fr3"
        'file = OpenFileDialog1.FileName.ToString
        musterino = nMusteriID
        'gecikmistaksitsayisi = sorgu_sayi(dr("GECIKMISTAKSIT"), 0)
        'gecikmistaksittutari = sorgu_sayi(dr("GECIKMISKALAN"), 0)
        'sonsatistutari = sorgu_sayi(dr("SONSATISTUTARI"), 0)
        'If sec_analiz.Checked = True Then
        '    sonsatistarihi = dr("SONSATISTARIHI")
        '    sontahsilattarihi = dr("SONTAHSILATTARIHI")
        'Else
        '    sonsatistarihi = "01/01/1900"
        '    sontahsilattarihi = "01/01/1900"
        'End If
        'sontahsilattutari = sorgu_sayi(dr("SONTAHSILATTUTARI"), 0)
        'toplamkalantaksitsayisi = sorgu_sayi(dr("KALANTAKSITSAYISI"), 0)
        'toplamkalantaksittutari = sorgu_sayi(dr("TOPLAMKALAN"), 0)
        tarih = dteFisTarihi
        belgeno = lMakbuzno
        musterikodu = lKodu
        miktar = 0
        tutar = lToplamTutar
        'Try
        '    gecikmisodeme = dr("GECIKMIS")
        '    gunundeodeme = dr("GUNUNDE")
        '    erkenodeme = dr("ERKEN")
        '    odemesayisi = dr("TOPLAM")
        'Catch ex As Exception
        '    gecikmisodeme = 0
        '    gunundeodeme = 0
        '    erkenodeme = 0
        '    odemesayisi = 0
        'End Try
        report_create_stok(file, satir_kontrol, izahat, islem, musterikodu, tarih, belgeno, miktar, tutar, musterino, sontahsilattarihi, sontahsilattutari, sonsatistarihi, sonsatistutari, gecikmistaksitsayisi, gecikmistaksittutari, toplamkalantaksitsayisi, toplamkalantaksittutari, gecikmisodeme, gunundeodeme, erkenodeme, odemesayisi, termal)
        dr = Nothing
        termal = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal izahat As String, ByVal status As Integer, ByVal musterikodu As String, ByVal tarih As DateTime, ByVal belgeno As String, ByVal miktar As Decimal, ByVal tutar As Decimal, ByVal musterino As Int64, ByVal sontahsilattarihi As DateTime, ByVal sontahsilattutari As Decimal, ByVal sonsatistarihi As DateTime, ByVal sonsatistutari As Decimal, ByVal gecikmistaksitsayisi As Int64, ByVal gecikmistaksittutari As Decimal, ByVal kalantaksitsayisi As Int64, ByVal kalantaksittutari As Decimal, ByVal gecikmisodeme As Int64, ByVal gunundeodeme As Int64, ByVal erkenodeme As Int64, ByVal toplamodeme As Int64, ByVal termal As Boolean)
        Dim stokno = 0
        Dim satir_line = "100"
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'frx.PrintOptions.Copies = dr("MIKTAR")
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("GecikmisTaksitSayisi", "" & gecikmistaksitsayisi & "")
            frx.SetVariable("GecikmisTaksitTutari", "" & gecikmistaksittutari & "")
            frx.SetVariable("SonTahsilatTutari", "" & sontahsilattutari & "")
            frx.SetVariable("SonSatisTutari", "" & sonsatistutari & "")
            frx.SetVariable("SonTahsilatTarihi", "'" & sontahsilattarihi & "'")
            frx.SetVariable("SonSatisTarihi", "'" & sonsatistarihi & "'")
            frx.SetVariable("KalanTaksitSayisi", "" & kalantaksitsayisi & "")
            frx.SetVariable("KalanTaksitTutari", "" & kalantaksittutari & "")
            frx.SetVariable("GecikmisOdeme", "" & gecikmisodeme & "")
            frx.SetVariable("GunundeOdeme", "" & gunundeodeme & "")
            frx.SetVariable("ErkenOdeme", "" & erkenodeme & "")
            frx.SetVariable("ToplamOdeme", "" & toplamodeme & "")
            frx.SetVariable("FisMiktari", "" & miktar & "")
            frx.SetVariable("FisTutari", "" & tutar & "")
            frx.SetVariable("Anons", "'" & sMusteri & "'")
            If Trim(izahat) = "OD" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM vwParekendeOdeme WHERE (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')")
                frx.SetVariable("BelgeTipi", "'Tahsilat'")
            End If
            Dim ara As String
            Try
                ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
            Catch ex As Exception
                ara = ""
            End Try
            Dim adi As String = ""
            Dim soyadi As String = ""
            Dim x
            If CStr(ara.ToString) <> "" Then
                x = (ara).IndexOf(",", 1, (ara.Length - 1))
                If x = -1 Then
                    adi = ara
                Else
                    adi = (ara).Substring(0, x)
                    soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                End If
            End If
            If termal = True Then
                Try
                    adi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterTermal").ToString
                Catch ex As Exception
                    adi = ""
                End Try
            Else
                If adi.ToString <> "" Then
                    frx.PrintOptions.Printer = adi
                End If
            End If
            If adi.ToString <> "" Then
                frx.PrintOptions.Printer = adi
            End If
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                'frx.OldStyleProgress = True
                'frx.PrepareReport(True)
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.DisableDialogs = True
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.ShowDialog = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(4) = "" & status.ToString() & ""
            args(5) = "20"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "GecikmisTaksitSayisi"
            args(15) = "" & gecikmistaksitsayisi.ToString() & ""
            args(16) = "GecikmisTaksitTutari"
            args(17) = "" & gecikmistaksittutari.ToString() & ""
            args(18) = "SonTahsilatTutari"
            args(19) = "" & sontahsilattutari.ToString() & ""
            args(20) = "SonSatisTutari"
            args(21) = "" & sonsatistutari.ToString() & ""
            args(22) = "SonTahsilatTarihi"
            args(23) = "'" & sontahsilattarihi.ToString() & "'"
            args(24) = "SonSatisTarihi"
            args(25) = "'" & sonsatistarihi.ToString() & "'"
            args(26) = "KalanTaksitSayisi"
            args(27) = "" & kalantaksitsayisi.ToString() & ""
            args(28) = "KalanTaksitTutari"
            args(29) = "" & kalantaksittutari.ToString() & ""
            args(30) = "GecikmisOdeme"
            args(31) = "" & gecikmisodeme.ToString() & ""
            args(32) = "GunundeOdeme"
            args(33) = "" & gunundeodeme.ToString() & ""
            args(34) = "ErkenOdeme"
            args(35) = "" & erkenodeme.ToString() & ""
            args(36) = "ToplamOdeme"
            args(37) = "" & toplamodeme.ToString() & ""
            args(38) = "FisMiktari"
            args(39) = "" & miktar.ToString() & ""
            args(40) = "FisTutari"
            args(41) = "" & tutar.ToString() & ""
            args(42) = "Anons"
            args(43) = "'" & sMusteri.ToString() & "'"
            If Trim(izahat) = "OD" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM vwParekendeOdeme WHERE (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')") & ""
                args(44) = "BelgeTipi"
                args(45) = "'Tahsilat'"
            End If
            Dim ara As String
            Try
                ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
            Catch ex As Exception
                ara = ""
            End Try
            Dim adi As String = ""
            Dim soyadi As String = ""
            Dim x
            If CStr(ara.ToString) <> "" Then
                x = (ara).IndexOf(",", 1, (ara.Length - 1))
                If x = -1 Then
                    adi = ara
                Else
                    adi = (ara).Substring(0, x)
                    soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                End If
            End If
            If termal = True Then
                Try
                    adi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterTermal").ToString
                Catch ex As Exception
                    adi = ""
                End Try
            End If
            processYol = args(0)
            For i As Integer = 1 To 45
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String = ""
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_tarih(ByVal deger As Object, ByVal sonuc As DateTime) As DateTime
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub tamamla()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = False

        ' *** POS ENTEGRE KONTROLU - Onay gelmeden odeme kaydetme ***
        Dim bPosEntegre As Boolean = False
        Try
            Dim dtParam As DataTable = SQLCalistir("SELECT TOP 1 PosEntegre FROM tbParamGenel")
            If dtParam IsNot Nothing AndAlso dtParam.Rows.Count > 0 Then
                Dim p = dtParam.Rows(0)("PosEntegre")
                If p IsNot Nothing AndAlso Not IsDBNull(p) Then bPosEntegre = Convert.ToBoolean(p)
            End If
        Catch
        End Try

        ' Eger POS aktifse ve kredi karti odemesi varsa, ONCE POS onay bekle
        If bPosEntegre AndAlso OdemedeKrediKartiVar() Then
            ' ÖNEMLİ: POS işlemi yapmadan önce Kolaysoft token ve cihaz bilgilerini al
            Try
                InitKolaysoftTokenVeCihaz(sDepo)
            Catch ex As Exception
                LogYaz("tamamla", "Kolaysoft init hatasi: " & ex.Message)
            End Try

            Dim posOnay As Boolean = PosOdemeOnayBekle()
            If Not posOnay Then
                ' POS RED verdi - odeme kaydetme
                MessageBox.Show("POS odemesi reddedildi veya iptal edildi." & vbCrLf & vbCrLf &
                    "Odeme kaydedilmedi. Lutfen tekrar deneyin.",
                    "POS Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SimpleButton1.Enabled = True
                SimpleButton2.Enabled = True
                Cursor.Current = Cursors.Default
                Return
            End If
        End If

        If nOdemeKodu = 4 Then
            tbOdeme_ekle_Pesinat()
        Else
            tbOdeme_ekle()
        End If

        Dim dr3 As DataRow = DataSet1.Tables(0).Rows(0)
        If dr3("STATUS") = "False" Then
            If sRaporUzanti = ".frx" Then
                raporla(2)
            Else
                sRaporUzanti = ".fr3"
                raporla1(2)
            End If
        Else
            If sRaporUzanti = ".frx" Then
                raporla(2)
            Else
                sRaporUzanti = ".fr3"
                raporla1(2)
            End If
        End If
        ' ========== VERESİYE (CARİ) TAHSİLAT BLOĞU ==========
        If _veresiyeTahsilatBusy Then
            LogYaz("tamamla.Veresiye", "Tekrar tetikleme engellendi (busy=true).")
        Else
            _veresiyeTahsilatBusy = True
            Try
                ' 1) Satış ID
                Dim nId As String = dr("nAlisverisID")
                Dim nIdSql As String = "'" & nId.Replace("'", "''") & "'"

                ' 2) POS belge no
                Dim dtFis As DataTable = SQLCalistir("SELECT PosFisNo, ISNULL(bMuhasebeyeIslendimi,0) AS b FROM tbAlisveris WHERE nAlisverisID = " & nIdSql)

                If dtFis Is Nothing Then
                    MsgBox("SQLCalistir Nothing döndürdü (hata yakalanıp yutuluyor olabilir).")
                ElseIf dtFis.Rows.Count = 0 Then
                    MsgBox("Kayıt yok. nAlisverisID=" & nIdSql)
                Else
                    Dim posFisNo As String = dtFis.Rows(0)("PosFisNo").ToString()
                    Dim b As Integer = Convert.ToInt32(dtFis.Rows(0)("b"))
                End If
                Dim posBelgeNo As String = ""
                Dim Muhasebe As Boolean = False
                If dtFis IsNot Nothing AndAlso dtFis.Rows.Count > 0 Then
                    If Not IsDBNull(dtFis.Rows(0)("PosFisNo")) Then posBelgeNo = dtFis.Rows(0)("PosFisNo").ToString().Trim()
                    Muhasebe = Convert.ToBoolean(dtFis.Rows(0)("b"))
                End If

                ' 3) Parametre
                ' Dim bPosEntegre As Boolean = False ' -- Ust blokta tanimli
                ' Dim dtParam As DataTable = SQLCalistir("SELECT TOP 1 PosEntegre FROM tbParamGenel") ' -- Ust blokta tanimli
                ' If dtParam IsNot Nothing AndAlso dtParam.Rows.Count > 0 Then ' -- Ust blokta tanimli
                ' Dim p = dtParam.Rows(0)("PosEntegre") ' -- Ust blokta tanimli
                ' If p IsNot Nothing AndAlso Not IsDBNull(p) Then bPosEntegre = Convert.ToBoolean(p) ' -- Ust blokta tanimli

                ' 4) Ödeme kırılımları (SADECE tek kez çalışacak)
                Dim cash As Decimal = 0D, credit1 As Decimal = 0D, credit2 As Decimal = 0D, eft As Decimal = 0D
                Dim kkCounter As Integer = 0

                Dim dtPay As DataTable = SQLCalistir(
    "SELECT lOdemeTutar, sOdemeSekli " &
    "FROM tbOdeme " &
    "WHERE nAlisverisID = " & nIdSql & " AND lMakbuzNo = " & lMakbuzno
)
                If dtPay IsNot Nothing AndAlso dtPay.Rows.Count > 0 Then
                    For Each r As DataRow In dtPay.Rows
                        Dim tutar As Decimal = If(IsDBNull(r("lOdemeTutar")), 0D, CDec(r("lOdemeTutar")))
                        Dim sekilRaw As String = If(IsDBNull(r("sOdemeSekli")), "", r("sOdemeSekli").ToString())
                        Dim sekil As String = sekilRaw.Trim()
                        Dim su As String = sekil.ToUpperInvariant()

                        ' --- NAKİT ---
                        If (su = "N") OrElse su.StartsWith("NAK") Then
                            cash += tutar
                            LogYaz("OdemeKirilim", $"NAKIT (+{tutar:0.00}) sOdemeSekli='{sekilRaw}'")

                            ' --- EFT/HAVALE ---
                        ElseIf su.Contains("EFT") OrElse su.Contains("HAVALE") Then
                            eft += tutar
                            LogYaz("OdemeKirilim", $"EFT  (+{tutar:0.00}) sOdemeSekli='{sekilRaw}'")

                            ' --- DİĞERLERİ = KREDİ KARTI ---
                        Else
                            If kkCounter = 0 Then
                                credit1 += tutar
                                LogYaz("OdemeKirilim", $"KK#1 (+{tutar:0.00}) sOdemeSekli='{sekilRaw}'")
                            Else
                                credit2 += tutar
                                LogYaz("OdemeKirilim", $"KK#2 (+{tutar:0.00}) sOdemeSekli='{sekilRaw}'")
                            End If
                            kkCounter += 1
                        End If
                    Next
                End If

                Dim toplamTahsilat As Decimal = cash + credit1 + credit2 + eft
                LogYaz("OdemeKirilimToplam", $"cash={cash:0.00}, credit1={credit1:0.00}, credit2={credit2:0.00}, eft={eft:0.00}, total={toplamTahsilat:0.00}")

                ' 5) Gönderim koşulu (tek tetikleme)
                If bPosEntegre AndAlso Muhasebe AndAlso Not String.IsNullOrEmpty(posBelgeNo) AndAlso toplamTahsilat > 0D Then
                    VeresiyeOdemeAl(nId, cash, credit1, credit2, eft)
                Else
                    ' Detaylı log - hangi koşul sağlanmadı?
                    Dim sebep As String = ""
                    If Not bPosEntegre Then sebep &= "POS entegre kapalı. "
                    If Not Muhasebe Then sebep &= "Muhasebe işlenmemiş (PosFisNo alınamamış olabilir). "
                    If String.IsNullOrEmpty(posBelgeNo) Then sebep &= "PosFisNo boş (e-belge numarası yok). "
                    If toplamTahsilat <= 0D Then sebep &= "Tahsilat tutarı 0. "
                    
                    LogYaz("tamamla.Veresiye", "Atlandı. Sebep: " & sebep & vbCrLf &
                                       "PosEntegre=" & bPosEntegre &
                                       ", Muhasebe=" & Muhasebe &
                                       ", PosFisNo=" & If(String.IsNullOrEmpty(posBelgeNo), "(boş)", posBelgeNo) &
                                       ", ToplamTahsilat=" & toplamTahsilat.ToString("0.00"))
                End If

            Catch ex As Exception
                LogYaz("tamamla.Veresiye", "Hata: " & ex.Message)
            Finally
                _veresiyeTahsilatBusy = False   ' yeni çağrılar için serbest bırak
            End Try
        End If
        ' ========== /VERESİYE (CARİ) TAHSİLAT BLOĞU ==========

        Cursor.Current = Cursors.Default
        Cursor.Hide()
        Me.Close()
    End Sub
    Public Sub VeresiyeOdemeAl(nAlisverisID As String, cash As Decimal, credit1 As Decimal, credit2 As Decimal, eft As Decimal)
        Dim responseContent As String = String.Empty

        Try
            If cash >= 30000D Then
                Throw New Exception("Nakit tahsilatlar 30.000 TL ve üzeri gönderilemez (mevzuat). Lütfen kart/EFT ile tahsil edin.")
            End If

            InitKolaysoftTokenVeCihaz(sDepo)

            ' --- Satış ve müşteri bilgileri ---
            Dim nIdSql As String = "'" & nAlisverisID.Replace("'", "''") & "'"
            Dim dtFis = SQLCalistir("SELECT TOP 1 PosFisNo, nMusteriID FROM tbAlisveris WHERE nAlisverisID = " & nIdSql)
            If dtFis Is Nothing OrElse dtFis.Rows.Count = 0 Then Throw New Exception("Satış bulunamadı.")
            Dim documentNo As String = If(IsDBNull(dtFis.Rows(0)("PosFisNo")), "", dtFis.Rows(0)("PosFisNo").ToString().Trim())
            If String.IsNullOrEmpty(documentNo) Then Throw New Exception("PosFisNo (e-belge numarası) boş.")

            Dim nMusteriID As String = dtFis.Rows(0)("nMusteriID").ToString()
            Dim dtMus = SQLCalistir("SELECT m.*, ISNULL(n.sCuzdanKayitNo,'') AS TC FROM tbMusteri m LEFT JOIN tbMusteriNufusu n ON m.nMusteriID=n.nMusteriID WHERE m.nMusteriID=" & nMusteriID)
            Dim currentIdentifier As String = ""
            If dtMus IsNot Nothing AndAlso dtMus.Rows.Count > 0 Then
                Dim r = dtMus.Rows(0)
                If Not IsDBNull(r("sVergiNo")) AndAlso r("sVergiNo") IsNot Nothing Then currentIdentifier = r("sVergiNo").ToString().Trim()
                If String.IsNullOrEmpty(currentIdentifier) AndAlso Not IsDBNull(r("TC")) AndAlso r("TC") IsNot Nothing Then currentIdentifier = r("TC").ToString().Trim()
            End If
            If String.IsNullOrEmpty(currentIdentifier) Then
                ' Nihai tüketici senaryosu için TC "11111111111" kullanılabiliyor; ama tercihen gerçek TC/VKN gönderin.
                currentIdentifier = "11111111111"
            End If

            Dim amount As Decimal = Math.Round(cash + credit1 + credit2 + eft, 2, MidpointRounding.AwayFromZero)
            If amount <= 0D Then Throw New Exception("Tahsilat tutarı 0 olamaz.")

            ' --- JSON Body (zorunlular + varsa kırılımlar) ---
            Dim body As New Dictionary(Of String, Object) From {
            {"documentNo", documentNo},
            {"amount", amount},
            {"currentIdentifier", currentIdentifier},
            {"companyId", KolaysoftFirmaId},
            {"cashAmount", If(cash > 0D, CType(cash, Decimal?), Nothing)},
            {"creditCardFirstAmount", If(credit1 > 0D, CType(credit1, Decimal?), Nothing)},
            {"creditCardSecondAmount", If(credit2 > 0D, CType(credit2, Decimal?), Nothing)},
            {"eftTransferAmount", If(eft > 0D, CType(eft, Decimal?), Nothing)}
        }
            Dim jsonBody As String = JsonConvert.SerializeObject(body, Formatting.None)

            ' --- HTTP POST: Current Pos Payment Create ---
            ServicePointManager.Expect100Continue = False
            ServicePointManager.DefaultConnectionLimit = 100

            Dim url As String = "https://service.kolaysoftpos.com/services/pos/api/erp/current-pos-payments"
            Dim req = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "POST"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            req.Headers.Add("Authorization", "Bearer " & KolaysoftToken)
            req.Timeout = 30000
            req.ReadWriteTimeout = 30000
            req.KeepAlive = False
            req.Proxy = Nothing
            req.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate

            Dim data = Encoding.UTF8.GetBytes(jsonBody)
            req.ContentLength = data.Length
            Using s = req.GetRequestStream()
                s.Write(data, 0, data.Length)
            End Using

            Dim currentPosPaymentId As String = Nothing

            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8, detectEncodingFromByteOrderMarks:=True)
                    Dim txt As String = reader.ReadToEnd()
                    Dim sTrim As String = txt.TrimStart(ChrW(&HFEFF)).Trim()
                    SonFaturaIcerigi = sTrim
                    LogYaz("VeresiyeOdemeAl", "Create yanıtı ilk 500: " & If(sTrim.Length > 500, sTrim.Substring(0, 500), sTrim))

                    If Not (sTrim.StartsWith("{") OrElse sTrim.StartsWith("[")) Then
                        Throw New Exception("Geçersiz JSON yanıtı.")
                    End If

                    Try
                        Dim tok As JToken = JToken.Parse(sTrim)

                        ' --- Objeyse: doğrudan objeden id al ---
                        If TypeOf tok Is JObject Then
                            Dim obj As JObject = CType(tok, JObject)
                            currentPosPaymentId = CStr(obj.SelectToken("id"))

                            ' Bazı endpoint'ler "content" dizisi döndürebilir: { "content": [ { id: ... } ] }
                            If String.IsNullOrEmpty(currentPosPaymentId) Then
                                Dim contentArr As JArray = TryCast(obj.SelectToken("content"), JArray)
                                If contentArr IsNot Nothing AndAlso contentArr.Count > 0 Then
                                    Dim first As JObject = TryCast(contentArr(0), JObject)
                                    If first IsNot Nothing Then
                                        currentPosPaymentId = CStr(first.SelectToken("id"))
                                    End If
                                End If
                            End If

                            ' --- Dizi ise: JArray'e çevir, Count/indeks güvenli ---
                        ElseIf TypeOf tok Is JArray Then
                            Dim arr As JArray = CType(tok, JArray)
                            If arr.Count > 0 Then
                                Dim first As JObject = TryCast(arr(0), JObject)
                                If first IsNot Nothing Then
                                    currentPosPaymentId = CStr(first.SelectToken("id"))
                                End If
                            End If
                        End If

                    Catch jx As Exception
                        LogYaz("VeresiyeOdemeAl", "JSON parse hatası: " & jx.Message)
                        ' id gelmese de listeden takip edeceğiz, devam...
                    End Try
                End Using
            End Using


            ' --- UI donmasın: durum kontrolünü arka planda yap ---
            StartCurrentPosPaymentWorker(documentNo, amount, currentPosPaymentId)

            'MessageBox.Show("✅ Cari tahsilat isteği gönderildi. Durum arka planda takip edilecek.")

        Catch wex As WebException
            If wex.Response IsNot Nothing Then
                responseContent = New StreamReader(wex.Response.GetResponseStream()).ReadToEnd()
            End If
            LogYaz("VeresiyeOdemeAl", "Hata: " & wex.Message & vbCrLf & "Yanıt: " & responseContent)
            
            ' ===== KULLANICI DOSTU HATA MESAJLARI =====
            Dim kullaniciMesaji As String = "Cari tahsilat hatası"
            If responseContent.Contains("kalan tutardan daha büyük") Then
                kullaniciMesaji = "Girilen tutar kalan borçtan fazla!" & vbCrLf & vbCrLf &
                    "Lütfen tutarı kontrol edin."
            ElseIf responseContent.Contains("veresiye ödeme talebi bulunmaktadır") Then
                kullaniciMesaji = "Bu satış için zaten bir ödeme talebi var!" & vbCrLf & vbCrLf &
                    "Önceki talebin tamamlanmasını bekleyin veya iptal edin."
            ElseIf responseContent.Contains("Tckn") AndAlso responseContent.Contains("uyumsuz") Then
                kullaniciMesaji = "TC Kimlik numarası uyuşmuyor!" & vbCrLf & vbCrLf &
                    "Müşteri kartındaki TC'yi kontrol edin."
            ElseIf responseContent.Contains("401") OrElse responseContent.Contains("Unauthorized") Then
                kullaniciMesaji = "Oturum süresi dolmuş. Programı yeniden başlatın."
            Else
                kullaniciMesaji = "Cari tahsilat hatası: " & wex.Message
            End If
            MessageBox.Show("❌ " & kullaniciMesaji, "Kolaysoft Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            LogYaz("VeresiyeOdemeAl", "Hata: " & ex.Message & vbCrLf & "Yanıt: " & responseContent)
            MessageBox.Show("❌ Cari tahsilat hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub InitKolaysoftTokenVeCihaz(sDepo As String)
        Try
            KolaysoftToken = GetAuthenticationToken()
            KolaysoftTokenAlinmaZamani = Now
            If Not String.IsNullOrEmpty(KolaysoftFirmaId) Then
                Dim tumCihazlar = GetPosCihazListesi(KolaysoftFirmaId, KolaysoftToken, sDepo)
                If tumCihazlar.Count = 0 Then
                    ' Gönderim iptal et
                    KolaysoftCihazListesi = New List(Of String)
                    Return
                End If
                Dim sorgu = "SELECT sPosSeri FROM tbDepo WHERE sDepo = ?"
                Dim hedefPosSeri = String.Empty
                Dim cmd As New OleDb.OleDbCommand
                Dim con As New OleDb.OleDbConnection
                con.ConnectionString = connection
                cmd.CommandText = sorgu
                cmd.CommandTimeout = Nothing
                cmd.Connection = con
                cmd.Parameters.AddWithValue("?", sDepo)
                con.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then hedefPosSeri = result.ToString()
                con.Close()
                If Not String.IsNullOrEmpty(hedefPosSeri) AndAlso tumCihazlar.Contains(hedefPosSeri) Then
                    KolaysoftCihazListesi = New List(Of String) From {hedefPosSeri}
                Else
                    KolaysoftCihazListesi = New List(Of String)
                End If
            End If
        Catch ex As Exception
            LogYaz("InitKolaysoftTokenVeCihaz", ex.ToString())
            MessageBox.Show("Kolaysoft bağlantısı kurulamadı: " & ex.Message)
        End Try
    End Sub
    Private Function GetAuthenticationToken() As String
        Dim dtParam As DataTable = SQLCalistir("SELECT PosKullanici, PosSifre FROM tbParamGenel")
        If dtParam.Rows.Count = 0 Then Throw New Exception("tbParamGenel tablosunda kullanıcı bilgisi yok.")
        Dim username As String = dtParam.Rows(0)("PosKullanici").ToString().Trim()
        Dim password As String = dtParam.Rows(0)("PosSifre").ToString().Trim()
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then Throw New Exception("Kullanıcı adı veya şifre boş.")

        Dim jsonBody As String = JsonConvert.SerializeObject(New With {.username = username, .password = password})
        Dim request As HttpWebRequest = CType(WebRequest.Create("https://service.kolaysoftpos.com/api/erp-authenticate"), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim data As Byte() = Encoding.UTF8.GetBytes(jsonBody)
        request.ContentLength = data.Length
        Using stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
        End Using

        Dim responseContent As String = String.Empty
        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    responseContent = reader.ReadToEnd()
                    Dim parsed = JObject.Parse(responseContent)
                    Dim token = parsed("id_token")?.ToString()
                    If String.IsNullOrEmpty(token) Then Throw New Exception("Token alınamadı.")
                    KolaysoftFirmaId = parsed("companyId")?.ToString()
                    If String.IsNullOrEmpty(KolaysoftFirmaId) Then Throw New Exception("Firma ID'si alınamadı.")
                    Return token
                End Using
            End Using
        Catch webEx As WebException
            responseContent = New StreamReader(webEx.Response.GetResponseStream()).ReadToEnd()
            Throw New Exception("API isteği başarısız: " & webEx.Message & vbCrLf & "Yanıt: " & responseContent)
        End Try
    End Function
    Private Function GetPosCihazListesi(companyId As String, token As String, sDepo As String) As List(Of String)
        Dim cihazlar As New List(Of String)()
        If String.IsNullOrEmpty(companyId) OrElse String.IsNullOrEmpty(token) OrElse String.IsNullOrEmpty(sDepo) Then
            Throw New Exception("companyId, token veya sDepo boş olamaz.")
        End If
        ' Ortamına göre base URL’i değiştir (demo/production)
        Dim baseUrl As String = "https://service.kolaysoftpos.com"
        'Dim baseUrl As String = "https://service.kolaysoftpos.com"
        Dim url As String = baseUrl & "/services/pos/api/erp/pos-devices?companyId=" & Uri.EscapeDataString(companyId)
        Dim responseContent As String = String.Empty
        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Accept = "application/json"
            request.Headers.Add("Authorization", "Bearer " & token)
            request.Timeout = 30000
            request.ReadWriteTimeout = 30000
            request.KeepAlive = False
            request.Proxy = Nothing
            request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream(), Encoding.UTF8, detectEncodingFromByteOrderMarks:=True)
                    responseContent = reader.ReadToEnd()
                End Using
            End Using
            If String.IsNullOrWhiteSpace(responseContent) Then
                Throw New Exception("API yanıtı boş.")
            End If
            Dim s As String = responseContent.TrimStart(ChrW(&HFEFF)).Trim()
            If Not (s.StartsWith("{") OrElse s.StartsWith("[")) Then
                Throw New Exception("API JSON dışı içerik döndürdü (muhtemelen HTML).")
            End If
            Dim tok As JToken = JToken.Parse(s)
            ' 1) Yanıt doğrudan dizi ise: ["123","456"] ya da [{...},{...}]
            If TypeOf tok Is JArray Then
                Dim arr As JArray = CType(tok, JArray)
                For Each item As JToken In arr
                    If TypeOf item Is JObject Then
                        Dim obj As JObject = CType(item, JObject)
                        Dim serial As String = CStr(obj.SelectToken("terminalSerialNumber"))
                        If String.IsNullOrEmpty(serial) Then serial = CStr(obj.SelectToken("serialNumber"))
                        If String.IsNullOrEmpty(serial) Then serial = CStr(obj.SelectToken("deviceSerialNumber"))
                        If Not String.IsNullOrEmpty(serial) AndAlso Not cihazlar.Contains(serial) Then
                            cihazlar.Add(serial)
                        End If
                    Else
                        ' Dizi elemanı string ise
                        Dim serial As String = item.ToString()
                        If Not String.IsNullOrEmpty(serial) AndAlso Not cihazlar.Contains(serial) Then
                            cihazlar.Add(serial)
                        End If
                    End If
                Next
                ' 2) Yanıt nesne ise: { "terminalSerialNumber":[...]} ya da { "content":[{...}]} vb.
            ElseIf TypeOf tok Is JObject Then
                Dim obj As JObject = CType(tok, JObject)
                ' a) terminalSerialNumber bir DİZİ ise
                Dim arrTerm As JArray = TryCast(obj.SelectToken("terminalSerialNumber"), JArray)
                If arrTerm IsNot Nothing Then
                    For Each item As JToken In arrTerm
                        Dim serial As String = item.ToString()
                        If Not String.IsNullOrEmpty(serial) AndAlso Not cihazlar.Contains(serial) Then
                            cihazlar.Add(serial)
                        End If
                    Next
                End If
                ' b) terminalSerialNumber tek bir string ise
                If cihazlar.Count = 0 Then
                    Dim singleTerm As JToken = obj.SelectToken("terminalSerialNumber")
                    If singleTerm IsNot Nothing AndAlso singleTerm.Type = JTokenType.String Then
                        Dim serial As String = CStr(singleTerm)
                        If Not String.IsNullOrEmpty(serial) AndAlso Not cihazlar.Contains(serial) Then
                            cihazlar.Add(serial)
                        End If
                    End If
                End If
                ' c) content/data/items altında nesne dizisi varsa
                If cihazlar.Count = 0 Then
                    Dim candidates() As String = {"content", "data", "items", "result"}
                    For Each path As String In candidates
                        Dim arr As JArray = TryCast(obj.SelectToken(path), JArray)
                        If arr IsNot Nothing AndAlso arr.Count > 0 Then
                            For Each row As JToken In arr
                                Dim r As JObject = TryCast(row, JObject)
                                If r Is Nothing Then Continue For
                                Dim serial As String = CStr(r.SelectToken("terminalSerialNumber"))
                                If String.IsNullOrEmpty(serial) Then serial = CStr(r.SelectToken("serialNumber"))
                                If String.IsNullOrEmpty(serial) Then serial = CStr(r.SelectToken("deviceSerialNumber"))
                                If Not String.IsNullOrEmpty(serial) AndAlso Not cihazlar.Contains(serial) Then
                                    cihazlar.Add(serial)
                                End If
                            Next
                            Exit For
                        End If
                    Next
                End If
            End If
            If cihazlar.Count = 0 Then
                Throw New Exception("Cihaz listesi boş döndü veya beklenen alanlar bulunamadı.")
            End If
        Catch wex As WebException
            Try
                If wex.Response IsNot Nothing Then
                    Using er As New StreamReader(wex.Response.GetResponseStream())
                        responseContent = er.ReadToEnd()
                    End Using
                End If
            Catch
            End Try
            Throw New Exception("POS cihaz listesi alınamadı: " & wex.Message & If(String.IsNullOrEmpty(responseContent), "", vbCrLf & "Yanıt: " & responseContent))
        Catch jex As JsonReaderException
            Throw New Exception("JSON ayrıştırma hatası: " & jex.Message & vbCrLf & "Yanıt: " & responseContent)
        Catch ex As Exception
            Throw New Exception("Cihaz listesi alınırken hata: " & ex.Message & If(String.IsNullOrEmpty(responseContent), "", vbCrLf & "Yanıt: " & responseContent))
        End Try

        ' Veritabanından sPosSeri sorgula ve filtrele
        Dim sorgu = "SELECT sPosSeri FROM tbDepo WHERE sDepo = ?"
        Dim hedefPosSeri = String.Empty
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandText = sorgu
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        cmd.Parameters.AddWithValue("?", sDepo)
        con.Open()
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing Then hedefPosSeri = result.ToString()
        con.Close()
        If Not String.IsNullOrEmpty(hedefPosSeri) AndAlso cihazlar.Contains(hedefPosSeri) Then
            cihazlar = New List(Of String) From {hedefPosSeri}
        Else
            cihazlar = New List(Of String)
        End If
        Return cihazlar
    End Function
    Private Sub StartCurrentPosPaymentWorker(documentNo As String, expectedAmount As Decimal, currentPosPaymentId As String)
        Dim th As New Thread(
        Sub()
            Try
                Dim maxTries As Integer = 10   ' ~5 dk
                Dim delaySec As Integer = 30

                For i As Integer = 1 To maxTries
                    Try
                        Dim sb As New StringBuilder("https://service.kolaysoftpos.com/services/pos/api/erp/current-pos-payments?")
                        sb.Append("size=1&sort=id,desc")
                        sb.Append("&companyId.equals=").Append(Uri.EscapeDataString(KolaysoftFirmaId))
                        sb.Append("&documentNo.equals=").Append(Uri.EscapeDataString(documentNo))
                        If Not String.IsNullOrEmpty(currentPosPaymentId) Then
                            sb.Append("&id.in=").Append(Uri.EscapeDataString(currentPosPaymentId))
                        End If

                        Dim req As HttpWebRequest = CType(WebRequest.Create(sb.ToString()), HttpWebRequest)
                        req.Method = "GET"
                        req.Accept = "application/json"
                        req.Headers.Add("Authorization", "Bearer " & KolaysoftToken)
                        req.Timeout = 30000
                        req.ReadWriteTimeout = 30000
                        req.KeepAlive = False
                        req.Proxy = Nothing
                        req.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate

                        Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                            Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8, detectEncodingFromByteOrderMarks:=True)
                                Dim txt As String = reader.ReadToEnd()
                                Dim s As String = txt.TrimStart(ChrW(&HFEFF)).Trim()

                                LogYaz("CurrentPosPaymentList", "Yanıt[" & i & "] first400: " & If(s.Length > 400, s.Substring(0, 400) & "...", s))

                                If String.IsNullOrWhiteSpace(s) OrElse Not (s.StartsWith("{") OrElse s.StartsWith("[")) Then
                                    Throw New Exception("Geçersiz JSON yanıtı.")
                                End If

                                Dim tok As JToken = JToken.Parse(s)
                                Dim arr As JArray
                                If TypeOf tok Is JArray Then
                                    arr = CType(tok, JArray)
                                Else
                                    ' Nesneyi tek elemanlı dizi gibi ele al
                                    arr = New JArray(tok)
                                End If

                                If arr.Count > 0 Then
                                    Dim first As JObject = TryCast(arr(0), JObject)
                                    If first IsNot Nothing Then
                                        Dim status As String = CStr(first.SelectToken("status"))
                                        Dim amount As Decimal = 0D
                                        Dim aTok As JToken = first.SelectToken("amount")
                                        If aTok IsNot Nothing AndAlso aTok.Type <> JTokenType.Null Then
                                            Decimal.TryParse(aTok.ToString(), amount)
                                        End If

                                        LogYaz("CurrentPosPaymentList", "status=" & status & ", amount=" & amount & ", expected=" & expectedAmount)

                                        If Not String.IsNullOrEmpty(status) Then
                                            Select Case status.ToUpperInvariant()
                                                Case "SUCCESS"
                                                    Try
                                                        If Application.OpenForms.Count > 0 Then
                                                            Dim f = Application.OpenForms(0)
                                                            If f IsNot Nothing AndAlso f.IsHandleCreated Then
                                                                f.BeginInvoke(CType(Sub()
                                                                                        ' MessageBox.Show("✅ Cari tahsilat SUCCESS. Belge: " & documentNo & ", Tutar: " & amount.ToString("0.00"))
                                                                                    End Sub, Action))
                                                            End If
                                                        End If
                                                    Catch
                                                    End Try
                                                    Exit For

                                                Case "FAILED", "CANCELLED", "ABORTED"
                                                    LogYaz("CurrentPosPaymentList", "Cari tahsilat sonlandı: " & status)
                                                    Exit For

                                                Case Else
                                                    ' PENDING / IN_PROGRESS / ON_TERMINAL -> beklemeye devam
                                            End Select
                                        End If
                                    End If
                                End If
                            End Using
                        End Using

                    Catch wex As WebException
                        Dim respBody As String = ""
                        Try
                            If wex.Response IsNot Nothing Then
                                Using er As New StreamReader(wex.Response.GetResponseStream())
                                    respBody = er.ReadToEnd()
                                End Using
                            End If
                        Catch
                        End Try
                        LogYaz("CurrentPosPaymentList", "Hata: " & wex.Message & If(String.IsNullOrEmpty(respBody), "", " | Yanıt: " & respBody))

                    Catch ex As Exception
                        LogYaz("CurrentPosPaymentList", "Hata: " & ex.Message)
                    End Try

                    Thread.Sleep(TimeSpan.FromSeconds(delaySec))
                Next

            Catch ex As Exception
                LogYaz("StartCurrentPosPaymentWorker", "Hata: " & ex.Message)
            End Try
        End Sub)
        th.IsBackground = True
        th.Start()
    End Sub

    Private Function SQLCalistir(sql As String) As DataTable
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        con.ConnectionString = connection ' connection değişkenini tanımla
        cmd.CommandText = sql ' SQL sorgusu ekle
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Dim dt As New DataTable()
        Try
            con.Open()
            adapter.Fill(dt)
        Catch ex As Exception
            LogYaz("SQLCalistir", ex.ToString())
            'MessageBox.Show("SQL çalıştırma hatası: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return dt
    End Function
    Private Sub taksit_kontrol_satirlar()
        Dim dr As DataRow
        Dim s As String
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        Dim dr1 As DataRow
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.SelectedRowsCount
        barlabel.Text = "Toplam Satır Sayısı : " & GridView1.SelectedRowsCount
        bar.Position = 0
        s = i.ToString
        dr = DataSet1.Tables(0).Rows(0)
        'Panelstatus.Visible = True
        'bar.Properties.Maximum = GridView1.SelectedRowsCount
        'barlabel.Text = "Toplam Satır Sayısı : " & GridView1.SelectedRowsCount
        'bar.Position = 0
        'Satır Oku
        barlabel.Text = "MüşteriKodu:" & dr("FIRMAKODU").ToString & vbTab & "Adı:" & dr("ADI").ToString
        barlabel.Refresh()
        If Trim(dr("FIRMAKODU")).ToString <> "999999" Then
            ds_taksit_kalan = sorgu_taksitler_kalanli(dr("nMusteriId"))
            For Each dr1 In ds_taksit_kalan.Tables(0).Rows
                dr("TOPLAMTAKSIT") = dr1("TUTAR")
                dr("TOPLAMTAHSILAT") = dr1("TAHSILAT")
                dr("TOPLAMKALAN") = dr1("KALAN")
            Next
            ds_taksitler = sorgu_taksitler(dr("nMusteriID"))
            Dim ilktaksit As DateTime
            Dim ilktaksittutar As Decimal
            Dim gecikmistaksitsayisi As Int64 = 0
            Dim gecikmistaksittutari As Decimal = 0
            Dim kalantaksitsayisi As Int64 = 0
            barlabel2.Text = "Taksitler Okunuyor...Toplam Satır Sayısı : " & ds_taksitler.Tables(0).Rows.Count
            bar2.Properties.Maximum = ds_taksitler.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            sayi = 0
            For Each dr1 In ds_taksitler.Tables(0).Rows
                sayi += 1
                If sayi = 1 Then
                    ilktaksit = dr1("dteTarihi")
                    ilktaksittutar = dr1("KALAN")
                End If
                If dr1("dteTarihi") <= Today Then
                    gecikmistaksitsayisi += 1
                    gecikmistaksittutari += dr1("KALAN")
                End If
                kalantaksitsayisi += 1
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            dr("GECIKENILKTAKSITTARIHI") = ilktaksit
            dr("GECIKENILKTAKSITTUTARI") = ilktaksittutar
            dr("GECIKMISTAKSIT") = gecikmistaksitsayisi
            dr("GECIKMISKALAN") = gecikmistaksittutari
            dr("KALANTAKSITSAYISI") = kalantaksitsayisi
            'Satışlar
            ds_satislar_detayli = sorgu_satislar_detayli(dr("nMusteriID"))
            Dim toplammiktar As Decimal = 0
            Dim toplamsatistutari As Decimal = 0
            Dim toplampesinattutari As Decimal = 0
            Dim iademiktar As Decimal = 0
            Dim iadetutari As Decimal = 0
            Dim satissayisi As Int64 = 0
            Dim satismiktar As Decimal = 0
            Dim satistutari As Decimal = 0
            Dim iadesayisi As Int64 = 0
            Dim sonsatistutari As Decimal = 0
            Dim sonsatistarihi As DateTime
            sayi = 0
            barlabel2.Text = "Satışlar Okunuyor...Toplam Satır Sayısı : " & ds_satislar_detayli.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            For Each dr1 In ds_satislar_detayli.Tables(0).Rows
                If dr1("nGirisCikis") = 3 Then
                    satismiktar += dr1("lToplamMiktar")
                    satistutari += dr1("lNetTutar")
                    toplampesinattutari = dr1("lPesinat")
                    satissayisi += 1
                    sayi += 1
                    If sayi = 1 Then
                        sonsatistutari += dr1("lNetTutar")
                        sonsatistarihi = dr1("dteFaturaTarihi")
                    End If
                ElseIf dr1("nGirisCikis") = 4 Then
                    iademiktar += Math.Abs(dr1("lToplamMiktar"))
                    iadetutari += Math.Abs(dr1("lNetTutar"))
                    iadesayisi += 1
                End If
                toplammiktar += dr1("lToplamMiktar")
                toplamsatistutari += dr1("lNetTutar")
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            dr("SATISSAYISI") = satissayisi
            dr("IADESAYISI") = iadesayisi
            dr("SATISTUTARI") = satistutari
            dr("SATISMIKTARI") = satismiktar
            dr("IADETUTARI") = iadetutari
            dr("IADEMIKTARI") = iademiktar
            dr("TOPLAMSATISTUTARI") = toplamsatistutari
            dr("TOPLAMSATISMIKTARI") = toplammiktar
            dr("TOPLAMPESINAT") = toplampesinattutari
            dr("SONSATISTUTARI") = sonsatistutari
            dr("SONSATISTARIHI") = sonsatistarihi
            'Tahsilatlar
            ds_tahsilatlar = sorgu_tahsilatlar_toplam(dr("nMusteriID"))
            bar2.Properties.Maximum = ds_tahsilatlar.Tables(0).Rows.Count
            barlabel2.Text = "Tahsilatlar Okunuyor...Toplam Satır Sayısı : " & ds_tahsilatlar.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            Dim sontahsilattarihi As DateTime
            Dim sontahsilattutari As Decimal = 0
            For Each dr1 In ds_tahsilatlar.Tables(0).Rows
                sontahsilattarihi = dr1("dteOdemeTarihi")
                sontahsilattutari = dr1("TAHSILAT")
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            dr("SONTAHSILATTARIHI") = sontahsilattarihi
            dr("SONTAHSILATTUTARI") = sontahsilattutari
            dr("STATUS") = 1
            Try
                dr("GUNUNDE") = sorgu_odemeler_sayi_gununde(dr("nMusteriID"))
                dr("GECIKMIS") = sorgu_odemeler_sayi_gecikmis(dr("nMusteriID"))
                dr("ERKEN") = sorgu_odemeler_sayi_erken(dr("nMusteriID"))
                dr("TOPLAM") = dr("GUNUNDE") + dr("GECIKMIS") + dr("ERKEN")
            Catch ex As Exception
                dr("GUNUNDE") = 0
                dr("GECIKMIS") = 0
                dr("ERKEN") = 0
                dr("TOPLAM") = 0
            End Try
        ElseIf Trim(dr("FIRMAKODU")).ToString = "999999" Then
            dr("TOPLAMTAKSIT") = 0
            dr("TOPLAMTAHSILAT") = 0
            dr("TOPLAMKALAN") = 0
            dr("GECIKENILKTAKSITTARIHI") = Today
            dr("GECIKENILKTAKSITTUTARI") = 0
            dr("GECIKMISTAKSIT") = 0
            dr("GECIKMISKALAN") = 0
            dr("KALANTAKSITSAYISI") = 0
            dr("SATISSAYISI") = 0
            dr("IADESAYISI") = 0
            dr("SATISTUTARI") = 0
            dr("SATISMIKTARI") = 0
            dr("IADETUTARI") = 0
            dr("IADEMIKTARI") = 0
            dr("TOPLAMSATISTUTARI") = 0
            dr("TOPLAMSATISMIKTARI") = 0
            dr("TOPLAMPESINAT") = 0
            dr("SONSATISTUTARI") = 0
            dr("SONSATISTARIHI") = Today
            dr("SONTAHSILATTARIHI") = Today
            dr("SONTAHSILATTUTARI") = 0
            dr("STATUS") = 1
            dr("GUNUNDE") = 0
            dr("GECIKMIS") = 0
            dr("ERKEN") = 0
            dr("TOPLAM") = 0
        End If
        'Satır Bitir
        bar.Position = bar.Position + 1
        bar.Refresh()
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Public Function sorgu_taksitler_kalanli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_taksitler(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT  ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY  tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_satislar_detayli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi, dteFaturaTarihi, nGirisCikis, lToplamMiktar, lNetTutar,lPesinat  FROM         tbAlisVeris  WHERE     (nMusteriID = " & musterino & ") ORDER BY dteFaturaTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_tahsilatlar_toplam(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 SUM(tbOdeme.lOdemeTutar) AS TAHSILAT, tbOdeme.dteOdemeTarihi, tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & musterino & ") GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi ORDER BY tbOdeme.dteOdemeTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_odemeler_sayi_gecikmis(ByVal musterino As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Int64
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(GECIKMIS),0) AS GECIKMIS FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkGecikmis > 0) GROUP BY Musteri_TanimlamaNo ) T GROUP BY nMusteriID")
        sayi = cmd.ExecuteScalar
        conn.Close()
        Return sayi
        sayi = Nothing
    End Function
    Public Function sorgu_odemeler_sayi_erken(ByVal musterino As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Int64
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(GECIKMIS),0) AS GECIKMIS FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken > 0) GROUP BY Musteri_TanimlamaNo ) T GROUP BY nMusteriID")
        sayi = cmd.ExecuteScalar
        conn.Close()
        Return sayi
        sayi = Nothing
    End Function
    Public Function sorgu_odemeler_sayi_gununde(ByVal musterino As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Int64
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(GECIKMIS),0) AS GECIKMIS FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken = 0) AND (NFarkGecikmis = 0) GROUP BY Musteri_TanimlamaNo ) T GROUP BY nMusteriID")
        sayi = cmd.ExecuteScalar
        conn.Close()
        Return sayi
        sayi = Nothing
    End Function
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        tamamla()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        tamamla()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Me.Close()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        If MenuItem27.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem27.Checked = True
        ElseIf MenuItem27.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem27.Checked = False
        End If
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        tamamla()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_satis_detay()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ödeme Ekranını Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla(1)
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla(2)
    End Sub
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nMusteriID = dr1("nMusteriID")
            lKodu = dr1("lKodu")
            LabelControl8.Text = dr1("Musteri")
            txt_musterino.EditValue = lKodu
            musteri_kontrol()
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS KAYIT FROM tbMusteri " & kriter & "")
            Dim kayitsayisi = cmd.ExecuteScalar
            Return kayitsayisi
        Catch ex As Exception
        End Try
        conn.Close()
    End Function
    Dim ds_cari As DataSet
    Dim kriter
    Private Sub dataload_cari(ByVal kod As String)
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT nMusteriID AS IND, lKodu AS MUSTERIKODU, sAdi + ' ' + sSoyadi AS MUSTERI FROM tbMusteri " & kriter & ""))
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musterino.Text).ToString <> "" And IsNumeric(Trim(txt_musterino.Text)) = True Then
            temizle()
            Dim kontrol = sorgu_cari_kontrol(txt_musterino.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musterino.EditValue)
                For Each dr In ds_cari.Tables(0).Rows
                    lKodu = dr("MUSTERIKODU")
                    nMusteriID = dr("IND")
                    LabelControl8.Text = dr("MUSTERI").ToString()
                    veriYukle()
                Next
                dr = Nothing
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Sayısal Veri Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
    End Sub
    Private Sub txt_musterino_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub temizle()
        lbl_borc.Text = "%"
        lbl_secilen_sayi.Text = "%"
        lbl_secilen.Text = "%"
        lbl_odenen.Text = "%"
        lbl_paraustu.Text = "%"
        lbl_gun.Text = "%"
        lbl_ortvade.Text = "%"
    End Sub
    Private Sub txt_musterino_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        ElseIf e.KeyCode = Keys.Space Then
            Dim deger = ""
            deger = InputBox("MüşteriNumarasını Okutun", "MüşteriKartOkut", "").ToString
            If deger.ToString <> "" Then
                txt_musterino.Text = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Decimal)
                musteri_kontrol()
            End If
            deger = Nothing
        End If
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Perakende Ekranından Çıkmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Odeme listesinde kredi karti odemesi var mi kontrol eder
    ''' </summary>
    Private Function OdemedeKrediKartiVar() As Boolean
        Try
            For Each dr1 As DataRow In ds_odeme.Tables(0).Rows
                Dim sekil As String = If(dr1("sOdemeSekli") IsNot Nothing, dr1("sOdemeSekli").ToString().Trim().ToUpperInvariant(), "")
                ' Nakit veya EFT degilse kredi karti sayilir
                If Not (sekil = "N" OrElse sekil.StartsWith("NAK") OrElse sekil.Contains("EFT") OrElse sekil.Contains("HAVALE")) Then
                    If CDec(dr1("lOdemeTutar")) > 0 Then
                        Return True
                    End If
                End If
            Next
        Catch
        End Try
        Return False
    End Function

    ''' <summary>
    ''' POS odemesi icin API'den otomatik cevap bekler. True = onaylandi, False = reddedildi/iptal
    ''' </summary>
    Private Function PosOdemeOnayBekle() As Boolean
        Try
            Dim kkTutar As Decimal = 0D
            For Each dr1 As DataRow In ds_odeme.Tables(0).Rows
                Dim sekil As String = If(dr1("sOdemeSekli") IsNot Nothing, dr1("sOdemeSekli").ToString().Trim().ToUpperInvariant(), "")
                If Not (sekil = "N" OrElse sekil.StartsWith("NAK") OrElse sekil.Contains("EFT") OrElse sekil.Contains("HAVALE")) Then
                    kkTutar += CDec(dr1("lOdemeTutar"))
                End If
            Next
            If kkTutar <= 0D Then Return True

            ' ===== ÖNCE POS'A ÖDEME GÖNDER =====
            Dim currentPosPaymentId As String = Nothing
            Try
                If String.IsNullOrEmpty(KolaysoftToken) OrElse String.IsNullOrEmpty(KolaysoftFirmaId) Then
                    LogYaz("PosOdemeOnayBekle", "Token veya FirmaId bos - POS entegrasyonu yapilamiyor")
                    Return True ' POS bilgileri yoksa odemeyi kabul et
                End If
                
                ' Belge numarasini tbAlisveris.PosFisNo'dan al
                Dim documentNo As String = ""
                Try
                    Dim nIdOdeme As String = dr("nAlisverisID").ToString()
                    Dim nIdSqlOdeme As String = "'" & nIdOdeme.Replace("'", "''") & "'"
                    Dim dtPosFis As DataTable = SQLCalistir("SELECT ISNULL(PosFisNo,'') AS PosFisNo FROM tbAlisveris WHERE nAlisverisID = " & nIdSqlOdeme)
                    If dtPosFis IsNot Nothing AndAlso dtPosFis.Rows.Count > 0 Then
                        documentNo = dtPosFis.Rows(0)("PosFisNo").ToString().Trim()
                    End If
                Catch exDoc As Exception
                    LogYaz("PosOdemeOnayBekle", "PosFisNo alinamadi: " & exDoc.Message)
                End Try
                If String.IsNullOrEmpty(documentNo) OrElse documentNo = "0" Then
                    LogYaz("PosOdemeOnayBekle", "PosFisNo bos - POS odemesi gonderilemez")
                    Dim sonucFisNo = MessageBox.Show("Bu satis icin POS belge numarasi (PosFisNo) bulunamadi." & vbCrLf & "Sebebi: Satis daha onceden POS'a gonderilememis veya belge numarasi alinamamis." & vbCrLf & vbCrLf & "Odemeyi POS'a gondermeden yerel olarak kaydetmek istiyor musunuz?" & vbCrLf & "(POS'a elle giris yapmaniz gerekecektir)", "POS Belge Numarasi Bulunamadi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If sonucFisNo = DialogResult.Yes Then
                        LogYaz("PosOdemeOnayBekle", "Kullanici onayladi - POS'suz yerel kayit yapilacak")
                        Return True
                    Else
                        Return False
                    End If
                End If
                
                ' Musteri TC/VKN - varsa al, yoksa nihai tuketici
                Dim currentIdentifier As String = "11111111111"
                Try
                    If nMusteriID > 0 Then
                        Dim dtMus = SQLCalistir("SELECT m.sVergiNo, ISNULL(n.sCuzdanKayitNo,'') AS TC FROM tbMusteri m LEFT JOIN tbMusteriNufusu n ON m.nMusteriID=n.nMusteriID WHERE m.nMusteriID=" & nMusteriID)
                        If dtMus IsNot Nothing AndAlso dtMus.Rows.Count > 0 Then
                            Dim r = dtMus.Rows(0)
                            If Not IsDBNull(r("sVergiNo")) AndAlso r("sVergiNo") IsNot Nothing Then currentIdentifier = r("sVergiNo").ToString().Trim()
                            If String.IsNullOrEmpty(currentIdentifier) Then
                                If Not IsDBNull(r("TC")) AndAlso r("TC") IsNot Nothing Then currentIdentifier = r("TC").ToString().Trim()
                            End If
                        End If
                    End If
                    If String.IsNullOrEmpty(currentIdentifier) Then currentIdentifier = "11111111111"
                Catch
                    currentIdentifier = "11111111111"
                End Try
                
                ' POS odeme gonder - API v1.0.3 formati
                Dim body As New Dictionary(Of String, Object) From {
                    {"documentNo", documentNo},
                    {"amount", kkTutar},
                    {"currentIdentifier", currentIdentifier},
                    {"companyId", KolaysoftFirmaId},
                    {"creditCardFirstAmount", kkTutar}
                }
                Dim jsonBody As String = JsonConvert.SerializeObject(body, Formatting.None)
                
                LogYaz("PosOdemeOnayBekle", "POS'a gonderiliyor: " & jsonBody)
                
                ServicePointManager.Expect100Continue = False
                Dim url As String = "https://service.kolaysoftpos.com/services/pos/api/erp/current-pos-payments"
                Dim req = CType(WebRequest.Create(url), HttpWebRequest)
                req.Method = "POST"
                req.ContentType = "application/json"
                req.Accept = "application/json"
                req.Headers.Add("Authorization", "Bearer " & KolaysoftToken)
                req.Timeout = 30000
                req.KeepAlive = False
                req.Proxy = Nothing
                
                Dim data = Encoding.UTF8.GetBytes(jsonBody)
                req.ContentLength = data.Length
                Using s = req.GetRequestStream()
                    s.Write(data, 0, data.Length)
                End Using
                
                Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim txt As String = reader.ReadToEnd().Trim()
                        LogYaz("PosOdemeOnayBekle", "POS yaniti: " & If(txt.Length > 300, txt.Substring(0, 300), txt))
                        
                        Try
                            Dim tok As JToken = JToken.Parse(txt)
                            If TypeOf tok Is JObject Then
                                currentPosPaymentId = CStr(CType(tok, JObject).SelectToken("id"))
                            ElseIf TypeOf tok Is JArray Then
                                Dim arr As JArray = CType(tok, JArray)
                                If arr.Count > 0 Then
                                    currentPosPaymentId = CStr(CType(arr(0), JObject).SelectToken("id"))
                                End If
                            End If
                        Catch
                        End Try
                    End Using
                End Using
                
                LogYaz("PosOdemeOnayBekle", "POS Payment ID: " & If(currentPosPaymentId, "NULL"))
            Catch wex As System.Net.WebException
                Dim errorResponse As String = ""
                Dim hataMesaji As String = wex.Message
                Try
                    If wex.Response IsNot Nothing Then
                        Using reader As New StreamReader(wex.Response.GetResponseStream())
                            errorResponse = reader.ReadToEnd()
                        End Using
                        LogYaz("PosOdemeOnayBekle", "POS API Hata Yaniti: " & errorResponse)
                        
                        ' Parse error message from JSON response
                        Try
                            Dim errObj As JObject = JObject.Parse(errorResponse)
                            If errObj.SelectToken("message") IsNot Nothing Then
                                hataMesaji = errObj.SelectToken("message").ToString()
                            ElseIf errObj.SelectToken("error") IsNot Nothing Then
                                hataMesaji = errObj.SelectToken("error").ToString()
                            ElseIf errObj.SelectToken("errors") IsNot Nothing Then
                                hataMesaji = errObj.SelectToken("errors").ToString()
                            End If
                        Catch
                            If Not String.IsNullOrEmpty(errorResponse) Then hataMesaji = errorResponse
                        End Try
                    End If
                Catch
                End Try
                LogYaz("PosOdemeOnayBekle", "POS gonderme hatasi: " & wex.Message & " - " & errorResponse)
                
                MessageBox.Show("POS'a odeme gonderilemedi." & vbCrLf & vbCrLf & "Hata: " & hataMesaji & vbCrLf & vbCrLf & "Odeme kaydedilmedi.", "POS Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Catch posEx As Exception
                LogYaz("PosOdemeOnayBekle", "POS gonderme hatasi: " & posEx.Message)
                MessageBox.Show("POS'a odeme gonderilemedi." & vbCrLf & vbCrLf & "Hata: " & posEx.Message & vbCrLf & vbCrLf & "Odeme kaydedilmedi.", "POS Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End Try
            ' ===== POS GONDERME BITTI =====

            Dim posOnay As Boolean = False
            Dim maxBekleme As Integer = 120
            Dim gecenSure As Integer = 0

            Using frmBekle As New Form()
                frmBekle.Text = "POS Odeme Bekleniyor"
                frmBekle.Size = New Size(420, 220)
                frmBekle.StartPosition = FormStartPosition.CenterScreen
                frmBekle.FormBorderStyle = FormBorderStyle.FixedDialog
                frmBekle.MaximizeBox = False
                frmBekle.MinimizeBox = False

                Dim lblMesaj As New Label()
                lblMesaj.Text = "POS cihazindan odeme bekleniyor..." & vbCrLf & vbCrLf & "Tutar: " & FormatNumber(kkTutar, 2) & " TL"
                lblMesaj.AutoSize = False
                lblMesaj.Size = New Size(380, 80)
                lblMesaj.Location = New Point(20, 20)
                lblMesaj.TextAlign = ContentAlignment.MiddleCenter
                lblMesaj.Font = New Font("Tahoma", 11, FontStyle.Bold)
                frmBekle.Controls.Add(lblMesaj)

                Dim lblDurum As New Label()
                lblDurum.Text = "Durum: POS'a gonderildi, bekleniyor..."
                lblDurum.AutoSize = False
                lblDurum.Size = New Size(380, 30)
                lblDurum.Location = New Point(20, 100)
                lblDurum.TextAlign = ContentAlignment.MiddleCenter
                frmBekle.Controls.Add(lblDurum)

                Dim btnIptal As New Button()
                btnIptal.Text = "IPTAL"
                btnIptal.Size = New Size(160, 40)
                btnIptal.Location = New Point(130, 135)
                AddHandler btnIptal.Click, Sub(s, ev) 
                    posOnay = False
                    frmBekle.DialogResult = DialogResult.Cancel
                End Sub
                frmBekle.Controls.Add(btnIptal)

                Dim timer As New Windows.Forms.Timer()
                timer.Interval = 3000
                AddHandler timer.Tick, Sub(s, ev)
                                           gecenSure += 3
                                           lblDurum.Text = "Durum: Kontrol ediliyor... (" & gecenSure & " sn)"
                                           Application.DoEvents()

                                           Dim durum As String = KolaysoftPosDurumKontrol()

                                           If durum = "SUCCESS" Then
                                               posOnay = True
                                               timer.Stop()
                                               frmBekle.DialogResult = DialogResult.OK
                                           ElseIf durum = "FAILED" Then
                                               lblDurum.Text = "HATA: Odeme basarisiz!"
                                               posOnay = False
                                               timer.Stop()
                                               Threading.Thread.Sleep(2000)
                                               frmBekle.DialogResult = DialogResult.Abort
                                           ElseIf durum = "CANCELLED" OrElse durum = "ABORTED" Then
                                               lblDurum.Text = "Odeme iptal edildi."
                                               posOnay = False
                                               timer.Stop()
                                               Threading.Thread.Sleep(2000)
                                               frmBekle.DialogResult = DialogResult.Cancel
                                           ElseIf durum = "ON_TERMINAL" OrElse durum = "IN_PROGRESS" Then
                                               lblDurum.Text = "Durum: POS islem yapiyor..."
                                           ElseIf gecenSure >= maxBekleme Then
                                               ' Zaman asimi - yine de kaydet seçeneği sun
                                               timer.Stop()
                                               MessageBox.Show("POS'tan yanit alinamadi (zaman asimi)." & vbCrLf & vbCrLf & "Odeme kaydedilmedi.", "Zaman Asimi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                               posOnay = False
                                               frmBekle.DialogResult = DialogResult.Abort
                                           End If
                                       End Sub

                timer.Start()
                frmBekle.ShowDialog()
                timer.Stop()
            End Using

            Return posOnay
        Catch ex As Exception
            LogYaz("PosOdemeOnayBekle", "Hata: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function KolaysoftPosDurumKontrol() As String
        Try
            If String.IsNullOrEmpty(KolaysoftToken) OrElse String.IsNullOrEmpty(KolaysoftFirmaId) Then Return "PENDING"

            Dim url As String = "https://service.kolaysoftpos.com/services/pos/api/erp/current-pos-payments?companyId.equals=" & Uri.EscapeDataString(KolaysoftFirmaId) & "&size=1&sort=id,desc"
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "GET"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            req.Headers.Add("Authorization", "Bearer " & KolaysoftToken)
            req.Timeout = 8000

            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                    Dim jsonStr As String = reader.ReadToEnd()
                    If jsonStr.Contains("""SUCCESS""") Then Return "SUCCESS"
                    If jsonStr.Contains("""FAILED""") Then Return "FAILED"
                    If jsonStr.Contains("""CANCELLED""") Then Return "CANCELLED"
                    If jsonStr.Contains("""ABORTED""") Then Return "ABORTED"
                    If jsonStr.Contains("""ON_TERMINAL""") Then Return "ON_TERMINAL"
                    If jsonStr.Contains("""IN_PROGRESS""") Then Return "IN_PROGRESS"
                End Using
            End Using
            Return "PENDING"
        Catch
            Return "PENDING"
        End Try
    End Function



End Class
