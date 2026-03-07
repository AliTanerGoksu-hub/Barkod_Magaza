Imports FastReport
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_emir_musteri_takip
    Inherits DevExpress.XtraEditors.XtraForm
    'Dim frx As New TfrxReportClass
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    'Dim ds1 As New TfrxUserDataSetClass
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
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTakipTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTakipAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSonuc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIletisimTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIletisimSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlgiliKisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIstihbarat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents colGelecekmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdendi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_personel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents colKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colErisimTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_takiptipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_durum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents colSonMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents colOnay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeslim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents colsEvAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents colSinif1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents colSeciliMi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_musteri_takip))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_takiptipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
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
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_personel = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.sec_durum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTakipTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTakipAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSonuc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIletisimTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIletisimSekli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlgiliKisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIstihbarat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGelecekmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdendi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colErisimTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSonMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeslim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeciliMi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_takiptipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_personel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_durum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colStatus
        '
        Me.colStatus.Caption = "Tamamlandi?"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 57
        '
        'colGTarih
        '
        Me.colGTarih.Caption = "GeleceðiTarih"
        Me.colGTarih.FieldName = "GTarih"
        Me.colGTarih.Name = "colGTarih"
        Me.colGTarih.Visible = True
        Me.colGTarih.VisibleIndex = 10
        Me.colGTarih.Width = 61
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 96)
        Me.PanelControl1.TabIndex = 2
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(558, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(264, 13)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_takiptipi)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.sec_personel)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.sec_durum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton7)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(96, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(456, 87)
        Me.GroupControl1.TabIndex = 37
        Me.GroupControl1.Text = "Ara"
        '
        'sec_takiptipi
        '
        Me.sec_takiptipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TakipTipi", True))
        Me.sec_takiptipi.EditValue = ""
        Me.sec_takiptipi.EnterMoveNextControl = True
        Me.sec_takiptipi.Location = New System.Drawing.Point(336, 22)
        Me.sec_takiptipi.Name = "sec_takiptipi"
        Me.sec_takiptipi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_takiptipi.Properties.Appearance.Options.UseFont = True
        Me.sec_takiptipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_takiptipi.Properties.Items.AddRange(New Object() {"Teslimat", "Kontrol", "Takip", "Telefon", "Fax", "Sms", "Mektup", "Avukat", "Ýcra", "Müþteri Sorma", "Adres Sorma", "Hatýrlatma", "Tanýþma", "Tatil", "Promosyon", "Hediye", "Görüþme", "Kutlama", "Ziyaret", "Bilgi Sorma", "Bilgilendirme", "Diðer"})
        Me.sec_takiptipi.Size = New System.Drawing.Size(112, 20)
        Me.sec_takiptipi.TabIndex = 57
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn5, Me.DataColumn6, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "dteTarih"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TakipTipi"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "TakipAciklama"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nMusteriID"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lKodu"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAdi"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sSoyadi"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Musteri"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Sonuc"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "IletisimTarihi"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "IletisimSekli"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "IlgiliKisi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Istihbarat"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Aciklama1"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Aciklama2"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Aciklama3"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Aciklama4"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Status"
        Me.DataColumn21.DataType = GetType(Boolean)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "PersonelNo"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Personel"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Gelecekmi"
        Me.DataColumn22.DataType = GetType(Boolean)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "GTarih"
        Me.DataColumn23.DataType = GetType(Date)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Tutar"
        Me.DataColumn24.DataType = GetType(Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Odendi"
        Me.DataColumn25.DataType = GetType(Boolean)
        '
        'DataColumn26
        '
        Me.DataColumn26.Caption = "Ev Adresi"
        Me.DataColumn26.ColumnName = "sEvAdresi"
        '
        'DataColumn27
        '
        Me.DataColumn27.Caption = "Sýnýf1"
        Me.DataColumn27.ColumnName = "Sinif1"
        '
        'DataColumn28
        '
        Me.DataColumn28.Caption = "Sýnýf2"
        Me.DataColumn28.ColumnName = "Sinif2"
        '
        'DataColumn29
        '
        Me.DataColumn29.Caption = "Sýnýf3"
        Me.DataColumn29.ColumnName = "Sinif3"
        '
        'DataColumn30
        '
        Me.DataColumn30.Caption = "Sýnýf4"
        Me.DataColumn30.ColumnName = "Sinif4"
        '
        'DataColumn31
        '
        Me.DataColumn31.Caption = "Sýnýf5"
        Me.DataColumn31.ColumnName = "Sinif5"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(264, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "TakipTipi :"
        '
        'sec_personel
        '
        Me.sec_personel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.PersonelNo", True))
        Me.sec_personel.EnterMoveNextControl = True
        Me.sec_personel.Location = New System.Drawing.Point(69, 22)
        Me.sec_personel.Name = "sec_personel"
        Me.sec_personel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_personel.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_personel.Properties.Appearance.Options.UseFont = True
        Me.sec_personel.Properties.Appearance.Options.UseForeColor = True
        Me.sec_personel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_personel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Personeller")})
        Me.sec_personel.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_personel.Properties.NullText = "[Personeller]"
        Me.sec_personel.Properties.ShowFooter = False
        Me.sec_personel.Properties.ShowHeader = False
        Me.sec_personel.Properties.ValueMember = "IND"
        Me.sec_personel.Size = New System.Drawing.Size(195, 20)
        Me.sec_personel.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-4, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Personel :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(272, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Durum:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(184, 66)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(80, 20)
        Me.sec_konum.TabIndex = 50
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(268, 64)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 51
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(69, 66)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(115, 20)
        Me.txt_ara.TabIndex = 49
        '
        'sec_durum
        '
        Me.sec_durum.EditValue = "Bekliyor"
        Me.sec_durum.EnterMoveNextControl = True
        Me.sec_durum.Location = New System.Drawing.Point(336, 44)
        Me.sec_durum.Name = "sec_durum"
        Me.sec_durum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_durum.Properties.Items.AddRange(New Object() {"[Tümü]", "Tamamlandý", "Bekliyor"})
        Me.sec_durum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_durum.Size = New System.Drawing.Size(112, 20)
        Me.sec_durum.TabIndex = 39
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(336, 66)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(112, 20)
        Me.SimpleButton7.TabIndex = 44
        Me.SimpleButton7.Text = "&Listele"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Müþteri:"
        '
        'Label6
        '
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(272, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(161, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(184, 44)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit2.TabIndex = 38
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(69, 44)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(90, 20)
        Me.DateEdit1.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Enabled = False
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(235, 14)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton6.TabIndex = 13
        Me.SimpleButton6.Text = "&Ýptal"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(160, 14)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 12
        Me.SimpleButton5.Text = "&Yazdýr"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(85, 14)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 11
        Me.SimpleButton4.Text = "&Ýncele"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(10, 14)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "&Ekle"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(360, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 14)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 14)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 96)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 285)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 281)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panelstatus)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 248)
        Me.XtraTabPage1.Text = "Takip Listesi"
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(169, 92)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(479, 64)
        Me.Panelstatus.TabIndex = 4
        Me.Panelstatus.Visible = False
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 14)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 3
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 33)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(463, 18)
        Me.bar.TabIndex = 2
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
        Me.GridControl1.Size = New System.Drawing.Size(818, 248)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem24, Me.MenuItem28, Me.MenuItem32, Me.MenuItem30, Me.MenuItem31, Me.MenuItem29, Me.MenuItem14, Me.MenuItem27, Me.MenuItem36, Me.MenuItem46, Me.MenuItem47, Me.MenuItem33, Me.MenuItem45, Me.MenuItem20, Me.MenuItem19, Me.MenuItem37, Me.MenuItem15, Me.MenuItem5, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem6, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem24
        '
        Me.MenuItem24.DefaultItem = True
        Me.MenuItem24.Index = 1
        Me.MenuItem24.Text = "Ýncele"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem28.Text = "Sil"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 3
        Me.MenuItem32.Text = "Tekrarlarý Kontrol Et"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 4
        Me.MenuItem30.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 5
        Me.MenuItem31.Text = "Gelmiþleri Kontrol Et"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 6
        Me.MenuItem29.Text = "Takip Emri Daðýlýmlarý"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 7
        Me.MenuItem14.Text = "-"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 8
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem27.Text = "Müþteri Kartý"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 9
        Me.MenuItem36.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem36.Text = "Bekleyen Satýþlar"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 10
        Me.MenuItem46.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem46.Text = "Bekleyen Satýþlar Rapor"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 11
        Me.MenuItem47.Shortcut = System.Windows.Forms.Shortcut.F10
        Me.MenuItem47.Text = "Onaylý Satýþlar Rapor"
        '
        'MenuItem33
        '
        Me.MenuItem33.DefaultItem = True
        Me.MenuItem33.Index = 12
        Me.MenuItem33.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem33.Text = "Satýþ Onayý"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 13
        Me.MenuItem45.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem2, Me.MenuItem4, Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem45.Text = "Müþteri Analizi"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Kalan Taksitler"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem2.Text = "Kalan Satýþlar"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem4.Text = "Yapýlan Ödemeler"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.Text = "Ekstre"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 4
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem26.Text = "Satýþlar"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 14
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 15
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem35, Me.MenuItem34})
        Me.MenuItem19.Text = "Raporla"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F2
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
        'MenuItem35
        '
        Me.MenuItem35.Index = 3
        Me.MenuItem35.Text = "-"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 4
        Me.MenuItem34.Text = "Seçilileri Yazdýr"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 16
        Me.MenuItem37.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem38, Me.MenuItem43, Me.MenuItem44, Me.MenuItem40, Me.MenuItem39, Me.MenuItem42, Me.MenuItem41})
        Me.MenuItem37.Text = "Teslimat Raporlarý"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 0
        Me.MenuItem38.Text = "Onay Kontrolü"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 1
        Me.MenuItem43.Text = "Teslimat Kontrolü"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 2
        Me.MenuItem44.Text = "-"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 3
        Me.MenuItem40.Text = "Onay Verilip Kaydý Olmayanlar"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 4
        Me.MenuItem39.Text = "Teslim Edilip Kaydý Olmayanlar"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 5
        Me.MenuItem42.Text = "-"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 6
        Me.MenuItem41.Text = "Teslimat Bekleyenler"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 17
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 18
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 19
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 20
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 21
        Me.MenuItem16.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 22
        Me.MenuItem6.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 23
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 24
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 25
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 26
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 27
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 28
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 29
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem13.Text = "Ekraný Kapla"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.coldteTarih, Me.colTakipTipi, Me.colTakipAciklama, Me.colsKasiyerRumuzu, Me.colsKasiyer, Me.colnMusteriID, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colMusteri, Me.colSonuc, Me.colIletisimTarihi, Me.colIletisimSekli, Me.colIlgiliKisi, Me.colIstihbarat, Me.colAciklama1, Me.colAciklama2, Me.colAciklama3, Me.colAciklama4, Me.colStatus, Me.colGelecekmi, Me.colGTarih, Me.colTutar, Me.colOdendi, Me.colKayitTarihi, Me.colErisimTarihi, Me.colSonMagaza, Me.colOnay, Me.colTeslim, Me.colsEvAdresi, Me.colSinif1, Me.colSinif2, Me.colSinif3, Me.colSinif4, Me.colSinif5, Me.colSeciliMi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 388, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colStatus
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Tag = True
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colGTarih
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Tag = New Date(1900, 1, 1, 0, 0, 0, 0)
        StyleFormatCondition2.Value1 = New Date(1900, 1, 1, 0, 0, 0, 0)
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colGTarih
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Tag = New Date(1900, 1, 1, 0, 0, 0, 0)
        StyleFormatCondition3.Value1 = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarih", "{0} Kayýt")})
        Me.coldteTarih.Visible = True
        Me.coldteTarih.VisibleIndex = 0
        Me.coldteTarih.Width = 53
        '
        'colTakipTipi
        '
        Me.colTakipTipi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTakipTipi.AppearanceCell.Options.UseBackColor = True
        Me.colTakipTipi.Caption = "TakipTipi"
        Me.colTakipTipi.FieldName = "TakipTipi"
        Me.colTakipTipi.Name = "colTakipTipi"
        Me.colTakipTipi.Visible = True
        Me.colTakipTipi.VisibleIndex = 1
        Me.colTakipTipi.Width = 61
        '
        'colTakipAciklama
        '
        Me.colTakipAciklama.Caption = "TakipAciklama"
        Me.colTakipAciklama.FieldName = "TakipAciklama"
        Me.colTakipAciklama.Name = "colTakipAciklama"
        Me.colTakipAciklama.Visible = True
        Me.colTakipAciklama.VisibleIndex = 2
        Me.colTakipAciklama.Width = 125
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "PersonelNo"
        Me.colsKasiyerRumuzu.FieldName = "PersonelNo"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Width = 50
        '
        'colsKasiyer
        '
        Me.colsKasiyer.Caption = "Personel"
        Me.colsKasiyer.FieldName = "Personel"
        Me.colsKasiyer.Name = "colsKasiyer"
        Me.colsKasiyer.Visible = True
        Me.colsKasiyer.VisibleIndex = 3
        Me.colsKasiyer.Width = 61
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müþteri No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.Width = 50
        '
        'collKodu
        '
        Me.collKodu.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collKodu.AppearanceCell.Options.UseFont = True
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 4
        Me.collKodu.Width = 61
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adý"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Width = 50
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadý"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Width = 50
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Müþteri"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 5
        Me.colMusteri.Width = 61
        '
        'colSonuc
        '
        Me.colSonuc.Caption = "Sonuç"
        Me.colSonuc.FieldName = "Sonuc"
        Me.colSonuc.Name = "colSonuc"
        Me.colSonuc.Visible = True
        Me.colSonuc.VisibleIndex = 6
        Me.colSonuc.Width = 61
        '
        'colIletisimTarihi
        '
        Me.colIletisimTarihi.Caption = "IletisimTarihi"
        Me.colIletisimTarihi.FieldName = "IletisimTarihi"
        Me.colIletisimTarihi.Name = "colIletisimTarihi"
        Me.colIletisimTarihi.Visible = True
        Me.colIletisimTarihi.VisibleIndex = 7
        Me.colIletisimTarihi.Width = 61
        '
        'colIletisimSekli
        '
        Me.colIletisimSekli.Caption = "IletisimSekli"
        Me.colIletisimSekli.FieldName = "IletisimSekli"
        Me.colIletisimSekli.Name = "colIletisimSekli"
        Me.colIletisimSekli.Visible = True
        Me.colIletisimSekli.VisibleIndex = 8
        Me.colIletisimSekli.Width = 61
        '
        'colIlgiliKisi
        '
        Me.colIlgiliKisi.Caption = "IlgiliKisi"
        Me.colIlgiliKisi.FieldName = "IlgiliKisi"
        Me.colIlgiliKisi.Name = "colIlgiliKisi"
        Me.colIlgiliKisi.Visible = True
        Me.colIlgiliKisi.VisibleIndex = 9
        Me.colIlgiliKisi.Width = 70
        '
        'colIstihbarat
        '
        Me.colIstihbarat.Caption = "Istihbarat"
        Me.colIstihbarat.FieldName = "Istihbarat"
        Me.colIstihbarat.Name = "colIstihbarat"
        Me.colIstihbarat.Width = 50
        '
        'colAciklama1
        '
        Me.colAciklama1.Caption = "Açýklama 1"
        Me.colAciklama1.FieldName = "Aciklama1"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Width = 73
        '
        'colAciklama2
        '
        Me.colAciklama2.Caption = "Açýklama 2"
        Me.colAciklama2.FieldName = "Aciklama2"
        Me.colAciklama2.Name = "colAciklama2"
        Me.colAciklama2.Width = 124
        '
        'colAciklama3
        '
        Me.colAciklama3.Caption = "Açýklama 3"
        Me.colAciklama3.FieldName = "Aciklama3"
        Me.colAciklama3.Name = "colAciklama3"
        Me.colAciklama3.Width = 50
        '
        'colAciklama4
        '
        Me.colAciklama4.Caption = "Açýklama 4"
        Me.colAciklama4.FieldName = "Aciklama4"
        Me.colAciklama4.Name = "colAciklama4"
        Me.colAciklama4.Width = 50
        '
        'colGelecekmi
        '
        Me.colGelecekmi.Caption = "Gelecekmi?"
        Me.colGelecekmi.FieldName = "Gelecekmi"
        Me.colGelecekmi.Name = "colGelecekmi"
        '
        'colTutar
        '
        Me.colTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTutar.AppearanceCell.Options.UseFont = True
        Me.colTutar.Caption = "Tutar"
        Me.colTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 11
        Me.colTutar.Width = 71
        '
        'colOdendi
        '
        Me.colOdendi.Caption = "Odendi?"
        Me.colOdendi.FieldName = "Odendi"
        Me.colOdendi.Name = "colOdendi"
        '
        'colKayitTarihi
        '
        Me.colKayitTarihi.Caption = "Kayýt Tarihi"
        Me.colKayitTarihi.DisplayFormat.FormatString = "dd.MM.yyy HH:mm"
        Me.colKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKayitTarihi.FieldName = "KayitTarihi"
        Me.colKayitTarihi.Name = "colKayitTarihi"
        '
        'colErisimTarihi
        '
        Me.colErisimTarihi.Caption = "EriþimTarihi"
        Me.colErisimTarihi.DisplayFormat.FormatString = "dd.MM.yyy HH:mm"
        Me.colErisimTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colErisimTarihi.FieldName = "ErisimTarihi"
        Me.colErisimTarihi.Name = "colErisimTarihi"
        '
        'colSonMagaza
        '
        Me.colSonMagaza.Caption = "SonMaðaza"
        Me.colSonMagaza.FieldName = "SonMagaza"
        Me.colSonMagaza.Name = "colSonMagaza"
        '
        'colOnay
        '
        Me.colOnay.Caption = "Onaylandi?"
        Me.colOnay.FieldName = "Onay"
        Me.colOnay.Name = "colOnay"
        '
        'colTeslim
        '
        Me.colTeslim.Caption = "TeslimEdildi?"
        Me.colTeslim.FieldName = "Teslim"
        Me.colTeslim.Name = "colTeslim"
        '
        'colsEvAdresi
        '
        Me.colsEvAdresi.Caption = "Ev Adresi"
        Me.colsEvAdresi.FieldName = "sEvAdresi"
        Me.colsEvAdresi.Name = "colsEvAdresi"
        '
        'colSinif1
        '
        Me.colSinif1.Caption = "Sýnýf 1"
        Me.colSinif1.FieldName = "Sinif1"
        Me.colSinif1.Name = "colSinif1"
        '
        'colSinif2
        '
        Me.colSinif2.Caption = "Sýnýf 2"
        Me.colSinif2.FieldName = "Sinif2"
        Me.colSinif2.Name = "colSinif2"
        '
        'colSinif3
        '
        Me.colSinif3.Caption = "Sýnýf 3"
        Me.colSinif3.FieldName = "Sinif3"
        Me.colSinif3.Name = "colSinif3"
        '
        'colSinif4
        '
        Me.colSinif4.Caption = "Sýnýf 4"
        Me.colSinif4.FieldName = "Sinif4"
        Me.colSinif4.Name = "colSinif4"
        '
        'colSinif5
        '
        Me.colSinif5.Caption = "Sýnýf 5"
        Me.colSinif5.FieldName = "Sinif5"
        Me.colSinif5.Name = "colSinif5"
        '
        'colSeciliMi
        '
        Me.colSeciliMi.Caption = "Ürün Seçili Mi"
        Me.colSeciliMi.FieldName = "SeciliMi"
        Me.colSeciliMi.Name = "colSeciliMi"
        Me.colSeciliMi.Visible = True
        Me.colSeciliMi.VisibleIndex = 12
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(818, 248)
        Me.XtraTabPage2.Text = "Bekleyenler"
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
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Müþteri Takip Emirleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "CRM-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_emir_musteri_takip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emir_musteri_takip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Takip Emirleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_takiptipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_personel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_durum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public kasiyerno
    Public kasiyer
    Public kullanici
    Dim ds_kasiyer As DataSet
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    'Dim qr_hareket As New TfrxADOQuery
    'Dim qr_baslik As New TfrxADOQuery
    Private Sub frm_emir_musteri_takip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        txt_ara.EditValue = ""
        dataload_kasiyer()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ekle()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
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
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        SimpleButton7.Text = Sorgu_sDil(SimpleButton7.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS IND, '[Tümü]' AS ACIKLAMA, '1111' AS SIFRE FROM APERSONEL UNION SELECT IND, PERSONELADI AS ACIKLAMA, SIFRE FROM APERSONEL "))
        sec_personel.Properties.DataSource = ds_kasiyer.Tables(0)
        sec_personel.EditValue = kasiyerno
        sec_personel.Text = kasiyer
        'sec_personel.ItemIndex = 1
        sec_personel.Refresh()
    End Sub
    Private Sub ekle()
        Dim frm As New frm_emir_musteri_takip_karti
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyer = kasiyer
        frm.kasiyerno = kasiyerno
        frm.kullanici = kullanici
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        frm.qfirmakodu = "Eþittir"
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        ara_load()
        frm = Nothing
    End Sub
    Private Sub duzelt()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_emir_musteri_takip_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.kasiyer = kasiyer
            frm.kasiyerno = kasiyerno
            frm.connection = connection
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim satir = GridView1.FocusedRowHandle
            frm.kayitno = dr("IND")
            frm.status = True
            frm.kullanici = kullanici
            frm.firmakodu = dr("lKodu")
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eþittir"
            frm.islemstatus = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            ara_load()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub Teslimat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Perakende_Teslimat
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.sKasiyer = ""
            frm.sKasiyerRumuzu = ""
            frm.sMagaza = ""
            frm.txt_kasiyer_kod.EditValue = ""
            frm.lbl_kasiyer.Text = ""
            frm.sec_magaza.EditValue = ""
            frm.emir_musteri_takipMi = True
            frm.emir_musteri_takip_kartID = dr("IND").ToString()
            frm.nMusteriID = dr("nMusteriID")
            frm.txt_musterino.EditValue = dr("lKodu")
            frm.lbl_musteri_adi.Text = dr("Musteri")
            frm.sAdi = dr("sAdi")
            frm.sSoyadi = dr("sSoyadi")
            frm.sAdres1 = ""
            frm.sAdres2 = ""
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        ara_load()
    End Sub
    Private Sub ara_load()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, Trim(sec_takiptipi.Text), sec_durum.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal takiptipi As String, ByVal durum As String)
        Dim kriter As String = ""
        kriter += " Where dteTarih BETWEEN '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) & "'"
        If sec_personel.EditValue > 0 Then
            kriter += " AND PersonelNo = '" & sec_personel.EditValue & "'"
        End If
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND ( lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND ( sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND ( sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
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
                'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
                If adi.ToString <> "" Then
                    kriter += " AND ( sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND ( sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
                End If
            End If
        End If
        If takiptipi <> "" Then
            kriter += " AND TakipTipi = '" & takiptipi & "'"
        End If
        If durum <> "" Then
            If durum = "[Tümü]" Then
                'kriter += " AND Status = 1 "
            ElseIf durum = "Bekliyor" Then
                kriter += " AND Status = 0 "
            ElseIf durum = "Tamamlandý" Then
                kriter += " AND Status = 1 "
            End If
        End If
        'kriter += " WHERE StartTime between '" & Microsoft.VisualBasic.Left(tarih.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih.ToString, 10) + " 23:59:59" & "'  "
        'If personelno > 0 Then
        '    kriter += " AND PersonelNo =" & personelno & " "
        'End If
        DataSet1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT *, (Select sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvSemt + ' ' + sEvPostaKodu + ' ' + sEvIl From tbMusteri where nMusteriID = aEmirMusteriTakip.nMusteriID) as sEvAdresi, (Select sAciklama1 + ' ' + sAciklama2 + ' ' + sAciklama3 + ' ' + sAciklama4 + ' ' + sAciklama5 AS ISTIHBARAT From tbMusteri where nMusteriID = aEmirMusteriTakip.nMusteriID) AS MUSTERIISTIHBARAT, (SELECT TOP 1 sMagaza FROM tbAlisVeris WHERE (nGirisCikis = 3) and nMusteriID = aEmirMusteriTakip.nMusteriID ORDER BY dteFaturaTarihi DESC) AS SonMagaza, CAST(0 AS BIT) AS Onay, CAST(0 AS BIT) AS Teslim, tbMSinif1.sAciklama AS Sinif1, tbMSinif2.sAciklama AS Sinif2, tbMSinif3.sAciklama AS Sinif3, tbMSinif4.sAciklama AS Sinif4, tbMSinif5.sAciklama AS Sinif5, (Case When (select Count(*) from tbAlisverisSiparis sip where (sip.nAlisverisID IN (Select nAlisverisID from tbAlisVeris Where (lFaturaNo IN (Select lFaturaNo from aEmirMusteriTakipUrunler a where (a.IND = aEmirMusteriTakip.IND))) AND (nMusteriID = aEmirMusteriTakip.nMusteriID))) AND (sip.dteOnayTarihi = '01.01.1900') AND (sip.bTeslimEdildi = 0)) > 0 Then (Case When (Select Count(*) as c from aEmirMusteriTakipUrunler a where (a.IND = aEmirMusteriTakip.IND)) > 0 Then CAST(1 AS bit) Else CAST(0 as bit) END) Else CAST(0 as bit) END) as SeciliMi  FROM aEmirMusteriTakip INNER JOIN tbMusteriSinifi ON aEmirMusteriTakip.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu " & kriter & ""))
        kriter = Nothing
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        If GridView1.RowCount > 0 Then
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.FocusedRowHandle = 0
            GridView1.SelectRow(GridView1.FocusedRowHandle)
        End If
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
    Private Sub gorev_sil()
        If GridView1.RowCount > 0 Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim satir = GridView1.FocusedRowHandle
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    gorev_kayit_sil(dr("IND"))
                Next
            End If
            ara_load()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            s = Nothing
            arr = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub gorev_kayit_sil(ByVal ID As Int64)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirMusteriTakip  WHERE IND= '" & ID & "'")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirAjanda  WHERE MusteriTakipIND= '" & ID & "' and FirmaTipi =1")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        duzelt()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            duzelt()
        ElseIf e.KeyCode = Keys.F4 Then
            duzelt()
        ElseIf e.Control = True And e.KeyCode = Keys.O Then
            Teslimat()
        Else
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        duzelt()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Müþteri Takip Kaydýný Silmek Ýstediðinize Eminmisinz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If yetki_kontrol(kullanici, "frm_musteri_takip_sil") = True Then
                gorev_sil()
            End If
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
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
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
    Private Sub stok_odeme_detay_tumu()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_odeme
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.musterikodu = dr("lKodu")
            frm.tarih = dr("dteTarih")
            'frm.belgeno = dr("BELGENO")
            frm.tumu = True
            'frm.stokno = dr("ALISVERISNO")
            'frm.fistipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub stok_satis_detay()
        Dim frm As New frm_stok_cari_satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.stokno = dr("ALISVERISNO")
        frm.fistipi = Trim(dr("IZAHAT").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        dr = Nothing
    End Sub
    Private Sub stok_odeme_detay()
        Dim frm As New frm_stok_cari_odeme
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.musterikodu = dr("lKodu")
        frm.tarih = dr("TARIH")
        frm.belgeno = dr("BELGENO")
        'frm.stokno = dr("ALISVERISNO")
        frm.fistipi = Trim(dr("IZAHAT").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        dr = Nothing
    End Sub
    Private Sub analiz_satis_onayi()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_cari_satis_onay
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.firmakodu = dr("lKodu")
            frm.tarih = dr("dteTarih")
            frm.izahat = "PF"
            frm.fisno = dr("lKodu")
            frm.Label1.Text = dr("Musteri") & vbCrLf & Label1.Text
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
            frm.firmakodu = dr("lKodu")
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eþittir"
            frm.islemstatus = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_onaybekleyenler()
        Dim frm As New frm_musteri_onaybekleyen
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyer = kasiyer
        frm.kasiyerno = kasiyerno
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_gorev_dagilim()
        Dim frm As New frm_emir_ajanda_dagilim
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.tarih1 = Today
        frm.takip = True
        frm.sec_tamamlandi.Text = "[Tümü]"
        frm.sec_tamamlandi.Enabled = False
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        kriter = " WHERE IND = " & dr("IND") & ""
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |musteri_*.fr3"
        OpenFileDialog1.InitialDirectory = "C:\Formlar\Raporlar\Ajanda\musteri_takip.fr3"
        OpenFileDialog1.FileName = "musteri_takip.fr3"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, islem)
        End If
        file = Nothing
        kriter = Nothing
        dr = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            qr_hareket = frx.FindObject("qr_hareket")
            'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT     *,NewID() AS Ref   FROM         aEmirMusteriTakip   " & kriter & " ORDER BY IND")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT  *,NewID() as Ref FROM aEmirMusteriTakip INNER JOIN (SELECT tbMusteri.nMusteriID , tbMusteri.sMagaza , tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri , tbMusteri.nCinsiyet , tbMusteri.lAylikGelir , tbMusteri.dteKartAcilisTarihi , tbMusteri.nIskontoPesin , tbMusteri.nIskontoKredili , tbMusteri.sUnvan , tbMusteri.sVergiDairesi , tbMusteri.sVergiNo , tbMusteri.bYazismaEvAdresinemi , tbMusteri.sEmail , tbMusteri.sIsYeriAdi , tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi , tbMusteri.sIsTelefonu , tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi , tbMusteri.sEvTelefonu , tbMusteri.sSigortaNo , tbMusteri.bEvlimi , tbMusteri.dteEvlilikTarihi , tbMusteri.dteDogumTarihi , tbMusteri.sDogumYeri , tbMusteri.sEhliyetNo , tbMusteri.sKanGrubu , tbMusteri.dteKayitTarihi , tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT , tbMusteri.sGSM , tbMusteri.sFax , (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME , tbMSinif1.sAciklama AS Sýnýf1 , tbMSinif2.sAciklama AS Sýnýf2 , tbMSinif3.sAciklama AS Sýnýf3 , tbMSinif4.sAciklama AS Sýnýf4 , tbMSinif5.sAciklama AS Sýnýf5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu) Musteri ON aEmirMusteriTakip.nMusteriID = Musteri.nMusteriID " & kriter & " ORDER BY aEmirMusteriTakip.IND")
            'qr_baslik = frx.FindObject("qr_baslik")
            'qr_baslik.Query = sorgu_query("set transaction isolation level read uncommitted SELECT     * FROM         ASTOKETIKETTALEPBASLIK WHERE IND =" & belgeind & "")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            frx.PrintOptions.Collate = False
            If status = 0 Then
                'frx.PrepareReport(True)
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_hareket = Nothing
            qr_baslik = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT  *,NewID() as Ref FROM aEmirMusteriTakip INNER JOIN (SELECT tbMusteri.nMusteriID , tbMusteri.sMagaza , tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri , tbMusteri.nCinsiyet , tbMusteri.lAylikGelir , tbMusteri.dteKartAcilisTarihi , tbMusteri.nIskontoPesin , tbMusteri.nIskontoKredili , tbMusteri.sUnvan , tbMusteri.sVergiDairesi , tbMusteri.sVergiNo , tbMusteri.bYazismaEvAdresinemi , tbMusteri.sEmail , tbMusteri.sIsYeriAdi , tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi , tbMusteri.sIsTelefonu , tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi , tbMusteri.sEvTelefonu , tbMusteri.sSigortaNo , tbMusteri.bEvlimi , tbMusteri.dteEvlilikTarihi , tbMusteri.dteDogumTarihi , tbMusteri.sDogumYeri , tbMusteri.sEhliyetNo , tbMusteri.sKanGrubu , tbMusteri.dteKayitTarihi , tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT , tbMusteri.sGSM , tbMusteri.sFax , (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME , tbMSinif1.sAciklama AS Sýnýf1 , tbMSinif2.sAciklama AS Sýnýf2 , tbMSinif3.sAciklama AS Sýnýf3 , tbMSinif4.sAciklama AS Sýnýf4 , tbMSinif5.sAciklama AS Sýnýf5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu) Musteri ON aEmirMusteriTakip.nMusteriID = Musteri.nMusteriID " & kriter & " ORDER BY aEmirMusteriTakip.IND") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "4"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 13
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Function satir_kontrol()
        Dim satir As String = "WHERE aEmirMusteriTakip.IND IN ("
        Dim dr As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString()
                dr = DataSet1.Tables(0).NewRow
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("IND").ToString()
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
        dr = Nothing
        s = Nothing
    End Function
    Private Function satir_kontrol_musteriler()
        Dim satir As String = " ("
        Dim dr As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString()
                dr = DataSet1.Tables(0).NewRow
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("nMusteriID").ToString()
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
        dr = Nothing
        s = Nothing
    End Function
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        stok_odeme_detay_tumu()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        analiz_musteri_karti()
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
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Try
            If GridView1.SelectedRowsCount > 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("MUSTERIISTIHBARAT").ToString
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        ekle()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        duzelt()
    End Sub
    Private Sub frm_emir_musteri_takip_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        analiz_gorev_dagilim()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        If XtraMessageBox.Show(Sorgu_sDil("Gelecek Kaydý Düþülmüþ Müþteri Kayýtlarýný Gelip Gelmediðini Kontrol Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView1.SelectAll()
            Dim dr As DataRow
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim kayitsayisi As Int64
            Dim sayi = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                Panelstatus.Visible = True
                bar.Properties.Maximum = GridView1.SelectedRowsCount
                barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
                    barlabel.Refresh()
                    kayitsayisi = 0
                    If dr("Status") = 0 And Trim(dr("TakipTipi")) <> "Teslimat" Then
                        kayitsayisi = sorgu_musteri_geldi(dr("nMusteriID"), DateEdit2.EditValue)
                        If kayitsayisi = 0 Then
                        ElseIf kayitsayisi > 0 Then
                            gorev_kayit_tamamla(0, 1, "( " & DateEdit1.EditValue & " Tarihinde Kontrol Edildi...)", dr("IND"))
                            dr("Status") = 1
                            dr("Odendi") = 1
                        End If
                    End If
                    'If ajanda = False Then
                    'takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text & " ( " & dr("IZAHAT") & " ) ", frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("FIRMAKODU"), dr("ADI"), dr("SOYADI"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", dr("TUTAR"), False, "", "", "", "", "", False)
                    'ElseIf ajanda = True Then
                    'gorev_ekle(1, dr("nMusteriID"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), frm.sec_personel.EditValue, 2, "Müþteri Takip Emri-ÝlkTaksitÖdemesi", frm.txt_takip_aciklama.Text & vbCrLf & dr("FIRMAKODU") + "-" + Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50) & vbCrLf & "AlýþVeriþTarihi : " & dr("TARIH") & " AlýþVeriþBelgeTipi: " & dr("IZAHAT") & " Kasiyer: " & dr("KASIYER") & " Miktar: " & FormatNumber(dr("MIKTAR"), 2) & " Tutar: " & dr("TUTAR") & vbCrLf & "ÝlkTaksitTarihi: " & dr("GECIKENILKTAKSITTARIHI") & " TaksitTutarý: " & dr("GECIKENILKTAKSITTUTARI"), 0, Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "17:00:00", Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "21:00:00", "Kredi", False, 0, "", "", dr("GECIKENILKTAKSITTUTARI"), "", 0, True, False, 0)
                    'End If
                    bar.Position = bar.Position + 1
                    bar.Refresh()
                    Panelstatus.Refresh()
                Next
                bar.Position = 0
                Panelstatus.Visible = False
                dr = Nothing
                'dataload_gorev(DateEdit1.EditValue, sec_personel.EditValue, sec_durum.Text)
            End If
        End If
    End Sub
    Private Sub kontrol_onay()
        If XtraMessageBox.Show(Sorgu_sDil("Sevkiyat Emirlerinin Onay Kontrolünü Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView1.SelectAll()
            Dim dr As DataRow
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim kayitsayisi As Int64
            Dim sayi = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                Panelstatus.Visible = True
                bar.Properties.Maximum = GridView1.SelectedRowsCount
                barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
                    barlabel.Refresh()
                    kayitsayisi = 0
                    kayitsayisi = sorgu_onay_verildi(dr("dteTarih"), "PF", dr("lKodu"), dr("nMusteriID"))
                    If kayitsayisi = 0 Then
                    ElseIf kayitsayisi > 0 Then
                        'gorev_kayit_tamamla(0, 1, "( " & DateEdit1.EditValue & " Tarihinde Kontrol Edildi...)", dr("IND"))
                        'dr("Status") = 1
                        'dr("Odendi") = 1
                        dr("Onay") = 1
                    Else
                        dr("Onay") = 0
                    End If
                    'If ajanda = False Then
                    'takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text & " ( " & dr("IZAHAT") & " ) ", frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("FIRMAKODU"), dr("ADI"), dr("SOYADI"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", dr("TUTAR"), False, "", "", "", "", "", False)
                    'ElseIf ajanda = True Then
                    'gorev_ekle(1, dr("nMusteriID"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), frm.sec_personel.EditValue, 2, "Müþteri Takip Emri-ÝlkTaksitÖdemesi", frm.txt_takip_aciklama.Text & vbCrLf & dr("FIRMAKODU") + "-" + Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50) & vbCrLf & "AlýþVeriþTarihi : " & dr("TARIH") & " AlýþVeriþBelgeTipi: " & dr("IZAHAT") & " Kasiyer: " & dr("KASIYER") & " Miktar: " & FormatNumber(dr("MIKTAR"), 2) & " Tutar: " & dr("TUTAR") & vbCrLf & "ÝlkTaksitTarihi: " & dr("GECIKENILKTAKSITTARIHI") & " TaksitTutarý: " & dr("GECIKENILKTAKSITTUTARI"), 0, Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "17:00:00", Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "21:00:00", "Kredi", False, 0, "", "", dr("GECIKENILKTAKSITTUTARI"), "", 0, True, False, 0)
                    'End If
                    bar.Position = bar.Position + 1
                    bar.Refresh()
                    Panelstatus.Refresh()
                Next
                bar.Position = 0
                Panelstatus.Visible = False
                dr = Nothing
                'dataload_gorev(DateEdit1.EditValue, sec_personel.EditValue, sec_durum.Text)
            End If
        End If
    End Sub
    Private Sub kontrol_teslimat()
        If XtraMessageBox.Show(Sorgu_sDil("Sevkiyat Emirlerinin Onay Kontrolünü Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView1.SelectAll()
            Dim dr As DataRow
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim kayitsayisi As Int64
            Dim sayi = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                Panelstatus.Visible = True
                bar.Properties.Maximum = GridView1.SelectedRowsCount
                barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
                    barlabel.Refresh()
                    kayitsayisi = 0
                    kayitsayisi = sorgu_teslim_edildi(dr("dteTarih"), "PF", dr("lKodu"), dr("nMusteriID"))
                    If kayitsayisi = 0 Then
                    ElseIf kayitsayisi > 0 Then
                        'gorev_kayit_tamamla(0, 1, "( " & DateEdit1.EditValue & " Tarihinde Kontrol Edildi...)", dr("IND"))
                        'dr("Status") = 1
                        'dr("Odendi") = 1
                        dr("Teslim") = 1
                    Else
                        dr("Teslim") = 0
                    End If
                    'If ajanda = False Then
                    'takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text & " ( " & dr("IZAHAT") & " ) ", frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("FIRMAKODU"), dr("ADI"), dr("SOYADI"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", dr("TUTAR"), False, "", "", "", "", "", False)
                    'ElseIf ajanda = True Then
                    'gorev_ekle(1, dr("nMusteriID"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), frm.sec_personel.EditValue, 2, "Müþteri Takip Emri-ÝlkTaksitÖdemesi", frm.txt_takip_aciklama.Text & vbCrLf & dr("FIRMAKODU") + "-" + Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50) & vbCrLf & "AlýþVeriþTarihi : " & dr("TARIH") & " AlýþVeriþBelgeTipi: " & dr("IZAHAT") & " Kasiyer: " & dr("KASIYER") & " Miktar: " & FormatNumber(dr("MIKTAR"), 2) & " Tutar: " & dr("TUTAR") & vbCrLf & "ÝlkTaksitTarihi: " & dr("GECIKENILKTAKSITTARIHI") & " TaksitTutarý: " & dr("GECIKENILKTAKSITTUTARI"), 0, Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "17:00:00", Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "21:00:00", "Kredi", False, 0, "", "", dr("GECIKENILKTAKSITTUTARI"), "", 0, True, False, 0)
                    'End If
                    bar.Position = bar.Position + 1
                    bar.Refresh()
                    Panelstatus.Refresh()
                Next
                bar.Position = 0
                Panelstatus.Visible = False
                dr = Nothing
                'dataload_gorev(DateEdit1.EditValue, sec_personel.EditValue, sec_durum.Text)
            End If
        End If
    End Sub
    Private Sub kontrol_kaydi_olmayan_onayli()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Onay Verilip Takip Kaydý Olmayan Müþteri Listesini Almak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                GridView1.SelectAll()
                Dim frm As New frm_musteri_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.kasiyer = kasiyer
                frm.kasiyerno = kasiyerno
                frm.islem = "Onay Verilip Kaydý Olmayanlar"
                frm.musteriler = satir_kontrol_musteriler()
                frm.tarih = DateEdit2.EditValue
                frm.goster = True
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.Show()
                End If
            End If
        End If
    End Sub
    Private Sub kontrol_kaydi_olmayan_teslimat()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Paket Teslimat Çýkýþý Yapýlýp Takip Kaydý Olmayan Müþteri Listesini Almak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                GridView1.SelectAll()
                Dim frm As New frm_musteri_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.kasiyer = kasiyer
                frm.kasiyerno = kasiyerno
                frm.islem = "Teslim Edilip Kaydý Olmayanlar"
                frm.musteriler = satir_kontrol_musteriler()
                frm.tarih = DateEdit2.EditValue
                frm.goster = True
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.Show()
                End If
            End If
        End If
    End Sub
    Private Sub gorev_kayit_tamamla(ByVal ID As Int64, ByVal tamamlandi As Byte, ByVal aciklamaekle As String, ByVal MusteriTakipID As Int64)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirAjanda SET              ReminderInfo='',Odendi= 1,Tamamlandi = " & tamamlandi & ",Description= '" & aciklamaekle & "' WHERE ID= '" & ID & "'")
        'cmd.ExecuteNonQuery()
        If MusteriTakipID > 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirMusteriTakip SET              Aciklama4 = '" & Today & " Tarihinde Geldi...', Sonuc= 'Geldi...' ,Odendi = 1,Status=1,ErisimTarihi = '" & Now & "' WHERE IND = '" & MusteriTakipID & "'")
            cmd.ExecuteNonQuery()
        End If
        conn.Close()
    End Sub
    Public Function sorgu_musteri_geldi(ByVal nMusteriID As String, ByVal tarih As DateTime) As Int64
        Dim kriter
        kriter = "WHERE     (tbOdeme.dteOdemeTarihi between '" & DateAdd(DateInterval.Day, -3, tarih) & "' and '" & tarih & "') and (tbAlisveris.nMusteriID = '" & nMusteriID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*),0) AS KAYIT FROM         tbOdeme INNER JOIN                       tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_teslim_edildi(ByVal tarih As DateTime, ByVal izahat As String, ByVal skodu As String, ByVal nMusteriID As Integer) As Int64
        Dim kriter
        'kriter = "WHERE     (tbOdeme.dteOdemeTarihi between '" & DateAdd(DateInterval.Day, -3, tarih) & "' and '" & tarih & "') and (tbAlisveris.nMusteriID = '" & nMusteriID & "') "
        kriter = " WHERE     (FISTARIHI = '" & tarih & " ') AND (IZAHAT = '" & izahat & "') AND (FIRMAKODU = '" & skodu & "')"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         ASTOKPAKETBASLIK " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_onay_verildi(ByVal tarih As DateTime, ByVal izahat As String, ByVal skodu As String, ByVal nMusteriID As Integer) As Int64
        Dim kriter
        'kriter = "WHERE     (tbOdeme.dteOdemeTarihi between '" & DateAdd(DateInterval.Day, -3, tarih) & "' and '" & tarih & "') and (tbAlisveris.nMusteriID = '" & nMusteriID & "') "
        'kriter = " WHERE     (FISTARIHI = '" & tarih & " ') AND (IZAHAT = '" & izahat & "') AND (FIRMAKODU = " & skodu & ")"
        kriter = " WHERE     (sFisTipi = '" & izahat & "') AND (dteFisTarihi = '" & tarih & "') AND (lFisNo = " & skodu & ") AND (nMusteriID = " & nMusteriID & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(DISTINCT nIslemID), 0) AS KAYIT FROM         tbStokFisiDetayi " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub kontrol_tekrar_musteri()
        Dim ds_liste As DataSet
        ds_liste = sorgu(sorgu_query("SELECT DISTINCT nMusteriID, lKodu,Musteri, COUNT(nMusteriID) AS Sayi FROM         aEmirMusteriTakip WHERE     (Status = 0) and TakipTipi<> 'Teslimat' GROUP BY nMusteriID, lKodu,Musteri HAVING      (COUNT(nMusteriID) > 1) ORDER BY COUNT(nMusteriID) DESC"))
        Dim dr As DataRow
        Panelstatus.Visible = True
        bar.Properties.Maximum = ds_liste.Tables(0).Rows.Count
        barlabel.Text = "Toplam Satýr Sayýsý : " & ds_liste.Tables(0).Rows.Count
        bar.Position = 0
        For Each dr In ds_liste.Tables(0).Rows
            barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
            barlabel.Refresh()
            kontrol_tekrar_sil(dr("nMusteriID"), dr("Sayi") - 1)
            bar.Position = bar.Position + 1
            bar.Refresh()
            Panelstatus.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Sub kontrol_tekrar_sil(ByVal nMusteriID As Int64, ByVal kayit As Int64)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM aEmirMusteriTakip WHERE     (Status = 0) AND (nMusteriID = " & nMusteriID & ") AND (IND IN (SELECT     TOP " & kayit & " IND FROM          aEmirMusteriTakip WHERE      status = 0 AND nMusteriID = " & nMusteriID & " ORDER BY dteTarih))")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        If XtraMessageBox.Show(Sorgu_sDil("Müþteri Kayýt Tekrarlarýný Kontrol Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            kontrol_tekrar_musteri()
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(0, 2)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla(0, 1)
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        analiz_satis_onayi()
    End Sub
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        analiz_bekleyen()
    End Sub
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        analiz_onaybekleyenler()
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        kontrol_onay()
    End Sub
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        kontrol_teslimat()
    End Sub
    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        kontrol_kaydi_olmayan_onayli()
    End Sub
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        kontrol_kaydi_olmayan_teslimat()
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
    Private Sub MenuItem46_Click(sender As Object, e As EventArgs) Handles MenuItem46.Click
        If GridView1.RowCount > 0 Then
            Dim s As String
            Dim cariK As String = ""
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim emir_musteri_takip_kartID As String = ""
            Dim satir = GridView1.FocusedRowHandle
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    cariK += dr("lKodu") + ","
                    emir_musteri_takip_kartID += dr("IND").ToString() + ","
                Next
            End If
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            s = Nothing
            arr = Nothing
            dr = Nothing
            cariK = cariK.Substring(0, cariK.Length - 1)
            emir_musteri_takip_kartID = emir_musteri_takip_kartID.Substring(0, emir_musteri_takip_kartID.Length - 1)
            'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_satis_bekleyen_onaysiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.firmakodu = dr("lKodu")
            frm.firmakodu = cariK
            frm.cokluMusteri = True
            frm.emir_musteri_takipMi = True
            frm.emir_musteri_takip_kartID = emir_musteri_takip_kartID
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eþittir"
            frm.islemstatus = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem47_Click(sender As Object, e As EventArgs) Handles MenuItem47.Click
        If GridView1.RowCount > 0 Then
            Dim s As String
            Dim cariK As String = ""
            Dim cariTarih As String = ""
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim satir = GridView1.FocusedRowHandle
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    cariK += dr("nMusteriID") + ","
                    cariTarih += "'" & dr("dteTarih") & "',"
                Next
            End If
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            s = Nothing
            arr = Nothing
            dr = Nothing
            cariK = cariK.Substring(0, cariK.Length - 1)
            cariTarih = cariTarih.Substring(0, cariTarih.Length - 1)
            'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_satis_bekleyen_onayli
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.firmakodu = dr("lKodu")
            frm.firmakodu = cariK
            frm.cokluTarih = cariTarih
            frm.cokluMusteri = True
            frm.emir_musteri_takipMi = True
            frm.emir_musteri_takip_kartID = ""
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eþittir"
            frm.islemstatus = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
End Class
