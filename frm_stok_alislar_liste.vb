Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_alislar_liste
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Dataset1 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_kasiyer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_depo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sonuc As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTransferDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFaturalasti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMuhasebelesti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamamlandi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHizmet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_satici As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISKONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_resmi1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_fistipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents colnEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_alislar_liste))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colTamamlandi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_fistipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_resmi1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_satici = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_sonuc = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kasiyer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit()
        Me.sec_depo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.Dataset1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTransferDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFaturalasti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMuhasebelesti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHizmet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_satici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sonuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colTamamlandi
        '
        Me.colTamamlandi.Caption = "Tamamlandi?"
        Me.colTamamlandi.FieldName = "Tamamlandi"
        Me.colTamamlandi.Name = "colTamamlandi"
        Me.colTamamlandi.Width = 82
        '
        'colISKONTO
        '
        Me.colISKONTO.Caption = "% Ýsk."
        Me.colISKONTO.DisplayFormat.FormatString = "P"
        Me.colISKONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISKONTO.FieldName = "ISKONTO"
        Me.colISKONTO.Name = "colISKONTO"
        Me.colISKONTO.Visible = True
        Me.colISKONTO.VisibleIndex = 9
        Me.colISKONTO.Width = 56
        '
        'colEkOran
        '
        Me.colEkOran.Caption = "% Ek Oran"
        Me.colEkOran.DisplayFormat.FormatString = "P"
        Me.colEkOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkOran.FieldName = "EkOran"
        Me.colEkOran.Name = "colEkOran"
        Me.colEkOran.Visible = True
        Me.colEkOran.VisibleIndex = 12
        Me.colEkOran.Width = 56
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 22)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 120)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.sec_fistipi)
        Me.GroupControl1.Controls.Add(Me.sec_resmi1)
        Me.GroupControl1.Controls.Add(Me.sec_resmi)
        Me.GroupControl1.Controls.Add(Me.txt_satici)
        Me.GroupControl1.Controls.Add(Me.sec_sonuc)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txt_kasiyer)
        Me.GroupControl1.Controls.Add(Me.txt_kod)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(597, 116)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Ara"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(16, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 65
        Me.LabelControl4.Text = "Depo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(16, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl3.TabIndex = 64
        Me.LabelControl3.Text = "Müþteri:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(16, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 63
        Me.LabelControl2.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(16, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 62
        Me.LabelControl1.Text = "Yetkili:"
        '
        'sec_fistipi
        '
        Me.sec_fistipi.EditValue = "FA"
        Me.sec_fistipi.EnterMoveNextControl = True
        Me.sec_fistipi.Location = New System.Drawing.Point(280, 20)
        Me.sec_fistipi.Name = "sec_fistipi"
        Me.sec_fistipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fistipi.Properties.Items.AddRange(New Object() {"FA", "FS"})
        Me.sec_fistipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_fistipi.Size = New System.Drawing.Size(80, 20)
        Me.sec_fistipi.TabIndex = 54
        '
        'sec_resmi1
        '
        Me.sec_resmi1.Location = New System.Drawing.Point(312, 64)
        Me.sec_resmi1.Name = "sec_resmi1"
        Me.sec_resmi1.Properties.Caption = "R1"
        Me.sec_resmi1.Size = New System.Drawing.Size(48, 19)
        Me.sec_resmi1.TabIndex = 53
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(280, 64)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 52
        '
        'txt_satici
        '
        Me.txt_satici.EnterMoveNextControl = True
        Me.txt_satici.Location = New System.Drawing.Point(69, 64)
        Me.txt_satici.Name = "txt_satici"
        Me.txt_satici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_satici.Size = New System.Drawing.Size(195, 20)
        Me.txt_satici.TabIndex = 39
        '
        'sec_sonuc
        '
        Me.sec_sonuc.EditValue = "[Tümü]"
        Me.sec_sonuc.Enabled = False
        Me.sec_sonuc.EnterMoveNextControl = True
        Me.sec_sonuc.Location = New System.Drawing.Point(184, 86)
        Me.sec_sonuc.Name = "sec_sonuc"
        Me.sec_sonuc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sonuc.Properties.Items.AddRange(New Object() {"[Tümü]", "Bekliyor...", "Tamamlandý...", "Ýptal Edildi...", "Ürün Talebi...", "Sipariþ Talebi..."})
        Me.sec_sonuc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sonuc.Size = New System.Drawing.Size(80, 20)
        Me.sec_sonuc.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(144, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Sonuç:"
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(136, 20)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(128, 20)
        Me.txt_kasiyer.TabIndex = 48
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(69, 20)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(67, 20)
        Me.txt_kod.TabIndex = 47
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.Enabled = False
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(69, 86)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.Items.AddRange(New Object() {"[Tümü]", "D001", "D002", "D003", "D004", "D005", "D006", "D007", "D008", "D009", "D010", "AKAT", "BKAT", "GKAT", "1KAT", "2KAT", "3KAT", "4KAT", "5KAT", "6KAT", "7KAT", "8KAT", "9KAT", "", ""})
        Me.sec_depo.Properties.ReadOnly = True
        Me.sec_depo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_depo.Size = New System.Drawing.Size(75, 20)
        Me.sec_depo.TabIndex = 40
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(280, 86)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton5.TabIndex = 44
        Me.SimpleButton5.Text = "&Listele"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(277, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "arasýndaki"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(165, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(184, 42)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit2.TabIndex = 38
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(69, 42)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.ReadOnly = True
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(90, 20)
        Me.DateEdit1.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(693, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fatura Listesi Aþaðýdadýr..."
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 367)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(158, 8)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton6.TabIndex = 7
        Me.SimpleButton6.Text = "&Yazdýr"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(83, 8)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "&Yenile"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(304, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 8)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Ýncele"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 142)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 225)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 221)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 188)
        Me.XtraTabPage1.Text = "Fiþler"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.Dataset1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(818, 188)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Dataset1
        '
        Me.Dataset1.DataSetName = "NewDataSet"
        Me.Dataset1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.Dataset1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "dteFisTarihi"
        Me.DataColumn1.DataType = GetType(Date)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lFisNo"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nGirisCikis"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lToplamMiktar"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lNetTutar"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sDepo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Depo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sKodu"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAciklama"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sTransferDepo"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "tDepo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sFaturalasti"
        Me.DataColumn12.DataType = GetType(Boolean)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Muhasebelesti"
        Me.DataColumn13.DataType = GetType(Boolean)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sHareketTipi"
        Me.DataColumn14.DataType = GetType(System.TimeSpan)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sNot"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Tamamlandi"
        Me.DataColumn16.DataType = GetType(Boolean)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lTevkifatKdvMatrahi"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "lTevkifatKdv"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Hizmet"
        Me.DataColumn19.DataType = GetType(Boolean)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "nFirmaID"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sFisTipi"
        Me.DataColumn21.DataType = GetType(System.TimeSpan)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nStokFisiID"
        Me.DataColumn22.DataType = GetType(Long)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "nEvrakNo"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteFisTarihi, Me.collFisNo, Me.colnGirisCikis, Me.collToplamMiktar, Me.collNetTutar, Me.colsDepo, Me.colDepo, Me.colsKodu, Me.colsAciklama, Me.colsTransferDepo, Me.coltDepo, Me.colsFaturalasti, Me.colMuhasebelesti, Me.colsHareketTipi, Me.colsNot, Me.colTamamlandi, Me.collTevkifatKdvMatrahi, Me.collTevkifatKdv, Me.colHizmet, Me.colnFirmaID, Me.colsFisTipi, Me.colnStokFisiID, Me.colKdvTutari, Me.colKdvMatrahi, Me.collMalIskontoTutari, Me.collMalBedeli, Me.colEkMaliyet, Me.colISKONTO, Me.colEkOran, Me.colnEvrakNo})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(796, 271, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colTamamlandi
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Tag = False
        StyleFormatCondition1.Value1 = False
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colISKONTO
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colEkOran
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition3.Tag = "0"
        StyleFormatCondition3.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Tarih"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", "{0} Kayýt")})
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 0
        Me.coldteFisTarihi.Width = 65
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 4
        Me.collFisNo.Width = 51
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Visible = True
        Me.colnGirisCikis.VisibleIndex = 5
        Me.colnGirisCikis.Width = 61
        '
        'collToplamMiktar
        '
        Me.collToplamMiktar.Caption = "Miktar"
        Me.collToplamMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collToplamMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamMiktar.FieldName = "lToplamMiktar"
        Me.collToplamMiktar.Name = "collToplamMiktar"
        Me.collToplamMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamMiktar", "{0:#,0.00}")})
        Me.collToplamMiktar.Visible = True
        Me.collToplamMiktar.VisibleIndex = 6
        Me.collToplamMiktar.Width = 53
        '
        'collNetTutar
        '
        Me.collNetTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collNetTutar.AppearanceCell.Options.UseFont = True
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 13
        Me.collNetTutar.Width = 65
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "DepoKodu"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colDepo
        '
        Me.colDepo.Caption = "DepoAdý"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Firma Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Width = 142
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Firma Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 147
        '
        'colsTransferDepo
        '
        Me.colsTransferDepo.Caption = "Transfer Depo"
        Me.colsTransferDepo.FieldName = "sTransferDepo"
        Me.colsTransferDepo.Name = "colsTransferDepo"
        '
        'coltDepo
        '
        Me.coltDepo.Caption = "Transfer Depo Adý"
        Me.coltDepo.FieldName = "tDepo"
        Me.coltDepo.Name = "coltDepo"
        '
        'colsFaturalasti
        '
        Me.colsFaturalasti.Caption = "Faturalaþtý ?"
        Me.colsFaturalasti.FieldName = "sFaturalasti"
        Me.colsFaturalasti.Name = "colsFaturalasti"
        '
        'colMuhasebelesti
        '
        Me.colMuhasebelesti.Caption = "Muhasebeleþti"
        Me.colMuhasebelesti.FieldName = "Muhasebelesti"
        Me.colMuhasebelesti.Name = "colMuhasebelesti"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Width = 67
        '
        'colsNot
        '
        Me.colsNot.Caption = "Notlar"
        Me.colsNot.FieldName = "sNot"
        Me.colsNot.Name = "colsNot"
        Me.colsNot.Visible = True
        Me.colsNot.VisibleIndex = 14
        Me.colsNot.Width = 255
        '
        'collTevkifatKdvMatrahi
        '
        Me.collTevkifatKdvMatrahi.Caption = "Tevkifat Kdv Matrahý"
        Me.collTevkifatKdvMatrahi.FieldName = "lTevkifatKdvMatrahi"
        Me.collTevkifatKdvMatrahi.Name = "collTevkifatKdvMatrahi"
        '
        'collTevkifatKdv
        '
        Me.collTevkifatKdv.Caption = "Tevkifat Kdv"
        Me.collTevkifatKdv.FieldName = "lTevkifatKdv"
        Me.collTevkifatKdv.Name = "collTevkifatKdv"
        '
        'colHizmet
        '
        Me.colHizmet.Caption = "Hizmet?"
        Me.colHizmet.FieldName = "Hizmet"
        Me.colHizmet.Name = "colHizmet"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 3
        Me.colsFisTipi.Width = 49
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Kayýt No"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colKdvTutari
        '
        Me.colKdvTutari.Caption = "Kdv Tutarý"
        Me.colKdvTutari.DisplayFormat.FormatString = "#,#.##"
        Me.colKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvTutari.FieldName = "KdvTutari"
        Me.colKdvTutari.Name = "colKdvTutari"
        Me.colKdvTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvTutari", "{0:#,0.00}")})
        Me.colKdvTutari.Visible = True
        Me.colKdvTutari.VisibleIndex = 10
        Me.colKdvTutari.Width = 56
        '
        'colKdvMatrahi
        '
        Me.colKdvMatrahi.Caption = "Kdv Matrahý"
        Me.colKdvMatrahi.DisplayFormat.FormatString = "#,0.00"
        Me.colKdvMatrahi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvMatrahi.FieldName = "KdvMatrahi"
        Me.colKdvMatrahi.Name = "colKdvMatrahi"
        Me.colKdvMatrahi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvMatrahi", "{0:#,0.00}")})
        '
        'collMalIskontoTutari
        '
        Me.collMalIskontoTutari.Caption = "Ýskonto"
        Me.collMalIskontoTutari.DisplayFormat.FormatString = "#,#.##"
        Me.collMalIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalIskontoTutari.FieldName = "lMalIskontoTutari"
        Me.collMalIskontoTutari.Name = "collMalIskontoTutari"
        Me.collMalIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalIskontoTutari", "{0:#,0.00}")})
        Me.collMalIskontoTutari.Visible = True
        Me.collMalIskontoTutari.VisibleIndex = 8
        '
        'collMalBedeli
        '
        Me.collMalBedeli.Caption = "Brüt"
        Me.collMalBedeli.DisplayFormat.FormatString = "#,0.00"
        Me.collMalBedeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalBedeli.FieldName = "lMalBedeli"
        Me.collMalBedeli.Name = "collMalBedeli"
        Me.collMalBedeli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalBedeli", "{0:#,0.00}")})
        Me.collMalBedeli.Visible = True
        Me.collMalBedeli.VisibleIndex = 7
        Me.collMalBedeli.Width = 60
        '
        'colEkMaliyet
        '
        Me.colEkMaliyet.Caption = "Ek Maliyet"
        Me.colEkMaliyet.DisplayFormat.FormatString = "#,#.##"
        Me.colEkMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkMaliyet.FieldName = "EkMaliyet"
        Me.colEkMaliyet.Name = "colEkMaliyet"
        Me.colEkMaliyet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EkMaliyet", "{0:#,0.00}")})
        Me.colEkMaliyet.Visible = True
        Me.colEkMaliyet.VisibleIndex = 11
        Me.colEkMaliyet.Width = 56
        '
        'colnEvrakNo
        '
        Me.colnEvrakNo.Caption = "Evrak No"
        Me.colnEvrakNo.FieldName = "nEvrakNo"
        Me.colnEvrakNo.Name = "colnEvrakNo"
        Me.colnEvrakNo.Visible = True
        Me.colnEvrakNo.VisibleIndex = 2
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_renk.ShowFooter = False
        Me.sec_renk.ShowHeader = False
        Me.sec_renk.ShowLines = False
        Me.sec_renk.ValueMember = "sRenk"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem20, Me.MenuItem4, Me.MenuItem13, Me.MenuItem32, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem15.Text = "Ara"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem27, Me.MenuItem28, Me.MenuItem31, Me.MenuItem29, Me.MenuItem30})
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 0
        Me.MenuItem27.Text = "Yeni Alýþ Faturasý"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 1
        Me.MenuItem28.Text = "Yeni Satýþ Faturasý"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 2
        Me.MenuItem31.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        Me.MenuItem29.Text = "Yeni Alýþ Ýade Faturasý"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 4
        Me.MenuItem30.Text = "Yeni Satýþ Ýade Faturasý"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = False
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 5
        Me.MenuItem20.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = False
        Me.MenuItem4.Index = 6
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem12, Me.MenuItem25, Me.MenuItem19, Me.MenuItem24, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem26})
        Me.MenuItem4.Text = "Raporla"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Hata Kaydý Düþülenler"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Açýklama Kaydý Düþülenler"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Okutulmayanlar"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.Text = "Depolar Sonradan Teslim Listesi"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Text = "Tümü"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 5
        Me.MenuItem24.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Text = "Çýkýþý Yapýlmayan Kredili Satýþlar"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 7
        Me.MenuItem22.Text = "Çýkýþý Yapýlmayan Peþin Satýþlar"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 8
        Me.MenuItem23.Text = "Çýkýþý Yapýlmayan Sonradan Teslimler"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 9
        Me.MenuItem26.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 7
        Me.MenuItem13.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 8
        Me.MenuItem32.Text = "Hýzlý Filtre"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 9
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 10
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 11
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 12
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 14
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 15
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 16
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem17.Text = "Tam Ekran"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Alýþ Faturalarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Bilgi"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Firma Bekleyen Sipariþleri"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Müþteri Bekleyen Satýþlar"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Ekstre"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Kar/Zarar Analizi"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "*"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 22)
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
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 385)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 385)
        '
        'frm_stok_alislar_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_alislar_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fatura Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_satici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sonuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean = False
    Public connection
    Public connection_resmi
    Public connection_orj
    Public connection_resmi1
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Public stokkodu
    Public malincinsi
    Public barkod
    Public muadilbarkod
    Public birim
    Public kod1
    Public kod2
    Public kod3
    Public kod4
    Public kod5
    Public kod6
    Public kod7
    Public kod8
    Public kod9
    Public kod10
    Public satisfiyati1
    Public satisfiyati2
    Public satisfiyati3
    Public istihbarat
    Public kayitno
    Public aktif
    Public sil As Boolean = False
    Public gelismis
    Public sonuc
    Public qkayitno
    Public qstokkodu
    Public qmalincinsi
    Public qbarkod
    Public qmuadilbarkod
    Public qkod1
    Public qkod2
    Public qkod3
    Public qkod4
    Public qkod5
    Public qkod6
    Public qkod7
    Public qkod8
    Public qkod9
    Public qkod10
    Public qistihbarat
    Public qbirim
    Public qdepo
    Public qsatisfiyati1
    Public qsatisfiyati2
    Public qsatisfiyati3
    Public qaktif
    Public qgelismis
    Public qsonuc
    Public ilktarih
    Public sontarih
    Public ilkbelge
    Public sonbelge
    Public firmakodu
    Public firmaadi
    Public personel
    Public depo
    Public parabirimi
    Public kur
    Public aciklama
    Public kdvdahil
    Public kapali
    Public qilktarih
    Public qsontarih
    Public qilkbelge
    Public qsonbelge
    Public qfirmakodu
    Public qfirmaadi
    Public qpersonel
    Public qparabirimi
    Public qkur
    Public qaciklama
    Public qkdvdahil
    Public qkapali
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public frf_islem As String = "mektup"
    Dim depokodu As String
    Dim ds_kasiyer As DataSet
    Dim ds_satir_firma As DataSet
    Dim ds_stok_fisi_detay As DataSet
    Public kasiyerno
    Public kasiyer
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        connection_resmi1 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi1")
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        Try
            depokodu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
            If depokodu <> "True" Then
                sec_depo.Text = depokodu
            Else
                sec_depo.Text = "[Tümü]"
            End If
        Catch ex As Exception
            'dr("DEPO") = "1KAT"
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", "True")
        End Try
        qdepo = "Eþittir"
        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            sec_depo.EditValue = "'" & sDepo & "'"
            If kullanici > 3 Then
                sec_depo.Properties.ReadOnly = False
            Else
                sec_depo.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                sec_depo.EditValue = "'" & sDepo & "'"
                sec_depo.Properties.ReadOnly = True
            Else
                'sec_sDepo.EditValue = sDepo
                sec_depo.Properties.ReadOnly = False
            End If
            'sec_sDepo.EditValue = sDepo
            'sec_sDepo.Properties.ReadOnly = False
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        Me.WindowState = FormWindowState.Maximized
        Me.Refresh()
        dataload_kasiyer()
        txt_kod.Focus()
        txt_kod.Select()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
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
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_depo()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
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
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kod.Text Then
                kasiyerno = dr("IND")
                kasiyer = dr("KASIYER")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            txt_kasiyer.EditValue = kasiyer
            txt_kod.Enabled = False
            If Trim(kasiyerno) = "VC" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                sec_depo.Properties.ReadOnly = False
                sec_sonuc.Properties.ReadOnly = False
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                sec_depo.Properties.ReadOnly = False
                sec_sonuc.Properties.ReadOnly = False
            End If
            DateEdit1.Focus()
            DateEdit1.SelectAll()
            GridControl1.Enabled = True
            status = True
        ElseIf sonuc = False Then
            txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            GridControl1.Enabled = False
            txt_kod.Focus()
            txt_kod.SelectAll()
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ara()
        Dim frm As New frm_fatura_ara
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.rowSTOKKODU.Visible = False
        frm.rowMALINCINSI.Visible = False
        frm.rowFIRMAKODU.Visible = False
        frm.rowFIRMAADI.Visible = False
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.kayitno
            ilktarih = frm.ilktarih
            sontarih = frm.sontarih
            ilkbelge = frm.ilkbelge
            sonbelge = frm.sonbelge
            firmakodu = frm.firmakodu
            firmaadi = frm.firmaadi
            parabirimi = frm.parabirimi
            kur = frm.kur
            personel = frm.personel
            depo = frm.depo
            kod1 = frm.kod1
            kod2 = frm.kod2
            kdvdahil = frm.kdvdahil
            kapali = frm.kapali
            qkayitno = frm.qkayitno
            qilktarih = frm.qilktarih
            qsontarih = frm.qsontarih
            qilkbelge = frm.qilkbelge
            qsonbelge = frm.qsonbelge
            qfirmakodu = frm.qfirmakodu
            qfirmaadi = frm.qfirmaadi
            qparabirimi = frm.qparabirimi
            qkur = frm.qkur
            qpersonel = frm.qpersonel
            qdepo = frm.qdepo
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkdvdahil = frm.qkdvdahil
            qkapali = frm.qkapali
            Dataset1.Clear()
            Dataset1.Dispose()
            dataload()
        Else
            Me.Close()
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.SimpleButton1 = Nothing
        frm.SimpleButton2 = Nothing
        frm.PanelControl1.Dispose()
        frm.PanelControl1 = Nothing
        frm.PanelControl2.Dispose()
        frm.PanelControl2 = Nothing
        frm.PanelControl3.Dispose()
        frm.PanelControl3 = Nothing
        frm.PictureBox1.Dispose()
        frm.PictureBox1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.XtraTabControl1.Dispose()
        frm.XtraTabControl1 = Nothing
        frm.XtraTabPage1.Dispose()
        frm.XtraTabPage1 = Nothing
        frm.Label1.Dispose()
        frm.Label1 = Nothing
        frm.Dispose()
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub dataload()
        ilktarih = (DateEdit1.EditValue).ToString
        sontarih = (DateEdit2.EditValue).ToString
        If sec_depo.Text <> "[Tümü]" Then
            depo = sec_depo.Text
        Else
            depo = ""
        End If
        If sec_sonuc.Text <> "[Tümü]" Then
            sonuc = sec_sonuc.Text
        Else
            sonuc = ""
        End If
        qdepo = "Eþittir"
        qsonuc = "Eþittir"
        dataload_depo()
        'DataSet1.Clear()
        'DataSet1.Dispose()
        Dataset1 = stok()
        Dim dr1 As DataRow
        For Each dr1 In Dataset1.Tables(0).Rows
            Try
                dr1("ISKONTO") = (dr1("lMalIskontoTutari") + dr1("lDipIskontoTutari3")) / dr1("lMalBedeli")
                If CType(dr1("Ekmaliyet"), Decimal) <> 0 Then
                    dr1("EkOran") = CType(dr1("Ekmaliyet"), Decimal) / CType(dr1("lMalBedeli") - dr1("lMalIskontoTutari"), Decimal)
                End If
            Catch ex As Exception
            End Try
        Next
        dr1 = Nothing
        GridControl1.DataSource = Dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.SelectRow(0)
    End Sub
    Private Sub stok_yeni()
        Dim frm As New frm_stok_etikettalep
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dataload()
    End Sub
    Private Sub firma()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_satici.Text = Trim(dr1("sKodu"))
        End If
    End Sub
    Private Sub ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        Dim frm_firma As New frm_firma_liste
        frm_firma.firmano = firmano
        frm_firma.donemno = donemno
        frm_firma.connection = connection
        frm_firma.islemstatus = True
        frm_firma.kullanici = kullanici
        If frm_firma.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm_firma.GridView1.GetDataRow(frm_firma.GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nStokFisiID = ""
            frm.nFirmaID = dr1("nFirmaID")
            frm.sFisTipi = sFisTipi
            frm.nGirisCikis = nGirisCikis
            frm.dteFisTarihi = Today
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub satir_firma_info()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
            Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
            BarButtonItem3.Caption = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
            Label2.Refresh()
            dr1 = Nothing
        End If
    End Sub
    Private Sub analiz_siparis_bekleyen_tumu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_siparis_verilen_bekleyen
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            'frm.nFirmaID = dr("nFirmaID")
            'frm.sec_firma.Checked = True
            'frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            'frm.nFirmaID = dr("nFirmaID")
            'frm.sec_firma.Checked = True
            'frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_bekleyen_stok_durum(ByVal stoklar As String)
        Dim frm As New frm_satis_bekleyen_stok_durum
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokkodu = stokkodu
        frm.status = True
        frm.stoklar = stoklar
        frm.islemstatus = False
        'frm.tarih1 = "01/01/1900"
        'frm.tarih2 = "31/12/2048"
        'frm.qstokkodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_bekleyen(ByVal stoklar As String)
        Dim frm As New frm_satis_bekleyen_onaysiz
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.kasiyerno = kasiyerno
        'frm.kasiyer = kasiyer
        'frm.stokkodu = stokkodu
        frm.stoklar = stoklar
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        'frm.qstokkodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_karlilik()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_cari_alis_karlilik
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.fistipi = dr("sFisTipi")
        frm.tarih = dr("dteFisTarihi")
        frm.firmaID = dr("nFirmaID")
        frm.fisno = dr("lFisNo")
        frm.nGirisCikis = dr("nGirisCikis")
        frm.kullanici = kullanici
        If Decimal.Parse(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "KdvTutari").ToString()) = 0 Then
            frm.bKdvKontrolluMaliyet = "True"
        Else
            frm.bKdvKontrolluMaliyet = "False"
        End If
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub dataload_fis_detay(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (tbStokFisiDetayi.sFisTipi = '" & sFistipi & "') and (tbStokFisiDetayi.dteFisTarihi = '" & dteFisTarihi & "') and (tbStokFisiDetayi.lFisNo = '" & lFisno & "') and (tbStokFisiDetayi.nFirmaID= '" & nFirmaID & "') and (tbStokFisiDetayi.nGirisCikis = '" & nGirisCikis & "')  "
        ds_stok_fisi_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.nStokID, tbStok.sKodu FROM         tbStokFisiDetayi INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & ""))
    End Sub
    Private Function satir_kontrol_nStokID(Optional ByVal etiket As Boolean = False)
        Dim satir As String = " ("
        If etiket = True Then
            satir = "WHERE stok.nStokId IN ("
        End If
        Dim toplamsayi = ds_stok_fisi_detay.Tables(0).Rows.Count
        Dim sayi = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_stok_fisi_detay.Tables(0).Rows
            satir += dr1("nStokID").ToString
            sayi += 1
            If sayi < toplamsayi Then
                satir += ","
            ElseIf sayi = toplamsayi Then
                satir += ")"
            End If
        Next
        Return satir
    End Function
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        con = Nothing
    End Function
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_etikettalep
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.belgeind = dr("IND")
            frm.status = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'dr = DataSet1.Tables(0).Rows(0)
            'stok_islemleri.kart_sil(dr("IND"), False)
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    'stok_islemleri.kart_sil(dr1("IND"), False)
                    'If stok_islemleri.sil = True Then
                    '    'dr1.Delete()
                    '    'dr1.AcceptChanges()
                    'End If
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataload()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        analiz_alis()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
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
    Private Sub analiz_alis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_cari_alis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.connection_ors = connection_orj
            'frm.musterino = dr("sKodu")
            frm.fisno = dr("lFisNo")
            frm.tarih = dr("dteFisTarihi")
            frm.fistipi = dr("sFisTipi")
            frm.firmaID = dr("nFirmaID")
            frm.ngiriscikis = dr("nGirisCikis")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
            frm.kullanici = kullanici
            frm.bResmi = sec_resmi.Checked
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Public Function stok() As DataSet
        Dim kriter
        Dim kriter_firma As String = ""
        kriter = "WHERE (IND > 0 ) "
        'If stokkodu <> "" Then
        '    kriter += " AND (STOKKODU " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        'End If
        'If malincinsi <> "" Then
        '    kriter += " AND (MALINCINSI " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        'End If
        'If barkod <> "" Then
        '    kriter += " AND (BARKOD " & sorgu_kriter_string(barkod, qbarkod) & ")"
        'End If
        If kayitno <> "" Then
            kriter += " AND (IND " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        If ilktarih <> "" And sontarih <> "" Then
            kriter += " AND (TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        End If
        If ilkbelge <> "" And sonbelge = "" Then
            kriter += " AND (BELGENO LIKE '" & ilkbelge & " %')"
        ElseIf ilkbelge <> "" And sonbelge <> "" Then
            kriter += " AND (BELGENO BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
        End If
        If Trim(txt_satici.Text) <> "" Then
            kriter_firma = " AND (tbFirma.sKodu " & sorgu_kriter_string(Trim(txt_satici.Text), "Eþittir") & " )"
        End If
        'If firmaadi <> "" Then
        '    kriter += " AND (FIRMAADI " & sorgu_kriter_string(firmaadi, qfirmaadi) & " )"
        'End If
        If kod1 <> "" Then
            kriter += " AND (KOD1 " & sorgu_kriter_string(kod1, qkod1) & " )"
        End If
        If kod2 <> "" Then
            kriter += " AND (KOD2 " & sorgu_kriter_string(kod2, qkod2) & " )"
        End If
        If aciklama <> "" Then
            kriter += " AND (ACIKLAMA " & sorgu_kriter_string(aciklama, qaciklama) & " )"
        End If
        If depo <> "" Then
            kriter += " AND (DEPO " & sorgu_kriter_string(depo, qdepo) & " )"
        End If
        If sonuc <> "" Then
            kriter += " AND (SONUC " & sorgu_kriter_string(sonuc, qsonuc) & " )"
        End If
        'If personel <> "" Then
        '    kriter += " AND (PERSONEL  " & sorgu_kriter_string(depo, qdepo) & " )"
        'End If
        'If kapali <> "" Then
        '    If kapali = True Then
        '        kapali = "1"
        '    Else
        '        kapali = "2"
        '    End If
        '    kriter += " AND (Baslik.sGirisCikis " & sorgu_kriter_string(kapali, qkapali) & " )"
        'End If
        'If gelismis <> "" Then
        '    kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        'End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, CONVERT (char(1), tbStokFisiMaster.bFaturayaDonustumu) AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari3, nEvrakNo FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = '" & sec_fistipi.Text & "') AND (tbStokFisiMaster.nGirisCikis IN( 1,2,3,4)) AND (tbStokFisiMaster.dteFisTarihi BETWEEN '" & ilktarih & "' AND '" & sontarih & "') AND (tbStokFisiMaster.lFisNo BETWEEN 0 AND 999999999) AND (tbStokFisiMaster.lNetTutar BETWEEN - 999999999999.99 AND 999999999999.99) " & kriter_firma & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
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
    Private Sub analiz_envanter()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokno = dr("nStokId")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_envanter_model()
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
    End Sub
    Private Sub analiz_hareket()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = "" 'dr("sRenk")
            frm.sBeden = "" 'dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            'qr_hareket.CommandTimeout = Nothing
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT * FROM " & kriter & " ")
            frx.OldStyleProgress = True
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.DisableDialogs = True
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
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT * FROM " & kriter & " ") & ""
            args(3) = "qr_hareket"
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
            processYol = args(0)
            For i As Integer = 1 To 13
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
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
    Private Sub report_create_stok_olmayan(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("SELECT Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND, Hareket.nGirisCikis AS CIKIS FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & " ORDER BY Hareket.nGirisCikis, Hareket.sDepo,Hareket.nMusteriID, Hareket.lFisNo ")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PrepareReport(True)
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
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("SELECT Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND, Hareket.nGirisCikis AS CIKIS FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & " ORDER BY Hareket.nGirisCikis, Hareket.sDepo,Hareket.nMusteriID, Hareket.lFisNo ") & ""
            args(3) = "qr_hareket"
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
            processYol = args(0)
            For i As Integer = 1 To 13
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
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
            satir_firma_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        ara()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        analiz_alis()
        'duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            analiz_alis()
            'duzelt()
        ElseIf e.KeyCode = Keys.Escape Then
            'Me.Close()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'stok_duzelt()
        duzelt()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        stok_yeni()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_fiyat()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
        'Me.Hide()
        'PanelControl1.Dispose()
        'PanelControl2.Dispose()
        ''PanelControl3.Dispose()
        'SimpleButton1.Dispose()
        'SimpleButton2.Dispose()
        'SimpleButton3.Dispose()
        'ContextMenu1.Dispose()
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        ''PanelControl3 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton3 = Nothing
        'ContextMenu1 = Nothing
        'status = Nothing
        'connection = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'stokno = Nothing
        'userno = Nothing
        'stokkodu = Nothing
        'malincinsi = Nothing
        'barkod = Nothing
        'muadilbarkod = Nothing
        'birim = Nothing
        'kod1 = Nothing
        'kod2 = Nothing
        'kod3 = Nothing
        'kod4 = Nothing
        'kod5 = Nothing
        'kod6 = Nothing
        'kod7 = Nothing
        'kod8 = Nothing
        'kod9 = Nothing
        'kod10 = Nothing
        'satisfiyati1 = Nothing
        'satisfiyati2 = Nothing
        'satisfiyati3 = Nothing
        'istihbarat = Nothing
        'kayitno = Nothing
        'qkayitno = Nothing
        'qstokkodu = Nothing
        'qmalincinsi = Nothing
        'qbarkod = Nothing
        'qmuadilbarkod = Nothing
        'qkod1 = Nothing
        'qkod2 = Nothing
        'qkod3 = Nothing
        'qkod4 = Nothing
        'qkod5 = Nothing
        'qkod6 = Nothing
        'qkod7 = Nothing
        'qkod8 = Nothing
        'qkod9 = Nothing
        'qkod10 = Nothing
        'qistihbarat = Nothing
        'qbirim = Nothing
        'qdepo = Nothing
        'qsatisfiyati1 = Nothing
        'qsatisfiyati2 = Nothing
        'qsatisfiyati3 = Nothing
        ''XtraTabPage1.Dispose()
        ''XtraTabPage1 = Nothing
        ''stok_islemleri = Nothing
        ''stkdll = Nothing
        'dr = Nothing
        'count = Nothing
        'ps.ClearContent()
        'ps.Dispose()
        'ps = Nothing
        'printlink1.Dispose()
        'printlink1 = Nothing
        'System.GC.Collect()
        'System.GC.GetTotalMemory(True)
        'System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_kaydet()
    End Sub
    Private Sub frm_stok_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        stok_sil()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim file As String
        'OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        'OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    file = OpenFileDialog1.FileName.ToString
        '    report_create_stok(file, satir_kontrol, 0)
        'End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 0)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim file As String
        'OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        'OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    file = OpenFileDialog1.FileName.ToString
        '    report_create_stok(file, satir_kontrol, 2)
        'End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim file As String
        'OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        'OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    file = OpenFileDialog1.FileName.ToString
        '    report_create_stok(file, satir_kontrol, 1)
        'End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 1)
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String = ""
        Dim kriter As String = ""
        OpenFileDialog1.Title = "Rapor Seç..."
        If Trim(dr("sFisTipi")) = "FS" Then
            OpenFileDialog1.Filter = "Rapor Dosyalarý (Fatura_Satis*.fr3) |Fatura_Satis*.fr3"
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Fatura_Satis.fr3"
            OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
            kriter = " vwSatisFaturasi WHERE (Fis_TanimlamaNo = " & dr("nStokFisiID") & ") AND (Fis_Tarihi = '" & dr("dteFisTarihi") & "') AND (Fis_No = " & dr("lFisNo") & ")"
        ElseIf Trim(dr("sFisTipi")) = "FA" Then
            OpenFileDialog1.Filter = "Rapor Dosyalarý (Fatura_Alis*.fr3) |Fatura_Alis*.fr3"
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Fatura_Alis.fr3"
            OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
            kriter = " vwAlisFaturasi WHERE (Fis_TanimlamaNo = " & dr("nStokFisiID") & ") AND (Fis_Tarihi = '" & dr("dteFisTarihi") & "') AND (Fis_No = " & dr("lFisNo") & ")"
        End If
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
    End Sub
    Private Sub raporla_olmayan(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " WHERE Hareket.lFisNo > 0"
        If ilktarih <> "" And sontarih <> "" Then
            kriter += " AND (Hareket.dteFisTarihi BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        End If
        If rapor = 0 Then
            kriter += " AND HAREKET.HATA = 1 "
        ElseIf rapor = 1 Then
            kriter += " AND HAREKET.ACIKLAMA <> ''"
        ElseIf rapor = 2 Then
            kriter += " AND HAREKET.OKUT = 0 "
        ElseIf rapor = 3 Then
            kriter += " AND (Hareket.sFisTipi IN ('K')) "
            kriter += " AND (Hareket.nGirisCikis = 3)"
            kriter += " AND (Hareket.lFisNo NOT IN (SELECT FISNO FROM ASTOKPAKETBASLIK WHERE TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "' AND FIRMANO = Hareket.nMusteriID))"
        ElseIf rapor = 4 Then
            kriter += " AND (Hareket.sFisTipi IN ('P')) "
            kriter += " AND (Hareket.nGirisCikis = 3)"
            kriter += " AND (Hareket.lFisNo NOT IN (SELECT FISNO FROM ASTOKPAKETBASLIK WHERE TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "' AND FIRMANO = Hareket.nMusteriID))"
        ElseIf rapor = 5 Then
            kriter += " AND (Hareket.sFisTipi IN ('PF')) "
            kriter += " AND (Hareket.nGirisCikis = 3 )"
            kriter += " AND (Hareket.lFisNo NOT IN (SELECT FISNO FROM ASTOKPAKETBASLIK WHERE TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "' AND FIRMANO = Hareket.nMusteriID))"
        End If
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Paket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok_olmayan(file, kriter, islem)
        End If
    End Sub
    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        raporla(1, 0)
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        raporla(2, 0)
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        raporla_olmayan(3, 0)
    End Sub
    Private Sub MenuItem22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla_olmayan(4, 0)
    End Sub
    Private Sub MenuItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla_olmayan(5, 0)
    End Sub
    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        raporla(3, 0)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        raporla(4, 0)
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            dataload()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Try
            dataload()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub txt_satici_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_satici.KeyDown
        If e.KeyCode = Keys.F4 Then
            firma()
        ElseIf e.KeyCode = Keys.Space Then
            firma()
        End If
    End Sub
    Private Sub txt_satici_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_satici.ButtonClick
        firma()
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            dataload()
            sec_resmi1.Checked = False
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            dataload()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_siparis_bekleyen_tumu()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If GridView1.RowCount > 0 Then
            dataload_fis_detay(dr("sFisTipi"), dr("nGirisCikis"), dr("dteFisTarihi"), dr("lFisNo"), dr("nFirmaID"))
            analiz_bekleyen(satir_kontrol_nStokID)
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_karlilik()
    End Sub
    Private Sub sec_resmi1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi1.CheckStateChanged
        If sec_resmi1.Checked = True Then
            connection = connection_resmi1
            dataload()
            sec_resmi.Checked = False
        ElseIf sec_resmi1.Checked = False Then
            connection = connection_orj
            dataload()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        ekle("FA", 1)
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        ekle("FS", 3)
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        ekle("FA", 2)
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        ekle("FS", 4)
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        If MenuItem32.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem32.Checked = True
        ElseIf MenuItem32.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem32.Checked = False
        End If
    End Sub
End Class