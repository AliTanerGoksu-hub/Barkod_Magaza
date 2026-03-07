Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbSiparis_ihtiyac
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
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents collSiparis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSevkiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bKapandimi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbSiparis_ihtiyac))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.collSiparis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSevkiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIhtiyac = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
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
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'collMevcut
        '
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,#.####"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        Me.collMevcut.Visible = True
        Me.collMevcut.VisibleIndex = 5
        Me.collMevcut.Width = 61
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 170)
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
        Me.GroupControl1.Size = New System.Drawing.Size(476, 166)
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
        Me.txt_lFisNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
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
        Me.txt_lFisNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.SimpleButton3.Location = New System.Drawing.Point(384, 136)
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
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(572, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(250, 166)
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 166)
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 358)
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 170)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 188)
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 184)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem13, Me.MenuItem14, Me.MenuItem18, Me.MenuItem15, Me.MenuItem23, Me.MenuItem24, Me.MenuItem26, Me.MenuItem25, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem23.Text = "Stok Kartý"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 6
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem24.Text = "Stok Hareketleri"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 7
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem26.Text = "Stok Fiyatlandýr"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 8
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem25.Text = "Stok Envanter"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 9
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 10
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlF6
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = False
        Me.MenuItem17.Index = 11
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem17.Text = "Firma Hareketleri"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 12
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 13
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 14
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 15
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 16
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 17
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 18
        Me.MenuItem22.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 19
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 20
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 21
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 22
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 23
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 24
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 25
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sFirmaKodu"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sFirmaAciklama"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lSiparisNo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "dteSiparisTarihi"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lMiktari"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sKodu"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sAciklama"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "nSiparisID"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "lKalan"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sAciklama1"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sAciklama2"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sAciklama3"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sAciklama4"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sAciklama5"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sFiyatTipi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nKdvOrani"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lFiyati"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "lTutari"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nIskontoYuzdesi"
        Me.DataColumn19.DataType = GetType(Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "lIskontosuzTutari"
        Me.DataColumn20.DataType = GetType(Decimal)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "dteTeslimTarihi"
        Me.DataColumn21.DataType = GetType(Date)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sSipIslem"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "bKapandimi"
        Me.DataColumn23.DataType = GetType(Boolean)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sModel"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collSiparis, Me.colsKodu, Me.colsAciklama, Me.collKalan, Me.colsModel, Me.collSevkiyat, Me.collMevcut, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colSINIF1, Me.colSINIF2, Me.colSINIF3, Me.colSINIF4, Me.colSINIF5, Me.colSINIF6, Me.colSINIF7, Me.colSINIF8, Me.colSINIF9, Me.colSINIF10, Me.colIhtiyac})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.collMevcut
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.collMevcut
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSiparis", Nothing, "Siparis:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkiyat", Nothing, "Sevkiyat:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", Nothing, "Kalan:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.colsKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSiparis", Me.collSiparis, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkiyat", Me.collSevkiyat, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", Me.collKalan, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIhtiyac", Nothing, "Ihtiyac:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIhtiyac", Me.colIhtiyac, "{0:#,0.####}")})
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
        'collSiparis
        '
        Me.collSiparis.Caption = "Sipariþ"
        Me.collSiparis.DisplayFormat.FormatString = "#,0.####"
        Me.collSiparis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSiparis.FieldName = "lSiparis"
        Me.collSiparis.Name = "collSiparis"
        Me.collSiparis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSiparis", "{0:#,0.####}")})
        Me.collSiparis.Visible = True
        Me.collSiparis.VisibleIndex = 2
        Me.collSiparis.Width = 81
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 81
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 135
        '
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.####"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.####}")})
        Me.collKalan.Visible = True
        Me.collKalan.VisibleIndex = 4
        Me.collKalan.Width = 85
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'collSevkiyat
        '
        Me.collSevkiyat.Caption = "Sevkiyat"
        Me.collSevkiyat.DisplayFormat.FormatString = "#,0.####"
        Me.collSevkiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkiyat.FieldName = "lSevkiyat"
        Me.collSevkiyat.Name = "collSevkiyat"
        Me.collSevkiyat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkiyat", "{0:#,#.####}")})
        Me.collSevkiyat.Visible = True
        Me.collSevkiyat.VisibleIndex = 3
        Me.collSevkiyat.Width = 87
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk Adý"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colSINIF1
        '
        Me.colSINIF1.Caption = "Sýnýf 1"
        Me.colSINIF1.FieldName = "SINIF1"
        Me.colSINIF1.Name = "colSINIF1"
        Me.colSINIF1.Visible = True
        Me.colSINIF1.VisibleIndex = 7
        Me.colSINIF1.Width = 229
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
        'colSINIF6
        '
        Me.colSINIF6.Caption = "Sýnýf 6"
        Me.colSINIF6.FieldName = "SINIF6"
        Me.colSINIF6.Name = "colSINIF6"
        '
        'colSINIF7
        '
        Me.colSINIF7.Caption = "Sýnýf 7"
        Me.colSINIF7.FieldName = "SINIF7"
        Me.colSINIF7.Name = "colSINIF7"
        '
        'colSINIF8
        '
        Me.colSINIF8.Caption = "Sýnýf 8"
        Me.colSINIF8.FieldName = "SINIF8"
        Me.colSINIF8.Name = "colSINIF8"
        '
        'colSINIF9
        '
        Me.colSINIF9.Caption = "Sýnýf 9"
        Me.colSINIF9.FieldName = "SINIF9"
        Me.colSINIF9.Name = "colSINIF9"
        '
        'colSINIF10
        '
        Me.colSINIF10.Caption = "Sýnýf 10"
        Me.colSINIF10.FieldName = "SINIF10"
        Me.colSINIF10.Name = "colSINIF10"
        '
        'colIhtiyac
        '
        Me.colIhtiyac.Caption = "Ýhtiyaç"
        Me.colIhtiyac.DisplayFormat.FormatString = "#,0.####"
        Me.colIhtiyac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIhtiyac.FieldName = "lIhtiyac"
        Me.colIhtiyac.Name = "colIhtiyac"
        Me.colIhtiyac.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIhtiyac", "{0:#,0.####}")})
        Me.colIhtiyac.Visible = True
        Me.colIhtiyac.VisibleIndex = 6
        Me.colIhtiyac.Width = 90
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Sipariþ Ýhtiyaç Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Sipariþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Envanter,F6"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        Me.BarButtonItem5.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.Appearance.Options.UseFont = True
        Me.BarButtonItem6.Caption = "Excel"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.Appearance.Options.UseFont = True
        Me.BarButtonItem7.Caption = "Text"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.Appearance.Options.UseFont = True
        Me.BarButtonItem8.Caption = "Mail"
        Me.BarButtonItem8.Id = 7
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 406)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 406)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 406)
        '
        'frm_tbSiparis_ihtiyac
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbSiparis_ihtiyac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sipariþ Ihtiyaclari..."
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
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
        kriter += Microsoft.VisualBasic.Left(txt_dteSiparisTarihi1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(txt_dteSiparisTarihi2.EditValue.ToString, 10) & " Tarihleri Arasýndaki " & vbCrLf
        kriter += " FisNo = " & txt_lFisNo1.Text & " ve " & txt_lFisNo1.Text & " Arasýndaki "
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Siparis Yonetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        sec_sSaticiRumuzu.Properties.DataSource = ds_satici.Tables(0)
    End Sub
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
                'having = " HAVING      (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)"
                having = " Where      ISNULL(lSiparis,0)-ISNULL(lSevkiyat,0) <> 0 "
            End If
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbSiparis.lMiktari, tbStok.nStokID,tbStok.sModel,tbStok.sKodu, tbStok.sAciklama,tbStok.sRenk,tbStok.sBeden,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut,tbSiparis.nSiparisID, ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lSevkiyat,ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lKalan, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, tbSiparis.sFiyatTipi, tbSiparis.nKdvOrani, tbSiparis.lFiyati, (tbSiparis.lTutari/tbSiparis.lMiktari)*ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), tbSiparis.lMiktari) as lTutari, tbSiparis.nIskontoYuzdesi, ISNULL((tbSiparis.lIskontosuzTutari/tbSiparis.lMiktari),1) * ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), tbSiparis.lMiktari) as lIskontosuzTutari, tbSiparis.dteTeslimTarihi, (SELECT MAX(SipIslem.sSiparisIslem + ' ' + rtrim(tbSiparisIslem.sAciklama)) FROM tbSiparisIslem , tbSiparis SipIslem WHERE tbSiparisIslem.sSiparisIslem = SipIslem.sSiparisIslem AND SipIslem.lSiparisNo = tbSiparis.lSiparisNo AND SipIslem.nFirmaID = tbSiparis.nFirmaID AND SipIslem.nSiparisTipi = tbSiparis.nSiparisTipi) AS sSipIslem, tbSiparis.bKapandimi FROM tbSiparisAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID ON tbSiparisAciklamasi.nSiparisTipi = tbSiparis.nSiparisTipi AND tbSiparisAciklamasi.nFirmaID = tbSiparis.nFirmaID AND tbSiparisAciklamasi.lSiparisNo = tbSiparis.lSiparisNo WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & " GROUP BY tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbStok.nStokID,tbStok.sAciklama, tbStok.sModel,tbStok.sKodu,tbStok.sRenk,tbStok.sBeden, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.bKapandimi, tbSiparis.sFiyatTipi, tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari, tbSiparis.dteTeslimTarihi, tbSiparis.nFirmaID, tbSiparis.nSiparisTipi, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5  " & having & " ORDER BY tbFirma.sKodu, tbSiparis.dteSiparisTarihi, tbStok.sKodu")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tSiparis.*, tSiparis.lSiparis - tSiparis.lSevkiyat AS lKalan,tSiparis.lSiparis - tSiparis.lSevkiyat - tSiparis.lMevcut AS lIhtiyac, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN (SELECT tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden ,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik, tbStok.sDovizCinsi,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim=0) AS sBarkod , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat3 & "'),0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat2 & "'),0) AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani, SUM(tbSiparis.lMiktari) AS lSiparis , ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & " GROUP BY tbStok.nStokID , tbStok.sAciklama , tbStok.sModel , tbStok.sKodu , tbStok.sRenk , tbStok.sBeden,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sDovizCinsi,tbStok.sKdvTipi ) tSiparis ON tbStokSinifi.nStokID = tSiparis.nStokID " & having & " Order by tSiparis.sKodu")
        ElseIf nSiparisTipi = 2 Then
            If bKapandimi = False Then
                having = " Where      ISNULL(lSiparis,0)-ISNULL(lSevkiyat,0) <> 0 "
            End If
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbSiparis.lMiktari, tbStok.nStokID,tbStok.sModel,tbStok.sKodu, tbStok.sAciklama,tbStok.sRenk,tbStok.sBeden,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut,tbSiparis.nSiparisID, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0) AS lSevkiyat,ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0) AS lKalan, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, tbSiparis.sFiyatTipi, tbSiparis.nKdvOrani, tbSiparis.lFiyati, (tbSiparis.lTutari/tbSiparis.lMiktari)*ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), tbSiparis.lMiktari) as lTutari, tbSiparis.nIskontoYuzdesi, ISNULL((tbSiparis.lIskontosuzTutari/tbSiparis.lMiktari),1) * ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), tbSiparis.lMiktari) as lIskontosuzTutari, tbSiparis.dteTeslimTarihi, (SELECT MAX(SipIslem.sSiparisIslem + ' ' + rtrim(tbSiparisIslem.sAciklama)) FROM tbSiparisIslem , tbSiparis SipIslem WHERE tbSiparisIslem.sSiparisIslem = SipIslem.sSiparisIslem AND SipIslem.lSiparisNo = tbSiparis.lSiparisNo AND SipIslem.nFirmaID = tbSiparis.nFirmaID AND SipIslem.nSiparisTipi = tbSiparis.nSiparisTipi) AS sSipIslem, tbSiparis.bKapandimi FROM tbSiparisAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID ON tbSiparisAciklamasi.nSiparisTipi = tbSiparis.nSiparisTipi AND tbSiparisAciklamasi.nFirmaID = tbSiparis.nFirmaID AND tbSiparisAciklamasi.lSiparisNo = tbSiparis.lSiparisNo WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & " GROUP BY tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbStok.nStokID,tbStok.sAciklama, tbStok.sModel,tbStok.sKodu, tbStok.sRenk,tbStok.sBeden, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.bKapandimi, tbSiparis.sFiyatTipi, tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari, tbSiparis.dteTeslimTarihi, tbSiparis.nFirmaID, tbSiparis.nSiparisTipi, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5 " & having & " ORDER BY tbFirma.sKodu, tbSiparis.dteSiparisTarihi, tbStok.sKodu")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tSiparis.*, tSiparis.lSiparis - tSiparis.lSevkiyat AS lKalan,tSiparis.lSiparis - tSiparis.lSevkiyat - tSiparis.lMevcut AS lIhtiyac, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN (SELECT tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden ,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik, tbStok.sDovizCinsi,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim=0) AS sBarkod , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat3 & "'),0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat2 & "'),0) AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI, (SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani, SUM(tbSiparis.lMiktari) AS lSiparis , ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1) , 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & " GROUP BY tbStok.nStokID , tbStok.sAciklama , tbStok.sModel , tbStok.sKodu , tbStok.sRenk , tbStok.sBeden,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sDovizCinsi,tbStok.sKdvTipi ) tSiparis ON tbStokSinifi.nStokID = tSiparis.nStokID " & having & " Order by tSiparis.sKodu")
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
            frm.sKodu = dr("sFirmaKodu")
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
    Private Sub analiz_fis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbSiparis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.dteSiparisTarihi = dr("dteSiparisTarihi")
            frm.lSiparisNo = dr("lSiparisNo")
            frm.nFirmaID = dr("nFirmaID")
            'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
            'frm.txt_SiparisAlan.EditValue = dr("sSiparisiAlan")
            'frm.txt_SiparisVeren.EditValue = dr("sSiparisiVeren")
            frm.nSiparisTipi = sec_sSiparisTipi.EditValue
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
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
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
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
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
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "Çýkýþlar"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
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
                'lbl_istihbarat.Text = dr("sAciklama1").ToString + " " + dr("sAciklama2").ToString + " " + dr("sAciklama3").ToString + " " + dr("sAciklama4").ToString + " " + dr("sAciklama5").ToString
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

        sec_sSiparisTipi.Focus()
        sec_sSiparisTipi.SelectAll()
        ara()
        'txt_dteFisTarihi1.Focus()
        'txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteSiparisTarihi1.Focus()
        txt_dteSiparisTarihi1.Select()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If MenuItem22.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem22.Checked = True
        ElseIf MenuItem22.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem22.Checked = True
        End If
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
    Friend WithEvents colSINIF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIhtiyac As DevExpress.XtraGrid.Columns.GridColumn
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
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        txt_dteSiparisTarihi1.Focus()
        txt_dteSiparisTarihi1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        gorunum_yazdir()
    End Sub
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sSaticiRumuzu As DevExpress.XtraEditors.LookUpEdit
End Class
