Imports DevExpress.XtraEditors
Public Class frm_tablo_personel_maas
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNormal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIzinli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGecikmeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrutMaas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEklenti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKesinti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimHesapla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteriSayisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamCiro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiroOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_yil As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents txt_aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colDurum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKesinti2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKesinti3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKesinti4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKesinti5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEklenti2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEklenti3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEklenti4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEklenti5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_satici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_durum As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colHesapKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colGorev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcaSayisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents sec_kapali As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tablo_personel_maas))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colAvans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimTutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_kapali = New DevExpress.XtraEditors.CheckEdit
        Me.ds_baslik = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.txt_ay = New DevExpress.XtraEditors.TextEdit
        Me.txt_yil = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txt_aciklama = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.bar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSira = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_satici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNormal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIzinli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGecikmeli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGun = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBrutMaas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEklenti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKesinti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimHesapla = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimOrani = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCiro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMusteriSayisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colToplamCiro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCiroOrani = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDurum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_durum = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colKesinti2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKesinti3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKesinti4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKesinti5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEklenti2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEklenti3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEklenti4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEklenti5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHesapKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGorev = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParcaSayisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_kapali.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_yil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_durum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colAvans
        '
        Me.colAvans.Caption = "Avans"
        Me.colAvans.DisplayFormat.FormatString = "#,#.##"
        Me.colAvans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAvans.FieldName = "Avans"
        Me.colAvans.Name = "colAvans"
        Me.colAvans.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Avans", "{0:#,0.00}")})
        Me.colAvans.Visible = True
        Me.colAvans.VisibleIndex = 10
        Me.colAvans.Width = 60
        '
        'colPrimTutari
        '
        Me.colPrimTutari.Caption = "PrimTutari"
        Me.colPrimTutari.DisplayFormat.FormatString = "#,#.##"
        Me.colPrimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrimTutari.FieldName = "PrimTutari"
        Me.colPrimTutari.Name = "colPrimTutari"
        Me.colPrimTutari.OptionsColumn.AllowEdit = False
        Me.colPrimTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrimTutari", "{0:#,0.00}")})
        Me.colPrimTutari.Visible = True
        Me.colPrimTutari.VisibleIndex = 14
        Me.colPrimTutari.Width = 71
        '
        'colPrim
        '
        Me.colPrim.Caption = "Net Prim"
        Me.colPrim.DisplayFormat.FormatString = "#,#.##"
        Me.colPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrim.FieldName = "Prim"
        Me.colPrim.Name = "colPrim"
        Me.colPrim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prim", "{0:#,0.00}")})
        Me.colPrim.Visible = True
        Me.colPrim.VisibleIndex = 15
        Me.colPrim.Width = 83
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 136)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.sec_kapali)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.DateEdit4)
        Me.GroupControl1.Controls.Add(Me.DateEdit3)
        Me.GroupControl1.Controls.Add(Me.txt_ay)
        Me.GroupControl1.Controls.Add(Me.txt_yil)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Location = New System.Drawing.Point(112, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(688, 123)
        Me.GroupControl1.TabIndex = 42
        Me.GroupControl1.Text = "Ara"
        '
        'sec_kapali
        '
        Me.sec_kapali.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_baslik, "Table1.Kapali", True))
        Me.sec_kapali.Location = New System.Drawing.Point(624, 99)
        Me.sec_kapali.Name = "sec_kapali"
        Me.sec_kapali.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_kapali.Properties.Appearance.Options.UseForeColor = True
        Me.sec_kapali.Properties.Caption = "Kapali"
        Me.sec_kapali.Properties.ReadOnly = True
        Me.sec_kapali.Size = New System.Drawing.Size(56, 19)
        Me.sec_kapali.TabIndex = 47
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Yil"
        Me.DataColumn38.DataType = GetType(Long)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Ay"
        Me.DataColumn39.DataType = GetType(Long)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "Tarih1"
        Me.DataColumn40.DataType = GetType(Date)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "Tarih2"
        Me.DataColumn41.DataType = GetType(Date)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "Aciklama"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "IND"
        Me.DataColumn43.DataType = GetType(Long)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "Tarih3"
        Me.DataColumn44.DataType = GetType(Date)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "Tarih4"
        Me.DataColumn45.DataType = GetType(Date)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "Kapali"
        Me.DataColumn46.DataType = GetType(Boolean)
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(616, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 46
        Me.LabelControl5.Text = "Arasýndaki"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(320, 44)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 45
        Me.LabelControl6.Text = "AvansTarihi:"
        '
        'Label3
        '
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(496, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "ve"
        '
        'DateEdit4
        '
        Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataTable2, "Tarih4", True))
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.EnterMoveNextControl = True
        Me.DateEdit4.Location = New System.Drawing.Point(520, 44)
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit4.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit4.TabIndex = 43
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataTable2, "Tarih3", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.EnterMoveNextControl = True
        Me.DateEdit3.Location = New System.Drawing.Point(392, 44)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit3.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit3.TabIndex = 42
        '
        'txt_ay
        '
        Me.txt_ay.EnterMoveNextControl = True
        Me.txt_ay.Location = New System.Drawing.Point(192, 24)
        Me.txt_ay.Name = "txt_ay"
        Me.txt_ay.Size = New System.Drawing.Size(95, 20)
        Me.txt_ay.TabIndex = 1
        '
        'txt_yil
        '
        Me.txt_yil.EnterMoveNextControl = True
        Me.txt_yil.Location = New System.Drawing.Point(64, 24)
        Me.txt_yil.Name = "txt_yil"
        Me.txt_yil.Size = New System.Drawing.Size(96, 20)
        Me.txt_yil.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(616, 21)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 41
        Me.LabelControl4.Text = "Arasýndaki"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_aciklama)
        Me.GroupControl2.Location = New System.Drawing.Point(320, 64)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(296, 56)
        Me.GroupControl2.TabIndex = 40
        Me.GroupControl2.Text = "Açýklama"
        '
        'txt_aciklama
        '
        Me.txt_aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataTable2, "Aciklama", True))
        Me.txt_aciklama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aciklama.Location = New System.Drawing.Point(2, 22)
        Me.txt_aciklama.Name = "txt_aciklama"
        Me.txt_aciklama.Size = New System.Drawing.Size(292, 32)
        Me.txt_aciklama.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(166, 27)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl3.TabIndex = 38
        Me.LabelControl3.Text = "Ay:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(8, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "Yýl:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(320, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "PrimTarihi:"
        '
        'Label8
        '
        Me.Label8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(496, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataTable2, "Tarih2", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(520, 22)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit2.TabIndex = 4
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataTable2, "Tarih1", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(392, 22)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 3
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(64, 46)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(224, 20)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Listele"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 41
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.bar1)
        Me.PanelControl2.Controls.Add(Me.SimpleButton7)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(344, 15)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton6.TabIndex = 14
        Me.SimpleButton6.Text = "&Yansýt"
        '
        'bar1
        '
        Me.bar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar1.Location = New System.Drawing.Point(520, 15)
        Me.bar1.Name = "bar1"
        Me.bar1.Properties.ShowTitle = True
        Me.bar1.Size = New System.Drawing.Size(128, 24)
        Me.bar1.TabIndex = 16
        Me.bar1.Visible = False
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(424, 15)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton7.TabIndex = 15
        Me.SimpleButton7.Text = "&Kaydet"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(264, 15)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton5.TabIndex = 13
        Me.SimpleButton5.Text = "Hesapla"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(168, 15)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(96, 24)
        Me.SimpleButton4.TabIndex = 12
        Me.SimpleButton4.Text = "Liste Yenile"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(734, 15)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(659, 15)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 136)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 245)
        Me.PanelControl3.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 241)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 215)
        Me.XtraTabPage1.Text = "Tablo"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_satici, Me.sec_durum})
        Me.GridControl1.Size = New System.Drawing.Size(814, 215)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn5, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "EvrakNo"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Sira"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "SaticiRumuzu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Adi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Normal"
        Me.DataColumn6.DataType = GetType(Long)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Izinli"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Gecikmeli"
        Me.DataColumn8.DataType = GetType(Long)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Gun"
        Me.DataColumn9.DataType = GetType(Long)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "BrutMaas"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Eklenti1"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Kesinti1"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Avans"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Prim"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "PrimHesapla"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "PrimOrani"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "PrimTutari"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Ciro"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "MusteriSayisi"
        Me.DataColumn19.DataType = GetType(Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "ToplamCiro"
        Me.DataColumn20.DataType = GetType(Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "CiroOrani"
        Me.DataColumn21.DataType = GetType(Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Kat"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Net"
        Me.DataColumn23.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Aciklama"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Status"
        Me.DataColumn25.DataType = GetType(Boolean)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "PersonelNo"
        Me.DataColumn26.DataType = GetType(Long)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "HesapKodu"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Magaza"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "Durum"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "Eklenti2"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "Eklenti3"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "Eklenti4"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "Eklenti5"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Kesinti2"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Kesinti3"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Kesinti4"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Kesinti5"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colEvrakNo, Me.colSira, Me.colSaticiRumuzu, Me.colAdi, Me.colNormal, Me.colIzinli, Me.colGecikmeli, Me.colGun, Me.colBrutMaas, Me.colEklenti, Me.colKesinti, Me.colAvans, Me.colPrim, Me.colPrimHesapla, Me.colPrimOrani, Me.colPrimTutari, Me.colCiro, Me.colMusteriSayisi, Me.colToplamCiro, Me.colCiroOrani, Me.colKat, Me.colNet, Me.colAciklama, Me.colStatus, Me.colDurum, Me.colKesinti2, Me.colKesinti3, Me.colKesinti4, Me.colKesinti5, Me.colEklenti2, Me.colEklenti3, Me.colEklenti4, Me.colEklenti5, Me.colHesapKodu, Me.colGorev, Me.colParcaSayisi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 388, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colAvans
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colPrimTutari
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colPrim
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition3.Tag = "0"
        StyleFormatCondition3.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
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
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colIND
        '
        Me.colIND.Caption = "IND"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.OptionsColumn.AllowEdit = False
        Me.colIND.OptionsColumn.ShowInCustomizationForm = False
        '
        'colEvrakNo
        '
        Me.colEvrakNo.Caption = "Evrak No"
        Me.colEvrakNo.FieldName = "EvrakNo"
        Me.colEvrakNo.Name = "colEvrakNo"
        Me.colEvrakNo.OptionsColumn.AllowEdit = False
        Me.colEvrakNo.OptionsColumn.ShowInCustomizationForm = False
        '
        'colSira
        '
        Me.colSira.Caption = "Sýra"
        Me.colSira.FieldName = "Sira"
        Me.colSira.Name = "colSira"
        Me.colSira.Visible = True
        Me.colSira.VisibleIndex = 0
        Me.colSira.Width = 45
        '
        'colSaticiRumuzu
        '
        Me.colSaticiRumuzu.Caption = "Rumuz"
        Me.colSaticiRumuzu.ColumnEdit = Me.sec_satici
        Me.colSaticiRumuzu.FieldName = "SaticiRumuzu"
        Me.colSaticiRumuzu.Name = "colSaticiRumuzu"
        Me.colSaticiRumuzu.Visible = True
        Me.colSaticiRumuzu.VisibleIndex = 1
        Me.colSaticiRumuzu.Width = 45
        '
        'sec_satici
        '
        Me.sec_satici.AutoHeight = False
        Me.sec_satici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satici.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sSaticiRumuzu", "Rumuz"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SATICI", "Satýcý")})
        Me.sec_satici.DisplayMember = "sSaticiRumuzu"
        Me.sec_satici.Name = "sec_satici"
        Me.sec_satici.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_satici.ShowFooter = False
        Me.sec_satici.ShowHeader = False
        Me.sec_satici.ShowLines = False
        Me.sec_satici.ValueMember = "sSaticiRumuzu"
        '
        'colAdi
        '
        Me.colAdi.Caption = "Adý"
        Me.colAdi.FieldName = "Adi"
        Me.colAdi.Name = "colAdi"
        Me.colAdi.OptionsColumn.AllowEdit = False
        Me.colAdi.OptionsColumn.AllowFocus = False
        Me.colAdi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Adi", "{0} Kayýt")})
        Me.colAdi.Visible = True
        Me.colAdi.VisibleIndex = 2
        Me.colAdi.Width = 157
        '
        'colNormal
        '
        Me.colNormal.Caption = "Normal"
        Me.colNormal.DisplayFormat.FormatString = "#,0.##"
        Me.colNormal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNormal.FieldName = "Normal"
        Me.colNormal.Name = "colNormal"
        Me.colNormal.Width = 73
        '
        'colIzinli
        '
        Me.colIzinli.Caption = "Ýzinli"
        Me.colIzinli.DisplayFormat.FormatString = "#,0.##"
        Me.colIzinli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIzinli.FieldName = "Izinli"
        Me.colIzinli.Name = "colIzinli"
        Me.colIzinli.Width = 63
        '
        'colGecikmeli
        '
        Me.colGecikmeli.Caption = "Gecikmeli"
        Me.colGecikmeli.DisplayFormat.FormatString = "#,0.##"
        Me.colGecikmeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGecikmeli.FieldName = "Gecikmeli"
        Me.colGecikmeli.Name = "colGecikmeli"
        Me.colGecikmeli.Width = 66
        '
        'colGun
        '
        Me.colGun.Caption = "Gün"
        Me.colGun.DisplayFormat.FormatString = "#,0.##"
        Me.colGun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGun.FieldName = "Gun"
        Me.colGun.Name = "colGun"
        Me.colGun.Visible = True
        Me.colGun.VisibleIndex = 6
        Me.colGun.Width = 51
        '
        'colBrutMaas
        '
        Me.colBrutMaas.Caption = "Brüt Maaþ"
        Me.colBrutMaas.DisplayFormat.FormatString = "#,0.00"
        Me.colBrutMaas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBrutMaas.FieldName = "BrutMaas"
        Me.colBrutMaas.Name = "colBrutMaas"
        Me.colBrutMaas.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrutMaas", "{0:#,0.00}")})
        Me.colBrutMaas.Visible = True
        Me.colBrutMaas.VisibleIndex = 7
        Me.colBrutMaas.Width = 73
        '
        'colEklenti
        '
        Me.colEklenti.Caption = "Eklenti 1"
        Me.colEklenti.DisplayFormat.FormatString = "#,0.00"
        Me.colEklenti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEklenti.FieldName = "Eklenti1"
        Me.colEklenti.Name = "colEklenti"
        Me.colEklenti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Eklenti1", "{0:#,0.00}")})
        Me.colEklenti.Visible = True
        Me.colEklenti.VisibleIndex = 8
        Me.colEklenti.Width = 70
        '
        'colKesinti
        '
        Me.colKesinti.Caption = "Kesinti 1"
        Me.colKesinti.DisplayFormat.FormatString = "#,0.00"
        Me.colKesinti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKesinti.FieldName = "Kesinti1"
        Me.colKesinti.Name = "colKesinti"
        Me.colKesinti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kesinti1", "{0:#,0.00}")})
        Me.colKesinti.Visible = True
        Me.colKesinti.VisibleIndex = 9
        '
        'colPrimHesapla
        '
        Me.colPrimHesapla.Caption = "PrimHesapla"
        Me.colPrimHesapla.DisplayFormat.FormatString = "#,0.00"
        Me.colPrimHesapla.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrimHesapla.FieldName = "PrimHesapla"
        Me.colPrimHesapla.Name = "colPrimHesapla"
        Me.colPrimHesapla.OptionsColumn.AllowEdit = False
        Me.colPrimHesapla.Visible = True
        Me.colPrimHesapla.VisibleIndex = 11
        Me.colPrimHesapla.Width = 63
        '
        'colPrimOrani
        '
        Me.colPrimOrani.Caption = "Prim Oraný"
        Me.colPrimOrani.DisplayFormat.FormatString = "P"
        Me.colPrimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrimOrani.FieldName = "PrimOrani"
        Me.colPrimOrani.Name = "colPrimOrani"
        Me.colPrimOrani.OptionsColumn.AllowEdit = False
        Me.colPrimOrani.Visible = True
        Me.colPrimOrani.VisibleIndex = 13
        Me.colPrimOrani.Width = 64
        '
        'colCiro
        '
        Me.colCiro.Caption = "Ciro"
        Me.colCiro.DisplayFormat.FormatString = "#,#.##"
        Me.colCiro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCiro.FieldName = "Ciro"
        Me.colCiro.Name = "colCiro"
        Me.colCiro.OptionsColumn.AllowEdit = False
        Me.colCiro.Visible = True
        Me.colCiro.VisibleIndex = 12
        Me.colCiro.Width = 79
        '
        'colMusteriSayisi
        '
        Me.colMusteriSayisi.Caption = "Müþteri Sayýsý"
        Me.colMusteriSayisi.DisplayFormat.FormatString = "#,0.00"
        Me.colMusteriSayisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMusteriSayisi.FieldName = "MusteriSayisi"
        Me.colMusteriSayisi.Name = "colMusteriSayisi"
        Me.colMusteriSayisi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MusteriSayisi", "{0:#,0.00}")})
        '
        'colToplamCiro
        '
        Me.colToplamCiro.Caption = "Toplam Ciro"
        Me.colToplamCiro.DisplayFormat.FormatString = "#,#.##"
        Me.colToplamCiro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamCiro.FieldName = "ToplamCiro"
        Me.colToplamCiro.Name = "colToplamCiro"
        Me.colToplamCiro.OptionsColumn.AllowEdit = False
        Me.colToplamCiro.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamCiro", "{0:#,0.00}")})
        '
        'colCiroOrani
        '
        Me.colCiroOrani.Caption = "Ciro Oraný"
        Me.colCiroOrani.DisplayFormat.FormatString = "#,0.00"
        Me.colCiroOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCiroOrani.FieldName = "CiroOrani"
        Me.colCiroOrani.Name = "colCiroOrani"
        Me.colCiroOrani.OptionsColumn.AllowEdit = False
        '
        'colKat
        '
        Me.colKat.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colKat.AppearanceCell.Options.UseBackColor = True
        Me.colKat.Caption = "Kat"
        Me.colKat.FieldName = "Magaza"
        Me.colKat.Name = "colKat"
        Me.colKat.OptionsColumn.AllowEdit = False
        Me.colKat.Visible = True
        Me.colKat.VisibleIndex = 3
        Me.colKat.Width = 73
        '
        'colNet
        '
        Me.colNet.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNet.AppearanceCell.Options.UseFont = True
        Me.colNet.Caption = "Hakediþ"
        Me.colNet.DisplayFormat.FormatString = "#,0.00"
        Me.colNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNet.FieldName = "Net"
        Me.colNet.Name = "colNet"
        Me.colNet.OptionsColumn.AllowEdit = False
        Me.colNet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Net", "{0:#,0.00}")})
        Me.colNet.Visible = True
        Me.colNet.VisibleIndex = 16
        Me.colNet.Width = 69
        '
        'colAciklama
        '
        Me.colAciklama.Caption = "Açýklama"
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        Me.colAciklama.Visible = True
        Me.colAciklama.VisibleIndex = 17
        Me.colAciklama.Width = 153
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.AllowEdit = False
        '
        'colDurum
        '
        Me.colDurum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDurum.AppearanceCell.Options.UseBackColor = True
        Me.colDurum.Caption = "Durum"
        Me.colDurum.ColumnEdit = Me.sec_durum
        Me.colDurum.FieldName = "Durum"
        Me.colDurum.Name = "colDurum"
        Me.colDurum.Visible = True
        Me.colDurum.VisibleIndex = 4
        '
        'sec_durum
        '
        Me.sec_durum.AutoHeight = False
        Me.sec_durum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_durum.Items.AddRange(New Object() {"Personel", "SatýþPersoneli", "FirmaPersoneli", "KatÞefi"})
        Me.sec_durum.Name = "sec_durum"
        Me.sec_durum.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_durum.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colKesinti2
        '
        Me.colKesinti2.Caption = "Kesinti 2"
        Me.colKesinti2.FieldName = "Kesinti2"
        Me.colKesinti2.Name = "colKesinti2"
        '
        'colKesinti3
        '
        Me.colKesinti3.Caption = "Kesinti 3"
        Me.colKesinti3.FieldName = "Kesinti3"
        Me.colKesinti3.Name = "colKesinti3"
        '
        'colKesinti4
        '
        Me.colKesinti4.Caption = "Kesinti 4"
        Me.colKesinti4.FieldName = "Kesinti4"
        Me.colKesinti4.Name = "colKesinti4"
        '
        'colKesinti5
        '
        Me.colKesinti5.Caption = "Kesinti 5"
        Me.colKesinti5.Name = "colKesinti5"
        '
        'colEklenti2
        '
        Me.colEklenti2.Caption = "Eklenti 2"
        Me.colEklenti2.FieldName = "Eklenti2"
        Me.colEklenti2.Name = "colEklenti2"
        '
        'colEklenti3
        '
        Me.colEklenti3.Caption = "Eklenti 3"
        Me.colEklenti3.FieldName = "Eklenti3"
        Me.colEklenti3.Name = "colEklenti3"
        '
        'colEklenti4
        '
        Me.colEklenti4.Caption = "Eklenti 4"
        Me.colEklenti4.FieldName = "Eklenti4"
        Me.colEklenti4.Name = "colEklenti4"
        '
        'colEklenti5
        '
        Me.colEklenti5.Caption = "Eklenti 5"
        Me.colEklenti5.FieldName = "Eklenti5"
        Me.colEklenti5.Name = "colEklenti5"
        '
        'colHesapKodu
        '
        Me.colHesapKodu.Caption = "Hesap Kodu"
        Me.colHesapKodu.FieldName = "HesapKodu"
        Me.colHesapKodu.Name = "colHesapKodu"
        '
        'colGorev
        '
        Me.colGorev.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGorev.AppearanceCell.Options.UseBackColor = True
        Me.colGorev.Caption = "Görev"
        Me.colGorev.FieldName = "Gorev"
        Me.colGorev.Name = "colGorev"
        Me.colGorev.Visible = True
        Me.colGorev.VisibleIndex = 5
        Me.colGorev.Width = 105
        '
        'colParcaSayisi
        '
        Me.colParcaSayisi.Caption = "Parça Sayýsý"
        Me.colParcaSayisi.DisplayFormat.FormatString = "#,#.##"
        Me.colParcaSayisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colParcaSayisi.FieldName = "ParcaSayisi"
        Me.colParcaSayisi.Name = "colParcaSayisi"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(812, 213)
        Me.XtraTabPage2.Text = "&Detay"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem18, Me.MenuItem14, Me.MenuItem16, Me.MenuItem17, Me.MenuItem21, Me.MenuItem15, Me.MenuItem19, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem18.Text = "Satýr Sil"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Text = "Satýrý Yenile"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "Personel Kartý"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 6
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem15.Text = "Hesap Kartý"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Text = "Yansýtmayý Ýptal Et"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 9
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 11
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 12
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = False
        Me.MenuItem5.Index = 14
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = False
        Me.MenuItem6.Index = 15
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 16
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Enabled = False
        Me.MenuItem7.Index = 17
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Enabled = False
        Me.MenuItem8.Index = 18
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 19
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 20
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
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
        Me.printlink1.Landscape = True
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Personel Hakediþleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Personel Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_tablo_personel_maas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tablo_personel_maas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personel Hakediþ Tablosu"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_kapali.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_yil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_durum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kayitno As Int64 = 0
    Public kullanici
    Dim ds_personel As DataSet
    Dim ds_satis_personel As DataSet
    Dim ds_satis_kat As DataSet
    Private Sub frm_tablo_personel_maas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_yil.EditValue = Now.Year
        txt_ay.EditValue = Now.Month
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        DateEdit3.EditValue = dteSistemTarihi
        DateEdit4.EditValue = dteSistemTarihi
        dataload_satici()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        SimpleButton7.Text = Sorgu_sDil(SimpleButton7.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        baslik_kaydet()
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Personel Hakediþleri" & vbCrLf
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Personel Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub dataload_satici()
        sec_satici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici where bAktif =1")).Tables(0)
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
    Private Function sorgu_kayitno(ByVal yil As String, ByVal ay As String) As Int64
        Dim kriter
        kriter = " where Yil = '" & yil & "' and Ay = '" & ay & "' "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(IND,0) AS IND  FROM         aEmirPuantaj " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload_harekets()
        DataSet1 = sorgu_harekets(kayitno)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
    End Sub
    Private Sub sorgu_baslik(ByVal kriter As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM  aEmirPuantaj WHERE IND =" & kayitno & "")
        cmd.Connection = con
        con.Open()
        ds_baslik.Tables(0).Clear()
        Dim N As Integer = adapter.Fill(ds_baslik, "Table1")
        con.Close()
    End Sub
    Private Function sorgu_personel(ByVal kriter As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         APERSONEL WHERE     (AKTIF = 1) ORDER BY PERSONELADI")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_harekets(ByVal kayitno As Int64) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED                           SELECT     *                            FROM         aEmirPuantajDetay                            WHERE     EvrakNo = " & kayitno & "  Order by Sira")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function baslik_kaydet_yeni(ByVal Yil As Int64, ByVal Ay As Int64, ByVal Tarih1 As DateTime, ByVal Tarih2 As DateTime, ByVal tarih3 As DateTime, ByVal tarih4 As DateTime, ByVal Aciklama As String, ByVal kapali As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirPuantaj                       (Yil, Ay, Tarih1, Tarih2,Tarih3,Tarih4, Aciklama,Kapali) VALUES     ('" & Yil & "', '" & Ay & "', '" & Tarih1 & "', '" & Tarih2 & "','" & tarih3 & "','" & tarih4 & "', '" & Aciklama & "',0)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub baslik_kaydet_degistir(ByVal kayitno As Int64, ByVal Yil As Int64, ByVal Ay As Int64, ByVal Tarih1 As DateTime, ByVal Tarih2 As DateTime, ByVal tarih3 As DateTime, ByVal tarih4 As DateTime, ByVal Aciklama As String, ByVal kapali As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.ConnectionString = connection
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirPuantaj SET              Yil = '" & Yil & "', Ay = '" & Ay & "', Tarih1 = '" & Tarih1 & "', Tarih2 = '" & Tarih2 & "',Tarih3 = '" & tarih3 & "',Tarih4 = '" & tarih4 & "', Aciklama = '" & Aciklama & "',Kapali= " & kapali & " WHERE IND = " & kayitno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub baslik_kaydet()
        Label2.Text = "Kaydediliyor..."
        Label2.Refresh()
        baslik_kaydet_degistir(kayitno, txt_yil.EditValue, txt_ay.EditValue, DateEdit1.EditValue, DateEdit2.EditValue, DateEdit3.EditValue, DateEdit4.EditValue, txt_aciklama.EditValue, sec_kapali.Checked)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Refresh()
    End Sub
    Private Function hareket_kaydet_yeni(ByVal EvrakNo As Int64, ByVal Sira As Int64, ByVal PersonelNo As Int64, ByVal SaticiRumuzu As String, ByVal HesapKodu As String, ByVal Magaza As String, ByVal Durum As String, ByVal Gorev As String, ByVal Adi As String, ByVal Normal As Int64, ByVal Izinli As Int64, ByVal Gecikmeli As Int64, ByVal Gun As Int64, ByVal BrutMaas As Decimal, ByVal Eklenti1 As Decimal, ByVal Eklenti2 As Decimal, ByVal Eklenti3 As Decimal, ByVal Eklenti4 As Decimal, ByVal Eklenti5 As Decimal, ByVal Kesinti1 As Decimal, ByVal Kesinti2 As Decimal, ByVal Kesinti3 As Decimal, ByVal Kesinti4 As Decimal, ByVal Kesinti5 As Decimal, ByVal Avans As Decimal, ByVal Prim As Decimal, ByVal PrimHesapla As Byte, ByVal PrimOrani As Decimal, ByVal PrimTutari As Decimal, ByVal Ciro As Decimal, ByVal ParcaSayisi As Decimal, ByVal MusteriSayisi As Int64, ByVal ToplamCiro As Decimal, ByVal CiroOrani As Decimal, ByVal Kat As String, ByVal Net As Decimal, ByVal Aciklama As String, ByVal Status As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.ConnectionString = connection
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirPuantajDetay                       (EvrakNo, Sira, PersonelNo, SaticiRumuzu, HesapKodu, Magaza, Durum,Gorev, Adi, Normal, Izinli, Gecikmeli, Gun, BrutMaas, Eklenti1, Eklenti2, Eklenti3,  Eklenti4, Eklenti5, Kesinti1, Kesinti2, Kesinti3, Kesinti4, Kesinti5, Avans, Prim, PrimHesapla, PrimOrani, PrimTutari, Ciro, ParcaSayisi,MusteriSayisi,ToplamCiro, CiroOrani, Kat, Net, Aciklama, Status) VALUES     (" & EvrakNo & ", " & Sira & ", " & PersonelNo & ", '" & SaticiRumuzu & "', '" & HesapKodu & "', '" & Magaza & "', '" & Durum & "', '" & Gorev & "','" & Adi & "', " & Normal & ", " & Izinli & ", " & Gecikmeli & ", " & Gun & ", " & BrutMaas & ", " & Eklenti1 & ", " & Eklenti2 & ", " & Eklenti3 & ",  " & Eklenti4 & ", " & Eklenti5 & ", " & Kesinti1 & ", " & Kesinti2 & ", " & Kesinti3 & ", " & Kesinti4 & ", " & Kesinti5 & ", " & Avans & ", " & Prim & ", " & PrimHesapla & ", " & PrimOrani & ", " & PrimTutari & ", " & Ciro & "," & ParcaSayisi & ", " & MusteriSayisi & "," & ToplamCiro & ", " & CiroOrani & ", '" & Kat & "', " & Net & ", '" & Aciklama & "', '" & Status & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal evrakno As Int64, ByVal Sira As Int64, ByVal PersonelNo As Int64, ByVal SaticiRumuzu As String, ByVal HesapKodu As String, ByVal Magaza As String, ByVal Durum As String, ByVal Gorev As String, ByVal Adi As String, ByVal Normal As Int64, ByVal Izinli As Int64, ByVal Gecikmeli As Int64, ByVal Gun As Int64, ByVal BrutMaas As Decimal, ByVal Eklenti1 As Decimal, ByVal Eklenti2 As Decimal, ByVal Eklenti3 As Decimal, ByVal Eklenti4 As Decimal, ByVal Eklenti5 As Decimal, ByVal Kesinti1 As Decimal, ByVal Kesinti2 As Decimal, ByVal Kesinti3 As Decimal, ByVal Kesinti4 As Decimal, ByVal Kesinti5 As Decimal, ByVal Avans As Decimal, ByVal Prim As Decimal, ByVal PrimHesapla As Byte, ByVal PrimOrani As Decimal, ByVal PrimTutari As Decimal, ByVal Ciro As Decimal, ByVal ParcaSayisi As Decimal, ByVal MusteriSayisi As Int64, ByVal ToplamCiro As Decimal, ByVal CiroOrani As Decimal, ByVal Kat As String, ByVal Net As Decimal, ByVal Aciklama As String, ByVal Status As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirPuantajDetay SET               Sira = " & Sira & ", PersonelNo = " & PersonelNo & ", SaticiRumuzu = '" & SaticiRumuzu & "', HesapKodu = '" & HesapKodu & "', Magaza = '" & Magaza & "',  Durum = '" & Durum & "', Gorev = '" & Gorev & "',Adi = '" & Adi & "', Normal = " & Normal & ", Izinli = " & Izinli & ", Gecikmeli = " & Gecikmeli & ", Gun = " & Gun & ", BrutMaas = " & BrutMaas & ", Eklenti1 = " & Eklenti1 & ", Eklenti2 = " & Eklenti2 & ", Eklenti3 = " & Eklenti3 & ", Eklenti4 = " & Eklenti4 & ", Eklenti5 = " & Eklenti5 & ", Kesinti1 = " & Kesinti1 & ", Kesinti2 = " & Kesinti2 & ", Kesinti3 = " & Kesinti3 & ",  Kesinti4 = " & Kesinti4 & ", Kesinti5 = " & Kesinti5 & ", Avans = " & Avans & ", Prim = " & Prim & ", PrimHesapla = " & PrimHesapla & ", PrimOrani = " & PrimOrani & ", PrimTutari = " & PrimTutari & ", Ciro = " & Ciro & ", ParcaSayisi = " & ParcaSayisi & ",MusteriSayisi = " & MusteriSayisi & ", ToplamCiro = " & ToplamCiro & ", CiroOrani = " & CiroOrani & ", Kat = '" & Kat & "', Net = " & Net & ", Aciklama = '" & Aciklama & "', Status = " & Status & " WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM aEmirPuantajDetay  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_sil_tumu(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM aEmirPuantajDetay  WHERE EvrakNo = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_nfirmaID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID,0) AS nFirmaID FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        Return 1
    End Function
    Private Function firmahareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        con.Close()
        Return nHareketID
    End Function
    Private Sub firmahareketi_kaydet_sil(ByVal nFirmaID As Int64, ByVal sCariIslem As String, ByVal sEvrakNo As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  DELETE FROM tbFirmaHareketi WHERE nFirmaID = " & nFirmaID & " and sCariIslem = '" & sCariIslem & "' and sEvrakNo = '" & sEvrakNo & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim hareketno = cmd.ExecuteScalar
        con.Close()
    End Sub
    Private Sub fis_Master_nCariHareketID_degistir(ByVal nCariHareketID As String)
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
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Sub
    Public Function sorgu_sirano(ByVal evrakno As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(Sira + 1, 0) AS Sira FROM         aEmirPuantajDetay WHERE     (EvrakNo = " & evrakno & ") ORDER BY Sira DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_avans(ByVal hesapkodu As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar),0) AS Tutar FROM         tbFirmaHareketi INNER JOIN                       tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE     (tbFirma.sKodu LIKE '" & hesapkodu & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar),0) AS Tutar FROM         tbFirmaHareketi INNER JOIN                       tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE     (tbFirma.sKodu LIKE '" & hesapkodu & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_satis_satici(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        ds_satis_personel = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,sSaticiRumuzu, Satici,PersonelOran, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(lNetTutar) * (PersonelOran / 100) AS Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY sKat,PersonelOran,sSaticiRumuzu, Satici ORDER BY sKat,sSaticiRumuzu, Satici"))
    End Sub
    Private Sub dataload_satis_kat(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        'Grid_satis_kat.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisVeris LEFT OUTER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & "  GROUP BY sKat ORDER BY sKat")).Tables(0)
        ds_satis_kat = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,KatOran,Kota, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(lNetTutar) * (KatOran / 100) AS Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY sKat, KatOran,Kota ORDER BY sKat"))
    End Sub
    Private Sub yenile()
        ds_personel = sorgu_personel("")
        hareket_kaydet_sil_tumu(kayitno)
        DataSet1.Tables(0).Clear()
        Dim dr1 As DataRow
        Dim dr As DataRow
        For Each dr1 In ds_personel.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("EvrakNo") = kayitno
            dr("Sira") = sorgu_sirano(kayitno)
            dr("PersonelNo") = dr1("IND")
            dr("SaticiRumuzu") = dr1("SATICIRUMUZU").ToString
            dr("HesapKodu") = dr1("HESAPKODU").ToString
            dr("Magaza") = dr1("MAGAZA").ToString
            dr("Durum") = dr1("Durum").ToString
            dr("Gorev") = dr1("GOREV").ToString
            dr("Adi") = dr1("PERSONELADI").ToString
            dr("Normal") = 30
            dr("Izinli") = 0
            dr("Gecikmeli") = 0
            dr("Gun") = 30
            dr("BrutMaas") = dr1("BrutMaas")
            dr("Eklenti1") = dr1("Eklenti1")
            dr("Eklenti2") = dr1("Eklenti2")
            dr("Eklenti3") = dr1("Eklenti3")
            dr("Eklenti4") = dr1("Eklenti4")
            dr("Eklenti5") = dr1("Eklenti5")
            dr("Kesinti1") = dr1("Kesinti1")
            dr("Kesinti2") = dr1("Kesinti2")
            dr("Kesinti3") = dr1("Kesinti3")
            dr("Kesinti4") = dr1("Kesinti4")
            dr("Kesinti5") = dr1("Kesinti5")
            dr("Avans") = 0
            dr("Prim") = 0
            dr("PrimHesapla") = 0
            dr("PrimOrani") = 0
            dr("PrimTutari") = 0
            dr("Ciro") = 0
            dr("ParcaSayisi") = 0
            dr("MusteriSayisi") = 0
            dr("ToplamCiro") = 0
            dr("CiroOrani") = 0
            dr("Kat") = ""
            dr("Net") = dr("BrutMaas") + (dr("Eklenti1") + dr("Eklenti2") + dr("Eklenti3") + dr("Eklenti4") + dr("Eklenti5")) - (dr("Kesinti1") + dr("Kesinti2") + dr("Kesinti3") + dr("Kesinti4") + dr("Kesinti5")) - dr("Avans") + dr("Prim")
            dr("Aciklama") = ""
            dr("Status") = 0
            dr("IND") = hareket_kaydet_yeni(kayitno, dr("Sira"), dr("PersonelNo"), dr("SaticiRumuzu"), dr("HesapKodu"), dr("Magaza"), dr("Durum"), dr("Gorev"), dr("Adi"), dr("Normal"), dr("Izinli"), dr("Gecikmeli"), dr("Gun"), dr("BrutMaas"), dr("Eklenti1"), dr("Eklenti2"), dr("Eklenti3"), dr("Eklenti4"), dr("Eklenti5"), dr("Kesinti1"), dr("Kesinti2"), dr("Kesinti3"), dr("Kesinti4"), dr("Kesinti5"), dr("Avans"), dr("Prim"), dr("PrimHesapla"), dr("PrimOrani"), dr("PrimTutari"), dr("Ciro"), dr("ParcaSayisi"), dr("MusteriSayisi"), dr("ToplamCiro"), dr("CiroOrani"), dr("Kat"), dr("Net"), dr("Aciklama"), dr("Status"))
            DataSet1.Tables(0).Rows.Add(dr)
        Next
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        dr = Nothing
        dr1 = Nothing
    End Sub
    Private Sub hesapla_avans()
        Dim dr As DataRow
        bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        bar1.Position = 0
        bar1.Visible = True
        For Each dr In DataSet1.Tables(0).Rows
            dr("Avans") = sorgu_avans(dr("HesapKodu"), DateEdit3.EditValue, DateEdit4.EditValue)
            dr("Net") = dr("BrutMaas") + (dr("Eklenti1") + dr("Eklenti2") + dr("Eklenti3") + dr("Eklenti4") + dr("Eklenti5")) - (dr("Kesinti1") + dr("Kesinti2") + dr("Kesinti3") + dr("Kesinti4") + dr("Kesinti5")) - dr("Avans") + dr("Prim")
            hareket_kaydet_degistir(dr("IND"), kayitno, dr("Sira"), dr("PersonelNo"), dr("SaticiRumuzu"), dr("HesapKodu"), dr("Magaza"), dr("Durum"), dr("Gorev"), dr("Adi"), dr("Normal"), dr("Izinli"), dr("Gecikmeli"), dr("Gun"), dr("BrutMaas"), dr("Eklenti1"), dr("Eklenti2"), dr("Eklenti3"), dr("Eklenti4"), dr("Eklenti5"), dr("Kesinti1"), dr("Kesinti2"), dr("Kesinti3"), dr("Kesinti4"), dr("Kesinti5"), dr("Avans"), dr("Prim"), dr("PrimHesapla"), dr("PrimOrani"), dr("PrimTutari"), dr("Ciro"), dr("ParcaSayisi"), dr("MusteriSayisi"), dr("ToplamCiro"), dr("CiroOrani"), dr("Kat"), dr("Net"), dr("Aciklama"), dr("Status"))
            bar1.Position += 1
            bar1.Refresh()
        Next
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = False
        'MsgBox(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub hesapla_avans_satir()
        bar1.Properties.Maximum = 1
        bar1.Position = 0
        bar1.Visible = True
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        dr("Avans") = sorgu_avans(dr("HesapKodu"), DateEdit3.EditValue, DateEdit4.EditValue)
        dr("Net") = dr("BrutMaas") + (dr("Eklenti1") + dr("Eklenti2") + dr("Eklenti3") + dr("Eklenti4") + dr("Eklenti5")) - (dr("Kesinti1") + dr("Kesinti2") + dr("Kesinti3") + dr("Kesinti4") + dr("Kesinti5")) - dr("Avans") + dr("Prim")
        hareket_kaydet_degistir(dr("IND"), kayitno, dr("Sira"), dr("PersonelNo"), dr("SaticiRumuzu"), dr("HesapKodu"), dr("Magaza"), dr("Durum"), dr("Gorev"), dr("Adi"), dr("Normal"), dr("Izinli"), dr("Gecikmeli"), dr("Gun"), dr("BrutMaas"), dr("Eklenti1"), dr("Eklenti2"), dr("Eklenti3"), dr("Eklenti4"), dr("Eklenti5"), dr("Kesinti1"), dr("Kesinti2"), dr("Kesinti3"), dr("Kesinti4"), dr("Kesinti5"), dr("Avans"), dr("Prim"), dr("PrimHesapla"), dr("PrimOrani"), dr("PrimTutari"), dr("Ciro"), dr("ParcaSayisi"), dr("MusteriSayisi"), dr("ToplamCiro"), dr("CiroOrani"), dr("Kat"), dr("Net"), dr("Aciklama"), dr("Status"))
        bar1.Position += 1
        bar1.Refresh()
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = False
        'MsgBox(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub hesapla_yansit()
        Dim dr As DataRow
        bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        bar1.Position = 0
        bar1.Visible = True
        Dim nFirmaID As Int64 = 0
        Dim nHareketID As Int64 = 0
        For Each dr In DataSet1.Tables(0).Rows
            nFirmaID = sorgu_nfirmaID(dr("HesapKodu"))
            If nFirmaID > 0 Then
                'Maaþ
                nHareketID = sorgu_nCariHareketID()
                nHareketID = firmahareketi_kaydet_yeni(nHareketID, nFirmaID, Today, Today, "HK", Microsoft.VisualBasic.Left(dr("Adi") & " Maaþ /" & txt_yil.Text & " / " & txt_ay.Text & "", 60), 0, dr("BrutMaas"), kayitno, 0, "", "UC", kullanici, Now, "", 0, 0, "", 0, 0, kullanici, Now)
                'Prim
                nHareketID = sorgu_nCariHareketID()
                nHareketID = firmahareketi_kaydet_yeni(nHareketID, nFirmaID, Today, Today, "HK", Microsoft.VisualBasic.Left(dr("Adi") & " Prim /" & txt_yil.Text & " / " & txt_ay.Text & " ", 60), 0, dr("Eklenti1") + dr("Eklenti2") + dr("Eklenti3") + dr("Eklenti4") + dr("Eklenti5") + dr("Prim"), kayitno, 0, "", "UC", kullanici, Now, "", 0, 0, "", 0, 0, kullanici, Now)
                fis_Master_nCariHareketID_degistir(nHareketID)
            Else
            End If
            bar1.Position += 1
            bar1.Refresh()
        Next
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = False
        sec_kapali.Checked = True
        baslik_kaydet()
        GridView1.OptionsBehavior.Editable = False
        SimpleButton4.Enabled = False
        SimpleButton5.Enabled = False
        SimpleButton6.Enabled = False
        SimpleButton7.Enabled = False
        nFirmaID = Nothing
        nHareketID = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Hesaplara Yansýtýlmýþ Hakediþ Tablosunda Deðiþiklik Yapamazsýnýz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Private Sub hesapla_yansit_sil()
        Dim dr As DataRow
        bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        bar1.Position = 0
        bar1.Visible = True
        Dim nFirmaID As Int64 = 0
        Dim nHareketID As Int64 = 0
        For Each dr In DataSet1.Tables(0).Rows
            nFirmaID = sorgu_nfirmaID(dr("HesapKodu"))
            If nFirmaID > 0 Then
                'Maaþ+Prim Sil
                firmahareketi_kaydet_sil(nFirmaID, "HK", kayitno)
                'nHareketID = sorgu_nCariHareketID()
                'fis_Master_nCariHareketID_degistir(nHareketID)
            Else
            End If
            bar1.Position += 1
            bar1.Refresh()
        Next
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = False
        sec_kapali.Checked = False
        baslik_kaydet()
        GridView1.OptionsBehavior.Editable = False
        SimpleButton4.Enabled = True
        SimpleButton5.Enabled = True
        SimpleButton6.Enabled = True
        SimpleButton7.Enabled = True
        nFirmaID = Nothing
        nHareketID = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Hesaplara Yansýtýlmýþ Hakediþler Baþarýyla Kaldýrýlmýþtýr...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub hesapla_prim()
        Dim dr As DataRow
        Dim gecti As Integer = 0
        bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        bar1.Position = 0
        bar1.Visible = True
        For Each dr In DataSet1.Tables(0).Rows
            If dr("Durum") = "SatýþPersoneli" Then
                If Trim(dr("SaticiRumuzu")) <> "" Then
                    dr("PrimHesapla") = 1
                    dr("PrimOrani") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 0) / 100
                    dr("ParcaSayisi") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 1)
                    dr("Ciro") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 2)
                    dr("PrimTutari") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 3)
                    dr("MusteriSayisi") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 4)
                    gecti = hesapla_prim_kat(Trim(dr("Magaza")), 5)
                    If gecti = 0 Then
                        dr("Prim") = 0
                        dr("Aciklama") = "Kota Tutturulamadý"
                    ElseIf gecti = 1 Then
                        dr("Prim") = dr("PrimTutari")
                    End If
                End If
            ElseIf dr("Durum") = "KatÞefi" Then
                If Trim(dr("Magaza")) <> "" Then
                    dr("PrimHesapla") = 1
                    dr("PrimOrani") = hesapla_prim_kat(Trim(dr("Magaza")), 0) / 100
                    dr("ParcaSayisi") = hesapla_prim_kat(Trim(dr("Magaza")), 1)
                    dr("Ciro") = hesapla_prim_kat(Trim(dr("Magaza")), 2)
                    dr("PrimTutari") = hesapla_prim_kat(Trim(dr("Magaza")), 3)
                    dr("MusteriSayisi") = hesapla_prim_kat(Trim(dr("Magaza")), 4)
                    gecti = hesapla_prim_kat(Trim(dr("Magaza")), 5)
                    If gecti = 0 Then
                        dr("Prim") = 0
                        dr("Aciklama") = "Kota Tutturulamadý"
                    ElseIf gecti = 1 Then
                        dr("Prim") = dr("PrimTutari")
                        If dr("Aciklama") = "Kota Tutturulamadý" Then
                            dr("Aciklama") = ""
                        End If
                    End If
                End If
                bar1.Position += 1
                bar1.Refresh()
            End If
            dr("Net") = dr("BrutMaas") + (dr("Eklenti1") + dr("Eklenti2") + dr("Eklenti3") + dr("Eklenti4") + dr("Eklenti5")) - (dr("Kesinti1") + dr("Kesinti2") + dr("Kesinti3") + dr("Kesinti4") + dr("Kesinti5")) - dr("Avans") + dr("Prim")
            hareket_kaydet_degistir(dr("IND"), kayitno, dr("Sira"), dr("PersonelNo"), dr("SaticiRumuzu"), dr("HesapKodu"), dr("Magaza"), dr("Durum"), dr("Gorev"), dr("Adi"), dr("Normal"), dr("Izinli"), dr("Gecikmeli"), dr("Gun"), dr("BrutMaas"), dr("Eklenti1"), dr("Eklenti2"), dr("Eklenti3"), dr("Eklenti4"), dr("Eklenti5"), dr("Kesinti1"), dr("Kesinti2"), dr("Kesinti3"), dr("Kesinti4"), dr("Kesinti5"), dr("Avans"), dr("Prim"), dr("PrimHesapla"), dr("PrimOrani"), dr("PrimTutari"), dr("Ciro"), dr("ParcaSayisi"), dr("MusteriSayisi"), dr("ToplamCiro"), dr("CiroOrani"), dr("Kat"), dr("Net"), dr("Aciklama"), dr("Status"))
        Next
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = False
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub hesapla_prim_satir()
        Dim gecti As Integer = 0
        bar1.Properties.Maximum = 1
        bar1.Position = 0
        bar1.Visible = True
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr("Durum") = "SatýþPersoneli" Then
            If Trim(dr("SaticiRumuzu")) <> "" Then
                dr("PrimHesapla") = 1
                dr("PrimOrani") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 0) / 100
                dr("ParcaSayisi") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 1)
                dr("Ciro") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 2)
                dr("PrimTutari") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 3)
                dr("MusteriSayisi") = hesapla_prim_satici(Trim(dr("Magaza")), Trim(dr("SaticiRumuzu")), 4)
                gecti = hesapla_prim_kat(Trim(dr("Magaza")), 5)
                If gecti = 0 Then
                    dr("Prim") = 0
                    dr("Aciklama") = "Kota Tutturulamadý"
                ElseIf gecti = 1 Then
                    dr("Prim") = dr("PrimTutari")
                End If
            End If
        ElseIf dr("Durum") = "KatÞefi" Then
            If Trim(dr("Magaza")) <> "" Then
                dr("PrimHesapla") = 1
                dr("PrimOrani") = hesapla_prim_kat(Trim(dr("Magaza")), 0) / 100
                dr("ParcaSayisi") = hesapla_prim_kat(Trim(dr("Magaza")), 1)
                dr("Ciro") = hesapla_prim_kat(Trim(dr("Magaza")), 2)
                dr("PrimTutari") = hesapla_prim_kat(Trim(dr("Magaza")), 3)
                dr("MusteriSayisi") = hesapla_prim_kat(Trim(dr("Magaza")), 4)
                gecti = hesapla_prim_kat(Trim(dr("Magaza")), 5)
                If gecti = 0 Then
                    dr("Prim") = 0
                    dr("Aciklama") = "Kota Tutturulamadý"
                ElseIf gecti = 1 Then
                    dr("Prim") = dr("PrimTutari")
                    If dr("Aciklama") = "Kota Tutturulamadý" Then
                        dr("Aciklama") = ""
                    End If
                End If
            End If
            bar1.Position += 1
            bar1.Refresh()
        End If
        dr("Net") = dr("BrutMaas") + (dr("Eklenti1") + dr("Eklenti2") + dr("Eklenti3") + dr("Eklenti4") + dr("Eklenti5")) - (dr("Kesinti1") + dr("Kesinti2") + dr("Kesinti3") + dr("Kesinti4") + dr("Kesinti5")) - dr("Avans") + dr("Prim")
        hareket_kaydet_degistir(dr("IND"), kayitno, dr("Sira"), dr("PersonelNo"), dr("SaticiRumuzu"), dr("HesapKodu"), dr("Magaza"), dr("Durum"), dr("Gorev"), dr("Adi"), dr("Normal"), dr("Izinli"), dr("Gecikmeli"), dr("Gun"), dr("BrutMaas"), dr("Eklenti1"), dr("Eklenti2"), dr("Eklenti3"), dr("Eklenti4"), dr("Eklenti5"), dr("Kesinti1"), dr("Kesinti2"), dr("Kesinti3"), dr("Kesinti4"), dr("Kesinti5"), dr("Avans"), dr("Prim"), dr("PrimHesapla"), dr("PrimOrani"), dr("PrimTutari"), dr("Ciro"), dr("ParcaSayisi"), dr("MusteriSayisi"), dr("ToplamCiro"), dr("CiroOrani"), dr("Kat"), dr("Net"), dr("Aciklama"), dr("Status"))
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function hesapla_prim_satici(ByVal magaza As String, ByVal rumuz As String, ByVal islem As Integer) As Decimal
        Dim dr As DataRow
        Dim oran As Decimal
        Dim miktar As Decimal
        Dim ciro As Decimal
        Dim prim As Decimal
        Dim musterisayisi As Decimal
        Dim deger As Decimal = 0
        For Each dr In ds_satis_personel.Tables(0).Rows
            If Trim(dr("sSaticiRumuzu")) = rumuz Then
                oran = dr("PersonelOran")
                miktar = dr("Miktar")
                ciro = dr("Tutar")
                prim = dr("Prim")
                musterisayisi = dr("MUSTERISAYISI")
            End If
        Next
        If islem = 0 Then
            deger = oran
        ElseIf islem = 1 Then
            deger = miktar
        ElseIf islem = 2 Then
            deger = ciro
        ElseIf islem = 3 Then
            deger = prim
        ElseIf islem = 4 Then
            deger = musterisayisi
        End If
        Return deger
    End Function
    Private Function hesapla_prim_kat(ByVal magaza As String, ByVal islem As Integer) As Decimal
        Dim dr As DataRow
        Dim oran As Decimal = 0
        Dim miktar As Decimal = 0
        Dim ciro As Decimal = 0
        Dim prim As Decimal = 0
        Dim musterisayisi As Decimal = 0
        Dim gecti As Decimal
        Dim deger As Decimal = 0
        For Each dr In ds_satis_kat.Tables(0).Rows
            If Trim(dr("sKat")) = magaza Then
                oran = dr("KatOran")
                miktar = dr("Miktar")
                ciro = dr("Tutar")
                prim = dr("Prim")
                musterisayisi = dr("MUSTERISAYISI")
                If dr("Tutar") > dr("Kota") Then
                    gecti = 1
                End If
            End If
        Next
        If islem = 0 Then
            deger = oran
        ElseIf islem = 1 Then
            deger = miktar
        ElseIf islem = 2 Then
            deger = ciro
        ElseIf islem = 3 Then
            deger = prim
        ElseIf islem = 4 Then
            deger = musterisayisi
        ElseIf islem = 5 Then
            deger = gecti
        End If
        Return deger
    End Function
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            Dim dr_hareket As DataRow
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                hareket_kaydet_sil(dr_hareket("IND"))
                DataSet1.Tables(0).Rows.Remove(dr_hareket)
                GridControl1.Select()
                GridControl1.Focus()
            End If
            dr_hareket = Nothing
        End If
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            dr("Net") = dr("BrutMaas") + (dr("Eklenti1") + dr("Eklenti2") + dr("Eklenti3") + dr("Eklenti4") + dr("Eklenti5")) - (dr("Kesinti1") + dr("Kesinti2") + dr("Kesinti3") + dr("Kesinti4") + dr("Kesinti5")) - dr("Avans") + dr("Prim")
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), kayitno, dr("Sira"), dr("PersonelNo"), dr("SaticiRumuzu"), dr("HesapKodu"), dr("Magaza"), dr("Durum"), dr("Gorev"), dr("Adi"), dr("Normal"), dr("Izinli"), dr("Gecikmeli"), dr("Gun"), dr("BrutMaas"), dr("Eklenti1"), dr("Eklenti2"), dr("Eklenti3"), dr("Eklenti4"), dr("Eklenti5"), dr("Kesinti1"), dr("Kesinti2"), dr("Kesinti3"), dr("Kesinti4"), dr("Kesinti5"), dr("Avans"), dr("Prim"), dr("PrimHesapla"), dr("PrimOrani"), dr("PrimTutari"), dr("Ciro"), dr("ParcaSayisi"), dr("MusteriSayisi"), dr("ToplamCiro"), dr("CiroOrani"), dr("Kat"), dr("Net"), dr("Aciklama"), dr("Status"))
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub analiz_firma_karti()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("HesapKodu")) <> "" Then
                Dim nMusteriID = dr("HesapKodu") 'analiz_musteri_kayitno(Trim(txt_hesapno.Text))
                Dim frm As New frm_cari_yonetimi
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.sKodu = Trim(dr("HesapKodu"))
                frm.txt_sKodu.Text = Trim(dr("HesapKodu"))
                frm.nFirmaID = 1
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_personel_karti()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("HesapKodu")) <> "" Then
                'Dim nMusteriID = dr("HesapKodu") 'analiz_musteri_kayitno(Trim(txt_hesapno.Text))
                Dim frm As New frm_personel
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.islemstatus = True
                frm.kayitno = Trim(dr("PersonelNo"))
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        kayitno = sorgu_kayitno(txt_yil.EditValue, txt_ay.EditValue)
        Label2.Text = "Kontrol Ediliyor..."
        Label2.Refresh()
        If kayitno = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý Yeni Kayýt Eklemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                kayitno = baslik_kaydet_yeni(txt_yil.EditValue, txt_ay.EditValue, DateEdit1.EditValue, DateEdit2.EditValue, DateEdit3.EditValue, DateEdit4.EditValue, "", 0)
                sorgu_baslik("")
                dataload_harekets()
            End If
        ElseIf kayitno > 0 Then
            sorgu_baslik("")
            dataload_harekets()
        End If
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Refresh()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show(Sorgu_sDil("Personel Listesini Yenilemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            yenile()
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show(Sorgu_sDil("Personellerin Çektikleri Avanslarý Yenilemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            hesapla_avans()
            dataload_satis_satici(DateEdit1.EditValue, DateEdit2.EditValue)
            dataload_satis_kat(DateEdit1.EditValue, DateEdit2.EditValue)
            hesapla_prim()
        End If
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        satir_sil()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        analiz_firma_karti()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        baslik_kaydet()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        baslik_kaydet()
        Me.Close()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
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
    Private Sub sec_kapali_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_kapali.CheckStateChanged
        If sec_kapali.CheckState = CheckState.Checked Then
            GridView1.OptionsBehavior.Editable = False
            SimpleButton4.Enabled = False
            SimpleButton5.Enabled = False
            SimpleButton6.Enabled = False
            SimpleButton7.Enabled = False
        Else
            GridView1.OptionsBehavior.Editable = True
            SimpleButton4.Enabled = True
            SimpleButton5.Enabled = True
            SimpleButton6.Enabled = True
            SimpleButton7.Enabled = True
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If XtraMessageBox.Show(Sorgu_sDil("Personellerin Brüt Maaþ + Primlerini Yansýtmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            hesapla_yansit()
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        If XtraMessageBox.Show(Sorgu_sDil("Personellerin Brüt Maaþ + Prim Yansýtmalarýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            hesapla_yansit_sil()
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Personellerin Çektikleri Avanslarý Yenilemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            hesapla_avans_satir()
            dataload_satis_satici(DateEdit1.EditValue, DateEdit2.EditValue)
            dataload_satis_kat(DateEdit1.EditValue, DateEdit2.EditValue)
            hesapla_prim()
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_personel_karti()
    End Sub
End Class
