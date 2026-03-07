Imports DevExpress.XtraEditors
Public Class frm_icra_takip_liste
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
    Friend WithEvents ds_IcraTakip As System.Data.DataSet
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
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_Avukat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colnTakipID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsAvukatKodu As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbAvukatta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldteAvukataVerilisTarihi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collAvukataVerilenTutar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colnMektupSayisi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbAskida As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collBorc As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collOdenen As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldteSonAlisVerisTarihi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldteSonOdemeTarihi As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ustlimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_altlimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents sec_Avukatlar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_tarih As DevExpress.XtraEditors.ComboBoxEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_icra_takip_liste))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_tarih = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label10 = New DevExpress.XtraEditors.LabelControl
        Me.sec_Avukatlar = New DevExpress.XtraEditors.LookUpEdit
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_ustlimit = New DevExpress.XtraEditors.CalcEdit
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_altlimit = New DevExpress.XtraEditors.CalcEdit
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.ds_IcraTakip = New System.Data.DataSet
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colbAskida = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colnTakipID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldteTarihi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colnMusteriID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collKodu = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsAdi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsSoyadi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colnMektupSayisi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collAvukataVerilenTutar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collBorc = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collOdenen = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collKalan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldteSonAlisVerisTarihi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldteSonOdemeTarihi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colbAvukatta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coldteAvukataVerilisTarihi = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colsAvukatKodu = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.sec_Avukat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsAciklama = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_tarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Avukatlar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ustlimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_altlimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_IcraTakip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Avukat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 120)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_tarih)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.sec_Avukatlar)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txt_ustlimit)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txt_altlimit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(110, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(384, 116)
        Me.GroupControl1.TabIndex = 39
        Me.GroupControl1.Text = "Ara"
        '
        'sec_tarih
        '
        Me.sec_tarih.EditValue = "TakipTarihi:"
        Me.sec_tarih.Location = New System.Drawing.Point(2, 21)
        Me.sec_tarih.Name = "sec_tarih"
        Me.sec_tarih.Properties.Appearance.Options.UseTextOptions = True
        Me.sec_tarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.sec_tarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tarih.Properties.Items.AddRange(New Object() {"TakipTarihi:", "Av.V.Tarihi:"})
        Me.sec_tarih.Size = New System.Drawing.Size(85, 20)
        Me.sec_tarih.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 22)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Avukat:"
        '
        'sec_Avukatlar
        '
        Me.sec_Avukatlar.EnterMoveNextControl = True
        Me.sec_Avukatlar.Location = New System.Drawing.Point(88, 87)
        Me.sec_Avukatlar.Name = "sec_Avukatlar"
        Me.sec_Avukatlar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Avukatlar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sKodu", "Kodu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açýklama")})
        Me.sec_Avukatlar.Properties.DisplayMember = "sAciklama"
        Me.sec_Avukatlar.Properties.NullText = "[Avukatlar]"
        Me.sec_Avukatlar.Properties.ValueMember = "sKodu"
        Me.sec_Avukatlar.Size = New System.Drawing.Size(205, 20)
        Me.sec_Avukatlar.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(296, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "arasýndaki"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Müþteriler:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(296, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(184, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(208, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(88, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(200, 65)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 5
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(293, 87)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(66, 20)
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(283, 61)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 6
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(88, 65)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Limit:"
        '
        'txt_ustlimit
        '
        Me.txt_ustlimit.EditValue = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txt_ustlimit.EnterMoveNextControl = True
        Me.txt_ustlimit.Location = New System.Drawing.Point(208, 43)
        Me.txt_ustlimit.Name = "txt_ustlimit"
        Me.txt_ustlimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_ustlimit.Properties.NullText = "0.00"
        Me.txt_ustlimit.Size = New System.Drawing.Size(83, 20)
        Me.txt_ustlimit.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(184, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ve"
        '
        'txt_altlimit
        '
        Me.txt_altlimit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_altlimit.EnterMoveNextControl = True
        Me.txt_altlimit.Location = New System.Drawing.Point(88, 43)
        Me.txt_altlimit.Name = "txt_altlimit"
        Me.txt_altlimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_altlimit.Properties.NullText = "0.00"
        Me.txt_altlimit.Size = New System.Drawing.Size(96, 20)
        Me.txt_altlimit.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(494, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 116)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Aþaðýda Icra Takibine Alýnmýþ Müþterilerin Listesini Görmektesiniz"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(736, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 120)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 261)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_IcraTakip
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_Avukat})
        Me.GridControl1.Size = New System.Drawing.Size(820, 257)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem14, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem20, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem6, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem2.Text = "Ekle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem3.Text = "Düzelt"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem4.Text = "Sil"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 5
        Me.MenuItem20.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 6
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem24.Text = "Kalan Taksitler"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 7
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem25.Text = "Kalan Satýþlar"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 8
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem26.Text = "Satýþlar"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 9
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem27.Text = "Bekleyen Satýþlar"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 10
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem28.Text = "Müþteri Kartý"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 11
        Me.MenuItem29.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 12
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem19.Text = "Raporla"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "Önizle"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "Dizayn"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "Yazdýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 13
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 14
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 15
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 16
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 17
        Me.MenuItem16.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 18
        Me.MenuItem6.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 19
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 20
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 21
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 22
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 23
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 24
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 25
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem13.Text = "Ekraný Kapla"
        '
        'ds_IcraTakip
        '
        Me.ds_IcraTakip.DataSetName = "NewDataSet"
        Me.ds_IcraTakip.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_IcraTakip.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nTakipID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "dteTarihi"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nMusteriID"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lKodu"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAdi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sSoyadi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sAvukatKodu"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "bAvukatta"
        Me.DataColumn8.DataType = GetType(Boolean)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dteAvukataVerilisTarihi"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "lAvukataVerilenTutar"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "nMektupSayisi"
        Me.DataColumn11.DataType = GetType(Long)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sAciklama"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "bAskida"
        Me.DataColumn13.DataType = GetType(Boolean)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "dteKayitTarihi"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'GridView1
        '
        Me.GridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colnTakipID, Me.coldteTarihi, Me.colnMusteriID, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colsAvukatKodu, Me.colbAvukatta, Me.coldteAvukataVerilisTarihi, Me.collAvukataVerilenTutar, Me.colnMektupSayisi, Me.colsAciklama, Me.colbAskida, Me.coldteKayitTarihi, Me.collBorc, Me.collOdenen, Me.collKalan, Me.coldteSonAlisVerisTarihi, Me.coldteSonOdemeTarihi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(709, 367, 217, 201)
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
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Ýcralýk Takip Listesi"
        Me.GridBand1.Columns.Add(Me.colbAskida)
        Me.GridBand1.Columns.Add(Me.colnTakipID)
        Me.GridBand1.Columns.Add(Me.coldteTarihi)
        Me.GridBand1.Columns.Add(Me.colnMusteriID)
        Me.GridBand1.Columns.Add(Me.collKodu)
        Me.GridBand1.Columns.Add(Me.colsAdi)
        Me.GridBand1.Columns.Add(Me.colsSoyadi)
        Me.GridBand1.Columns.Add(Me.colnMektupSayisi)
        Me.GridBand1.Columns.Add(Me.coldteKayitTarihi)
        Me.GridBand1.Columns.Add(Me.collAvukataVerilenTutar)
        Me.GridBand1.Columns.Add(Me.collBorc)
        Me.GridBand1.Columns.Add(Me.collOdenen)
        Me.GridBand1.Columns.Add(Me.collKalan)
        Me.GridBand1.Columns.Add(Me.coldteSonAlisVerisTarihi)
        Me.GridBand1.Columns.Add(Me.coldteSonOdemeTarihi)
        Me.GridBand1.Columns.Add(Me.colbAvukatta)
        Me.GridBand1.Columns.Add(Me.coldteAvukataVerilisTarihi)
        Me.GridBand1.Columns.Add(Me.colsAvukatKodu)
        Me.GridBand1.Columns.Add(Me.colsAciklama)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 816
        '
        'colbAskida
        '
        Me.colbAskida.Caption = "Askýda"
        Me.colbAskida.FieldName = "bAskida"
        Me.colbAskida.Name = "colbAskida"
        Me.colbAskida.Visible = True
        Me.colbAskida.Width = 65
        '
        'colnTakipID
        '
        Me.colnTakipID.Caption = "Takip ID"
        Me.colnTakipID.FieldName = "nTakipID"
        Me.colnTakipID.Name = "colnTakipID"
        Me.colnTakipID.OptionsColumn.AllowEdit = False
        '
        'coldteTarihi
        '
        Me.coldteTarihi.Caption = "Takip Tarihi"
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.Width = 72
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "MusteriID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        '
        'collKodu
        '
        Me.collKodu.Caption = "Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.OptionsColumn.AllowEdit = False
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.collKodu.Visible = True
        Me.collKodu.Width = 65
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adý"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.OptionsColumn.AllowEdit = False
        Me.colsAdi.Visible = True
        Me.colsAdi.Width = 65
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadi"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.OptionsColumn.AllowEdit = False
        Me.colsSoyadi.Visible = True
        Me.colsSoyadi.Width = 65
        '
        'colnMektupSayisi
        '
        Me.colnMektupSayisi.Caption = "Mektup"
        Me.colnMektupSayisi.FieldName = "nMektupSayisi"
        Me.colnMektupSayisi.Name = "colnMektupSayisi"
        Me.colnMektupSayisi.Visible = True
        Me.colnMektupSayisi.Width = 65
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        Me.coldteKayitTarihi.Width = 61
        '
        'collAvukataVerilenTutar
        '
        Me.collAvukataVerilenTutar.Caption = "Av.VerilenTutar"
        Me.collAvukataVerilenTutar.FieldName = "lAvukataVerilenTutar"
        Me.collAvukataVerilenTutar.Name = "collAvukataVerilenTutar"
        Me.collAvukataVerilenTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAvukataVerilenTutar", "{0:#,0.00##}")})
        Me.collAvukataVerilenTutar.Visible = True
        Me.collAvukataVerilenTutar.Width = 72
        '
        'collBorc
        '
        Me.collBorc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collBorc.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collBorc.AppearanceCell.Options.UseBackColor = True
        Me.collBorc.Caption = "Borç"
        Me.collBorc.DisplayFormat.FormatString = "#,0.00"
        Me.collBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorc.FieldName = "lBorc"
        Me.collBorc.Name = "collBorc"
        Me.collBorc.OptionsColumn.AllowEdit = False
        Me.collBorc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorc", "{0:#,0.00}")})
        Me.collBorc.Visible = True
        Me.collBorc.Width = 65
        '
        'collOdenen
        '
        Me.collOdenen.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collOdenen.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collOdenen.AppearanceCell.Options.UseBackColor = True
        Me.collOdenen.Caption = "Ödenen"
        Me.collOdenen.DisplayFormat.FormatString = "#,0.00"
        Me.collOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdenen.FieldName = "lOdenen"
        Me.collOdenen.Name = "collOdenen"
        Me.collOdenen.OptionsColumn.AllowEdit = False
        Me.collOdenen.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdenen", "{0:#,0.00}")})
        Me.collOdenen.Visible = True
        Me.collOdenen.Width = 65
        '
        'collKalan
        '
        Me.collKalan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collKalan.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collKalan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collKalan.AppearanceCell.Options.UseBackColor = True
        Me.collKalan.AppearanceCell.Options.UseFont = True
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.00"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lBakiye"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.OptionsColumn.AllowEdit = False
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBakiye", "{0:#,0.00}")})
        Me.collKalan.Visible = True
        Me.collKalan.Width = 65
        '
        'coldteSonAlisVerisTarihi
        '
        Me.coldteSonAlisVerisTarihi.AppearanceCell.ForeColor = System.Drawing.Color.Teal
        Me.coldteSonAlisVerisTarihi.AppearanceCell.Options.UseForeColor = True
        Me.coldteSonAlisVerisTarihi.Caption = "Son AlýþVeriþ"
        Me.coldteSonAlisVerisTarihi.FieldName = "dteSonAlisVerisTarihi"
        Me.coldteSonAlisVerisTarihi.Name = "coldteSonAlisVerisTarihi"
        Me.coldteSonAlisVerisTarihi.OptionsColumn.AllowEdit = False
        Me.coldteSonAlisVerisTarihi.Visible = True
        Me.coldteSonAlisVerisTarihi.Width = 68
        '
        'coldteSonOdemeTarihi
        '
        Me.coldteSonOdemeTarihi.AppearanceCell.ForeColor = System.Drawing.Color.Teal
        Me.coldteSonOdemeTarihi.AppearanceCell.Options.UseForeColor = True
        Me.coldteSonOdemeTarihi.Caption = "Son Ödeme"
        Me.coldteSonOdemeTarihi.FieldName = "dteSonOdemeTarihi"
        Me.coldteSonOdemeTarihi.Name = "coldteSonOdemeTarihi"
        Me.coldteSonOdemeTarihi.OptionsColumn.AllowEdit = False
        Me.coldteSonOdemeTarihi.Visible = True
        Me.coldteSonOdemeTarihi.Width = 84
        '
        'colbAvukatta
        '
        Me.colbAvukatta.Caption = "Avukatta"
        Me.colbAvukatta.FieldName = "bAvukatta"
        Me.colbAvukatta.Name = "colbAvukatta"
        Me.colbAvukatta.RowIndex = 1
        Me.colbAvukatta.Visible = True
        Me.colbAvukatta.Width = 65
        '
        'coldteAvukataVerilisTarihi
        '
        Me.coldteAvukataVerilisTarihi.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.coldteAvukataVerilisTarihi.AppearanceCell.Options.UseForeColor = True
        Me.coldteAvukataVerilisTarihi.Caption = "Av.VerilisTarihi"
        Me.coldteAvukataVerilisTarihi.FieldName = "dteAvukataVerilisTarihi"
        Me.coldteAvukataVerilisTarihi.Name = "coldteAvukataVerilisTarihi"
        Me.coldteAvukataVerilisTarihi.RowIndex = 1
        Me.coldteAvukataVerilisTarihi.Visible = True
        Me.coldteAvukataVerilisTarihi.Width = 72
        '
        'colsAvukatKodu
        '
        Me.colsAvukatKodu.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colsAvukatKodu.AppearanceCell.Options.UseForeColor = True
        Me.colsAvukatKodu.Caption = "Avukat"
        Me.colsAvukatKodu.ColumnEdit = Me.sec_Avukat
        Me.colsAvukatKodu.FieldName = "sAvukatKodu"
        Me.colsAvukatKodu.Name = "colsAvukatKodu"
        Me.colsAvukatKodu.RowIndex = 1
        Me.colsAvukatKodu.Visible = True
        Me.colsAvukatKodu.Width = 65
        '
        'sec_Avukat
        '
        Me.sec_Avukat.AutoHeight = False
        Me.sec_Avukat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Avukat.DisplayMember = "sAciklama"
        Me.sec_Avukat.Name = "sec_Avukat"
        Me.sec_Avukat.NullText = "[Avukat]"
        Me.sec_Avukat.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_Avukat.ValueMember = "sKodu"
        '
        'colsAciklama
        '
        Me.colsAciklama.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsAciklama.AppearanceCell.Options.UseForeColor = True
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.RowIndex = 1
        Me.colsAciklama.Visible = True
        Me.colsAciklama.Width = 614
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Ýcralýk Müþteriler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"www.barkodyazilim.com", "Ýcralýk Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_icra_takip_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_icra_takip_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ýcralýk Takip Listesi..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_tarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Avukatlar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ustlimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_altlimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_IcraTakip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Avukat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kasiyerno As Int64
    Public kullanici
    Dim islem As String
    Public status As Boolean = False
    Public islemstatus As Boolean = False
    Public takip As Boolean = False
    Public kayitno As String = ""
    Dim dr As DataRow
    Dim satir
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public kriter As String = ""
    Private Sub frm_icra_takip_liste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_avukat()
        DateEdit1.EditValue = "01/01/1900"
        DateEdit2.EditValue = "31/12/2048"
        txt_ara.EditValue = ""
        PanelControl1.Focus()
        PanelControl1.Select()
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub dataload_avukat()
        sec_Avukat.DataSource = sorgu(sorgu_query("SELECT     '' AS sKodu, '' AS sAciklama UNION ALL SELECT     sKodu, sAdi + ' ' + sSoyadi AS Aciklama FROM         aEmirIcraAvukat")).Tables(0) 'DataSet2.Tables(0)
        sec_Avukatlar.Properties.DataSource = sorgu(sorgu_query("SELECT     '' AS sKodu, '' AS sAciklama UNION ALL SELECT     sKodu, sAdi + ' ' + sSoyadi AS Aciklama FROM         aEmirIcraAvukat")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERSONEL\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERSONEL\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal limitalt As Decimal, ByVal limitust As Decimal, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sAvukatKodu As String, ByVal TarihTipi As String)
        'MsgBox(kriter)
        If kayitno <> "" Then
            kriter += " WHERE aEmirIcraTakip.nTakipID = '" & kayitno & "'"
        Else
            If takip = False Then
                kriter = ""
            End If
        End If
        If TarihTipi = "TakipTarihi:" Then
            kriter = " Where aEmirIcraTakip.dteTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        ElseIf TarihTipi = "Av.V.Tarihi:" Then
            kriter = " Where aEmirIcraTakip.dteAvukataVerilisTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        End If
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND ( aEmirIcraTakip.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND ( aEmirIcraTakip.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND ( aEmirIcraTakip.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý+Soyadý" Then
                Dim adi As String = ""
                Dim soyadi As String = ""
                Dim x
                If CStr(ara.ToString) <> "" Then
                    x = (ara).IndexOf(" ", 1, (ara.Length - 1))
                    If x = -1 Then
                        adi = ara
                    Else
                        adi = (ara).Substring(0, x)
                        soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                        If IsNumeric(ara) Then
                        Else
                        End If
                    End If
                End If
                If adi.ToString <> "" Then
                    kriter += " AND ( aEmirIcraTakip.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND ( aEmirIcraTakip.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
                End If
            Else
            End If
        End If
        If sAvukatKodu <> "" Then
            kriter += " and aEmirIcraTakip.sAvukatKodu = '" & sAvukatKodu & "' "
        End If
        'ds_IcraTakip = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT aEmirIcraTakip.*, tbBakiye.lBorc AS lBorc, tbBakiye.lOdenen AS lOdenen, tbBakiye.lBakiye AS lBakiye, (SELECT TOP 1 tbOdeme.dteOdemeTarihi FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.nOdemeKodu <> 1) AND tbAlisVeris.nMusteriID = aEmirIcraTakip.nMusteriID ORDER BY tbOdeme.dteOdemeTarihi DESC) AS dteSonOdemeTarihi, (SELECT TOP 1 dteFaturaTarihi FROM tbAlisVeris WHERE (nGirisCikis = 3) AND tbAlisVeris.nMusteriID = aEmirIcraTakip.nMusteriID AND lNetTutar > 50 ORDER BY dteFaturaTarihi DESC) AS dteSonAlisVerisTarihi FROM aEmirIcraTakip LEFT OUTER JOIN (SELECT dbo.tbMusteri.nMusteriID , ISNULL(TEMPAlisveris.ToplamAlisveris , 0) AS lBorc , ISNULL(TEMPOdeme.ToplamOdeme , 0) AS lOdenen , ISNULL(TEMPAlisveris.ToplamAlisveris , 0) - ISNULL(TEMPOdeme.ToplamOdeme , 0) AS lBakiye FROM dbo.tbMusteri LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lNetTutar - lPesinat) , 0) + isnull(SUM(lVadeFarki) , 0) AS ToplamAlisveris FROM tbAlisVeris WHERE (sFisTipi = 'K' OR sFisTipi = 'SK' OR sFistipi = 'KVF' OR sFistipi = 'PAD') AND nGirisCikis = 3 GROUP BY nMusteriID) TEMPAlisveris ON TEMPAlisveris.nMusteriID = dbo.tbMusteri.nMusteriID LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lOdemeTutar) , 0) AS ToplamOdeme FROM tbAlisVeris , tbOdeme WHERE tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID AND nOdemeKodu <> 1 GROUP BY nMusteriID) TEMPOdeme ON TEMPOdeme.nMusteriID = dbo.tbMusteri.nMusteriID) tbBakiye ON aEmirIcraTakip.nMusteriID = tbBakiye.nMusteriID " & kriter & ") as T Where lBakiye Between " & limitalt & " and " & limitust & " Order by lKodu"))
        ds_IcraTakip = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT aEmirIcraTakip.*, tbBakiye.lBorc AS lBorc, tbBakiye.lOdenen AS lOdenen, tbBakiye.lBakiye AS lBakiye, (SELECT TOP 1 tbOdeme.dteOdemeTarihi FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.nOdemeKodu <> 1) AND tbAlisVeris.nMusteriID = aEmirIcraTakip.nMusteriID ORDER BY tbOdeme.dteOdemeTarihi DESC) AS dteSonOdemeTarihi, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStok.sAciklama NOT LIKE 'MUHTELIF%') AND (tbStokFisiDetayi.nGirisCikis = 3) AND (tbStokFisiDetayi.sFisTipi IN ('K', 'P','PF')) and tbStokFisiDetayi.nMusteriID = aEmirIcraTakip.nMusteriID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS dteSonAlisVerisTarihi FROM aEmirIcraTakip LEFT OUTER JOIN (SELECT dbo.tbMusteri.nMusteriID , ISNULL(TEMPAlisveris.ToplamAlisveris , 0) AS lBorc , ISNULL(TEMPOdeme.ToplamOdeme , 0) AS lOdenen , ISNULL(TEMPAlisveris.ToplamAlisveris , 0) - ISNULL(TEMPOdeme.ToplamOdeme , 0) AS lBakiye FROM dbo.tbMusteri LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lNetTutar - lPesinat) , 0) + isnull(SUM(lVadeFarki) , 0) AS ToplamAlisveris FROM tbAlisVeris WHERE (sFisTipi = 'K' OR sFisTipi = 'SK' OR sFistipi = 'KVF' OR sFistipi = 'PAD') AND nGirisCikis = 3 GROUP BY nMusteriID) TEMPAlisveris ON TEMPAlisveris.nMusteriID = dbo.tbMusteri.nMusteriID LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lOdemeTutar) , 0) AS ToplamOdeme FROM tbAlisVeris , tbOdeme WHERE tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID AND nOdemeKodu <> 1 GROUP BY nMusteriID) TEMPOdeme ON TEMPOdeme.nMusteriID = dbo.tbMusteri.nMusteriID) tbBakiye ON aEmirIcraTakip.nMusteriID = tbBakiye.nMusteriID " & kriter & ") as T Where lBakiye Between " & limitalt & " and " & limitust & " Order by lKodu"))
        GridControl1.DataSource = ds_IcraTakip.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
        'If islemstatus = True Then
        '    kayit_duzelt()
        'End If
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
    Private Function ekle(ByVal dteTarihi As DateTime, ByVal nMusteriID As Int64, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sAvukatKodu As String, ByVal bAvukatta As Byte, ByVal dteAvukataVerilisTarihi As DateTime, ByVal lAvukataVerilenTutar As Decimal, ByVal nMektupSayisi As Int64, ByVal sAciklama As String, ByVal bAskida As Byte, ByVal dteKayitTarihi As DateTime) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirIcraTakip (dteTarihi, nMusteriID, lKodu, sAdi, sSoyadi, sAvukatKodu, bAvukatta, dteAvukataVerilisTarihi, lAvukataVerilenTutar, nMektupSayisi, sAciklama, bAskida, dteKayitTarihi) VALUES     ('" & dteTarihi & "', '" & nMusteriID & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & sAvukatKodu & "', " & bAvukatta & ", '" & dteAvukataVerilisTarihi & "', " & lAvukataVerilenTutar & ", " & nMektupSayisi & ", N'" & sAciklama & "', " & bAskida & ", '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        kayitno = Nothing
    End Function
    Private Sub duzelt(ByVal nTakipID As Int64, ByVal dteTarihi As DateTime, ByVal nMusteriID As Int64, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sAvukatKodu As String, ByVal bAvukatta As Byte, ByVal dteAvukataVerilisTarihi As DateTime, ByVal lAvukataVerilenTutar As Decimal, ByVal nMektupSayisi As Int64, ByVal sAciklama As String, ByVal bAskida As Byte, ByVal dteKayitTarihi As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirIcraTakip SET              dteTarihi = '" & dteTarihi & "', nMusteriID = " & nMusteriID & ", lKodu = '" & lKodu & "', sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', sAvukatKodu ='" & sAvukatKodu & "', bAvukatta = " & bAvukatta & ", dteAvukataVerilisTarihi = '" & dteAvukataVerilisTarihi & "', lAvukataVerilenTutar = " & lAvukataVerilenTutar & ", nMektupSayisi = " & nMektupSayisi & ", sAciklama = N'" & sAciklama & "', bAskida = " & bAskida & ", dteKayitTarihi = '" & dteKayitTarihi & "' WHERE nTakipID = " & nTakipID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub sil(ByVal nTakipID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM aEmirIcraTakip WHERE nTakipID = '" & nTakipID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            kayitno = dr("nTakipID")
            If kayitno > 0 Then
                If XtraMessageBox.Show(kayitno & vbTab & Sorgu_sDil("Kodlu Takip Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    sil(kayitno)
                End If
            End If
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_altlimit.EditValue, txt_ustlimit.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, Trim(sec_Avukatlar.EditValue), sec_tarih.Text)
            GridView1.FocusedRowHandle = satir
        End If
    End Sub
    Private Sub satir_hesapla()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'If dr("bAvukatta") = False Then
            '    dr("sAvukatKodu") = ""
            '    dr("dteAvukataVerilisTarihi") = "01/01/1900"
            'Else
            'End If
            dr.EndEdit()
            duzelt(dr("nTakipID"), dr("dteTarihi"), dr("nMusteriID"), dr("lKodu"), dr("sAdi"), dr("sSoyadi"), dr("sAvukatKodu"), dr("bAvukatta"), dr("dteAvukataVerilisTarihi"), dr("lAvukataVerilenTutar"), dr("nMektupSayisi"), dr("sAciklama"), dr("bAskida"), dr("dteKayitTarihi"))
        End If
    End Sub
    Private Sub satir_ekle()
        Dim frm As New frm_musteri_liste
        frm.islemstatus = True
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islem = "IcraTakipEkle"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_IcraTakip.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("dteTarihi") = Today
                    dr("nMusteriID") = dr1("nMusteriID")
                    dr("lKodu") = dr1("lKodu")
                    dr("sAdi") = dr1("sAdi")
                    dr("sSoyadi") = dr1("sSoyadi")
                    dr("sAvukatKodu") = ""
                    dr("bAvukatta") = 0
                    dr("dteAvukataVerilisTarihi") = "01/01/1900"
                    dr("lAvukataVerilenTutar") = 0
                    dr("nMektupSayisi") = 0
                    dr("sAciklama") = ""
                    dr("bAskida") = 0
                    dr("dteKayitTarihi") = Now
                    dr("nTakipID") = ekle(dr("dteTarihi"), dr("nMusteriID"), dr("lKodu"), dr("sAdi"), dr("sSoyadi"), dr("sAvukatKodu"), dr("bAvukatta"), dr("dteAvukataVerilisTarihi"), dr("lAvukataVerilenTutar"), dr("nMektupSayisi"), dr("sAciklama"), dr("bAskida"), dr("dteKayitTarihi"))
                    ds_IcraTakip.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                GridControl1.Focus()
                GridControl1.Select()
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
            dr1 = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
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
    Private Sub analiz_bekleyen()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_satis_bekleyen_onaysiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.firmakodu = dr("lKodu").ToString
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eþittir"
            frm.islemstatus = True
            frm.ShowDialog()
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        satir_ekle()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        kayit_sil()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If MenuItem9.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem9.Checked = True
        ElseIf MenuItem9.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem9.Checked = False
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If MenuItem10.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem10.Checked = True
        ElseIf MenuItem10.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem10.Checked = False
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        analiz_bekleyen()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_musteri_karti()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        SimpleButton3.Enabled = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_altlimit.EditValue, txt_ustlimit.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, Trim(sec_Avukatlar.EditValue), sec_tarih.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton3.Enabled = True
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            satir_hesapla()
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
