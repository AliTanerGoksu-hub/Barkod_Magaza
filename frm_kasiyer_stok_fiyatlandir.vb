Imports DevExpress.XtraEditors
Public Class frm_kasiyer_stok_fiyatlandir
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
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_belgeno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_tarih As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_satici As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_Musteri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_MusteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbl_ara_stok As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_yFiyat As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_eFiyat As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_stok_kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sec_fiyattipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_fisno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBelgeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReyonFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteriNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteriKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMalincinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coleFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colyFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSonuc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSure As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDegisimTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sure As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_kasiyer_stok_fiyatlandir))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label10 = New DevExpress.XtraEditors.LabelControl
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sure = New DevExpress.XtraEditors.SpinEdit
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_belgeno = New DevExpress.XtraEditors.ButtonEdit
        Me.txt_tarih = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.sec_satici = New DevExpress.XtraEditors.LookUpEdit
        Me.txt_Musteri = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.txt_MusteriNo = New DevExpress.XtraEditors.ButtonEdit
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_fisno = New DevExpress.XtraEditors.ButtonEdit
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
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
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTarih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBelgeNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReyonFisNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFisNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMusteriNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMusteriKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStokNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStokKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMalincinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coleFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colyFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSonuc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSure = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaticiNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSatici = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDegisimTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.sec_fiyattipi = New DevExpress.XtraEditors.LookUpEdit
        Me.Label14 = New DevExpress.XtraEditors.LabelControl
        Me.Label13 = New DevExpress.XtraEditors.LabelControl
        Me.Label12 = New DevExpress.XtraEditors.LabelControl
        Me.txt_yFiyat = New DevExpress.XtraEditors.CalcEdit
        Me.txt_eFiyat = New DevExpress.XtraEditors.CalcEdit
        Me.lbl_ara_stok = New DevExpress.XtraEditors.LabelControl
        Me.txt_stok = New DevExpress.XtraEditors.TextEdit
        Me.txt_stok_kod = New DevExpress.XtraEditors.ButtonEdit
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_sure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.sec_satici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Musteri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MusteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fisno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.sec_fiyattipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_yFiyat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_eFiyat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_stok_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(706, 64)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(89, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(614, 58)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Aþaðýda Fiyat Deðiþim Emri Bilgilerini ve Tanýmlarý Görmektesiniz. Ýþlemi Tamamla" & _
            "mak için [Tamam] iþlemden vazgeçmek için ise [Vazgeç] butonuna týklayýnýz..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label10)
        Me.PanelControl2.Controls.Add(Me.Label7)
        Me.PanelControl2.Controls.Add(Me.txt_sure)
        Me.PanelControl2.Controls.Add(Me.bar)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 448)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(706, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(119, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "dk."
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Süre:"
        '
        'txt_sure
        '
        Me.txt_sure.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_sure.Location = New System.Drawing.Point(64, 16)
        Me.txt_sure.Name = "txt_sure"
        Me.txt_sure.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sure.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sure.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_sure.Properties.MaxLength = 2
        Me.txt_sure.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txt_sure.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_sure.Size = New System.Drawing.Size(56, 22)
        Me.txt_sure.TabIndex = 7
        '
        'bar
        '
        Me.bar.Location = New System.Drawing.Point(152, 16)
        Me.bar.Name = "bar"
        Me.bar.Properties.Maximum = 60
        Me.bar.Properties.PercentView = False
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(376, 18)
        Me.bar.TabIndex = 6
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(618, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(538, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl4)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 64)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(706, 384)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txt_belgeno)
        Me.GroupControl1.Controls.Add(Me.txt_tarih)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(248, 94)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Fiyat Deðiþim Emri Bilgileri"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "BelgeNo:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tarih:"
        '
        'txt_belgeno
        '
        Me.txt_belgeno.Enabled = False
        Me.txt_belgeno.Location = New System.Drawing.Point(80, 46)
        Me.txt_belgeno.Name = "txt_belgeno"
        Me.txt_belgeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_belgeno.Size = New System.Drawing.Size(160, 22)
        Me.txt_belgeno.TabIndex = 1
        '
        'txt_tarih
        '
        Me.txt_tarih.EditValue = Nothing
        Me.txt_tarih.Enabled = False
        Me.txt_tarih.Location = New System.Drawing.Point(80, 24)
        Me.txt_tarih.Name = "txt_tarih"
        Me.txt_tarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tarih.Properties.DisplayFormat.FormatString = "D"
        Me.txt_tarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_tarih.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_tarih.Size = New System.Drawing.Size(160, 22)
        Me.txt_tarih.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl2.Controls.Add(Me.sec_satici)
        Me.GroupControl2.Controls.Add(Me.txt_Musteri)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.txt_MusteriNo)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.txt_fisno)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Location = New System.Drawing.Point(256, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(432, 94)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Fiþi Bilgileri"
        '
        'sec_satici
        '
        Me.sec_satici.EnterMoveNextControl = True
        Me.sec_satici.Location = New System.Drawing.Point(80, 46)
        Me.sec_satici.Name = "sec_satici"
        Me.sec_satici.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sec_satici.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.sec_satici.Properties.Appearance.Options.UseBackColor = True
        Me.sec_satici.Properties.Appearance.Options.UseForeColor = True
        Me.sec_satici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satici.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", 10, "KayýtNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SATICI", 35, "Satýcý")})
        Me.sec_satici.Properties.DisplayMember = "SATICI"
        Me.sec_satici.Properties.NullText = "[Satýcýlar]"
        Me.sec_satici.Properties.ValueMember = "IND"
        Me.sec_satici.Size = New System.Drawing.Size(248, 22)
        Me.sec_satici.TabIndex = 10
        '
        'txt_Musteri
        '
        Me.txt_Musteri.Enabled = False
        Me.txt_Musteri.EnterMoveNextControl = True
        Me.txt_Musteri.Location = New System.Drawing.Point(215, 68)
        Me.txt_Musteri.Name = "txt_Musteri"
        Me.txt_Musteri.Size = New System.Drawing.Size(208, 22)
        Me.txt_Musteri.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Müþteri:"
        '
        'txt_MusteriNo
        '
        Me.txt_MusteriNo.EnterMoveNextControl = True
        Me.txt_MusteriNo.Location = New System.Drawing.Point(80, 68)
        Me.txt_MusteriNo.Name = "txt_MusteriNo"
        Me.txt_MusteriNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_MusteriNo.Properties.Appearance.Options.UseFont = True
        Me.txt_MusteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_MusteriNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MusteriNo.Properties.MaxLength = 15
        Me.txt_MusteriNo.Size = New System.Drawing.Size(136, 22)
        Me.txt_MusteriNo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Satýcý:"
        '
        'txt_fisno
        '
        Me.txt_fisno.EnterMoveNextControl = True
        Me.txt_fisno.Location = New System.Drawing.Point(80, 24)
        Me.txt_fisno.Name = "txt_fisno"
        Me.txt_fisno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_fisno.Size = New System.Drawing.Size(136, 22)
        Me.txt_fisno.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FiþNo:"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl4.Controls.Add(Me.GridControl1)
        Me.GroupControl4.Location = New System.Drawing.Point(9, 195)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(680, 181)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Stoklar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 19)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(674, 159)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Kod"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Adi"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Tarih"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "BelgeNo"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ReyonFisNo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "FisNo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "MusteriNo"
        Me.DataColumn8.DataType = GetType(Long)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "MusteriKodu"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "MusteriAdi"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "StokNo"
        Me.DataColumn11.DataType = GetType(Long)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "StokKodu"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Malincinsi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Barcode"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "FiyatTipi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "eFiyat"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "yFiyat"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Sonuc"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Status"
        Me.DataColumn19.DataType = GetType(Boolean)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "KayitTarihi"
        Me.DataColumn20.DataType = GetType(Date)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Sure"
        Me.DataColumn21.DataType = GetType(Long)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Aciklama"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "DegisimTarihi"
        Me.DataColumn23.DataType = GetType(Date)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "SaticiNo"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Satici"
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
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colKod, Me.colAdi, Me.colTarih, Me.colBelgeNo, Me.colReyonFisNo, Me.colFisNo, Me.colMusteriNo, Me.colMusteriKodu, Me.colMusteriAdi, Me.colStokNo, Me.colStokKodu, Me.colMalincinsi, Me.colBarcode, Me.colFiyatTipi, Me.coleFiyat, Me.colyFiyat, Me.colSonuc, Me.colStatus, Me.colKayitTarihi, Me.colSure, Me.colAciklama, Me.colSaticiNo, Me.colSatici, Me.colDegisimTarihi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(609, 257, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'colKod
        '
        Me.colKod.Caption = "KasiyerKodu"
        Me.colKod.FieldName = "Kod"
        Me.colKod.Name = "colKod"
        '
        'colAdi
        '
        Me.colAdi.Caption = "Kasiyer"
        Me.colAdi.FieldName = "Adi"
        Me.colAdi.Name = "colAdi"
        '
        'colTarih
        '
        Me.colTarih.Caption = "Tarih"
        Me.colTarih.FieldName = "Tarih"
        Me.colTarih.Name = "colTarih"
        Me.colTarih.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.colTarih.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colTarih.Visible = True
        Me.colTarih.VisibleIndex = 0
        '
        'colBelgeNo
        '
        Me.colBelgeNo.Caption = "Belge No"
        Me.colBelgeNo.FieldName = "BelgeNo"
        Me.colBelgeNo.Name = "colBelgeNo"
        Me.colBelgeNo.Visible = True
        Me.colBelgeNo.VisibleIndex = 1
        Me.colBelgeNo.Width = 68
        '
        'colReyonFisNo
        '
        Me.colReyonFisNo.Caption = "ReyonFisNo"
        Me.colReyonFisNo.FieldName = "ReyonFisNo"
        Me.colReyonFisNo.Name = "colReyonFisNo"
        '
        'colFisNo
        '
        Me.colFisNo.Caption = "Fiþ No"
        Me.colFisNo.FieldName = "FisNo"
        Me.colFisNo.Name = "colFisNo"
        Me.colFisNo.Visible = True
        Me.colFisNo.VisibleIndex = 2
        Me.colFisNo.Width = 86
        '
        'colMusteriNo
        '
        Me.colMusteriNo.Caption = "Müþteri No"
        Me.colMusteriNo.FieldName = "MusteriNo"
        Me.colMusteriNo.Name = "colMusteriNo"
        '
        'colMusteriKodu
        '
        Me.colMusteriKodu.Caption = "Müþteri Kodu"
        Me.colMusteriKodu.FieldName = "MusteriKodu"
        Me.colMusteriKodu.Name = "colMusteriKodu"
        '
        'colMusteriAdi
        '
        Me.colMusteriAdi.Caption = "Müþteri Adý"
        Me.colMusteriAdi.FieldName = "MusteriAdi"
        Me.colMusteriAdi.Name = "colMusteriAdi"
        Me.colMusteriAdi.Visible = True
        Me.colMusteriAdi.VisibleIndex = 3
        Me.colMusteriAdi.Width = 86
        '
        'colStokNo
        '
        Me.colStokNo.Caption = "Stok No"
        Me.colStokNo.FieldName = "StokNo"
        Me.colStokNo.Name = "colStokNo"
        '
        'colStokKodu
        '
        Me.colStokKodu.Caption = "Stok Kodu"
        Me.colStokKodu.FieldName = "StokKodu"
        Me.colStokKodu.Name = "colStokKodu"
        Me.colStokKodu.Visible = True
        Me.colStokKodu.VisibleIndex = 4
        Me.colStokKodu.Width = 86
        '
        'colMalincinsi
        '
        Me.colMalincinsi.Caption = "Malincinsi"
        Me.colMalincinsi.FieldName = "Malincinsi"
        Me.colMalincinsi.Name = "colMalincinsi"
        Me.colMalincinsi.Visible = True
        Me.colMalincinsi.VisibleIndex = 5
        Me.colMalincinsi.Width = 86
        '
        'colBarcode
        '
        Me.colBarcode.Caption = "Barcode"
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.Name = "colBarcode"
        '
        'colFiyatTipi
        '
        Me.colFiyatTipi.Caption = "FiyatTipi"
        Me.colFiyatTipi.FieldName = "FiyatTipi"
        Me.colFiyatTipi.Name = "colFiyatTipi"
        Me.colFiyatTipi.Visible = True
        Me.colFiyatTipi.VisibleIndex = 6
        Me.colFiyatTipi.Width = 86
        '
        'coleFiyat
        '
        Me.coleFiyat.Caption = "EskiFiyat"
        Me.coleFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.coleFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coleFiyat.FieldName = "eFiyat"
        Me.coleFiyat.Name = "coleFiyat"
        Me.coleFiyat.Visible = True
        Me.coleFiyat.VisibleIndex = 7
        Me.coleFiyat.Width = 86
        '
        'colyFiyat
        '
        Me.colyFiyat.Caption = "YeniFiyat"
        Me.colyFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.colyFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colyFiyat.FieldName = "yFiyat"
        Me.colyFiyat.Name = "colyFiyat"
        Me.colyFiyat.Visible = True
        Me.colyFiyat.VisibleIndex = 8
        Me.colyFiyat.Width = 88
        '
        'colSonuc
        '
        Me.colSonuc.Caption = "Sonuc"
        Me.colSonuc.FieldName = "Sonuc"
        Me.colSonuc.Name = "colSonuc"
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colKayitTarihi
        '
        Me.colKayitTarihi.Caption = "KayitSaati"
        Me.colKayitTarihi.DisplayFormat.FormatString = "hh:mm:ss"
        Me.colKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKayitTarihi.FieldName = "KayitTarihi"
        Me.colKayitTarihi.Name = "colKayitTarihi"
        '
        'colSure
        '
        Me.colSure.Caption = "Sure"
        Me.colSure.FieldName = "Sure"
        Me.colSure.Name = "colSure"
        '
        'colAciklama
        '
        Me.colAciklama.Caption = "Açýklama"
        Me.colAciklama.FieldName = "Aciklama"
        Me.colAciklama.Name = "colAciklama"
        '
        'colSaticiNo
        '
        Me.colSaticiNo.Caption = "SatýcýNo"
        Me.colSaticiNo.FieldName = "SaticiNo"
        Me.colSaticiNo.Name = "colSaticiNo"
        '
        'colSatici
        '
        Me.colSatici.Caption = "Satýcý"
        Me.colSatici.FieldName = "Satici"
        Me.colSatici.Name = "colSatici"
        '
        'colDegisimTarihi
        '
        Me.colDegisimTarihi.Caption = "DeðiþimSaati"
        Me.colDegisimTarihi.DisplayFormat.FormatString = "hh:mm:ss"
        Me.colDegisimTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDegisimTarihi.FieldName = "DegisimTarihi"
        Me.colDegisimTarihi.Name = "colDegisimTarihi"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Controls.Add(Me.Label6)
        Me.GroupControl3.Controls.Add(Me.sec_fiyattipi)
        Me.GroupControl3.Controls.Add(Me.Label14)
        Me.GroupControl3.Controls.Add(Me.Label13)
        Me.GroupControl3.Controls.Add(Me.Label12)
        Me.GroupControl3.Controls.Add(Me.txt_yFiyat)
        Me.GroupControl3.Controls.Add(Me.txt_eFiyat)
        Me.GroupControl3.Controls.Add(Me.lbl_ara_stok)
        Me.GroupControl3.Controls.Add(Me.txt_stok)
        Me.GroupControl3.Controls.Add(Me.txt_stok_kod)
        Me.GroupControl3.Controls.Add(Me.Label9)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 98)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(680, 97)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Fiyatý Deðiþecek Stok Bilgileri"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 68)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(664, 23)
        Me.SimpleButton3.TabIndex = 23
        Me.SimpleButton3.Text = "&Ekle"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(288, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Stok:"
        '
        'sec_fiyattipi
        '
        Me.sec_fiyattipi.EnterMoveNextControl = True
        Me.sec_fiyattipi.Location = New System.Drawing.Point(80, 46)
        Me.sec_fiyattipi.Name = "sec_fiyattipi"
        Me.sec_fiyattipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_fiyattipi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_fiyattipi.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.sec_fiyattipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_fiyattipi.Properties.Appearance.Options.UseFont = True
        Me.sec_fiyattipi.Properties.Appearance.Options.UseForeColor = True
        Me.sec_fiyattipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyattipi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sFiyatTipi", 10, "FiyatTipi"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", 35, "Açýklama")})
        Me.sec_fiyattipi.Properties.DisplayMember = "sAciklama"
        Me.sec_fiyattipi.Properties.NullText = "[Fiyat Tipleri]"
        Me.sec_fiyattipi.Properties.ValueMember = "sFiyatTipi"
        Me.sec_fiyattipi.Size = New System.Drawing.Size(160, 22)
        Me.sec_fiyattipi.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(464, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 11)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "YeniFiyat:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(248, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "GüncelFiyat:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "FiyatTipi:"
        '
        'txt_yFiyat
        '
        Me.txt_yFiyat.EnterMoveNextControl = True
        Me.txt_yFiyat.Location = New System.Drawing.Point(528, 46)
        Me.txt_yFiyat.Name = "txt_yFiyat"
        Me.txt_yFiyat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_yFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_yFiyat.Properties.Appearance.Options.UseFont = True
        Me.txt_yFiyat.Properties.Appearance.Options.UseForeColor = True
        Me.txt_yFiyat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_yFiyat.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_yFiyat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_yFiyat.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_yFiyat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_yFiyat.Properties.NullText = "0.00"
        Me.txt_yFiyat.Size = New System.Drawing.Size(144, 22)
        Me.txt_yFiyat.TabIndex = 17
        '
        'txt_eFiyat
        '
        Me.txt_eFiyat.EnterMoveNextControl = True
        Me.txt_eFiyat.Location = New System.Drawing.Point(328, 46)
        Me.txt_eFiyat.Name = "txt_eFiyat"
        Me.txt_eFiyat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_eFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_eFiyat.Properties.Appearance.Options.UseFont = True
        Me.txt_eFiyat.Properties.Appearance.Options.UseForeColor = True
        Me.txt_eFiyat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_eFiyat.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_eFiyat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_eFiyat.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_eFiyat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_eFiyat.Properties.NullText = "0.00"
        Me.txt_eFiyat.Properties.ReadOnly = True
        Me.txt_eFiyat.Size = New System.Drawing.Size(128, 22)
        Me.txt_eFiyat.TabIndex = 16
        '
        'lbl_ara_stok
        '
        Me.lbl_ara_stok.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ara_stok.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbl_ara_stok.ForeColor = System.Drawing.Color.Black
        Me.lbl_ara_stok.Location = New System.Drawing.Point(248, 24)
        Me.lbl_ara_stok.Name = "lbl_ara_stok"
        Me.lbl_ara_stok.Size = New System.Drawing.Size(32, 18)
        Me.lbl_ara_stok.TabIndex = 15
        Me.lbl_ara_stok.Text = "*"
        '
        'txt_stok
        '
        Me.txt_stok.Enabled = False
        Me.txt_stok.EnterMoveNextControl = True
        Me.txt_stok.Location = New System.Drawing.Point(328, 24)
        Me.txt_stok.Name = "txt_stok"
        Me.txt_stok.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txt_stok.Properties.Appearance.Options.UseBackColor = True
        Me.txt_stok.Size = New System.Drawing.Size(344, 22)
        Me.txt_stok.TabIndex = 14
        '
        'txt_stok_kod
        '
        Me.txt_stok_kod.Location = New System.Drawing.Point(80, 24)
        Me.txt_stok_kod.Name = "txt_stok_kod"
        Me.txt_stok_kod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_stok_kod.Properties.Appearance.Options.UseFont = True
        Me.txt_stok_kod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_stok_kod.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_stok_kod.Properties.MaxLength = 15
        Me.txt_stok_kod.Size = New System.Drawing.Size(160, 22)
        Me.txt_stok_kod.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(32, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Kod:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frm_kasiyer_stok_fiyatlandir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(706, 496)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_kasiyer_stok_fiyatlandir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Fiyat Deðiþim Emri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txt_sure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.sec_satici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Musteri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MusteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fisno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.sec_fiyattipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_yFiyat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_eFiyat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_stok_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kasiyerno
    Public kasiyer
    Public kullanici
    Public ds_kasiyer As DataSet
    Public ds_satici As DataSet
    Public ds_fiyattipi As DataSet
    Dim ds_cari As DataSet
    Dim ds_stok As DataSet
    Dim dr As DataRow
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public musterino As Int64 = 0
    Public stokno As Int64 = 0
    Public stokkodu As String
    Public malincinsi As String
    Public fiyattipi As String
    Public barcode As String
    Public efiyat As Decimal
    Public yfiyat As Decimal
    Dim sayi As Int64 = 0
    Dim belgeind As Int64
    Public status As Boolean = False
    Public sure As Int64
    Private Sub frm_kasiyer_stok_fiyatlandir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
    End Sub
    Private Sub dataload()
        txt_tarih.EditValue = dteSistemTarihi
        Try
            txt_belgeno.EditValue = belgeno_kontrol(dataload_belgeno().ToString).ToString
            con.Close()
        Catch ex As Exception
            txt_belgeno.EditValue = "A-000001"
        End Try
        sec_satici.Properties.DataSource = ds_satici.Tables(0)
        sec_fiyattipi.Properties.DataSource = ds_fiyattipi.Tables(0)
        'sec_fiyattipi.ItemIndex = 0
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Function belgeno_kontrol(ByVal belgeno As String, Optional ByVal islem As Integer = 0) As String
        Dim seri
        Dim no
        Dim evrak_no
        evrak_no = belgeno
        evrak_no = evrak_no.Replace(0, "")
        evrak_no = evrak_no.Replace(1, "")
        evrak_no = evrak_no.Replace(2, "")
        evrak_no = evrak_no.Replace(3, "")
        evrak_no = evrak_no.Replace(4, "")
        evrak_no = evrak_no.Replace(5, "")
        evrak_no = evrak_no.Replace(6, "")
        evrak_no = evrak_no.Replace(7, "")
        evrak_no = evrak_no.Replace(8, "")
        evrak_no = evrak_no.Replace(9, "")
        'txtbelgeseri.EditValue = evrak_no
        seri = evrak_no
        If evrak_no = "" Then
            seri = "A-"
        End If
        evrak_no = belgeno
        evrak_no = evrak_no.Replace("A", "")
        evrak_no = evrak_no.Replace("B", "")
        evrak_no = evrak_no.Replace("C", "")
        evrak_no = evrak_no.Replace("Ç", "")
        evrak_no = evrak_no.Replace("D", "")
        evrak_no = evrak_no.Replace("E", "")
        evrak_no = evrak_no.Replace("F", "")
        evrak_no = evrak_no.Replace("G", "")
        evrak_no = evrak_no.Replace("H", "")
        evrak_no = evrak_no.Replace("I", "")
        evrak_no = evrak_no.Replace("Ý", "")
        evrak_no = evrak_no.Replace("J", "")
        evrak_no = evrak_no.Replace("K", "")
        evrak_no = evrak_no.Replace("L", "")
        evrak_no = evrak_no.Replace("M", "")
        evrak_no = evrak_no.Replace("N", "")
        evrak_no = evrak_no.Replace("O", "")
        evrak_no = evrak_no.Replace("Ö", "")
        evrak_no = evrak_no.Replace("P", "")
        evrak_no = evrak_no.Replace("R", "")
        evrak_no = evrak_no.Replace("S", "")
        evrak_no = evrak_no.Replace("Þ", "")
        evrak_no = evrak_no.Replace("T", "")
        evrak_no = evrak_no.Replace("U", "")
        evrak_no = evrak_no.Replace("Ü", "")
        evrak_no = evrak_no.Replace("V", "")
        evrak_no = evrak_no.Replace("Y", "")
        evrak_no = evrak_no.Replace("Z", "")
        evrak_no = evrak_no.Replace("X", "")
        evrak_no = evrak_no.Replace("W", "")
        evrak_no = evrak_no.Replace("_", "")
        evrak_no = evrak_no.Replace("-", "")
        evrak_no = evrak_no.Replace("*", "")
        evrak_no = evrak_no.Replace("/", "")
        evrak_no = evrak_no.Replace("+", "")
        Try
            If islem = 0 Then
                no = CType(evrak_no, Integer) + 1
            Else
                no = CType(evrak_no, Integer)
            End If
            no = columnuzunlukinteger_sifir(no.ToString, 6)
            belgeno = seri + no.ToString
        Catch ex As Exception
            belgeno = seri + columnuzunlukinteger_sifir(1, 6)
        End Try
        Return belgeno
    End Function
    Private Function dataload_belgeno() As String
        Dim sonuc
        Try
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(BelgeNo,'A-000001') AS BELGENO FROM aEmirKasiyerStokFiyat WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM aEmirKasiyerStokFiyat  WHERE  BelgeNo LIKE 'A%')")
            sonuc = cmd.ExecuteScalar
            con.Close()
            If CStr(sonuc).ToString = "" Then
                sonuc = "A-000000"
            End If
        Catch ex As Exception
            sonuc = "A-000000"
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return sonuc
        sonuc = Nothing
    End Function
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Sub txt_MusteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MusteriNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txt_MusteriNo.EditValue).ToString <> "" Then
                Dim kontrol = sorgu_cari_kontrol(txt_MusteriNo.EditValue)
                If kontrol = 0 Then
                    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf kontrol = 1 Then
                    dataload_cari(txt_MusteriNo.EditValue)
                    For Each dr In ds_cari.Tables(0).Rows
                        txt_Musteri.EditValue = dr("MUSTERI")
                        musterino = dr("IND")
                    Next
                End If
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (Stok.sKodu = '" & kod & "') or (Barcode.sBarkod ='" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok Stok INNER JOIN  tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat, 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nMusteriID AS IND, lKodu AS MUSTERIKODU, sAdi + ' ' + sSoyadi AS MUSTERI FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (Stok.sKodu = '" & kod & "') or (Barcode.sBarkod ='" & kod & "') "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     Stok.nStokID AS StokNo, Stok.sKodu AS StokKodu, Stok.sAciklama AS Malincinsi, Barcode.sBarkod AS Barcode FROM         tbStok Stok INNER JOIN                       tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & ""))
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
    Private Sub txt_stok_kod_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_stok_kod.EditValueChanged
        If Len(txt_stok_kod.EditValue.ToString) <> 0 Then
            lbl_ara_stok.Text = Len(txt_stok_kod.EditValue.ToString)
        Else
            lbl_ara_stok.Text = "*"
        End If
    End Sub
    Private Sub txt_stok_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_stok_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            stok_kontrol()
        ElseIf e.KeyCode = Keys.F6 Then
            stok_sec()
        End If
    End Sub
    Private Sub stok_kontrol()
        If Trim(txt_stok_kod.Text) <> "" Then
            Dim kontrol = sorgu_stok_kontrol(txt_stok_kod.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_stok_kod.Focus()
                txt_stok_kod.SelectAll()
            ElseIf kontrol = 1 Then
                dataload_stok(txt_stok_kod.EditValue)
                For Each dr In ds_stok.Tables(0).Rows
                    txt_stok.EditValue = dr("Malincinsi")
                    stokkodu = (dr("StokKodu"))
                    stokno = dr("STOKNO")
                    barcode = dr("Barcode")
                    malincinsi = dr("Malincinsi")
                Next
                If GridView1.RowCount > 0 Then
                    fiyat_kontrol()
                ElseIf GridView1.RowCount = 0 Then
                    If sec_fiyattipi.ItemIndex >= 0 Then
                        fiyat_kontrol()
                    End If
                End If
                sec_fiyattipi.Focus()
                sec_fiyattipi.SelectAll()
            End If
        End If
    End Sub
    Private Sub sec_fiyattipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_fiyattipi.EditValueChanged
        Dim fiyat As Decimal = 0
        Try
            fiyat = sorgu_stok_fiyat(sec_fiyattipi.EditValue, stokno)
        Catch ex As Exception
            fiyat = 0
        End Try
        If fiyat = 0 Then
            txt_eFiyat.EditValue = 0
            XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlanmamýþ... Lütfen Tekrar Deneyiniz..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txt_eFiyat.EditValue = fiyat
            txt_yFiyat.EditValue = fiyat
            txt_yFiyat.Focus()
            txt_yFiyat.SelectAll()
        End If
        fiyat = Nothing
    End Sub
    Private Sub fiyat_kontrol()
        Dim fiyat As Decimal = 0
        Try
            fiyat = sorgu_stok_fiyat(sec_fiyattipi.EditValue, stokno)
        Catch ex As Exception
            fiyat = 0
        End Try
        If fiyat = 0 Then
            txt_eFiyat.EditValue = 0
        Else
            txt_eFiyat.EditValue = fiyat
            txt_yFiyat.EditValue = fiyat
            txt_stok_kod.Focus()
            txt_stok_kod.SelectAll()
            'txt_eFiyat.Focus()
            'txt_eFiyat.SelectAll()
        End If
        fiyat = Nothing
    End Sub
    Private Function ekle(ByVal Kod As String, ByVal Adi As String, ByVal Tarih As DateTime, ByVal BelgeNo As String, ByVal FisNo As String, ByVal MusteriNo As Int64, ByVal MusteriKodu As String, ByVal MusteriAdi As String, ByVal SaticiNo As String, ByVal Satici As String, ByVal StokNo As Int64, ByVal StokKodu As String, ByVal Malincinsi As String, ByVal Barcode As String, ByVal FiyatTipi As String, ByVal eFiyat As Decimal, ByVal yFiyat As Decimal, ByVal Sonuc As String, ByVal Status As Integer, ByVal KayitTarihi As DateTime, ByVal DegisimTarihi As DateTime, ByVal Sure As Int64, ByVal Aciklama As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitno As Int64
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirKasiyerStokFiyat (Kod, Adi, Tarih, BelgeNo, FisNo, MusteriNo, MusteriKodu, MusteriAdi, SaticiNo, Satici, StokNo, StokKodu, Malincinsi, Barcode, FiyatTipi, eFiyat, yFiyat, Sonuc, Status, KayitTarihi, DegisimTarihi, Sure, Aciklama) VALUES     ('" & Kod & "', '" & Adi & "', '" & Tarih & "', '" & BelgeNo & "', '" & FisNo & "', " & MusteriNo & " , '" & MusteriKodu & "', '" & MusteriAdi & "' , '" & SaticiNo & "', '" & Satici & "', '" & StokNo & "', '" & StokKodu & "', '" & Malincinsi & "', '" & Barcode & "', '" & FiyatTipi & "', " & eFiyat & ", " & yFiyat & ", '" & Sonuc & "', " & Status & ", GETDATE(), GETDATE(), " & Sure & ", '" & Aciklama & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub duzelt(ByVal ind As Int64, ByVal Kod As String, ByVal Adi As String, ByVal Tarih As DateTime, ByVal BelgeNo As String, ByVal FisNo As String, ByVal MusteriNo As Int64, ByVal MusteriKodu As String, ByVal MusteriAdi As String, ByVal SaticiNo As String, ByVal Satici As String, ByVal StokNo As Int64, ByVal StokKodu As String, ByVal Malincinsi As String, ByVal Barcode As String, ByVal FiyatTipi As String, ByVal eFiyat As Decimal, ByVal yFiyat As Decimal, ByVal Sonuc As String, ByVal Status As Integer, ByVal KayitTarihi As DateTime, ByVal DegisimTarihi As DateTime, ByVal Sure As Int64, ByVal Aciklama As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    aEmirKasiyerStokFiyat SET              Kod = '" & Kod & "', Adi = '" & Adi & "', Tarih = '" & Tarih & "', BelgeNo = '" & BelgeNo & "', FisNo = '" & FisNo & "', MusteriNo = " & MusteriNo & " , MusteriKodu = '" & MusteriKodu & "', MusteriAdi = '" & MusteriAdi & "',SaticiNo = '" & SaticiNo & "', Satici = '" & Satici & "', StokNo = " & StokNo & "', StokKodu = '" & StokKodu & "', Malincinsi = '" & Malincinsi & "', Barcode = '" & Barcode & "', FiyatTipi = '" & FiyatTipi & "', eFiyat = " & eFiyat & ", yFiyat = " & yFiyat & ", Sonuc = '" & Sonuc & "', Status = " & Status & " , DegisimTarihi = GETDATE(), Sure = " & Sure & " , Aciklama = '" & Aciklama & "' WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt2(ByVal ind As Int64, ByVal sonuc As String, ByVal status As Integer, ByVal aciklama As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    aEmirKasiyerStokFiyat SET              Sonuc = '" & sonuc & "', Status = " & status & ", Aciklama = '" & aciklama & "',DegisimTarihi = getdate() WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub sil(ByVal ind As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM APERSONELDEPT WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kaydet()
        kontrol_kaydet()
    End Sub
    Private Sub kontrol_kaydet()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(sure & Sorgu_sDil(" Sn Süre Ýçerisinde Ýþleminizi Bitirmeniz Gerekmektedir...", sDil) & vbCrLf & Sorgu_sDil("Ýþleme Devam Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                For Each dr In DataSet1.Tables(0).Rows
                    dr("IND") = ekle(dr("Kod").ToString, dr("Adi").ToString, dr("Tarih"), dr("BelgeNo").ToString, dr("FisNo").ToString, dr("MusteriNo").ToString, dr("MusteriKodu").ToString, dr("MusteriAdi").ToString, dr("SaticiNo").ToString, dr("Satici").ToString, dr("StokNo"), dr("StokKodu").ToString, dr("Malincinsi").ToString, dr("Barcode").ToString, dr("FiyatTipi").ToString, dr("eFiyat"), dr("yFiyat"), dr("Sonuc").ToString, 0, Now, Now, sure, "")
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("yFiyat"))
                Next
                Me.Hide()
                Timer1.Enabled = True
            End If
        End If
    End Sub
    Private Sub kaydet_2()
        kontrol_2()
    End Sub
    Private Sub kontrol()
        Dim kontrol = sorgu_stok_kontrol(txt_stok_kod.EditValue)
        If kontrol = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            stokno = 0
            stokkodu = ""
            malincinsi = ""
            barcode = ""
            txt_stok_kod.Focus()
            txt_stok_kod.SelectAll()
        ElseIf kontrol = 1 Then
            dataload_stok(txt_stok_kod.EditValue)
            For Each dr In ds_stok.Tables(0).Rows
                txt_stok.EditValue = dr("Malincinsi")
                stokkodu = (dr("StokKodu"))
                stokno = dr("STOKNO")
                barcode = dr("Barcode")
                malincinsi = dr("Malincinsi")
            Next
            Try
                If XtraMessageBox.Show(Sorgu_sDil(" 60 Sn Süre Ýçerisinde Ýþleminizi Bitirmeniz Gerekmektedir..." & vbCrLf & "Ýþleme Devam Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    ekle(kasiyerno, kasiyer, txt_tarih.EditValue, txt_belgeno.EditValue, txt_fisno.EditValue, musterino, txt_MusteriNo.EditValue, txt_Musteri.EditValue, sec_satici.EditValue, sec_satici.Text, stokno, stokkodu, malincinsi, barcode, sec_fiyattipi.EditValue, txt_eFiyat.EditValue, txt_yFiyat.EditValue, "Bekliyor...", 0, Now, Now, 60, "")
                    duzelt_fiyat(stokno, sec_fiyattipi.EditValue, txt_yFiyat.EditValue)
                    GroupControl1.Enabled = False
                    GroupControl2.Enabled = False
                    GroupControl3.Enabled = False
                    SimpleButton2.Enabled = False
                    Me.Hide()
                    Timer1.Enabled = True
                End If
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Bilgileri Kontrol Ederek Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
    Private Sub kontrol_2()
        Dim kontrol = sorgu_stok_kontrol(txt_stok_kod.EditValue)
        If kontrol = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            stokno = 0
            stokkodu = ""
            malincinsi = ""
            barcode = ""
            txt_stok_kod.Focus()
            txt_stok_kod.SelectAll()
        ElseIf kontrol = 1 Then
            dataload_stok(txt_stok_kod.EditValue)
            For Each dr In ds_stok.Tables(0).Rows
                txt_stok.EditValue = dr("Malincinsi")
                stokkodu = (dr("StokKodu"))
                stokno = dr("STOKNO")
                barcode = dr("Barcode")
                malincinsi = dr("Malincinsi")
            Next
            satir_ekle(kasiyerno, kasiyer, txt_tarih.EditValue, txt_belgeno.EditValue, txt_fisno.EditValue, musterino, txt_MusteriNo.EditValue, txt_Musteri.EditValue, sec_satici.EditValue, sec_satici.Text, stokno, stokkodu, malincinsi, barcode, sec_fiyattipi.EditValue, txt_eFiyat.EditValue, txt_yFiyat.EditValue, "Bekliyor...", 0, Now, Now, 60, "")
            txt_stok_kod.EditValue = ""
            txt_stok.EditValue = ""
            sec_fiyattipi.ItemIndex = -1
            txt_eFiyat.EditValue = 0
            txt_yFiyat.EditValue = 0
            stokno = 0
            stokkodu = ""
            barcode = ""
            malincinsi = ""
            txt_stok_kod.Focus()
            txt_stok_kod.SelectAll()
        End If
    End Sub
    Private Sub satir_ekle(ByVal Kod As String, ByVal Adi As String, ByVal Tarih As DateTime, ByVal BelgeNo As String, ByVal FisNo As String, ByVal MusteriNo As Int64, ByVal MusteriKodu As String, ByVal MusteriAdi As String, ByVal SaticiNo As String, ByVal Satici As String, ByVal StokNo As Int64, ByVal StokKodu As String, ByVal Malincinsi As String, ByVal Barcode As String, ByVal FiyatTipi As String, ByVal eFiyat As Decimal, ByVal yFiyat As Decimal, ByVal Sonuc As String, ByVal Status As Integer, ByVal KayitTarihi As DateTime, ByVal DegisimTarihi As DateTime, ByVal Sure As Int64, ByVal Aciklama As String)
        Dim dr As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Kod") = Kod
        dr("Adi") = Adi
        dr("Tarih") = Tarih
        dr("BelgeNo") = BelgeNo
        dr("FisNo") = FisNo
        dr("MusteriNo") = MusteriNo
        dr("MusteriKodu") = MusteriKodu
        dr("MusteriAdi") = MusteriAdi
        dr("SaticiNo") = SaticiNo
        dr("Satici") = Satici
        dr("StokNo") = StokNo
        dr("StokKodu") = StokKodu
        dr("Malincinsi") = Malincinsi
        dr("Barcode") = Barcode
        dr("FiyatTipi") = FiyatTipi
        dr("eFiyat") = eFiyat
        dr("yFiyat") = yFiyat
        dr("Sonuc") = Sonuc
        dr("Status") = Status
        dr("KayitTarihi") = KayitTarihi
        dr("DegisimTarihi") = DegisimTarihi
        dr("Sure") = Sure
        dr("Aciklama") = Aciklama
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub kaydet_degistir()
        Try
            duzelt2(belgeind, Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
            duzelt_fiyat(stokno, sec_fiyattipi.EditValue, txt_eFiyat.EditValue)
            status = True
            Me.Show()
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Deðiþiklik Esnasýnda Bir Hata Oluþtu Fiyatlarý Kontrol Etmeyi Unutmayýnýz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try
    End Sub
    Private Sub kontrol_kaydet_degistir()
        If GridView1.RowCount > 0 Then
            For Each dr In DataSet1.Tables(0).Rows
                Try
                    duzelt2(dr("IND"), Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("eFiyat"))
                    'status = True
                    'Me.Show()
                    'Me.Close()
                Catch ex As Exception
                    'MsgBox(Sorgu_sDil("Deðiþiklik Esnasýnda Bir Hata Oluþtu Fiyatlarý Kontrol Etmeyi Unutmayýnýz...!",sDil), MessageBoxIcon.Warning)
                    'Me.Close()
                End Try
            Next
            status = True
            Me.Show()
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If GridView1.RowCount <> 0 Then
            sure = txt_sure.EditValue * 60
            kaydet()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Stok Bilgilerini Giriniz..! Eklenmiþ Kayýt Bulunamamaktadýr...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_stok_kod.Focus()
            txt_stok_kod.SelectAll()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If sayi <= sure Then
            bar.Position += 1
            sayi += 1
            bar.Refresh()
        Else
            Timer1.Enabled = False
            kontrol_kaydet_degistir()
        End If
    End Sub
    Private Sub txt_yFiyat_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_yFiyat.Validated
        If Trim(kasiyerno) = "VC" Then
        ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
        Else
            If txt_yFiyat.EditValue < txt_eFiyat.EditValue Then
                XtraMessageBox.Show(Sorgu_sDil("Düþük Fiyat Girme Yetkiniz Yok..!", sDil) & vbCrLf & Sorgu_sDil("Lütfen Tekrar Deneyiniz...", sDil))
                txt_yFiyat.Focus()
                txt_yFiyat.SelectAll()
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        kaydet_2()
    End Sub
    Private Sub sec_fiyattipi_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sec_fiyattipi.DragOver
    End Sub
    Private Sub stok_sec()
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_stok_kod.EditValue = Trim(dr1("sKodu"))
            dr1 = Nothing
        End If
        frm.Close()
        frm.Dispose()
        stok_kontrol()
    End Sub
    Private Sub txt_stok_kod_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_stok_kod.ButtonPressed
        'stok_sec()
    End Sub
    Private Sub txt_stok_kod_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_stok_kod.ButtonClick
        stok_sec()
    End Sub
    Private Sub txt_stok_kod_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_stok_kod.Validated
        stok_kontrol()
    End Sub
End Class
