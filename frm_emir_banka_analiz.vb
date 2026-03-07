Imports DevExpress.XtraEditors
Public Class frm_emir_banka_analiz
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsOdemeSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTaksitTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKomisyonTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collServisBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPuanKdv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKesinti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBAKIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHangiUygulama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOzelIskontosu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKrediLimiti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents sec_gun As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_banka_analiz))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_gun = New DevExpress.XtraEditors.SpinEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnOzelIskontosu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKrediLimiti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBorc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlacak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsOdemeSekli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTaksitTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKomisyonTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collServisBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPuanKdv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKesinti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collBorcTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacakTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBAKIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHangiUygulama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataSet1 = New System.Data.DataSet()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_gun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_gun)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Location = New System.Drawing.Point(112, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(352, 75)
        Me.GroupControl1.TabIndex = 48
        Me.GroupControl1.Text = "Ara"
        '
        'Label3
        '
        Me.Label3.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-4, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 11)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Kesinti Gün Farký:"
        '
        'sec_gun
        '
        Me.sec_gun.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sec_gun.EnterMoveNextControl = True
        Me.sec_gun.Location = New System.Drawing.Point(64, 48)
        Me.sec_gun.Name = "sec_gun"
        Me.sec_gun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_gun.Size = New System.Drawing.Size(96, 20)
        Me.sec_gun.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(272, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(-4, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(161, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(181, 23)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(64, 23)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(182, 48)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(84, 20)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "&Listele"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 670)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(734, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 16
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(659, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 15
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.SplitterControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 88)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 582)
        Me.PanelControl3.TabIndex = 2
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.SplitContainerControl2)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 238)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(820, 342)
        Me.PanelControl5.TabIndex = 2
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl2.Panel1.Text = "SplitContainerControl2_Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl5)
        Me.SplitContainerControl2.Panel2.Text = "SplitContainerControl2_Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(816, 338)
        Me.SplitContainerControl2.SplitterPosition = 393
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.GridControl3)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(393, 338)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Banka Ýþlemleri"
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 15)
        Me.GridControl3.MainView = Me.GridView4
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(389, 321)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.Empty.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView4.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23})
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(816, 320, 208, 170)
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", Nothing, "Giren: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Nothing, "Çýkan: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", Me.GridColumn12, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Me.GridColumn4, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", Me.GridColumn5, "{0:#,0.00}")})
        Me.GridView4.IndicatorWidth = 35
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsDetail.ShowDetailTabs = False
        Me.GridView4.OptionsPrint.ExpandAllGroups = False
        Me.GridView4.OptionsSelection.MultiSelect = True
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Çýkan"
        Me.GridColumn4.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "lBorcTutar"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 72
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn5.Caption = "Giren"
        Me.GridColumn5.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "lAlacaktutar"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", "{0:#,0.00}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 62
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Firma Kayýt No"
        Me.GridColumn6.FieldName = "nFirmaID"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Firma Kodu"
        Me.GridColumn7.FieldName = "sKodu"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 58
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Açýklama"
        Me.GridColumn8.FieldName = "sAciklama"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 125
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Kodlama"
        Me.GridColumn9.FieldName = "KOD"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 36
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Bakiye"
        Me.GridColumn10.DisplayFormat.FormatString = "{0:#,#0.00(B);#,#0.00(A);-}"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "BAKIYE"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 92
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Firma Adý"
        Me.GridColumn11.FieldName = "FIRMAADI"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 83
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Tarih"
        Me.GridColumn12.FieldName = "dteIslemTarihi"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", "{0} Kayýt")})
        Me.GridColumn12.Width = 52
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Evrak No"
        Me.GridColumn13.FieldName = "sEvrakNo"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Width = 145
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Uygulama"
        Me.GridColumn14.FieldName = "sHangiUygulama"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Width = 35
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Hareket Tipi"
        Me.GridColumn15.FieldName = "sHareketTipi"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Width = 29
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Kullanýcý Adý"
        Me.GridColumn16.FieldName = "sKullaniciAdi"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Döviz Cinsi 1"
        Me.GridColumn17.FieldName = "sDovizCinsi1"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Döviz Miktarý 1"
        Me.GridColumn18.FieldName = "lDovizMiktari1"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Döviz Kuru 1"
        Me.GridColumn19.FieldName = "lDovizKuru1"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Döviz Cinsi 2"
        Me.GridColumn20.FieldName = "sDovizCinsi2"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Döviz Miktarý 2"
        Me.GridColumn21.FieldName = "lDovizMiktari2"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Döviz Kuru 2"
        Me.GridColumn22.FieldName = "lDovizKuru2"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Valör Tarihi"
        Me.GridColumn23.FieldName = "dteValorTarihi"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.GridControl4)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(417, 338)
        Me.GroupControl5.TabIndex = 0
        Me.GroupControl5.Text = "Banka Bakiyeleri"
        '
        'GridControl4
        '
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(2, 15)
        Me.GridControl4.MainView = Me.GridView6
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(413, 321)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6, Me.GridView5})
        '
        'GridView6
        '
        Me.GridView6.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.Empty.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridView6.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView6.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView6.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView6.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.colnOzelIskontosu, Me.collKrediLimiti, Me.colAdres, Me.colISTIHBARAT, Me.colSINIF1, Me.colSINIF2, Me.colSINIF3, Me.colSINIF4, Me.colSINIF5, Me.colsVergiDairesi, Me.colsVergiNo, Me.GridColumn27, Me.colBorc, Me.colAlacak, Me.colDBakiye, Me.GridColumn28})
        Me.GridView6.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView6.DetailHeight = 160
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.GridControl = Me.GridControl4
        Me.GridView6.GroupFormat = "{0}: {1} {2}"
        Me.GridView6.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView6.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Borc", Nothing, "Borç: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Alacak", Nothing, "Alacak: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBakiye", Nothing, "Bakiye: {0:#,0.00(B);#,0.00(A);#,0.00(-)}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.GridColumn25, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Borc", Me.colBorc, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Alacak", Me.colAlacak, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBakiye", Me.colDBakiye, "{0:#,0.00(B);#,0.00(A);#,0.00(-)}")})
        Me.GridView6.IndicatorWidth = 35
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsDetail.ShowDetailTabs = False
        Me.GridView6.OptionsPrint.ExpandAllGroups = False
        Me.GridView6.OptionsSelection.MultiSelect = True
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Kayýt No"
        Me.GridColumn24.FieldName = "nFirmaID"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Width = 77
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Firma Kodu"
        Me.GridColumn25.FieldName = "sKodu"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.GridColumn25.Width = 85
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Firma Adý"
        Me.GridColumn26.FieldName = "sAciklama"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 0
        Me.GridColumn26.Width = 260
        '
        'colnOzelIskontosu
        '
        Me.colnOzelIskontosu.Caption = "Ýskonto"
        Me.colnOzelIskontosu.FieldName = "nOzelIskontosu"
        Me.colnOzelIskontosu.Name = "colnOzelIskontosu"
        Me.colnOzelIskontosu.Width = 69
        '
        'collKrediLimiti
        '
        Me.collKrediLimiti.Caption = "Kredi Limiti"
        Me.collKrediLimiti.FieldName = "lKrediLimiti"
        Me.collKrediLimiti.Name = "collKrediLimiti"
        Me.collKrediLimiti.Width = 77
        '
        'colAdres
        '
        Me.colAdres.Caption = "Adres"
        Me.colAdres.FieldName = "Adres"
        Me.colAdres.Name = "colAdres"
        Me.colAdres.Width = 100
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "Ýstihbarat"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
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
        'colsVergiDairesi
        '
        Me.colsVergiDairesi.Caption = "Vergi Dairesi"
        Me.colsVergiDairesi.FieldName = "sVergiDairesi"
        Me.colsVergiDairesi.Name = "colsVergiDairesi"
        Me.colsVergiDairesi.Width = 80
        '
        'colsVergiNo
        '
        Me.colsVergiNo.Caption = "Vergi No"
        Me.colsVergiNo.FieldName = "sVergiNo"
        Me.colsVergiNo.Name = "colsVergiNo"
        Me.colsVergiNo.Width = 64
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Bakiye"
        Me.GridColumn27.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.GridColumn27.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn27.FieldName = "Bakiye"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bakiye", "{0:#,0.00(B);#,0.00(A);#,0.00(-)}")})
        Me.GridColumn27.Width = 81
        '
        'colBorc
        '
        Me.colBorc.Caption = "Borç"
        Me.colBorc.DisplayFormat.FormatString = "#,0.00"
        Me.colBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBorc.FieldName = "Borc"
        Me.colBorc.Name = "colBorc"
        Me.colBorc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Borc", "{0:#,0.00}")})
        Me.colBorc.Visible = True
        Me.colBorc.VisibleIndex = 1
        '
        'colAlacak
        '
        Me.colAlacak.Caption = "Alacak"
        Me.colAlacak.DisplayFormat.FormatString = "#,0.00"
        Me.colAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAlacak.FieldName = "Alacak"
        Me.colAlacak.Name = "colAlacak"
        Me.colAlacak.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Alacak", "{0:#,0.00}")})
        Me.colAlacak.Visible = True
        Me.colAlacak.VisibleIndex = 2
        '
        'colDBakiye
        '
        Me.colDBakiye.Caption = "Döviz Bakiye"
        Me.colDBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.colDBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDBakiye.FieldName = "DBakiye"
        Me.colDBakiye.Name = "colDBakiye"
        Me.colDBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DBakiye", "{0:#,0.00(B);#,0.00(A);#,0.00(-)}")})
        Me.colDBakiye.Visible = True
        Me.colDBakiye.VisibleIndex = 3
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "PB"
        Me.GridColumn28.FieldName = "sDovizCinsi1"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 4
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.GridControl4
        Me.GridView5.Name = "GridView5"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(2, 232)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(820, 6)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.SplitContainerControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 230)
        Me.PanelControl4.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel1.Text = "SplitContainerControl1_Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel2.Text = "SplitContainerControl1_Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(816, 226)
        Me.SplitContainerControl1.SplitterPosition = 394
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(394, 226)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Kesintiler"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 15)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(390, 209)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsOdemeSekli, Me.collTaksitTutari, Me.collKomisyonTutari, Me.collServisBedeli, Me.collPuan, Me.collPuanKdv, Me.collNetTutar, Me.collOdemeTutar, Me.colnFirmaID, Me.colsKodu, Me.colsAciklama, Me.colKesinti})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(370, 413, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", Me.colsOdemeSekli, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTaksitTutari", Nothing, "Tutar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKomisyonTutari", Nothing, "Komisyon: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lServisBedeli", Nothing, "Servis: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuan", Nothing, "Puan: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuanKdv", Nothing, "PuanKdv: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Net: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTaksitTutari", Me.collTaksitTutari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKomisyonTutari", Me.collKomisyonTutari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lServisBedeli", Me.collServisBedeli, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuan", Me.collPuan, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuanKdv", Me.collPuanKdv, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Me.collNetTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", Me.collOdemeTutar, "{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsOdemeSekli
        '
        Me.colsOdemeSekli.Caption = "Ödeme Þekli"
        Me.colsOdemeSekli.FieldName = "sOdemeSekli"
        Me.colsOdemeSekli.Name = "colsOdemeSekli"
        '
        'collTaksitTutari
        '
        Me.collTaksitTutari.Caption = "Taksit Tutarý"
        Me.collTaksitTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collTaksitTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTaksitTutari.FieldName = "lTaksitTutari"
        Me.collTaksitTutari.Name = "collTaksitTutari"
        Me.collTaksitTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTaksitTutari", "{0:#,0.00}")})
        Me.collTaksitTutari.Visible = True
        Me.collTaksitTutari.VisibleIndex = 1
        '
        'collKomisyonTutari
        '
        Me.collKomisyonTutari.Caption = "Komisyon Tutarý"
        Me.collKomisyonTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collKomisyonTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKomisyonTutari.FieldName = "lKomisyonTutari"
        Me.collKomisyonTutari.Name = "collKomisyonTutari"
        Me.collKomisyonTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKomisyonTutari", "{0:#,0.00}")})
        Me.collKomisyonTutari.Visible = True
        Me.collKomisyonTutari.VisibleIndex = 2
        '
        'collServisBedeli
        '
        Me.collServisBedeli.Caption = "Servis Bedeli"
        Me.collServisBedeli.DisplayFormat.FormatString = "#,0.00"
        Me.collServisBedeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collServisBedeli.FieldName = "lServisBedeli"
        Me.collServisBedeli.Name = "collServisBedeli"
        Me.collServisBedeli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lServisBedeli", "{0:#,0.00}")})
        Me.collServisBedeli.Visible = True
        Me.collServisBedeli.VisibleIndex = 3
        '
        'collPuan
        '
        Me.collPuan.Caption = "Puan"
        Me.collPuan.DisplayFormat.FormatString = "#,0.00"
        Me.collPuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPuan.FieldName = "lPuan"
        Me.collPuan.Name = "collPuan"
        Me.collPuan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuan", "{0:#,0.00}")})
        Me.collPuan.Visible = True
        Me.collPuan.VisibleIndex = 4
        '
        'collPuanKdv
        '
        Me.collPuanKdv.Caption = "Puan Kdv"
        Me.collPuanKdv.DisplayFormat.FormatString = "#,0.00"
        Me.collPuanKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPuanKdv.FieldName = "lPuanKdv"
        Me.collPuanKdv.Name = "collPuanKdv"
        Me.collPuanKdv.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuanKdv", "{0:#,0.00}")})
        Me.collPuanKdv.Visible = True
        Me.collPuanKdv.VisibleIndex = 5
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 7
        '
        'collOdemeTutar
        '
        Me.collOdemeTutar.Caption = "Ödeme Tutarý"
        Me.collOdemeTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00}")})
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "FirmaID"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 0
        '
        'colKesinti
        '
        Me.colKesinti.Caption = "Kesinti"
        Me.colKesinti.DisplayFormat.FormatString = "#,0.00"
        Me.colKesinti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKesinti.FieldName = "Kesinti"
        Me.colKesinti.Name = "colKesinti"
        Me.colKesinti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kesinti", "{0:#,0.00}")})
        Me.colKesinti.Visible = True
        Me.colKesinti.VisibleIndex = 6
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(416, 226)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "Hesaba Ýþlenenler"
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 15)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(412, 209)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView2})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collBorcTutar, Me.collAlacakTutar, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colKOD, Me.colBAKIYE, Me.colFIRMAADI, Me.coldteIslemTarihi, Me.colsEvrakNo, Me.colsHangiUygulama, Me.colsHareketTipi, Me.colsKullaniciAdi, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsDovizCinsi2, Me.collDovizMiktari2, Me.collDovizKuru2, Me.coldteValorTarihi})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(816, 320, 208, 170)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", Nothing, "Giren: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Nothing, "Çýkan: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", Me.coldteIslemTarihi, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Me.collBorcTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", Me.collAlacakTutar, "{0:#,0.00}")})
        Me.GridView3.IndicatorWidth = 35
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsPrint.ExpandAllGroups = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'collBorcTutar
        '
        Me.collBorcTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collBorcTutar.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.collBorcTutar.AppearanceCell.Options.UseFont = True
        Me.collBorcTutar.AppearanceCell.Options.UseForeColor = True
        Me.collBorcTutar.Caption = "Çýkan"
        Me.collBorcTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutar.FieldName = "lBorcTutar"
        Me.collBorcTutar.Name = "collBorcTutar"
        Me.collBorcTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00}")})
        Me.collBorcTutar.Visible = True
        Me.collBorcTutar.VisibleIndex = 2
        Me.collBorcTutar.Width = 70
        '
        'collAlacakTutar
        '
        Me.collAlacakTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collAlacakTutar.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collAlacakTutar.AppearanceCell.Options.UseFont = True
        Me.collAlacakTutar.AppearanceCell.Options.UseForeColor = True
        Me.collAlacakTutar.Caption = "Giren"
        Me.collAlacakTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutar.FieldName = "lAlacaktutar"
        Me.collAlacakTutar.Name = "collAlacakTutar"
        Me.collAlacakTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", "{0:#,0.00}")})
        Me.collAlacakTutar.Width = 62
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Firma Kayýt No"
        Me.GridColumn1.FieldName = "nFirmaID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Firma Kodu"
        Me.GridColumn2.FieldName = "sKodu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 58
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Açýklama"
        Me.GridColumn3.FieldName = "sAciklama"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 160
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kodlama"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.Width = 36
        '
        'colBAKIYE
        '
        Me.colBAKIYE.Caption = "Bakiye"
        Me.colBAKIYE.DisplayFormat.FormatString = "{0:#,#0.00(B);#,#0.00(A);-}"
        Me.colBAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBAKIYE.FieldName = "BAKIYE"
        Me.colBAKIYE.Name = "colBAKIYE"
        Me.colBAKIYE.Visible = True
        Me.colBAKIYE.VisibleIndex = 3
        Me.colBAKIYE.Width = 72
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Firma Adý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 0
        Me.colFIRMAADI.Width = 102
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "Tarih"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", "{0} Kayýt")})
        Me.coldteIslemTarihi.Width = 52
        '
        'colsEvrakNo
        '
        Me.colsEvrakNo.Caption = "Evrak No"
        Me.colsEvrakNo.FieldName = "sEvrakNo"
        Me.colsEvrakNo.Name = "colsEvrakNo"
        Me.colsEvrakNo.Width = 145
        '
        'colsHangiUygulama
        '
        Me.colsHangiUygulama.Caption = "Uygulama"
        Me.colsHangiUygulama.FieldName = "sHangiUygulama"
        Me.colsHangiUygulama.Name = "colsHangiUygulama"
        Me.colsHangiUygulama.Width = 35
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Width = 29
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanýcý Adý"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi 1"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarý 1"
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru 1"
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'colsDovizCinsi2
        '
        Me.colsDovizCinsi2.Caption = "Döviz Cinsi 2"
        Me.colsDovizCinsi2.FieldName = "sDovizCinsi2"
        Me.colsDovizCinsi2.Name = "colsDovizCinsi2"
        '
        'collDovizMiktari2
        '
        Me.collDovizMiktari2.Caption = "Döviz Miktarý 2"
        Me.collDovizMiktari2.FieldName = "lDovizMiktari2"
        Me.collDovizMiktari2.Name = "collDovizMiktari2"
        '
        'collDovizKuru2
        '
        Me.collDovizKuru2.Caption = "Döviz Kuru 2"
        Me.collDovizKuru2.FieldName = "lDovizKuru2"
        Me.collDovizKuru2.Name = "collDovizKuru2"
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        '
        'frm_emir_banka_analiz
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 718)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emir_banka_analiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banka Ýþlemleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_gun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Private Sub frm_emir_banka_analiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView4.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView5.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView6.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        DataSet1.Clear()
        Label2.Text = "Kesintiler Okunuyor..."
        Label2.Refresh()
        dataload_kesilecek(DateEdit1.EditValue, DateEdit2.EditValue, sec_gun.EditValue)
        Label2.Text = "Ýþlenenler Okunuyor..."
        Label2.Refresh()
        dataload_kesilen(DateEdit1.EditValue, DateEdit2.EditValue)
        Label2.Text = "Baþka Ýþlemleri Okunuyor..."
        Label2.Refresh()
        dataload_hareket(DateEdit1.EditValue, DateEdit2.EditValue)
        Label2.Text = "Banka Bakiyeleri Okunuyor..."
        Label2.Refresh()
        dataload_bakiye(DateEdit1.EditValue, DateEdit2.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub dataload_kesilecek(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal gun As Int64, Optional ByVal sinifno As Integer = 1)
        Dim kriter As String = ""
        'tarih1 = DateAdd(DateInterval.Day, -gun, tarih1)
        'tarih2 = DateAdd(DateInterval.Day, -1, tarih2)
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        GridControl1.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbAVKartTaksit.lTaksitTutari) AS lTaksitTutari, SUM(tbAVKartTaksit.lKomisyonTutari) AS lKomisyonTutari, SUM(tbAVKartTaksit.lServisBedeli) AS lServisBedeli, SUM(tbAVKartTaksit.lPuan) AS lPuan, SUM(tbAVKartTaksit.lPuanKdv) AS lPuanKdv, SUM(tbAVKartTaksit.lTaksitTutari) - SUM(tbAVKartTaksit.lKomisyonTutari) - SUM(tbAVKartTaksit.lServisBedeli) - SUM(tbAVKartTaksit.lPuan) - SUM(tbAVKartTaksit.lPuanKdv) AS lNetTutar, SUM(tbAVKartTaksit.lKomisyonTutari) + SUM(tbAVKartTaksit.lServisBedeli) + SUM(tbAVKartTaksit.lPuan) + SUM(tbAVKartTaksit.lPuanKdv) AS Kesinti, SUM(tbOdeme.lOdemeTutar) AS lOdemeTutar, tbFirma.sAciklama FROM tbAVKartTaksit INNER JOIN tbOdeme ON tbAVKartTaksit.nOdemeID = tbOdeme.nOdemeID INNER JOIN aEmirOdemeSekliFirma ON tbAVKartTaksit.sOdemeSekli = aEmirOdemeSekliFirma.sOdemeSekli LEFT OUTER JOIN tbFirma ON aEmirOdemeSekliFirma.nFirmaID = tbFirma.nFirmaID WHERE (tbAVKartTaksit.dteTaksitTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sAciklama ORDER BY tbFirma.sAciklama")).Tables(0)
        GridControl1.DataMember = Nothing
    End Sub
    Private Sub dataload_hareket(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, Optional ByVal sinifno As Integer = 1)
        GridControl3.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacaktutar, tbFirma.nFirmaID, tbFirma.sKodu, SUBSTRING(tbFirma.sKodu, 1, 3) AS KOD, replace(tbFirma.sAciklama, 'FÝNANSMAN GÝDERLERÝ\', '') AS FIRMAADI, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbFirma.sKodu LIKE '102%' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi ORDER BY tbFirma.sAciklama")).Tables(0)
        GridControl3.DataMember = Nothing
    End Sub
    Private Sub dataload_kesilen(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, Optional ByVal sinifno As Integer = 1)
        GridControl2.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacaktutar, tbFirma.nFirmaID, tbFirma.sKodu, SUBSTRING(tbFirma.sKodu, 1, 3) AS KOD, (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS BAKIYE, replace(tbFirma.sAciklama, 'FÝNANSMAN GÝDERLERÝ\', '') AS FIRMAADI, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbFirma.sKodu LIKE '800.00.09%' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi ORDER BY tbFirma.sAciklama")).Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub dataload_bakiye(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, Optional ByVal sinifno As Integer = 1)
        GridControl4.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT nFirmaID , sFirmaKodu , SUM(lBorcTutar) Borc , SUM(lAlacakTutar) Alacak , SUM(lBorcTutar - lAlacakTutar) AS DBakiye , sDovizCinsi1 FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu AS sFirmaKodu , tbFirma.sAciklama AS sFirmaAciklama , lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END , lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END , Bakiye = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lBorcTutar - lAlacakTutar END , sDovizCinsi1 FROM tbFirma , tbCariIslem , tbFirmaHareketi LEFT OUTER JOIN tbStokfisiOdemePlani ON tbStokfisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih1 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem) AS T GROUP BY sDovizCinsi1 , nFirmaID , sFirmaKodu) tbCariHareketi LEFT OUTER JOIN (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS Bakiye FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.sKodu LIKE '102%') tbCari ON tbCari.nFirmaID = tbCariHareketi.nFirmaID WHERE (tbCari.Bakiye <> 0) ORDER BY tbCariHareketi.sDovizCinsi1 DESC, tbCari.sKodu")).Tables(0)
        GridControl4.DataMember = Nothing
    End Sub
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
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView4_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView4.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView5_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView5.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView6_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView6.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class
