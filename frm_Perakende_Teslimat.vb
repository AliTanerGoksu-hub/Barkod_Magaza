Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_Perakende_Teslimat
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
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents txt_dteTeslimEdilecek1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteTeslimEdilecek2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFaturaTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFaturaTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_musteri_adi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kasiyer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kasiyer_kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_magaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents coldteTeslimEdilecek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGCMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSiparisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagazaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEkAlan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEksiyeDusulebilirmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Sevkiyat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_dteSevkTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Perakende_Teslimat))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_sSinif2 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_magaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_kasiyer = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kasiyer_kod = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_musteri_adi = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musterino = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteFaturaTarihi2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteFaturaTarihi1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteTeslimEdilecek2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteTeslimEdilecek1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Sevkiyat = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_dteSevkTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldteTeslimEdilecek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGCMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSiparisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagazaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEkAlan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEksiyeDusulebilirmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFaturaTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFaturaTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFaturaTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFaturaTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteTeslimEdilecek2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteTeslimEdilecek2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteTeslimEdilecek1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteTeslimEdilecek1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_dteSevkTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSevkTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.####"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.####}")})
        Me.collKalan.Visible = True
        Me.collKalan.VisibleIndex = 12
        Me.collKalan.Width = 66
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
        Me.PanelControl1.Size = New System.Drawing.Size(1254, 223)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.lbl_sSinif2)
        Me.GroupControl1.Controls.Add(Me.sec_magaza)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.lbl_kasiyer)
        Me.GroupControl1.Controls.Add(Me.txt_kasiyer_kod)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.lbl_musteri_adi)
        Me.GroupControl1.Controls.Add(Me.txt_musterino)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txt_dteFaturaTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_dteFaturaTarihi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_dteTeslimEdilecek2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_dteTeslimEdilecek1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Location = New System.Drawing.Point(158, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(748, 216)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'lbl_sSinif2
        '
        Me.lbl_sSinif2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sSinif2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_sSinif2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_sSinif2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_sSinif2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_sSinif2.Location = New System.Drawing.Point(526, 181)
        Me.lbl_sSinif2.Name = "lbl_sSinif2"
        Me.lbl_sSinif2.Size = New System.Drawing.Size(213, 29)
        Me.lbl_sSinif2.TabIndex = 26
        Me.lbl_sSinif2.Text = "*"
        '
        'sec_magaza
        '
        Me.sec_magaza.Location = New System.Drawing.Point(136, 56)
        Me.sec_magaza.Name = "sec_magaza"
        Me.sec_magaza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_magaza.Properties.Appearance.Options.UseFont = True
        Me.sec_magaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_magaza.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açýklama")})
        Me.sec_magaza.Properties.DisplayMember = "sAciklama"
        Me.sec_magaza.Properties.NullText = "[Maðaza]"
        Me.sec_magaza.Properties.ValueMember = "sDepo"
        Me.sec_magaza.Size = New System.Drawing.Size(160, 28)
        Me.sec_magaza.TabIndex = 25
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(62, 56)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl9.TabIndex = 24
        Me.LabelControl9.Text = "Maðaza:"
        '
        'lbl_kasiyer
        '
        Me.lbl_kasiyer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kasiyer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_kasiyer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_kasiyer.Location = New System.Drawing.Point(342, 24)
        Me.lbl_kasiyer.Name = "lbl_kasiyer"
        Me.lbl_kasiyer.Size = New System.Drawing.Size(11, 21)
        Me.lbl_kasiyer.TabIndex = 23
        Me.lbl_kasiyer.Text = "*"
        '
        'txt_kasiyer_kod
        '
        Me.txt_kasiyer_kod.Location = New System.Drawing.Point(136, 24)
        Me.txt_kasiyer_kod.Name = "txt_kasiyer_kod"
        Me.txt_kasiyer_kod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kasiyer_kod.Properties.NullText = "[Kasiyer]"
        Me.txt_kasiyer_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kasiyer_kod.Size = New System.Drawing.Size(160, 26)
        Me.txt_kasiyer_kod.TabIndex = 22
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(66, 24)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl8.TabIndex = 21
        Me.LabelControl8.Text = "Kasiyer:"
        '
        'lbl_musteri_adi
        '
        Me.lbl_musteri_adi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_musteri_adi.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_musteri_adi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_musteri_adi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_musteri_adi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_musteri_adi.Location = New System.Drawing.Point(342, 87)
        Me.lbl_musteri_adi.Name = "lbl_musteri_adi"
        Me.lbl_musteri_adi.Size = New System.Drawing.Size(397, 29)
        Me.lbl_musteri_adi.TabIndex = 20
        Me.lbl_musteri_adi.Text = "*"
        '
        'txt_musterino
        '
        Me.txt_musterino.Location = New System.Drawing.Point(136, 87)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musterino.Properties.NullText = "[MüþteriNo]"
        Me.txt_musterino.Size = New System.Drawing.Size(160, 26)
        Me.txt_musterino.TabIndex = 19
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(45, 87)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "MüþteriNo:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(506, 150)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(120, 29)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Arasýndaki"
        '
        'txt_dteFaturaTarihi2
        '
        Me.txt_dteFaturaTarihi2.EditValue = Nothing
        Me.txt_dteFaturaTarihi2.EnterMoveNextControl = True
        Me.txt_dteFaturaTarihi2.Location = New System.Drawing.Point(342, 150)
        Me.txt_dteFaturaTarihi2.Name = "txt_dteFaturaTarihi2"
        Me.txt_dteFaturaTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFaturaTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteFaturaTarihi2.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteFaturaTarihi2.TabIndex = 14
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(301, 133)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 28)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "ve"
        '
        'txt_dteFaturaTarihi1
        '
        Me.txt_dteFaturaTarihi1.EditValue = Nothing
        Me.txt_dteFaturaTarihi1.EnterMoveNextControl = True
        Me.txt_dteFaturaTarihi1.Location = New System.Drawing.Point(136, 150)
        Me.txt_dteFaturaTarihi1.Name = "txt_dteFaturaTarihi1"
        Me.txt_dteFaturaTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFaturaTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteFaturaTarihi1.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteFaturaTarihi1.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(-2, 150)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(130, 29)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "AlýþVeriþTarihi:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(506, 119)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(120, 28)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Arasýndaki"
        '
        'txt_dteTeslimEdilecek2
        '
        Me.txt_dteTeslimEdilecek2.EditValue = Nothing
        Me.txt_dteTeslimEdilecek2.EnterMoveNextControl = True
        Me.txt_dteTeslimEdilecek2.Location = New System.Drawing.Point(342, 119)
        Me.txt_dteTeslimEdilecek2.Name = "txt_dteTeslimEdilecek2"
        Me.txt_dteTeslimEdilecek2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteTeslimEdilecek2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteTeslimEdilecek2.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteTeslimEdilecek2.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(301, 106)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 28)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "ve"
        '
        'txt_dteTeslimEdilecek1
        '
        Me.txt_dteTeslimEdilecek1.EditValue = Nothing
        Me.txt_dteTeslimEdilecek1.EnterMoveNextControl = True
        Me.txt_dteTeslimEdilecek1.Location = New System.Drawing.Point(136, 119)
        Me.txt_dteTeslimEdilecek1.Name = "txt_dteTeslimEdilecek1"
        Me.txt_dteTeslimEdilecek1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteTeslimEdilecek1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteTeslimEdilecek1.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteTeslimEdilecek1.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(-2, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 28)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "TeslimTarihi:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(136, 181)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(366, 29)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "&Listele"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(844, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(408, 219)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btn_Sevkiyat)
        Me.PanelControl2.Controls.Add(Me.txt_dteSevkTarihi)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 625)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1254, 68)
        Me.PanelControl2.TabIndex = 1
        '
        'btn_Sevkiyat
        '
        Me.btn_Sevkiyat.Enabled = False
        Me.btn_Sevkiyat.Image = CType(resources.GetObject("btn_Sevkiyat.Image"), System.Drawing.Image)
        Me.btn_Sevkiyat.Location = New System.Drawing.Point(584, 17)
        Me.btn_Sevkiyat.Name = "btn_Sevkiyat"
        Me.btn_Sevkiyat.Size = New System.Drawing.Size(173, 29)
        Me.btn_Sevkiyat.TabIndex = 13
        Me.btn_Sevkiyat.Text = "&Sevkiyat"
        '
        'txt_dteSevkTarihi
        '
        Me.txt_dteSevkTarihi.EditValue = Nothing
        Me.txt_dteSevkTarihi.EnterMoveNextControl = True
        Me.txt_dteSevkTarihi.Location = New System.Drawing.Point(424, 17)
        Me.txt_dteSevkTarihi.Name = "txt_dteSevkTarihi"
        Me.txt_dteSevkTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteSevkTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteSevkTarihi.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteSevkTarihi.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(286, 17)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(130, 29)
        Me.LabelControl10.TabIndex = 8
        Me.LabelControl10.Text = "Teslim Tarihi:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1117, 11)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(997, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 223)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1254, 402)
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
        Me.GridControl1.Size = New System.Drawing.Size(1250, 398)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem13, Me.MenuItem14, Me.MenuItem18, Me.MenuItem15, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 6
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Stok Envanter"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 7
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Stok Hareketleri"
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
        Me.MenuItem5.Index = 14
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
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
        Me.MenuItem7.Index = 17
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
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
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "dteTeslimEdilecek"
        Me.DataColumn1.DataType = GetType(Date)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "dteFaturaTarihi"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lFaturaNo"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sKodu"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAciklama"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "lGCMiktar"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lBrutFiyat"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lNetTutar"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "nStokID"
        Me.DataColumn9.DataType = GetType(Long)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "lFiyat"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lTutar"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "nKdvOrani"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nSiparisID"
        Me.DataColumn13.DataType = GetType(Long)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sHareketTipi"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sMagazaKodu"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sFisTipi"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lMevcut"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "bEkAlan1"
        Me.DataColumn18.DataType = GetType(Boolean)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "bEksiyeDusulebilirmi"
        Me.DataColumn19.DataType = GetType(Boolean)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sRenk"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sRenkAdi"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sBeden"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteTeslimEdilecek, Me.coldteFaturaTarihi, Me.collFaturaNo, Me.colsKodu, Me.colsAciklama, Me.collGCMiktar, Me.collBrutFiyat, Me.collNetTutar, Me.colnStokID, Me.collFiyat, Me.collTutar, Me.colnKdvOrani, Me.colnSiparisID, Me.colsHareketTipi, Me.colsMagazaKodu, Me.colsFisTipi, Me.collMevcut, Me.colbEkAlan1, Me.colbEksiyeDusulebilirmi, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.collIskontoTutar, Me.colnIskontoYuzdesi, Me.collKalan, Me.collBrutMevcut})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(377, 305, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.collKalan
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Column = Me.collKalan
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt")})
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'coldteTeslimEdilecek
        '
        Me.coldteTeslimEdilecek.Caption = "TeslimEdilecek"
        Me.coldteTeslimEdilecek.FieldName = "dteTeslimEdilecek"
        Me.coldteTeslimEdilecek.Name = "coldteTeslimEdilecek"
        Me.coldteTeslimEdilecek.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTeslimEdilecek", "{0} Kayýt")})
        Me.coldteTeslimEdilecek.Visible = True
        Me.coldteTeslimEdilecek.VisibleIndex = 0
        Me.coldteTeslimEdilecek.Width = 76
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "FaturaTarihi"
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 66
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "FaturaNo"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 3
        Me.collFaturaNo.Width = 52
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 4
        Me.colsKodu.Width = 58
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 5
        Me.colsAciklama.Width = 127
        '
        'collGCMiktar
        '
        Me.collGCMiktar.Caption = "Miktar"
        Me.collGCMiktar.DisplayFormat.FormatString = "#,0.00##"
        Me.collGCMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGCMiktar.FieldName = "lGCMiktar"
        Me.collGCMiktar.Name = "collGCMiktar"
        Me.collGCMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGCMiktar", "{0:#,0.00##}")})
        Me.collGCMiktar.Visible = True
        Me.collGCMiktar.VisibleIndex = 7
        Me.collGCMiktar.Width = 38
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Brüt Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 8
        Me.collBrutFiyat.Width = 50
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00##}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 9
        Me.collNetTutar.Width = 49
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok ID"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'collFiyat
        '
        Me.collFiyat.Caption = "Fiyat"
        Me.collFiyat.FieldName = "lFiyat"
        Me.collFiyat.Name = "collFiyat"
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00##}")})
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.00##"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.Visible = True
        Me.colnKdvOrani.VisibleIndex = 10
        Me.colnKdvOrani.Width = 31
        '
        'colnSiparisID
        '
        Me.colnSiparisID.Caption = "Sipariþ ID"
        Me.colnSiparisID.FieldName = "nSiparisID"
        Me.colnSiparisID.Name = "colnSiparisID"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colsMagazaKodu
        '
        Me.colsMagazaKodu.Caption = "MagazaKodu"
        Me.colsMagazaKodu.FieldName = "sMagazaKodu"
        Me.colsMagazaKodu.Name = "colsMagazaKodu"
        Me.colsMagazaKodu.Width = 77
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 2
        Me.colsFisTipi.Width = 45
        '
        'collMevcut
        '
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,0.####"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        Me.collMevcut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMevcut", "{0:#,0.####}")})
        Me.collMevcut.Visible = True
        Me.collMevcut.VisibleIndex = 11
        Me.collMevcut.Width = 51
        '
        'colbEkAlan1
        '
        Me.colbEkAlan1.Caption = "EkAlan1"
        Me.colbEkAlan1.FieldName = "bEkAlan1"
        Me.colbEkAlan1.Name = "colbEkAlan1"
        '
        'colbEksiyeDusulebilirmi
        '
        Me.colbEksiyeDusulebilirmi.Caption = "Eksiye Düþebilirmi"
        Me.colbEksiyeDusulebilirmi.FieldName = "bEksiyeDusulebilirmi"
        Me.colbEksiyeDusulebilirmi.Name = "colbEksiyeDusulebilirmi"
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
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 6
        Me.colsRenkAdi.Width = 107
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'collIskontoTutar
        '
        Me.collIskontoTutar.Caption = "IskontoTutar"
        Me.collIskontoTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collIskontoTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutar.FieldName = "lIskontoTutar"
        Me.collIskontoTutar.Name = "collIskontoTutar"
        Me.collIskontoTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskontoTutar", "{0:#,0.00##}")})
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "Ýskonto Yüzdesi"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatString = "#,0.00##"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        '
        'collBrutMevcut
        '
        Me.collBrutMevcut.Caption = "Brüt Mevcut"
        Me.collBrutMevcut.DisplayFormat.FormatString = "#,0.####"
        Me.collBrutMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutMevcut.FieldName = "lBMevcut"
        Me.collBrutMevcut.Name = "collBrutMevcut"
        Me.collBrutMevcut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBMevcut", "{0:#,0.####}")})
        Me.collBrutMevcut.Visible = True
        Me.collBrutMevcut.VisibleIndex = 13
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Bekleyen AlýþVeriþler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True)})
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
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Fisi Goster"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Envanter,F6"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Müþteri Kartý"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Excel"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Text"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Mail"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1254, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 693)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1254, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 693)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1254, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 693)
        '
        'frm_Perakende_Teslimat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1254, 723)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Perakende_Teslimat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teslimat Ýþlemi..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFaturaTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFaturaTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFaturaTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFaturaTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteTeslimEdilecek2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteTeslimEdilecek2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteTeslimEdilecek1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteTeslimEdilecek1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_dteSevkTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSevkTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public islemstatus As Boolean = False
    Public nSiparisTipi As String
    Public sKasiyerRumuzu As String
    Public sKasiyer As String
    Public sMagaza As String
    Public nMusteriID As Int64 = 0
    Public lKodu As String = 0
    Public sAdi As String = ""
    Public sSoyadi As String = ""
    Public sAdres1 As String = ""
    Public sAdres2 As String = ""
    Public emir_musteri_takipMi As Boolean = False
    Public emir_musteri_takip_kartID As String = ""
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Dim ds_satici As DataSet
    Dim ds_alislar As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_satir_firma As DataSet
    Public fistipi As String
    Public tarih As DateTime
    Public firmaID As String
    Public fisno As String
    Public ngiriscikis As String
    Dim ds_stok As DataSet
    Dim ds_stok_fisi As DataSet
    Dim ds_stok_barkod As DataSet
    Dim ds_stok_sinif As DataSet
    Dim ds_firma As DataSet
    Dim ds_renk As DataSet
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
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_depo()
        sec_magaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDepo, sAciklama FROM tbDepo Where sDepo <> '' ")).Tables(0)
        sec_magaza.ItemIndex = 0
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
        btn_Sevkiyat.Text = Sorgu_sDil(btn_Sevkiyat.Text, sDil)
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
    Public Function stok(ByVal nMusteriID As String, ByVal sDepo As String, ByVal dteTeslimEdilecek1 As DateTime, ByVal dteTeslimEdilecek2 As DateTime, ByVal dteFaturaTarihi1 As DateTime, ByVal dteFaturaTarihi2 As DateTime) As DataSet
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'emir_musteri_takip_kartID
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbStok.sKodu, tbStok.sAciklama, tbAlisverisSiparis.lGCMiktar, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbStok.nStokID, tbAlisverisSiparis.lFiyat, tbAlisverisSiparis.lTutar, tbAlisverisSiparis.nKdvOrani, tbAlisverisSiparis.nSiparisID, tbAlisVeris.sHareketTipi, tbAlisverisSiparis.sMagazaKodu, tbAlisVeris.sFisTipi, ISNULL((SELECT SUM(lGirisMiktar1) - SUM(lCikisMiktar1) FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.sDepo = '" & sDepo & "'), 0) AS lMevcut, tbAlisverisSiparis.bEkAlan1, tbStok.bEksiyeDusulebilirmi, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari FROM tbAlisverisSiparis INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisVeris.nMusteriID = '" & nMusteriID & "') AND (tbAlisverisSiparis.bTeslimEdildi = 0) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteFaturaTarihi1 & "' AND '" & dteFaturaTarihi2 & "') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '" & dteTeslimEdilecek1 & "' AND '" & dteTeslimEdilecek2 & "') ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbStok.sKodu")
        If emir_musteri_takipMi = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.nAlisVerisID, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbStok.sKodu, tbStok.sAciklama, tbStok.sBirimCinsi1, tbAlisverisSiparis.lGCMiktar, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbStok.nStokID, tbAlisverisSiparis.lFiyat, tbAlisverisSiparis.lTutar, tbAlisverisSiparis.nKdvOrani, tbAlisverisSiparis.nSiparisID, tbAlisVeris.sHareketTipi, tbAlisverisSiparis.sMagazaKodu, tbAlisVeris.sFisTipi, ISNULL((SELECT SUM(lGirisMiktar1) - SUM(lCikisMiktar1) FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.sDepo = tbAlisVerisSiparis.sMagazaKodu), 0) AS lMevcut, ISNULL((SELECT SUM(lGirisMiktar1) - SUM(lCikisMiktar1) FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID), 0) AS lBMevcut , ISNULL((SELECT SUM(lGirisMiktar1) - SUM(lCikisMiktar1) FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.sDepo = tbAlisverisSiparis.sMagazaKodu), 0)- ISNULL(tbAlisverisSiparis.lGCMiktar, 0) AS lKalan, tbAlisverisSiparis.bEkAlan1, tbStok.bEksiyeDusulebilirmi, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari, tbAlisVeris.nMusteriID, tbMusteri.lKodu, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5 FROM tbAlisverisSiparis INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisVeris.nMusteriID = '" & nMusteriID & "') AND (tbAlisverisSiparis.bTeslimEdildi = 0) AND (tbAlisverisSiparis.bEkAlan1 = 0) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteFaturaTarihi1 & "' AND '" & dteFaturaTarihi2 & "') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '" & dteTeslimEdilecek1 & "' AND '" & dteTeslimEdilecek2 & "') AND (tbAlisVeris.lFaturaNo IN(Select lFaturaNo From aEmirMusteriTakipUrunler Where IND = " & emir_musteri_takip_kartID & ")) AND (tbStok.sKodu IN(Select sKodu From aEmirMusteriTakipUrunler Where IND = " & emir_musteri_takip_kartID & ")) ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbStok.sKodu")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.nAlisVerisID, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbStok.sKodu, tbStok.sAciklama, tbStok.sBirimCinsi1, tbAlisverisSiparis.lGCMiktar, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbStok.nStokID, tbAlisverisSiparis.lFiyat, tbAlisverisSiparis.lTutar, tbAlisverisSiparis.nKdvOrani, tbAlisverisSiparis.nSiparisID, tbAlisVeris.sHareketTipi, tbAlisverisSiparis.sMagazaKodu, tbAlisVeris.sFisTipi, ISNULL((SELECT SUM(lGirisMiktar1) - SUM(lCikisMiktar1) FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.sDepo = tbAlisVerisSiparis.sMagazaKodu), 0) AS lMevcut, ISNULL((SELECT SUM(lGirisMiktar1) - SUM(lCikisMiktar1) FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID), 0) AS lBMevcut , ISNULL((SELECT SUM(lGirisMiktar1) - SUM(lCikisMiktar1) FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.sDepo = tbAlisverisSiparis.sMagazaKodu), 0)- ISNULL(tbAlisverisSiparis.lGCMiktar, 0) AS lKalan, tbAlisverisSiparis.bEkAlan1, tbStok.bEksiyeDusulebilirmi, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari, tbAlisVeris.nMusteriID, tbMusteri.lKodu, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5 FROM tbAlisverisSiparis INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisVeris.nMusteriID = '" & nMusteriID & "') AND (tbAlisverisSiparis.bTeslimEdildi = 0) AND (tbAlisverisSiparis.bEkAlan1 = 0) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteFaturaTarihi1 & "' AND '" & dteFaturaTarihi2 & "') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '" & dteTeslimEdilecek1 & "' AND '" & dteTeslimEdilecek2 & "') ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbStok.sKodu")
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
    Private Sub dataload(ByVal nMusteriID As String, ByVal sDepo As String, ByVal dteTeslimEdilecek1 As DateTime, ByVal dteTeslimEdilecek2 As DateTime, ByVal dteFaturaTarihi1 As DateTime, ByVal dteFaturaTarihi2 As DateTime)
        DataSet1 = stok(nMusteriID, sDepo, dteTeslimEdilecek1, dteTeslimEdilecek2, dteFaturaTarihi1, dteFaturaTarihi2)
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
            frm.musterino = dr("nMusteriID")
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
    Private Sub analiz_fis()
        Dim frm As New frm_Perakende_Satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.nAlisVerisID = dr("nAlisVerisID")
        frm.sFisTipi = Trim(dr("sFisTipi").ToString)
        frm.kullanici = kullanici
        frm.sMagaza = dr("sMagazaKodu")
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
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
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            GridView1.FocusedRowHandle = satir
            satir = Nothing
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
        End If
    End Sub
    Private Sub stok_satis_detay_kredi()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nAlisVerisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
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
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(nMusteriID, sec_magaza.EditValue, txt_dteTeslimEdilecek1.EditValue, txt_dteTeslimEdilecek2.EditValue, txt_dteFaturaTarihi1.EditValue, txt_dteFaturaTarihi2.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        If sDatabaseGenel = "UGURLU" Then
            lbl_sSinif2.Text = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMSinif2.sAciklama FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMusteri ON tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID Where tbMusteri.nMusteriID ='" & nMusteriID & "'")
            lbl_sSinif2.Text = Trim(lbl_sSinif2.Text)
        Else
            lbl_sSinif2.Text = ""
        End If
        If GridView1.RowCount = 0 And lbl_kasiyer.Text = "" Then
            btn_Sevkiyat.Enabled = False
        ElseIf GridView1.RowCount > 0 And lbl_kasiyer.Text <> "" Then
            If lbl_sSinif2.Text = "" Or lbl_sSinif2.Text = "NORMAL" Or lbl_sSinif2.Text = "ÜRÜNÜ KENDÝ ALACAK" Then
                btn_Sevkiyat.Enabled = True
            Else
                btn_Sevkiyat.Enabled = False
            End If
        End If
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub kasiyer_kontrol(Optional ByVal status As Boolean = False)
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
            Try
                sec_magaza.EditValue = sAktifTeslimatDepo
                If sAktifTeslimatDepo = "" Then
                    sec_magaza.EditValue = sMagaza
                End If
            Catch ex As Exception
                sec_magaza.EditValue = sMagaza
            End Try
            txt_kasiyer_kod.Enabled = False
            GridControl1.Enabled = True
            GridControl1.Focus()
            GridControl1.Select()
            'PanelControl2.Enabled = True
            'BarSubItem1.Enabled = True
            txt_dteSevkTarihi.Enabled = True
            btn_Sevkiyat.Enabled = True
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf sonuc = False Then
            lbl_kasiyer.Text = ""
            txt_kasiyer_kod.Enabled = True
            txt_kasiyer_kod.EditValue = ""
            GridControl1.Enabled = False
            txt_dteSevkTarihi.Enabled = False
            btn_Sevkiyat.Enabled = False
            'PanelControl2.Enabled = False
            'BarSubItem1.Enabled = False
            If status = False Then
                If XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                    txt_kasiyer_kod.Focus()
                    txt_kasiyer_kod.SelectAll()
                End If
            Else
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nMusteriID = dr1("nMusteriID")
            lKodu = dr1("lKodu")
            'lbl_musteri_adi.Text = dr1("Musteri")
            txt_musterino.EditValue = lKodu
            musteri_kontrol()
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musterino.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musterino.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musterino.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    lKodu = dr("MUSTERIKODU")
                    nMusteriID = dr("IND")
                    lbl_musteri_adi.Text = dr("MUSTERI")
                    sAdi = dr("sAdi")
                    sSoyadi = dr("sSoyadi")
                    sAdres1 = dr("sAdres1")
                    sAdres2 = dr("sAdres2")
                    ara()
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nMusteriID AS IND, lKodu AS MUSTERIKODU,sAdi,sSoyadi, sAdi + ' ' + sSoyadi AS MUSTERI,sEvAdresi1 as sAdres1, sEvAdresi2 as sAdres2 FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
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
                lbl_istihbarat.Text = dr("sAciklama1").ToString + " " + dr("sAciklama2").ToString + " " + dr("sAciklama3").ToString + " " + dr("sAciklama4").ToString + " " + dr("sAciklama5").ToString
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
        analiz_musteri_karti()
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
        analiz_envanter()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        stok_satis_detay()
    End Sub
    Private Sub frm_Perakende_Teslimat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("Teslimat").SetValue("dteSevkTarihi", txt_dteSevkTarihi.EditValue)
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dteSevkTarihi As DateTime
        Try
            dteSevkTarihi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("Perakende").OpenSubKey("Teslimat").GetValue("dteSevkTarihi").ToString
        Catch ex As Exception
            dteSevkTarihi = dteSistemTarihi
        End Try
        If dteSevkTarihi < dteSistemTarihi Then
            dteSevkTarihi = dteSistemTarihi
        End If
        txt_dteSevkTarihi.EditValue = dteSevkTarihi
        dataload_kasiyer()
        dataload_depo()
        txt_dteTeslimEdilecek1.EditValue = "01/01/1900"
        txt_dteTeslimEdilecek2.EditValue = "31/12/2048"
        txt_dteFaturaTarihi1.EditValue = "01/01/1900"
        txt_dteFaturaTarihi2.EditValue = "31/12/2048"
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        If yetki_kontrol(kullanici, "frm_Perakende_Teslimat_Magaza", False) = True Then
            sec_magaza.Properties.ReadOnly = False
        Else
            sec_magaza.Properties.ReadOnly = True
        End If
        kasiyer_kontrol(True)
        ara()
        'txt_dteFisTarihi1.Focus()
        'txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteTeslimEdilecek1.Focus()
        txt_dteTeslimEdilecek1.Select()
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        End If
    End Sub
    Private Sub txt_musterino_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_musterino.Validated
        musteri_kontrol()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sevkiyat.Click
        If GridView1.RowCount > 0 Then
            If GridView1.SelectedRowsCount > 0 Then
                sevkiyat(txt_musterino.Text, nMusteriID, txt_dteSevkTarihi.EditValue, sec_magaza.EditValue)
                ara()
            End If
        End If
    End Sub
    Private Sub sevkiyat(ByVal lKodu As String, ByVal nMusteriID As String, ByVal dteFisTarihi As DateTime, ByVal sDepo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sevkiyat Fiþini Düzenlemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow
            Dim fis_kayit_sayisi As Int64 = 0
            Dim stok_kayit_sayisi As Int64 = 0
            Dim cari_kayit_sayisi As Int64 = 0
            Dim barkod_var As Boolean = False
            Dim nStokID As Int64 = 0
            Dim nFirmaID As Int64 = 0
            Dim nStokFisiID As Int64 = 0
            Dim nIslemID As Int64 = 0
            Dim s_nIslemID As String = " AND tbStokFisiDetayi.nIslemID IN( "
            Dim nHareketID As Int64 = 0
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim sayi = 0
            Dim sonra_sorgu_calis As String = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    cari_kayit_sayisi = sorgu_firma_kontrol("NTuk")
                    If cari_kayit_sayisi = 0 Then
                        'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
                        nFirmaID = firma_kaydet_yeni("NTuk", "Nihai Tüketici (Son Kullanýcý)", 0, 0, "01/01/1900", 0, "", "", "", "", "", "", "", "", "", 0, "", kullanici, Now, "")
                        firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
                    Else
                        nFirmaID = cari_kayit_sayisi
                    End If
                    'fis_kayit_sayisi = sorgu_fis_kontrol("PF", 3, dteFisTarihi, lKodu, nFirmaID)
                    '1 den fazla Fiþ Ýçin Deðiþti: Ayný gün içinde yapýlan tüm sevkiyatlar artýk ayrý ayrý fiþlere yazýlacak.
                    'fis_kontrolleri()
                    If fis_kayit_sayisi = 0 Then
                        fis_kayit_sayisi = 1
                        'BAÞLIK
                        nStokFisiID = sorgu_nStokFisiID()
                        nStokFisiID = master_kaydet_yeni(nStokFisiID, "PF", dteFisTarihi, 3, lKodu, nFirmaID, sDepo, dteFisTarihi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", 0, 1, 0, "", "", 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0)
                        'master_kaydet_yeni(nStokFisiID, "PF", dteFisTarihi, 3, lKodu, nFirmaID, sDepo, dteFisTarihi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", "", 0, 1, 0, "", "", 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0)
                        fis_Master_fisno_degistir(nStokFisiID)
                        aciklama_kaydet_yeni(nStokFisiID, "Teslimat...", "", "", "", "")
                        'HAREKET
                        nIslemID = sorgu_nStokIslemID()
                        nStokID = dr("nStokID")
                        'nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, dr("nMusteriID"), "PF", dteFisTarihi, dr("lKodu"), 3, dr("sMagazaKodu"), 0, "", "", dr("sSaticiRumuzu"), "", dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lFiyat"), dr("lTutar"), dr("sFiyatTipi").ToString, dr("sBirimCinsi1"), 1, dr("lFiyat"), dr("lTutar"), 0, 0, 0, 0, 0, "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("nSiparisID"), dr("sHareketTipi").ToString, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, 0, "", nStokFisiID, "", "", "PF", 0, 0, 0, 0, kullanici, Now)
                        nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, dr("nMusteriID"), "PF", dteFisTarihi, dr("lKodu"), 3, sDepo, 0, "", "", dr("sSaticiRumuzu"), "", dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lFiyat"), dr("lTutar"), dr("sFiyatTipi").ToString, dr("sBirimCinsi1"), 1, dr("lFiyat"), dr("lTutar"), 0, 0, 0, 0, 0, "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("nSiparisID"), dr("sHareketTipi").ToString, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, 0, dr("nAlisverisID"), nStokFisiID, "", "", "PF", 0, 0, 0, 0, kullanici, Now)
                        'detay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, dr("nMusteriID"), "PF", dteFisTarihi, dr("lKodu"), 3, dr("sMagazaKodu"), 0, "", "", dr("sSaticiRumuzu"), "", dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lFiyat"), dr("lTutar"), dr("sFiyatTipi").ToString, dr("sBirimCinsi1"), 1, dr("lFiyat"), dr("lTutar"), 0, 0, 0, 0, 0, "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("nSiparisID"), dr("sHareketTipi").ToString, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, 0, "", nStokFisiID, "", "", "PF", 0, 0, 0, 0, kullanici, Now)
                        fis_detay_fisno_degistir(nIslemID)
                        'nSiparisID_degistir(dr("nAlisVerisID"), dr("sMagazaKodu"), nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi)
                        nSiparisID_degistir(dr("nAlisVerisID"), sDepo, nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi, dr("sMagazaKodu"))
                        tbAlisverisTeslimat_degistir(dr("nAlisVerisID"), sDepo, nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi, dr("sMagazaKodu"))
                        'sonra_sorgu_calis += nSiparisID_degistir_sonra(dr("nAlisVerisID"), sDepo, nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi, dr("sMagazaKodu")) + "; "
                        s_nIslemID += nIslemID.ToString
                        sayi += 1
                        If sayi < toplamsayi Then
                            s_nIslemID += ","
                        ElseIf sayi = toplamsayi Then
                            s_nIslemID += ")"
                        End If
                    Else
                        'BAÞLIK
                        'nStokFisiID = fis_kayit_sayisi.ToString
                        'HAREKET
                        nIslemID = sorgu_nStokIslemID()
                        nStokID = dr("nStokID")
                        'nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, dr("nMusteriID"), "PF", dteFisTarihi, dr("lKodu"), 3, dr("sMagazaKodu"), 0, "", "", dr("sSaticiRumuzu"), "", dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lFiyat"), dr("lTutar"), dr("sFiyatTipi").ToString, dr("sBirimCinsi1"), 1, dr("lFiyat"), dr("lTutar"), 0, 0, 0, 0, 0, "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("nSiparisID"), dr("sHareketTipi").ToString, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, 0, "", nStokFisiID, "", "", "PF", 0, 0, 0, 0, kullanici, Now)
                        nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, dr("nMusteriID"), "PF", dteFisTarihi, dr("lKodu"), 3, sDepo, 0, "", "", dr("sSaticiRumuzu"), "", dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lFiyat"), dr("lTutar"), dr("sFiyatTipi").ToString, dr("sBirimCinsi1"), 1, dr("lFiyat"), dr("lTutar"), 0, 0, 0, 0, 0, "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("nSiparisID"), dr("sHareketTipi").ToString, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, 0, "", nStokFisiID, "", "", "PF", 0, 0, 0, 0, kullanici, Now)
                        'nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, dr("nMusteriID"), "PF", dteFisTarihi, dr("lKodu"), 3, sDepo, 0, "", "", dr("sSaticiRumuzu"), "", dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lFiyat"), dr("lTutar"), dr("sFiyatTipi").ToString, dr("sBirimCinsi1"), 1, dr("lFiyat"), dr("lTutar"), 0, 0, 0, 0, 0, "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("nSiparisID"), dr("sHareketTipi").ToString, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, 0, "", nStokFisiID, "", "", "PF", 0, 0, 0, 0, kullanici, Now)
                        'detay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, dr("nMusteriID"), "PF", dteFisTarihi, dr("lKodu"), 3, dr("sMagazaKodu"), 0, "", "", dr("sSaticiRumuzu"), "", dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lFiyat"), dr("lTutar"), dr("sFiyatTipi").ToString, dr("sBirimCinsi1"), 1, dr("lFiyat"), dr("lTutar"), 0, 0, 0, 0, 0, "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("nSiparisID"), dr("sHareketTipi").ToString, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, 0, "", nStokFisiID, "", "", "PF", 0, 0, 0, 0, kullanici, Now)
                        fis_detay_fisno_degistir(nIslemID)
                        'nSiparisID_degistir(dr("nAlisVerisID"), dr("sMagazaKodu"), nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi)
                        'nSiparisID_degistir(dr("nAlisVerisID"), dr("sMagazaKodu"), nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi)
                        nSiparisID_degistir(dr("nAlisVerisID"), sDepo, nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi, dr("sMagazaKodu"))
                        'nSiparisID_degistir(dr("nAlisVerisID"), sDepo, nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi, dr("sMagazaKodu"))
                        'sonra_sorgu_calis += nSiparisID_degistir_sonra(dr("nAlisVerisID"), sDepo, nIslemID, dr("nSiparisID"), Today, 1, dteFisTarihi, dr("sMagazaKodu")) + "; "
                        s_nIslemID += nIslemID.ToString()
                        sayi += 1
                        If sayi < toplamsayi Then
                            s_nIslemID += ","
                        ElseIf sayi = toplamsayi Then
                            s_nIslemID += ")"
                        End If
                    End If
                Next
                'fis_resmi_kayit_kontrol()
                fis_duzelt(nFirmaID, lKodu, dteFisTarihi, "PF", 3, nStokFisiID, sonra_sorgu_calis, s_nIslemID)
                dr = Nothing
                fis_kayit_sayisi = Nothing
                stok_kayit_sayisi = Nothing
                cari_kayit_sayisi = Nothing
            End If
        End If
    End Sub
    'Private Function fis_kontrolleri() As Boolean
    '    Dim lKrediLimiti = sorgu(sorgu_query("Select lKrediLimiti from tbMusteriKredisi where nMusteriID = '" & nMusteriID & "'"))

    '    Dim bLimitAsimiIzinlimi = sorgu(sorgu_query("Select bLimitAsimiIzinlimi from tbParamAlisveris where sMagazaKodu = '" & sDepo & "'"))
    '    Dim pass As Boolean = False
    '    Dim bCikisIptal As Integer = -1
    '    Try
    '        If "bLimitAsimiIzinlimi" = False Then
    '            Dim ds_TaksitKalan As DataSet
    '            ds_TaksitKalan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) As odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris On tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri On tbAlisVeris.nMusteriID = tbMusteri.nMusteriID On tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi "), "KalanTaksit")
    '            Dim drk As DataRow
    '            Dim lBakiye As Decimal = 0
    '            For Each drk In ds_TaksitKalan.Tables(0).Rows
    '                lBakiye += drk("KALAN")
    '            Next
    '            If lBakiye > lKrediLimiti And lKrediLimiti > 0 Then
    '                bCikisIptal = -2
    '            End If
    '            lBakiye = Nothing
    '            drk = Nothing
    '            ds_TaksitKalan = Nothing
    '        End If
    '    Catch ex As Exception
    '    End Try
    '    If bCikisIptal >= -2 Then
    '        XtraMessageBox.Show(Sorgu_sDil("Müþteri Kredi Limitini Aþamazsýnýz..." & vbCrLf & "Lütfen Sistem Yöneticinizle Görüþün!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    ElseIf bCikisIptal = -1 Then
    '        pass = True
    '    End If
    '    Return pass
    'End Function
    Public Function sorgu_firma_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(nFirmaID, 0) AS KAYIT FROM tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        Return kayitsayisi
    End Function
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True) As Int64
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        If resmi = True Then
            conn.ConnectionString = connection
        ElseIf resmi = False Then
            conn.ConnectionString = connection
        End If
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(nStokFisiID, 0) AS KAYIT FROM tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        Return kayitsayisi
    End Function
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
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        Return kayitsayisi
    End Function
    Public Function sorgu_nStokFisiID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokFisiID+1,0) AS nStokFisiID FROM         tbStokFisiMaster " & kriter & " Order by nStokFisiID DESC")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT MAX(nStokFisiID) + 1 AS nStokFisiID FROM tbStokFisiMaster")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'conn.Close()
        'cmd = Nothing
        'adapter = Nothing
        'Return kayitsayisi
        Return 1
    End Function
    Public Function sorgu_nStokIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'conn.Close()
        'cmd = Nothing
        'adapter = Nothing
        'Return kayitsayisi
        Return 1
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        Return kayitsayisi
    End Function
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbFirma                       (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & " , '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "',  '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & " , '" & sOzelNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Sub firma_siniflari_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi                       (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function master_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As Int64, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'nStokFisiID lerin deðeri hesaplanýp kayýt ediliyor.
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     (" & nStokFisiID & ", '" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function detay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As String, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", '" & nSiparisID & "', '" & nReceteNo & "', '" & nTransferID & "', '" & sTransferDepo & "', " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", '" & nTransferFirmaID & "',  '" & nAlisverisID & "', '" & nStokFisiID & "', '" & nIrsaliyeFisiID & "', '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,sBirimCinsi,lBirimMiktar) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL, NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "','" & sBirimCinsi & "'," & lBirimMiktar & ")")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi (nIslemID, nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,sBirimCinsi,lBirimMiktar) VALUES     (" & nIslemID & ", '" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "','" & sBirimCinsi & "'," & lBirimMiktar & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub aciklama_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub odemeplani_kaydet_yeni(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani                       (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     ('" & nStokFisiID & "', '" & dteVadeTarihi & "', " & lTutari & ", '" & sCariIslem & "', '" & nCariHareketID & "')")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        'Return hareketno
    End Sub
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

        cmd = Nothing
        con = Nothing
    End Function
    Private Sub fis_Master_fisno_degistir(ByVal nstokFisiID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSiraNo SET nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSiraNo SET nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub nSiparisID_degistir(ByVal nAlisVerisID As String, ByVal sMagazaKodu As String, ByVal nIslemID As Int64, ByVal nSiparisID As Int64, ByVal dteOnayTarihi As DateTime, ByVal bTeslimEdildi As Integer, ByVal dteTeslimEdilen As DateTime, Optional ByVal eskiDepo As String = "")
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Integer = 0
        Dim yeninSiparisID As Int64 = 0
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If Trim(eskiDepo) = "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSiparis SET dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", dteOnayTarihi = '" & dteOnayTarihi & "', nStokIslemID = " & nIslemID & ", sMagazaKodu = '" & sMagazaKodu & "' Where nSiparisID = '" & nSiparisID & "' and nAlisVerisID = '" & nAlisVerisID & "' and sMagazaKodu ='" & sMagazaKodu & "'")
        Else
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSiparis SET dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", dteOnayTarihi = '" & dteOnayTarihi & "', nStokIslemID = " & nIslemID & ", sMagazaKodu = '" & sMagazaKodu & "' Where nSiparisID = '" & nSiparisID & "' and nAlisVerisID = '" & nAlisVerisID & "' and sMagazaKodu ='" & eskiDepo & "'")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select count(*) from tbAlisverisSiparis where nSiparisID = " & nSiparisID & "")
            sayi = Integer.Parse(cmd.ExecuteScalar.ToString())
            If sayi > 0 Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL((max(nSiparisID) + 1), 1) from tbAlisverisSiparis where sMagazaKodu = '" & sMagazaKodu & "'")
                yeninSiparisID = Integer.Parse(cmd.ExecuteScalar.ToString())
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSiparis SET dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", dteOnayTarihi = '" & dteOnayTarihi & "', nStokIslemID = " & nIslemID & ", sMagazaKodu = '" & sMagazaKodu & "', nSiparisID = '" & yeninSiparisID & "' Where nSiparisID = '" & nSiparisID & "' and nAlisVerisID = '" & nAlisVerisID & "' and sMagazaKodu ='" & eskiDepo & "'")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSiparis SET dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", dteOnayTarihi = '" & dteOnayTarihi & "', nStokIslemID = " & nIslemID & ", sMagazaKodu = '" & sMagazaKodu & "' Where nSiparisID = '" & nSiparisID & "' and nAlisVerisID = '" & nAlisVerisID & "' and sMagazaKodu ='" & eskiDepo & "'")
            End If
        End If
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub tbAlisverisTeslimat_degistir(ByVal nAlisVerisID As String, ByVal sMagazaKodu As String, ByVal nIslemID As Int64, ByVal nSiparisID As Int64, ByVal dteOnayTarihi As DateTime, ByVal bTeslimEdildi As Integer, ByVal dteTeslimEdilen As DateTime, Optional ByVal eskiDepo As String = "")
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Integer = 0
        Dim yeninSiparisID As Int64 = 0
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisveris SET bTeslimEdildi = " & bTeslimEdildi & " Where nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub
    Private Function nSiparisID_degistir_sonra(ByVal nAlisVerisID As String, ByVal sMagazaKodu As String, ByVal nIslemID As Int64, ByVal nSiparisID As Int64, ByVal dteOnayTarihi As DateTime, ByVal bTeslimEdildi As Integer, ByVal dteTeslimEdilen As DateTime, Optional ByVal eskiDepo As String = "") As String
        Dim sorgu As String = ""
        If Trim(eskiDepo) = "" Then
            sorgu = sorgu_query("UPDATE tbAlisverisSiparis SET dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", dteOnayTarihi = '" & dteOnayTarihi & "', nStokIslemID = " & nIslemID & ", sMagazaKodu = '" & sMagazaKodu & "' Where nSiparisID = '" & nSiparisID & "' and nAlisVerisID = '" & nAlisVerisID & "' and sMagazaKodu ='" & sMagazaKodu & "'")
        Else
            sorgu = sorgu_query("UPDATE tbAlisverisSiparis SET dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", dteOnayTarihi = '" & dteOnayTarihi & "', nStokIslemID = " & nIslemID & ", sMagazaKodu = '" & sMagazaKodu & "' Where nSiparisID = '" & nSiparisID & "' and nAlisVerisID = '" & nAlisVerisID & "' and sMagazaKodu ='" & eskiDepo & "'")
        End If
        Return sorgu
    End Function
    Private Sub fis_Master_nCariHareketID_degistir(ByVal nCariHareketID As String)
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub fis_duzelt(ByVal nFirmaID As Int64, ByVal lKodu As String, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal nStokFisiID As String, ByVal sonra_sorgu_calis As String, Optional ByVal s_nIslemID As String = "")
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = lKodu
            frm.dteFisTarihi = dteFisTarihi
            frm.sFisTipi = sFisTipi
            frm.nFirmaID = nFirmaID
            frm.nGirisCikis = nGirisCikis
            frm.nStokFisiID = nStokFisiID
            frm.kullanici = kullanici
            frm.s_nIslemID = s_nIslemID
            'frm.sonra_sorgu_calis_teslimat = sonra_sorgu_calis
            frm.aktarim = True
            'If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
            'End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            ara()
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
    Private Sub txt_kasiyer_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kasiyer_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
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
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        txt_dteTeslimEdilecek1.Focus()
        txt_dteTeslimEdilecek1.Select()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_musteri_karti()
    End Sub
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        analiz_fis()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_pdf()
    End Sub
    Friend WithEvents lbl_sSinif2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents collBrutMevcut As DevExpress.XtraGrid.Columns.GridColumn
End Class
