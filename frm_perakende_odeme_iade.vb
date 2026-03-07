Imports DevExpress.XtraEditors
Public Class frm_perakende_odeme_iade
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
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnOdemeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOdemeSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOdemeKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOdemeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMakbuzNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnTaksitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIadeAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbMuhasebeyeIslendimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKasaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTAHSILAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPesinat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsYaziIle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_borc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_odenen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_paraustu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ortvade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents ds_odeme As System.Data.DataSet
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
    Friend WithEvents sec_sOdemeSekli As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kisayol_odeme As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_secilen_sayi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colGECIKME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAZALT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNETKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents label2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perakende_odeme_iade))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colGECIKME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.kisayol_odeme = New System.Windows.Forms.ContextMenu
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.ds_odeme = New System.Data.DataSet
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnOdemeID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsOdemeSekli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sOdemeSekli = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colnOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteOdemeTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMakbuzNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOdemeNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnTaksitID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnIadeAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbMuhasebeyeIslendimi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKartNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_secilen = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_ortvade = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_paraustu = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_odenen = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_secilen_sayi = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_borc = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colkodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTAHSILAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collPesinat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsYaziIle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAZALT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNETKALAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colGECIKME
        '
        Me.colGECIKME.Caption = "Gün"
        Me.colGECIKME.FieldName = "GECIKME"
        Me.colGECIKME.Name = "colGECIKME"
        Me.colGECIKME.OptionsColumn.AllowFocus = False
        Me.colGECIKME.Visible = True
        Me.colGECIKME.VisibleIndex = 13
        Me.colGECIKME.Width = 64
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(776, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ödeme Ýþlemi Aþaðýdaki Gibi Yapýlmýþtýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 382)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(776, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'label2
        '
        Me.label2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.label2.Location = New System.Drawing.Point(96, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(18, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 8)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "&Yazdýr"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(696, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(616, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl6)
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(776, 326)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.GridControl2)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(2, 200)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(524, 124)
        Me.PanelControl6.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_odeme
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_odeme
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sOdemeSekli})
        Me.GridControl2.Size = New System.Drawing.Size(520, 120)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_odeme
        '
        Me.kisayol_odeme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem21, Me.MenuItem20})
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem17.Text = "Satýr Ekle"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Satýr Düzelt"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 2
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem19.Text = "Satýr Sil"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 3
        Me.MenuItem21.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 4
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem20.Text = "Taksitleri Seç"
        '
        'ds_odeme
        '
        Me.ds_odeme.DataSetName = "NewDataSet"
        Me.ds_odeme.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_odeme.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nOdemeID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "nAlisverisID"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sOdemeSekli"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "nOdemeKodu"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "dteOdemeTarihi"
        Me.DataColumn6.ColumnName = "dteOdemeTarihi"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "dteValorTarihi"
        Me.DataColumn7.DataType = GetType(Date)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lOdemeTutar"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sDovizCinsi"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "lDovizTutar"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lMakbuzNo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lOdemeNo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nTaksitID"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "nIadeAlisverisID"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nKasaNo"
        Me.DataColumn16.DataType = GetType(Long)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sKartNo"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sKullaniciAdi"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "dteKayitTarihi"
        Me.DataColumn19.DataType = GetType(Date)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sMagaza"
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnOdemeID, Me.colnAlisverisID, Me.colsOdemeSekli, Me.colnOdemeKodu, Me.colsKasiyerRumuzu, Me.coldteOdemeTarihi, Me.coldteValorTarihi, Me.collOdemeTutar, Me.colsDovizCinsi, Me.collDovizTutar, Me.collMakbuzNo, Me.collOdemeNo, Me.colnTaksitID, Me.colnIadeAlisverisID, Me.colbMuhasebeyeIslendimi, Me.colnKasaNo, Me.colsKartNo, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colsMagaza})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colnOdemeID
        '
        Me.colnOdemeID.Caption = "Ödeme ID"
        Me.colnOdemeID.FieldName = "nOdemeID"
        Me.colnOdemeID.Name = "colnOdemeID"
        Me.colnOdemeID.OptionsColumn.AllowEdit = False
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "Alýþveriþ ID"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        Me.colnAlisverisID.OptionsColumn.AllowEdit = False
        '
        'colsOdemeSekli
        '
        Me.colsOdemeSekli.Caption = "Ödeme Þekli"
        Me.colsOdemeSekli.ColumnEdit = Me.sec_sOdemeSekli
        Me.colsOdemeSekli.FieldName = "sOdemeSekli"
        Me.colsOdemeSekli.Name = "colsOdemeSekli"
        Me.colsOdemeSekli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", "{0} Kayýt")})
        Me.colsOdemeSekli.Visible = True
        Me.colsOdemeSekli.VisibleIndex = 0
        '
        'sec_sOdemeSekli
        '
        Me.sec_sOdemeSekli.AutoHeight = False
        Me.sec_sOdemeSekli.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeSekli.DisplayMember = "sOdemeSekli"
        Me.sec_sOdemeSekli.Name = "sec_sOdemeSekli"
        Me.sec_sOdemeSekli.NullText = "[ÖdemeÞekli]"
        Me.sec_sOdemeSekli.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sOdemeSekli.ValueMember = "sOdemeSekli"
        '
        'colnOdemeKodu
        '
        Me.colnOdemeKodu.Caption = "Ödeme Kodu"
        Me.colnOdemeKodu.FieldName = "nOdemeKodu"
        Me.colnOdemeKodu.Name = "colnOdemeKodu"
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "KasiyerRumuzu"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.OptionsColumn.AllowEdit = False
        '
        'coldteOdemeTarihi
        '
        Me.coldteOdemeTarihi.Caption = "OdemeTarihi"
        Me.coldteOdemeTarihi.FieldName = "dteOdemeTarihi"
        Me.coldteOdemeTarihi.Name = "coldteOdemeTarihi"
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        '
        'collOdemeTutar
        '
        Me.collOdemeTutar.Caption = "Ödeme Tutarý"
        Me.collOdemeTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00##}")})
        Me.collOdemeTutar.Visible = True
        Me.collOdemeTutar.VisibleIndex = 1
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        Me.colsDovizCinsi.Visible = True
        Me.colsDovizCinsi.VisibleIndex = 2
        '
        'collDovizTutar
        '
        Me.collDovizTutar.Caption = "Döviz Tutar"
        Me.collDovizTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizTutar.FieldName = "lDovizTutar"
        Me.collDovizTutar.Name = "collDovizTutar"
        Me.collDovizTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizTutar", "{0:#,0.00##}")})
        Me.collDovizTutar.Visible = True
        Me.collDovizTutar.VisibleIndex = 3
        '
        'collMakbuzNo
        '
        Me.collMakbuzNo.Caption = "MakbuzNo"
        Me.collMakbuzNo.FieldName = "lMakbuzNo"
        Me.collMakbuzNo.Name = "collMakbuzNo"
        '
        'collOdemeNo
        '
        Me.collOdemeNo.Caption = "OdemeNo"
        Me.collOdemeNo.FieldName = "lOdemeNo"
        Me.collOdemeNo.Name = "collOdemeNo"
        '
        'colnTaksitID
        '
        Me.colnTaksitID.Caption = "TaksitID"
        Me.colnTaksitID.FieldName = "nTaksitID"
        Me.colnTaksitID.Name = "colnTaksitID"
        Me.colnTaksitID.OptionsColumn.AllowEdit = False
        '
        'colnIadeAlisverisID
        '
        Me.colnIadeAlisverisID.Caption = "IadeAlisverisID"
        Me.colnIadeAlisverisID.FieldName = "nIadeAlisverisID"
        Me.colnIadeAlisverisID.Name = "colnIadeAlisverisID"
        Me.colnIadeAlisverisID.OptionsColumn.AllowEdit = False
        '
        'colbMuhasebeyeIslendimi
        '
        Me.colbMuhasebeyeIslendimi.Caption = "Muhasebeye Ýþlendimi"
        Me.colbMuhasebeyeIslendimi.FieldName = "bMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.Name = "colbMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.OptionsColumn.AllowEdit = False
        '
        'colnKasaNo
        '
        Me.colnKasaNo.Caption = "KasaNo"
        Me.colnKasaNo.FieldName = "nKasaNo"
        Me.colnKasaNo.Name = "colnKasaNo"
        Me.colnKasaNo.OptionsColumn.AllowEdit = False
        '
        'colsKartNo
        '
        Me.colsKartNo.Caption = "KartNo"
        Me.colsKartNo.FieldName = "sKartNo"
        Me.colsKartNo.Name = "colsKartNo"
        Me.colsKartNo.Visible = True
        Me.colsKartNo.VisibleIndex = 4
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanýcý Adý"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.OptionsColumn.AllowEdit = False
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.lbl_secilen)
        Me.PanelControl5.Controls.Add(Me.LabelControl4)
        Me.PanelControl5.Controls.Add(Me.lbl_ortvade)
        Me.PanelControl5.Controls.Add(Me.LabelControl11)
        Me.PanelControl5.Controls.Add(Me.lbl_gun)
        Me.PanelControl5.Controls.Add(Me.LabelControl9)
        Me.PanelControl5.Controls.Add(Me.lbl_paraustu)
        Me.PanelControl5.Controls.Add(Me.LabelControl7)
        Me.PanelControl5.Controls.Add(Me.lbl_odenen)
        Me.PanelControl5.Controls.Add(Me.LabelControl5)
        Me.PanelControl5.Controls.Add(Me.lbl_secilen_sayi)
        Me.PanelControl5.Controls.Add(Me.LabelControl3)
        Me.PanelControl5.Controls.Add(Me.lbl_borc)
        Me.PanelControl5.Controls.Add(Me.LabelControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl5.Location = New System.Drawing.Point(526, 200)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(248, 124)
        Me.PanelControl5.TabIndex = 1
        '
        'lbl_secilen
        '
        Me.lbl_secilen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen.Location = New System.Drawing.Point(112, 40)
        Me.lbl_secilen.Name = "lbl_secilen"
        Me.lbl_secilen.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilen.TabIndex = 22
        Me.lbl_secilen.Text = "%"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(8, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 21
        Me.LabelControl4.Text = "SeçilenTutar:"
        '
        'lbl_ortvade
        '
        Me.lbl_ortvade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ortvade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_ortvade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_ortvade.Location = New System.Drawing.Point(112, 104)
        Me.lbl_ortvade.Name = "lbl_ortvade"
        Me.lbl_ortvade.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ortvade.TabIndex = 20
        Me.lbl_ortvade.Text = "%"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(8, 104)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "OrtalamaVade:"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(112, 88)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(13, 13)
        Me.lbl_gun.TabIndex = 18
        Me.lbl_gun.Text = "%"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(8, 88)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "OrtalamaGün:"
        '
        'lbl_paraustu
        '
        Me.lbl_paraustu.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_paraustu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_paraustu.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_paraustu.Location = New System.Drawing.Point(112, 72)
        Me.lbl_paraustu.Name = "lbl_paraustu"
        Me.lbl_paraustu.Size = New System.Drawing.Size(13, 13)
        Me.lbl_paraustu.TabIndex = 16
        Me.lbl_paraustu.Text = "%"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(8, 72)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "ParaÜstü:"
        '
        'lbl_odenen
        '
        Me.lbl_odenen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_odenen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_odenen.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_odenen.Location = New System.Drawing.Point(112, 56)
        Me.lbl_odenen.Name = "lbl_odenen"
        Me.lbl_odenen.Size = New System.Drawing.Size(13, 13)
        Me.lbl_odenen.TabIndex = 14
        Me.lbl_odenen.Text = "%"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(8, 56)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Ödenen:"
        '
        'lbl_secilen_sayi
        '
        Me.lbl_secilen_sayi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen_sayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen_sayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen_sayi.Location = New System.Drawing.Point(112, 24)
        Me.lbl_secilen_sayi.Name = "lbl_secilen_sayi"
        Me.lbl_secilen_sayi.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilen_sayi.TabIndex = 12
        Me.lbl_secilen_sayi.Text = "%"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(8, 24)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "SeçilenTaksit:"
        '
        'lbl_borc
        '
        Me.lbl_borc.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_borc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_borc.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_borc.Location = New System.Drawing.Point(112, 8)
        Me.lbl_borc.Name = "lbl_borc"
        Me.lbl_borc.Size = New System.Drawing.Size(13, 13)
        Me.lbl_borc.TabIndex = 10
        Me.lbl_borc.Text = "%"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(8, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Toplam Borç:"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GridControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(772, 198)
        Me.PanelControl4.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(768, 194)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem16, Me.MenuItem23, Me.MenuItem22, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Faturayý Göster"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 3
        Me.MenuItem23.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem22.Text = "Ödemeleri Seç"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 6
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 7
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 8
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 9
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 11
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 12
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 13
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 14
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 15
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 16
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 17
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'GridView1
        '
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colkodu, Me.colTUTAR, Me.colTAHSILAT, Me.colKALAN, Me.colAY, Me.colYIL, Me.coldteTarihi, Me.colsFisTipi, Me.coldteFaturaTarihi, Me.collFaturaNo, Me.collToplamMiktar, Me.collPesinat, Me.collNetTutar, Me.colsYaziIle, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colsAdi, Me.colsSoyadi, Me.colGECIKME, Me.colAZALT, Me.colNETKALAN})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(590, 408, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colGECIKME
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Me.colTUTAR, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", Me.colTAHSILAT, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Me.colKALAN, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Me.coldteTarihi, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lToplamMiktar", Nothing, "{0:#,0.##} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lNetTutar", Nothing, "ToplamTutar : {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "Kalan  {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "Tutarý  : {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müþteri No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowFocus = False
        Me.colnMusteriID.Width = 73
        '
        'colkodu
        '
        Me.colkodu.Caption = "Müþteri Kodu"
        Me.colkodu.FieldName = "kodu"
        Me.colkodu.Name = "colkodu"
        Me.colkodu.OptionsColumn.AllowFocus = False
        Me.colkodu.Width = 45
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.OptionsColumn.AllowFocus = False
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 8
        Me.colTUTAR.Width = 55
        '
        'colTAHSILAT
        '
        Me.colTAHSILAT.Caption = "Ödenen"
        Me.colTAHSILAT.FieldName = "TAHSILAT"
        Me.colTAHSILAT.Name = "colTAHSILAT"
        Me.colTAHSILAT.OptionsColumn.AllowFocus = False
        Me.colTAHSILAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", "{0:#,0.00}")})
        Me.colTAHSILAT.Visible = True
        Me.colTAHSILAT.VisibleIndex = 9
        '
        'colKALAN
        '
        Me.colKALAN.Caption = "Kalan"
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.OptionsColumn.AllowFocus = False
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.00}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 10
        Me.colKALAN.Width = 80
        '
        'colAY
        '
        Me.colAY.Caption = "Ay"
        Me.colAY.DisplayFormat.FormatString = "m"
        Me.colAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAY.FieldName = "dteTarihi"
        Me.colAY.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
        Me.colAY.Name = "colAY"
        Me.colAY.OptionsColumn.AllowFocus = False
        Me.colAY.Width = 72
        '
        'colYIL
        '
        Me.colYIL.Caption = "Yýl"
        Me.colYIL.FieldName = "YIL"
        Me.colYIL.Name = "colYIL"
        Me.colYIL.OptionsColumn.AllowFocus = False
        Me.colYIL.Width = 37
        '
        'coldteTarihi
        '
        Me.coldteTarihi.Caption = "Vade"
        Me.coldteTarihi.DisplayFormat.FormatString = "D"
        Me.coldteTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.OptionsColumn.AllowFocus = False
        Me.coldteTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", "{0} Kayýt")})
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 7
        Me.coldteTarihi.Width = 121
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "Fiþ Tipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.OptionsColumn.AllowFocus = False
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 0
        Me.colsFisTipi.Width = 46
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.OptionsColumn.AllowFocus = False
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 66
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "FaturaNo"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.OptionsColumn.AllowFocus = False
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 2
        Me.collFaturaNo.Width = 63
        '
        'collToplamMiktar
        '
        Me.collToplamMiktar.Caption = "Miktar"
        Me.collToplamMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collToplamMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamMiktar.FieldName = "lToplamMiktar"
        Me.collToplamMiktar.Name = "collToplamMiktar"
        Me.collToplamMiktar.OptionsColumn.AllowFocus = False
        Me.collToplamMiktar.Visible = True
        Me.collToplamMiktar.VisibleIndex = 3
        Me.collToplamMiktar.Width = 41
        '
        'collPesinat
        '
        Me.collPesinat.Caption = "Peþinat"
        Me.collPesinat.FieldName = "lPesinat"
        Me.collPesinat.Name = "collPesinat"
        Me.collPesinat.OptionsColumn.AllowFocus = False
        Me.collPesinat.Visible = True
        Me.collPesinat.VisibleIndex = 4
        Me.collPesinat.Width = 52
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Tutar"
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.OptionsColumn.AllowFocus = False
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 5
        Me.collNetTutar.Width = 47
        '
        'colsYaziIle
        '
        Me.colsYaziIle.Caption = "Yazýyla"
        Me.colsYaziIle.FieldName = "sYaziIle"
        Me.colsYaziIle.Name = "colsYaziIle"
        Me.colsYaziIle.OptionsColumn.AllowFocus = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "KasaNo"
        Me.GridColumn1.FieldName = "nKasaNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Saat"
        Me.GridColumn2.DisplayFormat.FormatString = "HH:mm:ss"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "dteKayitTarihi"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 54
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "AlýþVeriþ No"
        Me.GridColumn3.FieldName = "nAlisverisID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Ad"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.OptionsColumn.AllowFocus = False
        Me.colsAdi.Width = 31
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyad"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.OptionsColumn.AllowFocus = False
        Me.colsSoyadi.Width = 38
        '
        'colAZALT
        '
        Me.colAZALT.Caption = "Azalt"
        Me.colAZALT.DisplayFormat.FormatString = "#,0.00##"
        Me.colAZALT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAZALT.FieldName = "AZALT"
        Me.colAZALT.Name = "colAZALT"
        Me.colAZALT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ODEME", "{0:#,0.00##}")})
        Me.colAZALT.Visible = True
        Me.colAZALT.VisibleIndex = 11
        '
        'colNETKALAN
        '
        Me.colNETKALAN.Caption = "NetKalan"
        Me.colNETKALAN.DisplayFormat.FormatString = "#,0.00##"
        Me.colNETKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNETKALAN.FieldName = "NETKALAN"
        Me.colNETKALAN.Name = "colNETKALAN"
        Me.colNETKALAN.OptionsColumn.AllowFocus = False
        Me.colNETKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETKALAN", "{0:#,0.00##}")})
        Me.colNETKALAN.Visible = True
        Me.colNETKALAN.VisibleIndex = 12
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Taksit Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "CRM-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_perakende_odeme_iade
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(776, 430)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_perakende_odeme_iade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taksitleri Azalt"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sKasiyerRumuzu
    Public sKasiyer As String
    Public nKasaNo As Int64
    Public nMusteriID As Int64
    Public dteFisTarihi As DateTime
    Public sMagaza As String
    Public lNetTutar As Decimal = 0
    Public lKalanTutar As Decimal = 0
    Public nAlisVerisID
    Dim lMakbuzNo
    Dim ds_taksit As DataSet
    Dim dr As DataRow
    Dim dr_odeme As DataRow
    Dim dr_taksit As DataRow
    Dim toplam As Decimal = 0
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim status As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_perakende_odeme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds_taksit = tbTaksit(nMusteriID, nAlisVerisID)
        dataload_tbOdemeSekli()
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_taksit.Tables(0)
        GridControl1.Focus()
        GridControl1.Select()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        toplam_hesapla()
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_odeme.Tables(0)
        GridView2.FocusedRowHandle = 1
        dr_taksit = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        'pesinat_satir_ekle(dr_taksit("KALAN"))
        status = True
    End Sub
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        toplam = 0
        For Each dr In ds_taksit.Tables(0).Rows
            toplam += dr("AZALT")
        Next
        lbl_borc.Text = toplam
        lKalanTutar = lNetTutar - toplam
        If lKalanTutar = 0 Then
            label2.Text = "***"
        ElseIf lKalanTutar > 0 Then
            label2.Text = "Düþülmesi Gereken Tutar: " & lKalanTutar
        ElseIf lKalanTutar < 0 Then
            label2.Text = "Fazla Düþülen Tutar: " & lKalanTutar
        End If
        label2.Text = lNetTutar - toplam
        dr = Nothing
    End Sub
    Private Sub odeme_hesapla()
        Dim dr As DataRow
        Dim tbOdeme_toplam As Decimal = 0
        For Each dr In ds_odeme.Tables(0).Rows
            tbOdeme_toplam += dr("lOdemeTutar")
        Next
        lbl_odenen.Text = tbOdeme_toplam
        If tbOdeme_toplam > toplam Then
            lbl_paraustu.Text = tbOdeme_toplam - toplam
        Else
            lbl_paraustu.Text = 0
        End If
        dr = Nothing
    End Sub
    Private Sub tbOdeme_hesapla()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("lOdemeTutar") = 0 Then
                dr("lOdemeTutar") = 0.01
            End If
            dr.EndEdit()
            'tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        End If
    End Sub
    Private Sub tbAzalt_hesapla()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("AZALT") < 0 Then
                dr("AZALT") = 0
            End If
            dr("NETKALAN") = dr("KALAN") - dr("AZALT")
            dr.EndEdit()
            'tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        End If
    End Sub
    Private Sub giris_hesapla()
        Dim s As String
        Dim i As Integer
        Dim tutar = 0
        Dim vade
        Dim dr As DataRow
        Dim gun As Decimal = 0
        Dim tutarvade As Decimal = 0
        Dim ortvade As Decimal = 0
        Dim ortgun As Decimal = 0
        Dim dr2 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'If GridView2.RowCount = 0 Then
        '    pesinat_satir_ekle(dr2("KALAN"))
        '    GridControl2.Focus()
        '    GridControl2.Select()
        '    GridView1.FocusedRowHandle = 1
        'End If
        'dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        For Each dr In ds_taksit.Tables(0).Rows
            tutar = tutar + dr("AZALT")
            Try
                gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteTarihi"))
            Catch ex As Exception
                gun = 0
            End Try
            tutarvade = tutarvade + (dr("AZALT") * gun)
        Next
        Try
            ortvade = tutarvade / tutar
            lbl_secilen_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            lbl_odenen.Text = FormatNumber(tutar, 2)
            'dr_odeme("lOdemeTutar") = tutar
            lbl_paraustu.Text = "0.00"
            lbl_gun.Text = CInt(ortvade)
            lbl_ortvade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_secilen_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            'dr_odeme("lOdemeTutar") = tutar
            lbl_odenen.Text = FormatNumber(tutar, 2)
            lbl_paraustu.Text = "0.00"
            lbl_gun.Text = CInt(ortvade)
            lbl_ortvade.Text = ""
        End Try
        dr2 = Nothing
        dr = Nothing
        s = Nothing
        i = Nothing
        tutar = Nothing
        vade = Nothing
        gun = Nothing
    End Sub
    Public Function tbTaksit(ByVal nMusteriID As Int64, ByVal nAlisVerisID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL,CAST(0 AS MONEY) AS AZALT,CAST(0 AS MONEY) AS NETKALAN,  tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID,tbMusteri.sAdi, tbMusteri.sSoyadi,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi, tbMusteri.sSoyadi,  tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "DATATABLE1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_tbOdemeSekli()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbOdemeSekli Order by sOdemeSekli ")).Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
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
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nOdemeID, '" & sDepo & "', ''), 0) + 1 AS nOdemeID FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') ORDER BY dteOdemeTarihi DESC, nOdemeID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lPerakendeIade1, 0) + 1 AS nSonID FROM         tbStokFisNolar WHERE     (sDepo = '" & sMagaza & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeIade1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Private Sub pesinat_satir_ekle(ByVal lKalanTutar As Decimal)
        'pesinat_satir_info()
        Dim dr As DataRow = ds_odeme.Tables(0).NewRow
        Dim nOdemeID = ""  'Trim(sMagaza) + sorgu_nOdemeID(sMagaza).ToString
        lMakbuzNo = 0
        dr("nOdemeID") = nOdemeID
        dr("nAlisverisID") = ""
        dr("sOdemeSekli") = "N   "
        dr("nOdemeKodu") = 3
        dr("sKasiyerRumuzu") = sKasiyerRumuzu
        dr("dteOdemeTarihi") = dteFisTarihi
        dr("dteValorTarihi") = dteFisTarihi
        dr("lOdemeTutar") = lKalanTutar
        dr("sDovizCinsi") = ""
        dr("lDovizTutar") = 0
        dr("lMakbuzNo") = lMakbuzNo
        dr("lOdemeNo") = lMakbuzNo
        dr("nTaksitID") = ""
        dr("nIadeAlisverisID") = ""
        dr("bMuhasebeyeIslendimi") = 0
        dr("nKasaNo") = nKasaNo
        dr("sKartNo") = ""
        dr("sKullaniciAdi") = "MUHASEBE"
        dr("dteKayitTarihi") = Now
        dr("sMagaza") = sMagaza
        'tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        ds_odeme.Tables(0).Rows.Add(dr)
        nOdemeID = Nothing
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbOdeme                       (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('" & nOdemeID & "', '" & nAlisverisID & "', '" & sOdemeSekli & "', " & nOdemeKodu & ", '" & sKasiyerRumuzu & "', '" & dteOdemeTarihi & "', '" & dteValorTarihi & "', " & lOdemeTutar & ", '" & sDovizCinsi & "', " & lDovizTutar & ", " & lMakbuzNo & ", " & lOdemeNo & ", '" & nTaksitID & "', '" & nIadeAlisverisID & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKartNo & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub pesinat_satir_sil()
        If GridView2.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                'tbOdeme_kaydet_sil(dr("nOdemeID"))
                ds_odeme.Tables(0).Rows.Remove(dr)
                GridControl2.Focus()
                GridControl2.Select()
                If GridView2.RowCount > 0 Then
                    GridView2.SelectRow(GridView2.FocusedRowHandle)
                End If
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        stok_satis_detay()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        'If status = True Then
        '    Try
        '        giris_hesapla()
        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            tbOdeme_hesapla()
            odeme_hesapla()
        End If
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        pesinat_satir_ekle(0)
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        pesinat_satir_sil()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub tbOdeme_ekle()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim tutar = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lOdemeTutar As Decimal = 0
        Dim nOdemeID
        Dim lMakbuzNo
        For Each dr1 In ds_odeme.Tables(0).Rows
            lOdemeTutar = dr1("lOdemeTutar")
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If dr("KALAN") > 0 Then
                        If lOdemeTutar > dr("KALAN") Then
                            tutar = dr("KALAN")
                            lOdemeTutar -= dr("KALAN")
                            dr("KALAN") = 0
                        ElseIf lOdemeTutar = dr("KALAN") Then
                            tutar = dr("KALAN")
                            lOdemeTutar -= dr("KALAN")
                            dr("KALAN") = 0
                        ElseIf lOdemeTutar < dr("KALAN") Then
                            tutar = dr("KALAN") - lOdemeTutar
                            lOdemeTutar = 0
                            dr("KALAN") = tutar
                        End If
                        nOdemeID = sorgu_nOdemeID(sMagaza)
                        lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
                        dr1("dteKayitTarihi") = Now
                        tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr("nAlisVerisID"), dr1("sOdemeSekli"), dr1("nOdemeKodu"), dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteValorTarihi"), tutar, dr1("sDovizCinsi"), dr1("lDovizTutar"), lMakbuzNo, lMakbuzNo, dr("nTaksitID"), dr1("nIadeAlisVerisID"), dr1("bMuhasebeyeIslendimi"), dr1("nKasaNo"), dr1("sKartNo"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
                        tbAvSirano_degistir(2, nOdemeID, sMagaza)
                        lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                    End If
                Next
            End If
        Next
        dr = Nothing
        dr1 = Nothing
        lOdemeTutar = Nothing
        nOdemeID = Nothing
        lMakbuzNo = Nothing
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        tbOdeme_ekle()
        Me.Close()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tbAzalt_hesapla()
            giris_hesapla()
            tbOdeme_hesapla()
            odeme_hesapla()
        End If
    End Sub
End Class
