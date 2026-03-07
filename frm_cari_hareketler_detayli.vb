Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_cari_hareketler_detayli
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colsFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIslemAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaHarAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDevirBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDevirAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDevir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcTutarORT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutarORT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirenMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikanMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirenFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikanFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIslemtipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatirAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirenTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikanTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirenMiktar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikanMiktar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatirIsk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDipIsk1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDipIsk2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBirimCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcTutarORT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutarORT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmintarihOrt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bDovizli As System.Windows.Forms.CheckBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSatir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bBakiyeHesapla As System.Windows.Forms.CheckBox
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Firma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari_hareketler_detayli))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colToplamBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBorcTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacakTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToplamBorc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToplamAlacak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIslemAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaHarAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDevirBorc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDevirAlacak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDevir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBorcTutarORT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacakTutarORT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirenMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikanMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirenFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikanFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIslemtipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatirAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirenTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikanTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirenMiktar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikanMiktar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatirIsk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDipIsk1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDipIsk2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirimCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBorcTutarORT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacakTutarORT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmintarihOrt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSatir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCariIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatirIskonto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatirIskonto2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatirIskonto3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatirIskonto4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.toplamlariYazdir = New System.Windows.Forms.CheckBox()
        Me.sec_bBakiyeHesapla = New System.Windows.Forms.CheckBox()
        Me.sec_sDovizCinsi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_bDovizli = New System.Windows.Forms.CheckBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.lbl_Firma = New DevExpress.XtraEditors.LabelControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colToplamBakiye
        '
        Me.colToplamBakiye.Caption = "Bakiye"
        Me.colToplamBakiye.DisplayFormat.FormatString = "#,#.##(B);#,#.##(A);-"
        Me.colToplamBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamBakiye.FieldName = "lBakiye"
        Me.colToplamBakiye.Name = "colToplamBakiye"
        Me.colToplamBakiye.Visible = True
        Me.colToplamBakiye.VisibleIndex = 2
        '
        'coltip
        '
        Me.coltip.Caption = "tip"
        Me.coltip.FieldName = "tip"
        Me.coltip.Name = "coltip"
        Me.coltip.Width = 20
        '
        'collBorcTutar
        '
        Me.collBorcTutar.Caption = "Borç"
        Me.collBorcTutar.DisplayFormat.FormatString = "#,#.##"
        Me.collBorcTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutar.FieldName = "lBorcTutar"
        Me.collBorcTutar.Name = "collBorcTutar"
        Me.collBorcTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00}")})
        Me.collBorcTutar.Visible = True
        Me.collBorcTutar.VisibleIndex = 10
        Me.collBorcTutar.Width = 61
        '
        'collAlacakTutar
        '
        Me.collAlacakTutar.Caption = "Alacak"
        Me.collAlacakTutar.DisplayFormat.FormatString = "#,#.##"
        Me.collAlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutar.FieldName = "lAlacakTutar"
        Me.collAlacakTutar.Name = "collAlacakTutar"
        Me.collAlacakTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", "{0:#,0.00}")})
        Me.collAlacakTutar.Visible = True
        Me.collAlacakTutar.VisibleIndex = 11
        Me.collAlacakTutar.Width = 65
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(942, 56)
        Me.PanelControl1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stoklu Cari Hesap Hareketleri Aþaðýdaki Gibidir..."
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 412)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(942, 48)
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
        Me.SimpleButton2.Location = New System.Drawing.Point(856, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(781, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(942, 356)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(243, 126)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(258, 133)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Bakiye Analizi"
        Me.GroupControl1.Visible = False
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 21)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(254, 110)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsDovizCinsi, Me.colToplamBorc, Me.colToplamAlacak, Me.colToplamBakiye})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colToplamBakiye
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colToplamBakiye
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Doviz"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'colToplamBorc
        '
        Me.colToplamBorc.Caption = "Borç"
        Me.colToplamBorc.DisplayFormat.FormatString = "#,0.00"
        Me.colToplamBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamBorc.FieldName = "lBorcTutar"
        Me.colToplamBorc.Name = "colToplamBorc"
        Me.colToplamBorc.Visible = True
        Me.colToplamBorc.VisibleIndex = 0
        '
        'colToplamAlacak
        '
        Me.colToplamAlacak.Caption = "Alacak"
        Me.colToplamAlacak.DisplayFormat.FormatString = "#,0.00"
        Me.colToplamAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamAlacak.FieldName = "lAlacakTutar"
        Me.colToplamAlacak.Name = "colToplamAlacak"
        Me.colToplamAlacak.Visible = True
        Me.colToplamAlacak.VisibleIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 56)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(938, 298)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem13, Me.MenuItem14, Me.MenuItem16, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem26, Me.MenuItem19, Me.MenuItem10, Me.MenuItem18, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem17.Text = "Ara"
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
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Faturayý Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 5
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 7
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 8
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 9
        Me.MenuItem26.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 10
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem25, Me.MenuItem23, Me.MenuItem24, Me.MenuItem27})
        Me.MenuItem19.Text = "Raporla"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 0
        Me.MenuItem20.Text = "Önizle"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 1
        Me.MenuItem21.Text = "Dizayn"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 2
        Me.MenuItem22.Text = "Yazdýr"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.Text = "-"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 4
        Me.MenuItem23.Text = "Excel"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 5
        Me.MenuItem24.Text = "Txt"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 6
        Me.MenuItem27.Text = "Mail"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 11
        Me.MenuItem10.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 12
        Me.MenuItem18.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 13
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 14
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 15
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 16
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 17
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 18
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 19
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sFirmaKodu"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sFirmaAciklamasi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "dteIslemTarihi"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "dteValorTarihi"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "IslemAciklama"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "lFisNo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lBorcTutar"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lAlacakTutar"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Bakiye"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sFirmaHarAciklama"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sHareketTipi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "IslemTipi"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "dteKayitTarihi"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "nStokFisiID"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFirmaKodu, Me.colsFirmaAciklama, Me.coldteIslemTarihi, Me.coldteValorTarihi, Me.colIslemAciklama, Me.collFisNo, Me.collBorcTutar, Me.collAlacakTutar, Me.colBakiye, Me.colsFirmaHarAciklama, Me.colsHareketTipi, Me.collDevirBorc, Me.collDevirAlacak, Me.collDevir, Me.collBorcTutarORT, Me.collAlacakTutarORT, Me.colsStokKodu, Me.colsStokAciklama, Me.collGirenMiktar, Me.collCikanMiktar, Me.collGirenFiyat, Me.collCikanFiyat, Me.colIslemtipi, Me.collBrutFiyat, Me.colsSatirAciklama, Me.coltip, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsDovizCinsi2, Me.collDovizMiktari2, Me.collDovizKuru2, Me.collGirenTutar, Me.collCikanTutar, Me.collBrutTutar, Me.coldteKayitTarihi, Me.colnStokFisiID, Me.collGirenMiktar2, Me.collCikanMiktar2, Me.colSatirIsk, Me.colDipIsk1, Me.colDipIsk2, Me.colNetFiyat, Me.colNetTutar, Me.colFiyatTipi, Me.colBirimCinsi, Me.collBorcTutarORT1, Me.collAlacakTutarORT1, Me.colmintarihOrt1, Me.collMiktar, Me.colsRenkAdi, Me.colsBeden, Me.colsRenk, Me.colnSatir, Me.colsCariIslem, Me.colsIslem, Me.colKdvS, Me.colKdvA, Me.colSKullaniciAdi, Me.colAciklama1, Me.colAciklama2, Me.colnEvrakNo, Me.colsSatirIskonto1, Me.colsSatirIskonto2, Me.colsSatirIskonto3, Me.colsSatirIskonto4})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(590, 408, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.coltip
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Nothing, "Borc: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Nothing, "Alacak: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", Me.coldteIslemTarihi, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Me.collBorcTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Me.collAlacakTutar, "{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Firma Kodu"
        Me.colsFirmaKodu.FieldName = "sFirmaKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        Me.colsFirmaKodu.Width = 20
        '
        'colsFirmaAciklama
        '
        Me.colsFirmaAciklama.Caption = "Firma Adý"
        Me.colsFirmaAciklama.FieldName = "sFirmaAciklama"
        Me.colsFirmaAciklama.Name = "colsFirmaAciklama"
        Me.colsFirmaAciklama.Width = 20
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "Tarih"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Visible = True
        Me.coldteIslemTarihi.VisibleIndex = 1
        Me.coldteIslemTarihi.Width = 44
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valor"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Visible = True
        Me.coldteValorTarihi.VisibleIndex = 2
        Me.coldteValorTarihi.Width = 45
        '
        'colIslemAciklama
        '
        Me.colIslemAciklama.Caption = "Ýþlem"
        Me.colIslemAciklama.FieldName = "IslemAciklama"
        Me.colIslemAciklama.Name = "colIslemAciklama"
        Me.colIslemAciklama.Width = 44
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 4
        Me.collFisNo.Width = 57
        '
        'colBakiye
        '
        Me.colBakiye.Caption = "Bakiye"
        Me.colBakiye.DisplayFormat.FormatString = "#,#.##(B);#,#.##(A);-"
        Me.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBakiye.FieldName = "Bakiye"
        Me.colBakiye.Name = "colBakiye"
        Me.colBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bakiye", "{0:#,0.00}")})
        Me.colBakiye.Visible = True
        Me.colBakiye.VisibleIndex = 12
        Me.colBakiye.Width = 80
        '
        'colsFirmaHarAciklama
        '
        Me.colsFirmaHarAciklama.Caption = "Ekstre Açýklama"
        Me.colsFirmaHarAciklama.FieldName = "sFirmaHarAciklama"
        Me.colsFirmaHarAciklama.Name = "colsFirmaHarAciklama"
        Me.colsFirmaHarAciklama.Width = 20
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "HT"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Width = 20
        '
        'collDevirBorc
        '
        Me.collDevirBorc.Caption = "Devir Borc"
        Me.collDevirBorc.DisplayFormat.FormatString = "#,0.00"
        Me.collDevirBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDevirBorc.FieldName = "lDevirBorc"
        Me.collDevirBorc.Name = "collDevirBorc"
        Me.collDevirBorc.Width = 20
        '
        'collDevirAlacak
        '
        Me.collDevirAlacak.Caption = "Devir Alacak"
        Me.collDevirAlacak.DisplayFormat.FormatString = "#,0.00"
        Me.collDevirAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDevirAlacak.FieldName = "lDevirAlacak"
        Me.collDevirAlacak.Name = "collDevirAlacak"
        Me.collDevirAlacak.Width = 20
        '
        'collDevir
        '
        Me.collDevir.Caption = "Devir"
        Me.collDevir.DisplayFormat.FormatString = "#,0.00"
        Me.collDevir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDevir.FieldName = "lDevir"
        Me.collDevir.Name = "collDevir"
        Me.collDevir.Width = 20
        '
        'collBorcTutarORT
        '
        Me.collBorcTutarORT.Caption = "BorcOrt"
        Me.collBorcTutarORT.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutarORT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutarORT.FieldName = "lBorcTutarORT"
        Me.collBorcTutarORT.Name = "collBorcTutarORT"
        Me.collBorcTutarORT.Width = 20
        '
        'collAlacakTutarORT
        '
        Me.collAlacakTutarORT.Caption = "AlacakOrt"
        Me.collAlacakTutarORT.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutarORT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutarORT.FieldName = "lAlacakTutarORT"
        Me.collAlacakTutarORT.Name = "collAlacakTutarORT"
        Me.collAlacakTutarORT.Width = 20
        '
        'colsStokKodu
        '
        Me.colsStokKodu.Caption = "Kod"
        Me.colsStokKodu.FieldName = "sStokKodu"
        Me.colsStokKodu.Name = "colsStokKodu"
        Me.colsStokKodu.Visible = True
        Me.colsStokKodu.VisibleIndex = 5
        Me.colsStokKodu.Width = 95
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Açýklama"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 6
        Me.colsStokAciklama.Width = 150
        '
        'collGirenMiktar
        '
        Me.collGirenMiktar.Caption = "Giren"
        Me.collGirenMiktar.DisplayFormat.FormatString = "#,0.00##"
        Me.collGirenMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirenMiktar.FieldName = "lGirenMiktar"
        Me.collGirenMiktar.Name = "collGirenMiktar"
        Me.collGirenMiktar.Width = 20
        '
        'collCikanMiktar
        '
        Me.collCikanMiktar.Caption = "Çýkan"
        Me.collCikanMiktar.DisplayFormat.FormatString = "#,0.00##"
        Me.collCikanMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikanMiktar.FieldName = "lCikanMiktar"
        Me.collCikanMiktar.Name = "collCikanMiktar"
        Me.collCikanMiktar.Width = 20
        '
        'collGirenFiyat
        '
        Me.collGirenFiyat.Caption = "GirenFiyat"
        Me.collGirenFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.collGirenFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirenFiyat.FieldName = "lGirenFiyat"
        Me.collGirenFiyat.Name = "collGirenFiyat"
        Me.collGirenFiyat.Width = 20
        '
        'collCikanFiyat
        '
        Me.collCikanFiyat.Caption = "Çýkan Fiyat"
        Me.collCikanFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collCikanFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikanFiyat.FieldName = "lCikanFiyat"
        Me.collCikanFiyat.Name = "collCikanFiyat"
        Me.collCikanFiyat.Width = 20
        '
        'colIslemtipi
        '
        Me.colIslemtipi.Caption = "Ýþlem Tipi"
        Me.colIslemtipi.FieldName = "Islemtipi"
        Me.colIslemtipi.Name = "colIslemtipi"
        Me.colIslemtipi.Visible = True
        Me.colIslemtipi.VisibleIndex = 3
        Me.colIslemtipi.Width = 44
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,#.####"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 8
        Me.collBrutFiyat.Width = 53
        '
        'colsSatirAciklama
        '
        Me.colsSatirAciklama.Caption = "Açýklama"
        Me.colsSatirAciklama.FieldName = "sSatirAciklama"
        Me.colsSatirAciklama.Name = "colsSatirAciklama"
        Me.colsSatirAciklama.Width = 20
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi 1"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        Me.colsDovizCinsi1.Width = 20
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarý 1"
        Me.collDovizMiktari1.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        Me.collDovizMiktari1.Width = 20
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru 1"
        Me.collDovizKuru1.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizKuru1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        Me.collDovizKuru1.Width = 20
        '
        'colsDovizCinsi2
        '
        Me.colsDovizCinsi2.Caption = "Döviz Cinsi 2"
        Me.colsDovizCinsi2.FieldName = "sDovizCinsi2"
        Me.colsDovizCinsi2.Name = "colsDovizCinsi2"
        Me.colsDovizCinsi2.Width = 20
        '
        'collDovizMiktari2
        '
        Me.collDovizMiktari2.Caption = "Döviz Miktarý 2"
        Me.collDovizMiktari2.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizMiktari2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari2.FieldName = "lDovizMiktari2"
        Me.collDovizMiktari2.Name = "collDovizMiktari2"
        Me.collDovizMiktari2.Width = 20
        '
        'collDovizKuru2
        '
        Me.collDovizKuru2.Caption = "Döviz Kuru 2"
        Me.collDovizKuru2.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizKuru2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru2.FieldName = "lDovizKuru2"
        Me.collDovizKuru2.Name = "collDovizKuru2"
        Me.collDovizKuru2.Width = 20
        '
        'collGirenTutar
        '
        Me.collGirenTutar.Caption = "Giren Tutar"
        Me.collGirenTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirenTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirenTutar.FieldName = "lGirenTutar"
        Me.collGirenTutar.Name = "collGirenTutar"
        Me.collGirenTutar.Width = 20
        '
        'collCikanTutar
        '
        Me.collCikanTutar.Caption = "Çýkan Tutarý"
        Me.collCikanTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collCikanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikanTutar.FieldName = "lCikanTutar"
        Me.collCikanTutar.Name = "collCikanTutar"
        Me.collCikanTutar.Width = 20
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,#.####"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Visible = True
        Me.collBrutTutar.VisibleIndex = 9
        Me.collBrutTutar.Width = 48
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Saat"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.Width = 20
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Stok Fiþi ID"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        Me.colnStokFisiID.Width = 20
        '
        'collGirenMiktar2
        '
        Me.collGirenMiktar2.Caption = "Giren 2"
        Me.collGirenMiktar2.DisplayFormat.FormatString = "#,0.00##"
        Me.collGirenMiktar2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirenMiktar2.FieldName = "lGirenMiktar2"
        Me.collGirenMiktar2.Name = "collGirenMiktar2"
        Me.collGirenMiktar2.Width = 20
        '
        'collCikanMiktar2
        '
        Me.collCikanMiktar2.Caption = "Çýkan 2"
        Me.collCikanMiktar2.DisplayFormat.FormatString = "#,0.00##"
        Me.collCikanMiktar2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikanMiktar2.FieldName = "lCikanMiktar2"
        Me.collCikanMiktar2.Name = "collCikanMiktar2"
        Me.collCikanMiktar2.Width = 20
        '
        'colSatirIsk
        '
        Me.colSatirIsk.Caption = "Satýr Ýsk."
        Me.colSatirIsk.FieldName = "SatirIsk"
        Me.colSatirIsk.Name = "colSatirIsk"
        Me.colSatirIsk.Width = 20
        '
        'colDipIsk1
        '
        Me.colDipIsk1.Caption = "Dip.Ýsk.1"
        Me.colDipIsk1.FieldName = "DipIsk1"
        Me.colDipIsk1.Name = "colDipIsk1"
        Me.colDipIsk1.Width = 20
        '
        'colDipIsk2
        '
        Me.colDipIsk2.Caption = "Dip.Ýsk.2"
        Me.colDipIsk2.FieldName = "DipIsk2"
        Me.colDipIsk2.Name = "colDipIsk2"
        Me.colDipIsk2.Width = 20
        '
        'colNetFiyat
        '
        Me.colNetFiyat.Caption = "Net Fiyat"
        Me.colNetFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.colNetFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNetFiyat.FieldName = "NetFiyat"
        Me.colNetFiyat.Name = "colNetFiyat"
        '
        'colNetTutar
        '
        Me.colNetTutar.Caption = "Net Tutar"
        Me.colNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNetTutar.FieldName = "NetTutar"
        Me.colNetTutar.Name = "colNetTutar"
        '
        'colFiyatTipi
        '
        Me.colFiyatTipi.Caption = "FiyatTipi"
        Me.colFiyatTipi.FieldName = "FiyatTipi"
        Me.colFiyatTipi.Name = "colFiyatTipi"
        Me.colFiyatTipi.Width = 20
        '
        'colBirimCinsi
        '
        Me.colBirimCinsi.Caption = "Birim"
        Me.colBirimCinsi.FieldName = "BirimCinsi"
        Me.colBirimCinsi.Name = "colBirimCinsi"
        Me.colBirimCinsi.Width = 20
        '
        'collBorcTutarORT1
        '
        Me.collBorcTutarORT1.Caption = "BorcOrt1"
        Me.collBorcTutarORT1.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutarORT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutarORT1.FieldName = "lBorcTutarORT1"
        Me.collBorcTutarORT1.Name = "collBorcTutarORT1"
        Me.collBorcTutarORT1.Width = 20
        '
        'collAlacakTutarORT1
        '
        Me.collAlacakTutarORT1.Caption = "AlacakOrt1"
        Me.collAlacakTutarORT1.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutarORT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutarORT1.FieldName = "lAlacakTutarORT1"
        Me.collAlacakTutarORT1.Name = "collAlacakTutarORT1"
        Me.collAlacakTutarORT1.Width = 20
        '
        'colmintarihOrt1
        '
        Me.colmintarihOrt1.Caption = "mintarihOrt1"
        Me.colmintarihOrt1.FieldName = "mintarihOrt1"
        Me.colmintarihOrt1.Name = "colmintarihOrt1"
        Me.colmintarihOrt1.Width = 20
        '
        'collMiktar
        '
        Me.collMiktar.Caption = "Miktar"
        Me.collMiktar.DisplayFormat.FormatString = "#,#.####"
        Me.collMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktar.FieldName = "lMiktar"
        Me.collMiktar.Name = "collMiktar"
        Me.collMiktar.Visible = True
        Me.collMiktar.VisibleIndex = 7
        Me.collMiktar.Width = 39
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "RenkAdi"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colnSatir
        '
        Me.colnSatir.Caption = "Sira"
        Me.colnSatir.FieldName = "nSatir"
        Me.colnSatir.Name = "colnSatir"
        Me.colnSatir.Visible = True
        Me.colnSatir.VisibleIndex = 0
        Me.colnSatir.Width = 33
        '
        'colsCariIslem
        '
        Me.colsCariIslem.Caption = "CariIslem"
        Me.colsCariIslem.FieldName = "sCariIslem"
        Me.colsCariIslem.Name = "colsCariIslem"
        '
        'colsIslem
        '
        Me.colsIslem.Caption = "Ýþlem"
        Me.colsIslem.FieldName = "sIslem"
        Me.colsIslem.Name = "colsIslem"
        '
        'colKdvS
        '
        Me.colKdvS.Caption = "Satýþ KDV"
        Me.colKdvS.FieldName = "kdvS"
        Me.colKdvS.Name = "colKdvS"
        Me.colKdvS.Visible = True
        Me.colKdvS.VisibleIndex = 13
        '
        'colKdvA
        '
        Me.colKdvA.Caption = "Alýþ KDV"
        Me.colKdvA.FieldName = "kdvA"
        Me.colKdvA.Name = "colKdvA"
        Me.colKdvA.Visible = True
        Me.colKdvA.VisibleIndex = 14
        '
        'colSKullaniciAdi
        '
        Me.colSKullaniciAdi.Caption = "Açýklama(kullanýcý)"
        Me.colSKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colSKullaniciAdi.Name = "colSKullaniciAdi"
        '
        'colAciklama1
        '
        Me.colAciklama1.Caption = "Açýklama 1"
        Me.colAciklama1.FieldName = "aciklama1"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Visible = True
        Me.colAciklama1.VisibleIndex = 15
        '
        'colAciklama2
        '
        Me.colAciklama2.Caption = "Açýklama 2"
        Me.colAciklama2.FieldName = "aciklama2"
        Me.colAciklama2.Name = "colAciklama2"
        Me.colAciklama2.Visible = True
        Me.colAciklama2.VisibleIndex = 16
        '
        'colnEvrakNo
        '
        Me.colnEvrakNo.Caption = "Evrak No"
        Me.colnEvrakNo.FieldName = "nEvrakNo"
        Me.colnEvrakNo.Name = "colnEvrakNo"
        Me.colnEvrakNo.Visible = True
        Me.colnEvrakNo.VisibleIndex = 17
        '
        'colsSatirIskonto1
        '
        Me.colsSatirIskonto1.Caption = "Satýr Iskonto 1"
        Me.colsSatirIskonto1.FieldName = "SatirIskonto1"
        Me.colsSatirIskonto1.Name = "colsSatirIskonto1"
        '
        'colsSatirIskonto2
        '
        Me.colsSatirIskonto2.Caption = "Satýr Iskonto 2"
        Me.colsSatirIskonto2.FieldName = "SatirIskonto2"
        Me.colsSatirIskonto2.Name = "colsSatirIskonto2"
        '
        'colsSatirIskonto3
        '
        Me.colsSatirIskonto3.Caption = "Satýr Iskonto 3"
        Me.colsSatirIskonto3.FieldName = "SatirIskonto3"
        Me.colsSatirIskonto3.Name = "colsSatirIskonto3"
        '
        'colsSatirIskonto4
        '
        Me.colsSatirIskonto4.Caption = "Satýr Iskonto 4"
        Me.colsSatirIskonto4.FieldName = "SatirIskonto4"
        Me.colsSatirIskonto4.Name = "colsSatirIskonto4"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.toplamlariYazdir)
        Me.PanelControl4.Controls.Add(Me.sec_bBakiyeHesapla)
        Me.PanelControl4.Controls.Add(Me.sec_sDovizCinsi)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl4.Controls.Add(Me.sec_bDovizli)
        Me.PanelControl4.Controls.Add(Me.SimpleButton3)
        Me.PanelControl4.Controls.Add(Me.DateEdit2)
        Me.PanelControl4.Controls.Add(Me.DateEdit1)
        Me.PanelControl4.Controls.Add(Me.lbl_Firma)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(938, 54)
        Me.PanelControl4.TabIndex = 1
        '
        'toplamlariYazdir
        '
        Me.toplamlariYazdir.AutoSize = True
        Me.toplamlariYazdir.Location = New System.Drawing.Point(465, 6)
        Me.toplamlariYazdir.Name = "toplamlariYazdir"
        Me.toplamlariYazdir.Size = New System.Drawing.Size(106, 17)
        Me.toplamlariYazdir.TabIndex = 24
        Me.toplamlariYazdir.Text = "Toplamlarý Yazdýr"
        Me.toplamlariYazdir.UseVisualStyleBackColor = True
        '
        'sec_bBakiyeHesapla
        '
        Me.sec_bBakiyeHesapla.AutoSize = True
        Me.sec_bBakiyeHesapla.Location = New System.Drawing.Point(465, 29)
        Me.sec_bBakiyeHesapla.Name = "sec_bBakiyeHesapla"
        Me.sec_bBakiyeHesapla.Size = New System.Drawing.Size(98, 17)
        Me.sec_bBakiyeHesapla.TabIndex = 23
        Me.sec_bBakiyeHesapla.Text = "Bakiye Hesapla"
        Me.sec_bBakiyeHesapla.UseVisualStyleBackColor = True
        '
        'sec_sDovizCinsi
        '
        Me.sec_sDovizCinsi.Enabled = False
        Me.sec_sDovizCinsi.EnterMoveNextControl = True
        Me.sec_sDovizCinsi.Location = New System.Drawing.Point(359, 27)
        Me.sec_sDovizCinsi.Name = "sec_sDovizCinsi"
        Me.sec_sDovizCinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDovizCinsi.Properties.DisplayMember = "sDovizCinsi"
        Me.sec_sDovizCinsi.Properties.NullText = "[Doviz]"
        Me.sec_sDovizCinsi.Properties.ValueMember = "sDovizCinsi"
        Me.sec_sDovizCinsi.Size = New System.Drawing.Size(100, 20)
        Me.sec_sDovizCinsi.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(3, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "FirmaKodu:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.EnterMoveNextControl = True
        Me.txt_musteriNo.Location = New System.Drawing.Point(85, 3)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(207, 20)
        Me.txt_musteriNo.TabIndex = 0
        '
        'sec_bDovizli
        '
        Me.sec_bDovizli.AutoSize = True
        Me.sec_bDovizli.Location = New System.Drawing.Point(297, 30)
        Me.sec_bDovizli.Name = "sec_bDovizli"
        Me.sec_bDovizli.Size = New System.Drawing.Size(56, 17)
        Me.sec_bDovizli.TabIndex = 3
        Me.sec_bDovizli.Text = "Dovizli"
        Me.sec_bDovizli.UseVisualStyleBackColor = True
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(569, 27)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 5
        Me.SimpleButton3.Text = "Listele"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(191, 27)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 2
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(85, 27)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 1
        '
        'lbl_Firma
        '
        Me.lbl_Firma.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Firma.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Firma.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_Firma.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Firma.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Firma.Location = New System.Drawing.Point(298, 3)
        Me.lbl_Firma.Name = "lbl_Firma"
        Me.lbl_Firma.Size = New System.Drawing.Size(243, 20)
        Me.lbl_Firma.TabIndex = 20
        Me.lbl_Firma.Text = "*"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.printlink})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 100)
        Me.printlink1.Owner = Me.printlink
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Cari Hesap Hareketleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink
        '
        Me.printlink.BreakSpace = 10
        '
        '
        '
        Me.printlink.ImageCollection.ImageStream = CType(resources.GetObject("printlink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        Me.printlink.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink.Owner = Nothing
        Me.printlink.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink.PrintingSystem = Me.ps
        Me.printlink.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.GridControl2
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.Owner = Me.printlink
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Txt"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Mail"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(942, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 460)
        Me.barDockControlBottom.Size = New System.Drawing.Size(942, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 460)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(942, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 460)
        '
        'frm_cari_hareketler_detayli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(942, 483)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cari_hareketler_detayli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stoklu Cari Hesap Hareketleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.sec_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino As String = ""
    Public kullanici
    Dim lDevir As Decimal = 0
    Public sModul As String = "Cari"
    Public sDovizCinsi As String = ""
    Dim ds_tbDovizCinsi As DataSet
    Public nFirmaId As Int64 = 0
    Public sKodu As String = ""
    Public sFirmaAciklama As String = ""
    Dim dataset2 As DataSet
    Private Sub frm_cari_hareketler_detayli_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("CARI").CreateSubKey("YENIKART").SetValue("bBakiyeHesapla", sec_bBakiyeHesapla.Checked)
    End Sub
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        Try
            sec_bBakiyeHesapla.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("CARI").OpenSubKey("YENIKART").GetValue("bBakiyeHesapla").ToString
        Catch ex As Exception
            sec_bBakiyeHesapla.Checked = False
        End Try
        dataload_tbDovizCinsi()
        If Trim(sDovizCinsi) <> "" Then
            sec_bDovizli.Checked = True
        End If
        If musterino.ToString <> "" Then
            txt_musteriNo.Text = musterino
            lbl_Firma.Text = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select TOP 1 sAciklama from tbFirma Where sKodu = '" & musterino & "'")
        End If
        ara()
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
        Dim kriter As String = ""
        kriter += "Kod: " & Trim(txt_musteriNo.Text) & " Aciklama: " & lbl_Firma.Text & vbCrLf & DateEdit1.EditValue & " ve " & DateEdit2.EditValue & Sorgu_sDil(" Tarihleri Arasýndaki Stoklu Cari Hesap Hareketleri", sDil) & vbCrLf
        'kriter += lbl_Firma.Text & "#" & DateEdit1.EditValue & " ve " & DateEdit2.EditValue & " Tarihleri Arasýndaki Stoklu Cari Hesap Hareketleri" & vbCrLf
        kriter += "Devir Bakiyesi: " & FormatNumber(lDevir, 2)
        colToplamAlacak.Visible = toplamlariYazdir.Checked
        colToplamBakiye.Visible = toplamlariYazdir.Checked
        colToplamBorc.Visible = toplamlariYazdir.Checked
        printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub ara()
        If musterino <> "" Then
            Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
            Label2.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, sec_bDovizli.Checked, Trim(sec_sDovizCinsi.EditValue))
            Label2.Text = Sorgu_sDil(Sorgu_sDil("Tamamlandý...", sDil), sDil)
            Label2.Refresh()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        Else
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi,sAciklama FROM tbDovizCinsi"))
        sec_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Ekstre*.frx) |Ekstre_Detayli*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Cari Ekstre\Ekstre_Detayli.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Cari Ekstre\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            report.RegisterData(DataSet1)
            report.RegisterData(dataset2)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("Devreden", lDevir)
            report.SetParameterValue("dteTarih1", DateEdit1.EditValue)
            report.SetParameterValue("dteTarih2", DateEdit2.EditValue)
            report.SetParameterValue("sKodu", sKodu)
            report.SetParameterValue("nFirmaID", nFirmaId)
            'report.GetDataSource("Table1").Enabled = True
            'report.GetDataSource("Table2").Enabled = True
            report.ScriptLanguage = FastReport.Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                'report.Prepare()
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = txt_musteriNo.Text & "_Ekstre.xls"
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
            SaveFileDialog1.FileName = txt_musteriNo.Text & "_Ekstre.txt"
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
    Public Function stok(ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean, ByVal sDovizCinsi As String) As DataSet
        Dim kriter As String = ""
        If sDovizCinsi <> "" Then
            kriter += " AND (tbFirmaHareketi.sDovizCinsi1 ='" & sDovizCinsi & "') "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'If bDovizli = False Then
        '    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT nFirmaID,sFirmaKodu, sFirmaAciklama, dteIslemTarihi, dteValorTarihi AS dteValorTarihi, IslemAciklama, lFisNo, lBorcTutar, lAlacakTutar, Bakiye, sFirmaHarAciklama, sHareketTipi, lDevirBorc, lDevirAlacak, lDevir, lBorcTutarORT, lAlacakTutarORT, sStokKodu, sStokAciklama, lGirenMiktar, lCikanMiktar, lMiktar, lGirenFiyat, lCikanFiyat, Islemtipi, lBrutFiyat, sSatirAciklama, tip, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, lGirenTutar, lCikanTutar, lBrutTutar, dteKayitTarihi, nStokFisiID,nGirisCikis, lGirenMiktar2, lCikanMiktar2, SatirIsk, DipIsk1, DipIsk2, NetFiyat, NetTutar, FiyatTipi, BirimCinsi, lBorcTutarORT1, lAlacakTutarORT1, mintarihOrt1 FROM (SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, CONVERT(char(8), tbFirmaHareketi.dteIslemTarihi, 3) AS dteIslemTarihi, CONVERT(char(8), tbFirmaHareketi.dteValorTarihi, 3) AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.lBorcTutar AS lBorcTutar, tbFirmaHareketi.lAlacakTutar AS lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sAciklama + (CASE WHEN sHangiUygulama IN ('AC', 'AS', 'BC', 'BS') THEN ' - ' + (SELECT sBorclusu + (CASE bKendineAit WHEN 1 THEN '(Kendi Çeki)' ELSE '' END) FROM tbCekSenet, tbCekSenetBordro WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.nCariHareketID = tbFirmaHareketi.nHareketID) ELSE '' END) AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, isnull(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, isnull(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir, 0 AS lBorcTutarORT, 0 AS lAlacakTutarORT, '' AS sStokKodu, '' AS sStokAciklama, 0 AS lMiktar, 0 AS lGirenMiktar, 0 AS lCikanMiktar, 0 AS lGirenFiyat, 0 AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 0 AS tip, 0 AS lBrutFiyat, '' AS sSatirAciklama, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0 AS lGirenTutar, 0 AS lCikanTutar, 0 AS lBrutTutar, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, 0 AS nstokfisiID,0 AS nGirisCikis, 0 AS lGirenMiktar2, 0 AS lCikanMiktar2, 0 AS SatirIsk, 0 AS DipIsk1, 0 AS DipIsk2, 0 AS NetFiyat, 0 AS NetTutar, '' AS FiyatTipi, '' AS BirimCinsi, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORT1, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORT1, tbTempMinTarih.MinTarih AS mintarihOrt1 FROM tbFirma, tbCariIslem, tbFirmaHareketi LEFT OUTER JOIN (SELECT SUM(isnull(lDevirBorc, 0)) lDevirBorc, SUM(isnull(lDevirAlacak, 0)) lDevirAlacak, SUM(isnull(lDevirBorc, 0)) - SUM(isnull(lDevirAlacak, 0)) AS lDevir, SUM(isnull(lBorcTutarORTDevir, 0)) lBorcTutarORTDevir, SUM(isnull(lAlacakTutarORTDevir, 0)) lAlacakTutarORTDevir, nFirmaID FROM (SELECT tbFirmaHareketi.lBorcTutar AS lDevirBorc, tbFirmaHareketi.lAlacakTutar AS lDevirAlacak, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORTDevir, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID, nHareketID FROM tbFirmaHareketi FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE dteIslemTarihi < '" & dteIslemTarihi1 & "') AS tbTempDevir GROUP BY nFirmaID) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem AND tbFirma.sKodu = '" & musterino & "' UNION ALL SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, '' sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi AS dteIslemTarihi, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, '' AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, 0 AS lBorcTutar, 0 AS lAlacakTutar, 0 AS Bakiye, '' AS sHareketTipi, tbStokFisiAciklamasi.saciklama1 + '½' + tbStokFisiAciklamasi.saciklama2 + '½' + tbStokFisiAciklamasi.saciklama3 + '½' + tbStokFisiAciklamasi.saciklama4 + '½' + tbStokFisiAciklamasi.saciklama5 AS sFirmaHarAciklama, 0 AS lDevirBorc, 0 AS lDevirAlacak, 0 AS lDevir, 0 AS lBorcTutarORT, 0 AS lBorcAlacakORT, tbStok.sKodu AS sStokKodu, rtrim(tbStok.sAciklama) + (CASE WHEN sRenkAdi = '' THEN '' ELSE ' - ' END) + rtrim(sRenkAdi) AS sStokAciklama, abs(lGirisMiktar1 - lCikisMiktar1) AS lMiktar, lGirisMiktar1 AS lGirenMiktar, lCikisMiktar1 AS lCikanMiktar, lGirisFiyat AS lGirenFiyat, lCikisFiyat AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 1 AS tip, lBrutFiyat = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) ELSE CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) END, ltrim(rtrim(tbstokFisiDetayi.sAciklama)) + (CASE WHEN tbStokFisiDetayi.nHesapID <> 0 THEN ' - ' + tbParti.sKodu ELSE '' END) AS sSatirAciklama, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, lGirisTutar AS lGirenTutar, lcikisTutar AS lCikanTutar, lBrutTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN lGirisMiktar1 * (CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) ELSE lCikisMiktar1 * (CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) END, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, tbStokFisiDetayi.nStokfisiID,tbStokFisiDetayi.nGirisCikis, lGirisMiktar2 AS lGirenMiktar2, lCikisMiktar2 AS lCikanMiktar2, tbStokFisiDetayi.nIskontoYuzdesi AS SatirIsk, tbStokFisiMaster.nDipIskontoYuzdesi1 AS DipIsk1, tbStokFisiMaster.nDipIskontoYuzdesi2 AS DipIsk2, NetFiyat = CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN lBrutFiyat / tbStokFisiDetayi.lDovizKuru1 ELSE lBrutFiyat END, NetTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lGirisMiktar1 ELSE lBrutFiyat * lGirisMiktar1 END) ELSE (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lCikisMiktar1 ELSE lBrutFiyat * lCikisMiktar1 END) END, tbstokfisiDetayi.sFiyatTipi AS FiyatTipi, tbStok.sBirimCinsi1 AS BirimCinsi, 0 AS lBorcTutarORT1, 0 AS lAlacakTutarORT1, '' AS mintarihOrt1 FROM tbFirma, tbFirmaHareketi, tbStokFisiDetayi, tbStok, tbRenk, tbParti, tbStokFisiMaster, tbStokFisiAciklamasi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirma.sKodu = '" & musterino & "' AND tbFirmaHareketi.sCariIslem <> 'KDV' AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND cast(tbStokFisiDetayi.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiDetayi.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiDetayi.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbRenk.sRenk = tbStok.sRenk AND tbStokFisiDetayi.nHesapID = tbParti.nPartiID AND tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND cast(tbStokFisiMaster.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiMaster.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiMAster.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStokFisiAciklamasi.nStokFisiId = tbStokFisimaster.nStokFisiId AND tbStokFisiMaster.nGirisCikis = tbStokFisiDetayi.nGirisCikis AND tbStokFisiMaster.nFirmaID = tbStokFisiDetayi.nFirmaID AND tbStokFisiMaster.sFisTipi = tbStokFisiDetayi.sFisTipi AND tbStokFisiMaster.lFisno = tbStokFisiDetayi.lFisno AND tbStokFisiMaster.dteFisTarihi = tbStokFisiDetayi.dteFisTarihi) AS tbTemp ORDER BY year(dteIslemTarihi), month(dteIslemTarihi), day(dteIslemTarihi), dteIslemTarihi, year(dteValorTarihi), month(dteValorTarihi), day(dteValorTarihi), dteValorTarihi, dteKayitTarihi, nHareketID, IslemTipi, lFisNo, tip ")
        'ElseIf bDovizli = True Then
        '    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT nFirmaID,sFirmaKodu, sFirmaAciklama, dteIslemTarihi, dteValorTarihi AS dteValorTarihi, IslemAciklama, lFisNo, lBorcTutar, lAlacakTutar, Bakiye, sFirmaHarAciklama, sHareketTipi, lDevirBorc, lDevirAlacak, lDevir, lBorcTutarORT, lAlacakTutarORT, sStokKodu, sStokAciklama, lGirenMiktar, lCikanMiktar, lMiktar, lGirenFiyat, lCikanFiyat, Islemtipi, lBrutFiyat, sSatirAciklama, tip, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, lGirenTutar, lCikanTutar, lBrutTutar, dteKayitTarihi, nStokFisiID,nGirisCikis, lGirenMiktar2, lCikanMiktar2, SatirIsk, DipIsk1, DipIsk2, NetFiyat, NetTutar, FiyatTipi, BirimCinsi, lBorcTutarORT1, lAlacakTutarORT1, mintarihOrt1 FROM (SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, CONVERT(char(8), tbFirmaHareketi.dteIslemTarihi, 3) AS dteIslemTarihi, CONVERT(char(8), tbFirmaHareketi.dteValorTarihi, 3) AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, Bakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sAciklama + (CASE WHEN sHangiUygulama IN ('AC', 'AS', 'BC', 'BS') THEN ' - ' + (SELECT sBorclusu + (CASE bKendineAit WHEN 1 THEN '(Kendi Çeki)' ELSE '' END) FROM tbCekSenet, tbCekSenetBordro WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.nCariHareketID = tbFirmaHareketi.nHareketID) ELSE '' END) AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, isnull(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, isnull(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir, 0 AS lBorcTutarORT, 0 AS lAlacakTutarORT, '' AS sStokKodu, '' AS sStokAciklama, 0 AS lMiktar, 0 AS lGirenMiktar, 0 AS lCikanMiktar, 0 AS lGirenFiyat, 0 AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 0 AS tip, 0 AS lBrutFiyat, '' AS sSatirAciklama, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0 AS lGirenTutar, 0 AS lCikanTutar, 0 AS lBrutTutar, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, 0 AS nstokfisiID,0 AS nGirisCikis, 0 AS lGirenMiktar2, 0 AS lCikanMiktar2, 0 AS SatirIsk, 0 AS DipIsk1, 0 AS DipIsk2, 0 AS NetFiyat, 0 AS NetTutar, '' AS FiyatTipi, '' AS BirimCinsi, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORT1, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORT1, tbTempMinTarih.MinTarih AS mintarihOrt1 FROM tbFirma, tbCariIslem, tbFirmaHareketi LEFT OUTER JOIN (SELECT sDovizCinsi1 as sDoviz,SUM(ISNULL(lDevirBorc, 0)) AS lDevirBorc, SUM(ISNULL(lDevirAlacak, 0)) AS lDevirAlacak, SUM(ISNULL(lDevirBorc, 0)) - SUM(ISNULL(lDevirAlacak, 0)) AS lDevir, SUM(ISNULL(lBorcTutarORTDevir, 0)) AS lBorcTutarORTDevir, SUM(ISNULL(lAlacakTutarORTDevir, 0)) AS lAlacakTutarORTDevir, nFirmaID FROM (SELECT tbFirmaHareketi.sDovizCinsi1,lDevirBorc = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lDevirAlacak = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lDevir = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORTDevir, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID, nHareketID FROM tbFirmaHareketi FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE dteIslemTarihi < '" & dteIslemTarihi1 & "') tbTempDevir GROUP BY nFirmaID,sDovizCinsi1) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID and tbFirmaHareketi.sDovizCinsi1 = tbTempFirmahareketi.sDoviz FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem AND tbFirma.sKodu = '" & musterino & "' " & kriter & " UNION ALL SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, '' sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi AS dteIslemTarihi, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, '' AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, 0 AS lBorcTutar, 0 AS lAlacakTutar, 0 AS Bakiye, '' AS sHareketTipi, tbStokFisiAciklamasi.saciklama1 + '½' + tbStokFisiAciklamasi.saciklama2 + '½' + tbStokFisiAciklamasi.saciklama3 + '½' + tbStokFisiAciklamasi.saciklama4 + '½' + tbStokFisiAciklamasi.saciklama5 AS sFirmaHarAciklama, 0 AS lDevirBorc, 0 AS lDevirAlacak, 0 AS lDevir, 0 AS lBorcTutarORT, 0 AS lBorcAlacakORT, tbStok.sKodu AS sStokKodu, rtrim(tbStok.sAciklama) + (CASE WHEN sRenkAdi = '' THEN '' ELSE ' - ' END) + rtrim(sRenkAdi) AS sStokAciklama, abs(lGirisMiktar1 - lCikisMiktar1) AS lMiktar, lGirisMiktar1 AS lGirenMiktar, lCikisMiktar1 AS lCikanMiktar, lGirisFiyat AS lGirenFiyat, lCikisFiyat AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 1 AS tip, lBrutFiyat = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) ELSE CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) END, ltrim(rtrim(tbstokFisiDetayi.sAciklama)) + (CASE WHEN tbStokFisiDetayi.nHesapID <> 0 THEN ' - ' + tbParti.sKodu ELSE '' END) AS sSatirAciklama, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, lGirisTutar AS lGirenTutar, lcikisTutar AS lCikanTutar, lBrutTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN lGirisMiktar1 * (CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) ELSE lCikisMiktar1 * (CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) END, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, tbStokFisiDetayi.nStokfisiID,tbStokFisiDetayi.nGirisCikis, lGirisMiktar2 AS lGirenMiktar2, lCikisMiktar2 AS lCikanMiktar2, tbStokFisiDetayi.nIskontoYuzdesi AS SatirIsk, tbStokFisiMaster.nDipIskontoYuzdesi1 AS DipIsk1, tbStokFisiMaster.nDipIskontoYuzdesi2 AS DipIsk2, NetFiyat = CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN lBrutFiyat / tbStokFisiDetayi.lDovizKuru1 ELSE lBrutFiyat END, NetTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lGirisMiktar1 ELSE lBrutFiyat * lGirisMiktar1 END) ELSE (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lCikisMiktar1 ELSE lBrutFiyat * lCikisMiktar1 END) END, tbstokfisiDetayi.sFiyatTipi AS FiyatTipi, tbStok.sBirimCinsi1 AS BirimCinsi, 0 AS lBorcTutarORT1, 0 AS lAlacakTutarORT1, '' AS mintarihOrt1 FROM tbFirma, tbFirmaHareketi, tbStokFisiDetayi, tbStok, tbRenk, tbParti, tbStokFisiMaster, tbStokFisiAciklamasi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirma.sKodu = '" & musterino & "' AND tbFirmaHareketi.sCariIslem <> 'KDV' AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' " & kriter & " AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND cast(tbStokFisiDetayi.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiDetayi.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiDetayi.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbRenk.sRenk = tbStok.sRenk AND tbStokFisiDetayi.nHesapID = tbParti.nPartiID AND tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND cast(tbStokFisiMaster.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiMaster.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiMAster.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStokFisiAciklamasi.nStokFisiId = tbStokFisimaster.nStokFisiId AND tbStokFisiMaster.nGirisCikis = tbStokFisiDetayi.nGirisCikis AND tbStokFisiMaster.nFirmaID = tbStokFisiDetayi.nFirmaID AND tbStokFisiMaster.sFisTipi = tbStokFisiDetayi.sFisTipi AND tbStokFisiMaster.lFisno = tbStokFisiDetayi.lFisno AND tbStokFisiMaster.dteFisTarihi = tbStokFisiDetayi.dteFisTarihi) AS tbTemp ORDER BY sDovizCinsi1,year(dteIslemTarihi), month(dteIslemTarihi), day(dteIslemTarihi), dteIslemTarihi, year(dteValorTarihi), month(dteValorTarihi), day(dteValorTarihi), dteValorTarihi, dteKayitTarihi, nHareketID, IslemTipi, lFisNo, tip ")
        'End If
        If sec_bBakiyeHesapla.Checked = True Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT *,0 as nSatir,0 as lDevir,'' sFirmaHarAciklama,sSatir as sSatirAciklama FROM (SELECT 1 as tip,tbFirmaHareketi.nHareketID, tbFirmaHareketi.nFirmaID, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.sHangiUygulama AS sFisTipi, tbFirmaHareketi.sHangiUygulama Islemtipi,tbFirmaHareketi.sEvrakNo AS lFisNo, ' ' nStokFisiID, ' ' AS sDepo, sCariIslem AS sStokKodu, tbFirmaHareketi.sCariIslem AS sModel, tbFirmaHareketi.sAciklama sStokAciklama, '' AS sRenk, '' AS sBeden, 0 AS lGirisMiktar1, 0 AS lCikisMiktar1, '' AS sBirimCinsi, 1 AS lBirimMiktar, Cast(0 AS Money) lMiktar, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lAlacakTutar AS Bakiye, CAST(0 AS Money) AS lBrutFiyat, CAST(0 AS money) AS lBrutTutar, 0 AS nKdvOrani, 0 as nGirisCikis,CAST(0 AS Money) AS nIskontoYuzdesi, CAST(0 AS Money) AS lIskontoTutari, tbFirmaHareketi.sAciklama AS sSatir, tbFirmaHareketi.sKullaniciAdi, CAST(0 AS Money) AS lIlaveMaliyetTutar, CAST(0 AS Money) AS lGirisFiyat, CAST(0 AS Money) AS lGirisTutar, CAST(0 AS Money) AS lCikisFiyat, CAST(0 AS Money) AS lCikisTutar, '' AS sFiyatTipi, '' AS sSaticiRumuzu, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, ' ' sNot FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND (tbFirmaHareketi.sHangiUygulama NOT IN ('FS', 'FA', 'HA', 'HS')) AND (tbFirma.sKodu = '" & musterino & "' ) UNION ALL SELECT 1 as tip,tbStokFisiOdemePlani.nCariHareketID AS nHareketID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.dteIslemTarihi, tbStokFisiOdemePlani.dteVadeTarihi AS dteValorTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sFisTipi Islemtipi,CAST(tbStokFisiDetayi.lFisNo AS CHAR(20)) lFisNo, CAST(tbStokFisiDetayi.nStokFisiID AS CHAR(20)) nStokFisiID, tbStokFisiDetayi.sDepo, tbStok.sKodu AS sStokKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbStok.sRenk, tbStok.sBeden, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.sBirimCinsi, tbStokFisiDetayi.lBirimMiktar, lMiktar = CASE WHEN tbStokFisiDetayi.lCikisMiktar1 = 0 THEN tbStokFisiDetayi.lGirisMiktar1 ELSE tbStokFisiDetayi.lCikisMiktar1 END, lBorcTutar = CASE WHEN tbStokFisiMaster.nGirisCikis = 2 OR tbStokFisiMaster.nGirisCikis = 3 THEN lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE 0 END, lAlacakTutar = CASE WHEN tbStokFisiMaster.nGirisCikis = 1 OR tbStokFisiMaster.nGirisCikis = 4 THEN ABS(lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) ELSE 0 END, Cast(0 AS Money) Bakiye, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sAciklama AS sSatir, tbStokFisiDetayi.sKullaniciAdi, tbStokFisiDetayi.lIlaveMaliyetTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.dteKayitTarihi, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, tbStokFisiAciklamasi.sAciklama1 AS sNot FROM tbStokFisiDetayi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStokFisiOdemePlani ON tbStokFisiMaster.nStokFisiID = tbStokFisiOdemePlani.nStokFisiID LEFT OUTER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE tbStokFisiDetayi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND (tbFirma.sKodu = '" & musterino & "') AND (tbStokFisiDetayi.sFisTipi IN ('FS', 'FA', 'HA', 'HS'))) tbEkstre ORDER BY dteIslemTarihi, sFisTipi, nStokFisiID, lFisNo ")
            'Bakiye Hesapla Sorunundan Dolayý Kapatýldý cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT *,0 as nSatir,'' sFirmaHarAciklama,sSatir as sSatirAciklama FROM (SELECT ISNULL(tbStokFisiMaster.nEvrakNo, 0) as nEvrakNo, 1 as tip,tbFirmaHareketi.nHareketID, tbFirmaHareketi.nFirmaID, tbFirma.sKodu,tbFirma.sAciklama as sFirmaAciklama,tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.sHangiUygulama AS sFisTipi, tbFirmaHareketi.sCariIslem,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem,tbFirmaHareketi.sHangiUygulama Islemtipi,tbFirmaHareketi.sEvrakNo AS lFisNo, ' ' nStokFisiID, ' ' AS sDepo, sCariIslem AS sStokKodu, tbFirmaHareketi.sCariIslem AS sModel, tbFirmaHareketi.sAciklama sStokAciklama, '' AS sRenk, '' AS sBeden, 0 AS lGirisMiktar1, 0 AS lCikisMiktar1, '' AS sBirimCinsi, 1 AS lBirimMiktar, Cast(0 AS Money) lMiktar, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lAlacakTutar AS Bakiye, CAST(0 AS Money) AS lBrutFiyat, CAST(0 AS money) AS lBrutTutar, 0 AS nKdvOrani, 0 as nGirisCikis,CAST(0 AS Money) AS nIskontoYuzdesi, CAST(0 AS Money) AS lIskontoTutari, tbFirmaHareketi.sAciklama AS sSatir, tbFirmaHareketi.sKullaniciAdi, CAST(0 AS Money) AS lIlaveMaliyetTutar, CAST(0 AS Money) AS lGirisFiyat, CAST(0 AS Money) AS lGirisTutar, CAST(0 AS Money) AS lCikisFiyat, CAST(0 AS Money) AS lCikisTutar, '' AS sFiyatTipi, '' AS sSaticiRumuzu, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, ' ' sNot,isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(isnull(lDevirBorc, 0)) lDevirBorc, SUM(isnull(lDevirAlacak, 0)) lDevirAlacak, SUM(isnull(lDevirBorc, 0)) - SUM(isnull(lDevirAlacak, 0)) AS lDevir, SUM(isnull(lBorcTutarORTDevir, 0)) lBorcTutarORTDevir, SUM(isnull(lAlacakTutarORTDevir, 0)) lAlacakTutarORTDevir, nFirmaID FROM (SELECT tbFirmaHareketi.lBorcTutar AS lDevirBorc, tbFirmaHareketi.lAlacakTutar AS lDevirAlacak, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORTDevir, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID, nHareketID FROM tbFirmaHareketi FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE dteIslemTarihi < '" & dteIslemTarihi1 & "') AS tbTempDevir GROUP BY nFirmaID) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND (tbFirmaHareketi.sHangiUygulama NOT IN ('FS', 'FA', 'HA', 'HS','T','MM')) AND (tbFirma.sKodu = '" & musterino & "' ) UNION ALL SELECT 1 as tip,tbStokFisiOdemePlani.nCariHareketID AS nHareketID, tbStokFisiDetayi.nFirmaID, tbFirma.sKodu,tbFirma.sAciklama as sFirmaAciklama,tbStokFisiDetayi.dteIslemTarihi, tbStokFisiOdemePlani.dteVadeTarihi AS dteValorTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sFisTipi as sCariIslem,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbStokFisiDetayi.sFisTipi) sIslem,tbStokFisiDetayi.sFisTipi Islemtipi,CAST(tbStokFisiDetayi.lFisNo AS CHAR(20)) lFisNo, CAST(tbStokFisiDetayi.nStokFisiID AS CHAR(20)) nStokFisiID, tbStokFisiDetayi.sDepo, tbStok.sKodu AS sStokKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbStok.sRenk, tbStok.sBeden, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.sBirimCinsi, tbStokFisiDetayi.lBirimMiktar, lMiktar = CASE WHEN tbStokFisiDetayi.lCikisMiktar1 = 0 THEN tbStokFisiDetayi.lGirisMiktar1 ELSE tbStokFisiDetayi.lCikisMiktar1 END, lBorcTutar = CASE WHEN tbStokFisiMaster.nGirisCikis = 1 and tbStokFisiDetayi.lGirisMiktar1 < 0 THEN ABS(lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) WHEN tbStokFisiMaster.nGirisCikis = 2 THEN ABS(lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) WHEN tbStokFisiMaster.nGirisCikis = 3 AND tbStokFisiDetayi.lCikisMiktar1 > 0 THEN ABS(lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani)) / 100 WHEN tbStokFisiMaster.nGirisCikis = 4 THEN 0 ELSE 0 END, lAlacakTutar = CASE WHEN tbStokFisiMaster.nGirisCikis = 1 and tbStokFisiDetayi.lGirisMiktar1 > 0 THEN ABS(lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100)  WHEN tbStokFisiMaster.nGirisCikis = 2 THEN 0 WHEN tbStokFisiMaster.nGirisCikis = 3 AND tbStokFisiDetayi.lCikisMiktar1 < 0 THEN ABS(lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani)) / 100 WHEN tbStokFisiMaster.nGirisCikis = 4 THEN ABS(lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) ELSE 0 END, Cast(0 AS Money) Bakiye, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sAciklama AS sSatir, tbStokFisiDetayi.sKullaniciAdi, tbStokFisiDetayi.lIlaveMaliyetTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.dteKayitTarihi, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, tbStokFisiAciklamasi.sAciklama1 AS sNot,Cast(0 as money) lDevir FROM tbStokFisiDetayi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStokFisiOdemePlani ON tbStokFisiMaster.nStokFisiID = tbStokFisiOdemePlani.nStokFisiID LEFT OUTER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE tbStokFisiDetayi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND (tbFirma.sKodu = '" & musterino & "') AND (tbStokFisiDetayi.sFisTipi IN ('FS', 'FA', 'HA', 'HS','T','MM'))) tbEkstre ORDER BY dteIslemTarihi, sFisTipi, nStokFisiID, lFisNo ")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT *,0 as nSatir,'' sFirmaHarAciklama,sSatir as sSatirAciklama FROM (SELECT 1 as tip,tbFirmaHareketi.nHareketID, tbFirmaHareketi.nFirmaID, tbFirma.sKodu,tbFirma.sAciklama as sFirmaAciklama,tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.sHangiUygulama AS sFisTipi, tbFirmaHareketi.sCariIslem,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem,tbFirmaHareketi.sHangiUygulama Islemtipi,tbFirmaHareketi.sEvrakNo AS lFisNo, ' ' nStokFisiID, ' ' AS sDepo, sCariIslem AS sStokKodu, tbFirmaHareketi.sCariIslem AS sModel, tbFirmaHareketi.sAciklama sStokAciklama, '' AS sRenk, '' AS sBeden, 0 AS lGirisMiktar1, 0 AS lCikisMiktar1, '' AS sBirimCinsi, 1 AS lBirimMiktar, Cast(0 AS Money) lMiktar, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lAlacakTutar AS Bakiye, CAST(0 AS Money) AS lBrutFiyat, CAST(0 AS money) AS lBrutTutar, 0 AS nKdvOrani, 0 as nGirisCikis,CAST(0 AS Money) AS nIskontoYuzdesi, CAST(0 AS Money) AS lIskontoTutari, tbFirmaHareketi.sAciklama AS sSatir, tbFirmaHareketi.sKullaniciAdi, CAST(0 AS Money) AS lIlaveMaliyetTutar, CAST(0 AS Money) AS lGirisFiyat, CAST(0 AS Money) AS lGirisTutar, CAST(0 AS Money) AS lCikisFiyat, CAST(0 AS Money) AS lCikisTutar, '' AS sFiyatTipi, '' AS sSaticiRumuzu, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, ' ' sNot,isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(isnull(lDevirBorc, 0)) lDevirBorc, SUM(isnull(lDevirAlacak, 0)) lDevirAlacak, SUM(isnull(lDevirBorc, 0)) - SUM(isnull(lDevirAlacak, 0)) AS lDevir, SUM(isnull(lBorcTutarORTDevir, 0)) lBorcTutarORTDevir, SUM(isnull(lAlacakTutarORTDevir, 0)) lAlacakTutarORTDevir, nFirmaID FROM (SELECT tbFirmaHareketi.lBorcTutar AS lDevirBorc, tbFirmaHareketi.lAlacakTutar AS lDevirAlacak, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORTDevir, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID, nHareketID FROM tbFirmaHareketi FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE dteIslemTarihi < '" & dteIslemTarihi1 & "') AS tbTempDevir GROUP BY nFirmaID) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND (tbFirmaHareketi.sHangiUygulama NOT IN ('FS', 'FA', 'HA', 'HS','T','MM')) AND (tbFirma.sKodu = '" & musterino & "' ) UNION ALL SELECT 1 as tip,tbStokFisiOdemePlani.nCariHareketID AS nHareketID, tbStokFisiDetayi.nFirmaID, tbFirma.sKodu,tbFirma.sAciklama as sFirmaAciklama,tbStokFisiDetayi.dteIslemTarihi, tbStokFisiOdemePlani.dteVadeTarihi AS dteValorTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sFisTipi as sCariIslem,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbStokFisiDetayi.sFisTipi) sIslem,tbStokFisiDetayi.sFisTipi Islemtipi,CAST(tbStokFisiDetayi.lFisNo AS CHAR(20)) lFisNo, CAST(tbStokFisiDetayi.nStokFisiID AS CHAR(20)) nStokFisiID, tbStokFisiDetayi.sDepo, tbStok.sKodu AS sStokKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbStok.sRenk, tbStok.sBeden, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.sBirimCinsi, tbStokFisiDetayi.lBirimMiktar, lMiktar = CASE WHEN tbStokFisiDetayi.lCikisMiktar1 = 0 THEN tbStokFisiDetayi.lGirisMiktar1 ELSE tbStokFisiDetayi.lCikisMiktar1 END, lBorcTutar = CASE WHEN tbStokFisiMaster.nGirisCikis = 1 and tbStokFisiDetayi.lGirisMiktar1 < 0 THEN ABS(lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) WHEN tbStokFisiMaster.nGirisCikis = 2 THEN ABS(lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) WHEN tbStokFisiMaster.nGirisCikis = 3 AND tbStokFisiDetayi.lCikisMiktar1 > 0 THEN ABS(lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani)) / 100 WHEN tbStokFisiMaster.nGirisCikis = 4 THEN 0 ELSE 0 END, lAlacakTutar = CASE WHEN tbStokFisiMaster.nGirisCikis = 1 and tbStokFisiDetayi.lGirisMiktar1 > 0 THEN ABS(lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100)  WHEN tbStokFisiMaster.nGirisCikis = 2 THEN 0 WHEN tbStokFisiMaster.nGirisCikis = 3 AND tbStokFisiDetayi.lCikisMiktar1 < 0 THEN ABS(lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani)) / 100 WHEN tbStokFisiMaster.nGirisCikis = 4 THEN ABS(lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) ELSE 0 END, Cast(0 AS Money) Bakiye, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sAciklama AS sSatir, tbStokFisiDetayi.sKullaniciAdi, tbStokFisiDetayi.lIlaveMaliyetTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.dteKayitTarihi, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, tbStokFisiAciklamasi.sAciklama1 AS sNot,Cast(0 as money) lDevir FROM tbStokFisiDetayi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStokFisiOdemePlani ON tbStokFisiMaster.nStokFisiID = tbStokFisiOdemePlani.nStokFisiID LEFT OUTER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE tbStokFisiDetayi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND (tbFirma.sKodu = '" & musterino & "') AND (tbStokFisiDetayi.sFisTipi IN ('FS', 'FA', 'HA', 'HS','T','MM'))) tbEkstre ORDER BY dteIslemTarihi, sFisTipi, nStokFisiID, lFisNo ")

        Else
            If bDovizli = False Then
                'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT 0 as nSatir,nFirmaID,sFirmaKodu, sFirmaAciklama, dteIslemTarihi, dteValorTarihi AS dteValorTarihi, IslemAciklama, lFisNo, lBorcTutar, lAlacakTutar, Bakiye, sFirmaHarAciklama, sHareketTipi, lDevirBorc, lDevirAlacak, lDevir, lBorcTutarORT, lAlacakTutarORT, sStokKodu, sStokAciklama,sRenkAdi,sBeden, sRenk,lGirenMiktar, lCikanMiktar, lMiktar, lGirenFiyat, lCikanFiyat, Islemtipi, lBrutFiyat, sSatirAciklama, tip, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, lGirenTutar, lCikanTutar, lBrutTutar, dteKayitTarihi, nStokFisiID,nGirisCikis, lGirenMiktar2, lCikanMiktar2, SatirIsk, DipIsk1, DipIsk2, NetFiyat, NetTutar, FiyatTipi, BirimCinsi, lBorcTutarORT1, lAlacakTutarORT1, mintarihOrt1 FROM (SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, CONVERT(char(8), tbFirmaHareketi.dteIslemTarihi, 3) AS dteIslemTarihi, CONVERT(char(8), tbFirmaHareketi.dteValorTarihi, 3) AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.lBorcTutar AS lBorcTutar, tbFirmaHareketi.lAlacakTutar AS lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sAciklama + (CASE WHEN sHangiUygulama IN ('AC', 'AS', 'BC', 'BS') THEN ' - ' + (SELECT sBorclusu + (CASE bKendineAit WHEN 1 THEN '(Kendi Çeki)' ELSE '' END) FROM tbCekSenet, tbCekSenetBordro WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.nCariHareketID = tbFirmaHareketi.nHareketID) ELSE '' END) AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, isnull(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, isnull(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir, 0 AS lBorcTutarORT, 0 AS lAlacakTutarORT, (SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sStokKodu, '' AS sStokAciklama, '' sRenkAdi,'' sBeden,'' sRenk,0 AS lMiktar, 0 AS lGirenMiktar, 0 AS lCikanMiktar, 0 AS lGirenFiyat, 0 AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 0 AS tip, 0 AS lBrutFiyat, '' AS sSatirAciklama, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0 AS lGirenTutar, 0 AS lCikanTutar, 0 AS lBrutTutar, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, 0 AS nstokfisiID,0 AS nGirisCikis, 0 AS lGirenMiktar2, 0 AS lCikanMiktar2, 0 AS SatirIsk, 0 AS DipIsk1, 0 AS DipIsk2, 0 AS NetFiyat, 0 AS NetTutar, '' AS FiyatTipi, '' AS BirimCinsi, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORT1, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORT1, tbTempMinTarih.MinTarih AS mintarihOrt1 FROM tbFirma, tbCariIslem, tbFirmaHareketi LEFT OUTER JOIN (SELECT SUM(isnull(lDevirBorc, 0)) lDevirBorc, SUM(isnull(lDevirAlacak, 0)) lDevirAlacak, SUM(isnull(lDevirBorc, 0)) - SUM(isnull(lDevirAlacak, 0)) AS lDevir, SUM(isnull(lBorcTutarORTDevir, 0)) lBorcTutarORTDevir, SUM(isnull(lAlacakTutarORTDevir, 0)) lAlacakTutarORTDevir, nFirmaID FROM (SELECT tbFirmaHareketi.lBorcTutar AS lDevirBorc, tbFirmaHareketi.lAlacakTutar AS lDevirAlacak, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORTDevir, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID, nHareketID FROM tbFirmaHareketi FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE dteIslemTarihi < '" & dteIslemTarihi1 & "') AS tbTempDevir GROUP BY nFirmaID) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem AND tbFirma.sKodu = '" & musterino & "' UNION ALL SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, '' sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi AS dteIslemTarihi, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, '' AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, 0 AS lBorcTutar, 0 AS lAlacakTutar, 0 AS Bakiye, '' AS sHareketTipi, tbStokFisiAciklamasi.saciklama1 + '½' + tbStokFisiAciklamasi.saciklama2 + '½' + tbStokFisiAciklamasi.saciklama3 + '½' + tbStokFisiAciklamasi.saciklama4 + '½' + tbStokFisiAciklamasi.saciklama5 AS sFirmaHarAciklama, 0 AS lDevirBorc, 0 AS lDevirAlacak, 0 AS lDevir, 0 AS lBorcTutarORT, 0 AS lBorcAlacakORT, tbStok.sKodu AS sStokKodu, rtrim(tbStok.sAciklama) + (CASE WHEN sRenkAdi = '' THEN '' ELSE ' - ' END) + rtrim(sRenkAdi) AS sStokAciklama, sRenkAdi,tbStok.sBeden,tbStok.sRenk,abs(lGirisMiktar1 - lCikisMiktar1) AS lMiktar, lGirisMiktar1 AS lGirenMiktar, lCikisMiktar1 AS lCikanMiktar, lGirisFiyat AS lGirenFiyat, lCikisFiyat AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 1 AS tip, lBrutFiyat = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) ELSE CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) END, ltrim(rtrim(tbstokFisiDetayi.sAciklama)) + (CASE WHEN tbStokFisiDetayi.nHesapID <> 0 THEN ' - ' + tbParti.sKodu ELSE '' END) AS sSatirAciklama, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, lGirisTutar AS lGirenTutar, lcikisTutar AS lCikanTutar, lBrutTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN lGirisMiktar1 * (CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) ELSE lCikisMiktar1 * (CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) END, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, tbStokFisiDetayi.nStokfisiID,tbStokFisiDetayi.nGirisCikis, lGirisMiktar2 AS lGirenMiktar2, lCikisMiktar2 AS lCikanMiktar2, tbStokFisiDetayi.nIskontoYuzdesi AS SatirIsk, tbStokFisiMaster.nDipIskontoYuzdesi1 AS DipIsk1, tbStokFisiMaster.nDipIskontoYuzdesi2 AS DipIsk2, NetFiyat = CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN lBrutFiyat / tbStokFisiDetayi.lDovizKuru1 ELSE lBrutFiyat END, NetTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lGirisMiktar1 ELSE lBrutFiyat * lGirisMiktar1 END) ELSE (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lCikisMiktar1 ELSE lBrutFiyat * lCikisMiktar1 END) END, tbstokfisiDetayi.sFiyatTipi AS FiyatTipi, tbStok.sBirimCinsi1 AS BirimCinsi, 0 AS lBorcTutarORT1, 0 AS lAlacakTutarORT1, '' AS mintarihOrt1 FROM tbFirma, tbFirmaHareketi, tbStokFisiDetayi, tbStok, tbRenk, tbParti, tbStokFisiMaster, tbStokFisiAciklamasi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirma.sKodu = '" & musterino & "' AND tbFirmaHareketi.sCariIslem <> 'KDV' AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND cast(tbStokFisiDetayi.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiDetayi.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiDetayi.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbRenk.sRenk = tbStok.sRenk AND tbStokFisiDetayi.nHesapID = tbParti.nPartiID AND tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND cast(tbStokFisiMaster.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiMaster.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiMAster.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStokFisiAciklamasi.nStokFisiId = tbStokFisimaster.nStokFisiId AND tbStokFisiMaster.nGirisCikis = tbStokFisiDetayi.nGirisCikis AND tbStokFisiMaster.nFirmaID = tbStokFisiDetayi.nFirmaID AND tbStokFisiMaster.sFisTipi = tbStokFisiDetayi.sFisTipi AND tbStokFisiMaster.lFisno = tbStokFisiDetayi.lFisno AND tbStokFisiMaster.dteFisTarihi = tbStokFisiDetayi.dteFisTarihi AND tbStokFisiDetayi.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1 ) AS tbTemp ORDER BY year(dteIslemTarihi), month(dteIslemTarihi), day(dteIslemTarihi), dteIslemTarihi, year(dteValorTarihi), month(dteValorTarihi), day(dteValorTarihi), dteValorTarihi, dteKayitTarihi, nHareketID, IslemTipi, lFisNo, tip ")
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT 0 as nSatir, nFirmaID,sFirmaKodu, sFirmaAciklama, dteIslemTarihi, dteValorTarihi AS dteValorTarihi, IslemAciklama, lFisNo, lBorcTutar, lAlacakTutar, Bakiye, sFirmaHarAciklama, sHareketTipi, lDevirBorc, lDevirAlacak, lDevir, lBorcTutarORT, lAlacakTutarORT, sStokKodu, sStokAciklama,sRenkAdi,sBeden, sRenk, kdvS, kdvA, lGirenMiktar, lCikanMiktar, lMiktar, lGirenFiyat, lCikanFiyat, Islemtipi, lBrutFiyat, sSatirAciklama, SatirIskonto1, SatirIskonto2, SatirIskonto3, SatirIskonto4, tip, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, lGirenTutar, lCikanTutar, lBrutTutar, dteKayitTarihi, nStokFisiID,nGirisCikis, lGirenMiktar2, lCikanMiktar2, nEvrakNo, SatirIsk, DipIsk1, DipIsk2, NetFiyat, NetTutar, nKdvOrani,FiyatTipi, BirimCinsi, lBorcTutarORT1, lAlacakTutarORT1, mintarihOrt1, sKullaniciAdi, aciklama1, aciklama2 FROM (SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, CONVERT(char(8), tbFirmaHareketi.dteIslemTarihi, 3) AS dteIslemTarihi, CONVERT(char(8), tbFirmaHareketi.dteValorTarihi, 3) AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.lBorcTutar AS lBorcTutar, tbFirmaHareketi.lAlacakTutar AS lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sAciklama + (CASE WHEN sHangiUygulama IN ('AC', 'AS', 'BC', 'BS') THEN ' - ' + (SELECT sBorclusu + (CASE bKendineAit WHEN 1 THEN '(Kendi Çeki)' ELSE '' END) FROM tbCekSenet, tbCekSenetBordro WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.nCariHareketID = tbFirmaHareketi.nHareketID) ELSE '' END) AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, isnull(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, isnull(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir, 0 AS lBorcTutarORT, 0 AS lAlacakTutarORT, (SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sStokKodu, '' AS sStokAciklama, '' sRenkAdi,'' sBeden,'' sRenk, 0 kdvS, 0 kdvA, 0 AS lMiktar, 0 AS lGirenMiktar, 0 AS lCikanMiktar, 0 AS lGirenFiyat, 0 AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 0 AS tip, 0 AS lBrutFiyat, '' AS sSatirAciklama, 0 as SatirIskonto1, 0 as SatirIskonto2, 0 as SatirIskonto3, 0 as SatirIskonto4, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0 AS lGirenTutar, 0 AS lCikanTutar, 0 AS lBrutTutar, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, 0 AS nstokfisiID,0 AS nGirisCikis, 0 AS lGirenMiktar2, 0 AS lCikanMiktar2, '' AS nEvrakNo, 0 AS SatirIsk, 0 AS DipIsk1, 0 AS DipIsk2, 0 AS NetFiyat, 0 AS NetTutar, 0 as nKdvOrani,'' AS FiyatTipi, '' AS BirimCinsi, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORT1, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORT1, tbTempMinTarih.MinTarih AS mintarihOrt1, '' AS sKullaniciAdi, '' as aciklama1, '' as aciklama2 FROM tbFirma, tbCariIslem, tbFirmaHareketi LEFT OUTER JOIN (SELECT SUM(isnull(lDevirBorc, 0)) lDevirBorc, SUM(isnull(lDevirAlacak, 0)) lDevirAlacak, SUM(isnull(lDevirBorc, 0)) - SUM(isnull(lDevirAlacak, 0)) AS lDevir, SUM(isnull(lBorcTutarORTDevir, 0)) lBorcTutarORTDevir, SUM(isnull(lAlacakTutarORTDevir, 0)) lAlacakTutarORTDevir, nFirmaID FROM (SELECT tbFirmaHareketi.lBorcTutar AS lDevirBorc, tbFirmaHareketi.lAlacakTutar AS lDevirAlacak, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORTDevir, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID, nHareketID FROM tbFirmaHareketi FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE dteIslemTarihi < '" & dteIslemTarihi1 & "') AS tbTempDevir GROUP BY nFirmaID) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem AND tbFirma.sKodu = '" & musterino & "' UNION ALL SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, '' sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi AS dteIslemTarihi, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, '' AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, 0 AS lBorcTutar, 0 AS lAlacakTutar, 0 AS Bakiye, '' AS sHareketTipi, tbStokFisiAciklamasi.saciklama1 + '½' + tbStokFisiAciklamasi.saciklama2 + '½' + tbStokFisiAciklamasi.saciklama3 + '½' + tbStokFisiAciklamasi.saciklama4 + '½' + tbStokFisiAciklamasi.saciklama5 AS sFirmaHarAciklama, 0 AS lDevirBorc, 0 AS lDevirAlacak, 0 AS lDevir, 0 AS lBorcTutarORT, 0 AS lBorcAlacakORT, tbStok.sKodu AS sStokKodu, rtrim(tbStok.sAciklama) + (CASE WHEN sRenkAdi = '' THEN '' ELSE ' - ' END) + rtrim(sRenkAdi) AS sStokAciklama, sRenkAdi,tbStok.sBeden,tbStok.sRenk, (select ISNULL(nKdvOrani,0) from tbKdv where tbkdv.sKdvTipi=tbStok.sKdvTipi) as kdvS, (select ISNULL(nKdvOrani,0) from tbKdv where tbkdv.sKdvTipi=tbStok.sAlisKdvTipi) as kdvA, abs(lGirisMiktar1 - lCikisMiktar1) AS lMiktar, lGirisMiktar1 AS lGirenMiktar, lCikisMiktar1 AS lCikanMiktar, lGirisFiyat AS lGirenFiyat, lCikisFiyat AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 1 AS tip, lBrutFiyat = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) ELSE CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) END, ltrim(rtrim(tbstokFisiDetayi.sAciklama)) + (CASE WHEN tbStokFisiDetayi.nHesapID <> 0 THEN ' - ' + tbParti.sKodu ELSE '' END) AS sSatirAciklama, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 6, 5) as numeric(4, 2)) as SatirIskonto1, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 17, 5) as numeric(4, 2)) as SatirIskonto2, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 28, 5) as numeric(4, 2)) as SatirIskonto3, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 39, 5) as numeric(4, 2)) as SatirIskonto4, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, lGirisTutar AS lGirenTutar, lcikisTutar AS lCikanTutar, lBrutTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN lGirisMiktar1 * (CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) ELSE lCikisMiktar1 * (CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) END, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, tbStokFisiDetayi.nStokfisiID,tbStokFisiDetayi.nGirisCikis, lGirisMiktar2 AS lGirenMiktar2, lCikisMiktar2 AS lCikanMiktar2, CAST(ISNULL(tbStokFisiMaster.nEvrakNo, '0') AS VARCHAR(15)) as nEvrakNo, tbStokFisiDetayi.nIskontoYuzdesi AS SatirIsk, tbStokFisiMaster.nDipIskontoYuzdesi1 AS DipIsk1, tbStokFisiMaster.nDipIskontoYuzdesi2 AS DipIsk2, NetFiyat = CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN lBrutFiyat / tbStokFisiDetayi.lDovizKuru1 ELSE lBrutFiyat END, NetTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lGirisMiktar1 ELSE lBrutFiyat * lGirisMiktar1 END) ELSE (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lCikisMiktar1 ELSE lBrutFiyat * lCikisMiktar1 END) END, tbStokFisiDetayi.nKdvOrani,tbstokfisiDetayi.sFiyatTipi AS FiyatTipi, tbStok.sBirimCinsi1 AS BirimCinsi, 0 AS lBorcTutarORT1, 0 AS lAlacakTutarORT1, '' AS mintarihOrt1, tbStokFisiDetayi.sKullaniciAdi AS sKullaniciAdi, tbStokFisiAciklamasi.saciklama1 as aciklama1, tbStokFisiAciklamasi.saciklama2 as aciklama2 FROM tbFirma, tbFirmaHareketi, tbStokFisiDetayi, tbStok, tbRenk, tbParti, tbStokFisiMaster, tbStokFisiAciklamasi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirma.sKodu = '" & musterino & "' AND tbFirmaHareketi.sCariIslem <> 'KDV' AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND cast(tbStokFisiDetayi.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiDetayi.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiDetayi.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbRenk.sRenk = tbStok.sRenk AND tbStokFisiDetayi.nHesapID = tbParti.nPartiID AND tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND cast(tbStokFisiMaster.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiMaster.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiMAster.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStokFisiAciklamasi.nStokFisiId = tbStokFisimaster.nStokFisiId AND tbStokFisiMaster.nGirisCikis = tbStokFisiDetayi.nGirisCikis AND tbStokFisiMaster.nFirmaID = tbStokFisiDetayi.nFirmaID AND tbStokFisiMaster.sFisTipi = tbStokFisiDetayi.sFisTipi AND tbStokFisiMaster.lFisno = tbStokFisiDetayi.lFisno AND tbStokFisiMaster.dteFisTarihi = tbStokFisiDetayi.dteFisTarihi AND tbStokFisiDetayi.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1 ) AS tbTemp ORDER BY year(dteIslemTarihi), month(dteIslemTarihi), day(dteIslemTarihi), dteIslemTarihi, year(dteValorTarihi), month(dteValorTarihi), day(dteValorTarihi), dteValorTarihi, dteKayitTarihi, nHareketID, IslemTipi, lFisNo, tip ")
            ElseIf bDovizli = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT 0 as nSatir, nFirmaID,sFirmaKodu, sFirmaAciklama, dteIslemTarihi, dteValorTarihi AS dteValorTarihi, IslemAciklama, lFisNo, lBorcTutar, lAlacakTutar, Bakiye, sFirmaHarAciklama, sHareketTipi, lDevirBorc, lDevirAlacak, lDevir, lBorcTutarORT, lAlacakTutarORT, sStokKodu, sStokAciklama, sRenkAdi,sBeden,sRenk,lGirenMiktar, lCikanMiktar, lMiktar, lGirenFiyat, lCikanFiyat, Islemtipi, lBrutFiyat, sSatirAciklama, SatirIskonto1, SatirIskonto2, SatirIskonto3, SatirIskonto4, tip, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, lGirenTutar, lCikanTutar, lBrutTutar, dteKayitTarihi, nStokFisiID,nGirisCikis, lGirenMiktar2, lCikanMiktar2, nEvrakNo, SatirIsk, DipIsk1, DipIsk2, NetFiyat, NetTutar, nKdvOrani,FiyatTipi, BirimCinsi, lBorcTutarORT1, lAlacakTutarORT1, mintarihOrt1, sKullaniciAdi, aciklama1, aciklama2 FROM (SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, CONVERT(char(8), tbFirmaHareketi.dteIslemTarihi, 3) AS dteIslemTarihi, CONVERT(char(8), tbFirmaHareketi.dteValorTarihi, 3) AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, Bakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sAciklama + (CASE WHEN sHangiUygulama IN ('AC', 'AS', 'BC', 'BS') THEN ' - ' + (SELECT sBorclusu + (CASE bKendineAit WHEN 1 THEN '(Kendi Çeki)' ELSE '' END) FROM tbCekSenet, tbCekSenetBordro WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.nCariHareketID = tbFirmaHareketi.nHareketID) ELSE '' END) AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, isnull(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, isnull(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir, 0 AS lBorcTutarORT, 0 AS lAlacakTutarORT, (SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) AS sStokKodu, '' AS sStokAciklama, '' sRenkAdi,'' sBeden,'' sRenk,0 AS lMiktar, 0 AS lGirenMiktar, 0 AS lCikanMiktar, 0 AS lGirenFiyat, 0 AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 0 AS tip, 0 AS lBrutFiyat, '' AS sSatirAciklama, 0 as SatirIskonto1, 0 as SatirIskonto2, 0 as SatirIskonto3, 0 as SatirIskonto4, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0 AS lGirenTutar, 0 AS lCikanTutar, 0 AS lBrutTutar, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, 0 AS nstokfisiID,0 AS nGirisCikis, 0 AS lGirenMiktar2, 0 AS lCikanMiktar2, 0 AS nEvrakNo, 0 AS SatirIsk, 0 AS DipIsk1, 0 AS DipIsk2, 0 AS NetFiyat, 0 AS NetTutar, 0 as nKdvOrani,'' AS FiyatTipi, '' AS BirimCinsi, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORT1, Datediff(day, tbTempMinTarih.MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORT1, tbTempMinTarih.MinTarih AS mintarihOrt1, '' AS sKullaniciAdi, '' AS aciklama1, '' AS aciklama2 FROM tbFirma, tbCariIslem, tbFirmaHareketi LEFT OUTER JOIN (SELECT sDovizCinsi1 as sDoviz,SUM(ISNULL(lDevirBorc, 0)) AS lDevirBorc, SUM(ISNULL(lDevirAlacak, 0)) AS lDevirAlacak, SUM(ISNULL(lDevirBorc, 0)) - SUM(ISNULL(lDevirAlacak, 0)) AS lDevir, SUM(ISNULL(lBorcTutarORTDevir, 0)) AS lBorcTutarORTDevir, SUM(ISNULL(lAlacakTutarORTDevir, 0)) AS lAlacakTutarORTDevir, nFirmaID FROM (SELECT tbFirmaHareketi.sDovizCinsi1,lDevirBorc = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lDevirAlacak = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lDevir = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lBorcTutar AS lBorcTutarORTDevir, Datediff(day, MinTarih, dteIslemTarihi) * tbFirmaHareketi.lAlacakTutar AS lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID, nHareketID FROM tbFirmaHareketi FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE dteIslemTarihi < '" & dteIslemTarihi1 & "') tbTempDevir GROUP BY nFirmaID,sDovizCinsi1) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID and tbFirmaHareketi.sDovizCinsi1 = tbTempFirmahareketi.sDoviz FULL JOIN (SELECT MIN(dteIslemTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem AND tbFirma.sKodu = '" & musterino & "' " & kriter & " UNION ALL SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, '' sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi AS dteIslemTarihi, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, '' AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, 0 AS lBorcTutar, 0 AS lAlacakTutar, 0 AS Bakiye, '' AS sHareketTipi, tbStokFisiAciklamasi.saciklama1 + '½' + tbStokFisiAciklamasi.saciklama2 + '½' + tbStokFisiAciklamasi.saciklama3 + '½' + tbStokFisiAciklamasi.saciklama4 + '½' + tbStokFisiAciklamasi.saciklama5 AS sFirmaHarAciklama, 0 AS lDevirBorc, 0 AS lDevirAlacak, 0 AS lDevir, 0 AS lBorcTutarORT, 0 AS lBorcAlacakORT, tbStok.sKodu AS sStokKodu, rtrim(tbStok.sAciklama) + (CASE WHEN sRenkAdi = '' THEN '' ELSE ' - ' END) + rtrim(sRenkAdi) AS sStokAciklama, sRenkAdi,tbStok.sBeden,tbStok.sRenk,abs(lGirisMiktar1 - lCikisMiktar1) AS lMiktar, lGirisMiktar1 AS lGirenMiktar, lCikisMiktar1 AS lCikanMiktar, lGirisFiyat AS lGirenFiyat, lCikisFiyat AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 1 AS tip, lBrutFiyat = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) ELSE CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) END, ltrim(rtrim(tbstokFisiDetayi.sAciklama)) + (CASE WHEN tbStokFisiDetayi.nHesapID <> 0 THEN ' - ' + tbParti.sKodu ELSE '' END) AS sSatirAciklama, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 6, 5) as numeric(4, 2)) as SatirIskonto1, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 17, 5) as numeric(4, 2)) as SatirIskonto2, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 28, 5) as numeric(4, 2)) as SatirIskonto3, CAST(SUBSTRING(tbstokFisiDetayi.sAciklama, 39, 5) as numeric(4, 2)) as SatirIskonto4, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lDovizMiktari1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi2, tbStokFisiDetayi.lDovizMiktari2, tbStokFisiDetayi.lDovizKuru2, lGirisTutar AS lGirenTutar, lcikisTutar AS lCikanTutar, lBrutTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN lGirisMiktar1 * (CAST(lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) ELSE lCikisMiktar1 * (CAST(lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) END, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, tbStokFisiDetayi.nStokfisiID,tbStokFisiDetayi.nGirisCikis, lGirisMiktar2 AS lGirenMiktar2, lCikisMiktar2 AS lCikanMiktar2, ISNULL(tbStokFisiMaster.nEvrakNo, 0) as nEvrakNo, tbStokFisiDetayi.nIskontoYuzdesi AS SatirIsk, tbStokFisiMaster.nDipIskontoYuzdesi1 AS DipIsk1, tbStokFisiMaster.nDipIskontoYuzdesi2 AS DipIsk2, NetFiyat = CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN lBrutFiyat / tbStokFisiDetayi.lDovizKuru1 ELSE lBrutFiyat END, NetTutar = CASE WHEN tbStokFisidetayi.nGirisCikis < 3 THEN (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lGirisMiktar1 ELSE lBrutFiyat * lGirisMiktar1 END) ELSE (CASE WHEN tbStokFisiDetayi.sDovizCinsi1 <> '' THEN (lBrutFiyat / tbStokFisiDetayi.lDovizKuru1) * lCikisMiktar1 ELSE lBrutFiyat * lCikisMiktar1 END) END, tbStokFisiDetayi.nKdvOrani,tbstokfisiDetayi.sFiyatTipi AS FiyatTipi, tbStok.sBirimCinsi1 AS BirimCinsi, 0 AS lBorcTutarORT1, 0 AS lAlacakTutarORT1, '' AS mintarihOrt1, tbStokFisiDetayi.sKullaniciAdi AS sKullaniciAdi, tbStokFisiAciklamasi.saciklama1 as aciklama1, tbStokFisiAciklamasi.saciklama2 as aciklama2 FROM tbFirma, tbFirmaHareketi, tbStokFisiDetayi, tbStok, tbRenk, tbParti, tbStokFisiMaster, tbStokFisiAciklamasi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirma.sKodu = '" & musterino & "' AND tbFirmaHareketi.sCariIslem <> 'KDV' AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "' " & kriter & " AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND cast(tbStokFisiDetayi.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiDetayi.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiDetayi.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbRenk.sRenk = tbStok.sRenk AND tbStokFisiDetayi.nHesapID = tbParti.nPartiID AND tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND cast(tbStokFisiMaster.lFisNo AS char(10)) = tbFirmaHareketi.sEvrakNo AND tbStokFisiMaster.dtefisTarihi = tbFirmaHareketi.dteIslemTarihi AND tbStokFisiMAster.sFisTipi = tbFirmaHareketi.sHangiUygulama AND tbStokFisiAciklamasi.nStokFisiId = tbStokFisimaster.nStokFisiId AND tbStokFisiMaster.nGirisCikis = tbStokFisiDetayi.nGirisCikis AND tbStokFisiMaster.nFirmaID = tbStokFisiDetayi.nFirmaID AND tbStokFisiMaster.sFisTipi = tbStokFisiDetayi.sFisTipi AND tbStokFisiMaster.lFisno = tbStokFisiDetayi.lFisno AND tbStokFisiMaster.dteFisTarihi = tbStokFisiDetayi.dteFisTarihi AND tbStokFisiDetayi.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1) AS tbTemp ORDER BY sDovizCinsi1,year(dteIslemTarihi), month(dteIslemTarihi), day(dteIslemTarihi), dteIslemTarihi, year(dteValorTarihi), month(dteValorTarihi), day(dteValorTarihi), dteValorTarihi, dteKayitTarihi, nHareketID, IslemTipi, lFisNo, tip ")
            End If
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function yekun(ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean, ByVal sDovizCinsi As String) As DataSet
        Dim kriter As String = ""
        If sDovizCinsi <> "" Then
            kriter += " AND (tbFirmaHareketi.sDovizCinsi1 ='" & sDovizCinsi & "') "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi,tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.lBorcTutar AS lBorcTutar, tbFirmaHareketi.lAlacakTutar AS lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sAciklama AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, isnull(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, isnull(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir, 0 AS lBorcTutarORT, 0 AS lAlacakTutarORT, '' AS sStokKodu, '' AS sStokAciklama, 0 AS lGirenMiktar, 0 AS lCikanMiktar, 0 AS lGirenFiyat, 0 AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 0 AS tip, 0 AS lBrutFiyat, '' AS sSatirAciklama, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0 AS lGirenTutar, 0 AS lCikanTutar, 0 AS lBrutTutar, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, isnull(tbstokfisiOdemePlani.nstokfisiID, 0) AS nStokFisiID, 0 AS lGirenMiktar2, 0 AS lCikanMiktar2, 0 AS SatirIsk, 0 AS DipIsk1, 0 AS DipIsk2, 0 AS NetFiyat, 0 AS NetTutar, '' AS FiyatTipi, '' AS BirimCinsi, 0 AS lBorcTutarORT1, 0 AS lAlacakTutarORT1, '' mintarihOrt1 FROM tbFirma, tbCariIslem, tbFirmaHareketi LEFT OUTER JOIN tbStokfisiOdemePlani ON tbStokfisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lDevirBorc, SUM(tbFirmaHareketi.lAlacakTutar) AS lDevirAlacak, SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir, 0 AS lBorcTutarORTDevir, 0 lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID FROM tbFirma, tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/2018' AND tbFirma.sKodu like '" & Trim(musterino) & "%' GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/2018' AND '31/12/2070' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem AND tbFirma.sKodu like '" & Trim(musterino) & "%' ORDER BY year(dteIslemTarihi), month(dteIslemTarihi), day(dteIslemTarihi), dteIslemTarihi, year(dteValorTarihi), month(dteValorTarihi), day(dteValorTarihi), dteValorTarihi, tbFirmaHareketi.nHareketID ")
        If bDovizli = False Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lBorcTutar) AS lBorcTutar, SUM(lAlacakTutar) AS lAlacakTutar, SUM(lBakiye) AS lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1 , tbFirma.nFirmaID , lBorcTutar , lAlacakTutar , lBorcTutar - lAlacakTutar AS lBakiye FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu LIKE '" & Trim(musterino) & "%')) TemDevir ")
        ElseIf bDovizli = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu LIKE '" & Trim(musterino) & "%') " & kriter & " ) TemDevir GROUP BY sDovizCinsi1 ")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table2")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean, ByVal sDovizCinsi As String)
        DataSet1 = stok(dteIslemTarihi1, dteIslemTarihi2, bDovizli, sDovizCinsi)
        dataset2 = yekun(dteIslemTarihi1, dteIslemTarihi2, bDovizli, sDovizCinsi)
        kontrol_bakiye(bDovizli)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl2.DataSource = dataset2.Tables(0)
        GridControl2.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.ExpandAllGroups()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            GridControl1.Focus()
        End If
        If sModul = "Banka" Then
            colsFirmaKodu.Caption = "Banka Kodu"
            colsFirmaAciklama.Caption = "Banka Adý"
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteIslemTarihi")
            frm.sFisTipi = dr("sFisTipi")
            frm.nFirmaID = dr("nFirmaID")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokFisiID = dr("nStokFisiID")
            frm.kullanici = kullanici
            Dim satir = GridView1.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub kontrol_bakiye(ByVal bDovizli As Boolean)
        Dim dr As DataRow
        Dim bakiye = 0
        Dim bakiye2 As Decimal = 0
        Dim bakiye_status = "-"
        Dim sayi As Integer = 0
        lDevir = 0
        Dim sDovizCinsi1 As String = ""
        Dim nSatirMaster As Integer = 0
        Dim nSatirDetay As Integer = 0
        For Each dr In DataSet1.Tables(0).Rows
            sayi += 1
            If sayi = 1 Then
                bakiye = bakiye + dr("lDevir")
                lDevir = dr("lDevir")
            End If
            If bDovizli = True Then
                If Trim(dr("sDovizCinsi1")) <> sDovizCinsi1 Then
                    bakiye = 0
                    bakiye = bakiye + dr("lDevir")
                    sDovizCinsi1 = Trim(dr("sDovizCinsi1"))
                End If
            End If
            'If sec_bBakiyeHesapla.Checked = True Then
            '    If dr("nStokFisiID") = 0 Then
            '        If Trim(dr("IslemTipi")) = "FS" Or Trim(dr("IslemTipi")) = "FA" Or Trim(dr("IslemTipi")) = "DG" Or Trim(dr("IslemTipi")) = "DC" Or Trim(dr("IslemTipi")) = "HA" Or Trim(dr("IslemTipi")) = "HS" Then
            '            dr("Bakiye") = 0
            '        Else
            '            bakiye = bakiye + (dr("lBorcTutar") - dr("lAlacakTutar"))
            '        End If
            '    Else
            '        dr("Bakiye") = 0
            '    End If
            'Else
            bakiye = bakiye + (dr("lBorcTutar") - dr("lAlacakTutar"))
            'End If
            If dr("tip") = 0 Then
                nSatirMaster += 1
                nSatirDetay = 0
                dr("nSatir") = nSatirMaster
                dr("Bakiye") = bakiye
                dr("sSatirAciklama") = dr("sFirmaHarAciklama")
                dr("sStokAciklama") = dr("sFirmaHarAciklama")
                bakiye2 = bakiye
            ElseIf dr("tip") = 1 Then
                nSatirDetay += 1
                dr("nSatir") = nSatirDetay
                'If sec_bBakiyeHesapla.Checked = True Then
                '    If dr("nGirisCikis") = 3 Or dr("nGirisCikis") = 4 Then
                '        'dr("NetTutar") = (dr("NetTutar") * ((dr("nKdvOrani") + 100) / 100))
                '        bakiye2 = bakiye2 + dr("lBrutTutar")
                '        dr("Bakiye") = bakiye2
                '    ElseIf dr("nGirisCikis") = 1 Or dr("nGirisCikis") = 2 Then
                '        'dr("NetTutar") = (dr("NetTutar") * ((dr("nKdvOrani") + 100) / 100))
                '        bakiye2 = bakiye2 + (dr("lBrutTutar"))
                '        dr("Bakiye") = bakiye2
                '    End If
                'End If
                'Detay Boþalt
                'dr("dteIslemTarihi") = Nullable
                'dr("dteValorTarihi") = Nullable
                'dr("Islemtipi") = ""
                'dr("lFisNo") = ""
                If sec_bBakiyeHesapla.Checked = True Then
                    If dr("nGirisCikis") = 1 Then
                    ElseIf dr("nGirisCikis") = 2 Then
                        If Trim(dr("IslemTipi").ToString) = "FA" Then
                            dr("sIslem") = "Alýþtan Ýade"
                        ElseIf Trim(dr("IslemTipi").ToString) = "DG" Then
                            dr("sIslem") = "StokÝadeEdilen"
                        End If
                    ElseIf dr("nGirisCikis") = 3 Then
                        'If dr("lMiktar") < 0 And dr("lBorcTutar") > 0 Then
                        '    dr("lBorcTutar") = 0
                        '    dr("lAlacakTutar") = dr("lBorcTutar")
                        'End If
                    ElseIf dr("nGirisCikis") = 4 Then
                        If Trim(dr("IslemTipi").ToString) = "FS" Then
                            dr("sIslem") = "Satýþtan Ýade"
                        ElseIf Trim(dr("IslemTipi").ToString) = "DC" Then
                            dr("sIslem") = "StokÝadeAlýnan"
                        End If
                    End If
                End If
            End If
            If bakiye < 0 Then
                bakiye_status = "A"
            ElseIf bakiye = 0 Then
                bakiye_status = "-"
            ElseIf bakiye > 0 Then
                bakiye_status = "B"
            End If
            If Trim(dr("sDovizCinsi1")) <> "" And dr("lDovizKuru1") <> 0 Then
                dr("lBrutFiyat") = dr("lBrutFiyat") / dr("lDovizKuru1")
                dr("lBrutTutar") = dr("lBrutTutar") / dr("lDovizKuru1")
            End If
            If dr("tip") = 0 Then
                If dr("nGirisCikis") = 1 Then
                ElseIf dr("nGirisCikis") = 2 Then
                    If Trim(dr("IslemTipi").ToString) = "FA" Then
                        dr("sStokKodu") = "Alýþtan Ýade"
                    ElseIf Trim(dr("IslemTipi").ToString) = "DG" Then
                        dr("sStokKodu") = "StokÝadeEdilen"
                    End If
                ElseIf dr("nGirisCikis") = 3 Then
                    'If dr("lMiktar") < 0 And dr("lBorcTutar") > 0 Then
                    '    dr("lBorcTutar") = 0
                    '    dr("lAlacakTutar") = dr("lBorcTutar")
                    'End If
                ElseIf dr("nGirisCikis") = 4 Then
                    If Trim(dr("IslemTipi").ToString) = "FS" Then
                        dr("sStokKodu") = "Satýþtan Ýade"
                    ElseIf Trim(dr("IslemTipi").ToString) = "DC" Then
                        dr("sStokKodu") = "StokÝadeAlýnan"
                    End If
                End If
                dr("sStokKodu") = Sorgu_sDil(dr("sStokKodu").ToString, sDil)
                dr("sStokAciklama") = Replace(dr("sStokAciklama").ToString, "Evrak No:", Sorgu_sDil("Evrak No:", sDil))
                dr("sStokAciklama") = Replace(dr("sStokAciklama").ToString, "ISKONTO YAPILDI", Sorgu_sDil("ISKONTO YAPILDI", sDil))
                dr("sStokAciklama") = Replace(dr("sStokAciklama").ToString, "Pesin Fatura No :", Sorgu_sDil("Pesin Fatura No ::", sDil))
            End If
            If sec_bBakiyeHesapla.Checked = True Then
                dr("Bakiye") = bakiye
            Else
                'dr("Bakiye") = 0
            End If
        Next
        If bDovizli = True Then
            GridView1.OptionsView.ShowFooter = False
            printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.ReportFooter
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString & "(" & bakiye_status & ")"
            'collBorcTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'collAlacakTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'GridView1.UpdateSummary()
            colsDovizCinsi1.Visible = True
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
            colsDovizCinsi1.Group()
        Else
            printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.None
            GridView1.OptionsView.ShowFooter = True
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
            GridView1.UpdateSummary()
            colsDovizCinsi1.Visible = False
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            colsDovizCinsi1.UnGroup()
        End If
        GridView1.ExpandAllGroups()
        'colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
        'GridView1.UpdateSummary()
        'GridView1.UpdateTotalSummary()
        bakiye = Nothing
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.sModul = sModul
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaId = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            musterino = sKodu
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        fis_duzelt()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
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
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Label2.Refresh()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, sec_bDovizli.Checked, Trim(sec_sDovizCinsi.EditValue))
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        txt_musteriNo.Text = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Space Then
            firma_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_musteriNo.Text) = "" Then
                firma_sec()
            End If
        End If
    End Sub
    Private Sub sec_bDovizli_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bDovizli.CheckStateChanged
        If sec_bDovizli.Checked = True Then
            sec_sDovizCinsi.Enabled = True
        ElseIf sec_bDovizli.Checked = False Then
            sec_sDovizCinsi.Enabled = False
            sec_sDovizCinsi.EditValue = ""
        End If
    End Sub
    Private Sub sec_bDovizli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_bDovizli.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton3.Focus()
        End If
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        If MenuItem18.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem18.Checked = True
        ElseIf MenuItem18.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem18.Checked = False
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        txt_musteriNo.Text = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_rtf()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        raporla(0)
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        raporla(1)
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(2)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla_excel()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla_text()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        raporla_rtf()
    End Sub
    Friend WithEvents colsCariIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents toplamlariYazdir As System.Windows.Forms.CheckBox
    Friend WithEvents colnEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatirIskonto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatirIskonto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatirIskonto3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatirIskonto4 As DevExpress.XtraGrid.Columns.GridColumn
End Class