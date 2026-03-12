Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_firma_liste_yaslandirma
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
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_islem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_bakiye As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents GridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
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
    Friend WithEvents fieldnFirmaID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSINIF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSINIF2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSINIF3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSINIF4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSINIF5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlBakiye As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCekRisk As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSenetRisk As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsUlke As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsIl As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSemt As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSaticiRumuzu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnGecikme As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlKalan As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsYil As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsHafta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsGun As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlVadeFarki As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sec_sdepo As DevExpress.XtraEditors.PopupContainerEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_firma_liste_yaslandirma))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txt_nVadeFarki = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nGun2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_nGun1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txt_limit2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_limit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sSatici = New DevExpress.XtraEditors.PopupContainerEdit
        Me.sec_islem = New DevExpress.XtraEditors.ComboBoxEdit
        Me.sec_bakiye = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldnFirmaID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAciklama = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSINIF1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSINIF2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSINIF3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSINIF4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSINIF5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlBakiye = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCekRisk = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSenetRisk = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsUlke = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsIl = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSemt = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSaticiRumuzu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnGecikme = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlKalan = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsYil = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAy = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsHafta = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsGun = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlVadeFarki = New DevExpress.XtraPivotGrid.PivotGridField
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
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
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.sec_sdepo = New DevExpress.XtraEditors.PopupContainerEdit
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sdepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 151)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_sdepo)
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
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(381, 147)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'txt_nVadeFarki
        '
        Me.txt_nVadeFarki.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nVadeFarki.EnterMoveNextControl = True
        Me.txt_nVadeFarki.Location = New System.Drawing.Point(230, 109)
        Me.txt_nVadeFarki.Name = "txt_nVadeFarki"
        Me.txt_nVadeFarki.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_nVadeFarki.Size = New System.Drawing.Size(62, 20)
        Me.txt_nVadeFarki.TabIndex = 12
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(163, 113)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl10.TabIndex = 29
        Me.LabelControl10.Text = "VadeFarki:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(102, 113)
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
        Me.LabelControl9.Location = New System.Drawing.Point(16, 109)
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
        Me.txt_limit2.Location = New System.Drawing.Point(191, 87)
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
        Me.LabelControl6.Location = New System.Drawing.Point(14, 87)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "Limit:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(9, 65)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Kriter:"
        '
        'sec_sSatici
        '
        Me.sec_sSatici.EditValue = "[Tümü]"
        Me.sec_sSatici.EnterMoveNextControl = True
        Me.sec_sSatici.Location = New System.Drawing.Point(191, 65)
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.Properties.ShowPopupCloseButton = False
        Me.sec_sSatici.Size = New System.Drawing.Size(101, 20)
        Me.sec_sSatici.TabIndex = 7
        '
        'sec_islem
        '
        Me.sec_islem.EditValue = "Detaylý"
        Me.sec_islem.EnterMoveNextControl = True
        Me.sec_islem.Location = New System.Drawing.Point(130, 65)
        Me.sec_islem.Name = "sec_islem"
        Me.sec_islem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_islem.Properties.Items.AddRange(New Object() {"Özet", "Detaylý"})
        Me.sec_islem.Properties.ReadOnly = True
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
        Me.LabelControl4.Location = New System.Drawing.Point(9, 43)
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
        Me.LabelControl3.Location = New System.Drawing.Point(11, 21)
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
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý"
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
        Me.SimpleButton3.Location = New System.Drawing.Point(293, 87)
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(477, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(345, 13)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 151)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 230)
        Me.PanelControl3.TabIndex = 0
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(465, 76)
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
        'GridControl1
        '
        Me.GridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldnFirmaID, Me.fieldsKodu, Me.fieldsAciklama, Me.fieldSINIF1, Me.fieldSINIF2, Me.fieldSINIF3, Me.fieldSINIF4, Me.fieldSINIF5, Me.fieldlBakiye, Me.fieldCekRisk, Me.fieldSenetRisk, Me.fieldsUlke, Me.fieldsIl, Me.fieldsSemt, Me.fieldsSaticiRumuzu, Me.fieldnGecikme, Me.fieldlKalan, Me.fieldsYil, Me.fieldsAy, Me.fieldsHafta, Me.fieldsGun, Me.fieldlVadeFarki})
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.GridControl1.Size = New System.Drawing.Size(820, 226)
        Me.GridControl1.TabIndex = 4
        '
        'fieldnFirmaID
        '
        Me.fieldnFirmaID.AreaIndex = 0
        Me.fieldnFirmaID.Caption = "Kayýt No"
        Me.fieldnFirmaID.FieldName = "nFirmaID"
        Me.fieldnFirmaID.Name = "fieldnFirmaID"
        Me.fieldnFirmaID.Visible = False
        '
        'fieldsKodu
        '
        Me.fieldsKodu.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsKodu.AreaIndex = 0
        Me.fieldsKodu.Caption = "Kod"
        Me.fieldsKodu.FieldName = "sKodu"
        Me.fieldsKodu.Name = "fieldsKodu"
        '
        'fieldsAciklama
        '
        Me.fieldsAciklama.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsAciklama.AreaIndex = 1
        Me.fieldsAciklama.Caption = "Açýklama"
        Me.fieldsAciklama.FieldName = "sAciklama"
        Me.fieldsAciklama.Name = "fieldsAciklama"
        '
        'fieldSINIF1
        '
        Me.fieldSINIF1.AreaIndex = 1
        Me.fieldSINIF1.Caption = "Sýnýf 1"
        Me.fieldSINIF1.FieldName = "SINIF1"
        Me.fieldSINIF1.Name = "fieldSINIF1"
        Me.fieldSINIF1.Visible = False
        '
        'fieldSINIF2
        '
        Me.fieldSINIF2.AreaIndex = 2
        Me.fieldSINIF2.Caption = "Sýnýf 2"
        Me.fieldSINIF2.FieldName = "SINIF2"
        Me.fieldSINIF2.Name = "fieldSINIF2"
        Me.fieldSINIF2.Visible = False
        '
        'fieldSINIF3
        '
        Me.fieldSINIF3.AreaIndex = 3
        Me.fieldSINIF3.Caption = "Sýnýf 3"
        Me.fieldSINIF3.FieldName = "SINIF3"
        Me.fieldSINIF3.Name = "fieldSINIF3"
        Me.fieldSINIF3.Visible = False
        '
        'fieldSINIF4
        '
        Me.fieldSINIF4.AreaIndex = 4
        Me.fieldSINIF4.Caption = "Sýnýf 4"
        Me.fieldSINIF4.FieldName = "SINIF4"
        Me.fieldSINIF4.Name = "fieldSINIF4"
        Me.fieldSINIF4.Visible = False
        '
        'fieldSINIF5
        '
        Me.fieldSINIF5.AreaIndex = 5
        Me.fieldSINIF5.Caption = "Sýnýf 5"
        Me.fieldSINIF5.FieldName = "SINIF5"
        Me.fieldSINIF5.Name = "fieldSINIF5"
        Me.fieldSINIF5.Visible = False
        '
        'fieldlBakiye
        '
        Me.fieldlBakiye.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldlBakiye.AreaIndex = 2
        Me.fieldlBakiye.Caption = "Bakiye"
        Me.fieldlBakiye.CellFormat.FormatString = "#,0.00##"
        Me.fieldlBakiye.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlBakiye.FieldName = "lBakiye"
        Me.fieldlBakiye.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlBakiye.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlBakiye.Name = "fieldlBakiye"
        Me.fieldlBakiye.TotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlBakiye.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlBakiye.TotalValueFormat.FormatString = "#,0.00##"
        Me.fieldlBakiye.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlBakiye.ValueFormat.FormatString = "#,0.00##"
        Me.fieldlBakiye.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldCekRisk
        '
        Me.fieldCekRisk.AreaIndex = 6
        Me.fieldCekRisk.Caption = "Çek Riski"
        Me.fieldCekRisk.CellFormat.FormatString = "#,0.00##"
        Me.fieldCekRisk.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCekRisk.FieldName = "CekRisk"
        Me.fieldCekRisk.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldCekRisk.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCekRisk.Name = "fieldCekRisk"
        Me.fieldCekRisk.TotalCellFormat.FormatString = "#,0.00##"
        Me.fieldCekRisk.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCekRisk.TotalValueFormat.FormatString = "#,0.00##"
        Me.fieldCekRisk.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCekRisk.ValueFormat.FormatString = "#,0.00##"
        Me.fieldCekRisk.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCekRisk.Visible = False
        '
        'fieldSenetRisk
        '
        Me.fieldSenetRisk.AreaIndex = 7
        Me.fieldSenetRisk.Caption = "Senet Risk"
        Me.fieldSenetRisk.CellFormat.FormatString = "#,0.00##"
        Me.fieldSenetRisk.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSenetRisk.FieldName = "SenetRisk"
        Me.fieldSenetRisk.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldSenetRisk.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSenetRisk.Name = "fieldSenetRisk"
        Me.fieldSenetRisk.TotalCellFormat.FormatString = "#,0.00##"
        Me.fieldSenetRisk.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSenetRisk.TotalValueFormat.FormatString = "#,0.00##"
        Me.fieldSenetRisk.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSenetRisk.ValueFormat.FormatString = "#,0.00##"
        Me.fieldSenetRisk.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldSenetRisk.Visible = False
        '
        'fieldsUlke
        '
        Me.fieldsUlke.AreaIndex = 8
        Me.fieldsUlke.Caption = "Ulke"
        Me.fieldsUlke.FieldName = "sUlke"
        Me.fieldsUlke.Name = "fieldsUlke"
        Me.fieldsUlke.Visible = False
        '
        'fieldsIl
        '
        Me.fieldsIl.AreaIndex = 9
        Me.fieldsIl.Caption = "il"
        Me.fieldsIl.FieldName = "sIl"
        Me.fieldsIl.Name = "fieldsIl"
        Me.fieldsIl.Visible = False
        '
        'fieldsSemt
        '
        Me.fieldsSemt.AreaIndex = 10
        Me.fieldsSemt.Caption = "Semt"
        Me.fieldsSemt.FieldName = "sSemt"
        Me.fieldsSemt.Name = "fieldsSemt"
        Me.fieldsSemt.Visible = False
        '
        'fieldsSaticiRumuzu
        '
        Me.fieldsSaticiRumuzu.AreaIndex = 11
        Me.fieldsSaticiRumuzu.Caption = "Satici"
        Me.fieldsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.fieldsSaticiRumuzu.Name = "fieldsSaticiRumuzu"
        Me.fieldsSaticiRumuzu.Visible = False
        '
        'fieldnGecikme
        '
        Me.fieldnGecikme.AreaIndex = 12
        Me.fieldnGecikme.Caption = "Gecikme"
        Me.fieldnGecikme.FieldName = "nGecikme"
        Me.fieldnGecikme.Name = "fieldnGecikme"
        Me.fieldnGecikme.Visible = False
        '
        'fieldlKalan
        '
        Me.fieldlKalan.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldlKalan.AreaIndex = 0
        Me.fieldlKalan.Caption = "Kalan"
        Me.fieldlKalan.CellFormat.FormatString = "#,0.00##"
        Me.fieldlKalan.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.FieldName = "lKalan"
        Me.fieldlKalan.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlKalan.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.Name = "fieldlKalan"
        Me.fieldlKalan.TotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlKalan.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.TotalValueFormat.FormatString = "#,0.00##"
        Me.fieldlKalan.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.ValueFormat.FormatString = "#,0.00##"
        Me.fieldlKalan.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldsYil
        '
        Me.fieldsYil.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsYil.AreaIndex = 0
        Me.fieldsYil.Caption = "Yil"
        Me.fieldsYil.FieldName = "sYil"
        Me.fieldsYil.Name = "fieldsYil"
        '
        'fieldsAy
        '
        Me.fieldsAy.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsAy.AreaIndex = 1
        Me.fieldsAy.Caption = "Ay"
        Me.fieldsAy.FieldName = "sAy"
        Me.fieldsAy.Name = "fieldsAy"
        '
        'fieldsHafta
        '
        Me.fieldsHafta.AreaIndex = 13
        Me.fieldsHafta.Caption = "Hafta"
        Me.fieldsHafta.FieldName = "sHafta"
        Me.fieldsHafta.Name = "fieldsHafta"
        Me.fieldsHafta.Visible = False
        '
        'fieldsGun
        '
        Me.fieldsGun.AreaIndex = 13
        Me.fieldsGun.Caption = "Gün"
        Me.fieldsGun.FieldName = "sGun"
        Me.fieldsGun.Name = "fieldsGun"
        Me.fieldsGun.Visible = False
        '
        'fieldlVadeFarki
        '
        Me.fieldlVadeFarki.AreaIndex = 14
        Me.fieldlVadeFarki.Caption = "VadeFarki"
        Me.fieldlVadeFarki.CellFormat.FormatString = "#,0.00##"
        Me.fieldlVadeFarki.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlVadeFarki.FieldName = "lVadeFarki"
        Me.fieldlVadeFarki.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlVadeFarki.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlVadeFarki.Name = "fieldlVadeFarki"
        Me.fieldlVadeFarki.TotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlVadeFarki.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlVadeFarki.TotalValueFormat.FormatString = "#,0.00##"
        Me.fieldlVadeFarki.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlVadeFarki.ValueFormat.FormatString = "#,0.00##"
        Me.fieldlVadeFarki.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlVadeFarki.Visible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sKodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama"
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
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lBakiye"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "CekRisk"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "SenetRisk"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sUlke"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sIl"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sSemt"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nGecikme"
        Me.DataColumn16.DataType = GetType(Long)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lKalan"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sYil"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sAy"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sHafta"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sGun"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "lVadeFarki"
        Me.DataColumn22.DataType = GetType(Decimal)
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem19, Me.MenuItem18, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem17, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Firma Hareketleri"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 6
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 7
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 8
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 9
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 10
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 11
        Me.MenuItem10.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 12
        Me.MenuItem17.Text = "Hýzlý Filtre"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Firmalar Karlýlýk Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Firma Hesaplarý Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'sec_sdepo
        '
        Me.sec_sdepo.EditValue = "[Tümü]"
        Me.sec_sdepo.EnterMoveNextControl = True
        Me.sec_sdepo.Location = New System.Drawing.Point(292, 65)
        Me.sec_sdepo.Name = "sec_sdepo"
        Me.sec_sdepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sdepo.Properties.PopupControl = Me.sec_grid
        Me.sec_sdepo.Properties.ShowPopupCloseButton = False
        Me.sec_sdepo.Size = New System.Drawing.Size(75, 20)
        Me.sec_sdepo.TabIndex = 64
        '
        'frm_firma_liste_yaslandirma
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_firma_liste_yaslandirma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acik Hesaplar Yaslandirma"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sdepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim ds_tbDepo As DataSet
    Dim ds_tbSatici As DataSet
    Public sFiyatTipi As String = ""
    'Public sDepo As String = ""
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
        txt_ara.EditValue = ""
        DateEdit1.Focus()
        DateEdit1.Select()
        dataload_tbdepo()
        dataload_tbSatici()
    End Sub
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
        'GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'GridView1.CollapseAllGroups()
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
    Private Sub dataload_tbSatici()
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici where (bAktif = 1)"))
        'sec_sHareketTipi.ItemIndex = 1
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
        GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridControl1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridControl1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridControl1.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each clmn As DevExpress.XtraPivotGrid.PivotGridField In GridControl1.Fields
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sIslem As String, ByVal sBakiye As String, ByVal sSaticiRumuzu As String, ByVal lLimit1 As Decimal, ByVal lLimit2 As Decimal, ByVal nGun1 As Integer, ByVal nGun2 As Integer, ByVal nVadeFarki As Decimal) As DataSet
        Dim kriter As String = ""
        If ara <> "" Then
            If sec_konum.Text = "Kodu" Then
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
        If sSaticiRumuzu.ToString <> "" And sSaticiRumuzu <> "[Tümü]" Then
            kriter += " AND (tbFirma.sSaticiRumuzu IN (" & sSaticiRumuzu & " ))"
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
        'kriter += " AND tbFirma.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If sBakiye = "Borclar" Then
            If sIslem = "Özet" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) AS dteValorTarihi, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,DATEDIFF(day,  CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME),GETDATE()) AS nGecikme,sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ) tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
            ElseIf sIslem = "Detaylý" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sUlke, sIl, sSemt, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, sSaticiRumuzu, lBakiye, CekRisk, SenetRisk, nGecikme, lTutar - lKarsilananTutar AS lKalan, YEAR(dteValorTarihi) AS sYil, MONTH(dteValorTarihi) AS sAy, { fn WEEK(dteValorTarihi) } AS sHafta, DAY(dteValorTarihi) AS sGun, (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
            End If
        ElseIf sBakiye = "Alacaklar" Then
            If sIslem = "Özet" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) AS dteValorTarihi, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,DATEDIFF(day, CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME),GETDATE()) AS nGecikme,sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & ") tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
            ElseIf sIslem = "Detaylý" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sUlke, sIl, sSemt, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, sSaticiRumuzu, lBakiye, CekRisk, SenetRisk, nGecikme, lTutar - lKarsilananTutar AS lKalan, YEAR(dteValorTarihi) AS sYil, MONTH(dteValorTarihi) AS sAy, { fn WEEK(dteValorTarihi) } AS sHafta, DAY(dteValorTarihi) AS sGun, (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
            End If
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sUlke, sIl, sSemt, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, sSaticiRumuzu, lBakiye, CekRisk, SenetRisk, nGecikme, lTutar - lKarsilananTutar AS lKalan, YEAR(dteValorTarihi) AS sYil, MONTH(dteValorTarihi) AS sAy, { fn WEEK(dteValorTarihi) } AS sHafta, DAY(dteValorTarihi) AS sGun, (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sIslem As String, ByVal sBakiye As String, ByVal sSaticiRumuzu As String, ByVal lLimit1 As Decimal, ByVal lLimit2 As Decimal, ByVal nGun1 As Int64, ByVal nGun2 As Int64, ByVal nVadeFarki As Decimal)
        DataSet1 = stok(ara, konum, ara_kriter, tarih1, tarih2, sIslem, sBakiye, sSaticiRumuzu, lLimit1, lLimit2, nGun1, nGun2, nVadeFarki)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        If sModul = "Banka" Then
            fieldsKodu.Caption = Sorgu_sDil("Banka Kodu", sDil)
            fieldsAciklama.Caption = Sorgu_sDil("Banka Adý", sDil)
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, DateEdit1.EditValue, DateEdit2.EditValue, sec_islem.Text, sec_bakiye.Text, sec_sSatici.Text, txt_limit1.EditValue, txt_limit2.EditValue, txt_nGun1.EditValue, txt_nGun2.EditValue, txt_nVadeFarki.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSatici.QueryPopUp
        sec_sSatici.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_tbSatici.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_sSatici.QueryResultValue
        Dim s As String = deger(ds_tbSatici)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub

    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
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
End Class
