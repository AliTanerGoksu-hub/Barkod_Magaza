Imports System.IO
Imports DevExpress.XtraEditors
Public Class frmposciro
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKASA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFATURA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPTALTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colARATOPLAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINDIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORTALAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAKIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKREDI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKREDI2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents ps1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colIADE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbl_Tarih As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblpos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_SonOkuma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colKREDI3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKREDI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents colKREDI4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colIADETUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmposciro))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl
        Me.lblpos = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.lbl_Tarih = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_SonOkuma = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKASA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFATURA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIPTAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIPTALTUTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colARATOPLAM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINDIRIM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colORTALAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNAKIT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKREDI1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKREDI2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIADE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKREDI3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKREDI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKREDI4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIADETUTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataSet1 = New System.Data.DataSet
        Me.ps1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.Controls.Add(Me.lblpos)
        Me.Panel1.Controls.Add(Me.GroupControl3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 126)
        Me.Panel1.TabIndex = 2
        '
        'lblpos
        '
        Me.lblpos.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblpos.Location = New System.Drawing.Point(563, 44)
        Me.lblpos.Name = "lblpos"
        Me.lblpos.Size = New System.Drawing.Size(47, 19)
        Me.lblpos.TabIndex = 5
        Me.lblpos.Text = "%pos"
        Me.lblpos.Visible = False
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.DateEdit2)
        Me.GroupControl3.Controls.Add(Me.DateEdit1)
        Me.GroupControl3.Controls.Add(Me.lbl_Tarih)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.SpinEdit2)
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Controls.Add(Me.SpinEdit1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl3.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(438, 122)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = " -- Kasalar --"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoEllipsis = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(212, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl3.TabIndex = 71
        Me.LabelControl3.Text = "SonTarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2009, 3, 1, 0, 0, 0, 0)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(295, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateEdit2.Properties.Appearance.Options.UseFont = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(137, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2009, 3, 1, 0, 0, 0, 0)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(61, 22)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(145, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'lbl_Tarih
        '
        Me.lbl_Tarih.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Tarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Tarih.AutoEllipsis = True
        Me.lbl_Tarih.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Tarih.Location = New System.Drawing.Point(6, 22)
        Me.lbl_Tarih.Name = "lbl_Tarih"
        Me.lbl_Tarih.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Tarih.TabIndex = 69
        Me.lbl_Tarih.Text = "ÝlkTarih:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoEllipsis = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(212, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 68
        Me.LabelControl2.Text = "SonKasa:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoEllipsis = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(6, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 67
        Me.LabelControl1.Text = "IlkKasa:"
        '
        'SpinEdit2
        '
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit2.EnterMoveNextControl = True
        Me.SpinEdit2.Location = New System.Drawing.Point(295, 43)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SpinEdit2.Properties.Appearance.Options.UseFont = True
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit2.Properties.MaxValue = New Decimal(New Integer() {1001, 0, 0, 0})
        Me.SpinEdit2.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit2.Size = New System.Drawing.Size(137, 20)
        Me.SpinEdit2.TabIndex = 3
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(61, 73)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(371, 24)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "&Yenile"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.EnterMoveNextControl = True
        Me.SpinEdit1.Location = New System.Drawing.Point(61, 44)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SpinEdit1.Properties.Appearance.Options.UseFont = True
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {1001, 0, 0, 0})
        Me.SpinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(145, 20)
        Me.SpinEdit1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(557, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pos Kasa Satýþ Raporu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbl_SonOkuma)
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 48)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Son Okuma:"
        '
        'lbl_SonOkuma
        '
        Me.lbl_SonOkuma.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SonOkuma.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_SonOkuma.Location = New System.Drawing.Point(124, 14)
        Me.lbl_SonOkuma.Name = "lbl_SonOkuma"
        Me.lbl_SonOkuma.Size = New System.Drawing.Size(5, 16)
        Me.lbl_SonOkuma.TabIndex = 6
        Me.lbl_SonOkuma.Text = ":"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 14)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 14)
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
        Me.Panel3.Location = New System.Drawing.Point(0, 126)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(824, 296)
        Me.Panel3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataSource = Me.DataTable1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 292)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem1.Text = "Görünümü Yazdýr"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem2.Text = "Ekraný Kapla"
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.AutoIncrementSeed = CType(1, Long)
        Me.DataColumn1.ColumnName = "KASA"
        Me.DataColumn1.DataType = GetType(Integer)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "FIS"
        Me.DataColumn2.DataType = GetType(Integer)
        Me.DataColumn2.DefaultValue = 0
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FATURA"
        Me.DataColumn3.DataType = GetType(Integer)
        Me.DataColumn3.DefaultValue = 0
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "IPTAL"
        Me.DataColumn4.DataType = GetType(Integer)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "IPTALTUTAR"
        Me.DataColumn5.DataType = GetType(Decimal)
        Me.DataColumn5.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ARATOPLAM"
        Me.DataColumn6.DataType = GetType(Decimal)
        Me.DataColumn6.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "INDIRIM"
        Me.DataColumn7.DataType = GetType(Decimal)
        Me.DataColumn7.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ORTALAMA"
        Me.DataColumn8.DataType = GetType(Decimal)
        Me.DataColumn8.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "NAKIT"
        Me.DataColumn9.DataType = GetType(Decimal)
        Me.DataColumn9.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KREDI1"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KREDI2"
        Me.DataColumn11.DataType = GetType(Decimal)
        Me.DataColumn11.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "IADE"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KREDI3"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "KREDI4"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "KREDI"
        Me.DataColumn15.DataType = GetType(Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "IADETUTAR"
        Me.DataColumn16.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKASA, Me.colFIS, Me.colFATURA, Me.colIPTAL, Me.colIPTALTUTAR, Me.colARATOPLAM, Me.colINDIRIM, Me.colORTALAMA, Me.colNAKIT, Me.colKREDI1, Me.colKREDI2, Me.colIADE, Me.colKREDI3, Me.colKREDI, Me.colKREDI4, Me.colIADETUTAR})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolon Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colKASA
        '
        Me.colKASA.Caption = "KasaNo"
        Me.colKASA.FieldName = "KASA"
        Me.colKASA.Name = "colKASA"
        Me.colKASA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "KASA", "{0}")})
        Me.colKASA.Visible = True
        Me.colKASA.VisibleIndex = 0
        Me.colKASA.Width = 48
        '
        'colFIS
        '
        Me.colFIS.Caption = "Fiþ"
        Me.colFIS.FieldName = "FIS"
        Me.colFIS.Name = "colFIS"
        Me.colFIS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FIS", "{0:#,0}")})
        Me.colFIS.Visible = True
        Me.colFIS.VisibleIndex = 1
        Me.colFIS.Width = 23
        '
        'colFATURA
        '
        Me.colFATURA.Caption = "Fatura"
        Me.colFATURA.FieldName = "FATURA"
        Me.colFATURA.Name = "colFATURA"
        Me.colFATURA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FATURA", "{0:#,0}")})
        Me.colFATURA.Visible = True
        Me.colFATURA.VisibleIndex = 2
        Me.colFATURA.Width = 42
        '
        'colIPTAL
        '
        Me.colIPTAL.Caption = "Ýptal"
        Me.colIPTAL.FieldName = "IPTAL"
        Me.colIPTAL.Name = "colIPTAL"
        Me.colIPTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IPTAL", "{0:#,0}")})
        Me.colIPTAL.Visible = True
        Me.colIPTAL.VisibleIndex = 5
        Me.colIPTAL.Width = 32
        '
        'colIPTALTUTAR
        '
        Me.colIPTALTUTAR.Caption = "ÝptalTutarý"
        Me.colIPTALTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colIPTALTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIPTALTUTAR.FieldName = "IPTALTUTAR"
        Me.colIPTALTUTAR.Name = "colIPTALTUTAR"
        Me.colIPTALTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IPTALTUTAR", "{0:#,0.00}")})
        Me.colIPTALTUTAR.Visible = True
        Me.colIPTALTUTAR.VisibleIndex = 6
        Me.colIPTALTUTAR.Width = 60
        '
        'colARATOPLAM
        '
        Me.colARATOPLAM.Caption = "ToplamCiro"
        Me.colARATOPLAM.DisplayFormat.FormatString = "#,0.00"
        Me.colARATOPLAM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colARATOPLAM.FieldName = "ARATOPLAM"
        Me.colARATOPLAM.Name = "colARATOPLAM"
        Me.colARATOPLAM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ARATOPLAM", "{0:#,0.00}")})
        Me.colARATOPLAM.Visible = True
        Me.colARATOPLAM.VisibleIndex = 7
        Me.colARATOPLAM.Width = 63
        '
        'colINDIRIM
        '
        Me.colINDIRIM.Caption = "ToplamÝnd."
        Me.colINDIRIM.DisplayFormat.FormatString = "#,0.00"
        Me.colINDIRIM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colINDIRIM.FieldName = "INDIRIM"
        Me.colINDIRIM.Name = "colINDIRIM"
        Me.colINDIRIM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INDIRIM", "{0:#,0.00}")})
        Me.colINDIRIM.Visible = True
        Me.colINDIRIM.VisibleIndex = 8
        Me.colINDIRIM.Width = 64
        '
        'colORTALAMA
        '
        Me.colORTALAMA.Caption = "Ort.Ciro"
        Me.colORTALAMA.DisplayFormat.FormatString = "#,0.00"
        Me.colORTALAMA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORTALAMA.FieldName = "ORTALAMA"
        Me.colORTALAMA.Name = "colORTALAMA"
        Me.colORTALAMA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "ORTALAMA", "Ort {0:#,0.00}")})
        Me.colORTALAMA.Visible = True
        Me.colORTALAMA.VisibleIndex = 9
        Me.colORTALAMA.Width = 50
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
        Me.colNAKIT.VisibleIndex = 10
        Me.colNAKIT.Width = 53
        '
        'colKREDI1
        '
        Me.colKREDI1.Caption = "KrediCiro1"
        Me.colKREDI1.DisplayFormat.FormatString = "#,0.00"
        Me.colKREDI1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKREDI1.FieldName = "KREDI1"
        Me.colKREDI1.Name = "colKREDI1"
        Me.colKREDI1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KREDI1", "{0:#,0.00}")})
        Me.colKREDI1.Visible = True
        Me.colKREDI1.VisibleIndex = 12
        Me.colKREDI1.Width = 59
        '
        'colKREDI2
        '
        Me.colKREDI2.Caption = "KrediCiro2"
        Me.colKREDI2.DisplayFormat.FormatString = "#,0.00"
        Me.colKREDI2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKREDI2.FieldName = "KREDI2"
        Me.colKREDI2.Name = "colKREDI2"
        Me.colKREDI2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KREDI2", "{0:#,0.00}")})
        Me.colKREDI2.Visible = True
        Me.colKREDI2.VisibleIndex = 13
        Me.colKREDI2.Width = 59
        '
        'colIADE
        '
        Me.colIADE.Caption = "Ýade"
        Me.colIADE.DisplayFormat.FormatString = "#,0"
        Me.colIADE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIADE.FieldName = "IADE"
        Me.colIADE.Name = "colIADE"
        Me.colIADE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADE", "{0:#,0}")})
        Me.colIADE.Visible = True
        Me.colIADE.VisibleIndex = 3
        Me.colIADE.Width = 32
        '
        'colKREDI3
        '
        Me.colKREDI3.Caption = "KrediCiro3"
        Me.colKREDI3.DisplayFormat.FormatString = "#,0.00"
        Me.colKREDI3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKREDI3.FieldName = "KREDI3"
        Me.colKREDI3.Name = "colKREDI3"
        Me.colKREDI3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KREDI3", "{0:#,0.00}")})
        Me.colKREDI3.Visible = True
        Me.colKREDI3.VisibleIndex = 14
        Me.colKREDI3.Width = 59
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
        Me.colKREDI.VisibleIndex = 11
        Me.colKREDI.Width = 53
        '
        'colKREDI4
        '
        Me.colKREDI4.Caption = "KrediCiro4"
        Me.colKREDI4.DisplayFormat.FormatString = "#,0.00"
        Me.colKREDI4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKREDI4.FieldName = "KREDI4"
        Me.colKREDI4.Name = "colKREDI4"
        Me.colKREDI4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KREDI4", "{0:#,0.00}")})
        Me.colKREDI4.Visible = True
        Me.colKREDI4.VisibleIndex = 15
        Me.colKREDI4.Width = 59
        '
        'colIADETUTAR
        '
        Me.colIADETUTAR.Caption = "ÝadeTutari"
        Me.colIADETUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colIADETUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIADETUTAR.FieldName = "IADETUTAR"
        Me.colIADETUTAR.Name = "colIADETUTAR"
        Me.colIADETUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADETUTAR", "{0:#,0.00}")})
        Me.colIADETUTAR.Visible = True
        Me.colIADETUTAR.VisibleIndex = 4
        Me.colIADETUTAR.Width = 60
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'ps1
        '
        Me.ps1.Links.AddRange(New Object() {Me.printlink1})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[Date Printed][Time Printed]", "Pos Kasa Satýþ Raporu", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps1
        Me.printlink1.PrintingSystemBase = Me.ps1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'frmposciro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 470)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmposciro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ciro Raporu"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Dim i As Integer
    Dim s As String
    Dim gun
    Dim ay
    Dim yil
    Dim dll As New AppYazarKasa
    Public islem As Integer = 1
    Public nIlkKasa As Integer = 1
    Public nSonKasa As Integer = 1
    Public sPath As String
    Public sFile As String
    Public tarih As String
    Public tarih2 As String
    Public dteIslemTarihi As DateTime
    Public kasa As String
    Dim fis
    Dim iade As Integer = 0
    Dim iadetutar As Decimal = 0
    Dim fatura
    Dim iptal
    Dim aratoplam As Decimal = 0
    Dim faturakdv As Decimal = 0
    Dim indirim As Decimal = 0
    Dim nakit As Decimal = 0
    Dim kredi1 As Decimal = 0
    Dim kredi2 As Decimal = 0
    Dim kredi3 As Decimal = 0
    Dim kredi4 As Decimal = 0
    Dim kredi5 As Decimal = 0
    Dim kredi As Decimal = 0
    Dim belgeiptal As Integer = 0
    Dim belgeiptaltutar As Decimal = 0
    Dim ortalamaciro As Decimal = 0
    Dim sAyrac As String = ":"
    Private Sub frmposciro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteIslemTarihi
        DateEdit2.EditValue = dteIslemTarihi
        SpinEdit1.Value = nIlkKasa
        SpinEdit2.Value = nSonKasa
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        ara()
    End Sub
    Private Sub ara()
        sorgu(islem, SpinEdit1.Value, SpinEdit2.Value, sPath, DateEdit1.EditValue, DateEdit2.EditValue, kasa)
    End Sub
    Private Sub sorgu(ByVal islem As Integer, ByVal nIlkKasa As Integer, ByVal nSonKasa As Integer, ByVal sPath As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasa As String)
        DataSet1.Tables(0).Clear()
        Dim tarih As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        ciro_inter_sifirla()
        If islem = 1 Then
            con.Open()
            cmd.CommandText = "TRUNCATE TABLE BTBLINTERSATIS"
            cmd.ExecuteNonQuery()
            con.Close()
            dll.dataset1.Clear()
        ElseIf islem = 2 Then
            dll.dataset1 = DataSet1
            dll.dataset1.Tables(0).Clear()
        ElseIf islem = 3 Then
            dll.dataset1.Tables(0).Clear()
        ElseIf islem = 4 Then
            dll.dataset1 = DataSet1
            con.Open()
            cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        tarih = tarih1.ToShortDateString
        Dim t As Integer = 0
        Dim gunsayisi As Integer = 1
        gunsayisi = DateDiff(DateInterval.Day, tarih1, tarih2)
        For i = nIlkKasa To nSonKasa
            For t = 0 To gunsayisi
                tarih = DateAdd(DateInterval.Day, t, tarih1)
                yil = tarih.Substring(8, 2)
                gun = tarih.Substring(0, 2)
                ay = tarih.Substring(3, 2)
                Dim path = sPath  'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("INTERPOS").GetValue("PATH")
                s = "" & sPath & sAyrac & sFile & "\posgenel\HR"
                s += gun
                s += ay
                s += yil
                s += ".00"
                s += nIlkKasa.ToString
                Dim DOSYA As New FileInfo(s)
                If DOSYA.Exists Then
                    DOSYA.CopyTo("" & s & "YDK", True)
                    If islem = 1 Then
                        'dll.intersatisoku(s & "YDK", kasa)
                    ElseIf islem = 2 Then
                        ciro_INTER(s & "YDK", nIlkKasa, kasa)
                    ElseIf islem = 3 Then
                        dll.interurunkontrol(s & "YDK", kasa)
                    ElseIf islem = 4 Then
                        dll.satis_INTER(s & "YDK", kasa)
                    End If
                Else
                    'MsgBox("Hareket Dosyasý Bulunamadý" & vbCrLf & "Kasano =" & nIlkKasa & vbCrLf & "Path :" & s,  MessageBoxIcon.Exclamation)
                End If
                'MsgBox(s)
                'ciro_inter_ekle(nIlkKasa)
                'ciro_inter_sifirla()
            Next
            ciro_inter_ekle(nIlkKasa)
            ciro_inter_sifirla()
            nIlkKasa += 1
        Next
        Dim DOSYA1 As New FileInfo(s)
        If DOSYA1.Exists Then
            If islem = 1 Then
                'dll.satis_INTER_sql()
            ElseIf islem = 2 Then
                Label1.Text = "" & kasa & " Ciro Raporu"
                DataSet1 = dll.dataset1
            End If
        End If
        DOSYA1 = Nothing
        lbl_SonOkuma.Text = Now.ToLongTimeString
        GridView1.BestFitColumns()
    End Sub
    Private Sub ciro_inter_sifirla()
        fis = 0
        iade = 0
        iadetutar = 0
        fatura = 0
        iptal = 0
        aratoplam = 0
        faturakdv = 0
        indirim = 0
        nakit = 0
        kredi1 = 0
        kredi2 = 0
        kredi3 = 0
        kredi4 = 0
        kredi5 = 0
        kredi = 0
        belgeiptal = 0
        belgeiptaltutar = 0
        ortalamaciro = 0
    End Sub
    Public Sub ciro_INTER(ByVal dosya As String, ByVal kasano As Integer, ByVal kasa As String)
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String = ""
        Dim satir As String
        Dim satis
        Dim sFisTipi As Integer = 1
        'Dim fis
        'Dim iade As Integer = 0
        'Dim iadetutar As Decimal = 0
        'Dim fatura
        'Dim iptal
        'Dim aratoplam As Decimal = 0
        'Dim faturakdv As Decimal = 0
        'Dim indirim As Decimal = 0
        'Dim nakit As Decimal = 0
        'Dim kredi1 As Decimal = 0
        'Dim kredi2 As Decimal = 0
        'Dim kredi3 As Decimal = 0
        'Dim kredi4 As Decimal = 0
        'Dim kredi5 As Decimal = 0
        'Dim kredi As Decimal = 0
        'Dim belgeiptal As Integer = 0
        'Dim belgeiptaltutar As Decimal = 0
        'Dim ortalamaciro As Decimal = 0
        Dim sOdemeKodu
        'Dim sayi As Integer
        'sayi = 0
        'fis = 0
        'iade = 0
        'fatura = 0
        'iptal = 0
        'faturakdv = 0
        'belgeiptal = 0
        'belgeiptaltutar = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(8, 2))
            If satis = 1 Then
                fis += 1
                sFisTipi = 1
            ElseIf satis = 2 Then
                fatura += 1
                sFisTipi = 2
            ElseIf satis = 5 Then
                iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 6 Then
                indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 7 Then
                faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 8 Then
                aratoplam = aratoplam + CType(Trim(satir.Substring(30, 10)), Decimal)
                If sFisTipi = 24 Then
                    'iadetutar += aratoplam
                    iadetutar = iadetutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
            ElseIf satis = 9 Then
                nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 10 Then
                kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
                sOdemeKodu = Trim(satir.Substring(25, 2))
                If sOdemeKodu = 1 Then
                    kredi1 = kredi1 + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf sOdemeKodu = 2 Then
                    kredi2 = kredi2 + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf sOdemeKodu = 3 Then
                    kredi3 = kredi3 + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf sOdemeKodu = 4 Then
                    kredi4 = kredi4 + CType(Trim(satir.Substring(30, 10)), Decimal)
                Else
                    kredi5 = kredi5 + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
                'kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 24 Then
                iade += 1
                sFisTipi = 24
            ElseIf satis = 21 Then
                iade += 1
            ElseIf satis = 30 Then
                belgeiptal += 1
                belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
            End If
        Loop
        sk.Close()
        If kasa = "inter" Then
            dosya = dosya.Replace("HR", "IP")
        ElseIf kasa = "escort" Then
            dosya = dosya.Replace("HR", "HI")
        End If
        dosya = dosya.Replace("YDK", "")
        z = dosya
        Dim dosya2 As New FileInfo(z)
        If dosya2.Exists Then
            dosya2.CopyTo("" & z & "YDK", True)
            z = z & "YDK"
            Dim ips As StreamReader = File.OpenText(z)
            Do While ips.Peek() > -1
                satir = ips.ReadLine
                satis = Trim(satir.Substring(8, 2))
                If satis = 1 Then
                    If kasa = "escort" Then
                        belgeiptal += 1
                        'belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    End If
                    'fis += 1
                ElseIf satis = 2 Then
                    If kasa = "escort" Then
                        belgeiptal += 1
                        'belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    End If
                ElseIf satis = 5 Then
                    'iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 6 Then
                    'indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 7 Then
                    'faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 8 Then
                    If kasa = "escort" Then
                        'belgeiptal += 1
                        belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    End If
                    'aratoplam = aratoplam + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 9 Then
                    'nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 10 Then
                    'kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 30 Then
                    belgeiptal += 1
                    belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
            Loop
            ips.Close()
        Else
        End If
        If kasa = "inter" Then
            dosya = dosya.Replace("HI", "HD")
        ElseIf kasa = "escort" Then
            dosya = dosya.Replace("HI", "HD")
        End If
        dosya = dosya.Replace("YDK", "")
        z = dosya
        Dim dosya3 As New FileInfo(z)
        If dosya3.Exists Then
            dosya3.CopyTo("" & z & "YDK", True)
            z = z & "YDK"
            Dim ipa As StreamReader = File.OpenText(z)
            Do While ipa.Peek() > -1
                satir = ipa.ReadLine
                satis = Trim(satir.Substring(8, 2))
                If satis = 1 Then
                    'fis += 1
                ElseIf satis = 2 Then
                    '
                ElseIf satis = 5 Then
                    'iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 6 Then
                    'indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 7 Then
                    'faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 8 Then
                    'MsgBox(satir)
                    'If kasa = "escort" Then
                    '    'MsgBox(CType(Trim(satir.Substring(30, 10)), Decimal))
                    iadetutar = iadetutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    'End If
                ElseIf satis = 9 Then
                    'nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 21 Then
                    iade = iade + 1
                ElseIf satis = 30 Then
                    'belgeiptal += 1
                    'belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
            Loop
            ipa.Close()
        Else
        End If
        'Try
        '    ortalamaciro = aratoplam / ((CType(fis, Integer) + CType(fatura, Integer)) - CType(belgeiptal, Integer))
        'Catch ex As Exception
        '    ortalamaciro = 0
        'End Try
        'If kasa = "inter" Then
        '    Dim dr As DataRow = dataset1.Tables(0).NewRow
        '    dr(0) = kasano
        '    dr(1) = fis
        '    dr(2) = fatura
        '    dr(3) = belgeiptal
        '    dr(4) = belgeiptaltutar
        '    dr(5) = aratoplam
        '    dr(6) = indirim
        '    dr(7) = ortalamaciro
        '    dr(8) = nakit
        '    dr(9) = kredi1
        '    dr(10) = kredi2
        '    dr(11) = iade
        '    dr(12) = kredi3
        '    dr(13) = kredi4
        '    dr(14) = kredi
        '    dr(15) = iadetutar
        '    dataset1.Tables(0).Rows.Add(dr)
        'ElseIf kasa = "escort" Then
        '    Dim dr As DataRow = dataset1.Tables(0).NewRow
        '    dr(0) = kasano
        '    dr(1) = fis
        '    dr(2) = fatura
        '    dr(3) = belgeiptal
        '    dr(4) = belgeiptaltutar / 100
        '    dr(5) = aratoplam / 100
        '    dr(6) = indirim / 100
        '    dr(7) = ortalamaciro / 100
        '    dr(8) = nakit / 100
        '    dr(9) = kredi1 / 100
        '    dr(10) = kredi2 / 100
        '    dr(11) = iade
        '    dr(12) = kredi3 / 100
        '    dr(13) = kredi4 / 100
        '    dr(14) = kredi / 100
        '    dr(15) = iadetutar / 100
        '    dataset1.Tables(0).Rows.Add(dr)
        'End If
        sk.Close()
        sr.Close()
    End Sub
    Private Sub ciro_inter_ekle(ByVal kasano As Integer)
        Try
            ortalamaciro = aratoplam / ((CType(fis, Integer) + CType(fatura, Integer)) - CType(belgeiptal, Integer))
        Catch ex As Exception
            ortalamaciro = 0
        End Try
        aratoplam = aratoplam - iadetutar
        If kasa = "inter" Then
            Dim dr As DataRow = DataSet1.Tables(0).NewRow
            dr(0) = kasano
            dr(1) = fis
            dr(2) = fatura
            dr(3) = belgeiptal
            dr(4) = belgeiptaltutar
            dr(5) = aratoplam - iadetutar
            dr(6) = indirim
            dr(7) = ortalamaciro
            dr(8) = nakit
            dr(9) = kredi1
            dr(10) = kredi2
            dr(11) = iade
            dr(12) = kredi3
            dr(13) = kredi4
            dr(14) = kredi
            dr(15) = iadetutar
            DataSet1.Tables(0).Rows.Add(dr)
        ElseIf kasa = "escort" Then
            Dim dr As DataRow = DataSet1.Tables(0).NewRow
            dr(0) = kasano
            dr(1) = fis
            dr(2) = fatura
            dr(3) = belgeiptal
            dr(4) = belgeiptaltutar / 100
            dr(5) = (aratoplam / 100) - (iadetutar / 100)
            dr(6) = indirim / 100
            dr(7) = ortalamaciro / 100
            dr(8) = nakit / 100
            dr(9) = kredi1 / 100
            dr(10) = kredi2 / 100
            dr(11) = iade
            dr(12) = kredi3 / 100
            dr(13) = kredi4 / 100
            dr(14) = kredi / 100
            dr(15) = iadetutar / 100
            DataSet1.Tables(0).Rows.Add(dr)
        End If
    End Sub
    Private Sub frmposciro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub VGridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        printlink1.CreateDocument(ps1)
        ps1.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If MenuItem2.Checked = False Then
            Me.WindowState = Windows.Forms.FormWindowState.Maximized
            MenuItem2.Checked = True
        ElseIf MenuItem2.Checked = True Then
            Me.WindowState = Windows.Forms.FormWindowState.Normal
            MenuItem2.Checked = False
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ara()
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    End Sub
End Class
