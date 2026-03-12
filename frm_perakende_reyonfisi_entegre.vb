Imports Microsoft.Win32
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Public Class frm_perakende_reyonfisi_entegre
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
    Friend WithEvents sec_magaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_kasa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kasa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kasiyer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kasiyer_kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_belgeno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sec_fistipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_sMusteri As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ds_baslik As System.Data.DataSet
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
    Friend WithEvents collMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sec_nGirisCikis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sOdemeKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sFiyatTipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_EvrakOlustur As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents kisayol_baslik As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
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
    Friend WithEvents kisayol_detay As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_toplu As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perakende_reyonfisi_entegre))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_magaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_kasa = New DevExpress.XtraEditors.LookUpEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_kasa = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_kasiyer = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kasiyer_kod = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sIslem = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_Onayla = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_belgeno = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_satic = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_toplu = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_fistipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_sMusteri = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sFisTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_EvrakOlustur = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_detay = New System.Windows.Forms.ContextMenu()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGCMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSatici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKayitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesiAV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sFiyatTipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_nGirisCikis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_sOdemeKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.panel_baslik = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_baslik = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.ds_baslik = New System.Data.DataSet()
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
        Me.collMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_Satici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sIslem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Onayla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_toplu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sMusteri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nGirisCikis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_baslik.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Satici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.sec_magaza)
        Me.PanelControl1.Controls.Add(Me.sec_kasa)
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.lbl_kasa)
        Me.PanelControl1.Controls.Add(Me.lbl_kasiyer)
        Me.PanelControl1.Controls.Add(Me.txt_kasiyer_kod)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl1.TabIndex = 2
        '
        'sec_magaza
        '
        Me.sec_magaza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sec_magaza.Location = New System.Drawing.Point(648, 23)
        Me.sec_magaza.Name = "sec_magaza"
        Me.sec_magaza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_magaza.Properties.Appearance.Options.UseFont = True
        Me.sec_magaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_magaza.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açıklama")})
        Me.sec_magaza.Properties.DisplayMember = "sAciklama"
        Me.sec_magaza.Properties.NullText = "[Mağaza]"
        Me.sec_magaza.Properties.ReadOnly = True
        Me.sec_magaza.Properties.ValueMember = "sDepo"
        Me.sec_magaza.Size = New System.Drawing.Size(168, 20)
        Me.sec_magaza.TabIndex = 11
        '
        'sec_kasa
        '
        Me.sec_kasa.Location = New System.Drawing.Point(56, 23)
        Me.sec_kasa.Name = "sec_kasa"
        Me.sec_kasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nKasaNo", 5, "KasaNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", 40, "Açıklama")})
        Me.sec_kasa.Properties.DisplayMember = "nKasaNo"
        Me.sec_kasa.Properties.NullText = "[Kasa]"
        Me.sec_kasa.Properties.ValueMember = "nKasaNo"
        Me.sec_kasa.Size = New System.Drawing.Size(120, 20)
        Me.sec_kasa.TabIndex = 10
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Enabled = False
        Me.DateEdit1.Location = New System.Drawing.Point(648, 4)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.NullText = "[Tarih]"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(168, 20)
        Me.DateEdit1.TabIndex = 8
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(477, 26)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Mağaza:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(503, 7)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Tarih:"
        '
        'lbl_kasa
        '
        Me.lbl_kasa.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kasa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_kasa.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_kasa.Location = New System.Drawing.Point(179, 26)
        Me.lbl_kasa.Name = "lbl_kasa"
        Me.lbl_kasa.Size = New System.Drawing.Size(14, 13)
        Me.lbl_kasa.TabIndex = 5
        Me.lbl_kasa.Text = "**"
        '
        'lbl_kasiyer
        '
        Me.lbl_kasiyer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kasiyer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_kasiyer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_kasiyer.Location = New System.Drawing.Point(179, 7)
        Me.lbl_kasiyer.Name = "lbl_kasiyer"
        Me.lbl_kasiyer.Size = New System.Drawing.Size(7, 13)
        Me.lbl_kasiyer.TabIndex = 4
        Me.lbl_kasiyer.Text = "*"
        '
        'txt_kasiyer_kod
        '
        Me.txt_kasiyer_kod.Location = New System.Drawing.Point(56, 4)
        Me.txt_kasiyer_kod.Name = "txt_kasiyer_kod"
        Me.txt_kasiyer_kod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kasiyer_kod.Properties.NullText = "[Kasiyer]"
        Me.txt_kasiyer_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kasiyer_kod.Size = New System.Drawing.Size(120, 20)
        Me.txt_kasiyer_kod.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(25, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Kasa:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(13, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Kasiyer:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 48)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 120)
        Me.PanelControl2.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lbl_istihbarat)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(542, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(280, 116)
        Me.GroupControl2.TabIndex = 25
        Me.GroupControl2.Text = "İstihbarat"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_istihbarat.Location = New System.Drawing.Point(2, 21)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(276, 13)
        Me.lbl_istihbarat.TabIndex = 0
        Me.lbl_istihbarat.Text = "İstihbarat..."
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.sec_sIslem)
        Me.GroupControl1.Controls.Add(Me.sec_Onayla)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txt_belgeno)
        Me.GroupControl1.Controls.Add(Me.sec_satic)
        Me.GroupControl1.Controls.Add(Me.sec_toplu)
        Me.GroupControl1.Controls.Add(Me.sec_resmi)
        Me.GroupControl1.Controls.Add(Me.sec_fistipi)
        Me.GroupControl1.Controls.Add(Me.txt_sMusteri)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(820, 116)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "&Listele"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(415, 90)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(107, 20)
        Me.SimpleButton3.TabIndex = 66
        Me.SimpleButton3.Text = "&Diğer Alışverişleri"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Enabled = False
        Me.SimpleButton4.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton4.Location = New System.Drawing.Point(415, 58)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(107, 20)
        Me.SimpleButton4.TabIndex = 65
        Me.SimpleButton4.Text = "&Değiştir"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(46, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Fis:"
        '
        'sec_sIslem
        '
        Me.sec_sIslem.EditValue = "Bekliyor..."
        Me.sec_sIslem.EnterMoveNextControl = True
        Me.sec_sIslem.Location = New System.Drawing.Point(184, 90)
        Me.sec_sIslem.Name = "sec_sIslem"
        Me.sec_sIslem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sIslem.Properties.Items.AddRange(New Object() {"[Tümü]", "Bekliyor...", "Hazırlandı...", "Tamamlandı...", "İptal Edildi...", ""})
        Me.sec_sIslem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sIslem.Size = New System.Drawing.Size(81, 20)
        Me.sec_sIslem.TabIndex = 63
        '
        'sec_Onayla
        '
        Me.sec_Onayla.EditValue = "Bekliyor..."
        Me.sec_Onayla.Enabled = False
        Me.sec_Onayla.EnterMoveNextControl = True
        Me.sec_Onayla.Location = New System.Drawing.Point(415, 30)
        Me.sec_Onayla.Name = "sec_Onayla"
        Me.sec_Onayla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Onayla.Properties.Items.AddRange(New Object() {"[Tümü]", "Bekliyor...", "Hazırlandı...", "Tamamlandı...", "İptal Edildi...", ""})
        Me.sec_Onayla.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_Onayla.Size = New System.Drawing.Size(109, 20)
        Me.sec_Onayla.TabIndex = 64
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(184, 46)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(80, 20)
        Me.sec_depo.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Magaza:"
        '
        'txt_belgeno
        '
        Me.txt_belgeno.EnterMoveNextControl = True
        Me.txt_belgeno.Location = New System.Drawing.Point(69, 90)
        Me.txt_belgeno.Name = "txt_belgeno"
        Me.txt_belgeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_belgeno.Size = New System.Drawing.Size(113, 20)
        Me.txt_belgeno.TabIndex = 55
        '
        'sec_satic
        '
        Me.sec_satic.EditValue = "[Tümü]"
        Me.sec_satic.EnterMoveNextControl = True
        Me.sec_satic.Location = New System.Drawing.Point(69, 46)
        Me.sec_satic.Name = "sec_satic"
        Me.sec_satic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satic.Properties.ShowPopupCloseButton = False
        Me.sec_satic.Size = New System.Drawing.Size(113, 20)
        Me.sec_satic.TabIndex = 60
        '
        'sec_toplu
        '
        Me.sec_toplu.Enabled = False
        Me.sec_toplu.Location = New System.Drawing.Point(272, 47)
        Me.sec_toplu.Name = "sec_toplu"
        Me.sec_toplu.Properties.Caption = "t"
        Me.sec_toplu.Size = New System.Drawing.Size(32, 19)
        Me.sec_toplu.TabIndex = 59
        '
        'sec_resmi
        '
        Me.sec_resmi.Enabled = False
        Me.sec_resmi.Location = New System.Drawing.Point(272, 67)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 57
        '
        'sec_fistipi
        '
        Me.sec_fistipi.EditValue = "[Tümü]"
        Me.sec_fistipi.EnterMoveNextControl = True
        Me.sec_fistipi.Location = New System.Drawing.Point(184, 68)
        Me.sec_fistipi.Name = "sec_fistipi"
        Me.sec_fistipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fistipi.Properties.Items.AddRange(New Object() {"[Tümü]", "K", "P", "SK", "SP"})
        Me.sec_fistipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_fistipi.Size = New System.Drawing.Size(80, 20)
        Me.sec_fistipi.TabIndex = 54
        '
        'txt_sMusteri
        '
        Me.txt_sMusteri.EnterMoveNextControl = True
        Me.txt_sMusteri.Location = New System.Drawing.Point(69, 68)
        Me.txt_sMusteri.Name = "txt_sMusteri"
        Me.txt_sMusteri.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sMusteri.Size = New System.Drawing.Size(113, 20)
        Me.txt_sMusteri.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Müşteri:"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton5.Location = New System.Drawing.Point(263, 90)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton5.TabIndex = 44
        Me.SimpleButton5.Text = "&Listele"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(272, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "arasındaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(161, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "ve"
        '
        'DateEdit3
        '
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.EnterMoveNextControl = True
        Me.DateEdit3.Location = New System.Drawing.Point(184, 24)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.ReadOnly = True
        Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit3.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit3.TabIndex = 38
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(69, 24)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(90, 20)
        Me.DateEdit2.TabIndex = 37
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.sec_sFisTipi)
        Me.PanelControl3.Controls.Add(Me.btn_EvrakOlustur)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.Label5)
        Me.PanelControl3.Controls.Add(Me.SimpleButton2)
        Me.PanelControl3.Controls.Add(Me.SimpleButton1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 556)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 58)
        Me.PanelControl3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(243, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'sec_sFisTipi
        '
        Me.sec_sFisTipi.EditValue = "P"
        Me.sec_sFisTipi.EnterMoveNextControl = True
        Me.sec_sFisTipi.Location = New System.Drawing.Point(12, 25)
        Me.sec_sFisTipi.Name = "sec_sFisTipi"
        Me.sec_sFisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFisTipi.Properties.Items.AddRange(New Object() {"K", "P", "SK", "SP"})
        Me.sec_sFisTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sFisTipi.Size = New System.Drawing.Size(80, 20)
        Me.sec_sFisTipi.TabIndex = 55
        '
        'btn_EvrakOlustur
        '
        Me.btn_EvrakOlustur.Enabled = False
        Me.btn_EvrakOlustur.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.btn_EvrakOlustur.Location = New System.Drawing.Point(98, 24)
        Me.btn_EvrakOlustur.Name = "btn_EvrakOlustur"
        Me.btn_EvrakOlustur.Size = New System.Drawing.Size(112, 24)
        Me.btn_EvrakOlustur.TabIndex = 16
        Me.btn_EvrakOlustur.Text = "&Satışı Gerçekleştir"
        '
        'Label2
        '
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(457, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'Label5
        '
        Me.Label5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(457, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 26)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 13
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 26)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GroupControl4)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 375)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(824, 181)
        Me.PanelControl4.TabIndex = 5
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Purple
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.GridControl2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(820, 177)
        Me.GroupControl4.TabIndex = 1
        Me.GroupControl4.Text = "Seçili Satışların Detayı"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_detay
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 21)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sFiyatTipi, Me.sec_nGirisCikis, Me.sec_sSatici, Me.sec_sOdemeKodu})
        Me.GridControl2.Size = New System.Drawing.Size(816, 154)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_detay
        '
        Me.kisayol_detay.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41, Me.MenuItem42, Me.MenuItem43, Me.MenuItem44, Me.MenuItem45})
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem25.Text = "Düzenle"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem28.Text = "Fiyat Düzenle"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem29.Text = "Envanter"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 4
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem30.Text = "Model Envanter"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 5
        Me.MenuItem31.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem31.Text = "Stok Hareketleri"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 6
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem32.Text = "Transfer Hareketleri"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 7
        Me.MenuItem37.Text = "-"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 8
        Me.MenuItem38.Text = "Görünüm Düzenle"
        '
        'MenuItem39
        '
        Me.MenuItem39.Enabled = False
        Me.MenuItem39.Index = 9
        Me.MenuItem39.Text = "Görünümü Kaydet"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 10
        Me.MenuItem40.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem40.Text = "Görünümü Yazdır"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 11
        Me.MenuItem41.Text = "-"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 12
        Me.MenuItem42.Text = "Filtrele"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 13
        Me.MenuItem43.Text = "Gruplandır"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 14
        Me.MenuItem44.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 15
        Me.MenuItem45.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem45.Text = "Tam Ekran"
        '
        'GridView2
        '
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.GridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView2.Appearance.TopNewRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsStokKodu, Me.colsStokAdi, Me.collGCMiktar, Me.collFiyat, Me.collTutar, Me.colsFiyatTipi, Me.colsAciklama, Me.colsMagaza, Me.colsSaticiRumuzu, Me.colnKdvOrani, Me.colsRenkAdi, Me.colnKayitID, Me.collMevcut, Me.colsSec, Me.colnIskontoYuzdesiAV, Me.collIskontoTutari, Me.collTutari})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(361, 243, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 35
        Me.GridView2.Name = "GridView2"
        Me.GridView2.NewItemRowText = "[Yeni Satır]"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "StokID"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.OptionsColumn.AllowFocus = False
        '
        'colsStokKodu
        '
        Me.colsStokKodu.Caption = "StokKodu"
        Me.colsStokKodu.FieldName = "sStokKodu"
        Me.colsStokKodu.Name = "colsStokKodu"
        Me.colsStokKodu.OptionsColumn.AllowFocus = False
        Me.colsStokKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sStokKodu", "{0} Kayıt")})
        Me.colsStokKodu.Visible = True
        Me.colsStokKodu.VisibleIndex = 1
        Me.colsStokKodu.Width = 94
        '
        'colsStokAdi
        '
        Me.colsStokAdi.Caption = "StokAdi"
        Me.colsStokAdi.FieldName = "sStokAdi"
        Me.colsStokAdi.Name = "colsStokAdi"
        Me.colsStokAdi.OptionsColumn.AllowFocus = False
        Me.colsStokAdi.Visible = True
        Me.colsStokAdi.VisibleIndex = 2
        Me.colsStokAdi.Width = 185
        '
        'collGCMiktar
        '
        Me.collGCMiktar.Caption = "Miktar"
        Me.collGCMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collGCMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGCMiktar.FieldName = "lGCMiktar"
        Me.collGCMiktar.Name = "collGCMiktar"
        Me.collGCMiktar.OptionsColumn.AllowFocus = False
        Me.collGCMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGCMiktar", "{0:#,0.##}")})
        Me.collGCMiktar.Visible = True
        Me.collGCMiktar.VisibleIndex = 4
        Me.collGCMiktar.Width = 65
        '
        'collFiyat
        '
        Me.collFiyat.Caption = "Fiyat"
        Me.collFiyat.FieldName = "lBrutFiyat"
        Me.collFiyat.Name = "collFiyat"
        Me.collFiyat.OptionsColumn.AllowFocus = False
        Me.collFiyat.Visible = True
        Me.collFiyat.VisibleIndex = 7
        Me.collFiyat.Width = 65
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.FieldName = "lBrutTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.OptionsColumn.AllowFocus = False
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.##}")})
        Me.collTutar.Visible = True
        Me.collTutar.VisibleIndex = 8
        Me.collTutar.Width = 66
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.OptionsColumn.AllowFocus = False
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 5
        Me.colsFiyatTipi.Width = 65
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Aciklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 13
        Me.colsAciklama.Width = 107
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Magaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.OptionsColumn.AllowFocus = False
        Me.colsMagaza.Width = 97
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satici"
        Me.colsSaticiRumuzu.ColumnEdit = Me.sec_sSatici
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        Me.colsSaticiRumuzu.OptionsColumn.AllowFocus = False
        Me.colsSaticiRumuzu.Visible = True
        Me.colsSaticiRumuzu.VisibleIndex = 12
        Me.colsSaticiRumuzu.Width = 65
        '
        'sec_sSatici
        '
        Me.sec_sSatici.AutoHeight = False
        Me.sec_sSatici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.DisplayMember = "sSatici"
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.NullText = "[Satıcı]"
        Me.sec_sSatici.ValueMember = "sSaticiRumuzu"
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.##"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.OptionsColumn.AllowFocus = False
        Me.colnKdvOrani.Visible = True
        Me.colnKdvOrani.VisibleIndex = 6
        Me.colnKdvOrani.Width = 65
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "RenkAdi"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.OptionsColumn.AllowFocus = False
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 3
        Me.colsRenkAdi.Width = 53
        '
        'colnKayitID
        '
        Me.colnKayitID.Caption = "KayıtID"
        Me.colnKayitID.FieldName = "nKayitID"
        Me.colnKayitID.Name = "colnKayitID"
        Me.colnKayitID.OptionsColumn.AllowFocus = False
        '
        'collMevcut
        '
        Me.collMevcut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collMevcut.AppearanceCell.Options.UseBackColor = True
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,0.###"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        Me.collMevcut.OptionsColumn.AllowFocus = False
        Me.collMevcut.Visible = True
        Me.collMevcut.VisibleIndex = 14
        Me.collMevcut.Width = 77
        '
        'colsSec
        '
        Me.colsSec.Caption = "Seç"
        Me.colsSec.FieldName = "SEC"
        Me.colsSec.Name = "colsSec"
        Me.colsSec.Visible = True
        Me.colsSec.VisibleIndex = 0
        Me.colsSec.Width = 83
        '
        'colnIskontoYuzdesiAV
        '
        Me.colnIskontoYuzdesiAV.Caption = "%Isk"
        Me.colnIskontoYuzdesiAV.DisplayFormat.FormatString = "#,0.00"
        Me.colnIskontoYuzdesiAV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnIskontoYuzdesiAV.FieldName = "nIskontoYuzdesiAV"
        Me.colnIskontoYuzdesiAV.Name = "colnIskontoYuzdesiAV"
        Me.colnIskontoYuzdesiAV.OptionsColumn.AllowFocus = False
        Me.colnIskontoYuzdesiAV.Visible = True
        Me.colnIskontoYuzdesiAV.VisibleIndex = 9
        Me.colnIskontoYuzdesiAV.Width = 74
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Iskonto Tutarı"
        Me.collIskontoTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.OptionsColumn.AllowFocus = False
        Me.collIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskontoTutari", "{0:#,0.00}")})
        Me.collIskontoTutari.Visible = True
        Me.collIskontoTutari.VisibleIndex = 10
        Me.collIskontoTutari.Width = 85
        '
        'collTutari
        '
        Me.collTutari.Caption = "NetTutar"
        Me.collTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutari.FieldName = "lNetTutar"
        Me.collTutari.Name = "collTutari"
        Me.collTutari.OptionsColumn.AllowFocus = False
        Me.collTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collTutari.Visible = True
        Me.collTutari.VisibleIndex = 11
        Me.collTutari.Width = 86
        '
        'sec_sFiyatTipi
        '
        Me.sec_sFiyatTipi.AutoHeight = False
        Me.sec_sFiyatTipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi.DisplayMember = "sFiyatTipi"
        Me.sec_sFiyatTipi.Name = "sec_sFiyatTipi"
        Me.sec_sFiyatTipi.NullText = "[FiyatTipi]"
        Me.sec_sFiyatTipi.ValueMember = "sFiyatTipi"
        '
        'sec_nGirisCikis
        '
        Me.sec_nGirisCikis.AutoHeight = False
        Me.sec_nGirisCikis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nGirisCikis.DisplayMember = "sAciklama"
        Me.sec_nGirisCikis.Name = "sec_nGirisCikis"
        Me.sec_nGirisCikis.NullText = "[SatırTipi]"
        Me.sec_nGirisCikis.ValueMember = "nGirisCikis"
        '
        'sec_sOdemeKodu
        '
        Me.sec_sOdemeKodu.AutoHeight = False
        Me.sec_sOdemeKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeKodu.DisplayMember = "sOdemeKodu"
        Me.sec_sOdemeKodu.Name = "sec_sOdemeKodu"
        Me.sec_sOdemeKodu.ValueMember = "sOdemeKodu"
        '
        'panel_baslik
        '
        Me.panel_baslik.Controls.Add(Me.GroupControl3)
        Me.panel_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_baslik.Location = New System.Drawing.Point(0, 168)
        Me.panel_baslik.Name = "panel_baslik"
        Me.panel_baslik.Size = New System.Drawing.Size(824, 207)
        Me.panel_baslik.TabIndex = 6
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.sec_grid)
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(820, 203)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Yapılan Satışların Listesi"
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl3)
        Me.sec_grid.Location = New System.Drawing.Point(79, 68)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(256, 128)
        Me.sec_grid.TabIndex = 3
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(256, 128)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
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
        Me.colACIKLAMA.Caption = "Açıklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.OptionsColumn.AllowFocus = False
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        Me.colACIKLAMA.Width = 128
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_baslik
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_baslik
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_Satici})
        Me.GridControl1.Size = New System.Drawing.Size(816, 180)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_baslik
        '
        Me.kisayol_baslik.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem22, Me.MenuItem21, Me.MenuItem24, Me.MenuItem18, Me.MenuItem16, Me.MenuItem17, Me.MenuItem19, Me.MenuItem23, Me.MenuItem20, Me.MenuItem2, Me.MenuItem1, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem22
        '
        Me.MenuItem22.Index = 3
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem22.Text = "Yeni Müşteri Hesabı Aç"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 4
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem21.Text = "Müşteri Hesabı Belirle"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 5
        Me.MenuItem24.Text = "Alınan Ödemeler"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 6
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Satışlar"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 7
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Kalan Taksitler"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 8
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Kalan Satışlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 9
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müşteri Kartı"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 10
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem23.Text = "Müşteri Düzenle"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 11
        Me.MenuItem20.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 12
        Me.MenuItem2.Text = "Hızlı Filtre"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 13
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = False
        Me.MenuItem3.Index = 14
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 15
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 16
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 17
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 18
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 19
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 20
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 21
        Me.MenuItem8.Text = "Satırları Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 22
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 23
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekranı Kapla"
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "lMiktar"
        Me.DataColumn1.DataType = GetType(Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lNetTutar"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nMusteriID"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lKodu"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAdi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sSoyadi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Musteri"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteFisTarihi"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "lFisNo"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nGirisCikis"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sFisTipi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sDepo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "ISTIHBARAT"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collMiktar, Me.collNetTutar, Me.colnMusteriID, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colMusteri, Me.coldteFisTarihi, Me.collFisNo, Me.colsFisTipi, Me.colsDepo, Me.colsSatici, Me.colsAciklama1, Me.colsAciklama2, Me.colsAciklama3, Me.colsAciklama4, Me.colsAciklama5, Me.coldteKayitTarihi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(852, 478, 208, 154)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldteKayitTarihi, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMusteri, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'collMiktar
        '
        Me.collMiktar.Caption = "Miktar"
        Me.collMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktar.FieldName = "lToplamMiktar"
        Me.collMiktar.Name = "collMiktar"
        Me.collMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamMiktar", "{0:#,0.##}")})
        Me.collMiktar.Visible = True
        Me.collMiktar.VisibleIndex = 9
        Me.collMiktar.Width = 50
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lMalBedeli"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 10
        Me.collNetTutar.Width = 53
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "MusteriID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        '
        'collKodu
        '
        Me.collKodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collKodu.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collKodu.AppearanceCell.Options.UseBackColor = True
        Me.collKodu.AppearanceCell.Options.UseFont = True
        Me.collKodu.Caption = "Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayıt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 6
        Me.collKodu.Width = 52
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adı"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Visible = True
        Me.colsAdi.VisibleIndex = 7
        Me.colsAdi.Width = 54
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadi"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Visible = True
        Me.colsSoyadi.VisibleIndex = 8
        Me.colsSoyadi.Width = 47
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Musteri"
        Me.colMusteri.FieldName = "sMusteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 5
        Me.colMusteri.Width = 100
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Fiş Tarihi"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 0
        Me.coldteFisTarihi.Width = 62
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiş No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 2
        Me.collFisNo.Width = 48
        '
        'colsFisTipi
        '
        Me.colsFisTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsFisTipi.AppearanceCell.Options.UseFont = True
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 1
        Me.colsFisTipi.Width = 58
        '
        'colsDepo
        '
        Me.colsDepo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsDepo.AppearanceCell.Options.UseBackColor = True
        Me.colsDepo.Caption = "Magaza"
        Me.colsDepo.FieldName = "sMagaza"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.Visible = True
        Me.colsDepo.VisibleIndex = 3
        Me.colsDepo.Width = 46
        '
        'colsSatici
        '
        Me.colsSatici.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsSatici.AppearanceCell.Options.UseBackColor = True
        Me.colsSatici.Caption = "Satici"
        Me.colsSatici.ColumnEdit = Me.sec_Satici
        Me.colsSatici.FieldName = "sSaticiRumuzu"
        Me.colsSatici.Name = "colsSatici"
        Me.colsSatici.Visible = True
        Me.colsSatici.VisibleIndex = 4
        Me.colsSatici.Width = 51
        '
        'sec_Satici
        '
        Me.sec_Satici.AutoHeight = False
        Me.sec_Satici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Satici.DisplayMember = "sSatici"
        Me.sec_Satici.Name = "sec_Satici"
        Me.sec_Satici.NullText = "[Satici]"
        Me.sec_Satici.ValueMember = "sSaticiRumuzu"
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Aciklama1"
        Me.colsAciklama1.FieldName = "sAciklama1"
        Me.colsAciklama1.Name = "colsAciklama1"
        Me.colsAciklama1.Visible = True
        Me.colsAciklama1.VisibleIndex = 11
        Me.colsAciklama1.Width = 62
        '
        'colsAciklama2
        '
        Me.colsAciklama2.Caption = "Aciklama2"
        Me.colsAciklama2.FieldName = "sAciklama2"
        Me.colsAciklama2.Name = "colsAciklama2"
        Me.colsAciklama2.Visible = True
        Me.colsAciklama2.VisibleIndex = 12
        Me.colsAciklama2.Width = 63
        '
        'colsAciklama3
        '
        Me.colsAciklama3.Caption = "Aciklama3"
        Me.colsAciklama3.Name = "colsAciklama3"
        '
        'colsAciklama4
        '
        Me.colsAciklama4.Caption = "Aciklama4"
        Me.colsAciklama4.FieldName = "sAciklama4"
        Me.colsAciklama4.Name = "colsAciklama4"
        '
        'colsAciklama5
        '
        Me.colsAciklama5.Caption = "Aciklama5"
        Me.colsAciklama5.FieldName = "sAciklama5"
        Me.colsAciklama5.Name = "colsAciklama5"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.coldteKayitTarihi.AppearanceCell.Options.UseBackColor = True
        Me.coldteKayitTarihi.Caption = "Saat"
        Me.coldteKayitTarihi.DisplayFormat.FormatString = "HH:mm:ss"
        Me.coldteKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.Visible = True
        Me.coldteKayitTarihi.VisibleIndex = 13
        Me.coldteKayitTarihi.Width = 62
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satış Entegrasyon listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Perakende Entegrasyon", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_perakende_reyonfisi_entegre
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 614)
        Me.Controls.Add(Me.panel_baslik)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_perakende_reyonfisi_entegre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reyon Fişi Entegrasyonu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_sIslem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Onayla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_toplu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sMusteri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nGirisCikis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeKodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_baslik.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Satici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public connection_resmi
    Public connection_orj
    Public connection_resmi1
    Public kullanici
    Dim sKasiyerRumuzu As String = ""
    Dim sKasiyer As String = ""
    Dim sMagaza As String = ""
    Dim nMusteriID As Int64 = 0
    Dim lKodu As String = 0
    Dim sAdi As String = ""
    Dim sSoyadi As String = ""
    Dim sAdres1 As String = ""
    Dim sAdres2 As String = ""
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Dim ds_tbMusteri As DataSet
    Dim ds_tbStok As DataSet
    Dim dr_baslik As DataRow
    Dim dr_Musteri As DataRow
    Dim dr_hareket As DataRow
    Dim ds_hareket As DataSet
    Dim ds_stok As DataSet
    Dim ds_stok_fisi As DataSet
    Dim ds_stok_barkod As DataSet
    Dim ds_stok_sinif As DataSet
    Dim ds_renk As DataSet
    Dim ds_Satici As DataSet
    Dim ds_Magaza As DataSet
    Private Sub frm_perakende_entegre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        DateEdit1.EditValue = sorgu_tarih_kontrol()
        DateEdit2.EditValue = DateEdit1.EditValue
        DateEdit3.EditValue = DateEdit1.EditValue
        dataload_kasa()
        dataload_kasiyer()
        dataload_depo()
        dataload_satici()
        dataload_odemekodu()
    End Sub
    Private Sub dataload_kasa()
        sec_kasa.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nKasaNo,sAciklama  FROM         tbParekendeKasa ")).Tables(0)
        sec_kasa.ItemIndex = 0
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_depo()
        sec_magaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
        sec_magaza.ItemIndex = 0
    End Sub
    Private Sub dataload_satici()
        sec_sSatici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici  FROM         tbSatici where bAktif =1")).Tables(0)
        sec_Satici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici  FROM         tbSatici where bAktif =1")).Tables(0)
        ds_Satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici where bAktif =1"))
        ds_Magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        GridControl3.DataSource = ds_Satici.Tables(0)
        GridControl3.DataMember = Nothing
        'If sDepo <> "" Then
        '    sec_satic.Text = sDepo.ToString
        '    sec_satic.EditValue = sDepo.ToString
        'End If
    End Sub
    Private Sub dataload_odemekodu(Optional ByVal sFiyatTipi As String = "PS")
        sec_sOdemeKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbFiyatTipiOdemePlani.sOdemeKodu, tbOdemePlani.sAciklama FROM         tbFiyatTipiOdemePlani INNER JOIN                       tbOdemePlani ON tbFiyatTipiOdemePlani.sOdemeKodu = tbOdemePlani.sOdemeKodu WHERE     (tbFiyatTipiOdemePlani.sFiyatTipi = '" & sFiyatTipi & "') ORDER BY cast(tbFiyatTipiOdemePlani.sOdemeKodu as integer) ")).Tables(0)
    End Sub
    Private Function satir_kontrol(Optional ByVal etiket As Boolean = False)
        Dim satir As String = " ("
        If etiket = True Then
            satir = "WHERE stok.nStokId IN ("
        End If
        Dim toplamsayi = GridView1.SelectedRowsCount
        'Dim sayi = 0
        'Dim dr1 As DataRow
        'For Each dr1 In ds_baslik.Tables(0).Rows
        '    satir += dr1("nReyonFisiID").ToString
        '    sayi += 1
        '    If sayi < toplamsayi Then
        '        satir += ","
        '    ElseIf sayi = toplamsayi Then
        '        satir += ")"
        '    End If
        'Next
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nMusteriID As String = ""
        Dim s As String
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                satir += dr("nReyonFisiID").ToString
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub sorgu_toplu(ByVal query As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(ds_hareket.Tables(0))
        con.Close()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Public Function sorgu_tarih_kontrol() As DateTime
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select convert(char(10), getdate() , 104)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload(ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal sFisTipi As String, ByVal sMagaza As String, ByVal sSaticiRumuzu As String, ByVal sMusteri As String, ByVal ilkbelge As String, ByVal sonbelge As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sSonuc As String)
        Dim kriter As String = ""
        Dim qAciklama1 = "Başlar"
        Dim qAciklama2 = "Başlar"
        Dim qAciklama3 = "Başlar"
        Dim qAciklama4 = "Başlar"
        Dim qAciklama5 = "Başlar"
        Dim qdepo = "Başlar"
        Dim qsonuc = "Eşittir"
        Dim qMusteri As String = "Başlar"
        kriter = "WHERE (tbAVReyonFisiMaster.nReyonFisiID > 0 ) "
        kriter += " AND (tbAVReyonFisiMaster.dteFisTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "')"
        If ilkbelge <> "" And sonbelge = "" Then
            kriter += " AND (tbAVReyonFisiMaster.lFisNo LIKE '" & ilkbelge & " %')"
        ElseIf ilkbelge <> "" And sonbelge <> "" Then
            kriter += " AND (tbAVReyonFisiMaster.lFisNo BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
        End If
        If sAciklama1 <> "" Then
            kriter += " AND (tbAVReyonFisiMaster.sAciklama1 " & sorgu_kriter_string(sAciklama1, qAciklama1) & " )"
        End If
        If sAciklama2 <> "" Then
            kriter += " AND (tbAVReyonFisiMaster.sAciklama2 " & sorgu_kriter_string(sAciklama2, qAciklama2) & " )"
        End If
        If sAciklama3 <> "" Then
            kriter += " AND (tbAVReyonFisiMaster.sAciklama2 " & sorgu_kriter_string(sAciklama3, qAciklama3) & " )"
        End If
        If sAciklama4 <> "" Then
            kriter += " AND (tbAVReyonFisiMaster.sAciklama2 " & sorgu_kriter_string(sAciklama4, qAciklama4) & " )"
        End If
        If sAciklama5 <> "" Then
            kriter += " AND (tbAVReyonFisiMaster.sAciklama2 " & sorgu_kriter_string(sAciklama5, qAciklama5) & " )"
        End If
        If sMusteri <> "" Then
            kriter += " AND (tbAVReyonFisiMaster.sMusteri " & sorgu_kriter_string(sMusteri, qMusteri) & " )"
        End If
        If Trim(sMagaza) <> "[Tümü]" Then
            kriter += " AND tbAVReyonFisiMaster.sMagaza IN (" & sMagaza & ") "
        End If
        If Trim(sSaticiRumuzu) <> "[Tümü]" Then
            kriter += " AND  tbAVReyonFisiMaster.sSaticiRumuzu IN ( " & sSaticiRumuzu & " ) "
        End If
        If sSonuc <> "[Tümü]" Then
            kriter += " AND (tbAVReyonFisiMaster.sSonuc " & sorgu_kriter_string(sSonuc, qsonuc) & " )"
        End If
        If Trim(sFisTipi) <> "[Tümü]" Then
            kriter += " AND (tbAVReyonFisiMaster.sFisTipi= '" & sFisTipi & "') "
        End If
        ds_baslik = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbAVReyonFisiMaster.*, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi,tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2,tbMusteri.sVergiDairesi,tbMusteri.sVergiNo,  tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT FROM         tbAVReyonFisiMaster INNER JOIN                       tbMusteri ON tbAVReyonFisiMaster.nMusteriID = tbMusteri.nMusteriID   " & kriter & " ORDER BY tbAVReyonFisiMaster.lFisNo"))
        GridControl1.DataSource = ds_baslik.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub dataload_hareket(ByVal nReyonFisiID As String)
        Dim kriter As String = ""
        kriter += " Where tbAVReyonFisiDetay.nReyonFisiID IN " & nReyonFisiID & " "
        ds_hareket = sorgu(sorgu_query("SELECT CAST(1 AS BIT) AS SEC,tbAVReyonFisiDetay.nKayitID, tbAVReyonFisiDetay.nReyonFisiID, tbAVReyonFisiDetay.sFisTipi, tbAVReyonFisiDetay.lFisNo, tbAVReyonFisiDetay.sMagaza, tbAVReyonFisiDetay.sSaticiRumuzu, tbAVReyonFisiDetay.nStokID, tbAVReyonFisiDetay.sFiyatTipi, tbAVReyonFisiDetay.lGCMiktar, tbAVReyonFisiDetay.lFiyat as lCikisFiyat, tbAVReyonFisiDetay.lTutar as lCikisTutar, tbAVReyonFisiDetay.lFiyat AS lBrutFiyat, tbAVReyonFisiDetay.lTutar as lBrutTutar,tbAVReyonFisiDetay.sAciklama, tbAVReyonFisiDetay.sKullaniciAdi, tbAVReyonFisiDetay.dteKayitTarihi, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAdi, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel,(Select nKdvOrani from tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,(Select ISNULL(SUM(lGirisMiktar1-lCikisMiktar1),0) from tbStokFisiDetayi where nStokID =tbAVReyonFisiDetay.nStokID) as lMevcut,tbStok.nIskontoYuzdesiAV,tbAVReyonFisiDetay.lTutar * ( tbStok.nIskontoYuzdesiAV / 100 ) as lIskontoTutari,tbAVReyonFisiDetay.lTutar / ((100 + tbStok.nIskontoYuzdesiAV) / 100) AS lNetTutar  FROM tbAVReyonFisiDetay INNER JOIN tbAVReyonFisiMaster ON tbAVReyonFisiDetay.nReyonFisiID = tbAVReyonFisiMaster.nReyonFisiID INNER JOIN tbStok ON tbAVReyonFisiDetay.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk " & kriter & " Order by tbAVReyonFisiDetay.nKayitID "))
        'If sec_toplu.Checked = True Then
        '    If GridView1.SelectedRowsCount = 1 Then
        '        ds_hareket = sorgu(sorgu_query("SELECT tbAVReyonFisiDetay.nKayitID, tbAVReyonFisiDetay.nReyonFisiID, tbAVReyonFisiDetay.sFisTipi, tbAVReyonFisiDetay.lFisNo, tbAVReyonFisiDetay.sMagaza, tbAVReyonFisiDetay.sSaticiRumuzu, tbAVReyonFisiDetay.nStokID, tbAVReyonFisiDetay.sFiyatTipi, tbAVReyonFisiDetay.lGCMiktar, tbAVReyonFisiDetay.lFiyat, tbAVReyonFisiDetay.lTutar, tbAVReyonFisiDetay.sAciklama, tbAVReyonFisiDetay.sKullaniciAdi, tbAVReyonFisiDetay.dteKayitTarihi, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAdi, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel FROM tbAVReyonFisiDetay INNER JOIN tbAVReyonFisiMaster ON tbAVReyonFisiDetay.nReyonFisiID = tbAVReyonFisiMaster.nReyonFisiID INNER JOIN tbStok ON tbAVReyonFisiDetay.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk " & kriter & " Order by tbAVReyonFisiDetay.nKayitID "))
        '    ElseIf GridView1.SelectedRowsCount > 1 Then
        '        sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        '    End If
        'Else
        '    ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        'End If
        'ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        GridControl2.DataSource = ds_hareket.Tables(0)
        GridControl2.DataMember = Nothing
        If GridView2.RowCount > 0 Then
            If GridView2.SelectedRowsCount > 1 Then
                Label2.Text = "Hareket Kayıt Sayısı :" & GridView2.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView2.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView2.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = "Hareket Kayıt Sayısı :" & GridView2.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView2.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
        End If
        Dim dr1 As DataRow
        For Each dr1 In ds_hareket.Tables(0).Rows
            dr1("lCikisFiyat") = dr1("lBrutFiyat") / ((100 + dr1("nIskontoYuzdesiAV")) / 100)
            dr1("lCikisFiyat") = dr1("lCikisFiyat") / ((100 + dr1("nKdvOrani")) / 100)
            dr1("lCikisTutar") = dr1("lCikisFiyat") * dr1("lGCMiktar")
        Next
        dr1 = Nothing
    End Sub
    Private Sub dataload_hareket_ler(ByVal tarih As DateTime, ByVal nMusteriID As String, ByVal sFisTipi As String, ByVal lFisNo As String)
        Dim kriter_musteri = ""
        Dim kriter_belgeno = ""
        Dim kasiyer_satis = ""
        Dim kasiyer_odeme = ""
        Dim kriter As String = ""
        kriter += " WHERE (tbStokFisiDetayi.nMusteriID = '" & nMusteriID & "') AND (tbStokFisiDetayi.sFisTipi = '" & sFisTipi & "') AND (tbStokFisiDetayi.dteFisTarihi = '" & tarih & "') and (tbStokFisiDetayi.lFisNo= '" & lFisNo & "') "
        If sec_toplu.Checked = True Then
            If GridView1.SelectedRowsCount = 1 Then
                ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
            ElseIf GridView1.SelectedRowsCount > 1 Then
                sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
            End If
            'ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        Else
            ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        End If
        'ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        GridControl2.DataSource = ds_hareket.Tables(0)
        GridControl2.DataMember = Nothing
        If GridView2.RowCount > 0 Then
            If GridView2.SelectedRowsCount > 1 Then
                Label2.Text = "Hareket Kayıt Sayısı :" & GridView2.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView2.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView2.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = "Hareket Kayıt Sayısı :" & GridView2.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView2.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
        End If
        Dim dr1 As DataRow
        For Each dr1 In ds_hareket.Tables(0).Rows
            dr1("lBrutFiyat") = dr1("lCikisFiyat") * ((100 + dr1("nKdvOrani")) / 100)
            dr1("lBrutTutar") = dr1("lBrutFiyat") * dr1("lCikisMiktar1")
        Next
        dr1 = Nothing
    End Sub
    Public Function sorgu_musteri_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nfirmaID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nMusteriID,0) AS nMusteriID FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_tbMusteri(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_tbMusteri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Function tbMusteri_kaydet_yeni(ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteri (sMagaza, lKodu, sAdi, sSoyadi, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsIl, sIsPostaKodu, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, sHitap, sKullaniciAdi, dteKayitTarihi, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sGSM, sFax, sResimAdi) VALUES     ('" & sMagaza & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", " & lAylikGelir & ", '" & dteKartAcilisTarihi & "', " & nIskontoPesin & ", " & nIskontoKredili & ", '" & sUnvan & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bYazismaEvAdresinemi & ", '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsIl & "', '" & sIsPostaKodu & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sSigortaNo & "', " & bEvlimi & ", '" & dteEvlilikTarihi & "', '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sEhliyetNo & "', '" & sKanGrubu & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sGSM & "', '" & sFax & "', '" & sResimAdi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbMusteriSinifi_kaydet_yeni(ByVal nMusteriID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriSinifi (nMusteriID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nMusteriID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nStokID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub dataload_stok_barkod(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_barkod = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokBarkodu " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokSinifi " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif1(ByVal sStokSinifi As String, ByVal sinifno As Integer)
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sStokSinifi & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM          tbSSinif" & sinifno & " " & kriter & ""))
    End Sub
    Private Sub dataload_sRenk(ByVal sRenk As String)
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "') "
        ds_renk = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbRenk " & kriter & ""))
    End Sub
    Public Function sorgu_Renk_kontrol(ByVal sRenk As String) As Int64
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbRenk " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_Sinif_kontrol(ByVal sSinifKodu As String, ByVal sinifno As Integer) As Int64
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM          tbSSinif" & sinifno & " " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function stok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStok                       (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', '" & nStokTipi & "', '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi2 & "', " & nIskontoYuzdesi & " , '" & sKdvTipi & "', " & nTeminSuresi & " , " & lAsgariMiktar & " , " & lAzamiMiktar & " , '" & sOzelNot & "', '" & nFiyatlandirma & "', '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & " , '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & " , " & bOTVVar & " , '" & sOTVTipi & "' , '" & nIskontoYuzdesiAV & "', '" & bEk1 & "', '" & nEk2 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub stok_renk_kaydet_yeni(ByVal sRenk As String, ByVal sRenkAdi As String, ByVal lRenkNo As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbRenk                       (sRenk, sRenkAdi, lRenkNo) VALUES     ('" & sRenk & "', '" & sRenkAdi & "', '" & lRenkNo & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_sinif_kaydet_yeni(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSSinif" & sinifno & "                       (sSinifKodu, sAciklama) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_barkod_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As String, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu                       (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     ('" & nStokID & "', '" & sBarkod & "', '" & nKisim & "', '" & nFirmaID & "', '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_siniflari_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi                       (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     ('" & nStokID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "', '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kasiyer_kontrol(Optional ByVal bKontrol As Boolean = True)
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kasiyer_kod.Text Then
                sKasiyerRumuzu = dr("IND")
                sKasiyer = dr("KASIYER")
                sMagaza = dr("DEPO")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            lbl_kasiyer.Text = sKasiyer
            sec_magaza.EditValue = sMagaza
            txt_kasiyer_kod.Enabled = False
            DateEdit2.Properties.ReadOnly = False
            DateEdit3.Properties.ReadOnly = False
            If bKontrol = True Then
                GridControl1.Focus()
                GridControl1.Select()
                txt_sMusteri.Focus()
                txt_sMusteri.SelectAll()
                btn_EvrakOlustur.Enabled = True
            Else
            End If
        ElseIf sonuc = False Then
            lbl_kasiyer.Text = ""
            txt_kasiyer_kod.Enabled = True
            txt_kasiyer_kod.EditValue = ""
            DateEdit2.Properties.ReadOnly = True
            DateEdit3.Properties.ReadOnly = True
            btn_EvrakOlustur.Enabled = False
            If XtraMessageBox.Show(Sorgu_sDil("Şifre Hatalı Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub tbMusteri_yeni()
        If KayitSiniri_kontrol("tbMusteri", "", nKayitSinir) = True Then
            Dim frm As New frm_musteri_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = 0
            frm.kullanici = kullanici
            frm.sMagaza = sec_magaza.EditValue
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim dr As DataRow
                    Dim arr As Integer()
                    Dim i As Integer
                    Dim sayi As Integer = 0
                    Dim nMusteriID As String = ""
                    Dim s As String
                    arr = GridView1.GetSelectedRows()
                    If arr Is Nothing Then
                    Else
                        Array.Sort(arr)
                        For Each i In arr
                            s = i.ToString
                            dr = GridView1.GetDataRow(s)
                            dr("nMusteriID") = frm.nMusteriID
                            dr("lKodu") = frm.txt_musteriNo.Text
                            dr("sAdi") = frm.txt_sAdi.Text
                            dr("sSoyadi") = frm.txt_sSoyadi.Text
                            baslik_kaydet_degistir(dr("nReyonFisiID"), dr("dteFisTarihi"), dr("sFisTipi").ToString, dr("lFisNo"), dr("sMagaza").ToString, dr("sSaticiRumuzu").ToString, dr("lToplamMiktar"), dr("lMalBedeli"), dr("nMusteriID"), dr("sMusteri").ToString, dr("sAciklama1").ToString, dr("sAciklama2").ToString, dr("sAciklama3").ToString, dr("sAciklama4").ToString, dr("sAciklama5").ToString, dr("sSonuc").ToString)
                        Next
                        GridControl1.Select()
                        GridView1.Focus()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr1 As DataRow
            Dim DR As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            Dim arr As Integer()
            Dim i As Integer
            Dim sayi As Integer = 0
            Dim nMusteriID As String = ""
            Dim s As String
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    DR = GridView1.GetDataRow(s)
                    DR("nMusteriID") = dr1("nMusteriID")
                    DR("lKodu") = dr1("lKodu")
                    DR("sAdi") = dr1("sAdi")
                    DR("sSoyadi") = dr1("sSoyadi")
                    baslik_kaydet_degistir(DR("nReyonFisiID"), DR("dteFisTarihi"), DR("sFisTipi").ToString, DR("lFisNo"), DR("sMagaza").ToString, DR("sSaticiRumuzu").ToString, DR("lToplamMiktar"), DR("lMalBedeli"), DR("nMusteriID"), DR("sMusteri").ToString, DR("sAciklama1").ToString, DR("sAciklama2").ToString, DR("sAciklama3").ToString, DR("sAciklama4").ToString, DR("sAciklama5").ToString, DR("sSonuc").ToString)
                Next
            End If
            GridView1.Focus()
            GridView1.FocusedRowHandle = satir
        End If
        'ara()
    End Sub
    Private Sub musteri_toplu_kontrol()
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nMusteriID As String = ""
        Dim s As String
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                If dr("nMusteriID").ToString <> nMusteriID.ToString Then
                    lKodu = dr("nMusteriID").ToString
                    sayi += 1
                End If
            Next
        End If
        If sayi = 1 Then
            sec_toplu.Checked = False
        ElseIf sayi > 1 Then
            sec_toplu.Checked = True
        End If
        'If sayi = 1 Then
        '    If sec_sFisTipi.EditValue = "IA" Or sec_sFisTipi.EditValue = "IS" Then
        '        MenuItem13.Visible = True
        '        MenuItem13.Enabled = True
        '    End If
        'Else
        '    MenuItem13.Visible = False
        '    MenuItem13.Enabled = False
        'End If
    End Sub
    Private Sub txt_kasiyer_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kasiyer_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sMusteri.ButtonClick
        musteri_sec()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        'If GridView1.RowCount > 0 Then
        '    dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    dataload_hareket(dr_baslik("dteFisTarihi"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("lFisNo"))
        '    lbl_istihbarat.Text = dr_baslik("ISTIHBARAT").ToString
        '    If GridView1.SelectedRowsCount > 1 Then
        '        Label5.Text = "Belge Kayıt Sayısı :" & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        '    ElseIf GridView1.SelectedRowsCount = 1 Then
        '        Label5.Text = "Belge Kayıt Sayısı :" & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        '    Else
        '        Label5.Text = ""
        '    End If
        'End If
        detay_kontrol()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        ara()
    End Sub
    Private Sub ara()
        GridView1.ClearColumnsFilter()
        dataload(DateEdit2.EditValue, DateEdit3.EditValue, sec_fistipi.Text, sec_depo.Text, sec_satic.Text, txt_sMusteri.Text, txt_belgeno.Text, txt_belgeno.Text, "", "", "", "", "", sec_sIslem.Text)
        Try
            If GridView1.RowCount > 0 Then
                dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dataload_hareket(satir_kontrol())
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount > 0 Then
            If GridView2.SelectedRowsCount > 1 Then
                Label2.Text = "Hareket Kayıt Sayısı :" & GridView2.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView2.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView2.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = "Hareket Kayıt Sayısı :" & GridView2.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView2.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub baslik_kaydet_degistir(ByVal nReyonFisiID As Int64, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal lFisNo As Int64, ByVal sMagaza As String, ByVal sSaticiRumuzu As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal nMusteriID As Int64, ByVal sMusteri As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sSonuc As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVReyonFisiMaster SET              dteFisTarihi = '" & dteFisTarihi & "', sFisTipi = '" & sFisTipi & "', lFisNo = " & lFisNo & ", sMagaza = '" & sMagaza & "', sSaticiRumuzu = '" & sSaticiRumuzu & "',lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", nMusteriID = " & nMusteriID & ", sMusteri = '" & sMusteri & "', sAciklama1 = '" & sAciklama1 & "',sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "', sSonuc = '" & sSonuc & "' Where nReyonFisiID = " & nReyonFisiID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EvrakOlustur.Click
        If btn_EvrakOlustur.Text = "&Satışı Gerçekleştir" Then
            dataload_kasiyer()
            kasiyer_kontrol(False)
            Dim dr As DataRow
            Dim sayi As Integer = 0
            Dim lMiktar As Decimal = 0
            Dim lTutar As Decimal = 0
            Dim lIskontoTutari As Decimal = 0
            For Each dr In ds_hareket.Tables(0).Rows
                If dr("SEC") = True Then
                    sayi += 1
                    lMiktar += dr("lGCMiktar")
                    lTutar += dr("lBrutTutar")
                    lIskontoTutari += dr("lIskontoTutari")
                End If
            Next
            If GridView1.FocusedRowHandle >= 0 And sayi > 0 Then
                dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr_baslik("lKodu") = 0 Then
                    musteri_sec()
                Else
                    If XtraMessageBox.Show("[" & sec_sFisTipi.Text & "]" & vbTab & sayi & "Prç" & vbTab & Format(lMiktar, "#,0.##") & " Adet" & vbTab & Format(lTutar, "#,0.00#") & " TL" & vbCrLf & "Evrak Tipi olarak Belgelendirmek İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        If sayi = 0 Then
                            XtraMessageBox.Show("Seçili Ürün Satırı Yok, Lütfen Seçim İşleminizi Kontrol Ediniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            baslik_sonuc_degistir("Tamamlandı...")
                            Faturala(Trim(sec_sFisTipi.Text))
                            ara()
                        End If
                    End If
                End If
            Else
                XtraMessageBox.Show("Lütfen Müşteri Satırı Seçiniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf btn_EvrakOlustur.Text = "Müşteri Seç" Then
            musteri_sec()
        End If
        'belgele()
    End Sub
    Private Sub belgele()
        If XtraMessageBox.Show(Sorgu_sDil("Faturalama İşlemine Başlamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            sec_sIslem.Text = "Bekliyor..."
            baslik_degistir("Tamamlandı...")
            Dim nStokID As Int64 = 0
            Dim nMusteriID As Int64 = 0
            Dim nAlisVerisID As String = ""
            Dim nIslemID As Int64 = 0
            Dim nHareketID As Int64 = 0
            Dim musteri_kayit_sayisi As Int64 = 0
            Dim stok_kayit_sayisi As Int64 = 0
            musteri_kayit_sayisi = 1 'sorgu_musteri_kontrol(dr_baslik("lKodu"))
            If musteri_kayit_sayisi = 0 Then
                dataload_tbMusteri(dr_baslik("lKodu"))
                dr_Musteri = ds_tbMusteri.Tables(0).Rows(0)
                nMusteriID = tbMusteri_kaydet_yeni(dr_Musteri("sMagaza"), dr_Musteri("lKodu"), dr_Musteri("sAdi"), dr_Musteri("sSoyadi"), dr_Musteri("nCinsiyet"), dr_Musteri("lAylikGelir"), dr_Musteri("dteKartAcilisTarihi"), dr_Musteri("nIskontoPesin"), dr_Musteri("nIskontoKredili"), dr_Musteri("sUnvan"), dr_Musteri("sVergiDairesi"), dr_Musteri("sVergiNo"), dr_Musteri("bYazismaEvAdresinemi"), dr_Musteri("sEmail"), dr_Musteri("sIsYeriAdi"), dr_Musteri("sIsAdresi1"), dr_Musteri("sIsAdresi2"), dr_Musteri("sIsSemt"), dr_Musteri("sIsIl"), dr_Musteri("sIsPostaKodu"), dr_Musteri("sIsTelefonu"), dr_Musteri("sEvAdresi1"), dr_Musteri("sEvAdresi2"), dr_Musteri("sEvSemt"), dr_Musteri("sEvPostaKodu"), dr_Musteri("sEvIl"), dr_Musteri("sEvTelefonu"), dr_Musteri("sSigortaNo"), dr_Musteri("bEvlimi"), dr_Musteri("dteEvlilikTarihi"), dr_Musteri("dteDogumTarihi"), dr_Musteri("sDogumYeri"), dr_Musteri("sEhliyetNo"), dr_Musteri("sKanGrubu"), dr_Musteri("sHitap"), dr_Musteri("sKullaniciAdi"), dr_Musteri("dteKayitTarihi"), dr_Musteri("sAciklama1"), dr_Musteri("sAciklama2"), dr_Musteri("sAciklama3"), dr_Musteri("sAciklama4"), dr_Musteri("sAciklama5"), dr_Musteri("sGSM"), dr_Musteri("sFax"), dr_Musteri("sResimAdi"))
                tbMusteriSinifi_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
            Else
            End If
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr_stok As DataRow
            'Dim dr_stok_barkod As DataRow
            Dim barkod_var As Boolean = False
            Dim dr_stok_sinif As DataRow
            Dim dr_renk As DataRow
            Dim dr_stok_sinifi As DataRow
            Dim renk_kayit_sayisi As Int64 = 0
            Dim sinif_kayit_sayisi As Int64 = 0
            arr = GridView2.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView2.GetDataRow(s)
                    stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr("sStokKodu")))
                    If stok_kayit_sayisi = 0 Then
                        'MsgBox(dr("sKodu") & " Kodlu Stok Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                        'Stok Bilgini Çek
                        dataload_stok(dr("sStokKodu"))
                        'Stok Barkod Bilgisini Çek
                        dataload_stok_barkod(dr("nStokID"))
                        Dim dr_stok_barkod As DataRow
                        If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                            barkod_var = True
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        Else
                            barkod_var = False
                        End If
                        'Sınıf Bilgisini Çek
                        dataload_stok_sinif(dr("nStokID"))
                        'datarowa yükle
                        dr_stok = ds_stok.Tables(0).Rows(0)
                        'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                        renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                        If renk_kayit_sayisi = 0 Then
                            dataload_sRenk(dr_stok("sRenk"))
                            dr_renk = ds_renk.Tables(0).Rows(0)
                            stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                        Else
                        End If
                        'Sınıf Kayıtlarını Kontrol Et
                        For ı As Integer = 1 To 15
                            'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                            sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                            If sinif_kayit_sayisi = 0 Then
                                dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                                stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ı)
                            Else
                            End If
                        Next
                        'Stoğu Kaydet
                        nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                        'barkodu kaydet
                        If barkod_var = True Then
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                        Else
                        End If
                        'sınıfları kaydet
                        stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                    Else
                        nStokID = sorgu_nStokID(Trim(dr("sStokKodu")))
                    End If
                Next
            End If
            Faturala(sec_sFisTipi.Text)
        End If
    End Sub
    Private Sub Faturala(ByVal sFisTipi As String)
        dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim nAlisVerisID As String = ""
        Dim dteFisTarihi = DateEdit1.EditValue
        Dim lFaturaNo = 0
        Dim nMusteriID = 0
        Dim sAdi = dr_baslik("sAdi")
        Dim sSoyadi = dr_baslik("sSoyadi")
        Dim sMagaza = sec_magaza.EditValue
        'Dim sKasiyerRumuzu = sKasiyerRumuzu
        'Dim sKasiyer = sKasiyer
        Dim sHareketTipi = ""
        Dim nKasaNo = sec_kasa.EditValue
        Dim sAdres1 As String = dr_baslik("sEvAdresi1")
        Dim sAdres2 As String = dr_baslik("sEvAdresi2")
        nMusteriID = dr_baslik("nMusteriID") 'sorgu_nfirmaID(dr_baslik("lKodu"))
        If nAlisVerisID = "" Then
            nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
            lFaturaNo = sorgu_lFaturaNo(sMagaza)
            sHareketTipi = sorgu_sHareketTipi(sMagaza)
            tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAdi, sSoyadi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, sHareketTipi, 0, nKasaNo, kullanici, Now, "")
            tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
            lFaturaNo_degistir(lFaturaNo, sMagaza)
            nAlisVerisID = sMagaza & nAlisVerisID.ToString
            Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
            If kayitsayisi = 0 Then
                tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, "", sAdres1, sAdres2, "", "", "Türkiye", "", dr_baslik("sVergiDairesi"), dr_baslik("sVergiNo"), "")
            End If
        End If
        Dim dr As DataRow
        For Each dr In ds_hareket.Tables(0).Rows
            If dr("SEC") = True Then
                If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
                    Dim nIslemID As Int64 = sorgu_nStokIslemID()
                    Dim nStokID As Int64 = 0
                    Dim sOdemeKodu As String = ""
                    If Trim(dr("sFiyatTipi")) = "6 AY" Then
                        sOdemeKodu = "6   "
                    ElseIf Trim(dr("sFiyatTipi")) = "10AY" Then
                        sOdemeKodu = "10  "
                    ElseIf Trim(dr("sFiyatTipi")) = "15AY" Then
                        sOdemeKodu = "15  "
                    ElseIf Trim(dr("sFiyatTipi")) = "PS" Then
                        sOdemeKodu = "0   "
                    ElseIf Trim(dr("sFiyatTipi")) = "HD" Then
                        sOdemeKodu = "0   "
                    End If
                    dr("sSaticiRumuzu") = sorgula_sSaticiRumuzu(dr("sSaticiRumuzu"))
                    nStokID = dr("nStokID")
                    nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, 3, sMagaza, 0, sFisTipi, sKasiyerRumuzu, dr("sSaticiRumuzu"), sOdemeKodu, dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), 0, 0, 0, dr("nIskontoYuzdesiAV"), dr("lIskontoTutari"), "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("sAciklama"), sHareketTipi, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, "", nAlisVerisID, 0, "", "", sFisTipi, 0, 0, 0, 0, kullanici, Now)
                    fis_detay_fisno_degistir(nIslemID)
                ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
                    Dim nSiparisID As Int64 = sorgu_nSiparisID(sMagaza)
                    Dim sOdemeKodu As String = ""
                    If Trim(dr("sFiyatTipi")) = "6 AY" Then
                        sOdemeKodu = "6"
                    ElseIf Trim(dr("sFiyatTipi")) = "10AY" Then
                        sOdemeKodu = "10"
                    ElseIf Trim(dr("sFiyatTipi")) = "10AY" Then
                        sOdemeKodu = "15"
                    ElseIf Trim(dr("sFiyatTipi")) = "PS" Then
                        sOdemeKodu = "0"
                    ElseIf Trim(dr("sFiyatTipi")) = "HD" Then
                        sOdemeKodu = "0"
                    End If
                    dr("sSaticiRumuzu") = sorgula_sSaticiRumuzu(dr("sSaticiRumuzu"))
                    tbAlisVerisSiparis_kaydet_yeni(nAlisVerisID, sMagaza, nSiparisID, 3, dr("nStokID"), sKasiyerRumuzu, dr("sSaticiRumuzu"), sOdemeKodu, 0, dr("sFiyatTipi"), dr("lGCMiktar"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesiAV"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), "", 0, DateAdd(DateInterval.Day, 1, dteFisTarihi), "01/01/1900", 0, 0, dr("sAciklama").ToString, 0, 0, 0, "", 0, 0, kullanici, Now, "01/01/1900")
                    tbAvSirano_degistir(5, nSiparisID, sMagaza)
                End If
            End If
        Next
        fatura_detay(nAlisVerisID, sFisTipi)
        'ara()
    End Sub
    Private Function sorgula_sSaticiRumuzu(ByVal Rumuz As String) As String
        Dim drs As DataRow
        Dim sSaticiRumuzu As String = "0"
        For Each drs In ds_Satici.Tables(0).Rows
            If Trim(Rumuz) = Trim(drs("KOD")) Then
                sSaticiRumuzu = Trim(drs("KOD"))
            End If
        Next
        Return sSaticiRumuzu
    End Function
    Private Sub fatura_detay(ByVal nAlisVerisID As String, ByVal sFisTipi As String)
        Dim frm As New frm_Perakende_Satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.aktarim = True
        frm.nAlisVerisID = nAlisVerisID
        frm.sFisTipi = Trim(sFisTipi.ToString)
        frm.kullanici = kullanici
        frm.nMusteriID = nMusteriID
        frm.bFisYenimi = True
        'frm.sinif2Bakma = True
        'If yetki_kontrol(kullanici, frm.Name) = True Then
        frm.ShowDialog()
        'End If
        dr = Nothing
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'If conn.State = ConnectionState.Closed Then
        '    conn.Open()
        'End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        'cmd = Nothing
        'adapter = Nothing
        Return 1
    End Function
    Public Function sorgu_nSiparisID(ByVal sMagazaKodu As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nSiparisID), 0) + 1 AS nSiparisID FROM         tbAlisverisSiparis Where sMagazaKodu ='" & sMagazaKodu & "'")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nAlisVerisID  like '" & sDepo & "%') ORDER BY CAST(ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) AS DECIMAL) DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_sHareketTipi(ByVal sDepo As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sDefaultHareketTipi,'') as sHareketTipi FROM         tbParamAlisVeris WHERE     (sMagazaKodu = '" & sDepo & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lFaturaNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lFaturaNo, 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (sMagaza = '" & sDepo & "') AND (nGirisCikis = 3) AND (sFisTipi IN ('K', 'P')) ORDER BY lFaturaNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
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
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub lFaturaNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String) As Int64
        Dim kriter As String = ""
        kriter = "WHERE (nAlisVerisID = '" & nAlisVerisID & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbAlisVerisAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
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
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
    End Function
    Private Sub tbAlisVerisSiparis_kaydet_yeni(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As Int64, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Decimal, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal bMuhasebeyeIslendimi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal dteOnayTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisverisSiparis (nAlisverisID, sMagazaKodu, nSiparisID, nGirisCikis, nStokID, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, lReyonFisNo, sFiyatTipi, lGCMiktar, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, nKdvOrani, sIadeNedeni, nPartiID, dteTeslimEdilecek, dteTeslimEdilen, bTeslimEdildi, bMuhasebeyeIslendimi, sAciklama, bEkSoru, bEkAlan1, bEkAlan2, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sSonKullaniciAdi, dteSonUpdateTarihi, dteOnayTarihi) VALUES     ('" & nAlisverisID & "', '" & sMagazaKodu & "', " & nSiparisID & ", " & nGirisCikis & ", " & nStokID & ", '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', " & lReyonFisNo & ", '" & sFiyatTipi & "', " & lGCMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", " & lFiyat & ", " & lTutar & ", " & nKdvOrani & ", '" & sIadeNedeni & "', " & nPartiID & ", '" & dteTeslimEdilecek & "', '" & dteTeslimEdilen & "', " & bTeslimEdildi & ", " & bMuhasebeyeIslendimi & ", N'" & sAciklama & "', " & bEkSoru & ", " & bEkAlan1 & ", '" & bEkAlan2 & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & dteOnayTarihi & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_odeme_detay_tumu()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_odeme
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.musterikodu = dr("lKodu")
            frm.tarih = Today
            frm.belgeno = 1
            frm.tumu = True
            'frm.stokno = dr("ALISVERISNO")
            'frm.fistipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
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
    Private Sub analiz_musteri_duzenle()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lKodu = dr("lKodu")
            frm.nMusteriID = dr("nMusteriID")
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
    Private Sub stok_duzelt()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sStokKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView2.FocusedRowHandle
            GridView2.FocusedRowHandle = satir
            satir = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sStokKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sStokKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sStokKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "[Tümü]"
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
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
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
            dr = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sStokKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView2.FocusedRowHandle
            GridView2.FocusedRowHandle = satir
            satir = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        'If sec_resmi.Checked = True Then
        '    connection = connection
        '    dataload(DateEdit2.EditValue, DateEdit3.EditValue, kullanici, txt_musterino.EditValue, txt_belgeno.EditValue, sec_depo.EditValue, sec_fistipi.Text)
        'ElseIf sec_resmi.Checked = False Then
        '    connection = connection_orj
        '    dataload(DateEdit2.EditValue, DateEdit3.EditValue, kullanici, txt_musterino.EditValue, txt_belgeno.EditValue, sec_depo.EditValue, sec_fistipi.Text)
        'End If
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If MenuItem2.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem2.Checked = True
        ElseIf MenuItem2.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem2.Checked = False
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If MenuItem5.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem5.Checked = True
        ElseIf MenuItem5.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem5.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem6.Checked = False
        End If
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
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        If MenuItem42.Checked = False Then
            GridView2.OptionsCustomization.AllowFilter = True
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem42.Checked = True
        ElseIf MenuItem42.Checked = True Then
            GridView2.OptionsCustomization.AllowFilter = False
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem42.Checked = False
        End If
    End Sub
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        If MenuItem43.Checked = False Then
            GridView2.OptionsCustomization.AllowGroup = True
            GridView2.OptionsView.ShowGroupPanel = True
            MenuItem43.Checked = True
        ElseIf MenuItem43.Checked = True Then
            GridView2.OptionsCustomization.AllowGroup = False
            GridView2.OptionsView.ShowGroupPanel = False
            MenuItem43.Checked = False
        End If
    End Sub
    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        detay_kontrol()
    End Sub
    Private Sub detay_kontrol()
        Try
            musteri_toplu_kontrol()
            If sec_toplu.Checked = True Then
                Dim arr As Integer()
                Dim i As Integer
                Dim sayi As Integer = 0
                Dim nMusteriID As String = ""
                Dim s As String = ""
                arr = GridView1.GetSelectedRows()
                If GridView1.SelectedRowsCount > 1 Then
                    ds_hareket.Clear()
                    If arr Is Nothing Then
                    Else
                        Array.Sort(arr)
                        For Each i In arr
                            s = i.ToString
                            dr_baslik = GridView1.GetDataRow(s)
                            dataload_hareket(satir_kontrol)
                        Next
                    End If
                End If
            Else
                If GridView1.RowCount > 0 Then
                    dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    dataload_hareket(satir_kontrol())
                    lbl_istihbarat.Text = dr_baslik("ISTIHBARAT").ToString
                    sec_sFisTipi.Text = Trim(dr_baslik("sFisTipi"))
                    If dr_baslik("lKodu") = 0 Then
                        btn_EvrakOlustur.Text = "Müşteri Seç"
                    Else
                        btn_EvrakOlustur.Text = "&Satışı Gerçekleştir"
                    End If
                    If GridView1.SelectedRowsCount > 1 Then
                        Label5.Text = "Belge Kayıt Sayısı :" & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
                    ElseIf GridView1.SelectedRowsCount = 1 Then
                        Label5.Text = "Belge Kayıt Sayısı :" & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
                    Else
                        Label5.Text = ""
                    End If
                End If
            End If
            'GridView2.SelectAll()
            If GridView1.RowCount > 0 Then
                If GridView1.SelectedRowsCount > 1 Then
                    Label5.Text = "Belge Kayıt Sayısı :" & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
                ElseIf GridView1.SelectedRowsCount = 1 Then
                    Label5.Text = "Belge Kayıt Sayısı :" & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
                Else
                    Label5.Text = ""
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_satic As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_satic.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl3.DataSource = ds_Magaza.Tables(0)
        GridControl3.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_Magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_satic_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_satic.QueryPopUp
        sec_depo.Properties.PopupControl = Nothing
        sec_satic.Properties.PopupControl = sec_grid
        GridControl3.DataSource = ds_Satici.Tables(0)
        GridControl3.DataMember = Nothing
    End Sub
    Private Sub sec_satic_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_satic.QueryResultValue
        Dim s As String = deger(ds_Satici)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sIslem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colsSatici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGCMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKayitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        musteri_sec()
    End Sub
    Friend WithEvents sec_sFisTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_Onayla As DevExpress.XtraEditors.ComboBoxEdit
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show("Seçili Reyon Fişlerinin Sonuç Durumunu " & sec_Onayla.Text & " Olarak Değiştirmek İstedinize Emin Misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            baslik_degistir(sec_Onayla.Text)
        End If
    End Sub
    Private Sub baslik_degistir(ByVal sSonuc As String)
        baslik_kaydet_degistir_toplu(satir_kontrol, dr_baslik("dteFisTarihi"), dr_baslik("sFisTipi").ToString, dr_baslik("lFisNo"), dr_baslik("sMagaza").ToString, dr_baslik("sSaticiRumuzu").ToString, dr_baslik("lToplamMiktar"), dr_baslik("lMalBedeli"), dr_baslik("nMusteriID"), dr_baslik("sMusteri").ToString, dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, sSonuc)
        ara()
    End Sub
    Private Sub baslik_sonuc_degistir(ByVal sSonuc As String)
        baslik_kaydet_degistir_sonuc_toplu(satir_kontrol, sSonuc)
    End Sub
    Private Sub baslik_kaydet_degistir_toplu(ByVal nReyonFisiID As String, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal lFisNo As Int64, ByVal sMagaza As String, ByVal sSaticiRumuzu As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal nMusteriID As Int64, ByVal sMusteri As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sSonuc As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVReyonFisiMaster SET              dteFisTarihi = '" & dteFisTarihi & "', sFisTipi = '" & sFisTipi & "', lFisNo = " & lFisNo & ", sMagaza = '" & sMagaza & "', sSaticiRumuzu = '" & sSaticiRumuzu & "',lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", nMusteriID = " & nMusteriID & ", sMusteri = '" & sMusteri & "', sAciklama1 = '" & sAciklama1 & "',sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "', sSonuc = '" & sSonuc & "' Where nReyonFisiID IN " & nReyonFisiID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub baslik_kaydet_degistir_sonuc_toplu(ByVal nReyonFisiID As String, ByVal sSonuc As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVReyonFisiMaster SET              sSonuc = '" & sSonuc & "' Where nReyonFisiID IN " & nReyonFisiID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        tbMusteri_yeni()
    End Sub
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_Satici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        stok_odeme_detay_tumu()
    End Sub
    Friend WithEvents colsSec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Private Sub SimpleButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.ClearColumnsFilter()
            GridView1.Columns("sMusteri").FilterInfo = New ColumnFilterInfo("[sMusteri] LIKE '" & Trim(dr("sMusteri")) & "%'")
        End If
    End Sub
    Friend WithEvents colnIskontoYuzdesiAV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutari As DevExpress.XtraGrid.Columns.GridColumn
End Class
