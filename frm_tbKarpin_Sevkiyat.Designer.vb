<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tbKarpin_Sevkiyat
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbKarpin_Sevkiyat))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txt_lKdv = New DevExpress.XtraEditors.CalcEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lNetSatis = New DevExpress.XtraEditors.CalcEdit
        Me.txt_lIskonto = New DevExpress.XtraEditors.CalcEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnKayitID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnKarpinID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collY1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_lMiktar = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.collY2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collY3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collIade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSatis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_lTutar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_lKdv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lNetSatis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lIskonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_lMiktar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_lTutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(777, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(45, 13)
        Me.lbl_istihbarat.TabIndex = 47
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txt_lKdv)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txt_lNetSatis)
        Me.PanelControl2.Controls.Add(Me.txt_lIskonto)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 346)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 60)
        Me.PanelControl2.TabIndex = 1
        '
        'txt_lKdv
        '
        Me.txt_lKdv.Location = New System.Drawing.Point(246, 6)
        Me.txt_lKdv.Name = "txt_lKdv"
        Me.txt_lKdv.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKdv.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKdv.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lKdv.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lKdv.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lKdv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lKdv.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_lKdv.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lKdv.Properties.EditFormat.FormatString = "#,0.00##"
        Me.txt_lKdv.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lKdv.Properties.NullText = "0"
        Me.txt_lKdv.Size = New System.Drawing.Size(92, 20)
        Me.txt_lKdv.TabIndex = 21
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(197, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 20)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Kdv:"
        '
        'txt_lNetSatis
        '
        Me.txt_lNetSatis.Location = New System.Drawing.Point(99, 28)
        Me.txt_lNetSatis.Name = "txt_lNetSatis"
        Me.txt_lNetSatis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetSatis.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetSatis.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lNetSatis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lNetSatis.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lNetSatis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lNetSatis.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_lNetSatis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lNetSatis.Properties.EditFormat.FormatString = "#,0.00##"
        Me.txt_lNetSatis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lNetSatis.Properties.NullText = "0"
        Me.txt_lNetSatis.Size = New System.Drawing.Size(92, 20)
        Me.txt_lNetSatis.TabIndex = 19
        '
        'txt_lIskonto
        '
        Me.txt_lIskonto.Location = New System.Drawing.Point(99, 6)
        Me.txt_lIskonto.Name = "txt_lIskonto"
        Me.txt_lIskonto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lIskonto.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lIskonto.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lIskonto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lIskonto.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lIskonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lIskonto.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_lIskonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lIskonto.Properties.EditFormat.FormatString = "#,0.00##"
        Me.txt_lIskonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lIskonto.Size = New System.Drawing.Size(92, 20)
        Me.txt_lIskonto.TabIndex = 18
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(8, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 20)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "NetSatis:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(8, 6)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(86, 20)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "ToplamIskonto:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(732, 22)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(657, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "&Tamam"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(243, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 290)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_lTutar, Me.sec_lMiktar})
        Me.GridControl1.Size = New System.Drawing.Size(820, 286)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnKayitID, Me.colnKarpinID, Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.collY1, Me.collY2, Me.collY3, Me.collMiktar, Me.collIade, Me.collSatis, Me.collFiyat, Me.collTutar, Me.colbStatus})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(506, 252, 208, 184)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnKayitID
        '
        Me.colnKayitID.Caption = "Kayýt No"
        Me.colnKayitID.FieldName = "nKayitID"
        Me.colnKayitID.Name = "colnKayitID"
        '
        'colnKarpinID
        '
        Me.colnKarpinID.Caption = "Evrak No"
        Me.colnKarpinID.FieldName = "nKarpinID"
        Me.colnKarpinID.Name = "colnKarpinID"
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sStokKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.OptionsColumn.AllowFocus = False
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sStokKodu", "Satýr: {0}")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 76
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sStokAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 204
        '
        'collY1
        '
        Me.collY1.Caption = "Y1"
        Me.collY1.ColumnEdit = Me.sec_lMiktar
        Me.collY1.DisplayFormat.FormatString = "#,0.####"
        Me.collY1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collY1.FieldName = "lY1"
        Me.collY1.Name = "collY1"
        Me.collY1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lY1", "{0:#,0.####}")})
        Me.collY1.Visible = True
        Me.collY1.VisibleIndex = 2
        Me.collY1.Width = 39
        '
        'sec_lMiktar
        '
        Me.sec_lMiktar.AutoHeight = False
        Me.sec_lMiktar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sec_lMiktar.DisplayFormat.FormatString = "#,0.####"
        Me.sec_lMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lMiktar.EditFormat.FormatString = "#,0.####"
        Me.sec_lMiktar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lMiktar.Name = "sec_lMiktar"
        '
        'collY2
        '
        Me.collY2.Caption = "Y2"
        Me.collY2.ColumnEdit = Me.sec_lMiktar
        Me.collY2.DisplayFormat.FormatString = "#,0.####"
        Me.collY2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collY2.FieldName = "lY2"
        Me.collY2.Name = "collY2"
        Me.collY2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lY2", "{0:#,0.####}")})
        Me.collY2.Visible = True
        Me.collY2.VisibleIndex = 3
        Me.collY2.Width = 36
        '
        'collY3
        '
        Me.collY3.Caption = "Y3"
        Me.collY3.ColumnEdit = Me.sec_lMiktar
        Me.collY3.DisplayFormat.FormatString = "#,0.####"
        Me.collY3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collY3.FieldName = "lY3"
        Me.collY3.Name = "collY3"
        Me.collY3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lY3", "{0:#,0.####}")})
        Me.collY3.Visible = True
        Me.collY3.VisibleIndex = 4
        Me.collY3.Width = 38
        '
        'collMiktar
        '
        Me.collMiktar.Caption = "Miktar"
        Me.collMiktar.ColumnEdit = Me.sec_lMiktar
        Me.collMiktar.DisplayFormat.FormatString = "#,0.####"
        Me.collMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktar.FieldName = "lMiktar"
        Me.collMiktar.Name = "collMiktar"
        Me.collMiktar.OptionsColumn.AllowFocus = False
        Me.collMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", "{0:#,0.####}")})
        Me.collMiktar.Visible = True
        Me.collMiktar.VisibleIndex = 5
        Me.collMiktar.Width = 57
        '
        'collIade
        '
        Me.collIade.Caption = "Ýade"
        Me.collIade.ColumnEdit = Me.sec_lMiktar
        Me.collIade.DisplayFormat.FormatString = "#,0.####"
        Me.collIade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIade.FieldName = "lIade"
        Me.collIade.Name = "collIade"
        Me.collIade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIade", "{0:#,0.####}")})
        Me.collIade.Visible = True
        Me.collIade.VisibleIndex = 6
        Me.collIade.Width = 47
        '
        'collSatis
        '
        Me.collSatis.Caption = "Satýþ"
        Me.collSatis.ColumnEdit = Me.sec_lMiktar
        Me.collSatis.DisplayFormat.FormatString = "#,0.####"
        Me.collSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSatis.FieldName = "lSatis"
        Me.collSatis.Name = "collSatis"
        Me.collSatis.OptionsColumn.AllowFocus = False
        Me.collSatis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSatis", "{0:#,0.####}")})
        Me.collSatis.Visible = True
        Me.collSatis.VisibleIndex = 7
        Me.collSatis.Width = 56
        '
        'collFiyat
        '
        Me.collFiyat.Caption = "Fiyat"
        Me.collFiyat.ColumnEdit = Me.sec_lTutar
        Me.collFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat.FieldName = "lFiyat"
        Me.collFiyat.Name = "collFiyat"
        Me.collFiyat.Visible = True
        Me.collFiyat.VisibleIndex = 8
        Me.collFiyat.Width = 61
        '
        'sec_lTutar
        '
        Me.sec_lTutar.AutoHeight = False
        Me.sec_lTutar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_lTutar.DisplayFormat.FormatString = "#,0.00"
        Me.sec_lTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lTutar.EditFormat.FormatString = "#,0.00##"
        Me.sec_lTutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lTutar.Name = "sec_lTutar"
        Me.sec_lTutar.Precision = 4
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.ColumnEdit = Me.sec_lTutar
        Me.collTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00}")})
        Me.collTutar.Visible = True
        Me.collTutar.VisibleIndex = 9
        Me.collTutar.Width = 90
        '
        'colbStatus
        '
        Me.colbStatus.Caption = "Status"
        Me.colbStatus.FieldName = "bStatus"
        Me.colbStatus.Name = "colbStatus"
        Me.colbStatus.Width = 119
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Satýr Ekle, Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Satýr Sil, Ctrl+Delete"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Stok Kartý, F4"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        Me.BarButtonItem5.Caption = "Envanter, F6"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.Appearance.Options.UseFont = True
        Me.BarButtonItem6.Caption = "Stok Hareketleri, F7"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.Appearance.Options.UseFont = True
        Me.BarButtonItem7.Caption = " Satýþtan Aktar, F5"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem7.Name = "BarButtonItem7"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Sevkiyat", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Karpin", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_tbKarpin_Sevkiyat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbKarpin_Sevkiyat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sevkiyat"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_lKdv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lNetSatis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lIskonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_lMiktar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_lTutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnKayitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKarpinID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collY2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collY3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSatis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_lNetSatis As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_lIskonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents sec_lMiktar As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents sec_lTutar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents txt_lKdv As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
