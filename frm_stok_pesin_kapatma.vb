Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_pesin_kapatma
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ds_odeme As System.Data.DataSet
    Friend WithEvents ds_taksit As System.Data.DataSet
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
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colnTaksitID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_sayi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_tutar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btn_ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_sOdemeSekli As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kisayol_odeme As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_taksit As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents lblTaksit_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_vade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taksit_tutari As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taksit_sayisi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pesinat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Satis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_tutar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents sec_taksit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sAralik As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_pesin_kapatma))
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim SuperToolTip31 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem31 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem31 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip32 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem32 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem32 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip33 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem33 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem33 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip34 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem34 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem34 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip35 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem35 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem35 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip36 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem36 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem36 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.lblTaksit_info = New DevExpress.XtraEditors.LabelControl
        Me.label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.kisayol_taksit = New System.Windows.Forms.ContextMenu
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.ds_taksit = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnTaksitID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnAlisverisID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_taksit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sAralik = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.btn_ekle = New DevExpress.XtraEditors.SimpleButton
        Me.txt_tutar = New DevExpress.XtraEditors.CalcEdit
        Me.txt_sayi = New DevExpress.XtraEditors.SpinEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_vade = New DevExpress.XtraEditors.LabelControl
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl
        Me.lbl_taksit_tutari = New DevExpress.XtraEditors.LabelControl
        Me.lbl_taksit_sayisi = New DevExpress.XtraEditors.LabelControl
        Me.lbl_pesinat = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Satis = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.kisayol_odeme = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.ds_odeme = New System.Data.DataSet
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnOdemeID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsOdemeSekli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sOdemeSekli = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colnOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteOdemeTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_tutar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sDovizCinsi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.collDovizTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMakbuzNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOdemeNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnTaksitID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnIadeAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbMuhasebeyeIslendimi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKartNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_taksit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_taksit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_sAralik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sayi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ShowInCustomizationForm = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(373, 56)
        Me.ToolTipController1.SetSuperTip(Me.PanelControl1, Nothing)
        Me.PanelControl1.TabIndex = 2
        Me.PanelControl1.Text = "PanelControl1"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 52)
        Me.ToolTipController1.SetSuperTip(Me.Label1, Nothing)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Satýþ Kapatma iþlemi aþaðýdaki gibi yapýlmýþtýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ToolTipController1.SetSuperTip(Me.PictureBox1, Nothing)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblTaksit_info)
        Me.PanelControl2.Controls.Add(Me.label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 558)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(373, 48)
        Me.ToolTipController1.SetSuperTip(Me.PanelControl2, Nothing)
        Me.PanelControl2.TabIndex = 1
        Me.PanelControl2.Text = "PanelControl2"
        '
        'lblTaksit_info
        '
        Me.lblTaksit_info.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblTaksit_info.Appearance.Options.UseForeColor = True
        Me.lblTaksit_info.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblTaksit_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTaksit_info.Location = New System.Drawing.Point(2, 33)
        Me.lblTaksit_info.Name = "lblTaksit_info"
        Me.lblTaksit_info.Size = New System.Drawing.Size(18, 13)
        Me.lblTaksit_info.TabIndex = 6
        Me.lblTaksit_info.Text = "***"
        '
        'label2
        '
        Me.label2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.label2.Appearance.Options.UseFont = True
        Me.label2.Appearance.Options.UseForeColor = True
        Me.label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.label2.Location = New System.Drawing.Point(2, 2)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(27, 19)
        Me.label2.TabIndex = 4
        Me.label2.Text = "***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(292, 7)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(212, 7)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(373, 502)
        Me.ToolTipController1.SetSuperTip(Me.PanelControl3, Nothing)
        Me.PanelControl3.TabIndex = 0
        Me.PanelControl3.Text = "PanelControl3"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.GridControl3)
        Me.GroupControl2.Controls.Add(Me.PanelControl4)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 138)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(369, 320)
        Me.ToolTipController1.SetSuperTip(Me.GroupControl2, Nothing)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Taksitlendirme Bu Bölümde Yapýlýr..."
        Me.ToolTipController1.SetTitle(Me.GroupControl2, "Taksitlendirme Ýþlemleri")
        Me.ToolTipController1.SetToolTip(Me.GroupControl2, resources.GetString("GroupControl2.ToolTip"))
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.kisayol_taksit
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.ds_taksit
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(2, 64)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_taksit})
        Me.GridControl3.Size = New System.Drawing.Size(365, 254)
        Me.GridControl3.TabIndex = 1
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'kisayol_taksit
        '
        Me.kisayol_taksit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem4, Me.MenuItem5, Me.MenuItem9, Me.MenuItem6, Me.MenuItem22, Me.MenuItem8, Me.MenuItem7, Me.MenuItem16, Me.MenuItem15, Me.MenuItem17})
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem19.Text = "Tamam"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem20.Text = "Vazgec"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 2
        Me.MenuItem21.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem4.Text = "Satýr Ekle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem5.Text = "Satýr Düzelt"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 5
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem9.Text = "Deðer Yay"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem6.Text = "Satýr Sil"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 7
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.MenuItem22.Text = "Ödeme Planýný Aktar"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 8
        Me.MenuItem8.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 9
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.AltF9
        Me.MenuItem7.Text = "Satýrlarý Sil"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 10
        Me.MenuItem16.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 11
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem15.Text = "Pesinat Bolumu"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 12
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Toplu Taksitlendir"
        '
        'ds_taksit
        '
        Me.ds_taksit.DataSetName = "NewDataSet"
        Me.ds_taksit.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_taksit.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "nTaksitID"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nAlisverisID"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "dteTarihi"
        Me.DataColumn23.DataType = GetType(Date)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "lTutari"
        Me.DataColumn24.DataType = GetType(Decimal)
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnTaksitID1, Me.colnAlisverisID1, Me.coldteTarihi, Me.collTutari, Me.colStatus})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colStatus
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Tag = "1"
        StyleFormatCondition2.Value1 = "1"
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colnTaksitID1
        '
        Me.colnTaksitID1.Caption = "TaksitID"
        Me.colnTaksitID1.FieldName = "nTaksitID"
        Me.colnTaksitID1.Name = "colnTaksitID1"
        Me.colnTaksitID1.OptionsColumn.AllowFocus = False
        '
        'colnAlisverisID1
        '
        Me.colnAlisverisID1.Caption = "Alýþveriþ ID"
        Me.colnAlisverisID1.FieldName = "nAlisverisID"
        Me.colnAlisverisID1.Name = "colnAlisverisID1"
        Me.colnAlisverisID1.OptionsColumn.AllowFocus = False
        '
        'coldteTarihi
        '
        Me.coldteTarihi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.coldteTarihi.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.coldteTarihi.AppearanceCell.Options.UseFont = True
        Me.coldteTarihi.AppearanceCell.Options.UseForeColor = True
        Me.coldteTarihi.Caption = "Tarih"
        Me.coldteTarihi.DisplayFormat.FormatString = "D"
        Me.coldteTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.coldteTarihi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 0
        '
        'collTutari
        '
        Me.collTutari.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collTutari.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.collTutari.AppearanceCell.Options.UseFont = True
        Me.collTutari.AppearanceCell.Options.UseForeColor = True
        Me.collTutari.Caption = "Tutarý"
        Me.collTutari.ColumnEdit = Me.sec_taksit
        Me.collTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutari.FieldName = "lTutari"
        Me.collTutari.Name = "collTutari"
        Me.collTutari.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.collTutari.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.collTutari.Visible = True
        Me.collTutari.VisibleIndex = 1
        '
        'sec_taksit
        '
        Me.sec_taksit.AutoHeight = False
        Me.sec_taksit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_taksit.DisplayFormat.FormatString = "#,0.00"
        Me.sec_taksit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_taksit.EditFormat.FormatString = "#,0.00##"
        Me.sec_taksit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_taksit.Name = "sec_taksit"
        Me.sec_taksit.NullText = "0.00"
        Me.sec_taksit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.LabelControl10)
        Me.PanelControl4.Controls.Add(Me.sec_sAralik)
        Me.PanelControl4.Controls.Add(Me.LabelControl9)
        Me.PanelControl4.Controls.Add(Me.LabelControl8)
        Me.PanelControl4.Controls.Add(Me.LabelControl7)
        Me.PanelControl4.Controls.Add(Me.btn_ekle)
        Me.PanelControl4.Controls.Add(Me.txt_tutar)
        Me.PanelControl4.Controls.Add(Me.txt_sayi)
        Me.PanelControl4.Controls.Add(Me.DateEdit1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(365, 44)
        Me.ToolTipController1.SetSuperTip(Me.PanelControl4, Nothing)
        Me.PanelControl4.TabIndex = 0
        Me.PanelControl4.Text = "PanelControl4"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(163, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl10.TabIndex = 11
        Me.LabelControl10.Text = "Aralýk"
        '
        'sec_sAralik
        '
        Me.sec_sAralik.EditValue = "Ay"
        Me.sec_sAralik.EnterMoveNextControl = True
        Me.sec_sAralik.Location = New System.Drawing.Point(163, 20)
        Me.sec_sAralik.Name = "sec_sAralik"
        Me.sec_sAralik.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sAralik.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sAralik.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_sAralik.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sAralik.Properties.Appearance.Options.UseFont = True
        Me.sec_sAralik.Properties.Appearance.Options.UseForeColor = True
        Me.sec_sAralik.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sAralik.Properties.Items.AddRange(New Object() {"Gün", "Hafta", "Ay", "3Ay", "Yýl"})
        Me.sec_sAralik.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sAralik.Size = New System.Drawing.Size(69, 20)
        Me.sec_sAralik.TabIndex = 2
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(231, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl9.TabIndex = 9
        Me.LabelControl9.Text = "Tutar"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(107, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "Sayý"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl7.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisPath
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(9, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Baþlangýç Tarihi"
        '
        'btn_ekle
        '
        Me.btn_ekle.Image = CType(resources.GetObject("btn_ekle.Image"), System.Drawing.Image)
        Me.btn_ekle.Location = New System.Drawing.Point(308, 20)
        Me.btn_ekle.Name = "btn_ekle"
        Me.btn_ekle.Size = New System.Drawing.Size(53, 20)
        Me.btn_ekle.TabIndex = 3
        Me.btn_ekle.Text = "Ekle"
        '
        'txt_tutar
        '
        Me.txt_tutar.EnterMoveNextControl = True
        Me.txt_tutar.Location = New System.Drawing.Point(231, 20)
        Me.txt_tutar.Name = "txt_tutar"
        Me.txt_tutar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tutar.Properties.NullText = "0.00"
        Me.txt_tutar.Size = New System.Drawing.Size(75, 20)
        Me.txt_tutar.TabIndex = 3
        '
        'txt_sayi
        '
        Me.txt_sayi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sayi.EnterMoveNextControl = True
        Me.txt_sayi.Location = New System.Drawing.Point(107, 20)
        Me.txt_sayi.Name = "txt_sayi"
        Me.txt_sayi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_sayi.Size = New System.Drawing.Size(57, 20)
        Me.txt_sayi.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(8, 20)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.lbl_vade)
        Me.PanelControl5.Controls.Add(Me.lbl_gun)
        Me.PanelControl5.Controls.Add(Me.lbl_taksit_tutari)
        Me.PanelControl5.Controls.Add(Me.lbl_taksit_sayisi)
        Me.PanelControl5.Controls.Add(Me.lbl_pesinat)
        Me.PanelControl5.Controls.Add(Me.lbl_Satis)
        Me.PanelControl5.Controls.Add(Me.LabelControl6)
        Me.PanelControl5.Controls.Add(Me.LabelControl5)
        Me.PanelControl5.Controls.Add(Me.LabelControl4)
        Me.PanelControl5.Controls.Add(Me.LabelControl3)
        Me.PanelControl5.Controls.Add(Me.LabelControl2)
        Me.PanelControl5.Controls.Add(Me.LabelControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(2, 458)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(369, 42)
        Me.ToolTipController1.SetSuperTip(Me.PanelControl5, Nothing)
        Me.PanelControl5.TabIndex = 2
        Me.PanelControl5.Text = "PanelControl5"
        '
        'lbl_vade
        '
        Me.lbl_vade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_vade.Appearance.Options.UseFont = True
        Me.lbl_vade.Appearance.Options.UseTextOptions = True
        Me.lbl_vade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_vade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_vade.Location = New System.Drawing.Point(318, 24)
        Me.lbl_vade.Name = "lbl_vade"
        Me.lbl_vade.Size = New System.Drawing.Size(13, 13)
        Me.lbl_vade.TabIndex = 25
        Me.lbl_vade.Text = "%"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.Options.UseFont = True
        Me.lbl_gun.Appearance.Options.UseTextOptions = True
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(318, 8)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(13, 13)
        Me.lbl_gun.TabIndex = 24
        Me.lbl_gun.Text = "%"
        '
        'lbl_taksit_tutari
        '
        Me.lbl_taksit_tutari.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_taksit_tutari.Appearance.Options.UseFont = True
        Me.lbl_taksit_tutari.Appearance.Options.UseTextOptions = True
        Me.lbl_taksit_tutari.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_taksit_tutari.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_taksit_tutari.Location = New System.Drawing.Point(193, 24)
        Me.lbl_taksit_tutari.Name = "lbl_taksit_tutari"
        Me.lbl_taksit_tutari.Size = New System.Drawing.Size(13, 13)
        Me.lbl_taksit_tutari.TabIndex = 23
        Me.lbl_taksit_tutari.Text = "%"
        '
        'lbl_taksit_sayisi
        '
        Me.lbl_taksit_sayisi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_taksit_sayisi.Appearance.Options.UseFont = True
        Me.lbl_taksit_sayisi.Appearance.Options.UseTextOptions = True
        Me.lbl_taksit_sayisi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_taksit_sayisi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_taksit_sayisi.Location = New System.Drawing.Point(193, 8)
        Me.lbl_taksit_sayisi.Name = "lbl_taksit_sayisi"
        Me.lbl_taksit_sayisi.Size = New System.Drawing.Size(13, 13)
        Me.lbl_taksit_sayisi.TabIndex = 22
        Me.lbl_taksit_sayisi.Text = "%"
        '
        'lbl_pesinat
        '
        Me.lbl_pesinat.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_pesinat.Appearance.Options.UseFont = True
        Me.lbl_pesinat.Appearance.Options.UseTextOptions = True
        Me.lbl_pesinat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_pesinat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_pesinat.Location = New System.Drawing.Point(67, 24)
        Me.lbl_pesinat.Name = "lbl_pesinat"
        Me.lbl_pesinat.Size = New System.Drawing.Size(13, 13)
        Me.lbl_pesinat.TabIndex = 21
        Me.lbl_pesinat.Text = "%"
        '
        'lbl_Satis
        '
        Me.lbl_Satis.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Satis.Appearance.Options.UseFont = True
        Me.lbl_Satis.Appearance.Options.UseTextOptions = True
        Me.lbl_Satis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Satis.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Satis.Location = New System.Drawing.Point(67, 8)
        Me.lbl_Satis.Name = "lbl_Satis"
        Me.lbl_Satis.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Satis.TabIndex = 20
        Me.lbl_Satis.Text = "%"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(254, 24)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "OrtVade:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(254, 8)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "OrtGün:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(128, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "TaksitTutarý:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(128, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "TaksitSayýsý:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(6, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Peþinat:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(6, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "SatýþTutarý:"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Purple
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.GridControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(369, 136)
        Me.ToolTipController1.SetSuperTip(Me.GroupControl1, Nothing)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Peþinatlar bu Bölüme Girilir..."
        Me.ToolTipController1.SetTitle(Me.GroupControl1, "Alýnan Peþinatlar Buraya Girilir")
        Me.ToolTipController1.SetToolTip(Me.GroupControl1, resources.GetString("GroupControl1.ToolTip"))
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_odeme
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_odeme
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sOdemeSekli, Me.sec_sDovizCinsi, Me.sec_tutar})
        Me.GridControl2.Size = New System.Drawing.Size(365, 114)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_odeme
        '
        Me.kisayol_odeme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem12, Me.MenuItem10, Me.MenuItem11, Me.MenuItem14, Me.MenuItem13, Me.MenuItem18})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Satýr Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Satýr Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Satýr Sil"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 4
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem10.Text = "Tamam"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 5
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem11.Text = "Vazgeç"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 6
        Me.MenuItem14.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 7
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem13.Text = "Taksit Bolumu"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 8
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Toplu Taksitlendir"
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
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnOdemeID, Me.colnAlisverisID, Me.colsOdemeSekli, Me.colnOdemeKodu, Me.colsKasiyerRumuzu, Me.coldteOdemeTarihi, Me.coldteValorTarihi, Me.collOdemeTutar, Me.colsDovizCinsi, Me.collDovizTutar, Me.collMakbuzNo, Me.collOdemeNo, Me.colnTaksitID, Me.colnIadeAlisverisID, Me.colbMuhasebeyeIslendimi, Me.colnKasaNo, Me.colsKartNo, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colsMagaza})
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
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
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
        Me.colnAlisverisID.Caption = "Alýþveriþ ID"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        Me.colnAlisverisID.OptionsColumn.AllowEdit = False
        '
        'colsOdemeSekli
        '
        Me.colsOdemeSekli.Caption = "Ödeme Þekli"
        Me.colsOdemeSekli.ColumnEdit = Me.sec_sOdemeSekli
        Me.colsOdemeSekli.FieldName = "sOdemeSekli"
        Me.colsOdemeSekli.Name = "colsOdemeSekli"
        Me.colsOdemeSekli.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.colsOdemeSekli.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colsOdemeSekli.Visible = True
        Me.colsOdemeSekli.VisibleIndex = 0
        Me.colsOdemeSekli.Width = 94
        '
        'sec_sOdemeSekli
        '
        Me.sec_sOdemeSekli.AutoHeight = False
        Me.sec_sOdemeSekli.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeSekli.DisplayMember = "sOdemeSekli"
        Me.sec_sOdemeSekli.Name = "sec_sOdemeSekli"
        Me.sec_sOdemeSekli.NullText = "[ÖdemeÞekli]"
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
        Me.collOdemeTutar.Caption = "Ödeme Tutarý"
        Me.collOdemeTutar.ColumnEdit = Me.sec_tutar
        Me.collOdemeTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.collOdemeTutar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.collOdemeTutar.Visible = True
        Me.collOdemeTutar.VisibleIndex = 1
        Me.collOdemeTutar.Width = 116
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
        Me.colsDovizCinsi.Width = 66
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
        Me.collDovizTutar.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.collDovizTutar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.collDovizTutar.Width = 69
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
        Me.colbMuhasebeyeIslendimi.Caption = "Muhasebeye Ýþlendimi"
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
        Me.colsKartNo.Width = 246
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanýcý Adý"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.OptionsColumn.AllowEdit = False
        '
        'ToolTipController1
        '
        Me.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        '
        'barDockControlTop
        '
        Me.ToolTipController1.SetSuperTip(Me.barDockControlTop, Nothing)
        '
        'barDockControlBottom
        '
        Me.ToolTipController1.SetSuperTip(Me.barDockControlBottom, Nothing)
        '
        'barDockControlLeft
        '
        Me.ToolTipController1.SetSuperTip(Me.barDockControlLeft, Nothing)
        '
        'barDockControlRight
        '
        Me.ToolTipController1.SetSuperTip(Me.barDockControlRight, Nothing)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "P.Ekle"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ToolTipTitleItem31.Text = "Peþinat Ekle"
        ToolTipItem31.LeftIndent = 6
        ToolTipItem31.Text = "Peþinat Bölümünde Peþinat Satýrý Ekler. Diðer Alanlar Boþ ise Satýþ tutarýný Peþi" & _
            "nat Olarak oluþturur."
        SuperToolTip31.Items.Add(ToolTipTitleItem31)
        SuperToolTip31.Items.Add(ToolTipItem31)
        Me.BarButtonItem1.SuperTip = SuperToolTip31
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "P.Sil"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ToolTipTitleItem32.Text = "Peþinat Sil"
        ToolTipItem32.LeftIndent = 6
        ToolTipItem32.Text = "Peþinat bölümünde Seçili Peþinat Satýr Kaydýný Siler."
        SuperToolTip32.Items.Add(ToolTipTitleItem32)
        SuperToolTip32.Items.Add(ToolTipItem32)
        Me.BarButtonItem2.SuperTip = SuperToolTip32
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "T.Ekle"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ToolTipTitleItem33.Text = "Taksit Ekle"
        ToolTipItem33.LeftIndent = 6
        ToolTipItem33.Text = "Taksitler bölümüne Belirtilen Baþlama Tarihinde Açýkta Kalan Ödeme Kadar 1 Taksit" & _
            " Oluþturur."
        SuperToolTip33.Items.Add(ToolTipTitleItem33)
        SuperToolTip33.Items.Add(ToolTipItem33)
        Me.BarButtonItem3.SuperTip = SuperToolTip33
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "T.Yay"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ToolTipTitleItem34.Text = "Taksit Yay"
        ToolTipItem34.LeftIndent = 6
        ToolTipItem34.Text = resources.GetString("ToolTipItem34.Text")
        SuperToolTip34.Items.Add(ToolTipTitleItem34)
        SuperToolTip34.Items.Add(ToolTipItem34)
        Me.BarButtonItem4.SuperTip = SuperToolTip34
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "T.Sil"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ToolTipTitleItem35.Text = "Taksit Sil"
        ToolTipItem35.LeftIndent = 6
        ToolTipItem35.Text = "Taksitlendirme Bölümünde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seçili Taksit Satýrýný Siler"
        SuperToolTip35.Items.Add(ToolTipTitleItem35)
        SuperToolTip35.Items.Add(ToolTipItem35)
        Me.BarButtonItem5.SuperTip = SuperToolTip35
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "TopluSil"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ToolTipTitleItem36.Text = "Taksitleri Sil"
        ToolTipItem36.LeftIndent = 6
        ToolTipItem36.Text = "Taksitlendirme Bölümünde Oluþturulmuþ Tüm Taksit Satýrlarýný Siler."
        SuperToolTip36.Items.Add(ToolTipTitleItem36)
        SuperToolTip36.Items.Add(ToolTipItem36)
        Me.BarButtonItem6.SuperTip = SuperToolTip36
        Me.BarButtonItem6.Appearance.Options.UseFont = True
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Çýkýþ"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        Me.BarButtonItem7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.Appearance.Options.UseFont = True
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Nakit"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        Me.BarButtonItem8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.Appearance.Options.UseFont = True
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Visa"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        Me.BarButtonItem9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.Appearance.Options.UseFont = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "dteTaksitTarihi"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "lTutari"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "nTaksit"
        Me.DataColumn27.DataType = GetType(Long)
        '
        'frm_stok_pesin_kapatma
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(373, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_stok_pesin_kapatma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolTipController1.SetSuperTip(Me, Nothing)
        Me.Text = "Satýþ Kapatma"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_taksit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_taksit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.sec_sAralik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sayi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public skasiyer
    Public skasiyerRumuzu
    Public sMagaza
    Public kullanici
    Public nAlisVerisID
    Public dteFisTarihi
    Public nKasaNo
    Public lNetTutar As Decimal = 0
    Public sOdemeKodu
    Dim lKalanTutar As Decimal = 0
    Dim lTaksitTutari As Decimal = 0
    Dim Pesinat As Decimal = 0
    Dim Taksit_tutari As Decimal = 0
    Dim taksit_sayisi As Int64 = 0
    Dim pesinat_sayisi As Int64 = 0
    Public sFisTipi As String = ""
    Dim dr As DataRow
    Dim dr_hareket As DataRow
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim ds_taksit_info As DataSet
    Dim ds_tbDoviz As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim nOdemeKodu = 1
    Dim lMakbuzNo = 0
    Dim bOtomatikTaksit As Boolean = False
    Dim nTaksitGun As Integer = 0
    Dim nTaksitBaslangic As Integer = 0
    Dim nTaksitSayi As Integer = 0
    Private Sub frm_stok_pesin_kapatma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        toplam_hesapla_kapatma()
        If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
            If pesinat_sayisi = 1 Then
                Dim dr_pesinat As DataRow = ds_odeme.Tables(0).Rows(0)
                dr_pesinat("lOdemeTutar") = dr_pesinat("lOdemeTutar") + lKalanTutar
                dr_pesinat = Nothing
                tbOdeme_hesapla()
                toplam_hesapla_kapatma()
            End If
        End If
    End Sub
    Private Sub frm_stok_pesin_kapatma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bOtomatikTaksit = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("bOtomatikTaksit").ToString
        Catch ex As Exception
            bOtomatikTaksit = False
        End Try
        Try
            nTaksitGun = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("nTaksitGun").ToString
        Catch ex As Exception
            nTaksitGun = 0
        End Try
        Try
            nTaksitBaslangic = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("nTaksitBaslangic").ToString
        Catch ex As Exception
            nTaksitBaslangic = 0
        End Try
        Try
            nTaksitSayi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("nTaksitSayi").ToString
        Catch ex As Exception
            nTaksitSayi = 0
        End Try
        If nTaksitBaslangic <> 0 Then
            Dim sGun As String = nTaksitBaslangic
            Dim sAy As String = Now.Month.ToString
            Dim sYil As String = Now.Year
            If Now.Month = 12 Then
                sYil = Now.Year + 1
                sAy = "01"
            Else
                sAy = (Now.Month + 1).ToString
            End If
            DateEdit1.EditValue = sGun + "/" + sAy + "/" + sYil
        Else
            DateEdit1.EditValue = dteSistemTarihi
        End If
        If nTaksitSayi <> 0 Then
            txt_sayi.EditValue = nTaksitSayi
        Else
            txt_sayi.EditValue = 1
        End If
        txt_tutar.EditValue = 0
        dataload_tbOdemeSekli()
        dataload_tbDovizCinsi()
        dataload_pesinat(nAlisVerisID)
        dataload_taksit(nAlisVerisID)
        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
            'lMakbuzNo = sorgu_lMakbuzNo(sDepo)
            'lMakbuzNo_degistir(lMakbuzNo, sDepo)
        End If
        toplam_hesapla_kapatma()
        If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
            If Pesinat = 0 Then
                pesinat_satir_ekle()
                toplam_hesapla_kapatma()
            End If
            GridControl2.Focus()
            GridControl2.Select()
        Else
            If Pesinat + Taksit_tutari = 0 Then
                If bOtomatikTaksit = True Then
                    tbTaksit_ekle_toplu(DateAdd(DateInterval.Day, nTaksitGun, dteFisTarihi), 1, "Ay", lKalanTutar)
                    toplam_hesapla_kapatma()
                End If
            ElseIf taksit_sayisi = 1 Then
                Dim dr_taksit As DataRow = ds_taksit.Tables(0).Rows(0)
                dr_taksit("lTutari") = dr_taksit("lTutari") + lKalanTutar
                dr_taksit = Nothing
                toplam_hesapla_kapatma()
            End If
            GridControl2.Focus()
            GridControl2.Select()
            GridView2.FocusedColumn = collOdemeTutar
        End If
        'pesinat_satir_info()
    End Sub
    Private Sub toplam_hesapla_kapatma()
        lbl_Satis.Text = lNetTutar
        Dim dr_pesinat As DataRow
        Dim dr_taksit As DataRow
        Pesinat = 0
        Taksit_tutari = 0
        taksit_sayisi = 0
        pesinat_sayisi = 0
        'Dim taksit_sayisi As Int64 = 0
        'Dim taksit_tutari As Decimal = 0
        For Each dr_pesinat In ds_odeme.Tables(0).Rows
            Pesinat += dr_pesinat("lOdemeTutar")
            pesinat_sayisi += 1
        Next
        lbl_pesinat.Text = Pesinat
        For Each dr_taksit In ds_taksit.Tables(0).Rows
            taksit_sayisi += 1
            Taksit_tutari += dr_taksit("lTutari")
        Next
        lbl_taksit_sayisi.Text = FormatNumber(taksit_sayisi, 2)
        lbl_taksit_tutari.Text = FormatNumber(Taksit_tutari, 2)
        lKalanTutar = lNetTutar - (Pesinat + Taksit_tutari)
        If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
            If lKalanTutar = 0 Then
                label2.Text = "***"
            ElseIf lKalanTutar < 0 Then
                label2.Text = "Para Üstü: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            ElseIf lKalanTutar > 0 Then
                label2.Text = "Eksik Para: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            End If
        Else
            If lKalanTutar = 0 Then
                label2.Text = "***"
            ElseIf lKalanTutar < 0 Then
                label2.Text = "Fazla Tutar: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            ElseIf lKalanTutar > 0 Then
                label2.Text = "Kalan Tutar: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            End If
        End If
        vade_hesapla_kapatma()
        dr_pesinat = Nothing
        dr_taksit = Nothing
        'taksit_sayisi = Nothing
        'taksit_tutari = Nothing
    End Sub
    Private Sub vade_hesapla_kapatma()
        Dim s As String
        Dim i As Integer
        Dim tutar = 0
        Dim vade
        Dim dr As DataRow
        Dim gun As Decimal = 0
        Dim tutarvade As Decimal = 0
        Dim ortvade As Decimal = 0
        Dim ortgun As Decimal = 0
        For Each dr In ds_taksit.Tables(0).Rows
            tutar = tutar + dr("lTutari")
            Try
                gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteTarihi"))
            Catch ex As Exception
                gun = 0
            End Try
            tutarvade = tutarvade + (dr("lTutari") * gun)
        Next
        Try
            ortvade = tutarvade / tutar
            lbl_gun.Text = CInt(ortvade)
            lbl_vade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_gun.Text = CInt(ortvade)
            lbl_vade.Text = ""
        End Try
        dr = Nothing
        s = Nothing
        i = Nothing
        tutar = Nothing
        vade = Nothing
        gun = Nothing
    End Sub
    Private Sub pesinat_satir_info()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("lMakbuzNo") <> lMakbuzNo Then
                lMakbuzNo = dr("lMakbuzNo")
            End If
            dr = Nothing
        Else
            lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
        End If
    End Sub
    Private Sub taksit_satir_info()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            ds_taksit_info = sorgu(sorgu_query("SELECT *, (SELECT ISNULL(SUM(lOdemeTutar) , 0) FROM tbOdeme WHERE nTaksitID = tbTaksit.nTaksitID) AS Tahsilat FROM tbTaksit Where nTaksitID ='" & dr("nTaksitID") & "'"))
            dr = Nothing
            Dim dr_taksit As DataRow
            Try
                dr_taksit = ds_taksit_info.Tables(0).Rows(0)
                If dr_taksit("Tahsilat") <> 0 Then
                    coldteTarihi.OptionsColumn.AllowEdit = False
                    collTutari.OptionsColumn.AllowEdit = False
                    MenuItem6.Enabled = False
                    'dr_taksit("Status") = 1
                Else
                    coldteTarihi.OptionsColumn.AllowEdit = True
                    collTutari.OptionsColumn.AllowEdit = True
                    MenuItem6.Enabled = True
                    'dr_taksit("Status") = 0
                End If
                lblTaksit_info.Text = "TaksitTarihi: " & dr_taksit("dteTarihi") & " Taksit Tutarý: " & dr_taksit("lTutari") & " Tahsil Edilen: " & dr_taksit("Tahsilat") & " Kalan: " & dr_taksit("lTutari") - dr_taksit("Tahsilat")
            Catch ex As Exception
                lblTaksit_info.Text = "***"
            End Try
            dr_taksit = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub dataload_tbOdemeSekli()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbOdemeSekli Order by sOdemeSekli ")).Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_pesinat(ByVal nAlisVerisID As String)
        ds_odeme = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID "))
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_odeme.Tables(0)
    End Sub
    Private Sub dataload_taksit(ByVal nAlisVerisID As String)
        ds_taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "))
        GridControl3.DataMember = Nothing
        GridControl3.DataSource = ds_taksit.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo,0) + 1 lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=1 ORDER BY  lMakbuzNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo_varmi(ByVal sDepo As String, ByVal nAlisVerisID As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo, 0) AS lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        nSonID += 1
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbAvSiraNo_kaydet_degistir(ByVal sMagaza As String, ByVal nSiraIndex As Int64, ByVal nSonID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVSiraNo SET              nSonID = nSonID WHERE     (sDepo = '" & sMagaza & "') AND (nSiraIndex = " & nSiraIndex & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub pesinat_satir_ekle()
        pesinat_satir_info()
        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
            lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
        End If
        Dim dr As DataRow = ds_odeme.Tables(0).NewRow
        Dim nOdemeID = sorgu_nOdemeID(sMagaza).ToString
        dr("nOdemeID") = sMagaza & nOdemeID.ToString
        dr("nAlisverisID") = nAlisVerisID
        dr("sOdemeSekli") = "N   "
        dr("nOdemeKodu") = 1
        dr("sKasiyerRumuzu") = skasiyerRumuzu
        dr("dteOdemeTarihi") = dteFisTarihi
        dr("dteValorTarihi") = dteFisTarihi
        dr("lOdemeTutar") = lKalanTutar
        dr("sDovizCinsi") = ""
        dr("lDovizTutar") = 0
        dr("lMakbuzNo") = lMakbuzNo
        dr("lOdemeNo") = lMakbuzNo
        dr("nTaksitID") = ""
        dr("nIadeAlisverisID") = ""
        dr("bMuhasebeyeIslendimi") = 0
        dr("nKasaNo") = nKasaNo
        dr("sKartNo") = ""
        dr("sKullaniciAdi") = "MUHASEBE"
        dr("dteKayitTarihi") = Now
        dr("sMagaza") = sMagaza
        tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        ds_odeme.Tables(0).Rows.Add(dr)
        tbAvSirano_degistir(2, nOdemeID, sMagaza)
        nOdemeID = Nothing
    End Sub
    Private Sub pesinat_satir_sil()
        If GridView2.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                tbOdeme_kaydet_sil(dr("nOdemeID"))
                ds_odeme.Tables(0).Rows.Remove(dr)
                GridControl2.Focus()
                GridControl2.Select()
                If GridView2.RowCount > 0 Then
                    GridView2.SelectRow(GridView2.FocusedRowHandle)
                End If
                toplam_hesapla_kapatma()
            End If
        End If
    End Sub
    Private Sub taksit_satir_sil()
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                tbTaksit_kaydet_sil(dr("nTaksitID"), nAlisVerisID)
                ds_taksit.Tables(0).Rows.Remove(dr)
                GridControl3.Focus()
                GridControl3.Select()
                If GridView3.RowCount > 0 Then
                    GridView3.SelectRow(GridView3.FocusedRowHandle)
                End If
                toplam_hesapla_kapatma()
            End If
        End If
    End Sub
    Private Sub taksit_satir_sil_toplu()
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr1 As DataRow
                For Each dr1 In ds_taksit.Tables(0).Rows
                    tbTaksit_kaydet_sil(dr1("nTaksitID"), nAlisVerisID)
                Next
                dataload_taksit(nAlisVerisID)
                toplam_hesapla_kapatma()
            End If
        End If
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbOdeme                       (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('" & nOdemeID & "', '" & nAlisverisID & "', '" & sOdemeSekli & "', " & nOdemeKodu & ", '" & sKasiyerRumuzu & "', '" & dteOdemeTarihi & "', '" & dteValorTarihi & "', " & lOdemeTutar & ", '" & sDovizCinsi & "', " & lDovizTutar & ", " & lMakbuzNo & ", " & lOdemeNo & ", '" & nTaksitID & "', '" & nIadeAlisverisID & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKartNo & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbOdeme_kaydet_degistir(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbOdeme SET              nAlisverisID = '" & nAlisverisID & "', sOdemeSekli = '" & sOdemeSekli & "', nOdemeKodu = " & nOdemeKodu & ", sKasiyerRumuzu = '" & sKasiyerRumuzu & "', dteOdemeTarihi = '" & dteOdemeTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', lOdemeTutar = " & lOdemeTutar & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizTutar = " & lDovizTutar & ", lMakbuzNo = '" & lMakbuzNo & "', lOdemeNo = '" & lOdemeNo & "', nTaksitID = '" & nTaksitID & "', nIadeAlisverisID = '" & nIadeAlisverisID & "', bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", nKasaNo = " & nKasaNo & ", sKartNo = '" & sKartNo & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sMagaza = '" & sMagaza & "' Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbOdeme_kaydet_sil(ByVal nOdemeID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbOdeme  Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_degistir(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbTaksit SET              dteTarihi = '" & dteTarihi & "', lTutari = " & lTutari & " Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_sil(ByVal nTaksitID As String, ByVal nAlisverisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim nKayit As Integer = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(nTaksitID) from tbOdeme Where nTaksitID = '" & nTaksitID & "'")
        If nKayit = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbTaksit Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
            cmd.ExecuteNonQuery()
        Else
            XtraMessageBox.Show("Ýþlem Görmüþ Taksit Kaydýný Silemezsiniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
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
    Private Sub tbOdeme_hesapla()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("lOdemeTutar") = 0 Then
                dr("lOdemeTutar") = 0.01
            End If
            dr.EndEdit()
            tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        End If
    End Sub
    Private Sub tbTaksit_hesapla(Optional ByVal bSatir As Integer = -1)
        If GridView3.RowCount > 0 Then
            GridView3.PostEditor()
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            If bSatir = -1 Then
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Else
                dr = GridView3.GetDataRow(bSatir)
            End If
            Dim satir = GridView3.FocusedRowHandle
            If dr("lTutari") = 0 Then
                dr("lTutari") = 0.01
            End If
            If dr("dteTarihi") < dteFisTarihi Then
                dr("dteTarihi") = dteFisTarihi
            End If
            If GridView3.FocusedRowHandle = 0 Then
                If dr("dteTarihi") > DateAdd(DateInterval.Day, 40, dteFisTarihi) Then
                    dr("dteTarihi") = DateAdd(DateInterval.Day, 40, dteFisTarihi)
                End If
            Else
                Dim dr_ilk As DataRow = GridView3.GetDataRow(0)
                Dim ilktarih As DateTime = dr_ilk("dteTarihi")
                If dr("dteTarihi") > DateAdd(DateInterval.Month, (GridView3.FocusedRowHandle + 1), ilktarih) Then
                    'dr("dteTarihi") = DateAdd(DateInterval.Month, (GridView2.FocusedRowHandle + 1), ilktarih)
                End If
                dr_ilk = Nothing
                ilktarih = Nothing
            End If
            dr.EndEdit()
            tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            toplam_hesapla_kapatma()
            If lKalanTutar < 0 Then
                GridView3.FocusedRowHandle = GridView3.RowCount - 1
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("lTutari") = lKalanTutar + dr("lTutari")
                dr.EndEdit()
                tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            ElseIf lKalanTutar > 0 Then
                GridView3.FocusedRowHandle = GridView3.RowCount - 1
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("lTutari") = lKalanTutar + dr("lTutari")
                dr.EndEdit()
                tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            End If
            toplam_hesapla_kapatma()
            GridView3.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView3.RowCount  'kl.Count
        Dim satir = GridView3.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView3.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        dr_hareket = GridView3.GetDataRow(GridView3.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            If columnkriter = "dteTarihi" Then
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                If t > 1 Then
                    durum = DateAdd(DateInterval.Month, 1, durum)
                Else
                    durum = durum
                End If
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            ElseIf columnkriter = "lTutari" Then
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            End If
            tbTaksit_hesapla()
            toplam_hesapla_kapatma()
            GridView3.FocusedRowHandle += 1
        Next
        GridView3.FocusedRowHandle = satir
        GridView3.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub tbTaksit_ekle_toplu(ByVal dteBaslangic As DateTime, ByVal TaksitSayisi As Int64, ByVal sAralik As String, ByVal TaksitTutari As Decimal)
        Dim i As Integer
        Dim dteTarihi As DateTime
        Dim nTaksitID As String = ""
        For i = 1 To TaksitSayisi
            If lKalanTutar > 0 Then
                If TaksitTutari > lKalanTutar Then
                    TaksitTutari = lKalanTutar
                End If
                dr = ds_taksit.Tables(0).NewRow
                If i > 1 Then
                    If sAralik = "Gün" Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    ElseIf sAralik = "Hafta" Then
                        dteTarihi = DateAdd(DateInterval.Day, 7, dteTarihi)
                    ElseIf sAralik = "Ay" Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    ElseIf sAralik = "3Ay" Then
                        dteTarihi = DateAdd(DateInterval.Quarter, 1, dteTarihi)
                    ElseIf sAralik = "Yýl" Then
                        dteTarihi = DateAdd(DateInterval.Year, 1, dteTarihi)
                    End If
                    'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                Else
                    dteTarihi = dteBaslangic
                End If
                nTaksitID = sorgu_nTaksitID(sMagaza)
                dr("nTaksitID") = sMagaza & nTaksitID
                dr("nAlisVerisID") = nAlisVerisID
                dr("dteTarihi") = dteTarihi
                dr("lTutari") = TaksitTutari
                tbTaksit_kaydet_yeni(dr("nTaksitID"), dr("nAlisVerisID"), dr("dteTarihi"), dr("lTutari"))
                ds_taksit.Tables(0).Rows.Add(dr)
                tbAvSirano_degistir(3, nTaksitID, sMagaza)
                toplam_hesapla_kapatma()
            End If
        Next
    End Sub
    Private Sub calculator()
        Dim frm As New frm_calc
        frm.ShowDialog()
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            tbOdeme_hesapla()
            toplam_hesapla_kapatma()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Try
            pesinat_satir_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        pesinat_satir_sil()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        pesinat_satir_ekle()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        tbTaksit_ekle_toplu(DateEdit1.EditValue, 1, sec_sAralik.Text, lKalanTutar)
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        taksit_satir_sil()
    End Sub
    Private Sub btn_ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ekle.Click
        If txt_tutar.EditValue = 0 And txt_sayi.EditValue > 0 Then
            txt_tutar.EditValue = lKalanTutar / txt_sayi.EditValue
        End If
        tbTaksit_ekle_toplu(DateEdit1.EditValue, txt_sayi.EditValue, sec_sAralik.Text, txt_tutar.EditValue)
        txt_sayi.EditValue = 0
        txt_tutar.EditValue = 0
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        Try
            taksit_satir_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView3.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView3.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            GridView3.PostEditor()
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            dr.EndEdit()
            tbTaksit_hesapla()
            toplam_hesapla_kapatma()
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Me.Close()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Me.Close()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Ödeme Ekranýný Kapatmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question, sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl3.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Ödeme Ekranýný Kapatmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question, sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        GridControl3.Focus()
        GridControl3.Select()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Me.Close()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Me.Close()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        taksit_satir_sil_toplu()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        pesinat_satir_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        pesinat_satir_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        tbTaksit_ekle_toplu(DateEdit1.EditValue, 1, sec_sAralik.Text, lKalanTutar)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView3.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView3.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        taksit_satir_sil()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        calculator()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If XtraMessageBox.Show(Sorgu_sDil("Oluþturulmuþ Taksitleri Silip, Fiþte Tanýmlanmýþ Ödeme Koduna Göre Taksitlendirme Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            OdemePlani_Aktar(sFisTipi, nAlisVerisID, DateEdit1.EditValue, sec_sAralik.Text)
        End If
    End Sub
    Private Sub OdemePlani_Aktar(ByVal sFisTipi As String, ByVal nAlisVerisID As String, ByVal dteBaslangic As DateTime, ByVal sAralik As String)
        taksit_satir_sil_toplu()
        Dim ds_OdemePlani As New DataSet
        ds_OdemePlani = sorgu(sorgu_query("SELECT     CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sFisTipi = '" & sFisTipi & "')"))
        If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
            ds_OdemePlani = sorgu(sorgu_query("SELECT     CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sFisTipi = '" & sFisTipi & "')"))
        ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
            ds_OdemePlani = sorgu(sorgu_query("SELECT     CAST(lTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbAlisVerisSiparis WHERE     (nAlisverisID = '" & nAlisVerisID & "') "))
        End If
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        For Each dr1 In ds_OdemePlani.Tables(0).Rows
            Dim TaksitSayisi As Integer = 0
            Dim dteTarihi As DateTime
            Dim i As Integer = 0
            If dr1("sOdemeKodu") = 0 Then
                TaksitSayisi = 1
            Else
                TaksitSayisi = dr1("sOdemeKodu")
            End If
            For i = 1 To TaksitSayisi
                If i > 1 Then
                    If sAralik = "Gün" Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    ElseIf sAralik = "Hafta" Then
                        dteTarihi = DateAdd(DateInterval.Day, 7, dteTarihi)
                    ElseIf sAralik = "Ay" Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    ElseIf sAralik = "3Ay" Then
                        dteTarihi = DateAdd(DateInterval.Quarter, 1, dteTarihi)
                    ElseIf sAralik = "Yýl" Then
                        dteTarihi = DateAdd(DateInterval.Year, 1, dteTarihi)
                    End If
                    'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                Else
                    dteTarihi = dteBaslangic
                End If
                Dim nTaksitID As String = ""
                If ds_taksit.Tables(0).Rows.Count < i Then
                    'dr2 = DataSet1.Tables(0).NewRow
                    'dr2("dteTaksitTarihi") = dteTarihi
                    'dr2("lTutari") = dr1("lTutar") / TaksitSayisi
                    'dr2("nTaksit") = i
                    'DataSet1.Tables(0).Rows.Add(dr2)
                    dr2 = ds_taksit.Tables(0).NewRow
                    nTaksitID = sorgu_nTaksitID(sMagaza)
                    dr2("nTaksitID") = sMagaza & nTaksitID
                    dr2("nAlisVerisID") = nAlisVerisID
                    dr2("dteTarihi") = dteTarihi
                    dr2("lTutari") = FormatNumber(dr1("lTutar") / TaksitSayisi, 2)
                    tbTaksit_kaydet_yeni(dr2("nTaksitID"), dr2("nAlisVerisID"), dr2("dteTarihi"), dr2("lTutari"))
                    ds_taksit.Tables(0).Rows.Add(dr2)
                    tbAvSirano_degistir(3, nTaksitID, sMagaza)
                    toplam_hesapla_kapatma()
                Else
                    dr2 = ds_taksit.Tables(0).Rows(i - 1)
                    dr2("lTutari") = FormatNumber(dr2("lTutari") + (dr1("lTutar") / TaksitSayisi), 2)
                    dr2.EndEdit()
                    tbTaksit_kaydet_degistir(dr2("nTaksitID"), nAlisVerisID, dr2("dteTarihi"), dr2("lTutari"))
                    toplam_hesapla_kapatma()
                End If
            Next
        Next
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
    End Sub
End Class
