Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.Utils
Public Class frmrptpos
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
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISSAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAKIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKREDI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As ContextMenu
    Friend WithEvents MenuItem1 As MenuItem
    Friend WithEvents MenuItem2 As MenuItem
    Friend WithEvents MenuItem3 As MenuItem
    Friend WithEvents MenuItem4 As MenuItem
    Friend WithEvents MenuItem5 As MenuItem
    Friend WithEvents MenuItem6 As MenuItem
    Friend WithEvents MenuItem7 As MenuItem
    Friend WithEvents MenuItem8 As MenuItem
    Friend WithEvents MenuItem9 As MenuItem
    Friend WithEvents MenuItem10 As MenuItem
    Friend WithEvents MenuItem11 As MenuItem
    Friend WithEvents MenuItem12 As MenuItem
    Friend WithEvents MenuItem13 As MenuItem
    Friend WithEvents MenuItem14 As MenuItem
    Friend WithEvents MenuItem15 As MenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuItem16 As MenuItem
    Friend WithEvents MenuItem17 As MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrptpos))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFISSAYISI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIRO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNAKIT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKREDI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataSet1 = New System.Data.DataSet
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 60)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(728, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Satýþ Raporu"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 407)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 43)
        Me.Panel2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(731, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'Panel3
        '
        Me.Panel3.Appearance.BackColor = System.Drawing.Color.White
        Me.Panel3.Appearance.Options.UseBackColor = True
        Me.Panel3.Controls.Add(Me.GridControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(824, 347)
        Me.Panel3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataTable1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 343)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "POS"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NO"
        Me.DataColumn1.DataType = GetType(Integer)
        Me.DataColumn1.DefaultValue = 0
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "FISSAYISI"
        Me.DataColumn2.DataType = GetType(Integer)
        Me.DataColumn2.DefaultValue = 0
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CIRO"
        Me.DataColumn3.DataType = GetType(Decimal)
        Me.DataColumn3.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "NAKIT"
        Me.DataColumn4.DataType = GetType(Decimal)
        Me.DataColumn4.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "KREDI"
        Me.DataColumn5.DataType = GetType(Decimal)
        Me.DataColumn5.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNO, Me.colFISSAYISI, Me.colCIRO, Me.colNAKIT, Me.colKREDI})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNO
        '
        Me.colNO.Caption = "No"
        Me.colNO.FieldName = "NO"
        Me.colNO.Name = "colNO"
        Me.colNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NO", "{0}")})
        Me.colNO.Visible = True
        Me.colNO.VisibleIndex = 0
        Me.colNO.Width = 61
        '
        'colFISSAYISI
        '
        Me.colFISSAYISI.Caption = "FiþSayýsý"
        Me.colFISSAYISI.FieldName = "FISSAYISI"
        Me.colFISSAYISI.Name = "colFISSAYISI"
        Me.colFISSAYISI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FISSAYISI", "{0:#,0.####}")})
        Me.colFISSAYISI.Visible = True
        Me.colFISSAYISI.VisibleIndex = 1
        Me.colFISSAYISI.Width = 76
        '
        'colCIRO
        '
        Me.colCIRO.Caption = "ToplamCiro"
        Me.colCIRO.DisplayFormat.FormatString = "#,0.00"
        Me.colCIRO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCIRO.FieldName = "CIRO"
        Me.colCIRO.Name = "colCIRO"
        Me.colCIRO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CIRO", "{0:#,0.00}")})
        Me.colCIRO.Visible = True
        Me.colCIRO.VisibleIndex = 2
        Me.colCIRO.Width = 121
        '
        'colNAKIT
        '
        Me.colNAKIT.Caption = "NakitCiro"
        Me.colNAKIT.DisplayFormat.FormatString = "#,0.00"
        Me.colNAKIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNAKIT.FieldName = "NAKIT"
        Me.colNAKIT.Name = "colNAKIT"
        Me.colNAKIT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NAKIT", "{0:#,0.00}")})
        Me.colNAKIT.Visible = True
        Me.colNAKIT.VisibleIndex = 3
        Me.colNAKIT.Width = 134
        '
        'colKREDI
        '
        Me.colKREDI.Caption = "KrediCiro"
        Me.colKREDI.DisplayFormat.FormatString = "#,0.00"
        Me.colKREDI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKREDI.FieldName = "KREDI"
        Me.colKREDI.Name = "colKREDI"
        Me.colKREDI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KREDI", "{0:#,0.00}")})
        Me.colKREDI.Visible = True
        Me.colKREDI.VisibleIndex = 4
        Me.colKREDI.Width = 124
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem16, Me.MenuItem12, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem17, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem14, Me.MenuItem9, Me.MenuItem10, Me.MenuItem15, Me.MenuItem11})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3})
        Me.MenuItem1.Text = "Kaydet"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Text Dosya"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Excel"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "Veri Formatý Düzenle"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Görünümü Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "Görünümü Kaydet"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 6
        Me.MenuItem17.Text = "Görünümü Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 7
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        Me.MenuItem7.Text = "Filtrele"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 9
        Me.MenuItem8.Text = "Gruplandýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 10
        Me.MenuItem14.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 11
        Me.MenuItem9.Text = "Satýrlarý Aç"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 12
        Me.MenuItem10.Text = "Satýrlarý Kapat"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 13
        Me.MenuItem15.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 14
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.AltF10
        Me.MenuItem11.Text = "Ekraný Kapla"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink})
        '
        'printlink
        '
        Me.printlink.Component = Me.GridControl1
        '
        '
        '
        Me.printlink.ImageCollection.ImageStream = CType(resources.GetObject("printlink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[Date Printed][Time Printed]", "Ýnter Pos Satýþ Raporu", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"www.barkodyazilim.com.tr", "", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink.PrintingSystem = Me.ps
        Me.printlink.PrintingSystemBase = Me.ps
        '
        'frmrptpos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 450)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmrptpos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pos Raporu"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public islem
    Dim dll As New AppYazarKasa
    Private Sub frmrptpos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GridControl1.DataSource = DataSet1.Tables("POS")
    End Sub
    Private Sub frmrptpos_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Default
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem8.Click
        If MenuItem8.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem8.Checked = True
        ElseIf MenuItem8.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem8.Checked = False
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem9.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem10.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem11.Click
        If MenuItem11.Checked = False Then
            Me.WindowState = Windows.Forms.FormWindowState.Maximized
            MenuItem11.Checked = True
        ElseIf MenuItem11.Checked = True Then
            Me.WindowState = Windows.Forms.FormWindowState.Normal
            MenuItem11.Checked = False
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Windows.Forms.Keys.Enter Then
            Close()
        End If
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem16.Click
        Dim format = InputBox("Veri Formatý", "Format Deðiþtir", "#,0.00")
        GridView1.FocusedColumn.DisplayFormat.FormatType = FormatType.Numeric
        GridView1.FocusedColumn.DisplayFormat.FormatString = format
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem17.Click
        printlink.CreateDocument(ps)
        ps.PreviewFormEx.Show()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class
