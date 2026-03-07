Imports System.IO
Imports Microsoft.Win32
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Public Class frm_stok_hareketleri_genel
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
    Friend WithEvents Panel_Baslik As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara_stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_satismi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colnGiris As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisIade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikisIade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_magaza As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_lFiyat1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFiyat2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents colnGirisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisIadeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikisIadeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKalanTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bSayimHaric As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_hareketleri_genel))
        Me.Panel_Baslik = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_bSayimHaric = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_lFiyat2 = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_lFiyat1 = New DevExpress.XtraEditors.CalcEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara_stok = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_satismi = New DevExpress.XtraEditors.CheckEdit()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGiris = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisIade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikisIade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisIadeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikisTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikisIadeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKalanTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.DataSet2 = New System.Data.DataSet()
        Me.ds_magaza = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.Panel_Baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Baslik.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_bSayimHaric.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFiyat2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFiyat1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satismi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Baslik
        '
        Me.Panel_Baslik.Controls.Add(Me.GroupControl1)
        Me.Panel_Baslik.Controls.Add(Me.Label1)
        Me.Panel_Baslik.Controls.Add(Me.PictureBox1)
        Me.Panel_Baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Baslik.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Baslik.Name = "Panel_Baslik"
        Me.Panel_Baslik.Size = New System.Drawing.Size(824, 117)
        Me.Panel_Baslik.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_bSayimHaric)
        Me.GroupControl1.Controls.Add(Me.txt_lFiyat2)
        Me.GroupControl1.Controls.Add(Me.txt_lFiyat1)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.sec_konum_stok)
        Me.GroupControl1.Controls.Add(Me.sec_kriter_stok)
        Me.GroupControl1.Controls.Add(Me.txt_ara_stok)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.sec_satismi)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(726, 113)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "Ara"
        '
        'sec_bSayimHaric
        '
        Me.sec_bSayimHaric.EditValue = True
        Me.sec_bSayimHaric.Enabled = False
        Me.sec_bSayimHaric.Location = New System.Drawing.Point(351, 67)
        Me.sec_bSayimHaric.Name = "sec_bSayimHaric"
        Me.sec_bSayimHaric.Properties.Caption = "Sayým Hariç"
        Me.sec_bSayimHaric.Size = New System.Drawing.Size(75, 19)
        Me.sec_bSayimHaric.TabIndex = 49
        '
        'txt_lFiyat2
        '
        Me.txt_lFiyat2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lFiyat2.EnterMoveNextControl = True
        Me.txt_lFiyat2.Location = New System.Drawing.Point(192, 89)
        Me.txt_lFiyat2.Name = "txt_lFiyat2"
        Me.txt_lFiyat2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lFiyat2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lFiyat2.Size = New System.Drawing.Size(109, 20)
        Me.txt_lFiyat2.TabIndex = 8
        '
        'txt_lFiyat1
        '
        Me.txt_lFiyat1.EnterMoveNextControl = True
        Me.txt_lFiyat1.Location = New System.Drawing.Point(64, 89)
        Me.txt_lFiyat1.Name = "txt_lFiyat1"
        Me.txt_lFiyat1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lFiyat1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lFiyat1.Size = New System.Drawing.Size(112, 20)
        Me.txt_lFiyat1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(10, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "BrutFiyat:"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(64, 68)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(112, 20)
        Me.sec_depo.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(344, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "arasýndaki"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(192, 23)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(152, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'sec_konum_stok
        '
        Me.sec_konum_stok.EditValue = "Kod"
        Me.sec_konum_stok.EnterMoveNextControl = True
        Me.sec_konum_stok.Location = New System.Drawing.Point(192, 45)
        Me.sec_konum_stok.Name = "sec_konum_stok"
        Me.sec_konum_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum_stok.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5", "Sýnýf6", "Sýnýf7", "Sýnýf8"})
        Me.sec_konum_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum_stok.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum_stok.TabIndex = 3
        '
        'sec_kriter_stok
        '
        Me.sec_kriter_stok.EditValue = "Baþlar"
        Me.sec_kriter_stok.EnterMoveNextControl = True
        Me.sec_kriter_stok.Location = New System.Drawing.Point(280, 45)
        Me.sec_kriter_stok.Name = "sec_kriter_stok"
        Me.sec_kriter_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_stok.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Ýçermez", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter_stok.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter_stok.TabIndex = 4
        '
        'txt_ara_stok
        '
        Me.txt_ara_stok.EnterMoveNextControl = True
        Me.txt_ara_stok.Location = New System.Drawing.Point(64, 45)
        Me.txt_ara_stok.Name = "txt_ara_stok"
        Me.txt_ara_stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara_stok.Properties.Appearance.Options.UseFont = True
        Me.txt_ara_stok.Properties.MaxLength = 15
        Me.txt_ara_stok.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara_stok.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(17, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Depolar:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(177, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(64, 23)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(113, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(302, 89)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(64, 20)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "R/B/K"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(192, 66)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Model", "R/B/K", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5", "Sýnýf6", "Sýnýf7", "Sýnýf8", "Sýnýf9", "Sýnýf10"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(83, 20)
        Me.sec_kriter.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(177, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "ve"
        '
        'sec_satismi
        '
        Me.sec_satismi.EditValue = True
        Me.sec_satismi.Enabled = False
        Me.sec_satismi.Location = New System.Drawing.Point(279, 67)
        Me.sec_satismi.Name = "sec_satismi"
        Me.sec_satismi.Properties.Caption = "Satýlanlar"
        Me.sec_satismi.Size = New System.Drawing.Size(68, 19)
        Me.sec_satismi.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(30, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Stoklar:"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(248, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(6, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "*"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 117)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 242)
        Me.PanelControl3.TabIndex = 0
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(168, 6)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 3
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(232, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colSEC
        '
        Me.colSEC.Caption = "Seçim"
        Me.colSEC.FieldName = "SEC"
        Me.colSEC.Name = "colSEC"
        Me.colSEC.Visible = True
        Me.colSEC.VisibleIndex = 0
        Me.colSEC.Width = 48
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kod"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.OptionsColumn.AllowFocus = False
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 1
        Me.colKOD.Width = 52
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.OptionsColumn.AllowFocus = False
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        Me.colACIKLAMA.Width = 128
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(820, 238)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem21, Me.MenuItem16, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem17, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 3
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem21.Text = "Envanter"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem16.Text = "Ekstre"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 5
        Me.MenuItem20.Text = "-"
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
        'MenuItem17
        '
        Me.MenuItem17.Index = 11
        Me.MenuItem17.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 12
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 13
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 14
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 15
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 16
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 17
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 18
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nAlisverisID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "nMusteriID"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sMusteriAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dteTarih"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "fisTipi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lNo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "nStokID"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sKodu"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sStokAciklama"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Miktar"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Fiyat"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Iskonto"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lNetTutar"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sOdemeKodu"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sFiyatTipi"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nGirisCikis"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sMagaza"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sRenk"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsKodu, Me.colsStokAciklama, Me.colnGiris, Me.colnGirisIade, Me.colnCikis, Me.colnCikisIade, Me.colnKalan, Me.collMevcut, Me.colnGirisTutar, Me.colnGirisIadeTutar, Me.colnCikisTutar, Me.colnCikisIadeTutar, Me.colnKalanTutar})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Me.colsKodu, "{0} Kayýt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kod"
        Me.colsKodu.FieldName = "sModel"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sModel", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 153
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Açýklama"
        Me.colsStokAciklama.FieldName = "sAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 1
        Me.colsStokAciklama.Width = 287
        '
        'colnGiris
        '
        Me.colnGiris.Caption = "Giriþ"
        Me.colnGiris.DisplayFormat.FormatString = "#,#.###"
        Me.colnGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGiris.FieldName = "nGiris"
        Me.colnGiris.Name = "colnGiris"
        Me.colnGiris.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nGiris", "{0:#,0.00##}")})
        Me.colnGiris.Visible = True
        Me.colnGiris.VisibleIndex = 2
        Me.colnGiris.Width = 47
        '
        'colnGirisIade
        '
        Me.colnGirisIade.Caption = "Giriþ Ýadesi"
        Me.colnGirisIade.DisplayFormat.FormatString = "#,#.###"
        Me.colnGirisIade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGirisIade.FieldName = "nGirisIade"
        Me.colnGirisIade.Name = "colnGirisIade"
        Me.colnGirisIade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nGirisIade", "{0:#,0.00##}")})
        Me.colnGirisIade.Visible = True
        Me.colnGirisIade.VisibleIndex = 4
        Me.colnGirisIade.Width = 53
        '
        'colnCikis
        '
        Me.colnCikis.Caption = "Çýkýþ"
        Me.colnCikis.DisplayFormat.FormatString = "#,#.###"
        Me.colnCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnCikis.FieldName = "nCikis"
        Me.colnCikis.Name = "colnCikis"
        Me.colnCikis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nCikis", "{0:#,0.00##}")})
        Me.colnCikis.Visible = True
        Me.colnCikis.VisibleIndex = 6
        Me.colnCikis.Width = 53
        '
        'colnCikisIade
        '
        Me.colnCikisIade.Caption = "Çýkýþ Ýadesi"
        Me.colnCikisIade.DisplayFormat.FormatString = "#,#.###"
        Me.colnCikisIade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnCikisIade.FieldName = "nCikisIade"
        Me.colnCikisIade.Name = "colnCikisIade"
        Me.colnCikisIade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nCikisIade", "{0:#,0.00##}")})
        Me.colnCikisIade.Visible = True
        Me.colnCikisIade.VisibleIndex = 8
        Me.colnCikisIade.Width = 63
        '
        'colnKalan
        '
        Me.colnKalan.Caption = "Kalan"
        Me.colnKalan.DisplayFormat.FormatString = "#,#.###"
        Me.colnKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKalan.FieldName = "nKalan"
        Me.colnKalan.Name = "colnKalan"
        Me.colnKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nKalan", "{0:#,0.00##}")})
        Me.colnKalan.Visible = True
        Me.colnKalan.VisibleIndex = 10
        Me.colnKalan.Width = 49
        '
        'collMevcut
        '
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,#.###"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        '
        'colnGirisTutar
        '
        Me.colnGirisTutar.Caption = "Giriþ Tutarý"
        Me.colnGirisTutar.DisplayFormat.FormatString = "#,#.###"
        Me.colnGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGirisTutar.FieldName = "nGirisTutar"
        Me.colnGirisTutar.Name = "colnGirisTutar"
        Me.colnGirisTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nGirisTutar", "{0:#,0.00}")})
        Me.colnGirisTutar.Visible = True
        Me.colnGirisTutar.VisibleIndex = 3
        Me.colnGirisTutar.Width = 66
        '
        'colnGirisIadeTutar
        '
        Me.colnGirisIadeTutar.Caption = "Giriþ Ýadesi Tutarý"
        Me.colnGirisIadeTutar.DisplayFormat.FormatString = "#,#.###"
        Me.colnGirisIadeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGirisIadeTutar.FieldName = "nGirisIadeTutar"
        Me.colnGirisIadeTutar.Name = "colnGirisIadeTutar"
        Me.colnGirisIadeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nGirisIadeTutar", "{0:#,0.00}")})
        Me.colnGirisIadeTutar.Visible = True
        Me.colnGirisIadeTutar.VisibleIndex = 5
        Me.colnGirisIadeTutar.Width = 87
        '
        'colnCikisTutar
        '
        Me.colnCikisTutar.Caption = "Çýkýþ Tutarý"
        Me.colnCikisTutar.DisplayFormat.FormatString = "#,#.###"
        Me.colnCikisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnCikisTutar.FieldName = "nCikisTutar"
        Me.colnCikisTutar.Name = "colnCikisTutar"
        Me.colnCikisTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nCikisTutar", "{0:#,0.00}")})
        Me.colnCikisTutar.Visible = True
        Me.colnCikisTutar.VisibleIndex = 7
        Me.colnCikisTutar.Width = 63
        '
        'colnCikisIadeTutar
        '
        Me.colnCikisIadeTutar.Caption = "Çýkýþ Ýadesi Tutarý"
        Me.colnCikisIadeTutar.DisplayFormat.FormatString = "#,#.###"
        Me.colnCikisIadeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnCikisIadeTutar.FieldName = "nCikisIadeTutar"
        Me.colnCikisIadeTutar.Name = "colnCikisIadeTutar"
        Me.colnCikisIadeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nCikisIadeTutar", "{0:#,0.00}")})
        Me.colnCikisIadeTutar.Visible = True
        Me.colnCikisIadeTutar.VisibleIndex = 9
        Me.colnCikisIadeTutar.Width = 88
        '
        'colnKalanTutar
        '
        Me.colnKalanTutar.Caption = "Kalan Tutar"
        Me.colnKalanTutar.DisplayFormat.FormatString = "#,#.###"
        Me.colnKalanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKalanTutar.FieldName = "nKalanTutar"
        Me.colnKalanTutar.Name = "colnKalanTutar"
        Me.colnKalanTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nKalanTutar", "{0:#,0.00}")})
        Me.colnKalanTutar.Visible = True
        Me.colnKalanTutar.VisibleIndex = 11
        Me.colnKalanTutar.Width = 96
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ValueMember = "sRenk"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Ödemesi Geciken Müþteri Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        '
        'ds_magaza
        '
        Me.ds_magaza.DataSetName = "NewDataSet"
        Me.ds_magaza.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_magaza.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn49, Me.DataColumn50, Me.DataColumn51})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "SEC"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "KOD"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "ACIKLAMA"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Stok Kartý,F4"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Envanter,F6"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Ekstre,F7"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Txt"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Mail"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'frm_stok_hareketleri_genel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.Panel_Baslik)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_hareketleri_genel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genel Stok Hareketleri"
        CType(Me.Panel_Baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Baslik.ResumeLayout(False)
        Me.Panel_Baslik.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_bSayimHaric.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFiyat2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFiyat1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satismi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public islemstatus As Boolean = False
    Public firmatipi As Boolean = False
    Public bDegerli As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_satir_stok As DataSet
    Dim satir_indx As String = ""
    Dim yuklendi As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi '"31/12/" + Today.Year.ToString
        DateEdit1.Focus()
        DateEdit1.Select()
        'If txt_ara.EditValue <> "" Then
        'Else
        '    txt_ara.EditValue = ""
        'End If
        txt_ara_stok.EditValue = ""
        dataload_renk()
        dataload_depo()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_renk()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
    End Sub
    Private Sub dataload_depo()
        DataSet2 = sorgu(sorgu_query("SELECT     sDepo AS DEPOKODU, sAciklama AS DEPOADI,0 AS SEC  FROM         tbDepo ORDER BY sDepo"))
        dataload_depolar()
    End Sub
    Private Sub dataload_depolar()
        Dim dr As DataRow
        For Each dr In DataSet2.Tables(0).Rows
            'CheckedListBoxControl1.Items.Add(dr("DEPOKODU"), CheckState.Unchecked)
        Next
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Stok Genel Hareket Raporu" & vbCrLf
        'kriter += "Limit = " & txt_altlimit.EditValue & "-" & txt_ustlimit.EditValue
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Ýçermez" Then
            sorgu_kriter = " NOT LIKE '%" & deger & "%' "
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal depo As String, ByVal lFiyat1 As Decimal, ByVal lFiyat2 As Decimal) As DataSet
        Dim kriter As String = ""
        Dim kriter2 = ""
        Dim kriter3 = ""
        Dim kriter4 = ""
        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
                'ElseIf konum_stok = "Soyadý" Then
                '   kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf1" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf2" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf3" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf4" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf5" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf6" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif6.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf7" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif7.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf8" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif8.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"

            ElseIf sec_konum_stok.Text = "Barkod" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID  FROM         tbStok INNER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            End If
        End If
        If sStokSinirla <> "" Then
            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
        End If
        'If sec_kriter.Text <> "" Then
        '    If sec_kriter.Text = "[Tümü]" Then
        '    ElseIf sec_kriter.Text = "Artýlar" Then
        '        kriter2 = " HAVING (SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) > 0) "
        '    ElseIf sec_kriter.Text = "Eksiler" Then
        '        kriter2 = " HAVING (SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) < 0) "
        '    ElseIf sec_kriter.Text = "Bitenler" Then
        '        kriter2 = " HAVING (SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) = 0) "
        '    End If
        'End If
        'If sec_satismi.Checked = True Then
        '    If kriter2 = "" Then
        '        'kriter2 = " WHERE Satis > 0 "
        '    Else
        '        'kriter2 += " AND Satis > 0 "
        '    End If
        'End If
        If depo <> "[Tümü]" Then
            kriter += " AND tbStokFisiDetayi.sDepo IN ( " & depo & " )"
        End If
        kriter += " AND tbStokFisiDetayi.lBrutFiyat Between " & lFiyat1 & " and " & lFiyat2 & " "
        If sec_bSayimHaric.Checked = True Then
            kriter += " AND tbStokFisiDetayi.nFirmaID NOT IN (Select nFirmaID from tbFirma Where sAciklama like '%SAYIM%')"
        End If
        'kriter3 = sorgu_depo_kontrol()
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sBeden, stok.sModel, barkod.sBarkod,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis=1 AND tbStokFisiDetayi.nStokID=stok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi,(SELECT TOP 1 ISNULL(tbStokFisiDetayi.lGirisMiktar1,0) as lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis=1 AND tbStokFisiDetayi.nStokID=stok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisMiktari, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND  tbStokFisiDetayi.dteFisTarihi < = '" & tarih2 & "') AS Mevcut " & kriter3 & " ,(SELECT ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1),0) AS Miktar FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbFisTipi.bSatismi = 1) AND Stok.nStokID = tbStokFisiDetayi.nStokID AND  tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "') AS Satis , tbRenk.sRenkAdi, stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        If bDegerli = False Then
            If sec_kriter.Text = "Model" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.sModel, tbStok.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan,tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbStok.sModel, tbStok.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "R/B/K" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.sModel, tbStok.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID and tbStokFisiDetayi.dteFisTarihi <= '" & tarih2 & "') AS lMevcut,tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbStok.nStokID,tbStok.sModel, tbStok.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf1" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif1.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf2" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif2.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif2.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf3" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif3.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif3.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf4" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif4.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif4.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf5" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif5.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif5.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf6" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif6.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif6.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf7" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif7.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif7.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf8" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif8.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif8.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf9" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif9.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif9.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf10" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif10.sSinifKodu as sModel, tbSSinif1.sAciklama, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif10.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            End If
            colnGirisTutar.Visible = False
            colnGirisTutar.OptionsColumn.ShowInCustomizationForm = False
            colnGirisIadeTutar.Visible = False
            colnGirisIadeTutar.OptionsColumn.ShowInCustomizationForm = False
            colnCikisTutar.Visible = False
            colnCikisTutar.OptionsColumn.ShowInCustomizationForm = False
            colnCikisIadeTutar.Visible = False
            colnCikisIadeTutar.OptionsColumn.ShowInCustomizationForm = False
            colnKalanTutar.Visible = False
            colnKalanTutar.OptionsColumn.ShowInCustomizationForm = False
        ElseIf bDegerli = True Then
            If sec_kriter.Text = "Model" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.sModel, tbStok.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar,tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbStok.sModel, tbStok.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "R/B/K" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.sModel, tbStok.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID and tbStokFisiDetayi.dteFisTarihi <= '" & tarih2 & "') AS lMevcut,tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbStok.nStokID,tbStok.sModel, tbStok.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf1" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif1.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf2" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif2.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif2.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf3" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif3.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif3.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf4" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif4.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif4.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf5" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif5.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif5.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf6" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif6.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif6.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf7" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif7.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif7.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf8" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif8.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif8.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf9" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif9.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif9.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            ElseIf sec_kriter.Text = "Sýnýf10" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSSinif10.sSinifKodu as sModel, tbSSinif1.sAciklama,  ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1) * tbStokFisiDetayi.lGirisFiyat)), 0) AS nGirisIadeTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisTutar, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3) * tbStokFisiDetayi.lCikisFiyat)), 0) AS nCikisIadeTutar, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan, ISNULL(SUM((tbStokFisiDetayi.lGirisMiktar1*tbStokFisiDetayi.lGirisFiyat) - (tbStokFisiDetayi.lCikisMiktar1*tbStokFisiDetayi.lCikisFiyat)), 0) AS nKalanTutar, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & " GROUP BY tbSSinif10.sSinifKodu, tbSSinif1.sAciklama, tbStok.lAsgariMiktar, tbStok.lAzamiMiktar ")
            End If
            colnGirisTutar.Visible = True
            colnGirisTutar.OptionsColumn.ShowInCustomizationForm = True
            colnGirisIadeTutar.Visible = True
            colnGirisIadeTutar.OptionsColumn.ShowInCustomizationForm = True
            colnCikisTutar.Visible = True
            colnCikisTutar.OptionsColumn.ShowInCustomizationForm = True
            colnCikisIadeTutar.Visible = True
            colnCikisIadeTutar.OptionsColumn.ShowInCustomizationForm = True
            colnKalanTutar.Visible = True
            colnKalanTutar.OptionsColumn.ShowInCustomizationForm = True
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub satir_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_satir_stok = sorgu_stok_info(dr("sKodu"))
            Dim dr1 As DataRow = ds_satir_stok.Tables(0).Rows(0)
            If dr1("sRenkAdi").ToString <> "" Then
                Label6.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ") Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
            Else
                Label6.Text = dr1("STOKADI") & " Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
            End If
            'Label2.Text = dr1("STOKADI") & " Renk: " & dr1("sRenkAdi") & " Giren: " & dr1("GIREN") & "Çýkan: " & dr1("CIKAN") & " Kalan: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
            Label2.Refresh()
            dr1 = Nothing
        End If
    End Sub
    Private Function sorgu_stok_info(ByVal stokkodu As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, CAST(SUM(TS.GIREN) AS MONEY) AS  GIREN, CAST(SUM(TS.CIKAN) AS MONEY) AS CIKAN, CAST(SUM(TS.KALAN) AS MONEY) AS KALAN, CAST(SUM(TS.BEKLEYEN) AS MONEY) AS  BEKLEYEN, tbRenk.sRenkAdi FROM (SELECT sAciklama , SUM(GIREN) AS GIREN , SUM(CIKAN) AS CIKAN , SUM(KALAN) AS KALAN , SUM(BEKLEYEN) AS BEKLEYEN , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel FROM (SELECT depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = '" & stokkodu & "') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY depo.sAciklama , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID WHERE (stok.sKodu = '" & stokkodu & "' and hareket.sFistipi <> 'T') GROUP BY depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sAciklama , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel) TS INNER JOIN tbRenk ON TS.sRenk COLLATE Turkish_CI_AS = tbRenk.sRenk GROUP BY TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, tbRenk.sRenkAdi")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        con = Nothing
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal depo As String, ByVal lFiyat1 As Decimal, ByVal lFiyat2 As Decimal)
        yuklendi = False
        DataSet1 = stok(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, depo, lFiyat1, lFiyat2)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        yuklendi = True
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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("sModel")
            frm.stokkodu = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
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
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        'Dim dr As DataRow
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'lbl_istihbarat.Text = dr("ISTIHBARAT")
        'dr = Nothing
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
        'Me.Close()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, sec_depo.Text, txt_lFiyat1.EditValue, txt_lFiyat2.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_envanter()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            'Me.Close()
        End If
    End Sub
    'Private Sub ClosePopup()
    '    If Not PopupContainerControl1.OwnerEdit Is Nothing Then
    '        PopupContainerControl1.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    Private Function sorgu_depo_kontrol() As String
        Dim dr As DataRow
        Dim depo_satir As String
        depo_satir = ""
        For Each dr In DataSet2.Tables(0).Rows
            'Satýþ
            If dr("SEC") = 1 Then
                depo_satir += ", CAST((SELECT ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1),0) AS Miktar FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbFisTipi.bSatismi = 1) AND Stok.nStokID = tbStokFisiDetayi.nStokID AND  tbStokFisiDetayi.dteFisTarihi between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "'AND  (tbStokFisiDetayi.sDepo = '" & dr("DEPOKODU") & "')) AS MONEY) AS  [" & dr("DEPOKODU") & " Satis] "
                'MsgBox(GridView1.Columns.Contains(GridView1.Columns(dr("DEPOKODU"))))
                If GridView1.Columns.Contains(GridView1.Columns(dr("DEPOKODU") + " Satis")) = False Then
                    GridView1.Columns.AddField(dr("DEPOKODU") + " Satis")
                End If
                GridView1.Columns(dr("DEPOKODU") + " Satis").visible = True
                GridView1.Columns(dr("DEPOKODU") + " Satis").FieldName = dr("DEPOKODU") + " Satis"
                GridView1.Columns(dr("DEPOKODU") + " Satis").caption = dr("DEPOKODU") + " Satis"
                GridView1.Columns(dr("DEPOKODU") + " Satis").DisplayFormat.FormatString = "#,0.##"
                GridView1.Columns(dr("DEPOKODU") + " Satis").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(dr("DEPOKODU") + " Satis").SummaryItem.DisplayFormat = "{0:#,0.##}"
                GridView1.Columns(dr("DEPOKODU") + " Satis").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridView1.Columns(dr("DEPOKODU") + " Satis").AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Columns(dr("DEPOKODU") + " Satis").AppearanceCell.ForeColor = System.Drawing.Color.Red
                GridView1.Columns(dr("DEPOKODU") + " Satis").AppearanceCell.Options.UseFont = True
                GridView1.Columns(dr("DEPOKODU") + " Satis").AppearanceCell.Options.UseForeColor = True
                GridView1.Columns(dr("DEPOKODU") + " Satis").AppearanceCell.Options.UseBackColor = True
                GridView1.Columns(dr("DEPOKODU") + " Satis").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
            Else
                If GridView1.Columns.Contains(GridView1.Columns(dr("DEPOKODU") + " Satis")) = True Then
                    GridView1.Columns.Remove(GridView1.Columns(dr("DEPOKODU") + " Satis"))
                End If
            End If
            'Kalan
            If dr("SEC") = 1 Then
                depo_satir += ", CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND  tbStokFisiDetayi.dteFisTarihi < = '" & DateEdit2.EditValue & "' AND (tbStokFisiDetayi.sDepo = '" & dr("DEPOKODU") & "')) AS MONEY) AS  [" & dr("DEPOKODU") & "]"
                'MsgBox(GridView1.Columns.Contains(GridView1.Columns(dr("DEPOKODU"))))
                If GridView1.Columns.Contains(GridView1.Columns(dr("DEPOKODU"))) = False Then
                    GridView1.Columns.Add(dr("DEPOKODU"))
                End If
                GridView1.Columns(dr("DEPOKODU")).visible = True
                GridView1.Columns(dr("DEPOKODU")).FieldName = dr("DEPOKODU")
                GridView1.Columns(dr("DEPOKODU")).caption = dr("DEPOKODU") + " Kalan"
                GridView1.Columns(dr("DEPOKODU")).DisplayFormat.FormatString = "#,0.##"
                GridView1.Columns(dr("DEPOKODU")).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(dr("DEPOKODU")).SummaryItem.DisplayFormat = "{0:#,0.##}"
                GridView1.Columns(dr("DEPOKODU")).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridView1.Columns(dr("DEPOKODU")).AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Columns(dr("DEPOKODU")).AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
                GridView1.Columns(dr("DEPOKODU")).AppearanceCell.Options.UseFont = True
                GridView1.Columns(dr("DEPOKODU")).AppearanceCell.Options.UseForeColor = True
                GridView1.Columns(dr("DEPOKODU")).AppearanceCell.Options.UseBackColor = True
                GridView1.Columns(dr("DEPOKODU")).AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
            Else
                If GridView1.Columns.Contains(GridView1.Columns(dr("DEPOKODU"))) = True Then
                    GridView1.Columns.Remove(GridView1.Columns(dr("DEPOKODU")))
                End If
            End If
        Next
        dr = Nothing
        Return depo_satir.ToString
        depo_satir = Nothing
        'MsgBox(depo_satir)
    End Function
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sModel")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sModel")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.DateEdit1.EditValue = DateEdit1.EditValue
            frm.DateEdit2.EditValue = DateEdit2.EditValue
            frm.sec_giris.Text = "[Tümü]"
            frm.kullanici = kullanici
            frm.bRapor = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_stok_hareket()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If yuklendi = True Then
                Try
                    satir_info()
                Catch ex As Exception
                End Try
            End If
            'satir_info()
        Catch ex As Exception
            Label6.Text = "*"
        End Try
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub

    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        Return s.ToString
    End Function
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
End Class
