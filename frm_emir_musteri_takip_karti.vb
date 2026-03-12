Imports DevExpress.XtraEditors
Public Class frm_emir_musteri_takip_karti
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
    Friend WithEvents sec_personel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_odendi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_tutar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_takiptipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_takip_aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_tarih As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_musterikodu As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_musteri_adi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_musteri_soyadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_musteri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_iletisim_tarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_iletisim_sekli As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ilgili As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_gelecekmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_gelecek_tarih As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_istihbarat As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents sec_sonuc As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_aciklama1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_aciklama2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_aciklama4 As DevExpress.XtraEditors.MemoEdit
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
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents sec_status As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_aciklama3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents txt_saat As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents txt_sGSM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nMusteriID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilecek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOnayTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_SinifKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colMusteriKodlu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents colsSec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataSet3 As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_musteri_takip_karti))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.DataSet2 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilecek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_SinifKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMusteriKodlu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_saat = New DevExpress.XtraEditors.TimeEdit()
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
        Me.sec_status = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_aciklama4 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama3 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama2 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama1 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label16 = New DevExpress.XtraEditors.LabelControl()
        Me.Label15 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sonuc = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_istihbarat = New DevExpress.XtraEditors.MemoEdit()
        Me.Label14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_gelecek_tarih = New DevExpress.XtraEditors.DateEdit()
        Me.sec_gelecekmi = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_ilgili = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_iletisim_sekli = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_iletisim_tarihi = New DevExpress.XtraEditors.DateEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_nMusteriID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sGSM = New DevExpress.XtraEditors.TextEdit()
        Me.sec_odendi = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_tutar = New DevExpress.XtraEditors.CalcEdit()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteri = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteri_soyadi = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteri_adi = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musterikodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tarih = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_takip_aciklama = New DevExpress.XtraEditors.MemoEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_takiptipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_personel = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.DataSet3 = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_SinifKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_saat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sonuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_istihbarat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_gelecek_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_gelecek_tarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_gelecekmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ilgili.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_iletisim_sekli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_iletisim_tarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_iletisim_tarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_nMusteriID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_odendi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteri_soyadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteri_adi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterikodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_takip_aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_takiptipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_personel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colMevcut
        '
        Me.colMevcut.Caption = "Mevcut"
        Me.colMevcut.DisplayFormat.FormatString = "#,0.00"
        Me.colMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMevcut.FieldName = "Mevcut"
        Me.colMevcut.Name = "colMevcut"
        Me.colMevcut.OptionsColumn.AllowEdit = False
        Me.colMevcut.Visible = True
        Me.colMevcut.VisibleIndex = 11
        Me.colMevcut.Width = 116
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
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(515, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(309, 52)
        Me.lbl_istihbarat.TabIndex = 11
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 11)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Müþteri Takip Emri Bilgilendirme Ekraný..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 619)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(826, 42)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(302, 11)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton6.TabIndex = 13
        Me.SimpleButton6.Text = "Ürünleri Seç"
        Me.SimpleButton6.Visible = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(104, 11)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton5.TabIndex = 12
        Me.SimpleButton5.Text = "&SMS Gönder"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Enabled = False
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(200, 11)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton4.TabIndex = 11
        Me.SimpleButton4.Text = "A&jandaya At"
        Me.SimpleButton4.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 11)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "&Müþteri"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(740, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(660, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(826, 563)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SimpleButton7)
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(2, 316)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(822, 245)
        Me.GroupControl3.TabIndex = 27
        Me.GroupControl3.Text = "Ürünler"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Location = New System.Drawing.Point(9, 218)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton7.TabIndex = 14
        Me.SimpleButton7.Text = "Tümünü Seç"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet2
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 15)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_SinifKodu})
        Me.GridControl1.Size = New System.Drawing.Size(818, 228)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem1.Text = "Tamam"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem2.Text = "Vazgeç"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem6.Text = "Müþteri Seç"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 5
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem3.Text = "Müþteri Kartýný Göster"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 6
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem4.Text = "Takibi Ajandaya Al"
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "lKodu"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Musteri"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sKodu"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sModel"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sRenk"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sRenkAdi"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sBeden"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sKavala"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sAciklama"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Miktar"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "lBrutFiyat"
        Me.DataColumn37.DataType = GetType(Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Tutar"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Depo"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "lFaturaNo"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "dteFaturaTarihi"
        Me.DataColumn41.DataType = GetType(Date)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "dteTeslimEdilecek"
        Me.DataColumn42.DataType = GetType(Date)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "dteOnayTarihi"
        Me.DataColumn43.DataType = GetType(Date)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "dteTeslimEdilen"
        Me.DataColumn44.DataType = GetType(Date)
        '
        'DataColumn45
        '
        Me.DataColumn45.Caption = "id"
        Me.DataColumn45.ColumnName = "id"
        Me.DataColumn45.DataType = GetType(Integer)
        '
        'DataColumn46
        '
        Me.DataColumn46.Caption = "IND"
        Me.DataColumn46.ColumnName = "IND"
        Me.DataColumn46.DataType = GetType(Integer)
        '
        'DataColumn47
        '
        Me.DataColumn47.Caption = "Seç"
        Me.DataColumn47.ColumnName = "Sec"
        Me.DataColumn47.DataType = GetType(Boolean)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collKodu, Me.colMusteri, Me.colsKodu, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsKavala, Me.colsAciklama, Me.colMiktar, Me.collBrutFiyat, Me.colTutar, Me.colDepo, Me.collFaturaNo, Me.coldteFaturaTarihi, Me.coldteTeslimEdilecek, Me.coldteOnayTarihi, Me.coldteTeslimEdilen, Me.colIZAHAT, Me.colMevcut, Me.colsSinifKodu1, Me.colMusteriKodlu, Me.colSINIF2, Me.colsSaticiRumuzu, Me.colsSatici, Me.colsSec})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(342, 287, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colMevcut
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colMevcut
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.colsKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Me.colMiktar, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Me.colTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, " :{0} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "Toplam : {0:#,0.##} Adet"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Nothing, "ToplamTutar: {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.OptionsColumn.AllowEdit = False
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 4
        Me.collKodu.Width = 85
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Müþteri Adý"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.OptionsColumn.AllowEdit = False
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 5
        Me.colMusteri.Width = 141
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.OptionsColumn.AllowEdit = False
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 6
        Me.colsKodu.Width = 80
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "RenkKodu"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk Adý"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.OptionsColumn.AllowEdit = False
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 8
        Me.colsRenkAdi.Width = 76
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsKavala
        '
        Me.colsKavala.Caption = "Kavala"
        Me.colsKavala.FieldName = "sKavala"
        Me.colsKavala.Name = "colsKavala"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowEdit = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 7
        Me.colsAciklama.Width = 127
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Miktar"
        Me.colMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.OptionsColumn.AllowEdit = False
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.00}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 9
        Me.colMiktar.Width = 76
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Birim Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Width = 44
        '
        'colTutar
        '
        Me.colTutar.Caption = "Tutar"
        Me.colTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:#,0.00}")})
        Me.colTutar.Width = 38
        '
        'colDepo
        '
        Me.colDepo.Caption = "Depo"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.OptionsColumn.AllowEdit = False
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 10
        Me.colDepo.Width = 165
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "Fiþ No"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.OptionsColumn.AllowEdit = False
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 3
        Me.collFaturaNo.Width = 83
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.OptionsColumn.AllowEdit = False
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 2
        Me.coldteFaturaTarihi.Width = 73
        '
        'coldteTeslimEdilecek
        '
        Me.coldteTeslimEdilecek.Caption = "Termin Tarihi"
        Me.coldteTeslimEdilecek.FieldName = "dteTeslimEdilecek"
        Me.coldteTeslimEdilecek.Name = "coldteTeslimEdilecek"
        '
        'coldteOnayTarihi
        '
        Me.coldteOnayTarihi.Caption = "Onay Tarihi"
        Me.coldteOnayTarihi.FieldName = "dteOnayTarihi"
        Me.coldteOnayTarihi.Name = "coldteOnayTarihi"
        '
        'coldteTeslimEdilen
        '
        Me.coldteTeslimEdilen.Caption = "Teslim Tarihi"
        Me.coldteTeslimEdilen.FieldName = "dteTeslimEdilen"
        Me.coldteTeslimEdilen.Name = "coldteTeslimEdilen"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Ýzahat"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.OptionsColumn.AllowEdit = False
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 1
        Me.colIZAHAT.Width = 61
        '
        'colsSinifKodu1
        '
        Me.colsSinifKodu1.Caption = "Firma"
        Me.colsSinifKodu1.ColumnEdit = Me.sec_SinifKodu
        Me.colsSinifKodu1.FieldName = "sSinifKodu1"
        Me.colsSinifKodu1.Name = "colsSinifKodu1"
        '
        'sec_SinifKodu
        '
        Me.sec_SinifKodu.AutoHeight = False
        Me.sec_SinifKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_SinifKodu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sSinifKodu1", "SýnýfKodu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açýklama")})
        Me.sec_SinifKodu.DisplayMember = "sAciklama"
        Me.sec_SinifKodu.Name = "sec_SinifKodu"
        Me.sec_SinifKodu.ShowFooter = False
        Me.sec_SinifKodu.ShowHeader = False
        Me.sec_SinifKodu.ShowLines = False
        Me.sec_SinifKodu.ValueMember = "sSinifKodu"
        '
        'colMusteriKodlu
        '
        Me.colMusteriKodlu.Caption = "Müþteri"
        Me.colMusteriKodlu.FieldName = "MusteriKodlu"
        Me.colMusteriKodlu.Name = "colMusteriKodlu"
        '
        'colSINIF2
        '
        Me.colSINIF2.Caption = "TeslimatÞekli"
        Me.colSINIF2.FieldName = "SINIF2"
        Me.colSINIF2.Name = "colSINIF2"
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "SaticiRumuzu"
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        '
        'colsSatici
        '
        Me.colsSatici.Caption = "Satici"
        Me.colsSatici.FieldName = "sSatici"
        Me.colsSatici.Name = "colsSatici"
        Me.colsSatici.Width = 152
        '
        'colsSec
        '
        Me.colsSec.Caption = "Seç"
        Me.colsSec.FieldName = "Sec"
        Me.colsSec.Name = "colsSec"
        Me.colsSec.Visible = True
        Me.colsSec.VisibleIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_saat)
        Me.GroupControl2.Controls.Add(Me.sec_status)
        Me.GroupControl2.Controls.Add(Me.txt_aciklama4)
        Me.GroupControl2.Controls.Add(Me.Label19)
        Me.GroupControl2.Controls.Add(Me.txt_aciklama3)
        Me.GroupControl2.Controls.Add(Me.Label18)
        Me.GroupControl2.Controls.Add(Me.txt_aciklama2)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.txt_aciklama1)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.Label15)
        Me.GroupControl2.Controls.Add(Me.sec_sonuc)
        Me.GroupControl2.Controls.Add(Me.txt_istihbarat)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.txt_gelecek_tarih)
        Me.GroupControl2.Controls.Add(Me.sec_gelecekmi)
        Me.GroupControl2.Controls.Add(Me.txt_ilgili)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.sec_iletisim_sekli)
        Me.GroupControl2.Controls.Add(Me.txt_iletisim_tarihi)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 140)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(822, 421)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Notlar:"
        '
        'txt_saat
        '
        Me.txt_saat.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.IletisimTarihi", True))
        Me.txt_saat.EditValue = New Date(2007, 4, 18, 0, 0, 0, 0)
        Me.txt_saat.EnterMoveNextControl = True
        Me.txt_saat.Location = New System.Drawing.Point(200, 15)
        Me.txt_saat.Name = "txt_saat"
        Me.txt_saat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_saat.Size = New System.Drawing.Size(88, 20)
        Me.txt_saat.TabIndex = 1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn5, Me.DataColumn6, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
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
        Me.DataColumn2.DataType = GetType(Date)
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
        Me.DataColumn26.ColumnName = "sGSM"
        '
        'sec_status
        '
        Me.sec_status.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Status", True))
        Me.sec_status.Location = New System.Drawing.Point(384, 145)
        Me.sec_status.Name = "sec_status"
        Me.sec_status.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_status.Properties.Appearance.Options.UseFont = True
        Me.sec_status.Properties.Caption = "Tamamlandý ?"
        Me.sec_status.Size = New System.Drawing.Size(192, 19)
        Me.sec_status.TabIndex = 12
        '
        'txt_aciklama4
        '
        Me.txt_aciklama4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Aciklama4", True))
        Me.txt_aciklama4.EnterMoveNextControl = True
        Me.txt_aciklama4.Location = New System.Drawing.Point(384, 113)
        Me.txt_aciklama4.Name = "txt_aciklama4"
        Me.txt_aciklama4.Properties.MaxLength = 100
        Me.txt_aciklama4.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama4.Size = New System.Drawing.Size(427, 32)
        Me.txt_aciklama4.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(304, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Not4 :"
        '
        'txt_aciklama3
        '
        Me.txt_aciklama3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Aciklama3", True))
        Me.txt_aciklama3.EnterMoveNextControl = True
        Me.txt_aciklama3.Location = New System.Drawing.Point(384, 81)
        Me.txt_aciklama3.Name = "txt_aciklama3"
        Me.txt_aciklama3.Properties.MaxLength = 100
        Me.txt_aciklama3.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama3.Size = New System.Drawing.Size(427, 32)
        Me.txt_aciklama3.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(304, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Not3 :"
        '
        'txt_aciklama2
        '
        Me.txt_aciklama2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Aciklama2", True))
        Me.txt_aciklama2.EnterMoveNextControl = True
        Me.txt_aciklama2.Location = New System.Drawing.Point(384, 49)
        Me.txt_aciklama2.Name = "txt_aciklama2"
        Me.txt_aciklama2.Properties.MaxLength = 100
        Me.txt_aciklama2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama2.Size = New System.Drawing.Size(427, 32)
        Me.txt_aciklama2.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(304, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Not2 :"
        '
        'txt_aciklama1
        '
        Me.txt_aciklama1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Aciklama1", True))
        Me.txt_aciklama1.EnterMoveNextControl = True
        Me.txt_aciklama1.Location = New System.Drawing.Point(384, 17)
        Me.txt_aciklama1.Name = "txt_aciklama1"
        Me.txt_aciklama1.Properties.MaxLength = 100
        Me.txt_aciklama1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama1.Size = New System.Drawing.Size(427, 32)
        Me.txt_aciklama1.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(304, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Not1 :"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Sonuç:"
        '
        'sec_sonuc
        '
        Me.sec_sonuc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Sonuc", True))
        Me.sec_sonuc.EditValue = "Bekliyor"
        Me.sec_sonuc.EnterMoveNextControl = True
        Me.sec_sonuc.Location = New System.Drawing.Point(88, 154)
        Me.sec_sonuc.Name = "sec_sonuc"
        Me.sec_sonuc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sonuc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sonuc.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_sonuc.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sonuc.Properties.Appearance.Options.UseFont = True
        Me.sec_sonuc.Properties.Appearance.Options.UseForeColor = True
        Me.sec_sonuc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sonuc.Properties.Items.AddRange(New Object() {"Bekliyor", "Onaylandý", "Hazýrlandý", "Gönderildi", "Yüklendi", "Teslim Edildi", "Tamamlandý", "Görüþülüyor", "Görüþüldü", "Haber Verildi", "Mektup Hazýrla", "Mektup Gönder", "Mektup Gönderildi", "Sms Gönder", "Sms Gönderildi", "Arandý", "Diðer"})
        Me.sec_sonuc.Properties.MaxLength = 20
        Me.sec_sonuc.Size = New System.Drawing.Size(200, 20)
        Me.sec_sonuc.TabIndex = 7
        '
        'txt_istihbarat
        '
        Me.txt_istihbarat.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Istihbarat", True))
        Me.txt_istihbarat.EnterMoveNextControl = True
        Me.txt_istihbarat.Location = New System.Drawing.Point(88, 99)
        Me.txt_istihbarat.Name = "txt_istihbarat"
        Me.txt_istihbarat.Properties.MaxLength = 255
        Me.txt_istihbarat.Size = New System.Drawing.Size(200, 54)
        Me.txt_istihbarat.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Açýklama :"
        '
        'txt_gelecek_tarih
        '
        Me.txt_gelecek_tarih.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.GTarih", True))
        Me.txt_gelecek_tarih.EditValue = Nothing
        Me.txt_gelecek_tarih.Enabled = False
        Me.txt_gelecek_tarih.EnterMoveNextControl = True
        Me.txt_gelecek_tarih.Location = New System.Drawing.Point(88, 78)
        Me.txt_gelecek_tarih.Name = "txt_gelecek_tarih"
        Me.txt_gelecek_tarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_gelecek_tarih.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_gelecek_tarih.Size = New System.Drawing.Size(200, 20)
        Me.txt_gelecek_tarih.TabIndex = 5
        '
        'sec_gelecekmi
        '
        Me.sec_gelecekmi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Gelecekmi", True))
        Me.sec_gelecekmi.Location = New System.Drawing.Point(8, 81)
        Me.sec_gelecekmi.Name = "sec_gelecekmi"
        Me.sec_gelecekmi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_gelecekmi.Properties.Appearance.Options.UseFont = True
        Me.sec_gelecekmi.Properties.Caption = "Gelecek mi?"
        Me.sec_gelecekmi.Size = New System.Drawing.Size(80, 19)
        Me.sec_gelecekmi.TabIndex = 4
        '
        'txt_ilgili
        '
        Me.txt_ilgili.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.IlgiliKisi", True))
        Me.txt_ilgili.EnterMoveNextControl = True
        Me.txt_ilgili.Location = New System.Drawing.Point(88, 57)
        Me.txt_ilgili.Name = "txt_ilgili"
        Me.txt_ilgili.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ilgili.Properties.Appearance.Options.UseForeColor = True
        Me.txt_ilgili.Properties.MaxLength = 50
        Me.txt_ilgili.Size = New System.Drawing.Size(200, 20)
        Me.txt_ilgili.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Ýlgili Kiþi:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "ÝletiþimÞekli:"
        '
        'sec_iletisim_sekli
        '
        Me.sec_iletisim_sekli.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.IletisimSekli", True))
        Me.sec_iletisim_sekli.EditValue = ""
        Me.sec_iletisim_sekli.EnterMoveNextControl = True
        Me.sec_iletisim_sekli.Location = New System.Drawing.Point(88, 36)
        Me.sec_iletisim_sekli.Name = "sec_iletisim_sekli"
        Me.sec_iletisim_sekli.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.sec_iletisim_sekli.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_iletisim_sekli.Properties.Appearance.Options.UseBackColor = True
        Me.sec_iletisim_sekli.Properties.Appearance.Options.UseFont = True
        Me.sec_iletisim_sekli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_iletisim_sekli.Properties.Items.AddRange(New Object() {"Telefon", "Fax", "Sms", "Mektup", "Avukat", "Ýcra", "Komþu", "Aile", "Hatýrlatma", "Görüþme", "Ziyaret", "Bilgi Sorma", "Bilgilendirme", "Diðer"})
        Me.sec_iletisim_sekli.Properties.MaxLength = 50
        Me.sec_iletisim_sekli.Size = New System.Drawing.Size(200, 20)
        Me.sec_iletisim_sekli.TabIndex = 2
        '
        'txt_iletisim_tarihi
        '
        Me.txt_iletisim_tarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.IletisimTarihi", True))
        Me.txt_iletisim_tarihi.EditValue = Nothing
        Me.txt_iletisim_tarihi.EnterMoveNextControl = True
        Me.txt_iletisim_tarihi.Location = New System.Drawing.Point(88, 15)
        Me.txt_iletisim_tarihi.Name = "txt_iletisim_tarihi"
        Me.txt_iletisim_tarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_iletisim_tarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_iletisim_tarihi.Size = New System.Drawing.Size(112, 20)
        Me.txt_iletisim_tarihi.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "ÝletiþimTarihi:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_nMusteriID)
        Me.GroupControl1.Controls.Add(Me.txt_sGSM)
        Me.GroupControl1.Controls.Add(Me.sec_odendi)
        Me.GroupControl1.Controls.Add(Me.txt_tutar)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txt_musteri)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txt_musteri_soyadi)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.txt_musteri_adi)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txt_musterikodu)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txt_tarih)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txt_takip_aciklama)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_takiptipi)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.sec_personel)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(822, 138)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Tanýmlar"
        '
        'txt_nMusteriID
        '
        Me.txt_nMusteriID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.nMusteriID", True))
        Me.txt_nMusteriID.Enabled = False
        Me.txt_nMusteriID.EnterMoveNextControl = True
        Me.txt_nMusteriID.Location = New System.Drawing.Point(384, 19)
        Me.txt_nMusteriID.Name = "txt_nMusteriID"
        Me.txt_nMusteriID.Properties.MaxLength = 50
        Me.txt_nMusteriID.Size = New System.Drawing.Size(96, 20)
        Me.txt_nMusteriID.TabIndex = 26
        '
        'txt_sGSM
        '
        Me.txt_sGSM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sGSM", True))
        Me.txt_sGSM.Enabled = False
        Me.txt_sGSM.EnterMoveNextControl = True
        Me.txt_sGSM.Location = New System.Drawing.Point(384, 85)
        Me.txt_sGSM.Name = "txt_sGSM"
        Me.txt_sGSM.Properties.MaxLength = 50
        Me.txt_sGSM.Size = New System.Drawing.Size(192, 20)
        Me.txt_sGSM.TabIndex = 25
        '
        'sec_odendi
        '
        Me.sec_odendi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Odendi", True))
        Me.sec_odendi.Location = New System.Drawing.Point(512, 108)
        Me.sec_odendi.Name = "sec_odendi"
        Me.sec_odendi.Properties.Caption = "Ödendi?"
        Me.sec_odendi.Size = New System.Drawing.Size(62, 19)
        Me.sec_odendi.TabIndex = 9
        '
        'txt_tutar
        '
        Me.txt_tutar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Tutar", True))
        Me.txt_tutar.EnterMoveNextControl = True
        Me.txt_tutar.Location = New System.Drawing.Point(384, 107)
        Me.txt_tutar.Name = "txt_tutar"
        Me.txt_tutar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tutar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_tutar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_tutar.Properties.Appearance.Options.UseBackColor = True
        Me.txt_tutar.Properties.Appearance.Options.UseFont = True
        Me.txt_tutar.Properties.Appearance.Options.UseForeColor = True
        Me.txt_tutar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tutar.Properties.NullText = "0"
        Me.txt_tutar.Size = New System.Drawing.Size(96, 20)
        Me.txt_tutar.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(304, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Tutar :"
        '
        'txt_musteri
        '
        Me.txt_musteri.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Musteri", True))
        Me.txt_musteri.Enabled = False
        Me.txt_musteri.EnterMoveNextControl = True
        Me.txt_musteri.Location = New System.Drawing.Point(384, 63)
        Me.txt_musteri.Name = "txt_musteri"
        Me.txt_musteri.Properties.MaxLength = 50
        Me.txt_musteri.Size = New System.Drawing.Size(192, 20)
        Me.txt_musteri.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(304, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "GSM :"
        '
        'txt_musteri_soyadi
        '
        Me.txt_musteri_soyadi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sSoyadi", True))
        Me.txt_musteri_soyadi.Enabled = False
        Me.txt_musteri_soyadi.EnterMoveNextControl = True
        Me.txt_musteri_soyadi.Location = New System.Drawing.Point(480, 41)
        Me.txt_musteri_soyadi.Name = "txt_musteri_soyadi"
        Me.txt_musteri_soyadi.Properties.MaxLength = 50
        Me.txt_musteri_soyadi.Size = New System.Drawing.Size(95, 20)
        Me.txt_musteri_soyadi.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(304, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Müþteri :"
        '
        'txt_musteri_adi
        '
        Me.txt_musteri_adi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAdi", True))
        Me.txt_musteri_adi.Enabled = False
        Me.txt_musteri_adi.EnterMoveNextControl = True
        Me.txt_musteri_adi.Location = New System.Drawing.Point(384, 41)
        Me.txt_musteri_adi.Name = "txt_musteri_adi"
        Me.txt_musteri_adi.Properties.MaxLength = 50
        Me.txt_musteri_adi.Size = New System.Drawing.Size(96, 20)
        Me.txt_musteri_adi.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(304, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Adý :"
        '
        'txt_musterikodu
        '
        Me.txt_musterikodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.lKodu", True))
        Me.txt_musterikodu.EnterMoveNextControl = True
        Me.txt_musterikodu.Location = New System.Drawing.Point(479, 19)
        Me.txt_musterikodu.Name = "txt_musterikodu"
        Me.txt_musterikodu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musterikodu.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musterikodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musterikodu.Properties.MaxLength = 50
        Me.txt_musterikodu.Size = New System.Drawing.Size(96, 20)
        Me.txt_musterikodu.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(304, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MüþteriNo :"
        '
        'txt_tarih
        '
        Me.txt_tarih.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.dteTarih", True))
        Me.txt_tarih.EditValue = Nothing
        Me.txt_tarih.EnterMoveNextControl = True
        Me.txt_tarih.Location = New System.Drawing.Point(88, 19)
        Me.txt_tarih.Name = "txt_tarih"
        Me.txt_tarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_tarih.Properties.Appearance.Options.UseBackColor = True
        Me.txt_tarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tarih.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_tarih.Size = New System.Drawing.Size(200, 20)
        Me.txt_tarih.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tarih :"
        '
        'txt_takip_aciklama
        '
        Me.txt_takip_aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TakipAciklama", True))
        Me.txt_takip_aciklama.EnterMoveNextControl = True
        Me.txt_takip_aciklama.Location = New System.Drawing.Point(88, 85)
        Me.txt_takip_aciklama.Name = "txt_takip_aciklama"
        Me.txt_takip_aciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_takip_aciklama.Properties.Appearance.Options.UseForeColor = True
        Me.txt_takip_aciklama.Properties.MaxLength = 255
        Me.txt_takip_aciklama.Size = New System.Drawing.Size(200, 47)
        Me.txt_takip_aciklama.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Açýklama :"
        '
        'sec_takiptipi
        '
        Me.sec_takiptipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TakipTipi", True))
        Me.sec_takiptipi.EditValue = "Telefon"
        Me.sec_takiptipi.EnterMoveNextControl = True
        Me.sec_takiptipi.Location = New System.Drawing.Point(88, 63)
        Me.sec_takiptipi.Name = "sec_takiptipi"
        Me.sec_takiptipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_takiptipi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_takiptipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_takiptipi.Properties.Appearance.Options.UseFont = True
        Me.sec_takiptipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_takiptipi.Properties.Items.AddRange(New Object() {"Teslimat", "Kontrol", "Takip", "Telefon", "Fax", "Sms", "Mektup", "Avukat", "Ýcra", "Müþteri Sorma", "Adres Sorma", "Hatýrlatma", "Tanýþma", "Tatil", "Promosyon", "Hediye", "Görüþme", "Kutlama", "Ziyaret", "Bilgi Sorma", "Bilgilendirme", "Diðer"})
        Me.sec_takiptipi.Size = New System.Drawing.Size(200, 20)
        Me.sec_takiptipi.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TakipTipi :"
        '
        'sec_personel
        '
        Me.sec_personel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.PersonelNo", True))
        Me.sec_personel.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.PersonelNo", True))
        Me.sec_personel.EnterMoveNextControl = True
        Me.sec_personel.Location = New System.Drawing.Point(88, 41)
        Me.sec_personel.Name = "sec_personel"
        Me.sec_personel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_personel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_personel.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_personel.Properties.Appearance.Options.UseBackColor = True
        Me.sec_personel.Properties.Appearance.Options.UseFont = True
        Me.sec_personel.Properties.Appearance.Options.UseForeColor = True
        Me.sec_personel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_personel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Personeller")})
        Me.sec_personel.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_personel.Properties.NullText = "[Personeller]"
        Me.sec_personel.Properties.ShowFooter = False
        Me.sec_personel.Properties.ShowHeader = False
        Me.sec_personel.Properties.ValueMember = "IND"
        Me.sec_personel.Size = New System.Drawing.Size(200, 20)
        Me.sec_personel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Personel :"
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "NewDataSet"
        Me.DataSet3.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet3.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "lKodu"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "Musteri"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "sKodu"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "sModel"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "sRenk"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "sRenkAdi"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "sBeden"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "sKavala"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "sAciklama"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "Miktar"
        Me.DataColumn57.DataType = GetType(Decimal)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "lBrutFiyat"
        Me.DataColumn58.DataType = GetType(Decimal)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "Tutar"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "Depo"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "lFaturaNo"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "dteFaturaTarihi"
        Me.DataColumn62.DataType = GetType(Date)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "dteTeslimEdilecek"
        Me.DataColumn63.DataType = GetType(Date)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "dteOnayTarihi"
        Me.DataColumn64.DataType = GetType(Date)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "dteTeslimEdilen"
        Me.DataColumn65.DataType = GetType(Date)
        '
        'DataColumn66
        '
        Me.DataColumn66.Caption = "id"
        Me.DataColumn66.ColumnName = "id"
        Me.DataColumn66.DataType = GetType(Integer)
        '
        'DataColumn67
        '
        Me.DataColumn67.Caption = "IND"
        Me.DataColumn67.ColumnName = "IND"
        Me.DataColumn67.DataType = GetType(Integer)
        '
        'DataColumn68
        '
        Me.DataColumn68.Caption = "Seç"
        Me.DataColumn68.ColumnName = "Sec"
        Me.DataColumn68.DataType = GetType(Boolean)
        '
        'frm_emir_musteri_takip_karti
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(826, 661)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_emir_musteri_takip_karti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Takip Kartý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_SinifKodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txt_saat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sonuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_istihbarat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_gelecek_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_gelecek_tarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_gelecekmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ilgili.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_iletisim_sekli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_iletisim_tarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_iletisim_tarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_nMusteriID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_odendi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteri_soyadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteri_adi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterikodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_takip_aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_takiptipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_personel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public firmakodu As String
    Public tarih1
    Public tarih2
    Public qfirmakodu
    Public islemstatus As Boolean = False
    Dim ds_kasiyer As DataSet
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    Dim ds_hareket As DataSet
    Dim urunUpdate As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS IND, '[Tümü]' AS ACIKLAMA, '1111' AS SIFRE FROM APERSONEL UNION SELECT IND, PERSONELADI AS ACIKLAMA, SIFRE FROM APERSONEL "))
        sec_personel.Properties.DataSource = ds_kasiyer.Tables(0)
        If status = False Then
            sec_personel.EditValue = kasiyerno
            sec_personel.Text = kasiyer
            sec_personel.ItemIndex = 1
        End If
        'sec_personel.ItemIndex = 1
        'sec_personel.Refresh()
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        con.ConnectionString = connection
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
    Private Sub musteri()
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = txt_musterikodu.EditValue
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            'dr("FIRMAKODU") = Microsoft.VisualBasic.Left(dr1("lKodu"), 50)
            'dr("FIRMAADI") = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
            'dr("YETKILI") = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
            'dr("ADRES") = dr1("sEvAdresi")
            'dr("TELEFON") = dr1("sEvTelefonu")
            txt_nMusteriID.EditValue = Microsoft.VisualBasic.Left(Trim(dr1("nMusteriID")), 50)
            txt_musterikodu.EditValue = Microsoft.VisualBasic.Left(Trim(dr1("lKodu")), 50)
            txt_musteri.EditValue = Microsoft.VisualBasic.Left(dr1("Musteri"), 50)
            txt_musteri_adi.EditValue = Microsoft.VisualBasic.Left(dr1("sAdi"), 50)
            txt_musteri_soyadi.EditValue = Microsoft.VisualBasic.Left(dr1("sSoyadi"), 50)
            txt_sGSM.EditValue = Microsoft.VisualBasic.Left(dr1("sGSM"), 50)
            analiz_musteri_istihbarat()
            UrunlerGetir()
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If txt_musterikodu.Text <> "" Then
            Dim nMusteriID = analiz_musteri_kayitno(Trim(txt_musterikodu.Text))
            If nMusteriID > 0 Then
                Dim frm As New frm_musteri_karti
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.musterino = txt_musterikodu.Text
                frm.musteriID = nMusteriID
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
                analiz_musteri_istihbarat()
            End If
        End If
    End Sub
    Private Sub analiz_musteri_istihbarat()
        If txt_musterikodu.Text <> "" Then
            Dim nMusteriID = analiz_musteri_kayitno(Trim(txt_musterikodu.Text))
            If nMusteriID > 0 Then
                lbl_istihbarat.Text = analiz_musteri_aciklamalar(Trim(txt_musterikodu.Text)).ToString
            Else
                lbl_istihbarat.Text = ""
            End If
            nMusteriID = Nothing
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
    Private Function analiz_musteri_aciklamalar(ByVal kod As String) As String
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
        Dim kayitsayisi As String
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sAciklama1 + ' ' + sAciklama2 + ' ' + sAciklama3 + ' ' + sAciklama4 + ' ' + sAciklama5,'') AS ISTIHBARAT FROM         tbMusteri " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub analiz_ajanda_kayit(ByVal kayitno As String)
        Dim kriter
        kriter = "WHERE FirmaTipi =1 and FirmaNo <> 0 and MusteriTakipIND <> 0 AND (MusteriTakipIND = '" & kayitno & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE From         aEmirAjanda " & kriter & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub dataload()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     aEmirMusteriTakip.*, tbMusteri.sGSM AS sGSM FROM         aEmirMusteriTakip LEFT OUTER JOIN                       tbMusteri ON aEmirMusteriTakip.nMusteriID = tbMusteri.nMusteriID WHERE aEmirMusteriTakip.IND =" & kayitno & "")
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        con.Close()
    End Sub
    Private Function ekle(ByVal dteTarih As DateTime, ByVal TakipTipi As String, ByVal TakipAciklama As String, ByVal PersonelNo As Int64, ByVal Personel As String, ByVal nMusteriID As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal Musteri As String, ByVal Sonuc As String, ByVal IletisimTarihi As DateTime, ByVal IletisimSekli As String, ByVal IlgiliKisi As String, ByVal Gelecekmi As Byte, ByVal GTarih As DateTime, ByVal Tutar As Decimal, ByVal Odendi As Byte, ByVal Istihbarat As String, ByVal Aciklama1 As String, ByVal Aciklama2 As String, ByVal Aciklama3 As String, ByVal Aciklama4 As String, ByVal Status As Byte)
        con.ConnectionString = connection
        cmd.Connection = con
        Dim geriVeri As String = ""
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirMusteriTakip(dteTarih, TakipTipi, TakipAciklama, PersonelNo, Personel, nMusteriID,lKodu, sAdi, sSoyadi, Musteri, Sonuc, IletisimTarihi, IletisimSekli, IlgiliKisi, Gelecekmi, GTarih, Tutar, Odendi, Istihbarat, Aciklama1, Aciklama2, Aciklama3, Aciklama4, Status,KayitTarihi,ErisimTarihi) VALUES     ('" & dteTarih & "', '" & TakipTipi & "', '" & TakipAciklama & "', " & PersonelNo & ", '" & Personel & "','" & nMusteriID & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & Musteri & "', '" & Sonuc & "', '" & IletisimTarihi & "', '" & IletisimSekli & "', '" & IlgiliKisi & "', " & Gelecekmi & ", '" & GTarih & "', " & Tutar & " , " & Odendi & ", '" & Istihbarat & "', '" & Aciklama1 & "', '" & Aciklama2 & "', '" & Aciklama3 & "', '" & Aciklama4 & "', " & Status & " ,'" & Now & "','" & Now & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        geriVeri = cmd.ExecuteScalar().ToString()
        Status = True
        con.Close()
        Return geriVeri
    End Function
    Private Sub duzelt(ByVal IND As Int64, ByVal dteTarih As DateTime, ByVal TakipTipi As String, ByVal TakipAciklama As String, ByVal PersonelNo As Int64, ByVal Personel As String, ByVal nMusteriID As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal Musteri As String, ByVal Sonuc As String, ByVal IletisimTarihi As DateTime, ByVal IletisimSekli As String, ByVal IlgiliKisi As String, ByVal Gelecekmi As Byte, ByVal GTarih As DateTime, ByVal Tutar As Decimal, ByVal Odendi As Byte, ByVal Istihbarat As String, ByVal Aciklama1 As String, ByVal Aciklama2 As String, ByVal Aciklama3 As String, ByVal Aciklama4 As String, ByVal Status As Byte)
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirMusteriTakip SET              dteTarih = '" & dteTarih & "', TakipTipi = '" & TakipTipi & "', TakipAciklama = '" & TakipAciklama & "', PersonelNo = " & PersonelNo & ", Personel = '" & Personel & "', nMusteriID= '" & nMusteriID & "',lKodu = '" & lKodu & "', sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', Musteri = '" & Musteri & "', Sonuc = '" & Sonuc & "', IletisimTarihi = '" & IletisimTarihi & "', IletisimSekli = '" & IletisimSekli & "', IlgiliKisi = '" & IlgiliKisi & "', Gelecekmi = " & Gelecekmi & " , GTarih = '" & GTarih & "', Tutar = " & Tutar & " , Odendi = " & Odendi & " , Istihbarat = '" & Istihbarat & "', Aciklama1 = '" & Aciklama1 & "', Aciklama2 = '" & Aciklama2 & "', Aciklama3 = '" & Aciklama3 & "', Aciklama4 = '" & Aciklama4 & "', Status = " & Status & ",ErisimTarihi ='" & Now & "'  WHERE IND= '" & kayitno & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub sil(ByVal ID As Int64)
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirMusteriTakip  WHERE IND= '" & kayitno & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kontrol()
        If txt_musterikodu.Text <> "" Then
            'If GridView1.RowCount > 0 Then
            Dim nMusteriID = analiz_musteri_kayitno(Trim(txt_musterikodu.Text))
            If nMusteriID > 0 Then
                If status = False Then
                    'ekle(sec_hesaptipi.EditValue, txt_hesapno.EditValue, txt_hesap.EditValue, sec_personel.EditValue, 2, txt_konu.EditValue, txt_aciklama.EditValue, 0, Microsoft.VisualBasic.Left((txt_tarih_baslama.Text).ToString, 10) + " " + txt_saat_baslama.Text, Microsoft.VisualBasic.Left((txt_tarih_bitis.Text).ToString, 10) + " " + txt_saat_bitis.Text, txt_yer.EditValue, sec_hergun.Checked, 0, "", "", txt_tutar.EditValue, txt_pb.EditValue, sec_odendi.Checked, sec_gelecek.Checked, sec_tamamlandi.Checked)
                    ekleUrunler(ekle(txt_tarih.EditValue, sec_takiptipi.Text, txt_takip_aciklama.Text, sec_personel.EditValue, sec_personel.Text, nMusteriID, txt_musterikodu.Text, txt_musteri_adi.Text, txt_musteri_soyadi.Text, txt_musteri.Text, sec_sonuc.Text, Microsoft.VisualBasic.Left((txt_iletisim_tarihi.Text).ToString, 10) + " " + txt_saat.Text, sec_iletisim_sekli.Text, txt_ilgili.Text, sec_gelecekmi.Checked, txt_gelecek_tarih.EditValue, txt_tutar.EditValue, sec_odendi.Checked, txt_istihbarat.Text, txt_aciklama1.Text, txt_aciklama2.Text, txt_aciklama3.Text, txt_aciklama4.Text, sec_status.Checked), False)
                Else
                    'duzelt(kayitno, sec_hesaptipi.EditValue, (txt_hesapno.EditValue).ToString, (txt_hesap.EditValue).ToString, sec_personel.EditValue, 2, (txt_konu.EditValue).ToString, (txt_aciklama.EditValue).ToString, 0, Microsoft.VisualBasic.Left((txt_tarih_baslama.Text).ToString, 10) + " " + (txt_saat_baslama.Text).ToString, Microsoft.VisualBasic.Left((txt_tarih_bitis.Text).ToString, 10) + " " + (txt_saat_bitis.Text).ToString, (txt_yer.EditValue).ToString, sec_hergun.Checked, 0, "", "", txt_tutar.EditValue, (txt_pb.EditValue).ToString, sec_odendi.Checked, sec_gelecek.Checked, sec_tamamlandi.Checked)
                    duzelt(kayitno, txt_tarih.EditValue, sec_takiptipi.Text, txt_takip_aciklama.Text, sec_personel.EditValue, sec_personel.Text, nMusteriID, txt_musterikodu.Text, txt_musteri_adi.Text, txt_musteri_soyadi.Text, txt_musteri.Text, sec_sonuc.Text, Microsoft.VisualBasic.Left((txt_iletisim_tarihi.Text).ToString, 10) + " " + txt_saat.Text, sec_iletisim_sekli.Text, txt_ilgili.Text, sec_gelecekmi.Checked, txt_gelecek_tarih.EditValue, txt_tutar.EditValue, sec_odendi.Checked, txt_istihbarat.Text, txt_aciklama1.Text, txt_aciklama2.Text, txt_aciklama3.Text, txt_aciklama4.Text, sec_status.Checked)
                    'If urunUpdate = True Then
                    ekleUrunler(kayitno, True)
                    'End If
                End If
                If sec_gelecekmi.Checked = True Then
                    ajanda_aktar()
                ElseIf sec_gelecekmi.Checked = False Then
                    analiz_ajanda_kayit(kayitno)
                End If
                Me.Close()
            Else
            End If
            'Else
            '    XtraMessageBox.Show(Sorgu_sDil("Lütfen Ürünleri Ekleyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Müþteri Kayýt Bilgisini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_musterikodu.Focus()
        End If
    End Sub
    Private Sub txt_musterikodu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterikodu.ButtonClick
        musteri()
    End Sub
    Private Sub frm_emir_musteri_takip_karti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_tarih.EditValue = dteSistemTarihi
        txt_iletisim_tarihi.EditValue = "01.01.1900"
        txt_saat.EditValue = "00:00:00"
        txt_gelecek_tarih.EditValue = "01.01.1900"
        'dataload_kasiyer()
        If status = True Then
            dataload()
            analiz_musteri_istihbarat()
            UrunlerGetir()
        End If
        dataload_kasiyer()
    End Sub
    Private Sub sec_gelecekmi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_gelecekmi.CheckedChanged
        If sec_gelecekmi.Checked = False Then
            txt_gelecek_tarih.Enabled = False
            txt_gelecek_tarih.EditValue = "01.01.1900"
            SimpleButton4.Enabled = False
        ElseIf sec_gelecekmi.Checked = True Then
            txt_gelecek_tarih.Enabled = True
            txt_gelecek_tarih.Properties.MinValue = dteSistemTarihi
            If status = False Then
                txt_gelecek_tarih.EditValue = dteSistemTarihi
            End If
            SimpleButton4.Enabled = True
            'txt_gelecek_tarih.EditValue = "01.01.1900"
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        analiz_musteri_karti()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kontrol()
    End Sub
    Private Sub txt_musterikodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterikodu.KeyDown
        If e.KeyCode = Keys.F4 Then
            musteri()
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        musteri()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        kontrol()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
    Private Sub ajanda_aktar()
        Dim nMusteriID = analiz_musteri_kayitno(Trim(txt_musterikodu.Text))
        Dim reminderinfo As String = "<Reminder AlertTime=""" & Microsoft.VisualBasic.Left((txt_gelecek_tarih.Text).ToString, 10) & " 17:00:00"" TimeBeforeStart=""00:10:00"" />"
        If nMusteriID > 0 Then
            analiz_ajanda_kayit(kayitno)
            gorev_ekle(1, nMusteriID, txt_musteri.EditValue, sec_personel.EditValue, 2, Microsoft.VisualBasic.Left("Müþteri Takip Emri-Gelecek-" & txt_musteri.EditValue, 50), txt_takip_aciklama.Text, 0, Microsoft.VisualBasic.Left((txt_gelecek_tarih.EditValue).ToString, 10) + " " + "17:00:00", Microsoft.VisualBasic.Left((txt_gelecek_tarih.EditValue).ToString, 10) + " " + "18:00:00", "Kredi", False, 0, "", reminderinfo, txt_tutar.EditValue, "", 0, True, False, kayitno)
        Else
            'gorev_duzelt(1, nMusteriID, txt_musteri.EditValue, sec_personel.EditValue, 2, "Müþteri Takip Emri-Gelecek-" & txt_musteri.EditValue, txt_takip_aciklama.Text, 0, Microsoft.VisualBasic.Left((txt_gelecek_tarih.Text).ToString, 10) + " " + "17:00:00", Microsoft.VisualBasic.Left((txt_gelecek_tarih.Text).ToString, 10) + " " + "21:00:00", "Kredi", False, 0, "", "", txt_tutar.EditValue, "", 0, True, False, kayitno)
        End If
    End Sub
    Private Sub gorev_ekle(ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte, ByVal kayitno As Int64)
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi,MusteriTakipIND) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", NULL,'" & ReminderInfo & "', " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & "," & kayitno & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub gorev_duzelt(ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte, ByVal kayitno As Int64)
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirAjanda SET              FirmaTipi = " & FirmaTipi & ", FirmaNo = '" & FirmaNo & "', Firma = '" & Firma & "', PersonelNo = " & PersonelNo & ", Status = " & Status & ", Subject = '" & Subject & "', Description = '" & Description & "', StartTime = '" & StartTime & "', EndTime = '" & EndTime & "', Location = '" & Location & "', AllDay = " & AllDay & ", EventType = " & EventType & ",   Tutar = " & Tutar & ", Pb = '" & Pb & "', Odendi = " & Odendi & ", Gelecekmi = " & Gelecekmi & ", Tamamlandi = " & Tamamlandi & " WHERE MusteriTakipIND= '" & kayitno & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        'If txt_musterikodu.Text <> "" Then
        '    Dim nMusteriID = analiz_musteri_kayitno(Trim(txt_musterikodu.Text))
        '    If nMusteriID > 0 Then
        '        If status = False Then
        '            'ekle(sec_hesaptipi.EditValue, txt_hesapno.EditValue, txt_hesap.EditValue, sec_personel.EditValue, 2, txt_konu.EditValue, txt_aciklama.EditValue, 0, Microsoft.VisualBasic.Left((txt_tarih_baslama.Text).ToString, 10) + " " + txt_saat_baslama.Text, Microsoft.VisualBasic.Left((txt_tarih_bitis.Text).ToString, 10) + " " + txt_saat_bitis.Text, txt_yer.EditValue, sec_hergun.Checked, 0, "", "", txt_tutar.EditValue, txt_pb.EditValue, sec_odendi.Checked, sec_gelecek.Checked, sec_tamamlandi.Checked)
        '            ekle(txt_tarih.EditValue, sec_takiptipi.Text, txt_takip_aciklama.Text, sec_personel.EditValue, sec_personel.Text, nMusteriID, txt_musterikodu.Text, txt_musteri_adi.Text, txt_musteri_soyadi.Text, txt_musteri.Text, sec_sonuc.Text, Microsoft.VisualBasic.Left((txt_iletisim_tarihi.Text).ToString, 10) + " " + txt_saat.Text, sec_iletisim_sekli.Text, txt_ilgili.Text, sec_gelecekmi.Checked, txt_gelecek_tarih.EditValue, txt_tutar.EditValue, sec_odendi.Checked, txt_istihbarat.Text, txt_aciklama1.Text, txt_aciklama2.Text, txt_aciklama3.Text, txt_aciklama4.Text, sec_status.Checked)
        '        Else
        '            'duzelt(kayitno, sec_hesaptipi.EditValue, (txt_hesapno.EditValue).ToString, (txt_hesap.EditValue).ToString, sec_personel.EditValue, 2, (txt_konu.EditValue).ToString, (txt_aciklama.EditValue).ToString, 0, Microsoft.VisualBasic.Left((txt_tarih_baslama.Text).ToString, 10) + " " + (txt_saat_baslama.Text).ToString, Microsoft.VisualBasic.Left((txt_tarih_bitis.Text).ToString, 10) + " " + (txt_saat_bitis.Text).ToString, (txt_yer.EditValue).ToString, sec_hergun.Checked, 0, "", "", txt_tutar.EditValue, (txt_pb.EditValue).ToString, sec_odendi.Checked, sec_gelecek.Checked, sec_tamamlandi.Checked)
        '            duzelt(kayitno, txt_tarih.EditValue, sec_takiptipi.Text, txt_takip_aciklama.Text, sec_personel.EditValue, sec_personel.Text, nMusteriID, txt_musterikodu.Text, txt_musteri_adi.Text, txt_musteri_soyadi.Text, txt_musteri.Text, sec_sonuc.Text, Microsoft.VisualBasic.Left((txt_iletisim_tarihi.Text).ToString, 10) + " " + txt_saat.Text, sec_iletisim_sekli.Text, txt_ilgili.Text, sec_gelecekmi.Checked, txt_gelecek_tarih.EditValue, txt_tutar.EditValue, sec_odendi.Checked, txt_istihbarat.Text, txt_aciklama1.Text, txt_aciklama2.Text, txt_aciklama3.Text, txt_aciklama4.Text, sec_status.Checked)
        '        End If
        '        ajanda_aktar()
        '        XtraMessageBox.Show(Sorgu_sDil("Ajandaya Aktarýldý")
        '    Else
        '        XtraMessageBox.Show(Sorgu_sDil("Müþteri Kayýt Bilgisini Girmeniz Gerekmektedir...")
        '        txt_musterikodu.Focus()
        '    End If
        'Else
        '    XtraMessageBox.Show(Sorgu_sDil("Müþteri Kayýt Bilgisini Girmeniz Gerekmektedir...")
        '    txt_musterikodu.Focus()
        'End If
    End Sub
    Private Sub frm_emir_musteri_takip_karti_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'GroupControl1 = Nothing
        'sec_personel = Nothing
        'Label4 = Nothing
        'Label2 = Nothing
        'Label3 = Nothing
        'Label5 = Nothing
        'Label6 = Nothing
        'Label7 = Nothing
        'Label8 = Nothing
        'Label9 = Nothing
        'sec_odendi = Nothing
        'txt_tutar = Nothing
        'Label11 = Nothing
        'GroupControl2 = Nothing
        'Label10 = Nothing
        'Label12 = Nothing
        'Label13 = Nothing
        'Label14 = Nothing
        'Label15 = Nothing
        'Label16 = Nothing
        'Label17 = Nothing
        'Label18 = Nothing
        'Label19 = Nothing
        'SimpleButton3 = Nothing
        'SimpleButton4 = Nothing
        'sec_takiptipi = Nothing
        'txt_takip_aciklama = Nothing
        'txt_tarih = Nothing
        'txt_musterikodu = Nothing
        'txt_musteri_adi = Nothing
        'txt_musteri_soyadi = Nothing
        'txt_musteri = Nothing
        'txt_iletisim_tarihi = Nothing
        'sec_iletisim_sekli = Nothing
        'txt_ilgili = Nothing
        'sec_gelecekmi = Nothing
        'txt_gelecek_tarih = Nothing
        'txt_istihbarat = Nothing
        'sec_sonuc = Nothing
        'txt_aciklama1 = Nothing
        'txt_aciklama2 = Nothing
        'txt_aciklama4 = Nothing
        'DataSet1.Clear()
        'DataSet1.Dispose()
        'DataSet1 = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
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
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn22 = Nothing
        'DataColumn23 = Nothing
        'DataColumn24 = Nothing
        'DataColumn25 = Nothing
        'sec_status = Nothing
        'txt_aciklama3 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'txt_saat = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        SMS_Gonder()
    End Sub
    Private Sub SMS_Gonder()
        If XtraMessageBox.Show(Sorgu_sDil("SMS Göndermek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            If Trim(txt_sGSM.Text.ToString) <> "" Then
                Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                dr1("nIslemID") = 0
                dr1("sSMSID") = 0
                dr1("dteGonderimTarihi") = Today
                dr1("sMesaj") = ""
                dr1("nMusteriID") = txt_nMusteriID.Text
                dr1("lKodu") = txt_musterikodu.Text
                dr1("sAdi") = txt_musteri_adi.Text
                dr1("sSoyadi") = txt_musteri_soyadi.Text
                dr1("sTelefon") = txt_sGSM.Text
                dr1("dteUpdateTarihi") = Now
                dr1("lDurum") = 0
                dr1("lBakiye") = txt_tutar.Text
                frm.DataSet1.Tables(0).Rows.Add(dr1)
            End If
            'MsgBox(Sorgu_sDil("Ýþlem Tamamlandý...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            frm.ShowDialog()
        End If
    End Sub
    Private Sub UrunleriSec()
        Dim frm As New frm_satis_bekleyen_onaysiz
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.firmakodu = txt_musterikodu.Text
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        frm.qfirmakodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.musteri_takip_karti = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim dr1 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    urunUpdate = True
                    DataSet2.Clear()
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString()
                        dr = DataSet2.Tables(0).NewRow()
                        dr1 = frm.GridView1.GetDataRow(s)
                        dr("lKodu") = dr1("lKodu")
                        dr("Musteri") = dr1("Musteri")
                        dr("sKodu") = dr1("sKodu")
                        dr("sModel") = dr1("sModel")
                        dr("sRenk") = dr1("sRenk")
                        dr("sRenkAdi") = dr1("sRenkAdi")
                        dr("sBeden") = dr1("sBeden")
                        dr("sKavala") = dr1("sKavala")
                        dr("sAciklama") = dr1("sAciklama")
                        dr("Miktar") = dr1("Miktar")
                        dr("lBrutFiyat") = dr1("lBrutFiyat")
                        dr("Tutar") = dr1("Tutar")
                        dr("Depo") = dr1("Depo")
                        dr("lFaturaNo") = dr1("lFaturaNo")
                        dr("dteFaturaTarihi") = dr1("dteFaturaTarihi")
                        dr("dteTeslimEdilecek") = dr1("dteTeslimEdilecek")
                        dr("dteOnayTarihi") = dr1("dteOnayTarihi")
                        dr("dteTeslimEdilen") = dr1("dteTeslimEdilen")
                        dr.EndEdit()
                        DataSet2.Tables(0).Rows.Add(dr)
                        Me.Refresh()
                    Next
                    GridControl1.DataSource = DataSet2.Tables(0)
                    GridControl1.DataMember = Nothing
                    GridControl1.Focus()
                    GridControl1.Select()
                    GridControl1.Refresh()
                    Me.Refresh()
                    dr = Nothing
                    dr1 = Nothing
                    s = Nothing
                    arr = Nothing
                    i = Nothing
                End If
            End If
        End If
        frm = Nothing
    End Sub
    Private Sub ekleUrunler(ByVal IND As Integer, ByVal upd As Boolean)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            con.ConnectionString = connection
            cmd.Connection = con
            Dim geriVeri As String = ""
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If upd = True Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Delete From aEmirMusteriTakipUrunler Where (IND = " & IND & ")")
                cmd.ExecuteNonQuery()
            End If
            For Each dr In DataSet2.Tables(0).Rows
                If Boolean.Parse(dr("Sec").ToString()) = True Then
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirMusteriTakipUrunler(IND, lKodu, Musteri, sKodu, sModel, sRenk, sRenkAdi, sBeden, sKavala, sAciklama, Miktar, lBrutFiyat, Tutar, Depo, lFaturaNo, dteFaturaTarihi, dteTeslimEdilecek, dteOnayTarihi, dteTeslimEdilen) VALUES(" & IND & ", '" & dr("lKodu").ToString() & "', '" & dr("Musteri").ToString() & "', '" & dr("sKodu").ToString() & "', '" & dr("sModel").ToString() & "', '" & dr("sRenk").ToString() & "', '" & dr("sRenkAdi").ToString() & "', '" & dr("sBeden").ToString() & "', '" & dr("sKavala").ToString() & "', '" & dr("sAciklama").ToString() & "', " & dr("Miktar").ToString() & ", " & dr("lBrutFiyat").ToString() & ", " & dr("Tutar").ToString() & ", '" & dr("Depo").ToString() & "', '" & dr("lFaturaNo").ToString() & "', '" & dr("dteFaturaTarihi").ToString() & "', '" & dr("dteTeslimEdilecek").ToString() & "', '" & dr("dteOnayTarihi").ToString() & "', '" & dr("dteTeslimEdilen").ToString() & "')")
                    cmd.ExecuteNonQuery()
                End If
            Next
            con.Close()
        End If
    End Sub
    Private Sub dataload_urunler()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From aEmirMusteriTakipUrunler WHERE (IND = " & kayitno & ")")
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DataSet3.Tables(0))
        con.Close()
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr In DataSet2.Tables(0).Rows
            For Each dr1 In DataSet3.Tables(0).Rows
                If dr("sKodu") = dr1("sKodu") And dr("lFaturaNo") = dr1("lFaturaNo") And dr("Miktar") = dr1("Miktar") Then
                    dr("Sec") = "True"
                End If
            Next
        Next
    End Sub
    Private Sub UrunlerGetir()
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 as Sec, tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu,tbMusteri.sAdi,tbMusteri.sSoyadi,tbMusteri.sGSM, rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri, rtrim(tbMusteri.lKodu) + ' ' + rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS MusteriKodlu,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT,(SELECT     tbMSinif2.sAciklama FROM         tbMusteriSinifi INNER JOIN  tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE     (tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID)) AS SINIF2, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,(SELECT     sSinifKodu1 FROM         tbStokSinifi Where nStokID =tbStok.nStokID) AS sSinifKodu1, (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVerisSiparis.sSaticiRumuzu,tbSatici.sAdi + ' ' + tbSatici.sSoyadi as sSatici, dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo,tbSatici,tbMusteriSinifi,tbStokSinifi WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID AND tbStokSinifi.nStokID = tbStok.nStokID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbAlisVerisSiparis.sSaticiRumuzu = tbSatici.sSaticiRumuzu AND tbStok.sRenk = tbRenk.sRenk AND (tbMusteri.lKodu BETWEEN 0 AND 999999999) AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbMusteri.nMusteriID = " & txt_nMusteriID.Text & ") ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(DataSet2.Tables(0))
        conn.Close()
        GridControl1.DataSource = DataSet2.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        GridControl1.Refresh()
        Me.Refresh()
        If status = True Then
            dataload_urunler()
        End If
        cmd = Nothing
        adapter = Nothing
        N = Nothing
    End Sub
    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If txt_musterikodu.Text <> "" Then
            UrunleriSec()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Bir Müþteri Seçiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Dim dr As DataRow
        For Each dr In DataSet2.Tables(0).Rows
            dr("Sec") = "True"
        Next
        GridControl1.Refresh()
        Me.Refresh()
    End Sub
End Class
