Imports Microsoft.Win32
Public Class frm_fatura_kdv_ozet
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
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lNetTutar2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lNetTutar1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sFisTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_nGirisCikis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sDepo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sHareketTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fatura_kdv_ozet))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_resmi1 = New DevExpress.XtraEditors.CheckEdit
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sHareketTipi = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteFisTarihi2 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteFisTarihi1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lFisNo2 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lFisNo1 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sDepo = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.sec_nGirisCikis = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sFisTipi = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lNetTutar2 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lNetTutar1 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.label3 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.fieldKDV = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMATRAH = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldKDVTUTARI = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldIZAHAT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldACIKLAMA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nGirisCikis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lNetTutar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lNetTutar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 150)
        Me.PanelControl1.TabIndex = 3
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Location = New System.Drawing.Point(582, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(240, 146)
        Me.lbl_istihbarat.TabIndex = 40
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_resmi1)
        Me.GroupControl1.Controls.Add(Me.sec_resmi)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.sec_sHareketTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.sec_sDepo)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.sec_nGirisCikis)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sec_sFisTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_lNetTutar2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_lNetTutar1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(486, 146)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_resmi1
        '
        Me.sec_resmi1.Location = New System.Drawing.Point(429, 96)
        Me.sec_resmi1.Name = "sec_resmi1"
        Me.sec_resmi1.Properties.Caption = "R1"
        Me.sec_resmi1.Size = New System.Drawing.Size(48, 19)
        Me.sec_resmi1.TabIndex = 55
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(397, 96)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 54
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Location = New System.Drawing.Point(172, 98)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(41, 20)
        Me.LabelControl15.TabIndex = 43
        Me.LabelControl15.Text = "Hareket"
        '
        'sec_sHareketTipi
        '
        Me.sec_sHareketTipi.EnterMoveNextControl = True
        Me.sec_sHareketTipi.Location = New System.Drawing.Point(215, 99)
        Me.sec_sHareketTipi.Name = "sec_sHareketTipi"
        Me.sec_sHareketTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sHareketTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sHareketTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sHareketTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sHareketTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sHareketTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sHareketTipi.Properties.DisplayMember = "sHareketTipi"
        Me.sec_sHareketTipi.Properties.NullText = "[Hareket]"
        Me.sec_sHareketTipi.Properties.ValueMember = "sHareketTipi"
        Me.sec_sHareketTipi.Size = New System.Drawing.Size(100, 20)
        Me.sec_sHareketTipi.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(317, 42)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl9.TabIndex = 41
        Me.LabelControl9.Text = "Arasýndaki"
        '
        'txt_dteFisTarihi2
        '
        Me.txt_dteFisTarihi2.EditValue = Nothing
        Me.txt_dteFisTarihi2.EnterMoveNextControl = True
        Me.txt_dteFisTarihi2.Location = New System.Drawing.Point(215, 42)
        Me.txt_dteFisTarihi2.Name = "txt_dteFisTarihi2"
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteFisTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteFisTarihi2.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteFisTarihi2.TabIndex = 3
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(177, 42)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl11.TabIndex = 40
        Me.LabelControl11.Text = "ve"
        '
        'txt_dteFisTarihi1
        '
        Me.txt_dteFisTarihi1.EditValue = Nothing
        Me.txt_dteFisTarihi1.EnterMoveNextControl = True
        Me.txt_dteFisTarihi1.Location = New System.Drawing.Point(71, 42)
        Me.txt_dteFisTarihi1.Name = "txt_dteFisTarihi1"
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteFisTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteFisTarihi1.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteFisTarihi1.TabIndex = 2
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Location = New System.Drawing.Point(0, 42)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl13.TabIndex = 39
        Me.LabelControl13.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(317, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Arasýndaki"
        '
        'txt_lFisNo2
        '
        Me.txt_lFisNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lFisNo2.EnterMoveNextControl = True
        Me.txt_lFisNo2.Location = New System.Drawing.Point(215, 61)
        Me.txt_lFisNo2.Name = "txt_lFisNo2"
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lFisNo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo2.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(177, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "ve"
        '
        'txt_lFisNo1
        '
        Me.txt_lFisNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_lFisNo1.EnterMoveNextControl = True
        Me.txt_lFisNo1.Location = New System.Drawing.Point(71, 61)
        Me.txt_lFisNo1.Name = "txt_lFisNo1"
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lFisNo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo1.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(0, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "FiþNo:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.Location = New System.Drawing.Point(317, 101)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl14.TabIndex = 31
        Me.LabelControl14.Text = "Eþittir"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(0, 99)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "Depo"
        '
        'sec_sDepo
        '
        Me.sec_sDepo.EnterMoveNextControl = True
        Me.sec_sDepo.Location = New System.Drawing.Point(71, 99)
        Me.sec_sDepo.Name = "sec_sDepo"
        Me.sec_sDepo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sDepo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sDepo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sDepo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sDepo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sDepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDepo.Properties.DisplayMember = "sDepo"
        Me.sec_sDepo.Properties.NullText = "[Depolar]"
        Me.sec_sDepo.Properties.ValueMember = "sDepo"
        Me.sec_sDepo.Size = New System.Drawing.Size(100, 20)
        Me.sec_sDepo.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(174, 23)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 20)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Ýþlem:"
        '
        'sec_nGirisCikis
        '
        Me.sec_nGirisCikis.Enabled = False
        Me.sec_nGirisCikis.EnterMoveNextControl = True
        Me.sec_nGirisCikis.Location = New System.Drawing.Point(215, 23)
        Me.sec_nGirisCikis.Name = "sec_nGirisCikis"
        Me.sec_nGirisCikis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_nGirisCikis.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_nGirisCikis.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_nGirisCikis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_nGirisCikis.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_nGirisCikis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nGirisCikis.Properties.DisplayMember = "sAciklama"
        Me.sec_nGirisCikis.Properties.NullText = "[Islem]"
        Me.sec_nGirisCikis.Properties.ValueMember = "nGirisCikis"
        Me.sec_nGirisCikis.Size = New System.Drawing.Size(100, 20)
        Me.sec_nGirisCikis.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(0, 23)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "FiþTipi:"
        '
        'sec_sFisTipi
        '
        Me.sec_sFisTipi.Enabled = False
        Me.sec_sFisTipi.EnterMoveNextControl = True
        Me.sec_sFisTipi.Location = New System.Drawing.Point(71, 23)
        Me.sec_sFisTipi.Name = "sec_sFisTipi"
        Me.sec_sFisTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFisTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFisTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sFisTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sFisTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sFisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFisTipi.Properties.DisplayMember = "sAciklama"
        Me.sec_sFisTipi.Properties.NullText = "[FiþTipleri]"
        Me.sec_sFisTipi.Properties.ValueMember = "sFisTipi"
        Me.sec_sFisTipi.Size = New System.Drawing.Size(100, 20)
        Me.sec_sFisTipi.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(0, 118)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Firma:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(317, 79)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasýndaki"
        '
        'txt_lNetTutar2
        '
        Me.txt_lNetTutar2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lNetTutar2.EnterMoveNextControl = True
        Me.txt_lNetTutar2.Location = New System.Drawing.Point(215, 80)
        Me.txt_lNetTutar2.Name = "txt_lNetTutar2"
        Me.txt_lNetTutar2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lNetTutar2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lNetTutar2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lNetTutar2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lNetTutar2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lNetTutar2.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(177, 80)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lNetTutar1
        '
        Me.txt_lNetTutar1.EditValue = New Decimal(New Integer() {999999999, 0, 0, -2147483648})
        Me.txt_lNetTutar1.EnterMoveNextControl = True
        Me.txt_lNetTutar1.Location = New System.Drawing.Point(71, 80)
        Me.txt_lNetTutar1.Name = "txt_lNetTutar1"
        Me.txt_lNetTutar1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lNetTutar1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lNetTutar1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lNetTutar1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lNetTutar1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lNetTutar1.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(0, 80)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Tutar:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(215, 118)
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
        Me.SimpleButton3.Location = New System.Drawing.Point(402, 118)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 13
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(317, 118)
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
        Me.txt_ara.Location = New System.Drawing.Point(71, 118)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_ara.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(146, 20)
        Me.txt_ara.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 146)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.label3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'label3
        '
        Me.label3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label3.Location = New System.Drawing.Point(2, 33)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(7, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 150)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 231)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.GridControl1.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.Silver
        Me.GridControl1.Appearance.FieldValueTotal.BackColor2 = System.Drawing.Color.Silver
        Me.GridControl1.Appearance.FieldValueTotal.Options.UseBackColor = True
        Me.GridControl1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.Gray
        Me.GridControl1.Appearance.GrandTotalCell.BackColor2 = System.Drawing.Color.Gray
        Me.GridControl1.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldKDV, Me.fieldMATRAH, Me.fieldKDVTUTARI, Me.fieldIZAHAT, Me.fieldACIKLAMA})
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.GridControl1.OptionsDataField.AreaIndex = 1
        Me.GridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.GridControl1.OptionsView.ShowColumnHeaders = False
        Me.GridControl1.OptionsView.ShowDataHeaders = False
        Me.GridControl1.OptionsView.ShowFilterHeaders = False
        Me.GridControl1.OptionsView.ShowRowTotals = False
        Me.GridControl1.Size = New System.Drawing.Size(820, 227)
        Me.GridControl1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nKdvOrani"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lKdvMatrahi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKdv"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sIzahat"
        '
        'fieldKDV
        '
        Me.fieldKDV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldKDV.AreaIndex = 0
        Me.fieldKDV.Caption = "Kdv Oraný"
        Me.fieldKDV.EmptyCellText = "0"
        Me.fieldKDV.EmptyValueText = "0"
        Me.fieldKDV.FieldName = "nKdvOrani"
        Me.fieldKDV.GrandTotalText = "Toplamlar"
        Me.fieldKDV.Name = "fieldKDV"
        Me.fieldKDV.TotalCellFormat.FormatString = "#,0"
        Me.fieldKDV.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldMATRAH
        '
        Me.fieldMATRAH.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMATRAH.AreaIndex = 0
        Me.fieldMATRAH.Caption = "Matrah"
        Me.fieldMATRAH.CellFormat.FormatString = "#,0.00"
        Me.fieldMATRAH.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMATRAH.EmptyCellText = "0"
        Me.fieldMATRAH.EmptyValueText = "0"
        Me.fieldMATRAH.FieldName = "lKdvMatrahi"
        Me.fieldMATRAH.GrandTotalText = "Toplamlar"
        Me.fieldMATRAH.Name = "fieldMATRAH"
        Me.fieldMATRAH.TotalCellFormat.FormatString = "#,0.00"
        Me.fieldMATRAH.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldKDVTUTARI
        '
        Me.fieldKDVTUTARI.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldKDVTUTARI.AreaIndex = 1
        Me.fieldKDVTUTARI.Caption = "Kdv Tutarý"
        Me.fieldKDVTUTARI.CellFormat.FormatString = "#,0.00"
        Me.fieldKDVTUTARI.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldKDVTUTARI.EmptyCellText = "0"
        Me.fieldKDVTUTARI.EmptyValueText = "0"
        Me.fieldKDVTUTARI.FieldName = "lKdv"
        Me.fieldKDVTUTARI.GrandTotalText = "Toplamlar"
        Me.fieldKDVTUTARI.Name = "fieldKDVTUTARI"
        Me.fieldKDVTUTARI.TotalCellFormat.FormatString = "#,0.00"
        Me.fieldKDVTUTARI.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldIZAHAT
        '
        Me.fieldIZAHAT.AreaIndex = 0
        Me.fieldIZAHAT.Caption = "Belge Tipi"
        Me.fieldIZAHAT.FieldName = "sIzahat"
        Me.fieldIZAHAT.GrandTotalText = "Toplamlar"
        Me.fieldIZAHAT.Name = "fieldIZAHAT"
        Me.fieldIZAHAT.Visible = False
        '
        'fieldACIKLAMA
        '
        Me.fieldACIKLAMA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldACIKLAMA.AreaIndex = 0
        Me.fieldACIKLAMA.Caption = "Ýzahat"
        Me.fieldACIKLAMA.FieldName = "sIzahat"
        Me.fieldACIKLAMA.GrandTotalText = "Toplamlar"
        Me.fieldACIKLAMA.Name = "fieldACIKLAMA"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem23, Me.MenuItem18, Me.MenuItem13, Me.MenuItem15, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem22, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem21.Text = "Ara"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem23.Text = "Ekle"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Düzelt"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "Faturalaþtýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 6
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 7
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Firma Hareketleri"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem22.Text = "Firma Bakiyesi"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 9
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 10
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 11
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 12
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 13
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 14
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 15
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 16
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 17
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 18
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 19
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 20
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 21
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Kdv Raporu", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_fatura_kdv_ozet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_fatura_kdv_ozet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KDV Dökümleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nGirisCikis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lNetTutar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lNetTutar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public connection_resmi
    Public connection_orj
    Public connection_resmi1
    Public musterino
    Public kullanici
    Public nFirmaID As Int64 = 0
    Public islemstatus As Boolean = False
    Dim ds_tbFisTipi As DataSet
    Dim ds_tbGirisCikis As DataSet
    Dim ds_tbDepo As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_satir_firma As DataSet
    Public sFisTipi As String = ""
    Public nGirisCikis As Int64 = 1
    Dim status As Boolean = False
    Public kapla As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridControl1.FieldsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        'GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'GridView1.OptionsView.ShowGroupPanel = True
        'GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        'GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += txt_dteFisTarihi1.EditValue & " ve " & txt_dteFisTarihi2.EditValue & " Tarihleri Arasýndaki KdvÖzeti" & vbCrLf
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        'GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        'MsgBox(Sorgu_sDil("Görünüm Kaydedildi",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
    End Sub
    Private Sub gorunum_yukle()
        'GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        'Try
        '    
        'Catch ex As Exception
        '    
        'End Try
        'Try
        '    If nFontSize > 0 Then
        '        Dim sayi As Single = nFontSize
        '        GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        '        GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        '        GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        '        sayi = Nothing
        '    End If
        'Catch ex As Exception
        'End Try
        For Each clmn As DevExpress.XtraPivotGrid.PivotGridField In GridControl1.Fields
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
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
    Private Sub dataload_tbFisTipi()
        ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     'S+A' as sFisTipi ,'Satislar+Alislar' as sAciklama UNION ALL SELECT     'S' as sFisTipi ,'Satislar' as sAciklama UNION ALL SELECT     'A' as sFisTipi ,'Alislar' as sAciklama UNION ALL Select sFisTipi,sAciklama FROM         tbFisTipi Where sFisTipi IN ('DG','DC','FS','FA','HA','HS','IA','IS') UNION ALL SELECT     'P' as sFisTipi ,'Perakende' as sAciklama"))
        sec_sFisTipi.Properties.DataSource = ds_tbFisTipi.Tables(0)
        'sec_sFisTipi.EditValue = sFisTipi
        sec_sFisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbGirisCikis(ByVal nGirisCikis As Int64)
        If kapla = False Then
            ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis = '" & nGirisCikis & "'"))
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.ItemIndex = 0
        ElseIf kapla = True Then
            If sec_sFisTipi.EditValue = "FS " Or sec_sFisTipi.EditValue = "HS " Or sec_sFisTipi.EditValue = "DC " Or sec_sFisTipi.EditValue = "IS " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (3,4)"))
                sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
                sec_nGirisCikis.EditValue = nGirisCikis
                sec_nGirisCikis.ItemIndex = 0
            ElseIf sec_sFisTipi.EditValue = "FA " Or sec_sFisTipi.EditValue = "HA " Or sec_sFisTipi.EditValue = "DG " Or sec_sFisTipi.EditValue = "IA " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (1,2)"))
                sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
                sec_nGirisCikis.EditValue = nGirisCikis
                sec_nGirisCikis.ItemIndex = 0
            ElseIf sec_sFisTipi.EditValue = "S" Or sec_sFisTipi.EditValue = "A" Or sec_sFisTipi.EditValue = "S+A" Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (1,2,3,4)"))
                sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
                sec_nGirisCikis.ItemIndex = 0
            End If
        End If
    End Sub
    Private Sub dataload_tbdepo()
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama FROM         tbDepo"))
        sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        'sec_sDepo.ItemIndex = 1
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String) As DataSet
        Dim kriter As String = ""
        If sFisTipi = "A" Then
            kriter += " AND (tbStokFisiDetayi.sFisTipi = 'FA')"
        ElseIf sFisTipi = "S" Then
            kriter += " AND (tbStokFisiDetayi.sFisTipi = 'FS')"
        ElseIf sFisTipi = "S+A" Then
            kriter += " AND (tbStokFisiDetayi.sFisTipi IN ('FS','FA','K','P','PF'))"
        ElseIf sFisTipi = "P" Then
            kriter += " AND (tbStokFisiDetayi.sFisTipi IN ('P','K','PF'))"
        Else
            kriter += " AND (tbStokFisiDetayi.sFisTipi = '" & sFisTipi & "')"
            If nGirisCikis > 0 Then
                kriter += " and tbStokFisiMaster.nGirisCikis =" & nGirisCikis & " "
            End If
        End If
        kriter += " AND tbStokFisiDetayi.dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        'kriter += " and tbStokFisiMaster.lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'"
        'kriter += " and tbStokFisiMaster.lNetTutar between '" & lNetTutar1 & "' and '" & lNetTutar2 & "'"
        If Trim(sDepo) <> "" Then
            kriter += " And tbStokFisiDetayi.sDepo = '" & sDepo & "' "
        End If
        If Trim(sHareketTipi) <> "" Then
            kriter += " And tbStokFisiMaster.sHareketTipi = '" & sHareketTipi & "' "
        End If
        If Trim(sFisTipi) = "PF" Then
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        Else
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 5 tbStokFisiDetayi.nKdvOrani, ISNULL(ROUND(SUM(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari), 2), 0) AS lKdvMatrahi, SUM(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * tbStokFisiDetayi.nKdvOrani / 100, 2)) AS lKdv, 'Satis+Iadeler' AS sIzahat FROM tbStokFisiDetayi LEFT OUTER  JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID  WHERE (tbStokFisiDetayi.dteFisTarihi Between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "')" & kriter & " GROUP BY tbStokFisiDetayi.nKdvOrani UNION ALL SELECT TOP 5 tbStokFisiDetayi.nKdvOrani, ISNULL(ROUND(SUM(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari), 2), 0) AS lKdvMatrahi, SUM(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * tbStokFisiDetayi.nKdvOrani / 100, 2)) AS lKdv, 'Alis+Iadeler' AS sIzahat FROM tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.sFisTipi IN ('FA', 'HA', 'DG')) " & kriter & " GROUP BY tbStokFisiDetayi.nKdvOrani")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 5 tbStokFisiDetayi.nKdvOrani, ISNULL(ROUND(SUM(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari), 2), 0) AS lKdvMatrahi, ISNULL(ROUND(SUM(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * tbStokFisiDetayi.nKdvOrani / 100, 2), 0) AS lKdv, 'Satis+Iadeler' AS sIzahat FROM tbStokFisiDetayi LEFT OUTER  JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID  WHERE (tbStokFisiDetayi.dteFisTarihi Between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "')" & kriter & " GROUP BY tbStokFisiDetayi.nKdvOrani UNION ALL SELECT TOP 5 tbStokFisiDetayi.nKdvOrani, ISNULL(ROUND(SUM(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari), 2), 0) AS lKdvMatrahi, ISNULL(ROUND(SUM(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * tbStokFisiDetayi.nKdvOrani / 100, 2), 0) AS lKdv, 'Alis+Iadeler' AS sIzahat FROM tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.sFisTipi IN ('FA', 'HA', 'DG')) " & kriter & " GROUP BY tbStokFisiDetayi.nKdvOrani")
        'If Trim(sFisTipi) = "PF" Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot, tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5 AS KdvTutari, tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5 AS KdvMatrahi, tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 AS EkMaliyet, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli, CAST(0 AS MONEY) AS ISKONTO, tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI, CAST(0 AS MONEY) AS EkOran, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari3, tbMusteri.nMusteriID, tbMusteri.lKodu AS sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAciklama FROM tbStokFisiMaster INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        'Else
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        'End If
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
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
        Return DS
    End Function
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String)
        status = True
        DataSet1 = stok(ara, konum, ara_kriter, sFisTipi, nGirisCikis, dteFisTarihi1, dteFisTarihi2, lFisNo1, lFisNo2, lNetTutar1, lNetTutar2, sDepo, sHareketTipi)
        'Dim dr1 As DataRow
        'For Each dr1 In DataSet1.Tables(0).Rows
        '    Try
        '        dr1("ISKONTO") = (dr1("lIskontoTutari")) / dr1("lMalBedeli")
        '        If CType(dr1("Ekmaliyet"), Decimal) <> 0 Then
        '            dr1("EkOran") = CType(dr1("Ekmaliyet"), Decimal) / CType(dr1("lMalBedeli") - dr1("lMalIskontoTutari") - dr1("lDipIskontoTutari"), Decimal)
        '        End If
        '    Catch ex As Exception
        '    End Try
        'Next
        'dr1 = Nothing
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.CollapseAllGroups()
        satir_firma_info()
        status = True
        'If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
        '    colsFaturalasti.Visible = True
        'Else
        '    colsFaturalasti.Visible = False
        'End If
    End Sub
    Private Sub analiz_Firma_karti()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    If Trim(dr("sFisTipi")) = "PF" Then
        '        Dim frm As New frm_musteri_karti
        '        frm.firmano = firmano
        '        frm.donemno = donemno
        '        frm.connection = connection
        '        frm.musterino = dr("sKodu")
        '        frm.musteriID = dr("nMusteriID")
        '        frm.kullanici = kullanici
        '        If yetki_kontrol(kullanici, frm.Name) = True Then
        '            frm.ShowDialog()
        '        End If
        '        frm.Close()
        '        frm.Dispose()
        '        frm = Nothing
        '    Else
        '        Dim frm As New frm_firma_kart
        '        frm.firmano = firmano
        '        frm.donemno = donemno
        '        frm.connection = connection
        '        frm.sKodu = dr("sKodu")
        '        frm.nFirmaID = dr("nFirmaID")
        '        frm.kullanici = kullanici
        '        If yetki_kontrol(kullanici, frm.Name) = True Then
        '            frm.ShowDialog()
        '        End If
        '        frm.Close()
        '        frm.Dispose()
        '        frm = Nothing
        '    End If
        '    dr = Nothing
        'End If
    End Sub
    Private Sub Fis_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        Dim frm_firma As New frm_firma_liste
        frm_firma.firmano = firmano
        frm_firma.donemno = donemno
        frm_firma.connection = connection
        frm_firma.islemstatus = True
        frm_firma.kullanici = kullanici
        If frm_firma.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm_firma.GridView1.GetDataRow(frm_firma.GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nStokFisiID = ""
            frm.nFirmaID = dr1("nFirmaID")
            frm.sFisTipi = sFisTipi
            If sFisTipi = "HS " Or sFisTipi = "HA " Then
                frm.bHizmetFaturasimi = True
            End If
            frm.nGirisCikis = nGirisCikis
            frm.dteFisTarihi = Today
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            ara()
        End If
    End Sub
    Private Sub fis_duzelt()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_fatura
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.lFisNo = dr("lFisNo")
        '    frm.dteFisTarihi = dr("dteFisTarihi")
        '    frm.sFisTipi = dr("sFisTipi")
        '    frm.nFirmaID = dr("nFirmaID")
        '    frm.nGirisCikis = dr("nGirisCikis")
        '    frm.nStokFisiID = dr("nStokFisiID")
        '    frm.kullanici = kullanici
        '    Dim satir = GridView1.FocusedRowHandle
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm = Nothing
        '    dr = Nothing
        '    ara()
        '    GridView1.FocusedRowHandle = satir
        '    satir = Nothing
        'End If
    End Sub
    Private Sub analiz_cari_hareket()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_hareketler_ozet
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("sKodu")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        '    dr = Nothing
        'End If
    End Sub
    Private Sub analiz_iletisim()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_firma_iletisim
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("nFirmaID")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        '    dr = Nothing
        'End If
    End Sub
    Private Sub analiz_cari_bakiye()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_Firma_bakiye
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.sKodu = dr("sKodu")
        '    frm.txt_musteriNo.EditValue = dr("sKodu")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        '    dr = Nothing
        'End If
    End Sub
    Private Sub satir_firma_info()
        'If GridView1.RowCount > 0 Then
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
        '    Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
        '    label3.Text = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
        '    label3.Refresh()
        '    dr1 = Nothing
        'End If
    End Sub
    Private Sub analiz_stok_karti()
        'If GridView1.RowCount > 0 Then
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_kart
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.nStokID = dr("nStokId")
        '    frm.sKodu = dr("sStokKodu")
        '    frm.sModel = dr("sModel")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub stok_fiyat()
        'If GridView1.RowCount > 0 Then
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_fiyatlandir
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.nStokID = dr("nStokId")
        '    frm.sModel = dr("sModel")
        '    frm.sKodu = dr("sStokKodu")
        '    frm.sRenk = dr("sRenk")
        '    frm.sBeden = dr("sBeden")
        '    frm.txt_musteriNo.Text = dr("sModel")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_stok_hareket()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_hareketleri
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("sStokKodu")
        '    frm.nFirmaID = 0
        '    frm.sec_firma.Checked = False
        '    frm.sec_giris.Text = "Çýkýþlar"
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_envanter()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_envanter
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.stokno = dr("nStokId")
        '    frm.stokkodu = dr("sStokKodu")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub irsaliyelestir_kontrol()
        'Dim arr As Integer()
        'Dim i As Integer
        'Dim sayi As Integer = 0
        'Dim nFirmaID As String = ""
        'arr = GridView1.GetSelectedRows()
        'If arr Is Nothing Then
        'Else
        '    Array.Sort(arr)
        '    For Each i In arr
        '        s = i.ToString
        '        dr = GridView1.GetDataRow(s)
        '        If dr("sFaturalasti") <> True Then
        '            If dr("nFirmaID").tostring <> nFirmaID.ToString Then
        '                nFirmaID = dr("nFirmaID").tostring
        '                sayi += 1
        '            End If
        '        End If
        '    Next
        'End If
        'If sayi = 1 Then
        '    If sec_sFisTipi.EditValue = "IA" Or sec_sFisTipi.EditValue = "IS" Then
        '        MenuItem13.Visible = True
        '        MenuItem13.Enabled = True
        '    End If
        'Else
        '    MenuItem13.Visible = False
        '    MenuItem13.Enabled = False
        'End If
    End Sub
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
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
    Private Sub tbStokFisidetay_kaydet_faturala(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal sHareketTipi As String, ByVal nStokFisiID As String, ByVal enStokFisiID As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              bFaturayaDonustumu = 1, sHareketTipi = '" & sHareketTipi & "' WHERE     (nStokFisiID IN " & enStokFisiID & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', nStokFisiID = '" & nStokFisiID & "', lFisNo = " & lFisNo & ", sHareketTipi = '" & sHareketTipi & "' WHERE     (nStokFisiID IN " & enStokFisiID & ") ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (nHareketID IN (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      nStokFisiID IN " & enStokFisiID & "))")
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lNetTutar1.EditValue, txt_lNetTutar2.EditValue, sec_sDepo.EditValue, sec_sHareketTipi.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        If status = True Then
            Try
                satir_firma_info()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
        'irsaliyelestir_kontrol()
        'If GridView1.SelectedRowsCount > 1 Then
        '    Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        'Else
        '    Label2.Text = ""
        'End If
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    'lbl_istihbarat.Text = dr("sAciklama1").ToString & vbCrLf & dr("sAciklama2").ToString & vbCrLf & dr("sAciklama3").ToString & vbCrLf & dr("sAciklama4").ToString & vbCrLf & dr("sAciklama5").ToString
        '    dr = Nothing
        'End If
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        fis_duzelt()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            'If GridControl1.Fields > 0 Then
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            'Else
            '    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
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
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_cari_hareket()
    End Sub
    Private Sub frm_fatura_liste_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        connection_resmi1 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi1")
        dataload_tbFisTipi()
        dataload_tbGirisCikis(nGirisCikis)
        dataload_tbdepo()
        dataload_tbHareketTipi()
        sec_sFisTipi.EditValue = sFisTipi
        sec_nGirisCikis.EditValue = nGirisCikis.ToString
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        If kapla = True Then
            sec_sFisTipi.Enabled = True
            sec_nGirisCikis.Enabled = True
        End If
        ara()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteFisTarihi1.Focus()
        txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        fis_duzelt()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Fis_ekle(sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue)
    End Sub
    Private Sub sec_sFisTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFisTipi.EditValueChanged
        dataload_tbGirisCikis(nGirisCikis)
    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents fieldKDV As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMATRAH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKDVTUTARI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIZAHAT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldACIKLAMA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sec_resmi1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.Control = True And e.KeyCode = Keys.P Then
            gorunum_yazdir()
        End If
        If e.KeyCode = Keys.Escape Then
            Try
                Me.Close()
            Catch ex As Exception
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            ara()
            sec_resmi1.Checked = False
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub sec_resmi1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi1.CheckStateChanged
        If sec_resmi1.Checked = True Then
            connection = connection_resmi1
            ara()
            sec_resmi.Checked = False
        ElseIf sec_resmi1.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
End Class
