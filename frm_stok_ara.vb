Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_ara
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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowSTOKKODU As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowMALINCINSI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowBARKOD As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowMUADILBARKOD As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowBIRIM As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowDEPO As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD10 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSATISFIYATI1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSATISFIYATI2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSATISFIYATI3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowPB As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowISTIHBARAT As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents sec_depo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents rowAKTIF As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_ozelkod As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents rowADVANCED As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents rowKRITER As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
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
    Friend WithEvents MultiEditorRowProperties38 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties39 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties40 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties41 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties42 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties43 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties44 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties45 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties46 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties47 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties48 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties49 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties50 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties51 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties52 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties53 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents ýmageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents sec_kriter1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_secenek1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rowKDV As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowsKdvTipi As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents rowqsKdvTipi As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MultiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents RepositoryItemButtonEdit2 As Repository.RepositoryItemButtonEdit
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_ara))
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.ýmageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.sec_aciklama = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.sec_depo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_ozelkod = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.sec_kriter1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.sec_secenek1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.rowSTOKKODU = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.MultiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowMALINCINSI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowBARKOD = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowADVANCED = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties11 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowBIRIM = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties12 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties13 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowMUADILBARKOD = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties14 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties15 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties16 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.MultiEditorRowProperties17 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties18 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties19 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowSATISFIYATI1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties20 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties21 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowSATISFIYATI2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties22 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties23 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowSATISFIYATI3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties24 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties25 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowPB = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties26 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties27 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowISTIHBARAT = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties28 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties29 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties30 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties31 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties32 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties33 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties34 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties35 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties36 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties37 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties38 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties39 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties40 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties41 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties42 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties43 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKOD10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties44 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties45 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties46 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties47 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKRITER = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties48 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties49 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowAKTIF = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties50 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties51 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowKDV = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowsKdvTipi = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowqsKdvTipi = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowDEPO = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties52 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties53 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
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
        Me.DataSet2 = New System.Data.DataSet()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ýmageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_secenek1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn45, Me.DataColumn46, Me.DataColumn47})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "IND"
        Me.DataColumn45.DataType = GetType(Long)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "DEPOKODU"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "DEPOADI"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.PanelControl1, "PanelControl1")
        Me.PanelControl1.Name = "PanelControl1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        resources.ApplyResources(Me.PanelControl2, "PanelControl2")
        Me.PanelControl2.Name = "PanelControl2"
        '
        'SimpleButton2
        '
        resources.ApplyResources(Me.SimpleButton2, "SimpleButton2")
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Name = "SimpleButton2"
        '
        'SimpleButton1
        '
        resources.ApplyResources(Me.SimpleButton1, "SimpleButton1")
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Name = "SimpleButton1"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = CType(resources.GetObject("PanelControl3.Appearance.BackColor"), System.Drawing.Color)
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.VGridControl1)
        resources.ApplyResources(Me.PanelControl3, "PanelControl3")
        Me.PanelControl3.Name = "PanelControl3"
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.FocusedCell.BackColor = CType(resources.GetObject("VGridControl1.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.VGridControl1.Appearance.FocusedCell.BackColor2 = CType(resources.GetObject("VGridControl1.Appearance.FocusedCell.BackColor2"), System.Drawing.Color)
        Me.VGridControl1.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("VGridControl1.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.VGridControl1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.VGridControl1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.VGridControl1.ContextMenu = Me.ContextMenu1
        Me.VGridControl1.CustomizationFormBounds = New System.Drawing.Rectangle(547, 127, 208, 252)
        resources.ApplyResources(Me.VGridControl1, "VGridControl1")
        Me.VGridControl1.ImageList = Me.ýmageCollection1
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.OptionsBehavior.ResizeHeaderPanel = False
        Me.VGridControl1.OptionsBehavior.ResizeRowHeaders = False
        Me.VGridControl1.OptionsBehavior.ResizeRowValues = False
        Me.VGridControl1.OptionsBehavior.SmartExpand = False
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_aciklama, Me.sec_depo, Me.sec_ozelkod, Me.sec_kriter1, Me.sec_secenek1})
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowTARIH, Me.rowSTOKKODU, Me.rowMALINCINSI, Me.rowBARKOD, Me.rowADVANCED, Me.rowBIRIM, Me.rowMUADILBARKOD, Me.rowKOD1, Me.rowKOD2, Me.rowSATISFIYATI1, Me.rowSATISFIYATI2, Me.rowSATISFIYATI3, Me.rowPB, Me.rowISTIHBARAT, Me.rowKOD3, Me.rowKOD4, Me.rowKOD5, Me.rowKOD6, Me.rowKOD7, Me.rowKOD8, Me.rowKOD9, Me.rowKOD10, Me.rowIND, Me.rowKRITER, Me.rowAKTIF, Me.rowKDV, Me.rowDEPO})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem8, Me.MenuItem5, Me.MenuItem2, Me.MenuItem3, Me.MenuItem11, Me.MenuItem4, Me.MenuItem12, Me.MenuItem7, Me.MenuItem6, Me.MenuItem10, Me.MenuItem9})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        resources.ApplyResources(Me.MenuItem8, "MenuItem8")
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        resources.ApplyResources(Me.MenuItem5, "MenuItem5")
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        resources.ApplyResources(Me.MenuItem2, "MenuItem2")
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        resources.ApplyResources(Me.MenuItem3, "MenuItem3")
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 5
        resources.ApplyResources(Me.MenuItem11, "MenuItem11")
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 6
        resources.ApplyResources(Me.MenuItem4, "MenuItem4")
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 7
        resources.ApplyResources(Me.MenuItem12, "MenuItem12")
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        resources.ApplyResources(Me.MenuItem7, "MenuItem7")
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        resources.ApplyResources(Me.MenuItem6, "MenuItem6")
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        resources.ApplyResources(Me.MenuItem10, "MenuItem10")
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 11
        resources.ApplyResources(Me.MenuItem9, "MenuItem9")
        '
        'ýmageCollection1
        '
        Me.ýmageCollection1.ImageStream = CType(resources.GetObject("ýmageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'sec_aciklama
        '
        Me.sec_aciklama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("sec_aciklama.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.sec_aciklama.Name = "sec_aciklama"
        '
        'sec_depo
        '
        Me.sec_depo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("sec_depo.Columns"), resources.GetString("sec_depo.Columns1"), CType(resources.GetObject("sec_depo.Columns2"), Integer), CType(resources.GetObject("sec_depo.Columns3"), DevExpress.Utils.FormatType), resources.GetString("sec_depo.Columns4"), CType(resources.GetObject("sec_depo.Columns5"), Boolean), CType(resources.GetObject("sec_depo.Columns6"), DevExpress.Utils.HorzAlignment)), New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("sec_depo.Columns7"), resources.GetString("sec_depo.Columns8"), CType(resources.GetObject("sec_depo.Columns9"), Integer), CType(resources.GetObject("sec_depo.Columns10"), DevExpress.Utils.FormatType), resources.GetString("sec_depo.Columns11"), CType(resources.GetObject("sec_depo.Columns12"), Boolean), CType(resources.GetObject("sec_depo.Columns13"), DevExpress.Utils.HorzAlignment))})
        Me.sec_depo.DataSource = Me.DataTable2
        Me.sec_depo.DisplayMember = "DEPOADI"
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.ValueMember = "IND"
        '
        'sec_ozelkod
        '
        Me.sec_ozelkod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ozelkod.Name = "sec_ozelkod"
        '
        'sec_kriter1
        '
        Me.sec_kriter1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("sec_kriter1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.sec_kriter1.Items.AddRange(New Object() {resources.GetString("sec_kriter1.Items"), resources.GetString("sec_kriter1.Items1"), resources.GetString("sec_kriter1.Items2"), resources.GetString("sec_kriter1.Items3"), resources.GetString("sec_kriter1.Items4"), resources.GetString("sec_kriter1.Items5"), resources.GetString("sec_kriter1.Items6"), resources.GetString("sec_kriter1.Items7"), resources.GetString("sec_kriter1.Items8"), resources.GetString("sec_kriter1.Items9")})
        Me.sec_kriter1.Name = "sec_kriter1"
        Me.sec_kriter1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'sec_secenek1
        '
        Me.sec_secenek1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("sec_secenek1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.sec_secenek1.Items.AddRange(New Object() {resources.GetString("sec_secenek1.Items"), resources.GetString("sec_secenek1.Items1"), resources.GetString("sec_secenek1.Items2"), resources.GetString("sec_secenek1.Items3")})
        Me.sec_secenek1.Name = "sec_secenek1"
        Me.sec_secenek1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'rowTARIH
        '
        resources.ApplyResources(Me.rowTARIH, "rowTARIH")
        Me.rowTARIH.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties1, Me.MultiEditorRowProperties2, Me.MultiEditorRowProperties3})
        '
        'MultiEditorRowProperties1
        '
        resources.ApplyResources(Me.MultiEditorRowProperties1, "MultiEditorRowProperties1")
        Me.MultiEditorRowProperties1.FieldName = "TARIH1"
        '
        'MultiEditorRowProperties2
        '
        resources.ApplyResources(Me.MultiEditorRowProperties2, "MultiEditorRowProperties2")
        Me.MultiEditorRowProperties2.FieldName = "TARIH2"
        '
        'MultiEditorRowProperties3
        '
        resources.ApplyResources(Me.MultiEditorRowProperties3, "MultiEditorRowProperties3")
        Me.MultiEditorRowProperties3.FieldName = "QTARIH"
        Me.MultiEditorRowProperties3.RowEdit = Me.RepositoryItemComboBox1
        '
        'RepositoryItemComboBox1
        '
        resources.ApplyResources(Me.RepositoryItemComboBox1, "RepositoryItemComboBox1")
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {resources.GetString("RepositoryItemComboBox1.Items"), resources.GetString("RepositoryItemComboBox1.Items1"), resources.GetString("RepositoryItemComboBox1.Items2"), resources.GetString("RepositoryItemComboBox1.Items3"), resources.GetString("RepositoryItemComboBox1.Items4"), resources.GetString("RepositoryItemComboBox1.Items5"), resources.GetString("RepositoryItemComboBox1.Items6"), resources.GetString("RepositoryItemComboBox1.Items7"), resources.GetString("RepositoryItemComboBox1.Items8"), resources.GetString("RepositoryItemComboBox1.Items9")})
        Me.RepositoryItemComboBox1.LookAndFeel.SkinName = "VS2010"
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'rowSTOKKODU
        '
        resources.ApplyResources(Me.rowSTOKKODU, "rowSTOKKODU")
        Me.rowSTOKKODU.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties4, Me.MultiEditorRowProperties5})
        '
        'MultiEditorRowProperties4
        '
        resources.ApplyResources(Me.MultiEditorRowProperties4, "MultiEditorRowProperties4")
        Me.MultiEditorRowProperties4.FieldName = "STOKKODU"
        Me.MultiEditorRowProperties4.RowEdit = Me.RepositoryItemButtonEdit2
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.LookAndFeel.SkinName = "VS2010"
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'MultiEditorRowProperties5
        '
        resources.ApplyResources(Me.MultiEditorRowProperties5, "MultiEditorRowProperties5")
        Me.MultiEditorRowProperties5.FieldName = "QSTOKKODU"
        Me.MultiEditorRowProperties5.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowMALINCINSI
        '
        resources.ApplyResources(Me.rowMALINCINSI, "rowMALINCINSI")
        Me.rowMALINCINSI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties6, Me.MultiEditorRowProperties7})
        '
        'MultiEditorRowProperties6
        '
        resources.ApplyResources(Me.MultiEditorRowProperties6, "MultiEditorRowProperties6")
        Me.MultiEditorRowProperties6.FieldName = "MALINCINSI"
        Me.MultiEditorRowProperties6.RowEdit = Me.RepositoryItemButtonEdit2
        '
        'MultiEditorRowProperties7
        '
        resources.ApplyResources(Me.MultiEditorRowProperties7, "MultiEditorRowProperties7")
        Me.MultiEditorRowProperties7.FieldName = "QMALINCINSI"
        Me.MultiEditorRowProperties7.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowBARKOD
        '
        resources.ApplyResources(Me.rowBARKOD, "rowBARKOD")
        Me.rowBARKOD.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties8, Me.MultiEditorRowProperties9})
        '
        'MultiEditorRowProperties8
        '
        resources.ApplyResources(Me.MultiEditorRowProperties8, "MultiEditorRowProperties8")
        Me.MultiEditorRowProperties8.FieldName = "BARKOD"
        Me.MultiEditorRowProperties8.RowEdit = Me.RepositoryItemButtonEdit2
        '
        'MultiEditorRowProperties9
        '
        resources.ApplyResources(Me.MultiEditorRowProperties9, "MultiEditorRowProperties9")
        Me.MultiEditorRowProperties9.FieldName = "QBARKOD"
        Me.MultiEditorRowProperties9.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowADVANCED
        '
        resources.ApplyResources(Me.rowADVANCED, "rowADVANCED")
        Me.rowADVANCED.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties10, Me.MultiEditorRowProperties11})
        '
        'MultiEditorRowProperties10
        '
        resources.ApplyResources(Me.MultiEditorRowProperties10, "MultiEditorRowProperties10")
        Me.MultiEditorRowProperties10.FieldName = "ADVANCE"
        Me.MultiEditorRowProperties10.RowEdit = Me.RepositoryItemComboBox3
        '
        'RepositoryItemComboBox3
        '
        resources.ApplyResources(Me.RepositoryItemComboBox3, "RepositoryItemComboBox3")
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemComboBox3.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemComboBox3.LookAndFeel.SkinName = "VS2010"
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'MultiEditorRowProperties11
        '
        resources.ApplyResources(Me.MultiEditorRowProperties11, "MultiEditorRowProperties11")
        Me.MultiEditorRowProperties11.FieldName = "QADVANCE"
        Me.MultiEditorRowProperties11.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowBIRIM
        '
        resources.ApplyResources(Me.rowBIRIM, "rowBIRIM")
        Me.rowBIRIM.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties12, Me.MultiEditorRowProperties13})
        '
        'MultiEditorRowProperties12
        '
        resources.ApplyResources(Me.MultiEditorRowProperties12, "MultiEditorRowProperties12")
        Me.MultiEditorRowProperties12.FieldName = "BIRIM"
        '
        'MultiEditorRowProperties13
        '
        resources.ApplyResources(Me.MultiEditorRowProperties13, "MultiEditorRowProperties13")
        Me.MultiEditorRowProperties13.FieldName = "QBIRIM"
        Me.MultiEditorRowProperties13.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowMUADILBARKOD
        '
        resources.ApplyResources(Me.rowMUADILBARKOD, "rowMUADILBARKOD")
        Me.rowMUADILBARKOD.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties14, Me.MultiEditorRowProperties15})
        '
        'MultiEditorRowProperties14
        '
        resources.ApplyResources(Me.MultiEditorRowProperties14, "MultiEditorRowProperties14")
        Me.MultiEditorRowProperties14.FieldName = "MUADILBARKOD"
        '
        'MultiEditorRowProperties15
        '
        resources.ApplyResources(Me.MultiEditorRowProperties15, "MultiEditorRowProperties15")
        Me.MultiEditorRowProperties15.FieldName = "QMUADILBARKOD"
        Me.MultiEditorRowProperties15.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD1
        '
        resources.ApplyResources(Me.rowKOD1, "rowKOD1")
        Me.rowKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties16, Me.MultiEditorRowProperties17})
        '
        'MultiEditorRowProperties16
        '
        resources.ApplyResources(Me.MultiEditorRowProperties16, "MultiEditorRowProperties16")
        Me.MultiEditorRowProperties16.FieldName = "KOD1"
        Me.MultiEditorRowProperties16.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'RepositoryItemButtonEdit1
        '
        resources.ApplyResources(Me.RepositoryItemButtonEdit1, "RepositoryItemButtonEdit1")
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.LookAndFeel.SkinName = "VS2010"
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'MultiEditorRowProperties17
        '
        resources.ApplyResources(Me.MultiEditorRowProperties17, "MultiEditorRowProperties17")
        Me.MultiEditorRowProperties17.FieldName = "QKOD1"
        Me.MultiEditorRowProperties17.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD2
        '
        resources.ApplyResources(Me.rowKOD2, "rowKOD2")
        Me.rowKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties18, Me.MultiEditorRowProperties19})
        '
        'MultiEditorRowProperties18
        '
        resources.ApplyResources(Me.MultiEditorRowProperties18, "MultiEditorRowProperties18")
        Me.MultiEditorRowProperties18.FieldName = "KOD2"
        Me.MultiEditorRowProperties18.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties19
        '
        resources.ApplyResources(Me.MultiEditorRowProperties19, "MultiEditorRowProperties19")
        Me.MultiEditorRowProperties19.FieldName = "QKOD2"
        Me.MultiEditorRowProperties19.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowSATISFIYATI1
        '
        resources.ApplyResources(Me.rowSATISFIYATI1, "rowSATISFIYATI1")
        Me.rowSATISFIYATI1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties20, Me.MultiEditorRowProperties21})
        '
        'MultiEditorRowProperties20
        '
        resources.ApplyResources(Me.MultiEditorRowProperties20, "MultiEditorRowProperties20")
        Me.MultiEditorRowProperties20.FieldName = "SATISFIYATI1"
        '
        'MultiEditorRowProperties21
        '
        resources.ApplyResources(Me.MultiEditorRowProperties21, "MultiEditorRowProperties21")
        Me.MultiEditorRowProperties21.FieldName = "QSATISFIYATI1"
        Me.MultiEditorRowProperties21.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowSATISFIYATI2
        '
        resources.ApplyResources(Me.rowSATISFIYATI2, "rowSATISFIYATI2")
        Me.rowSATISFIYATI2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties22, Me.MultiEditorRowProperties23})
        '
        'MultiEditorRowProperties22
        '
        resources.ApplyResources(Me.MultiEditorRowProperties22, "MultiEditorRowProperties22")
        Me.MultiEditorRowProperties22.FieldName = "SATISFIYATI2"
        '
        'MultiEditorRowProperties23
        '
        resources.ApplyResources(Me.MultiEditorRowProperties23, "MultiEditorRowProperties23")
        Me.MultiEditorRowProperties23.FieldName = "QSATISFIYATI2"
        Me.MultiEditorRowProperties23.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowSATISFIYATI3
        '
        resources.ApplyResources(Me.rowSATISFIYATI3, "rowSATISFIYATI3")
        Me.rowSATISFIYATI3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties24, Me.MultiEditorRowProperties25})
        '
        'MultiEditorRowProperties24
        '
        resources.ApplyResources(Me.MultiEditorRowProperties24, "MultiEditorRowProperties24")
        Me.MultiEditorRowProperties24.FieldName = "SATISFIYATI3"
        '
        'MultiEditorRowProperties25
        '
        resources.ApplyResources(Me.MultiEditorRowProperties25, "MultiEditorRowProperties25")
        Me.MultiEditorRowProperties25.FieldName = "QSATISFIYATI3"
        Me.MultiEditorRowProperties25.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowPB
        '
        resources.ApplyResources(Me.rowPB, "rowPB")
        Me.rowPB.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties26, Me.MultiEditorRowProperties27})
        '
        'MultiEditorRowProperties26
        '
        resources.ApplyResources(Me.MultiEditorRowProperties26, "MultiEditorRowProperties26")
        Me.MultiEditorRowProperties26.FieldName = "PB"
        '
        'MultiEditorRowProperties27
        '
        resources.ApplyResources(Me.MultiEditorRowProperties27, "MultiEditorRowProperties27")
        Me.MultiEditorRowProperties27.FieldName = "QPB"
        Me.MultiEditorRowProperties27.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowISTIHBARAT
        '
        resources.ApplyResources(Me.rowISTIHBARAT, "rowISTIHBARAT")
        Me.rowISTIHBARAT.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties28, Me.MultiEditorRowProperties29})
        '
        'MultiEditorRowProperties28
        '
        resources.ApplyResources(Me.MultiEditorRowProperties28, "MultiEditorRowProperties28")
        Me.MultiEditorRowProperties28.FieldName = "ISTIHBARAT"
        '
        'MultiEditorRowProperties29
        '
        Me.MultiEditorRowProperties29.FieldName = "QISTIHBARAT"
        Me.MultiEditorRowProperties29.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD3
        '
        resources.ApplyResources(Me.rowKOD3, "rowKOD3")
        Me.rowKOD3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties30, Me.MultiEditorRowProperties31})
        '
        'MultiEditorRowProperties30
        '
        resources.ApplyResources(Me.MultiEditorRowProperties30, "MultiEditorRowProperties30")
        Me.MultiEditorRowProperties30.FieldName = "KOD3"
        Me.MultiEditorRowProperties30.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties31
        '
        resources.ApplyResources(Me.MultiEditorRowProperties31, "MultiEditorRowProperties31")
        Me.MultiEditorRowProperties31.FieldName = "QKOD3"
        Me.MultiEditorRowProperties31.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD4
        '
        resources.ApplyResources(Me.rowKOD4, "rowKOD4")
        Me.rowKOD4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties32, Me.MultiEditorRowProperties33})
        '
        'MultiEditorRowProperties32
        '
        resources.ApplyResources(Me.MultiEditorRowProperties32, "MultiEditorRowProperties32")
        Me.MultiEditorRowProperties32.FieldName = "KOD4"
        Me.MultiEditorRowProperties32.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties33
        '
        resources.ApplyResources(Me.MultiEditorRowProperties33, "MultiEditorRowProperties33")
        Me.MultiEditorRowProperties33.FieldName = "QKOD4"
        Me.MultiEditorRowProperties33.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD5
        '
        resources.ApplyResources(Me.rowKOD5, "rowKOD5")
        Me.rowKOD5.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties34, Me.MultiEditorRowProperties35})
        '
        'MultiEditorRowProperties34
        '
        resources.ApplyResources(Me.MultiEditorRowProperties34, "MultiEditorRowProperties34")
        Me.MultiEditorRowProperties34.FieldName = "KOD5"
        Me.MultiEditorRowProperties34.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties35
        '
        resources.ApplyResources(Me.MultiEditorRowProperties35, "MultiEditorRowProperties35")
        Me.MultiEditorRowProperties35.FieldName = "QKOD5"
        Me.MultiEditorRowProperties35.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD6
        '
        resources.ApplyResources(Me.rowKOD6, "rowKOD6")
        Me.rowKOD6.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties36, Me.MultiEditorRowProperties37})
        '
        'MultiEditorRowProperties36
        '
        resources.ApplyResources(Me.MultiEditorRowProperties36, "MultiEditorRowProperties36")
        Me.MultiEditorRowProperties36.FieldName = "KOD6"
        Me.MultiEditorRowProperties36.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties37
        '
        resources.ApplyResources(Me.MultiEditorRowProperties37, "MultiEditorRowProperties37")
        Me.MultiEditorRowProperties37.FieldName = "QKOD6"
        Me.MultiEditorRowProperties37.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD7
        '
        resources.ApplyResources(Me.rowKOD7, "rowKOD7")
        Me.rowKOD7.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties38, Me.MultiEditorRowProperties39})
        '
        'MultiEditorRowProperties38
        '
        resources.ApplyResources(Me.MultiEditorRowProperties38, "MultiEditorRowProperties38")
        Me.MultiEditorRowProperties38.FieldName = "KOD7"
        Me.MultiEditorRowProperties38.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties39
        '
        resources.ApplyResources(Me.MultiEditorRowProperties39, "MultiEditorRowProperties39")
        Me.MultiEditorRowProperties39.FieldName = "QKOD7"
        Me.MultiEditorRowProperties39.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD8
        '
        resources.ApplyResources(Me.rowKOD8, "rowKOD8")
        Me.rowKOD8.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties40, Me.MultiEditorRowProperties41})
        '
        'MultiEditorRowProperties40
        '
        resources.ApplyResources(Me.MultiEditorRowProperties40, "MultiEditorRowProperties40")
        Me.MultiEditorRowProperties40.FieldName = "KOD8"
        Me.MultiEditorRowProperties40.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties41
        '
        resources.ApplyResources(Me.MultiEditorRowProperties41, "MultiEditorRowProperties41")
        Me.MultiEditorRowProperties41.FieldName = "QKOD8"
        Me.MultiEditorRowProperties41.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD9
        '
        resources.ApplyResources(Me.rowKOD9, "rowKOD9")
        Me.rowKOD9.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties42, Me.MultiEditorRowProperties43})
        '
        'MultiEditorRowProperties42
        '
        resources.ApplyResources(Me.MultiEditorRowProperties42, "MultiEditorRowProperties42")
        Me.MultiEditorRowProperties42.FieldName = "KOD9"
        Me.MultiEditorRowProperties42.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties43
        '
        resources.ApplyResources(Me.MultiEditorRowProperties43, "MultiEditorRowProperties43")
        Me.MultiEditorRowProperties43.FieldName = "QKOD9"
        Me.MultiEditorRowProperties43.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKOD10
        '
        resources.ApplyResources(Me.rowKOD10, "rowKOD10")
        Me.rowKOD10.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties44, Me.MultiEditorRowProperties45})
        '
        'MultiEditorRowProperties44
        '
        resources.ApplyResources(Me.MultiEditorRowProperties44, "MultiEditorRowProperties44")
        Me.MultiEditorRowProperties44.FieldName = "KOD10"
        Me.MultiEditorRowProperties44.RowEdit = Me.RepositoryItemButtonEdit1
        '
        'MultiEditorRowProperties45
        '
        resources.ApplyResources(Me.MultiEditorRowProperties45, "MultiEditorRowProperties45")
        Me.MultiEditorRowProperties45.FieldName = "QKOD10"
        Me.MultiEditorRowProperties45.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowIND
        '
        resources.ApplyResources(Me.rowIND, "rowIND")
        Me.rowIND.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties46, Me.MultiEditorRowProperties47})
        '
        'MultiEditorRowProperties46
        '
        resources.ApplyResources(Me.MultiEditorRowProperties46, "MultiEditorRowProperties46")
        Me.MultiEditorRowProperties46.FieldName = "IND"
        '
        'MultiEditorRowProperties47
        '
        resources.ApplyResources(Me.MultiEditorRowProperties47, "MultiEditorRowProperties47")
        Me.MultiEditorRowProperties47.FieldName = "QIND"
        Me.MultiEditorRowProperties47.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKRITER
        '
        resources.ApplyResources(Me.rowKRITER, "rowKRITER")
        Me.rowKRITER.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties48, Me.MultiEditorRowProperties49})
        '
        'MultiEditorRowProperties48
        '
        resources.ApplyResources(Me.MultiEditorRowProperties48, "MultiEditorRowProperties48")
        Me.MultiEditorRowProperties48.FieldName = "KRITER"
        Me.MultiEditorRowProperties48.RowEdit = Me.RepositoryItemComboBox2
        '
        'RepositoryItemComboBox2
        '
        resources.ApplyResources(Me.RepositoryItemComboBox2, "RepositoryItemComboBox2")
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {resources.GetString("RepositoryItemComboBox2.Items"), resources.GetString("RepositoryItemComboBox2.Items1"), resources.GetString("RepositoryItemComboBox2.Items2"), resources.GetString("RepositoryItemComboBox2.Items3")})
        Me.RepositoryItemComboBox2.LookAndFeel.SkinName = "VS2010"
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties49
        '
        resources.ApplyResources(Me.MultiEditorRowProperties49, "MultiEditorRowProperties49")
        Me.MultiEditorRowProperties49.FieldName = "QKRITER"
        Me.MultiEditorRowProperties49.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowAKTIF
        '
        resources.ApplyResources(Me.rowAKTIF, "rowAKTIF")
        Me.rowAKTIF.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties50, Me.MultiEditorRowProperties51})
        '
        'MultiEditorRowProperties50
        '
        resources.ApplyResources(Me.MultiEditorRowProperties50, "MultiEditorRowProperties50")
        Me.MultiEditorRowProperties50.FieldName = "AKTIF"
        '
        'MultiEditorRowProperties51
        '
        resources.ApplyResources(Me.MultiEditorRowProperties51, "MultiEditorRowProperties51")
        Me.MultiEditorRowProperties51.FieldName = "QAKTIF"
        Me.MultiEditorRowProperties51.RowEdit = Me.RepositoryItemComboBox1
        '
        'rowKDV
        '
        resources.ApplyResources(Me.rowKDV, "rowKDV")
        Me.rowKDV.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.rowsKdvTipi, Me.rowqsKdvTipi})
        '
        'rowsKdvTipi
        '
        resources.ApplyResources(Me.rowsKdvTipi, "rowsKdvTipi")
        Me.rowsKdvTipi.FieldName = "sKdvTipi"
        '
        'rowqsKdvTipi
        '
        resources.ApplyResources(Me.rowqsKdvTipi, "rowqsKdvTipi")
        Me.rowqsKdvTipi.FieldName = "qsKdvTipi"
        '
        'rowDEPO
        '
        resources.ApplyResources(Me.rowDEPO, "rowDEPO")
        Me.rowDEPO.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties52, Me.MultiEditorRowProperties53})
        '
        'MultiEditorRowProperties52
        '
        resources.ApplyResources(Me.MultiEditorRowProperties52, "MultiEditorRowProperties52")
        Me.MultiEditorRowProperties52.FieldName = "DEPO"
        '
        'MultiEditorRowProperties53
        '
        resources.ApplyResources(Me.MultiEditorRowProperties53, "MultiEditorRowProperties53")
        Me.MultiEditorRowProperties53.FieldName = "QDEPO"
        Me.MultiEditorRowProperties53.RowEdit = Me.RepositoryItemComboBox1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58})
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
        Me.DataColumn3.ColumnName = "MALINCINSI"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "BARKOD"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "MUADILBARKOD"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "DEPO"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "KOD1"
        Me.DataColumn7.DefaultValue = ""
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "KOD2"
        Me.DataColumn8.DefaultValue = ""
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "KOD3"
        Me.DataColumn9.DefaultValue = ""
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KOD4"
        Me.DataColumn10.DefaultValue = ""
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KOD5"
        Me.DataColumn11.DefaultValue = ""
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "BIRIM"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "SATISFIYATI1"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "SATISFIYATI2"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "SATISFIYATI3"
        Me.DataColumn15.DataType = GetType(Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "PB"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KOD6"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "KOD7"
        Me.DataColumn18.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "KOD8"
        Me.DataColumn19.DefaultValue = ""
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "KOD9"
        Me.DataColumn20.DefaultValue = ""
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "KOD10"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ISTIHBARAT"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "QIND"
        Me.DataColumn23.DefaultValue = "Eþittir"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "QSTOKKODU"
        Me.DataColumn24.DefaultValue = "Ýçerir"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "QMALINCINSI"
        Me.DataColumn25.DefaultValue = "Ýçerir"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "QBARKOD"
        Me.DataColumn26.DefaultValue = "Baþlar"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "QMUADILBARKOD"
        Me.DataColumn27.DefaultValue = "Baþlar"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "QDEPO"
        Me.DataColumn28.DefaultValue = "Eþittir"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "QKOD1"
        Me.DataColumn29.DefaultValue = "Baþlar"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "QKOD2"
        Me.DataColumn30.DefaultValue = "Baþlar"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "QKOD3"
        Me.DataColumn31.DefaultValue = "Baþlar"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "QKOD4"
        Me.DataColumn32.DefaultValue = "Baþlar"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "QKOD5"
        Me.DataColumn33.DefaultValue = "Baþlar"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "QKOD6"
        Me.DataColumn34.DefaultValue = "Baþlar"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "QKOD7"
        Me.DataColumn35.DefaultValue = "Baþlar"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "QKOD8"
        Me.DataColumn36.DefaultValue = "Baþlar"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "QKOD9"
        Me.DataColumn37.DefaultValue = "Baþlar"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "QKOD10"
        Me.DataColumn38.DefaultValue = "Baþlar"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "QSATISFIYATI1"
        Me.DataColumn39.DefaultValue = "Eþittir"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "QSATISFIYATI2"
        Me.DataColumn40.DefaultValue = "Eþittir"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "QSATISFIYATI3"
        Me.DataColumn41.DefaultValue = "Eþittir"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "QPB"
        Me.DataColumn42.DefaultValue = "Eþittir"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "QISTIHBARAT"
        Me.DataColumn43.DefaultValue = "Ýçerir"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "QBIRIM"
        Me.DataColumn44.DefaultValue = "Eþittir"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "AKTIF"
        Me.DataColumn48.DataType = GetType(Boolean)
        Me.DataColumn48.DefaultValue = True
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "QAKTIF"
        Me.DataColumn49.DefaultValue = "Eþittir"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "ADVANCE"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "QADVANCE"
        Me.DataColumn51.DefaultValue = "Ýçerir"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "KRITER"
        Me.DataColumn52.DefaultValue = "[Tümü]"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "QKRITER"
        Me.DataColumn53.DefaultValue = "Eþittir"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "TARIH1"
        Me.DataColumn54.DataType = GetType(Date)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "TARIH2"
        Me.DataColumn55.DataType = GetType(Date)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "QTARIH"
        Me.DataColumn56.DefaultValue = "Eþittir"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sKdvTipi"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "qsKdvTipi"
        Me.DataColumn58.DefaultValue = "Baþlar"
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'frm_stok_ara
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_stok_ara"
        Me.ShowInTaskbar = False
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ýmageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_secenek1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim dr As DataRow
    Dim kriter
    Public connection
    Public firmano
    Public donemno
    Public kullanici
    Public ind
    Public stokkodu
    Public malincinsi
    Public barkod
    Public muadilbarkod
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
    Public istihbarat
    Public birim
    Public depo
    Public satisfiyati1
    Public satisfiyati2
    Public satisfiyati3
    Public aktif
    Public gelismis
    Public secenek
    Public tarih1
    Public tarih2
    Public sKdvTipi
    Public qind
    Public qstokkodu
    Public qmalincinsi
    Public qbarkod
    Public qmuadilbarkod
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
    Public qistihbarat
    Public qbirim
    Public qdepo
    Public qsatisfiyati1
    Public qsatisfiyati2
    Public qsatisfiyati3
    Public qaktif
    Public qResim
    Public qgelismis
    Public qsecenek
    Public qtarih
    Public qsKdvTipi
    Public mevcut = 1
    Public yeni
    Public x
    Private Sub frm_stok_ara_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    End Sub
    Private Sub frm_stok_ara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        VGridControl1.Select()
        VGridControl1.FocusedRecordCellIndex() = 0
        Dim row = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("ActiveRow")
        Dim auto_boyut = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("auto_boyut")
        Try
            Dim width_s = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("width").ToString
            Dim heigh_s = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("heigh").ToString
            Dim x As Integer = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("x")
            Dim y As Integer = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("y")
            If width_s.ToString <> "" Then
                If auto_boyut = True Then
                    MenuItem12.Checked = True
                    Try
                        Me.Size = New System.Drawing.Size(width_s, heigh_s)
                        Me.Location = New System.Drawing.Point(x, y)
                    Catch ex As Exception
                    End Try
                ElseIf auto_boyut = False Then
                    MenuItem12.Checked = False
                End If
            End If
            width_s = Nothing
            heigh_s = Nothing
            x = Nothing
            y = Nothing
        Catch ex As Exception
        End Try
        If row <> "" Then
            If row.ToString = "rowSTOKKODU" Then
                VGridControl1.FocusedRow = rowSTOKKODU
            ElseIf row.ToString = "rowMALINCINSI" Then
                VGridControl1.FocusedRow = rowMALINCINSI
            ElseIf row.ToString = "rowBARKOD" Then
                VGridControl1.FocusedRow = rowBARKOD
            ElseIf row.ToString = "rowDEPO" Then
                VGridControl1.FocusedRow = rowDEPO
            ElseIf row.ToString = "rowMUADILBARKOD" Then
                VGridControl1.FocusedRow = rowMUADILBARKOD
            ElseIf row.ToString = "rowKOD1" Then
                VGridControl1.FocusedRow = rowKOD1
            ElseIf row.ToString = "rowKOD2" Then
                VGridControl1.FocusedRow = rowKOD2
            ElseIf row.ToString = "rowKOD3" Then
                VGridControl1.FocusedRow = rowKOD3
            ElseIf row.ToString = "rowKOD4" Then
                VGridControl1.FocusedRow = rowKOD4
            ElseIf row.ToString = "rowKOD5" Then
                VGridControl1.FocusedRow = rowKOD5
            ElseIf row.ToString = "rowKOD6" Then
                VGridControl1.FocusedRow = rowKOD6
            ElseIf row.ToString = "rowKOD7" Then
                VGridControl1.FocusedRow = rowKOD7
            ElseIf row.ToString = "rowKOD8" Then
                VGridControl1.FocusedRow = rowKOD8
            ElseIf row.ToString = "rowKOD9" Then
                VGridControl1.FocusedRow = rowKOD9
            ElseIf row.ToString = "rowKOD10" Then
                VGridControl1.FocusedRow = rowKOD10
            ElseIf row.ToString = "rowBIRIM" Then
                VGridControl1.FocusedRow = rowBIRIM
            ElseIf row.ToString = "rowISTIHBARAT" Then
                VGridControl1.FocusedRow = rowISTIHBARAT
            ElseIf row.ToString = "rowIND" Then
                VGridControl1.FocusedRow = rowIND
            ElseIf row.ToString = "rowSATISFIYATI1" Then
                VGridControl1.FocusedRow = rowSATISFIYATI1
            ElseIf row.ToString = "rowSATISFIYATI2" Then
                VGridControl1.FocusedRow = rowSATISFIYATI2
            ElseIf row.ToString = "rowSATISFIYATI3" Then
                VGridControl1.FocusedRow = rowSATISFIYATI3
            ElseIf row.ToString = "rowAKTIF" Then
                VGridControl1.FocusedRow = rowAKTIF
            ElseIf row.ToString = "rowADVANCED" Then
                VGridControl1.FocusedRow = rowADVANCED
            ElseIf row.ToString = "rowKRITER" Then
                VGridControl1.FocusedRow = rowKRITER
            ElseIf row.ToString = "rowKDV" Then
                VGridControl1.FocusedRow = rowKDV
            End If
        End If
        Dim auto_save = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("auto_save")
        Dim auto_load = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("auto_load")
        If auto_load = True Then
            MenuItem4.Checked = True
            Try
                kriter_yukle()
            Catch ex As Exception
            End Try
        ElseIf auto_load = False Then
            MenuItem4.Checked = False
        End If
        If auto_save = True Then
            MenuItem11.Checked = True
        Else
            MenuItem11.Checked = False
        End If
        auto_save = Nothing
        auto_load = Nothing
        dataload_depo()
    End Sub
    Private Sub gorunum_yukle()
        Dim row
        For Each row In VGridControl1.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
    End Sub
    Private Sub dataload_depo()
        'DataSet2 = sorgu_depo(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama FROM tbDepo"))
        'sec_para.Properties.DataSource = DataSet2.Tables(0)
        'sec_depo.DataSource = DataSet2.Tables(0)
    End Sub
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
    Private Function sorgu_depo(ByVal query As String) As DataSet
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
    Private Sub sorgu()
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            ind = dr("IND").ToString
            stokkodu = Trim(dr("STOKKODU").ToString)
            malincinsi = Trim(dr("MALINCINSI").ToString)
            barkod = Trim(dr("BARKOD").ToString)
            muadilbarkod = Trim(dr("MUADILBARKOD").ToString)
            kod1 = dr("KOD1").ToString
            kod2 = Trim(dr("KOD2").ToString)
            kod3 = Trim(dr("KOD3").ToString)
            kod4 = Trim(dr("KOD4").ToString)
            kod5 = Trim(dr("KOD5").ToString)
            kod6 = Trim(dr("KOD6").ToString)
            kod7 = Trim(dr("KOD7").ToString)
            kod8 = Trim(dr("KOD8").ToString)
            kod9 = Trim(dr("KOD9").ToString)
            kod10 = Trim(dr("KOD10").ToString)
            istihbarat = Trim(dr("ISTIHBARAT").ToString)
            birim = Trim(dr("BIRIM").ToString)
            depo = dr("DEPO").ToString
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("ARA").SetValue("Depo", dr("DEPO").ToString)
            satisfiyati1 = dr("SATISFIYATI1").ToString
            satisfiyati2 = dr("SATISFIYATI2").ToString
            satisfiyati3 = dr("SATISFIYATI3").ToString
            aktif = Math.Abs(CInt(dr("AKTIF"))).ToString
            gelismis = dr("ADVANCE").ToString
            secenek = dr("KRITER").ToString
            tarih1 = dr("TARIH1").ToString
            tarih2 = dr("TARIH2").ToString
            sKdvTipi = dr("sKdvTipi").ToString
            qind = dr("QIND").ToString
            qstokkodu = dr("QSTOKKODU").ToString
            qmalincinsi = dr("QMALINCINSI").ToString
            qbarkod = dr("QBARKOD").ToString
            qmuadilbarkod = dr("QMUADILBARKOD").ToString
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
            qistihbarat = dr("QISTIHBARAT").ToString
            qbirim = dr("QBIRIM").ToString
            qdepo = dr("QDEPO").ToString
            qsatisfiyati1 = dr("QSATISFIYATI1").ToString
            qsatisfiyati2 = dr("QSATISFIYATI2").ToString
            qsatisfiyati3 = dr("QSATISFIYATI3").ToString
            qaktif = dr("QAKTIF").ToString
            qResim = dr("QAKTIF").ToString
            qgelismis = dr("QADVANCE").ToString
            qsecenek = dr("QKRITER").ToString
            qtarih = dr("QTARIH").ToString
            qsKdvTipi = dr("qsKdvTipi").ToString
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub dataload()
        Dim dr As DataRow = DataSet1.Tables(0).NewRow
        dr("STOKKODU") = ""
        dr("TARIH1") = Today.ToString
        dr("TARIH2") = Today.ToString
        Try
            dr("DEPO") = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("Ara").GetValue("Depo").ToString
        Catch ex As Exception
            dr("DEPO") = sDepo
        End Try
        DataSet1.Tables(0).Rows.Add(dr)
        dr = Nothing
        VGridControl1.DataSource = DataSet1.Tables(0)
        rowKOD1.Properties.Caption = sStokSinifTipi1
        rowKOD2.Properties.Caption = sStokSinifTipi2
        rowKOD3.Properties.Caption = sStokSinifTipi3
        rowKOD4.Properties.Caption = sStokSinifTipi4
        rowKOD5.Properties.Caption = sStokSinifTipi5
        rowKOD6.Properties.Caption = sStokSinifTipi6
        rowKOD7.Properties.Caption = sStokSinifTipi7
        rowKOD8.Properties.Caption = sStokSinifTipi8
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub VGridControl1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles VGridControl1.Validated
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
    End Sub
    Private Sub sec_kriter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        sorgu()
    End Sub
    Private Sub VGridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub sec_aciklama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_aciklama.KeyDown
        If e.KeyCode = Keys.Enter Then
            VGridControl1.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
            Dim dr As DataRow = DataSet1.Tables(0).Rows(0)
            If IsNumeric(dr("BARKOD")) = True Then
                If Len(dr("BARKOD").ToString) < 2 Then
                    dr("BARKOD") = dr("BARKOD") + "  "
                End If
                If Trim((dr("BARKOD")).substring(0, 2)) = sBarcodeStd Then
                    Dim deger = Trim(dr("BARKOD"))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        dr("BARKOD") = deger.substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(dr("BARKOD").ToString) <> "" Then
                    x = (dr("BARKOD")).indexof("*", 1, (dr("BARKOD")).LENGTH - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (dr("BARKOD")).substring(0, x)
                        dr("BARKOD") = (dr("BARKOD")).substring((x + 1), (dr("BARKOD")).LENGTH - (x + 1))
                        If IsNumeric(dr("BARKOD")) Then
                        Else
                        End If
                    End If
                End If
            End If
            If VGridControl1.FocusedRow.Name = rowBARKOD.Name Then
                yeni = True
            Else
                yeni = False
            End If
            sorgu()
            dr = Nothing
        End If
    End Sub
    Private Sub frm_stok_ara_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("ActiveRow", VGridControl1.FocusedRow.Name)
        If MenuItem11.Checked = True Then
            kriter_kaydet()
        End If
        DataSet2.Clear()
        DataSet2.Dispose()
        DataSet2 = Nothing
        'ind = Nothing
        'stokkodu = Nothing
        'malincinsi = Nothing
        'barkod = Nothing
        'muadilbarkod = Nothing
        'kod1 = Nothing
        'kod2 = Nothing
        'kod3 = Nothing
        'kod4 = Nothing
        'kod5 = Nothing
        'kod6 = Nothing
        'kod7 = Nothing
        'kod8 = Nothing
        'kod9 = Nothing
        'kod10 = Nothing
        'istihbarat = Nothing
        'birim = Nothing
        'depo = Nothing
        'satisfiyati1 = Nothing
        'satisfiyati2 = Nothing
        'satisfiyati3 = Nothing
        'aktif = Nothing
        'qind = Nothing
        'qstokkodu = Nothing
        'qmalincinsi = Nothing
        'qbarkod = Nothing
        'qmuadilbarkod = Nothing
        'qkod1 = Nothing
        'qkod2 = Nothing
        'qkod3 = Nothing
        'qkod4 = Nothing
        'qkod5 = Nothing
        'qkod6 = Nothing
        'qkod7 = Nothing
        'qkod8 = Nothing
        'qkod9 = Nothing
        'qkod10 = Nothing
        'qistihbarat = Nothing
        'qbirim = Nothing
        'qdepo = Nothing
        'qsatisfiyati1 = Nothing
        'qsatisfiyati2 = Nothing
        'qsatisfiyati3 = Nothing
        'qaktif = Nothing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("width", Me.Size.Width)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("heigh", Me.Size.Height)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("x", Me.Location.X)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("y", Me.Location.Y)
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub sec_kriter_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
    End Sub
    Private Sub sec_kriter_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs)
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
    End Sub
    Private Sub sec_kriter_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
        dr.AcceptChanges()
    End Sub
    Private Sub sec_kriter_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
    End Sub
    Private Sub VGridControl1_FocusedRecordCellChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.IndexChangedEventArgs) Handles VGridControl1.FocusedRecordCellChanged
        Try
            VGridControl1.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        kriter_kaydet()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kriter_yukle()
    End Sub
    Private Sub kriter_kaydet()
        Dim s As String = "c:\Formlar\STOK\stokara.xml"
        Dim dosya As New FileInfo(s)
        If dosya.Exists = False Then
            dosya.Create()
        End If
        DataSet1.WriteXml(s)
    End Sub
    Private Sub kriter_yukle()
        Dim s As String = "c:\Formlar\STOK\stokara.xml"
        Dim dosya As New FileInfo(s)
        If dosya.Exists = True Then
            DataSet1.Clear()
            DataSet1.Dispose()
            DataSet1.ReadXml(s)
            VGridControl1.DataSource = DataSet1
        End If
    End Sub
    Private Sub kriter_sil()
        Dim s As String = "c:\Formlar\STOK\stokara.xml"
        Dim dosya As New FileInfo(s)
        If dosya.Exists = True Then
            dosya.Delete()
            XtraMessageBox.Show(Sorgu_sDil("Kriter Silindi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If MenuItem4.Checked = True Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("auto_load", False)
            MenuItem4.Checked = False
        ElseIf MenuItem4.Checked = False Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("auto_load", True)
            MenuItem4.Checked = True
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        kriter_sil()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub ozelkod_s(ByVal kod As String)
        'Dim frm As New frm_ozelkod
        'frm.connection = connection
        'frm.firmano = firmano
        'frm.donemno = donemno
        'frm.modul = "STOK"
        'frm.category = kod
        'If frm.ShowDialog(Me) = DialogResult.OK Then
        '    If kod = 1 Then
        '        dr("KOD1") = frm.ozelkod.ToString
        '    ElseIf kod = 2 Then
        '        dr("KOD2") = frm.ozelkod.ToString
        '    ElseIf kod = 3 Then
        '        dr("KOD3") = frm.ozelkod.ToString
        '    ElseIf kod = 4 Then
        '        dr("KOD4") = frm.ozelkod.ToString
        '    ElseIf kod = 5 Then
        '        dr("KOD5") = frm.ozelkod.ToString
        '    ElseIf kod = 6 Then
        '        dr("KOD6") = frm.ozelkod.ToString
        '    ElseIf kod = 7 Then
        '        dr("KOD7") = frm.ozelkod.ToString
        '    ElseIf kod = 8 Then
        '        dr("KOD8") = frm.ozelkod.ToString
        '    ElseIf kod = 9 Then
        '        dr("KOD9") = frm.ozelkod.ToString
        '    ElseIf kod = 10 Then
        '        dr("KOD10") = frm.ozelkod.ToString
        '    End If
        '    frm.DataSet1.Clear()
        '    frm.DataSet1.Dispose()
        '    frm.DataSet1 = Nothing
        '    frm.GridView1.Dispose()
        '    frm.GridView1 = Nothing
        '    frm.GridControl1.Dispose()
        '    frm.GridControl1 = Nothing
        '    frm.Panel1.Dispose()
        '    frm.Panel2.Dispose()
        '    frm.Panel3.Dispose()
        '    frm.Panel1 = Nothing
        '    frm.Panel2 = Nothing
        '    frm.Panel3 = Nothing
        '    frm.SimpleButton1.Dispose()
        '    frm.SimpleButton2.Dispose()
        '    frm.SimpleButton1 = Nothing
        '    frm.SimpleButton2 = Nothing
        '    frm.PictureBox1.Dispose()
        '    frm.PictureBox1 = Nothing
        '    frm.Label1.Dispose()
        '    frm.Label1 = Nothing
        '    frm.Dispose()
        '    frm.Close()
        '    frm = Nothing
        '    VGridControl1.UpdateFocusedRecord()
        '    VGridControl1.CloseEditor()
        'End If
    End Sub
    Private Sub sec_ozelkod_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_ozelkod.ButtonClick
        ozelkod_sec()
    End Sub
    Private Sub ozelkod_sec()
        If VGridControl1.FocusedRow.Name = rowKOD1.Name Then
            ozelkod_s(1)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD2.Name Then
            ozelkod_s(2)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD3.Name Then
            ozelkod_s(3)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD4.Name Then
            ozelkod_s(4)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD5.Name Then
            ozelkod_s(5)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD6.Name Then
            ozelkod_s(6)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD7.Name Then
            ozelkod_s(7)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD8.Name Then
            ozelkod_s(8)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD9.Name Then
            ozelkod_s(9)
        ElseIf VGridControl1.FocusedRow.Name = rowKOD10.Name Then
            ozelkod_s(10)
        End If
    End Sub
    Private Sub sec_ozelkod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_ozelkod.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Space Then
            ozelkod_sec()
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If MenuItem11.Checked = True Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("auto_save", False)
            MenuItem11.Checked = False
        ElseIf MenuItem11.Checked = False Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("auto_save", True)
            MenuItem11.Checked = True
        End If
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        If MenuItem12.Checked = True Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("auto_boyut", False)
            MenuItem12.Checked = False
        ElseIf MenuItem12.Checked = False Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("auto_boyut", True)
            MenuItem12.Checked = True
        End If
    End Sub
End Class
