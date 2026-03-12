Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_farklifiyat_kontrol
    Inherits DevExpress.XtraEditors.XtraForm
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMODEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colPESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALTIAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents colORANEKMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNETMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTLALTIAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTLPESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTLONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTLFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_farklifiyat_kontrol))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colORAN1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colORAN2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colORAN3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl
        Me.barlabel = New DevExpress.XtraEditors.LabelControl
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsMODEL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPESIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colALTIAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colONAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colORANEKMALIYET = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNETMALIYET = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMALIYET = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTLALTIAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTLPESIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTLONAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTLFIYAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colORAN1
        '
        Me.colORAN1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN1.AppearanceCell.Options.UseFont = True
        Me.colORAN1.Caption = "Oran 1"
        Me.colORAN1.DisplayFormat.FormatString = "P"
        Me.colORAN1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN1.FieldName = "ORAN1"
        Me.colORAN1.Name = "colORAN1"
        Me.colORAN1.Width = 31
        '
        'colORAN2
        '
        Me.colORAN2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN2.AppearanceCell.Options.UseFont = True
        Me.colORAN2.Caption = "Oran 2"
        Me.colORAN2.DisplayFormat.FormatString = "P"
        Me.colORAN2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN2.FieldName = "ORAN2"
        Me.colORAN2.Name = "colORAN2"
        Me.colORAN2.Width = 31
        '
        'colORAN3
        '
        Me.colORAN3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN3.AppearanceCell.Options.UseFont = True
        Me.colORAN3.Caption = "Oran 3"
        Me.colORAN3.DisplayFormat.FormatString = "P"
        Me.colORAN3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN3.FieldName = "ORAN3"
        Me.colORAN3.Name = "colORAN3"
        Me.colORAN3.Width = 54
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 52)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(97, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(724, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aþýðýda Stoklarýn Fiyat Tanýmlarýný ve Tl Fiyat Karþýlaþtýrma farkýlýlýklarýný gö" & _
            "rmektesiniz..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 368)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 43)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(96, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 9)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Ara F3"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 52)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 316)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(818, 310)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panelstatus)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 283)
        Me.XtraTabPage1.Text = "Kartlar..."
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panelstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(138, 88)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(538, 108)
        Me.Panelstatus.TabIndex = 11
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(8, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(514, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 50)
        Me.barlabel2.Name = "barlabel2"
        Me.barlabel2.Size = New System.Drawing.Size(514, 14)
        Me.barlabel2.TabIndex = 2
        Me.barlabel2.Text = "barlabel2"
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 4)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(514, 14)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 23)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(514, 18)
        Me.bar.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(814, 283)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nStokID"
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
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sRenk"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sBeden"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sMODEL"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sBarkod"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "MEVCUT"
        Me.DataColumn8.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.colsRenk, Me.colsBeden, Me.colsMODEL, Me.colsBarkod, Me.colMEVCUT, Me.colPESIN, Me.colALTIAY, Me.colONAY, Me.colORANEKMALIYET, Me.colORAN1, Me.colORAN2, Me.colORAN3, Me.colNETMALIYET, Me.colMALIYET, Me.colTLALTIAY, Me.colTLPESIN, Me.colTLONAY, Me.colAciklama, Me.colFiyat, Me.colTLFIYAT})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 327, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colORAN1
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colORAN2
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colORAN3
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition3.Tag = "0"
        StyleFormatCondition3.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Kayýt No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.colnStokID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colnStokID.Width = 72
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.colsKodu.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 1
        Me.colsKodu.Width = 123
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        Me.colsAciklama.Width = 208
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.ColumnEdit = Me.sec_renk
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.Visible = True
        Me.colsRenk.VisibleIndex = 3
        Me.colsRenk.Width = 100
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_renk.ShowFooter = False
        Me.sec_renk.ShowHeader = False
        Me.sec_renk.ShowLines = False
        Me.sec_renk.ValueMember = "sRenk"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.Width = 82
        '
        'colsMODEL
        '
        Me.colsMODEL.Caption = "ModelNo"
        Me.colsMODEL.FieldName = "sModel"
        Me.colsMODEL.Name = "colsMODEL"
        Me.colsMODEL.Width = 109
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.Width = 154
        '
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcut"
        Me.colMEVCUT.DisplayFormat.FormatString = "#,0.####"
        Me.colMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT.FieldName = "Mevcut"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.SummaryItem.DisplayFormat = "{0:#,0.####}"
        Me.colMEVCUT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMEVCUT.Visible = True
        Me.colMEVCUT.VisibleIndex = 4
        Me.colMEVCUT.Width = 102
        '
        'colPESIN
        '
        Me.colPESIN.Caption = "Fiyat1"
        Me.colPESIN.DisplayFormat.FormatString = "#,0.00"
        Me.colPESIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPESIN.FieldName = "PESIN"
        Me.colPESIN.Name = "colPESIN"
        Me.colPESIN.Width = 40
        '
        'colALTIAY
        '
        Me.colALTIAY.Caption = "Fiyat2"
        Me.colALTIAY.DisplayFormat.FormatString = "#,0.00"
        Me.colALTIAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colALTIAY.FieldName = "ALTIAY"
        Me.colALTIAY.Name = "colALTIAY"
        Me.colALTIAY.Width = 40
        '
        'colONAY
        '
        Me.colONAY.Caption = "Fiyat3"
        Me.colONAY.DisplayFormat.FormatString = "#,0.00"
        Me.colONAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONAY.FieldName = "ONAY"
        Me.colONAY.Name = "colONAY"
        Me.colONAY.Width = 46
        '
        'colORANEKMALIYET
        '
        Me.colORANEKMALIYET.Caption = "Ek Maliyet Oraný"
        Me.colORANEKMALIYET.FieldName = "ORANEKMALIYET"
        Me.colORANEKMALIYET.Name = "colORANEKMALIYET"
        '
        'colNETMALIYET
        '
        Me.colNETMALIYET.Caption = "Net Maliyet"
        Me.colNETMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colNETMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNETMALIYET.FieldName = "NETMALIYET"
        Me.colNETMALIYET.Name = "colNETMALIYET"
        Me.colNETMALIYET.Width = 48
        '
        'colMALIYET
        '
        Me.colMALIYET.Caption = "Maliyet"
        Me.colMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMALIYET.FieldName = "MALIYET"
        Me.colMALIYET.Name = "colMALIYET"
        Me.colMALIYET.Width = 42
        '
        'colTLALTIAY
        '
        Me.colTLALTIAY.Caption = "Tl6Ay"
        Me.colTLALTIAY.DisplayFormat.FormatString = "#,0.00"
        Me.colTLALTIAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTLALTIAY.FieldName = "TLALTIAY"
        Me.colTLALTIAY.Name = "colTLALTIAY"
        Me.colTLALTIAY.Width = 63
        '
        'colTLPESIN
        '
        Me.colTLPESIN.Caption = "TlPeþin"
        Me.colTLPESIN.DisplayFormat.FormatString = "#,0.00"
        Me.colTLPESIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTLPESIN.FieldName = "TLPESIN"
        Me.colTLPESIN.Name = "colTLPESIN"
        Me.colTLPESIN.Width = 63
        '
        'colTLONAY
        '
        Me.colTLONAY.Caption = "Tl10Ay"
        Me.colTLONAY.DisplayFormat.FormatString = "#,0.00"
        Me.colTLONAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTLONAY.FieldName = "TLONAY"
        Me.colTLONAY.Name = "colTLONAY"
        Me.colTLONAY.Width = 51
        '
        'colAciklama
        '
        Me.colAciklama.Caption = "Açýklama"
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        Me.colAciklama.Visible = True
        Me.colAciklama.VisibleIndex = 0
        Me.colAciklama.Width = 187
        '
        'colFiyat
        '
        Me.colFiyat.Caption = "Fiyatý"
        Me.colFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 5
        Me.colFiyat.Width = 183
        '
        'colTLFIYAT
        '
        Me.colTLFIYAT.Caption = "TlFiyatý"
        Me.colTLFIYAT.DisplayFormat.FormatString = "#,0.00"
        Me.colTLFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTLFIYAT.FieldName = "TLFIYAT"
        Me.colTLFIYAT.Name = "colTLFIYAT"
        Me.colTLFIYAT.Visible = True
        Me.colTLFIYAT.VisibleIndex = 6
        Me.colTLFIYAT.Width = 193
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem21, Me.MenuItem19, Me.MenuItem12, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem20, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem15.Text = "Ara"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = False
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = False
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = False
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "Fiyatlarý Güncelle"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Text = "Satýr Kontrol"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 7
        Me.MenuItem12.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 8
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem4.Text = "Fiyat Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 9
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem5.Text = "Envanter"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 10
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem6.Text = "Model Envanter"
        '
        'MenuItem20
        '
        Me.MenuItem20.Enabled = False
        Me.MenuItem20.Index = 11
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem23, Me.MenuItem24})
        Me.MenuItem20.Text = "Etiket"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Text = "Etiket Önizle"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Etiket Dizayn"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem24.Text = "Etiket Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 12
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 13
        Me.MenuItem7.Text = "Görünüm Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 14
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 15
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 16
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 17
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 18
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 19
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 20
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem17.Text = "Tam Ekran"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Stok Fiyat Tanýmlarý Tl Fiyat Karþýlaþtýrma Farklarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Stok Ýþlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Fiyatlandir,Ctrl+F"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Envanter,F6"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        Me.BarButtonItem5.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.Appearance.Options.UseFont = True
        Me.BarButtonItem6.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.Appearance.Options.UseFont = True
        Me.BarButtonItem7.Caption = "Excel"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.Appearance.Options.UseFont = True
        Me.BarButtonItem8.Caption = "Text"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.Appearance.Options.UseFont = True
        Me.BarButtonItem9.Caption = "Mail"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.Name = "BarButtonItem9"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 411)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 18)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 411)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 411)
        '
        'frm_stok_farklifiyat_kontrol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_farklifiyat_kontrol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Fiyatlarý TL Farklýlýklarý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panelstatus.ResumeLayout(False)
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public status As Boolean
    Public connection
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Public stokkodu
    Public malincinsi
    Public barkod
    Public muadilbarkod
    Public birim
    Public kod1
    Public kod2
    Public kod3
    Public kod4
    Public kod5
    Public kod6
    Public kod7
    Public kod8
    Public kod9
    Public kod10
    Public satisfiyati1
    Public satisfiyati2
    Public satisfiyati3
    Public istihbarat
    Public kayitno
    Public aktif
    Public sil As Boolean = False
    Public gelismis
    Public secenek
    Public stoklar
    Public qkayitno
    Public qstokkodu
    Public qmalincinsi
    Public qbarkod
    Public qmuadilbarkod
    Public qkod1
    Public qkod2
    Public qkod3
    Public qkod4
    Public qkod5
    Public qkod6
    Public qkod7
    Public qkod8
    Public qkod9
    Public qkod10
    Public qistihbarat
    Public qbirim
    Public qdepo
    Public qsatisfiyati1
    Public qsatisfiyati2
    Public qsatisfiyati3
    Public qaktif
    Public qgelismis
    Public qsecenek
    Public qstoklar
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public frf_islem As String = "mektup"
    Public islemstatus As Boolean = False
    Public okut As Boolean = False
    Dim ds_alislar As DataSet
    Dim ds_stok As DataSet
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide()
        If status = False Then
            count = ""
            Dim frm As New frm_stok_ara
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.rowKRITER.Visible = True
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                kayitno = frm.ind
                stokkodu = frm.stokkodu
                malincinsi = frm.malincinsi
                barkod = frm.barkod
                muadilbarkod = frm.muadilbarkod
                kod1 = frm.kod1
                kod2 = frm.kod2
                kod3 = frm.kod3
                kod4 = frm.kod4
                kod5 = frm.kod5
                kod6 = frm.kod6
                kod7 = frm.kod7
                kod8 = frm.kod8
                kod9 = frm.kod9
                kod10 = frm.kod10
                birim = frm.birim
                satisfiyati1 = frm.satisfiyati1
                satisfiyati2 = frm.satisfiyati2
                satisfiyati3 = frm.satisfiyati3
                istihbarat = frm.istihbarat
                aktif = frm.aktif
                gelismis = frm.gelismis
                secenek = frm.secenek
                qkayitno = frm.qind
                qstokkodu = frm.qstokkodu
                qmalincinsi = frm.qmalincinsi
                qbarkod = frm.qbarkod
                qmuadilbarkod = frm.qmuadilbarkod
                qkod1 = frm.qkod1
                qkod2 = frm.qkod2
                qkod3 = frm.qkod3
                qkod4 = frm.qkod4
                qkod5 = frm.qkod5
                qkod6 = frm.qkod6
                qkod7 = frm.qkod7
                qkod8 = frm.qkod8
                qkod9 = frm.qkod9
                qkod10 = frm.qkod10
                qbirim = frm.qbirim
                qsatisfiyati1 = frm.qsatisfiyati1
                qsatisfiyati2 = frm.qsatisfiyati2
                qsatisfiyati3 = frm.qsatisfiyati3
                qistihbarat = frm.qistihbarat
                qaktif = frm.qaktif
                mevcut = frm.mevcut
                yeni = frm.yeni
                qgelismis = frm.qgelismis
                qsecenek = frm.qsecenek
                Me.Show()
                frm.stokkodu = Nothing
                frm.malincinsi = Nothing
                frm.barkod = Nothing
                frm.muadilbarkod = Nothing
                frm.birim = Nothing
                frm.kod1 = Nothing
                frm.kod2 = Nothing
                frm.kod3 = Nothing
                frm.kod4 = Nothing
                frm.kod5 = Nothing
                frm.kod6 = Nothing
                frm.kod7 = Nothing
                frm.kod8 = Nothing
                frm.kod9 = Nothing
                frm.kod10 = Nothing
                frm.satisfiyati1 = Nothing
                frm.satisfiyati2 = Nothing
                frm.satisfiyati3 = Nothing
                frm.istihbarat = Nothing
                frm.ind = Nothing
                frm.qind = Nothing
                frm.qstokkodu = Nothing
                frm.qmalincinsi = Nothing
                frm.qbarkod = Nothing
                frm.qmuadilbarkod = Nothing
                frm.qkod1 = Nothing
                frm.qkod2 = Nothing
                frm.qkod3 = Nothing
                frm.qkod4 = Nothing
                frm.qkod5 = Nothing
                frm.qkod6 = Nothing
                frm.qkod7 = Nothing
                frm.qkod8 = Nothing
                frm.qkod9 = Nothing
                frm.qkod10 = Nothing
                frm.qistihbarat = Nothing
                frm.qbirim = Nothing
                frm.qdepo = Nothing
                frm.qsatisfiyati1 = Nothing
                frm.qsatisfiyati2 = Nothing
                frm.qsatisfiyati3 = Nothing
                frm.PanelControl1.Dispose()
                frm.PanelControl1 = Nothing
                frm.PanelControl2.Dispose()
                frm.PanelControl2 = Nothing
                frm.PanelControl3.Dispose()
                frm.PanelControl3 = Nothing
                frm.PictureBox1.Dispose()
                frm.PictureBox1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.VGridControl1.Dispose()
                frm.VGridControl1 = Nothing
                frm.Dispose()
                frm = Nothing
                dataload()
            Else
                frm.stokkodu = Nothing
                frm.malincinsi = Nothing
                frm.barkod = Nothing
                frm.muadilbarkod = Nothing
                frm.birim = Nothing
                frm.kod1 = Nothing
                frm.kod2 = Nothing
                frm.kod3 = Nothing
                frm.kod4 = Nothing
                frm.kod5 = Nothing
                frm.kod6 = Nothing
                frm.kod7 = Nothing
                frm.kod8 = Nothing
                frm.kod9 = Nothing
                frm.kod10 = Nothing
                frm.satisfiyati1 = Nothing
                frm.satisfiyati2 = Nothing
                frm.satisfiyati3 = Nothing
                frm.istihbarat = Nothing
                frm.ind = Nothing
                frm.qind = Nothing
                frm.qstokkodu = Nothing
                frm.qmalincinsi = Nothing
                frm.qbarkod = Nothing
                frm.qmuadilbarkod = Nothing
                frm.qkod1 = Nothing
                frm.qkod2 = Nothing
                frm.qkod3 = Nothing
                frm.qkod4 = Nothing
                frm.qkod5 = Nothing
                frm.qkod6 = Nothing
                frm.qkod7 = Nothing
                frm.qkod8 = Nothing
                frm.qkod9 = Nothing
                frm.qkod10 = Nothing
                frm.qistihbarat = Nothing
                frm.qbirim = Nothing
                frm.qdepo = Nothing
                frm.qsatisfiyati1 = Nothing
                frm.qsatisfiyati2 = Nothing
                frm.qsatisfiyati3 = Nothing
                frm.PanelControl1.Dispose()
                frm.PanelControl1 = Nothing
                frm.PanelControl2.Dispose()
                frm.PanelControl2 = Nothing
                frm.PanelControl3.Dispose()
                frm.PanelControl3 = Nothing
                frm.PictureBox1.Dispose()
                frm.PictureBox1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.VGridControl1.Dispose()
                frm.VGridControl1 = Nothing
                frm.Dispose()
                frm = Nothing
                Me.Close()
            End If
        Else
            count = "TOP 1000"
            dataload()
        End If
        'stok_islemleri.firmano = firmano
        'stok_islemleri.donemno = donemno
        'stok_islemleri.connection = connection
        If GridView1.RowCount = 0 Then
        ElseIf GridView1.RowCount = 1 Then
            If islemstatus = True Then
                If sil = False Then
                    sorgu()
                End If
            End If
        Else
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
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
            SaveFileDialog1.FileName = "Rapor.txt"
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
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub dataload_depo()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub satir_ekle()
    End Sub
    Private Sub ara()
        Dim frm As New frm_stok_ara
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.rowKRITER.Visible = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.ind
            stokkodu = frm.stokkodu
            malincinsi = frm.malincinsi
            barkod = frm.barkod
            muadilbarkod = frm.muadilbarkod
            kod1 = frm.kod1
            kod2 = frm.kod2
            kod3 = frm.kod3
            kod4 = frm.kod4
            kod5 = frm.kod5
            kod6 = frm.kod6
            kod7 = frm.kod7
            kod8 = frm.kod8
            kod9 = frm.kod9
            kod10 = frm.kod10
            birim = frm.birim
            satisfiyati1 = frm.satisfiyati1
            satisfiyati2 = frm.satisfiyati2
            satisfiyati3 = frm.satisfiyati3
            istihbarat = frm.istihbarat
            aktif = frm.aktif
            gelismis = frm.gelismis
            secenek = frm.secenek
            qkayitno = frm.qind
            qstokkodu = frm.qstokkodu
            qmalincinsi = frm.qmalincinsi
            qbarkod = frm.qbarkod
            qmuadilbarkod = frm.qmuadilbarkod
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkod3 = frm.qkod3
            qkod4 = frm.qkod4
            qkod5 = frm.qkod5
            qkod6 = frm.qkod6
            qkod7 = frm.qkod7
            qkod8 = frm.qkod8
            qkod9 = frm.qkod9
            qkod10 = frm.qkod10
            qbirim = frm.qbirim
            qsatisfiyati1 = frm.qsatisfiyati1
            qsatisfiyati2 = frm.qsatisfiyati2
            qsatisfiyati3 = frm.qsatisfiyati3
            qistihbarat = frm.qistihbarat
            qaktif = frm.qaktif
            qgelismis = frm.qgelismis
            qsecenek = frm.qsecenek
            mevcut = frm.mevcut
            yeni = frm.yeni
            dataload()
        End If
        frm.stokkodu = Nothing
        frm.malincinsi = Nothing
        frm.barkod = Nothing
        frm.muadilbarkod = Nothing
        frm.birim = Nothing
        frm.kod1 = Nothing
        frm.kod2 = Nothing
        frm.kod3 = Nothing
        frm.kod4 = Nothing
        frm.kod5 = Nothing
        frm.kod6 = Nothing
        frm.kod7 = Nothing
        frm.kod8 = Nothing
        frm.kod9 = Nothing
        frm.kod10 = Nothing
        frm.satisfiyati1 = Nothing
        frm.satisfiyati2 = Nothing
        frm.satisfiyati3 = Nothing
        frm.istihbarat = Nothing
        frm.ind = Nothing
        frm.qind = Nothing
        frm.qstokkodu = Nothing
        frm.qmalincinsi = Nothing
        frm.qbarkod = Nothing
        frm.qmuadilbarkod = Nothing
        frm.qkod1 = Nothing
        frm.qkod2 = Nothing
        frm.qkod3 = Nothing
        frm.qkod4 = Nothing
        frm.qkod5 = Nothing
        frm.qkod6 = Nothing
        frm.qkod7 = Nothing
        frm.qkod8 = Nothing
        frm.qkod9 = Nothing
        frm.qkod10 = Nothing
        frm.qistihbarat = Nothing
        frm.qbirim = Nothing
        frm.qdepo = Nothing
        frm.qsatisfiyati1 = Nothing
        frm.qsatisfiyati2 = Nothing
        frm.qsatisfiyati3 = Nothing
        frm.PanelControl1.Dispose()
        frm.PanelControl1 = Nothing
        frm.PanelControl2.Dispose()
        frm.PanelControl2 = Nothing
        frm.PanelControl3.Dispose()
        frm.PanelControl3 = Nothing
        frm.PictureBox1.Dispose()
        frm.PictureBox1 = Nothing
        frm.SimpleButton1 = Nothing
        frm.SimpleButton2 = Nothing
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub dataload()
        dataload_depo()
        'DataSet1.Clear()
        'DataSet1.Dispose()
        Me.Refresh()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        DataSet1 = stok()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.SelectRow(0)
        Me.Refresh()
        Label2.Text = "Maliyet ve Oranlar Hesaplanýyor..."
        Label2.Refresh()
        kontrol_oran()
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub stok_yeni()
        'stok_islemleri.kart_yeni()
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'stok_islemleri.kart_duzelt(dr("IND"), dr("STOKKODU"), dr("MALINCINSI"))
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    'stok_islemleri.kart_sil(dr1("IND"), False)
                    'If stok_islemleri.sil = True Then
                    '    'dr1.Delete()
                    '    'dr1.AcceptChanges()
                    'End If
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataload()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
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
    Public Function stok() As DataSet
        Dim kriter
        kriter = "WHERE (skodu is not null ) "
        If stokkodu <> "" Then
            kriter += " AND (skodu " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        End If
        If malincinsi <> "" Then
            kriter += " AND (saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        End If
        If barkod <> "" Then
            kriter += " AND (sbarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
            okut = True
        Else
            okut = False
        End If
        If kod1 <> "" Then
            kriter += " AND (srenk " & sorgu_kriter_string(kod1, qkod1) & " )"
        End If
        If kod2 <> "" Then
            kriter += " AND (sbeden " & sorgu_kriter_string(kod2, qkod2) & ")"
        End If
        If kayitno <> "" Then
            kriter += " AND (nStokID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        If gelismis <> "" Then
            kriter += " AND (skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ")  "
        End If
        If stoklar <> "" Then
            kriter += " AND (nStokID IN  " & stoklar & " )"
        End If
        If sStokSinirla <> "" Then
            kriter += " AND (sKodu like '" & sStokSinirla & "%') "
        End If
        Dim kriter2 As String = ""
        If secenek <> "" Then
            If secenek = "[Tümü]" Then
            ElseIf secenek = "Artýlar" Then
                kriter2 = " AND Mevcut > 0 "
            ElseIf secenek = "Eksiler" Then
                kriter2 = " AND Mevcut < 0 "
            ElseIf secenek = "Bitenler" Then
                kriter2 = " AND Mevcut = 0 "
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        cmd.CommandTimeout = False
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, CAST(0 AS MONEY) AS ORANEKMALIYET, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS ORAN2, CAST(0 AS MONEY) AS ORAN3, CAST(0 AS MONEY) AS SONALISMIKTARI, CAST(0 AS MONEY) AS SONALISFIYATI, CAST(0 AS MONEY) AS SONALISMALIYETI, CAST(0 AS MONEY) AS ONCEKIALISMALIYETI, CAST('01.01.1900' AS DATETIME) AS ONCEKIALISTARIHI, CAST('01.01.1900' AS DATETIME) AS SONALISTARIHI, CAST(0 AS MONEY) AS NETMALIYET, CAST(0 AS MONEY) AS EKMALIYET FROM (SELECT * , 'PeþinFiyatFarklarý' AS Aciklama , PESIN AS Fiyat , TLPESIN AS TLFIYAT FROM (SELECT stok.nStokID , stok.sKodu , stok.sAciklama , stok.sBeden , stok.sModel , barkod.sBarkod , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & EsFiyat1 & "') AS TLPESIN , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & EsFiyat2 & "') AS TLALTIAY , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & EsFiyat3 & "') AS TLONAY , tbRenk.sRenkAdi , stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk) T WHERE (PESIN <> TLPESIN) UNION ALL SELECT * , '6AylýkFiyatFarklarý' AS Aciklama , ALTIAY AS Fiyat , TLALTIAY AS TLFIYAT FROM (SELECT stok.nStokID , stok.sKodu , stok.sAciklama , stok.sBeden , stok.sModel , barkod.sBarkod , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = 'YTP') AS TLPESIN , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = 'YT6') AS TLALTIAY , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = 'YT10') AS TLONAY , tbRenk.sRenkAdi , stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk) T WHERE (ALTIAY <> TLALTIAY) UNION ALL SELECT * , '10AylýkFiyatFarklarý' AS Aciklama , ONAY AS Fiyat , TLONAY AS TLFIYAT FROM (SELECT stok.nStokID , stok.sKodu , stok.sAciklama , stok.sBeden , stok.sModel , barkod.sBarkod , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = 'YTP') AS TLPESIN , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = 'YT6') AS TLALTIAY , (SELECT isnull(lfiyat / 1000000 , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = 'YT10') AS TLONAY , tbRenk.sRenkAdi , stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk) T WHERE (ONAY <> TLONAY)) tt  " & kriter & "  ORDER BY sKodu")
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
    Private Sub analiz_envanter()
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
    End Sub
    Private Sub analiz_envanter_model()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
    End Sub
    Private Sub analiz_hareket()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub stok_fiyat()
        'If GridView1.RowCount > 0 Then
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_fiyat
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.stokno = dr("nStokId")
        '    frm.ShowDialog()
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        '    Dim satir = GridView1.FocusedRowHandle
        '    dataload()
        '    GridView1.FocusedRowHandle = satir
        '    satir = Nothing
        'End If
    End Sub
    Private Sub kontrol_oran()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            barlabel.Text = "StokKodu:" & dr("sKodu").ToString & vbTab & "Adý:" & dr("sAciklama").ToString
            barlabel.Refresh()
            'If dr("EKMALIYET") <> 0 Then
            '    dr("ORANEKMALIYET") = dr("EKMALIYET") / dr("FATURATUTARI")
            'End If
            'dr("NETMALIYET") = dr("KDVLITUTAR") * ((100 + (dr("ORANEKMALIYET") * 100)) / 100)
            'Karlýlýk Kontrol
            dr("NETMALIYET") = dr("MALIYET")
            'Dim dr1 As DataRow
            'ds_alislar = sorgu_alislar(Today, "99999999", dr("sKodu"))
            'Dim sayi As Integer = 0
            'For Each dr1 In ds_alislar.Tables(0).Rows
            '    sayi += 1
            '    If dr1("EKMALIYET") <> 0 Then
            '        dr1("ORANEKMALIYET") = dr1("EKMALIYET") / dr1("FATURATUTARI")
            '    End If
            '    dr1("NETMALIYET") = dr1("KDVLITUTAR") * ((100 + (dr1("ORANEKMALIYET") * 100)) / 100)
            '    If sayi = 1 Then
            '        dr("SONALISMALIYETI") = dr1("NETMALIYET")
            '        dr("NETMALIYET") = dr("SONALISMALIYETI")
            '        dr("SONALISTARIHI") = dr1("TARIH")
            '    ElseIf sayi = 2 Then
            '        dr("ONCEKIALISMALIYETI") = dr1("NETMALIYET")
            '        dr("ONCEKIALISTARIHI") = dr1("TARIH")
            '    End If
            'Next
            Try
                If dr("PESIN") <> 0 Then
                    dr("ORAN1") = ((dr("PESIN") - dr("NETMALIYET")) / dr("NETMALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ALTIAY") <> 0 Then
                    dr("ORAN2") = ((dr("ALTIAY") - dr("NETMALIYET")) / dr("NETMALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ONAY") <> 0 Then
                    dr("ORAN3") = ((dr("ONAY") - dr("NETMALIYET")) / dr("NETMALIYET"))
                End If
            Catch ex As Exception
            End Try
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Sub dataload_stok(ByVal stokno As Int64)
        Dim kriter
        kriter = "WHERE (nStokID = " & stokno & ")  "
        ds_stok = sorgu(sorgu_query("SELECT     * FROM  tbStok " & kriter & ""))
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
    Private Sub duzelt_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " , dteFiyatTespittarihi = '" & Today & "' where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt_fiyat_renk(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal modelno As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & ", dteFiyatTespittarihi = '" & Today & "' where nStokID IN (Select nStokID from tbStok where sModel ='" & modelno & "') AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub ekle_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal sKullaniciAdi As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & Today & "', '" & sKullaniciAdi & "', GETDATE())")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(count(lFiyat),0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub guncelle_satis()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            dataload_stok(dr("STOKNO"))
            For Each dr1 In ds_stok.Tables(0).Rows
                Dim fiyat As Decimal = 0
                '///////////////////////////////////10 AYLIK FÝYAT
                Try
                    fiyat = sorgu_stok_fiyat("10AY", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 Then
                    ekle_fiyat(dr("STOKNO"), "10AY", dr("ONAY"), kullaniciadi)
                Else
                    If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                        duzelt_fiyat_renk(dr("STOKNO"), "10AY", dr("ONAY"), dr1("sModel"))
                    ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                        duzelt_fiyat(dr("STOKNO"), "10AY", dr("ONAY"))
                    ElseIf dr1("nStokTipi") = 0 Then
                        duzelt_fiyat(dr("STOKNO"), "10AY", dr("ONAY"))
                    End If
                End If
                Try
                    fiyat = sorgu_stok_fiyat("YT10", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 Then
                    ekle_fiyat(dr("STOKNO"), "YT10", dr("ONAY") * 1000000, kullaniciadi)
                Else
                    If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                        duzelt_fiyat_renk(dr("STOKNO"), "YT10", dr("ONAY") * 1000000, dr1("sModel"))
                    ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                        duzelt_fiyat(dr("STOKNO"), "YT10", dr("ONAY") * 1000000)
                    ElseIf dr1("nStokTipi") = 0 Then
                        duzelt_fiyat(dr("STOKNO"), "YT10", dr("ONAY") * 1000000)
                    End If
                    'duzelt_fiyat(dr("STOKNO"), "YT10", dr("ONAY") * 1000000)
                End If
                '/////////////////////////////////////6 AYLIK FÝYAT
                Try
                    fiyat = sorgu_stok_fiyat("6 AY", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 Then
                    ekle_fiyat(dr("STOKNO"), "6 AY", dr("ALTIAY"), kullaniciadi)
                Else
                    If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                        duzelt_fiyat_renk(dr("STOKNO"), "6 AY", dr("ALTIAY"), dr1("sModel"))
                    ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                        duzelt_fiyat(dr("STOKNO"), "6 AY", dr("ALTIAY"))
                    ElseIf dr1("nStokTipi") = 0 Then
                        duzelt_fiyat(dr("STOKNO"), "6 AY", dr("ALTIAY"))
                    End If
                    'duzelt_fiyat(dr("STOKNO"), "6 AY", dr("ALTIAY"))
                End If
                Try
                    fiyat = sorgu_stok_fiyat("YT6", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 Then
                    ekle_fiyat(dr("STOKNO"), "YT6", dr("ALTIAY") * 1000000, kullaniciadi)
                Else
                    If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                        duzelt_fiyat_renk(dr("STOKNO"), "YT6", dr("ALTIAY") * 1000000, dr1("sModel"))
                    ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                        duzelt_fiyat(dr("STOKNO"), "YT6", dr("ALTIAY") * 1000000)
                    ElseIf dr1("nStokTipi") = 0 Then
                        duzelt_fiyat(dr("STOKNO"), "YT6", dr("ALTIAY") * 1000000)
                    End If
                    'duzelt_fiyat(dr("STOKNO"), "YT6", dr("ALTIAY") * 1000000)
                End If
                ''/////////////////////////////////////////////6 PEÞÝN
                Try
                    fiyat = sorgu_stok_fiyat("PS", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 Then
                    ekle_fiyat(dr("STOKNO"), "PS", dr("PESIN"), kullaniciadi)
                Else
                    If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                        duzelt_fiyat_renk(dr("STOKNO"), "PS", dr("PESIN"), dr1("sModel"))
                    ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                        duzelt_fiyat(dr("STOKNO"), "PS", dr("PESIN"))
                    ElseIf dr1("nStokTipi") = 0 Then
                        duzelt_fiyat(dr("STOKNO"), "PS", dr("PESIN"))
                    End If
                    'duzelt_fiyat(dr("STOKNO"), "PS", dr("PESIN"))
                End If
                Try
                    fiyat = sorgu_stok_fiyat("YTP", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 Then
                    ekle_fiyat(dr("STOKNO"), "YTP", dr("PESIN") * 1000000, kullaniciadi)
                Else
                    If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                        duzelt_fiyat_renk(dr("STOKNO"), "YTP", dr("PESIN") * 1000000, dr1("sModel"))
                    ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                        duzelt_fiyat(dr("STOKNO"), "YTP", dr("PESIN") * 1000000)
                    ElseIf dr1("nStokTipi") = 0 Then
                        duzelt_fiyat(dr("STOKNO"), "YTP", dr("PESIN") * 1000000)
                    End If
                    'duzelt_fiyat(dr("STOKNO"), "YTP", dr("PESIN") * 1000000)
                End If
                fiyat = Nothing
            Next
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Stok Fiyatlarý Baþarýyla Deðiþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        'dr_baslik("KOD3") = "Satýþ Fiyatlarý Deðiþtirildi..."
        'baslik_degistir()
    End Sub
    Public Function sorgu_alislar(ByVal tarih As DateTime, ByVal fisno As String, ByVal stokkodu As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.sFisTipi = 'FA') AND(tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < = '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') AND (tbStokFisiDetayi.lFisNo <> '" & fisno & "') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function satir_kontrol()
        Dim satir As String = "WHERE stok.nStokId IN ("
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = DataSet1.Tables(0).NewRow
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("nStokID").ToString
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
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "4"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 13
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        'If GridView1.SelectedRowsCount > 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Dim sayi1 = GridView1.SelectedRowsCount
        '    GridView1.FocusedColumn = colSTOKKODU
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}/Satýr:" & sayi & "/Seçili:" & sayi1 & ""
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}"
        'End If
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        ara()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        sorgu()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        stok_yeni()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        gorunum_yazdir()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        stok_fiyat()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If islemstatus = False Then
            e.Cancel = True
            Me.Hide()
        Else
            'Me.Hide()
            'PanelControl1.Dispose()
            'PanelControl2.Dispose()
            ''PanelControl3.Dispose()
            'SimpleButton1.Dispose()
            'SimpleButton2.Dispose()
            'SimpleButton3.Dispose()
            'ContextMenu1.Dispose()
            'PanelControl1 = Nothing
            'PanelControl2 = Nothing
            ''PanelControl3 = Nothing
            'SimpleButton1 = Nothing
            'SimpleButton2 = Nothing
            'SimpleButton3 = Nothing
            'ContextMenu1 = Nothing
            'status = Nothing
            'connection = Nothing
            'firmano = Nothing
            'donemno = Nothing
            'stokno = Nothing
            'userno = Nothing
            'stokkodu = Nothing
            'malincinsi = Nothing
            'barkod = Nothing
            'muadilbarkod = Nothing
            'birim = Nothing
            'kod1 = Nothing
            'kod2 = Nothing
            'kod3 = Nothing
            'kod4 = Nothing
            'kod5 = Nothing
            'kod6 = Nothing
            'kod7 = Nothing
            'kod8 = Nothing
            'kod9 = Nothing
            'kod10 = Nothing
            'satisfiyati1 = Nothing
            'satisfiyati2 = Nothing
            'satisfiyati3 = Nothing
            'istihbarat = Nothing
            'kayitno = Nothing
            'qkayitno = Nothing
            'qstokkodu = Nothing
            'qmalincinsi = Nothing
            'qbarkod = Nothing
            'qmuadilbarkod = Nothing
            'qkod1 = Nothing
            'qkod2 = Nothing
            'qkod3 = Nothing
            'qkod4 = Nothing
            'qkod5 = Nothing
            'qkod6 = Nothing
            'qkod7 = Nothing
            'qkod8 = Nothing
            'qkod9 = Nothing
            'qkod10 = Nothing
            'qistihbarat = Nothing
            'qbirim = Nothing
            'qdepo = Nothing
            'qsatisfiyati1 = Nothing
            'qsatisfiyati2 = Nothing
            'qsatisfiyati3 = Nothing
            ''XtraTabPage1.Dispose()
            ''XtraTabPage1 = Nothing
            ''stok_islemleri = Nothing
            ''stkdll = Nothing
            'dr = Nothing
            'count = Nothing
            'ps.ClearContent()
            'ps.Dispose()
            'ps = Nothing
            'printlink1.Dispose()
            'printlink1 = Nothing
            System.GC.Collect()
            System.GC.GetTotalMemory(True)
            System.GC.SuppressFinalize(Me)
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_kaydet()
    End Sub
    Private Sub frm_stok_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        stok_sil()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim file As String
        OpenFileDialog1.Filter = "Plu Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, 0)
        End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 0)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim file As String
        OpenFileDialog1.Filter = "Plu Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, 2)
        End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim file As String
        OpenFileDialog1.Filter = "Plu Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, 1)
        End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 1)
    End Sub
    Private Sub guncelle_fiyatlar()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s As String = ""
        For Each dr In DataSet1.Tables(0).Rows
            dataload_stok(dr("nStokID"))
            For Each dr1 In ds_stok.Tables(0).Rows
                Dim fiyat As Decimal = 0
                If sorgu_sayi(dr("TLPESIN"), 0) > 0 Then
                    If sorgu_sayi(dr("TLPESIN"), 0) <> sorgu_sayi(dr("PESIN"), 0) Then
                        's += "Peþin Fiyatlar Farklý" & vbCrLf
                        '///////Peþin Fiyatlarý Deðiþtir
                        Try
                            fiyat = sorgu_stok_fiyat("PS", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "PS", dr("TLPESIN"), kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "PS", dr("TLPESIN"), dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "PS", dr("TLPESIN"))
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "PS", dr("TLPESIN"))
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    End If
                Else
                    s += "TlPeþin FiyatYok" & vbTab
                    If sorgu_sayi(dr("PESIN"), 0) > 0 Then
                        Try
                            fiyat = sorgu_stok_fiyat("YTP", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "YTP", dr("PESIN") * 1000000, kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "YTP", dr("PESIN") * 1000000, dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "YTP", dr("PESIN") * 1000000)
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "YTP", dr("PESIN") * 1000000)
                            End If
                        End If
                        's += "Peþin Fiyat: " & sorgu_sayi(dr("PESIN"), 0) & vbCrLf
                    Else
                        s += "Peþin FiyatYok" & vbCrLf
                    End If
                    's += "TlPeþin FiyatYok" & vbCrLf
                End If
                '///////////////////////ALTI AYLIK FÝYATLAR
                If sorgu_sayi(dr("TLALTIAY"), 0) > 0 Then
                    If sorgu_sayi(dr("TLALTIAY"), 0) <> sorgu_sayi(dr("ALTIAY"), 0) Then
                        's += "Altý Aylýk Fiyatlar Farklý" & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("6 AY", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "6 AY", dr("TLALTIAY"), kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "6 AY", dr("TLALTIAY"), dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "6 AY", dr("TLALTIAY"))
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "6 AY", dr("TLALTIAY"))
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    End If
                Else
                    s += "TlAltý Aylýk FiyatYok" & vbTab
                    If sorgu_sayi(dr("ALTIAY"), 0) > 0 Then
                        's += "AltýAylýk Fiyat: " & sorgu_sayi(dr("ALTIAY"), 0) & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("YT6", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000, kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000, dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000)
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000)
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    Else
                        s += "AltýAylýk FiyatYok" & vbCrLf
                    End If
                    's += "TlAltý Aylýk FiyatYok" & vbCrLf
                End If
                '/////////////////////10 AYLIK FÝYATLAR
                If sorgu_sayi(dr("TLONAY"), 0) > 0 Then
                    If sorgu_sayi(dr("TLONAY"), 0) <> sorgu_sayi(dr("ONAY"), 0) Then
                        's += "Peþin Fiyatlar Farklý" & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("10AY", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "10AY", dr("TLONAY"), kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "10AY", dr("TLONAY"), dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "10AY", dr("TLONAY"))
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "10AY", dr("TLONAY"))
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    End If
                Else
                    s += "TlOn Aylýk FiyatYok" & vbTab
                    If sorgu_sayi(dr("ONAY"), 0) > 0 Then
                        's += "OnAylýk Fiyat: " & sorgu_sayi(dr("ONAY"), 0) & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("YT10", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "YT10", dr("ONAY") * 1000000, kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "YT10", dr("ONAY") * 1000000, dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "YT10", dr("ONAY") * 1000000)
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "YT10", dr("ONAY") * 1000000)
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    Else
                        s += "OnAylýk FiyatYok" & vbCrLf
                    End If
                    's += "TlOn Aylýk FiyatYok" & vbCrLf
                End If
            Next
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Stok Fiyatlarý Baþarýyla Deðiþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow
            Dim s As String = ""
            dataload_stok(dr("nStokID"))
            For Each dr1 In ds_stok.Tables(0).Rows
                Dim fiyat As Decimal = 0
                If sorgu_sayi(dr("TLPESIN"), 0) > 0 Then
                    If sorgu_sayi(dr("TLPESIN"), 0) <> sorgu_sayi(dr("PESIN"), 0) Then
                        's += "Peþin Fiyatlar Farklý" & vbCrLf
                        '///////Peþin Fiyatlarý Deðiþtir
                        Try
                            fiyat = sorgu_stok_fiyat("PS", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "PS", dr("TLPESIN"), kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "PS", dr("TLPESIN"), dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "PS", dr("TLPESIN"))
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "PS", dr("TLPESIN"))
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    End If
                Else
                    s += "TlPeþin FiyatYok" & vbTab
                    If sorgu_sayi(dr("PESIN"), 0) > 0 Then
                        Try
                            fiyat = sorgu_stok_fiyat("YTP", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "YTP", dr("PESIN") * 1000000, kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "YTP", dr("PESIN") * 1000000, dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "YTP", dr("PESIN") * 1000000)
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "YTP", dr("PESIN") * 1000000)
                            End If
                        End If
                        's += "Peþin Fiyat: " & sorgu_sayi(dr("PESIN"), 0) & vbCrLf
                    Else
                        s += "Peþin FiyatYok" & vbCrLf
                    End If
                    's += "TlPeþin FiyatYok" & vbCrLf
                End If
                '///////////////////////ALTI AYLIK FÝYATLAR
                If sorgu_sayi(dr("TLALTIAY"), 0) > 0 Then
                    If sorgu_sayi(dr("TLALTIAY"), 0) <> sorgu_sayi(dr("ALTIAY"), 0) Then
                        's += "Altý Aylýk Fiyatlar Farklý" & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("6 AY", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "6 AY", dr("TLALTIAY"), kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "6 AY", dr("TLALTIAY"), dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "6 AY", dr("TLALTIAY"))
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "6 AY", dr("TLALTIAY"))
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    End If
                Else
                    s += "TlAltý Aylýk FiyatYok" & vbTab
                    If sorgu_sayi(dr("ALTIAY"), 0) > 0 Then
                        's += "AltýAylýk Fiyat: " & sorgu_sayi(dr("ALTIAY"), 0) & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("YT6", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000, kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000, dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000)
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "YT6", dr("ALTIAY") * 1000000)
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    Else
                        s += "AltýAylýk FiyatYok" & vbCrLf
                    End If
                    's += "TlAltý Aylýk FiyatYok" & vbCrLf
                End If
                '/////////////////////10 AYLIK FÝYATLAR
                If sorgu_sayi(dr("TLONAY"), 0) > 0 Then
                    If sorgu_sayi(dr("TLONAY"), 0) <> sorgu_sayi(dr("ONAY"), 0) Then
                        's += "Peþin Fiyatlar Farklý" & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("10AY", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "10AY", dr("TLONAY"), kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "10AY", dr("TLONAY"), dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "10AY", dr("TLONAY"))
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "10AY", dr("TLONAY"))
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    End If
                Else
                    s += "TlOn Aylýk FiyatYok" & vbTab
                    If sorgu_sayi(dr("ONAY"), 0) > 0 Then
                        's += "OnAylýk Fiyat: " & sorgu_sayi(dr("ONAY"), 0) & vbCrLf
                        Try
                            fiyat = sorgu_stok_fiyat("YT10", dr("nStokID"))
                        Catch ex As Exception
                            fiyat = 0
                        End Try
                        If fiyat = 0 Then
                            ekle_fiyat(dr("nStokID"), "YT10", dr("ONAY") * 1000000, kullaniciadi)
                        Else
                            If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                                duzelt_fiyat_renk(dr("nStokID"), "YT10", dr("ONAY") * 1000000, dr1("sModel"))
                            ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                                duzelt_fiyat(dr("nStokID"), "YT10", dr("ONAY") * 1000000)
                            ElseIf dr1("nStokTipi") = 0 Then
                                duzelt_fiyat(dr("nStokID"), "YT10", dr("ONAY") * 1000000)
                            End If
                            'duzelt_fiyat(dr("STOKNO"), "PS", dr("TLPESIN"))
                        End If
                    Else
                        s += "OnAylýk FiyatYok" & vbCrLf
                    End If
                    's += "TlOn Aylýk FiyatYok" & vbCrLf
                End If
            Next
            XtraMessageBox.Show(s)
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyat Bilgilerini Güncellemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_fiyatlar()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ara()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_hareket()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
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
End Class
