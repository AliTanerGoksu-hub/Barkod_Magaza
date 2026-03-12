<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tbFirmaKapama
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbFirmaKapama))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ds_FirmaHesap = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsCariIslem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnHareketID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKapananTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKalan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.ds_tbKapatilacak = New System.Data.DataSet
        Me.DataTable3 = New System.Data.DataTable
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldteIslemTarihi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteValorTarihi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutar1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvrakNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsCariIslem1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnHareketID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOnceOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnSiralama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizKuru = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizMiktari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.ds_tbKapatilmis = New System.Data.DataSet
        Me.DataTable4 = New System.Data.DataTable
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldteIslemTarihi2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteValorTarihi2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutar2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvrakNo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsCariIslem2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnHareketID2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOnceOdemeTutar1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOdemeTutar1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnSiralama1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKalan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_ortvade = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl
        Me.lbl_secilen_sayi = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_secilen = New DevExpress.XtraEditors.LabelControl
        Me.lbl_SecilenTutar_ortvade = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_SecilenTutar_gun = New DevExpress.XtraEditors.LabelControl
        Me.lbl_secilenTutar_sayi = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_secilenTutar = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_bKapanan = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.ds_tbFirmaBakiyesi = New System.Data.DataSet
        Me.DataTable6 = New System.Data.DataTable
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.ds_tbFirma = New System.Data.DataSet
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
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.Printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Printlink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.colnOpsiyon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOpsiyon1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_FirmaHesap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbKapatilacak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbKapatilmis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_bKapanan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaBakiyesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl92)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 439)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl92.Location = New System.Drawing.Point(12, 16)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(54, 20)
        Me.LabelControl92.TabIndex = 63
        Me.LabelControl92.Text = "FirmaKodu:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(84, 16)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_musteriNo.Size = New System.Drawing.Size(241, 20)
        Me.txt_musteriNo.TabIndex = 62
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(732, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 60
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(657, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 59
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.SplitContainerControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 65)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 374)
        Me.PanelControl3.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(820, 265)
        Me.SplitContainerControl1.SplitterPosition = 444
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_FirmaHesap
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(444, 265)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ds_FirmaHesap
        '
        Me.ds_FirmaHesap.DataSetName = "NewDataSet"
        Me.ds_FirmaHesap.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_FirmaHesap.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nFirmaID"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "dteIslemTarihi"
        Me.DataColumn23.DataType = GetType(Date)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "dteValorTarihi"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "lTutar"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sAciklama"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sEvrakNo"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sCariIslem"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "nHareketID"
        Me.DataColumn29.DataType = GetType(Long)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "lKapananTutar"
        Me.DataColumn30.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteIslemTarihi, Me.coldteValorTarihi, Me.collTutar, Me.colsAciklama, Me.colsEvrakNo, Me.colsCariIslem, Me.colnHareketID, Me.collKapananTutar, Me.collKalan2, Me.colsDovizCinsi1, Me.collDovizKuru1, Me.collDovizMiktari1, Me.colnOpsiyon})
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
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "Ýþlem Tarihi"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", "{0} Kayýt")})
        Me.coldteIslemTarihi.Visible = True
        Me.coldteIslemTarihi.VisibleIndex = 0
        Me.coldteIslemTarihi.Width = 153
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Visible = True
        Me.coldteValorTarihi.VisibleIndex = 2
        Me.coldteValorTarihi.Width = 161
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00##}")})
        Me.collTutar.Visible = True
        Me.collTutar.VisibleIndex = 6
        Me.collTutar.Width = 152
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 5
        Me.colsAciklama.Width = 276
        '
        'colsEvrakNo
        '
        Me.colsEvrakNo.Caption = "Evrak No"
        Me.colsEvrakNo.FieldName = "sEvrakNo"
        Me.colsEvrakNo.Name = "colsEvrakNo"
        Me.colsEvrakNo.Visible = True
        Me.colsEvrakNo.VisibleIndex = 4
        Me.colsEvrakNo.Width = 139
        '
        'colsCariIslem
        '
        Me.colsCariIslem.Caption = "Ýþlem"
        Me.colsCariIslem.FieldName = "sCariIslem"
        Me.colsCariIslem.Name = "colsCariIslem"
        Me.colsCariIslem.Visible = True
        Me.colsCariIslem.VisibleIndex = 3
        Me.colsCariIslem.Width = 109
        '
        'colnHareketID
        '
        Me.colnHareketID.Caption = "Kayýt No"
        Me.colnHareketID.FieldName = "nHareketID"
        Me.colnHareketID.Name = "colnHareketID"
        '
        'collKapananTutar
        '
        Me.collKapananTutar.Caption = "Kapanan"
        Me.collKapananTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collKapananTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKapananTutar.FieldName = "lKapananTutar"
        Me.collKapananTutar.Name = "collKapananTutar"
        Me.collKapananTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKapananTutar", "{0:#,0.00##}")})
        Me.collKapananTutar.Width = 69
        '
        'collKalan2
        '
        Me.collKalan2.Caption = "Kalan"
        Me.collKalan2.DisplayFormat.FormatString = "#,0.00##"
        Me.collKalan2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan2.FieldName = "lKalan"
        Me.collKalan2.Name = "collKalan2"
        Me.collKalan2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.00##}")})
        Me.collKalan2.Visible = True
        Me.collKalan2.VisibleIndex = 7
        Me.collKalan2.Width = 191
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru"
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarý"
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        Me.collDovizMiktari1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", "{0:#,0.00}")})
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabControl1.AppearancePage.HeaderActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Navy
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseBackColor = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(371, 265)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl2)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(343, 259)
        Me.XtraTabPage1.Text = "Kapatýlacak"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_tbKapatilacak
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(343, 219)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ds_tbKapatilacak
        '
        Me.ds_tbKapatilacak.DataSetName = "NewDataSet"
        Me.ds_tbKapatilacak.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbKapatilacak.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "dteIslemTarihi"
        Me.DataColumn31.DataType = GetType(Date)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "dteValorTarihi"
        Me.DataColumn32.DataType = GetType(Date)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "lTutar"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sAciklama"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sEvrakNo"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sCariIslem"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "nHareketID"
        Me.DataColumn37.DataType = GetType(Long)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "OnceOdemeTutar"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "lOdemeTutar"
        Me.DataColumn39.DataType = GetType(Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "nSiralama"
        Me.DataColumn40.DataType = GetType(Byte)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "lKalan"
        Me.DataColumn41.DataType = GetType(Decimal)
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteIslemTarihi1, Me.coldteValorTarihi1, Me.collTutar1, Me.colsAciklama1, Me.colsEvrakNo1, Me.colsCariIslem1, Me.colnHareketID1, Me.colOnceOdemeTutar, Me.collOdemeTutar, Me.colnSiralama, Me.collKalan, Me.colsDovizCinsi, Me.collDovizKuru, Me.collDovizMiktari, Me.colOpsiyon1})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 35
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'coldteIslemTarihi1
        '
        Me.coldteIslemTarihi1.Caption = "Tarih"
        Me.coldteIslemTarihi1.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi1.Name = "coldteIslemTarihi1"
        Me.coldteIslemTarihi1.Visible = True
        Me.coldteIslemTarihi1.VisibleIndex = 0
        Me.coldteIslemTarihi1.Width = 149
        '
        'coldteValorTarihi1
        '
        Me.coldteValorTarihi1.Caption = "Valor"
        Me.coldteValorTarihi1.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi1.Name = "coldteValorTarihi1"
        Me.coldteValorTarihi1.Visible = True
        Me.coldteValorTarihi1.VisibleIndex = 2
        Me.coldteValorTarihi1.Width = 195
        '
        'collTutar1
        '
        Me.collTutar1.Caption = "Tutar"
        Me.collTutar1.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar1.FieldName = "lTutar"
        Me.collTutar1.Name = "collTutar1"
        Me.collTutar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00##}")})
        Me.collTutar1.Visible = True
        Me.collTutar1.VisibleIndex = 5
        Me.collTutar1.Width = 153
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Açýklama"
        Me.colsAciklama1.FieldName = "sAciklama"
        Me.colsAciklama1.Name = "colsAciklama1"
        Me.colsAciklama1.Visible = True
        Me.colsAciklama1.VisibleIndex = 4
        Me.colsAciklama1.Width = 364
        '
        'colsEvrakNo1
        '
        Me.colsEvrakNo1.Caption = "Evrak No"
        Me.colsEvrakNo1.FieldName = "sEvrakNo"
        Me.colsEvrakNo1.Name = "colsEvrakNo1"
        Me.colsEvrakNo1.Width = 42
        '
        'colsCariIslem1
        '
        Me.colsCariIslem1.Caption = "Ýþlem"
        Me.colsCariIslem1.FieldName = "sCariIslem"
        Me.colsCariIslem1.Name = "colsCariIslem1"
        Me.colsCariIslem1.Visible = True
        Me.colsCariIslem1.VisibleIndex = 3
        Me.colsCariIslem1.Width = 115
        '
        'colnHareketID1
        '
        Me.colnHareketID1.Caption = "HareketID"
        Me.colnHareketID1.FieldName = "nHareketID"
        Me.colnHareketID1.Name = "colnHareketID1"
        '
        'colOnceOdemeTutar
        '
        Me.colOnceOdemeTutar.Caption = "OnceOdemeTutar"
        Me.colOnceOdemeTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.colOnceOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOnceOdemeTutar.FieldName = "OnceOdemeTutar"
        Me.colOnceOdemeTutar.Name = "colOnceOdemeTutar"
        Me.colOnceOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OnceOdemeTutar", "{0:#,0.00##}")})
        '
        'collOdemeTutar
        '
        Me.collOdemeTutar.Caption = "Ödeme"
        Me.collOdemeTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00##}")})
        Me.collOdemeTutar.Width = 123
        '
        'colnSiralama
        '
        Me.colnSiralama.Caption = "Sec"
        Me.colnSiralama.FieldName = "nSiralama"
        Me.colnSiralama.Name = "colnSiralama"
        Me.colnSiralama.Width = 44
        '
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.00##"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.00##}")})
        Me.collKalan.Visible = True
        Me.collKalan.VisibleIndex = 6
        Me.collKalan.Width = 205
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'collDovizKuru
        '
        Me.collDovizKuru.Caption = "Döviz Kuru"
        Me.collDovizKuru.FieldName = "lDovizKuru1"
        Me.collDovizKuru.Name = "collDovizKuru"
        '
        'collDovizMiktari
        '
        Me.collDovizMiktari.Caption = "Döviz Miktarý"
        Me.collDovizMiktari.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari.Name = "collDovizMiktari"
        Me.collDovizMiktari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizMiktari1", "{0:#,0.00}")})
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.SimpleButton3)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(0, 219)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(343, 40)
        Me.PanelControl5.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(13, 9)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 0
        Me.SimpleButton3.Text = "&Kapat"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl3)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(343, 259)
        Me.XtraTabPage2.Text = "Kapatýlmýs"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.ds_tbKapatilmis
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(343, 219)
        Me.GridControl3.TabIndex = 2
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ds_tbKapatilmis
        '
        Me.ds_tbKapatilmis.DataSetName = "NewDataSet"
        Me.ds_tbKapatilmis.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbKapatilmis.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "dteIslemTarihi"
        Me.DataColumn52.DataType = GetType(Date)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "dteValorTarihi"
        Me.DataColumn53.DataType = GetType(Date)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "lTutar"
        Me.DataColumn54.DataType = GetType(Decimal)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "sAciklama"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "sEvrakNo"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sCariIslem"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "nHareketID"
        Me.DataColumn58.DataType = GetType(Long)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "OnceOdemeTutar"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "lOdemeTutar"
        Me.DataColumn60.DataType = GetType(Decimal)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "nSiralama"
        Me.DataColumn61.DataType = GetType(Byte)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "lKalan"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteIslemTarihi2, Me.coldteValorTarihi2, Me.collTutar2, Me.colsAciklama2, Me.colsEvrakNo2, Me.colsCariIslem2, Me.colnHareketID2, Me.colOnceOdemeTutar1, Me.collOdemeTutar1, Me.colnSiralama1, Me.collKalan1})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 35
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'coldteIslemTarihi2
        '
        Me.coldteIslemTarihi2.Caption = "Ýþlem Tarihi"
        Me.coldteIslemTarihi2.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi2.Name = "coldteIslemTarihi2"
        Me.coldteIslemTarihi2.Visible = True
        Me.coldteIslemTarihi2.VisibleIndex = 1
        Me.coldteIslemTarihi2.Width = 74
        '
        'coldteValorTarihi2
        '
        Me.coldteValorTarihi2.Caption = "Valor"
        Me.coldteValorTarihi2.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi2.Name = "coldteValorTarihi2"
        Me.coldteValorTarihi2.Width = 20
        '
        'collTutar2
        '
        Me.collTutar2.Caption = "Tutar"
        Me.collTutar2.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutar2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar2.FieldName = "lTutar"
        Me.collTutar2.Name = "collTutar2"
        Me.collTutar2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00##}")})
        Me.collTutar2.Visible = True
        Me.collTutar2.VisibleIndex = 4
        Me.collTutar2.Width = 58
        '
        'colsAciklama2
        '
        Me.colsAciklama2.Caption = "Açýklama"
        Me.colsAciklama2.FieldName = "sAciklama"
        Me.colsAciklama2.Name = "colsAciklama2"
        Me.colsAciklama2.Visible = True
        Me.colsAciklama2.VisibleIndex = 2
        Me.colsAciklama2.Width = 89
        '
        'colsEvrakNo2
        '
        Me.colsEvrakNo2.Caption = "Evrak No"
        Me.colsEvrakNo2.FieldName = "sEvrakNo"
        Me.colsEvrakNo2.Name = "colsEvrakNo2"
        Me.colsEvrakNo2.Width = 21
        '
        'colsCariIslem2
        '
        Me.colsCariIslem2.Caption = "Ýþlem"
        Me.colsCariIslem2.FieldName = "sCariIslem"
        Me.colsCariIslem2.Name = "colsCariIslem2"
        Me.colsCariIslem2.Visible = True
        Me.colsCariIslem2.VisibleIndex = 3
        Me.colsCariIslem2.Width = 58
        '
        'colnHareketID2
        '
        Me.colnHareketID2.Caption = "Kayýt No"
        Me.colnHareketID2.FieldName = "nHareketID"
        Me.colnHareketID2.Name = "colnHareketID2"
        Me.colnHareketID2.Width = 104
        '
        'colOnceOdemeTutar1
        '
        Me.colOnceOdemeTutar1.Caption = "DigerKarsilama"
        Me.colOnceOdemeTutar1.DisplayFormat.FormatString = "#,0.00##"
        Me.colOnceOdemeTutar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOnceOdemeTutar1.FieldName = "OnceOdemeTutar"
        Me.colOnceOdemeTutar1.Name = "colOnceOdemeTutar1"
        Me.colOnceOdemeTutar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OnceOdemeTutar", "{0:#,0.00##}")})
        Me.colOnceOdemeTutar1.Width = 104
        '
        'collOdemeTutar1
        '
        Me.collOdemeTutar1.Caption = "Ödeme"
        Me.collOdemeTutar1.DisplayFormat.FormatString = "#,0.00##"
        Me.collOdemeTutar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdemeTutar1.FieldName = "lOdemeTutar"
        Me.collOdemeTutar1.Name = "collOdemeTutar1"
        Me.collOdemeTutar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00##}")})
        Me.collOdemeTutar1.Visible = True
        Me.collOdemeTutar1.VisibleIndex = 5
        Me.collOdemeTutar1.Width = 82
        '
        'colnSiralama1
        '
        Me.colnSiralama1.Caption = "Sec"
        Me.colnSiralama1.FieldName = "nSiralama"
        Me.colnSiralama1.Name = "colnSiralama1"
        Me.colnSiralama1.Visible = True
        Me.colnSiralama1.VisibleIndex = 0
        Me.colnSiralama1.Width = 44
        '
        'collKalan1
        '
        Me.collKalan1.Caption = "Kalan"
        Me.collKalan1.FieldName = "lKalan"
        Me.collKalan1.Name = "collKalan1"
        Me.collKalan1.Width = 43
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.SimpleButton4)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl6.Location = New System.Drawing.Point(0, 219)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(343, 40)
        Me.PanelControl6.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(13, 9)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 1
        Me.SimpleButton4.Text = "&Ýptal"
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.Black
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.Controls.Add(Me.lbl_ortvade)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Controls.Add(Me.lbl_gun)
        Me.PanelControl4.Controls.Add(Me.lbl_secilen_sayi)
        Me.PanelControl4.Controls.Add(Me.LabelControl5)
        Me.PanelControl4.Controls.Add(Me.lbl_secilen)
        Me.PanelControl4.Controls.Add(Me.lbl_SecilenTutar_ortvade)
        Me.PanelControl4.Controls.Add(Me.LabelControl14)
        Me.PanelControl4.Controls.Add(Me.LabelControl16)
        Me.PanelControl4.Controls.Add(Me.LabelControl13)
        Me.PanelControl4.Controls.Add(Me.lbl_SecilenTutar_gun)
        Me.PanelControl4.Controls.Add(Me.lbl_secilenTutar_sayi)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.lbl_secilenTutar)
        Me.PanelControl4.Controls.Add(Me.SimpleButton5)
        Me.PanelControl4.Controls.Add(Me.sec_bKapanan)
        Me.PanelControl4.Controls.Add(Me.LabelControl18)
        Me.PanelControl4.Controls.Add(Me.LabelControl17)
        Me.PanelControl4.Controls.Add(Me.LabelControl10)
        Me.PanelControl4.Controls.Add(Me.TextEdit3)
        Me.PanelControl4.Controls.Add(Me.TextEdit2)
        Me.PanelControl4.Controls.Add(Me.TextEdit1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 267)
        Me.PanelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 105)
        Me.PanelControl4.TabIndex = 1
        '
        'lbl_ortvade
        '
        Me.lbl_ortvade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ortvade.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_ortvade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_ortvade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_ortvade.Location = New System.Drawing.Point(547, 43)
        Me.lbl_ortvade.Name = "lbl_ortvade"
        Me.lbl_ortvade.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ortvade.TabIndex = 83
        Me.lbl_ortvade.Text = "%"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(474, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 78
        Me.LabelControl2.Text = "SeçilenTutar:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(465, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "OrtalamaVade:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(473, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 76
        Me.LabelControl4.Text = "SeçilenEvrak:"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(547, 30)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(13, 13)
        Me.lbl_gun.TabIndex = 81
        Me.lbl_gun.Text = "%"
        '
        'lbl_secilen_sayi
        '
        Me.lbl_secilen_sayi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen_sayi.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_secilen_sayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen_sayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen_sayi.Location = New System.Drawing.Point(547, 4)
        Me.lbl_secilen_sayi.Name = "lbl_secilen_sayi"
        Me.lbl_secilen_sayi.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilen_sayi.TabIndex = 77
        Me.lbl_secilen_sayi.Text = "%"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(470, 30)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl5.TabIndex = 80
        Me.LabelControl5.Text = "OrtalamaGün:"
        '
        'lbl_secilen
        '
        Me.lbl_secilen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_secilen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen.Location = New System.Drawing.Point(547, 17)
        Me.lbl_secilen.Name = "lbl_secilen"
        Me.lbl_secilen.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilen.TabIndex = 79
        Me.lbl_secilen.Text = "%"
        '
        'lbl_SecilenTutar_ortvade
        '
        Me.lbl_SecilenTutar_ortvade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_SecilenTutar_ortvade.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_SecilenTutar_ortvade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_SecilenTutar_ortvade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_SecilenTutar_ortvade.Location = New System.Drawing.Point(88, 42)
        Me.lbl_SecilenTutar_ortvade.Name = "lbl_SecilenTutar_ortvade"
        Me.lbl_SecilenTutar_ortvade.Size = New System.Drawing.Size(13, 13)
        Me.lbl_SecilenTutar_ortvade.TabIndex = 75
        Me.lbl_SecilenTutar_ortvade.Text = "%"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(15, 16)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl14.TabIndex = 70
        Me.LabelControl14.Text = "SeçilenTutar:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(6, 42)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl16.TabIndex = 74
        Me.LabelControl16.Text = "OrtalamaVade:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(14, 3)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl13.TabIndex = 68
        Me.LabelControl13.Text = "SeçilenEvrak:"
        '
        'lbl_SecilenTutar_gun
        '
        Me.lbl_SecilenTutar_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_SecilenTutar_gun.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_SecilenTutar_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_SecilenTutar_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_SecilenTutar_gun.Location = New System.Drawing.Point(88, 29)
        Me.lbl_SecilenTutar_gun.Name = "lbl_SecilenTutar_gun"
        Me.lbl_SecilenTutar_gun.Size = New System.Drawing.Size(13, 13)
        Me.lbl_SecilenTutar_gun.TabIndex = 73
        Me.lbl_SecilenTutar_gun.Text = "%"
        '
        'lbl_secilenTutar_sayi
        '
        Me.lbl_secilenTutar_sayi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilenTutar_sayi.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_secilenTutar_sayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilenTutar_sayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilenTutar_sayi.Location = New System.Drawing.Point(88, 3)
        Me.lbl_secilenTutar_sayi.Name = "lbl_secilenTutar_sayi"
        Me.lbl_secilenTutar_sayi.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilenTutar_sayi.TabIndex = 69
        Me.lbl_secilenTutar_sayi.Text = "%"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(11, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl1.TabIndex = 72
        Me.LabelControl1.Text = "OrtalamaGün:"
        '
        'lbl_secilenTutar
        '
        Me.lbl_secilenTutar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilenTutar.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_secilenTutar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilenTutar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilenTutar.Location = New System.Drawing.Point(88, 16)
        Me.lbl_secilenTutar.Name = "lbl_secilenTutar"
        Me.lbl_secilenTutar.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilenTutar.TabIndex = 71
        Me.lbl_secilenTutar.Text = "%"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(659, 71)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(150, 23)
        Me.SimpleButton5.TabIndex = 67
        Me.SimpleButton5.Text = "&Tüm Kapatmalarý Ýptal Et"
        '
        'sec_bKapanan
        '
        Me.sec_bKapanan.Location = New System.Drawing.Point(12, 81)
        Me.sec_bKapanan.Name = "sec_bKapanan"
        Me.sec_bKapanan.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.sec_bKapanan.Properties.Appearance.Options.UseForeColor = True
        Me.sec_bKapanan.Properties.Caption = "Kapananlar"
        Me.sec_bKapanan.Size = New System.Drawing.Size(128, 19)
        Me.sec_bKapanan.TabIndex = 66
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl18.Location = New System.Drawing.Point(455, 62)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl18.TabIndex = 65
        Me.LabelControl18.Text = "Bakiye"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.Location = New System.Drawing.Point(271, 62)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl17.TabIndex = 64
        Me.LabelControl17.Text = "Alacak"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(82, 62)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl10.TabIndex = 63
        Me.LabelControl10.Text = "Borç"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lBakiye", True))
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(455, 80)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.EditFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.TextEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.MaxLength = 60
        Me.TextEdit3.Properties.NullText = "0.00"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit3.Size = New System.Drawing.Size(193, 18)
        Me.TextEdit3.TabIndex = 62
        '
        'ds_tbFirmaBakiyesi
        '
        Me.ds_tbFirmaBakiyesi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaBakiyesi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaBakiyesi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "nFirmaID"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "lBorc"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "lAlacak"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "lBakiye"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lAlacak", True))
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(271, 80)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.EditFormat.FormatString = "#,0.00##"
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.MaxLength = 60
        Me.TextEdit2.Properties.NullText = "0.00"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit2.Size = New System.Drawing.Size(185, 18)
        Me.TextEdit2.TabIndex = 61
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lBorc", True))
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(82, 80)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatString = "#,0.00##"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.MaxLength = 60
        Me.TextEdit1.Properties.NullText = "0.00"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit1.Size = New System.Drawing.Size(190, 18)
        Me.TextEdit1.TabIndex = 60
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hesap Kapama Tablosu Aþaðýdadýr..."
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 65)
        Me.PanelControl1.TabIndex = 2
        '
        'ds_tbFirma
        '
        Me.ds_tbFirma.DataSetName = "NewDataSet"
        Me.ds_tbFirma.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirma.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sKodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "nOzelIskontosu"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lKrediLimiti"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "dteMutabakatTarihi"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nVadeGun"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sHitap"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAdres1"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sAdres2"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sSemt"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sIl"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sUlke"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sPostaKodu"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sVergiDairesi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sVergiNo"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "nHesapID"
        Me.DataColumn17.DataType = GetType(Long)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sOzelNot"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sKullaniciAdi"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "dteKayitTarihi"
        Me.DataColumn20.DataType = GetType(Date)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sFiyatTipi"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sMuhasebeKodu"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "sMuhasebeAciklama"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "nOzelIskontosu2"
        Me.DataColumn49.DataType = GetType(Long)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "nOzelIskontosu3"
        Me.DataColumn50.DataType = GetType(Long)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "nOzelIskontosu4"
        Me.DataColumn51.DataType = GetType(Long)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Çýkýþ,Esc"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem2.Name = "BarButtonItem2"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 487)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 487)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.Printlink1, Me.Printlink2, Me.Printlink3})
        '
        'Printlink1
        '
        Me.Printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.Printlink1.ImageCollection.ImageStream = CType(resources.GetObject("Printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.Printlink1.Margins = New System.Drawing.Printing.Margins(30, 20, 60, 60)
        Me.Printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Printlink1.PrintingSystem = Me.ps
        Me.Printlink1.PrintingSystemBase = Me.ps
        '
        'Printlink2
        '
        Me.Printlink2.Component = Me.GridControl2
        '
        '
        '
        Me.Printlink2.ImageCollection.ImageStream = CType(resources.GetObject("Printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.Printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.Printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Printlink2.PrintingSystem = Me.ps
        Me.Printlink2.PrintingSystemBase = Me.ps
        '
        'Printlink3
        '
        Me.Printlink3.Component = Me.GridControl3
        '
        '
        '
        Me.Printlink3.ImageCollection.ImageStream = CType(resources.GetObject("Printlink3.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.Printlink3.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.Printlink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Printlink3.PrintingSystem = Me.ps
        Me.Printlink3.PrintingSystemBase = Me.ps
        '
        'colnOpsiyon
        '
        Me.colnOpsiyon.Caption = "Opsiyon"
        Me.colnOpsiyon.FieldName = "nOpsiyon"
        Me.colnOpsiyon.Name = "colnOpsiyon"
        Me.colnOpsiyon.Visible = True
        Me.colnOpsiyon.VisibleIndex = 1
        Me.colnOpsiyon.Width = 54
        '
        'colOpsiyon1
        '
        Me.colOpsiyon1.Caption = "Opsiyon"
        Me.colOpsiyon1.FieldName = "nOpsiyon"
        Me.colOpsiyon1.Name = "colOpsiyon1"
        Me.colOpsiyon1.Visible = True
        Me.colOpsiyon1.VisibleIndex = 1
        Me.colOpsiyon1.Width = 54
        '
        'frm_tbFirmaKapama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 510)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbFirmaKapama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borc/Alacak Kapama Kaydý"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_FirmaHesap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbKapatilacak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbKapatilmis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.sec_bKapanan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaBakiyesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCariIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHareketID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKapananTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_tbFirma As System.Data.DataSet
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
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents ds_tbFirmaBakiyesi As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents ds_FirmaHesap As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents ds_tbKapatilacak As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents ds_tbKapatilmis As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
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
    Friend WithEvents collKalan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bKapanan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldteIslemTarihi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvrakNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCariIslem1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHareketID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnceOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSiralama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldteIslemTarihi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvrakNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCariIslem2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHareketID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOnceOdemeTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSiralama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_SecilenTutar_ortvade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_SecilenTutar_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilenTutar_sayi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilenTutar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ortvade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilen_sayi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Printlink3 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colnOpsiyon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpsiyon1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
