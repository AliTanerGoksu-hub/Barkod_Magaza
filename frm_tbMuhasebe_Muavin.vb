Imports Microsoft.Win32
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Public Class frm_tbMuhasebe_Muavin
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
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAciklamasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIslemAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaHarAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIslemTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents sec_bDovizli As System.Windows.Forms.CheckBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents lbl_Firma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents Printlink3 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colsIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sDefter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_bAltHesapli As System.Windows.Forms.CheckBox
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbMuhasebe_Muavin))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFirmaAciklamasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIslemAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBorcTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAlacakTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBakiye = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFirmaHarAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIslemTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIslem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_Devreden = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sTarih = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sDovizCinsi = New DevExpress.XtraEditors.LookUpEdit
        Me.sec_sDefter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Firma = New DevExpress.XtraEditors.LabelControl
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit
        Me.sec_bDovizli = New System.Windows.Forms.CheckBox
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.sec_bAltHesapli = New System.Windows.Forms.CheckBox
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.Printlink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_sTarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sTarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDefter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Bakiye"
        Me.GridColumn4.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "lBakiye"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hesap Hareketleri Aşağıdaki Gibidir..."
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
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 409)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
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
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 353)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(133, 169)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(258, 133)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Bakiye Analizi"
        Me.GroupControl1.Visible = False
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 22)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(254, 109)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsDovizCinsi, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.GridColumn4
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.GridColumn4
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Doviz"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        Me.colsDovizCinsi.Visible = True
        Me.colsDovizCinsi.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Borç"
        Me.GridColumn2.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "lBorcTutar"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Alacak"
        Me.GridColumn3.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "lAlacakTutar"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 98)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 253)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem13, Me.MenuItem14, Me.MenuItem16, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem19, Me.MenuItem18, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9, Me.MenuItem27})
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem17.Text = "Ara"
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Faturayı Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 5
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Text = "Başlık Değiştir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 7
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 8
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 9
        Me.MenuItem10.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 10
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22})
        Me.MenuItem19.Text = "Raporla"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "Önizle"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 1
        Me.MenuItem24.Text = "Dizayn"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 2
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem25.Text = "Yazdır"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 3
        Me.MenuItem26.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 4
        Me.MenuItem20.Text = "Excel"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "Text"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Text = "Mail"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 11
        Me.MenuItem18.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 12
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 13
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 14
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 15
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 16
        Me.MenuItem8.Text = "Satırları Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 17
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 18
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekranı Kapla"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 19
        Me.MenuItem27.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem29, Me.MenuItem30})
        Me.MenuItem27.Text = "Language"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Text = "Türkçe"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 1
        Me.MenuItem29.Text = "English"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 2
        Me.MenuItem30.Text = "Arabic"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sFirmaKodu"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sFirmaAciklamasi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "dteIslemTarihi"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "dteValorTarihi"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "IslemAciklama"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "lFisNo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lBorcTutar"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lAlacakTutar"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Bakiye"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sFirmaHarAciklama"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sHareketTipi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "IslemTipi"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "dteKayitTarihi"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "nStokFisiID"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFirmaKodu, Me.colsFirmaAciklamasi, Me.coldteIslemTarihi, Me.coldteValorTarihi, Me.colIslemAciklama, Me.collFisNo, Me.collBorcTutar, Me.collAlacakTutar, Me.colBakiye, Me.colsFirmaHarAciklama, Me.colsHareketTipi, Me.colIslemTipi, Me.coldteKayitTarihi, Me.colnStokFisiID, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsIslem, Me.colsAciklama1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(590, 408, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Nothing, "Borc: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Nothing, "Alacak: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaKodu", Me.colsFirmaKodu, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Me.collBorcTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Me.collAlacakTutar, "{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Hesap Kodu"
        Me.colsFirmaKodu.FieldName = "sKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        Me.colsFirmaKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaKodu", "{0} Kayıt")})
        Me.colsFirmaKodu.Width = 62
        '
        'colsFirmaAciklamasi
        '
        Me.colsFirmaAciklamasi.Caption = "Hesap Adı"
        Me.colsFirmaAciklamasi.FieldName = "sFirmaAciklama"
        Me.colsFirmaAciklamasi.Name = "colsFirmaAciklamasi"
        Me.colsFirmaAciklamasi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaAciklama", "{0} Kayıt")})
        Me.colsFirmaAciklamasi.Width = 138
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "İşlem Tarihi"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", "{0} Kayıt")})
        Me.coldteIslemTarihi.Visible = True
        Me.coldteIslemTarihi.VisibleIndex = 1
        Me.coldteIslemTarihi.Width = 66
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Width = 60
        '
        'colIslemAciklama
        '
        Me.colIslemAciklama.Caption = "İşlem"
        Me.colIslemAciklama.FieldName = "IslemAciklama"
        Me.colIslemAciklama.Name = "colIslemAciklama"
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiş No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 2
        Me.collFisNo.Width = 46
        '
        'collBorcTutar
        '
        Me.collBorcTutar.Caption = "Borç"
        Me.collBorcTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutar.FieldName = "lBorcTutar"
        Me.collBorcTutar.Name = "collBorcTutar"
        Me.collBorcTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00}")})
        Me.collBorcTutar.Visible = True
        Me.collBorcTutar.VisibleIndex = 4
        Me.collBorcTutar.Width = 67
        '
        'collAlacakTutar
        '
        Me.collAlacakTutar.Caption = "Alacak"
        Me.collAlacakTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutar.FieldName = "lAlacakTutar"
        Me.collAlacakTutar.Name = "collAlacakTutar"
        Me.collAlacakTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", "{0:#,0.00}")})
        Me.collAlacakTutar.Visible = True
        Me.collAlacakTutar.VisibleIndex = 5
        Me.collAlacakTutar.Width = 68
        '
        'colBakiye
        '
        Me.colBakiye.Caption = "Bakiye"
        Me.colBakiye.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBakiye.FieldName = "lBakiye"
        Me.colBakiye.Name = "colBakiye"
        Me.colBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBakiye", "{0:#,#0.00(B);#,#0.00(A);-}")})
        Me.colBakiye.Visible = True
        Me.colBakiye.VisibleIndex = 6
        '
        'colsFirmaHarAciklama
        '
        Me.colsFirmaHarAciklama.Caption = "Açıklama"
        Me.colsFirmaHarAciklama.FieldName = "sAciklama"
        Me.colsFirmaHarAciklama.Name = "colsFirmaHarAciklama"
        Me.colsFirmaHarAciklama.Visible = True
        Me.colsFirmaHarAciklama.VisibleIndex = 3
        Me.colsFirmaHarAciklama.Width = 128
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colIslemTipi
        '
        Me.colIslemTipi.Caption = "İşlem Tipi"
        Me.colIslemTipi.FieldName = "IslemTipi"
        Me.colIslemTipi.Name = "colIslemTipi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Stok Fişi ID"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarı"
        Me.collDovizMiktari1.DisplayFormat.FormatString = "#,0.00#"
        Me.collDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru"
        Me.collDovizKuru1.DisplayFormat.FormatString = "#,0.###"
        Me.collDovizKuru1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'colsIslem
        '
        Me.colsIslem.Caption = "İşlem"
        Me.colsIslem.FieldName = "sIslem"
        Me.colsIslem.Name = "colsIslem"
        Me.colsIslem.Visible = True
        Me.colsIslem.VisibleIndex = 0
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Not"
        Me.colsAciklama1.FieldName = "sAciklama1"
        Me.colsAciklama1.Name = "colsAciklama1"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.lbl_Devreden)
        Me.PanelControl4.Controls.Add(Me.LabelControl5)
        Me.PanelControl4.Controls.Add(Me.sec_sTarih)
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Controls.Add(Me.SimpleButton5)
        Me.PanelControl4.Controls.Add(Me.SimpleButton4)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Controls.Add(Me.sec_sDovizCinsi)
        Me.PanelControl4.Controls.Add(Me.sec_sDefter)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.lbl_Firma)
        Me.PanelControl4.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl4.Controls.Add(Me.sec_bDovizli)
        Me.PanelControl4.Controls.Add(Me.SimpleButton3)
        Me.PanelControl4.Controls.Add(Me.DateEdit2)
        Me.PanelControl4.Controls.Add(Me.DateEdit1)
        Me.PanelControl4.Controls.Add(Me.sec_bAltHesapli)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 96)
        Me.PanelControl4.TabIndex = 2
        '
        'lbl_Devreden
        '
        Me.lbl_Devreden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Devreden.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Devreden.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Devreden.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Devreden.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Devreden.Location = New System.Drawing.Point(680, 6)
        Me.lbl_Devreden.Name = "lbl_Devreden"
        Me.lbl_Devreden.Size = New System.Drawing.Size(131, 20)
        Me.lbl_Devreden.TabIndex = 28
        Me.lbl_Devreden.Text = "*"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(594, 6)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "Devreden:"
        '
        'sec_sTarih
        '
        Me.sec_sTarih.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sec_sTarih.EditValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.sec_sTarih.EnterMoveNextControl = True
        Me.sec_sTarih.Location = New System.Drawing.Point(514, 68)
        Me.sec_sTarih.Name = "sec_sTarih"
        Me.sec_sTarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sTarih.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sec_sTarih.Size = New System.Drawing.Size(100, 20)
        Me.sec_sTarih.TabIndex = 26
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(434, 68)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Aralık:"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Image = Global.business_smart.My.Resources.Resources.nav_right_blue
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton5.Location = New System.Drawing.Point(714, 68)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(100, 23)
        Me.SimpleButton5.TabIndex = 23
        Me.SimpleButton5.Text = "&İleri"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = Global.business_smart.My.Resources.Resources.nav_left_blue
        Me.SimpleButton4.Location = New System.Drawing.Point(614, 68)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(100, 23)
        Me.SimpleButton4.TabIndex = 22
        Me.SimpleButton4.Text = "&Geri"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(3, 48)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Defter Türü:"
        '
        'sec_sDovizCinsi
        '
        Me.sec_sDovizCinsi.Enabled = False
        Me.sec_sDovizCinsi.EnterMoveNextControl = True
        Me.sec_sDovizCinsi.Location = New System.Drawing.Point(85, 68)
        Me.sec_sDovizCinsi.Name = "sec_sDovizCinsi"
        Me.sec_sDovizCinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDovizCinsi.Properties.DisplayMember = "sDovizCinsi"
        Me.sec_sDovizCinsi.Properties.NullText = "[Doviz]"
        Me.sec_sDovizCinsi.Properties.ValueMember = "sDovizCinsi"
        Me.sec_sDovizCinsi.Size = New System.Drawing.Size(100, 20)
        Me.sec_sDovizCinsi.TabIndex = 5
        '
        'sec_sDefter
        '
        Me.sec_sDefter.EditValue = "Tümü"
        Me.sec_sDefter.EnterMoveNextControl = True
        Me.sec_sDefter.Location = New System.Drawing.Point(85, 46)
        Me.sec_sDefter.Name = "sec_sDefter"
        Me.sec_sDefter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDefter.Properties.Items.AddRange(New Object() {"Tümü", "Günlük", "Aylık"})
        Me.sec_sDefter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sDefter.Size = New System.Drawing.Size(100, 20)
        Me.sec_sDefter.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(3, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "HesapKodu:"
        '
        'lbl_Firma
        '
        Me.lbl_Firma.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Firma.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Firma.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_Firma.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Firma.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Firma.Location = New System.Drawing.Point(298, 2)
        Me.lbl_Firma.Name = "lbl_Firma"
        Me.lbl_Firma.Size = New System.Drawing.Size(243, 20)
        Me.lbl_Firma.TabIndex = 17
        Me.lbl_Firma.Text = "*"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.EnterMoveNextControl = True
        Me.txt_musteriNo.Location = New System.Drawing.Point(85, 2)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_musteriNo.Size = New System.Drawing.Size(207, 20)
        Me.txt_musteriNo.TabIndex = 0
        '
        'sec_bDovizli
        '
        Me.sec_bDovizli.AutoSize = True
        Me.sec_bDovizli.Location = New System.Drawing.Point(27, 71)
        Me.sec_bDovizli.Name = "sec_bDovizli"
        Me.sec_bDovizli.Size = New System.Drawing.Size(56, 17)
        Me.sec_bDovizli.TabIndex = 4
        Me.sec_bDovizli.Text = "Dovizli"
        Me.sec_bDovizli.UseVisualStyleBackColor = True
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(192, 68)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(100, 23)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "Ara"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(192, 24)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 2
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(85, 24)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 1
        '
        'sec_bAltHesapli
        '
        Me.sec_bAltHesapli.AutoSize = True
        Me.sec_bAltHesapli.Location = New System.Drawing.Point(191, 49)
        Me.sec_bAltHesapli.Name = "sec_bAltHesapli"
        Me.sec_bAltHesapli.Size = New System.Drawing.Size(73, 17)
        Me.sec_bAltHesapli.TabIndex = 20
        Me.sec_bAltHesapli.Text = "AltHesaplı"
        Me.sec_bAltHesapli.UseVisualStyleBackColor = True
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.printlink, Me.Printlink3})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Muavin Defrter", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        Me.printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.InnerPageFooter
        '
        'printlink2
        '
        Me.printlink2.Component = Me.GridControl2
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'printlink
        '
        Me.printlink.BreakSpace = 10
        '
        '
        '
        Me.printlink.ImageCollection.ImageStream = CType(resources.GetObject("printlink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.Printlink3})
        Me.printlink.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink.PrintingSystem = Me.ps
        Me.printlink.PrintingSystemBase = Me.ps
        '
        'Printlink3
        '
        '
        '
        '
        Me.Printlink3.ImageCollection.ImageStream = CType(resources.GetObject("Printlink3.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.Printlink3.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.Printlink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Printlink3.PrintingSystem = Me.ps
        Me.Printlink3.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Ara ,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Yazdır ,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Text"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        Me.BarButtonItem5.Caption = "Mail"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 457)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 457)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 457)
        '
        'frm_tbMuhasebe_Muavin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 480)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbMuhasebe_Muavin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Muavin Defter"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.sec_sTarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sTarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDefter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino As String = ""
    Public kullanici
    Public bMuhasebe As Boolean = True
    Public sModul As String = "Muhasebe"
    Public sDovizCinsi As String = ""
    Dim lDevir As Decimal = 0
    Public nFirmaId As Int64 = 0
    Public sKodu As String = ""
    Public sFirmaAciklama As String = ""
    Dim ds_irsaliye As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim dataset2 As DataSet
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_tbDovizCinsi()
        If Trim(sDovizCinsi) <> "" Then
            sec_bDovizli.Checked = True
        End If
        If musterino.ToString <> "" Then
            txt_musteriNo.Text = musterino
        Else
            DateEdit1.EditValue = "01/01/" & Year(dteSistemTarihi)
            DateEdit2.EditValue = "31/12/" & Year(dteSistemTarihi)
        End If
        ara()
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
        Dim kriter As String = ""
        kriter += DateEdit1.EditValue & " ve " & DateEdit2.EditValue & Sorgu_sDil(" Tarihleri Arasındaki Hesap Hareketleri", sDil) & vbCrLf
        kriter += Sorgu_sDil("Devir Bakiyesi: ", sDil) & FormatNumber(lDevir, 2)
        printlink.Links.Clear()
        If sec_sDefter.SelectedIndex = 0 Then
            Me.printlink.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        Else
            Me.printlink.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.Printlink3})
        End If
        printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub dil_degistir_arabic()
        For Each clmn As GridColumn In GridView1.Columns
            clmn.Caption = sArabic(clmn.Caption)
        Next
        Try
            For Each btn As DevExpress.XtraBars.BarSubItem In BarManager1.Items
                btn.Caption = sArabic(btn.Caption)
            Next
        Catch ex As Exception
        End Try
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
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
    Public Function stok(ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean, ByVal bIrsaliye As Integer, ByVal sDovizCinsi As String, ByVal bAltHesapli As Boolean, ByVal bAylik As Boolean) As DataSet
        Dim kriter
        kriter = ""
        If sDovizCinsi <> "" Then
            kriter += " AND (tbFirmaHareketi.sDovizCinsi1 ='" & sDovizCinsi & "') "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If bMuhasebe = False Then
            'If bDovizli = False Then
            '    If bAltHesapli = True Then
            '        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS lBakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,tbStokFisiAciklamasi.sAciklama1,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID RIGHT OUTER JOIN tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '" & dteIslemTarihi1 & "' AND tbFirma.sKodu = '" & Trim(musterino) & "' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID ON tbStokFisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE (tbFirma.sKodu LIKE '" & Trim(musterino) & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') ORDER BY tbFirmaHareketi.dteIslemTarihi ")
            '    Else
            '        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS lBakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,tbStokFisiAciklamasi.sAciklama1,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID RIGHT OUTER JOIN tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '" & dteIslemTarihi1 & "' AND tbFirma.sKodu = '" & Trim(musterino) & "' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID ON tbStokFisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE (tbFirma.sKodu = '" & Trim(musterino) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') ORDER BY tbFirmaHareketi.dteIslemTarihi ")
            '    End If
            'ElseIf bDovizli = True Then
            '    If bAltHesapli = True Then
            '        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sCariIslem AS IslemAciklama, (SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) as sIslem,Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT sDovizCinsi1, nFirmaID, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lDevir FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi < '" & dteIslemTarihi1 & "') AND (tbFirma.sKodu = '" & Trim(musterino) & "')) TemDevir GROUP BY nFirmaID, sDovizCinsi1) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID AND tbFirmaHareketi.sDovizCinsi1 = TempDevir.sDovizCinsi1 LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu LIKE '" & Trim(musterino) & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') " & kriter & " ORDER BY tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.dteIslemTarihi ")
            '    Else
            '        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sCariIslem AS IslemAciklama, (SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) as sIslem,Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT sDovizCinsi1, nFirmaID, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lDevir FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi < '" & dteIslemTarihi1 & "') AND (tbFirma.sKodu ='" & Trim(musterino) & "')) TemDevir GROUP BY nFirmaID, sDovizCinsi1) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID AND tbFirmaHareketi.sDovizCinsi1 = TempDevir.sDovizCinsi1 LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu = '" & Trim(musterino) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') " & kriter & " ORDER BY tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.dteIslemTarihi ")
            '    End If
            'End If
        ElseIf bMuhasebe = True Then
            If bDovizli = False Then
                If bAylik = True Then
                    If bAltHesapli = True Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (month(tbMuhasebeFisi.dteFisTarihi) = '" & Month(dteIslemTarihi1) & "') AND (tbHesapPlani.sKodu LIKE '" & Trim(musterino) & "%') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    Else
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (month(tbMuhasebeFisi.dteFisTarihi) = '" & Month(dteIslemTarihi1) & "') AND (tbHesapPlani.sKodu = '" & Trim(musterino) & "') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    End If
                Else
                    If bAltHesapli = True Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu LIKE '" & Trim(musterino) & "%') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    Else
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu = '" & Trim(musterino) & "') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    End If
                End If
            ElseIf bDovizli = True Then
                If bAylik = True Then
                    If bAltHesapli = True Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (month(tbMuhasebeFisi.dteFisTarihi) = '" & Month(dteIslemTarihi1) & "') AND (tbHesapPlani.sKodu LIKE '" & Trim(musterino) & "%') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    Else
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (month(tbMuhasebeFisi.dteFisTarihi) = '" & Month(dteIslemTarihi1) & "') AND (tbHesapPlani.sKodu = '" & Trim(musterino) & "') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    End If
                Else
                    If bAltHesapli = True Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu LIKE '" & Trim(musterino) & "%') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    Else
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,ISNULL(TempDevir.lDevir, 0) AS lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN (SELECT tbMuhasebeFisi.nHesapID, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lDevir FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi < '" & dteIslemTarihi1 & "') GROUP BY tbMuhasebeFisi.nHesapID) TempDevir On tbHesapPlani.nHesapID = TempDevir.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu = '" & Trim(musterino) & "') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID ")
                    End If
                End If
            End If
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function yekun(ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean, ByVal bIrsaliye As Integer, ByVal sDovizCinsi As String, ByVal bAltHesapli As Boolean, ByVal bAylik As Boolean) As DataSet
        Dim kriter
        kriter = ""
        If sDovizCinsi <> "" Then
            kriter += " AND (tbMuhasebeFisi.sDovizCinsi1 ='" & sDovizCinsi & "') "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If bDovizli = False Then
            If bAltHesapli = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lBorcTutar) AS lBorcTutar, SUM(lAlacakTutar) AS lAlacakTutar, SUM(lBakiye) AS lBakiye FROM (SELECT tbMuhasebeFisi.sDovizCinsi1 , tbHesapPlani.nHesapID , lBorcTutar , lAlacakTutar , lBorcTutar - lAlacakTutar AS lBakiye FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi <= '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu like '" & Trim(musterino) & "%')) TemDevir ")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lBorcTutar) AS lBorcTutar, SUM(lAlacakTutar) AS lAlacakTutar, SUM(lBakiye) AS lBakiye FROM (SELECT tbMuhasebeFisi.sDovizCinsi1 , tbHesapPlani.nHesapID , lBorcTutar , lAlacakTutar , lBorcTutar - lAlacakTutar AS lBakiye FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi <= '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu = '" & Trim(musterino) & "')) TemDevir ")
            End If
        ElseIf bDovizli = True Then
            If bAltHesapli = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbMuhasebeFisi.sDovizCinsi1, tbHesapPlani.nHesapID, lBorcTutar = CASE WHEN tbMuhasebeFisi.lBorcTutar > 0 AND tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN tbMuhasebeFisi.lBorcTutar / tbMuhasebeFisi.lDovizKuru1 ELSE tbMuhasebeFisi.lBorcTutar END, lAlacakTutar = CASE WHEN tbMuhasebeFisi.lAlacakTutar > 0 AND tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN tbMuhasebeFisi.lAlacakTutar / tbMuhasebeFisi.lDovizKuru1 ELSE tbMuhasebeFisi.lAlacakTutar END, lBakiye = CASE WHEN tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN (tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) / tbMuhasebeFisi.lDovizKuru1 ELSE (tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) END FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi <= '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu like '" & Trim(musterino) & "%') " & kriter & " ) TemDevir GROUP BY sDovizCinsi1 ")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbMuhasebeFisi.sDovizCinsi1, tbHesapPlani.nHesapID, lBorcTutar = CASE WHEN tbMuhasebeFisi.lBorcTutar > 0 AND tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN tbMuhasebeFisi.lBorcTutar / tbMuhasebeFisi.lDovizKuru1 ELSE tbMuhasebeFisi.lBorcTutar END, lAlacakTutar = CASE WHEN tbMuhasebeFisi.lAlacakTutar > 0 AND tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN tbMuhasebeFisi.lAlacakTutar / tbMuhasebeFisi.lDovizKuru1 ELSE tbMuhasebeFisi.lAlacakTutar END, lBakiye = CASE WHEN tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN (tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) / tbMuhasebeFisi.lDovizKuru1 ELSE (tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) END FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi <= '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu = '" & Trim(musterino) & "') " & kriter & " ) TemDevir GROUP BY sDovizCinsi1 ")
            End If
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table2")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean, ByVal bIrsaliye As Integer, ByVal sDovizCinsi As String, ByVal bAltHesapli As Boolean, ByVal bAylik As Boolean)
        DataSet1 = stok(dteIslemTarihi1, dteIslemTarihi2, bDovizli, bIrsaliye, sDovizCinsi, bAltHesapli, bAylik)
        dataset2 = yekun(dteIslemTarihi1, dteIslemTarihi2, bDovizli, bIrsaliye, sDovizCinsi, bAltHesapli, bAylik)
        kontrol_bakiye(bDovizli, bAltHesapli)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl2.DataSource = dataset2.Tables(0)
        GridControl2.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.ExpandAllGroups()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            GridControl1.Focus()
        End If
        If sModul = "Banka" Then
            colsFirmaKodu.Caption = "Banka Kodu"
            colsFirmaAciklamasi.Caption = "Banka Adı"
        End If
    End Sub
    Public Function irsaliyeler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sIrsaliyeTipi As Integer, ByVal sDovizCinsi As String) As DataSet
        Dim kriter As String = ""
        Dim sFisTipi As String = ""
        If sIrsaliyeTipi = 1 Then
            sFisTipi = "IA"
        ElseIf sIrsaliyeTipi = 2 Then
            sFisTipi = "IS"
        End If
        kriter = "WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        If musterino.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & musterino & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & musterino & "'"
        End If
        If secim = "[Tümü]" Then
            kriter += ""
        ElseIf secim = "Açık" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 0"
        ElseIf secim = "Kapalı" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 1"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table3")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
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
    Private Sub ara()
        If txt_musteriNo.Text <> "" Then
            musterino = txt_musteriNo.Text
            txt_musteriNo.Text = musterino
            Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
            Label2.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If sec_sDefter.Text = "Günlük" Then
                sec_sTarih.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
                sec_sTarih.Properties.MinValue = DateEdit1.EditValue
                sec_sTarih.Properties.MaxValue = DateEdit2.EditValue
                dataload(sec_sTarih.EditValue, sec_sTarih.EditValue, sec_bDovizli.Checked, sec_sDefter.SelectedIndex, Trim(sec_sDovizCinsi.EditValue), sec_bAltHesapli.Checked, False)
            ElseIf sec_sDefter.Text = "Aylık" Then
                sec_sTarih.Properties.DisplayFormat.FormatString = "MM"
                sec_sTarih.Properties.MinValue = DateEdit1.EditValue
                sec_sTarih.Properties.MaxValue = DateEdit2.EditValue
                dataload("01/" & Month(sec_sTarih.EditValue) & "/" & Year(sec_sTarih.EditValue), "01/" & Month(sec_sTarih.EditValue) & "/" & Year(sec_sTarih.EditValue), sec_bDovizli.Checked, sec_sDefter.SelectedIndex, Trim(sec_sDovizCinsi.EditValue), sec_bAltHesapli.Checked, True)
            ElseIf sec_sDefter.Text = "Tümü" Then
                sec_sTarih.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
                sec_sTarih.Properties.MinValue = DateEdit1.EditValue
                sec_sTarih.Properties.MaxValue = DateEdit2.EditValue
                dataload(DateEdit1.EditValue, DateEdit2.EditValue, sec_bDovizli.Checked, sec_sDefter.SelectedIndex, Trim(sec_sDovizCinsi.EditValue), sec_bAltHesapli.Checked, False)
            End If
            lbl_Devreden.Text = FormatNumber(lDevir, 2)
            Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
            Label2.Refresh()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        Else
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            If yetki_kontrol(kullanici, "frm_Cari_Hareket_Duzelt") = True Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Trim(dr("sHangiUygulama")) = "FA" Or Trim(dr("sHangiUygulama")) = "FS" Or Trim(dr("sHangiUygulama")) = "DG" Or Trim(dr("sHangiUygulama")) = "DC" Or Trim(dr("sHangiUygulama")) = "HA" Or Trim(dr("sHangiUygulama")) = "HS" Or Trim(dr("sHangiUygulama")) = "MM" Then
                    Dim frm As New frm_fatura
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.lFisNo = dr("lFisNo")
                    frm.dteFisTarihi = dr("dteIslemTarihi")
                    frm.sFisTipi = dr("sHangiUygulama")
                    'frm.nFirmaID = dr("nFirmaID")
                    'frm.nGirisCikis = dr("nGirisCikis")
                    frm.nStokFisiID = dr("nStokFisiID")
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                    End If
                    'ara()
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                    dr = Nothing
                    Dim satir = GridView1.FocusedRowHandle
                    GridView1.FocusedRowHandle = satir
                    satir = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "MUH" Then
                    Dim frm As New frm_tbMuhasebeFisi
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.dteFisTarihi = dr("dteIslemTarihi")
                    frm.lFisNo = dr("lFisNo")
                    'frm.txt_lYevmiyeNo.EditValue = dr("lYevmiyeNo")
                    frm.kullanici = kullanici
                    frm.bMuhasabe = bMuhasebe
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        'ara()
                        GridView1.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "" Then
                    Dim frm As New frm_tbFirmaHareketi
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_dteTarih1.EditValue = dr("dteIslemTarihi")
                    frm.txt_dteTarih2.EditValue = dr("dteIslemTarihi")
                    frm.sKodu = musterino
                    frm.txt_musteriNo.Text = musterino
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    frm.nHareketID = dr("nHareketID")
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        'ara()
                        GridView1.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "CG" Or Trim(dr("sHangiUygulama")) = "CC" Or Trim(dr("sHangiUygulama")) = "TCG" Or Trim(dr("sHangiUygulama")) = "TCC" Then
                    analiz_tbFirmaBordro(dr("nFirmaID"), dr("nHareketID"))
                ElseIf Trim(dr("sHangiUygulama")) = "KASA" Then
                    Dim frm As New frm_tbNakitKasa
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_dteIslemTarihi1.EditValue = dr("dteIslemTarihi")
                    frm.txt_dteIslemTarihi2.EditValue = dr("dteIslemTarihi")
                    frm.nHareketID = dr("nHareketID")
                    frm.sFirmaKodu = musterino
                    frm.nFirmaid = dr("nFirmaID")
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        'ara()
                        GridView1.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "BC" Or Trim(dr("sHangiUygulama")) = "BS" Or Trim(dr("sHangiUygulama")) = "AC" Or Trim(dr("sHangiUygulama")) = "AS" Then
                    analiz_tbCekSenet_Hareket()
                End If
            End If
        End If
    End Sub
    Private Sub analiz_tbFirmaBordro(ByVal nFirmaID As Int64, ByVal nHareketID As Int64)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow
            Dim ds_tbFirmaBordroMaster As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaBordroMaster.nBordroID, tbFirmaBordroMaster.dteBordroTarihi, tbFirmaBordroMaster.lBordroNo, tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster ON tbFirmaBordroDetay.nBordroID = tbFirmaBordroMaster.nBordroID WHERE (tbFirmaBordroDetay.nFirmaID = " & nFirmaID & ") and (tbFirmaBordroDetay.nHareketID = " & nHareketID & ")"))
            If ds_tbFirmaBordroMaster.Tables(0).Rows.Count > 0 Then
                dr1 = ds_tbFirmaBordroMaster.Tables(0).Rows(0)
                Dim frm As New frm_tbFirmaBordro
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.kullanici = kullanici
                frm.sFisTipi = dr1("sFisTipi")
                frm.nGirisCikis = dr1("nGirisCikis")
                frm.nBordroID = dr1("nBordroID")
                frm.sFisTipi = dr1("sFisTipi")
                frm.nGirisCikis = dr1("nGirisCikis")
                frm.sHareketID = nHareketID
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                    Dim satir As String = GridView1.FocusedRowHandle
                    GridView1.FocusedRowHandle = satir
                    satir = Nothing
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
                dr1 = Nothing
                ds_tbFirmaBordroMaster.Dispose()
                ds_tbFirmaBordroMaster = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_tbCekSenet_Hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If sorgu_sayi(dr("nCekSenetID"), 0) > 0 Then
                Dim frm As New frm_tbCekSenet_Hareketleri
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.nCekSenetID = dr("nCekSenetID")
                frm.lCekSenetNo = dr("lFisNo")
                frm.sCekSenetTipi = dr("sHangiUygulama")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
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
    Private Sub kontrol_bakiye(ByVal bDovizli As Boolean, ByVal bAltHesapli As Boolean)
        Dim dr As DataRow
        Dim bakiye = 0
        Dim bakiye_status = "-"
        Dim sayi As Integer = 0
        lDevir = 0
        Dim sDovizCinsi1 As String = ""
        For Each dr In DataSet1.Tables(0).Rows
            sayi += 1
            If sayi = 1 Then
                bakiye = bakiye + dr("lDevir")
                lDevir = dr("lDevir")
            End If
            If bDovizli = True Then
                If Trim(dr("sDovizCinsi1")) <> sDovizCinsi1 Then
                    bakiye = 0
                    bakiye = bakiye + dr("lDevir")
                    sDovizCinsi1 = Trim(dr("sDovizCinsi1"))
                End If
            End If
            bakiye = bakiye + (dr("lBorcTutar") - dr("lAlacakTutar"))
            dr("lBakiye") = bakiye
            If bakiye < 0 Then
                bakiye_status = "A"
            ElseIf bakiye = 0 Then
                bakiye_status = "-"
            ElseIf bakiye > 0 Then
                bakiye_status = "B"
            End If
            If dr("nGirisCikis") = 1 Then
            ElseIf dr("nGirisCikis") = 2 Then
                If Trim(dr("sHangiUygulama").ToString) = "FA" Then
                    dr("sIslem") = "Alıştan İade"
                ElseIf Trim(dr("sHangiUygulama").ToString) = "DG" Then
                    dr("sIslem") = "StokİadeEdilen"
                End If
            ElseIf dr("nGirisCikis") = 3 Then
            ElseIf dr("nGirisCikis") = 4 Then
                If Trim(dr("sHangiUygulama").ToString) = "FS" Then
                    dr("sIslem") = "Satıştan İade"
                ElseIf Trim(dr("sHangiUygulama").ToString) = "DC" Then
                    dr("sIslem") = "StokİadeAlınan"
                End If
            End If
            dr("sIslem") = Sorgu_sDil(dr("sIslem").ToString, sDil)
            dr("sAciklama") = Replace(dr("sAciklama").ToString, "Evrak No:", Sorgu_sDil("Evrak No:", sDil))
            dr("sAciklama") = Replace(dr("sAciklama").ToString, "ISKONTO YAPILDI", Sorgu_sDil("ISKONTO YAPILDI", sDil))
            dr("sAciklama") = Replace(dr("sAciklama").ToString, "Pesin Fatura No :", Sorgu_sDil("Pesin Fatura No ::", sDil))
        Next
        If bDovizli = True Then
            GridView1.OptionsView.ShowFooter = False
            printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.ReportFooter
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString & "(" & bakiye_status & ")"
            'collBorcTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'collAlacakTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'GridView1.UpdateSummary()
            colsDovizCinsi1.Visible = True
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
            colsDovizCinsi1.Group()
        Else
            printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.None
            GridView1.OptionsView.ShowFooter = True
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
            GridView1.UpdateSummary()
            colsDovizCinsi1.Visible = False
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            colsDovizCinsi1.UnGroup()
        End If
        GridView1.ExpandAllGroups()
        'GridView1.UpdateTotalSummary()
        bakiye = Nothing
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        If bMuhasebe = False Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.islemstatus = True
            frm.kullanici = kullanici
            frm.sModul = sModul
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                nFirmaId = dr1("nFirmaID")
                sKodu = dr1("sKodu")
                musterino = sKodu
                lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
                sFirmaAciklama = Trim(dr1("sAciklama").ToString)
                txt_musteriNo.EditValue = sKodu
                dr1 = Nothing
            End If
        ElseIf bMuhasebe = True Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_HesapPlani_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.islemstatus = True
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                nFirmaId = dr1("nHesapID")
                sKodu = dr1("sKodu")
                musterino = sKodu
                lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
                sFirmaAciklama = Trim(dr1("sAciklama").ToString)
                txt_musteriNo.EditValue = sKodu
                dr1 = Nothing
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        stok_satis_detay()
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Space Then
            firma_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_musteriNo.Text) = "" Then
                firma_sec()
            End If
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        'txt_musteriNo.Text = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub sec_bDovizli_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bDovizli.CheckStateChanged
        If sec_bDovizli.Checked = True Then
            sec_sDovizCinsi.Enabled = True
        ElseIf sec_bDovizli.Checked = False Then
            sec_sDovizCinsi.Enabled = False
            sec_sDovizCinsi.EditValue = ""
        End If
    End Sub
    Private Sub sec_bDovizli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_bDovizli.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton3.Focus()
        End If
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        If MenuItem18.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem18.Checked = True
        ElseIf MenuItem18.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem18.Checked = False
        End If
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        raporla_excel()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = txt_musteriNo.Text & "_Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = txt_musteriNo.Text & "_Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.rtf) |*.rtf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.rtf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToRtf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        raporla_text()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla_rtf()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        txt_musteriNo.Text = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_rtf()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        fis_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        End If
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Ekstre*.frx) |Ekstre*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Cari Ekstre\Ekstre.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Cari Ekstre\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            report.RegisterData(DataSet1)
            report.RegisterData(dataset2)
            report.RegisterData(dataset2)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("Devreden", lDevir)
            report.SetParameterValue("dteTarih1", DateEdit1.EditValue)
            report.SetParameterValue("dteTarih2", DateEdit2.EditValue)
            report.SetParameterValue("sKodu", sKodu)
            report.SetParameterValue("nFirmaID", nFirmaId)
            Try
                report.RegisterData(ds_irsaliye, "TABLE3")
                report.GetDataSource("Table3").Enabled = True
            Catch ex As Exception
            End Try
            'report.GetDataSource("Table1").Enabled = True
            'report.GetDataSource("Table2").Enabled = True
            report.ScriptLanguage = FastReport.Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                'report.Prepare()
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla(0)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla(1)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        raporla(2)
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        dil_degistir_arabic()
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sTarih As DevExpress.XtraEditors.DateEdit
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If sec_sDefter.Text = "Günlük" Then
            sec_sTarih.EditValue = DateAdd(DateInterval.Day, 1, sec_sTarih.EditValue)
            ara()
        ElseIf sec_sDefter.Text = "Aylık" Then
            sec_sTarih.EditValue = DateAdd(DateInterval.Month, 1, sec_sTarih.EditValue)
            ara()
        ElseIf sec_sDefter.Text = "Tümü" Then
            'sec_sTarih.EditValue = DateEdit1.EditValue
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If sec_sDefter.Text = "Günlük" Then
            sec_sTarih.EditValue = DateAdd(DateInterval.Day, -1, sec_sTarih.EditValue)
            ara()
        ElseIf sec_sDefter.Text = "Aylık" Then
            sec_sTarih.EditValue = DateAdd(DateInterval.Month, -1, sec_sTarih.EditValue)
            ara()
        ElseIf sec_sDefter.Text = "Tümü" Then
            'sec_sTarih.EditValue = DateEdit1.EditValue
        End If
    End Sub

    Private Sub DateEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged
        sec_sTarih.EditValue = DateEdit1.EditValue
    End Sub
    Friend WithEvents lbl_Devreden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
