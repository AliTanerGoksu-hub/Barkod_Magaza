Imports DevExpress.XtraEditors
Public Class frm_emir_kargo_takip
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents sec_saat As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
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
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGETIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMATIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGESERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colODEMETIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICERIK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_ozelkod As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents sec_sonuc As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_izahat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_belgetipi As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_firmatipi As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents sec_odemetipi As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colODEMEYAPILDI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_kargo_takip))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGETIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_belgetipi = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFIRMATIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_firmatipi = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGESERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colODEMETIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_odemetipi = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colICERIK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_ozelkod = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colKOD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONUC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sonuc = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_izahat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colODEMEYAPILDI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_saat = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_firmatipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_odemetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sonuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_izahat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_saat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 88)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton6)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Location = New System.Drawing.Point(128, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(320, 72)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Ara"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(48, 46)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(208, 20)
        Me.SimpleButton6.TabIndex = 73
        Me.SimpleButton6.Text = "&Listele"
        '
        'Label6
        '
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(256, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "arasýndaki"
        '
        'Label8
        '
        Me.Label8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(147, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(172, 24)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 62
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(48, 24)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(-3, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Tarih:"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Gelen/Giden Kargo Listesi Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 389)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(96, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 8)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "&Ekle"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(736, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 88)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 301)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 297)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 264)
        Me.XtraTabPage1.Text = "Tanýmlar"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_saat, Me.sec_ozelkod, Me.sec_sonuc, Me.sec_izahat, Me.sec_belgetipi, Me.sec_firmatipi, Me.sec_odemetipi})
        Me.GridControl1.Size = New System.Drawing.Size(818, 264)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem17, Me.MenuItem12, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem13, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem16, Me.MenuItem15})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Satýr Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Satýr Sil"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 3
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Hesap Seç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 4
        Me.MenuItem12.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Text = "Görünümü Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "Görünümü Kaydet"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem7.Text = "Görünümü Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 9
        Me.MenuItem13.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 10
        Me.MenuItem8.Text = "Filtrele"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 11
        Me.MenuItem9.Text = "Gruplandýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 12
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "Satýrlarý Aç"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 14
        Me.MenuItem11.Text = "Satýrlarý Kapat"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 15
        Me.MenuItem16.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 16
        Me.MenuItem15.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TARIH"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "BELGETIPI"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FIRMATIPI"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "FIRMAKODU"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "FIRMAADI"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ADRES"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "TELEFON"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "YETKILI"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "BELGESERI"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "BELGENO"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ODEMETIPI"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "TUTAR"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "ICERIK"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ACIKLAMA"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "KOD1"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KOD2"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "SONUC"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "STATUS"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "IZAHAT"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ODEMEYAPILDI"
        Me.DataColumn21.DataType = GetType(Boolean)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colTARIH, Me.colBELGETIPI, Me.colFIRMATIPI, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colADRES, Me.colTELEFON, Me.colYETKILI, Me.colBELGESERI, Me.colBELGENO, Me.colODEMETIPI, Me.colTUTAR, Me.colICERIK, Me.colACIKLAMA, Me.colKOD1, Me.colKOD2, Me.colSONUC, Me.colSTATUS, Me.colIZAHAT, Me.colODEMEYAPILDI})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(533, 404, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", "{0} Kayýt")})
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 68
        '
        'colBELGETIPI
        '
        Me.colBELGETIPI.Caption = "Belge Tipi"
        Me.colBELGETIPI.ColumnEdit = Me.sec_belgetipi
        Me.colBELGETIPI.FieldName = "BELGETIPI"
        Me.colBELGETIPI.Name = "colBELGETIPI"
        Me.colBELGETIPI.Visible = True
        Me.colBELGETIPI.VisibleIndex = 1
        '
        'sec_belgetipi
        '
        Me.sec_belgetipi.AutoHeight = False
        Me.sec_belgetipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_belgetipi.Items.AddRange(New Object() {"Gelen", "Giden"})
        Me.sec_belgetipi.Name = "sec_belgetipi"
        Me.sec_belgetipi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_belgetipi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colFIRMATIPI
        '
        Me.colFIRMATIPI.Caption = "HesapTipi"
        Me.colFIRMATIPI.ColumnEdit = Me.sec_firmatipi
        Me.colFIRMATIPI.FieldName = "FIRMATIPI"
        Me.colFIRMATIPI.Name = "colFIRMATIPI"
        Me.colFIRMATIPI.Visible = True
        Me.colFIRMATIPI.VisibleIndex = 3
        '
        'sec_firmatipi
        '
        Me.sec_firmatipi.AutoHeight = False
        Me.sec_firmatipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_firmatipi.Items.AddRange(New Object() {"Firma", "Müþteri", "Diðer"})
        Me.sec_firmatipi.Name = "sec_firmatipi"
        Me.sec_firmatipi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_firmatipi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Hesap Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.OptionsColumn.ReadOnly = True
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 4
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "HesapAdý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 5
        Me.colFIRMAADI.Width = 190
        '
        'colADRES
        '
        Me.colADRES.Caption = "Adres"
        Me.colADRES.FieldName = "ADRES"
        Me.colADRES.Name = "colADRES"
        Me.colADRES.Visible = True
        Me.colADRES.VisibleIndex = 6
        Me.colADRES.Width = 215
        '
        'colTELEFON
        '
        Me.colTELEFON.Caption = "Telefon"
        Me.colTELEFON.FieldName = "TELEFON"
        Me.colTELEFON.Name = "colTELEFON"
        Me.colTELEFON.Visible = True
        Me.colTELEFON.VisibleIndex = 8
        '
        'colYETKILI
        '
        Me.colYETKILI.Caption = "Yetkili"
        Me.colYETKILI.FieldName = "YETKILI"
        Me.colYETKILI.Name = "colYETKILI"
        Me.colYETKILI.Visible = True
        Me.colYETKILI.VisibleIndex = 7
        '
        'colBELGESERI
        '
        Me.colBELGESERI.Caption = "BelgeSeri"
        Me.colBELGESERI.FieldName = "BELGESERI"
        Me.colBELGESERI.Name = "colBELGESERI"
        Me.colBELGESERI.Visible = True
        Me.colBELGESERI.VisibleIndex = 9
        Me.colBELGESERI.Width = 56
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Visible = True
        Me.colBELGENO.VisibleIndex = 10
        '
        'colODEMETIPI
        '
        Me.colODEMETIPI.Caption = "ÖdemeTipi"
        Me.colODEMETIPI.ColumnEdit = Me.sec_odemetipi
        Me.colODEMETIPI.FieldName = "ODEMETIPI"
        Me.colODEMETIPI.Name = "colODEMETIPI"
        Me.colODEMETIPI.Visible = True
        Me.colODEMETIPI.VisibleIndex = 11
        '
        'sec_odemetipi
        '
        Me.sec_odemetipi.AutoHeight = False
        Me.sec_odemetipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_odemetipi.Items.AddRange(New Object() {"Bizden", "KarþýTaraftan", "Yok"})
        Me.sec_odemetipi.Name = "sec_odemetipi"
        Me.sec_odemetipi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_odemetipi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 12
        '
        'colICERIK
        '
        Me.colICERIK.Caption = "Ýçerik"
        Me.colICERIK.FieldName = "ICERIK"
        Me.colICERIK.Name = "colICERIK"
        Me.colICERIK.Visible = True
        Me.colICERIK.VisibleIndex = 14
        Me.colICERIK.Width = 129
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 15
        Me.colACIKLAMA.Width = 257
        '
        'colKOD1
        '
        Me.colKOD1.Caption = "1.ÖzelKod"
        Me.colKOD1.ColumnEdit = Me.sec_ozelkod
        Me.colKOD1.FieldName = "KOD1"
        Me.colKOD1.Name = "colKOD1"
        Me.colKOD1.Visible = True
        Me.colKOD1.VisibleIndex = 16
        '
        'sec_ozelkod
        '
        Me.sec_ozelkod.AutoHeight = False
        Me.sec_ozelkod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ozelkod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sec_ozelkod.Name = "sec_ozelkod"
        '
        'colKOD2
        '
        Me.colKOD2.Caption = "2.ÖzelKod"
        Me.colKOD2.ColumnEdit = Me.sec_ozelkod
        Me.colKOD2.FieldName = "KOD2"
        Me.colKOD2.Name = "colKOD2"
        Me.colKOD2.Visible = True
        Me.colKOD2.VisibleIndex = 17
        '
        'colSONUC
        '
        Me.colSONUC.Caption = "Sonuç"
        Me.colSONUC.ColumnEdit = Me.sec_sonuc
        Me.colSONUC.FieldName = "SONUC"
        Me.colSONUC.Name = "colSONUC"
        Me.colSONUC.Visible = True
        Me.colSONUC.VisibleIndex = 18
        Me.colSONUC.Width = 81
        '
        'sec_sonuc
        '
        Me.sec_sonuc.AutoHeight = False
        Me.sec_sonuc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sonuc.Items.AddRange(New Object() {"Bekliyor...", "Tamamlandý...", "ÝptalEdildi..."})
        Me.sec_sonuc.Name = "sec_sonuc"
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Durum"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Ýzahat"
        Me.colIZAHAT.ColumnEdit = Me.sec_izahat
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 2
        '
        'sec_izahat
        '
        Me.sec_izahat.AutoHeight = False
        Me.sec_izahat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_izahat.Items.AddRange(New Object() {"Paket", "Kargo", "Nakliye", "Gönderi", "Mektup", "Zarf", "Tebligat", "Fatura", "Bildiri", "Promosyon", "Tanýtým", "Ýnsört", "Reklam", "Video"})
        Me.sec_izahat.Name = "sec_izahat"
        '
        'colODEMEYAPILDI
        '
        Me.colODEMEYAPILDI.Caption = "ÖdemeYapýldý?"
        Me.colODEMEYAPILDI.FieldName = "ODEMEYAPILDI"
        Me.colODEMEYAPILDI.Name = "colODEMEYAPILDI"
        Me.colODEMEYAPILDI.Visible = True
        Me.colODEMEYAPILDI.VisibleIndex = 13
        Me.colODEMEYAPILDI.Width = 82
        '
        'sec_saat
        '
        Me.sec_saat.AutoHeight = False
        Me.sec_saat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_saat.DisplayFormat.FormatString = "HH:mm"
        Me.sec_saat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.sec_saat.Name = "sec_saat"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(818, 264)
        Me.XtraTabPage2.Text = "Raporlar"
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
        Me.printlink1.Landscape = True
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Kargo/Paket/Nakliye Takibi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Evrak Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_emir_kargo_takip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emir_kargo_takip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kargo ve Paket Takibi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_firmatipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_odemetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sonuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_izahat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_saat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    Private Sub frm_emir_arac_km_takip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        dataload(DateEdit1.EditValue, DateEdit2.EditValue)
        status = True
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_emir_arac_km_takip_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'e.Cancel = True
        ''Me.Hide()
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton3 = Nothing
        'XtraTabControl1 = Nothing
        'XtraTabPage1 = Nothing
        'XtraTabPage2 = Nothing
        'GridControl1 = Nothing
        'DataSet1 = Nothing
        'DataTable1 = Nothing
        'sec_saat = Nothing
        'GridView1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem13 = Nothing
        'MenuItem14 = Nothing
        'MenuItem15 = Nothing
        'MenuItem16 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn7 = Nothing
        'DataColumn8 = Nothing
        'DataColumn9 = Nothing
        'DataColumn10 = Nothing
        'DataColumn11 = Nothing
        'DataColumn12 = Nothing
        'DataColumn13 = Nothing
        'DataColumn14 = Nothing
        'DataColumn15 = Nothing
        'DataColumn16 = Nothing
        'DataColumn17 = Nothing
        'DataColumn18 = Nothing
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'colIND = Nothing
        'colTARIH = Nothing
        'colBELGETIPI = Nothing
        'colFIRMATIPI = Nothing
        'colFIRMAKODU = Nothing
        'colFIRMAADI = Nothing
        'colADRES = Nothing
        'colTELEFON = Nothing
        'colYETKILI = Nothing
        'colBELGESERI = Nothing
        'colBELGENO = Nothing
        'colODEMETIPI = Nothing
        'colTUTAR = Nothing
        'colICERIK = Nothing
        'colACIKLAMA = Nothing
        'colKOD1 = Nothing
        'colKOD2 = Nothing
        'colSONUC = Nothing
        'colSTATUS = Nothing
        'colIZAHAT = Nothing
        'sec_ozelkod = Nothing
        'sec_sonuc = Nothing
        'sec_izahat = Nothing
        'sec_belgetipi = Nothing
        'sec_firmatipi = Nothing
        'DataColumn21 = Nothing
        'sec_odemetipi = Nothing
        'MenuItem17 = Nothing
        'Label3 = Nothing
        'ps = Nothing
        'printlink1 = Nothing
        'colODEMEYAPILDI = Nothing
        'GroupControl1 = Nothing
        'Label6 = Nothing
        'Label7 = Nothing
        'Label8 = Nothing
        'DateEdit2 = Nothing
        'DateEdit1 = Nothing
        'SimpleButton6 = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'connection = Nothing
        'cmd = Nothing
        'con = Nothing
        'adapter = Nothing
        'status = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        satir_ekle()
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        DataSet1 = sorgu_s(sorgu_query("SELECT     * FROM         aEmirKargoTakip WHERE TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
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
    Private Sub satir_ekle()
        Dim dr As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("TARIH") = DateEdit1.EditValue
        dr("BELGETIPI") = "Gelen"
        dr("IZAHAT") = "Kargo"
        dr("FIRMATIPI") = "Firma"
        dr("FIRMAKODU") = ""
        dr("FIRMAADI") = ""
        dr("ADRES") = ""
        dr("YETKILI") = ""
        dr("TELEFON") = ""
        dr("BELGESERI") = ""
        dr("BELGENO") = ""
        dr("ODEMETIPI") = "Yok"
        dr("TUTAR") = 0
        dr("ODEMEYAPILDI") = 0
        dr("ICERIK") = ""
        dr("ACIKLAMA") = ""
        dr("KOD1") = ""
        dr("KOD2") = ""
        dr("SONUC") = Sorgu_sDil("Tamamlandý...", sDil)
        dr("STATUS") = 0
        dr("IND") = hareket_kaydet_yeni(dr("TARIH"), dr("BELGETIPI"), dr("IZAHAT"), dr("FIRMATIPI"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("ADRES"), dr("YETKILI"), dr("TELEFON"), dr("BELGESERI"), dr("BELGENO"), dr("ODEMETIPI"), dr("TUTAR"), dr("ODEMEYAPILDI"), dr("ICERIK"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("SONUC"), dr("STATUS"))
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            If dr("ODEMETIPI") = "Yok" Then
                dr("TUTAR") = 0
            End If
            'If dr("KM") = 0 Then
            '    dr("MIKTAR") = 1
            'End If
            'dr("KM") = dr("VARISKM") - dr("CIKISKM")
            'dr("SURE") = DateDiff(DateInterval.Minute, dr("CIKISSAAT"), dr("VARISSAAT"))
            'If dr("PLAKA") <> "" Then
            '    dr(sorgu_sDil("Dikkat",sDil)) = 1
            'Else
            '    dr(sorgu_sDil("Dikkat",sDil)) = 0
            'End If
            'If GridView1.FocusedColumn.Name.ToString = colHTUTAR.Name.ToString Then
            '    dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
            'Else
            '    dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            'End If
            'dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), dr("TARIH"), dr("BELGETIPI"), dr("IZAHAT"), dr("FIRMATIPI"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("ADRES"), dr("YETKILI"), dr("TELEFON"), dr("BELGESERI"), dr("BELGENO"), dr("ODEMETIPI"), dr("TUTAR"), dr("ODEMEYAPILDI"), dr("ICERIK"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("SONUC"), dr("STATUS"))
            'hareket_kaydet_degistir(dr("IND"), dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub musteri()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("FIRMAKODU") = Microsoft.VisualBasic.Left(dr1("lKodu"), 50)
            dr("FIRMAADI") = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
            dr("YETKILI") = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
            dr("ADRES") = dr1("sEvAdresi")
            dr("TELEFON") = dr1("sEvTelefonu")
            girdi_tutar_hesapla()
            GridView1.UpdateCurrentRow()
        End If
    End Sub
    Private Sub firma()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            'dr_baslik("FIRMANO") = Trim(dr1("nFirmaID"))
            dr("FIRMAKODU") = Microsoft.VisualBasic.Left(Trim(dr1("sKodu")), 50)
            dr("FIRMAADI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
            dr("YETKILI") = ""
            dr("ADRES") = Trim(dr1("Adres"))
            dr("TELEFON") = ""
            girdi_tutar_hesapla()
        End If
    End Sub
    Private Function hareket_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGETIPI As String, ByVal IZAHAT As String, ByVal FIRMATIPI As String, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal ADRES As String, ByVal YETKILI As String, ByVal TELEFON As String, ByVal BELGESERI As String, ByVal BELGENO As String, ByVal ODEMETIPI As String, ByVal TUTAR As Decimal, ByVal ODEMEYAPILDI As Byte, ByVal ICERIK As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal SONUC As String, ByVal STATUS As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirKargoTakip (TARIH, BELGETIPI, IZAHAT, FIRMATIPI, FIRMAKODU, FIRMAADI, ADRES, YETKILI, TELEFON, BELGESERI, BELGENO, ODEMETIPI, TUTAR, ODEMEYAPILDI, ICERIK, ACIKLAMA, KOD1, KOD2, SONUC, STATUS) VALUES     ('" & TARIH & "', '" & BELGETIPI & "', '" & IZAHAT & "', '" & FIRMATIPI & "', '" & FIRMAKODU & "', '" & FIRMAADI & "' , '" & ADRES & "', '" & YETKILI & "', '" & TELEFON & "', '" & BELGESERI & "', '" & BELGENO & "', '" & ODEMETIPI & "', " & TUTAR & "," & ODEMEYAPILDI & " , '" & ICERIK & "', '" & ACIKLAMA & "', '" & KOD1 & "', '" & KOD2 & "', '" & SONUC & "', " & STATUS & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal TARIH As DateTime, ByVal BELGETIPI As String, ByVal IZAHAT As String, ByVal FIRMATIPI As String, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal ADRES As String, ByVal YETKILI As String, ByVal TELEFON As String, ByVal BELGESERI As String, ByVal BELGENO As String, ByVal ODEMETIPI As String, ByVal TUTAR As Decimal, ByVal ODEMEYAPILDI As Byte, ByVal ICERIK As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal SONUC As String, ByVal STATUS As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirKargoTakip SET              TARIH = '" & TARIH & "', BELGETIPI = '" & BELGETIPI & "', IZAHAT = '" & IZAHAT & "', FIRMATIPI = '" & FIRMATIPI & "', FIRMAKODU = '" & FIRMAKODU & "', FIRMAADI = '" & FIRMAADI & "', ADRES = '" & ADRES & "', YETKILI = '" & YETKILI & "', TELEFON = '" & TELEFON & "', BELGESERI = '" & BELGESERI & "', BELGENO = '" & BELGENO & "', ODEMETIPI = '" & ODEMETIPI & "', TUTAR = " & TUTAR & " , ODEMEYAPILDI = " & ODEMEYAPILDI & " , ICERIK = '" & ICERIK & "', ACIKLAMA = '" & ACIKLAMA & "', KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', SONUC = '" & SONUC & "', STATUS = " & STATUS & " WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM aEmirKargoTakip  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sorgu_s(ByVal query As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub yetki_kontrol()
        Dim yetki As Int64 = Sorgu_Yetki(kullanici, Me.Name)
        If yetki = 0 Then
            Me.Hide()
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!" & vbCrLf & "Lütfen Sistem Yönecinizle Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            status = True
            Me.Close()
        ElseIf yetki = 1 Then
        End If
    End Sub
    Private Function Sorgu_Yetki(ByVal kasiyerno As Int64, ByVal Form As String, Optional ByVal islem As Integer = 0, Optional ByVal bYetki As Integer = 0) As Int64
        Dim kriter
        kriter = " WHERE     (Personel.PersonelNo = " & kasiyerno & ") AND (Forms.Form = '" & Form & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         aEmirForms WHERE     (Form = '" & Form & "')")
        formkayitsayisi = cmd.ExecuteScalar
        If formkayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES     ('Genel', '" & Form & "', '" & Form & "', " & bYetki & ")")
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(CAST(Personel.Yetki AS int), 0) AS Yetki FROM         aPersonelYetki Personel INNER JOIN                       aEmirForms Forms ON Personel.Form = Forms.Form  " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        If islem = 1 Then
            If kayitsayisi = 0 Then
                kayitsayisi = 1
            ElseIf kayitsayisi = 1 Then
                kayitsayisi = 0
            End If
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr("IND").ToString <> "" Then
                    hareket_kaydet_sil(dr("IND"))
                End If
                'DataTable1.Rows.RemoveAt(GridView1.FocusedRowHandle - 1)
                DataSet1.Tables(0).Rows.Remove(dr)
                'dr.Delete()
                'dr.AcceptChanges()
                'GridControl1.EndUpdate()
                'DataSet1.EndInit()
                GridControl1.Select()
                GridControl1.Focus()
            End If
        End If
    End Sub
    Private Sub hesap_sec()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("FIRMATIPI") = "Firma" Then
                firma()
            ElseIf dr("FIRMATIPI") = "Müþteri" Then
                musteri()
            ElseIf dr("FIRMATIPI") = "Diðer" Then
                dr("FIRMAKODU") = "Diðer..."
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub DateEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If status = True Then
        '    dataload()
        'End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        hesap_sec()
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
            Label3.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label3.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label3.Text = ""
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        gorunum_kaydet()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        dataload(DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
End Class
