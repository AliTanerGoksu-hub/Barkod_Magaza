Imports DevExpress.XtraEditors
Public Class frm_stok_pesin_kapatma_iade
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colnTaksitID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sOdemeSekli As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kisayol_odeme As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_taksit As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Satis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pesinat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taksit_sayisi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taksit_tutari As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_vade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ds_taksit As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblTaksit_info As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_pesin_kapatma_iade))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.lblTaksit_info = New DevExpress.XtraEditors.LabelControl
        Me.label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_vade = New DevExpress.XtraEditors.LabelControl
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl
        Me.lbl_taksit_tutari = New DevExpress.XtraEditors.LabelControl
        Me.lbl_taksit_sayisi = New DevExpress.XtraEditors.LabelControl
        Me.lbl_pesinat = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Satis = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.kisayol_taksit = New System.Windows.Forms.ContextMenu
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnTaksitID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnAlisverisID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.kisayol_odeme = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
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
        Me.sec_sDovizCinsi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
        Me.ds_taksit = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_taksit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(482, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(97, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Satýþ Kapatma iþlemi Aþaðýdaki gibi yapýlmýþtýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblTaksit_info)
        Me.PanelControl2.Controls.Add(Me.label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 560)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(482, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'lblTaksit_info
        '
        Me.lblTaksit_info.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblTaksit_info.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblTaksit_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTaksit_info.Location = New System.Drawing.Point(3, 32)
        Me.lblTaksit_info.Name = "lblTaksit_info"
        Me.lblTaksit_info.Size = New System.Drawing.Size(476, 13)
        Me.lblTaksit_info.TabIndex = 5
        Me.lblTaksit_info.Text = "***"
        '
        'label2
        '
        Me.label2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.label2.Location = New System.Drawing.Point(3, 3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(476, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(401, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(321, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.lbl_vade)
        Me.PanelControl3.Controls.Add(Me.lbl_gun)
        Me.PanelControl3.Controls.Add(Me.lbl_taksit_tutari)
        Me.PanelControl3.Controls.Add(Me.lbl_taksit_sayisi)
        Me.PanelControl3.Controls.Add(Me.lbl_pesinat)
        Me.PanelControl3.Controls.Add(Me.lbl_Satis)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Controls.Add(Me.LabelControl4)
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(482, 504)
        Me.PanelControl3.TabIndex = 0
        '
        'lbl_vade
        '
        Me.lbl_vade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_vade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_vade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_vade.Location = New System.Drawing.Point(384, 480)
        Me.lbl_vade.Name = "lbl_vade"
        Me.lbl_vade.Size = New System.Drawing.Size(13, 13)
        Me.lbl_vade.TabIndex = 13
        Me.lbl_vade.Text = "%"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(384, 464)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(13, 13)
        Me.lbl_gun.TabIndex = 12
        Me.lbl_gun.Text = "%"
        '
        'lbl_taksit_tutari
        '
        Me.lbl_taksit_tutari.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_taksit_tutari.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_taksit_tutari.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_taksit_tutari.Location = New System.Drawing.Point(248, 480)
        Me.lbl_taksit_tutari.Name = "lbl_taksit_tutari"
        Me.lbl_taksit_tutari.Size = New System.Drawing.Size(13, 13)
        Me.lbl_taksit_tutari.TabIndex = 11
        Me.lbl_taksit_tutari.Text = "%"
        '
        'lbl_taksit_sayisi
        '
        Me.lbl_taksit_sayisi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_taksit_sayisi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_taksit_sayisi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_taksit_sayisi.Location = New System.Drawing.Point(248, 464)
        Me.lbl_taksit_sayisi.Name = "lbl_taksit_sayisi"
        Me.lbl_taksit_sayisi.Size = New System.Drawing.Size(13, 13)
        Me.lbl_taksit_sayisi.TabIndex = 10
        Me.lbl_taksit_sayisi.Text = "%"
        '
        'lbl_pesinat
        '
        Me.lbl_pesinat.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_pesinat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_pesinat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_pesinat.Location = New System.Drawing.Point(96, 480)
        Me.lbl_pesinat.Name = "lbl_pesinat"
        Me.lbl_pesinat.Size = New System.Drawing.Size(13, 13)
        Me.lbl_pesinat.TabIndex = 9
        Me.lbl_pesinat.Text = "%"
        '
        'lbl_Satis
        '
        Me.lbl_Satis.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Satis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Satis.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Satis.Location = New System.Drawing.Point(96, 464)
        Me.lbl_Satis.Name = "lbl_Satis"
        Me.lbl_Satis.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Satis.TabIndex = 8
        Me.lbl_Satis.Text = "%"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(320, 480)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "OrtVade:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(320, 464)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "OrtGün:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(176, 480)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "TaksitTutarý:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(176, 464)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "TaksitSayýsý:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(16, 480)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Peþinat:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(16, 464)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "SatýþTutarý:"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.GridControl3)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 144)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(464, 312)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Taksit iadesi bu bölümden yapýlýr"
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.kisayol_taksit
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(3, 19)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(458, 290)
        Me.GridControl3.TabIndex = 1
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'kisayol_taksit
        '
        Me.kisayol_taksit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem4, Me.MenuItem5, Me.MenuItem9, Me.MenuItem6, Me.MenuItem8, Me.MenuItem7})
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem10.Text = "Faturayý Göster"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem4.Text = "Satýr Ekle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem5.Text = "Satýr Düzelt"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem9.Text = "Deðer Yay"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem6.Text = "Satýr Sil"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 7
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.AltF9
        Me.MenuItem7.Text = "Satýrlarý Sil"
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnTaksitID1, Me.colnAlisverisID1, Me.coldteTarihi, Me.collTutari})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colnTaksitID1
        '
        Me.colnTaksitID1.Caption = "TaksitID"
        Me.colnTaksitID1.FieldName = "nTaksitID"
        Me.colnTaksitID1.Name = "colnTaksitID1"
        Me.colnTaksitID1.OptionsColumn.AllowFocus = False
        '
        'colnAlisverisID1
        '
        Me.colnAlisverisID1.Caption = "Alýþveriþ ID"
        Me.colnAlisverisID1.FieldName = "nAlisverisID"
        Me.colnAlisverisID1.Name = "colnAlisverisID1"
        Me.colnAlisverisID1.OptionsColumn.AllowFocus = False
        '
        'coldteTarihi
        '
        Me.coldteTarihi.Caption = "Tarih"
        Me.coldteTarihi.DisplayFormat.FormatString = "D"
        Me.coldteTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.OptionsColumn.AllowEdit = False
        Me.coldteTarihi.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.coldteTarihi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 0
        '
        'collTutari
        '
        Me.collTutari.Caption = "Tutarý"
        Me.collTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutari.FieldName = "lOdemeTutar"
        Me.collTutari.Name = "collTutari"
        Me.collTutari.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.collTutari.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.collTutari.Visible = True
        Me.collTutari.VisibleIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.GridControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(464, 136)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Para iadesi bu bölümde yapýlýr."
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_odeme
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_odeme
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(3, 19)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sOdemeSekli, Me.sec_sDovizCinsi})
        Me.GridControl2.Size = New System.Drawing.Size(458, 114)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_odeme
        '
        Me.kisayol_odeme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
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
        Me.MenuItem2.Text = "Satýr Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Satýr Sil"
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
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
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
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
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
        Me.colsOdemeSekli.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.colsOdemeSekli.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
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
        Me.collOdemeTutar.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.collOdemeTutar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.collOdemeTutar.Visible = True
        Me.collOdemeTutar.VisibleIndex = 1
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi.ColumnEdit = Me.sec_sDovizCinsi
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        Me.colsDovizCinsi.Visible = True
        Me.colsDovizCinsi.VisibleIndex = 2
        '
        'sec_sDovizCinsi
        '
        Me.sec_sDovizCinsi.AutoHeight = False
        Me.sec_sDovizCinsi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDovizCinsi.DisplayMember = "sDovizCinsi"
        Me.sec_sDovizCinsi.Name = "sec_sDovizCinsi"
        Me.sec_sDovizCinsi.NullText = "[Doviz]"
        Me.sec_sDovizCinsi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sDovizCinsi.ValueMember = "sDovizCinsi"
        '
        'collDovizTutar
        '
        Me.collDovizTutar.Caption = "Döviz Tutar"
        Me.collDovizTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizTutar.FieldName = "lDovizTutar"
        Me.collDovizTutar.Name = "collDovizTutar"
        Me.collDovizTutar.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.collDovizTutar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
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
        'ds_taksit
        '
        Me.ds_taksit.DataSetName = "NewDataSet"
        Me.ds_taksit.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_taksit.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "nOdemeID"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nAlisverisID"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sOdemeSekli"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "nOdemeKodu"
        Me.DataColumn24.DataType = GetType(Long)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn26
        '
        Me.DataColumn26.Caption = "dteOdemeTarihi"
        Me.DataColumn26.ColumnName = "dteOdemeTarihi"
        Me.DataColumn26.DataType = GetType(Date)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "dteValorTarihi"
        Me.DataColumn27.DataType = GetType(Date)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "lOdemeTutar"
        Me.DataColumn28.DataType = GetType(Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sDovizCinsi"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "lDovizTutar"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "lMakbuzNo"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "lOdemeNo"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nTaksitID"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "nIadeAlisverisID"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn35.DataType = GetType(Boolean)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "nKasaNo"
        Me.DataColumn36.DataType = GetType(Long)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sKartNo"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sKullaniciAdi"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "dteKayitTarihi"
        Me.DataColumn39.DataType = GetType(Date)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sMagaza"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "dteTarihi"
        Me.DataColumn41.DataType = GetType(Date)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "lTutari"
        Me.DataColumn42.DataType = GetType(Decimal)
        '
        'frm_stok_pesin_kapatma_iade
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(482, 608)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_stok_pesin_kapatma_iade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satýþ Kapatma"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_taksit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public skasiyer
    Public skasiyerRumuzu
    Public sMagaza
    Public kullanici
    Public nAlisVerisID
    Public nMusteriID
    Public dteFisTarihi
    Public nKasaNo
    Public sFisTipi
    Public lNetTutar As Decimal = 0
    Public sOdemeKodu
    Dim lKalanTutar As Decimal = 0
    Dim lTaksitTutari As Decimal = 0
    Dim dr As DataRow
    Dim dr_hareket As DataRow
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim nOdemeKodu = 1
    Dim lMakbuzNo = 0
    Dim ds_taksit_info As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Private Sub frm_stok_pesin_kapatma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbOdemeSekli()
        dataload_tbDovizCinsi()
        dataload_pesinat(nAlisVerisID)
        dataload_taksit(nAlisVerisID)
        toplam_hesapla()
        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
            'lMakbuzNo = sorgu_lMakbuzNo(sDepo)
            'lMakbuzNo_degistir(lMakbuzNo, sDepo)
        End If
    End Sub
    Private Sub toplam_hesapla()
        lbl_Satis.Text = lNetTutar
        Dim dr_pesinat As DataRow
        Dim dr_taksit As DataRow
        Dim pesinat As Decimal = 0
        Dim taksit_sayisi As Int64 = 0
        Dim taksit_tutari As Decimal = 0
        For Each dr_pesinat In ds_odeme.Tables(0).Rows
            pesinat += dr_pesinat("lOdemeTutar")
        Next
        lbl_pesinat.Text = pesinat
        For Each dr_taksit In ds_taksit.Tables(0).Rows
            taksit_sayisi += 1
            taksit_tutari += dr_taksit("lOdemeTutar")
        Next
        lbl_taksit_sayisi.Text = taksit_sayisi
        lbl_taksit_tutari.Text = taksit_tutari
        lKalanTutar = lNetTutar - (pesinat + taksit_tutari)
        If lKalanTutar = 0 Then
            label2.Text = "***"
        ElseIf lKalanTutar < 0 Then
            label2.Text = "Fazla Kapanan Tutar: " & lKalanTutar
        ElseIf lKalanTutar > 0 Then
            label2.Text = "Kalan Kapanacak Tutar: " & lKalanTutar
        End If
        vade_hesapla()
        dr_pesinat = Nothing
        dr_taksit = Nothing
        pesinat = Nothing
        taksit_sayisi = Nothing
        taksit_tutari = Nothing
    End Sub
    Private Sub vade_hesapla()
        Dim s As String
        Dim i As Integer
        Dim tutar = 0
        Dim vade
        Dim dr As DataRow
        Dim gun As Decimal = 0
        Dim tutarvade As Decimal = 0
        Dim ortvade As Decimal = 0
        Dim ortgun As Decimal = 0
        For Each dr In ds_taksit.Tables(0).Rows
            tutar = tutar + dr("lOdemeTutar")
            Try
                gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteTarihi"))
            Catch ex As Exception
                gun = 0
            End Try
            tutarvade = tutarvade + (dr("lOdemeTutar") * gun)
        Next
        Try
            ortvade = tutarvade / tutar
            lbl_gun.Text = CInt(ortvade)
            lbl_vade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_gun.Text = CInt(ortvade)
            lbl_vade.Text = ""
        End Try
        dr = Nothing
        s = Nothing
        i = Nothing
        tutar = Nothing
        vade = Nothing
        gun = Nothing
    End Sub
    Private Sub pesinat_satir_info()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("lMakbuzNo") <> lMakbuzNo Then
                lMakbuzNo = dr("lMakbuzNo")
            End If
            dr = Nothing
        Else
            lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
        End If
    End Sub
    Private Sub taksit_satir_info()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            ds_taksit_info = sorgu(sorgu_query("SELECT *, (SELECT ISNULL(SUM(lOdemeTutar) , 0) FROM tbOdeme WHERE nTaksitID = tbTaksit.nTaksitID) AS Tahsilat FROM tbTaksit Where nTaksitID ='" & dr("nTaksitID") & "'"))
            dr = Nothing
            Dim dr_taksit As DataRow
            Try
                dr_taksit = ds_taksit_info.Tables(0).Rows(0)
                lblTaksit_info.Text = "Vade: " & dr_taksit("dteTarihi") & " Tutarý: " & dr_taksit("lTutari") & " Tahsilat: " & dr_taksit("Tahsilat") & " Kalan: " & dr_taksit("lTutari") - dr_taksit("Tahsilat")
            Catch ex As Exception
                lblTaksit_info.Text = "***"
            End Try
            dr_taksit = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub dataload_tbOdemeSekli()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbOdemeSekli Order by sOdemeSekli ")).Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_pesinat(ByVal nAlisVerisID As String)
        ds_odeme = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, ABS(lOdemeTutar) AS lOdemeTutar,sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID "))
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_odeme.Tables(0)
    End Sub
    Private Sub dataload_taksit(ByVal nAlisVerisID As String)
        ds_taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbOdeme.*, tbTaksit.dteTarihi, tbTaksit.lTutari FROM         tbOdeme INNER JOIN                       tbTaksit ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE     (tbOdeme.nAlisverisID = '" & nAlisVerisID & "') AND (tbOdeme.nOdemeKodu = 3) "))
        GridControl3.DataMember = Nothing
        GridControl3.DataSource = ds_taksit.Tables(0)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo,0) + 1 lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=1 ORDER BY  lMakbuzNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lMakbuzNo_varmi(ByVal sDepo As String, ByVal nAlisVerisID As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo, 0) AS lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "')  AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        nSonID += 1
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeIade1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nTaksitID_lKalan(ByVal nTaksitID As String) As Decimal
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lTutari - (SELECT ISNULL(SUM(lOdemeTutar) , 0) FROM tbOdeme WHERE nTaksitID = tbTaksit.nTaksitID), 0) AS Kalan FROM tbTaksit Where nTaksitID = '" & nTaksitID & "' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAvSiraNo_kaydet_degistir(ByVal sMagaza As String, ByVal nSiraIndex As Int64, ByVal nSonID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVSiraNo SET              nSonID = nSonID WHERE     (sDepo = '" & sMagaza & "') AND (nSiraIndex = " & nSiraIndex & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub pesinat_satir_ekle()
        pesinat_satir_info()
        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
            lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
        End If
        Dim dr As DataRow = ds_odeme.Tables(0).NewRow
        Dim nOdemeID = sorgu_nOdemeID(sMagaza).ToString
        dr("nOdemeID") = sMagaza & nOdemeID.ToString
        dr("nAlisverisID") = nAlisVerisID
        dr("sOdemeSekli") = "N   "
        dr("nOdemeKodu") = 1
        dr("sKasiyerRumuzu") = skasiyerRumuzu
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
        tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), -dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        ds_odeme.Tables(0).Rows.Add(dr)
        tbAvSirano_degistir(2, nOdemeID, sMagaza)
        nOdemeID = Nothing
    End Sub
    Private Sub taksit_satir_ekle()
        Dim frm As New frm_cari_faturalar_acik
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = nMusteriID
        frm.kullanici = kullanici
        frm.status = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    'pesinat_satir_info()
                    If lKalanTutar > 0 Then
                        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
                            lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
                            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                        End If
                        If dr1("KALAN") > lKalanTutar Then
                            dr1("KALAN") = lKalanTutar
                        End If
                        dr = ds_taksit.Tables(0).NewRow
                        Dim nOdemeID = sorgu_nOdemeID(sMagaza).ToString
                        dr("nOdemeID") = sMagaza & nOdemeID.ToString
                        dr("nAlisverisID") = nAlisVerisID
                        dr("sOdemeSekli") = "N   "
                        dr("nOdemeKodu") = 3
                        dr("sKasiyerRumuzu") = skasiyerRumuzu
                        dr("dteOdemeTarihi") = dteFisTarihi
                        dr("dteValorTarihi") = dteFisTarihi
                        dr("lOdemeTutar") = dr1("KALAN")
                        dr("sDovizCinsi") = ""
                        dr("lDovizTutar") = 0
                        dr("lMakbuzNo") = lMakbuzNo
                        dr("lOdemeNo") = lMakbuzNo
                        dr("dteTarihi") = dr1("dteTarihi")
                        dr("lTutari") = dr1("TUTAR")
                        dr("nTaksitID") = dr1("nTaksitID")
                        dr("nIadeAlisverisID") = dr1("nAlisVerisID")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("nKasaNo") = nKasaNo
                        dr("sKartNo") = ""
                        dr("sKullaniciAdi") = "MUHASEBE"
                        dr("dteKayitTarihi") = Now
                        dr("sMagaza") = sMagaza
                        tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
                        tbAvSirano_degistir(2, nOdemeID, sMagaza)
                        ds_taksit.Tables(0).Rows.Add(dr)
                        toplam_hesapla()
                        Me.Refresh()
                    End If
                Next
            End If
        End If
        'End If
        dr = Nothing
        dr1 = Nothing
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub stok_satis_detay()
        If GridView3.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nIadeAlisverisID")
            frm.fistipi = Trim(sFisTipi)
            frm.kullanici = kullanici
            'If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
            'End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub pesinat_satir_sil()
        If GridView2.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                tbOdeme_kaydet_sil(dr("nOdemeID"))
                ds_odeme.Tables(0).Rows.Remove(dr)
                GridControl2.Focus()
                GridControl2.Select()
                If GridView2.RowCount > 0 Then
                    GridView2.SelectRow(GridView2.FocusedRowHandle)
                End If
                toplam_hesapla()
            End If
        End If
    End Sub
    Private Sub taksit_satir_sil()
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                tbOdeme_kaydet_sil(dr("nOdemeID"))
                ds_taksit.Tables(0).Rows.Remove(dr)
                GridControl3.Focus()
                GridControl3.Select()
                If GridView3.RowCount > 0 Then
                    GridView3.SelectRow(GridView3.FocusedRowHandle)
                End If
                toplam_hesapla()
            End If
        End If
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
    Private Sub tbOdeme_kaydet_degistir(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbOdeme SET              nAlisverisID = '" & nAlisverisID & "', sOdemeSekli = '" & sOdemeSekli & "', nOdemeKodu = " & nOdemeKodu & ", sKasiyerRumuzu = '" & sKasiyerRumuzu & "', dteOdemeTarihi = '" & dteOdemeTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', lOdemeTutar = " & lOdemeTutar & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizTutar = " & lDovizTutar & ", lMakbuzNo = '" & lMakbuzNo & "', lOdemeNo = '" & lOdemeNo & "', nTaksitID = '" & nTaksitID & "', nIadeAlisverisID = '" & nIadeAlisverisID & "', bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", nKasaNo = " & nKasaNo & ", sKartNo = '" & sKartNo & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sMagaza = '" & sMagaza & "' Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbOdeme_kaydet_sil(ByVal nOdemeID As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE    tbOdeme  Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbTaksit_kaydet_degistir(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbTaksit SET              dteTarihi = '" & dteTarihi & "', lTutari = " & lTutari & " Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbTaksit_kaydet_sil(ByVal nTaksitID As String, ByVal nAlisverisID As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim nKayit As Integer = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(nTaksitID) from tbOdeme Where nTaksitID = '" & nTaksitID & "'")
        If nKayit = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbTaksit Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
            cmd.ExecuteNonQuery()
        Else
            XtraMessageBox.Show("Ýþlem Görmüþ Taksit Kaydýný Silemezsiniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        con.Close()
    End Sub
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
    Private Sub tbOdeme_hesapla()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("lOdemeTutar") = 0 Then
                dr("lOdemeTutar") = 0.01
            ElseIf dr("lOdemeTutar") < 0 Then
                dr("lOdemeTutar") = Math.Abs(dr("lOdemeTutar"))
            End If
            dr.EndEdit()
            tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), -dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
        End If
    End Sub
    Private Sub tbTaksitIade_hesapla()
        If GridView3.RowCount > 0 Then
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            If dr("lOdemeTutar") > dr("lTutari") Then
                dr("lOdemeTutar") = dr("lTutari")
            End If
            If dr("lOdemeTutar") = 0 Then
                dr("lOdemeTutar") = 0.01
            ElseIf dr("lOdemeTutar") < 0 Then
                dr("lOdemeTutar") = Math.Abs(dr("lOdemeTutar"))
            End If
            dr.EndEdit()
            tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            Dim lKalanTaksit = sorgu_nTaksitID_lKalan(dr("nTaksitID"))
            If lKalanTaksit < 0 Then
                dr("lOdemeTutar") = dr("lOdemeTutar") - (Math.Abs(lKalanTaksit))
            End If
            dr.EndEdit()
            tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            taksit_satir_info()
        End If
    End Sub
    Private Sub tbTaksit_hesapla()
        If GridView3.RowCount > 0 Then
            GridView3.PostEditor()
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Dim satir = GridView3.FocusedRowHandle
            If dr("lTutari") = 0 Then
                dr("lTutari") = 0.01
            End If
            If dr("dteTarihi") < dteFisTarihi Then
                dr("dteTarihi") = dteFisTarihi
            End If
            If GridView3.FocusedRowHandle = 0 Then
                If dr("dteTarihi") > DateAdd(DateInterval.Day, 40, dteFisTarihi) Then
                    dr("dteTarihi") = DateAdd(DateInterval.Day, 40, dteFisTarihi)
                End If
            Else
                Dim dr_ilk As DataRow = GridView3.GetDataRow(0)
                Dim ilktarih As DateTime = dr_ilk("dteTarihi")
                If dr("dteTarihi") > DateAdd(DateInterval.Month, (GridView3.FocusedRowHandle + 1), ilktarih) Then
                    dr("dteTarihi") = DateAdd(DateInterval.Month, (GridView3.FocusedRowHandle + 1), ilktarih)
                End If
                dr_ilk = Nothing
                ilktarih = Nothing
            End If
            dr.EndEdit()
            tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            toplam_hesapla()
            If lKalanTutar < 0 Then
                GridView3.FocusedRowHandle = GridView3.RowCount - 1
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("lTutari") = lKalanTutar + dr("lTutari")
                dr.EndEdit()
                tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            ElseIf lKalanTutar > 0 Then
                GridView3.FocusedRowHandle = GridView3.RowCount - 1
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("lTutari") = lKalanTutar + dr("lTutari")
                dr.EndEdit()
                tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            End If
            toplam_hesapla()
            GridView3.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView3.RowCount  'kl.Count
        Dim satir = GridView3.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView3.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        dr_hareket = GridView3.GetDataRow(GridView3.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            If columnkriter = "dteTarihi" Then
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                If t > 1 Then
                    durum = DateAdd(DateInterval.Month, 1, durum)
                Else
                    durum = durum
                End If
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            ElseIf columnkriter = "lTutari" Then
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            End If
            tbTaksit_hesapla()
            toplam_hesapla()
            GridView3.FocusedRowHandle += 1
        Next
        GridView3.FocusedRowHandle = satir
        GridView3.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub tbTaksit_ekle_toplu(ByVal dteBaslangic As DateTime, ByVal TaksitSayisi As Int64, ByVal TaksitTutari As Decimal)
        Dim i As Integer
        Dim dteTarihi As DateTime
        Dim nTaksitID As String = ""
        For i = 1 To TaksitSayisi
            If lKalanTutar > 0 Then
                If TaksitTutari > lKalanTutar Then
                    TaksitTutari = lKalanTutar
                End If
                dr = ds_taksit.Tables(0).NewRow
                If i > 1 Then
                    dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                Else
                    dteTarihi = dteBaslangic
                End If
                nTaksitID = sorgu_nTaksitID(sMagaza)
                dr("nTaksitID") = sMagaza & nTaksitID
                dr("nAlisVerisID") = nAlisVerisID
                dr("dteTarihi") = dteTarihi
                dr("lTutari") = TaksitTutari
                tbTaksit_kaydet_yeni(dr("nTaksitID"), dr("nAlisVerisID"), dr("dteTarihi"), dr("lTutari"))
                ds_taksit.Tables(0).Rows.Add(dr)
                tbAvSirano_degistir(3, nTaksitID, sMagaza)
                toplam_hesapla()
            End If
        Next
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            tbOdeme_hesapla()
            toplam_hesapla()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Try
            pesinat_satir_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        pesinat_satir_sil()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        pesinat_satir_ekle()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        taksit_satir_ekle()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        taksit_satir_sil()
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        Try
            taksit_satir_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView3.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView3.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            GridView3.PostEditor()
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            dr.EndEdit()
            tbTaksitIade_hesapla()
            toplam_hesapla()
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        stok_satis_detay()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ödeme Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl3.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ödeme Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
