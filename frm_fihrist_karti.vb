Imports DevExpress.XtraEditors
Public Class frm_fihrist_karti
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_firmakodu As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
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
    Friend WithEvents sec_il As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_gorev As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ilgili As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_telefon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_mail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_web As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ilce As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_postakodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_daireno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_binano As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_semt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_mahalle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sokak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_cadde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vergino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vergidairesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_unvan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_firmaadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_soyad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alan1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents sec_fax As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_telefon As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents btn_alan14 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan13 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan12 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan11 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan10 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan9 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan8 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan7 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan5 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan4 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan3 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents btn_alan2 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents Label21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_GSM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_alan1 As DevExpress.XtraEditors.HyperLinkEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fihrist_karti))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txt_gorev = New DevExpress.XtraEditors.TextEdit
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
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
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.Label20 = New DevExpress.XtraEditors.LabelControl
        Me.txt_ilgili = New DevExpress.XtraEditors.TextEdit
        Me.Label19 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.Label21 = New DevExpress.XtraEditors.LabelControl
        Me.txt_GSM = New DevExpress.XtraEditors.TextEdit
        Me.sec_fax = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_fax = New DevExpress.XtraEditors.TextEdit
        Me.txt_telefon = New DevExpress.XtraEditors.TextEdit
        Me.sec_telefon = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_mail = New DevExpress.XtraEditors.TextEdit
        Me.txt_web = New DevExpress.XtraEditors.TextEdit
        Me.Label18 = New DevExpress.XtraEditors.LabelControl
        Me.Label17 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txt_ilce = New DevExpress.XtraEditors.TextEdit
        Me.sec_il = New DevExpress.XtraEditors.LookUpEdit
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.Label16 = New DevExpress.XtraEditors.LabelControl
        Me.Label15 = New DevExpress.XtraEditors.LabelControl
        Me.txt_postakodu = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New DevExpress.XtraEditors.LabelControl
        Me.Label13 = New DevExpress.XtraEditors.LabelControl
        Me.Label12 = New DevExpress.XtraEditors.LabelControl
        Me.txt_daireno = New DevExpress.XtraEditors.TextEdit
        Me.txt_binano = New DevExpress.XtraEditors.TextEdit
        Me.txt_semt = New DevExpress.XtraEditors.TextEdit
        Me.txt_mahalle = New DevExpress.XtraEditors.TextEdit
        Me.txt_sokak = New DevExpress.XtraEditors.TextEdit
        Me.txt_cadde = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New DevExpress.XtraEditors.LabelControl
        Me.Label10 = New DevExpress.XtraEditors.LabelControl
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_vergino = New DevExpress.XtraEditors.TextEdit
        Me.txt_vergidairesi = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_unvan = New DevExpress.XtraEditors.MemoEdit
        Me.txt_firmaadi = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_firmakodu = New DevExpress.XtraEditors.LabelControl
        Me.txt_soyad = New DevExpress.XtraEditors.TextEdit
        Me.txt_ad = New DevExpress.XtraEditors.TextEdit
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.btn_alan14 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan13 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan12 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan11 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.txt_alan14 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan13 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan12 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan11 = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.btn_alan10 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan9 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan8 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan7 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.txt_alan10 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan9 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan8 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan7 = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.btn_alan5 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan4 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan3 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan2 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.btn_alan1 = New DevExpress.XtraEditors.HyperLinkEdit
        Me.txt_alan5 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan4 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan3 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alan1 = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.txt_aciklama = New DevExpress.XtraEditors.MemoEdit
        Me.DataSet2 = New System.Data.DataSet
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txt_gorev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ilgili.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_GSM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_telefon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_web.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_ilce.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_il.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_postakodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_daireno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_binano.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_semt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mahalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sokak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cadde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vergino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vergidairesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_unvan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_firmaadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_soyad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.btn_alan14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.btn_alan10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.btn_alan5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_alan1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alan1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 52)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Aþaðýda Fihrist Kart Bilgilerini Görmektesiniz. Fihrist kartýna baðlý [EkBilgiler" & _
            "] girebilir, [Resim] düzenleyebilir ve Analiz bilgilerine ulaþabilirsiniz."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(766, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 471)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 52)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(741, 17)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(77, 25)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 17)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(77, 25)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Kaydet F2"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 52)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 419)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 415)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 389)
        Me.XtraTabPage1.Text = "Tanýmlar"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.txt_gorev)
        Me.GroupControl3.Controls.Add(Me.Label20)
        Me.GroupControl3.Controls.Add(Me.txt_ilgili)
        Me.GroupControl3.Controls.Add(Me.Label19)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 283)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(814, 59)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Ýlgili Kiþi"
        '
        'txt_gorev
        '
        Me.txt_gorev.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ILGILIKISIGOREVI", True))
        Me.txt_gorev.EnterMoveNextControl = True
        Me.txt_gorev.Location = New System.Drawing.Point(320, 26)
        Me.txt_gorev.Name = "txt_gorev"
        Me.txt_gorev.Properties.MaxLength = 30
        Me.txt_gorev.Size = New System.Drawing.Size(168, 20)
        Me.txt_gorev.TabIndex = 31
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "IND"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "KODU"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ADI"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "SOYADI"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "UNVANI"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "UZUNADI"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "VERGIDAIRESI"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "VERGINO"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "TELEFON1"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "TELEFON2"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "TELEFON3"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "TELEFON4"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "TELEFON5"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "FAX1"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "FAX2"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "POSTAKODU"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "CADDE"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "SOKAK"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "MAH"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "SEMT"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "DAIRENO"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "KAPINO"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "ADRES"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "EMAIL"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "ILGILIKISI"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "ILGILIKISIGOREVI"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "ALAN1"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ALAN2"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "ALAN3"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "ALAN4"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "ALAN5"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ALAN6"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "ALAN7"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "ALAN8"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "ALAN9"
        Me.DataColumn37.DataType = GetType(Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "ALAN10"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "ALAN11"
        Me.DataColumn39.DataType = GetType(Date)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "ALAN12"
        Me.DataColumn40.DataType = GetType(Date)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "ALAN13"
        Me.DataColumn41.DataType = GetType(Date)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "ALAN14"
        Me.DataColumn42.DataType = GetType(Date)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "BASLIKALAN1"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "BASLIKALAN2"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "BASLIKALAN3"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "BASLIKALAN4"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "BASLIKALAN5"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "BASLIKALAN6"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "BASLIKALAN7"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "BASLIKALAN8"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "BASLIKALAN9"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "BASLIKALAN10"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "BASLIKALAN11"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "BASLIKALAN12"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "BASLIKALAN13"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "BASLIKALAN14"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "IL"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "ILCE"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "WEB"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "ACIKLAMA"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(256, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Görevi :"
        '
        'txt_ilgili
        '
        Me.txt_ilgili.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ILGILIKISI", True))
        Me.txt_ilgili.EnterMoveNextControl = True
        Me.txt_ilgili.Location = New System.Drawing.Point(80, 26)
        Me.txt_ilgili.Name = "txt_ilgili"
        Me.txt_ilgili.Properties.MaxLength = 30
        Me.txt_ilgili.Size = New System.Drawing.Size(168, 20)
        Me.txt_ilgili.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Ýsim :"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.Label21)
        Me.GroupControl2.Controls.Add(Me.txt_GSM)
        Me.GroupControl2.Controls.Add(Me.sec_fax)
        Me.GroupControl2.Controls.Add(Me.txt_fax)
        Me.GroupControl2.Controls.Add(Me.txt_telefon)
        Me.GroupControl2.Controls.Add(Me.sec_telefon)
        Me.GroupControl2.Controls.Add(Me.txt_mail)
        Me.GroupControl2.Controls.Add(Me.txt_web)
        Me.GroupControl2.Controls.Add(Me.Label18)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 206)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(814, 77)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Ýletiþim"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(494, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "GSM :"
        '
        'txt_GSM
        '
        Me.txt_GSM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON2", True))
        Me.txt_GSM.EnterMoveNextControl = True
        Me.txt_GSM.Location = New System.Drawing.Point(558, 25)
        Me.txt_GSM.Name = "txt_GSM"
        Me.txt_GSM.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_GSM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_GSM.Properties.Mask.SaveLiteral = False
        Me.txt_GSM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_GSM.Properties.MaxLength = 20
        Me.txt_GSM.Size = New System.Drawing.Size(168, 20)
        Me.txt_GSM.TabIndex = 33
        '
        'sec_fax
        '
        Me.sec_fax.EditValue = "1.Fax"
        Me.sec_fax.EnterMoveNextControl = True
        Me.sec_fax.Location = New System.Drawing.Point(248, 48)
        Me.sec_fax.Name = "sec_fax"
        Me.sec_fax.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_fax.Properties.Appearance.Options.UseBackColor = True
        Me.sec_fax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_fax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fax.Properties.Items.AddRange(New Object() {"1.Fax", "2.Fax"})
        Me.sec_fax.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_fax.Size = New System.Drawing.Size(72, 18)
        Me.sec_fax.TabIndex = 32
        '
        'txt_fax
        '
        Me.txt_fax.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FAX1", True))
        Me.txt_fax.EnterMoveNextControl = True
        Me.txt_fax.Location = New System.Drawing.Point(320, 48)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Properties.MaxLength = 15
        Me.txt_fax.Size = New System.Drawing.Size(168, 20)
        Me.txt_fax.TabIndex = 31
        '
        'txt_telefon
        '
        Me.txt_telefon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON1", True))
        Me.txt_telefon.EnterMoveNextControl = True
        Me.txt_telefon.Location = New System.Drawing.Point(320, 25)
        Me.txt_telefon.Name = "txt_telefon"
        Me.txt_telefon.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_telefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_telefon.Properties.Mask.SaveLiteral = False
        Me.txt_telefon.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_telefon.Properties.MaxLength = 20
        Me.txt_telefon.Size = New System.Drawing.Size(168, 20)
        Me.txt_telefon.TabIndex = 30
        '
        'sec_telefon
        '
        Me.sec_telefon.EditValue = "1.Telefon"
        Me.sec_telefon.EnterMoveNextControl = True
        Me.sec_telefon.Location = New System.Drawing.Point(248, 26)
        Me.sec_telefon.Name = "sec_telefon"
        Me.sec_telefon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_telefon.Properties.Appearance.Options.UseBackColor = True
        Me.sec_telefon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_telefon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_telefon.Properties.Items.AddRange(New Object() {"1.Telefon", "GSM", "3.Telefon", "4.Telefon", "5.Telefon"})
        Me.sec_telefon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_telefon.Size = New System.Drawing.Size(72, 18)
        Me.sec_telefon.TabIndex = 29
        '
        'txt_mail
        '
        Me.txt_mail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.EMAIL", True))
        Me.txt_mail.EnterMoveNextControl = True
        Me.txt_mail.Location = New System.Drawing.Point(80, 48)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Properties.MaxLength = 35
        Me.txt_mail.Size = New System.Drawing.Size(168, 20)
        Me.txt_mail.TabIndex = 28
        '
        'txt_web
        '
        Me.txt_web.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.WEB", True))
        Me.txt_web.EnterMoveNextControl = True
        Me.txt_web.Location = New System.Drawing.Point(80, 26)
        Me.txt_web.Name = "txt_web"
        Me.txt_web.Properties.MaxLength = 35
        Me.txt_web.Size = New System.Drawing.Size(168, 20)
        Me.txt_web.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(25, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Mail :"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Web :"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txt_ilce)
        Me.GroupControl1.Controls.Add(Me.sec_il)
        Me.GroupControl1.Controls.Add(Me.Label16)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Controls.Add(Me.txt_postakodu)
        Me.GroupControl1.Controls.Add(Me.Label14)
        Me.GroupControl1.Controls.Add(Me.Label13)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.txt_daireno)
        Me.GroupControl1.Controls.Add(Me.txt_binano)
        Me.GroupControl1.Controls.Add(Me.txt_semt)
        Me.GroupControl1.Controls.Add(Me.txt_mahalle)
        Me.GroupControl1.Controls.Add(Me.txt_sokak)
        Me.GroupControl1.Controls.Add(Me.txt_cadde)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txt_vergino)
        Me.GroupControl1.Controls.Add(Me.txt_vergidairesi)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txt_unvan)
        Me.GroupControl1.Controls.Add(Me.txt_firmaadi)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.lbl_firmakodu)
        Me.GroupControl1.Controls.Add(Me.txt_soyad)
        Me.GroupControl1.Controls.Add(Me.txt_ad)
        Me.GroupControl1.Controls.Add(Me.txt_kod)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(814, 206)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Genel Bilgiler"
        '
        'txt_ilce
        '
        Me.txt_ilce.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ILCE", True))
        Me.txt_ilce.EnterMoveNextControl = True
        Me.txt_ilce.Location = New System.Drawing.Point(320, 180)
        Me.txt_ilce.Name = "txt_ilce"
        Me.txt_ilce.Properties.MaxLength = 20
        Me.txt_ilce.Size = New System.Drawing.Size(168, 20)
        Me.txt_ilce.TabIndex = 42
        '
        'sec_il
        '
        Me.sec_il.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.IL", True))
        Me.sec_il.EnterMoveNextControl = True
        Me.sec_il.Location = New System.Drawing.Point(320, 158)
        Me.sec_il.Name = "sec_il"
        Me.sec_il.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sec_il.Properties.Appearance.Options.UseBackColor = True
        Me.sec_il.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_il.Properties.DataSource = Me.DataTable2
        Me.sec_il.Properties.DisplayMember = "sIl"
        Me.sec_il.Properties.MaxLength = 20
        Me.sec_il.Properties.NullText = "[Ýller...]"
        Me.sec_il.Properties.ValueMember = "sIl"
        Me.sec_il.Size = New System.Drawing.Size(168, 20)
        Me.sec_il.TabIndex = 41
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "IL"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(253, 180)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Ýlçe :"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(253, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Ýl :"
        '
        'txt_postakodu
        '
        Me.txt_postakodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.POSTAKODU", True))
        Me.txt_postakodu.EnterMoveNextControl = True
        Me.txt_postakodu.Location = New System.Drawing.Point(320, 136)
        Me.txt_postakodu.Name = "txt_postakodu"
        Me.txt_postakodu.Properties.MaxLength = 5
        Me.txt_postakodu.Size = New System.Drawing.Size(168, 20)
        Me.txt_postakodu.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(253, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "PostaKodu :"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(375, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "DaireNo:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(253, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "BinaNo:"
        '
        'txt_daireno
        '
        Me.txt_daireno.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.DAIRENO", True))
        Me.txt_daireno.EnterMoveNextControl = True
        Me.txt_daireno.Location = New System.Drawing.Point(432, 114)
        Me.txt_daireno.Name = "txt_daireno"
        Me.txt_daireno.Properties.MaxLength = 5
        Me.txt_daireno.Size = New System.Drawing.Size(56, 20)
        Me.txt_daireno.TabIndex = 34
        '
        'txt_binano
        '
        Me.txt_binano.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KAPINO", True))
        Me.txt_binano.EnterMoveNextControl = True
        Me.txt_binano.Location = New System.Drawing.Point(320, 114)
        Me.txt_binano.Name = "txt_binano"
        Me.txt_binano.Properties.MaxLength = 5
        Me.txt_binano.Size = New System.Drawing.Size(56, 20)
        Me.txt_binano.TabIndex = 33
        '
        'txt_semt
        '
        Me.txt_semt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.SEMT", True))
        Me.txt_semt.EnterMoveNextControl = True
        Me.txt_semt.Location = New System.Drawing.Point(320, 92)
        Me.txt_semt.Name = "txt_semt"
        Me.txt_semt.Properties.MaxLength = 25
        Me.txt_semt.Size = New System.Drawing.Size(168, 20)
        Me.txt_semt.TabIndex = 32
        '
        'txt_mahalle
        '
        Me.txt_mahalle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.MAH", True))
        Me.txt_mahalle.EnterMoveNextControl = True
        Me.txt_mahalle.Location = New System.Drawing.Point(320, 70)
        Me.txt_mahalle.Name = "txt_mahalle"
        Me.txt_mahalle.Properties.MaxLength = 25
        Me.txt_mahalle.Size = New System.Drawing.Size(168, 20)
        Me.txt_mahalle.TabIndex = 31
        '
        'txt_sokak
        '
        Me.txt_sokak.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.SOKAK", True))
        Me.txt_sokak.EnterMoveNextControl = True
        Me.txt_sokak.Location = New System.Drawing.Point(320, 48)
        Me.txt_sokak.Name = "txt_sokak"
        Me.txt_sokak.Properties.MaxLength = 25
        Me.txt_sokak.Size = New System.Drawing.Size(168, 20)
        Me.txt_sokak.TabIndex = 30
        '
        'txt_cadde
        '
        Me.txt_cadde.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.CADDE", True))
        Me.txt_cadde.EnterMoveNextControl = True
        Me.txt_cadde.Location = New System.Drawing.Point(320, 26)
        Me.txt_cadde.Name = "txt_cadde"
        Me.txt_cadde.Properties.MaxLength = 25
        Me.txt_cadde.Size = New System.Drawing.Size(168, 20)
        Me.txt_cadde.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(253, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Semt :"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(253, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Mahalle :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(253, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Sokak :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(253, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Cadde :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "V.No :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "V.Dairesi :"
        '
        'txt_vergino
        '
        Me.txt_vergino.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.VERGINO", True))
        Me.txt_vergino.EnterMoveNextControl = True
        Me.txt_vergino.Location = New System.Drawing.Point(80, 179)
        Me.txt_vergino.Name = "txt_vergino"
        Me.txt_vergino.Properties.MaxLength = 10
        Me.txt_vergino.Size = New System.Drawing.Size(168, 20)
        Me.txt_vergino.TabIndex = 22
        '
        'txt_vergidairesi
        '
        Me.txt_vergidairesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.VERGIDAIRESI", True))
        Me.txt_vergidairesi.EnterMoveNextControl = True
        Me.txt_vergidairesi.Location = New System.Drawing.Point(80, 157)
        Me.txt_vergidairesi.Name = "txt_vergidairesi"
        Me.txt_vergidairesi.Properties.MaxLength = 20
        Me.txt_vergidairesi.Size = New System.Drawing.Size(168, 20)
        Me.txt_vergidairesi.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Ünvan"
        '
        'txt_unvan
        '
        Me.txt_unvan.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.UNVANI", True))
        Me.txt_unvan.EnterMoveNextControl = True
        Me.txt_unvan.Location = New System.Drawing.Point(80, 114)
        Me.txt_unvan.Name = "txt_unvan"
        Me.txt_unvan.Properties.MaxLength = 40
        Me.txt_unvan.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_unvan.Size = New System.Drawing.Size(168, 43)
        Me.txt_unvan.TabIndex = 19
        '
        'txt_firmaadi
        '
        Me.txt_firmaadi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.UZUNADI", True))
        Me.txt_firmaadi.EnterMoveNextControl = True
        Me.txt_firmaadi.Location = New System.Drawing.Point(80, 92)
        Me.txt_firmaadi.Name = "txt_firmaadi"
        Me.txt_firmaadi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firmaadi.Properties.Appearance.Options.UseBackColor = True
        Me.txt_firmaadi.Properties.MaxLength = 25
        Me.txt_firmaadi.Size = New System.Drawing.Size(168, 20)
        Me.txt_firmaadi.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Firma Adý :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Soyadý :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Adý :"
        '
        'lbl_firmakodu
        '
        Me.lbl_firmakodu.Location = New System.Drawing.Point(8, 26)
        Me.lbl_firmakodu.Name = "lbl_firmakodu"
        Me.lbl_firmakodu.Size = New System.Drawing.Size(31, 13)
        Me.lbl_firmakodu.TabIndex = 14
        Me.lbl_firmakodu.Text = "Kodu :"
        '
        'txt_soyad
        '
        Me.txt_soyad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.SOYADI", True))
        Me.txt_soyad.EnterMoveNextControl = True
        Me.txt_soyad.Location = New System.Drawing.Point(80, 70)
        Me.txt_soyad.Name = "txt_soyad"
        Me.txt_soyad.Properties.MaxLength = 20
        Me.txt_soyad.Size = New System.Drawing.Size(168, 20)
        Me.txt_soyad.TabIndex = 2
        '
        'txt_ad
        '
        Me.txt_ad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ADI", True))
        Me.txt_ad.EnterMoveNextControl = True
        Me.txt_ad.Location = New System.Drawing.Point(80, 48)
        Me.txt_ad.Name = "txt_ad"
        Me.txt_ad.Properties.MaxLength = 20
        Me.txt_ad.Size = New System.Drawing.Size(168, 20)
        Me.txt_ad.TabIndex = 1
        '
        'txt_kod
        '
        Me.txt_kod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KODU", True))
        Me.txt_kod.EnterMoveNextControl = True
        Me.txt_kod.Location = New System.Drawing.Point(80, 26)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_kod.Properties.Appearance.Options.UseBackColor = True
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Size = New System.Drawing.Size(168, 20)
        Me.txt_kod.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl7)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl6)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 389)
        Me.XtraTabPage2.Text = "Ek Bilgiler"
        '
        'GroupControl7
        '
        Me.GroupControl7.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl7.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl7.AppearanceCaption.Options.UseFont = True
        Me.GroupControl7.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.btn_alan14)
        Me.GroupControl7.Controls.Add(Me.btn_alan13)
        Me.GroupControl7.Controls.Add(Me.btn_alan12)
        Me.GroupControl7.Controls.Add(Me.btn_alan11)
        Me.GroupControl7.Controls.Add(Me.txt_alan14)
        Me.GroupControl7.Controls.Add(Me.txt_alan13)
        Me.GroupControl7.Controls.Add(Me.txt_alan12)
        Me.GroupControl7.Controls.Add(Me.txt_alan11)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl7.Location = New System.Drawing.Point(0, 264)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(814, 118)
        Me.GroupControl7.TabIndex = 2
        Me.GroupControl7.Text = "Tarihsel Bilgiler :"
        '
        'btn_alan14
        '
        Me.btn_alan14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN14", True))
        Me.btn_alan14.EditValue = "4. Tarihsel Bilgi"
        Me.btn_alan14.EnterMoveNextControl = True
        Me.btn_alan14.Location = New System.Drawing.Point(16, 90)
        Me.btn_alan14.Name = "btn_alan14"
        Me.btn_alan14.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan14.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan14.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan14.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan14.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan14.TabIndex = 9
        '
        'btn_alan13
        '
        Me.btn_alan13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN13", True))
        Me.btn_alan13.EditValue = "3. Tarihsel Bilgi"
        Me.btn_alan13.EnterMoveNextControl = True
        Me.btn_alan13.Location = New System.Drawing.Point(16, 68)
        Me.btn_alan13.Name = "btn_alan13"
        Me.btn_alan13.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan13.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan13.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan13.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan13.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan13.TabIndex = 8
        '
        'btn_alan12
        '
        Me.btn_alan12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN12", True))
        Me.btn_alan12.EditValue = "2. Tarihsel Bilgi"
        Me.btn_alan12.EnterMoveNextControl = True
        Me.btn_alan12.Location = New System.Drawing.Point(16, 46)
        Me.btn_alan12.Name = "btn_alan12"
        Me.btn_alan12.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan12.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan12.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan12.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan12.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan12.TabIndex = 7
        '
        'btn_alan11
        '
        Me.btn_alan11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN11", True))
        Me.btn_alan11.EditValue = "1. Tarihsel Bilgi"
        Me.btn_alan11.EnterMoveNextControl = True
        Me.btn_alan11.Location = New System.Drawing.Point(16, 24)
        Me.btn_alan11.Name = "btn_alan11"
        Me.btn_alan11.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan11.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan11.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan11.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan11.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan11.TabIndex = 6
        '
        'txt_alan14
        '
        Me.txt_alan14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN14", True))
        Me.txt_alan14.EnterMoveNextControl = True
        Me.txt_alan14.Location = New System.Drawing.Point(184, 90)
        Me.txt_alan14.Name = "txt_alan14"
        Me.txt_alan14.Properties.DisplayFormat.FormatString = "d"
        Me.txt_alan14.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_alan14.Properties.EditFormat.FormatString = "d"
        Me.txt_alan14.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan14.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan14.TabIndex = 4
        '
        'txt_alan13
        '
        Me.txt_alan13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN13", True))
        Me.txt_alan13.EnterMoveNextControl = True
        Me.txt_alan13.Location = New System.Drawing.Point(184, 68)
        Me.txt_alan13.Name = "txt_alan13"
        Me.txt_alan13.Properties.DisplayFormat.FormatString = "d"
        Me.txt_alan13.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_alan13.Properties.EditFormat.FormatString = "d"
        Me.txt_alan13.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan13.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan13.TabIndex = 3
        '
        'txt_alan12
        '
        Me.txt_alan12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN12", True))
        Me.txt_alan12.EnterMoveNextControl = True
        Me.txt_alan12.Location = New System.Drawing.Point(184, 46)
        Me.txt_alan12.Name = "txt_alan12"
        Me.txt_alan12.Properties.DisplayFormat.FormatString = "d"
        Me.txt_alan12.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_alan12.Properties.EditFormat.FormatString = "d"
        Me.txt_alan12.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan12.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan12.TabIndex = 2
        '
        'txt_alan11
        '
        Me.txt_alan11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN11", True))
        Me.txt_alan11.EnterMoveNextControl = True
        Me.txt_alan11.Location = New System.Drawing.Point(184, 24)
        Me.txt_alan11.Name = "txt_alan11"
        Me.txt_alan11.Properties.DisplayFormat.FormatString = "d"
        Me.txt_alan11.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_alan11.Properties.EditFormat.FormatString = "d"
        Me.txt_alan11.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan11.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan11.TabIndex = 1
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl6.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.btn_alan10)
        Me.GroupControl6.Controls.Add(Me.btn_alan9)
        Me.GroupControl6.Controls.Add(Me.btn_alan8)
        Me.GroupControl6.Controls.Add(Me.btn_alan7)
        Me.GroupControl6.Controls.Add(Me.txt_alan10)
        Me.GroupControl6.Controls.Add(Me.txt_alan9)
        Me.GroupControl6.Controls.Add(Me.txt_alan8)
        Me.GroupControl6.Controls.Add(Me.txt_alan7)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl6.Location = New System.Drawing.Point(0, 141)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(814, 123)
        Me.GroupControl6.TabIndex = 1
        Me.GroupControl6.Text = "Parasal Bilgiler:"
        '
        'btn_alan10
        '
        Me.btn_alan10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN10", True))
        Me.btn_alan10.EditValue = "4. Parasal Bilgi"
        Me.btn_alan10.EnterMoveNextControl = True
        Me.btn_alan10.Location = New System.Drawing.Point(16, 92)
        Me.btn_alan10.Name = "btn_alan10"
        Me.btn_alan10.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan10.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan10.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan10.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan10.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan10.TabIndex = 9
        '
        'btn_alan9
        '
        Me.btn_alan9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN9", True))
        Me.btn_alan9.EditValue = "3. Parasal Bilgi"
        Me.btn_alan9.EnterMoveNextControl = True
        Me.btn_alan9.Location = New System.Drawing.Point(16, 70)
        Me.btn_alan9.Name = "btn_alan9"
        Me.btn_alan9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan9.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan9.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan9.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan9.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan9.TabIndex = 8
        '
        'btn_alan8
        '
        Me.btn_alan8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN8", True))
        Me.btn_alan8.EditValue = "2. Parasal Bilgi"
        Me.btn_alan8.EnterMoveNextControl = True
        Me.btn_alan8.Location = New System.Drawing.Point(16, 48)
        Me.btn_alan8.Name = "btn_alan8"
        Me.btn_alan8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan8.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan8.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan8.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan8.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan8.TabIndex = 7
        '
        'btn_alan7
        '
        Me.btn_alan7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN7", True))
        Me.btn_alan7.EditValue = "1. Parasal Bilgi"
        Me.btn_alan7.EnterMoveNextControl = True
        Me.btn_alan7.Location = New System.Drawing.Point(16, 26)
        Me.btn_alan7.Name = "btn_alan7"
        Me.btn_alan7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan7.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan7.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan7.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan7.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan7.TabIndex = 6
        '
        'txt_alan10
        '
        Me.txt_alan10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN10", True))
        Me.txt_alan10.EnterMoveNextControl = True
        Me.txt_alan10.Location = New System.Drawing.Point(184, 92)
        Me.txt_alan10.Name = "txt_alan10"
        Me.txt_alan10.Properties.DisplayFormat.FormatString = "N"
        Me.txt_alan10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan10.Properties.EditFormat.FormatString = "N"
        Me.txt_alan10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_alan10.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan10.TabIndex = 4
        '
        'txt_alan9
        '
        Me.txt_alan9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN9", True))
        Me.txt_alan9.EnterMoveNextControl = True
        Me.txt_alan9.Location = New System.Drawing.Point(184, 70)
        Me.txt_alan9.Name = "txt_alan9"
        Me.txt_alan9.Properties.DisplayFormat.FormatString = "N"
        Me.txt_alan9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan9.Properties.EditFormat.FormatString = "N"
        Me.txt_alan9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_alan9.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan9.TabIndex = 3
        '
        'txt_alan8
        '
        Me.txt_alan8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN8", True))
        Me.txt_alan8.EnterMoveNextControl = True
        Me.txt_alan8.Location = New System.Drawing.Point(184, 48)
        Me.txt_alan8.Name = "txt_alan8"
        Me.txt_alan8.Properties.DisplayFormat.FormatString = "N"
        Me.txt_alan8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan8.Properties.EditFormat.FormatString = "N"
        Me.txt_alan8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_alan8.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan8.TabIndex = 2
        '
        'txt_alan7
        '
        Me.txt_alan7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN7", True))
        Me.txt_alan7.EnterMoveNextControl = True
        Me.txt_alan7.Location = New System.Drawing.Point(184, 26)
        Me.txt_alan7.Name = "txt_alan7"
        Me.txt_alan7.Properties.DisplayFormat.FormatString = "N"
        Me.txt_alan7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan7.Properties.EditFormat.FormatString = "N"
        Me.txt_alan7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_alan7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_alan7.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan7.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.btn_alan5)
        Me.GroupControl4.Controls.Add(Me.btn_alan4)
        Me.GroupControl4.Controls.Add(Me.btn_alan3)
        Me.GroupControl4.Controls.Add(Me.btn_alan2)
        Me.GroupControl4.Controls.Add(Me.btn_alan1)
        Me.GroupControl4.Controls.Add(Me.txt_alan5)
        Me.GroupControl4.Controls.Add(Me.txt_alan4)
        Me.GroupControl4.Controls.Add(Me.txt_alan3)
        Me.GroupControl4.Controls.Add(Me.txt_alan2)
        Me.GroupControl4.Controls.Add(Me.txt_alan1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(814, 141)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Ek Bilgiler:"
        '
        'btn_alan5
        '
        Me.btn_alan5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN5", True))
        Me.btn_alan5.EditValue = "5. Ek Bilgi"
        Me.btn_alan5.EnterMoveNextControl = True
        Me.btn_alan5.Location = New System.Drawing.Point(16, 114)
        Me.btn_alan5.Name = "btn_alan5"
        Me.btn_alan5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan5.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan5.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan5.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan5.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan5.TabIndex = 10
        '
        'btn_alan4
        '
        Me.btn_alan4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN4", True))
        Me.btn_alan4.EditValue = "4. Ek Bilgi"
        Me.btn_alan4.EnterMoveNextControl = True
        Me.btn_alan4.Location = New System.Drawing.Point(16, 92)
        Me.btn_alan4.Name = "btn_alan4"
        Me.btn_alan4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan4.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan4.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan4.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan4.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan4.TabIndex = 9
        '
        'btn_alan3
        '
        Me.btn_alan3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN3", True))
        Me.btn_alan3.EditValue = "3. Ek Bilgi"
        Me.btn_alan3.EnterMoveNextControl = True
        Me.btn_alan3.Location = New System.Drawing.Point(16, 70)
        Me.btn_alan3.Name = "btn_alan3"
        Me.btn_alan3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan3.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan3.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan3.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan3.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan3.TabIndex = 8
        '
        'btn_alan2
        '
        Me.btn_alan2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN2", True))
        Me.btn_alan2.EditValue = "2. Ek Bilgi"
        Me.btn_alan2.EnterMoveNextControl = True
        Me.btn_alan2.Location = New System.Drawing.Point(16, 48)
        Me.btn_alan2.Name = "btn_alan2"
        Me.btn_alan2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan2.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan2.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan2.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan2.TabIndex = 7
        '
        'btn_alan1
        '
        Me.btn_alan1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLIKALAN1", True))
        Me.btn_alan1.EditValue = "1. Ek Bilgi"
        Me.btn_alan1.EnterMoveNextControl = True
        Me.btn_alan1.Location = New System.Drawing.Point(16, 26)
        Me.btn_alan1.Name = "btn_alan1"
        Me.btn_alan1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btn_alan1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_alan1.Properties.Appearance.Options.UseBackColor = True
        Me.btn_alan1.Properties.Appearance.Options.UseForeColor = True
        Me.btn_alan1.Size = New System.Drawing.Size(160, 20)
        Me.btn_alan1.TabIndex = 6
        '
        'txt_alan5
        '
        Me.txt_alan5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN5", True))
        Me.txt_alan5.EnterMoveNextControl = True
        Me.txt_alan5.Location = New System.Drawing.Point(184, 114)
        Me.txt_alan5.Name = "txt_alan5"
        Me.txt_alan5.Properties.MaxLength = 30
        Me.txt_alan5.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan5.TabIndex = 5
        '
        'txt_alan4
        '
        Me.txt_alan4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN4", True))
        Me.txt_alan4.EnterMoveNextControl = True
        Me.txt_alan4.Location = New System.Drawing.Point(184, 92)
        Me.txt_alan4.Name = "txt_alan4"
        Me.txt_alan4.Properties.MaxLength = 30
        Me.txt_alan4.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan4.TabIndex = 4
        '
        'txt_alan3
        '
        Me.txt_alan3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN3", True))
        Me.txt_alan3.EnterMoveNextControl = True
        Me.txt_alan3.Location = New System.Drawing.Point(184, 70)
        Me.txt_alan3.Name = "txt_alan3"
        Me.txt_alan3.Properties.MaxLength = 30
        Me.txt_alan3.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan3.TabIndex = 3
        '
        'txt_alan2
        '
        Me.txt_alan2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN2", True))
        Me.txt_alan2.EnterMoveNextControl = True
        Me.txt_alan2.Location = New System.Drawing.Point(184, 48)
        Me.txt_alan2.Name = "txt_alan2"
        Me.txt_alan2.Properties.MaxLength = 30
        Me.txt_alan2.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan2.TabIndex = 2
        '
        'txt_alan1
        '
        Me.txt_alan1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ALAN1", True))
        Me.txt_alan1.EnterMoveNextControl = True
        Me.txt_alan1.Location = New System.Drawing.Point(184, 26)
        Me.txt_alan1.Name = "txt_alan1"
        Me.txt_alan1.Properties.MaxLength = 30
        Me.txt_alan1.Size = New System.Drawing.Size(296, 20)
        Me.txt_alan1.TabIndex = 1
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(814, 389)
        Me.XtraTabPage3.Text = "Ýstihbarat"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl5.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.txt_aciklama)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(814, 389)
        Me.GroupControl5.TabIndex = 0
        Me.GroupControl5.Text = "Notlar :"
        '
        'txt_aciklama
        '
        Me.txt_aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ACIKLAMA", True))
        Me.txt_aciklama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aciklama.Location = New System.Drawing.Point(2, 22)
        Me.txt_aciklama.Name = "txt_aciklama"
        Me.txt_aciklama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_aciklama.Properties.Appearance.Options.UseBackColor = True
        Me.txt_aciklama.Properties.MaxLength = 255
        Me.txt_aciklama.Size = New System.Drawing.Size(810, 365)
        Me.txt_aciklama.TabIndex = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
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
        'frm_fihrist_karti
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_fihrist_karti"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fihrist"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txt_gorev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ilgili.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txt_GSM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_telefon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_web.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_ilce.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_il.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_postakodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_daireno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_binano.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_semt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mahalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sokak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cadde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vergino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vergidairesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_unvan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_firmaadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_soyad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.btn_alan14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.btn_alan10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.btn_alan5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_alan1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alan1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kod
    Public status As Integer
    Public carino
    Public kullanici
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adap As New OleDb.OleDbDataAdapter
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_fihrist_karti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_il()
        dataload()
    End Sub
    Private Sub dataload()
        If status = 1 Then
            con.ConnectionString = connection
            cmd.Connection = con
            adap.SelectCommand = cmd
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         TBLAJNFIHRIST WHERE IND =" & carino & "")
            adap.Fill(DataSet1.Tables(0))
        ElseIf status = 0 Then
            Dim dr As DataRow = DataSet1.Tables(0).NewRow
            dr("KODU") = ""
            dr("ADI") = ""
            dr("SOYADI") = ""
            dr("UZUNADI") = ""
            dr("UNVANI") = ""
            dr("IL") = ""
            dr("ALAN1") = ""
            dr("ALAN2") = ""
            dr("ALAN3") = ""
            dr("ALAN4") = ""
            dr("ALAN5") = ""
            dr("ALAN6") = ""
            dr("ALAN7") = 0
            dr("ALAN8") = 0
            dr("ALAN9") = 0
            dr("ALAN10") = 0
            dr("BASLIKALAN1") = "1. Ek Bilgi"
            dr("BASLIKALAN2") = "2. Ek Bilgi"
            dr("BASLIKALAN3") = "3. Ek Bilgi"
            dr("BASLIKALAN4") = "4. Ek Bilgi"
            dr("BASLIKALAN5") = "5. Ek Bilgi"
            dr("BASLIKALAN6") = "1. Parasal Bilgi"
            dr("BASLIKALAN7") = "2. Parasal Bilgi"
            dr("BASLIKALAN8") = "3. Parasal Bilgi"
            dr("BASLIKALAN9") = "4. Parasal Bilgi"
            dr("BASLIKALAN10") = "5. Parasal Bilgi"
            dr("BASLIKALAN11") = "1. Tarihsel Bilgi"
            dr("BASLIKALAN12") = "2. Tarihsel Bilgi"
            dr("BASLIKALAN13") = "3. Tarihsel Bilgi"
            dr("BASLIKALAN14") = "4. Tarihsel Bilgi"
            DataSet1.Tables(0).Rows.Add(dr)
            dr = Nothing
        End If
    End Sub
    Private Sub dataload_il()
        sec_il.Properties.DataSource = sorgu(sorgu_query("SELECT * FROM tbIl")).Tables(0)
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
    Private Sub sec_telefon_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_telefon.SelectedIndexChanged
        If sec_telefon.EditValue = "1.Telefon" Then
            Me.txt_telefon.DataBindings.Clear()
            Me.txt_telefon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON1"))
        ElseIf sec_telefon.EditValue = "GSM" Then
            Me.txt_telefon.DataBindings.Clear()
            Me.txt_telefon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON2"))
        ElseIf sec_telefon.EditValue = "3.Telefon" Then
            Me.txt_telefon.DataBindings.Clear()
            Me.txt_telefon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON3"))
        ElseIf sec_telefon.EditValue = "4.Telefon" Then
            Me.txt_telefon.DataBindings.Clear()
            Me.txt_telefon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON4"))
        ElseIf sec_telefon.EditValue = "5.Telefon" Then
            Me.txt_telefon.DataBindings.Clear()
            Me.txt_telefon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON5"))
        End If
    End Sub
    Private Sub sec_fax_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_fax.SelectedIndexChanged
        If sec_fax.EditValue = "1.Fax" Then
            Me.txt_fax.DataBindings.Clear()
            Me.txt_fax.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FAX1"))
        ElseIf sec_fax.EditValue = "2.Fax" Then
            Me.txt_fax.DataBindings.Clear()
            Me.txt_fax.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FAX2"))
        End If
    End Sub
    Private Sub sorgu()
        If txt_kod.EditValue <> "" Then
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            XtraMessageBox.Show(Sorgu_sDil("Firma Kodunu Boþ Býrakamazsýnýz ..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_kod.Focus()
            txt_kod.SelectAll()
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub frm_fihrist_karti_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txt_kod.Focus()
        txt_kod.SelectAll()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        sorgu()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            txt_kod.Focus()
            txt_kod.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            txt_alan1.Focus()
            txt_alan1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            txt_aciklama.Focus()
            txt_aciklama.Select()
        End If
    End Sub
    Private Function baslik_alan(ByVal baslik As String) As String
        Dim aciklama = InputBox("Lütfen Bir Açýklama Giriniz...", "Baþlýk Tanýmla", baslik)
        If aciklama.ToString <> "" Then
            baslik = aciklama
        End If
        Return baslik
    End Function
    Private Sub btn_alan1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan1.Click
        btn_alan1.EditValue = baslik_alan(btn_alan1.EditValue).ToString
    End Sub
    Private Sub btn_alan2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan2.Click
        btn_alan2.EditValue = baslik_alan(btn_alan2.EditValue).ToString
    End Sub
    Private Sub btn_alan3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan3.Click
        btn_alan3.EditValue = baslik_alan(btn_alan3.EditValue).ToString
    End Sub
    Private Sub btn_alan4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan4.Click
        btn_alan4.EditValue = baslik_alan(btn_alan4.EditValue).ToString
    End Sub
    Private Sub btn_alan5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan5.Click
        btn_alan5.EditValue = baslik_alan(btn_alan5.EditValue).ToString
    End Sub
    Private Sub btn_alan7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan7.Click
        btn_alan7.EditValue = baslik_alan(btn_alan7.EditValue).ToString
    End Sub
    Private Sub btn_alan8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan8.Click
        btn_alan8.EditValue = baslik_alan(btn_alan8.EditValue).ToString
    End Sub
    Private Sub btn_alan9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan9.Click
        btn_alan9.EditValue = baslik_alan(btn_alan9.EditValue).ToString
    End Sub
    Private Sub btn_alan10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan10.Click
        btn_alan10.EditValue = baslik_alan(btn_alan10.EditValue).ToString
    End Sub
    Private Sub btn_alan11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan11.Click
        btn_alan11.EditValue = baslik_alan(btn_alan11.EditValue).ToString
    End Sub
    Private Sub btn_alan12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan12.Click
        btn_alan12.EditValue = baslik_alan(btn_alan12.EditValue).ToString
    End Sub
    Private Sub btn_alan13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan13.Click
        btn_alan13.EditValue = baslik_alan(btn_alan13.EditValue).ToString
    End Sub
    Private Sub btn_alan14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alan14.Click
        btn_alan14.EditValue = baslik_alan(btn_alan14.EditValue).ToString
    End Sub
End Class
