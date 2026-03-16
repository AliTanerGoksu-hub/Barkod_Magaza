Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbSiparis_liste
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
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
    Friend WithEvents collSiparisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSiparisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSiparisiAlan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSiparisiVeren As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_sSiparisVeren2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSiparisVeren1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sSiparisAlan2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSiparisAlan1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sSiparisTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteSiparisTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteSiparisTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIsk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
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
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colbKilitli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbSiparis_liste))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_Onayverilen = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
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
        Me.sec_bYuklenenler = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bBekleyen = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sSiparisTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSiparisVeren2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sSiparisVeren1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSiparisAlan2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sSiparisAlan1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lFisNo2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lFisNo1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteSiparisTarihi2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteSiparisTarihi1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collSiparisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteSiparisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMiktari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSiparisiAlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSiparisiVeren = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIsk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbKilitli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSevkiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collYukleme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOnay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_Onayverilen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bYuklenenler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bBekleyen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSiparisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisVeren2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisVeren1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisAlan2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSiparisAlan1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSiparisTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1564, 223)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_Onayverilen)
        Me.GroupControl1.Controls.Add(Me.sec_bYuklenenler)
        Me.GroupControl1.Controls.Add(Me.sec_bBekleyen)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.sec_sSiparisTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisVeren2)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisVeren1)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisAlan2)
        Me.GroupControl1.Controls.Add(Me.txt_sSiparisAlan1)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_dteSiparisTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_dteSiparisTarihi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(154, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1066, 219)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_Onayverilen
        '
        Me.sec_Onayverilen.Location = New System.Drawing.Point(112, 195)
        Me.sec_Onayverilen.MenuManager = Me.BarManager1
        Me.sec_Onayverilen.Name = "sec_Onayverilen"
        Me.sec_Onayverilen.Properties.Caption = "Onay Verilenler"
        Me.sec_Onayverilen.Size = New System.Drawing.Size(145, 24)
        Me.sec_Onayverilen.TabIndex = 32
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Listele,F2"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ekle,Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Düzelt,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem3.Enabled = False
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Firma Kartı"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Firma Hareketleri"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "İletişim"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Yazdır,Ctrl+P"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Excel"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Text"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Mail"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1564, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 832)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1564, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 832)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1564, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 832)
        '
        'sec_bYuklenenler
        '
        Me.sec_bYuklenenler.Location = New System.Drawing.Point(399, 195)
        Me.sec_bYuklenenler.MenuManager = Me.BarManager1
        Me.sec_bYuklenenler.Name = "sec_bYuklenenler"
        Me.sec_bYuklenenler.Properties.Caption = "Yüklenenler"
        Me.sec_bYuklenenler.Size = New System.Drawing.Size(120, 24)
        Me.sec_bYuklenenler.TabIndex = 31
        '
        'sec_bBekleyen
        '
        Me.sec_bBekleyen.EditValue = True
        Me.sec_bBekleyen.Location = New System.Drawing.Point(273, 195)
        Me.sec_bBekleyen.MenuManager = Me.BarManager1
        Me.sec_bBekleyen.Name = "sec_bBekleyen"
        Me.sec_bBekleyen.Properties.Caption = "Bekleyen"
        Me.sec_bBekleyen.Size = New System.Drawing.Size(120, 24)
        Me.sec_bBekleyen.TabIndex = 30
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Location = New System.Drawing.Point(483, 29)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(120, 28)
        Me.LabelControl15.TabIndex = 29
        Me.LabelControl15.Text = "Eşittir"
        '
        'sec_sSiparisTipi
        '
        Me.sec_sSiparisTipi.Enabled = False
        Me.sec_sSiparisTipi.EnterMoveNextControl = True
        Me.sec_sSiparisTipi.Location = New System.Drawing.Point(114, 30)
        Me.sec_sSiparisTipi.Name = "sec_sSiparisTipi"
        Me.sec_sSiparisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSiparisTipi.Properties.DisplayMember = "sAciklama"
        Me.sec_sSiparisTipi.Properties.NullText = "[SiparisTipi]"
        Me.sec_sSiparisTipi.Properties.ValueMember = "nSiparisTipi"
        Me.sec_sSiparisTipi.Size = New System.Drawing.Size(366, 26)
        Me.sec_sSiparisTipi.TabIndex = 0
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.Location = New System.Drawing.Point(0, 29)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(104, 28)
        Me.LabelControl14.TabIndex = 28
        Me.LabelControl14.Text = "FişTipi:"
        '
        'txt_sSiparisVeren2
        '
        Me.txt_sSiparisVeren2.EditValue = "zzzzzzzzzzzzzzzzzzzz"
        Me.txt_sSiparisVeren2.EnterMoveNextControl = True
        Me.txt_sSiparisVeren2.Location = New System.Drawing.Point(320, 139)
        Me.txt_sSiparisVeren2.Name = "txt_sSiparisVeren2"
        Me.txt_sSiparisVeren2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisVeren2.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisVeren2.Properties.MaxLength = 15
        Me.txt_sSiparisVeren2.Size = New System.Drawing.Size(160, 28)
        Me.txt_sSiparisVeren2.TabIndex = 8
        '
        'txt_sSiparisVeren1
        '
        Me.txt_sSiparisVeren1.EnterMoveNextControl = True
        Me.txt_sSiparisVeren1.Location = New System.Drawing.Point(114, 139)
        Me.txt_sSiparisVeren1.Name = "txt_sSiparisVeren1"
        Me.txt_sSiparisVeren1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisVeren1.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisVeren1.Properties.MaxLength = 15
        Me.txt_sSiparisVeren1.Size = New System.Drawing.Size(160, 28)
        Me.txt_sSiparisVeren1.TabIndex = 7
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(483, 140)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(120, 26)
        Me.LabelControl11.TabIndex = 24
        Me.LabelControl11.Text = "Arasındaki"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(278, 141)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(39, 22)
        Me.LabelControl12.TabIndex = 23
        Me.LabelControl12.Text = "ve"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Location = New System.Drawing.Point(8, 139)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(104, 28)
        Me.LabelControl13.TabIndex = 22
        Me.LabelControl13.Text = "Siparis Veren:"
        '
        'txt_sSiparisAlan2
        '
        Me.txt_sSiparisAlan2.EditValue = "zzzzzzzzzzzzzzzzzzzz"
        Me.txt_sSiparisAlan2.EnterMoveNextControl = True
        Me.txt_sSiparisAlan2.Location = New System.Drawing.Point(320, 111)
        Me.txt_sSiparisAlan2.Name = "txt_sSiparisAlan2"
        Me.txt_sSiparisAlan2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisAlan2.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisAlan2.Properties.MaxLength = 15
        Me.txt_sSiparisAlan2.Size = New System.Drawing.Size(160, 28)
        Me.txt_sSiparisAlan2.TabIndex = 6
        '
        'txt_sSiparisAlan1
        '
        Me.txt_sSiparisAlan1.EnterMoveNextControl = True
        Me.txt_sSiparisAlan1.Location = New System.Drawing.Point(114, 111)
        Me.txt_sSiparisAlan1.Name = "txt_sSiparisAlan1"
        Me.txt_sSiparisAlan1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSiparisAlan1.Properties.Appearance.Options.UseFont = True
        Me.txt_sSiparisAlan1.Properties.MaxLength = 15
        Me.txt_sSiparisAlan1.Size = New System.Drawing.Size(160, 28)
        Me.txt_sSiparisAlan1.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(8, 166)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(104, 28)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Hesap:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(483, 113)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(120, 26)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Arasındaki"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(278, 114)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(39, 22)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "ve"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(8, 111)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl9.TabIndex = 14
        Me.LabelControl9.Text = "Siparis Alan:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(483, 84)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(120, 29)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasındaki"
        '
        'txt_lFisNo2
        '
        Me.txt_lFisNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lFisNo2.EnterMoveNextControl = True
        Me.txt_lFisNo2.Location = New System.Drawing.Point(320, 84)
        Me.txt_lFisNo2.Name = "txt_lFisNo2"
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lFisNo2.Size = New System.Drawing.Size(160, 26)
        Me.txt_lFisNo2.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(278, 84)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 29)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lFisNo1
        '
        Me.txt_lFisNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_lFisNo1.EnterMoveNextControl = True
        Me.txt_lFisNo1.Location = New System.Drawing.Point(114, 84)
        Me.txt_lFisNo1.Name = "txt_lFisNo1"
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lFisNo1.Size = New System.Drawing.Size(160, 26)
        Me.txt_lFisNo1.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(8, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "FişNo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(483, 57)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(120, 29)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Arasındaki"
        '
        'txt_dteSiparisTarihi2
        '
        Me.txt_dteSiparisTarihi2.EditValue = Nothing
        Me.txt_dteSiparisTarihi2.EnterMoveNextControl = True
        Me.txt_dteSiparisTarihi2.Location = New System.Drawing.Point(320, 57)
        Me.txt_dteSiparisTarihi2.Name = "txt_dteSiparisTarihi2"
        Me.txt_dteSiparisTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteSiparisTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteSiparisTarihi2.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteSiparisTarihi2.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(278, 57)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 29)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "ve"
        '
        'txt_dteSiparisTarihi1
        '
        Me.txt_dteSiparisTarihi1.EditValue = Nothing
        Me.txt_dteSiparisTarihi1.EnterMoveNextControl = True
        Me.txt_dteSiparisTarihi1.Location = New System.Drawing.Point(114, 57)
        Me.txt_dteSiparisTarihi1.Name = "txt_dteSiparisTarihi1"
        Me.txt_dteSiparisTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteSiparisTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteSiparisTarihi1.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteSiparisTarihi1.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(8, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tarih:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(320, 166)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adı"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(160, 26)
        Me.sec_konum.TabIndex = 10
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(614, 166)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(120, 28)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(483, 166)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(120, 26)
        Me.sec_kriter.TabIndex = 11
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(114, 166)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(208, 28)
        Me.txt_ara.TabIndex = 9
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(1220, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(342, 17)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(154, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 765)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1564, 67)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1427, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1307, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'Label3
        '
        Me.Label3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(2, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "*"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 223)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1564, 542)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1560, 538)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem13, Me.MenuItem14, Me.MenuItem18, Me.MenuItem15, Me.MenuItem23, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9, Me.MenuItem27, Me.MenuItem26})
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem21.Text = "Ara"
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Fişi Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "-"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25})
        Me.MenuItem23.Text = "Kilit"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Text = "Kilitle"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Text = "Kilit Kaldır"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartı"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 7
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "İletişim Bilgileri"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 8
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Firma Hareketleri"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 9
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 10
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 11
        Me.MenuItem2.Text = "Başlık Değiştir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 12
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 13
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 14
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 15
        Me.MenuItem22.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 16
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 17
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 18
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 19
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 20
        Me.MenuItem8.Text = "Satırları Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 21
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 22
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekranı Kapla"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 23
        Me.MenuItem27.Text = "Sipariş Onayla"
        Me.MenuItem27.Visible = False
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 24
        Me.MenuItem26.Text = "Sipariş Onayı Kaldır"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "lSiparisNo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "dteSiparisTarihi"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lMiktari"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lTutari"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAciklama1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sAciklama2"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sAciklama3"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sAciklama4"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAciklama5"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sFirmaKodu"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sFirmaAciklama"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lKdvTutari"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sSiparisiAlan"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sSiparisiVeren"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collSiparisNo, Me.coldteSiparisTarihi, Me.collMiktari, Me.collTutari, Me.colsAciklama1, Me.colsAciklama2, Me.colsAciklama3, Me.colsAciklama4, Me.colsAciklama5, Me.colsFirmaKodu, Me.colsFirmaAciklama, Me.collKdvTutari, Me.colsSiparisiAlan, Me.colsSiparisiVeren, Me.collIskontoTutari, Me.collNetTutar, Me.colnIsk, Me.colbKilitli, Me.collSevkiyat, Me.collKalan, Me.colnFirmaID, Me.collYukleme, Me.colOnay})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayıt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'collSiparisNo
        '
        Me.collSiparisNo.Caption = "Sipariş No"
        Me.collSiparisNo.FieldName = "lSiparisNo"
        Me.collSiparisNo.Name = "collSiparisNo"
        Me.collSiparisNo.Visible = True
        Me.collSiparisNo.VisibleIndex = 3
        Me.collSiparisNo.Width = 65
        '
        'coldteSiparisTarihi
        '
        Me.coldteSiparisTarihi.Caption = "Sipariş Tarihi"
        Me.coldteSiparisTarihi.FieldName = "dteSiparisTarihi"
        Me.coldteSiparisTarihi.Name = "coldteSiparisTarihi"
        Me.coldteSiparisTarihi.Visible = True
        Me.coldteSiparisTarihi.VisibleIndex = 2
        Me.coldteSiparisTarihi.Width = 65
        '
        'collMiktari
        '
        Me.collMiktari.Caption = "Miktar"
        Me.collMiktari.DisplayFormat.FormatString = "#,0.00##"
        Me.collMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktari.FieldName = "lMiktari"
        Me.collMiktari.Name = "collMiktari"
        Me.collMiktari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktari", "{0:#,0.00##}")})
        Me.collMiktari.Visible = True
        Me.collMiktari.VisibleIndex = 4
        Me.collMiktari.Width = 65
        '
        'collTutari
        '
        Me.collTutari.Caption = "Tutarı"
        Me.collTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutari.FieldName = "lTutari"
        Me.collTutari.Name = "collTutari"
        Me.collTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutari", "{0:#,0.00}")})
        Me.collTutari.Visible = True
        Me.collTutari.VisibleIndex = 5
        Me.collTutari.Width = 65
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Açıklama 1"
        Me.colsAciklama1.FieldName = "sAciklama1"
        Me.colsAciklama1.Name = "colsAciklama1"
        '
        'colsAciklama2
        '
        Me.colsAciklama2.Caption = "Açıklama 2"
        Me.colsAciklama2.FieldName = "sAciklama2"
        Me.colsAciklama2.Name = "colsAciklama2"
        '
        'colsAciklama3
        '
        Me.colsAciklama3.Caption = "Açıklama 3"
        Me.colsAciklama3.FieldName = "sAciklama3"
        Me.colsAciklama3.Name = "colsAciklama3"
        '
        'colsAciklama4
        '
        Me.colsAciklama4.Caption = "Açıklama 4"
        Me.colsAciklama4.FieldName = "sAciklama4"
        Me.colsAciklama4.Name = "colsAciklama4"
        '
        'colsAciklama5
        '
        Me.colsAciklama5.Caption = "Açıklama 5"
        Me.colsAciklama5.FieldName = "sAciklama5"
        Me.colsAciklama5.Name = "colsAciklama5"
        '
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Firma Kodu"
        Me.colsFirmaKodu.FieldName = "sFirmaKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        Me.colsFirmaKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaKodu", "{0} Kayıt")})
        Me.colsFirmaKodu.Visible = True
        Me.colsFirmaKodu.VisibleIndex = 0
        Me.colsFirmaKodu.Width = 48
        '
        'colsFirmaAciklama
        '
        Me.colsFirmaAciklama.Caption = "Firma Açıklama"
        Me.colsFirmaAciklama.FieldName = "sFirmaAciklama"
        Me.colsFirmaAciklama.Name = "colsFirmaAciklama"
        Me.colsFirmaAciklama.Visible = True
        Me.colsFirmaAciklama.VisibleIndex = 1
        Me.colsFirmaAciklama.Width = 65
        '
        'collKdvTutari
        '
        Me.collKdvTutari.Caption = "Kdv Tutarı"
        Me.collKdvTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvTutari.FieldName = "lKdvTutari"
        Me.collKdvTutari.Name = "collKdvTutari"
        Me.collKdvTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKdvTutari", "{0:#,0.00}")})
        Me.collKdvTutari.Visible = True
        Me.collKdvTutari.VisibleIndex = 6
        Me.collKdvTutari.Width = 65
        '
        'colsSiparisiAlan
        '
        Me.colsSiparisiAlan.Caption = "Siparişi Alan"
        Me.colsSiparisiAlan.FieldName = "sSiparisiAlan"
        Me.colsSiparisiAlan.Name = "colsSiparisiAlan"
        Me.colsSiparisiAlan.Visible = True
        Me.colsSiparisiAlan.VisibleIndex = 10
        Me.colsSiparisiAlan.Width = 65
        '
        'colsSiparisiVeren
        '
        Me.colsSiparisiVeren.Caption = "SiparisiVeren"
        Me.colsSiparisiVeren.FieldName = "sSiparisiVeren"
        Me.colsSiparisiVeren.Name = "colsSiparisiVeren"
        Me.colsSiparisiVeren.Visible = True
        Me.colsSiparisiVeren.VisibleIndex = 11
        Me.colsSiparisiVeren.Width = 122
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Iskonto Tutarı"
        Me.collIskontoTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskontoTutari", "{0:#,0.00}")})
        Me.collIskontoTutari.Visible = True
        Me.collIskontoTutari.VisibleIndex = 8
        Me.collIskontoTutari.Width = 61
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
        Me.collNetTutar.VisibleIndex = 9
        Me.collNetTutar.Width = 50
        '
        'colnIsk
        '
        Me.colnIsk.Caption = "Iskonto"
        Me.colnIsk.DisplayFormat.FormatString = "p"
        Me.colnIsk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnIsk.FieldName = "nIsk"
        Me.colnIsk.Name = "colnIsk"
        Me.colnIsk.Visible = True
        Me.colnIsk.VisibleIndex = 7
        Me.colnIsk.Width = 40
        '
        'colbKilitli
        '
        Me.colbKilitli.Caption = "Kilitli?"
        Me.colbKilitli.FieldName = "bKilitli"
        Me.colbKilitli.Name = "colbKilitli"
        Me.colbKilitli.Visible = True
        Me.colbKilitli.VisibleIndex = 13
        Me.colbKilitli.Width = 40
        '
        'collSevkiyat
        '
        Me.collSevkiyat.Caption = "Sevkiyat"
        Me.collSevkiyat.DisplayFormat.FormatString = "#,0.###"
        Me.collSevkiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkiyat.FieldName = "lSevkiyat"
        Me.collSevkiyat.Name = "collSevkiyat"
        Me.collSevkiyat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkiyat", "{0:#,0.###}")})
        '
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.###"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.###}")})
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "FirmaNo"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'collYukleme
        '
        Me.collYukleme.Caption = "Yukleme"
        Me.collYukleme.DisplayFormat.FormatString = "#,0.###"
        Me.collYukleme.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collYukleme.FieldName = "lYukleme"
        Me.collYukleme.Name = "collYukleme"
        Me.collYukleme.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lYukleme", "{0:#,0.###}")})
        '
        'colOnay
        '
        Me.colOnay.Caption = "Onay"
        Me.colOnay.FieldName = "bOnay"
        Me.colOnay.Name = "colOnay"
        Me.colOnay.Visible = True
        Me.colOnay.VisibleIndex = 12
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Sipariş Fişleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Sipariş Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_tbSiparis_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1564, 862)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbSiparis_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sipariş Fişleri..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_Onayverilen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bYuklenenler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bBekleyen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSiparisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisVeren2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisVeren1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisAlan2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSiparisAlan1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSiparisTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Dim count As String = ""
    Dim ds_tbSiparisTipi As DataSet
    Dim ds_satir_firma As DataSet
    Public islemstatus As Boolean = False
    Public nSiparisTipi As Integer
    Dim status As Boolean = False
    Public sKodu As String = ""
    Public bKapla As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
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
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(txt_dteSiparisTarihi1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(txt_dteSiparisTarihi2.EditValue.ToString, 10) & " Tarihleri Arasındaki " & vbCrLf
        kriter += " FisNo = " & txt_lFisNo1.Text & " ve " & txt_lFisNo1.Text & " Arasındaki "
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Siparis Yonetimi", "[Page # of Pages #]"}, New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub dataload_tbHareketTipi(ByVal nSiparisTipi As Integer)
        If bKapla = False Then
            ds_tbSiparisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nSiparisTipi,sAciklama FROM         tbSiparisTipi Where nSiparisTipi  ='" & nSiparisTipi & "'"))
            sec_sSiparisTipi.Properties.DataSource = ds_tbSiparisTipi.Tables(0)
            sec_sSiparisTipi.ItemIndex = 0
            sec_sSiparisTipi.Enabled = False
        ElseIf bKapla = True Then
            sec_sSiparisTipi.Enabled = True
            ds_tbSiparisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nSiparisTipi,sAciklama FROM         tbSiparisTipi Where nSiparisTipi  IN (1,2,3,4,5)"))
            sec_sSiparisTipi.Properties.DataSource = ds_tbSiparisTipi.Tables(0)
            sec_sSiparisTipi.ItemIndex = 0
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New Font("Tahoma", sayi, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New Font("Tahoma", sayi, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New Font("Tahoma", sayi, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte))
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal nSiparisTipi As String, ByVal dteSiparisTarihi1 As DateTime, ByVal dteSiparisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal sSiparisAlan1 As String, ByVal sSiparisAlan2 As String, ByVal sSiparisVeren1 As String, ByVal sSiparisVeren2 As String) As DataSet
        Dim kriter As String = ""
        Dim having As String = ""
        If CStr(Trim(ara.ToString)) <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND   (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adı" Then
                kriter += " AND  (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        End If
        If sec_bBekleyen.Checked = True Then
            'kriter += " tbSiparis.bKapandimi = 0"
            having += " HAVING SUM(tbSiparis.lMiktari) - ISNULL(SUM(tbSevkiyat.lSevkMiktari),0) > 0"
        End If
        If sec_bYuklenenler.Checked = True And sec_bBekleyen.Checked = True Then
            having += " AND ISNULL(SUM(tbYukleme.lYukleme), 0) > 0"
        ElseIf sec_bYuklenenler.Checked = True Then
            having = " HAVING ISNULL(SUM(tbYukleme.lYukleme), 0) > 0"
        End If
        If sec_Onayverilen.Checked = True Then
            kriter += "AND tbSiparis.bOnay = 1"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, SUM(tbSiparis.lMiktari) AS lMiktari, SUM(tbSiparis.lTutari) AS lTutari, SUM(tbSiparis.lTutari * (100 + tbSiparis.nKdvOrani) / 100) AS lNetTutar, SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) AS lIskontoTutari, SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) / SUM(tbSiparis.lIskontosuzTutari) AS nIsk, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, ISNULL(tbSiparisAciklamasi.bKilitli,0) bKilitli,tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, SUM(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)) AS lKdvTutari, SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) AS sSiparisiAlan, SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) AS sSiparisiVeren FROM tbStok INNER JOIN tbSiparis INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbSiparis.nStokID INNER JOIN tbKdv ON tbStok.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo WHERE (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & "  GROUP BY tbSiparis.dteSiparisTarihi, tbSiparis.lSiparisNo, tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5, tbSiparisAciklamasi.bKilitli,tbSiparis.sSiparisiAlan ORDER BY tbSiparis.dteSiparisTarihi, tbSiparis.lSiparisNo, tbFirma.sKodu")
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparisAciklamasi SELECT DISTINCT nSiparisTipi, lSiparisNo, nFirmaID, '' AS sAciklama1, '' AS sAciklama2, '' AS sAciklama3, '' AS sAciklama4, '' AS sAciklama5, 0 AS bKilitli, 0 as bListelendimi, '', '', '' FROM tbSiparis WHERE (nSiparisTipi = " & nSiparisTipi & ") AND (lSiparisNo NOT IN (SELECT lSiparisno FROM tbSiparisAciklamasi WHERE nSiparisTipi = " & nSiparisTipi & "))"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSiparis SET lFiyati = 0.01, lTutari = 0.01, lIskontosuzTutari = 0.01 WHERE     (lFiyati = 0)"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSiparis SET lFiyati = 0.01, lTutari = 0.01, lIskontosuzTutari = 0.01 WHERE     (lIskontosuzTutari = 0)"
        cmd.ExecuteNonQuery()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, SUM(tbSiparis.lMiktari) AS lMiktari, SUM(tbSiparis.lTutari) AS lTutari, SUM(tbSiparis.lTutari * (100 + tbSiparis.nKdvOrani) / 100) AS lNetTutar, SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) AS lIskontoTutari, SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) / SUM(tbSiparis.lIskontosuzTutari) AS nIsk, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, ISNULL(tbSiparisAciklamasi.bKilitli,0) bKilitli,tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, SUM(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)) AS lKdvTutari, SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) AS sSiparisiAlan, SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) AS sSiparisiVeren FROM tbStok INNER JOIN tbSiparis INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbSiparis.nStokID INNER JOIN tbKdv ON tbStok.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo WHERE (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & "  GROUP BY tbSiparis.dteSiparisTarihi, tbSiparis.lSiparisNo, tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5, tbSiparisAciklamasi.bKilitli,tbSiparis.sSiparisiAlan ORDER BY tbSiparis.dteSiparisTarihi, tbSiparis.lSiparisNo, tbFirma.sKodu")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbSiparis.lSiparisNo,tbSiparis.bOnay, tbSiparis.dteSiparisTarihi, SUM(tbSiparis.lMiktari) AS lMiktari, ISNULL(SUM(tbSevkiyat.lSevkMiktari),0) AS lSevkiyat, SUM(tbSiparis.lMiktari) - ISNULL(SUM(tbSevkiyat.lSevkMiktari),0) AS lKalan, ISNULL(SUM(tbYukleme.lYukleme),0) as lYukleme,SUM(tbSiparis.lTutari) AS lTutari, SUM(tbSiparis.lTutari * (100 + tbSiparis.nKdvOrani) / 100) AS lNetTutar, SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) AS lIskontoTutari, SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) / SUM(tbSiparis.lIskontosuzTutari) AS nIsk, ISNULL(tbSiparisAciklamasi.sAciklama1, '') AS sAciklama1, ISNULL(tbSiparisAciklamasi.sAciklama2, '') AS sAciklama2, ISNULL(tbSiparisAciklamasi.sAciklama3, '') AS sAciklama3, ISNULL(tbSiparisAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbSiparisAciklamasi.sAciklama5, '') AS sAciklama5, ISNULL(tbSiparisAciklamasi.bKilitli, 0) AS bKilitli, tbFirma.nFirmaID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, SUM(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)) AS lKdvTutari, SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) AS sSiparisiAlan, SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) AS sSiparisiVeren FROM tbStok INNER JOIN tbSiparis INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbSiparis.nStokID INNER JOIN tbKdv ON tbStok.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT ABS(SUM(lGirisMiktar1) - SUM(lCikisMiktar1)) AS lSevkMiktari , nSiparisID , nFirmaID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID , nFirmaID) tbSevkiyat ON tbSiparis.nFirmaID = tbSevkiyat.nFirmaID AND tbSiparis.nSiparisID = tbSevkiyat.nSiparisID LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo  LEFT OUTER JOIN (SELECT     TARIH AS dteSiparisTarihi, IZAHAT AS sFisTipi, FISNO AS lFisNo, FIRMANO,STOKNO,SUM(MIKTAR) AS lYukleme  FROM         ASTOKPAKETDETAY  GROUP BY TARIH, IZAHAT, FISNO,FIRMANO,STOKNO) tbYukleme ON tbSiparis.nFirmaID = tbYukleme.FIRMANO AND tbSiparis.dteSiparisTarihi = tbYukleme.dteSiparisTarihi and tbYukleme.lFisNo = tbSiparis.lSiparisNo and tbYukleme.sFisTipi ='AS' and tbYukleme.STOKNO = tbSiparis.nStokID WHERE (tbSiparis.lSiparisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ") AND (tbSiparis.dteSiparisTarihi BETWEEN '" & dteSiparisTarihi1 & "' AND '" & dteSiparisTarihi2 & "')  AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '" & sSiparisAlan1 & "' AND '" & sSiparisAlan2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '" & sSiparisVeren1 & "' AND '" & sSiparisVeren2 & "') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") " & kriter & " GROUP BY tbSiparis.dteSiparisTarihi,tbSiparis.bOnay, tbSiparis.lSiparisNo, tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5, tbSiparisAciklamasi.bKilitli, tbSiparis.sSiparisiAlan " & having & " ORDER BY tbSiparis.dteSiparisTarihi, tbSiparis.lSiparisNo, tbFirma.sKodu")
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal nSiparisTipi As String, ByVal dteSiparisTarihi1 As DateTime, ByVal dteSiparisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal sSiparisAlan1 As String, ByVal sSiparisAlan2 As String, ByVal sSiparisVeren1 As String, ByVal sSiparisVeren2 As String)
        DataSet1 = stok(ara, konum, ara_kriter, nSiparisTipi, dteSiparisTarihi1, dteSiparisTarihi2, lFisNo1, lFisNo2, sSiparisAlan1, sSiparisAlan2, sSiparisVeren1, sSiparisVeren2)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub satir_firma_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
            Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
            Label3.Text = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
            Label3.Refresh()
            dr1 = Nothing
        End If
    End Sub
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
        Return DS
    End Function
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
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sFirmaKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub tbSiparis(ByVal nSiparisTipi As String)
        Dim frm_firma As New frm_firma_liste
        frm_firma.firmano = firmano
        frm_firma.donemno = donemno
        frm_firma.connection = connection
        frm_firma.islemstatus = True
        frm_firma.kullanici = kullanici
        If frm_firma.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm_firma.GridView1.GetDataRow(frm_firma.GridView1.FocusedRowHandle)
            Dim frm As New frm_tbSiparis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nFirmaID = dr1("nFirmaID")
            frm.nSiparisTipi = nSiparisTipi
            frm.dteSiparisTarihi = Today
            frm.islemstatus = False
            frm.yeni = True
            'frm.MdiParent = Me
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
            'frm.Close()
            'frm.Dispose()
            'frm = Nothing
        End If
    End Sub
    Private Sub analiz_fis()

        If GridView1.RowCount > 0 Then
            Dim frm1 = "frm_tbSiapris_Onay"
            If yetki_kontrol(kullanici, frm1) = False Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

                Dim lSiparisNo As Decimal = Convert.ToDecimal(dr("lSiparisNo"))
                Dim nFirmaID As Integer = Convert.ToInt32(dr("nFirmaID"))

                ' Siparis tipine gore onay kontrolu yap (Alinan veya Verilen)
                Dim sParamTablo As String = If(nSiparisTipi = 1, "tbParamAlSiparis", "tbParamVerSiparis")
                Dim dtParam As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM " & sParamTablo)
                Dim bOnayVar As Boolean = False
                If dtParam.Rows.Count > 0 Then
                    bOnayVar = Convert.ToBoolean(dtParam.Rows(0)("bOnayVar"))
                End If

                ' Eğer onay kontrolü isteniyorsa, bOnay'a bak
                If bOnayVar Then
                    Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                    If dtOnay.Rows.Count = 0 OrElse Not Convert.ToBoolean(dtOnay.Rows(0)("bOnay")) Then
                        Dim sSiparisTipiAdi As String = If(nSiparisTipi = 1, "Alınan Sipariş", "Verilen Sipariş")
                        MessageBox.Show(sSiparisTipiAdi & " için onay verilmemiştir. Onaylanmamış sipariş işlenemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
            Else
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                ' Fişi aç
                Dim frm As New frm_tbSiparis
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.dteSiparisTarihi = dr("dteSiparisTarihi")
                frm.lSiparisNo = dr("lSiparisNo")
                frm.nFirmaID = dr("nFirmaID")
                frm.sSiparisiAlan = dr("sSiparisiAlan")
                frm.sSiparisiVeren = dr("sSiparisiVeren")
                frm.nSiparisTipi = sec_sSiparisTipi.EditValue
                frm.kullanici = kullanici
                frm.islemstatus = True

                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If

                frm.Close()
                frm.Dispose()
                frm = Nothing

                ' Satırı geri yükle
                Dim satir As Int64 = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub

    Private Function SQLCalistir(sql As String) As DataTable
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        con.ConnectionString = connection
        cmd.CommandText = sql
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Dim dt As New DataTable()
        Try
            con.Open()
            adapter.Fill(dt)
        Catch ex As Exception
            LogYaz("SQLCalistir", ex.ToString())
            MessageBox.Show("SQL çalıştırma hatası: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return dt
    End Function
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
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
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Dim satir = GridView1.FocusedRowHandle
        status = False
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sSiparisTipi.EditValue, txt_dteSiparisTarihi1.EditValue, txt_dteSiparisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_sSiparisAlan1.EditValue, txt_sSiparisAlan2.EditValue, txt_sSiparisVeren1.EditValue, txt_sSiparisVeren2.EditValue)
        status = True
        GridView1.FocusedRowHandle = satir
        satir = Nothing
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
    End Sub
    Private Sub firma_sec()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_ara.Text = dr1("sKodu")
            dr1 = Nothing
        Else
            'Me.Close()
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        analiz_fis()
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("sAciklama1").ToString + " " + dr("sAciklama2").ToString + " " + dr("sAciklama3").ToString + " " + dr("sAciklama4").ToString + " " + dr("sAciklama5").ToString
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_Firma_karti()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            analiz_fis()
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_fis()
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_tbHareketTipi(nSiparisTipi)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        If sKodu = "" Then
            txt_dteSiparisTarihi1.EditValue = dteSistemTarihi
            txt_dteSiparisTarihi2.EditValue = dteSistemTarihi
            txt_ara.EditValue = ""
        Else
        End If
        ara()
        'txt_dteFisTarihi1.Focus()
        'txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteSiparisTarihi1.Focus()
        txt_dteSiparisTarihi1.Select()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If status = True Then
            Try
                satir_firma_info()
            Catch ex As Exception
                Label3.Text = "*"
            End Try
        End If
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If MenuItem22.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem22.Checked = True
        ElseIf MenuItem22.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem22.Checked = False
        End If
    End Sub
    Private Sub sec_sSiparisTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sSiparisTipi.EditValueChanged
        If sec_sSiparisTipi.EditValue = 3 Then
            colsSiparisiAlan.Caption = "Başlangıç"
            colsSiparisiVeren.Caption = "Bitiş"
            collKdvTutari.Caption = "Kar Tutarı"
        ElseIf sec_sSiparisTipi.EditValue = 4 Then
            colsSiparisiAlan.Caption = "TeklifiAlan"
            colsSiparisiVeren.Caption = "TeklifiVeren"
            collKdvTutari.Caption = "Kdv Tutarı"
        Else
            colsSiparisiAlan.Caption = "Siparişi Alan"
            colsSiparisiVeren.Caption = "Siparişi Veren"
            collKdvTutari.Caption = "Kdv Tutarı"
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        tbSiparis(sec_sSiparisTipi.EditValue)
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_fis()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_pdf()
    End Sub
    Private Sub satirlar_kilit(ByVal bKilitli As Byte)
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                tbSiparisAciklamasi_Kilit(sec_sSiparisTipi.EditValue, dr("lSiparisNo"), dr("nFirmaID"), bKilitli)
            Next
        End If
        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        ara()
    End Sub
    Private Sub tbSiparisAciklamasi_Kilit(ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal bKilitli As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbSiparisAciklamasi set bKilitli = " & bKilitli & " where nSiparisTipi =" & nSiparisTipi & " and lSiparisNo =" & lSiparisNo & " and nFirmaID =" & nFirmaID & " ")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Fis Kayıtlarını Kilitlemek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(1)
            End If
        End If
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Bordro Kayıtlarının Kilitlerini Kaldırmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(0)
            End If
        End If
    End Sub
    Friend WithEvents sec_bBekleyen As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents collSevkiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bYuklenenler As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_Onayverilen As DevExpress.XtraEditors.CheckEdit
    Private Sub sec_bBekleyen_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bBekleyen.CheckStateChanged
        ara()
    End Sub
    Private Sub sec_bYuklenenler_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bYuklenenler.CheckStateChanged
        ara()
    End Sub
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collYukleme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        ara()
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Space Then
            firma_sec()
        End If
    End Sub
    Private Sub sec_Onayverilen_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_Onayverilen.CheckStateChanged
        ara()
    End Sub

    Friend WithEvents colOnay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem26 As MenuItem
    Friend WithEvents MenuItem27 As MenuItem

    Private Sub MenuItem26_Click(sender As Object, e As EventArgs) Handles MenuItem26.Click
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim s As String = ""
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing OrElse arr.Length = 0 Then
            MessageBox.Show("Lutfen bir siparis secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Array.Sort(arr)
        Dim basarili As Integer = 0
        Dim basarisiz As Integer = 0

        For Each i In arr
            Try
                dr = GridView1.GetDataRow(i)
                If dr Is Nothing Then Continue For

                Dim lSiparisNo As Integer = 0
                Dim nFirmaID As Integer = 0
                Dim dteSiparisTarihi As Date = Nothing

                ' Grid'den lSiparisNo al
                If dr.Table.Columns.Contains("lSiparisNo") AndAlso Not IsDBNull(dr("lSiparisNo")) Then
                    lSiparisNo = Convert.ToInt32(dr("lSiparisNo"))
                End If

                ' Grid'den nFirmaID al
                If dr.Table.Columns.Contains("nFirmaID") AndAlso Not IsDBNull(dr("nFirmaID")) Then
                    nFirmaID = Convert.ToInt32(dr("nFirmaID"))
                End If

                ' Grid'den tarih al
                If dr.Table.Columns.Contains("dteSiparisTarihi") AndAlso Not IsDBNull(dr("dteSiparisTarihi")) Then
                    dteSiparisTarihi = Convert.ToDateTime(dr("dteSiparisTarihi"))
                End If

                If lSiparisNo = 0 Then
                    basarisiz += 1
                    Continue For
                End If

                ' Siparis tipi formdan al
                Dim nSiparisTipiLocal As Integer = 0
                Try
                    nSiparisTipiLocal = Convert.ToInt32(sec_sSiparisTipi.EditValue)
                Catch
                End Try

                ' Sorguyu olustur - nFirmaID 0 ise sadece lSiparisNo ve tarih ile ara
                Dim sqlQuery As String = "SELECT TOP 1 nSiparisID, nFirmaID FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo

                ' nFirmaID varsa ekle
                If nFirmaID > 0 Then
                    sqlQuery &= " AND nFirmaID = " & nFirmaID
                End If

                ' Tarih varsa ekle
                If dteSiparisTarihi <> Nothing AndAlso dteSiparisTarihi > #1/1/1900# Then
                    sqlQuery &= " AND CONVERT(DATE, dteSiparisTarihi) = '" & dteSiparisTarihi.ToString("yyyy-MM-dd") & "'"
                End If

                ' Siparis tipi varsa ekle
                If nSiparisTipiLocal > 0 Then
                    sqlQuery &= " AND nSiparisTipi = " & nSiparisTipiLocal
                End If

                sqlQuery &= " ORDER BY nSiparisID DESC"

                Dim dtSiparis As DataTable = SQLCalistir(sqlQuery)

                If dtSiparis.Rows.Count > 0 Then
                    Dim nSiparisID As Integer = Convert.ToInt32(dtSiparis.Rows(0)("nSiparisID"))
                    Dim nFirmaIDFromDB As Integer = Convert.ToInt32(dtSiparis.Rows(0)("nFirmaID"))
                    SiparisOnay_Kaldir(nSiparisTipiLocal, lSiparisNo, nSiparisID, nFirmaIDFromDB)
                    basarili += 1
                Else
                    MessageBox.Show("Siparis No: " & lSiparisNo & " icin kayit bulunamadi." & vbCrLf & "nFirmaID: " & nFirmaID & ", Tarih: " & dteSiparisTarihi.ToString("dd.MM.yyyy"), "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    basarisiz += 1
                End If
            Catch ex As Exception
                basarisiz += 1
                Continue For
            End Try
        Next

        If basarili > 0 Then
            MessageBox.Show(basarili & " adet siparisin sevk onayi kaldirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ara()
    End Sub
    Private Sub SiparisOnay_Kaldir(ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Integer, ByVal nSiparisID As Integer, ByVal nFirmaID As Integer)
        Try
            ' ===== YETKI KONTROLU: frm_tbSiparis_Onay =====
            If yetki_kontrol(kullanici, "frm_tbSiparis_Onay") = False Then
                MessageBox.Show("Siparis onayi kaldirma yetkiniz bulunmamaktadir." & vbCrLf & vbCrLf & _
                    "Gerekli Yetki: frm_tbSiparis_Onay", "Yetki Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' 1. Zaten onayli mi kontrol et
            Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay, ISNULL(bKilitli, 0) AS bKilitli FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            
            If dtOnay.Rows.Count = 0 Then
                MessageBox.Show("Siparis bulunamadi: " & lSiparisNo, "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            Dim bOnayDurumu As Boolean = Convert.ToBoolean(dtOnay.Rows(0)("bOnay"))
            
            If Not bOnayDurumu Then
                ' Siparis zaten onaysiz, sadece kilidi kaldir (eger varsa)
                SQLCalistir("UPDATE tbSiparis SET bKilitli = 0, bOnaylandi = 0, nOnaylayanID = NULL, dteOnayTarihi = NULL WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                SQLCalistir("UPDATE tbSiparisAciklamasi SET bKilitli = 0 WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                Exit Sub
            End If
            
            ' 2. Parametre kontrolu (Uretim entegrasyonu acik mi?)
            Dim ReceteKontrolEt As Boolean = False
            Try
                Dim dtParam As DataTable = SQLCalistir("SELECT ISNULL(bReceteVarmi, 0) FROM tbParamAlSiparis")
                If dtParam.Rows.Count > 0 Then
                    ReceteKontrolEt = Convert.ToBoolean(dtParam.Rows(0)(0))
                End If
            Catch
                ReceteKontrolEt = False
            End Try
            
            If ReceteKontrolEt Then
                ' 3. Siparis kalemleri
                Dim dtKalem As DataTable = SQLCalistir("SELECT nStokID, lMiktari, sDepo FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                For Each dr As DataRow In dtKalem.Rows
                    Dim nStokID As Integer = Convert.ToInt32(dr("nStokID"))
                    
                    ' Uretim kayitlarini sil
                    Dim evrakNo As Integer = YeniEvrakNoUret()
                    SQLCalistir("DELETE FROM TBLUREURETIM WHERE EVRAKNO = " & evrakNo & " AND STOKNO = " & nStokID)
                    
                    ' Recete hammaddelerini sil
                    Dim dtRecete As DataTable = SQLCalistir("SELECT * FROM TBLURERECETE WHERE STOKNO = " & nStokID)
                    For Each row As DataRow In dtRecete.Rows
                        Dim girdiStokID As Integer = Convert.ToInt32(row("DETAY"))
                        SQLCalistir("DELETE FROM TBLUREURETIMLIST WHERE EVRAKNO = " & evrakNo & " AND STOKNO = " & girdiStokID)
                    Next
                    
                    SQLCalistir("DELETE FROM TBLUREURETIMCIKTI WHERE EVRAKNO = " & evrakNo & " AND STOKNO = " & nStokID)
                Next
            End If
            
            ' 4. Siparis onayini ve kilidini kaldir
            SQLCalistir("UPDATE tbSiparis SET bOnay = 0, bOnaylandi = 0, bKilitli = 0, nOnaylayanID = NULL, dteOnayTarihi = NULL WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            SQLCalistir("UPDATE tbSiparisAciklamasi SET bKilitli = 0 WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            
            ' AUDIT LOG
            Try
                LogSiparis("GUNCELLE", nSiparisID, lSiparisNo.ToString(), "Sevk onayi kaldirildi (Liste) - Siparis No: " & lSiparisNo & ", Firma: " & nFirmaID, "True", "False")
            Catch
            End Try
            
        Catch ex As Exception
            MessageBox.Show("Onay kaldirma hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function YeniEvrakNoUret() As Integer
        Dim dt As DataTable = SQLCalistir("SELECT ISNULL(MAX(EVRAKNO), 100) AS SonEvrakNo FROM TBLUREURETIM")
        Return Convert.ToInt32(dt.Rows(0)("SonEvrakNo")) + 1
    End Function
    
    ''' <summary>
    ''' Siparis Onayla - Liste formundan calisir
    ''' </summary>
    Private Sub MenuItem27_Click(sender As Object, e As EventArgs) Handles MenuItem27.Click
        ' Liste formundan siparis onaylama devre disi birakildi
        ' Siparis icerigi gorulmeden onay verilmesi sakincali oldugu icin
        ' kullanici ana siparis formuna yonlendirilir
        MessageBox.Show("Siparis onaylama islemi liste formundan yapilamaz." & vbCrLf & vbCrLf & _
            "Siparis onaylamak icin:" & vbCrLf & _
            "1. Siparisi cift tiklayarak acin" & vbCrLf & _
            "2. Siparis icerigini kontrol edin" & vbCrLf & _
            "3. Siparis formundan onay verin" & vbCrLf & vbCrLf & _
            "NOT: Siparis icerigini gormeden onay vermek sakincalidir.", _
            "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    
    ''' <summary>
    ''' Siparis onaylama fonksiyonu - Liste formundan
    ''' </summary>
    ' SiparisOnayla_Liste fonksiyonu kaldirildi
    ' Siparis onaylama islemi artik sadece ana siparis formundan (frm_tbSiparis) yapilabilir
    ' Sebep: Siparis icerigi gorulmeden onay verilmesi sakincalidir
    
End Class
