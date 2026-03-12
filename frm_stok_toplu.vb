Public Class frm_stok_toplu
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
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
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
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKODU As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKADI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowBARKOD As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowDEPO As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowFIYAT As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKRITER As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_fiyat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_stok_kriter As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents rowSIRALAMA As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_sirala As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents rowAKTIF As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_toplu))
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.sec_kriter = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties11 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.sec_fiyat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.MultiEditorRowProperties12 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties13 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.sec_stok_kriter = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.MultiEditorRowProperties14 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties15 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties16 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties17 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties18 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties19 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties20 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties21 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties22 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties23 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties24 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties25 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties26 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties27 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties38 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.sec_sirala = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.MultiEditorRowProperties39 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties40 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties41 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties28 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties29 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties30 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties31 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties32 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties33 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties34 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties35 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties36 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.MultiEditorRowProperties37 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Me.DataSet1 = New System.Data.DataSet
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowSTOKKODU = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowSTOKADI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowBARKOD = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowDEPO = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowFIYAT = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKRITER = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowKOD10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowSIRALAMA = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.rowAKTIF = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        CType(Me.sec_kriter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_stok_kriter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sirala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.Caption = "Kayýt No"
        Me.MultiEditorRowProperties1.CellWidth = 134
        Me.MultiEditorRowProperties1.FieldName = "IND"
        Me.MultiEditorRowProperties1.ImageIndex = 0
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.CellWidth = 56
        Me.MultiEditorRowProperties2.FieldName = "QIND"
        Me.MultiEditorRowProperties2.ReadOnly = True
        Me.MultiEditorRowProperties2.RowEdit = Me.sec_kriter
        '
        'sec_kriter
        '
        Me.sec_kriter.AutoHeight = False
        Me.sec_kriter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties3
        '
        Me.MultiEditorRowProperties3.Caption = "Stok Kodu"
        Me.MultiEditorRowProperties3.CellWidth = 134
        Me.MultiEditorRowProperties3.FieldName = "STOKKODU"
        Me.MultiEditorRowProperties3.ImageIndex = 0
        '
        'MultiEditorRowProperties4
        '
        Me.MultiEditorRowProperties4.CellWidth = 56
        Me.MultiEditorRowProperties4.FieldName = "QSTOKKODU"
        Me.MultiEditorRowProperties4.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties5
        '
        Me.MultiEditorRowProperties5.Caption = "Stok Adý"
        Me.MultiEditorRowProperties5.CellWidth = 134
        Me.MultiEditorRowProperties5.FieldName = "STOKADI"
        Me.MultiEditorRowProperties5.ImageIndex = 0
        '
        'MultiEditorRowProperties6
        '
        Me.MultiEditorRowProperties6.CellWidth = 56
        Me.MultiEditorRowProperties6.FieldName = "QSTOKADI"
        Me.MultiEditorRowProperties6.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties7
        '
        Me.MultiEditorRowProperties7.Caption = "Barkod"
        Me.MultiEditorRowProperties7.CellWidth = 134
        Me.MultiEditorRowProperties7.FieldName = "BARKOD"
        Me.MultiEditorRowProperties7.ImageIndex = 0
        '
        'MultiEditorRowProperties8
        '
        Me.MultiEditorRowProperties8.CellWidth = 56
        Me.MultiEditorRowProperties8.FieldName = "QBARKOD"
        Me.MultiEditorRowProperties8.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties9
        '
        Me.MultiEditorRowProperties9.Caption = "Depo"
        Me.MultiEditorRowProperties9.CellWidth = 134
        Me.MultiEditorRowProperties9.FieldName = "DEPO"
        Me.MultiEditorRowProperties9.ImageIndex = 0
        '
        'MultiEditorRowProperties10
        '
        Me.MultiEditorRowProperties10.CellWidth = 56
        Me.MultiEditorRowProperties10.FieldName = "QDEPO"
        Me.MultiEditorRowProperties10.ReadOnly = True
        Me.MultiEditorRowProperties10.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties11
        '
        Me.MultiEditorRowProperties11.Caption = "Fiyat"
        Me.MultiEditorRowProperties11.CellWidth = 134
        Me.MultiEditorRowProperties11.FieldName = "FIYAT"
        Me.MultiEditorRowProperties11.ImageIndex = 0
        Me.MultiEditorRowProperties11.RowEdit = Me.sec_fiyat
        '
        'sec_fiyat
        '
        Me.sec_fiyat.AutoHeight = False
        Me.sec_fiyat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyat.Items.AddRange(New Object() {"1. Satýþ Fiyatý", "2. Satýþ Fiyatý", "3. Satýþ Fiyatý", "4. Satýþ Fiyatý"})
        Me.sec_fiyat.Name = "sec_fiyat"
        Me.sec_fiyat.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties12
        '
        Me.MultiEditorRowProperties12.CellWidth = 56
        Me.MultiEditorRowProperties12.FieldName = "QFIYAT"
        Me.MultiEditorRowProperties12.ReadOnly = True
        Me.MultiEditorRowProperties12.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties13
        '
        Me.MultiEditorRowProperties13.Caption = "Kriter"
        Me.MultiEditorRowProperties13.CellWidth = 134
        Me.MultiEditorRowProperties13.FieldName = "KRITER"
        Me.MultiEditorRowProperties13.ImageIndex = 0
        Me.MultiEditorRowProperties13.RowEdit = Me.sec_stok_kriter
        '
        'sec_stok_kriter
        '
        Me.sec_stok_kriter.AutoHeight = False
        Me.sec_stok_kriter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_stok_kriter.Items.AddRange(New Object() {"Satýþ Fiyatý Deðiþenler", "Alýþ Fiyatý Deðiþenler", "Maliyet Fiyatý Deðiþenler", "Yeni Açýlan Stoklar", "Tartýlý Stoklar", "Plu Stoklar", "Tüm Stoklar"})
        Me.sec_stok_kriter.Name = "sec_stok_kriter"
        Me.sec_stok_kriter.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties14
        '
        Me.MultiEditorRowProperties14.CellWidth = 56
        Me.MultiEditorRowProperties14.FieldName = "QKRITER"
        Me.MultiEditorRowProperties14.ReadOnly = True
        Me.MultiEditorRowProperties14.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties15
        '
        Me.MultiEditorRowProperties15.Caption = "ÝlkTarih"
        Me.MultiEditorRowProperties15.CellWidth = 67
        Me.MultiEditorRowProperties15.FieldName = "ILKTARIH"
        Me.MultiEditorRowProperties15.ImageIndex = 0
        Me.MultiEditorRowProperties15.Width = 71
        '
        'MultiEditorRowProperties16
        '
        Me.MultiEditorRowProperties16.Caption = "SonTarih"
        Me.MultiEditorRowProperties16.CellWidth = 67
        Me.MultiEditorRowProperties16.FieldName = "SONTARIH"
        Me.MultiEditorRowProperties16.Width = 58
        '
        'MultiEditorRowProperties17
        '
        Me.MultiEditorRowProperties17.CellWidth = 56
        Me.MultiEditorRowProperties17.FieldName = "QILKTARIH"
        Me.MultiEditorRowProperties17.ReadOnly = True
        Me.MultiEditorRowProperties17.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties17.Width = 36
        '
        'MultiEditorRowProperties18
        '
        Me.MultiEditorRowProperties18.Caption = "Sýnýf 1"
        Me.MultiEditorRowProperties18.CellWidth = 134
        Me.MultiEditorRowProperties18.FieldName = "KOD1"
        Me.MultiEditorRowProperties18.ImageIndex = 0
        '
        'MultiEditorRowProperties19
        '
        Me.MultiEditorRowProperties19.CellWidth = 56
        Me.MultiEditorRowProperties19.FieldName = "QKOD1"
        Me.MultiEditorRowProperties19.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties20
        '
        Me.MultiEditorRowProperties20.Caption = "Sýnýf 2"
        Me.MultiEditorRowProperties20.CellWidth = 134
        Me.MultiEditorRowProperties20.FieldName = "KOD2"
        Me.MultiEditorRowProperties20.ImageIndex = 0
        '
        'MultiEditorRowProperties21
        '
        Me.MultiEditorRowProperties21.CellWidth = 56
        Me.MultiEditorRowProperties21.FieldName = "QKOD2"
        Me.MultiEditorRowProperties21.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties22
        '
        Me.MultiEditorRowProperties22.Caption = "Sýnýf 3"
        Me.MultiEditorRowProperties22.CellWidth = 134
        Me.MultiEditorRowProperties22.FieldName = "KOD3"
        Me.MultiEditorRowProperties22.ImageIndex = 0
        '
        'MultiEditorRowProperties23
        '
        Me.MultiEditorRowProperties23.CellWidth = 56
        Me.MultiEditorRowProperties23.FieldName = "QKOD3"
        Me.MultiEditorRowProperties23.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties24
        '
        Me.MultiEditorRowProperties24.Caption = "Sýnýf 4"
        Me.MultiEditorRowProperties24.CellWidth = 134
        Me.MultiEditorRowProperties24.FieldName = "KOD4"
        Me.MultiEditorRowProperties24.ImageIndex = 0
        '
        'MultiEditorRowProperties25
        '
        Me.MultiEditorRowProperties25.CellWidth = 56
        Me.MultiEditorRowProperties25.FieldName = "QKOD4"
        Me.MultiEditorRowProperties25.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties26
        '
        Me.MultiEditorRowProperties26.Caption = "Sýnýf 5"
        Me.MultiEditorRowProperties26.CellWidth = 134
        Me.MultiEditorRowProperties26.FieldName = "KOD5"
        Me.MultiEditorRowProperties26.ImageIndex = 0
        '
        'MultiEditorRowProperties27
        '
        Me.MultiEditorRowProperties27.CellWidth = 56
        Me.MultiEditorRowProperties27.FieldName = "QKOD5"
        Me.MultiEditorRowProperties27.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties38
        '
        Me.MultiEditorRowProperties38.Caption = "Sýralama"
        Me.MultiEditorRowProperties38.CellWidth = 134
        Me.MultiEditorRowProperties38.FieldName = "SIRALAMA"
        Me.MultiEditorRowProperties38.ImageIndex = 0
        Me.MultiEditorRowProperties38.ReadOnly = True
        Me.MultiEditorRowProperties38.RowEdit = Me.sec_sirala
        '
        'sec_sirala
        '
        Me.sec_sirala.AutoHeight = False
        Me.sec_sirala.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sirala.Items.AddRange(New Object() {"STOKKODU", "MALINCINSI", "BARKOD", "OZELKOD"})
        Me.sec_sirala.Name = "sec_sirala"
        Me.sec_sirala.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties39
        '
        Me.MultiEditorRowProperties39.CellWidth = 56
        Me.MultiEditorRowProperties39.FieldName = "QSIRALAMA"
        Me.MultiEditorRowProperties39.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties40
        '
        Me.MultiEditorRowProperties40.Caption = "Aktif"
        Me.MultiEditorRowProperties40.CellWidth = 134
        Me.MultiEditorRowProperties40.FieldName = "AKTIF"
        Me.MultiEditorRowProperties40.ImageIndex = 0
        '
        'MultiEditorRowProperties41
        '
        Me.MultiEditorRowProperties41.CellWidth = 56
        Me.MultiEditorRowProperties41.FieldName = "QAKTIF"
        Me.MultiEditorRowProperties41.ReadOnly = True
        Me.MultiEditorRowProperties41.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties28
        '
        Me.MultiEditorRowProperties28.Caption = "Sýnýf 6"
        Me.MultiEditorRowProperties28.CellWidth = 134
        Me.MultiEditorRowProperties28.FieldName = "KOD6"
        Me.MultiEditorRowProperties28.ImageIndex = 0
        '
        'MultiEditorRowProperties29
        '
        Me.MultiEditorRowProperties29.CellWidth = 56
        Me.MultiEditorRowProperties29.FieldName = "QKOD6"
        Me.MultiEditorRowProperties29.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties30
        '
        Me.MultiEditorRowProperties30.Caption = "Sýnýf 7"
        Me.MultiEditorRowProperties30.CellWidth = 134
        Me.MultiEditorRowProperties30.FieldName = "KOD7"
        Me.MultiEditorRowProperties30.ImageIndex = 0
        '
        'MultiEditorRowProperties31
        '
        Me.MultiEditorRowProperties31.CellWidth = 56
        Me.MultiEditorRowProperties31.FieldName = "QKOD7"
        Me.MultiEditorRowProperties31.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties32
        '
        Me.MultiEditorRowProperties32.Caption = "Sýnýf 8"
        Me.MultiEditorRowProperties32.CellWidth = 134
        Me.MultiEditorRowProperties32.FieldName = "KOD8"
        Me.MultiEditorRowProperties32.ImageIndex = 0
        '
        'MultiEditorRowProperties33
        '
        Me.MultiEditorRowProperties33.CellWidth = 56
        Me.MultiEditorRowProperties33.FieldName = "QKOD8"
        Me.MultiEditorRowProperties33.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties34
        '
        Me.MultiEditorRowProperties34.Caption = "Sýnýf 9"
        Me.MultiEditorRowProperties34.CellWidth = 134
        Me.MultiEditorRowProperties34.FieldName = "KOD9"
        Me.MultiEditorRowProperties34.ImageIndex = 0
        '
        'MultiEditorRowProperties35
        '
        Me.MultiEditorRowProperties35.CellWidth = 56
        Me.MultiEditorRowProperties35.FieldName = "QKOD9"
        Me.MultiEditorRowProperties35.RowEdit = Me.sec_kriter
        '
        'MultiEditorRowProperties36
        '
        Me.MultiEditorRowProperties36.Caption = "Sýnýf 10"
        Me.MultiEditorRowProperties36.CellWidth = 134
        Me.MultiEditorRowProperties36.FieldName = "KOD10"
        Me.MultiEditorRowProperties36.ImageIndex = 0
        '
        'MultiEditorRowProperties37
        '
        Me.MultiEditorRowProperties37.CellWidth = 56
        Me.MultiEditorRowProperties37.FieldName = "QKOD10"
        Me.MultiEditorRowProperties37.RowEdit = Me.sec_kriter
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "STOKKODU"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "STOKADI"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "BARKOD"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "DEPO"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ILKTARIH"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "SONTARIH"
        Me.DataColumn7.DataType = GetType(Date)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "KRITER"
        Me.DataColumn8.DefaultValue = "[Boþ Liste]"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "FIYAT"
        Me.DataColumn9.DefaultValue = "1. Satýþ Fiyatý"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KOD1"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KOD2"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "KOD3"
        Me.DataColumn12.DefaultValue = ""
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KOD4"
        Me.DataColumn13.DefaultValue = ""
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "KOD5"
        Me.DataColumn14.DefaultValue = ""
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "SIRALAMA"
        Me.DataColumn15.DefaultValue = "STOKKODU"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "QIND"
        Me.DataColumn16.DefaultValue = "Eþittir"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "QSTOKKODU"
        Me.DataColumn17.DefaultValue = "Baþlar"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "QSTOKADI"
        Me.DataColumn18.DefaultValue = "Baþlar"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "QBARKOD"
        Me.DataColumn19.DefaultValue = "Baþlar"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "QDEPO"
        Me.DataColumn20.DefaultValue = "Eþittir"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "QILKTARIH"
        Me.DataColumn21.DefaultValue = "Aralýk"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "QSONTARIH"
        Me.DataColumn22.DefaultValue = "Aralýk"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "QKRITER"
        Me.DataColumn23.DefaultValue = "Eþittir"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "QFIYAT"
        Me.DataColumn24.DefaultValue = "Eþittir"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "QKOD1"
        Me.DataColumn25.DefaultValue = "Baþlar"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "QKOD2"
        Me.DataColumn26.DefaultValue = "Baþlar"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "QKOD3"
        Me.DataColumn27.DefaultValue = "Baþlar"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "QKOD4"
        Me.DataColumn28.DefaultValue = "Baþlar"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "QKOD5"
        Me.DataColumn29.DefaultValue = "Baþlar"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "QSIRALAMA"
        Me.DataColumn30.DefaultValue = "Eþittir"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "AKTIF"
        Me.DataColumn31.DataType = GetType(Boolean)
        Me.DataColumn31.DefaultValue = True
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "QAKTIF"
        Me.DataColumn32.DefaultValue = "Eþittir"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "KOD6"
        Me.DataColumn33.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "KOD7"
        Me.DataColumn34.DefaultValue = ""
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "KOD8"
        Me.DataColumn35.DefaultValue = ""
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "KOD9"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "KOD10"
        Me.DataColumn37.DefaultValue = ""
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "QKOD6"
        Me.DataColumn38.DefaultValue = "Baþlar"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "QKOD7"
        Me.DataColumn39.DefaultValue = "Baþlar"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "QKOD8"
        Me.DataColumn40.DefaultValue = "Baþlar"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "QKOD9"
        Me.DataColumn41.DefaultValue = "Baþlar"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "QKOD10"
        Me.DataColumn42.DefaultValue = "Baþlar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(408, 69)
        Me.PanelControl1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1033, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(358, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 385)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(408, 44)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(314, 10)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(234, 10)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 69)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(408, 316)
        Me.PanelControl3.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(404, 312)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.VGridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(398, 284)
        Me.XtraTabPage1.Text = "Ara"
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VGridControl1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VGridControl1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.VGridControl1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.VGridControl1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.VGridControl1.ContextMenu = Me.ContextMenu1
        Me.VGridControl1.CustomizationFormBounds = New System.Drawing.Rectangle(806, 385, 208, 255)
        Me.VGridControl1.DataMember = Nothing
        Me.VGridControl1.DataSource = Me.DataSet1
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.ImageList = Me.ImageList1
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.OptionsBehavior.ResizeHeaderPanel = False
        Me.VGridControl1.OptionsBehavior.ResizeRowHeaders = False
        Me.VGridControl1.OptionsBehavior.ResizeRowValues = False
        Me.VGridControl1.OptionsBehavior.SmartExpand = False
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_kriter, Me.sec_fiyat, Me.sec_stok_kriter, Me.sec_sirala})
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIND, Me.rowSTOKKODU, Me.rowSTOKADI, Me.rowBARKOD, Me.rowDEPO, Me.rowFIYAT, Me.rowKRITER, Me.rowTARIH, Me.rowKOD1, Me.rowKOD2, Me.rowKOD3, Me.rowKOD4, Me.rowKOD5, Me.rowKOD6, Me.rowKOD7, Me.rowKOD8, Me.rowKOD9, Me.rowKOD10, Me.rowSIRALAMA, Me.rowAKTIF})
        Me.VGridControl1.Size = New System.Drawing.Size(398, 284)
        Me.VGridControl1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem8, Me.MenuItem5, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem7, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem1.Text = "Tamam"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem8.Text = "Vazgeç"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "Kriteri Kaydet"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Text = "Kriteri Yükle"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Text = "Otomatik Yükle"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "Kriteri Sil"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "quiz.png")
        '
        'rowIND
        '
        Me.rowIND.Name = "rowIND"
        Me.rowIND.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties1, Me.MultiEditorRowProperties2})
        '
        'rowSTOKKODU
        '
        Me.rowSTOKKODU.Name = "rowSTOKKODU"
        Me.rowSTOKKODU.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties3, Me.MultiEditorRowProperties4})
        '
        'rowSTOKADI
        '
        Me.rowSTOKADI.Name = "rowSTOKADI"
        Me.rowSTOKADI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties5, Me.MultiEditorRowProperties6})
        '
        'rowBARKOD
        '
        Me.rowBARKOD.Name = "rowBARKOD"
        Me.rowBARKOD.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties7, Me.MultiEditorRowProperties8})
        '
        'rowDEPO
        '
        Me.rowDEPO.Name = "rowDEPO"
        Me.rowDEPO.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties9, Me.MultiEditorRowProperties10})
        '
        'rowFIYAT
        '
        Me.rowFIYAT.Name = "rowFIYAT"
        Me.rowFIYAT.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties11, Me.MultiEditorRowProperties12})
        '
        'rowKRITER
        '
        Me.rowKRITER.Name = "rowKRITER"
        Me.rowKRITER.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties13, Me.MultiEditorRowProperties14})
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties15, Me.MultiEditorRowProperties16, Me.MultiEditorRowProperties17})
        '
        'rowKOD1
        '
        Me.rowKOD1.Name = "rowKOD1"
        Me.rowKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties18, Me.MultiEditorRowProperties19})
        '
        'rowKOD2
        '
        Me.rowKOD2.Name = "rowKOD2"
        Me.rowKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties20, Me.MultiEditorRowProperties21})
        '
        'rowKOD3
        '
        Me.rowKOD3.Name = "rowKOD3"
        Me.rowKOD3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties22, Me.MultiEditorRowProperties23})
        '
        'rowKOD4
        '
        Me.rowKOD4.Name = "rowKOD4"
        Me.rowKOD4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties24, Me.MultiEditorRowProperties25})
        '
        'rowKOD5
        '
        Me.rowKOD5.Name = "rowKOD5"
        Me.rowKOD5.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties26, Me.MultiEditorRowProperties27})
        '
        'rowKOD6
        '
        Me.rowKOD6.Name = "rowKOD6"
        Me.rowKOD6.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties28, Me.MultiEditorRowProperties29})
        '
        'rowKOD7
        '
        Me.rowKOD7.Name = "rowKOD7"
        Me.rowKOD7.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties30, Me.MultiEditorRowProperties31})
        '
        'rowKOD8
        '
        Me.rowKOD8.Name = "rowKOD8"
        Me.rowKOD8.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties32, Me.MultiEditorRowProperties33})
        '
        'rowKOD9
        '
        Me.rowKOD9.Name = "rowKOD9"
        Me.rowKOD9.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties34, Me.MultiEditorRowProperties35})
        '
        'rowKOD10
        '
        Me.rowKOD10.Name = "rowKOD10"
        Me.rowKOD10.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties36, Me.MultiEditorRowProperties37})
        '
        'rowSIRALAMA
        '
        Me.rowSIRALAMA.Name = "rowSIRALAMA"
        Me.rowSIRALAMA.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties38, Me.MultiEditorRowProperties39})
        '
        'rowAKTIF
        '
        Me.rowAKTIF.Name = "rowAKTIF"
        Me.rowAKTIF.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties40, Me.MultiEditorRowProperties41})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.MemoEdit1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(398, 284)
        Me.XtraTabPage2.Text = "Sql"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.EditValue = ""
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(398, 284)
        Me.MemoEdit1.TabIndex = 0
        '
        'frm_stok_toplu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(408, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_toplu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kartlarý Ara"
        CType(Me.sec_kriter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_stok_kriter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sirala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Dim dr As DataRow
    Public ind
    Public stokkodu
    Public malincinsi
    Public barkod
    Public depo
    Public tarih1
    Public tarih2
    Public kriter
    Public kod1
    Public kod2
    Public kod3
    Public kod4
    Public kod5
    Public kod6
    Public kod7
    Public kod8
    Public kod9
    Public kod10
    Public sirala
    Public fiyat
    Public aktif
    Public qind
    Public qstokkodu
    Public qmalincinsi
    Public qbarkod
    Public qdepo
    Public qtarih1
    Public qtarih2
    Public qkriter
    Public qkod1
    Public qkod2
    Public qkod3
    Public qkod4
    Public qkod5
    Public qkod6
    Public qkod7
    Public qkod8
    Public qkod9
    Public qkod10
    Public qsirala
    Public qfiyat
    Public qaktif
    Private Sub frm_stok_toplu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        VGridControl1.Select()
        VGridControl1.FocusedRecordCellIndex() = 0
    End Sub
    Private Sub sorgu()
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            ind = dr("IND").ToString
            stokkodu = dr("STOKKODU").ToString
            malincinsi = dr("STOKADI").ToString
            barkod = dr("BARKOD").ToString
            depo = dr("DEPO").ToString
            kod1 = dr("KOD1").ToString
            kod2 = dr("KOD2").ToString
            kod3 = dr("KOD3").ToString
            kod4 = dr("KOD4").ToString
            kod5 = dr("KOD5").ToString
            kod6 = dr("KOD6").ToString
            kod7 = dr("KOD7").ToString
            kod8 = dr("KOD8").ToString
            kod9 = dr("KOD9").ToString
            kod10 = dr("KOD10").ToString
            tarih1 = dr("ILKTARIH").ToString
            tarih2 = dr("SONTARIH").ToString
            kriter = dr("KRITER").ToString
            fiyat = dr("FIYAT").ToString
            sirala = dr("SIRALAMA").ToString
            aktif = Math.Abs(CInt(dr("AKTIF"))).ToString
            qind = dr("QIND").ToString
            qstokkodu = dr("QSTOKKODU").ToString
            qmalincinsi = dr("QSTOKADI").ToString
            qbarkod = dr("QBARKOD").ToString
            qdepo = dr("QDEPO").ToString
            qkod1 = dr("QKOD1").ToString
            qkod2 = dr("QKOD2").ToString
            qkod3 = dr("QKOD3").ToString
            qkod4 = dr("QKOD4").ToString
            qkod5 = dr("QKOD5").ToString
            qkod6 = dr("QKOD6").ToString
            qkod7 = dr("QKOD7").ToString
            qkod8 = dr("QKOD8").ToString
            qkod9 = dr("QKOD9").ToString
            qkod10 = dr("QKOD10").ToString
            qtarih1 = dr("QILKTARIH").ToString
            qtarih2 = dr("QSONTARIH").ToString
            qkriter = dr("QKRITER").ToString
            qfiyat = dr("QFIYAT").ToString
            qsirala = dr("QSIRALAMA").ToString
            qaktif = dr("QAKTIF").ToString
        Next
        If depo = "" Then
            depo = 100
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub dataload()
        dr = DataSet1.Tables(0).NewRow
        dr("ILKTARIH") = Today
        dr("SONTARIH") = Today
        DataSet1.Tables(0).Rows.Add(dr)
        VGridControl1.DataSource = DataSet1.Tables(0)
        VGridControl1.DataMember = Nothing
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        sorgu()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.Close()
    End Sub
    Private Sub VGridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents rowKOD6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD10 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties10 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties11 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties12 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties13 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties14 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties15 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties16 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties17 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties18 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties19 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties20 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties21 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties22 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties23 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties24 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties25 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties26 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties27 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties38 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties39 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties40 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties41 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties28 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties29 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties30 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties31 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties32 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties33 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties34 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties35 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties36 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties37 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
End Class
