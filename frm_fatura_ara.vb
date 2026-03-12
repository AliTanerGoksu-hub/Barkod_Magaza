Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Public Class frm_fatura_ara
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
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
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
    Friend WithEvents DataColumn20 As System.Data.DataColumn
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
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowBELGENO As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowFIRMAKODU As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowFIRMAADI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowDEPO As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowPERSONEL As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowPARABIRIMI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKUR As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowACIKLAMA As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKAPALI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKDVDAHIL As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents sec_izahat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents rowIZAHAT As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
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
    Friend WithEvents rowSTOKKODU As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowMALINCINSI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_depo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents rowOZELKODLAR As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_ozelkodlar As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents rowPERIYOD As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_periyod As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents rowSTOKTIPI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_stoktipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ds_stoktipi As System.Data.DataSet
    Friend WithEvents rowTOP As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents rowCARIKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowCARIKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowCARIKOD3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowCARIKOD4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowCARIKOD5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_ozelkod As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DataSet3 As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents sec_personel As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents rowHESAPKODU As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents ds_belgetipi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn83 As System.Data.DataColumn
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
    Friend WithEvents MultiEditorRowProperties54 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties55 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties56 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties57 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties58 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties59 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties60 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties61 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties62 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties63 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties64 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties65 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties66 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fatura_ara))
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_kriter = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_izahat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.MultiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_periyod = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties11 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties12 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties13 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties14 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties15 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties16 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties17 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties18 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties19 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_depo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MultiEditorRowProperties20 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties21 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_personel = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn79 = New System.Data.DataColumn()
        Me.DataColumn80 = New System.Data.DataColumn()
        Me.MultiEditorRowProperties22 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties23 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties24 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties25 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties26 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties27 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_ozelkod = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.MultiEditorRowProperties28 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties29 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties30 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties31 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties32 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties33 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties34 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties35 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties36 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties37 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties38 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties39 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties40 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties41 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties42 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties43 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties44 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties45 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties46 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties47 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties48 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties49 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_ozelkodlar = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties50 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties51 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_stoktipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.MultiEditorRowProperties52 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties53 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties54 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties55 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties56 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties57 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties58 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties59 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties60 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties61 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties62 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties63 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties64 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties65 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties66 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn20 = New System.Data.DataColumn()
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
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
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
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.DataColumn81 = New System.Data.DataColumn()
        Me.DataColumn82 = New System.Data.DataColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowBELGENO = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowIZAHAT = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowPERIYOD = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowFIRMAKODU = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowFIRMAADI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKODU = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowMALINCINSI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowDEPO = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowPERSONEL = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowPARABIRIMI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKUR = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKAPALI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKDVDAHIL = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowOZELKODLAR = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKTIPI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowTOP = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowCARIKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowCARIKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowCARIKOD3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowCARIKOD4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowCARIKOD5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowHESAPKODU = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.DataSet2 = New System.Data.DataSet()
        Me.ds_stoktipi = New System.Data.DataSet()
        Me.DataSet3 = New System.Data.DataSet()
        Me.ds_belgetipi = New System.Data.DataSet()
        CType(Me.sec_kriter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_izahat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_periyod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_personel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ozelkodlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_stoktipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_stoktipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.Caption = "ÝlkTarih"
        Me.MultiEditorRowProperties1.CellWidth = 67
        Me.MultiEditorRowProperties1.FieldName = "ILKTARIH"
        Me.MultiEditorRowProperties1.ImageIndex = 0
        Me.MultiEditorRowProperties1.Width = 80
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.Caption = "SonTarih"
        Me.MultiEditorRowProperties2.CellWidth = 67
        Me.MultiEditorRowProperties2.FieldName = "SONTARIH"
        Me.MultiEditorRowProperties2.Width = 56
        '
        'MultiEditorRowProperties3
        '
        Me.MultiEditorRowProperties3.CellWidth = 56
        Me.MultiEditorRowProperties3.FieldName = "QTARIH"
        Me.MultiEditorRowProperties3.ReadOnly = True
        Me.MultiEditorRowProperties3.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties3.Width = 25
        '
        'sec_kriter
        '
        Me.sec_kriter.AutoHeight = False
        Me.sec_kriter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties4
        '
        Me.MultiEditorRowProperties4.Caption = "ÝlkBelge"
        Me.MultiEditorRowProperties4.CellWidth = 67
        Me.MultiEditorRowProperties4.FieldName = "ILKBELGE"
        Me.MultiEditorRowProperties4.ImageIndex = 0
        Me.MultiEditorRowProperties4.Width = 71
        '
        'MultiEditorRowProperties5
        '
        Me.MultiEditorRowProperties5.Caption = "SonBelge"
        Me.MultiEditorRowProperties5.CellWidth = 67
        Me.MultiEditorRowProperties5.FieldName = "SONBELGE"
        Me.MultiEditorRowProperties5.Width = 49
        '
        'MultiEditorRowProperties6
        '
        Me.MultiEditorRowProperties6.CellWidth = 56
        Me.MultiEditorRowProperties6.FieldName = "QBELGENO"
        Me.MultiEditorRowProperties6.ReadOnly = True
        Me.MultiEditorRowProperties6.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties6.Width = 21
        '
        'MultiEditorRowProperties7
        '
        Me.MultiEditorRowProperties7.Caption = "Belge Tipi"
        Me.MultiEditorRowProperties7.CellWidth = 181
        Me.MultiEditorRowProperties7.FieldName = "IZAHAT"
        Me.MultiEditorRowProperties7.ImageIndex = 0
        Me.MultiEditorRowProperties7.RowEdit = Me.sec_izahat
        Me.MultiEditorRowProperties7.Width = 138
        '
        'sec_izahat
        '
        Me.sec_izahat.AutoHeight = False
        Me.sec_izahat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_izahat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", 10, "KayýtNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", 30, "BelgeTipi")})
        Me.sec_izahat.DataSource = Me.DataTable5
        Me.sec_izahat.DisplayMember = "ACIKLAMA"
        Me.sec_izahat.Name = "sec_izahat"
        Me.sec_izahat.NullText = ""
        Me.sec_izahat.ValueMember = "IND"
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn83, Me.DataColumn84})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "IND"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "ACIKLAMA"
        '
        'MultiEditorRowProperties8
        '
        Me.MultiEditorRowProperties8.CellWidth = 76
        Me.MultiEditorRowProperties8.FieldName = "QIZAHAT"
        Me.MultiEditorRowProperties8.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties8.Width = 24
        '
        'MultiEditorRowProperties9
        '
        Me.MultiEditorRowProperties9.Caption = "Periyod"
        Me.MultiEditorRowProperties9.CellWidth = 181
        Me.MultiEditorRowProperties9.FieldName = "PERIYOD"
        Me.MultiEditorRowProperties9.ImageIndex = 0
        Me.MultiEditorRowProperties9.RowEdit = Me.sec_periyod
        Me.MultiEditorRowProperties9.Width = 138
        '
        'sec_periyod
        '
        Me.sec_periyod.AutoHeight = False
        Me.sec_periyod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_periyod.Items.AddRange(New Object() {"Günlük", "Aylýk", "Haftalýk", "Haftanýn Günü", "3 Er Aylýk", "Yýllýk"})
        Me.sec_periyod.Name = "sec_periyod"
        Me.sec_periyod.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties10
        '
        Me.MultiEditorRowProperties10.CellWidth = 76
        Me.MultiEditorRowProperties10.FieldName = "QPERIYOD"
        Me.MultiEditorRowProperties10.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties10.Width = 24
        '
        'MultiEditorRowProperties11
        '
        Me.MultiEditorRowProperties11.Caption = "Firma Kodu"
        Me.MultiEditorRowProperties11.CellWidth = 134
        Me.MultiEditorRowProperties11.FieldName = "FIRMAKODU"
        Me.MultiEditorRowProperties11.ImageIndex = 0
        Me.MultiEditorRowProperties11.Width = 121
        '
        'MultiEditorRowProperties12
        '
        Me.MultiEditorRowProperties12.CellWidth = 56
        Me.MultiEditorRowProperties12.FieldName = "QFIRMAKODU"
        Me.MultiEditorRowProperties12.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties12.Width = 21
        '
        'MultiEditorRowProperties13
        '
        Me.MultiEditorRowProperties13.Caption = "Firma Adý"
        Me.MultiEditorRowProperties13.CellWidth = 134
        Me.MultiEditorRowProperties13.FieldName = "FIRMAADI"
        Me.MultiEditorRowProperties13.ImageIndex = 0
        Me.MultiEditorRowProperties13.Width = 121
        '
        'MultiEditorRowProperties14
        '
        Me.MultiEditorRowProperties14.CellWidth = 56
        Me.MultiEditorRowProperties14.FieldName = "QFIRMAADI"
        Me.MultiEditorRowProperties14.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties14.Width = 21
        '
        'MultiEditorRowProperties15
        '
        Me.MultiEditorRowProperties15.Caption = "Stok Kodu"
        Me.MultiEditorRowProperties15.CellWidth = 181
        Me.MultiEditorRowProperties15.FieldName = "STOKKODU"
        Me.MultiEditorRowProperties15.ImageIndex = 0
        Me.MultiEditorRowProperties15.Width = 138
        '
        'MultiEditorRowProperties16
        '
        Me.MultiEditorRowProperties16.CellWidth = 76
        Me.MultiEditorRowProperties16.FieldName = "QSTOKKODU"
        Me.MultiEditorRowProperties16.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties16.Width = 24
        '
        'MultiEditorRowProperties17
        '
        Me.MultiEditorRowProperties17.Caption = "Stok Adý"
        Me.MultiEditorRowProperties17.CellWidth = 181
        Me.MultiEditorRowProperties17.FieldName = "MALINCINSI"
        Me.MultiEditorRowProperties17.ImageIndex = 0
        Me.MultiEditorRowProperties17.Width = 138
        '
        'MultiEditorRowProperties18
        '
        Me.MultiEditorRowProperties18.CellWidth = 76
        Me.MultiEditorRowProperties18.FieldName = "QMALINCINSI"
        Me.MultiEditorRowProperties18.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties18.Width = 24
        '
        'MultiEditorRowProperties19
        '
        Me.MultiEditorRowProperties19.Caption = "Depo"
        Me.MultiEditorRowProperties19.CellWidth = 134
        Me.MultiEditorRowProperties19.FieldName = "DEPO"
        Me.MultiEditorRowProperties19.ImageIndex = 0
        Me.MultiEditorRowProperties19.RowEdit = Me.sec_depo
        Me.MultiEditorRowProperties19.Width = 121
        '
        'sec_depo
        '
        Me.sec_depo.AutoHeight = False
        Me.sec_depo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPO", "DEPO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOADI", "Depo Adý")})
        Me.sec_depo.DisplayMember = "DEPO"
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.NullText = "[Hepsi]"
        Me.sec_depo.ValueMember = "DEPO"
        '
        'MultiEditorRowProperties20
        '
        Me.MultiEditorRowProperties20.CellWidth = 56
        Me.MultiEditorRowProperties20.FieldName = "QDEPO"
        Me.MultiEditorRowProperties20.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties20.Width = 21
        '
        'MultiEditorRowProperties21
        '
        Me.MultiEditorRowProperties21.Caption = "Personel"
        Me.MultiEditorRowProperties21.CellWidth = 134
        Me.MultiEditorRowProperties21.FieldName = "PERSONEL"
        Me.MultiEditorRowProperties21.ImageIndex = 0
        Me.MultiEditorRowProperties21.RowEdit = Me.sec_personel
        Me.MultiEditorRowProperties21.Width = 121
        '
        'sec_personel
        '
        Me.sec_personel.AutoHeight = False
        Me.sec_personel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_personel.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "KayýtNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Personel")})
        Me.sec_personel.DataSource = Me.DataTable4
        Me.sec_personel.DisplayMember = "ACIKLAMA"
        Me.sec_personel.Name = "sec_personel"
        Me.sec_personel.NullText = "[Hepsi]"
        Me.sec_personel.ValueMember = "IND"
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn79, Me.DataColumn80})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "IND"
        Me.DataColumn79.DataType = GetType(Long)
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "ACIKLAMA"
        '
        'MultiEditorRowProperties22
        '
        Me.MultiEditorRowProperties22.CellWidth = 56
        Me.MultiEditorRowProperties22.FieldName = "QPERSONEL"
        Me.MultiEditorRowProperties22.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties22.Width = 21
        '
        'MultiEditorRowProperties23
        '
        Me.MultiEditorRowProperties23.Caption = "Parabirimi"
        Me.MultiEditorRowProperties23.CellWidth = 134
        Me.MultiEditorRowProperties23.FieldName = "PARABIRIMI"
        Me.MultiEditorRowProperties23.ImageIndex = 0
        Me.MultiEditorRowProperties23.Width = 121
        '
        'MultiEditorRowProperties24
        '
        Me.MultiEditorRowProperties24.CellWidth = 56
        Me.MultiEditorRowProperties24.FieldName = "QPARABIRIMI"
        Me.MultiEditorRowProperties24.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties24.Width = 21
        '
        'MultiEditorRowProperties25
        '
        Me.MultiEditorRowProperties25.Caption = "Kur"
        Me.MultiEditorRowProperties25.CellWidth = 134
        Me.MultiEditorRowProperties25.FieldName = "KUR"
        Me.MultiEditorRowProperties25.ImageIndex = 0
        Me.MultiEditorRowProperties25.Width = 121
        '
        'MultiEditorRowProperties26
        '
        Me.MultiEditorRowProperties26.CellWidth = 56
        Me.MultiEditorRowProperties26.FieldName = "QKUR"
        Me.MultiEditorRowProperties26.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties26.Width = 21
        '
        'MultiEditorRowProperties27
        '
        Me.MultiEditorRowProperties27.Caption = "Açýklama 1"
        Me.MultiEditorRowProperties27.CellWidth = 134
        Me.MultiEditorRowProperties27.FieldName = "KOD1"
        Me.MultiEditorRowProperties27.ImageIndex = 0
        Me.MultiEditorRowProperties27.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties27.Width = 121
        '
        'sec_ozelkod
        '
        Me.sec_ozelkod.AutoHeight = False
        Me.sec_ozelkod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ozelkod.Name = "sec_ozelkod"
        '
        'MultiEditorRowProperties28
        '
        Me.MultiEditorRowProperties28.CellWidth = 56
        Me.MultiEditorRowProperties28.FieldName = "QKOD1"
        Me.MultiEditorRowProperties28.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties28.Width = 21
        '
        'MultiEditorRowProperties29
        '
        Me.MultiEditorRowProperties29.Caption = "Açýklama 2"
        Me.MultiEditorRowProperties29.CellWidth = 134
        Me.MultiEditorRowProperties29.FieldName = "KOD2"
        Me.MultiEditorRowProperties29.ImageIndex = 0
        Me.MultiEditorRowProperties29.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties29.Width = 121
        '
        'MultiEditorRowProperties30
        '
        Me.MultiEditorRowProperties30.CellWidth = 56
        Me.MultiEditorRowProperties30.FieldName = "QKOD2"
        Me.MultiEditorRowProperties30.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties30.Width = 21
        '
        'MultiEditorRowProperties31
        '
        Me.MultiEditorRowProperties31.Caption = "Not"
        Me.MultiEditorRowProperties31.CellWidth = 134
        Me.MultiEditorRowProperties31.FieldName = "ACIKLAMA"
        Me.MultiEditorRowProperties31.ImageIndex = 0
        Me.MultiEditorRowProperties31.Width = 138
        '
        'MultiEditorRowProperties32
        '
        Me.MultiEditorRowProperties32.CellWidth = 56
        Me.MultiEditorRowProperties32.FieldName = "QACIKLAMA"
        Me.MultiEditorRowProperties32.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties32.Width = 24
        '
        'MultiEditorRowProperties33
        '
        Me.MultiEditorRowProperties33.Caption = "Normal"
        Me.MultiEditorRowProperties33.CellWidth = 134
        Me.MultiEditorRowProperties33.FieldName = "KAPALI"
        Me.MultiEditorRowProperties33.ImageIndex = 0
        Me.MultiEditorRowProperties33.Width = 138
        '
        'MultiEditorRowProperties34
        '
        Me.MultiEditorRowProperties34.CellWidth = 56
        Me.MultiEditorRowProperties34.FieldName = "QKAPALI"
        Me.MultiEditorRowProperties34.ReadOnly = True
        Me.MultiEditorRowProperties34.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties34.Width = 24
        '
        'MultiEditorRowProperties35
        '
        Me.MultiEditorRowProperties35.Caption = "KdvDahil"
        Me.MultiEditorRowProperties35.CellWidth = 134
        Me.MultiEditorRowProperties35.FieldName = "KDVDAHIL"
        Me.MultiEditorRowProperties35.ImageIndex = 0
        Me.MultiEditorRowProperties35.Width = 138
        '
        'MultiEditorRowProperties36
        '
        Me.MultiEditorRowProperties36.CellWidth = 56
        Me.MultiEditorRowProperties36.FieldName = "QKDVDAHIL"
        Me.MultiEditorRowProperties36.ReadOnly = True
        Me.MultiEditorRowProperties36.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties36.Width = 24
        '
        'MultiEditorRowProperties37
        '
        Me.MultiEditorRowProperties37.Caption = "Kayýt No"
        Me.MultiEditorRowProperties37.CellWidth = 181
        Me.MultiEditorRowProperties37.FieldName = "IND"
        Me.MultiEditorRowProperties37.ImageIndex = 0
        Me.MultiEditorRowProperties37.Width = 138
        '
        'MultiEditorRowProperties38
        '
        Me.MultiEditorRowProperties38.CellWidth = 76
        Me.MultiEditorRowProperties38.FieldName = "QIND"
        Me.MultiEditorRowProperties38.ReadOnly = True
        Me.MultiEditorRowProperties38.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties38.Width = 24
        '
        'MultiEditorRowProperties39
        '
        Me.MultiEditorRowProperties39.Caption = "1.StokÖzelKodu"
        Me.MultiEditorRowProperties39.CellWidth = 181
        Me.MultiEditorRowProperties39.FieldName = "STOKKOD1"
        Me.MultiEditorRowProperties39.ImageIndex = 0
        Me.MultiEditorRowProperties39.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties39.Width = 138
        '
        'MultiEditorRowProperties40
        '
        Me.MultiEditorRowProperties40.CellWidth = 76
        Me.MultiEditorRowProperties40.FieldName = "QSTOKKOD1"
        Me.MultiEditorRowProperties40.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties40.Width = 24
        '
        'MultiEditorRowProperties41
        '
        Me.MultiEditorRowProperties41.Caption = "2.StokÖzelKodu"
        Me.MultiEditorRowProperties41.CellWidth = 181
        Me.MultiEditorRowProperties41.FieldName = "STOKKOD2"
        Me.MultiEditorRowProperties41.ImageIndex = 0
        Me.MultiEditorRowProperties41.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties41.Width = 138
        '
        'MultiEditorRowProperties42
        '
        Me.MultiEditorRowProperties42.CellWidth = 76
        Me.MultiEditorRowProperties42.FieldName = "QSTOKKOD2"
        Me.MultiEditorRowProperties42.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties42.Width = 24
        '
        'MultiEditorRowProperties43
        '
        Me.MultiEditorRowProperties43.Caption = "3.StokÖzelKodu"
        Me.MultiEditorRowProperties43.CellWidth = 181
        Me.MultiEditorRowProperties43.FieldName = "STOKKOD3"
        Me.MultiEditorRowProperties43.ImageIndex = 0
        Me.MultiEditorRowProperties43.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties43.Width = 138
        '
        'MultiEditorRowProperties44
        '
        Me.MultiEditorRowProperties44.CellWidth = 76
        Me.MultiEditorRowProperties44.FieldName = "QSTOKKOD3"
        Me.MultiEditorRowProperties44.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties44.Width = 24
        '
        'MultiEditorRowProperties45
        '
        Me.MultiEditorRowProperties45.Caption = "4.StokÖzelKodu"
        Me.MultiEditorRowProperties45.CellWidth = 181
        Me.MultiEditorRowProperties45.FieldName = "STOKKOD4"
        Me.MultiEditorRowProperties45.ImageIndex = 0
        Me.MultiEditorRowProperties45.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties45.Width = 138
        '
        'MultiEditorRowProperties46
        '
        Me.MultiEditorRowProperties46.CellWidth = 76
        Me.MultiEditorRowProperties46.FieldName = "QSTOKKOD4"
        Me.MultiEditorRowProperties46.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties46.Width = 24
        '
        'MultiEditorRowProperties47
        '
        Me.MultiEditorRowProperties47.Caption = "5.StokÖzelKodu"
        Me.MultiEditorRowProperties47.CellWidth = 181
        Me.MultiEditorRowProperties47.FieldName = "STOKKOD5"
        Me.MultiEditorRowProperties47.ImageIndex = 0
        Me.MultiEditorRowProperties47.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties47.Width = 138
        '
        'MultiEditorRowProperties48
        '
        Me.MultiEditorRowProperties48.CellWidth = 76
        Me.MultiEditorRowProperties48.FieldName = "QSTOKKOD5"
        Me.MultiEditorRowProperties48.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties48.Width = 24
        '
        'MultiEditorRowProperties49
        '
        Me.MultiEditorRowProperties49.Caption = "Kodlamalar"
        Me.MultiEditorRowProperties49.CellWidth = 181
        Me.MultiEditorRowProperties49.FieldName = "OZELKODLAR"
        Me.MultiEditorRowProperties49.ImageIndex = 0
        Me.MultiEditorRowProperties49.RowEdit = Me.sec_ozelkodlar
        Me.MultiEditorRowProperties49.Width = 138
        '
        'sec_ozelkodlar
        '
        Me.sec_ozelkodlar.AutoHeight = False
        Me.sec_ozelkodlar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ozelkodlar.Items.AddRange(New Object() {"STOKKOD1", "STOKKOD2", "STOKKOD3", "STOKKOD4", "STOKKOD5", "STOKKOD6", "STOKKOD7", "STOKKOD8", "STOKKOD9", "STOKKOD10", "CARIKOD1", "CARIKOD2", "CARIKOD3", "CARIKOD4", "CARIKOD5"})
        Me.sec_ozelkodlar.Name = "sec_ozelkodlar"
        Me.sec_ozelkodlar.NullText = "[Hepsi]"
        Me.sec_ozelkodlar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties50
        '
        Me.MultiEditorRowProperties50.CellWidth = 76
        Me.MultiEditorRowProperties50.FieldName = "QOZELKODLAR"
        Me.MultiEditorRowProperties50.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties50.Width = 24
        '
        'MultiEditorRowProperties51
        '
        Me.MultiEditorRowProperties51.Caption = "Stok Tipi"
        Me.MultiEditorRowProperties51.CellWidth = 181
        Me.MultiEditorRowProperties51.FieldName = "STOKTIPI"
        Me.MultiEditorRowProperties51.ImageIndex = 0
        Me.MultiEditorRowProperties51.RowEdit = Me.sec_stoktipi
        Me.MultiEditorRowProperties51.Width = 138
        '
        'sec_stoktipi
        '
        Me.sec_stoktipi.AutoHeight = False
        Me.sec_stoktipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_stoktipi.DataSource = Me.DataTable3
        Me.sec_stoktipi.DisplayMember = "ACIKLAMA"
        Me.sec_stoktipi.Name = "sec_stoktipi"
        Me.sec_stoktipi.NullText = "[Hepsi]"
        Me.sec_stoktipi.ValueMember = "IND"
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn67, Me.DataColumn68})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "IND"
        Me.DataColumn67.DataType = GetType(Long)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "ACIKLAMA"
        '
        'MultiEditorRowProperties52
        '
        Me.MultiEditorRowProperties52.CellWidth = 76
        Me.MultiEditorRowProperties52.FieldName = "QSTOKTIPI"
        Me.MultiEditorRowProperties52.ReadOnly = True
        Me.MultiEditorRowProperties52.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties52.Width = 24
        '
        'MultiEditorRowProperties53
        '
        Me.MultiEditorRowProperties53.Caption = "KayýtSayýsý"
        Me.MultiEditorRowProperties53.CellWidth = 181
        Me.MultiEditorRowProperties53.FieldName = "TOP"
        Me.MultiEditorRowProperties53.ImageIndex = 0
        Me.MultiEditorRowProperties53.Width = 138
        '
        'MultiEditorRowProperties54
        '
        Me.MultiEditorRowProperties54.CellWidth = 76
        Me.MultiEditorRowProperties54.FieldName = "QTOP"
        Me.MultiEditorRowProperties54.ReadOnly = True
        Me.MultiEditorRowProperties54.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties54.Width = 24
        '
        'MultiEditorRowProperties55
        '
        Me.MultiEditorRowProperties55.Caption = "1.CariÖzelKod"
        Me.MultiEditorRowProperties55.CellWidth = 181
        Me.MultiEditorRowProperties55.FieldName = "CARIKOD1"
        Me.MultiEditorRowProperties55.ImageIndex = 0
        Me.MultiEditorRowProperties55.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties55.Width = 138
        '
        'MultiEditorRowProperties56
        '
        Me.MultiEditorRowProperties56.CellWidth = 76
        Me.MultiEditorRowProperties56.FieldName = "QCARIKOD1"
        Me.MultiEditorRowProperties56.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties56.Width = 24
        '
        'MultiEditorRowProperties57
        '
        Me.MultiEditorRowProperties57.Caption = "2.CariÖzelKod"
        Me.MultiEditorRowProperties57.CellWidth = 181
        Me.MultiEditorRowProperties57.FieldName = "CARIKOD2"
        Me.MultiEditorRowProperties57.ImageIndex = 0
        Me.MultiEditorRowProperties57.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties57.Width = 138
        '
        'MultiEditorRowProperties58
        '
        Me.MultiEditorRowProperties58.CellWidth = 76
        Me.MultiEditorRowProperties58.FieldName = "QCARIKOD2"
        Me.MultiEditorRowProperties58.Width = 24
        '
        'MultiEditorRowProperties59
        '
        Me.MultiEditorRowProperties59.Caption = "3.CariÖzelKod"
        Me.MultiEditorRowProperties59.CellWidth = 181
        Me.MultiEditorRowProperties59.FieldName = "CARIKOD3"
        Me.MultiEditorRowProperties59.ImageIndex = 0
        Me.MultiEditorRowProperties59.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties59.Width = 138
        '
        'MultiEditorRowProperties60
        '
        Me.MultiEditorRowProperties60.CellWidth = 76
        Me.MultiEditorRowProperties60.FieldName = "QCARIKOD3"
        Me.MultiEditorRowProperties60.Width = 24
        '
        'MultiEditorRowProperties61
        '
        Me.MultiEditorRowProperties61.Caption = "4.CariÖzelKod"
        Me.MultiEditorRowProperties61.CellWidth = 181
        Me.MultiEditorRowProperties61.FieldName = "CARIKOD4"
        Me.MultiEditorRowProperties61.ImageIndex = 0
        Me.MultiEditorRowProperties61.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties61.Width = 138
        '
        'MultiEditorRowProperties62
        '
        Me.MultiEditorRowProperties62.CellWidth = 76
        Me.MultiEditorRowProperties62.FieldName = "QCARIKOD4"
        Me.MultiEditorRowProperties62.Width = 24
        '
        'MultiEditorRowProperties63
        '
        Me.MultiEditorRowProperties63.Caption = "5.CariÖzelKod"
        Me.MultiEditorRowProperties63.CellWidth = 181
        Me.MultiEditorRowProperties63.FieldName = "CARIKOD5"
        Me.MultiEditorRowProperties63.ImageIndex = 0
        Me.MultiEditorRowProperties63.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties63.Width = 138
        '
        'MultiEditorRowProperties64
        '
        Me.MultiEditorRowProperties64.CellWidth = 76
        Me.MultiEditorRowProperties64.FieldName = "QCARIKOD5"
        Me.MultiEditorRowProperties64.Width = 24
        '
        'MultiEditorRowProperties65
        '
        Me.MultiEditorRowProperties65.Caption = "Gider Kodu"
        Me.MultiEditorRowProperties65.CellWidth = 181
        Me.MultiEditorRowProperties65.FieldName = "HESAPKODU"
        Me.MultiEditorRowProperties65.ImageIndex = 0
        Me.MultiEditorRowProperties65.Width = 138
        '
        'MultiEditorRowProperties66
        '
        Me.MultiEditorRowProperties66.CellWidth = 76
        Me.MultiEditorRowProperties66.FieldName = "QHESAPKODU"
        Me.MultiEditorRowProperties66.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties66.Width = 24
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "IND"
        Me.DataColumn33.DataType = GetType(Long)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "IZAHAT"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "BASLIK"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "HAREKET"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "GIRIS"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "IADE"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "STKH"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "CH"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "CGH"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "DEPOH"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "SIPH"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "ALTTABLO"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(456, 69)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 65)
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
        Me.PanelControl2.Size = New System.Drawing.Size(456, 44)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(363, 10)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(283, 10)
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
        Me.PanelControl3.Size = New System.Drawing.Size(456, 316)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(452, 312)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.VGridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(450, 279)
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
        Me.VGridControl1.CustomizationFormBounds = New System.Drawing.Rectangle(547, 127, 208, 252)
        Me.VGridControl1.DataMember = Nothing
        Me.VGridControl1.DataSource = Me.DataSet1
        Me.VGridControl1.ImageList = Me.ImageList1
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.OptionsBehavior.ResizeHeaderPanel = False
        Me.VGridControl1.OptionsBehavior.ResizeRowHeaders = False
        Me.VGridControl1.OptionsBehavior.ResizeRowValues = False
        Me.VGridControl1.OptionsBehavior.SmartExpand = False
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_kriter, Me.sec_izahat, Me.sec_depo, Me.sec_ozelkodlar, Me.sec_periyod, Me.sec_stoktipi, Me.sec_ozelkod, Me.sec_personel})
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowTARIH, Me.rowBELGENO, Me.rowIZAHAT, Me.rowPERIYOD, Me.rowFIRMAKODU, Me.rowFIRMAADI, Me.rowSTOKKODU, Me.rowMALINCINSI, Me.rowDEPO, Me.rowPERSONEL, Me.rowPARABIRIMI, Me.rowKUR, Me.rowKOD1, Me.rowKOD2, Me.rowACIKLAMA, Me.rowKAPALI, Me.rowKDVDAHIL, Me.rowIND, Me.rowSTOKKOD1, Me.rowSTOKKOD2, Me.rowSTOKKOD3, Me.rowSTOKKOD4, Me.rowSTOKKOD5, Me.rowOZELKODLAR, Me.rowSTOKTIPI, Me.rowTOP, Me.rowCARIKOD1, Me.rowCARIKOD2, Me.rowCARIKOD3, Me.rowCARIKOD4, Me.rowCARIKOD5, Me.rowHESAPKODU})
        Me.VGridControl1.Size = New System.Drawing.Size(446, 283)
        Me.VGridControl1.TabIndex = 0
        Me.VGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
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
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn20, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn19, Me.DataColumn21, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn81, Me.DataColumn82})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ILKTARIH"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "SONTARIH"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ILKBELGE"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "SONBELGE"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "FIRMAKODU"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "FIRMAADI"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "PERSONEL"
        Me.DataColumn8.DataType = GetType(Long)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "DEPO"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "PARABIRIMI"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KUR"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "KOD1"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KOD2"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "ACIKLAMA"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "KDVDAHIL"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "KAPALI"
        Me.DataColumn16.DataType = GetType(Boolean)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "QIND"
        Me.DataColumn17.DefaultValue = "Eþittir"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "QTARIH"
        Me.DataColumn18.DefaultValue = "Aralýk"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "QBELGENO"
        Me.DataColumn20.DefaultValue = "Aralýk"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "QFIRMAKODU"
        Me.DataColumn22.DefaultValue = "Baþlar"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "QFIRMAADI"
        Me.DataColumn23.DefaultValue = "Ýçerir"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "QPERSONEL"
        Me.DataColumn24.DefaultValue = "Eþittir"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "QDEPO"
        Me.DataColumn25.DefaultValue = "Eþittir"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "QPARABIRIMI"
        Me.DataColumn26.DefaultValue = "Eþittir"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "QKUR"
        Me.DataColumn27.DefaultValue = "Eþittir"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "QKOD1"
        Me.DataColumn28.DefaultValue = "Baþlar"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "QKOD2"
        Me.DataColumn29.DefaultValue = "Baþlar"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "QACIKLAMA"
        Me.DataColumn30.DefaultValue = "Ýçerir"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "QKAPALI"
        Me.DataColumn31.DefaultValue = "Eþittir"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "QKDVDAHIL"
        Me.DataColumn32.DefaultValue = "Eþittir"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "IZAHAT"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "QIZAHAT"
        Me.DataColumn21.DefaultValue = "Eþittir"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "STOKKODU"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "QSTOKKODU"
        Me.DataColumn46.DefaultValue = "Baþlar"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "MALINCINSI"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "QMALINCINSI"
        Me.DataColumn48.DefaultValue = "Ýçerir"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "STOKKOD1"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "QSTOKKOD1"
        Me.DataColumn50.DefaultValue = "Baþlar"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "STOKKOD2"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "QSTOKKOD2"
        Me.DataColumn52.DefaultValue = "Baþlar"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "STOKKOD3"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "QSTOKKOD3"
        Me.DataColumn54.DefaultValue = "Baþlar"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "STOKKOD4"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "QSTOKKOD4"
        Me.DataColumn56.DefaultValue = "Baþlar"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "STOKKOD5"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "QSTOKKOD5"
        Me.DataColumn58.DefaultValue = "Baþlar"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "OZELKODLAR"
        Me.DataColumn59.DefaultValue = "STOKKOD1"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "QOZELKODLAR"
        Me.DataColumn60.DefaultValue = "Eþittir"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "PERIYOD"
        Me.DataColumn61.DefaultValue = "Günlük"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "QPERIYOD"
        Me.DataColumn62.DefaultValue = "Eþittir"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "STOKTIPI"
        Me.DataColumn63.DataType = GetType(Long)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "QSTOKTIPI"
        Me.DataColumn64.DefaultValue = "Eþittir"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "TOP"
        Me.DataColumn65.DataType = GetType(Long)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "QTOP"
        Me.DataColumn66.DefaultValue = "Eþittir"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "CARIKOD1"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "CARIKOD2"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "CARIKOD3"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "CARIKOD4"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "CARIKOD5"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "QCARIKOD1"
        Me.DataColumn74.DefaultValue = "Baþlar"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "QCARIKOD2"
        Me.DataColumn75.DefaultValue = "Baþlar"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "QCARIKOD3"
        Me.DataColumn76.DefaultValue = "Baþlar"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "QCARIKOD4"
        Me.DataColumn77.DefaultValue = "Baþlar"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "QCARIKOD5"
        Me.DataColumn78.DefaultValue = "Baþlar"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "HESAPKODU"
        Me.DataColumn81.DefaultValue = "800-"
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "QHESAPKODU"
        Me.DataColumn82.DefaultValue = "Baþlar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties1, Me.MultiEditorRowProperties2, Me.MultiEditorRowProperties3})
        '
        'rowBELGENO
        '
        Me.rowBELGENO.Name = "rowBELGENO"
        Me.rowBELGENO.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties4, Me.MultiEditorRowProperties5, Me.MultiEditorRowProperties6})
        '
        'rowIZAHAT
        '
        Me.rowIZAHAT.Name = "rowIZAHAT"
        Me.rowIZAHAT.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties7, Me.MultiEditorRowProperties8})
        Me.rowIZAHAT.Visible = False
        '
        'rowPERIYOD
        '
        Me.rowPERIYOD.Name = "rowPERIYOD"
        Me.rowPERIYOD.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties9, Me.MultiEditorRowProperties10})
        Me.rowPERIYOD.Visible = False
        '
        'rowFIRMAKODU
        '
        Me.rowFIRMAKODU.Name = "rowFIRMAKODU"
        Me.rowFIRMAKODU.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties11, Me.MultiEditorRowProperties12})
        '
        'rowFIRMAADI
        '
        Me.rowFIRMAADI.Name = "rowFIRMAADI"
        Me.rowFIRMAADI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties13, Me.MultiEditorRowProperties14})
        '
        'rowSTOKKODU
        '
        Me.rowSTOKKODU.Name = "rowSTOKKODU"
        Me.rowSTOKKODU.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties15, Me.MultiEditorRowProperties16})
        Me.rowSTOKKODU.Visible = False
        '
        'rowMALINCINSI
        '
        Me.rowMALINCINSI.Name = "rowMALINCINSI"
        Me.rowMALINCINSI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties17, Me.MultiEditorRowProperties18})
        Me.rowMALINCINSI.Visible = False
        '
        'rowDEPO
        '
        Me.rowDEPO.Name = "rowDEPO"
        Me.rowDEPO.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties19, Me.MultiEditorRowProperties20})
        '
        'rowPERSONEL
        '
        Me.rowPERSONEL.Name = "rowPERSONEL"
        Me.rowPERSONEL.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties21, Me.MultiEditorRowProperties22})
        '
        'rowPARABIRIMI
        '
        Me.rowPARABIRIMI.Name = "rowPARABIRIMI"
        Me.rowPARABIRIMI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties23, Me.MultiEditorRowProperties24})
        Me.rowPARABIRIMI.Visible = False
        '
        'rowKUR
        '
        Me.rowKUR.Name = "rowKUR"
        Me.rowKUR.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties25, Me.MultiEditorRowProperties26})
        Me.rowKUR.Visible = False
        '
        'rowKOD1
        '
        Me.rowKOD1.Name = "rowKOD1"
        Me.rowKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties27, Me.MultiEditorRowProperties28})
        '
        'rowKOD2
        '
        Me.rowKOD2.Name = "rowKOD2"
        Me.rowKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties29, Me.MultiEditorRowProperties30})
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties31, Me.MultiEditorRowProperties32})
        Me.rowACIKLAMA.Visible = False
        '
        'rowKAPALI
        '
        Me.rowKAPALI.Name = "rowKAPALI"
        Me.rowKAPALI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties33, Me.MultiEditorRowProperties34})
        '
        'rowKDVDAHIL
        '
        Me.rowKDVDAHIL.Name = "rowKDVDAHIL"
        Me.rowKDVDAHIL.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties35, Me.MultiEditorRowProperties36})
        Me.rowKDVDAHIL.Visible = False
        '
        'rowIND
        '
        Me.rowIND.Name = "rowIND"
        Me.rowIND.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties37, Me.MultiEditorRowProperties38})
        '
        'rowSTOKKOD1
        '
        Me.rowSTOKKOD1.Name = "rowSTOKKOD1"
        Me.rowSTOKKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties39, Me.MultiEditorRowProperties40})
        Me.rowSTOKKOD1.Visible = False
        '
        'rowSTOKKOD2
        '
        Me.rowSTOKKOD2.Name = "rowSTOKKOD2"
        Me.rowSTOKKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties41, Me.MultiEditorRowProperties42})
        Me.rowSTOKKOD2.Visible = False
        '
        'rowSTOKKOD3
        '
        Me.rowSTOKKOD3.Name = "rowSTOKKOD3"
        Me.rowSTOKKOD3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties43, Me.MultiEditorRowProperties44})
        Me.rowSTOKKOD3.Visible = False
        '
        'rowSTOKKOD4
        '
        Me.rowSTOKKOD4.Name = "rowSTOKKOD4"
        Me.rowSTOKKOD4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties45, Me.MultiEditorRowProperties46})
        Me.rowSTOKKOD4.Visible = False
        '
        'rowSTOKKOD5
        '
        Me.rowSTOKKOD5.Name = "rowSTOKKOD5"
        Me.rowSTOKKOD5.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties47, Me.MultiEditorRowProperties48})
        Me.rowSTOKKOD5.Visible = False
        '
        'rowOZELKODLAR
        '
        Me.rowOZELKODLAR.Name = "rowOZELKODLAR"
        Me.rowOZELKODLAR.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties49, Me.MultiEditorRowProperties50})
        Me.rowOZELKODLAR.Visible = False
        '
        'rowSTOKTIPI
        '
        Me.rowSTOKTIPI.Name = "rowSTOKTIPI"
        Me.rowSTOKTIPI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties51, Me.MultiEditorRowProperties52})
        Me.rowSTOKTIPI.Visible = False
        '
        'rowTOP
        '
        Me.rowTOP.Name = "rowTOP"
        Me.rowTOP.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties53, Me.MultiEditorRowProperties54})
        Me.rowTOP.Visible = False
        '
        'rowCARIKOD1
        '
        Me.rowCARIKOD1.Name = "rowCARIKOD1"
        Me.rowCARIKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties55, Me.MultiEditorRowProperties56})
        Me.rowCARIKOD1.Visible = False
        '
        'rowCARIKOD2
        '
        Me.rowCARIKOD2.Name = "rowCARIKOD2"
        Me.rowCARIKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties57, Me.MultiEditorRowProperties58})
        Me.rowCARIKOD2.Visible = False
        '
        'rowCARIKOD3
        '
        Me.rowCARIKOD3.Name = "rowCARIKOD3"
        Me.rowCARIKOD3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties59, Me.MultiEditorRowProperties60})
        Me.rowCARIKOD3.Visible = False
        '
        'rowCARIKOD4
        '
        Me.rowCARIKOD4.Name = "rowCARIKOD4"
        Me.rowCARIKOD4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties61, Me.MultiEditorRowProperties62})
        Me.rowCARIKOD4.Visible = False
        '
        'rowCARIKOD5
        '
        Me.rowCARIKOD5.Name = "rowCARIKOD5"
        Me.rowCARIKOD5.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties63, Me.MultiEditorRowProperties64})
        Me.rowCARIKOD5.Visible = False
        '
        'rowHESAPKODU
        '
        Me.rowHESAPKODU.Name = "rowHESAPKODU"
        Me.rowHESAPKODU.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties65, Me.MultiEditorRowProperties66})
        Me.rowHESAPKODU.Visible = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.MemoEdit1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(450, 279)
        Me.XtraTabPage2.Text = "Sql"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.EditValue = "SELECT * FROM *!F!DTBLBELGELER"
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(450, 279)
        Me.MemoEdit1.TabIndex = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'ds_stoktipi
        '
        Me.ds_stoktipi.DataSetName = "NewDataSet"
        Me.ds_stoktipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_stoktipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "NewDataSet"
        Me.DataSet3.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet3.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'ds_belgetipi
        '
        Me.ds_belgetipi.DataSetName = "NewDataSet"
        Me.ds_belgetipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_belgetipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'frm_fatura_ara
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(456, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_fatura_ara"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Belge Ara"
        CType(Me.sec_kriter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_izahat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_periyod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_personel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ozelkodlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_stoktipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_stoktipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim dr As DataRow
    Public kayitno
    Public ilktarih
    Public sontarih
    Public ilkbelge
    Public sonbelge
    Public firmakodu
    Public firmaadi
    Public personel
    Public depo
    Public parabirimi
    Public kur
    Public kod1
    Public kod2
    Public aciklama
    Public kdvdahil
    Public kapali
    Public izahat
    Public stokkodu
    Public malincinsi
    Public stokkod1
    Public stokkod2
    Public stokkod3
    Public stokkod4
    Public stokkod5
    Public ozelkodlar
    Public periyod
    Public stoktipi
    Public toplist
    Public carikod1
    Public carikod2
    Public carikod3
    Public carikod4
    Public carikod5
    Public hesapkodu
    Public qkayitno
    Public qilktarih
    Public qsontarih
    Public qilkbelge
    Public qsonbelge
    Public qfirmakodu
    Public qfirmaadi
    Public qpersonel
    Public qdepo
    Public qparabirimi
    Public qkur
    Public qkod1
    Public qkod2
    Public qaciklama
    Public qkdvdahil
    Public qkapali
    Public qizahat
    Public qstokkodu
    Public qmalincinsi
    Public qstokkod1
    Public qstokkod2
    Public qstokkod3
    Public qstokkod4
    Public qstokkod5
    Public qcarikod1
    Public qcarikod2
    Public qcarikod3
    Public qcarikod4
    Public qcarikod5
    Public qozelkodlar
    Public qperiyod
    Public qstoktipi
    Public qtoplist
    Public qhesapkodu
    Public belge As String
    Public connection, firmano, donemno, kullanici
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Private Sub frm_fatura_ara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sec_depo.DataSource = sorgu_s(sorgu_query("SELECT     sDepo AS DEPO, sAciklama AS DEPOADI  FROM         tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        If belge = "Fatura Ýþlemleri" Then
            belgetipleri_fatura()
        ElseIf belge = "Peþin Ýþlemleri" Then
            belgetipleri_pesin()
        ElseIf belge = "Stok Ýþlemleri" Then
            belgetipleri_stok()
        ElseIf belge = "Sipariþ Ýþlemleri" Then
            belgetipleri_siparis()
        Else
        End If
        dataload()
        'dataload_personel()
        stoktipleri()
        belgetipleri()
        VGridControl1.Select()
        VGridControl1.FocusedRecordCellIndex() = 0
    End Sub
    Private Sub stoktipleri()
        Dim dr1 As DataRow = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 0
        dr1("ACIKLAMA") = "Ticari Mal"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 3
        dr1("ACIKLAMA") = "Hizmet"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 6
        dr1("ACIKLAMA") = "Promosyon"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 7
        dr1("ACIKLAMA") = "Seri(Kombini)"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 8
        dr1("ACIKLAMA") = "Seri(Detay)"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 9
        dr1("ACIKLAMA") = "Grup"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 12
        dr1("ACIKLAMA") = "Masraf"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 18
        dr1("ACIKLAMA") = "Hammadde"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 19
        dr1("ACIKLAMA") = "Mamül"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stoktipi.Tables(0).NewRow
        dr1("IND") = 21
        dr1("ACIKLAMA") = "Yarý Mamül"
        ds_stoktipi.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub belgetipleri()
        Dim dr1 As DataRow = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "FA"
        dr1("ACIKLAMA") = "Alýþ Faturasý"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "K"
        dr1("ACIKLAMA") = "Kredili Satýþ"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "P"
        dr1("ACIKLAMA") = "Peþin Satýþ"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "PF"
        dr1("ACIKLAMA") = "Sonradan Teslim Onaylý"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Function sorgu_s(ByVal query As String) As DataSet
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
    Private Sub sorgu()
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
        For Each dr In DataSet1.Tables(0).Rows
            kayitno = dr("IND").ToString
            ilktarih = dr("ILKTARIH").ToString
            sontarih = dr("SONTARIH").ToString
            ilkbelge = dr("ILKBELGE").ToString
            sonbelge = dr("SONBELGE").ToString
            firmakodu = dr("FIRMAKODU").ToString
            firmaadi = dr("FIRMAADI").ToString
            personel = dr("PERSONEL").ToString
            depo = dr("DEPO").ToString
            parabirimi = dr("PARABIRIMI").ToString
            kur = dr("KUR").ToString
            kod1 = dr("KOD1").ToString
            kod2 = dr("KOD2").ToString
            aciklama = dr("ACIKLAMA").ToString
            kdvdahil = dr("KDVDAHIL").ToString
            kapali = dr("KAPALI").ToString
            izahat = dr("IZAHAT").ToString
            stokkodu = dr("STOKKODU").ToString
            malincinsi = dr("MALINCINSI").ToString
            stokkod1 = dr("STOKKOD1").ToString
            stokkod2 = dr("STOKKOD2").ToString
            stokkod3 = dr("STOKKOD3").ToString
            stokkod4 = dr("STOKKOD4").ToString
            stokkod5 = dr("STOKKOD5").ToString
            carikod1 = dr("CARIKOD1").ToString
            carikod2 = dr("CARIKOD2").ToString
            carikod3 = dr("CARIKOD3").ToString
            carikod4 = dr("CARIKOD4").ToString
            carikod5 = dr("CARIKOD5").ToString
            ozelkodlar = dr("OZELKODLAR").ToString
            periyod = dr("PERIYOD").ToString
            stoktipi = dr("STOKTIPI").ToString
            toplist = dr("TOP").ToString
            hesapkodu = dr("HESAPKODU").ToString
            qkayitno = dr("QIND").ToString
            qilktarih = dr("QTARIH").ToString
            qsontarih = dr("QTARIH").ToString
            qilkbelge = dr("QBELGENO").ToString
            qsonbelge = dr("QBELGENO").ToString
            qfirmakodu = dr("QFIRMAKODU").ToString
            qfirmaadi = dr("QFIRMAADI").ToString
            qpersonel = dr("QPERSONEL").ToString
            qdepo = dr("QDEPO").ToString
            qparabirimi = dr("QPARABIRIMI").ToString
            qkur = dr("QKUR").ToString
            qkod1 = dr("QKOD1").ToString
            qkod2 = dr("QKOD2").ToString
            qaciklama = dr("QACIKLAMA").ToString
            qkdvdahil = dr("QKDVDAHIL").ToString
            qkapali = dr("QKAPALI").ToString
            qizahat = dr("QIZAHAT").ToString
            qstokkodu = dr("QSTOKKODU").ToString
            qmalincinsi = dr("QMALINCINSI").ToString
            qstokkod1 = dr("QSTOKKOD1").ToString
            qstokkod2 = dr("QSTOKKOD2").ToString
            qstokkod3 = dr("QSTOKKOD3").ToString
            qstokkod4 = dr("QSTOKKOD4").ToString
            qstokkod5 = dr("QSTOKKOD5").ToString
            qcarikod1 = dr("QCARIKOD1").ToString
            qcarikod2 = dr("QCARIKOD2").ToString
            qcarikod3 = dr("QCARIKOD3").ToString
            qcarikod4 = dr("QCARIKOD4").ToString
            qcarikod5 = dr("QCARIKOD5").ToString
            qozelkodlar = dr("QOZELKODLAR").ToString
            qperiyod = dr("QPERIYOD").ToString
            qstoktipi = dr("QSTOKTIPI").ToString
            qtoplist = dr("QTOP").ToString
            qhesapkodu = dr("QHESAPKODU").ToString
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub dataload()
        dr = DataSet1.Tables(0).NewRow
        dr("ILKTARIH") = Today
        dr("SONTARIH") = Today
        dr("IZAHAT") = "FA"
        'If belge = "Fatura Ýþlemleri" Then
        '    dr("IZAHAT") = 21
        'ElseIf belge = "Peþin Ýþlemleri" Then
        '    dr("IZAHAT") = 25
        'ElseIf belge = "Stok Ýþlemleri" Then
        '    dr("IZAHAT") = 33
        'ElseIf belge = "Sipariþ Ýþlemleri" Then
        '    dr("IZAHAT") = 60
        'Else
        'End If
        DataSet1.Tables(0).Rows.Add(dr)
        VGridControl1.DataSource = DataSet1.Tables(0)
        VGridControl1.DataMember = Nothing
    End Sub
    Private Sub dataload_personel()
        Try
            DataSet3 = sorgu(sorgu_query("SELECT IND,KODU, AD AS ACIKLAMA,PRIM FROM *!FTBLPERSONEL WHERE KODU <>''"))
            sec_personel.DataSource = DataSet3.Tables(0)
        Catch ex As Exception
        End Try
        'DataSet3 = sorgu(sorgu_query("SELECT IND,KODU, AD AS ACIKLAMA,PRIM FROM *!FTBLPERSONEL WHERE KODU <>''"))
        'sec_personel.Properties.DataSource = ds_personel.Tables(0)
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
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        sorgu()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub VGridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub belgetipleri_pesin()
        Dim dr As DataRow = DataSet2.Tables(0).NewRow
        dr("IND") = 86
        dr("IZAHAT") = "Peþin Alýþ Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLALFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLALFATHAREKET")
        dr("GIRIS") = 1
        dr("IADE") = 0
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 25
        dr("IZAHAT") = "Peþin Satýþ Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLSATFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLSATFATHAREKET")
        dr("GIRIS") = 0
        dr("IADE") = 0
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 88
        dr("IZAHAT") = "Peþin Alýþ Ýade Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLALFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLALFATHAREKET")
        dr("GIRIS") = 1
        dr("IADE") = 1
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 87
        dr("IZAHAT") = "Peþin Satýþ Ýade Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLSATFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLSATFATHAREKET")
        dr("GIRIS") = 0
        dr("IADE") = 1
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 100
        dr("IZAHAT") = "Pos Satýþ Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLSATFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLSATFATHAREKET")
        dr("GIRIS") = 0
        dr("IADE") = 0
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = Nothing
    End Sub
    Private Sub belgetipleri_stok()
        Dim dr As DataRow = DataSet2.Tables(0).NewRow
        dr("IND") = 32
        dr("IZAHAT") = "Stok Giriþ Fiþi"
        dr("BASLIK") = sorgu_query("*!F!DTBLSTKGIRBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLSTKGIRHAREKET")
        dr("GIRIS") = 1
        dr("IADE") = 0
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 33
        dr("IZAHAT") = "Stok Çýkýþ Fiþi"
        dr("BASLIK") = sorgu_query("*!F!DTBLSTKCIKBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLSTKCIKHAREKET")
        dr("GIRIS") = 0
        dr("IADE") = 0
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 37
        dr("IZAHAT") = "Depolar Arasý Sevkiyat"
        dr("BASLIK") = sorgu_query("*!F!DTBLDEPOHARBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLDEPOHARHAREKET")
        dr("GIRIS") = 1
        dr("IADE") = 0
        dr("STKH") = 0
        dr("CH") = 0
        dr("CGH") = 0
        dr("DEPOH") = 0
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = Nothing
    End Sub
    Private Sub belgetipleri_fatura()
        Dim dr As DataRow = DataSet2.Tables(0).NewRow
        dr("IND") = 20
        dr("IZAHAT") = "Alýþ Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLALFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLALFATHAREKET")
        dr("GIRIS") = 1
        dr("IADE") = 0
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 21
        dr("IZAHAT") = "Satýþ Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLSATFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLSATFATHAREKET")
        dr("GIRIS") = 0
        dr("IADE") = 0
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 24
        dr("IZAHAT") = "Proforma Fatura"
        dr("BASLIK") = sorgu_query("*!F!DTBLPROFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLPROFATHAREKET")
        dr("GIRIS") = 0
        dr("IADE") = 0
        dr("STKH") = 0
        dr("CH") = 0
        dr("CGH") = 0
        dr("DEPOH") = 0
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 22
        dr("IZAHAT") = "Alýþ Ýade Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLALFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLALFATHAREKET")
        dr("GIRIS") = 1
        dr("IADE") = 1
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 23
        dr("IZAHAT") = "Satýþ Ýade Faturasý"
        dr("BASLIK") = sorgu_query("*!F!DTBLSATFATBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLSATFATHAREKET")
        dr("GIRIS") = 0
        dr("IADE") = 1
        dr("STKH") = 1
        dr("CH") = 1
        dr("CGH") = 1
        dr("DEPOH") = 1
        dr("SIPH") = 0
        DataSet2.Tables(0).Rows.Add(dr)
        dr = Nothing
    End Sub
    Private Sub belgetipleri_siparis()
        Dim dr As DataRow = DataSet2.Tables(0).NewRow
        dr("IND") = 61
        dr("IZAHAT") = "Verilen Sipariþ"
        dr("BASLIK") = sorgu_query("*!F!DTBLVERSIPBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLVERSIPHAREKET")
        dr("ALTTABLO") = sorgu_query("*!F!DTBLVERSIPLIST")
        dr("GIRIS") = 1
        dr("IADE") = 0
        dr("STKH") = 0
        dr("CH") = 0
        dr("CGH") = 1
        dr("DEPOH") = 0
        dr("SIPH") = 1
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr("IND") = 60
        dr("IZAHAT") = "Alýnan Sipariþ"
        dr("BASLIK") = sorgu_query("*!F!DTBLALSIPBASLIK")
        dr("HAREKET") = sorgu_query("*!F!DTBLALSIPHAREKET")
        dr("ALTTABLO") = sorgu_query("*!F!DTBLALSIPLIST")
        dr("GIRIS") = 0
        dr("IADE") = 0
        dr("STKH") = 0
        dr("CH") = 0
        dr("CGH") = 1
        dr("DEPOH") = 0
        dr("SIPH") = 1
        DataSet2.Tables(0).Rows.Add(dr)
        dr = Nothing
    End Sub
    Private Sub ozelkod_s(ByVal kod As String, ByVal modul As String, ByVal row As String)
        'Dim frm As New frm_ozelkod
        'frm.connection = connection
        'frm.firmano = firmano
        'frm.donemno = donemno
        'frm.modul = modul
        'frm.category = kod
        'If frm.ShowDialog(Me) = DialogResult.OK Then
        '    dr("" & row & "") = frm.ozelkod.ToString
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
    Private Sub VGridControl1_FocusedRecordCellChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.IndexChangedEventArgs) Handles VGridControl1.FocusedRecordCellChanged
        Try
            VGridControl1.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ozelkod_sec()
        If VGridControl1.FocusedRow.Name = rowKOD1.Name Then
            ozelkod_s(1, "BELGE", "KOD1")
        ElseIf VGridControl1.FocusedRow.Name = rowKOD2.Name Then
            ozelkod_s(2, "BELGE", "KOD2")
        ElseIf VGridControl1.FocusedRow.Name = rowSTOKKOD1.Name Then
            ozelkod_s(1, "STOK", "STOKKOD1")
        ElseIf VGridControl1.FocusedRow.Name = rowSTOKKOD2.Name Then
            ozelkod_s(2, "STOK", "STOKKOD2")
        ElseIf VGridControl1.FocusedRow.Name = rowSTOKKOD3.Name Then
            ozelkod_s(3, "STOK", "STOKKOD3")
        ElseIf VGridControl1.FocusedRow.Name = rowSTOKKOD4.Name Then
            ozelkod_s(4, "STOK", "STOKKOD4")
        ElseIf VGridControl1.FocusedRow.Name = rowSTOKKOD5.Name Then
            ozelkod_s(5, "STOK", "STOKKOD5")
        ElseIf VGridControl1.FocusedRow.Name = rowCARIKOD1.Name Then
            ozelkod_s(1, "CARI", "CARIKOD1")
        ElseIf VGridControl1.FocusedRow.Name = rowCARIKOD2.Name Then
            ozelkod_s(2, "CARI", "CARIKOD2")
        ElseIf VGridControl1.FocusedRow.Name = rowCARIKOD3.Name Then
            ozelkod_s(3, "CARI", "CARIKOD3")
        ElseIf VGridControl1.FocusedRow.Name = rowCARIKOD4.Name Then
            ozelkod_s(4, "CARI", "CARIKOD4")
        ElseIf VGridControl1.FocusedRow.Name = rowCARIKOD5.Name Then
            ozelkod_s(5, "CARI", "CARIKOD5")
        End If
    End Sub
    Private Sub sec_ozelkod_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_ozelkod.ButtonClick
        ozelkod_sec()
    End Sub
End Class
