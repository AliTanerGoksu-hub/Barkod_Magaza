Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports System.Net.Mail
Imports System.Net
Public Class frm_emir_ajanda_gorev
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_personel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents sec_hatirlat_zaman As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_hatirlat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_hergun As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_saat_bitis As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txt_saat_baslama As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txt_tarih_bitis As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_tarih_baslama As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_pb As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sec_tamamlandi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_gelecek As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_odendi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_tutar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_hesap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_hesapno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_yer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_konu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ds_hesap_tipi As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents sec_hesaptipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERSONELADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_ajanda_gorev))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_aciklama = New DevExpress.XtraEditors.MemoEdit()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERSONELADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sec_hesaptipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.sec_hatirlat_zaman = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_hatirlat = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_hergun = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_saat_bitis = New DevExpress.XtraEditors.TimeEdit()
        Me.txt_saat_baslama = New DevExpress.XtraEditors.TimeEdit()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tarih_bitis = New DevExpress.XtraEditors.DateEdit()
        Me.txt_tarih_baslama = New DevExpress.XtraEditors.DateEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pb = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_tamamlandi = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_gelecek = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_odendi = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_tutar = New DevExpress.XtraEditors.CalcEdit()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_hesap = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_hesapno = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_yer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_konu = New DevExpress.XtraEditors.TextEdit()
        Me.sec_personel = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.ds_hesap_tipi = New System.Data.DataSet()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_hesaptipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_hatirlat_zaman.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_hatirlat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_hergun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_saat_bitis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_saat_baslama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih_bitis.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih_bitis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih_baslama.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih_baslama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tamamlandi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_gelecek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_odendi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_hesap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_hesapno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_yer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_konu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_personel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hesap_tipi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(826, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(503, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(321, 11)
        Me.lbl_istihbarat.TabIndex = 12
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 11)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ajanda Görev Taným Bilgileri Aþaðýdadýr."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 391)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(826, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = Global.business_smart.My.Resources.Resources.barcode1
        Me.SimpleButton6.Location = New System.Drawing.Point(296, 8)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton6.TabIndex = 14
        Me.SimpleButton6.Text = "Etiket Yazdýr"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = Global.business_smart.My.Resources.Resources.nav_right_blue
        Me.SimpleButton5.Location = New System.Drawing.Point(200, 8)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton5.TabIndex = 13
        Me.SimpleButton5.Text = "Mail Gönder"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(104, 8)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton4.TabIndex = 12
        Me.SimpleButton4.Text = "Takip Emri"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 8)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "&Müþteri"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(730, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(650, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(826, 335)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_aciklama)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 192)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(812, 136)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Açýklama"
        '
        'txt_aciklama
        '
        Me.txt_aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Description", True))
        Me.txt_aciklama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aciklama.Location = New System.Drawing.Point(2, 21)
        Me.txt_aciklama.Name = "txt_aciklama"
        Me.txt_aciklama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_aciklama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_aciklama.Properties.Appearance.Options.UseBackColor = True
        Me.txt_aciklama.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama.Properties.Appearance.Options.UseForeColor = True
        Me.txt_aciklama.Size = New System.Drawing.Size(808, 113)
        Me.txt_aciklama.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ID"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FirmaTipi"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "FirmaNo"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "PersonelNo"
        Me.DataColumn6.DataType = GetType(Long)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Status"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Subject"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Description"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Label"
        Me.DataColumn10.DataType = GetType(Long)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "StartTime"
        Me.DataColumn11.DataType = GetType(Date)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "EndTime"
        Me.DataColumn12.DataType = GetType(Date)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Location"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "AllDay"
        Me.DataColumn14.DataType = GetType(Boolean)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "EventType"
        Me.DataColumn15.DataType = GetType(Long)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "RecurrenceInfo"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "ReminderInfo"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Tutar"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Pb"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Odendi"
        Me.DataColumn20.DataType = GetType(Boolean)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Tamamlandi"
        Me.DataColumn21.DataType = GetType(Boolean)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Gelecekmi"
        Me.DataColumn22.DataType = GetType(Boolean)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Firma"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sHatirlat"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Controls.Add(Me.sec_hesaptipi)
        Me.GroupControl1.Controls.Add(Me.sec_hatirlat_zaman)
        Me.GroupControl1.Controls.Add(Me.sec_hatirlat)
        Me.GroupControl1.Controls.Add(Me.sec_hergun)
        Me.GroupControl1.Controls.Add(Me.txt_saat_bitis)
        Me.GroupControl1.Controls.Add(Me.txt_saat_baslama)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txt_tarih_bitis)
        Me.GroupControl1.Controls.Add(Me.txt_tarih_baslama)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.txt_pb)
        Me.GroupControl1.Controls.Add(Me.sec_tamamlandi)
        Me.GroupControl1.Controls.Add(Me.sec_gelecek)
        Me.GroupControl1.Controls.Add(Me.sec_odendi)
        Me.GroupControl1.Controls.Add(Me.txt_tutar)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txt_hesap)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txt_hesapno)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txt_yer)
        Me.GroupControl1.Controls.Add(Me.txt_konu)
        Me.GroupControl1.Controls.Add(Me.sec_personel)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(812, 184)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Görev Tanýmý"
        '
        'LabelControl1
        '
        Me.LabelControl1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "Table1.sHatirlat", True))
        Me.LabelControl1.Location = New System.Drawing.Point(416, 139)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "*"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GridControl1.Location = New System.Drawing.Point(582, 21)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(228, 161)
        Me.GridControl1.TabIndex = 26
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colIND, Me.colPERSONELADI, Me.colsDepo})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colSEC
        '
        Me.colSEC.Caption = "SEC"
        Me.colSEC.FieldName = "SEC"
        Me.colSEC.Name = "colSEC"
        Me.colSEC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SEC", "{0}")})
        Me.colSEC.Visible = True
        Me.colSEC.VisibleIndex = 0
        Me.colSEC.Width = 29
        '
        'colIND
        '
        Me.colIND.Caption = "No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.OptionsColumn.AllowFocus = False
        Me.colIND.Visible = True
        Me.colIND.VisibleIndex = 1
        Me.colIND.Width = 25
        '
        'colPERSONELADI
        '
        Me.colPERSONELADI.Caption = "Personel"
        Me.colPERSONELADI.FieldName = "ACIKLAMA"
        Me.colPERSONELADI.Name = "colPERSONELADI"
        Me.colPERSONELADI.OptionsColumn.AllowFocus = False
        Me.colPERSONELADI.Visible = True
        Me.colPERSONELADI.VisibleIndex = 3
        Me.colPERSONELADI.Width = 135
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.OptionsColumn.AllowFocus = False
        Me.colsDepo.Visible = True
        Me.colsDepo.VisibleIndex = 2
        Me.colsDepo.Width = 37
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'sec_hesaptipi
        '
        Me.sec_hesaptipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FirmaTipi", True))
        Me.sec_hesaptipi.EnterMoveNextControl = True
        Me.sec_hesaptipi.Location = New System.Drawing.Point(80, 88)
        Me.sec_hesaptipi.Name = "sec_hesaptipi"
        Me.sec_hesaptipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_hesaptipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_hesaptipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_hesaptipi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_hesaptipi.Properties.DataSource = Me.DataTable1
        Me.sec_hesaptipi.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_hesaptipi.Properties.NullText = "[HesapTipleri]"
        Me.sec_hesaptipi.Properties.ShowFooter = False
        Me.sec_hesaptipi.Properties.ShowHeader = False
        Me.sec_hesaptipi.Properties.ValueMember = "IND"
        Me.sec_hesaptipi.Size = New System.Drawing.Size(96, 20)
        Me.sec_hesaptipi.TabIndex = 3
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ACIKLAMA"
        '
        'sec_hatirlat_zaman
        '
        Me.sec_hatirlat_zaman.EditValue = "10 Dakika"
        Me.sec_hatirlat_zaman.EnterMoveNextControl = True
        Me.sec_hatirlat_zaman.Location = New System.Drawing.Point(416, 154)
        Me.sec_hatirlat_zaman.Name = "sec_hatirlat_zaman"
        Me.sec_hatirlat_zaman.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_hatirlat_zaman.Properties.Appearance.Options.UseBackColor = True
        Me.sec_hatirlat_zaman.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_hatirlat_zaman.Properties.Items.AddRange(New Object() {"0 Dakika", "5 Dakita", "10 Dakika", "15 Dakika", "30 Dakika", "1 Saat", "2 Saat", "3 Saat", "4 Saat", "5 Saat", "6 Saat", "7 Saat", "8 Saat", "9 Saat", "10 Saat", "11 Saat", "1 Gün", "2 Gün", "3 Gün", "4 Gün", "1 Hafta", "2 Hafta", ""})
        Me.sec_hatirlat_zaman.Size = New System.Drawing.Size(160, 20)
        Me.sec_hatirlat_zaman.TabIndex = 17
        '
        'sec_hatirlat
        '
        Me.sec_hatirlat.EditValue = True
        Me.sec_hatirlat.Location = New System.Drawing.Point(336, 156)
        Me.sec_hatirlat.Name = "sec_hatirlat"
        Me.sec_hatirlat.Properties.Caption = "Hatýrlat?"
        Me.sec_hatirlat.Size = New System.Drawing.Size(75, 19)
        Me.sec_hatirlat.TabIndex = 16
        '
        'sec_hergun
        '
        Me.sec_hergun.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.AllDay", True))
        Me.sec_hergun.Location = New System.Drawing.Point(336, 133)
        Me.sec_hergun.Name = "sec_hergun"
        Me.sec_hergun.Properties.Caption = "Her Gün?"
        Me.sec_hergun.Size = New System.Drawing.Size(75, 19)
        Me.sec_hergun.TabIndex = 13
        '
        'txt_saat_bitis
        '
        Me.txt_saat_bitis.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.EndTime", True))
        Me.txt_saat_bitis.EditValue = New Date(2007, 4, 16, 0, 0, 0, 0)
        Me.txt_saat_bitis.EnterMoveNextControl = True
        Me.txt_saat_bitis.Location = New System.Drawing.Point(232, 154)
        Me.txt_saat_bitis.Name = "txt_saat_bitis"
        Me.txt_saat_bitis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_saat_bitis.Size = New System.Drawing.Size(104, 20)
        Me.txt_saat_bitis.TabIndex = 15
        '
        'txt_saat_baslama
        '
        Me.txt_saat_baslama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.StartTime", True))
        Me.txt_saat_baslama.EditValue = New Date(2007, 4, 16, 0, 0, 0, 0)
        Me.txt_saat_baslama.EnterMoveNextControl = True
        Me.txt_saat_baslama.Location = New System.Drawing.Point(232, 132)
        Me.txt_saat_baslama.Name = "txt_saat_baslama"
        Me.txt_saat_baslama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_saat_baslama.Size = New System.Drawing.Size(104, 20)
        Me.txt_saat_baslama.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(176, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Saat :"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(176, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Saat :"
        '
        'txt_tarih_bitis
        '
        Me.txt_tarih_bitis.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.EndTime", True))
        Me.txt_tarih_bitis.EditValue = Nothing
        Me.txt_tarih_bitis.EnterMoveNextControl = True
        Me.txt_tarih_bitis.Location = New System.Drawing.Point(80, 154)
        Me.txt_tarih_bitis.Name = "txt_tarih_bitis"
        Me.txt_tarih_bitis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tarih_bitis.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_tarih_bitis.Size = New System.Drawing.Size(96, 20)
        Me.txt_tarih_bitis.TabIndex = 14
        '
        'txt_tarih_baslama
        '
        Me.txt_tarih_baslama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.StartTime", True))
        Me.txt_tarih_baslama.EditValue = Nothing
        Me.txt_tarih_baslama.EnterMoveNextControl = True
        Me.txt_tarih_baslama.Location = New System.Drawing.Point(80, 132)
        Me.txt_tarih_baslama.Name = "txt_tarih_baslama"
        Me.txt_tarih_baslama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tarih_baslama.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_tarih_baslama.Size = New System.Drawing.Size(96, 20)
        Me.txt_tarih_baslama.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Bitiþ :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Baþlangýç :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(176, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Pb :"
        '
        'txt_pb
        '
        Me.txt_pb.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Pb", True))
        Me.txt_pb.EnterMoveNextControl = True
        Me.txt_pb.Location = New System.Drawing.Point(232, 110)
        Me.txt_pb.Name = "txt_pb"
        Me.txt_pb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pb.Properties.Appearance.Options.UseBackColor = True
        Me.txt_pb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_pb.Size = New System.Drawing.Size(104, 20)
        Me.txt_pb.TabIndex = 7
        '
        'sec_tamamlandi
        '
        Me.sec_tamamlandi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Tamamlandi", True))
        Me.sec_tamamlandi.Location = New System.Drawing.Point(493, 110)
        Me.sec_tamamlandi.Name = "sec_tamamlandi"
        Me.sec_tamamlandi.Properties.Caption = "Tamamlandý?"
        Me.sec_tamamlandi.Size = New System.Drawing.Size(83, 19)
        Me.sec_tamamlandi.TabIndex = 10
        '
        'sec_gelecek
        '
        Me.sec_gelecek.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Gelecekmi", True))
        Me.sec_gelecek.Location = New System.Drawing.Point(408, 110)
        Me.sec_gelecek.Name = "sec_gelecek"
        Me.sec_gelecek.Properties.Caption = "Gelecek mi?"
        Me.sec_gelecek.Size = New System.Drawing.Size(78, 19)
        Me.sec_gelecek.TabIndex = 8
        '
        'sec_odendi
        '
        Me.sec_odendi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Odendi", True))
        Me.sec_odendi.Location = New System.Drawing.Point(336, 110)
        Me.sec_odendi.Name = "sec_odendi"
        Me.sec_odendi.Properties.Caption = "Ödendi?"
        Me.sec_odendi.Size = New System.Drawing.Size(62, 19)
        Me.sec_odendi.TabIndex = 9
        '
        'txt_tutar
        '
        Me.txt_tutar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Tutar", True))
        Me.txt_tutar.EnterMoveNextControl = True
        Me.txt_tutar.Location = New System.Drawing.Point(80, 110)
        Me.txt_tutar.Name = "txt_tutar"
        Me.txt_tutar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tutar.Properties.Appearance.Options.UseBackColor = True
        Me.txt_tutar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tutar.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_tutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tutar.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_tutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tutar.Properties.NullText = "0"
        Me.txt_tutar.Size = New System.Drawing.Size(96, 20)
        Me.txt_tutar.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tutar :"
        '
        'txt_hesap
        '
        Me.txt_hesap.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Firma", True))
        Me.txt_hesap.EnterMoveNextControl = True
        Me.txt_hesap.Location = New System.Drawing.Point(336, 88)
        Me.txt_hesap.Name = "txt_hesap"
        Me.txt_hesap.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_hesap.Properties.Appearance.Options.UseBackColor = True
        Me.txt_hesap.Size = New System.Drawing.Size(240, 20)
        Me.txt_hesap.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(176, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "HesapNo :"
        '
        'txt_hesapno
        '
        Me.txt_hesapno.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FirmaNo", True))
        Me.txt_hesapno.Enabled = False
        Me.txt_hesapno.EnterMoveNextControl = True
        Me.txt_hesapno.Location = New System.Drawing.Point(232, 88)
        Me.txt_hesapno.Name = "txt_hesapno"
        Me.txt_hesapno.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_hesapno.Properties.Appearance.Options.UseBackColor = True
        Me.txt_hesapno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_hesapno.Size = New System.Drawing.Size(104, 20)
        Me.txt_hesapno.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hesap : "
        '
        'txt_yer
        '
        Me.txt_yer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Location", True))
        Me.txt_yer.EnterMoveNextControl = True
        Me.txt_yer.Location = New System.Drawing.Point(80, 66)
        Me.txt_yer.Name = "txt_yer"
        Me.txt_yer.Size = New System.Drawing.Size(496, 20)
        Me.txt_yer.TabIndex = 2
        '
        'txt_konu
        '
        Me.txt_konu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Subject", True))
        Me.txt_konu.EnterMoveNextControl = True
        Me.txt_konu.Location = New System.Drawing.Point(80, 44)
        Me.txt_konu.Name = "txt_konu"
        Me.txt_konu.Size = New System.Drawing.Size(496, 20)
        Me.txt_konu.TabIndex = 1
        '
        'sec_personel
        '
        Me.sec_personel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.PersonelNo", True))
        Me.sec_personel.EnterMoveNextControl = True
        Me.sec_personel.Location = New System.Drawing.Point(80, 22)
        Me.sec_personel.Name = "sec_personel"
        Me.sec_personel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_personel.Properties.Appearance.Options.UseBackColor = True
        Me.sec_personel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_personel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Personeller")})
        Me.sec_personel.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_personel.Properties.NullText = "[Personeller]"
        Me.sec_personel.Properties.ShowFooter = False
        Me.sec_personel.Properties.ShowHeader = False
        Me.sec_personel.Properties.ValueMember = "IND"
        Me.sec_personel.Size = New System.Drawing.Size(200, 20)
        Me.sec_personel.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Personel :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Yer :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Konu :"
        '
        'ds_hesap_tipi
        '
        Me.ds_hesap_tipi.DataSetName = "NewDataSet"
        Me.ds_hesap_tipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hesap_tipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'frm_emir_ajanda_gorev
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(826, 431)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_emir_ajanda_gorev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Görev Takip Tanýmý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_hesaptipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_hatirlat_zaman.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_hatirlat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_hergun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_saat_bitis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_saat_baslama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih_bitis.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih_bitis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih_baslama.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih_baslama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tamamlandi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_gelecek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_odendi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_hesap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_hesapno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_yer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_konu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_personel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hesap_tipi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public kayitno
    Public connection
    Public kullanici
    Public kasiyer
    Public kasiyerno
    Dim ds_kasiyer As DataSet
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    Private Sub frm_emir_ajanda_gorev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_tarih_baslama.EditValue = dteSistemTarihi
        txt_tarih_bitis.EditValue = dteSistemTarihi
        txt_saat_baslama.EditValue = Now
        txt_saat_bitis.EditValue = Now
        dataload_kasiyer()
        dataload_hesaptipleri()
        If status = True Then
            dataload()
            'Dim dr As DataRow = DataSet1.Tables(0).Rows(0)
            'sec_personel.EditValue = dr("PersonelNo")
            'dr = Nothing
            analiz_musteri_istihbarat()
            If Trim(LabelControl1.Text.ToString) = "" Then
                sec_hatirlat.Checked = False
                sec_hatirlat_zaman.Text = "0 Dakika"
            ElseIf Trim(LabelControl1.Text.ToString) = "00:05:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "5 Dakika"
            ElseIf Trim(LabelControl1.Text.ToString) = "00:10:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "10 Dakika"
            ElseIf Trim(LabelControl1.Text.ToString) = "00:15:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "15 Dakika"
            ElseIf Trim(LabelControl1.Text.ToString) = "00:30:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "30 Dakika"
            ElseIf Trim(LabelControl1.Text.ToString) = "01:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "1 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "02:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "2 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "03:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "3 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "04:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "4 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "05:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "5 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "06:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "6 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "07:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "7 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "08:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "8 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "09:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "9 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "10:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "10 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "11:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "11 Saat"
            ElseIf Trim(LabelControl1.Text.ToString) = "12:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "1 Gün"
            ElseIf Trim(LabelControl1.Text.ToString) = "24:00:00" Then
                sec_hatirlat.Checked = True
                sec_hatirlat_zaman.Text = "2 Gün"
            End If
        End If
        If status = False Then
            If txt_hesapno.Text = 0 Then
                sec_hesaptipi.ItemIndex = 0
            Else
            End If
        End If
        dataload_kasiyer()
        txt_konu.Focus()
        txt_konu.Select()
    End Sub
    Private Sub dataload()
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,SUBSTRING(ReminderInfo, 71, 8) AS sHatirlat From aEmirAjanda WHERE ID =" & kayitno & "")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
    End Sub
    Private Sub dataload_hesaptipleri()
        Dim dr As DataRow = ds_hesap_tipi.Tables(0).NewRow
        dr("IND") = 0
        dr("ACIKLAMA") = "Diðer"
        ds_hesap_tipi.Tables(0).Rows.Add(dr)
        dr = ds_hesap_tipi.Tables(0).NewRow
        dr("IND") = 1
        dr("ACIKLAMA") = "Müþteri"
        ds_hesap_tipi.Tables(0).Rows.Add(dr)
        dr = ds_hesap_tipi.Tables(0).NewRow
        dr("IND") = 2
        dr("ACIKLAMA") = "Firma"
        ds_hesap_tipi.Tables(0).Rows.Add(dr)
        dr = ds_hesap_tipi.Tables(0).NewRow
        dr("IND") = 3
        dr("ACIKLAMA") = "Stok"
        ds_hesap_tipi.Tables(0).Rows.Add(dr)
        dr = Nothing
    End Sub
    Private Sub analiz_musteri_karti()
        If txt_hesapno.Text <> "" Then
            Dim nMusteriID = txt_hesapno.Text 'analiz_musteri_kayitno(Trim(txt_hesapno.Text))
            If nMusteriID > 0 Then
                Dim frm As New frm_musteri_karti
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.musterino = txt_hesapno.Text
                frm.musteriID = txt_hesapno.Text
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
    Private Sub analiz_firma_karti()
        If txt_hesapno.Text <> "" Then
            Dim nMusteriID = txt_hesapno.Text 'analiz_musteri_kayitno(Trim(txt_hesapno.Text))
            If nMusteriID > 0 Then
                Dim frm As New frm_cari_yonetimi
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.sKodu = analiz_firma_sKodu(txt_hesapno.Text)
                frm.txt_sKodu.Text = frm.sKodu
                frm.nFirmaID = txt_hesapno.Text
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
    Private Sub analiz_stok_karti()
        If txt_hesapno.Text <> "" Then
            Dim nStokID As Int64 = txt_hesapno.Text
            If nStokID <> 0 Then
                Dim frm As New frm_stok_kart
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.nStokID = txt_hesapno.Text
                frm.sKodu = analiz_stok_sKodu(txt_hesapno.Text, False)
                frm.sModel = analiz_stok_sKodu(txt_hesapno.Text, True)
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
    Private Function analiz_musteri_kayitno(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nMusteriID,0) AS IND FROM         tbMusteri " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
    End Function
    Private Function analiz_firma_sKodu(ByVal nFirmaID As String) As String
        Dim kriter
        kriter = "WHERE (nFirmaID = '" & nFirmaID & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As String
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sKodu,0) AS sKodu FROM         tbFirma " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
    End Function
    Private Function analiz_stok_sKodu(ByVal nStokID As String, Optional ByVal sModel As Boolean = False) As String
        Dim kriter As String = ""
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As String
        If sModel = False Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sKodu,0) AS sKodu FROM         tbStok " & kriter & "")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sModel,0) AS sKodu FROM         tbStok " & kriter & "")
        End If
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST('0' as bit) AS SEC,'0' AS IND, '[Tümü]' AS sDepo,'[Tümü]' AS ACIKLAMA, '1111' AS SIFRE,'' REFADI FROM APERSONEL UNION SELECT CAST('0' as bit) AS SEC,IND, sDepo,PERSONELADI AS ACIKLAMA, SIFRE,REFADI FROM APERSONEL "))
        sec_personel.Properties.DataSource = ds_kasiyer.Tables(0)
        GridControl1.DataSource = ds_kasiyer.Tables(0)
        GridControl1.DataMember = Nothing
        If status = False Then
            sec_personel.EditValue = kasiyerno
            sec_personel.Text = kasiyer
            sec_personel.ItemIndex = 1
            GridControl1.Visible = True
        Else
            GridControl1.Visible = False
        End If
        'sec_personel.Refresh()
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
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'MsgBox(txt_saat_baslama.Text)
        'MsgBox(txt_saat_bitis.Text)
        kontrol()
    End Sub
    Private Sub mail_gonder(ByVal sMail As String)
        If sMail = "" Then
            XtraMessageBox.Show(Sorgu_sDil("Mail Adresi Bulunamadý...!", sDil), Sorgu_sDil("Dikkat", sDil))
        Else
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim smtpServer As New SmtpClient()
            Using mail As New MailMessage()
                smtpServer.Credentials = New NetworkCredential("barkodsmart@gmail.com", "BusSmart159")
                smtpServer.Port = 587
                smtpServer.Host = "smtp.gmail.com"
                smtpServer.EnableSsl = True
                mail.From = New MailAddress("barkodsmart@gmail.com")
                mail.To.Add(sMail)
                mail.Subject = String.Format("Görev-{0}-{1}-{2}", sOnayKodu, kullaniciadi, txt_konu.Text)
                'mail.Body = String.Format("Mail:{0}{1}Kimden: {2}{1}Öncelik:  {3}{1}{1}{4}", txt_konu.Text, vbCrLf, kullaniciadi, txt_yer.Text, txt_aciklama.Text)
                mail.Body = "Kimden :" & kullaniciadi & vbCrLf & "Konu:" & txt_konu.Text & vbCrLf & "Yer: " & txt_yer.Text & vbCrLf & "HesapTipi: " & sec_hesaptipi.EditValue & " Hesap: " & txt_hesapno.Text & "\" & txt_hesap.Text & vbCrLf & "Tutar: " & txt_tutar.EditValue & vbCrLf & "Baþlangýç: " & txt_tarih_baslama.EditValue & " Bitiþ" & txt_tarih_bitis.EditValue & vbCrLf & vbCrLf & txt_aciklama.Text
                'If Trim(txt_sEklenti.Text) = "" Then
                'Else
                '    mail.Attachments.Add(New Attachment(txt_sEklenti.Text))
                'End If
                'mail.Body = "Bayii: " & lbl_Bayii.Text & vbCrLf & "Install Alan: " & txt_sSifreyiAlan.Text & vbCrLf & vbCrLf & "Müþteri:" & lbl_Firma.Text & vbCrLf & "OnayKodu: " & txt_sOnayKodu.Text & vbCrLf & "Ülke: " & txtCountry.Text & " Bölge: " & txtRegion.Text & " IP : " & txtCustomIPAddress.Text & vbCrLf & vbCrLf & "Bilgisayar ; " & vbCrLf & info_bilgisayar.ToString & vbCrLf & vbCrLf & "Ýþletim Sistemi;" & vbCrLf & info_sistem() & vbCrLf & "Parametre1: " & txt_sParametre1.Text & vbCrLf & "Paremetre2: " & txt_sParametre2.Text & vbCrLf & Now.ToLongDateString & " " & Now.ToLongTimeString
                Try
                    smtpServer.Send(mail)
                    'Label8.Text = "Mail Gönderildi..." & Now
                    'mail_gonder_bc()
                    XtraMessageBox.Show("Mailiniz Baþarýyla Gönderildi...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    'Label8.Text = "Mail Gönderilemedi..."
                    XtraMessageBox.Show(String.Format("Mail Gönderilemedi...!{0}Lütfen Daha Sonra Tekrar Deneyiniz...!", vbCrLf), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Private Sub kontrol()
        If status = False Then
            Dim dr As DataRow
            Dim sayi As Integer = 0
            For Each dr In ds_kasiyer.Tables(0).Rows
                If dr("SEC") = True Then
                    ekle(sec_hesaptipi.EditValue, txt_hesapno.EditValue, txt_hesap.EditValue, dr("IND"), 2, txt_konu.EditValue, txt_aciklama.EditValue, 0, Microsoft.VisualBasic.Left((txt_tarih_baslama.Text).ToString, 10) + " " + txt_saat_baslama.Text, Microsoft.VisualBasic.Left((txt_tarih_bitis.Text).ToString, 10) + " " + txt_saat_bitis.Text, txt_yer.EditValue, sec_hergun.Checked, 0, "", sec_hatirlat_zaman.Text, txt_tutar.EditValue, txt_pb.EditValue, sec_odendi.Checked, sec_gelecek.Checked, sec_tamamlandi.Checked)
                    sayi += 1
                End If
            Next
            If sayi = 0 Then
                ekle(sec_hesaptipi.EditValue, txt_hesapno.EditValue, txt_hesap.EditValue, sec_personel.EditValue, 2, txt_konu.EditValue, txt_aciklama.EditValue, 0, Microsoft.VisualBasic.Left((txt_tarih_baslama.Text).ToString, 10) + " " + txt_saat_baslama.Text, Microsoft.VisualBasic.Left((txt_tarih_bitis.Text).ToString, 10) + " " + txt_saat_bitis.Text, txt_yer.EditValue, sec_hergun.Checked, 0, "", sec_hatirlat_zaman.Text, txt_tutar.EditValue, txt_pb.EditValue, sec_odendi.Checked, sec_gelecek.Checked, sec_tamamlandi.Checked)
            End If
        Else
            duzelt(kayitno, sec_hesaptipi.EditValue, (txt_hesapno.EditValue).ToString, (txt_hesap.EditValue).ToString, sec_personel.EditValue, 2, (txt_konu.EditValue).ToString, (txt_aciklama.EditValue).ToString, 0, Microsoft.VisualBasic.Left((txt_tarih_baslama.Text).ToString, 10) + " " + (txt_saat_baslama.Text).ToString, Microsoft.VisualBasic.Left((txt_tarih_bitis.Text).ToString, 10) + " " + (txt_saat_bitis.Text).ToString, (txt_yer.EditValue).ToString, sec_hergun.Checked, 0, "", sec_hatirlat_zaman.Text, txt_tutar.EditValue, (txt_pb.EditValue).ToString, sec_odendi.Checked, sec_gelecek.Checked, sec_tamamlandi.Checked)
        End If
        Me.Close()
    End Sub
    Private Sub ekle(ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If sec_hatirlat.Checked = True Then
            If ReminderInfo = "0 Dakika" Then
                ReminderInfo = ""
            ElseIf ReminderInfo = "5 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:05:00""/></Reminders>"
            ElseIf ReminderInfo = "10 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:10:00""/></Reminders>"
            ElseIf ReminderInfo = "15 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:15:00""/></Reminders>"
            ElseIf ReminderInfo = "30 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:30:00""/></Reminders>"
            ElseIf ReminderInfo = "1 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""01:00:00""/></Reminders>"
            ElseIf ReminderInfo = "2 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""02:00:00""/></Reminders>"
            ElseIf ReminderInfo = "3 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""03:00:00""/></Reminders>"
            ElseIf ReminderInfo = "4 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""04:00:00""/></Reminders>"
            ElseIf ReminderInfo = "5 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""05:00:00""/></Reminders>"
            ElseIf ReminderInfo = "6 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""06:00:00""/></Reminders>"
            ElseIf ReminderInfo = "7 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""07:00:00""/></Reminders>"
            ElseIf ReminderInfo = "8 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""08:00:00""/></Reminders>"
            ElseIf ReminderInfo = "9 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""09:00:00""/></Reminders>"
            ElseIf ReminderInfo = "10 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""10:00:00""/></Reminders>"
            ElseIf ReminderInfo = "11 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""11:00:00""/></Reminders>"
            ElseIf ReminderInfo = "1 Gün" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""12:00:00""/></Reminders>"
            ElseIf ReminderInfo = "2 Gün" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""24:00:00""/></Reminders>"
            ElseIf ReminderInfo = "3 Gün" Then
            ElseIf ReminderInfo = "4 Gün" Then
            ElseIf ReminderInfo = "1 Gün" Then
            ElseIf ReminderInfo = "1 Hafta" Then
            ElseIf ReminderInfo = "2 Hafta" Then
            End If
        Else
            ReminderInfo = ""
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", '" & RecurrenceInfo & "','" & ReminderInfo & "', " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", NULL,'" & ReminderInfo & "', " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & ")")
        cmd.ExecuteNonQuery()
        conn.Close()
        
        ' Gorev bildirimi gonder
        Try
            If PersonelNo > 0 Then
                Dim bAcil As Boolean = False ' Acil gorev kontrolu eklenebilir
                BildirimServisi.GorevBildirimiGonder(0, CInt(PersonelNo), Subject, Description, bAcil)
            End If
        Catch ex As Exception
            Debug.WriteLine("Gorev bildirim hatasi: " & ex.Message)
        End Try
    End Sub
    Private Sub duzelt(ByVal ID As Int64, ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte)
        If sec_hatirlat.Checked = True Then
            If ReminderInfo = "0 Dakika" Then
                ReminderInfo = ""
            ElseIf ReminderInfo = "5 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:05:00""/></Reminders>"
            ElseIf ReminderInfo = "10 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:10:00""/></Reminders>"
            ElseIf ReminderInfo = "15 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:15:00""/></Reminders>"
            ElseIf ReminderInfo = "30 Dakika" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:30:00""/></Reminders>"
            ElseIf ReminderInfo = "1 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""01:00:00""/></Reminders>"
            ElseIf ReminderInfo = "2 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""02:00:00""/></Reminders>"
            ElseIf ReminderInfo = "3 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""03:00:00""/></Reminders>"
            ElseIf ReminderInfo = "4 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""04:00:00""/></Reminders>"
            ElseIf ReminderInfo = "5 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""05:00:00""/></Reminders>"
            ElseIf ReminderInfo = "6 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""06:00:00""/></Reminders>"
            ElseIf ReminderInfo = "7 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""07:00:00""/></Reminders>"
            ElseIf ReminderInfo = "8 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""08:00:00""/></Reminders>"
            ElseIf ReminderInfo = "9 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""09:00:00""/></Reminders>"
            ElseIf ReminderInfo = "10 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""10:00:00""/></Reminders>"
            ElseIf ReminderInfo = "11 Saat" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""11:00:00""/></Reminders>"
            ElseIf ReminderInfo = "1 Gün" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""12:00:00""/></Reminders>"
            ElseIf ReminderInfo = "2 Gün" Then
                ReminderInfo = "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, EndTime), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""24:00:00""/></Reminders>"
            ElseIf ReminderInfo = "3 Gün" Then
            ElseIf ReminderInfo = "4 Gün" Then
            ElseIf ReminderInfo = "1 Gün" Then
            ElseIf ReminderInfo = "1 Hafta" Then
            ElseIf ReminderInfo = "2 Hafta" Then
            End If
        Else
            ReminderInfo = ""
        End If
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirAjanda SET              FirmaTipi = " & FirmaTipi & ", FirmaNo = '" & FirmaNo & "', Firma = '" & Firma & "', PersonelNo = " & PersonelNo & ", Status = " & Status & ", Subject = '" & Subject & "', Description = '" & Description & "', StartTime = '" & StartTime & "', EndTime = '" & EndTime & "', Location = '" & Location & "', AllDay = " & AllDay & ", EventType = " & EventType & ", ReminderInfo = '" & ReminderInfo & "',  Tutar = " & Tutar & ", Pb = '" & Pb & "', Odendi = " & Odendi & ", Gelecekmi = " & Gelecekmi & ", Tamamlandi = " & Tamamlandi & " WHERE ID= '" & kayitno & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub sil(ByVal ID As Int64)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirAjanda  WHERE ID= '" & kayitno & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub musteri()
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = txt_hesapno.EditValue
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                'dr("FIRMAKODU") = Microsoft.VisualBasic.Left(dr1("lKodu"), 50)
                'dr("FIRMAADI") = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
                'dr("YETKILI") = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
                'dr("ADRES") = dr1("sEvAdresi")
                'dr("TELEFON") = dr1("sEvTelefonu")
                txt_hesapno.EditValue = Microsoft.VisualBasic.Left(Trim(dr1("nMusteriID")), 50)
                txt_hesap.EditValue = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
                analiz_musteri_istihbarat()
            End If
        End If
    End Sub
    Private Sub takip_emri()
        Dim dr As DataRow = DataSet1.Tables(0).Rows(0)
        If dr("MusteriTakipIND") > 0 Then
            Dim frm As New frm_emir_musteri_takip_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.kasiyer = kasiyer
            frm.kasiyerno = kasiyerno
            frm.connection = connection
            frm.kayitno = dr("MusteriTakipIND")
            frm.status = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Me.Close()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr = Nothing
    End Sub
    Private Sub analiz_musteri_istihbarat()
        If txt_hesapno.Text <> "" Then
            Dim nMusteriID = analiz_musteri_kayitno(Trim(txt_hesapno.Text))
            If nMusteriID > 0 Then
                lbl_istihbarat.Text = analiz_musteri_aciklamalar(Trim(txt_hesapno.Text)).ToString
            Else
                lbl_istihbarat.Text = ""
            End If
            nMusteriID = Nothing
        End If
    End Sub
    Private Function analiz_musteri_aciklamalar(ByVal kod As String) As String
        Dim kriter
        kriter = "WHERE (nMusteriID = '" & kod & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As String
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sAciklama1 + ' ' + sAciklama2 + ' ' + sAciklama3 + ' ' + sAciklama4 + ' ' + sAciklama5,'') AS ISTIHBARAT FROM         tbMusteri " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub firma()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = txt_hesapno.EditValue
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                ''dr_baslik("FIRMANO") = Trim(dr1("nFirmaID"))
                'dr("FIRMAKODU") = Microsoft.VisualBasic.Left(Trim(dr1("sKodu")), 50)
                txt_hesapno.EditValue = Microsoft.VisualBasic.Left(Trim(dr1("nFirmaID")), 50)
                txt_hesap.EditValue = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                'dr("FIRMAADI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                'dr("YETKILI") = ""
                'dr("ADRES") = Trim(dr1("Adres"))
                'dr("TELEFON") = ""
                'girdi_tutar_hesapla()
            End If
        End If
    End Sub
    Private Sub stok()
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokno = txt_hesapno.EditValue
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                ''dr_baslik("FIRMANO") = Trim(dr1("nFirmaID"))
                'dr("FIRMAKODU") = Microsoft.VisualBasic.Left(Trim(dr1("sKodu")), 50)
                txt_hesapno.EditValue = Microsoft.VisualBasic.Left(Trim(dr1("nStokID")), 50)
                txt_hesap.EditValue = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                'dr("FIRMAADI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                'dr("YETKILI") = ""
                'dr("ADRES") = Trim(dr1("Adres"))
                'dr("TELEFON") = ""
                'girdi_tutar_hesapla()
            End If
        End If
    End Sub
    Private Sub sec_hesaptipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_hesaptipi.EditValueChanged
        If sec_hesaptipi.EditValue = 0 Then
            txt_hesap.Enabled = True
            txt_hesapno.Enabled = False
            SimpleButton3.Enabled = False
        ElseIf sec_hesaptipi.EditValue = 1 Then
            txt_hesapno.Enabled = True
            txt_hesap.Enabled = False
            SimpleButton3.Enabled = True
        ElseIf sec_hesaptipi.EditValue = 2 Then
            txt_hesapno.Enabled = True
            txt_hesap.Enabled = False
            SimpleButton3.Enabled = True
            SimpleButton3.Text = "&Firma"
        ElseIf sec_hesaptipi.EditValue = 3 Then
            txt_hesapno.Enabled = True
            txt_hesap.Enabled = False
            SimpleButton3.Enabled = True
            SimpleButton3.Text = "&Stok"
        End If
    End Sub
    Private Sub txt_hesapno_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_hesapno.ButtonClick
        If sec_hesaptipi.EditValue = 0 Then
        ElseIf sec_hesaptipi.EditValue = 2 Then
            firma()
        ElseIf sec_hesaptipi.EditValue = 1 Then
            musteri()
        ElseIf sec_hesaptipi.EditValue = 3 Then
            stok()
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If sec_hesaptipi.EditValue = 0 Then
        ElseIf sec_hesaptipi.EditValue = 1 Then
            analiz_musteri_karti()
        ElseIf sec_hesaptipi.EditValue = 2 Then
            analiz_firma_karti()
        ElseIf sec_hesaptipi.EditValue = 3 Then
            analiz_stok_karti()
        End If
    End Sub
    Private Sub sec_hatirlat_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_hatirlat.CheckStateChanged
    End Sub
    Private Sub sec_hatirlat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_hatirlat.CheckedChanged
        If sec_hatirlat.Checked = True Then
            sec_hatirlat_zaman.Text = "10 Dakika"
        ElseIf sec_hatirlat.Checked = False Then
            sec_hatirlat_zaman.Text = "0 Dakika"
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        takip_emri()
    End Sub
    Private Sub frm_emir_ajanda_gorev_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'GroupControl1 = Nothing
        'Label2 = Nothing
        'Label3 = Nothing
        'Label4 = Nothing
        'Label5 = Nothing
        'Label6 = Nothing
        'Label7 = Nothing
        'Label8 = Nothing
        'Label9 = Nothing
        'Label10 = Nothing
        'Label11 = Nothing
        'Label12 = Nothing
        'GroupControl2 = Nothing
        'sec_personel = Nothing
        'txt_aciklama = Nothing
        'sec_hatirlat_zaman = Nothing
        'sec_hatirlat = Nothing
        'sec_hergun = Nothing
        'txt_saat_bitis = Nothing
        'txt_saat_baslama = Nothing
        'txt_tarih_bitis = Nothing
        'txt_tarih_baslama = Nothing
        'txt_pb = Nothing
        'sec_tamamlandi = Nothing
        'sec_gelecek = Nothing
        'sec_odendi = Nothing
        'txt_tutar = Nothing
        'txt_hesap = Nothing
        'txt_hesapno = Nothing
        'txt_yer = Nothing
        'txt_konu = Nothing
        'ds_hesap_tipi = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'sec_hesaptipi = Nothing
        'DataSet1.Clear()
        'DataSet1.Dispose()
        'DataSet1 = Nothing
        'DataTable2 = Nothing
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
        'DataColumn21 = Nothing
        'DataColumn22 = Nothing
        'DataColumn23 = Nothing
        'SimpleButton3 = Nothing
        'SimpleButton4 = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        mail_gonder(adres_bul(sec_personel.EditValue))
    End Sub
    Private Function adres_bul(ByVal IND As Int64) As String
        Dim dr As DataRow
        Dim adres As String = ""
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("IND") = IND Then
                adres = Trim(dr("REFADI"))
            End If
        Next
        Return adres
    End Function
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If sec_hesaptipi.EditValue = 3 Then
            If txt_hesapno.Text <> "" Then
                Dim nStokID As Int64 = txt_hesapno.Text
                If nStokID <> 0 Then
                    Dim frm As New frm_Stok_Etiket_Yazdir
                    frm.kullanici = kullanici
                    frm.connection = connection
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.txt_sAra.Text = analiz_stok_sKodu(txt_hesapno.Text, False)
                    frm.islem_status = True
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_hesapno_EditValueChanged(sender As Object, e As EventArgs) Handles txt_hesapno.EditValueChanged

    End Sub
End Class
