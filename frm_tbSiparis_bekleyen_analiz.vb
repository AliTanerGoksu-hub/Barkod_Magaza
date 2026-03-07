Imports DevExpress.XtraEditors
Public Class frm_tbSiparis_bekleyen_analiz
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
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents txt_sSiparisVeren2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSiparisVeren1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sSiparisAlan2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSiparisAlan1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sSiparisTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteSiparisTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteSiparisTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_bKapandimi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbSiparis_bekleyen_analiz))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sSaticiRumuzu = New DevExpress.XtraEditors.LookUpEdit
        Me.sec_bKapandimi = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sSiparisTipi = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sSiparisVeren2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_sSiparisVeren1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sSiparisAlan2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_sSiparisAlan1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lFisNo2 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lFisNo1 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteSiparisTarihi2 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteSiparisTarihi1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.fieldnFirmaID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsFirmaKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsFirmaAciklama = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlSiparisNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fielddteSiparisTarihi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGun = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAy = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldYil = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHafta = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCeyrek = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlMiktari = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnStokID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsModel = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAciklama = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsRenk = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBeden = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsRenkAdi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBarkod = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlMevcut = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnSiparisID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlSevkiyat = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlKalan = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAciklama1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAciklama2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAciklama3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAciklama4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAciklama5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsFiyatTipi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnKdvOrani = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlFiyati = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlTutari = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnIskontoYuzdesi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlIskontosuzTutari = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fielddteTeslimTarihi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSiparisIslem = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldbKapandimi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSemt = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsIl = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsUlke = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFSnf1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFSnf2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFSnf3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFSnf4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFSnf5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf7 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf8 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf9 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSnf10 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlSevkiyatTutari = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlSiparisTutari = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSaticiRumuzu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DataSet1 = New System.Data.DataSet
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
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bKapandimi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSiparisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisVeren2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisVeren1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisAlan2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisAlan1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 176)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.sec_sSaticiRumuzu)
        Me.GroupControl1.Controls.Add(Me.sec_bKapandimi)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.sec_sSiparisTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisVeren2)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisVeren1)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisAlan2)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisAlan1)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_dteSiparisTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_dteSiparisTarihi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(726, 172)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl16.Location = New System.Drawing.Point(3, 116)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl16.TabIndex = 34
        Me.LabelControl16.Text = "Satýcý:"
        '
        'sec_sSaticiRumuzu
        '
        Me.sec_sSaticiRumuzu.Location = New System.Drawing.Point(71, 116)
        Me.sec_sSaticiRumuzu.Name = "sec_sSaticiRumuzu"
        Me.sec_sSaticiRumuzu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSaticiRumuzu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sSaticiRumuzu", "Rumuz"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sSatici", "Satici")})
        Me.sec_sSaticiRumuzu.Properties.DisplayMember = "sSatici"
        Me.sec_sSaticiRumuzu.Properties.NullText = "[Satici]"
        Me.sec_sSaticiRumuzu.Properties.ValueMember = "sSaticiRumuzu"
        Me.sec_sSaticiRumuzu.Size = New System.Drawing.Size(229, 20)
        Me.sec_sSaticiRumuzu.TabIndex = 9
        '
        'sec_bKapandimi
        '
        Me.sec_bKapandimi.Location = New System.Drawing.Point(385, 97)
        Me.sec_bKapandimi.Name = "sec_bKapandimi"
        Me.sec_bKapandimi.Properties.Caption = "Kapali"
        Me.sec_bKapandimi.Size = New System.Drawing.Size(75, 19)
        Me.sec_bKapandimi.TabIndex = 30
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Location = New System.Drawing.Point(302, 20)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl15.TabIndex = 29
        Me.LabelControl15.Text = "Eþittir"
        '
        'sec_sSiparisTipi
        '
        Me.sec_sSiparisTipi.Enabled = False
        Me.sec_sSiparisTipi.EnterMoveNextControl = True
        Me.sec_sSiparisTipi.Location = New System.Drawing.Point(71, 21)
        Me.sec_sSiparisTipi.Name = "sec_sSiparisTipi"
        Me.sec_sSiparisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSiparisTipi.Properties.DisplayMember = "sAciklama"
        Me.sec_sSiparisTipi.Properties.NullText = "[SiparisTipi]"
        Me.sec_sSiparisTipi.Properties.ValueMember = "nSiparisTipi"
        Me.sec_sSiparisTipi.Size = New System.Drawing.Size(229, 20)
        Me.sec_sSiparisTipi.TabIndex = 0
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl14.TabIndex = 28
        Me.LabelControl14.Text = "FiþTipi:"
        '
        'txt_sSiparisVeren2
        '
        Me.txt_sSiparisVeren2.EditValue = "zzzzzzzzzzzzzzzzzzzz"
        Me.txt_sSiparisVeren2.EnterMoveNextControl = True
        Me.txt_sSiparisVeren2.Location = New System.Drawing.Point(200, 97)
        Me.txt_sSiparisVeren2.Name = "txt_sSiparisVeren2"
        Me.txt_sSiparisVeren2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisVeren2.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisVeren2.Properties.MaxLength = 15
        Me.txt_sSiparisVeren2.Size = New System.Drawing.Size(100, 20)
        Me.txt_sSiparisVeren2.TabIndex = 8
        '
        'txt_sSiparisVeren1
        '
        Me.txt_sSiparisVeren1.EnterMoveNextControl = True
        Me.txt_sSiparisVeren1.Location = New System.Drawing.Point(71, 97)
        Me.txt_sSiparisVeren1.Name = "txt_sSiparisVeren1"
        Me.txt_sSiparisVeren1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisVeren1.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisVeren1.Properties.MaxLength = 15
        Me.txt_sSiparisVeren1.Size = New System.Drawing.Size(100, 20)
        Me.txt_sSiparisVeren1.TabIndex = 7
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(302, 98)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl11.TabIndex = 24
        Me.LabelControl11.Text = "Arasýndaki"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(174, 99)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(24, 15)
        Me.LabelControl12.TabIndex = 23
        Me.LabelControl12.Text = "ve"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Location = New System.Drawing.Point(5, 97)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl13.TabIndex = 22
        Me.LabelControl13.Text = "Siparis Veren:"
        '
        'txt_sSiparisAlan2
        '
        Me.txt_sSiparisAlan2.EditValue = "zzzzzzzzzzzzzzzzzzzz"
        Me.txt_sSiparisAlan2.EnterMoveNextControl = True
        Me.txt_sSiparisAlan2.Location = New System.Drawing.Point(200, 78)
        Me.txt_sSiparisAlan2.Name = "txt_sSiparisAlan2"
        Me.txt_sSiparisAlan2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisAlan2.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisAlan2.Properties.MaxLength = 15
        Me.txt_sSiparisAlan2.Size = New System.Drawing.Size(100, 20)
        Me.txt_sSiparisAlan2.TabIndex = 6
        '
        'txt_sSiparisAlan1
        '
        Me.txt_sSiparisAlan1.EnterMoveNextControl = True
        Me.txt_sSiparisAlan1.Location = New System.Drawing.Point(71, 78)
        Me.txt_sSiparisAlan1.Name = "txt_sSiparisAlan1"
        Me.txt_sSiparisAlan1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisAlan1.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisAlan1.Properties.MaxLength = 15
        Me.txt_sSiparisAlan1.Size = New System.Drawing.Size(100, 20)
        Me.txt_sSiparisAlan1.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(5, 135)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Hesap:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(302, 79)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Arasýndaki"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(174, 80)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(24, 15)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "ve"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(5, 78)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl9.TabIndex = 14
        Me.LabelControl9.Text = "Siparis Alan:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(302, 59)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasýndaki"
        '
        'txt_lFisNo2
        '
        Me.txt_lFisNo2.EditValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txt_lFisNo2.EnterMoveNextControl = True
        Me.txt_lFisNo2.Location = New System.Drawing.Point(200, 59)
        Me.txt_lFisNo2.Name = "txt_lFisNo2"
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lFisNo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo2.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(174, 59)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lFisNo1
        '
        Me.txt_lFisNo1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_lFisNo1.EnterMoveNextControl = True
        Me.txt_lFisNo1.Location = New System.Drawing.Point(71, 59)
        Me.txt_lFisNo1.Name = "txt_lFisNo1"
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lFisNo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo1.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(5, 59)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "FiþNo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(302, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Arasýndaki"
        '
        'txt_dteSiparisTarihi2
        '
        Me.txt_dteSiparisTarihi2.EditValue = Nothing
        Me.txt_dteSiparisTarihi2.EnterMoveNextControl = True
        Me.txt_dteSiparisTarihi2.Location = New System.Drawing.Point(200, 40)
        Me.txt_dteSiparisTarihi2.Name = "txt_dteSiparisTarihi2"
        Me.txt_dteSiparisTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteSiparisTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteSiparisTarihi2.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteSiparisTarihi2.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(174, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "ve"
        '
        'txt_dteSiparisTarihi1
        '
        Me.txt_dteSiparisTarihi1.EditValue = Nothing
        Me.txt_dteSiparisTarihi1.EnterMoveNextControl = True
        Me.txt_dteSiparisTarihi1.Location = New System.Drawing.Point(71, 40)
        Me.txt_dteSiparisTarihi1.Name = "txt_dteSiparisTarihi1"
        Me.txt_dteSiparisTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteSiparisTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteSiparisTarihi1.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteSiparisTarihi1.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(5, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tarih:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(200, 135)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adý"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 11
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(385, 135)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 13
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(302, 135)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 12
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(71, 135)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(130, 20)
        Me.txt_ara.TabIndex = 10
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.bar)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'bar
        '
        Me.bar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bar.Location = New System.Drawing.Point(2, 36)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(820, 10)
        Me.bar.TabIndex = 7
        Me.bar.Visible = False
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
        Me.SimpleButton2.Location = New System.Drawing.Point(743, 8)
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
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 176)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 205)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldnFirmaID, Me.fieldsFirmaKodu, Me.fieldsFirmaAciklama, Me.fieldlSiparisNo, Me.fielddteSiparisTarihi, Me.fieldGun, Me.fieldAy, Me.fieldYil, Me.fieldHafta, Me.fieldCeyrek, Me.fieldlMiktari, Me.fieldnStokID, Me.fieldsModel, Me.fieldsKodu, Me.fieldsAciklama, Me.fieldsRenk, Me.fieldsBeden, Me.fieldsRenkAdi, Me.fieldsBarkod, Me.fieldlMevcut, Me.fieldnSiparisID, Me.fieldlSevkiyat, Me.fieldlKalan, Me.fieldsAciklama1, Me.fieldsAciklama2, Me.fieldsAciklama3, Me.fieldsAciklama4, Me.fieldsAciklama5, Me.fieldsFiyatTipi, Me.fieldnKdvOrani, Me.fieldlFiyati, Me.fieldlTutari, Me.fieldnIskontoYuzdesi, Me.fieldlIskontosuzTutari, Me.fielddteTeslimTarihi, Me.fieldsSiparisIslem, Me.fieldbKapandimi, Me.fieldsSemt, Me.fieldsIl, Me.fieldsUlke, Me.fieldFSnf1, Me.fieldFSnf2, Me.fieldFSnf3, Me.fieldFSnf4, Me.fieldFSnf5, Me.fieldSSnf1, Me.fieldSSnf2, Me.fieldSSnf3, Me.fieldSSnf4, Me.fieldSSnf5, Me.fieldSSnf6, Me.fieldSSnf7, Me.fieldSSnf8, Me.fieldSSnf9, Me.fieldSSnf10, Me.fieldlSevkiyatTutari, Me.fieldlSiparisTutari, Me.fieldsSaticiRumuzu})
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.GridControl1.OptionsDataField.AreaIndex = 0
        Me.GridControl1.Size = New System.Drawing.Size(820, 201)
        Me.GridControl1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem13, Me.MenuItem14, Me.MenuItem18, Me.MenuItem29, Me.MenuItem27, Me.MenuItem28, Me.MenuItem15, Me.MenuItem23, Me.MenuItem24, Me.MenuItem26, Me.MenuItem25, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem18.Visible = False
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 4
        Me.MenuItem29.Text = "-"
        Me.MenuItem29.Visible = False
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 5
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlK
        Me.MenuItem27.Text = "Sipariþi Kapat"
        Me.MenuItem27.Visible = False
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 6
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItem28.Text = "Sipariþi Aç"
        Me.MenuItem28.Visible = False
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 7
        Me.MenuItem15.Text = "-"
        Me.MenuItem15.Visible = False
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 8
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem23.Text = "Stok Kartý"
        Me.MenuItem23.Visible = False
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 9
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem24.Text = "Stok Hareketleri"
        Me.MenuItem24.Visible = False
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 10
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem26.Text = "Stok Fiyatlandýr"
        Me.MenuItem26.Visible = False
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 11
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem25.Text = "Stok Envanter"
        Me.MenuItem25.Visible = False
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 12
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem19.Text = "Firma Kartý"
        Me.MenuItem19.Visible = False
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 13
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlF6
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        Me.MenuItem16.Visible = False
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 14
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem17.Text = "Firma Hareketleri"
        Me.MenuItem17.Visible = False
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 15
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 16
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 17
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 18
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 19
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 20
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 21
        Me.MenuItem22.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 22
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 23
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 24
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 25
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 26
        Me.MenuItem8.Text = "Satýrlarý Kapat"
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
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'fieldnFirmaID
        '
        Me.fieldnFirmaID.AreaIndex = 0
        Me.fieldnFirmaID.Caption = "Firma ID"
        Me.fieldnFirmaID.FieldName = "nFirmaID"
        Me.fieldnFirmaID.Name = "fieldnFirmaID"
        Me.fieldnFirmaID.Visible = False
        '
        'fieldsFirmaKodu
        '
        Me.fieldsFirmaKodu.AreaIndex = 0
        Me.fieldsFirmaKodu.Caption = "Firma Kodu"
        Me.fieldsFirmaKodu.FieldName = "sFirmaKodu"
        Me.fieldsFirmaKodu.Name = "fieldsFirmaKodu"
        Me.fieldsFirmaKodu.Visible = False
        '
        'fieldsFirmaAciklama
        '
        Me.fieldsFirmaAciklama.AreaIndex = 0
        Me.fieldsFirmaAciklama.Caption = "Firma Adý"
        Me.fieldsFirmaAciklama.FieldName = "sFirmaAciklama"
        Me.fieldsFirmaAciklama.Name = "fieldsFirmaAciklama"
        Me.fieldsFirmaAciklama.Visible = False
        '
        'fieldlSiparisNo
        '
        Me.fieldlSiparisNo.AreaIndex = 0
        Me.fieldlSiparisNo.Caption = "Sipariþ No"
        Me.fieldlSiparisNo.FieldName = "lSiparisNo"
        Me.fieldlSiparisNo.Name = "fieldlSiparisNo"
        Me.fieldlSiparisNo.Visible = False
        '
        'fielddteSiparisTarihi
        '
        Me.fielddteSiparisTarihi.AreaIndex = 0
        Me.fielddteSiparisTarihi.Caption = "Sipariþ Tarihi"
        Me.fielddteSiparisTarihi.FieldName = "dteSiparisTarihi"
        Me.fielddteSiparisTarihi.Name = "fielddteSiparisTarihi"
        Me.fielddteSiparisTarihi.Visible = False
        '
        'fieldGun
        '
        Me.fieldGun.AreaIndex = 0
        Me.fieldGun.Caption = "Gün"
        Me.fieldGun.FieldName = "Gun"
        Me.fieldGun.Name = "fieldGun"
        '
        'fieldAy
        '
        Me.fieldAy.AreaIndex = 1
        Me.fieldAy.Caption = "Ay"
        Me.fieldAy.FieldName = "Ay"
        Me.fieldAy.Name = "fieldAy"
        '
        'fieldYil
        '
        Me.fieldYil.AreaIndex = 2
        Me.fieldYil.Caption = "Yil"
        Me.fieldYil.FieldName = "Yil"
        Me.fieldYil.Name = "fieldYil"
        '
        'fieldHafta
        '
        Me.fieldHafta.AreaIndex = 3
        Me.fieldHafta.Caption = "Hafta"
        Me.fieldHafta.FieldName = "Hafta"
        Me.fieldHafta.Name = "fieldHafta"
        '
        'fieldCeyrek
        '
        Me.fieldCeyrek.AreaIndex = 4
        Me.fieldCeyrek.Caption = "Çeyrek"
        Me.fieldCeyrek.FieldName = "Ceyrek"
        Me.fieldCeyrek.Name = "fieldCeyrek"
        '
        'fieldlMiktari
        '
        Me.fieldlMiktari.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldlMiktari.AreaIndex = 0
        Me.fieldlMiktari.Caption = "Miktar"
        Me.fieldlMiktari.CellFormat.FormatString = "#,0.00##"
        Me.fieldlMiktari.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlMiktari.FieldName = "lMiktari"
        Me.fieldlMiktari.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlMiktari.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlMiktari.Name = "fieldlMiktari"
        '
        'fieldnStokID
        '
        Me.fieldnStokID.AreaIndex = 5
        Me.fieldnStokID.Caption = "Stok ID"
        Me.fieldnStokID.FieldName = "nStokID"
        Me.fieldnStokID.Name = "fieldnStokID"
        Me.fieldnStokID.Visible = False
        '
        'fieldsModel
        '
        Me.fieldsModel.AreaIndex = 5
        Me.fieldsModel.Caption = "Model"
        Me.fieldsModel.FieldName = "sModel"
        Me.fieldsModel.Name = "fieldsModel"
        Me.fieldsModel.Visible = False
        '
        'fieldsKodu
        '
        Me.fieldsKodu.AreaIndex = 12
        Me.fieldsKodu.Caption = "Stok Kodu"
        Me.fieldsKodu.FieldName = "sKodu"
        Me.fieldsKodu.Name = "fieldsKodu"
        Me.fieldsKodu.Visible = False
        '
        'fieldsAciklama
        '
        Me.fieldsAciklama.AreaIndex = 13
        Me.fieldsAciklama.Caption = "Stok Adý"
        Me.fieldsAciklama.FieldName = "sAciklama"
        Me.fieldsAciklama.Name = "fieldsAciklama"
        Me.fieldsAciklama.Visible = False
        '
        'fieldsRenk
        '
        Me.fieldsRenk.AreaIndex = 14
        Me.fieldsRenk.Caption = "Renk"
        Me.fieldsRenk.FieldName = "sRenk"
        Me.fieldsRenk.Name = "fieldsRenk"
        Me.fieldsRenk.Visible = False
        '
        'fieldsBeden
        '
        Me.fieldsBeden.AreaIndex = 15
        Me.fieldsBeden.Caption = "Beden"
        Me.fieldsBeden.FieldName = "sBeden"
        Me.fieldsBeden.Name = "fieldsBeden"
        Me.fieldsBeden.Visible = False
        '
        'fieldsRenkAdi
        '
        Me.fieldsRenkAdi.AreaIndex = 16
        Me.fieldsRenkAdi.Caption = "Renk Adý"
        Me.fieldsRenkAdi.FieldName = "sRenkAdi"
        Me.fieldsRenkAdi.Name = "fieldsRenkAdi"
        Me.fieldsRenkAdi.Visible = False
        '
        'fieldsBarkod
        '
        Me.fieldsBarkod.AreaIndex = 17
        Me.fieldsBarkod.Caption = "Barkod"
        Me.fieldsBarkod.FieldName = "sBarkod"
        Me.fieldsBarkod.Name = "fieldsBarkod"
        Me.fieldsBarkod.Visible = False
        '
        'fieldlMevcut
        '
        Me.fieldlMevcut.AreaIndex = 18
        Me.fieldlMevcut.Caption = "Mevcut"
        Me.fieldlMevcut.FieldName = "lMevcut"
        Me.fieldlMevcut.Name = "fieldlMevcut"
        Me.fieldlMevcut.Visible = False
        '
        'fieldnSiparisID
        '
        Me.fieldnSiparisID.AreaIndex = 19
        Me.fieldnSiparisID.Caption = "Sipariþ ID"
        Me.fieldnSiparisID.FieldName = "nSiparisID"
        Me.fieldnSiparisID.Name = "fieldnSiparisID"
        Me.fieldnSiparisID.Visible = False
        '
        'fieldlSevkiyat
        '
        Me.fieldlSevkiyat.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldlSevkiyat.AreaIndex = 1
        Me.fieldlSevkiyat.Caption = "Sevkiyat"
        Me.fieldlSevkiyat.CellFormat.FormatString = "#,0.00##"
        Me.fieldlSevkiyat.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlSevkiyat.FieldName = "lSevkiyat"
        Me.fieldlSevkiyat.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlSevkiyat.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlSevkiyat.Name = "fieldlSevkiyat"
        '
        'fieldlKalan
        '
        Me.fieldlKalan.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldlKalan.AreaIndex = 2
        Me.fieldlKalan.Caption = "Kalan"
        Me.fieldlKalan.CellFormat.FormatString = "#,0.00##"
        Me.fieldlKalan.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.FieldName = "lKalan"
        Me.fieldlKalan.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlKalan.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.Name = "fieldlKalan"
        '
        'fieldsAciklama1
        '
        Me.fieldsAciklama1.AreaIndex = 20
        Me.fieldsAciklama1.Caption = "Açýklama 1"
        Me.fieldsAciklama1.FieldName = "sAciklama1"
        Me.fieldsAciklama1.Name = "fieldsAciklama1"
        Me.fieldsAciklama1.Visible = False
        '
        'fieldsAciklama2
        '
        Me.fieldsAciklama2.AreaIndex = 21
        Me.fieldsAciklama2.Caption = "Açýklama 2"
        Me.fieldsAciklama2.FieldName = "sAciklama2"
        Me.fieldsAciklama2.Name = "fieldsAciklama2"
        Me.fieldsAciklama2.Visible = False
        '
        'fieldsAciklama3
        '
        Me.fieldsAciklama3.AreaIndex = 22
        Me.fieldsAciklama3.Caption = "Açýklama 3"
        Me.fieldsAciklama3.FieldName = "sAciklama3"
        Me.fieldsAciklama3.Name = "fieldsAciklama3"
        Me.fieldsAciklama3.Visible = False
        '
        'fieldsAciklama4
        '
        Me.fieldsAciklama4.AreaIndex = 23
        Me.fieldsAciklama4.Caption = "Açýklama 4"
        Me.fieldsAciklama4.FieldName = "sAciklama4"
        Me.fieldsAciklama4.Name = "fieldsAciklama4"
        Me.fieldsAciklama4.Visible = False
        '
        'fieldsAciklama5
        '
        Me.fieldsAciklama5.AreaIndex = 24
        Me.fieldsAciklama5.Caption = "Açýklama 5"
        Me.fieldsAciklama5.FieldName = "sAciklama5"
        Me.fieldsAciklama5.Name = "fieldsAciklama5"
        Me.fieldsAciklama5.Visible = False
        '
        'fieldsFiyatTipi
        '
        Me.fieldsFiyatTipi.AreaIndex = 25
        Me.fieldsFiyatTipi.Caption = "FiyatTipi"
        Me.fieldsFiyatTipi.FieldName = "sFiyatTipi"
        Me.fieldsFiyatTipi.Name = "fieldsFiyatTipi"
        Me.fieldsFiyatTipi.Visible = False
        '
        'fieldnKdvOrani
        '
        Me.fieldnKdvOrani.AreaIndex = 26
        Me.fieldnKdvOrani.Caption = "Kdv Oraný"
        Me.fieldnKdvOrani.FieldName = "nKdvOrani"
        Me.fieldnKdvOrani.Name = "fieldnKdvOrani"
        Me.fieldnKdvOrani.Visible = False
        '
        'fieldlFiyati
        '
        Me.fieldlFiyati.AreaIndex = 27
        Me.fieldlFiyati.Caption = "Fiyatý"
        Me.fieldlFiyati.CellFormat.FormatString = "#,0.00##"
        Me.fieldlFiyati.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlFiyati.FieldName = "lFiyati"
        Me.fieldlFiyati.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlFiyati.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlFiyati.Name = "fieldlFiyati"
        Me.fieldlFiyati.Visible = False
        '
        'fieldlTutari
        '
        Me.fieldlTutari.AreaIndex = 28
        Me.fieldlTutari.Caption = "Tutarý"
        Me.fieldlTutari.CellFormat.FormatString = "#,0.00##"
        Me.fieldlTutari.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTutari.FieldName = "lTutari"
        Me.fieldlTutari.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlTutari.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTutari.Name = "fieldlTutari"
        Me.fieldlTutari.Visible = False
        '
        'fieldnIskontoYuzdesi
        '
        Me.fieldnIskontoYuzdesi.AreaIndex = 29
        Me.fieldnIskontoYuzdesi.Caption = "Ýskonto Yüzdesi"
        Me.fieldnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.fieldnIskontoYuzdesi.Name = "fieldnIskontoYuzdesi"
        Me.fieldnIskontoYuzdesi.Visible = False
        '
        'fieldlIskontosuzTutari
        '
        Me.fieldlIskontosuzTutari.AreaIndex = 30
        Me.fieldlIskontosuzTutari.Caption = "Ýskontosuz Tutarý"
        Me.fieldlIskontosuzTutari.FieldName = "lIskontosuzTutari"
        Me.fieldlIskontosuzTutari.Name = "fieldlIskontosuzTutari"
        Me.fieldlIskontosuzTutari.Visible = False
        '
        'fielddteTeslimTarihi
        '
        Me.fielddteTeslimTarihi.AreaIndex = 31
        Me.fielddteTeslimTarihi.Caption = "Teslim Tarihi"
        Me.fielddteTeslimTarihi.FieldName = "dteTeslimTarihi"
        Me.fielddteTeslimTarihi.Name = "fielddteTeslimTarihi"
        Me.fielddteTeslimTarihi.Visible = False
        '
        'fieldsSiparisIslem
        '
        Me.fieldsSiparisIslem.AreaIndex = 32
        Me.fieldsSiparisIslem.Caption = "Sipariþ Ýþlem"
        Me.fieldsSiparisIslem.FieldName = "sSiparisIslem"
        Me.fieldsSiparisIslem.Name = "fieldsSiparisIslem"
        Me.fieldsSiparisIslem.Visible = False
        '
        'fieldbKapandimi
        '
        Me.fieldbKapandimi.AreaIndex = 32
        Me.fieldbKapandimi.Caption = "Kapandimi"
        Me.fieldbKapandimi.FieldName = "bKapandimi"
        Me.fieldbKapandimi.Name = "fieldbKapandimi"
        Me.fieldbKapandimi.Visible = False
        '
        'fieldsSemt
        '
        Me.fieldsSemt.AreaIndex = 32
        Me.fieldsSemt.Caption = "Semt"
        Me.fieldsSemt.FieldName = "sSemt"
        Me.fieldsSemt.Name = "fieldsSemt"
        Me.fieldsSemt.Visible = False
        '
        'fieldsIl
        '
        Me.fieldsIl.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsIl.AreaIndex = 0
        Me.fieldsIl.Caption = "il"
        Me.fieldsIl.FieldName = "sIl"
        Me.fieldsIl.Name = "fieldsIl"
        '
        'fieldsUlke
        '
        Me.fieldsUlke.AreaIndex = 32
        Me.fieldsUlke.Caption = "Ulke"
        Me.fieldsUlke.FieldName = "sUlke"
        Me.fieldsUlke.Name = "fieldsUlke"
        Me.fieldsUlke.Visible = False
        '
        'fieldFSnf1
        '
        Me.fieldFSnf1.AreaIndex = 31
        Me.fieldFSnf1.Caption = "Firma Sýnýf 1"
        Me.fieldFSnf1.FieldName = "FSýnýf1"
        Me.fieldFSnf1.Name = "fieldFSnf1"
        Me.fieldFSnf1.Visible = False
        '
        'fieldFSnf2
        '
        Me.fieldFSnf2.AreaIndex = 31
        Me.fieldFSnf2.Caption = "Firma Sýnýf 2"
        Me.fieldFSnf2.FieldName = "FSýnýf2"
        Me.fieldFSnf2.Name = "fieldFSnf2"
        Me.fieldFSnf2.Visible = False
        '
        'fieldFSnf3
        '
        Me.fieldFSnf3.AreaIndex = 31
        Me.fieldFSnf3.Caption = "Firma Sýnýf 3"
        Me.fieldFSnf3.FieldName = "FSýnýf3"
        Me.fieldFSnf3.Name = "fieldFSnf3"
        Me.fieldFSnf3.Visible = False
        '
        'fieldFSnf4
        '
        Me.fieldFSnf4.AreaIndex = 31
        Me.fieldFSnf4.Caption = "Firma Sýnýf 4"
        Me.fieldFSnf4.FieldName = "FSýnýf4"
        Me.fieldFSnf4.Name = "fieldFSnf4"
        Me.fieldFSnf4.Visible = False
        '
        'fieldFSnf5
        '
        Me.fieldFSnf5.AreaIndex = 31
        Me.fieldFSnf5.Caption = "Firma Sýnýf 5"
        Me.fieldFSnf5.FieldName = "FSýnýf5"
        Me.fieldFSnf5.Name = "fieldFSnf5"
        Me.fieldFSnf5.Visible = False
        '
        'fieldSSnf1
        '
        Me.fieldSSnf1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSSnf1.AreaIndex = 1
        Me.fieldSSnf1.Caption = "Stok Sýnýf 1"
        Me.fieldSSnf1.FieldName = "SSýnýf1"
        Me.fieldSSnf1.Name = "fieldSSnf1"
        '
        'fieldSSnf2
        '
        Me.fieldSSnf2.AreaIndex = 31
        Me.fieldSSnf2.Caption = "Stok Sýnýf 2"
        Me.fieldSSnf2.FieldName = "SSýnýf2"
        Me.fieldSSnf2.Name = "fieldSSnf2"
        Me.fieldSSnf2.Visible = False
        '
        'fieldSSnf3
        '
        Me.fieldSSnf3.AreaIndex = 31
        Me.fieldSSnf3.Caption = "Stok Sýnýf 3"
        Me.fieldSSnf3.FieldName = "SSýnýf3"
        Me.fieldSSnf3.Name = "fieldSSnf3"
        Me.fieldSSnf3.Visible = False
        '
        'fieldSSnf4
        '
        Me.fieldSSnf4.AreaIndex = 43
        Me.fieldSSnf4.Caption = "Stok Sýnýf 4"
        Me.fieldSSnf4.FieldName = "SSýnýf4"
        Me.fieldSSnf4.Name = "fieldSSnf4"
        Me.fieldSSnf4.Visible = False
        '
        'fieldSSnf5
        '
        Me.fieldSSnf5.AreaIndex = 44
        Me.fieldSSnf5.Caption = "Stok Sýnýf 5"
        Me.fieldSSnf5.FieldName = "SSýnýf5"
        Me.fieldSSnf5.Name = "fieldSSnf5"
        Me.fieldSSnf5.Visible = False
        '
        'fieldSSnf6
        '
        Me.fieldSSnf6.AreaIndex = 45
        Me.fieldSSnf6.Caption = "Stok Sýnýf 6"
        Me.fieldSSnf6.FieldName = "SSýnýf6"
        Me.fieldSSnf6.Name = "fieldSSnf6"
        Me.fieldSSnf6.Visible = False
        '
        'fieldSSnf7
        '
        Me.fieldSSnf7.AreaIndex = 46
        Me.fieldSSnf7.Caption = "Stok Sýnýf 7"
        Me.fieldSSnf7.FieldName = "SSýnýf7"
        Me.fieldSSnf7.Name = "fieldSSnf7"
        Me.fieldSSnf7.Visible = False
        '
        'fieldSSnf8
        '
        Me.fieldSSnf8.AreaIndex = 47
        Me.fieldSSnf8.Caption = "Stok Sýnýf 8"
        Me.fieldSSnf8.FieldName = "SSýnýf8"
        Me.fieldSSnf8.Name = "fieldSSnf8"
        Me.fieldSSnf8.Visible = False
        '
        'fieldSSnf9
        '
        Me.fieldSSnf9.AreaIndex = 48
        Me.fieldSSnf9.Caption = "Stok Sýnýf 9"
        Me.fieldSSnf9.FieldName = "SSýnýf9"
        Me.fieldSSnf9.Name = "fieldSSnf9"
        Me.fieldSSnf9.Visible = False
        '
        'fieldSSnf10
        '
        Me.fieldSSnf10.AreaIndex = 49
        Me.fieldSSnf10.Caption = "Stok Sýnýf 10"
        Me.fieldSSnf10.FieldName = "SSýnýf10"
        Me.fieldSSnf10.Name = "fieldSSnf10"
        Me.fieldSSnf10.Visible = False
        '
        'fieldlSevkiyatTutari
        '
        Me.fieldlSevkiyatTutari.AreaIndex = 50
        Me.fieldlSevkiyatTutari.Caption = "Sevkiyat Tutarý"
        Me.fieldlSevkiyatTutari.CellFormat.FormatString = "#,0.00##"
        Me.fieldlSevkiyatTutari.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlSevkiyatTutari.FieldName = "lSevkiyatTutari"
        Me.fieldlSevkiyatTutari.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlSevkiyatTutari.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlSevkiyatTutari.Name = "fieldlSevkiyatTutari"
        Me.fieldlSevkiyatTutari.Visible = False
        '
        'fieldlSiparisTutari
        '
        Me.fieldlSiparisTutari.AreaIndex = 51
        Me.fieldlSiparisTutari.Caption = "Sipariþ Tutarý"
        Me.fieldlSiparisTutari.CellFormat.FormatString = "#,0.00##"
        Me.fieldlSiparisTutari.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlSiparisTutari.FieldName = "lSiparisTutari"
        Me.fieldlSiparisTutari.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlSiparisTutari.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlSiparisTutari.Name = "fieldlSiparisTutari"
        Me.fieldlSiparisTutari.Visible = False
        '
        'fieldsSaticiRumuzu
        '
        Me.fieldsSaticiRumuzu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsSaticiRumuzu.AreaIndex = 0
        Me.fieldsSaticiRumuzu.Caption = "Satici"
        Me.fieldsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.fieldsSaticiRumuzu.Name = "fieldsSaticiRumuzu"
        Me.fieldsSaticiRumuzu.Visible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sFirmaKodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sFirmaAciklama"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lSiparisNo"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dteSiparisTarihi"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Gun"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Ay"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Yil"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Hafta"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Ceyrek"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lMiktari"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "nStokID"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sModel"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sKodu"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sAciklama"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sRenk"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sBeden"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sRenkAdi"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sBarkod"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "lMevcut"
        Me.DataColumn20.DataType = GetType(Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "nSiparisID"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "lSevkiyat"
        Me.DataColumn22.DataType = GetType(Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "lKalan"
        Me.DataColumn23.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sAciklama1"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sAciklama2"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sAciklama3"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sAciklama4"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sAciklama5"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sFiyatTipi"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "nKdvOrani"
        Me.DataColumn30.DataType = GetType(Short)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "lFiyati"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "lTutari"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nIskontoYuzdesi"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "lIskontosuzTutari"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "dteTeslimTarihi"
        Me.DataColumn35.DataType = GetType(Date)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sSiparisIslem"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "bKapandimi"
        Me.DataColumn37.DataType = GetType(Boolean)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sSemt"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "sIl"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sUlke"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "FSýnýf1"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "FSýnýf2"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "FSýnýf3"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "FSýnýf4"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "FSýnýf5"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "SSýnýf1"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "SSýnýf2"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "SSýnýf3"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "SSýnýf4"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "SSýnýf5"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "SSýnýf6"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "SSýnýf7"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "SSýnýf8"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "SSýnýf9"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "SSýnýf10"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "lSevkiyatTutari"
        Me.DataColumn56.DataType = GetType(Decimal)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "lSiparisTutari"
        Me.DataColumn57.DataType = GetType(Decimal)
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Sipariþ Bekleyenleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Sipariþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_tbSiparis_bekleyen_analiz
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbSiparis_bekleyen_analiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sipariþ Analizleri..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bKapandimi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSiparisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisVeren2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisVeren1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisAlan2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisAlan1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim ds_tbSiparisTipi As DataSet
    Dim ds_Satici As DataSet
    Public islemstatus As Boolean = False
    Public nSiparisTipi As String
    Public sFirmaKodu As String = ""
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridControl1.FieldsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        'GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'GridView1.OptionsView.ShowGroupPanel = True
        'GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridControl1.ExpandAllRows()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridControl1.CollapseAllRows()
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
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub dataload_tbHareketTipi(ByVal nSiparisTipi As String)
        ds_tbSiparisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nSiparisTipi,sAciklama FROM         tbSiparisTipi Where nSiparisTipi  ='" & nSiparisTipi & "'"))
        sec_sSiparisTipi.Properties.DataSource = ds_tbSiparisTipi.Tables(0)
        sec_sSiparisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_satici()
        ds_Satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici  FROM         tbSatici where bAktif =1"))
        sec_sSaticiRumuzu.Properties.DataSource = ds_Satici.Tables(0)
    End Sub
    Private Sub gorunum_kaydet()
        GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\tbSiparisBekleyen\" & Me.Name.ToString)
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        'GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        For Each clmn As DevExpress.XtraPivotGrid.PivotGridField In GridControl1.Fields
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\tbSiparisBekleyen\" & Me.Name.ToString)
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
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal nSiparisTipi As String, ByVal dteSiparisTarihi1 As DateTime, ByVal dteSiparisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal sSiparisAlan1 As String, ByVal sSiparisAlan2 As String, ByVal sSiparisVeren1 As String, ByVal sSiparisVeren2 As String, ByVal bKapandimi As Boolean, ByVal sSaticiRumuzu As String) As DataSet
        Dim kriter As String = ""
        Dim kriter_kapali = ""
        Dim having = ""
        If CStr(Trim(ara.ToString)) <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND   (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND  (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        If Trim(sSaticiRumuzu) <> "" Then
            kriter += " AND tbSiparis.sSaticiRumuzu ='" & sSaticiRumuzu & "' "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, SUM(tbSiparis.lMiktari) AS lMiktari, SUM(tbSiparis.lTutari) AS lTutari, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, SUM(ROUND(tbSiparis.lTutari * (1 + tbKdv.nKdvOrani * .01), 2)) AS lKdvTutari, SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) AS sSiparisiAlan, SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) AS sSiparisiVeren FROM tbStok INNER JOIN tbSiparis INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbSiparis.nStokID INNER JOIN tbKdv ON tbStok.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo WHERE (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & "  GROUP BY tbSiparis.dteSiparisTarihi, tbSiparis.lSiparisNo, tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5, tbSiparis.sSiparisiAlan ORDER BY tbSiparis.dteSiparisTarihi, tbSiparis.lSiparisNo, tbFirma.sKodu")
        If nSiparisTipi = 1 Then
            If bKapandimi = False Then
                having = " HAVING      (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)"
                kriter_kapali = " tbSiparis.bKapandimi=0 "
            Else
                kriter_kapali = " tbSiparis.bKapandimi=1 "
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi,DAY(tbSiparis.dteSiparisTarihi) AS Gun, MONTH(tbSiparis.dteSiparisTarihi) AS Ay, YEAR(tbSiparis.dteSiparisTarihi) AS Yil, { fn WEEK(tbSiparis.dteSiparisTarihi) } AS Hafta, { fn QUARTER(tbSiparis.dteSiparisTarihi) } AS Ceyrek, tbSiparis.lMiktari, tbStok.nStokID,tbStok.sModel,tbStok.sKodu, tbStok.sAciklama,tbStok.sRenk,tbStok.sBeden,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut,tbSiparis.nSiparisID, ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lSevkiyat,ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lKalan, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, tbSiparis.sFiyatTipi, tbSiparis.sSaticiRumuzu,tbSiparis.nKdvOrani, tbSiparis.lFiyati * (100 + tbSiparis.nKdvOrani) / 100 as lFiyati, (tbSiparis.lTutari/tbSiparis.lMiktari)* (tbSiparis.lMiktari-ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0)) * (100 + tbSiparis.nKdvOrani) / 100 as lTutari,(tbSiparis.lTutari/tbSiparis.lMiktari)* (tbSiparis.lMiktari) * (100 + tbSiparis.nKdvOrani) / 100 as lSiparisTutari,(tbSiparis.lTutari/tbSiparis.lMiktari)* (ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0)) * (100 + tbSiparis.nKdvOrani) / 100 as lSevkiyatTutari, tbSiparis.nIskontoYuzdesi, ISNULL((tbSiparis.lIskontosuzTutari/tbSiparis.lMiktari),1) * (tbSiparis.lMiktari-ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0)) * (100 + tbSiparis.nKdvOrani) / 100 as lIskontosuzTutari, tbSiparis.dteTeslimTarihi, (SELECT MAX(SipIslem.sSiparisIslem + ' ' + rtrim(tbSiparisIslem.sAciklama)) FROM tbSiparisIslem , tbSiparis SipIslem WHERE tbSiparisIslem.sSiparisIslem = SipIslem.sSiparisIslem AND SipIslem.lSiparisNo = tbSiparis.lSiparisNo AND SipIslem.nFirmaID = tbSiparis.nFirmaID AND SipIslem.nSiparisTipi = tbSiparis.nSiparisTipi) AS sSipIslem, tbSiparis.bKapandimi,tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFSinif1.sAciklama AS FSýnýf1, tbFSinif2.sAciklama AS FSýnýf2, tbFSinif3.sAciklama AS FSýnýf3, tbFSinif4.sAciklama AS FSýnýf4, tbFSinif5.sAciklama AS FSýnýf5, tbSSinif1.sAciklama AS SSýnýf1, tbSSinif2.sAciklama AS SSýnýf2, tbSSinif3.sAciklama AS SSýnýf3, tbSSinif4.sAciklama AS SSýnýf4, tbSSinif5.sAciklama AS SSýnýf5, tbSSinif6.sAciklama AS SSýnýf6, tbSSinif7.sAciklama AS SSýnýf7, tbSSinif8.sAciklama AS SSýnýf8, tbSSinif9.sAciklama AS SSýnýf9, tbSSinif10.sAciklama AS SSýnýf10 FROM tbFSinif1 INNER JOIN tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo WHERE " & kriter_kapali & " AND (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & " GROUP BY tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbStok.nStokID,tbStok.sAciklama, tbStok.sModel,tbStok.sKodu,tbStok.sRenk,tbStok.sBeden, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.bKapandimi, tbSiparis.sFiyatTipi, tbSiparis.sSaticiRumuzu,tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari, tbSiparis.dteTeslimTarihi, tbSiparis.nFirmaID, tbSiparis.nSiparisTipi, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5,tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFSinif1.sAciklama, tbFSinif2.sAciklama, tbFSinif3.sAciklama, tbFSinif4.sAciklama, tbFSinif5.sAciklama, tbSSinif1.sAciklama, tbSSinif2.sAciklama, tbSSinif3.sAciklama, tbSSinif4.sAciklama, tbSSinif5.sAciklama, tbSSinif6.sAciklama, tbSSinif7.sAciklama, tbSSinif8.sAciklama, tbSSinif9.sAciklama, tbSSinif10.sAciklama  " & having & " ORDER BY tbFirma.sKodu, tbSiparis.dteSiparisTarihi, tbStok.sKodu")
        ElseIf nSiparisTipi = 2 Then
            If bKapandimi = False Then
                having = " HAVING      (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)"
                kriter_kapali = " tbSiparis.bKapandimi=0 "
            Else
                kriter_kapali = " tbSiparis.bKapandimi=1 "
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi,DAY(tbSiparis.dteSiparisTarihi) AS Gun, MONTH(tbSiparis.dteSiparisTarihi) AS Ay, YEAR(tbSiparis.dteSiparisTarihi) AS Yil, { fn WEEK(tbSiparis.dteSiparisTarihi) } AS Hafta, { fn QUARTER(tbSiparis.dteSiparisTarihi) } AS Ceyrek, tbSiparis.lMiktari, tbStok.nStokID,tbStok.sModel,tbStok.sKodu, tbStok.sAciklama,tbStok.sRenk,tbStok.sBeden,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut,tbSiparis.nSiparisID, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0) AS lSevkiyat,ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0) AS lKalan, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, tbSiparis.sFiyatTipi, tbSiparis.sSaticiRumuzu,tbSiparis.nKdvOrani, tbSiparis.lFiyati * (100 + tbSiparis.nKdvOrani) / 100 as lFiyati, (tbSiparis.lTutari/tbSiparis.lMiktari)* (tbSiparis.lMiktari-ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0)) * (100 + tbSiparis.nKdvOrani) / 100 as lTutari, (tbSiparis.lTutari/tbSiparis.lMiktari)* (tbSiparis.lMiktari) * (100 + tbSiparis.nKdvOrani) / 100 as lSiparisTutari,(tbSiparis.lTutari/tbSiparis.lMiktari)* (ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0)) * (100 + tbSiparis.nKdvOrani) / 100 as lSevkiyatTutari, tbSiparis.nIskontoYuzdesi, ISNULL((tbSiparis.lIskontosuzTutari/tbSiparis.lMiktari),1) * (tbSiparis.lMiktari-ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0)) * (100 + tbSiparis.nKdvOrani) / 100 as lIskontosuzTutari, tbSiparis.dteTeslimTarihi, (SELECT MAX(SipIslem.sSiparisIslem + ' ' + rtrim(tbSiparisIslem.sAciklama)) FROM tbSiparisIslem , tbSiparis SipIslem WHERE tbSiparisIslem.sSiparisIslem = SipIslem.sSiparisIslem AND SipIslem.lSiparisNo = tbSiparis.lSiparisNo AND SipIslem.nFirmaID = tbSiparis.nFirmaID AND SipIslem.nSiparisTipi = tbSiparis.nSiparisTipi) AS sSipIslem, tbSiparis.bKapandimi,tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFSinif1.sAciklama AS FSýnýf1, tbFSinif2.sAciklama AS FSýnýf2, tbFSinif3.sAciklama AS FSýnýf3, tbFSinif4.sAciklama AS FSýnýf4, tbFSinif5.sAciklama AS FSýnýf5, tbSSinif1.sAciklama AS SSýnýf1, tbSSinif2.sAciklama AS SSýnýf2, tbSSinif3.sAciklama AS SSýnýf3, tbSSinif4.sAciklama AS SSýnýf4, tbSSinif5.sAciklama AS SSýnýf5, tbSSinif6.sAciklama AS SSýnýf6, tbSSinif7.sAciklama AS SSýnýf7, tbSSinif8.sAciklama AS SSýnýf8, tbSSinif9.sAciklama AS SSýnýf9, tbSSinif10.sAciklama AS SSýnýf10 FROM tbFSinif1 INNER JOIN tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo WHERE " & kriter_kapali & " AND (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & " GROUP BY tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbStok.nStokID,tbStok.sAciklama, tbStok.sModel,tbStok.sKodu, tbStok.sRenk,tbStok.sBeden, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.bKapandimi, tbSiparis.sFiyatTipi, tbSiparis.sSaticiRumuzu,tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari, tbSiparis.dteTeslimTarihi, tbSiparis.nFirmaID, tbSiparis.nSiparisTipi, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5,tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFSinif1.sAciklama, tbFSinif2.sAciklama, tbFSinif3.sAciklama, tbFSinif4.sAciklama, tbFSinif5.sAciklama, tbSSinif1.sAciklama, tbSSinif2.sAciklama, tbSSinif3.sAciklama, tbSSinif4.sAciklama, tbSSinif5.sAciklama, tbSSinif6.sAciklama, tbSSinif7.sAciklama, tbSSinif8.sAciklama, tbSSinif9.sAciklama, tbSSinif10.sAciklama " & having & " ORDER BY tbFirma.sKodu, tbSiparis.dteSiparisTarihi, tbStok.sKodu")
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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal nSiparisTipi As String, ByVal dteSiparisTarihi1 As DateTime, ByVal dteSiparisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal sSiparisAlan1 As String, ByVal sSiparisAlan2 As String, ByVal sSiparisVeren1 As String, ByVal sSiparisVeren2 As String, ByVal bKapandimi As Boolean, ByVal sSaticiRumuzu As String)
        DataSet1 = stok(ara, konum, ara_kriter, nSiparisTipi, dteSiparisTarihi1, dteSiparisTarihi2, lFisNo1, lFisNo2, sSiparisAlan1, sSiparisAlan2, sSiparisVeren1, sSiparisVeren2, bKapandimi, sSaticiRumuzu)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub analiz_Firma_karti()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_firma_kart
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.sKodu = dr("sFirmaKodu")
        '    frm.nFirmaID = dr("nFirmaID")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_fis()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_tbSiparis
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.dteSiparisTarihi = dr("dteSiparisTarihi")
        '    frm.lSiparisNo = dr("lSiparisNo")
        '    frm.nFirmaID = dr("nFirmaID")
        '    'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
        '    'frm.txt_SiparisAlan.EditValue = dr("sSiparisiAlan")
        '    'frm.txt_SiparisVeren.EditValue = dr("sSiparisiVeren")
        '    frm.nSiparisTipi = sec_sSiparisTipi.EditValue
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_cari_hareket()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_hareketler_ozet
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("sFirmaKodu")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_faturalar_acik_analiz
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("nMusteriID")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_acik_faturalar()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_faturalar_acik
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("nMusteriID")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_iletisim()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_firma_iletisim
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("nFirmaID")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_musteri_satislar()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_faturalar_kapatma
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("lKodu")
        '    frm.musteriID = dr("nMusteriID")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_ekstre
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("lKodu")
        '    frm.musteriID = dr("nMusteriID")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_stok_karti()
        'If GridView1.RowCount > 0 Then
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_kart
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.nStokID = dr("nStokId")
        '    frm.sKodu = dr("sKodu")
        '    frm.sModel = dr("sModel")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub stok_fiyat()
        'If GridView1.RowCount > 0 Then
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_fiyatlandir
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.nStokID = dr("nStokId")
        '    frm.sModel = dr("sModel")
        '    frm.sKodu = dr("sKodu")
        '    frm.sRenk = dr("sRenk")
        '    frm.sBeden = dr("sBeden")
        '    frm.txt_musteriNo.Text = dr("sModel")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_stok_hareket()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_hareketleri
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("sKodu")
        '    frm.nFirmaID = 0
        '    frm.sec_firma.Checked = False
        '    frm.sec_giris.Text = "Çýkýþlar"
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_envanter()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_envanter
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.stokno = dr("nStokId")
        '    frm.stokkodu = dr("sKodu")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sSiparisTipi.EditValue, txt_dteSiparisTarihi1.EditValue, txt_dteSiparisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_sSiparisAlan1.EditValue, txt_sSiparisAlan2.EditValue, txt_sSiparisVeren1.EditValue, txt_sSiparisVeren2.EditValue, sec_bKapandimi.Checked, sec_sSaticiRumuzu.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
        'If GridView1.SelectedRowsCount > 1 Then
        '    Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        'Else
        '    Label2.Text = ""
        'End If
        'Try
        '    If GridView1.RowCount > 0 Then
        '        Dim dr As DataRow
        '        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '        lbl_istihbarat.Text = dr("sAciklama1").ToString + " " + dr("sAciklama2").ToString + " " + dr("sAciklama3").ToString + " " + dr("sAciklama4").ToString + " " + dr("sAciklama5").ToString
        '        dr = Nothing
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            'If GridView1.RowCount > 0 Then
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            'Else
            '    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
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
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                'If GridView1.RowCount > 0 Then
                '    Me.DialogResult = Windows.Forms.DialogResult.OK
                'Else
                '    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
            Else
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_fis()
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_tbHareketTipi(nSiparisTipi)
        dataload_satici()
        txt_dteSiparisTarihi1.EditValue = dteSistemTarihi
        txt_dteSiparisTarihi2.EditValue = dteSistemTarihi
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        If Trim(txt_ara.Text.ToString) <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        'ara()
        'txt_dteFisTarihi1.Focus()
        'txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteSiparisTarihi1.Focus()
        txt_dteSiparisTarihi1.Select()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        'If MenuItem22.Checked = False Then
        '    GridView1.OptionsView.ShowAutoFilterRow = True
        '    GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        '    GridView1.OptionsCustomization.AllowFilter = True
        '    MenuItem22.Checked = True
        'ElseIf MenuItem22.Checked = True Then
        '    GridView1.OptionsView.ShowAutoFilterRow = False
        '    GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '    GridView1.OptionsCustomization.AllowFilter = False
        '    MenuItem22.Checked = True
        'End If
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_stok_karti()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        analiz_envanter()
    End Sub
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Private Sub tbSiparis_degistir(ByVal nSiparisID As String, ByVal bkapandimi As Integer, Optional ByVal uyari As Boolean = True)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparis SET              bKapandimi =" & bkapandimi & "  Where nSiparisID =" & nSiparisID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sModel,'') as sModel FROM         tbStok WHERE     (sModel < '" & sModel & "' ) ORDER BY sModel DESC ")
            'sModel = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sModel
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Degistirildi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'stok_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Islem Hatasý Lutfen tekrar Deneyinizi...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub satir_degistir(Optional ByVal kapali As Boolean = False)
        'If GridView1.RowCount > 0 Then
        '    If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question, sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
        '        Dim s As String
        '        Dim arr As Integer()
        '        Dim i As Integer
        '        Dim toplamsayi = GridView1.SelectedRowsCount
        '        Dim sayi = 0
        '        arr = GridView1.GetSelectedRows()
        '        Dim dr1 As DataRow
        '        If arr Is Nothing Then
        '        Else
        '            Array.Sort(arr)
        '            bar.Properties.Maximum = GridView1.SelectedRowsCount
        '            'panelstatus.Visible = True
        '            bar.Visible = True
        '            bar.Position = 0
        '            For Each i In arr
        '                s = i.ToString
        '                dr1 = GridView1.GetDataRow(s)
        '                tbSiparis_degistir(dr1("nSiparisID"), kapali, False)
        '                bar.Position += 1
        '                bar.Refresh()
        '            Next
        '            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
        '            dr = Nothing
        '            'panelstatus.Visible = False
        '            bar.Visible = False
        '        End If
        '        dr1 = Nothing
        '        ara()
        '    End If
        'End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        satir_degistir(True)
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        satir_degistir(False)
    End Sub
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
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
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents fieldnFirmaID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsFirmaKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsFirmaAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlSiparisNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteSiparisTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGun As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYil As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHafta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCeyrek As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlMiktari As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnStokID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsModel As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsRenk As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBeden As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsRenkAdi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBarkod As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlMevcut As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnSiparisID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlSevkiyat As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlKalan As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsFiyatTipi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnKdvOrani As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlFiyati As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlTutari As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnIskontoYuzdesi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlIskontosuzTutari As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteTeslimTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSiparisIslem As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldbKapandimi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSemt As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsIl As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsUlke As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFSnf1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFSnf2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFSnf3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFSnf4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFSnf5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSnf10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlSevkiyatTutari As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlSiparisTutari As DevExpress.XtraPivotGrid.PivotGridField
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Friend WithEvents fieldsSaticiRumuzu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sSaticiRumuzu As DevExpress.XtraEditors.LookUpEdit
End Class
