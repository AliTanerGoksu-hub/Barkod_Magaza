Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbCekSenet_liste
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
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_dteBordroTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBordroNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBordroNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteBordroTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sCekSenetTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents colnCekSenetID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCekSenetNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteVadeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBankaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBankaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOrjinalCekSenetNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVerenFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVerenFirmaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSonCekSenetIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAlanFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAlanFirmaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_secilen_sayi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ortvade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colsIl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBorclusu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBorcluVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBorcluVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCekSenetKodu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCekSenetKodu2 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sBankaKodu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sEvrakNo2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sEvrakNo1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colsBankaHesapNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_sSubeMagaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBordroNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVadeGun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKod1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKod2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBorcluVergiNumarasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteBordroTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ds_tbCekSenet As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_nCekSenetIslem As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_magaza As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbCekSenet_liste))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sNot = New DevExpress.XtraEditors.TextEdit()
        Me.sec_sSubeMagaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_nCekSenetIslem = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_sTarih = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sBankaKodu = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sEvrakNo2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sEvrakNo1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sCekSenetTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lBordroNo2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lBordroNo1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteBordroTarihi2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteBordroTarihi1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_ortvade = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_secilen = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_secilen_sayi = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnCekSenetID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCekSenetNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteVadeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBankaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBankaAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOrjinalCekSenetNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVerenFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVerenFirmaAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSonCekSenetIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlanFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlanFirmaAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBankaHesapNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSemt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBorclusu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBorcluVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBorcluVergiNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCekSenetKodu1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCekSenetKodu2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTahsilat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnOpsiyon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGecikme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteSonSonIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteDuzenlemeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel4 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBordroNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVadeGun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKod1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKod2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBorcluVergiNumarasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteBordroTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.ds_tbCekSenet = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.ds_magaza = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_sNot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nCekSenetIslem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sTarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sBankaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvrakNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvrakNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sCekSenetTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lBordroNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lBordroNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Panel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbCekSenet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelControl1.Size = New System.Drawing.Size(1766, 247)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.txt_sNot)
        Me.GroupControl1.Controls.Add(Me.sec_sSubeMagaza)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.sec_nCekSenetIslem)
        Me.GroupControl1.Controls.Add(Me.sec_sTarih)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.sec_sBankaKodu)
        Me.GroupControl1.Controls.Add(Me.txt_sEvrakNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_sEvrakNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sec_sCekSenetTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_lBordroNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_lBordroNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_dteBordroTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_dteBordroTarihi1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(153, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1235, 243)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Location = New System.Drawing.Point(0, 204)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl15.TabIndex = 34
        Me.LabelControl15.Text = "Not:"
        '
        'txt_sNot
        '
        Me.txt_sNot.EnterMoveNextControl = True
        Me.txt_sNot.Location = New System.Drawing.Point(114, 204)
        Me.txt_sNot.Name = "txt_sNot"
        Me.txt_sNot.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sNot.Properties.Appearance.Options.UseFont = True
        Me.txt_sNot.Properties.MaxLength = 15
        Me.txt_sNot.Size = New System.Drawing.Size(233, 28)
        Me.txt_sNot.TabIndex = 33
        '
        'sec_sSubeMagaza
        '
        Me.sec_sSubeMagaza.EnterMoveNextControl = True
        Me.sec_sSubeMagaza.Location = New System.Drawing.Point(344, 147)
        Me.sec_sSubeMagaza.Name = "sec_sSubeMagaza"
        Me.sec_sSubeMagaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSubeMagaza.Properties.DisplayMember = "sSubeMagaza"
        Me.sec_sSubeMagaza.Properties.NullText = "[SubeMagaza]"
        Me.sec_sSubeMagaza.Properties.ValueMember = "sSubeMagaza"
        Me.sec_sSubeMagaza.Size = New System.Drawing.Size(160, 26)
        Me.sec_sSubeMagaza.TabIndex = 31
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(286, 147)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 29)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Þube:"
        '
        'sec_nCekSenetIslem
        '
        Me.sec_nCekSenetIslem.EditValue = "[Tümü]"
        Me.sec_nCekSenetIslem.EnterMoveNextControl = True
        Me.sec_nCekSenetIslem.Location = New System.Drawing.Point(344, 33)
        Me.sec_nCekSenetIslem.Name = "sec_nCekSenetIslem"
        Me.sec_nCekSenetIslem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nCekSenetIslem.Properties.ShowPopupCloseButton = False
        Me.sec_nCekSenetIslem.Size = New System.Drawing.Size(160, 26)
        Me.sec_nCekSenetIslem.TabIndex = 1
        '
        'sec_sTarih
        '
        Me.sec_sTarih.EditValue = "Vade:"
        Me.sec_sTarih.Location = New System.Drawing.Point(24, 66)
        Me.sec_sTarih.Name = "sec_sTarih"
        Me.sec_sTarih.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sTarih.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sTarih.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sTarih.Properties.Appearance.Options.UseFont = True
        Me.sec_sTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_sTarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sTarih.Properties.Items.AddRange(New Object() {"Vade:", "Tarih:", "Ýþlem:"})
        Me.sec_sTarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sTarih.Size = New System.Drawing.Size(86, 26)
        Me.sec_sTarih.TabIndex = 30
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(0, 147)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "Banka:"
        '
        'sec_sBankaKodu
        '
        Me.sec_sBankaKodu.EnterMoveNextControl = True
        Me.sec_sBankaKodu.Location = New System.Drawing.Point(114, 147)
        Me.sec_sBankaKodu.Name = "sec_sBankaKodu"
        Me.sec_sBankaKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sBankaKodu.Properties.DisplayMember = "sAciklama"
        Me.sec_sBankaKodu.Properties.NullText = "[Bankalar]"
        Me.sec_sBankaKodu.Properties.ValueMember = "sBankaKodu"
        Me.sec_sBankaKodu.Size = New System.Drawing.Size(160, 26)
        Me.sec_sBankaKodu.TabIndex = 8
        '
        'txt_sEvrakNo2
        '
        Me.txt_sEvrakNo2.EditValue = "zzzzzzzzz"
        Me.txt_sEvrakNo2.EnterMoveNextControl = True
        Me.txt_sEvrakNo2.Location = New System.Drawing.Point(344, 119)
        Me.txt_sEvrakNo2.Name = "txt_sEvrakNo2"
        Me.txt_sEvrakNo2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEvrakNo2.Properties.Appearance.Options.UseFont = True
        Me.txt_sEvrakNo2.Properties.MaxLength = 15
        Me.txt_sEvrakNo2.Size = New System.Drawing.Size(160, 28)
        Me.txt_sEvrakNo2.TabIndex = 7
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(283, 119)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(39, 27)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "ve"
        '
        'txt_sEvrakNo1
        '
        Me.txt_sEvrakNo1.EnterMoveNextControl = True
        Me.txt_sEvrakNo1.Location = New System.Drawing.Point(114, 119)
        Me.txt_sEvrakNo1.Name = "txt_sEvrakNo1"
        Me.txt_sEvrakNo1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEvrakNo1.Properties.Appearance.Options.UseFont = True
        Me.txt_sEvrakNo1.Properties.MaxLength = 15
        Me.txt_sEvrakNo1.Size = New System.Drawing.Size(160, 28)
        Me.txt_sEvrakNo1.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(0, 119)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(104, 28)
        Me.LabelControl9.TabIndex = 24
        Me.LabelControl9.Text = "EvrakNo:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(278, 33)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(56, 28)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Durum:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(0, 33)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(104, 28)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "EvrakTipi:"
        '
        'sec_sCekSenetTipi
        '
        Me.sec_sCekSenetTipi.EnterMoveNextControl = True
        Me.sec_sCekSenetTipi.Location = New System.Drawing.Point(114, 33)
        Me.sec_sCekSenetTipi.Name = "sec_sCekSenetTipi"
        Me.sec_sCekSenetTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sCekSenetTipi.Properties.DisplayMember = "sCekSenetTipi"
        Me.sec_sCekSenetTipi.Properties.NullText = "[CekSenetTipi]"
        Me.sec_sCekSenetTipi.Properties.ValueMember = "sCekSenetTipi"
        Me.sec_sCekSenetTipi.Size = New System.Drawing.Size(160, 26)
        Me.sec_sCekSenetTipi.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(0, 176)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(104, 28)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Hesap:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(507, 86)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(120, 28)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasýndaki"
        '
        'txt_lBordroNo2
        '
        Me.txt_lBordroNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lBordroNo2.EnterMoveNextControl = True
        Me.txt_lBordroNo2.Location = New System.Drawing.Point(344, 90)
        Me.txt_lBordroNo2.Name = "txt_lBordroNo2"
        Me.txt_lBordroNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lBordroNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lBordroNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lBordroNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lBordroNo2.Size = New System.Drawing.Size(160, 26)
        Me.txt_lBordroNo2.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(283, 90)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 27)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lBordroNo1
        '
        Me.txt_lBordroNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_lBordroNo1.EnterMoveNextControl = True
        Me.txt_lBordroNo1.Location = New System.Drawing.Point(114, 90)
        Me.txt_lBordroNo1.Name = "txt_lBordroNo1"
        Me.txt_lBordroNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lBordroNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lBordroNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lBordroNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lBordroNo1.Size = New System.Drawing.Size(160, 26)
        Me.txt_lBordroNo1.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(0, 90)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "PortföyNo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(507, 60)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(120, 29)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Arasýndaki"
        '
        'txt_dteBordroTarihi2
        '
        Me.txt_dteBordroTarihi2.EditValue = Nothing
        Me.txt_dteBordroTarihi2.EnterMoveNextControl = True
        Me.txt_dteBordroTarihi2.Location = New System.Drawing.Point(344, 61)
        Me.txt_dteBordroTarihi2.Name = "txt_dteBordroTarihi2"
        Me.txt_dteBordroTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteBordroTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteBordroTarihi2.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteBordroTarihi2.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(283, 61)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 29)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "ve"
        '
        'txt_dteBordroTarihi1
        '
        Me.txt_dteBordroTarihi1.EditValue = Nothing
        Me.txt_dteBordroTarihi1.EnterMoveNextControl = True
        Me.txt_dteBordroTarihi1.Location = New System.Drawing.Point(114, 61)
        Me.txt_dteBordroTarihi1.Name = "txt_dteBordroTarihi1"
        Me.txt_dteBordroTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteBordroTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteBordroTarihi1.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteBordroTarihi1.TabIndex = 2
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(344, 176)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adý"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(160, 26)
        Me.sec_konum.TabIndex = 10
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(344, 204)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(160, 29)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(507, 176)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(120, 26)
        Me.sec_kriter.TabIndex = 11
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(114, 176)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(233, 28)
        Me.txt_ara.TabIndex = 9
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(1388, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(376, 243)
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
        Me.PictureBox1.Image = Global.business_smart.My.Resources.Resources._6E32A293_1676_0913_6941A3AC186BF8D8___Kopya
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 243)
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 826)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1766, 69)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1629, 11)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1509, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'lbl_ortvade
        '
        Me.lbl_ortvade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ortvade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_ortvade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_ortvade.Location = New System.Drawing.Point(133, 79)
        Me.lbl_ortvade.Name = "lbl_ortvade"
        Me.lbl_ortvade.Size = New System.Drawing.Size(20, 21)
        Me.lbl_ortvade.TabIndex = 30
        Me.lbl_ortvade.Text = "%"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(2, 79)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(106, 19)
        Me.LabelControl16.TabIndex = 29
        Me.LabelControl16.Text = "OrtalamaVade:"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(133, 60)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(20, 21)
        Me.lbl_gun.TabIndex = 28
        Me.lbl_gun.Text = "%"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.Location = New System.Drawing.Point(10, 60)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(100, 19)
        Me.LabelControl17.TabIndex = 27
        Me.LabelControl17.Text = "OrtalamaGün:"
        '
        'lbl_secilen
        '
        Me.lbl_secilen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen.Location = New System.Drawing.Point(133, 41)
        Me.lbl_secilen.Name = "lbl_secilen"
        Me.lbl_secilen.Size = New System.Drawing.Size(20, 21)
        Me.lbl_secilen.TabIndex = 26
        Me.lbl_secilen.Text = "%"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(16, 41)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(93, 19)
        Me.LabelControl14.TabIndex = 25
        Me.LabelControl14.Text = "SeçilenTutar:"
        '
        'lbl_secilen_sayi
        '
        Me.lbl_secilen_sayi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen_sayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen_sayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen_sayi.Location = New System.Drawing.Point(133, 23)
        Me.lbl_secilen_sayi.Name = "lbl_secilen_sayi"
        Me.lbl_secilen_sayi.Size = New System.Drawing.Size(20, 21)
        Me.lbl_secilen_sayi.TabIndex = 14
        Me.lbl_secilen_sayi.Text = "%"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(14, 23)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(94, 19)
        Me.LabelControl13.TabIndex = 13
        Me.LabelControl13.Text = "SeçilenEvrak:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.Panel1)
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 247)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1766, 579)
        Me.PanelControl3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1762, 425)
        Me.Panel2.TabIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1758, 421)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem13, Me.MenuItem14, Me.MenuItem18, Me.MenuItem15, Me.MenuItem17, Me.MenuItem23, Me.MenuItem24, Me.MenuItem16, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem21.Text = "Ara"
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Fiþi Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 5
        Me.MenuItem17.Text = "Bankaya Tahsile Ver"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.Text = "Tahsilat"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 7
        Me.MenuItem24.Text = "Kapat"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 8
        Me.MenuItem16.Text = "Bankadan Tahsilat"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 9
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 10
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 11
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 12
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 13
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 14
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 15
        Me.MenuItem22.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 16
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 17
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 18
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 19
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 20
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 21
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 22
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nCekSenetID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lCekSenetNo"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lTutar"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "dteVadeTarihi"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sBankaKodu"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sBankaAciklama"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sOrjinalCekSenetNo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sVerenFirmaKodu"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sVerenFirmaAciklama"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nSonCekSenetIslem"
        Me.DataColumn10.DataType = GetType(Long)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sIslem"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sAlanFirmaKodu"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sAlanFirmaAciklama"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sHareketTipi"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sDovizCinsi1"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lDovizMiktari1"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lDovizKuru1"
        Me.DataColumn17.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnCekSenetID, Me.collCekSenetNo, Me.collTutar, Me.coldteVadeTarihi, Me.colsBankaKodu, Me.colsBankaAciklama, Me.colsOrjinalCekSenetNo, Me.colsVerenFirmaKodu, Me.colsVerenFirmaAciklama, Me.colnSonCekSenetIslem, Me.colsIslem, Me.colsAlanFirmaKodu, Me.colsAlanFirmaAciklama, Me.colsHareketTipi, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsBankaHesapNo, Me.colsIl, Me.colsSemt, Me.colsBorclusu, Me.colsBorcluVergiDairesi, Me.colsBorcluVergiNo, Me.colsNot, Me.colsCekSenetKodu1, Me.colsCekSenetKodu2, Me.collTahsilat, Me.collKalan, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colnOpsiyon, Me.colnGecikme, Me.coldteSonSonIslemTarihi, Me.coldteDuzenlemeTarihi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1017, 233, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "lCekSenetNo", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "lCekSenetNo", Me.collCekSenetNo, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", Me.collTutar, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", Me.collDovizMiktari1, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "lKalan", Me.collKalan, "{0:#,0.00##}")})
        Me.GridView1.IndicatorWidth = 30
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
        'colnCekSenetID
        '
        Me.colnCekSenetID.Caption = "Çek Senet ID"
        Me.colnCekSenetID.FieldName = "nCekSenetID"
        Me.colnCekSenetID.Name = "colnCekSenetID"
        '
        'collCekSenetNo
        '
        Me.collCekSenetNo.Caption = "PortFöy"
        Me.collCekSenetNo.FieldName = "lCekSenetNo"
        Me.collCekSenetNo.Name = "collCekSenetNo"
        Me.collCekSenetNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lCekSenetNo", "{0} Kayýt")})
        Me.collCekSenetNo.Visible = True
        Me.collCekSenetNo.VisibleIndex = 3
        Me.collCekSenetNo.Width = 53
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00}")})
        Me.collTutar.Width = 54
        '
        'coldteVadeTarihi
        '
        Me.coldteVadeTarihi.Caption = "Vade"
        Me.coldteVadeTarihi.FieldName = "dteVadeTarihi"
        Me.coldteVadeTarihi.Name = "coldteVadeTarihi"
        Me.coldteVadeTarihi.Visible = True
        Me.coldteVadeTarihi.VisibleIndex = 6
        Me.coldteVadeTarihi.Width = 61
        '
        'colsBankaKodu
        '
        Me.colsBankaKodu.Caption = "Banka Kodu"
        Me.colsBankaKodu.FieldName = "sBankaKodu"
        Me.colsBankaKodu.Name = "colsBankaKodu"
        Me.colsBankaKodu.Visible = True
        Me.colsBankaKodu.VisibleIndex = 8
        Me.colsBankaKodu.Width = 57
        '
        'colsBankaAciklama
        '
        Me.colsBankaAciklama.Caption = "Banka"
        Me.colsBankaAciklama.FieldName = "sBankaAciklama"
        Me.colsBankaAciklama.Name = "colsBankaAciklama"
        Me.colsBankaAciklama.Visible = True
        Me.colsBankaAciklama.VisibleIndex = 9
        Me.colsBankaAciklama.Width = 94
        '
        'colsOrjinalCekSenetNo
        '
        Me.colsOrjinalCekSenetNo.Caption = "Evrak No"
        Me.colsOrjinalCekSenetNo.FieldName = "sOrjinalCekSenetNo"
        Me.colsOrjinalCekSenetNo.Name = "colsOrjinalCekSenetNo"
        Me.colsOrjinalCekSenetNo.Visible = True
        Me.colsOrjinalCekSenetNo.VisibleIndex = 4
        Me.colsOrjinalCekSenetNo.Width = 50
        '
        'colsVerenFirmaKodu
        '
        Me.colsVerenFirmaKodu.Caption = "Firma Kodu"
        Me.colsVerenFirmaKodu.FieldName = "sVerenFirmaKodu"
        Me.colsVerenFirmaKodu.Name = "colsVerenFirmaKodu"
        Me.colsVerenFirmaKodu.Visible = True
        Me.colsVerenFirmaKodu.VisibleIndex = 1
        Me.colsVerenFirmaKodu.Width = 60
        '
        'colsVerenFirmaAciklama
        '
        Me.colsVerenFirmaAciklama.Caption = "Firma"
        Me.colsVerenFirmaAciklama.FieldName = "sVerenFirmaAciklama"
        Me.colsVerenFirmaAciklama.Name = "colsVerenFirmaAciklama"
        Me.colsVerenFirmaAciklama.Visible = True
        Me.colsVerenFirmaAciklama.VisibleIndex = 2
        Me.colsVerenFirmaAciklama.Width = 95
        '
        'colnSonCekSenetIslem
        '
        Me.colnSonCekSenetIslem.Caption = "Çek Senet Ýþlem"
        Me.colnSonCekSenetIslem.FieldName = "nSonCekSenetIslem"
        Me.colnSonCekSenetIslem.Name = "colnSonCekSenetIslem"
        Me.colnSonCekSenetIslem.Width = 60
        '
        'colsIslem
        '
        Me.colsIslem.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsIslem.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsIslem.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colsIslem.AppearanceCell.Options.UseBackColor = True
        Me.colsIslem.AppearanceCell.Options.UseForeColor = True
        Me.colsIslem.Caption = "Ýþlem"
        Me.colsIslem.FieldName = "sIslem"
        Me.colsIslem.Name = "colsIslem"
        Me.colsIslem.Visible = True
        Me.colsIslem.VisibleIndex = 0
        Me.colsIslem.Width = 56
        '
        'colsAlanFirmaKodu
        '
        Me.colsAlanFirmaKodu.Caption = "Alan Hesap Kodu"
        Me.colsAlanFirmaKodu.FieldName = "sAlanFirmaKodu"
        Me.colsAlanFirmaKodu.Name = "colsAlanFirmaKodu"
        '
        'colsAlanFirmaAciklama
        '
        Me.colsAlanFirmaAciklama.Caption = "Alan Hesap"
        Me.colsAlanFirmaAciklama.FieldName = "sAlanFirmaAciklama"
        Me.colsAlanFirmaAciklama.Name = "colsAlanFirmaAciklama"
        Me.colsAlanFirmaAciklama.Visible = True
        Me.colsAlanFirmaAciklama.VisibleIndex = 7
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "HT"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Width = 31
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Pb"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        Me.colsDovizCinsi1.Width = 33
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Tutar"
        Me.collDovizMiktari1.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        Me.collDovizMiktari1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", "{0:#,0.00}")})
        Me.collDovizMiktari1.Visible = True
        Me.collDovizMiktari1.VisibleIndex = 10
        Me.collDovizMiktari1.Width = 66
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Kur"
        Me.collDovizKuru1.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizKuru1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        Me.collDovizKuru1.Width = 38
        '
        'colsBankaHesapNo
        '
        Me.colsBankaHesapNo.Caption = "Hesap No"
        Me.colsBankaHesapNo.FieldName = "sBankaHesapNo"
        Me.colsBankaHesapNo.Name = "colsBankaHesapNo"
        '
        'colsIl
        '
        Me.colsIl.Caption = "il"
        Me.colsIl.FieldName = "sIl"
        Me.colsIl.Name = "colsIl"
        '
        'colsSemt
        '
        Me.colsSemt.Caption = "Semt"
        Me.colsSemt.FieldName = "sSemt"
        Me.colsSemt.Name = "colsSemt"
        '
        'colsBorclusu
        '
        Me.colsBorclusu.Caption = "Borçlusu"
        Me.colsBorclusu.FieldName = "sBorclusu"
        Me.colsBorclusu.Name = "colsBorclusu"
        '
        'colsBorcluVergiDairesi
        '
        Me.colsBorcluVergiDairesi.Caption = "Borçlu Vergi Dairesi"
        Me.colsBorcluVergiDairesi.FieldName = "sBorcluVergiDairesi"
        Me.colsBorcluVergiDairesi.Name = "colsBorcluVergiDairesi"
        '
        'colsBorcluVergiNo
        '
        Me.colsBorcluVergiNo.Caption = "Borçlu Vergi No"
        Me.colsBorcluVergiNo.FieldName = "sBorcluVergiNo"
        Me.colsBorcluVergiNo.Name = "colsBorcluVergiNo"
        '
        'colsNot
        '
        Me.colsNot.Caption = "Not"
        Me.colsNot.FieldName = "sNot"
        Me.colsNot.Name = "colsNot"
        '
        'colsCekSenetKodu1
        '
        Me.colsCekSenetKodu1.Caption = "Kod 1"
        Me.colsCekSenetKodu1.FieldName = "sCekSenetKodu1"
        Me.colsCekSenetKodu1.Name = "colsCekSenetKodu1"
        '
        'colsCekSenetKodu2
        '
        Me.colsCekSenetKodu2.Caption = "Kod 2"
        Me.colsCekSenetKodu2.FieldName = "sCekSenetKodu2"
        Me.colsCekSenetKodu2.Name = "colsCekSenetKodu2"
        '
        'collTahsilat
        '
        Me.collTahsilat.Caption = "Tahsilat"
        Me.collTahsilat.FieldName = "lTahsilat"
        Me.collTahsilat.Name = "collTahsilat"
        '
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.00##"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.00##}")})
        Me.collKalan.Visible = True
        Me.collKalan.VisibleIndex = 5
        Me.collKalan.Width = 68
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kaydeden"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.DisplayFormat.FormatString = "dd/MM/yyyy HH:m:s t"
        Me.coldteKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colnOpsiyon
        '
        Me.colnOpsiyon.Caption = "Opsiyon"
        Me.colnOpsiyon.DisplayFormat.FormatString = "#,0"
        Me.colnOpsiyon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnOpsiyon.FieldName = "nOpsiyon"
        Me.colnOpsiyon.Name = "colnOpsiyon"
        '
        'colnGecikme
        '
        Me.colnGecikme.Caption = "Gecikme"
        Me.colnGecikme.DisplayFormat.FormatString = "#,0"
        Me.colnGecikme.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGecikme.FieldName = "nGecikme"
        Me.colnGecikme.Name = "colnGecikme"
        '
        'coldteSonSonIslemTarihi
        '
        Me.coldteSonSonIslemTarihi.Caption = "SonBordroTarihi"
        Me.coldteSonSonIslemTarihi.FieldName = "dteBordroTarihi"
        Me.coldteSonSonIslemTarihi.Name = "coldteSonSonIslemTarihi"
        '
        'coldteDuzenlemeTarihi
        '
        Me.coldteDuzenlemeTarihi.Caption = "DüzenlemeTarihi"
        Me.coldteDuzenlemeTarihi.FieldName = "dteDuzenlemeTarihi"
        Me.coldteDuzenlemeTarihi.Name = "coldteDuzenlemeTarihi"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 427)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1762, 150)
        Me.Panel1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GridControl3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(340, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1420, 146)
        Me.Panel4.TabIndex = 1
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1416, 142)
        Me.GridControl3.TabIndex = 1
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStatus, Me.collBordroNo, Me.colsKodu, Me.colsAciklama, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.colVadeGun, Me.colsHareketAciklama, Me.GridColumn8, Me.GridColumn9, Me.colKod1, Me.colKod2, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.colsBorcluVergiNumarasi, Me.coldteBordroTarihi, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.colsDovizCinsi2, Me.collDovizMiktari2})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "lCekSenetNo", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "lCekSenetNo", Me.GridColumn1, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", Me.GridColumn7, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", Nothing, "{0:#,0.00##}")})
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsPrint.ExpandAllGroups = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colStatus
        '
        Me.colStatus.Caption = "Ýþlem"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 173
        '
        'collBordroNo
        '
        Me.collBordroNo.Caption = "Bordro No"
        Me.collBordroNo.FieldName = "lBordroNo"
        Me.collBordroNo.Name = "collBordroNo"
        Me.collBordroNo.Visible = True
        Me.collBordroNo.VisibleIndex = 2
        Me.collBordroNo.Width = 65
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 3
        Me.colsKodu.Width = 65
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 4
        Me.colsAciklama.Width = 65
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "PorfoyNo"
        Me.GridColumn1.FieldName = "lCekSenetNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 65
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Banka Kodu"
        Me.GridColumn2.FieldName = "sBankaKodu"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Banka Açýklama"
        Me.GridColumn3.FieldName = "sBankaAciklama"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 95
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Semt"
        Me.GridColumn4.FieldName = "sSemt"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 61
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "il"
        Me.GridColumn5.FieldName = "sIl"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 61
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "VadeTarihi"
        Me.GridColumn6.FieldName = "dteVadeTarihi"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Width = 62
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tutar"
        Me.GridColumn7.DisplayFormat.FormatString = "#,0.00##"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "lTutar"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 62
        '
        'colVadeGun
        '
        Me.colVadeGun.Caption = "VadeGun"
        Me.colVadeGun.FieldName = "VadeGun"
        Me.colVadeGun.Name = "colVadeGun"
        '
        'colsHareketAciklama
        '
        Me.colsHareketAciklama.Caption = "HTAciklama"
        Me.colsHareketAciklama.FieldName = "sHareketAciklama"
        Me.colsHareketAciklama.Name = "colsHareketAciklama"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Hareket Tipi"
        Me.GridColumn8.FieldName = "sHareketTipi"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 76
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Evrak No"
        Me.GridColumn9.FieldName = "sOrjinalCekSenetNo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 94
        '
        'colKod1
        '
        Me.colKod1.Caption = "Kod 1"
        Me.colKod1.FieldName = "Kod1"
        Me.colKod1.Name = "colKod1"
        '
        'colKod2
        '
        Me.colKod2.Caption = "Kod 2"
        Me.colKod2.FieldName = "Kod2"
        Me.colKod2.Name = "colKod2"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Not"
        Me.GridColumn10.FieldName = "sNot"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Banka Hesap No"
        Me.GridColumn11.FieldName = "sBankaHesapNo"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Borçlusu"
        Me.GridColumn12.FieldName = "sBorclusu"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Borçlu Vergi Dairesi"
        Me.GridColumn13.FieldName = "sBorcluVergiDairesi"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'colsBorcluVergiNumarasi
        '
        Me.colsBorcluVergiNumarasi.Caption = "Borçlu Vergi No"
        Me.colsBorcluVergiNumarasi.FieldName = "sBorcluVergiNumarasi"
        Me.colsBorcluVergiNumarasi.Name = "colsBorcluVergiNumarasi"
        '
        'coldteBordroTarihi
        '
        Me.coldteBordroTarihi.Caption = "Tarih"
        Me.coldteBordroTarihi.FieldName = "dteBordroTarihi"
        Me.coldteBordroTarihi.Name = "coldteBordroTarihi"
        Me.coldteBordroTarihi.Visible = True
        Me.coldteBordroTarihi.VisibleIndex = 0
        Me.coldteBordroTarihi.Width = 73
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Ýþlem"
        Me.GridColumn14.FieldName = "sIslem"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 94
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Döviz Cinsi 1"
        Me.GridColumn15.FieldName = "sDovizCinsi1"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Döviz Miktarý 1"
        Me.GridColumn16.DisplayFormat.FormatString = "#,0.00##"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "lDovizMiktari1"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", "{0:#,0.00##}")})
        '
        'colsDovizCinsi2
        '
        Me.colsDovizCinsi2.Caption = "Döviz Cinsi 2"
        Me.colsDovizCinsi2.FieldName = "sDovizCinsi2"
        Me.colsDovizCinsi2.Name = "colsDovizCinsi2"
        '
        'collDovizMiktari2
        '
        Me.collDovizMiktari2.Caption = "Döviz Miktarý 2"
        Me.collDovizMiktari2.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizMiktari2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari2.FieldName = "lDovizMiktari2"
        Me.collDovizMiktari2.Name = "collDovizMiktari2"
        Me.collDovizMiktari2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari2", "{0:#,0.00##}")})
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_ortvade)
        Me.Panel3.Controls.Add(Me.LabelControl14)
        Me.Panel3.Controls.Add(Me.LabelControl16)
        Me.Panel3.Controls.Add(Me.LabelControl13)
        Me.Panel3.Controls.Add(Me.lbl_gun)
        Me.Panel3.Controls.Add(Me.lbl_secilen_sayi)
        Me.Panel3.Controls.Add(Me.LabelControl17)
        Me.Panel3.Controls.Add(Me.lbl_secilen)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(338, 146)
        Me.Panel3.TabIndex = 0
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(470, 23)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(372, 183)
        Me.sec_grid.TabIndex = 3
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(372, 183)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
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
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 90)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Cek/Senet Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16})
        Me.BarManager1.MaxItemId = 16
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
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
        Me.BarButtonItem5.Caption = "Firma Kartý"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Firma Hareketleri"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Ekstre,F7"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
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
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Text"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Mail"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Öde/Tahsil Et"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Kapat"
        Me.BarButtonItem14.Id = 13
        Me.BarButtonItem14.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem14.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Bankadan Tahsilat"
        Me.BarButtonItem15.Enabled = False
        Me.BarButtonItem15.Id = 14
        Me.BarButtonItem15.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem15.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Tahsile Ver"
        Me.BarButtonItem16.Id = 15
        Me.BarButtonItem16.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem16.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1766, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 895)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1766, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 895)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1766, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 895)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ekle,Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Düzelt,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Banka Kartý"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Banka Hareketleri"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'ds_tbCekSenet
        '
        Me.ds_tbCekSenet.DataSetName = "NewDataSet"
        Me.ds_tbCekSenet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nBordroSatirID"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nCekSenetID"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "lCekSenetNo"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "lTutar"
        Me.DataColumn21.DataType = GetType(Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "dteVadeTarihi"
        Me.DataColumn22.DataType = GetType(Date)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sHareketTipi"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sNot"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sIl"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sSemt"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sKarsiTarafCekSenetNo"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "dteDuzenlemeTarihi"
        Me.DataColumn28.DataType = GetType(Date)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sBankaKodu"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sBankaHesapNo"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sBankaSubeNo"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sOrjinalCekSenetNo"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nVerenID"
        Me.DataColumn33.DataType = GetType(Long)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "bKendineAit"
        Me.DataColumn34.DataType = GetType(Boolean)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sBorclusu"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sBorcluVergiDairesi"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sBorcluVergiNumarasi"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "nSonBordroSatirID"
        Me.DataColumn38.DataType = GetType(Long)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "nSonCekSenetIslem"
        Me.DataColumn39.DataType = GetType(Long)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "nCariHareketID"
        Me.DataColumn40.DataType = GetType(Long)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "nKasaIslemID"
        Me.DataColumn41.DataType = GetType(Long)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "nBorcluFirmaID"
        Me.DataColumn42.DataType = GetType(Long)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "nBorcluCariHareketID"
        Me.DataColumn43.DataType = GetType(Long)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "nProtestoMasrafiFirmaID"
        Me.DataColumn44.DataType = GetType(Long)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "nProtestoMasrafiCariHareketID"
        Me.DataColumn52.DataType = GetType(Long)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "lProtestoMasrafi"
        Me.DataColumn53.DataType = GetType(Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "nOncekiBordroSatirID"
        Me.DataColumn54.DataType = GetType(Long)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "nOncekiCekSenetIslem"
        Me.DataColumn55.DataType = GetType(Long)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "dteValorTarihi"
        Me.DataColumn56.DataType = GetType(Date)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn57.DataType = GetType(Boolean)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "sDovizCinsi1"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "lDovizMiktari1"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "lDovizKuru1"
        Me.DataColumn60.DataType = GetType(Decimal)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "sDovizCinsi2"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "lDovizMiktari2"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "lDovizKuru2"
        Me.DataColumn63.DataType = GetType(Decimal)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "sCekSenetKodu1"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "sCekSenetKodu2"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "sCekSenetTipi"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "nCekSenetIslem"
        Me.DataColumn67.DataType = GetType(Long)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "dteBordroTarihi"
        Me.DataColumn68.DataType = GetType(Date)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "lBordroNo"
        Me.DataColumn69.DataType = GetType(Long)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "nFirmaID"
        Me.DataColumn70.DataType = GetType(Long)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "sFirmaKodu"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "sKullaniciAdi"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "dteKayitTarihi"
        Me.DataColumn73.DataType = GetType(Date)
        '
        'ds_magaza
        '
        Me.ds_magaza.DataSetName = "NewDataSet"
        Me.ds_magaza.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_magaza.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn49, Me.DataColumn50, Me.DataColumn51})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "SEC"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "KOD"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "ACIKLAMA"
        '
        'frm_tbCekSenet_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1766, 925)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbCekSenet_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CekSenet Bordrolarý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txt_sNot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nCekSenetIslem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sTarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sBankaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvrakNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvrakNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sCekSenetTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lBordroNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lBordroNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Panel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbCekSenet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public nFirmaID As Int64 = 0
    Public islemstatus As Boolean = False
    Public bHatirlatma As Boolean = False
    Dim ds_tbCekSenetTipi As DataSet
    Dim ds_tbCekSenetIslem As DataSet
    Dim ds_tbBankaKodu As DataSet
    Dim ds_tbsube As DataSet
    Public sCekSenetTipi As String = ""
    Public nCekSenetIslem As String = 0
    Public bCekSenetIslemGoster As Boolean = False
    Public sCekSenetIslem As String = ""
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
        kriter += "EvrakTipi = " & sec_sCekSenetTipi.Text & vbTab & " Islem = " & sec_nCekSenetIslem.Text
        kriter += txt_dteBordroTarihi1.EditValue & " ve " & txt_dteBordroTarihi2.EditValue & " Tarihleri Arasýndaki" & vbCrLf
        kriter += "Portföy: " & txt_lBordroNo1.Text & " ve " & txt_lBordroNo1.Text & " Arasindaki " & "Evrakno = " & txt_sEvrakNo1.Text & " ve " & txt_sEvrakNo1.Text & "Arasindaki" & vbCrLf
        kriter += "Secilen Evrak: " & lbl_secilen_sayi.Text & " Secilen Tutar: " & lbl_secilen.Text & " OrtGun:  " & lbl_gun.Text & " OrtVade: " & lbl_ortvade.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Kambiyo Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        If GridView1.SelectedRowsCount > 1 Then
            GridView1.OptionsPrint.PrintSelectedRowsOnly = True
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        Else
            GridView1.OptionsPrint.PrintSelectedRowsOnly = False
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        Dim sCekSenetTipi As String = Trim(sec_sCekSenetTipi.EditValue)
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & sCekSenetTipi & "\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        sCekSenetTipi = Nothing
    End Sub
    Private Sub gorunum_yukle_grid()
        'Dim sCekSenetTipi As String = Trim(sec_sCekSenetTipi.EditValue)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Trim(sec_sCekSenetTipi.EditValue) & "\" & Me.Name.ToString & "")
        'sCekSenetTipi = Nothing
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
        LabelControl16.Text = Sorgu_sDil(LabelControl16.Text, sDil)
        LabelControl17.Text = Sorgu_sDil(LabelControl17.Text, sDil)
        Dim sCekSenetTipi As String = Trim(sec_sCekSenetTipi.EditValue)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & sCekSenetTipi & "\" & Me.Name.ToString & "")
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
    Private Sub dataload_tbCekSenetTipi()
        ds_tbCekSenetTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCekSenetTipi,sAciklama FROM         tbCekSenetTipi"))
        sec_sCekSenetTipi.Properties.DataSource = ds_tbCekSenetTipi.Tables(0)
        If sCekSenetTipi.ToString <> "" Then
            sec_sCekSenetTipi.EditValue = sCekSenetTipi
            dataload_tbCekSenetIslem(Trim(sec_sCekSenetTipi.EditValue), sCekSenetIslem)
            sec_sCekSenetTipi.Enabled = False
        Else
            sec_sCekSenetTipi.ItemIndex = 0
        End If
    End Sub
    Private Sub dataload_tbCekSenetIslem(Optional ByVal sCekSenetTipi As String = "AC", Optional ByVal sCekSenetIslem As String = "")
        Dim kriter As String = ""
        If sCekSenetIslem = "" Then
        Else
            kriter = " AND nCekSenetIslem IN(" & sCekSenetIslem & ") "
        End If
        If sCekSenetTipi = "AC" Or sCekSenetTipi = "AS" Then
            ds_tbCekSenetIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 AS nCekSenetIslem , '[Tümü]' AS sAciklama UNION ALL SELECT * FROM tbCekSenetIslem WHERE (nCekSenetIslem < 20) " & kriter & " "))
            ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nCekSenetIslem AS KOD, sAciklama AS ACIKLAMA FROM         tbCekSenetIslem  WHERE (nCekSenetIslem < 20) " & kriter & " ORDER BY nCekSenetIslem"))
            MenuItem23.Text = "Cüzdandan Tahsil Et"
            BarButtonItem13.Caption = MenuItem23.Text
        ElseIf sCekSenetTipi = "BC" Or sCekSenetTipi = "BS" Then
            ds_tbCekSenetIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 AS nCekSenetIslem , '[Tümü]' AS sAciklama UNION ALL SELECT * FROM tbCekSenetIslem WHERE (nCekSenetIslem >= 20)"))
            ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nCekSenetIslem AS KOD, sAciklama AS ACIKLAMA FROM         tbCekSenetIslem  WHERE (nCekSenetIslem >= 20)  ORDER BY nCekSenetIslem"))
            MenuItem23.Text = "Bankadan Öde"
            BarButtonItem13.Caption = MenuItem23.Text
        End If
        'sec_nCekSenetIslem.Properties.DataSource = ds_tbCekSenetIslem.Tables(0)
        If nCekSenetIslem = 0 Then
            'sec_nCekSenetIslem.ItemIndex = 0
        Else
            sec_nCekSenetIslem.EditValue = "'" + nCekSenetIslem.ToString + "'"
            sec_nCekSenetIslem.Enabled = bCekSenetIslemGoster
        End If
    End Sub
    Private Sub dataload_tbBankaKodu()
        ds_tbBankaKodu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sBankaKodu,sAciklama FROM         tbBanka"))
        sec_sBankaKodu.Properties.DataSource = ds_tbBankaKodu.Tables(0)
    End Sub
    Private Sub dataload_tbSube()
        ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        sec_sSubeMagaza.Properties.DataSource = ds_tbsube.Tables(0)
        If kullanici > 3 Then
            sec_sSubeMagaza.ItemIndex = 1
            sec_sSubeMagaza.EditValue = sSubeMagaza
            If Trim(sSubeMagaza) = "001" Then
                sec_sSubeMagaza.Properties.ReadOnly = False
            ElseIf Trim(sSubeMagaza) = "" Then
                sec_sSubeMagaza.Properties.ReadOnly = False
            Else
                sec_sSubeMagaza.Properties.ReadOnly = True
            End If
        Else
            sec_sSubeMagaza.EditValue = ""
            sec_sSubeMagaza.Properties.ReadOnly = False
        End If
    End Sub
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sTarih As String, ByVal sSubeMagaza As String, ByVal sNot As String) As DataSet
        Dim kriter As String = "WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "')"
        If sTarih = "Vade:" Then
            kriter += " AND tbCekSenet.dteVadeTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        ElseIf sTarih = "Tarih:" Then
            kriter += " AND tbCekSenet.dteDuzenlemeTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        ElseIf sTarih = "Ýþlem:" Then
            kriter += " AND tbCekSenet.dteKayitTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        End If
        kriter += " and tbCekSenet.lCekSenetNo between '" & lBordroNo1 & "' and '" & lBordroNo2 & "'"
        kriter += " and tbCekSenet.sOrjinalCekSenetNo between '" & sEvrakNo1 & "' and '" & sEvrakNo2 & "'"
        If Trim(sBankaKodu) <> "" Then
            kriter += " And tbCekSenet.sBankaKodu = '" & sBankaKodu & "' "
        End If
        'If nCekSenetIslem > 0 Then
        '    kriter += " and tbCekSenetBordro.nCekSenetIslem =" & nCekSenetIslem & " "
        'End If
        If nCekSenetIslem <> "[Tümü]" Then
            kriter += " and tbCekSenetBordro.nCekSenetIslem IN (" & nCekSenetIslem & ",6) "
        End If
        If Trim(sSubeMagaza) <> "" Then
            kriter += " AND tbCekSenet.sCekSenetKodu1 = '" & sSubeMagaza & "' "
        End If
        'If CStr(Trim(ara.ToString)) <> "" Then
        '    If sec_konum.Text = "Kodu" Then
        '        kriter += " AND   (tbFirma_1.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    ElseIf sec_konum.Text = "Adý" Then
        '        kriter += " AND  (tbFirma_1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    End If
        'End If
        If sec_nCekSenetIslem.EditValue = "'1'" Or sec_nCekSenetIslem.EditValue = "'6'" Then
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (Veren.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (Veren.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        Else
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbFirma_1.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (tbFirma_1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        End If
        If Trim(sNot) <> "" Then
            kriter += " And tbCekSenet.sNot = '" & sNot & "' "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.sCekSenetTipi,tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.nVerenID,tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, VEREN.sKodu AS sAlanFirmaKodu, VEREN.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi,(SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lTahsilat, tbCekSenet.lTutar - (SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lKalan,tbCekSenet.sKullaniciAdi,tbCekSenet.dteKayitTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.sCekSenetTipi,tbCekSenet.lTutar, DATEDIFF(day, '" & dteSistemTarihi & "', tbCekSenet.dteVadeTarihi) AS nGecikme,DATEDIFF(day, tbCekSenetBordro.dteBordroTarihi, tbCekSenet.dteVadeTarihi) AS nOpsiyon,tbCekSenet.dteVadeTarihi, tbCekSenet.dteDuzenlemeTarihi,tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.nVerenID,tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, tbFirma_1.sKodu AS sAlanFirmaKodu, tbFirma_1.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenet.sDovizCinsi2, tbCekSenet.lDovizMiktari2, tbCekSenet.lDovizKuru2,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi,(SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lTahsilat, tbCekSenet.lTutar - (SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lKalan,tbCekSenet.sKullaniciAdi,tbCekSenet.dteKayitTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi")
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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sTarih As String, ByVal sSubeMagaza As String, ByVal sNot As String)
        DataSet1 = stok(ara, konum, ara_kriter, sCekSenetTipi, nCekSenetIslem, nFirmaID, dteBordroTarihi1, dteBordroTarihi2, lBordroNo1, lBordroNo2, sEvrakNo1, sEvrakNo2, sBankaKodu, sHareketTipi, sTarih, sSubeMagaza, sNot)
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
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sVerenFirmaKodu")
            frm.nFirmaID = dr("nVerenID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_fis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Dim frm As New frm_tbCekSenetBordro
            Dim nCekSenetIslem
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sec_sCekSenetTipi.EditValue = dr("sCekSenetTipi")
            frm.sCekSenetTipi = dr("sCekSenetTipi")
            frm.sec_nCekSenetIslem.EditValue = dr("nCekSenetIslem")
            frm.nCekSenetIslem = dr("nCekSenetIslem")
            nCekSenetIslem = dr("nCekSenetIslem")
            frm.sHT = dr("sHareketTipi")
            If nCekSenetIslem = 1 Then
                frm.sCekSenetIslem = "Cüzdana Giriþ"
            ElseIf nCekSenetIslem = 2 Then
                frm.sCekSenetIslem = "Cüzdandan Ýade"
            ElseIf nCekSenetIslem = 3 Then
                frm.sCekSenetIslem = "Banka Tahsile Çýkýþ"
            ElseIf nCekSenetIslem = 4 Then
                frm.sCekSenetIslem = "Banka Teminata Çýkýþ"
            ElseIf nCekSenetIslem = 5 Then
                frm.sCekSenetIslem = "Üçüncü Þahsa Çýkýþ"
            ElseIf nCekSenetIslem = 6 Then
                frm.sCekSenetIslem = "Çýkýþ Ýadesi, Cüzdanda"
            ElseIf nCekSenetIslem = 7 Then
                frm.sCekSenetIslem = "Bankadan Tahsil"
            ElseIf nCekSenetIslem = 8 Then
                frm.sCekSenetIslem = "Cüzdandan Tahsilat"
            ElseIf nCekSenetIslem = 9 Then
                frm.sCekSenetIslem = "Protesto / Karþýlýksýz"
            ElseIf nCekSenetIslem = 10 Then
                frm.sCekSenetIslem = "3. Þahýstan Kapandý"
            ElseIf nCekSenetIslem = 20 Then
                frm.sCekSenetIslem = "Çýkýþ"
            ElseIf nCekSenetIslem = 21 Then
                frm.sCekSenetIslem = "Ödendi"
            ElseIf nCekSenetIslem = 22 Then
                frm.sCekSenetIslem = "Hatalý ,Ýptal , Ýade"
            ElseIf nCekSenetIslem = 23 Then
                frm.sCekSenetIslem = "Protesto / Karþýlýksýz"
            End If
            frm.txt_dteBordroTarihi.EditValue = dr("dteBordroTarihi")
            frm.txt_lBordroNo.EditValue = dr("lBordroNo")
            frm.sKodu = dr("sKodu")
            frm.txt_musteriNo.EditValue = frm.sKodu
            frm.nFirmaId = dr("nFirmaID")
            frm.lbl_Firma.Text = dr("sAciklama")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                ara()
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
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sVerenFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sVerenFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_tbCekSenet_Hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbCekSenet_Hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nCekSenetID = dr("nCekSenetID")
            frm.lCekSenetNo = dr("lCekSenetNo")
            frm.sCekSenetTipi = dr("sCekSenetTipi")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_tbCekSenetHareketleri()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dataload_hareket(dr("sCekSenetTipi"), dr("nCekSenetID"), dr("lCekSenetNo"))
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
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        If nCekSenetIslem <> 0 Then
            dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaID, txt_dteBordroTarihi1.EditValue, txt_dteBordroTarihi2.EditValue, txt_lBordroNo1.EditValue, txt_lBordroNo2.EditValue, txt_sEvrakNo1.EditValue, txt_sEvrakNo2.EditValue, sec_sBankaKodu.EditValue, "", sec_sTarih.Text, sec_sSubeMagaza.EditValue, txt_sNot.Text)
        Else
            dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaID, txt_dteBordroTarihi1.EditValue, txt_dteBordroTarihi2.EditValue, txt_lBordroNo1.EditValue, txt_lBordroNo2.EditValue, txt_sEvrakNo1.EditValue, txt_sEvrakNo2.EditValue, sec_sBankaKodu.EditValue, "", sec_sTarih.Text, sec_sSubeMagaza.EditValue, txt_sNot.Text)
        End If
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub dataload_hareket(ByVal sCekSenetTipi As String, ByVal nCekSenetID As Integer, ByVal lCekSenetNo As Integer)
        DataSet1 = cek(sCekSenetTipi, nCekSenetID, lCekSenetNo)
        GridControl3.DataSource = DataSet1.Tables(0)
        GridControl3.DataMember = Nothing
        GridView3.CollapseAllGroups()
    End Sub
    Public Function cek(ByVal sCekSenetTipi As String, ByVal nCekSenetID As Integer, ByVal lCekSenetNo As Integer) As DataSet
        Dim kriter As String = " WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenet.sBankaKodu = tbBanka.sBankaKodu  AND tbCekSenetIslem.nCekSenetIslem = tbCekSenetBordro.nCekSenetIslem AND (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "')"
        kriter += " and tbCekSenet.lCekSenetNo ='" & lCekSenetNo & "'"
        kriter += " and tbCekSenet.nCekSenetID ='" & nCekSenetID & "'"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.sCekSenetTipi, tbCekSenetIslem.nCekSenetIslem,CONVERT(char(10), tbCekSenetBordro.dteBordroTarihi, 103) + ' ' + tbCekSenetIslem.sAciklama AS Status, tbCekSenetBordro.dteBordroTarihi,tbCekSenetIslem.sAciklama as sIslem,tbCekSenetBordro.lBordroNo, tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbCekSenet.lCekSenetNo, tbBanka.sBankaKodu, tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sBankaHesapNo, tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.dteVadeTarihi, lTutar = CASE WHEN tbCekSenetBordro.lProtestoMasrafi > 0 THEN -(tbCekSenetBordro.lProtestoMasrafi) ELSE tbCekSenet.lTutar END, (DateDiff(Day, tbCekSenetBordro.dteBordroTarihi, tbCekSenet.dteVadeTarihi) * tbCekSenet.lTutar) VadeGun, tbCekSenet.sDovizCinsi1,tbCekSenet.lDovizMiktari1,tbCekSenet.sDovizCinsi2,tbCekSenet.lDovizMiktari2,tbHareketTipi.sHareketTipi, tbHareketTipi.sAciklama AS sHareketAciklama, tbCekSenet.sOrjinalCekSenetNo, sCekSenetKodu1 + (CASE sCekSenetKodu1 WHEN '' THEN '' ELSE ' - ' END) + (SELECT sAciklama FROM tbCekSenetKodu WHERE tbCekSenetKodu.sCekSenetKodu = tbCekSenet.sCekSenetKodu1) AS Kod1, sCekSenetKodu2 + (CASE sCekSenetKodu2 WHEN '' THEN '' ELSE ' - ' END) + (SELECT sAciklama FROM tbCekSenetKodu WHERE tbCekSenetKodu.sCekSenetKodu = tbCekSenet.sCekSenetKodu2) AS Kod2,tbCekSenet.sNot FROM tbCekSenetIslem, tbCekSenetBordro, tbCekSenet, tbFirma, tbBanka, tbHareketTipi " & kriter & " ORDER BY tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, tbCekSenet.dteVadeTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
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
        Dim dteFisTarihi As DateTime = Today
        Dim dr2 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'If GridView2.RowCount = 0 Then
        '    pesinat_satir_ekle(dr2("KALAN"))
        '    GridControl2.Focus()
        '    GridControl2.Select()
        '    GridView1.FocusedRowHandle = 1
        'End If
        'dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                tutar = tutar + dr("lTutar")
                Try
                    gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteVadeTarihi"))
                Catch ex As Exception
                    gun = 0
                End Try
                tutarvade = tutarvade + (dr("lTutar") * gun)
            Next
        End If
        Try
            ortvade = tutarvade / tutar
            lbl_secilen_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            'lbl_odenen.Text = FormatNumber(tutar, 2)
            'lbl_paraustu.Text = "0.00"o
            lbl_gun.Text = CInt(ortvade)
            lbl_ortvade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_secilen_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            'lbl_odenen.Text = FormatNumber(tutar, 2)
            'lbl_paraustu.Text = "0.00"
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
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
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
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.rtf) |*.rtf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.rtf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToRtf(SaveFileDialog1.FileName.ToString)
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
        Try
            analiz_tbCekSenetHareketleri()
        Catch ex As Exception
        End Try
        giris_hesapla()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    lbl_istihbarat.Text = dr("sNot").ToString
        '    dr = Nothing
        'End If
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
        ara()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_Firma_karti()
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
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                analiz_tbCekSenet_Hareket()
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        'analiz_fis()
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_tbCekSenetTipi()
        'dataload_tbCekSenetIslem()
        dataload_tbBankaKodu()
        dataload_tbSube()
        If bHatirlatma = False Then
            txt_dteBordroTarihi1.EditValue = "01/01/2018"
            txt_dteBordroTarihi2.EditValue = "31/12/2078"
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        If txt_ara.Text.ToString <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        'txt_ara.EditValue = ""
        ara()
        'txt_dteFisTarihi1.Focus()
        'txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteBordroTarihi1.Focus()
        txt_dteBordroTarihi1.Select()
    End Sub
    Private Sub sec_sCekSenetTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sCekSenetTipi.EditValueChanged
        gorunum_yukle_grid()
        dataload_tbCekSenetIslem(Trim(sec_sCekSenetTipi.EditValue))
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_tbCekSenet_Hareket()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla_rtf()
    End Sub
    Friend WithEvents collTahsilat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sTarih As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        tahsilat_odeme()
    End Sub
    Private Sub tahsilat_odeme()
        If Trim(sec_sCekSenetTipi.EditValue) = "BC" Or Trim(sec_sCekSenetTipi.EditValue) = "BS" Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Ödeme Ýþlemini Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                CekSenetOdeme()
            End If
        ElseIf Trim(sec_sCekSenetTipi.EditValue) = "AC" Or Trim(sec_sCekSenetTipi.EditValue) = "AS" Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Cüzdandan Tahsilat Ýþlemini Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                CekSenetCuzdandanTahsil()
            End If
        End If
    End Sub
    Private Sub CekSenetBankadanTahsil()
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim dr As DataRow
        Dim lBordroNo As Int64 = 0
        Dim nVerenID As Integer = 0
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView1.GetDataRow(s)
                If dr1("nSonCekSenetIslem") = 3 Then
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID As Int64 = sorgu_nCariHareketID()
                    Dim nCekSenetID As Int64 = sorgu_nCekSenetID()
                    Dim lCekSenetNo As Int64 = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    Dim nKasaIslemID As Int64 = sorgu_nKasaIslemID()
                    If dr1("nVerenID") <> nVerenID Then
                        lBordroNo = sorgu_lBordroNo()
                        nVerenID = dr1("nVerenID")
                    End If
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = dr1("sNot")
                    dr("sIl") = dr1("sIl")
                    dr("sSemt") = dr1("sSemt")
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = dr1("sBorclusu")
                    dr("sBorcluVergiDairesi") = dr1("sBorcluVergiDairesi")
                    dr("sBorcluVergiNumarasi") = dr1("sBorcluVergiNumarasi")
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = 7
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 3
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = 7
                    dr("dteBordroTarihi") = Today
                    dr("lBordroNo") = lBordroNo
                    dr("nFirmaID") = dr1("nVerenID")
                    dr("sFirmaKodu") = ""
                    dr("sKullaniciAdi") = kullanici
                    dr("dteKayitTarihi") = Now
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullanici, Now)
                    nCariHareketID_degistir(dr("nCariHareketID"))
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullanici, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 7)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                End If
            Next
        End If
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        ara()
    End Sub
    Private Sub CekSenetSahistanKapat()
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim dr As DataRow
        Dim lBordroNo As Int64 = 0
        Dim nVerenID As Integer = 0
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView1.GetDataRow(s)
                If dr1("nSonCekSenetIslem") = 5 Then
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID As Int64 = sorgu_nCariHareketID()
                    Dim nCekSenetID As Int64 = sorgu_nCekSenetID()
                    Dim lCekSenetNo As Int64 = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    Dim nKasaIslemID As Int64 = sorgu_nKasaIslemID()
                    If dr1("nVerenID") <> nVerenID Then
                        lBordroNo = sorgu_lBordroNo()
                        nVerenID = dr1("nVerenID")
                    End If
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = dr1("sNot")
                    dr("sIl") = dr1("sIl")
                    dr("sSemt") = dr1("sSemt")
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = dr1("sBorclusu")
                    dr("sBorcluVergiDairesi") = dr1("sBorcluVergiDairesi")
                    dr("sBorcluVergiNumarasi") = dr1("sBorcluVergiNumarasi")
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = 10
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = 10
                    dr("dteBordroTarihi") = Today
                    dr("lBordroNo") = lBordroNo
                    dr("nFirmaID") = dr1("nVerenID")
                    dr("sFirmaKodu") = ""
                    dr("sKullaniciAdi") = kullanici
                    dr("dteKayitTarihi") = Now
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullanici, Now)
                    'nCariHareketID_degistir(nCariHareketID)
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullanici, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), sec_nCekSenetIslem.EditValue)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                End If
            Next
        End If
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        ara()
    End Sub
    Private Sub CekSenetCuzdandanTahsil()
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim dr As DataRow
        Dim lBordroNo As Int64 = 0
        Dim nVerenID As Integer = 0
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView1.GetDataRow(s)
                If dr1("nSonCekSenetIslem") = 1 Then
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID As Int64 = sorgu_nCariHareketID()
                    Dim nCekSenetID As Int64 = sorgu_nCekSenetID()
                    Dim lCekSenetNo As Int64 = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    Dim nKasaIslemID As Int64 = sorgu_nKasaIslemID()
                    If dr1("nVerenID") <> nVerenID Then
                        lBordroNo = sorgu_lBordroNo()
                        nVerenID = dr1("nVerenID")
                    End If
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = ""
                    dr("sSemt") = ""
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = 1
                    dr("nCariHareketID") = 0
                    dr("nKasaIslemID") = nKasaIslemID
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1 'dr1("nSonCekSenetIslem")
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = 8
                    dr("dteBordroTarihi") = Today
                    dr("lBordroNo") = lBordroNo
                    dr("nFirmaID") = dr1("nVerenID")
                    dr("sFirmaKodu") = dr1("sVerenFirmaKodu")
                    dr("sKullaniciAdi") = kullanici
                    dr("dteKayitTarihi") = Now
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    nKasaIslemID = tbNakitKasa_kaydet_yeni(dr("nKasaIslemID"), "001", dr("dteBordroTarihi"), dr("lTutar"), 0, sAciklama, 0, dr("nFirmaID"), 0, "AC", dr("sHareketTipi"), kullanici, dr("dteKayitTarihi"), 0, "", "", 0, 0, "", 0, 0, kullanici, dr("dteKayitTarihi"))
                    nKasaIslemID_degistir(nKasaIslemID)
                    dr("nKasaIslemID") = nKasaIslemID
                    'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullanici, Now)
                    'nCariHareketID_degistir(nCariHareketID)
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullanici, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), dr("nKasaIslemID"), dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 8)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Else
                    XtraMessageBox.Show(dr1("lCekSenetNo") & Sorgu_sDil(" Seçmiþ Oldugunuz Kayit Cuzdanda Degil...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Next
        End If
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        ara()
    End Sub
    Private Sub CekSenetOdeme()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        Dim pass As Boolean = False
        frm.sModul = "CekSenetBordroBanka"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            Dim nBorcluFirmaID As Int64 = dr1("nFirmaID")
            Dim sBorcluKodu As String = dr1("sKodu")
            Dim sBorcluAciklama As String = dr1("sAciklama")
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim lBordroNo As Int64 = 0
            Dim nVerenID As Integer = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    If dr1("nSonCekSenetIslem") = 20 Then
                        dr = ds_tbCekSenet.Tables(0).NewRow
                        Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                        Dim nCariHareketID = sorgu_nCariHareketID()
                        Dim nCekSenetID = sorgu_nCekSenetID()
                        Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                        If dr1("nVerenID") <> nVerenID Then
                            lBordroNo = sorgu_lBordroNo()
                            nVerenID = dr1("nVerenID")
                        End If
                        dr("nBordroSatirID") = nBordroSatirID
                        dr("nCekSenetID") = dr1("nCekSenetID")
                        dr("lCekSenetNo") = dr1("lCekSenetNo")
                        dr("lTutar") = dr1("lTutar")
                        dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                        dr("sHareketTipi") = dr1("sHareketTipi")
                        dr("sNot") = ""
                        dr("sIl") = ""
                        dr("sSemt") = ""
                        dr("sKarsiTarafCekSenetNo") = ""
                        dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                        dr("sBankaKodu") = dr1("sBankaKodu")
                        dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                        dr("sBankaSubeNo") = ""
                        dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                        dr("nVerenID") = dr1("nVerenID")
                        dr("bKendineAit") = 0
                        dr("sBorclusu") = ""
                        dr("sBorcluVergiDairesi") = ""
                        dr("sBorcluVergiNumarasi") = ""
                        dr("nSonBordroSatirID") = nBordroSatirID
                        dr("nSonCekSenetIslem") = 20
                        dr("nCariHareketID") = 0
                        dr("nKasaIslemID") = 0
                        dr("nBorcluFirmaID") = nBorcluFirmaID
                        dr("nBorcluCariHareketID") = nCariHareketID
                        dr("nProtestoMasrafiFirmaID") = 0
                        dr("nProtestoMasrafiCariHareketID") = 0
                        dr("lProtestoMasrafi") = 0
                        dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                        dr("nOncekiCekSenetIslem") = 20
                        dr("dteValorTarihi") = dr1("dteVadeTarihi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                        dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                        dr("lDovizKuru1") = dr1("lDovizKuru1")
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("sCekSenetKodu1") = ""
                        dr("sCekSenetKodu2") = ""
                        dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                        dr("nCekSenetIslem") = 24
                        dr("dteBordroTarihi") = Today
                        dr("lBordroNo") = lBordroNo
                        dr("nFirmaID") = dr1("nVerenID")
                        dr("sFirmaKodu") = sBorcluKodu
                        dr("sKullaniciAdi") = kullanici
                        dr("dteKayitTarihi") = Now
                        Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                        dr("nBorcluCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nBorcluCariHareketID"), dr("nBorcluFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullanici, Now)
                        nCariHareketID_degistir(dr("nBorcluCariHareketID"))
                        'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullanici, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                        dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                        'nCekSenetID_degistir(nCekSenetID)
                        nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 24)
                        nBordroSatirID_degistir(dr("nBordroSatirID"))
                        ds_tbCekSenet.Tables(0).Rows.Add(dr)
                    Else
                        XtraMessageBox.Show(dr1("lCekSenetNo") & Sorgu_sDil(" Seçmiþ Oldugunuz Kayýt Cýkýþ Pozisyonunda Deðil...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Next
            End If
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ara()
        End If
    End Sub
    Private Sub CekSenetTahsileVer()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        Dim pass As Boolean = False
        frm.sModul = "tbCekSenetBordro"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            Dim nBorcluFirmaID As Int64 = dr1("nFirmaID")
            Dim sBorcluKodu As String = dr1("sKodu")
            Dim sBorcluAciklama As String = dr1("sAciklama")
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim lBordroNo As Int64 = 0
            Dim nVerenID As Integer = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    If dr1("nSonCekSenetIslem") = 1 Then
                        dr = ds_tbCekSenet.Tables(0).NewRow
                        Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                        Dim nCariHareketID = sorgu_nCariHareketID()
                        Dim nCekSenetID = sorgu_nCekSenetID()
                        Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                        If dr1("nVerenID") <> nVerenID Then
                            lBordroNo = sorgu_lBordroNo()
                            nVerenID = dr1("nVerenID")
                        End If
                        dr("nBordroSatirID") = nBordroSatirID
                        dr("nCekSenetID") = dr1("nCekSenetID")
                        dr("lCekSenetNo") = dr1("lCekSenetNo")
                        dr("lTutar") = dr1("lTutar")
                        dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                        dr("sHareketTipi") = dr1("sHareketTipi")
                        dr("sNot") = ""
                        dr("sIl") = ""
                        dr("sSemt") = ""
                        dr("sKarsiTarafCekSenetNo") = ""
                        dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                        dr("sBankaKodu") = dr1("sBankaKodu")
                        dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                        dr("sBankaSubeNo") = ""
                        dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                        dr("nVerenID") = dr1("nVerenID")
                        dr("bKendineAit") = 0
                        dr("sBorclusu") = ""
                        dr("sBorcluVergiDairesi") = ""
                        dr("sBorcluVergiNumarasi") = ""
                        dr("nSonBordroSatirID") = nBordroSatirID
                        dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                        dr("nCariHareketID") = 0
                        dr("nKasaIslemID") = 0
                        dr("nBorcluFirmaID") = nBorcluFirmaID
                        dr("nBorcluCariHareketID") = nCariHareketID
                        dr("nProtestoMasrafiFirmaID") = 0
                        dr("nProtestoMasrafiCariHareketID") = 0
                        dr("lProtestoMasrafi") = 0
                        dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                        dr("nOncekiCekSenetIslem") = 1
                        dr("dteValorTarihi") = dr1("dteVadeTarihi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                        dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                        dr("lDovizKuru1") = dr1("lDovizKuru1")
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("sCekSenetKodu1") = ""
                        dr("sCekSenetKodu2") = ""
                        dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                        dr("nCekSenetIslem") = 3
                        dr("dteBordroTarihi") = Today
                        dr("lBordroNo") = lBordroNo
                        dr("nFirmaID") = dr1("nVerenID")
                        dr("sFirmaKodu") = sBorcluKodu
                        dr("sKullaniciAdi") = kullanici
                        dr("dteKayitTarihi") = Now
                        Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                        dr("nBorcluCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nBorcluCariHareketID"), dr("nBorcluFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullanici, Now)
                        nCariHareketID_degistir(dr("nBorcluCariHareketID"))
                        'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullanici, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                        dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                        'nCekSenetID_degistir(nCekSenetID)
                        nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 21)
                        nBordroSatirID_degistir(dr("nBordroSatirID"))
                        ds_tbCekSenet.Tables(0).Rows.Add(dr)
                    End If
                Next
            End If
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ara()
        End If
    End Sub
    Private Sub CekSenetTakasaVer()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        Dim pass As Boolean = False
        frm.sModul = "tbCekSenetBordro"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            Dim nBorcluFirmaID As Int64 = dr1("nFirmaID")
            Dim sBorcluKodu As String = dr1("sKodu")
            Dim sBorcluAciklama As String = dr1("sAciklama")
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim lBordroNo As Int64 = 0
            Dim nVerenID As Integer = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    If dr1("nSonCekSenetIslem") = 1 Then
                        dr = ds_tbCekSenet.Tables(0).NewRow
                        Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                        Dim nCariHareketID = 0 'sorgu_nCariHareketID()
                        Dim nCekSenetID = sorgu_nCekSenetID()
                        Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                        If dr1("nVerenID") <> nVerenID Then
                            lBordroNo = sorgu_lBordroNo()
                            nVerenID = dr1("nVerenID")
                        End If
                        dr("nBordroSatirID") = nBordroSatirID
                        dr("nCekSenetID") = dr1("nCekSenetID")
                        dr("lCekSenetNo") = dr1("lCekSenetNo")
                        dr("lTutar") = dr1("lTutar")
                        dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                        dr("sHareketTipi") = dr1("sHareketTipi")
                        dr("sNot") = ""
                        dr("sIl") = ""
                        dr("sSemt") = ""
                        dr("sKarsiTarafCekSenetNo") = ""
                        dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                        dr("sBankaKodu") = dr1("sBankaKodu")
                        dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                        dr("sBankaSubeNo") = ""
                        dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                        dr("nVerenID") = dr1("nVerenID")
                        'dr("nVerenID") = nBorcluFirmaID
                        dr("bKendineAit") = 0
                        dr("sBorclusu") = ""
                        dr("sBorcluVergiDairesi") = ""
                        dr("sBorcluVergiNumarasi") = ""
                        dr("nSonBordroSatirID") = nBordroSatirID
                        dr("nSonCekSenetIslem") = 3
                        dr("nCariHareketID") = 0
                        dr("nKasaIslemID") = 0
                        dr("nBorcluFirmaID") = nBorcluFirmaID
                        dr("nBorcluCariHareketID") = nCariHareketID
                        dr("nProtestoMasrafiFirmaID") = 0
                        dr("nProtestoMasrafiCariHareketID") = 0
                        dr("lProtestoMasrafi") = 0
                        dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                        dr("nOncekiCekSenetIslem") = 1
                        dr("dteValorTarihi") = dr1("dteVadeTarihi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                        dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                        dr("lDovizKuru1") = dr1("lDovizKuru1")
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("sCekSenetKodu1") = ""
                        dr("sCekSenetKodu2") = ""
                        dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                        dr("nCekSenetIslem") = 3
                        dr("dteBordroTarihi") = Today
                        dr("lBordroNo") = lBordroNo
                        dr("nFirmaID") = nBorcluFirmaID
                        dr("sFirmaKodu") = sBorcluKodu
                        dr("sKullaniciAdi") = kullanici
                        dr("dteKayitTarihi") = Now
                        Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                        'tbFirmaHareketi_kaydet_yeni(dr("nBorcluCariHareketID"), dr("nBorcluFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullanici, Now)
                        'nCariHareketID_degistir(nCariHareketID)
                        'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullanici, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                        dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                        'nCekSenetID_degistir(nCekSenetID)
                        nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 3)
                        nBordroSatirID_degistir(dr("nBordroSatirID"))
                        ds_tbCekSenet.Tables(0).Rows.Add(dr)
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Seçmiþ Oldugunuz Kayit Cuzdanda Degil...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Next
            End If
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ara()
        End If
    End Sub
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
    End Function
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        nCariHareketID = "NULL"
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = cmd.ExecuteScalar
        Return nKasaIslemID
        con.Close()
    End Function
    Private Sub nKasaIslemID_degistir(ByVal nKasaIslemID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nKasaIslemID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbCekSenetBordro_kaydet_yeni(ByVal nBordroSatirID As Int64, ByVal nCekSenetIslem As Int64, ByVal nFirmaID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal nCekSenetID As Int64, ByVal nOncekiBordroSatirID As Int64, ByVal nOncekiCekSenetIslem As Int64, ByVal nCariHareketID As Int64, ByVal nKasaIslemID As String, ByVal nBorcluFirmaID As Int64, ByVal nBorcluCariHareketID As String, ByVal nProtestoMasrafiFirmaID As Int64, ByVal nProtestoMasrafiCariHareketID As String, ByVal lProtestoMasrafi As Decimal, ByVal dteValorTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        If nProtestoMasrafiCariHareketID = "" Then
            nProtestoMasrafiCariHareketID = "NULL"
        End If
        If nKasaIslemID = "" Then
            nKasaIslemID = "NULL"
        End If
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nCekSenetIslem = 21 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nBorcluFirmaID, nBorcluCariHareketID,nProtestoMasrafiFirmaID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", NULL, " & nBorcluFirmaID & ", " & nBorcluCariHareketID & " ," & nProtestoMasrafiFirmaID & ", " & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nKasaIslemID,nBorcluFirmaID, nProtestoMasrafiFirmaID,nProtestoMasrafiCariHareketID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", " & nCariHareketID & "," & nKasaIslemID & ", " & nBorcluFirmaID & ", " & nProtestoMasrafiFirmaID & ", " & nProtestoMasrafiCariHareketID & "," & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nBordroSatirID = cmd.ExecuteScalar
        Return nBordroSatirID
        con.Close()
    End Function
    Private Sub nBordroSatirID_degistir(ByVal nSonID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetSiraNo SET              nSonID =" & nSonID & " WHERE     (nSiraIndex = 2)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCekSenetID_Odeme_degistir(ByVal nCekSenetID As String, ByVal nSonBordroSatirID As String, ByVal nSonCekSenetIslem As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenet SET              nSonBordroSatirID = " & nSonBordroSatirID & ",nSonCekSenetIslem = " & nSonCekSenetIslem & " WHere nCekSenetID = " & nCekSenetID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nBordroSatirID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nBordroSatirID + 1, 1) AS nBordroSatirID FROM tbCekSenetBordro ORDER BY nBordroSatirID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'If kayitsayisi = 0 Then
        '    kayitsayisi = 1
        'End If
        'Return kayitsayisi
        Return 1
    End Function
    Public Function sorgu_nCekSenetID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nCekSenetID + 1, 1) AS nCekSenetID FROM tbCekSenet ORDER BY nCekSenetID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nKasaIslemID + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa " & kriter & " ORDER BY nKasaIslemID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lCekSenetNo(ByVal sCekSenetTipi As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lCekSenetNo + 1, 1) AS lCekSenetNo FROM tbCekSenet Where sCekSenetTipi = '" & sCekSenetTipi & "' ORDER BY lCekSenetNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lBordroNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lBordroNo + 1, 1) AS lBordroNo FROM tbCekSenetBordro ORDER BY lBordroNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_sBankaAdi(ByVal sBankaKodu As String) As String
        Dim dr As DataRow
        Dim sAciklama As String = ""
        For Each dr In ds_tbBankaKodu.Tables(0).Rows
            If Trim(dr("sBankaKodu")) = Trim(sBankaKodu) Then
                sAciklama = dr("sAciklama")
            End If
        Next
        Return sAciklama
    End Function
    Public Function sorgu_sCekSenetIslem(ByVal nCekSenetIslem As String) As String
        Dim dr As DataRow
        Dim sAciklama As String = ""
        For Each dr In ds_tbCekSenetIslem.Tables(0).Rows
            If Trim(dr("nCekSenetIslem")) = Trim(nCekSenetIslem) Then
                sAciklama = dr("sAciklama")
            End If
        Next
        Return sAciklama
    End Function
    Public Function sorgu_sCekSenetAciklama(ByVal sCekSenetTipi As String) As String
        Dim dr As DataRow
        Dim sAciklama As String = ""
        For Each dr In ds_tbCekSenetTipi.Tables(0).Rows
            If Trim(dr("sCekSenetTipi")) = Trim(sCekSenetTipi) Then
                sAciklama = dr("sAciklama")
            End If
        Next
        Return sAciklama
    End Function
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        kapat()
    End Sub
    Private Sub kapat()
        If Trim(sec_sCekSenetTipi.EditValue) = "BC" Or Trim(sec_sCekSenetTipi.EditValue) = "BS" Then
            'If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Ödeme Ýþlemini Yapmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            '    'CekSenetOdeme()
            'End If
        ElseIf Trim(sec_sCekSenetTipi.EditValue) = "AC" Or Trim(sec_sCekSenetTipi.EditValue) = "AS" Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Kapatma Ýþlemini Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                CekSenetSahistanKapat()
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        bankadantahsil()
    End Sub
    Private Sub bankadantahsil()
        If Trim(sec_sCekSenetTipi.EditValue) = "BC" Or Trim(sec_sCekSenetTipi.EditValue) = "BS" Then
            'If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Ödeme Ýþlemini Yapmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            '    'CekSenetOdeme()
            'End If
        ElseIf Trim(sec_sCekSenetTipi.EditValue) = "AC" Or Trim(sec_sCekSenetTipi.EditValue) = "AS" Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Bankadan Tahsilat Ýþlemini Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'CekSenetBankadanTahsil()
            End If
        End If
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        tahsilat_odeme()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        kapat()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        bankadantahsil()
    End Sub
    Private Sub MenuItem17_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If Trim(sec_sCekSenetTipi.EditValue) = "AC" Or Trim(sec_sCekSenetTipi.EditValue) = "AS" Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Tahsilata Verme Ýþlemini Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                CekSenetTakasaVer()
            End If
        End If
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        If Trim(sec_sCekSenetTipi.EditValue) = "AC" Or Trim(sec_sCekSenetTipi.EditValue) = "AS" Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Çek/Senetlerin Tahsilata Verme Ýþlemini Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                CekSenetTakasaVer()
            End If
        End If
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_nCekSenetIslem.QueryPopUp
        sec_nCekSenetIslem.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_nCekSenetIslem.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
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
    Private Sub GridView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView3.DoubleClick
        analiz_fis()
    End Sub
    Private Sub GridView3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView3.KeyDown
        If e.KeyCode = Keys.Enter Then
            analiz_fis()
        End If
    End Sub
    Friend WithEvents colnOpsiyon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGecikme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSonSonIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteDuzenlemeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sNot As DevExpress.XtraEditors.TextEdit
End Class
