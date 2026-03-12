Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_HesapPlani_liste
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
    Friend WithEvents colSINIF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Ara As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Ekle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Duzelt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Sil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_GorunumYazdir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Iletisim As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FirmaHareketleri As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_StokHareketleri As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_bAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents collBorcTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirenMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikanMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Seviye As DevExpress.XtraEditors.CheckButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HesapPlani_liste))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cols02 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cols03 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_bAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Seviye = New DevExpress.XtraEditors.CheckButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
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
        Me.colSINIF1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlternatifAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cols04 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cols05 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cols06 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBorcTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacakTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirenMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikanMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel_Seviye = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckButton6 = New DevExpress.XtraEditors.CheckButton()
        Me.CheckButton5 = New DevExpress.XtraEditors.CheckButton()
        Me.CheckButton4 = New DevExpress.XtraEditors.CheckButton()
        Me.CheckButton3 = New DevExpress.XtraEditors.CheckButton()
        Me.CheckButton2 = New DevExpress.XtraEditors.CheckButton()
        Me.CheckButton1 = New DevExpress.XtraEditors.CheckButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btn_Ara = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Ekle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Duzelt = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Sil = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_GorunumYazdir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FirmaHareketleri = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btn_Iletisim = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_StokHareketleri = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_bAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Panel_Seviye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Seviye.SuspendLayout()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 4
        '
        'col01
        '
        Me.col01.Caption = "1-Hesap Sýnýflarý"
        Me.col01.FieldName = "s01"
        Me.col01.Name = "col01"
        '
        'cols02
        '
        Me.cols02.Caption = "2-Hesap Gruplarý"
        Me.cols02.FieldName = "s02"
        Me.cols02.Name = "cols02"
        '
        'cols03
        '
        Me.cols03.Caption = "3-Hesap Planý"
        Me.cols03.FieldName = "s03"
        Me.cols03.Name = "cols03"
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_bAktif)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(681, 52)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_bAktif
        '
        Me.sec_bAktif.EditValue = True
        Me.sec_bAktif.Location = New System.Drawing.Point(323, 23)
        Me.sec_bAktif.Name = "sec_bAktif"
        Me.sec_bAktif.Properties.Caption = ""
        Me.sec_bAktif.Size = New System.Drawing.Size(22, 19)
        ToolTipTitleItem1.Text = "Hesap Tipi"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Aktif Hesaplar Ýçin Çentik Ýþaretinin Dolu olmasý gerekir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pasif Hesaplar için is" & _
    "e Çentik Ýþaretini Kaldýrýnýz"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.sec_bAktif.SuperTip = SuperToolTip1
        Me.sec_bAktif.TabIndex = 4
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Geliþmiþ"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(150, 22)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adý", "Geliþmiþ", "AlternatifAd", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(98, 20)
        Me.sec_konum.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(345, 22)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(248, 22)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 2
        '
        'txt_ara
        '
        Me.txt_ara.EditValue = ""
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(2, 22)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(148, 20)
        Me.txt_ara.TabIndex = 0
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(777, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(45, 13)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btn_Seviye)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 2
        '
        'btn_Seviye
        '
        Me.btn_Seviye.Image = Global.business_smart.My.Resources.Resources.replace2
        Me.btn_Seviye.Location = New System.Drawing.Point(6, 9)
        Me.btn_Seviye.Name = "btn_Seviye"
        Me.btn_Seviye.Size = New System.Drawing.Size(103, 23)
        Me.btn_Seviye.TabIndex = 7
        Me.btn_Seviye.Text = "Seviye Göster"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(115, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Controls.Add(Me.Panel_Seviye)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 303)
        Me.PanelControl3.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 142)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 159)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem19, Me.MenuItem27, Me.MenuItem17, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem26, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem18.Text = "Ara"
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
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem22.Text = "Ekle"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Text = "Duzelt"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 6
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem24.Text = "Sil"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 7
        Me.MenuItem25.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 8
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Hesap Kartý"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 9
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem27.Text = "Bakiye Analizi"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 10
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Hesap Hareketleri"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 11
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 12
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 13
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 14
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 15
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 16
        Me.MenuItem10.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 17
        Me.MenuItem26.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 18
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 19
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 20
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 21
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 22
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 23
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 24
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnFirmaID, Me.colsKodu, Me.colsAciklama, Me.colSINIF1, Me.colSINIF2, Me.colSINIF3, Me.colSINIF4, Me.colSINIF5, Me.collBakiye, Me.colsAlternatifAciklama, Me.collKalan, Me.col01, Me.cols02, Me.cols03, Me.cols04, Me.cols05, Me.cols06, Me.collBorcTutar, Me.collAlacakTutar, Me.collGirenMiktar, Me.collCikanMiktar})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.collBakiye
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.collBakiye
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.col01
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Expression = "1"
        StyleFormatCondition3.Value1 = "1"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Appearance.Options.UseFont = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.cols02
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Expression = "1"
        StyleFormatCondition4.Value1 = "1"
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.Appearance.Options.UseFont = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.cols03
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Expression = "1"
        StyleFormatCondition5.Value1 = "1"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = ""
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Kayýt No"
        Me.colnFirmaID.FieldName = "nHesapID"
        Me.colnFirmaID.Name = "colnFirmaID"
        Me.colnFirmaID.Width = 77
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Hesap Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 134
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "HesapAdý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 350
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
        'colsAlternatifAciklama
        '
        Me.colsAlternatifAciklama.Caption = "AlternatifAciklama"
        Me.colsAlternatifAciklama.FieldName = "sAlternatifAciklama"
        Me.colsAlternatifAciklama.Name = "colsAlternatifAciklama"
        '
        'collKalan
        '
        Me.collKalan.Caption = "Mevcut"
        Me.collKalan.DisplayFormat.FormatString = "#,0.##"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        '
        'cols04
        '
        Me.cols04.Caption = "4-Muavin Hesap"
        Me.cols04.FieldName = "s04"
        Me.cols04.Name = "cols04"
        '
        'cols05
        '
        Me.cols05.Caption = "5-Tali Hesap"
        Me.cols05.FieldName = "s05"
        Me.cols05.Name = "cols05"
        '
        'cols06
        '
        Me.cols06.Caption = "6-Detay Hesap"
        Me.cols06.FieldName = "s06"
        Me.cols06.Name = "cols06"
        '
        'collBorcTutar
        '
        Me.collBorcTutar.Caption = "Borc"
        Me.collBorcTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutar.FieldName = "lBorcTutar"
        Me.collBorcTutar.Name = "collBorcTutar"
        Me.collBorcTutar.Visible = True
        Me.collBorcTutar.VisibleIndex = 2
        '
        'collAlacakTutar
        '
        Me.collAlacakTutar.Caption = "Alacak"
        Me.collAlacakTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutar.FieldName = "lAlacakTutar"
        Me.collAlacakTutar.Name = "collAlacakTutar"
        Me.collAlacakTutar.Visible = True
        Me.collAlacakTutar.VisibleIndex = 3
        '
        'collGirenMiktar
        '
        Me.collGirenMiktar.Caption = "GirenMiktar"
        Me.collGirenMiktar.DisplayFormat.FormatString = "#,#.###"
        Me.collGirenMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirenMiktar.FieldName = "lGirenMiktar"
        Me.collGirenMiktar.Name = "collGirenMiktar"
        '
        'collCikanMiktar
        '
        Me.collCikanMiktar.Caption = "CikanMiktar"
        Me.collCikanMiktar.DisplayFormat.FormatString = "#,#.###"
        Me.collCikanMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikanMiktar.FieldName = "lCikanMiktar"
        Me.collCikanMiktar.Name = "collCikanMiktar"
        '
        'Panel_Seviye
        '
        Me.Panel_Seviye.Controls.Add(Me.LabelControl9)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl12)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl11)
        Me.Panel_Seviye.Controls.Add(Me.CheckButton6)
        Me.Panel_Seviye.Controls.Add(Me.CheckButton5)
        Me.Panel_Seviye.Controls.Add(Me.CheckButton4)
        Me.Panel_Seviye.Controls.Add(Me.CheckButton3)
        Me.Panel_Seviye.Controls.Add(Me.CheckButton2)
        Me.Panel_Seviye.Controls.Add(Me.CheckButton1)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl10)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl8)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl7)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl6)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl5)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl4)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl3)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl2)
        Me.Panel_Seviye.Controls.Add(Me.LabelControl1)
        Me.Panel_Seviye.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Seviye.Location = New System.Drawing.Point(2, 2)
        Me.Panel_Seviye.Name = "Panel_Seviye"
        Me.Panel_Seviye.Size = New System.Drawing.Size(820, 140)
        Me.Panel_Seviye.TabIndex = 1
        Me.Panel_Seviye.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(35, 48)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(4, 86)
        Me.LabelControl9.TabIndex = 25
        Me.LabelControl9.Text = "llllllllllllll"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(67, 110)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(4, 24)
        Me.LabelControl12.TabIndex = 28
        Me.LabelControl12.Text = "llll"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(57, 89)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(4, 45)
        Me.LabelControl11.TabIndex = 27
        Me.LabelControl11.Text = "llllllll"
        '
        'CheckButton6
        '
        Me.CheckButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckButton6.Appearance.Options.UseBackColor = True
        Me.CheckButton6.Location = New System.Drawing.Point(78, 109)
        Me.CheckButton6.Name = "CheckButton6"
        Me.CheckButton6.Size = New System.Drawing.Size(116, 21)
        Me.CheckButton6.TabIndex = 16
        Me.CheckButton6.Text = "6-Detay Hesap"
        '
        'CheckButton5
        '
        Me.CheckButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckButton5.Appearance.Options.UseBackColor = True
        Me.CheckButton5.Checked = True
        Me.CheckButton5.Location = New System.Drawing.Point(68, 88)
        Me.CheckButton5.Name = "CheckButton5"
        Me.CheckButton5.Size = New System.Drawing.Size(116, 21)
        Me.CheckButton5.TabIndex = 15
        Me.CheckButton5.Text = "5-Tali Hesap"
        '
        'CheckButton4
        '
        Me.CheckButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckButton4.Appearance.Options.UseBackColor = True
        Me.CheckButton4.Checked = True
        Me.CheckButton4.Location = New System.Drawing.Point(58, 67)
        Me.CheckButton4.Name = "CheckButton4"
        Me.CheckButton4.Size = New System.Drawing.Size(116, 21)
        Me.CheckButton4.TabIndex = 14
        Me.CheckButton4.Text = "4-Muavin Hesap"
        '
        'CheckButton3
        '
        Me.CheckButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckButton3.Appearance.Options.UseBackColor = True
        Me.CheckButton3.Checked = True
        Me.CheckButton3.Location = New System.Drawing.Point(48, 46)
        Me.CheckButton3.Name = "CheckButton3"
        Me.CheckButton3.Size = New System.Drawing.Size(116, 21)
        Me.CheckButton3.TabIndex = 13
        Me.CheckButton3.Text = "3-Hesap Planý"
        '
        'CheckButton2
        '
        Me.CheckButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckButton2.Appearance.Options.UseBackColor = True
        Me.CheckButton2.Checked = True
        Me.CheckButton2.Location = New System.Drawing.Point(38, 25)
        Me.CheckButton2.Name = "CheckButton2"
        Me.CheckButton2.Size = New System.Drawing.Size(116, 21)
        Me.CheckButton2.TabIndex = 12
        Me.CheckButton2.Text = "2-Hesap Gruplarý"
        '
        'CheckButton1
        '
        Me.CheckButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckButton1.Appearance.Options.UseBackColor = True
        Me.CheckButton1.Appearance.Options.UseTextOptions = True
        Me.CheckButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.CheckButton1.Checked = True
        Me.CheckButton1.Location = New System.Drawing.Point(26, 4)
        Me.CheckButton1.Name = "CheckButton1"
        Me.CheckButton1.Size = New System.Drawing.Size(116, 21)
        Me.CheckButton1.TabIndex = 11
        Me.CheckButton1.Text = "1-Hesap Sýnýflarý"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(46, 70)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(4, 64)
        Me.LabelControl10.TabIndex = 26
        Me.LabelControl10.Text = "llllllllllll"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(22, 28)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(4, 106)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "llllllllllllllllll"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "=="
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(10, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(4, 127)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "llllllllllllllllllll"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(65, 107)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "=="
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(55, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "=="
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(45, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "=="
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(35, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "=="
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "=="
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Muhasebe Hesap Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Ara, Me.btn_Ekle, Me.btn_Duzelt, Me.btn_Sil, Me.btn_GorunumYazdir, Me.btn_Iletisim, Me.btn_FirmaHareketleri, Me.btn_StokHareketleri, Me.BarButtonItem1})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ara), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ekle, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Duzelt, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Sil, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_GorunumYazdir, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FirmaHareketleri, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btn_Ara
        '
        Me.btn_Ara.Caption = "Ara"
        Me.btn_Ara.Id = 0
        Me.btn_Ara.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Ara.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Ara.Name = "btn_Ara"
        '
        'btn_Ekle
        '
        Me.btn_Ekle.Caption = "Ekle,Insert"
        Me.btn_Ekle.Id = 1
        Me.btn_Ekle.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Ekle.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Ekle.Name = "btn_Ekle"
        '
        'btn_Duzelt
        '
        Me.btn_Duzelt.Caption = "Düzelt,F4"
        Me.btn_Duzelt.Id = 2
        Me.btn_Duzelt.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Duzelt.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Duzelt.Name = "btn_Duzelt"
        '
        'btn_Sil
        '
        Me.btn_Sil.Caption = "Sil,Ctrl+Del"
        Me.btn_Sil.Id = 3
        Me.btn_Sil.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Sil.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Sil.Name = "btn_Sil"
        '
        'btn_GorunumYazdir
        '
        Me.btn_GorunumYazdir.Caption = "Yazdýr,Ctrl+P"
        Me.btn_GorunumYazdir.Id = 4
        Me.btn_GorunumYazdir.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_GorunumYazdir.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_GorunumYazdir.Name = "btn_GorunumYazdir"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Bakiye Analizi"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btn_FirmaHareketleri
        '
        Me.btn_FirmaHareketleri.Caption = "Hesap Ekstresi,F7"
        Me.btn_FirmaHareketleri.Id = 6
        Me.btn_FirmaHareketleri.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_FirmaHareketleri.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_FirmaHareketleri.Name = "btn_FirmaHareketleri"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'btn_Iletisim
        '
        Me.btn_Iletisim.Caption = "Ýletiþim,F8"
        Me.btn_Iletisim.Id = 5
        Me.btn_Iletisim.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Iletisim.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Iletisim.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.btn_Iletisim.Name = "btn_Iletisim"
        '
        'btn_StokHareketleri
        '
        Me.btn_StokHareketleri.Caption = "Stok Hareketleri,Ctrl+F7"
        Me.btn_StokHareketleri.Id = 7
        Me.btn_StokHareketleri.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_StokHareketleri.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_StokHareketleri.Name = "btn_StokHareketleri"
        '
        'frm_HesapPlani_liste
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
        Me.Name = "frm_HesapPlani_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hesap Kayýtlarý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_bAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Panel_Seviye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Seviye.ResumeLayout(False)
        Me.Panel_Seviye.PerformLayout()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public connection As String = ""
    Public musterino
    Public kullanici
    Dim count As String
    Public islemstatus As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        If Trim(txt_ara.Text) <> "" Then
            Try
                ara()
            Catch ex As Exception
            End Try
        Else
            txt_ara.EditValue = ""
            txt_ara.Focus()
            txt_ara.Select()
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
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal bAktif As Integer) As DataSet
        Dim kriter As String = "Where tbHesapPlani.sKodu <>''"
        If ara <> "" Then
            If sec_konum.Text = "Kodu" And ara.Contains("x") = False Then
                kriter += " AND ( tbHesapPlani.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND ( tbHesapPlani.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Geliþmiþ" Then
                kriter += " AND ( tbHesapPlani.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbHesapPlani.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "AlternatifAd" Then
                kriter += " AND ( tbHesapPlani.sAlterneAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Geliþmiþ" Then
                kriter += " AND ( tbHesapPlani.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbHesapPlani.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND (( tbHesapPlaniAciklamasi.sAciklama1 + ' ' + tbHesapPlaniAciklamasi.sAciklama2 + ' ' + tbHesapPlaniAciklamasi.sAciklama3 + ' ' + tbHesapPlaniAciklamasi.sAciklama4 + '  ' + tbHesapPlaniAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adres" Then
                kriter += " AND ( tbHesapPlani.sAdres1 + ' ' + tbHesapPlani.sAdres2 + ' ' + tbHesapPlani.sSemt + ' ' + tbHesapPlani.sIl + ' ' + tbHesapPlani.sUlke + ' ' + tbHesapPlani.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND (tbHSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND (tbHSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND (tbHSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND (tbHSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND (tbHSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
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
                        kriter += " and substring(tbHesapPlani.sKodu, " & t & ", " & 1 & ") = '" & sDeger & "' "
                    End If
                Next
            End If
        Else
            If CheckButton1.Checked = True Then
                kriter += " and s01 = 1"
            End If
            If CheckButton2.Checked = True Then
                kriter += " or s02 = 1"
            End If
            If CheckButton3.Checked = True Then
                kriter += " or s03 = 1"
            End If
            If CheckButton4.Checked = True Then
                kriter += " or s04 = 1"
            End If
            If CheckButton5.Checked = True Then
                kriter += " or s05 = 1"
            End If
            If CheckButton6.Checked = True Then
                kriter += " or s06 = 1"
            End If
        End If
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        'If bAktif = 0 Then
        '    kriter += " and tbHesapPlani.sAktifPasif ='Pasif'"
        'ElseIf bAktif = 1 Then
        '    kriter += " and tbHesapPlani.sAktifPasif <> 'Pasif'"
        'End If
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbHesapPlani.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, tbHesapPlani.sAlterneAciklama,'' AS ISTIHBARAT, tbHSinif1.sAciklama AS SINIF1, tbHSinif2.sAciklama AS SINIF2, tbHSinif3.sAciklama AS SINIF3, tbHSinif4.sAciklama AS SINIF4, tbHSinif5.sAciklama AS SINIF5, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbMuhasebeFisi WHERE nHesapID = tbHesapPlani.nHesapID) AS lBakiye  FROM tbHSinif1 INNER JOIN tbHesapSinifi ON tbHSinif1.sSinifKodu = tbHesapSinifi.sSinifKodu1 INNER JOIN tbHSinif2 ON tbHesapSinifi.sSinifKodu2 = tbHSinif2.sSinifKodu INNER JOIN tbHSinif3 ON tbHesapSinifi.sSinifKodu3 = tbHSinif3.sSinifKodu INNER JOIN tbHSinif4 ON tbHesapSinifi.sSinifKodu4 = tbHSinif4.sSinifKodu INNER JOIN tbHSinif5 ON tbHesapSinifi.sSinifKodu5 = tbHSinif5.sSinifKodu RIGHT OUTER JOIN tbHesapPlani ON tbHesapSinifi.nHesapID = tbHesapPlani.nHesapID " & kriter & " ORDER BY tbHesapPlani.sKodu")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbHesapPlani.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, tbHesapPlani.sAlterneAciklama, '' AS ISTIHBARAT, tbHSinif1.sAciklama AS SINIF1, tbHSinif2.sAciklama AS SINIF2, tbHSinif3.sAciklama AS SINIF3, tbHSinif4.sAciklama AS SINIF4, tbHSinif5.sAciklama AS SINIF5, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbMuhasebeFisi WHERE nHesapID = tbHesapPlani.nHesapID) AS lBakiye,(SELECT ISNULL(SUM(lGirenMiktar - lCikanMiktar) , 0) AS lKalan FROM tbMuhasebeFisi WHERE nHesapID = tbHesapPlani.nHesapID) AS lKalan, ISNULL(tbFirma.nFirmaID,0) as nFirmaID, ISNULL(tbFirma.sKodu,'') AS sFirmaKodu, ISNULL(tbFirma.sAciklama,'') AS sFirmaAciklama FROM tbFirma RIGHT OUTER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN tbHSinif1 INNER JOIN tbHesapSinifi ON tbHSinif1.sSinifKodu = tbHesapSinifi.sSinifKodu1 INNER JOIN tbHSinif2 ON tbHesapSinifi.sSinifKodu2 = tbHSinif2.sSinifKodu INNER JOIN tbHSinif3 ON tbHesapSinifi.sSinifKodu3 = tbHSinif3.sSinifKodu INNER JOIN tbHSinif4 ON tbHesapSinifi.sSinifKodu4 = tbHSinif4.sSinifKodu INNER JOIN tbHSinif5 ON tbHesapSinifi.sSinifKodu5 = tbHSinif5.sSinifKodu ON tbHesapPlani.nHesapID = tbHesapSinifi.nHesapID " & kriter & " ORDER BY tbHesapPlani.sKodu")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT nHesapID , SUBSTRING(sKodu , 1 , 1) AS sKodu , sAciklama , 0 AS lBorcTutar , 0 AS lAlacakTutar , 0 AS lBakiye , 1 AS 's01' , 0 AS s02 , 0 AS s03 , 0 AS s04 , 0 AS s05 , 0 AS s06 FROM tbHesapPlani WHERE (LEN(sKodu) = 1) AND (SUBSTRING(sKodu , 1 , 1) <> '') AND (sAciklama <> '') UNION ALL SELECT nHesapID , SUBSTRING(sKodu , 1 , 2) AS sKodu , sAciklama , 0 AS lBorcTutar , 0 AS lAlacakTutar , 0 AS lBakiye , 0 AS 's01' , 1 AS s02 , 0 AS s03 , 0 AS s04 , 0 AS s05 , 0 AS s06 FROM tbHesapPlani WHERE (LEN(sKodu) = 2) AND (SUBSTRING(sKodu , 1 , 2) <> '') AND (sAciklama <> '') UNION ALL SELECT nHesapID , SUBSTRING(sKodu , 1 , 3) AS sKodu , sAciklama , 0 AS lBorcTutar , 0 AS lAlacakTutar , 0 AS lBakiye , 0 AS 's01' , 0 AS s02 , 1 AS s03 , 0 AS s04 , 0 AS s05 , 0 AS s06 FROM tbHesapPlani WHERE (LEN(sKodu) = 3) AND (SUBSTRING(sKodu , 1 , 3) <> '') AND (sAciklama <> '') UNION ALL SELECT nHesapID , SUBSTRING(sKodu , 1 , 8) AS sKodu , sAciklama , 0 AS lBorcTutar , 0 AS lAlacakTutar , 0 AS lBakiye , 0 AS 's01' , 0 AS s02 , 0 AS s03 , 1 AS s04 , 0 AS s05 , 0 AS s06 FROM tbHesapPlani WHERE (LEN(sKodu) = 8) AND (SUBSTRING(sKodu , 1 , 8) <> '') AND (sAciklama <> '') UNION ALL SELECT nHesapID , SUBSTRING(sKodu , 1 , 14) AS sKodu , sAciklama , 0 AS lBorcTutar , 0 AS lAlacakTutar , 0 AS lBakiye , 0 AS 's01' , 0 AS s02 , 0 AS s03 , 0 AS s04 , 1 AS s05 , 0 AS s06 FROM tbHesapPlani WHERE (LEN(sKodu) = 14) AND (SUBSTRING(sKodu , 1 , 14) <> '') AND (sAciklama <> '') UNION ALL SELECT nHesapID , SUBSTRING(sKodu , 1 , 20) AS sKodu , sAciklama , 0 AS lBorcTutar , 0 AS lAlacakTutar , 0 AS lBakiye , 0 AS 's01' , 0 AS s02 , 0 AS s03 , 0 AS s04 , 0 AS s05 , 1 AS s06 FROM tbHesapPlani WHERE /*(LEN(sKodu) = 20) AND*/ (SUBSTRING(sKodu , 1 , 20) <> '') AND (sAciklama <> '')) tbHesapPlani " & kriter & " ORDER BY sKodu")
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
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Try
            dataload(txt_ara.Text, sec_konum.Text, sec_kriter.Text, sec_bAktif.Checked)
        Catch ex As Exception
        End Try
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal bAktif As Integer)
        DataSet1 = stok(ara, konum, ara_kriter, Math.Abs(bAktif))
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            Dim ds_Bakiye As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lBakiye, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.sHangiUygulama = 'MUH') AND (tbHesapPlani.sKodu LIKE '" & dr("sKodu") & "%')"))
            Dim dr1 As DataRow
            For Each dr1 In ds_Bakiye.Tables(0).Rows
                dr("lBorcTutar") = dr1("lBorcTutar")
                dr("lAlacakTutar") = dr1("lAlacakTutar")
                dr("lBakiye") = dr1("lBakiye")
                'dr("lGirenMiktar") = dr1("lGirenMiktar")
                'dr("lCikanMiktar") = dr1("lCikanMiktar")
            Next
            dr1 = Nothing
            ds_Bakiye = Nothing
        Next
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub tbFirma(ByVal nFirmaID As Int64, ByVal yeni As Boolean)
        Dim frm As New frm_firma_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.yeni = yeni
        frm.nFirmaID = nFirmaID
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbFirma_sil(ByVal nFirmaID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If sorgu_nkayit_kontrol(nFirmaID) = 0 Then
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("set implicit_transactions on")
            cmd.ExecuteNonQuery()
            Try
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbHesapSinifi where nHesapID = " & nFirmaID & " ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbHesapPlani where nHesapID = " & nFirmaID & "")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
                cmd.ExecuteNonQuery()
            End Try
            con.Close()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Public Function sorgu_nkayit_kontrol(ByVal nFirmaID As String) As Int64
        Dim kriter
        kriter = "WHERE (nFirmaID = '" & nFirmaID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(count(nFirmaID),0) as nKayit from tbFirmaHareketi " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
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
            Dim frm As New frm_HesapPlani_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sKodu")
            frm.nHesapID = dr("nHesapID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
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
            frm.bMuhasebe = True
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
    Private Sub analiz_bakiye()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sKodu")
            frm.txt_musteriNo.EditValue = dr("sKodu")
            frm.kullanici = kullanici
            frm.bMuhasebe = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.sKodu))) = True Then
                    frm.ShowDialog()
                End If
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
            frm.musterino = 0
            frm.nFirmaID = dr("nFirmaID")
            frm.sec_firma.Checked = True
            frm.rStokCari = True
            frm.sec_giris.Text = "[Tümü]"
            frm.sec_firma.Enabled = False
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_fiyatlari(Optional ByVal ara As String = "")
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok
            frm.islemstatus = True
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.bFatura = True
            If ara <> "" Then
                frm.qgelismis = "Baþlar"
                frm.gelismis = ara
                frm.status = True
                frm.mevcut = 1
            End If
            frm.kullanici = kullanici
            frm.sFiyatTipi = Trim(dr("sFiyatTipi").ToString)
            frm.ShowDialog()
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
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
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
                Me.Close()
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
                    Me.Close()
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_cari_hareket()
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If islemstatus = True Then
            If e.KeyCode = Keys.Enter Then
                ara()
                PanelControl3.Focus()
                PanelControl3.Select()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        tbFirma(0, True)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_Firma_karti()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        satir_sil()
    End Sub
    Private Sub satir_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
                    tbFirma_sil(dr("nHesapID"))
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
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If MenuItem26.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem26.Checked = True
        ElseIf MenuItem26.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem26.Checked = False
        End If
    End Sub
    Private Sub btn_Ara_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ara.ItemClick
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub btn_Ekle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ekle.ItemClick
        tbFirma(0, True)
    End Sub
    Private Sub btn_Duzelt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Duzelt.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub btn_Sil_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Sil.ItemClick
        satir_sil()
    End Sub
    Private Sub btn_GorunumYazdir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_GorunumYazdir.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub btn_Iletisim_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Iletisim.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub btn_FirmaHareketleri_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FirmaHareketleri.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub btn_StokHareketleri_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_StokHareketleri.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_bakiye()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        analiz_bakiye()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_stok_fiyatlari()
    End Sub
    Friend WithEvents colsAlternatifAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col01 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cols02 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cols03 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cols04 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cols05 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cols06 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel_Seviye As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CheckButton6 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CheckButton5 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CheckButton4 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CheckButton3 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CheckButton2 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CheckButton1 As DevExpress.XtraEditors.CheckButton
    Private Sub CheckButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckButton6.CheckedChanged
        If CheckButton6.Checked = True Then
            CheckButton1.Checked = True
            CheckButton2.Checked = True
            CheckButton3.Checked = True
            CheckButton4.Checked = True
            CheckButton5.Checked = True
            ara()
        End If
    End Sub
    Private Sub CheckButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckButton5.CheckedChanged
        If CheckButton5.Checked = True Then
            CheckButton1.Checked = True
            CheckButton2.Checked = True
            CheckButton3.Checked = True
            CheckButton4.Checked = True
            ara()
        Else
            CheckButton6.Checked = False
            ara()
        End If
    End Sub
    Private Sub CheckButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckButton4.CheckedChanged
        If CheckButton4.Checked = True Then
            CheckButton1.Checked = True
            CheckButton2.Checked = True
            CheckButton3.Checked = True
            ara()
        Else
            CheckButton5.Checked = False
            CheckButton6.Checked = False
            ara()
        End If
    End Sub
    Private Sub CheckButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckButton3.CheckedChanged
        If CheckButton3.Checked = True Then
            CheckButton1.Checked = True
            CheckButton2.Checked = True
            ara()
        Else
            CheckButton4.Checked = False
            CheckButton5.Checked = False
            CheckButton6.Checked = False
            ara()
        End If
    End Sub
    Private Sub CheckButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckButton2.CheckedChanged
        If CheckButton2.Checked = True Then
            CheckButton1.Checked = True
            ara()
        Else
            CheckButton3.Checked = False
            CheckButton4.Checked = False
            CheckButton5.Checked = False
            CheckButton6.Checked = False
            ara()
        End If
    End Sub

    Private Sub btn_Seviye_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Seviye.CheckedChanged
        If btn_Seviye.Checked = True Then
            Panel_Seviye.Visible = True
            btn_Seviye.Text = "Seviye Gizle"
        ElseIf btn_Seviye.Checked = False Then
            Panel_Seviye.Visible = False
            btn_Seviye.Text = "Seviye Göster"
        End If
    End Sub
End Class
