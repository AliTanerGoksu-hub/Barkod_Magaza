Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_pesin_liste
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
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_fistipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_kasiyer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_depo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOYADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALISVERISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVADEFARKI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAGAZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASIYER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYAZI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOGUMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVLILIKTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYAZDIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOZLESME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_isim As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_belgeno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.ButtonEdit
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
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
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
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdres1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdres2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUlke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsPostaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAlisverisYapanSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAlisverisYapanAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents collKazanilanPuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collHarcananPuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAVSoyadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAVadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents collMalIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnDipIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDipIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPesinat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_sKapama As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents collKapanan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_bIadeDegisim As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bSatisYapilamaz As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bAvukatlik As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bTaksitHatali As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colnKasaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sTarihTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents progressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents collKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMuhasebeFaturalasma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPosFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSaticiRumuzu As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_pesin_liste))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_isim = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_sTarihTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_bTaksitHatali = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bSatisYapilamaz = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bAvukatlik = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bIadeDegisim = New DevExpress.XtraEditors.CheckEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sKapama = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_sSaticiRumuzu = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAVSoyadi = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sAVadi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_belgeno = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_fistipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_musterino = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_kasiyer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit()
        Me.sec_depo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.progressBar1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
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
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOYADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALISVERISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVADEFARKI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAGAZA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASIYER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYAZI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOGUMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVLILIKTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYAZDIRMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAYIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOZLESME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdres1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdres2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSemt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUlke = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsPostaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisverisYapanSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisverisYapanAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKazanilanPuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collHarcananPuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnDipIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDipIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPesinat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKapanan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMuhasebeFaturalasma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPosFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sTarihTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bTaksitHatali.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bSatisYapilamaz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bAvukatlik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bIadeDegisim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sKapama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAVSoyadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAVadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.progressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton7)
        Me.PanelControl1.Controls.Add(Me.lbl_isim)
        Me.PanelControl1.Controls.Add(Me.SimpleButton6)
        Me.PanelControl1.Controls.Add(Me.SimpleButton4)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 980)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(2038, 80)
        Me.PanelControl1.TabIndex = 2
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Location = New System.Drawing.Point(381, 34)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(139, 35)
        Me.SimpleButton7.TabIndex = 74
        Me.SimpleButton7.Text = "POS Güncelle"
        '
        'lbl_isim
        '
        Me.lbl_isim.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_isim.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_isim.Location = New System.Drawing.Point(2, 2)
        Me.lbl_isim.Name = "lbl_isim"
        Me.lbl_isim.Size = New System.Drawing.Size(54, 19)
        Me.lbl_isim.TabIndex = 14
        Me.lbl_isim.Text = "Hediye:"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(251, 34)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton6.TabIndex = 13
        Me.SimpleButton6.Text = "&Yazdýr"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(131, 34)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton4.TabIndex = 12
        Me.SimpleButton4.Text = "&Yenile"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(536, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(11, 34)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "&Ýncele"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1901, 34)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1781, 34)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.PictureBox1)
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(2038, 197)
        Me.PanelControl2.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_sTarihTipi)
        Me.GroupControl1.Controls.Add(Me.sec_bTaksitHatali)
        Me.GroupControl1.Controls.Add(Me.sec_bSatisYapilamaz)
        Me.GroupControl1.Controls.Add(Me.sec_bAvukatlik)
        Me.GroupControl1.Controls.Add(Me.sec_bIadeDegisim)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.sec_sKapama)
        Me.GroupControl1.Controls.Add(Me.sec_sSaticiRumuzu)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txt_sAVSoyadi)
        Me.GroupControl1.Controls.Add(Me.txt_sAVadi)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.sec_resmi)
        Me.GroupControl1.Controls.Add(Me.txt_belgeno)
        Me.GroupControl1.Controls.Add(Me.sec_fistipi)
        Me.GroupControl1.Controls.Add(Me.txt_musterino)
        Me.GroupControl1.Controls.Add(Me.txt_kasiyer)
        Me.GroupControl1.Controls.Add(Me.txt_kod)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(153, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1536, 193)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Ara"
        '
        'sec_sTarihTipi
        '
        Me.sec_sTarihTipi.EditValue = "Tarih:"
        Me.sec_sTarihTipi.EnterMoveNextControl = True
        Me.sec_sTarihTipi.Location = New System.Drawing.Point(3, 57)
        Me.sec_sTarihTipi.Name = "sec_sTarihTipi"
        Me.sec_sTarihTipi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sTarihTipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sTarihTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sTarihTipi.Properties.Items.AddRange(New Object() {"Tarih:", "KayýtTarihi:"})
        Me.sec_sTarihTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sTarihTipi.Size = New System.Drawing.Size(104, 26)
        Me.sec_sTarihTipi.TabIndex = 73
        '
        'sec_bTaksitHatali
        '
        Me.sec_bTaksitHatali.Location = New System.Drawing.Point(600, 116)
        Me.sec_bTaksitHatali.Name = "sec_bTaksitHatali"
        Me.sec_bTaksitHatali.Properties.Caption = "HatalýTaksit"
        Me.sec_bTaksitHatali.Size = New System.Drawing.Size(131, 24)
        Me.sec_bTaksitHatali.TabIndex = 72
        '
        'sec_bSatisYapilamaz
        '
        Me.sec_bSatisYapilamaz.Location = New System.Drawing.Point(600, 87)
        Me.sec_bSatisYapilamaz.Name = "sec_bSatisYapilamaz"
        Me.sec_bSatisYapilamaz.Properties.Caption = "Satýþ Yapýlamaz"
        Me.sec_bSatisYapilamaz.Size = New System.Drawing.Size(168, 24)
        Me.sec_bSatisYapilamaz.TabIndex = 71
        '
        'sec_bAvukatlik
        '
        Me.sec_bAvukatlik.Location = New System.Drawing.Point(600, 59)
        Me.sec_bAvukatlik.Name = "sec_bAvukatlik"
        Me.sec_bAvukatlik.Properties.Caption = "AVUKATLIK"
        Me.sec_bAvukatlik.Size = New System.Drawing.Size(131, 24)
        Me.sec_bAvukatlik.TabIndex = 70
        '
        'sec_bIadeDegisim
        '
        Me.sec_bIadeDegisim.Location = New System.Drawing.Point(475, 116)
        Me.sec_bIadeDegisim.Name = "sec_bIadeDegisim"
        Me.sec_bIadeDegisim.Properties.Caption = "Iade/Degisim"
        Me.sec_bIadeDegisim.Size = New System.Drawing.Size(131, 24)
        Me.sec_bIadeDegisim.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(259, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Satýcý:"
        '
        'sec_sKapama
        '
        Me.sec_sKapama.EditValue = "[Tümü]"
        Me.sec_sKapama.EnterMoveNextControl = True
        Me.sec_sKapama.Location = New System.Drawing.Point(475, 144)
        Me.sec_sKapama.Name = "sec_sKapama"
        Me.sec_sKapama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sKapama.Properties.Items.AddRange(New Object() {"[Tümü]", "Kapalý", "Açýk"})
        Me.sec_sKapama.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sKapama.Size = New System.Drawing.Size(128, 26)
        Me.sec_sKapama.TabIndex = 11
        '
        'sec_sSaticiRumuzu
        '
        Me.sec_sSaticiRumuzu.EnterMoveNextControl = True
        Me.sec_sSaticiRumuzu.Location = New System.Drawing.Point(331, 144)
        Me.sec_sSaticiRumuzu.Name = "sec_sSaticiRumuzu"
        Me.sec_sSaticiRumuzu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSaticiRumuzu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sSaticiRumuzu", "sSaticiRumuzu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAdi", "sAdi")})
        Me.sec_sSaticiRumuzu.Properties.DisplayMember = "sSaticiRumuzu"
        Me.sec_sSaticiRumuzu.Properties.NullText = "[Tümü]"
        Me.sec_sSaticiRumuzu.Properties.ValueMember = "sSaticiRumuzu"
        Me.sec_sSaticiRumuzu.Size = New System.Drawing.Size(144, 26)
        Me.sec_sSaticiRumuzu.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(259, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Soyad:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(259, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "FisNo:"
        '
        'txt_sAVSoyadi
        '
        Me.txt_sAVSoyadi.EnterMoveNextControl = True
        Me.txt_sAVSoyadi.Location = New System.Drawing.Point(331, 116)
        Me.txt_sAVSoyadi.Name = "txt_sAVSoyadi"
        Me.txt_sAVSoyadi.Properties.MaxLength = 10
        Me.txt_sAVSoyadi.Size = New System.Drawing.Size(144, 26)
        Me.txt_sAVSoyadi.TabIndex = 8
        '
        'txt_sAVadi
        '
        Me.txt_sAVadi.EnterMoveNextControl = True
        Me.txt_sAVadi.Location = New System.Drawing.Point(110, 114)
        Me.txt_sAVadi.Name = "txt_sAVadi"
        Me.txt_sAVadi.Properties.MaxLength = 10
        Me.txt_sAVadi.Size = New System.Drawing.Size(144, 26)
        Me.txt_sAVadi.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(6, 114)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 19)
        Me.LabelControl5.TabIndex = 62
        Me.LabelControl5.Text = "AV YapanAd:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(42, 143)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl4.TabIndex = 61
        Me.LabelControl4.Text = "Magaza:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(45, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 19)
        Me.LabelControl3.TabIndex = 60
        Me.LabelControl3.Text = "Müþteri:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(58, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "Yetkili:"
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(475, 87)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(51, 24)
        Me.sec_resmi.TabIndex = 13
        '
        'txt_belgeno
        '
        Me.txt_belgeno.EnterMoveNextControl = True
        Me.txt_belgeno.Location = New System.Drawing.Point(331, 87)
        Me.txt_belgeno.Name = "txt_belgeno"
        Me.txt_belgeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_belgeno.Size = New System.Drawing.Size(144, 26)
        Me.txt_belgeno.TabIndex = 6
        '
        'sec_fistipi
        '
        Me.sec_fistipi.EditValue = "[Tümü]"
        Me.sec_fistipi.EnterMoveNextControl = True
        Me.sec_fistipi.Location = New System.Drawing.Point(477, 29)
        Me.sec_fistipi.Name = "sec_fistipi"
        Me.sec_fistipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fistipi.Properties.Items.AddRange(New Object() {"[Tümü]", "K", "P", "PF"})
        Me.sec_fistipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_fistipi.Size = New System.Drawing.Size(128, 26)
        Me.sec_fistipi.TabIndex = 2
        '
        'txt_musterino
        '
        Me.txt_musterino.EnterMoveNextControl = True
        Me.txt_musterino.Location = New System.Drawing.Point(110, 86)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musterino.Size = New System.Drawing.Size(144, 26)
        Me.txt_musterino.TabIndex = 5
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(253, 29)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(224, 26)
        Me.txt_kasiyer.TabIndex = 1
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(110, 29)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(143, 26)
        Me.txt_kod.TabIndex = 0
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.Enabled = False
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(110, 143)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.Items.AddRange(New Object() {"[Tümü]", "D001", "D002", "D003", "D004", "D005", "D006", "D007", "D008", "D009", "D010", "AKAT", "BKAT", "GKAT", "1KAT", "2KAT", "3KAT", "4KAT", "5KAT", "6KAT", "7KAT", "8KAT", "9KAT", "", ""})
        Me.sec_depo.Properties.ReadOnly = True
        Me.sec_depo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_depo.Size = New System.Drawing.Size(144, 26)
        Me.sec_depo.TabIndex = 9
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton5.Location = New System.Drawing.Point(603, 144)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(98, 29)
        Me.SimpleButton5.TabIndex = 12
        Me.SimpleButton5.Text = "&Listele"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(485, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "arasýndaki"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(259, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 19)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(331, 59)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(144, 26)
        Me.DateEdit2.TabIndex = 4
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(110, 57)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.ReadOnly = True
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(144, 26)
        Me.DateEdit1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lbl_istihbarat)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(1689, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(347, 193)
        Me.GroupControl2.TabIndex = 24
        Me.GroupControl2.Text = "Ýstihbarat"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_istihbarat.Location = New System.Drawing.Point(2, 21)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(343, 19)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.progressBar1)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 197)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(2038, 783)
        Me.PanelControl3.TabIndex = 1
        '
        'progressBar1
        '
        Me.progressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar1.Location = New System.Drawing.Point(19, 746)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Properties.ShowTitle = True
        Me.progressBar1.Properties.Step = 1
        Me.progressBar1.Size = New System.Drawing.Size(1093, 29)
        Me.progressBar1.TabIndex = 18
        Me.progressBar1.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(2034, 779)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem24, Me.MenuItem14, Me.MenuItem3, Me.MenuItem2, Me.MenuItem4, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem29, Me.MenuItem28, Me.MenuItem30, Me.MenuItem20, Me.MenuItem19, Me.MenuItem35, Me.MenuItem5, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem6, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem24
        '
        Me.MenuItem24.DefaultItem = True
        Me.MenuItem24.Index = 1
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem24.Text = "Ýncele"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem3.Text = "Kalan Taksitler"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem2.Text = "Kalan Satýþlar"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem4.Text = "Yapýlan Ödemeler"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 6
        Me.MenuItem25.Text = "Ekstre"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 7
        Me.MenuItem26.Text = "Satýþlar"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 8
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem27.Text = "Müþteri Kartý"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 9
        Me.MenuItem29.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 10
        Me.MenuItem28.Text = "Takibe Al"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 11
        Me.MenuItem30.Text = "Ýlk Taksit Ödemesi Takip Et"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 12
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 13
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
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
        Me.MenuItem35.Index = 14
        Me.MenuItem35.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 15
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 16
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 17
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 18
        Me.MenuItem16.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 19
        Me.MenuItem6.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 20
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 21
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 22
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 23
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 24
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 25
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 26
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Red
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRMAKODU, Me.colADI, Me.colSOYADI, Me.colBELGENO, Me.colTARIH, Me.colMIKTAR, Me.colTUTAR, Me.colALISVERISNO, Me.colIZAHAT, Me.colVADEFARKI, Me.colMAGAZA, Me.colKASIYER, Me.colGIRIS, Me.colYAZI, Me.colDOGUMTARIHI, Me.colEVLILIKTARIHI, Me.colYAZDIRMA, Me.colKAYIT, Me.colSOZLESME, Me.colsAciklama, Me.colsAdres1, Me.colsAdres2, Me.colsSemt, Me.colsIl, Me.colsUlke, Me.colsPostaKodu, Me.colsVergiDairesi, Me.colsVergiNo, Me.colsAlisverisYapanSoyadi, Me.colsAlisverisYapanAdi, Me.collKazanilanPuan, Me.collHarcananPuan, Me.collMalIskontoTutari, Me.colnDipIskontoYuzdesi, Me.collDipIskontoTutari, Me.collPesinat, Me.collKapanan, Me.collKalan, Me.colnKasaNo, Me.collKdvMatrahi, Me.collKdv, Me.colsMuhasebeFaturalasma, Me.collPosFisNo})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(471, 284, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "FIRMAKODU", Nothing, "ÝþlemSayýsý: {0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "ToplamMiktar: {0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Nothing, "ToplamTutar: {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Müþteri Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FIRMAKODU", "{0} Kayýt")})
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 3
        '
        'colADI
        '
        Me.colADI.Caption = "HesapAdý"
        Me.colADI.FieldName = "ADI"
        Me.colADI.Name = "colADI"
        '
        'colSOYADI
        '
        Me.colSOYADI.Caption = "HesapSoyad"
        Me.colSOYADI.FieldName = "SOYADI"
        Me.colSOYADI.Name = "colSOYADI"
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Visible = True
        Me.colBELGENO.VisibleIndex = 2
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.00}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 6
        '
        'colTUTAR
        '
        Me.colTUTAR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTUTAR.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colTUTAR.AppearanceCell.Options.UseFont = True
        Me.colTUTAR.AppearanceCell.Options.UseForeColor = True
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 7
        '
        'colALISVERISNO
        '
        Me.colALISVERISNO.Caption = "AlýþVeriþ No"
        Me.colALISVERISNO.FieldName = "ALISVERISNO"
        Me.colALISVERISNO.Name = "colALISVERISNO"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Belge Tipi"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 1
        '
        'colVADEFARKI
        '
        Me.colVADEFARKI.Caption = "VadeFarký"
        Me.colVADEFARKI.DisplayFormat.FormatString = "#,0.00"
        Me.colVADEFARKI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVADEFARKI.FieldName = "VADEFARKI"
        Me.colVADEFARKI.Name = "colVADEFARKI"
        '
        'colMAGAZA
        '
        Me.colMAGAZA.Caption = "Maðaza"
        Me.colMAGAZA.FieldName = "MAGAZA"
        Me.colMAGAZA.Name = "colMAGAZA"
        Me.colMAGAZA.Visible = True
        Me.colMAGAZA.VisibleIndex = 8
        '
        'colKASIYER
        '
        Me.colKASIYER.Caption = "Kasiyer"
        Me.colKASIYER.FieldName = "KASIYER"
        Me.colKASIYER.Name = "colKASIYER"
        Me.colKASIYER.Visible = True
        Me.colKASIYER.VisibleIndex = 9
        '
        'colGIRIS
        '
        Me.colGIRIS.Caption = "Giriþ"
        Me.colGIRIS.FieldName = "GIRIS"
        Me.colGIRIS.Name = "colGIRIS"
        '
        'colYAZI
        '
        Me.colYAZI.Caption = "Yazý"
        Me.colYAZI.FieldName = "YAZI"
        Me.colYAZI.Name = "colYAZI"
        '
        'colDOGUMTARIHI
        '
        Me.colDOGUMTARIHI.Caption = "Doðum Tarihi"
        Me.colDOGUMTARIHI.FieldName = "DOGUMTARIHI"
        Me.colDOGUMTARIHI.Name = "colDOGUMTARIHI"
        '
        'colEVLILIKTARIHI
        '
        Me.colEVLILIKTARIHI.Caption = "Evlilik Tarihi"
        Me.colEVLILIKTARIHI.FieldName = "EVLILIKTARIHI"
        Me.colEVLILIKTARIHI.Name = "colEVLILIKTARIHI"
        '
        'colYAZDIRMA
        '
        Me.colYAZDIRMA.Caption = "Yazýlan"
        Me.colYAZDIRMA.FieldName = "YAZDIRMA"
        Me.colYAZDIRMA.Name = "colYAZDIRMA"
        '
        'colKAYIT
        '
        Me.colKAYIT.Caption = "Kayýt Saati"
        Me.colKAYIT.DisplayFormat.FormatString = "HH:mm"
        Me.colKAYIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKAYIT.FieldName = "KAYIT"
        Me.colKAYIT.Name = "colKAYIT"
        Me.colKAYIT.Visible = True
        Me.colKAYIT.VisibleIndex = 10
        '
        'colSOZLESME
        '
        Me.colSOZLESME.Caption = "Sözleþme"
        Me.colSOZLESME.FieldName = "SOZLESME"
        Me.colSOZLESME.Name = "colSOZLESME"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        '
        'colsAdres1
        '
        Me.colsAdres1.Caption = "Adres1"
        Me.colsAdres1.FieldName = "sAdres1"
        Me.colsAdres1.Name = "colsAdres1"
        '
        'colsAdres2
        '
        Me.colsAdres2.Caption = "Adres2"
        Me.colsAdres2.FieldName = "sAdres2"
        Me.colsAdres2.Name = "colsAdres2"
        '
        'colsSemt
        '
        Me.colsSemt.Caption = "Semt"
        Me.colsSemt.FieldName = "sSemt"
        Me.colsSemt.Name = "colsSemt"
        '
        'colsIl
        '
        Me.colsIl.Caption = "il"
        Me.colsIl.FieldName = "sIl"
        Me.colsIl.Name = "colsIl"
        '
        'colsUlke
        '
        Me.colsUlke.Caption = "Ulke"
        Me.colsUlke.FieldName = "sUlke"
        Me.colsUlke.Name = "colsUlke"
        '
        'colsPostaKodu
        '
        Me.colsPostaKodu.Caption = "PostaKodu"
        Me.colsPostaKodu.FieldName = "sPostaKodu"
        Me.colsPostaKodu.Name = "colsPostaKodu"
        '
        'colsVergiDairesi
        '
        Me.colsVergiDairesi.Caption = "Vergi Dairesi"
        Me.colsVergiDairesi.FieldName = "sVergiDairesi"
        Me.colsVergiDairesi.Name = "colsVergiDairesi"
        '
        'colsVergiNo
        '
        Me.colsVergiNo.Caption = "Vergi No"
        Me.colsVergiNo.FieldName = "sVergiNo"
        Me.colsVergiNo.Name = "colsVergiNo"
        '
        'colsAlisverisYapanSoyadi
        '
        Me.colsAlisverisYapanSoyadi.Caption = "Ad"
        Me.colsAlisverisYapanSoyadi.FieldName = "sAlisverisYapanAdi"
        Me.colsAlisverisYapanSoyadi.Name = "colsAlisverisYapanSoyadi"
        Me.colsAlisverisYapanSoyadi.Visible = True
        Me.colsAlisverisYapanSoyadi.VisibleIndex = 4
        '
        'colsAlisverisYapanAdi
        '
        Me.colsAlisverisYapanAdi.Caption = "Soyad"
        Me.colsAlisverisYapanAdi.FieldName = "sAlisverisYapanSoyadi"
        Me.colsAlisverisYapanAdi.Name = "colsAlisverisYapanAdi"
        Me.colsAlisverisYapanAdi.Visible = True
        Me.colsAlisverisYapanAdi.VisibleIndex = 5
        '
        'collKazanilanPuan
        '
        Me.collKazanilanPuan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collKazanilanPuan.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.collKazanilanPuan.AppearanceCell.Options.UseFont = True
        Me.collKazanilanPuan.AppearanceCell.Options.UseForeColor = True
        Me.collKazanilanPuan.Caption = "KazanilanPuan"
        Me.collKazanilanPuan.DisplayFormat.FormatString = "#,#.####"
        Me.collKazanilanPuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKazanilanPuan.FieldName = "lKazanilanPuan"
        Me.collKazanilanPuan.Name = "collKazanilanPuan"
        Me.collKazanilanPuan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKazanilanPuan", "{0:#,#.####}")})
        '
        'collHarcananPuan
        '
        Me.collHarcananPuan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collHarcananPuan.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.collHarcananPuan.AppearanceCell.Options.UseFont = True
        Me.collHarcananPuan.AppearanceCell.Options.UseForeColor = True
        Me.collHarcananPuan.Caption = "HarcananPuan"
        Me.collHarcananPuan.DisplayFormat.FormatString = "#,#.####"
        Me.collHarcananPuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collHarcananPuan.FieldName = "lHarcananPuan"
        Me.collHarcananPuan.Name = "collHarcananPuan"
        Me.collHarcananPuan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lHarcananPuan", "{0:#,#.####}")})
        '
        'collMalIskontoTutari
        '
        Me.collMalIskontoTutari.Caption = "Mal Ýskonto Tutarý"
        Me.collMalIskontoTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collMalIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalIskontoTutari.FieldName = "lMalIskontoTutari"
        Me.collMalIskontoTutari.Name = "collMalIskontoTutari"
        Me.collMalIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalIskontoTutari", "{0:#,0.00##}")})
        '
        'colnDipIskontoYuzdesi
        '
        Me.colnDipIskontoYuzdesi.Caption = "Dip Ýskonto Yüzdesi"
        Me.colnDipIskontoYuzdesi.DisplayFormat.FormatString = "#,0.00##"
        Me.colnDipIskontoYuzdesi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnDipIskontoYuzdesi.FieldName = "nDipIskontoYuzdesi"
        Me.colnDipIskontoYuzdesi.Name = "colnDipIskontoYuzdesi"
        Me.colnDipIskontoYuzdesi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nDipIskontoYuzdesi", "{0:#,0.00##}")})
        '
        'collDipIskontoTutari
        '
        Me.collDipIskontoTutari.Caption = "Dip Ýskonto Tutarý"
        Me.collDipIskontoTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collDipIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDipIskontoTutari.FieldName = "lDipIskontoTutari"
        Me.collDipIskontoTutari.Name = "collDipIskontoTutari"
        Me.collDipIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDipIskontoTutari", "{0:#,0.00##}")})
        '
        'collPesinat
        '
        Me.collPesinat.Caption = "Peþinat"
        Me.collPesinat.DisplayFormat.FormatString = "#,0.00##"
        Me.collPesinat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPesinat.FieldName = "lPesinat"
        Me.collPesinat.Name = "collPesinat"
        Me.collPesinat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPesinat", "{0:#,0.00##}")})
        '
        'collKapanan
        '
        Me.collKapanan.Caption = "Kapanan"
        Me.collKapanan.DisplayFormat.FormatString = "#,0.00"
        Me.collKapanan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKapanan.FieldName = "lKapanan"
        Me.collKapanan.Name = "collKapanan"
        Me.collKapanan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKapanan", "{0:#,0.00}")})
        '
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.00"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.00}")})
        '
        'colnKasaNo
        '
        Me.colnKasaNo.Caption = "KasaNo"
        Me.colnKasaNo.FieldName = "nKasaNo"
        Me.colnKasaNo.Name = "colnKasaNo"
        '
        'collKdvMatrahi
        '
        Me.collKdvMatrahi.Caption = "KDV Matrahý"
        Me.collKdvMatrahi.FieldName = "lKdvMatrahi"
        Me.collKdvMatrahi.Name = "collKdvMatrahi"
        Me.collKdvMatrahi.Visible = True
        Me.collKdvMatrahi.VisibleIndex = 11
        '
        'collKdv
        '
        Me.collKdv.Caption = "KDV Tutarý"
        Me.collKdv.FieldName = "lKdv"
        Me.collKdv.Name = "collKdv"
        Me.collKdv.Visible = True
        Me.collKdv.VisibleIndex = 12
        '
        'colsMuhasebeFaturalasma
        '
        Me.colsMuhasebeFaturalasma.Caption = "Muh.Durum"
        Me.colsMuhasebeFaturalasma.FieldName = "sMuhasebeFaturalasma"
        Me.colsMuhasebeFaturalasma.Name = "colsMuhasebeFaturalasma"
        Me.colsMuhasebeFaturalasma.Visible = True
        Me.colsMuhasebeFaturalasma.VisibleIndex = 13
        '
        'collPosFisNo
        '
        Me.collPosFisNo.Caption = "Pos Fiþ No"
        Me.collPosFisNo.FieldName = "PosFisNo"
        Me.collPosFisNo.Name = "collPosFisNo"
        Me.collPosFisNo.Visible = True
        Me.collPosFisNo.VisibleIndex = 14
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Perakende Satýþlar", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Ýþ Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Ekle,Insert"
        Me.BarButtonItem2.Enabled = False
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Düzelt,F4"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem4.Enabled = False
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Müþteri Kartý"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Satýþlar"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Ekstre"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Kalan Satislar"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Kalan Taksitler"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(2038, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1060)
        Me.barDockControlBottom.Size = New System.Drawing.Size(2038, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 1060)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(2038, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1060)
        '
        'frm_stok_pesin_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(2038, 1090)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_pesin_liste"
        Me.Text = "Perakende Satýþlar"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_sTarihTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bTaksitHatali.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bSatisYapilamaz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bAvukatlik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bIadeDegisim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sKapama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAVSoyadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAVadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.progressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean = False
    Public connection
    Public connection_resmi
    Public connection_orj
    Public connection_resmi1
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Public sFisTipi As String = ""
    Public sKasiyerler As String = ""
    Public sDepolar As String = ""
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public frf_islem As String = "mektup"
    Dim depokodu As String
    Dim ds_kasiyer As DataSet
    Dim dataset1 As New DataSet
    Dim ds_satir_firma As DataSet
    Dim ds_stok_fisi_detay As DataSet
    Public kasiyerno As String
    Public kasiyer As String
    Public kasiyer_depo As String = ""
    Public sMagaza As String
    Dim sinifBilgi2 As String = ""
    Private Sub frm_stok_pesin_liste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU_RESMI")
        connection_resmi1 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU_RESMI1")
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        Try
            depokodu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
            If depokodu <> "True" Then
                sec_depo.Text = depokodu
            Else
                sec_depo.Text = "[Tümü]"
            End If
        Catch ex As Exception
            'dr("DEPO") = "1KAT"
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", "True")
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        Me.WindowState = FormWindowState.Maximized
        Me.Refresh()
        dataload_kasiyer()
        dataload_tbSatici()
        txt_kod.Focus()
        txt_kod.Select()
        hatirlaKontrol()
    End Sub
    Private Sub hatirlaKontrol(Optional ByVal kapat As Boolean = False)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim hatKon As Boolean = False
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If kapat = False Then
            cmd.CommandText = sorgu_query("IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_NAME='aHatirla') BEGIN SELECT * from aHatirla; End ELSE BEGIN CREATE TABLE aHatirla (POSUpdate Bit); insert into aHatirla values('False'); SELECT * from aHatirla; END")
        Else
            cmd.CommandText = sorgu_query("IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_NAME='aHatirla') BEGIN DELETE FROM aHatirla; insert into aHatirla values('False'); SELECT * from aHatirla; End ELSE BEGIN CREATE TABLE aHatirla (POSUpdate Bit); insert into aHatirla values('False'); SELECT * from aHatirla; END")
        End If
        hatKon = Boolean.Parse(cmd.ExecuteScalar.ToString())
        If hatKon = True Then
            XtraMessageBox.Show(Sorgu_sDil("Yeni bir Pos hareket aktarýmý algýlandý." & vbCrLf & "Satýþlarýn doðru görüntülenmesi için," & vbCrLf & "güncellemelerin yapýlmasý gereklidir...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
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
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_tbSatici()
        sec_sSaticiRumuzu.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi  FROM         tbSatici Order by sSaticiRumuzu")).Tables(0)
        sec_sSaticiRumuzu.ItemIndex = 0
    End Sub
    Private Sub dataload_depo()
        'sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kod.Text Then
                kasiyerno = dr("IND")
                kasiyer = dr("KASIYER")
                sMagaza = dr("DEPO")
                kasiyer_depo = dr("DEPO")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            txt_kasiyer.EditValue = kasiyer
            txt_kod.Enabled = False
            If Trim(kasiyerno) = "VC" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                sec_depo.Properties.ReadOnly = False
                'sec_sonuc.Properties.ReadOnly = False
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "AL" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                sec_depo.Properties.ReadOnly = False
                'sec_sonuc.Properties.ReadOnly = False
            Else
            End If
            DateEdit1.Focus()
            DateEdit1.SelectAll()
            GridControl1.Enabled = True
            status = True
        ElseIf sonuc = False Then
            txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            GridControl1.Enabled = False
            txt_kod.Focus()
            txt_kod.SelectAll()
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasiyerno As String, ByVal musterikodu As String, ByVal belgeno As String, ByVal sAvYapanAdi As String, ByVal sAvYapanSoyadi As String, ByVal sSaticiRumuzu As String, ByVal sKapama As String, ByVal bIadeDegisim As Boolean, ByVal bAvukatlik As Boolean, ByVal bSatisYapilamaz As Boolean)
        Dim kriter_musteri = ""
        Dim kriter_belgeno = ""
        Dim kasiyer_satis = ""
        Dim kriter_kapama = ""
        Dim kriter As String = ""
        If sec_sTarihTipi.SelectedIndex = 0 Then
            kriter += " Where tbAlisVeris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        ElseIf sec_sTarihTipi.SelectedIndex = 1 Then
            tarih1 = Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00"
            tarih2 = Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59"
            kriter += " Where tbAlisVeris.dteKayitTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        End If
        If Trim(kasiyerno) = "VC" Then
        ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
        ElseIf Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "AL" Then
            kasiyer_satis = " AND tbAlisVeris.sMagaza ='" & kasiyer_depo & "' "
        Else
            kasiyer_satis = " AND tbAlisVeris.sKasiyerRumuzu ='" & kasiyerno & "' "
        End If
        If musterikodu <> "" Then
            kriter_musteri = " AND tbMusteri.lKodu = '" & Trim(musterikodu) & "' "
        End If
        If bAvukatlik = True Then
            kriter_musteri = " AND tbMusteri.nMusteriID IN (SELECT DISTINCT nMusteriID FROM tbMusteriSinifi WHERE (sSinifKodu6 <> '')) "
        End If
        If bSatisYapilamaz = True Then
            kriter_musteri = " AND tbMusteri.nMusteriID IN (SELECT DISTINCT tbMusteriSinifi.nMusteriID FROM tbMusteriSinifi INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN                       tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN                       tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN                       tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN                       tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu INNER JOIN                       tbMSinif6 ON tbMusteriSinifi.sSinifKodu6 = tbMSinif6.sSinifKodu INNER JOIN                       tbMSinif7 ON tbMusteriSinifi.sSinifKodu7 = tbMSinif7.sSinifKodu INNER JOIN                       tbMSinif8 ON tbMusteriSinifi.sSinifKodu8 = tbMSinif8.sSinifKodu INNER JOIN                       tbMSinif9 ON tbMusteriSinifi.sSinifKodu9 = tbMSinif9.sSinifKodu INNER JOIN                       tbMSinif10 ON tbMusteriSinifi.sSinifKodu10 = tbMSinif10.sSinifKodu WHERE     (tbMSinif1.bSatisYapilamaz = 1) OR                       (tbMSinif2.bSatisYapilamaz = 1) OR                       (tbMSinif3.bSatisYapilamaz = 1) OR                       (tbMSinif4.bSatisYapilamaz = 1) OR                       (tbMSinif5.bSatisYapilamaz = 1) OR                       (tbMSinif6.bSatisYapilamaz = 1) OR                       (tbMSinif7.bSatisYapilamaz = 1) OR                       (tbMSinif8.bSatisYapilamaz = 1) OR                       (tbMSinif9.bSatisYapilamaz = 1) OR                       (tbMSinif10.bSatisYapilamaz = 1)) "
        End If
        If Trim(belgeno) <> "" Then
            kriter_belgeno = " AND tbAlisVeris.lFaturaNo = '" & Trim(belgeno) & "' "
        End If
        If sAvYapanAdi <> "" Then
            kriter_musteri += " And tbAlisVeris.sAlisVerisYapanAdi like '" & sAvYapanAdi & "%' "
        End If
        If sAvYapanSoyadi <> "" Then
            kriter_musteri += " And tbAlisVeris.sAlisVerisYapanSoyadi like '" & sAvYapanSoyadi & "%' "
        End If
        If sFisTipi <> "" Then
            kriter_musteri += " And tbAlisVeris.sFisTipi = '" & sFisTipi & "' "
        End If
        If Trim(sSaticiRumuzu) <> "" Then
            kriter_musteri += " and tbAlisVeris.nAlisVerisID IN (SELECT nAlisVerisID FROM (SELECT nAlisVerisID, sSaticiRumuzu FROM tbStokFisiDetayi " & kriter & " and sSaticiRumuzu ='" & sSaticiRumuzu & "' UNION ALL SELECT nAlisVerisID , sSaticiRumuzu FROM tbAlisVerisSiparis " & kriter & " and sSaticiRumuzu = '" & sSaticiRumuzu & "') tbAlisVerisSaticisi)"
        End If
        If sKapama = "[Tümü]" Then
            kriter_kapama = ""
        ElseIf sKapama = "Açýk" Then
            kriter_kapama = " WHERE TUTAR <> lKapanan "
        ElseIf sKapama = "Kapalý" Then
            kriter_kapama = " WHERE TUTAR = lKapanan "
        End If
        If bIadeDegisim = True Then
            kasiyer_satis += "AND tbAlisVeris.nAlisVerisID IN (SELECT tbStokFisiDetayi.nAlisverisID FROM tbStokFisiDetayi INNER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbStokFisiDetayi.lCikisMiktar1 < 0) AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kasiyer_satis & " UNION ALL SELECT tbAlisVeris.nAlisverisID FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID " & kriter & " AND tbAlisVerisSiparis.lGCMiktar < 0) " & kasiyer_satis & "  "
        End If
        If sec_bTaksitHatali.Checked = True Then
            kriter_musteri += "AND tbAlisVeris.nAlisVerisID IN (SELECT nAlisVerisID FROM tbTaksit WHERE (lTutari <= 0))  "
        End If
        dataset1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, ABS(TUTAR)-ABS(lKapanan) as lKalan FROM (SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS FIRMAKODU, tbMusteri.sAdi AS ADI, tbMusteri.sSoyadi AS SOYADI, tbAlisVeris.lFaturaNo AS BELGENO, tbAlisVeris.PosFisNo,ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma, tbAlisVeris.dteFaturaTarihi AS TARIH, tbAlisVeris.lToplamMiktar AS MIKTAR, tbAlisVeris.lNetTutar AS TUTAR, (tbAlisVeris.lKdvMatrahi1 + tbAlisVeris.lKdvMatrahi2 + tbAlisVeris.lKdvMatrahi3 + tbAlisVeris.lKdvMatrahi4 + tbAlisVeris.lKdvMatrahi5) as lKdvMatrahi, (tbAlisVeris.lKdv1 + tbAlisVeris.lKdv2 + tbAlisVeris.lKdv3 + tbAlisVeris.lKdv4 + tbAlisVeris.lKdv5) as lKdv, tbAlisVeris.nAlisverisID AS ALISVERISNO, tbAlisVeris.sFisTipi AS IZAHAT, tbAlisVeris.lVadeFarki AS VADEFARKI, tbAlisVeris.sMagaza AS MAGAZA, tbAlisVeris.sKasiyerRumuzu AS KASIYER, tbAlisVeris.nKasaNo,tbAlisVeris.nGirisCikis AS GIRIS, tbAlisVeris.sYaziIle AS YAZI, tbMusteri.dteDogumTarihi AS DOGUMTARIHI, tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI, tbAlisVeris.dteKayitTarihi AS KAYIT, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl, tbAlisVerisAdres.sUlke, tbAlisVerisAdres.sPostaKodu, tbAlisVerisAdres.sVergiDairesi, tbAlisVerisAdres.sVergiNo,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_KAZ' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lKazanilanPuan, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_HAR' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lHarcananPuan,tbAlisVeris.lMalIskontoTutari, tbAlisVeris.nDipIskontoYuzdesi, tbAlisVeris.lDipIskontoTutari, tbAlisVeris.lPesinat,(SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = tbAlisVeris.nAlisVerisID UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = tbAlisVeris.nAlisVerisID) AND (nOdemeKodu = 3)) Kapatma) AS lKapanan FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter & " " & kriter_musteri & " AND (tbAlisVeris.sFisTipi IN ('K','P','SK','SP') ) " & kasiyer_satis & ") tbAlisverisler " & kriter_kapama & " "))
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Public Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub sorgu_dokumler(ByVal query As String)
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        cmd.CommandTimeout = False
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(dataset1.Tables(0))
        conn.Close()
        DS = Nothing
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
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
            frm.musterino = dr("FIRMAKODU")
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
            frm.musterino = dr("FIRMAKODU")
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
            frm.musterino = dr("FIRMAKODU")
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
            frm.musterikodu = dr("FIRMAKODU")
            frm.tarih = dr("TARIH")
            frm.belgeno = dr("BELGENO")
            frm.tumu = True
            'frm.stokno = dr("ALISVERISNO")
            frm.fistipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub dataload_tbMusteriSinif2(ByVal nMusteriID As Int64)
        Dim sinifI2 As String = ""
        Dim kriter = "SELECT tbMSinif2.sSinifKodu FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query(kriter)
        sinifBilgi2 = cmd.ExecuteScalar.ToString()
    End Sub
    Private Sub stok_satis_detay(Optional ByVal otoEkle As Boolean = False)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If sorgu_nAlisVerisID_lSayi(dr("ALISVERISNO")) > 0 Then
            Dim frm As New frm_Perakende_Satis
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.nAlisVerisID = dr("ALISVERISNO")
            frm.sFisTipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            frm.nMusteriID = dr("nMusteriID")
            frm.sMagaza = dr("MAGAZA")
            frm.otomatikEkle = otoEkle
            If sDatabaseGenel = "UGURLU" Then
                frm.sinifBilgi2 = sinifBilgi2
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
            'frm.Close()
            'frm.Dispose()
            'frm = Nothing
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        dr = Nothing
    End Sub
    Public Function sorgu_nAlisVerisID_lSayi(ByVal nAlisVerisID As String) As Integer
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        Dim kayitsayisi
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisVerisID), 0) AS nKayit FROM         tbAlisVeris WHERE     (nAlisverisID = '" & nAlisVerisID & "')")
        kayitsayisi = 0
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "') UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = '" & nAlisVerisID & "') as Kapatma")
        kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub stok_odeme_detay()
        Dim frm As New frm_stok_cari_odeme
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.musterikodu = dr("FIRMAKODU")
        frm.tarih = dr("TARIH")
        frm.belgeno = dr("BELGENO")
        'frm.stokno = dr("ALISVERISNO")
        frm.fistipi = Trim(dr("IZAHAT").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
    End Sub
    Private Sub incele()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("IZAHAT")).ToString = "OD" Then
                stok_odeme_detay()
                ara()
            Else
                If sDatabaseGenel = "UGURLU" Then
                    dataload_tbMusteriSinif2(dr("nMusteriID"))
                End If
                stok_satis_detay()
                'ara()
            End If
        End If
    End Sub
    Private Sub musteri_sec()
        If Trim(kasiyer.ToString) <> "" Then
            Dim frm As New frm_musteri_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.musterino = dr_baslik("FIRMAKODU")
            frm.islemstatus = True
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                txt_musterino.EditValue = dr1("lKodu")
                dr1 = Nothing
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Kasiyer Bilgilerinizi Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_kasiyer.Focus()
            txt_kasiyer.SelectAll()
        End If
    End Sub
    Private Sub frm_stok_pesin_liste_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub txt_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
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
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_isim.Text = dr("ADI").ToString & " " & dr("SOYADI").ToString
            Dim gun_dogum
            Dim yil As String = ""
            Dim gun As String = ""
            Dim ay As String = ""
            If Trim(dr("DOGUMTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr("DOGUMTARIHI")).ToString.Substring(3, 2) = "01" Then
            ElseIf Trim(dr("DOGUMTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            Else
                'lbl_isim.Text += "  Doðum Tarihi :" & dr("DOGUMTARIHI").ToLongDateString
                yil = Today.ToString.Substring(8, 2)
                gun = dr("DOGUMTARIHI").ToString.Substring(0, 2)
                ay = dr("DOGUMTARIHI").ToString.Substring(3, 2)
                lbl_isim.Text += "  Doðum Günü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                If gun_dogum > 0 And gun_dogum < 30 Then
                    lbl_isim.Text += " " & gun_dogum & " Gün Sonra Doðum Gününüz.Þimdiden Doðum Gününüz Kutlu Olsun..!"
                ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                    lbl_isim.Text += " " & Math.Abs(gun_dogum) & " Gün Önce Doðum Gününüzmüþ...Nice Senelere..!"
                ElseIf gun_dogum = 0 Then
                    lbl_isim.Text += "  Doðum Gününüz Kutlu Olsun...!"
                End If
            End If
            lbl_istihbarat.Text = dr("ISTIHBARAT")
            If Trim(dr("EVLILIKTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr("EVLILIKTARIHI")).ToString.Substring(3, 2) = "01" Then
            ElseIf Trim(dr("EVLILIKTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            Else
                lbl_isim.Text += "  Evlilik Tarihi :" & dr("EVLILIKTARIHI")
                yil = Today.ToString.Substring(8, 2)
                gun = dr("EVLILIKTARIHI").ToString.Substring(0, 2)
                ay = dr("EVLILIKTARIHI").ToString.Substring(3, 2)
                lbl_isim.Text += "  Evlilik Yýldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                If gun_dogum > 0 And gun_dogum < 30 Then
                    lbl_isim.Text += " " & gun_dogum & " Gün Sonra Evlilik Yýldönümünüz.Þimdiden Evlilik Yýldönümünüz Kutlu Olsun..!"
                ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                    lbl_isim.Text += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yýldönümünüzmüþ...Nice Senelere..!"
                ElseIf gun_dogum = 0 Then
                    lbl_isim.Text += "  Evlilik Yýldönümünüz Kutlu Olsun...!"
                End If
            End If
        Else
            Label5.Text = "*"
        End If
        If GridView1.SelectedRowsCount > 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label5.Text = ""
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        ara()
    End Sub
    Private Sub ara()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim satir = GridView1.FocusedRowHandle
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, txt_sAVadi.Text, txt_sAVSoyadi.Text, sec_sSaticiRumuzu.Text, sec_sKapama.Text, sec_bIadeDegisim.Checked, sec_bAvukatlik.Checked, sec_bSatisYapilamaz.Checked)
        GridView1.FocusedRowHandle = satir
        satir = Nothing
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += DateEdit1.EditValue & " ve " & DateEdit2.EditValue & " Tarihleri Arasýndaki Perakende Satýþ Tablosu" & vbCrLf
        kriter += "Magaza: " & sec_depo.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Perakende Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        incele()
    End Sub
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
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            incele()
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        incele()
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, txt_sAVadi.Text, txt_sAVSoyadi.Text, sec_sSaticiRumuzu.Text, sec_sKapama.Text, sec_bIadeDegisim.Checked, sec_bAvukatlik.Checked, sec_bSatisYapilamaz.Checked)
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, txt_sAVadi.Text, txt_sAVSoyadi.Text, sec_sSaticiRumuzu.Text, sec_sKapama.Text, sec_bIadeDegisim.Checked, sec_bAvukatlik.Checked, sec_bSatisYapilamaz.Checked)
        End If
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
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        incele()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Space Then
            If Trim(txt_musterino.Text) = "" Then
                musteri_sec()
            End If
        End If
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal nIslem As Integer, Optional ByVal bFis As Boolean = False, Optional ByVal bFatura As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (PerakendeSatis*.frx) |PerakendeSatis*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            Dim ds_baslik As DataSet
            Dim ds_hareket As DataSet
            Dim ds_toplam As DataSet
            Dim nAlisVerisID As String = dr("ALISVERISNO")
            Dim sFisTipi As String = dr("IZAHAT")
            ds_baslik = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.nMusteriID, tbAlisVeris.sMagaza, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.sHareketTipi, tbAlisVeris.bMuhasebeyeIslendimi, tbAlisVeris.nKasaNo, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisVeris.sYaziIle, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl, tbAlisVerisAdres.sUlke, tbAlisVerisAdres.sPostaKodu, tbAlisVerisAdres.sVergiDairesi, tbAlisVerisAdres.sVergiNo, tbAlisVerisAdres.sSubeMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri,tbMusteri.sGsm,tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu,tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,(SELECT      CAST(bSatismi AS integer) AS bSatismi FROM          tbFisTipi WHERE      sFisTipi = tbAlisVeris.sFisTipi) AS nGCT,tbMusteri.nIskontoPesin,tbMusteri.nIskontoKredili FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID WHERE (tbAlisVeris.nAlisverisID = '" & nAlisVerisID & "')"), "BASLIK")
            If Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
                ds_hareket = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.nAlisverisID, tbAlisverisSiparis.sMagazaKodu, tbAlisverisSiparis.nSiparisID, tbAlisverisSiparis.nGirisCikis, tbAlisverisSiparis.nStokID, tbAlisverisSiparis.sKasiyerRumuzu, tbAlisverisSiparis.sSaticiRumuzu, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.lReyonFisNo, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.lGCMiktar AS lCikisMiktar1, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari, tbAlisverisSiparis.lFiyat AS lCikisFiyat, 0 as lGirisFiyat,0 as lGirisTutar, tbAlisverisSiparis.lTutar AS lCikisTutar, tbAlisverisSiparis.nKdvOrani, tbAlisverisSiparis.sIadeNedeni, tbAlisverisSiparis.nPartiID, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisverisSiparis.dteTeslimEdilen, tbAlisverisSiparis.bTeslimEdildi, tbAlisverisSiparis.bMuhasebeyeIslendimi, tbAlisverisSiparis.sAciklama, tbAlisverisSiparis.bEkSoru, tbAlisverisSiparis.bEkAlan1, tbAlisverisSiparis.bEkAlan2, tbAlisverisSiparis.sDovizCinsi1, tbAlisverisSiparis.lDovizMiktari1, tbAlisverisSiparis.lDovizKuru1, tbAlisverisSiparis.sSonKullaniciAdi, tbAlisverisSiparis.dteSonUpdateTarihi, tbAlisverisSiparis.dteOnayTarihi, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, (SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sBeden, tbStok.sBirimCinsi1, tbStok.sModel FROM tbAlisverisSiparis INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID Where tbAlisVerisSiparis.nAlisverisID = '" & nAlisVerisID & "' ORDER BY tbAlisVerisSiparis.nSiparisID"), "HAREKET")
            Else
                ds_hareket = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,tbStok.sModel,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE     (tbStokFisiDetayi.nAlisverisID = '" & nAlisVerisID & "') ORDER BY tbStokFisiDetayi.nIslemID"), "HAREKET")
            End If
            ds_toplam = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1 = CASE WHEN (lMalBedeli-lMalIskontoTutari) <> 0 THEN (lDipIskontoTutari - lHarcananPuan) / (lMalBedeli-lMalIskontoTutari) * 100 ELSE 0 END, lDipIskontoTutari - lHarcananPuan AS lDipIskontoTutari1, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, lKazanilanPuan, lHarcananPuan, nDipIskontoYuzdesi , lDipIskontoTutari  FROM (SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_KAZ' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lKazanilanPuan, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_HAR' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lHarcananPuan FROM tbAlisVeris WHERE (nAlisverisID = '" & nAlisVerisID & "')) tbToplam "), "TOPLAM")
            report.RegisterData(ds_baslik)
            report.RegisterData(ds_hareket)
            report.RegisterData(ds_toplam)
            report.SetParameterValue("dteFaturaTarihi", dr("TARIH"))
            report.SetParameterValue("lFaturaNo", dr("BELGENO"))
            report.SetParameterValue("sFisTipi", dr("IZAHAT"))
            Dim sIsim As String = ""
            sIsim = dr("ADI") & " " & dr("SOYADI")
            Dim gun_evlilik As String = ""
            Dim gun_dogum
            Dim yil
            Dim gun
            Dim ay
            If Trim(dr("EVLILIKTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr("EVLILIKTARIHI")).ToString.Substring(3, 2) = "01" Then
            ElseIf Trim(dr("EVLILIKTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            Else
                sIsim += "  Evlilik Tarihi :" & dr("EVLILIKTARIHI")
                yil = Today.ToString.Substring(8, 2)
                gun = dr("EVLILIKTARIHI").ToString.Substring(0, 2)
                ay = dr("EVLILIKTARIHI").ToString.Substring(3, 2)
                sIsim += "  Evlilik Yýldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                If gun_dogum > 0 And gun_dogum < 30 Then
                    sIsim += " " & gun_dogum & " Gün Sonra Evlilik Yýldönümünüz.Þimdiden Evlilik Yýldönümünüz Kutlu Olsun..!"
                ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                    sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yýldönümünüzmüþ...Nice Senelere..!"
                ElseIf gun_dogum = 0 Then
                    sIsim += "  Evlilik Yýldönümünüz Kutlu Olsun...!"
                End If
            End If
            report.SetParameterValue("Anons", "" & sIsim & "")
            If dr("MIKTAR") > 0 Then
                If Trim(sFisTipi) = "K" Then
                    report.SetParameterValue("BelgeTipi", "Kredili Satýþ")
                ElseIf Trim(sFisTipi) = "SK" Then
                    report.SetParameterValue("BelgeTipi", "Sonradan Teslim Kredili Satýþ")
                ElseIf Trim(sFisTipi) = "SP" Then
                    report.SetParameterValue("BelgeTipi", "Sonradan Teslim Peþin Satýþ")
                ElseIf Trim(sFisTipi) = "P" Then
                    report.SetParameterValue("BelgeTipi", "Peþin Satýþ")
                End If
            ElseIf dr("MIKTAR") <= 0 Then
                If Trim(sFisTipi) = "K" Then
                    report.SetParameterValue("BelgeTipi", "Kredili Satýþ Ýade/Deðiþim")
                ElseIf Trim(sFisTipi) = "SK" Then
                    report.SetParameterValue("BelgeTipi", "Sonradan Teslim Kredili Satýþ Ýade/Deðiþim")
                ElseIf Trim(sFisTipi) = "SP" Then
                    report.SetParameterValue("BelgeTipi", "Sonradan Teslim Peþin SatýþÝade/Deðiþim")
                ElseIf Trim(sFisTipi) = "P" Then
                    report.SetParameterValue("BelgeTipi", "Peþin Satýþ Ýade/Deðiþim")
                End If
            End If
            Dim ds_pesinat As DataSet
            Dim ds_taksit As DataSet
            Dim ds_AVHediyeCeki As DataSet
            Dim ds_KalanPuan As DataSet
            Dim ds_TaksitKalan As DataSet
            Dim ds_Kampanya As DataSet
            Dim ds_Anons As DataSet
            Dim ds_MusteriKefil1 As DataSet
            ds_pesinat = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbOdeme WHERE (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID "), "Pesinat")
            ds_taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbTaksit WHERE (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
            ds_AVHediyeCeki = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, sAlinanBasilan, sHediyeCekiSeriNo, sHediyeCekiTipi, lTutar, dteGecerliBaslangicTarih, dteGecerliBitisTarih, lUzerindekiTutar, " & dr("TUTAR") & " AS lAlisVerisTutari, lTutar / " & dr("TUTAR") & " * 100 AS nOran FROM tbAVHediyeCeki WHERE nAlisVerisID = '" & nAlisVerisID & "' "), "AVHediyeCeki")
            ds_KalanPuan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKazanilanPuan - lHarcananPuan), 0) AS lKalanPuan FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , SUM(tbAVHediyeCeki.lTutar) AS lKazanilanPuan , 0 AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi = 'ParaPU_KAZ') and tbMusteri.nMusteriID = " & dr("nMusteriID") & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu UNION ALL SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , 0 AS lKazanilanPuan , SUM(tbAVHediyeCeki.lTutar) AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi IN ('ParaPU_HAR','ParaPU_AL')) and tbMusteri.nMusteriID = " & dr("nMusteriID") & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbPuan Where (nMusteriID = " & dr("nMusteriID") & ") "), "KalanPuan")
            ds_TaksitKalan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & dr("nMusteriID") & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi "), "KalanTaksit")
            ds_MusteriKefil1 = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMusteriKefil1 WHERE nMusteriID  = " & dr("nMusteriID") & "", "Kefil1")
            ds_Kampanya = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ATBLDOKUMKAMPANYA", "KAMPANYA")
            ds_Anons = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ATBLDOKUMANONS", "ANONS")
            report.RegisterData(ds_pesinat)
            report.RegisterData(ds_taksit)
            report.RegisterData(ds_AVHediyeCeki)
            report.RegisterData(ds_KalanPuan)
            report.RegisterData(ds_TaksitKalan)
            report.RegisterData(ds_MusteriKefil1)
            report.RegisterData(ds_Kampanya)
            report.RegisterData(ds_Anons)
            report.RegisterData(ds_tbParamGenel)
            report.ScriptLanguage = FastReport.Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 2 Then
                report.Design()
            ElseIf nIslem = 1 Then
                report.Print()
            End If
            ds_baslik.Dispose()
            ds_hareket.Dispose()
            ds_toplam.Dispose()
            ds_pesinat.Dispose()
            ds_taksit.Dispose()
            ds_AVHediyeCeki.Dispose()
            ds_KalanPuan.Dispose()
            ds_TaksitKalan.Dispose()
            ds_baslik = Nothing
            ds_hareket = Nothing
            ds_toplam = Nothing
            ds_pesinat = Nothing
            ds_taksit = Nothing
            ds_AVHediyeCeki = Nothing
            ds_KalanPuan = Nothing
            ds_TaksitKalan = Nothing
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        raporla(0, 0, True, False)
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(0, 2, True, False)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla(0, 1, True, False)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Public Function sorgu_lPesinat_lTutari(ByVal nAlisVerisID) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar), 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        If XtraMessageBox.Show(Sorgu_sDil("POS kayýt güncelleme sistemi listedeki" & vbCrLf & "tüm kayýtlarý düzenleyecek, kabul ediyormusunuz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            progressBar1.Position = 0
            progressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count()
            progressBar1.Visible = True
            Dim dr As DataRow
            Dim i As Integer = 0
            'Dim lKapanan As Decimal
            GridControl1.Enabled = False
            'For Each dr In dataset1.Tables(0).Rows
            For i = 0 To GridView1.RowCount
                GridView1.FocusedRowHandle = i
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Trim(dr("IZAHAT").ToString()) = "K" Or Trim(dr("IZAHAT").ToString()) = "SK" Then
                    Try
                        stok_satis_detay(True)
                    Catch ex As Exception
                        MessageBox.Show(Trim(dr("BELGENO").ToString()) & " Numaralý Belgede HATA")
                    End Try
                ElseIf Trim(dr("IZAHAT").ToString()) = "P" Or Trim(dr("IZAHAT").ToString()) = "SP" Then
                    Try
                        If CType(Trim(dr("lKalan").ToString()), Decimal) <> 0 Then
                            '    If CType(Trim(dr("lKalan").ToString()), Decimal) < 0 And CType(Trim(dr("TUTAR").ToString()), Decimal) < 0 Then
                            '        lKapanan = (CType(Trim(dr("TUTAR").ToString()), Decimal) + CType(Trim(dr("lKalan").ToString()), Decimal)) * -1
                            '        pesinSatisDuzelt(Trim(dr("BELGENO").ToString()), lKapanan)
                            '    ElseIf CType(Trim(dr("lKalan").ToString()), Decimal) < 0 And CType(Trim(dr("TUTAR").ToString()), Decimal) > 0 Then
                            '        lKapanan = CType(Trim(dr("TUTAR").ToString()), Decimal) + (CType(Trim(dr("lKalan").ToString()), Decimal) * -1)
                            '        pesinSatisDuzelt(Trim(dr("BELGENO").ToString()), lKapanan)
                            '    ElseIf CType(Trim(dr("lKalan").ToString()), Decimal) > 0 And CType(Trim(dr("TUTAR").ToString()), Decimal) < 0 Then
                            '        lKapanan = (CType(Trim(dr("TUTAR").ToString()), Decimal) * -1) + CType(Trim(dr("lKalan").ToString()), Decimal)
                            '        pesinSatisDuzelt(Trim(dr("BELGENO").ToString()), lKapanan)
                            '    ElseIf CType(Trim(dr("lKalan").ToString()), Decimal) > 0 And CType(Trim(dr("TUTAR").ToString()), Decimal) > 0 Then
                            '        lKapanan = CType(Trim(dr("TUTAR").ToString()), Decimal) + CType(Trim(dr("lKalan").ToString()), Decimal)
                            '        pesinSatisDuzelt(Trim(dr("BELGENO").ToString()), lKapanan)
                            '    End If
                            If CType(Trim(dr("MIKTAR").ToString()), Decimal) <> 0 Then
                                pesinSatisDuzelt(Trim(dr("BELGENO").ToString()), Trim(dr("nKasaNo").ToString()), Trim(dr("TARIH").ToString()), CType(Trim(dr("lKapanan").ToString()), Decimal))
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show(Trim(dr("BELGENO").ToString()) & " Numaralý Belgede HATA")
                    End Try
                End If
                progressBar1.PerformStep()
            Next
            GridControl1.Enabled = True
            XtraMessageBox.Show(Sorgu_sDil("POS kayýt güncelleme iþlemi tamamlandý.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            progressBar1.Visible = False
            hatirlaKontrol(True)
        End If
    End Sub
    Private Sub pesinSatisDuzelt(ByVal lFisNo As String, ByVal nKasaNo As String, ByVal TARIH As String, ByVal lKapanan As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set dateformat dmy Update tbAlisVeris SET lMalBedeli = " & lKapanan & ", lNetTutar = " & lKapanan & ", sYaziIle = '" & ygeneltoplam(Math.Abs(lKapanan)).ToString() & "' WHERE (lFaturaNo = '" & lFisNo & "') AND (nKasaNo = '" & nKasaNo & "') AND (dteFaturaTarihi = '" & TARIH & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Business Smart")
        End Try
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
End Class
