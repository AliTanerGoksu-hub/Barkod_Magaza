Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_firma_liste_acik
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
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOzelIskontosu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKrediLimiti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colsSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sIl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sUlke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents coleMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsGsm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTelefon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsWeb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsYetkili As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSenetRisk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCekRisk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCariIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKarsilananTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOpsiyon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGecikme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collVadeFarki As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_islem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_bakiye As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_limit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_limit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nVadeFarki As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nGun2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nGun1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents sec_satici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_nGrupla As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_bTumHesaplar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents coldteOrtVade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sdepo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_firma_liste_acik))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_sdepo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_nGrupla = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_nVadeFarki = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nGun2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nGun1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_limit2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_limit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sSatici = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_islem = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_bakiye = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_bTumHesaplar = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
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
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnOzelIskontosu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKrediLimiti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSemt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sIl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sUlke = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coleMail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsGsm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTelefon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsWeb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYetkili = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSenetRisk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCekRisk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCariIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKarsilananTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnOpsiyon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGecikme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collVadeFarki = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_satici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.coldteOrtVade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGecikmeOrtalama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sdepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nGrupla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nVadeFarki.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nGun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nGun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_limit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_limit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSatici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_islem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bakiye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bTumHesaplar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 152)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_sdepo)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.sec_nGrupla)
        Me.GroupControl1.Controls.Add(Me.txt_nVadeFarki)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txt_nGun2)
        Me.GroupControl1.Controls.Add(Me.txt_nGun1)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txt_limit2)
        Me.GroupControl1.Controls.Add(Me.txt_limit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.sec_sSatici)
        Me.GroupControl1.Controls.Add(Me.sec_islem)
        Me.GroupControl1.Controls.Add(Me.sec_bakiye)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.sec_bTumHesaplar)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(407, 148)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_sdepo
        '
        Me.sec_sdepo.EditValue = "[Tümü]"
        Me.sec_sdepo.EnterMoveNextControl = True
        Me.sec_sdepo.Location = New System.Drawing.Point(56, 129)
        Me.sec_sdepo.Name = "sec_sdepo"
        Me.sec_sdepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sdepo.Properties.PopupControl = Me.sec_grid
        Me.sec_sdepo.Properties.ShowPopupCloseButton = False
        Me.sec_sdepo.Size = New System.Drawing.Size(70, 20)
        Me.sec_sdepo.TabIndex = 63
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(194, 75)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(256, 128)
        Me.sec_grid.TabIndex = 3
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(256, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.GridColumn1})
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Açýklama"
        Me.GridColumn1.FieldName = "ACIKLAMA"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 128
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(14, 130)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(34, 20)
        Me.LabelControl12.TabIndex = 64
        Me.LabelControl12.Text = "Depo:"
        '
        'sec_nGrupla
        '
        Me.sec_nGrupla.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sec_nGrupla.EnterMoveNextControl = True
        Me.sec_nGrupla.Location = New System.Drawing.Point(251, 109)
        Me.sec_nGrupla.Name = "sec_nGrupla"
        Me.sec_nGrupla.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_nGrupla.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_nGrupla.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_nGrupla.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_nGrupla.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_nGrupla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_nGrupla.Size = New System.Drawing.Size(43, 20)
        Me.sec_nGrupla.TabIndex = 61
        '
        'txt_nVadeFarki
        '
        Me.txt_nVadeFarki.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nVadeFarki.EnterMoveNextControl = True
        Me.txt_nVadeFarki.Location = New System.Drawing.Point(192, 109)
        Me.txt_nVadeFarki.Name = "txt_nVadeFarki"
        Me.txt_nVadeFarki.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nVadeFarki.Size = New System.Drawing.Size(38, 20)
        Me.txt_nVadeFarki.TabIndex = 12
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(158, 114)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl10.TabIndex = 29
        Me.LabelControl10.Text = "VFarki:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(102, 114)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl8.TabIndex = 27
        Me.LabelControl8.Text = "ve"
        '
        'txt_nGun2
        '
        Me.txt_nGun2.EditValue = "9999"
        Me.txt_nGun2.EnterMoveNextControl = True
        Me.txt_nGun2.Location = New System.Drawing.Point(120, 109)
        Me.txt_nGun2.Name = "txt_nGun2"
        Me.txt_nGun2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nGun2.Properties.Appearance.Options.UseFont = True
        Me.txt_nGun2.Properties.MaxLength = 15
        Me.txt_nGun2.Size = New System.Drawing.Size(36, 20)
        Me.txt_nGun2.TabIndex = 11
        '
        'txt_nGun1
        '
        Me.txt_nGun1.EditValue = "-9999"
        Me.txt_nGun1.EnterMoveNextControl = True
        Me.txt_nGun1.Location = New System.Drawing.Point(56, 109)
        Me.txt_nGun1.Name = "txt_nGun1"
        Me.txt_nGun1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nGun1.Properties.Appearance.Options.UseFont = True
        Me.txt_nGun1.Properties.MaxLength = 15
        Me.txt_nGun1.Size = New System.Drawing.Size(40, 20)
        Me.txt_nGun1.TabIndex = 10
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(26, 109)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl9.TabIndex = 26
        Me.LabelControl9.Text = "Gun:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(163, 91)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "ve"
        '
        'txt_limit2
        '
        Me.txt_limit2.EditValue = "9999999999999"
        Me.txt_limit2.EnterMoveNextControl = True
        Me.txt_limit2.Location = New System.Drawing.Point(192, 87)
        Me.txt_limit2.Name = "txt_limit2"
        Me.txt_limit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_limit2.Properties.Appearance.Options.UseFont = True
        Me.txt_limit2.Properties.MaxLength = 15
        Me.txt_limit2.Size = New System.Drawing.Size(101, 20)
        Me.txt_limit2.TabIndex = 9
        '
        'txt_limit1
        '
        Me.txt_limit1.EditValue = "-9999999999999"
        Me.txt_limit1.EnterMoveNextControl = True
        Me.txt_limit1.Location = New System.Drawing.Point(56, 87)
        Me.txt_limit1.Name = "txt_limit1"
        Me.txt_limit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_limit1.Properties.Appearance.Options.UseFont = True
        Me.txt_limit1.Properties.MaxLength = 15
        Me.txt_limit1.Size = New System.Drawing.Size(100, 20)
        Me.txt_limit1.TabIndex = 8
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(24, 87)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "Limit:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(14, 65)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Bakiye:"
        '
        'sec_sSatici
        '
        Me.sec_sSatici.EditValue = "[Tümü]"
        Me.sec_sSatici.EnterMoveNextControl = True
        Me.sec_sSatici.Location = New System.Drawing.Point(192, 65)
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.Properties.ShowPopupCloseButton = False
        Me.sec_sSatici.Size = New System.Drawing.Size(100, 20)
        Me.sec_sSatici.TabIndex = 7
        '
        'sec_islem
        '
        Me.sec_islem.EditValue = "Detaylý"
        Me.sec_islem.EnterMoveNextControl = True
        Me.sec_islem.Location = New System.Drawing.Point(131, 65)
        Me.sec_islem.Name = "sec_islem"
        Me.sec_islem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_islem.Properties.Items.AddRange(New Object() {"Özet", "Detaylý"})
        Me.sec_islem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_islem.Size = New System.Drawing.Size(62, 20)
        Me.sec_islem.TabIndex = 6
        '
        'sec_bakiye
        '
        Me.sec_bakiye.EditValue = "Alacaklar"
        Me.sec_bakiye.EnterMoveNextControl = True
        Me.sec_bakiye.Location = New System.Drawing.Point(56, 65)
        Me.sec_bakiye.Name = "sec_bakiye"
        Me.sec_bakiye.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_bakiye.Properties.Items.AddRange(New Object() {"Borclar", "Alacaklar"})
        Me.sec_bakiye.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_bakiye.Size = New System.Drawing.Size(75, 20)
        Me.sec_bakiye.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(19, 43)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Hesap:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(296, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Arasýndaki"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(163, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "ve"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(21, 24)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 6, 16, 19, 41, 57, 199)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(192, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2007, 6, 16, 19, 41, 51, 511)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(56, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(192, 43)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adý", "Adres", "Ýstihbarat", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 3
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(296, 87)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 44)
        Me.SimpleButton3.TabIndex = 13
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(292, 43)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 4
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(56, 43)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(136, 20)
        Me.txt_ara.TabIndex = 2
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.Location = New System.Drawing.Point(224, 109)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(30, 20)
        Me.LabelControl17.TabIndex = 60
        Me.LabelControl17.Text = "Grup:"
        '
        'sec_bTumHesaplar
        '
        Me.sec_bTumHesaplar.Location = New System.Drawing.Point(294, 65)
        Me.sec_bTumHesaplar.MenuManager = Me.BarManager1
        Me.sec_bTumHesaplar.Name = "sec_bTumHesaplar"
        Me.sec_bTumHesaplar.Properties.Caption = "Tüm Hesaplar"
        Me.sec_bTumHesaplar.Size = New System.Drawing.Size(108, 19)
        Me.sec_bTumHesaplar.TabIndex = 62
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True)})
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
        Me.BarButtonItem2.Caption = "Firma Kartý,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Firma Hareketleri,F7"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Hesap Kapatma Servisi,F8"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Ýletiþim ,F6"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Excel"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Text"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Mail"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(503, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(319, 13)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 379)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
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
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 152)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 227)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_satici})
        Me.GridControl1.Size = New System.Drawing.Size(820, 223)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem19, Me.MenuItem16, Me.MenuItem18, Me.MenuItem22, Me.MenuItem23, Me.MenuItem21, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem17, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Hareketler"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem22.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 7
        Me.MenuItem23.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 8
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem21.Text = "Hesap Kapatma Servisi"
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
        'MenuItem17
        '
        Me.MenuItem17.Index = 15
        Me.MenuItem17.Text = "Hýzlý Filtre"
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
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
        Me.DataColumn4.ColumnName = "nOzelIskontosu"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lKrediLimiti"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Adres"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ISTIHBARAT"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "SINIF1"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "SINIF2"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "SINIF3"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "SINIF4"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "SINIF5"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnFirmaID, Me.colsKodu, Me.colsAciklama, Me.colnOzelIskontosu, Me.collKrediLimiti, Me.colAdres, Me.colISTIHBARAT, Me.colSINIF1, Me.colSINIF2, Me.colSINIF3, Me.colSINIF4, Me.colSINIF5, Me.colsVergiDairesi, Me.colsVergiNo, Me.colsSemt, Me.sIl, Me.sUlke, Me.coleMail, Me.colsFax, Me.colsGsm, Me.colsTelefon, Me.colsWeb, Me.colsYetkili, Me.collBakiye, Me.colSenetRisk, Me.colCekRisk, Me.coldteIslemTarihi, Me.coldteValorTarihi, Me.colsCariIslem, Me.colAciklama, Me.colsEvrakNo, Me.collTutar, Me.collKarsilananTutar, Me.collKalan, Me.colnOpsiyon, Me.colnGecikme, Me.collVadeFarki, Me.colsSaticiRumuzu, Me.coldteOrtVade, Me.colnGecikmeOrtalama})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Aciklama", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Aciklama", Me.colAciklama, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", Me.collTutar, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKarsilananTutar", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKarsilananTutar", Me.collKarsilananTutar, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", Nothing, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", Me.collKalan, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "dteOrtVade", Me.coldteValorTarihi, "{0:dd/MM/yyyy}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colsKodu, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Kayýt No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        Me.colnFirmaID.Width = 77
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Firma Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 79
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Firma Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 208
        '
        'colnOzelIskontosu
        '
        Me.colnOzelIskontosu.Caption = "Ýskonto"
        Me.colnOzelIskontosu.FieldName = "nOzelIskontosu"
        Me.colnOzelIskontosu.Name = "colnOzelIskontosu"
        Me.colnOzelIskontosu.Visible = True
        Me.colnOzelIskontosu.VisibleIndex = 2
        Me.colnOzelIskontosu.Width = 67
        '
        'collKrediLimiti
        '
        Me.collKrediLimiti.Caption = "Kredi Limiti"
        Me.collKrediLimiti.FieldName = "lKrediLimiti"
        Me.collKrediLimiti.Name = "collKrediLimiti"
        Me.collKrediLimiti.Visible = True
        Me.collKrediLimiti.VisibleIndex = 3
        Me.collKrediLimiti.Width = 60
        '
        'colAdres
        '
        Me.colAdres.Caption = "Adres"
        Me.colAdres.FieldName = "Adres"
        Me.colAdres.Name = "colAdres"
        Me.colAdres.Width = 163
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "Ýstihbarat"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        '
        'colSINIF1
        '
        Me.colSINIF1.Caption = "Sýnýf 1"
        Me.colSINIF1.FieldName = "SINIF1"
        Me.colSINIF1.Name = "colSINIF1"
        '
        'colSINIF2
        '
        Me.colSINIF2.Caption = "Sýnýf 2"
        Me.colSINIF2.FieldName = "SINIF2"
        Me.colSINIF2.Name = "colSINIF2"
        '
        'colSINIF3
        '
        Me.colSINIF3.Caption = "Sýnýf 3"
        Me.colSINIF3.FieldName = "SINIF3"
        Me.colSINIF3.Name = "colSINIF3"
        '
        'colSINIF4
        '
        Me.colSINIF4.Caption = "Sýnýf 4"
        Me.colSINIF4.FieldName = "SINIF4"
        Me.colSINIF4.Name = "colSINIF4"
        '
        'colSINIF5
        '
        Me.colSINIF5.Caption = "Sýnýf 5"
        Me.colSINIF5.FieldName = "SINIF5"
        Me.colSINIF5.Name = "colSINIF5"
        '
        'colsVergiDairesi
        '
        Me.colsVergiDairesi.Caption = "Vergi Dairesi"
        Me.colsVergiDairesi.FieldName = "sVergiDairesi"
        Me.colsVergiDairesi.Name = "colsVergiDairesi"
        Me.colsVergiDairesi.Width = 108
        '
        'colsVergiNo
        '
        Me.colsVergiNo.Caption = "Vergi No"
        Me.colsVergiNo.FieldName = "sVergiNo"
        Me.colsVergiNo.Name = "colsVergiNo"
        Me.colsVergiNo.Width = 87
        '
        'colsSemt
        '
        Me.colsSemt.Caption = "Semt"
        Me.colsSemt.FieldName = "sSemt"
        Me.colsSemt.Name = "colsSemt"
        '
        'sIl
        '
        Me.sIl.Caption = "il"
        Me.sIl.FieldName = "sIl"
        Me.sIl.Name = "sIl"
        '
        'sUlke
        '
        Me.sUlke.Caption = "Ulke"
        Me.sUlke.FieldName = "sUlke"
        Me.sUlke.Name = "sUlke"
        '
        'coleMail
        '
        Me.coleMail.Caption = "E-Mail"
        Me.coleMail.FieldName = "E-Mail"
        Me.coleMail.Name = "coleMail"
        '
        'colsFax
        '
        Me.colsFax.Caption = "Faks"
        Me.colsFax.FieldName = "Fax"
        Me.colsFax.Name = "colsFax"
        '
        'colsGsm
        '
        Me.colsGsm.Caption = "Gsm"
        Me.colsGsm.FieldName = "Gsm"
        Me.colsGsm.Name = "colsGsm"
        '
        'colsTelefon
        '
        Me.colsTelefon.Caption = "Telefon"
        Me.colsTelefon.FieldName = "Telefon"
        Me.colsTelefon.Name = "colsTelefon"
        '
        'colsWeb
        '
        Me.colsWeb.Caption = "Web"
        Me.colsWeb.FieldName = "Web"
        Me.colsWeb.Name = "colsWeb"
        '
        'colsYetkili
        '
        Me.colsYetkili.Caption = "Yetkili"
        Me.colsYetkili.FieldName = "Yetkili"
        Me.colsYetkili.Name = "colsYetkili"
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBakiye", "{0:#,0.00(B);#,0.00(A);#,0.00(-)}")})
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 4
        Me.collBakiye.Width = 66
        '
        'colSenetRisk
        '
        Me.colSenetRisk.Caption = "Senet Risk"
        Me.colSenetRisk.DisplayFormat.FormatString = "#,0.00"
        Me.colSenetRisk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSenetRisk.FieldName = "SenetRisk"
        Me.colSenetRisk.Name = "colSenetRisk"
        Me.colSenetRisk.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SenetRisk", "{0:#,0.00}")})
        '
        'colCekRisk
        '
        Me.colCekRisk.Caption = "Çek Riski"
        Me.colCekRisk.DisplayFormat.FormatString = "#,0.00"
        Me.colCekRisk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCekRisk.FieldName = "CekRisk"
        Me.colCekRisk.Name = "colCekRisk"
        Me.colCekRisk.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CekRisk", "{0:#,0.00}")})
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "Ýþlem Tarihi"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Visible = True
        Me.coldteIslemTarihi.VisibleIndex = 5
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Visible = True
        Me.coldteValorTarihi.VisibleIndex = 6
        '
        'colsCariIslem
        '
        Me.colsCariIslem.Caption = "Ýþlem"
        Me.colsCariIslem.FieldName = "sCariIslem"
        Me.colsCariIslem.Name = "colsCariIslem"
        Me.colsCariIslem.Visible = True
        Me.colsCariIslem.VisibleIndex = 8
        '
        'colAciklama
        '
        Me.colAciklama.Caption = "Açýklama"
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        Me.colAciklama.Visible = True
        Me.colAciklama.VisibleIndex = 9
        '
        'colsEvrakNo
        '
        Me.colsEvrakNo.Caption = "Evrak No"
        Me.colsEvrakNo.FieldName = "EvrakNo"
        Me.colsEvrakNo.Name = "colsEvrakNo"
        Me.colsEvrakNo.Visible = True
        Me.colsEvrakNo.VisibleIndex = 10
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00##}")})
        Me.collTutar.Visible = True
        Me.collTutar.VisibleIndex = 11
        '
        'collKarsilananTutar
        '
        Me.collKarsilananTutar.Caption = "Kapanan"
        Me.collKarsilananTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collKarsilananTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKarsilananTutar.FieldName = "lKarsilananTutar"
        Me.collKarsilananTutar.Name = "collKarsilananTutar"
        Me.collKarsilananTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKarsilananTutar", "{0:#,0.00##}")})
        Me.collKarsilananTutar.Visible = True
        Me.collKarsilananTutar.VisibleIndex = 12
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
        Me.collKalan.VisibleIndex = 13
        '
        'colnOpsiyon
        '
        Me.colnOpsiyon.Caption = "Opsiyon"
        Me.colnOpsiyon.FieldName = "nOpsiyon"
        Me.colnOpsiyon.Name = "colnOpsiyon"
        Me.colnOpsiyon.Visible = True
        Me.colnOpsiyon.VisibleIndex = 7
        '
        'colnGecikme
        '
        Me.colnGecikme.Caption = "Gecikme"
        Me.colnGecikme.FieldName = "nGecikme"
        Me.colnGecikme.Name = "colnGecikme"
        Me.colnGecikme.Visible = True
        Me.colnGecikme.VisibleIndex = 14
        '
        'collVadeFarki
        '
        Me.collVadeFarki.Caption = "VadeFarki"
        Me.collVadeFarki.DisplayFormat.FormatString = "#,0.00"
        Me.collVadeFarki.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collVadeFarki.FieldName = "lVadeFarki"
        Me.collVadeFarki.Name = "collVadeFarki"
        Me.collVadeFarki.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lVadeFarki", "{0:#,0.00##}")})
        Me.collVadeFarki.Visible = True
        Me.collVadeFarki.VisibleIndex = 15
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satici"
        Me.colsSaticiRumuzu.ColumnEdit = Me.sec_satici
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        '
        'sec_satici
        '
        Me.sec_satici.AutoHeight = False
        Me.sec_satici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satici.DisplayMember = "SATICI"
        Me.sec_satici.Name = "sec_satici"
        Me.sec_satici.ValueMember = "sSaticiRumuzu"
        '
        'coldteOrtVade
        '
        Me.coldteOrtVade.Caption = "OrtVade"
        Me.coldteOrtVade.FieldName = "dteOrtVade"
        Me.coldteOrtVade.Name = "coldteOrtVade"
        '
        'colnGecikmeOrtalama
        '
        Me.colnGecikmeOrtalama.Caption = "Gecikme Ortalama"
        Me.colnGecikmeOrtalama.FieldName = "nGecikmeOrtalama"
        Me.colnGecikmeOrtalama.Name = "colnGecikmeOrtalama"
        Me.colnGecikmeOrtalama.Visible = True
        Me.colnGecikmeOrtalama.VisibleIndex = 16
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Firmalar Karlýlýk Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Firma Hesaplarý Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_firma_liste_acik
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
        Me.Name = "frm_firma_liste_acik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acik Hesaplar"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_sdepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nGrupla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nVadeFarki.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nGun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nGun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_limit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_limit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSatici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_islem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bakiye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bTumHesaplar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public sModul As String = "Cari"
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_satici As New DataSet
    Dim ds_tbDepo As DataSet
    Public sFiyatTipi As String = ""
    Public sDepo As String = ""
    Public islemstatus As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        'DateEdit1.EditValue = dteSistemTarihi
        'DateEdit2.EditValue = dteSistemTarihi
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
        dataload_satici()
        dataload_tbdepo()
        If txt_ara.Text <> "" Then
            ara()
        Else
            txt_ara.EditValue = ""
        End If
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Acik Borc/Alacaklar" & vbCrLf
        kriter += "Bakiye : " & sec_bakiye.Text & " Listeleme : " & sec_islem.Text & " Satici: " & sec_sSatici.Text
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Financial Managment-Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub dataload_tbdepo()
        If Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo Where sDepo IN ('D012','D013')"))
            'sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        Else
            'ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
            ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo  ORDER BY sDepo"))
            'sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        End If
        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            sec_sdepo.EditValue = "'" & sDepo & "'"
            If kullanici > 3 Then
                sec_sdepo.Properties.ReadOnly = False
            Else
                sec_sdepo.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                sec_sdepo.EditValue = "'" & sDepo & "'"
                sec_sdepo.Properties.ReadOnly = True
            Else
                'sec_sDepo.EditValue = sDepo
                sec_sdepo.Properties.ReadOnly = False
            End If
            'sec_sDepo.EditValue = sDepo
            'sec_sDepo.Properties.ReadOnly = False
        End If
        'sec_sDepo.ItemIndex = 1
    End Sub
    Private Sub dataload_satici()
        sec_satici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici where (bAktif = 1)")).Tables(0)
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici Where (bAktif = 1)"))
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing

        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            'sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
            If Trim(sSaticiRumuzu) = "" Then
                sec_sSatici.EditValue = "[Tümü]"
            Else
                sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
            End If
            If kullanici > 3 Then
                sec_sSatici.Properties.ReadOnly = False
            Else
                sec_sSatici.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                'sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
                If Trim(sSaticiRumuzu) = "" Then
                    sec_sSatici.EditValue = "[Tümü]"
                Else
                    sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
                End If
                sec_sSatici.Properties.ReadOnly = True
            Else
                'sec_sDepo.EditValue = sDepo
                sec_sSatici.Properties.ReadOnly = False
            End If
            'sec_sDepo.EditValue = sDepo
            'sec_sDepo.Properties.ReadOnly = False
        End If
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
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
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sIslem As String, ByVal sBakiye As String, ByVal sSaticiRumuzu As String, ByVal lLimit1 As Decimal, ByVal lLimit2 As Decimal, ByVal nGun1 As Integer, ByVal nGun2 As Integer, ByVal nVadeFarki As Decimal, ByVal nGrupla As Int64, ByVal bTumHesaplar As Boolean, ByVal sDepo As String) As DataSet
        Dim kriter As String = ""
        Dim kriter_tumu As String = ""
        If ara <> "" Then
            If sec_konum.Text = "Kodu" And ara.Contains("x") = False Then
                kriter += " AND ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adres" Then
                kriter += " AND ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
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
        If Trim(sDepo) <> "[Tümü]" Then
            kriter += " And tbFirma.sDepo IN  ( ''," & sDepo & " )"
        End If
        If Trim(sSaticiRumuzu) <> "[Tümü]" Then
            kriter += " AND (tbFirma.sSaticiRumuzu IN (''," & sSaticiRumuzu & " ))"
        End If
        If sModul = "Cari" Then
            kriter += " and tbFirma.sKodu not like '102%' "
            If sCariSinirla <> "" Then
                kriter += " and tbFirma.sKodu like '" & sCariSinirla & "%' "
            End If
            If sCariSinifKoduSinirla <> "" Then
                kriter += " and tbFirma.nFirmaID IN (SELECT     nFirmaID FROM         tbFirmaSinifi WHERE     (sSinifKodu1 IN (" & sCariSinifKoduSinirla & ")))"
            End If
        ElseIf sModul = "Banka" Then
            kriter += " and tbFirma.sKodu like '102%' "
            If sBankaSinirla <> "" Then
                kriter += " and tbFirma.sKodu like '" & sBankaSinirla & "%' "
            End If
        End If
        kriter += " and (tbFirma.bAktif =1) "
        kriter += " AND ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) BETWEEN " & nGun1 & " and " & nGun2 & " "
        If ara.Contains("x") = True Then
            Dim sAra As String = Trim(ara)
            Dim nSayi As Integer = Trim(ara).Length
            Dim sDeger As String = ""
            Dim i As Integer = 0
            Dim t As Integer = 0
            For i = 1 To nSayi
                t += 1
                If sAra.Substring(t - 1, 1) = "x" Then
                Else
                    sDeger = sAra.Substring(t - 1, 1)
                    kriter += " and substring(tbFirma.sKodu, " & t & ", " & 1 & ") = '" & sDeger & "' "
                End If
            Next
        End If
        If bTumHesaplar = True Then
            kriter_tumu = ""
        Else
            kriter_tumu = "(lTutar <> lKarsilananTutar) and"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If sBakiye = "Borclar" Then
            If sIslem = "Özet" Then
                If nGrupla > 0 Then
                    'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteValorTarihi = CASE WHEN SUM(lKalan) = 0 THEN '" & Today & "' ELSE CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) END, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,nGecikme = CASE WHEN SUM(lKalan) = 0 THEN 0 ELSE DATEDIFF(day,  CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME),GETDATE()) END,sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE " & kriter_tumu & " lBakiye between " & lLimit1 & " and " & lLimit2 & " ) tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteValorTarihi = CASE WHEN SUM(lKalan) = 0 THEN '" & Today & "' ELSE CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) END, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,nGecikme = ROUND(AVG(ROUND(CAST(GETDATE() - (CAST(dteValorTarihi AS INT) + 1) AS FLOAT) , 0)), 0), sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nOdemeId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE " & kriter_tumu & " lBakiye between " & lLimit1 & " and " & lLimit2 & " ) tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
                Else
                    'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteValorTarihi = CASE WHEN SUM(lKalan) = 0 THEN '" & Today & "' ELSE CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) END, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,nGecikme = CASE WHEN SUM(lKalan) = 0 THEN 0 ELSE DATEDIFF(day,  CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME),GETDATE()) END,sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE " & kriter_tumu & " lBakiye between " & lLimit1 & " and " & lLimit2 & " ) tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  dteValorTarihi = CASE WHEN SUM(lKalan) = 0 THEN '" & Today & "' ELSE CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) END, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,nGecikme = ROUND(AVG(ROUND(CAST(GETDATE() - (CAST(dteValorTarihi AS INT) + 1) AS FLOAT), 0)), 0), sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nOdemeId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE " & kriter_tumu & " lBakiye between " & lLimit1 & " and " & lLimit2 & " ) tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
                End If
            ElseIf sIslem = "Detaylý" Then
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKarsilananTutar AS lKalan,(lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, dteValorTarihi as dteOrtVade,lTutar - lKarsilananTutar AS lKalan,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade,(lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nOdemeId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme, (Select ROUND(AVG(ROUND(CAST(GETDATE() - (CAST(dteValorTarihi AS INT) + 1) AS FLOAT), 0)), 0) from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID AND (lAlacakTutar <> 0) and (dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "')) AS nGecikmeOrtalama FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
            End If
        ElseIf sBakiye = "Alacaklar" Then
            If sIslem = "Özet" Then
                If nGrupla = 0 Then
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteValorTarihi = CASE WHEN SUM(lKalan) = 0 THEN '" & Today & "' ELSE CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) END, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,nGecikme = ROUND(AVG(ROUND(CAST(GETDATE() - (CAST(dteValorTarihi AS INT) + 1) AS FLOAT), 0)), 0), sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE " & kriter_tumu & " lBakiye between " & lLimit1 & " and " & lLimit2 & ") tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
                Else
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteValorTarihi = CASE WHEN SUM(lKalan) = 0 THEN '" & Today & "' ELSE CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) END, sFirmaKodu sKodu, sFirmaAciklama sAciklama, nFirmaOzelIskontosu nOzelIskontosu, lFirmaKrediLimiti lKrediLimiti, sFirmaSemt sSemt, sFirmaIl sIl, sFirmaSaticiRumuzu sSaticiRumuzu, sFirmaUlke sUlke, sFirmaAdres Adres, sFirmaVergiDairesi sVergiDairesi, sFirmaVergiNo sVergiNo,  sum(lBakiye) as lBakiye, sum(SenetRisk) SenetRisk, sum(CekRisk) CekRisk, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,nGecikme = ROUND(AVG(ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0)), 0), sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma_1.sKodu as sFirmaKodu, tbFirma_1.sAciklama as sFirmaAciklama, tbFirma_1.nOzelIskontosu as nFirmaOzelIskontosu, tbFirma_1.lKrediLimiti as lFirmaKrediLimiti, tbFirma_1.sSemt as sFirmaSemt, tbFirma_1.sIl as sFirmaIl, tbFirma_1.sSaticiRumuzu as sFirmaSaticiRumuzu, tbFirma_1.sUlke as sFirmaUlke, tbFirma_1.sAdres1 + ' ' + tbFirma_1.sAdres2 + ' ' + tbFirma_1.sSemt + ' ' + tbFirma_1.sIl + ' ' + tbFirma_1.sUlke + ' ' + tbFirma_1.sPostaKodu AS sFirmaAdres , tbFirma_1.sVergiDairesi as sFirmaVergiDairesi , tbFirma_1.sVergiNo as sFirmaVergiNo,tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID LEFT OUTER JOIN tbFirma tbFirma_1 ON LEFT(tbFirma.sKodu, " & nGrupla & ") = tbFirma_1.sKodu WHERE (tbFirmaHareketi.lBorcTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE " & kriter_tumu & " lBakiye between " & lLimit1 & " and " & lLimit2 & ") tbTempVade GROUP BY sFirmaKodu, sFirmaAciklama, nFirmaOzelIskontosu, lFirmaKrediLimiti, sFirmaSemt, sFirmaIl, sFirmaSaticiRumuzu, sFirmaUlke, sFirmaAdres, sFirmaVergiDairesi, sFirmaVergiNo  ")
                End If
            ElseIf sIslem = "Detaylý" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, dteValorTarihi as dteOrtVade,lTutar - lKarsilananTutar AS lKalan,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade,(lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme, (Select ROUND(AVG(ROUND(CAST(GETDATE() - (CAST(dteValorTarihi AS INT) + 1) AS FLOAT), 0)), 0) from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID AND (lBorcTutar <> 0) and (dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "')) AS nGecikmeOrtalama FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
            End If
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        If sIslem = "Özet" Then
            If nGrupla > 0 Then
                Dim dr As DataRow
                For Each dr In Datastoklar1.Tables(0).Rows
                    If Trim(dr("sKodu").ToString) <> "" Then
                        dr("lBakiye") = sorgu_lBakiye(dteSistemTarihi, Trim(dr("sKodu").ToString))
                    End If
                Next
                dr = Nothing
            End If
        End If
        Return Datastoklar1
    End Function
    Private Sub OrtVadeBul()
        If sec_islem.Text = "Detaylý" Then
            coldteOrtVade.FieldName = "dteOrtVade"
            Dim dr As DataRow
            Dim dteFisTarihi As DateTime = "02/01/1900"
            Dim sKodu As String = ""
            Dim lKalan As Decimal = 0
            Dim lTutarVade As Decimal = 0
            Dim nOrtVade As Double = 0
            For Each dr In DataSet1.Tables(0).Rows
                If sKodu <> dr("sKodu") Then
                    Try
                        nOrtVade = lTutarVade / lKalan
                    Catch ex As Exception
                        nOrtVade = 0
                    End Try
                    'ortVadeDegistir(sKodu, sorgula_String("Select Cast(" & nOrtVade & " AS DATETIME)"))
                    ortVadeDegistir(sKodu, DateAdd(DateInterval.Day, nOrtVade, dteFisTarihi))
                    lTutarVade = 0
                    lKalan = 0
                    sKodu = dr("sKodu")
                End If
                lKalan = lKalan + dr("lKalan")
                lTutarVade = lTutarVade + dr("lTutarVade")
            Next
            ortVadeDegistir(sKodu, DateAdd(DateInterval.Day, nOrtVade, dteFisTarihi))
        Else
            coldteOrtVade.FieldName = "dteValorTarihi"
        End If
    End Sub
    Private Sub ortVadeDegistir(ByVal sKodu As String, ByVal dteOrtVade As DateTime)
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            If dr("sKodu") = sKodu Then
                dr("dteOrtVade") = dteOrtVade
            End If
        Next
    End Sub
    Public Function sorgu_lBakiye(ByVal dteIslemTarihi As DateTime, ByVal sKodu As String) As Decimal
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lBakiye As Decimal
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT ISNULL(SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi & "') AND tbFirma.sKodu LIKE '" & sKodu & "%'  ")
        lBakiye = cmd.ExecuteScalar
        con.Close()
        Return lBakiye
        'kayitsayisi = Nothing
        lBakiye = Nothing
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sIslem As String, ByVal sBakiye As String, ByVal sSaticiRumuzu As String, ByVal lLimit1 As Decimal, ByVal lLimit2 As Decimal, ByVal nGun1 As Int64, ByVal nGun2 As Int64, ByVal nVadeFarki As Decimal, ByVal nGrupla As Integer, ByVal bTumHesaplar As Boolean, ByVal sDepo As String)
        DataSet1 = stok(ara, konum, ara_kriter, tarih1, tarih2, sIslem, sBakiye, sSaticiRumuzu, lLimit1, lLimit2, nGun1, nGun2, nVadeFarki, nGrupla, bTumHesaplar, sDepo)
        OrtVadeBul()
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
            frm.sKodu = dr("sKodu")
            frm.nFirmaID = dr("nFirmaID")
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
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
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
    Private Sub analiz_firma_KarlilikAkisTablosu(Optional ByVal islem As Integer = 2)
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
            frm.kriter_musteriID = "AND tbStokFisiDetayi.nFirmaID = " & dr("nFirmaID") & " "
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
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
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
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("ISTIHBARAT").ToString
                dr = Nothing
            End If
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
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
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
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, DateEdit1.EditValue, DateEdit2.EditValue, sec_islem.Text, sec_bakiye.Text, sec_sSatici.Text, txt_limit1.EditValue, txt_limit2.EditValue, txt_nGun1.EditValue, txt_nGun2.EditValue, txt_nVadeFarki.EditValue, sec_nGrupla.EditValue, sec_bTumHesaplar.Checked, sec_sDepo.text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If MenuItem17.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem17.Checked = True
        ElseIf MenuItem17.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem17.Checked = False
        End If
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_cari_hareket()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSatici.QueryPopUp
        sec_sSatici.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_sSatici.QueryResultValue
        Dim s As String = deger(ds_satici)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        satir_HesapKapat()
    End Sub
    Private Sub satir_HesapKapat()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlara Hesap Kapatma Servisi Çalýþtýrmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim nFirmaID As Integer = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If nFirmaID <> dr("nFirmaID") Then
                        nFirmaID = dr("nFirmaID")
                        tbFirmaKapama_Toplu(dr("sKodu"))
                    Else
                    End If
                Next
            End If
            ara()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub tbFirmaKapama_Toplu(ByVal sKodu As String)
        Dim frm As New frm_tbFirmaKapama_Toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.sec_kriter.Text = "Baþlar"
        frm.sec_bGuncelle.Checked = True
        frm.GroupControl1.Enabled = False
        frm.bKapat = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        satir_HesapKapat()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_firma_karlilikakistablosu()
    End Sub
    Private Sub sec_sdepo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sdepo.QueryPopUp
        sec_sdepo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_tbDepo.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_sdepo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_sdepo.QueryResultValue
        Dim s As String = deger(ds_tbDepo)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Friend WithEvents colnGecikmeOrtalama As DevExpress.XtraGrid.Columns.GridColumn
End Class
