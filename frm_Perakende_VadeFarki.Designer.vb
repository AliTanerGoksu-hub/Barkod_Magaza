<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Perakende_VadeFarki
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Perakende_VadeFarki))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_aciklama = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_ParaUstu = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_Odenen = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_GenelToplam = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_VadeFarki = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_ToplamTutar = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_VadeOrani = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteVade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnGun = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collVadeFarki = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collToplam = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_ParaUstu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Odenen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GenelToplam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_VadeFarki.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ToplamTutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_VadeOrani.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_aciklama)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'lbl_aciklama
        '
        Me.lbl_aciklama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_aciklama.Location = New System.Drawing.Point(96, 2)
        Me.lbl_aciklama.Name = "lbl_aciklama"
        Me.lbl_aciklama.Size = New System.Drawing.Size(170, 13)
        Me.lbl_aciklama.TabIndex = 21
        Me.lbl_aciklama.Text = "Vade Farký Hesaplama Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.txt_ParaUstu)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.txt_Odenen)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txt_GenelToplam)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.txt_VadeFarki)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txt_ToplamTutar)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txt_VadeOrani)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 285)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 144)
        Me.PanelControl2.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(593, 110)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 83
        Me.SimpleButton3.Text = "&Yazdýr"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 115)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl6.TabIndex = 82
        Me.LabelControl6.Text = "ParaÜstü:"
        '
        'txt_ParaUstu
        '
        Me.txt_ParaUstu.Enabled = False
        Me.txt_ParaUstu.Location = New System.Drawing.Point(106, 115)
        Me.txt_ParaUstu.Name = "txt_ParaUstu"
        Me.txt_ParaUstu.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_ParaUstu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_ParaUstu.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_ParaUstu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_ParaUstu.Properties.NullText = "0.00"
        Me.txt_ParaUstu.Size = New System.Drawing.Size(117, 20)
        Me.txt_ParaUstu.TabIndex = 81
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(5, 93)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 80
        Me.LabelControl5.Text = "Ödenen:"
        '
        'txt_Odenen
        '
        Me.txt_Odenen.Location = New System.Drawing.Point(106, 93)
        Me.txt_Odenen.Name = "txt_Odenen"
        Me.txt_Odenen.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_Odenen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_Odenen.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_Odenen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_Odenen.Properties.NullText = "0.00"
        Me.txt_Odenen.Size = New System.Drawing.Size(117, 20)
        Me.txt_Odenen.TabIndex = 79
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 71)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl4.TabIndex = 78
        Me.LabelControl4.Text = "GenelToplam:"
        '
        'txt_GenelToplam
        '
        Me.txt_GenelToplam.Enabled = False
        Me.txt_GenelToplam.Location = New System.Drawing.Point(106, 71)
        Me.txt_GenelToplam.Name = "txt_GenelToplam"
        Me.txt_GenelToplam.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_GenelToplam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_GenelToplam.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_GenelToplam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_GenelToplam.Properties.NullText = "0.00"
        Me.txt_GenelToplam.Size = New System.Drawing.Size(117, 20)
        Me.txt_GenelToplam.TabIndex = 77
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 49)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 76
        Me.LabelControl3.Text = "VadeFarký"
        '
        'txt_VadeFarki
        '
        Me.txt_VadeFarki.Location = New System.Drawing.Point(106, 49)
        Me.txt_VadeFarki.Name = "txt_VadeFarki"
        Me.txt_VadeFarki.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_VadeFarki.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_VadeFarki.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_VadeFarki.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_VadeFarki.Properties.NullText = "0.00"
        Me.txt_VadeFarki.Size = New System.Drawing.Size(117, 20)
        Me.txt_VadeFarki.TabIndex = 75
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 74
        Me.LabelControl2.Text = "ToplamTutar:"
        '
        'txt_ToplamTutar
        '
        Me.txt_ToplamTutar.Enabled = False
        Me.txt_ToplamTutar.Location = New System.Drawing.Point(106, 27)
        Me.txt_ToplamTutar.Name = "txt_ToplamTutar"
        Me.txt_ToplamTutar.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_ToplamTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_ToplamTutar.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_ToplamTutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_ToplamTutar.Properties.NullText = "0.00"
        Me.txt_ToplamTutar.Size = New System.Drawing.Size(117, 20)
        Me.txt_ToplamTutar.TabIndex = 73
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl1.TabIndex = 72
        Me.LabelControl1.Text = "VadeFarkýOraný%:"
        '
        'txt_VadeOrani
        '
        Me.txt_VadeOrani.EditValue = "10.00"
        Me.txt_VadeOrani.Location = New System.Drawing.Point(106, 5)
        Me.txt_VadeOrani.Name = "txt_VadeOrani"
        Me.txt_VadeOrani.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_VadeOrani.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_VadeOrani.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_VadeOrani.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_VadeOrani.Properties.NullText = "10.00"
        Me.txt_VadeOrani.Size = New System.Drawing.Size(117, 20)
        Me.txt_VadeOrani.TabIndex = 71
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(743, 110)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 70
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(668, 110)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 69
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 229)
        Me.PanelControl3.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 225)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "dteTarih"
        Me.DataColumn1.DataType = GetType(Date)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "dteVade"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lTutar"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "nGun"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lVadeFarki"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "lToplam"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteTarih, Me.coldteVade, Me.collTutar, Me.colnGun, Me.collVadeFarki, Me.collToplam})
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarih", "{0} Kayýt")})
        '
        'coldteVade
        '
        Me.coldteVade.Caption = "Vade"
        Me.coldteVade.FieldName = "dteVade"
        Me.coldteVade.Name = "coldteVade"
        Me.coldteVade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteVade", "{0} Kayýt")})
        Me.coldteVade.Visible = True
        Me.coldteVade.VisibleIndex = 0
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00}")})
        Me.collTutar.Visible = True
        Me.collTutar.VisibleIndex = 1
        '
        'colnGun
        '
        Me.colnGun.Caption = "Gün"
        Me.colnGun.FieldName = "nGun"
        Me.colnGun.Name = "colnGun"
        Me.colnGun.Visible = True
        Me.colnGun.VisibleIndex = 2
        '
        'collVadeFarki
        '
        Me.collVadeFarki.Caption = "VadeFarki"
        Me.collVadeFarki.DisplayFormat.FormatString = "#,0.00"
        Me.collVadeFarki.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collVadeFarki.FieldName = "lVadeFarki"
        Me.collVadeFarki.Name = "collVadeFarki"
        Me.collVadeFarki.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lVadeFarki", "{0:#,0.00}")})
        Me.collVadeFarki.Visible = True
        Me.collVadeFarki.VisibleIndex = 3
        '
        'collToplam
        '
        Me.collToplam.Caption = "Toplam"
        Me.collToplam.DisplayFormat.FormatString = "#,0.00"
        Me.collToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplam.FieldName = "lToplam"
        Me.collToplam.Name = "collToplam"
        Me.collToplam.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplam", "{0:#,0.00}")})
        Me.collToplam.Visible = True
        Me.collToplam.VisibleIndex = 4
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "VadeFarkýHesaplama", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_Perakende_VadeFarki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Perakende_VadeFarki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VadeFarki"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_ParaUstu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Odenen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GenelToplam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_VadeFarki.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ToplamTutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_VadeOrani.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_aciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_VadeFarki As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ToplamTutar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_VadeOrani As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ParaUstu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Odenen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_GenelToplam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteVade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collVadeFarki As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
