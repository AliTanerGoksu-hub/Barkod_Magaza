Imports FastReport
Imports System.Threading
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_musteri_mektup
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
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCinsiyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAylikGelir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKartAcilisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoPesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoKredili As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbYazismaEvAdresinemi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsYeriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSigortaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEvlimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteEvlilikTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteDogumTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDogumYeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEhliyetNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKanGrubu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOZLESME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_altlimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_ustlimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents coltutar As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_AlisVeris As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_odemesiz As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_ilktaksit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Date_ilktaksit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_iletisim As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_istihbarat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_Thread As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents colsKefil1GSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil2GSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents yazdirmaSecenegi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_mektup))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_Thread = New DevExpress.XtraEditors.CheckEdit()
        Me.Label15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_istihbarat = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New DevExpress.XtraEditors.LabelControl()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_iletisim = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_ilktaksit = New DevExpress.XtraEditors.CheckEdit()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.Date_ilktaksit = New DevExpress.XtraEditors.DateEdit()
        Me.sec_odemesiz = New DevExpress.XtraEditors.CheckEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_AlisVeris = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ustlimit = New DevExpress.XtraEditors.CalcEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_altlimit = New DevExpress.XtraEditors.CalcEdit()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.yazdirmaSecenegi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCinsiyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAylikGelir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKartAcilisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoPesin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoKredili = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbYazismaEvAdresinemi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsYeriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSigortaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEvlimi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteEvlilikTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteDogumTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDogumYeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEhliyetNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKanGrubu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOZLESME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil1GSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil2GSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_Thread.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_istihbarat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_iletisim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ilktaksit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_ilktaksit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_ilktaksit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_odemesiz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_AlisVeris.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ustlimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_altlimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.yazdirmaSecenegi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 144)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_Thread)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Controls.Add(Me.txt_istihbarat)
        Me.GroupControl1.Controls.Add(Me.Label14)
        Me.GroupControl1.Controls.Add(Me.Label13)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.sec_iletisim)
        Me.GroupControl1.Controls.Add(Me.sec_ilktaksit)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.Date_ilktaksit)
        Me.GroupControl1.Controls.Add(Me.sec_odemesiz)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.sec_AlisVeris)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txt_ustlimit)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txt_altlimit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(536, 140)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "Ara"
        '
        'sec_Thread
        '
        Me.sec_Thread.Location = New System.Drawing.Point(383, 65)
        Me.sec_Thread.Name = "sec_Thread"
        Me.sec_Thread.Properties.Caption = "Thread"
        Me.sec_Thread.Size = New System.Drawing.Size(88, 19)
        Me.sec_Thread.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(488, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Ýçermez"
        '
        'txt_istihbarat
        '
        Me.txt_istihbarat.Location = New System.Drawing.Point(384, 43)
        Me.txt_istihbarat.Name = "txt_istihbarat"
        Me.txt_istihbarat.Size = New System.Drawing.Size(104, 20)
        Me.txt_istihbarat.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(328, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Istihbarat:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(488, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Eþittir"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(328, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Ýletiþim:"
        '
        'sec_iletisim
        '
        Me.sec_iletisim.EnterMoveNextControl = True
        Me.sec_iletisim.Location = New System.Drawing.Point(384, 21)
        Me.sec_iletisim.Name = "sec_iletisim"
        Me.sec_iletisim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_iletisim.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sSinifKodu", 10, "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", 35, "Açýklama")})
        Me.sec_iletisim.Properties.DisplayMember = "sAciklama"
        Me.sec_iletisim.Properties.NullText = "[Ýletiþim]"
        Me.sec_iletisim.Properties.ValueMember = "sSinifKodu"
        Me.sec_iletisim.Size = New System.Drawing.Size(104, 20)
        Me.sec_iletisim.TabIndex = 10
        '
        'sec_ilktaksit
        '
        Me.sec_ilktaksit.Location = New System.Drawing.Point(-2, 45)
        Me.sec_ilktaksit.Name = "sec_ilktaksit"
        Me.sec_ilktaksit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_ilktaksit.Properties.Appearance.Options.UseFont = True
        Me.sec_ilktaksit.Properties.Caption = "IlkTaksit:"
        Me.sec_ilktaksit.Size = New System.Drawing.Size(60, 19)
        Me.sec_ilktaksit.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(271, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "sonraki"
        '
        'Date_ilktaksit
        '
        Me.Date_ilktaksit.EditValue = Nothing
        Me.Date_ilktaksit.Enabled = False
        Me.Date_ilktaksit.EnterMoveNextControl = True
        Me.Date_ilktaksit.Location = New System.Drawing.Point(64, 43)
        Me.Date_ilktaksit.Name = "Date_ilktaksit"
        Me.Date_ilktaksit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_ilktaksit.Properties.DisplayFormat.FormatString = "D"
        Me.Date_ilktaksit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_ilktaksit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Date_ilktaksit.Size = New System.Drawing.Size(203, 20)
        Me.Date_ilktaksit.TabIndex = 3
        '
        'sec_odemesiz
        '
        Me.sec_odemesiz.Location = New System.Drawing.Point(267, 109)
        Me.sec_odemesiz.Name = "sec_odemesiz"
        Me.sec_odemesiz.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_odemesiz.Properties.Appearance.Options.UseFont = True
        Me.sec_odemesiz.Properties.Caption = "Hiç Ödememiþ"
        Me.sec_odemesiz.Size = New System.Drawing.Size(87, 19)
        Me.sec_odemesiz.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(-12, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 11)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "AlýþVeriþ Noktasý"
        '
        'sec_AlisVeris
        '
        Me.sec_AlisVeris.EnterMoveNextControl = True
        Me.sec_AlisVeris.Location = New System.Drawing.Point(64, 109)
        Me.sec_AlisVeris.Name = "sec_AlisVeris"
        Me.sec_AlisVeris.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_AlisVeris.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", 10, "KayýtNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SATICI", 35, "Satýcý")})
        Me.sec_AlisVeris.Properties.DisplayMember = "SATICI"
        Me.sec_AlisVeris.Properties.NullText = "[AlýþVeriþ Noktalarý]"
        Me.sec_AlisVeris.Properties.ValueMember = "IND"
        Me.sec_AlisVeris.Size = New System.Drawing.Size(203, 20)
        Me.sec_AlisVeris.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(272, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "arasýndaki"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Müþteriler:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(272, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(30, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Vade:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(161, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(184, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(64, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(184, 87)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 7
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(384, 87)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(112, 43)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(267, 87)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 8
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(64, 87)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(120, 20)
        Me.txt_ara.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(33, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Limit:"
        '
        'txt_ustlimit
        '
        Me.txt_ustlimit.EditValue = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txt_ustlimit.EnterMoveNextControl = True
        Me.txt_ustlimit.Location = New System.Drawing.Point(184, 65)
        Me.txt_ustlimit.Name = "txt_ustlimit"
        Me.txt_ustlimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_ustlimit.Properties.NullText = "0.00"
        Me.txt_ustlimit.Size = New System.Drawing.Size(83, 20)
        Me.txt_ustlimit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(160, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ve"
        '
        'txt_altlimit
        '
        Me.txt_altlimit.EditValue = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txt_altlimit.EnterMoveNextControl = True
        Me.txt_altlimit.Location = New System.Drawing.Point(64, 65)
        Me.txt_altlimit.Name = "txt_altlimit"
        Me.txt_altlimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_altlimit.Properties.NullText = "0.00"
        Me.txt_altlimit.Size = New System.Drawing.Size(96, 20)
        Me.txt_altlimit.TabIndex = 4
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(632, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(190, 140)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.yazdirmaSecenegi)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 379)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(324, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 39
        Me.LabelControl1.Text = "Yazdýrma Seçenekleri:"
        '
        'yazdirmaSecenegi
        '
        Me.yazdirmaSecenegi.EditValue = "Müþteriler"
        Me.yazdirmaSecenegi.EnterMoveNextControl = True
        Me.yazdirmaSecenegi.Location = New System.Drawing.Point(434, 10)
        Me.yazdirmaSecenegi.Name = "yazdirmaSecenegi"
        Me.yazdirmaSecenegi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.yazdirmaSecenegi.Properties.Items.AddRange(New Object() {"Müþteriler", "Kefiller", "Hepsi", "Ýcralýk"})
        Me.yazdirmaSecenegi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.yazdirmaSecenegi.Size = New System.Drawing.Size(83, 20)
        Me.yazdirmaSecenegi.TabIndex = 38
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(243, 8)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton5.TabIndex = 8
        Me.SimpleButton5.Text = "&Yazdýr"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(168, 8)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "&Hazýrla"
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
        Me.PanelControl3.Controls.Add(Me.Panelstatus)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 144)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 235)
        Me.PanelControl3.TabIndex = 0
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(266, 64)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(293, 106)
        Me.Panelstatus.TabIndex = 4
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(10, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(269, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 49)
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
        Me.barlabel.Location = New System.Drawing.Point(8, 3)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 22)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(269, 18)
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 231)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem27, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem30, Me.MenuItem22, Me.MenuItem21, Me.MenuItem29, Me.MenuItem31, Me.MenuItem23, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem28, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem27.Text = "Satýr Sil"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Kalan Taksitler"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 5
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Kalan Satýþlar"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 6
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Satýþlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 8
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem30.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 9
        Me.MenuItem22.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 10
        Me.MenuItem21.Text = "Takibe Al"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 11
        Me.MenuItem29.Text = "SMS Gönder"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 12
        Me.MenuItem31.Text = "Kefillere SMS Gönder"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 13
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem23.Text = "Raporla"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Text = "Önizle"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Text = "Dizayn"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Text = "Yazdýr"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 14
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 15
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 16
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 17
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 18
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 19
        Me.MenuItem10.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 20
        Me.MenuItem28.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 21
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 22
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 23
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 24
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 25
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 26
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 27
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sMagaza"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sSoyadi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Musteri"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nCinsiyet"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = " lAylikGelir"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dteKartAcilisTarihi"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nIskontoPesin"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "nIskontoKredili"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sUnvan"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sVergiDairesi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sVergiNo"
        Me.DataColumn14.DataType = GetType(System.TimeSpan)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "bYazismaEvAdresinemi"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sEmail"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sIsYeriAdi"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sIsAdresi"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sIsTelefonu"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sEvAdresi"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sEvTelefonu"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sSigortaNo"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "bEvlimi"
        Me.DataColumn23.DataType = GetType(Boolean)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "dteEvlilikTarihi"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "dteDogumTarihi"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sDogumYeri"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sEhliyetNo"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sKanGrubu"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dteKayitTarihi"
        Me.DataColumn29.DataType = GetType(Date)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ISTIHBARAT"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sGSM"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sFax"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "SOZLESME"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Sýnýf1"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Sýnýf2"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Sýnýf3"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Sýnýf4"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Sýnýf5"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsMagaza, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colMusteri, Me.colnCinsiyet, Me.collAylikGelir, Me.coldteKartAcilisTarihi, Me.colnIskontoPesin, Me.colnIskontoKredili, Me.colsUnvan, Me.colsVergiDairesi, Me.colsVergiNo, Me.colbYazismaEvAdresinemi, Me.colsEmail, Me.colsIsYeriAdi, Me.colsIsAdresi, Me.colsIsTelefonu, Me.colsEvAdresi, Me.colsEvTelefonu, Me.colsSigortaNo, Me.colbEvlimi, Me.coldteEvlilikTarihi, Me.coldteDogumTarihi, Me.colsDogumYeri, Me.colsEhliyetNo, Me.colsKanGrubu, Me.coldteKayitTarihi, Me.colISTIHBARAT, Me.colsGSM, Me.colsFax, Me.colSOZLESME, Me.colSýnýf1, Me.colSýnýf2, Me.colSýnýf3, Me.colSýnýf4, Me.colSýnýf5, Me.coltutar, Me.colsKefil1GSM, Me.colsKefil2GSM})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(473, 244, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Me.colMusteri, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tutar", Me.coltutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tutar", Nothing, "GecikmiþTutar:{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
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
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Kayýt No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.Width = 37
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.Width = 50
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 0
        Me.collKodu.Width = 62
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adý"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Width = 178
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadý"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Width = 178
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Müþteri"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 1
        Me.colMusteri.Width = 91
        '
        'colnCinsiyet
        '
        Me.colnCinsiyet.Caption = "Cinsiyet"
        Me.colnCinsiyet.FieldName = "nCinsiyet"
        Me.colnCinsiyet.Name = "colnCinsiyet"
        Me.colnCinsiyet.Width = 72
        '
        'collAylikGelir
        '
        Me.collAylikGelir.Caption = "Aylýk Gelir"
        Me.collAylikGelir.FieldName = " lAylikGelir"
        Me.collAylikGelir.Name = "collAylikGelir"
        '
        'coldteKartAcilisTarihi
        '
        Me.coldteKartAcilisTarihi.Caption = "Kart Açýlýþ Tarihi"
        Me.coldteKartAcilisTarihi.FieldName = "dteKartAcilisTarihi"
        Me.coldteKartAcilisTarihi.Name = "coldteKartAcilisTarihi"
        Me.coldteKartAcilisTarihi.Width = 81
        '
        'colnIskontoPesin
        '
        Me.colnIskontoPesin.Caption = "Ýskonto Peþin"
        Me.colnIskontoPesin.FieldName = "nIskontoPesin"
        Me.colnIskontoPesin.Name = "colnIskontoPesin"
        '
        'colnIskontoKredili
        '
        Me.colnIskontoKredili.Caption = "Ýskonto Kredili"
        Me.colnIskontoKredili.FieldName = "nIskontoKredili"
        Me.colnIskontoKredili.Name = "colnIskontoKredili"
        '
        'colsUnvan
        '
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        '
        'colsVergiDairesi
        '
        Me.colsVergiDairesi.Caption = "Vergi Dairesi"
        Me.colsVergiDairesi.FieldName = "sVergiDairesi"
        Me.colsVergiDairesi.Name = "colsVergiDairesi"
        '
        'colsVergiNo
        '
        Me.colsVergiNo.Caption = "Vergi No"
        Me.colsVergiNo.FieldName = "sVergiNo"
        Me.colsVergiNo.Name = "colsVergiNo"
        '
        'colbYazismaEvAdresinemi
        '
        Me.colbYazismaEvAdresinemi.Caption = "YazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.FieldName = "bYazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.Name = "colbYazismaEvAdresinemi"
        '
        'colsEmail
        '
        Me.colsEmail.Caption = "Email"
        Me.colsEmail.FieldName = "sEmail"
        Me.colsEmail.Name = "colsEmail"
        '
        'colsIsYeriAdi
        '
        Me.colsIsYeriAdi.Caption = "Ýþ Yeri Adý"
        Me.colsIsYeriAdi.FieldName = "sIsYeriAdi"
        Me.colsIsYeriAdi.Name = "colsIsYeriAdi"
        '
        'colsIsAdresi
        '
        Me.colsIsAdresi.Caption = "Ýþ Adresi"
        Me.colsIsAdresi.FieldName = "sIsAdresi"
        Me.colsIsAdresi.Name = "colsIsAdresi"
        '
        'colsIsTelefonu
        '
        Me.colsIsTelefonu.Caption = "Ýþ Telefonu"
        Me.colsIsTelefonu.FieldName = "sIsTelefonu"
        Me.colsIsTelefonu.Name = "colsIsTelefonu"
        '
        'colsEvAdresi
        '
        Me.colsEvAdresi.Caption = "Ev Adresi"
        Me.colsEvAdresi.FieldName = "sEvAdresi"
        Me.colsEvAdresi.Name = "colsEvAdresi"
        Me.colsEvAdresi.Visible = True
        Me.colsEvAdresi.VisibleIndex = 2
        Me.colsEvAdresi.Width = 117
        '
        'colsEvTelefonu
        '
        Me.colsEvTelefonu.Caption = "Ev Telefonu"
        Me.colsEvTelefonu.FieldName = "sEvTelefonu"
        Me.colsEvTelefonu.Name = "colsEvTelefonu"
        Me.colsEvTelefonu.Visible = True
        Me.colsEvTelefonu.VisibleIndex = 3
        Me.colsEvTelefonu.Width = 77
        '
        'colsSigortaNo
        '
        Me.colsSigortaNo.Caption = "Sigorta No"
        Me.colsSigortaNo.FieldName = "sSigortaNo"
        Me.colsSigortaNo.Name = "colsSigortaNo"
        '
        'colbEvlimi
        '
        Me.colbEvlimi.Caption = "Evlimi"
        Me.colbEvlimi.FieldName = "bEvlimi"
        Me.colbEvlimi.Name = "colbEvlimi"
        '
        'coldteEvlilikTarihi
        '
        Me.coldteEvlilikTarihi.Caption = "Evlilik Tarihi"
        Me.coldteEvlilikTarihi.FieldName = "dteEvlilikTarihi"
        Me.coldteEvlilikTarihi.Name = "coldteEvlilikTarihi"
        '
        'coldteDogumTarihi
        '
        Me.coldteDogumTarihi.Caption = "Doðum Tarihi"
        Me.coldteDogumTarihi.FieldName = "dteDogumTarihi"
        Me.coldteDogumTarihi.Name = "coldteDogumTarihi"
        '
        'colsDogumYeri
        '
        Me.colsDogumYeri.Caption = "Doðum Yeri"
        Me.colsDogumYeri.FieldName = "sDogumYeri"
        Me.colsDogumYeri.Name = "colsDogumYeri"
        '
        'colsEhliyetNo
        '
        Me.colsEhliyetNo.Caption = "Ehliyet No"
        Me.colsEhliyetNo.FieldName = "sEhliyetNo"
        Me.colsEhliyetNo.Name = "colsEhliyetNo"
        '
        'colsKanGrubu
        '
        Me.colsKanGrubu.Caption = "Kan Grubu"
        Me.colsKanGrubu.FieldName = "sKanGrubu"
        Me.colsKanGrubu.Name = "colsKanGrubu"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.Width = 57
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "ISTIHBARAT"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        '
        'colsGSM
        '
        Me.colsGSM.Caption = "GSM"
        Me.colsGSM.FieldName = "sGSM"
        Me.colsGSM.Name = "colsGSM"
        Me.colsGSM.Visible = True
        Me.colsGSM.VisibleIndex = 4
        Me.colsGSM.Width = 48
        '
        'colsFax
        '
        Me.colsFax.Caption = "Fax"
        Me.colsFax.FieldName = "sFax"
        Me.colsFax.Name = "colsFax"
        '
        'colSOZLESME
        '
        Me.colSOZLESME.Caption = "Sözleþme No"
        Me.colSOZLESME.FieldName = "SOZLESME"
        Me.colSOZLESME.Name = "colSOZLESME"
        Me.colSOZLESME.Visible = True
        Me.colSOZLESME.VisibleIndex = 7
        Me.colSOZLESME.Width = 65
        '
        'colSýnýf1
        '
        Me.colSýnýf1.Caption = "Sýnýf 1"
        Me.colSýnýf1.FieldName = "Sýnýf1"
        Me.colSýnýf1.Name = "colSýnýf1"
        Me.colSýnýf1.Visible = True
        Me.colSýnýf1.VisibleIndex = 5
        Me.colSýnýf1.Width = 53
        '
        'colSýnýf2
        '
        Me.colSýnýf2.Caption = "Sýnýf 2"
        Me.colSýnýf2.FieldName = "Sýnýf2"
        Me.colSýnýf2.Name = "colSýnýf2"
        '
        'colSýnýf3
        '
        Me.colSýnýf3.Caption = "Sýnýf 3"
        Me.colSýnýf3.FieldName = "Sýnýf3"
        Me.colSýnýf3.Name = "colSýnýf3"
        Me.colSýnýf3.Visible = True
        Me.colSýnýf3.VisibleIndex = 6
        Me.colSýnýf3.Width = 78
        '
        'colSýnýf4
        '
        Me.colSýnýf4.Caption = "Sýnýf 4"
        Me.colSýnýf4.FieldName = "Sýnýf4"
        Me.colSýnýf4.Name = "colSýnýf4"
        '
        'colSýnýf5
        '
        Me.colSýnýf5.Caption = "Sýnýf 5"
        Me.colSýnýf5.FieldName = "Sýnýf5"
        Me.colSýnýf5.Name = "colSýnýf5"
        '
        'coltutar
        '
        Me.coltutar.Caption = "Geciken Tutar"
        Me.coltutar.DisplayFormat.FormatString = "#,0.00"
        Me.coltutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltutar.FieldName = "tutar"
        Me.coltutar.Name = "coltutar"
        Me.coltutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tutar", "{0:#,0.00}")})
        Me.coltutar.Visible = True
        Me.coltutar.VisibleIndex = 8
        '
        'colsKefil1GSM
        '
        Me.colsKefil1GSM.Caption = "Kefil1GSM"
        Me.colsKefil1GSM.FieldName = "sKefil1GSM"
        Me.colsKefil1GSM.Name = "colsKefil1GSM"
        '
        'colsKefil2GSM
        '
        Me.colsKefil2GSM.Caption = "Kefil2GSM"
        Me.colsKefil2GSM.FieldName = "sKefil2GSM"
        Me.colsKefil2GSM.Name = "colsKefil2GSM"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Ödemesi Geciken Müþteri Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Musteri Karti,F4"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Satýþlar ,F7"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Kalan Satýþlar,F6"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Kalan Taksitler,F8"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Ekstre"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Notlar ,F9"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Excel"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Text"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Mail"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 427)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 427)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 427)
        '
        'frm_musteri_mektup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 449)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_musteri_mektup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ödemesi Geciken Müþteri Kayýtlarý Mektup Hazýrlama"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_Thread.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_istihbarat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_iletisim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ilktaksit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_ilktaksit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_ilktaksit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_odemesiz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_AlisVeris.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ustlimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_altlimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.yazdirmaSecenegi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public kasiyerno
    Public kasiyer
    Private _searching As Boolean
    Private _deferSearch As Boolean
    Private _searchThread As Thread
    Dim ds_taksit_kalan As DataSet
    Dim ds_taksitler As DataSet
    Dim ds_satislar As DataSet
    Dim ds_satislar_detayli As DataSet
    Dim ds_tahsilatlar As DataSet
    Dim ds_odemeler As DataSet
    Dim yeniYol As String = ""
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        Date_ilktaksit.EditValue = dteSistemTarihi
        DateEdit1.Focus()
        DateEdit1.Select()
        txt_ara.EditValue = ""
        dataload_satis_noktasi()
        'dataload()
    End Sub
    Private Sub dataload_satis_noktasi(Optional ByVal sinifno As Integer = 1)
        sec_AlisVeris.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo AS IND, sAciklama AS SATICI FROM         tbDepo")).Tables(0)
        sec_AlisVeris.ItemIndex = 0
        sec_iletisim.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMSinif3")).Tables(0)
        sec_iletisim.ItemIndex = 0
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        conn.Close()
        Return DS
        adapter = Nothing
        cmd = Nothing
    End Function
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýnda Gecikmiþ Borçlu Müþteriler" & vbCrLf
        kriter += "Limit = " & txt_altlimit.EditValue & "-" & txt_ustlimit.EditValue
        If Trim(sec_iletisim.EditValue) <> "" Then
            kriter += " Ýletiþim = " & sec_iletisim.Text
        End If
        If Trim(txt_istihbarat.Text) <> "" Then
            kriter += "Ýstihbarat;Ýçermez=" & txt_istihbarat.Text
        End If
        If sec_ilktaksit.Checked = True Then
            kriter += " ÝlkTaksit;Büyük/Eþittir= " & Date_ilktaksit.EditValue
        End If
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
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
        ElseIf kriter = "Ýçermez" Then
            sorgu_kriter = "  NOT LIKE '%" & deger & "%' "
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal limitalt As Decimal, ByVal limitust As Decimal, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal magaza As String, ByVal odemesiz As Boolean, ByVal ilk_taksit As Boolean, ByVal ilk_taksit_tarihi As DateTime, ByVal iletisim As String, ByVal istihbarat As String) As DataSet
        Dim kriter = "Where tbMusteri.lKodu > 0 "
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND ( tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvTelefonu" Then
                kriter += " AND ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþTelefonu" Then
                kriter += " AND ( tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Gsm" Then
                kriter += " AND ( tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "DoðumYeri" Then
                kriter += " AND ( tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "1.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "2.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
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
                        If IsNumeric(ara) Then
                        Else
                        End If
                    End If
                End If
                'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
                If adi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
                End If
            Else
            End If
        End If
        Dim kriter_magaza As String = ""
        If magaza <> "" Then
            kriter_magaza = " and tbAlisVeris.sMagaza = '" & magaza & "' "
        End If
        Dim kriter_odeme As String = ""
        If odemesiz = True Then
            kriter_odeme = " HAVING isnull(SUM(Odeme) , 0) = 0 "
        End If
        If Trim(iletisim) <> "" Then
            kriter += " AND (tbMSinif3.sSinifKodu = '" & Trim(iletisim) & "') "
        End If
        If Trim(istihbarat) <> "" Then
            kriter += " AND (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(Trim(istihbarat), "Ýçermez") & " )"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If ilk_taksit = True Then
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT * FROM (SELECT nMusteriID , tutar FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) & "' " & kriter_magaza & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu " & kriter_odeme & " ) t WHERE (Tutar BETWEEN " & limitalt & " AND " & limitust & ")) tt) ttt INNER JOIN (SELECT (SELECT TOP 1 tbTaksit.dteTarihi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri Musteri ON tbAlisVeris.nMusteriID = Musteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (Musteri.nMusteriID = tbMusteri.nMusteriID) GROUP BY Musteri.nMusteriID, tbTaksit.dteTarihi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbTaksit.dteTarihi) as dteTarihi,tbMusteri.nMusteriID , tbMusteri.sMagaza , tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri , tbMusteri.nCinsiyet , tbMusteri.lAylikGelir , tbMusteri.dteKartAcilisTarihi , tbMusteri.nIskontoPesin , tbMusteri.nIskontoKredili , tbMusteri.sUnvan , tbMusteri.sVergiDairesi , tbMusteri.sVergiNo , tbMusteri.bYazismaEvAdresinemi , tbMusteri.sEmail , tbMusteri.sIsYeriAdi , tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi , tbMusteri.sIsTelefonu , tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi , tbMusteri.sEvTelefonu , tbMusteri.sSigortaNo , tbMusteri.bEvlimi , tbMusteri.dteEvlilikTarihi , tbMusteri.dteDogumTarihi , tbMusteri.sDogumYeri , tbMusteri.sEhliyetNo , tbMusteri.sKanGrubu , tbMusteri.dteKayitTarihi , tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT , tbMusteri.sGSM , tbMusteri.sFax , (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME , (SELECT     sIsTelefonu FROM         tbMusteriKefil1 WHERE     (nMusteriID = tbMusteri.nMusteriID)) sKefil1GSM,(SELECT     sIsTelefonu FROM         tbMusteriKefil2 WHERE     (nMusteriID = tbMusteri.nMusteriID)) sKefil2GSM,tbMSinif1.sAciklama AS Sýnýf1 , tbMSinif2.sAciklama AS Sýnýf2 , tbMSinif3.sAciklama AS Sýnýf3 , tbMSinif4.sAciklama AS Sýnýf4 , tbMSinif5.sAciklama AS Sýnýf5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu " & kriter & ") Musteri ON ttt.nMusteriID = Musteri.nMusteriID Where Musteri.dteTarihi >= '" & ilk_taksit_tarihi & "' Order by Musteri.nMusteriID")
        Else
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT * FROM (SELECT nMusteriID , tutar FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) & "' " & kriter_magaza & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu " & kriter_odeme & " ) t WHERE (Tutar BETWEEN " & limitalt & " AND " & limitust & ")) tt) ttt INNER JOIN (SELECT tbMusteri.nMusteriID , tbMusteri.sMagaza , tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri , tbMusteri.nCinsiyet , tbMusteri.lAylikGelir , tbMusteri.dteKartAcilisTarihi , tbMusteri.nIskontoPesin , tbMusteri.nIskontoKredili , tbMusteri.sUnvan , tbMusteri.sVergiDairesi , tbMusteri.sVergiNo , tbMusteri.bYazismaEvAdresinemi , tbMusteri.sEmail , tbMusteri.sIsYeriAdi , tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi , tbMusteri.sIsTelefonu , tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi , tbMusteri.sEvTelefonu , tbMusteri.sSigortaNo , tbMusteri.bEvlimi , tbMusteri.dteEvlilikTarihi , tbMusteri.dteDogumTarihi , tbMusteri.sDogumYeri , tbMusteri.sEhliyetNo , tbMusteri.sKanGrubu , tbMusteri.dteKayitTarihi , tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT , tbMusteri.sGSM , tbMusteri.sFax , (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME , (SELECT     sIsTelefonu FROM         tbMusteriKefil1 WHERE     (nMusteriID = tbMusteri.nMusteriID)) sKefil1GSM,(SELECT     sIsTelefonu FROM         tbMusteriKefil2 WHERE     (nMusteriID = tbMusteri.nMusteriID)) sKefil2GSM,tbMSinif1.sAciklama AS Sýnýf1 , tbMSinif2.sAciklama AS Sýnýf2 , tbMSinif3.sAciklama AS Sýnýf3 , tbMSinif4.sAciklama AS Sýnýf4 , tbMSinif5.sAciklama AS Sýnýf5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu " & kriter & ") Musteri ON ttt.nMusteriID = Musteri.nMusteriID Order by Musteri.nMusteriID")
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal limitalt As Decimal, ByVal limitust As Decimal, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal magaza As String, ByVal odemesiz As Boolean, ByVal ilk_taksit As Boolean, ByVal ilk_taksit_tarihi As DateTime, ByVal iletisim As String, ByVal istihbarat As String)
        DataSet1 = stok(tarih1, tarih2, limitalt, limitust, ara, konum, ara_kriter, magaza, odemesiz, ilk_taksit, ilk_taksit_tarihi, Trim(iletisim), Trim(istihbarat))
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
    Private Sub musteri_notlari()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti_aciklama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kayitno = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
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
        Try
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_istihbarat.Text = dr("ISTIHBARAT").ToString
            dr = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
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
        If sec_Thread.Checked = True Then
            BeginSearch()
        Else
            loading()
        End If
    End Sub
    Sub loading()
        SimpleButton3.Enabled = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_altlimit.EditValue, txt_ustlimit.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, Trim(sec_AlisVeris.EditValue), sec_odemesiz.Checked, sec_ilktaksit.Checked, Date_ilktaksit.EditValue, sec_iletisim.EditValue, txt_istihbarat.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton3.Enabled = True
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub SMS_Gonder(ByVal bKefil As Boolean)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlara SMS Göndermek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If bKefil = True Then
                        If Trim(dr("sKefil1GSM")) <> "" Then
                            Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                            dr1("nIslemID") = 0
                            dr1("sSMSID") = 0
                            dr1("dteGonderimTarihi") = Today
                            dr1("sMesaj") = ""
                            dr1("nMusteriID") = dr("nMusteriID")
                            dr1("lKodu") = dr("lKodu")
                            dr1("sAdi") = dr("sAdi")
                            dr1("sSoyadi") = dr("sSoyadi")
                            dr1("sTelefon") = dr("sKefil1GSM")
                            dr1("dteUpdateTarihi") = Now
                            dr1("lDurum") = 0
                            dr1("lBakiye") = dr("tutar")
                            frm.DataSet1.Tables(0).Rows.Add(dr1)
                        End If
                        If Trim(dr("sKefil2GSM")) <> "" Then
                            Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                            dr1("nIslemID") = 0
                            dr1("sSMSID") = 0
                            dr1("dteGonderimTarihi") = Today
                            dr1("sMesaj") = ""
                            dr1("nMusteriID") = dr("nMusteriID")
                            dr1("lKodu") = dr("lKodu")
                            dr1("sAdi") = dr("sAdi")
                            dr1("sSoyadi") = dr("sSoyadi")
                            dr1("sTelefon") = dr("sKefil2GSM")
                            dr1("dteUpdateTarihi") = Now
                            dr1("lDurum") = 0
                            dr1("lBakiye") = dr("tutar")
                            frm.DataSet1.Tables(0).Rows.Add(dr1)
                        End If
                    Else
                        If Trim(dr("sGSM")) <> "" Then
                            Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                            dr1("nIslemID") = 0
                            dr1("sSMSID") = 0
                            dr1("dteGonderimTarihi") = Today
                            dr1("sMesaj") = ""
                            dr1("nMusteriID") = dr("nMusteriID")
                            dr1("lKodu") = dr("lKodu")
                            dr1("sAdi") = dr("sAdi")
                            dr1("sSoyadi") = dr("sSoyadi")
                            dr1("sTelefon") = dr("sGSM")
                            dr1("dteUpdateTarihi") = Now
                            dr1("lDurum") = 0
                            dr1("lBakiye") = dr("tutar")
                            frm.DataSet1.Tables(0).Rows.Add(dr1)
                        End If
                    End If
                Next
            End If
            'MsgBox(Sorgu_sDil("Ýþlem Tamamlandý...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_musteri_KarlilikAkisTablosu(Optional ByVal islem As Integer = 0)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_satis_karlilik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = dteSistemTarihi
            frm.txt_ara.Text = ""
            frm.txt_ara_stok.Text = ""
            frm.sec_MaliyetTipi.Text = "Stok Kartýndan"
            frm.kriter_musteriID = "AND tbMusteri.nMusteriID = " & dr("nMusteriID") & " "
            If islem = 3 Then
                frm.kriter_fistipi = "'DC'"
                frm.islem = 2
            Else
                frm.islem = islem
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub takibe_al()
        Dim frm As New frm_emir_musteri_takip_toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyerno = kasiyerno
        frm.kasiyer = kasiyer
        frm.txt_takip_aciklama.Text = "Geciken Ödemeleri var..."
        frm.status = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim sayi = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                Panelstatus.Visible = True
                bar.Properties.Maximum = GridView1.SelectedRowsCount
                barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
                    barlabel.Refresh()
                    takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text, frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("lKodu"), dr("sAdi"), dr("sSoyadi"), Microsoft.VisualBasic.Left(dr("Musteri"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", dr("tutar"), False, "", "", "", "", "", False)
                    bar.Position = bar.Position + 1
                    bar.Refresh()
                Next
                bar.Position = 0
                Panelstatus.Visible = False
                dr = Nothing
            End If
            frm.Dispose()
            frm.Close()
            System.GC.SuppressFinalize(frm)
            frm = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub takib_ekle(ByVal dteTarih As DateTime, ByVal TakipTipi As String, ByVal TakipAciklama As String, ByVal PersonelNo As Int64, ByVal Personel As String, ByVal nMusteriID As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal Musteri As String, ByVal Sonuc As String, ByVal IletisimTarihi As DateTime, ByVal IletisimSekli As String, ByVal IlgiliKisi As String, ByVal Gelecekmi As Byte, ByVal GTarih As DateTime, ByVal Tutar As Decimal, ByVal Odendi As Byte, ByVal Istihbarat As String, ByVal Aciklama1 As String, ByVal Aciklama2 As String, ByVal Aciklama3 As String, ByVal Aciklama4 As String, ByVal Status As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim ilk_personel As Decimal = 0
        ilk_personel = sorgu_ilkpersonelno(nMusteriID).ToString
        If ilk_personel > 0 Then
            PersonelNo = ilk_personel
            Personel = sorgu_ilkpersoneladi(ilk_personel)
        Else
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirMusteriTakip                       (dteTarih, TakipTipi, TakipAciklama, PersonelNo, Personel, nMusteriID,lKodu, sAdi, sSoyadi, Musteri, Sonuc, IletisimTarihi, IletisimSekli, IlgiliKisi, Gelecekmi, GTarih, Tutar, Odendi, Istihbarat, Aciklama1, Aciklama2, Aciklama3, Aciklama4, Status,KayitTarihi,ErisimTarihi) VALUES     ('" & dteTarih & "', '" & TakipTipi & "', '" & TakipAciklama & "', " & PersonelNo & ", '" & Personel & "','" & nMusteriID & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & Musteri & "', '" & Sonuc & "', '" & IletisimTarihi & "', '" & IletisimSekli & "', '" & IlgiliKisi & "', " & Gelecekmi & ", '" & GTarih & "', " & Tutar & " , " & Odendi & ", '" & Istihbarat & "', '" & Aciklama1 & "', '" & Aciklama2 & "', '" & Aciklama3 & "', '" & Aciklama4 & "', " & Status & " ,'" & Now & "','" & Now & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        ilk_personel = Nothing
    End Sub
    Public Function sorgu_ilkpersonelno(ByVal nMusteriID) As Int64
        Dim kriter
        kriter = "WHERE (nMusteriID = '" & nMusteriID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(PersonelNo, 0) AS PersonelNo FROM         aEmirMusteriTakip " & kriter & " ORDER BY IND DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_ilkpersoneladi(ByVal PersonelNo As Int64) As String
        Dim kriter
        kriter = "WHERE (IND = '" & PersonelNo & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     PERSONELADI FROM         APERSONEL        " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub taksit_kontrol()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        For Each dr In DataSet1.Tables(0).Rows
            'Satýr Oku
            barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
            barlabel.Refresh()
            ds_taksit_kalan = sorgu_taksitler_kalanli(dr("nMusteriId"))
            Dim toplamtaksit As Decimal = 0
            Dim toplamtahsilat As Decimal = 0
            Dim toplamkalan As Decimal = 0
            Dim gununde As Int64 = 0
            Dim erken As Int64 = 0
            Dim gecikmis As Int64 = 0
            Dim toplam As Int64 = 0
            Dim ilktaksit As DateTime
            Dim ilktaksittutar As Decimal
            Dim gecikmistaksitsayisi As Int64 = 0
            Dim gecikmistaksittutari As Decimal = 0
            Dim kalantaksitsayisi As Int64 = 0
            Dim sayi As Integer = 0
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
            Dim sontahsilattarihi As DateTime
            Dim sontahsilattutari As Decimal = 0
            For Each dr1 In ds_taksit_kalan.Tables(0).Rows
                toplamtaksit = sorgu_sayi(dr1("TUTAR"), 0)
                toplamtahsilat = sorgu_sayi(dr1("TAHSILAT"), 0)
                toplamkalan = sorgu_sayi(dr1("KALAN"), 0)
            Next
            ds_taksitler = sorgu_taksitler(dr("nMusteriID"))
            bar2.Properties.Maximum = ds_taksitler.Tables(0).Rows.Count
            barlabel2.Text = "Taksitler Okunuyor...Toplam Satýr Sayýsý : " & ds_taksitler.Tables(0).Rows.Count
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
            'Try
            '    dr("GECIKENILKTAKSITTARIHI") = ilktaksit
            '    dr("GECIKENILKTAKSITTUTARI") = sorgu_sayi(ilktaksittutar, 2)
            'Catch ex As Exception
            'End Try
            'dr("GECIKMISTAKSIT") = sorgu_sayi(gecikmistaksitsayisi, 0)
            'dr("GECIKMISKALAN") = sorgu_sayi(gecikmistaksittutari, 0)
            'dr("KALANTAKSITSAYISI") = sorgu_sayi(kalantaksitsayisi, 0)
            'Satýþlar
            ds_satislar_detayli = sorgu_satislar_detayli(dr("nMusteriID"))
            sayi = 0
            bar2.Properties.Maximum = ds_satislar_detayli.Tables(0).Rows.Count
            barlabel2.Text = "Satýþlar Okunuyor...Toplam Satýr Sayýsý : " & ds_satislar_detayli.Tables(0).Rows.Count
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
            'dr("SATISSAYISI") = sorgu_sayi(satissayisi, 0)
            'dr("IADESAYISI") = sorgu_sayi(iadesayisi, 0)
            'dr("SATISTUTARI") = sorgu_sayi(satistutari, 0)
            'dr("SATISMIKTARI") = sorgu_sayi(satismiktar, 0)
            'dr("IADETUTARI") = sorgu_sayi(iadetutari, 0)
            'dr("IADEMIKTARI") = sorgu_sayi(iademiktar, 0)
            'dr("TOPLAMSATISTUTARI") = sorgu_sayi(toplamsatistutari, 0)
            'dr("TOPLAMSATISMIKTARI") = sorgu_sayi(toplammiktar, 0)
            'dr("TOPLAMPESINAT") = sorgu_sayi(toplampesinattutari, 0)
            'dr("SONSATISTUTARI") = sorgu_sayi(sonsatistutari, 0)
            'dr("SONSATISTARIHI") = sonsatistarihi
            'Tahsilatlar
            ds_tahsilatlar = sorgu_tahsilatlar_toplam(dr("nMusteriID"))
            bar2.Properties.Maximum = ds_tahsilatlar.Tables(0).Rows.Count
            barlabel2.Text = "Tahsilatlar Okunuyor...Toplam Satýr Sayýsý : " & ds_tahsilatlar.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            For Each dr1 In ds_tahsilatlar.Tables(0).Rows
                sontahsilattarihi = dr1("dteOdemeTarihi")
                sontahsilattutari = dr1("TAHSILAT")
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            'dr("SONTAHSILATTARIHI") = sontahsilattarihi
            'dr("SONTAHSILATTUTARI") = sorgu_sayi(sontahsilattutari, 0)
            Try
                ds_odemeler = sorgu_odemeler_sayi(dr("nMusteriID"))
                bar2.Properties.Maximum = ds_odemeler.Tables(0).Rows.Count
                barlabel2.Text = "ÖdemeAnalizi Okunuyor...Toplam Satýr Sayýsý : " & ds_odemeler.Tables(0).Rows.Count
                bar2.Position = 0
                barlabel2.Refresh()
                For Each dr1 In ds_odemeler.Tables(0).Rows
                    gecikmis = sorgu_sayi(dr1("GECIKMIS"), 0)
                    erken = sorgu_sayi(dr1("ERKEN"), 0)
                    gununde = sorgu_sayi(dr1("GUNUNDE"), 0)
                    bar2.Position = bar2.Position + 1
                    bar2.Refresh()
                Next
                'dr("GUNUNDE") = gununde
                'dr("GECIKMIS") = gecikmis
                'dr("ERKEN") = erken
                'dr("TOPLAM") = gununde + gecikmis + erken
            Catch ex As Exception
                gununde = 0
                gecikmis = 0
                erken = 0
                toplam = 0
                'dr("GUNUNDE") = 0
                'dr("GECIKMIS") = 0
                'dr("ERKEN") = 0
                'dr("TOPLAM") = 0
            End Try
            toplam = gununde + gecikmis + erken
            'Satýr Bitir
            bar2.Properties.Maximum = ds_taksitler.Tables(0).Rows.Count
            barlabel2.Text = "Taksitler Oluþturuluyor...Toplam Satýr Sayýsý : " & ds_taksitler.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            For Each dr1 In ds_taksitler.Tables(0).Rows
                mektup_kaydet_yeni(dr("nMusteriID"), dr("sMagaza").ToString, dr("lKodu").ToString, dr("sAdi").ToString, dr("sSoyadi").ToString, dr("Musteri").ToString, dr("nCinsiyet"), dr("lAylikGelir"), dr("dteKartAcilisTarihi"), dr("nIskontoPesin"), dr("nIskontoKredili"), dr("sUnvan").ToString, dr("sVergiDairesi").ToString, dr("sVergiNo").ToString, dr("bYazismaEvAdresinemi"), dr("sEmail").ToString, dr("sIsYeriAdi").ToString, dr("sIsAdresi").ToString, dr("sIsTelefonu").ToString, dr("sEvAdresi").ToString, dr("sEvTelefonu").ToString, dr("sSigortaNo").ToString, dr("bEvlimi"), dr("dteEvlilikTarihi"), dr("dteDogumTarihi"), dr("sDogumYeri").ToString, dr("sEhliyetNo").ToString, dr("sKanGrubu").ToString, dr("dteKayitTarihi"), dr("ISTIHBARAT").ToString, dr("sGSM").ToString, dr("sFax").ToString, dr("SOZLESME").ToString, dr("Sýnýf1").ToString, dr("Sýnýf2").ToString, dr("Sýnýf3").ToString, dr("Sýnýf4").ToString, dr("Sýnýf5").ToString, 1, 1, sonsatistarihi, sontahsilattarihi, satistutari, satismiktar, iadetutari, iademiktar, toplamsatistutari, toplammiktar, toplampesinattutari, toplamtaksit, ilktaksit, ilktaksittutar, toplamtahsilat, toplamkalan, gecikmistaksittutari, gecikmistaksitsayisi, kalantaksitsayisi, satissayisi, iadesayisi, sonsatistutari, sontahsilattutari, gununde, erken, gecikmis, toplam, 0, dr1("dteTarihi"), dr1("TUTAR"), dr1("TAHSILAT"), dr1("KALAN"))
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu")
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_satislar_toplam(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     SUM(lToplamMiktar) AS MIKTAR, SUM(lNetTutar) AS TUTAR, SUM(lPesinat) AS PESINAT FROM         tbAlisVeris WHERE     (nMusteriID = " & musterino & ")")
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
    Public Function sorgu_odemeler_sayi(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nMusteriID, SUM(GECIKMIS) AS GECIKMIS, SUM(ERKEN) AS ERKEN, SUM(GUNUNDE) AS GUNUNDE FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkGecikmis > 0) GROUP BY Musteri_TanimlamaNo UNION SELECT Musteri_TanimlamaNo AS nMusteriID , 0 AS GECIKMIS , COUNT(*) AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken > 0) GROUP BY Musteri_TanimlamaNo UNION SELECT Musteri_TanimlamaNo AS nMusteriID , 0 AS GECIKMIS , 0 AS ERKEN , COUNT(*) AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken = 0) AND (NFarkGecikmis = 0) GROUP BY Musteri_TanimlamaNo) T GROUP BY nMusteriID")
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
    Private Sub mektup_kaydet_yeni(ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal Musteri As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Int64, ByVal nIskontoKredili As Int64, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Byte, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi As String, ByVal sIsTelefonu As String, ByVal sEvAdresi As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Byte, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal dteKayitTarihi As DateTime, ByVal ISTIHBARAT As String, ByVal sGSM As String, ByVal sFax As String, ByVal SOZLESME As String, ByVal Sýnýf1 As String, ByVal Sýnýf2 As String, ByVal Sýnýf3 As String, ByVal Sýnýf4 As String, ByVal Sýnýf5 As String, ByVal Status As Byte, ByVal MektupSayisi As Int64, ByVal SonSatisTarihi As DateTime, ByVal SonTahsilatTarihi As DateTime, ByVal SatisTutari As Decimal, ByVal SatisMiktari As Decimal, ByVal IadeTutari As Decimal, ByVal IadeMiktari As Decimal, ByVal ToplamSatisTutari As Decimal, ByVal ToplamSatisMiktari As Decimal, ByVal ToplamPesinat As Decimal, ByVal ToplamTaksit As Decimal, ByVal GecikenIlkTaksitTarihi As DateTime, ByVal GecikenIlkTaksitTutari As Decimal, ByVal ToplamTahsilat As Decimal, ByVal ToplamKalan As Decimal, ByVal GecikmisKalan As Decimal, ByVal GecikmisTaksit As Decimal, ByVal KalanTaksitSayisi As Decimal, ByVal SatisSayisi As Decimal, ByVal IadeSayisi As Decimal, ByVal SonSatisTutari As Decimal, ByVal SonTahsilatTutari As Decimal, ByVal Gununde As Decimal, ByVal Erken As Decimal, ByVal Gecikmis As Decimal, ByVal Toplam As Decimal, ByVal Kayit As Decimal, ByVal dteTarihi As DateTime, ByVal Tutar As Decimal, ByVal Tahsilat As Decimal, ByVal Kalan As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirMusteriMektup                       (nMusteriID, sMagaza, lKodu, sAdi, sSoyadi, Musteri, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, sEmail, sIsYeriAdi, sIsAdresi, sIsTelefonu, sEvAdresi, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, dteKayitTarihi, ISTIHBARAT, sGSM, sFax, SOZLESME, Sýnýf1, Sýnýf2, Sýnýf3, Sýnýf4, Sýnýf5, Status, MektupSayisi, SonSatisTarihi, SonTahsilatTarihi, SatisTutari, SatisMiktari, IadeTutari, IadeMiktari, ToplamSatisTutari, ToplamSatisMiktari, ToplamPesinat, ToplamTaksit, GecikenIlkTaksitTarihi, GecikenIlkTaksitTutari, ToplamTahsilat, ToplamKalan, GecikmisKalan, GecikmisTaksit, KalanTaksitSayisi, SatisSayisi, IadeSayisi, SonSatisTutari, SonTahsilatTutari, Gununde, Erken, Gecikmis, Toplam, Kayit, dteTarihi, Tutar, Tahsilat, Kalan) VALUES     (" & nMusteriID & ", '" & sMagaza & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & Musteri & "', " & nCinsiyet & ", " & lAylikGelir & ", '" & dteKartAcilisTarihi & "', " & nIskontoPesin & ", " & nIskontoKredili & ", '" & sUnvan & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bYazismaEvAdresinemi & ", '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi & "', '" & sIsTelefonu & "', '" & sEvAdresi & "', '" & sEvTelefonu & "', '" & sSigortaNo & "', " & bEvlimi & ", '" & dteEvlilikTarihi & "', '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sEhliyetNo & "', '" & sKanGrubu & "', '" & dteKayitTarihi & "', '" & ISTIHBARAT & "', '" & sGSM & "', '" & sFax & "', '" & SOZLESME & "', '" & Sýnýf1 & "', '" & Sýnýf2 & "', '" & Sýnýf3 & "', '" & Sýnýf4 & "', '" & Sýnýf5 & "', " & Status & ", " & MektupSayisi & ", '" & SonSatisTarihi & "', '" & SonTahsilatTarihi & "', " & SatisTutari & ", " & SatisMiktari & ", " & IadeTutari & ", " & IadeMiktari & ", " & ToplamSatisTutari & ", " & ToplamSatisMiktari & ",  " & ToplamPesinat & ", " & ToplamTaksit & ", '" & GecikenIlkTaksitTarihi & "', " & GecikenIlkTaksitTutari & ", " & ToplamTahsilat & ", " & ToplamKalan & ", " & GecikmisKalan & ", " & GecikmisTaksit & ", " & KalanTaksitSayisi & ", " & SatisSayisi & ", " & IadeSayisi & ", " & SonSatisTutari & ", " & SonTahsilatTutari & ", " & Gununde & ", " & Erken & ", " & Gecikmis & ", " & Toplam & ", " & Kayit & ", '" & dteTarihi & "', " & Tutar & ", " & Tahsilat & ", " & Kalan & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub mektup_sil_tumu()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("Truncate table aEmirMusteriMektup")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        takibe_al()
    End Sub
    Private Sub frm_musteri_geciken_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            StopSearch()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub sec_ilktaksit_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_ilktaksit.CheckStateChanged
        If sec_ilktaksit.Checked = True Then
            Date_ilktaksit.Enabled = True
        Else
            Date_ilktaksit.Enabled = False
        End If
    End Sub
    Public Sub BeginSearch()
        ' Create the search thread, which 
        ' will begin the search.
        ' If already searching, do nothing.
        '
        ' Start the search if the handle has
        ' been created. Otherwise, defer it until the
        ' handle has been created.
        If IsHandleCreated Then
            _searchThread = New Thread(New ThreadStart(AddressOf loading))
            _searching = True
            _searchThread.Start()
        Else
            _deferSearch = True
        End If
    End Sub
    Public Sub StopSearch()
        If Not _searching Then
            Return
        End If
        If _searchThread.IsAlive Then
            _searchThread.Abort()
            _searchThread.Join()
        End If
        _searchThread = Nothing
        _searching = False
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " WHERE nMusteriID > 0"
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "C:\Formlar\Raporlar\Musteri_Mektup\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
        file = Nothing
        kriter = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            'Dim qr_baslik As New TfrxADOQuery
            Dim qr_hareket As New TfrxADOQuery
            Dim frx As New TfrxReportClass
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            If yazdirmaSecenegi.SelectedIndex = 0 Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT *, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM aEmirMusteriMektup ORDER BY nMusteriID")
            ElseIf yazdirmaSecenegi.SelectedIndex = 1 Then
                qr_hareket = frx.FindObject("qr_kefil1")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil1 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID")
                qr_hareket = frx.FindObject("qr_kefil2")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil2 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID")
            ElseIf yazdirmaSecenegi.SelectedIndex = 2 Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT *, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM aEmirMusteriMektup ORDER BY nMusteriID")
                qr_hareket = frx.FindObject("qr_kefil1")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil1 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID")
                qr_hareket = frx.FindObject("qr_kefil2")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil2 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID")
            ElseIf yazdirmaSecenegi.SelectedIndex = 3 Then
                qr_hareket = frx.FindObject("qr_hareket")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT *, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM aEmirMusteriMektup ORDER BY nMusteriID, dteTarihi")
            End If
            'qr_baslik = frx.FindObject("qr_baslik")
            'qr_baslik.Query = sorgu_query("set transaction isolation level read uncommitted SELECT     * FROM         ASTOKETIKETTALEPBASLIK WHERE IND =" & belgeind & "")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            'qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                'frx.PrepareReport(True)
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_connection = Nothing
            qr_hareket = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(4) = "" & status.ToString() & ""
            args(5) = "4"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            'args(2) = """" & sorgu_query("set transaction isolation level read uncommitted SELECT *, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM aEmirMusteriMektup ORDER BY nMusteriID") & """"
            'args(3) = """qr_hareket"""
            If yazdirmaSecenegi.SelectedIndex = 0 Then
                args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT *, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM aEmirMusteriMektup ORDER BY nMusteriID") & ""
                args(3) = "qr_musteri"
            ElseIf yazdirmaSecenegi.SelectedIndex = 1 Then
                args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil1 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil2 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID") & ""
                args(3) = "qr_kefil1éqr_kefil2"
            ElseIf yazdirmaSecenegi.SelectedIndex = 2 Then
                args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT *, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM aEmirMusteriMektup ORDER BY nMusteriID") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil1 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT aEmirMusteriMektup.*, NEWID() AS Ref, MONTH(dteTarihi) AS Ay, YEAR(dteTarihi) AS Yil, ROUND(CAST(GETDATE() - (CAST(dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME, k.sAdi + ' ' + k.sSoyadi AS KSAdi, k.sIsYeriAdi + '' + k.sIsAdresi1 + ' ' + k.sIsAdresi2 + ' ' + k.sIsSemt + ' ' + k.sIsPostaKodu + ' ' + k.sIsIl AS KSIsAdresi, k.sIsTelefonu as KSIsTelefonu, k.sEvAdresi1 + ' ' + k.sEvAdresi2 + ' ' + k.sEvSemt + ' ' + k.sEvPostaKodu + ' ' + k.sEvIl AS KSEvAdresi, k.sEvTelefonu as KSEvTelefonu FROM aEmirMusteriMektup inner join tbMusteriKefil2 as k on k.nMusteriID=aEmirMusteriMektup.nMusteriID WHERE k.sAdi <> '' ORDER BY aEmirMusteriMektup.nMusteriID") & ""
                args(3) = "qr_musteriéqr_kefil1éqr_kefil2"
            End If
            processYol = args(0)
            For i As Integer = 1 To 13
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub satir_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Satýrlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView1.DeleteSelectedRows()
            Try
                DataSet1.AcceptChanges()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show(Sorgu_sDil("Mektup gönderilecek Müþterilerin dosyasýný hazýrlamak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            mektup_sil_tumu()
            taksit_kontrol()
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        raporla(0, 2)
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        raporla(0, 1)
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        satir_sil()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        musteri_notlari()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_pdf()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        If MenuItem28.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem28.Checked = True
        ElseIf MenuItem28.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem28.Checked = False
        End If
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        SMS_Gonder(False)
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        SMS_Gonder(True)
    End Sub
End Class
