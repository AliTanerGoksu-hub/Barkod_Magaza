Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.Utils
Imports Microsoft.Win32
Imports System.IO
Imports System.Windows.Forms
Public Class frm_cari_ara
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
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
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents sec_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_firmatipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_kayitno As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents DataSet3 As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents sec_personel As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents rowFIRMAKODU As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowFIRMAADI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowADRES As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowPERSONEL As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKOD5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowTELEFON As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowISTIHBARAT As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowFIRMATIPI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowKAYITNO As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents rowAKTIF As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents rowKRITER As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_bakiye_tipi As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents sec_tarih As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents rowOPSIYON As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowFAIZ As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowDURUM As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowLISTELE As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_durum As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_listeleme As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
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
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents rowVADE As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKOD5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowASIPARIS As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowVSIPARIS As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSTOKKODU As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowMALINCINSI As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents rowBELGEKOD1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowBELGEKOD2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_kriter_alinan_siparis As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_kriter_verilen_siparis As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rowTARIH2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents sec_ozelkod As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents sec_periyod As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rowPERIYOD As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
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
    Friend WithEvents MultiEditorRowProperties67 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties68 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties69 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties70 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties71 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties72 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents rowLIMIT As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari_ara))
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_kriter = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_ozelkod = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.MultiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties11 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties12 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties13 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_aciklama = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties14 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties15 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties16 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties17 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties18 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties19 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties20 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties21 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties22 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties23 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_bakiye_tipi = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties24 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties25 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_personel = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.MultiEditorRowProperties26 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties27 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties28 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties29 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties30 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties31 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_durum = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties32 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties33 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_listeleme = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
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
        Me.MultiEditorRowProperties50 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties51 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_periyod = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties52 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties53 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_firmatipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.MultiEditorRowProperties54 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties55 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_kriter_alinan_siparis = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties56 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties57 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_kriter_verilen_siparis = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.MultiEditorRowProperties58 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties59 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties60 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties61 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties62 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties63 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties64 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties65 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties66 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties67 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties68 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties69 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties70 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties71 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_kayitno = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.MultiEditorRowProperties72 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_tarih = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
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
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowVADE = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowBELGEKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowBELGEKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowTARIH2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowFIRMAKODU = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowFIRMAADI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKODU = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowMALINCINSI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowADRES = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKRITER = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowPERSONEL = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowOPSIYON = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowFAIZ = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowDURUM = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowLISTELE = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowTELEFON = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowISTIHBARAT = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowAKTIF = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowPERIYOD = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowFIRMATIPI = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowASIPARIS = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowVSIPARIS = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowLIMIT = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowSTOKKOD5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowKAYITNO = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.DataSet2 = New System.Data.DataSet()
        Me.DataSet3 = New System.Data.DataSet()
        CType(Me.sec_kriter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bakiye_tipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_personel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_durum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_listeleme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_periyod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_firmatipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_alinan_siparis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_verilen_siparis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kayitno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tarih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tarih.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.Caption = "Tarih Aralığı"
        Me.MultiEditorRowProperties1.CellWidth = 74
        Me.MultiEditorRowProperties1.FieldName = "TARIH1"
        Me.MultiEditorRowProperties1.Format.FormatString = "dd.MM.yyyy"
        Me.MultiEditorRowProperties1.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.MultiEditorRowProperties1.ImageIndex = 0
        Me.MultiEditorRowProperties1.Width = 108
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.CellWidth = 72
        Me.MultiEditorRowProperties2.FieldName = "TARIH2"
        Me.MultiEditorRowProperties2.Width = 38
        '
        'MultiEditorRowProperties3
        '
        Me.MultiEditorRowProperties3.CellWidth = 48
        Me.MultiEditorRowProperties3.FieldName = "QTARIH"
        Me.MultiEditorRowProperties3.ReadOnly = True
        Me.MultiEditorRowProperties3.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties3.Width = 15
        '
        'sec_kriter
        '
        Me.sec_kriter.AutoHeight = False
        Me.sec_kriter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "İçermez", "Boş", "Dolu", "Farklı", "Büyük", "Küçük"})
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.NullText = "Başlar"
        Me.sec_kriter.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties4
        '
        Me.MultiEditorRowProperties4.Caption = "Termin Tarihi"
        Me.MultiEditorRowProperties4.CellWidth = 74
        Me.MultiEditorRowProperties4.FieldName = "VADE1"
        Me.MultiEditorRowProperties4.ImageIndex = 0
        Me.MultiEditorRowProperties4.Width = 108
        '
        'MultiEditorRowProperties5
        '
        Me.MultiEditorRowProperties5.CellWidth = 72
        Me.MultiEditorRowProperties5.FieldName = "VADE2"
        Me.MultiEditorRowProperties5.Width = 38
        '
        'MultiEditorRowProperties6
        '
        Me.MultiEditorRowProperties6.CellWidth = 48
        Me.MultiEditorRowProperties6.FieldName = "QVADE"
        Me.MultiEditorRowProperties6.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties6.Width = 15
        '
        'MultiEditorRowProperties7
        '
        Me.MultiEditorRowProperties7.Caption = "BelgeÖzelKod1"
        Me.MultiEditorRowProperties7.CellWidth = 124
        Me.MultiEditorRowProperties7.FieldName = "BELGEKOD1"
        Me.MultiEditorRowProperties7.ImageIndex = 0
        Me.MultiEditorRowProperties7.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties7.Width = 30
        '
        'sec_ozelkod
        '
        Me.sec_ozelkod.AutoHeight = False
        Me.sec_ozelkod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ozelkod.Name = "sec_ozelkod"
        '
        'MultiEditorRowProperties8
        '
        Me.MultiEditorRowProperties8.CellWidth = 41
        Me.MultiEditorRowProperties8.FieldName = "QBELGEKOD1"
        Me.MultiEditorRowProperties8.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties8.Width = 15
        '
        'MultiEditorRowProperties9
        '
        Me.MultiEditorRowProperties9.Caption = "BelgeÖzelKod2"
        Me.MultiEditorRowProperties9.CellWidth = 124
        Me.MultiEditorRowProperties9.FieldName = "BELGEKOD2"
        Me.MultiEditorRowProperties9.ImageIndex = 0
        Me.MultiEditorRowProperties9.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties9.Width = 30
        '
        'MultiEditorRowProperties10
        '
        Me.MultiEditorRowProperties10.CellWidth = 41
        Me.MultiEditorRowProperties10.FieldName = "QBELGEKOD2"
        Me.MultiEditorRowProperties10.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties10.Width = 15
        '
        'MultiEditorRowProperties11
        '
        Me.MultiEditorRowProperties11.Caption = "Tarih"
        Me.MultiEditorRowProperties11.CellWidth = 124
        Me.MultiEditorRowProperties11.FieldName = "TARIH2"
        Me.MultiEditorRowProperties11.ImageIndex = 0
        Me.MultiEditorRowProperties11.Width = 30
        '
        'MultiEditorRowProperties12
        '
        Me.MultiEditorRowProperties12.CellWidth = 41
        Me.MultiEditorRowProperties12.FieldName = "QTARIH"
        Me.MultiEditorRowProperties12.ReadOnly = True
        Me.MultiEditorRowProperties12.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties12.Width = 15
        '
        'MultiEditorRowProperties13
        '
        Me.MultiEditorRowProperties13.Caption = "Firma Kodu"
        Me.MultiEditorRowProperties13.CellWidth = 124
        Me.MultiEditorRowProperties13.FieldName = "FIRMAKODU"
        Me.MultiEditorRowProperties13.ImageIndex = 0
        Me.MultiEditorRowProperties13.RowEdit = Me.sec_aciklama
        Me.MultiEditorRowProperties13.Width = 30
        '
        'sec_aciklama
        '
        Me.sec_aciklama.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_aciklama.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_aciklama.Appearance.ForeColor = System.Drawing.Color.Black
        Me.sec_aciklama.Appearance.Options.UseBackColor = True
        Me.sec_aciklama.Appearance.Options.UseForeColor = True
        Me.sec_aciklama.AutoHeight = False
        Me.sec_aciklama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_aciklama.Name = "sec_aciklama"
        '
        'MultiEditorRowProperties14
        '
        Me.MultiEditorRowProperties14.CellWidth = 41
        Me.MultiEditorRowProperties14.FieldName = "QFIRMAKODU"
        Me.MultiEditorRowProperties14.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties14.Width = 15
        '
        'MultiEditorRowProperties15
        '
        Me.MultiEditorRowProperties15.Caption = "Firma Adı"
        Me.MultiEditorRowProperties15.CellWidth = 124
        Me.MultiEditorRowProperties15.FieldName = "FIRMAADI"
        Me.MultiEditorRowProperties15.ImageIndex = 0
        Me.MultiEditorRowProperties15.RowEdit = Me.sec_aciklama
        Me.MultiEditorRowProperties15.Width = 30
        '
        'MultiEditorRowProperties16
        '
        Me.MultiEditorRowProperties16.CellWidth = 41
        Me.MultiEditorRowProperties16.FieldName = "QFIRMAADI"
        Me.MultiEditorRowProperties16.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties16.Width = 15
        '
        'MultiEditorRowProperties17
        '
        Me.MultiEditorRowProperties17.Caption = "Müşteri Adı"
        Me.MultiEditorRowProperties17.CellWidth = 124
        Me.MultiEditorRowProperties17.FieldName = "STOKKODU"
        Me.MultiEditorRowProperties17.ImageIndex = 0
        Me.MultiEditorRowProperties17.Width = 30
        '
        'MultiEditorRowProperties18
        '
        Me.MultiEditorRowProperties18.CellWidth = 41
        Me.MultiEditorRowProperties18.FieldName = "QSTOKKODU"
        Me.MultiEditorRowProperties18.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties18.Width = 15
        '
        'MultiEditorRowProperties19
        '
        Me.MultiEditorRowProperties19.Caption = "MüşteriSoyadı"
        Me.MultiEditorRowProperties19.CellWidth = 124
        Me.MultiEditorRowProperties19.FieldName = "MALINCINSI"
        Me.MultiEditorRowProperties19.ImageIndex = 0
        Me.MultiEditorRowProperties19.Width = 30
        '
        'MultiEditorRowProperties20
        '
        Me.MultiEditorRowProperties20.CellWidth = 41
        Me.MultiEditorRowProperties20.FieldName = "QMALINCINSI"
        Me.MultiEditorRowProperties20.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties20.Width = 15
        '
        'MultiEditorRowProperties21
        '
        Me.MultiEditorRowProperties21.Caption = "Adres"
        Me.MultiEditorRowProperties21.CellWidth = 124
        Me.MultiEditorRowProperties21.FieldName = "ADRES"
        Me.MultiEditorRowProperties21.ImageIndex = 0
        Me.MultiEditorRowProperties21.Width = 30
        '
        'MultiEditorRowProperties22
        '
        Me.MultiEditorRowProperties22.CellWidth = 41
        Me.MultiEditorRowProperties22.FieldName = "QADRES"
        Me.MultiEditorRowProperties22.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties22.Width = 15
        '
        'MultiEditorRowProperties23
        '
        Me.MultiEditorRowProperties23.Caption = "Bakiye Durumu"
        Me.MultiEditorRowProperties23.CellWidth = 124
        Me.MultiEditorRowProperties23.FieldName = "KRITER"
        Me.MultiEditorRowProperties23.ImageIndex = 0
        Me.MultiEditorRowProperties23.RowEdit = Me.sec_bakiye_tipi
        Me.MultiEditorRowProperties23.Width = 328
        '
        'sec_bakiye_tipi
        '
        Me.sec_bakiye_tipi.AutoHeight = False
        Me.sec_bakiye_tipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_bakiye_tipi.Items.AddRange(New Object() {"Borç Bakiyesi Verenler", "Alacak Bakiyesi Verenler", "Bakiye Verenler", "Bakiyesizler", "Hepsi"})
        Me.sec_bakiye_tipi.Name = "sec_bakiye_tipi"
        Me.sec_bakiye_tipi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties24
        '
        Me.MultiEditorRowProperties24.CellWidth = 41
        Me.MultiEditorRowProperties24.FieldName = "QKRITER"
        Me.MultiEditorRowProperties24.ReadOnly = True
        Me.MultiEditorRowProperties24.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties24.Width = 166
        '
        'MultiEditorRowProperties25
        '
        Me.MultiEditorRowProperties25.Caption = "Personel"
        Me.MultiEditorRowProperties25.CellWidth = 124
        Me.MultiEditorRowProperties25.FieldName = "PERSONEL"
        Me.MultiEditorRowProperties25.ImageIndex = 0
        Me.MultiEditorRowProperties25.RowEdit = Me.sec_personel
        Me.MultiEditorRowProperties25.Width = 30
        '
        'sec_personel
        '
        Me.sec_personel.AutoHeight = False
        Me.sec_personel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_personel.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "KayıtNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açıklama")})
        Me.sec_personel.DataSource = Me.DataTable3
        Me.sec_personel.DisplayMember = "ACIKLAMA"
        Me.sec_personel.Name = "sec_personel"
        Me.sec_personel.NullText = "[Hepsi]"
        Me.sec_personel.ValueMember = "IND"
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn29, Me.DataColumn30})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "IND"
        Me.DataColumn29.DataType = GetType(Long)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ACIKLAMA"
        '
        'MultiEditorRowProperties26
        '
        Me.MultiEditorRowProperties26.CellWidth = 41
        Me.MultiEditorRowProperties26.FieldName = "QPERSONEL"
        Me.MultiEditorRowProperties26.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties26.Width = 15
        '
        'MultiEditorRowProperties27
        '
        Me.MultiEditorRowProperties27.Caption = "Opsiyon(Gün)"
        Me.MultiEditorRowProperties27.CellWidth = 124
        Me.MultiEditorRowProperties27.FieldName = "OPSIYON"
        Me.MultiEditorRowProperties27.ImageIndex = 0
        Me.MultiEditorRowProperties27.Width = 328
        '
        'MultiEditorRowProperties28
        '
        Me.MultiEditorRowProperties28.CellWidth = 41
        Me.MultiEditorRowProperties28.FieldName = "QOPSIYON"
        Me.MultiEditorRowProperties28.ReadOnly = True
        Me.MultiEditorRowProperties28.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties28.Width = 166
        '
        'MultiEditorRowProperties29
        '
        Me.MultiEditorRowProperties29.Caption = "Faiz"
        Me.MultiEditorRowProperties29.CellWidth = 124
        Me.MultiEditorRowProperties29.FieldName = "FAIZ"
        Me.MultiEditorRowProperties29.ImageIndex = 0
        Me.MultiEditorRowProperties29.Width = 328
        '
        'MultiEditorRowProperties30
        '
        Me.MultiEditorRowProperties30.CellWidth = 41
        Me.MultiEditorRowProperties30.FieldName = "QFAIZ"
        Me.MultiEditorRowProperties30.ReadOnly = True
        Me.MultiEditorRowProperties30.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties30.Width = 166
        '
        'MultiEditorRowProperties31
        '
        Me.MultiEditorRowProperties31.Caption = "Durum"
        Me.MultiEditorRowProperties31.CellWidth = 124
        Me.MultiEditorRowProperties31.FieldName = "DURUM"
        Me.MultiEditorRowProperties31.ImageIndex = 0
        Me.MultiEditorRowProperties31.RowEdit = Me.sec_durum
        Me.MultiEditorRowProperties31.Width = 328
        '
        'sec_durum
        '
        Me.sec_durum.AutoHeight = False
        Me.sec_durum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_durum.Items.AddRange(New Object() {"Alacaklar", "Borçlar"})
        Me.sec_durum.Name = "sec_durum"
        Me.sec_durum.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties32
        '
        Me.MultiEditorRowProperties32.CellWidth = 41
        Me.MultiEditorRowProperties32.FieldName = "QDURUM"
        Me.MultiEditorRowProperties32.ReadOnly = True
        Me.MultiEditorRowProperties32.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties32.Width = 166
        '
        'MultiEditorRowProperties33
        '
        Me.MultiEditorRowProperties33.Caption = "Listeleme"
        Me.MultiEditorRowProperties33.CellWidth = 124
        Me.MultiEditorRowProperties33.FieldName = "LISTELE"
        Me.MultiEditorRowProperties33.ImageIndex = 0
        Me.MultiEditorRowProperties33.RowEdit = Me.sec_listeleme
        Me.MultiEditorRowProperties33.Width = 328
        '
        'sec_listeleme
        '
        Me.sec_listeleme.AutoHeight = False
        Me.sec_listeleme.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_listeleme.Items.AddRange(New Object() {"Detaylı", "Özet"})
        Me.sec_listeleme.Name = "sec_listeleme"
        Me.sec_listeleme.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties34
        '
        Me.MultiEditorRowProperties34.CellWidth = 41
        Me.MultiEditorRowProperties34.FieldName = "QLISTELE"
        Me.MultiEditorRowProperties34.ReadOnly = True
        Me.MultiEditorRowProperties34.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties34.Width = 166
        '
        'MultiEditorRowProperties35
        '
        Me.MultiEditorRowProperties35.Caption = "Sınıf 1"
        Me.MultiEditorRowProperties35.CellWidth = 124
        Me.MultiEditorRowProperties35.FieldName = "KOD1"
        Me.MultiEditorRowProperties35.ImageIndex = 0
        Me.MultiEditorRowProperties35.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties35.Width = 30
        '
        'MultiEditorRowProperties36
        '
        Me.MultiEditorRowProperties36.CellWidth = 41
        Me.MultiEditorRowProperties36.FieldName = "QKOD1"
        Me.MultiEditorRowProperties36.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties36.Width = 15
        '
        'MultiEditorRowProperties37
        '
        Me.MultiEditorRowProperties37.Caption = "Sınıf 2"
        Me.MultiEditorRowProperties37.CellWidth = 124
        Me.MultiEditorRowProperties37.FieldName = "KOD2"
        Me.MultiEditorRowProperties37.ImageIndex = 0
        Me.MultiEditorRowProperties37.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties37.Width = 87
        '
        'MultiEditorRowProperties38
        '
        Me.MultiEditorRowProperties38.CellWidth = 41
        Me.MultiEditorRowProperties38.FieldName = "QKOD2"
        Me.MultiEditorRowProperties38.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties38.Width = 44
        '
        'MultiEditorRowProperties39
        '
        Me.MultiEditorRowProperties39.Caption = "Sınıf 3"
        Me.MultiEditorRowProperties39.CellWidth = 124
        Me.MultiEditorRowProperties39.FieldName = "KOD3"
        Me.MultiEditorRowProperties39.ImageIndex = 0
        Me.MultiEditorRowProperties39.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties39.Width = 327
        '
        'MultiEditorRowProperties40
        '
        Me.MultiEditorRowProperties40.CellWidth = 41
        Me.MultiEditorRowProperties40.FieldName = "QKOD3"
        Me.MultiEditorRowProperties40.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties40.Width = 167
        '
        'MultiEditorRowProperties41
        '
        Me.MultiEditorRowProperties41.Caption = "Sınıf 4"
        Me.MultiEditorRowProperties41.CellWidth = 124
        Me.MultiEditorRowProperties41.FieldName = "KOD4"
        Me.MultiEditorRowProperties41.ImageIndex = 0
        Me.MultiEditorRowProperties41.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties41.Width = 327
        '
        'MultiEditorRowProperties42
        '
        Me.MultiEditorRowProperties42.CellWidth = 41
        Me.MultiEditorRowProperties42.FieldName = "QKOD4"
        Me.MultiEditorRowProperties42.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties42.Width = 167
        '
        'MultiEditorRowProperties43
        '
        Me.MultiEditorRowProperties43.Caption = "Sınıf 5"
        Me.MultiEditorRowProperties43.CellWidth = 124
        Me.MultiEditorRowProperties43.FieldName = "KOD5"
        Me.MultiEditorRowProperties43.ImageIndex = 0
        Me.MultiEditorRowProperties43.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties43.Width = 327
        '
        'MultiEditorRowProperties44
        '
        Me.MultiEditorRowProperties44.CellWidth = 41
        Me.MultiEditorRowProperties44.FieldName = "QKOD5"
        Me.MultiEditorRowProperties44.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties44.Width = 167
        '
        'MultiEditorRowProperties45
        '
        Me.MultiEditorRowProperties45.Caption = "Telefon"
        Me.MultiEditorRowProperties45.CellWidth = 124
        Me.MultiEditorRowProperties45.FieldName = "TELEFON"
        Me.MultiEditorRowProperties45.ImageIndex = 0
        Me.MultiEditorRowProperties45.Width = 328
        '
        'MultiEditorRowProperties46
        '
        Me.MultiEditorRowProperties46.CellWidth = 41
        Me.MultiEditorRowProperties46.FieldName = "QTELEFON"
        Me.MultiEditorRowProperties46.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties46.Width = 166
        '
        'MultiEditorRowProperties47
        '
        Me.MultiEditorRowProperties47.Caption = "İstihbarat"
        Me.MultiEditorRowProperties47.CellWidth = 124
        Me.MultiEditorRowProperties47.FieldName = "ISTIHBARAT"
        Me.MultiEditorRowProperties47.ImageIndex = 0
        Me.MultiEditorRowProperties47.Width = 328
        '
        'MultiEditorRowProperties48
        '
        Me.MultiEditorRowProperties48.CellWidth = 41
        Me.MultiEditorRowProperties48.FieldName = "QISTIHBARAT"
        Me.MultiEditorRowProperties48.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties48.Width = 166
        '
        'MultiEditorRowProperties49
        '
        Me.MultiEditorRowProperties49.Caption = "Aktif"
        Me.MultiEditorRowProperties49.CellWidth = 124
        Me.MultiEditorRowProperties49.FieldName = "AKTIF"
        Me.MultiEditorRowProperties49.ImageIndex = 0
        Me.MultiEditorRowProperties49.Width = 328
        '
        'MultiEditorRowProperties50
        '
        Me.MultiEditorRowProperties50.CellWidth = 41
        Me.MultiEditorRowProperties50.FieldName = "QAKTIF"
        Me.MultiEditorRowProperties50.ReadOnly = True
        Me.MultiEditorRowProperties50.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties50.Width = 166
        '
        'MultiEditorRowProperties51
        '
        Me.MultiEditorRowProperties51.Caption = "Periyod"
        Me.MultiEditorRowProperties51.CellWidth = 124
        Me.MultiEditorRowProperties51.FieldName = "PERIYOD"
        Me.MultiEditorRowProperties51.ImageIndex = 0
        Me.MultiEditorRowProperties51.RowEdit = Me.sec_periyod
        Me.MultiEditorRowProperties51.Width = 30
        '
        'sec_periyod
        '
        Me.sec_periyod.AutoHeight = False
        Me.sec_periyod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_periyod.Items.AddRange(New Object() {"Günlük", "Haftalık", "HaftaGünü", "Aylık", "Quarter", "Yıllık"})
        Me.sec_periyod.Name = "sec_periyod"
        Me.sec_periyod.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties52
        '
        Me.MultiEditorRowProperties52.CellWidth = 41
        Me.MultiEditorRowProperties52.FieldName = "QPERIYOD"
        Me.MultiEditorRowProperties52.ReadOnly = True
        Me.MultiEditorRowProperties52.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties52.Width = 15
        '
        'MultiEditorRowProperties53
        '
        Me.MultiEditorRowProperties53.Caption = "FirmaTipi"
        Me.MultiEditorRowProperties53.CellWidth = 124
        Me.MultiEditorRowProperties53.FieldName = "FIRMATIPI"
        Me.MultiEditorRowProperties53.ImageIndex = 0
        Me.MultiEditorRowProperties53.RowEdit = Me.sec_firmatipi
        Me.MultiEditorRowProperties53.Width = 328
        '
        'sec_firmatipi
        '
        Me.sec_firmatipi.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_firmatipi.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_firmatipi.Appearance.ForeColor = System.Drawing.Color.Black
        Me.sec_firmatipi.Appearance.Options.UseBackColor = True
        Me.sec_firmatipi.Appearance.Options.UseForeColor = True
        Me.sec_firmatipi.AutoHeight = False
        Me.sec_firmatipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_firmatipi.DataSource = Me.DataTable2
        Me.sec_firmatipi.DisplayMember = "ACIKLAMA"
        Me.sec_firmatipi.Name = "sec_firmatipi"
        Me.sec_firmatipi.NullText = "[Hepsi]"
        Me.sec_firmatipi.ShowFooter = False
        Me.sec_firmatipi.ShowHeader = False
        Me.sec_firmatipi.ValueMember = "IND"
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "IND"
        Me.DataColumn27.DataType = GetType(Long)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "ACIKLAMA"
        '
        'MultiEditorRowProperties54
        '
        Me.MultiEditorRowProperties54.CellWidth = 41
        Me.MultiEditorRowProperties54.FieldName = "QFIRMATIPI"
        Me.MultiEditorRowProperties54.ReadOnly = True
        Me.MultiEditorRowProperties54.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties54.Width = 166
        '
        'MultiEditorRowProperties55
        '
        Me.MultiEditorRowProperties55.Caption = "Durum"
        Me.MultiEditorRowProperties55.CellWidth = 124
        Me.MultiEditorRowProperties55.FieldName = "ASIPARISKRITER"
        Me.MultiEditorRowProperties55.ImageIndex = 0
        Me.MultiEditorRowProperties55.RowEdit = Me.sec_kriter_alinan_siparis
        Me.MultiEditorRowProperties55.Width = 30
        '
        'sec_kriter_alinan_siparis
        '
        Me.sec_kriter_alinan_siparis.AutoHeight = False
        Me.sec_kriter_alinan_siparis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_alinan_siparis.Items.AddRange(New Object() {"1- Teslim Edilmiş", "2- Teslim Edilecek", "3- Hepsi"})
        Me.sec_kriter_alinan_siparis.Name = "sec_kriter_alinan_siparis"
        Me.sec_kriter_alinan_siparis.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties56
        '
        Me.MultiEditorRowProperties56.CellWidth = 41
        Me.MultiEditorRowProperties56.FieldName = "QASIPARISKRITER"
        Me.MultiEditorRowProperties56.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties56.Width = 15
        '
        'MultiEditorRowProperties57
        '
        Me.MultiEditorRowProperties57.Caption = "Durum"
        Me.MultiEditorRowProperties57.CellWidth = 124
        Me.MultiEditorRowProperties57.FieldName = "VSIPARISKRITER"
        Me.MultiEditorRowProperties57.ImageIndex = 0
        Me.MultiEditorRowProperties57.RowEdit = Me.sec_kriter_verilen_siparis
        Me.MultiEditorRowProperties57.Width = 30
        '
        'sec_kriter_verilen_siparis
        '
        Me.sec_kriter_verilen_siparis.AutoHeight = False
        Me.sec_kriter_verilen_siparis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_verilen_siparis.Items.AddRange(New Object() {"1- Teslim Alınmış", "2- Teslim Alınacak", "3- Hepsi"})
        Me.sec_kriter_verilen_siparis.Name = "sec_kriter_verilen_siparis"
        Me.sec_kriter_verilen_siparis.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'MultiEditorRowProperties58
        '
        Me.MultiEditorRowProperties58.CellWidth = 41
        Me.MultiEditorRowProperties58.FieldName = "QVSIPARISKRITER"
        Me.MultiEditorRowProperties58.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties58.Width = 15
        '
        'MultiEditorRowProperties59
        '
        Me.MultiEditorRowProperties59.Caption = "Limit"
        Me.MultiEditorRowProperties59.CellWidth = 124
        Me.MultiEditorRowProperties59.FieldName = "LIMIT"
        Me.MultiEditorRowProperties59.ImageIndex = 0
        Me.MultiEditorRowProperties59.Width = 30
        '
        'MultiEditorRowProperties60
        '
        Me.MultiEditorRowProperties60.CellWidth = 41
        Me.MultiEditorRowProperties60.FieldName = "QLIMIT"
        Me.MultiEditorRowProperties60.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties60.Width = 15
        '
        'MultiEditorRowProperties61
        '
        Me.MultiEditorRowProperties61.Caption = "Açıklama 1"
        Me.MultiEditorRowProperties61.CellWidth = 124
        Me.MultiEditorRowProperties61.FieldName = "STOKKOD1"
        Me.MultiEditorRowProperties61.ImageIndex = 0
        Me.MultiEditorRowProperties61.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties61.Width = 30
        '
        'MultiEditorRowProperties62
        '
        Me.MultiEditorRowProperties62.CellWidth = 41
        Me.MultiEditorRowProperties62.FieldName = "QSTOKKOD1"
        Me.MultiEditorRowProperties62.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties62.Width = 15
        '
        'MultiEditorRowProperties63
        '
        Me.MultiEditorRowProperties63.Caption = "Açıklama 2"
        Me.MultiEditorRowProperties63.CellWidth = 124
        Me.MultiEditorRowProperties63.FieldName = "STOKKOD2"
        Me.MultiEditorRowProperties63.ImageIndex = 0
        Me.MultiEditorRowProperties63.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties63.Width = 30
        '
        'MultiEditorRowProperties64
        '
        Me.MultiEditorRowProperties64.CellWidth = 41
        Me.MultiEditorRowProperties64.FieldName = "QSTOKKOD2"
        Me.MultiEditorRowProperties64.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties64.Width = 15
        '
        'MultiEditorRowProperties65
        '
        Me.MultiEditorRowProperties65.Caption = "Açıklama 3"
        Me.MultiEditorRowProperties65.CellWidth = 124
        Me.MultiEditorRowProperties65.FieldName = "STOKKOD3"
        Me.MultiEditorRowProperties65.ImageIndex = 0
        Me.MultiEditorRowProperties65.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties65.Width = 30
        '
        'MultiEditorRowProperties66
        '
        Me.MultiEditorRowProperties66.CellWidth = 41
        Me.MultiEditorRowProperties66.FieldName = "QSTOKKOD3"
        Me.MultiEditorRowProperties66.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties66.Width = 15
        '
        'MultiEditorRowProperties67
        '
        Me.MultiEditorRowProperties67.Caption = "Açıklama 4"
        Me.MultiEditorRowProperties67.CellWidth = 124
        Me.MultiEditorRowProperties67.FieldName = "STOKKOD4"
        Me.MultiEditorRowProperties67.ImageIndex = 0
        Me.MultiEditorRowProperties67.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties67.Width = 30
        '
        'MultiEditorRowProperties68
        '
        Me.MultiEditorRowProperties68.CellWidth = 41
        Me.MultiEditorRowProperties68.FieldName = "QSTOKKOD4"
        Me.MultiEditorRowProperties68.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties68.Width = 15
        '
        'MultiEditorRowProperties69
        '
        Me.MultiEditorRowProperties69.Caption = "Açıklama 5"
        Me.MultiEditorRowProperties69.CellWidth = 124
        Me.MultiEditorRowProperties69.FieldName = "STOKKOD5"
        Me.MultiEditorRowProperties69.ImageIndex = 0
        Me.MultiEditorRowProperties69.RowEdit = Me.sec_ozelkod
        Me.MultiEditorRowProperties69.Width = 30
        '
        'MultiEditorRowProperties70
        '
        Me.MultiEditorRowProperties70.CellWidth = 41
        Me.MultiEditorRowProperties70.FieldName = "QSTOKKOD5"
        Me.MultiEditorRowProperties70.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties70.Width = 15
        '
        'MultiEditorRowProperties71
        '
        Me.MultiEditorRowProperties71.Caption = "Kayıt No"
        Me.MultiEditorRowProperties71.CellWidth = 124
        Me.MultiEditorRowProperties71.FieldName = "IND"
        Me.MultiEditorRowProperties71.ImageIndex = 0
        Me.MultiEditorRowProperties71.RowEdit = Me.sec_kayitno
        Me.MultiEditorRowProperties71.Width = 328
        '
        'sec_kayitno
        '
        Me.sec_kayitno.AutoHeight = False
        Me.sec_kayitno.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_kayitno.Name = "sec_kayitno"
        '
        'MultiEditorRowProperties72
        '
        Me.MultiEditorRowProperties72.CellWidth = 41
        Me.MultiEditorRowProperties72.FieldName = "QIND"
        Me.MultiEditorRowProperties72.ReadOnly = True
        Me.MultiEditorRowProperties72.RowEdit = Me.sec_kriter
        Me.MultiEditorRowProperties72.Width = 166
        '
        'sec_tarih
        '
        Me.sec_tarih.AutoHeight = False
        Me.sec_tarih.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tarih.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.sec_tarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.sec_tarih.Name = "sec_tarih"
        Me.sec_tarih.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_tarih.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(432, 60)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(382, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 377)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(432, 52)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(340, 17)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 25)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(256, 17)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(84, 25)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 60)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(432, 317)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(428, 313)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.VGridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(422, 285)
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
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_kriter, Me.sec_aciklama, Me.sec_firmatipi, Me.sec_kayitno, Me.sec_personel, Me.sec_bakiye_tipi, Me.sec_tarih, Me.sec_durum, Me.sec_listeleme, Me.sec_kriter_alinan_siparis, Me.sec_kriter_verilen_siparis, Me.sec_ozelkod, Me.sec_periyod})
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowTARIH, Me.rowVADE, Me.rowBELGEKOD1, Me.rowBELGEKOD2, Me.rowTARIH2, Me.rowFIRMAKODU, Me.rowFIRMAADI, Me.rowSTOKKODU, Me.rowMALINCINSI, Me.rowADRES, Me.rowKRITER, Me.rowPERSONEL, Me.rowOPSIYON, Me.rowFAIZ, Me.rowDURUM, Me.rowLISTELE, Me.rowKOD1, Me.rowKOD2, Me.rowKOD3, Me.rowKOD4, Me.rowKOD5, Me.rowTELEFON, Me.rowISTIHBARAT, Me.rowAKTIF, Me.rowPERIYOD, Me.rowFIRMATIPI, Me.rowASIPARIS, Me.rowVSIPARIS, Me.rowLIMIT, Me.rowSTOKKOD1, Me.rowSTOKKOD2, Me.rowSTOKKOD3, Me.rowSTOKKOD4, Me.rowSTOKKOD5, Me.rowKAYITNO})
        Me.VGridControl1.Size = New System.Drawing.Size(422, 284)
        Me.VGridControl1.TabIndex = 0
        Me.VGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem8, Me.MenuItem5, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem7, Me.MenuItem6, Me.MenuItem9})
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
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12})
        Me.MenuItem9.Text = "Dil Değiştir"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Turkish"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "English"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Arabic"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "FIRMAKODU"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FIRMAADI"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ADRES"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "PERSONEL"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "KOD1"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "KOD2"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "KOD3"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "KOD4"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KOD5"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "TELEFON"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ISTIHBARAT"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "FIRMATIPI"
        Me.DataColumn13.DataType = GetType(Long)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "QIND"
        Me.DataColumn14.DefaultValue = "Eşittir"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "QFIRMAKODU"
        Me.DataColumn15.DefaultValue = "Eşittir"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "QFIRMAADI"
        Me.DataColumn16.DefaultValue = "Başlar"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "QADRES"
        Me.DataColumn17.DefaultValue = "İçerir"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "QPERSONEL"
        Me.DataColumn18.DefaultValue = "Eşittir"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "QKOD1"
        Me.DataColumn19.DefaultValue = "Başlar"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "QKOD2"
        Me.DataColumn20.DefaultValue = "Başlar"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "QKOD3"
        Me.DataColumn21.DefaultValue = "Başlar"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "QKOD4"
        Me.DataColumn22.DefaultValue = "Başlar"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "QKOD5"
        Me.DataColumn23.DefaultValue = "Başlar"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "QTELEFON"
        Me.DataColumn24.DefaultValue = "Başlar"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "QISTIHBARAT"
        Me.DataColumn25.DefaultValue = "İçerir"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "QFIRMATIPI"
        Me.DataColumn26.DefaultValue = "Eşittir"
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
        Me.DataColumn32.DefaultValue = "Eşittir"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "KRITER"
        Me.DataColumn33.DefaultValue = "Hepsi"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "QKRITER"
        Me.DataColumn34.DefaultValue = "Eşittir"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "TARIH1"
        Me.DataColumn35.DataType = GetType(Date)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "QTARIH"
        Me.DataColumn36.DefaultValue = "Eşittir"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "TARIH2"
        Me.DataColumn37.DataType = GetType(Date)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "OPSIYON"
        Me.DataColumn38.DataType = GetType(Long)
        Me.DataColumn38.DefaultValue = CType(0, Long)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "QOPSIYON"
        Me.DataColumn39.DefaultValue = "Eşittir"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "FAIZ"
        Me.DataColumn40.DataType = GetType(Long)
        Me.DataColumn40.DefaultValue = CType(0, Long)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "QFAIZ"
        Me.DataColumn41.DefaultValue = "Eşittir"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "DURUM"
        Me.DataColumn42.DefaultValue = "Alacaklar"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "QDURUM"
        Me.DataColumn43.DefaultValue = "Eşittir"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "LISTELE"
        Me.DataColumn44.DefaultValue = "Özet"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "QLISTELE"
        Me.DataColumn45.DefaultValue = "Eşittir"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "STOKKODU"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "QSTOKKODU"
        Me.DataColumn47.DefaultValue = "Başlar"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "MALINCINSI"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "QMALINCINSI"
        Me.DataColumn49.DefaultValue = "İçerir"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "STOKKOD1"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "STOKKOD2"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "STOKKOD3"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "STOKKOD4"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "STOKKOD5"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "QSTOKKOD1"
        Me.DataColumn55.DefaultValue = "Başlar"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "QSTOKKOD2"
        Me.DataColumn56.DefaultValue = "Başlar"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "QSTOKKOD3"
        Me.DataColumn57.DefaultValue = "Başlar"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "QSTOKKOD4"
        Me.DataColumn58.DefaultValue = "Başlar"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "QSTOKKOD5"
        Me.DataColumn59.DefaultValue = "Başlar"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "ASIPARISKRITER"
        Me.DataColumn60.DefaultValue = "2- Teslim Edilecek"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "QASIPARISKRITER"
        Me.DataColumn61.DefaultValue = "Eşittir"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "VSIPARISKRITER"
        Me.DataColumn62.DefaultValue = "2- Teslim Alınacak"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "QVSIPARISKRITER"
        Me.DataColumn63.DefaultValue = "Eşittir"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "VADE1"
        Me.DataColumn64.DataType = GetType(Date)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "VADE2"
        Me.DataColumn65.DataType = GetType(Date)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "QVADE"
        Me.DataColumn66.DefaultValue = "Aralık"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "BELGEKOD1"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "BELGEKOD2"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "QBELGEKOD1"
        Me.DataColumn69.DefaultValue = "Başlar"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "QBELGEKOD2"
        Me.DataColumn70.DefaultValue = "Başlar"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "PERIYOD"
        Me.DataColumn71.DefaultValue = "Günlük"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "QPERIYOD"
        Me.DataColumn72.DefaultValue = "Eşittir"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "LIMIT"
        Me.DataColumn73.DefaultValue = "0"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "QLIMIT"
        Me.DataColumn74.DefaultValue = "Büyük"
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
        Me.rowTARIH.Visible = False
        '
        'rowVADE
        '
        Me.rowVADE.Name = "rowVADE"
        Me.rowVADE.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties4, Me.MultiEditorRowProperties5, Me.MultiEditorRowProperties6})
        Me.rowVADE.Visible = False
        '
        'rowBELGEKOD1
        '
        Me.rowBELGEKOD1.Name = "rowBELGEKOD1"
        Me.rowBELGEKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties7, Me.MultiEditorRowProperties8})
        Me.rowBELGEKOD1.Visible = False
        '
        'rowBELGEKOD2
        '
        Me.rowBELGEKOD2.Name = "rowBELGEKOD2"
        Me.rowBELGEKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties9, Me.MultiEditorRowProperties10})
        Me.rowBELGEKOD2.Visible = False
        '
        'rowTARIH2
        '
        Me.rowTARIH2.Name = "rowTARIH2"
        Me.rowTARIH2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties11, Me.MultiEditorRowProperties12})
        Me.rowTARIH2.Visible = False
        '
        'rowFIRMAKODU
        '
        Me.rowFIRMAKODU.Name = "rowFIRMAKODU"
        Me.rowFIRMAKODU.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties13, Me.MultiEditorRowProperties14})
        '
        'rowFIRMAADI
        '
        Me.rowFIRMAADI.Name = "rowFIRMAADI"
        Me.rowFIRMAADI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties15, Me.MultiEditorRowProperties16})
        '
        'rowSTOKKODU
        '
        Me.rowSTOKKODU.Name = "rowSTOKKODU"
        Me.rowSTOKKODU.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties17, Me.MultiEditorRowProperties18})
        '
        'rowMALINCINSI
        '
        Me.rowMALINCINSI.Name = "rowMALINCINSI"
        Me.rowMALINCINSI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties19, Me.MultiEditorRowProperties20})
        '
        'rowADRES
        '
        Me.rowADRES.Name = "rowADRES"
        Me.rowADRES.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties21, Me.MultiEditorRowProperties22})
        '
        'rowKRITER
        '
        Me.rowKRITER.Name = "rowKRITER"
        Me.rowKRITER.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties23, Me.MultiEditorRowProperties24})
        Me.rowKRITER.Visible = False
        '
        'rowPERSONEL
        '
        Me.rowPERSONEL.Name = "rowPERSONEL"
        Me.rowPERSONEL.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties25, Me.MultiEditorRowProperties26})
        Me.rowPERSONEL.Visible = False
        '
        'rowOPSIYON
        '
        Me.rowOPSIYON.Name = "rowOPSIYON"
        Me.rowOPSIYON.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties27, Me.MultiEditorRowProperties28})
        Me.rowOPSIYON.Visible = False
        '
        'rowFAIZ
        '
        Me.rowFAIZ.Name = "rowFAIZ"
        Me.rowFAIZ.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties29, Me.MultiEditorRowProperties30})
        Me.rowFAIZ.Visible = False
        '
        'rowDURUM
        '
        Me.rowDURUM.Name = "rowDURUM"
        Me.rowDURUM.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties31, Me.MultiEditorRowProperties32})
        Me.rowDURUM.Visible = False
        '
        'rowLISTELE
        '
        Me.rowLISTELE.Name = "rowLISTELE"
        Me.rowLISTELE.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties33, Me.MultiEditorRowProperties34})
        Me.rowLISTELE.Visible = False
        '
        'rowKOD1
        '
        Me.rowKOD1.Name = "rowKOD1"
        Me.rowKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties35, Me.MultiEditorRowProperties36})
        '
        'rowKOD2
        '
        Me.rowKOD2.Name = "rowKOD2"
        Me.rowKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties37, Me.MultiEditorRowProperties38})
        '
        'rowKOD3
        '
        Me.rowKOD3.Name = "rowKOD3"
        Me.rowKOD3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties39, Me.MultiEditorRowProperties40})
        '
        'rowKOD4
        '
        Me.rowKOD4.Name = "rowKOD4"
        Me.rowKOD4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties41, Me.MultiEditorRowProperties42})
        '
        'rowKOD5
        '
        Me.rowKOD5.Name = "rowKOD5"
        Me.rowKOD5.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties43, Me.MultiEditorRowProperties44})
        '
        'rowTELEFON
        '
        Me.rowTELEFON.Name = "rowTELEFON"
        Me.rowTELEFON.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties45, Me.MultiEditorRowProperties46})
        '
        'rowISTIHBARAT
        '
        Me.rowISTIHBARAT.Name = "rowISTIHBARAT"
        Me.rowISTIHBARAT.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties47, Me.MultiEditorRowProperties48})
        '
        'rowAKTIF
        '
        Me.rowAKTIF.Name = "rowAKTIF"
        Me.rowAKTIF.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties49, Me.MultiEditorRowProperties50})
        Me.rowAKTIF.Visible = False
        '
        'rowPERIYOD
        '
        Me.rowPERIYOD.Name = "rowPERIYOD"
        Me.rowPERIYOD.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties51, Me.MultiEditorRowProperties52})
        Me.rowPERIYOD.Visible = False
        '
        'rowFIRMATIPI
        '
        Me.rowFIRMATIPI.Name = "rowFIRMATIPI"
        Me.rowFIRMATIPI.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties53, Me.MultiEditorRowProperties54})
        Me.rowFIRMATIPI.Visible = False
        '
        'rowASIPARIS
        '
        Me.rowASIPARIS.Name = "rowASIPARIS"
        Me.rowASIPARIS.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties55, Me.MultiEditorRowProperties56})
        Me.rowASIPARIS.Visible = False
        '
        'rowVSIPARIS
        '
        Me.rowVSIPARIS.Name = "rowVSIPARIS"
        Me.rowVSIPARIS.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties57, Me.MultiEditorRowProperties58})
        Me.rowVSIPARIS.Visible = False
        '
        'rowLIMIT
        '
        Me.rowLIMIT.Name = "rowLIMIT"
        Me.rowLIMIT.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties59, Me.MultiEditorRowProperties60})
        Me.rowLIMIT.Visible = False
        '
        'rowSTOKKOD1
        '
        Me.rowSTOKKOD1.Name = "rowSTOKKOD1"
        Me.rowSTOKKOD1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties61, Me.MultiEditorRowProperties62})
        '
        'rowSTOKKOD2
        '
        Me.rowSTOKKOD2.Name = "rowSTOKKOD2"
        Me.rowSTOKKOD2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties63, Me.MultiEditorRowProperties64})
        '
        'rowSTOKKOD3
        '
        Me.rowSTOKKOD3.Name = "rowSTOKKOD3"
        Me.rowSTOKKOD3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties65, Me.MultiEditorRowProperties66})
        '
        'rowSTOKKOD4
        '
        Me.rowSTOKKOD4.Name = "rowSTOKKOD4"
        Me.rowSTOKKOD4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties67, Me.MultiEditorRowProperties68})
        '
        'rowSTOKKOD5
        '
        Me.rowSTOKKOD5.Name = "rowSTOKKOD5"
        Me.rowSTOKKOD5.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties69, Me.MultiEditorRowProperties70})
        '
        'rowKAYITNO
        '
        Me.rowKAYITNO.Name = "rowKAYITNO"
        Me.rowKAYITNO.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties71, Me.MultiEditorRowProperties72})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.MemoEdit1)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.PageVisible = False
        Me.XtraTabPage3.Size = New System.Drawing.Size(422, 285)
        Me.XtraTabPage3.Text = "SQL"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.EditValue = "SELECT * FROM *!FTBLCARI"
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(422, 285)
        Me.MemoEdit1.TabIndex = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "NewDataSet"
        Me.DataSet3.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet3.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'frm_cari_ara
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(432, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cari_ara"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ara"
        CType(Me.sec_kriter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ozelkod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bakiye_tipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_personel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_durum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_listeleme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_periyod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_firmatipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_alinan_siparis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_verilen_siparis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kayitno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tarih.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tarih, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim dr2 As DataRow
    Dim durum As Boolean
    'Dim sender2 As New DevExpress.XtraEditors.TextEdit
    Public firmakodu
    Public firmaadi
    Public adres
    Public personel
    Public kod1
    Public kod2
    Public kod3
    Public kod4
    Public kod5
    Public telefon
    Public istihbarat
    Public firmatipi
    Public kayitno
    Public aktif
    Public bakiye_tipi
    Public tarih1
    Public tarih2
    Public opsiyon
    Public faiz
    Public durumu
    Public listele
    Public vade1
    Public vade2
    Public stokkodu
    Public malincinsi
    Public stokkod1
    Public stokkod2
    Public stokkod3
    Public stokkod4
    Public stokkod5
    Public asipariskriter
    Public vsipariskriter
    Public belgekod1
    Public belgekod2
    Public periyod
    Public limit
    Public qfirmakodu
    Public qfirmaadi
    Public qadres
    Public qpersonel
    Public qkod1
    Public qkod2
    Public qkod3
    Public qkod4
    Public qkod5
    Public qtelefon
    Public qistihbarat
    Public qfirmatipi
    Public qkayitno
    Public qaktif
    Public language
    Public qbakiye_tipi
    Public qtarih
    Public qopsiyon
    Public qfaiz
    Public qdurumu
    Public qlistele
    Public qvade
    Public qstokkodu
    Public qmalincinsi
    Public qstokkod1
    Public qstokkod2
    Public qstokkod3
    Public qstokkod4
    Public qstokkod5
    Public qasipariskriter
    Public qvsipariskriter
    Public qbelgekod1
    Public qbelgekod2
    Public qperiyod
    Public qlimit
    Public connection
    Public firmano
    Public donemno
    Public kullanici
    Private Sub frm_cari_ara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_personel()
        dr2 = DataSet1.Tables(0).Rows(0)
        VGridControl1.Select()
        VGridControl1.FocusedRecordCellIndex() = 0
        durum = True
        If language = "turkish" Then
            language_turkish()
        ElseIf language = "arabic" Then
            language_arabic()
        End If
        Dim auto_load = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CARI").GetValue("auto_load")
        If auto_load = True Then
            MenuItem4.Checked = True
            kriter_yukle()
        ElseIf auto_load = False Then
            MenuItem4.Checked = False
        End If
        Dim row = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CARI").GetValue("ActiveRow")
        If row <> "" Then
            If row.ToString = "rowFIRMAKODU" Then
                VGridControl1.FocusedRow = rowFIRMAKODU
            ElseIf row.ToString = "rowFIRMAADI" Then
                VGridControl1.FocusedRow = rowFIRMAADI
            ElseIf row.ToString = "rowADRES" Then
                VGridControl1.FocusedRow = rowADRES
            ElseIf row.ToString = "rowTELEFON" Then
                VGridControl1.FocusedRow = rowTELEFON
            ElseIf row.ToString = "rowKAYITNO" Then
                VGridControl1.FocusedRow = rowKAYITNO
            ElseIf row.ToString = "rowISTIHBARAT" Then
                VGridControl1.FocusedRow = rowISTIHBARAT
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
            ElseIf row.ToString = "rowAKTIF" Then
                VGridControl1.FocusedRow = rowAKTIF
            ElseIf row.ToString = "rowKRITER" Then
                VGridControl1.FocusedRow = rowKRITER
            ElseIf row.ToString = "rowTARIH" Then
                VGridControl1.FocusedRow = rowTARIH
            ElseIf row.ToString = "rowOPSIYON" Then
                VGridControl1.FocusedRow = rowOPSIYON
            ElseIf row.ToString = "rowFAIZ" Then
                VGridControl1.FocusedRow = rowFAIZ
            ElseIf row.ToString = "rowDURUM" Then
                VGridControl1.FocusedRow = rowDURUM
            ElseIf row.ToString = "rowLISTELE" Then
                VGridControl1.FocusedRow = rowLISTELE
            ElseIf row.ToString = "rowSTOKKODU" Then
                VGridControl1.FocusedRow = rowSTOKKODU
            ElseIf row.ToString = "rowMALINCINSI" Then
                VGridControl1.FocusedRow = rowMALINCINSI
            ElseIf row.ToString = "rowBELGEKOD1" Then
                VGridControl1.FocusedRow = rowBELGEKOD1
            ElseIf row.ToString = "rowBELGEKOD2" Then
                VGridControl1.FocusedRow = rowBELGEKOD2
            ElseIf row.ToString = "rowSTOKKOD1" Then
                VGridControl1.FocusedRow = rowSTOKKOD1
            ElseIf row.ToString = "rowSTOKKOD2" Then
                VGridControl1.FocusedRow = rowSTOKKOD2
            ElseIf row.ToString = "rowSTOKKOD3" Then
                VGridControl1.FocusedRow = rowSTOKKOD3
            ElseIf row.ToString = "rowSTOKKOD4" Then
                VGridControl1.FocusedRow = rowSTOKKOD4
            ElseIf row.ToString = "rowSTOKKOD5" Then
                VGridControl1.FocusedRow = rowSTOKKOD5
            ElseIf row.ToString = "rowVADE" Then
                VGridControl1.FocusedRow = rowVADE
            ElseIf row.ToString = "rowASIPARIS" Then
                VGridControl1.FocusedRow = rowASIPARIS
            ElseIf row.ToString = "rowVSIPARIS" Then
                VGridControl1.FocusedRow = rowVSIPARIS
            ElseIf row.ToString = "rowTARIH2" Then
                VGridControl1.FocusedRow = rowTARIH2
            ElseIf row.ToString = "rowPERIYOD" Then
                VGridControl1.FocusedRow = rowPERIYOD
            Else
            End If
        End If
    End Sub
    Private Sub kriter_sorgu()
        Dim dr As DataRow
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
        For Each dr In DataSet1.Tables(0).Rows
            kayitno = dr("IND").ToString
            firmakodu = dr("FIRMAKODU").ToString
            firmaadi = dr("FIRMAADI").ToString
            adres = dr("ADRES").ToString
            kod1 = dr("KOD1").ToString
            kod2 = dr("KOD2").ToString
            kod3 = dr("KOD3").ToString
            kod4 = dr("KOD4").ToString
            kod5 = dr("KOD5").ToString
            istihbarat = dr("ISTIHBARAT").ToString
            telefon = dr("TELEFON").ToString
            firmatipi = dr("FIRMATIPI").ToString
            personel = dr("PERSONEL").ToString
            aktif = Math.Abs(CInt(dr("AKTIF"))).ToString
            bakiye_tipi = dr("KRITER").ToString
            tarih1 = dr("TARIH1").ToString
            tarih2 = dr("TARIH2").ToString  'DateDiff(DateInterval.Day, dr("TARIH2"), 1).ToString
            opsiyon = dr("OPSIYON")
            faiz = dr("FAIZ")
            durumu = dr("DURUM").ToString
            listele = dr("LISTELE").ToString
            vade1 = dr("VADE1").ToString
            vade2 = dr("VADE2").ToString
            stokkodu = dr("STOKKODU").ToString
            malincinsi = dr("MALINCINSI").ToString
            stokkod1 = dr("STOKKOD1").ToString
            stokkod2 = dr("STOKKOD2").ToString
            stokkod3 = dr("STOKKOD3").ToString
            stokkod4 = dr("STOKKOD4").ToString
            stokkod5 = dr("STOKKOD5").ToString
            asipariskriter = dr("ASIPARISKRITER").ToString
            vsipariskriter = dr("VSIPARISKRITER").ToString
            belgekod1 = dr("BELGEKOD1").ToString
            belgekod2 = dr("BELGEKOD2").ToString
            periyod = dr("PERIYOD").ToString
            limit = dr("LIMIT").ToString
            qkayitno = dr("QIND").ToString
            qfirmakodu = dr("QFIRMAKODU").ToString
            qfirmaadi = dr("QFIRMAADI").ToString
            qadres = dr("QADRES").ToString
            qkod1 = dr("QKOD1").ToString
            qkod2 = dr("QKOD2").ToString
            qkod3 = dr("QKOD3").ToString
            qkod4 = dr("QKOD4").ToString
            qkod5 = dr("QKOD5").ToString
            qistihbarat = dr("QISTIHBARAT").ToString
            qtelefon = dr("QTELEFON").ToString
            qfirmatipi = dr("QFIRMATIPI").ToString
            qpersonel = dr("QPERSONEL").ToString
            qaktif = dr("QAKTIF").ToString
            qbakiye_tipi = dr("QKRITER").ToString
            qtarih = dr("QTARIH").ToString
            qopsiyon = dr("QOPSIYON")
            qfaiz = dr("QFAIZ")
            qdurumu = dr("QDURUM").ToString
            qlistele = dr("QLISTELE").ToString
            qvade = dr("QVADE").ToString
            qstokkodu = dr("QSTOKKODU").ToString
            qmalincinsi = dr("QMALINCINSI").ToString
            qstokkod1 = dr("QSTOKKOD1").ToString
            qstokkod2 = dr("QSTOKKOD2").ToString
            qstokkod3 = dr("QSTOKKOD3").ToString
            qstokkod4 = dr("QSTOKKOD4").ToString
            qstokkod5 = dr("QSTOKKOD5").ToString
            qasipariskriter = dr("QASIPARISKRITER").ToString
            qvsipariskriter = dr("QVSIPARISKRITER").ToString
            qbelgekod1 = dr("QBELGEKOD1").ToString
            qbelgekod2 = dr("QBELGEKOD2").ToString
            qperiyod = dr("QPERIYOD").ToString
            qlimit = dr("QLIMIT").ToString
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub gorunum_yukle()
        Dim row
        For Each row In VGridControl1.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
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
    End Sub
    Private Sub dataload()
        Dim dr As DataRow = DataSet1.Tables(0).NewRow
        Dim gun
        Dim ay
        Dim yil
        yil = Today.ToString.Substring(8, 2)
        gun = Today.ToString.Substring(0, 2)
        ay = Today.ToString.Substring(3, 2)
        dr("FIRMAKODU") = ""
        dr("TARIH1") = CDate("01." + ay + "." + yil)
        Try
            dr("TARIH2") = CDate("31." + ay + "." + yil)
        Catch ex As Exception
            If ay <> 2 Then
                dr("TARIH2") = CDate("30." + ay + "." + yil)
            Else
                dr("TARIH2") = CDate("28." + ay + "." + yil)
            End If
        End Try
        dr("VADE1") = CDate("01." + ay + "." + yil)
        Try
            dr("VADE2") = CDate("31." + ay + "." + yil)
        Catch ex As Exception
            If ay <> 2 Then
                dr("VADE2") = CDate("30." + ay + "." + yil)
            Else
                dr("VADE2") = CDate("28." + ay + "." + yil)
            End If
        End Try
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr(0) = 1
        dr(1) = "Alıcı"
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr(0) = 2
        dr(1) = "Satıcı"
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr(0) = 3
        dr(1) = "Alıcı+Satıcı"
        DataSet2.Tables(0).Rows.Add(dr)
        dr = DataSet2.Tables(0).NewRow
        dr(0) = 5
        dr(1) = "Kredili Müşteri"
        DataSet2.Tables(0).Rows.Add(dr)
        dr = Nothing
        gun = Nothing
        yil = Nothing
        ay = Nothing
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub yetki_kontrol()
        Dim yetki As Int64 = Sorgu_Yetki(kullanici, Me.Name)
        If yetki = 0 Then
            Me.Hide()
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!" & vbCrLf & "Lütfen Sistem Yönecinizle Görüşün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        cmd.CommandTimeout = Nothing
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
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub sec_aciklama_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_aciklama.EditValueChanged
    End Sub
    Private Sub sec_aciklama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_aciklama.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    kriter_sorgu()
        'ElseIf e.KeyCode = Keys.Down Then
        '    VGridControl1.PostEditor()
        '    VGridControl1.UpdateFocusedRecord()
        '    VGridControl1.CloseEditor()
        'ElseIf e.KeyCode = Keys.Up Then
        '    VGridControl1.PostEditor()
        '    VGridControl1.UpdateFocusedRecord()
        '    VGridControl1.CloseEditor()
        'ElseIf e.KeyCode = Keys.Escape Then
        'End If
    End Sub
    Private Sub VGridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            VGridControl1.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
            kriter_sorgu()
        ElseIf e.KeyCode = Keys.Down Then
            VGridControl1.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
        ElseIf e.KeyCode = Keys.Up Then
            VGridControl1.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F2 Then
            kriter_sorgu()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub
    Private Sub sec_firmatipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_firmatipi.EditValueChanged
        VGridControl1.PostEditor()
        VGridControl1.UpdateFocusedRecord()
        VGridControl1.CloseEditor()
    End Sub
    Private Sub VGridControl1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs) Handles VGridControl1.FocusedRowChanged
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        kriter_sorgu()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kriter_sorgu()
    End Sub
    Private Sub sec_aciklama_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_aciklama.Validating
        'VGridControl1.PostEditor()
        'VGridControl1.UpdateFocusedRecord()
        'VGridControl1.CloseEditor()
    End Sub
    Private Sub frm_cari_ara_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CARI").SetValue("ActiveRow", VGridControl1.FocusedRow.Name)
        If MenuItem4.Checked = True Then
            kriter_kaydet()
        End If
        SimpleButton1.Dispose()
        SimpleButton2.Dispose()
        SimpleButton1 = Nothing
        SimpleButton2 = Nothing
        language = Nothing
    End Sub
    Private Sub kriter_kaydet()
        Dim s As String = "..\CARI\cariara.xml"
        Dim dosya As New FileInfo(s)
        If dosya.Exists = False Then
            dosya.Create()
        End If
        DataSet1.WriteXml(s)
    End Sub
    Private Sub kriter_yukle()
        Dim s As String = "..\CARI\cariara.xml"
        Dim dosya As New FileInfo(s)
        If dosya.Exists = True Then
            DataSet1.Clear()
            DataSet1.Dispose()
            DataSet1.ReadXml(s)
            VGridControl1.DataSource = DataSet1
        End If
    End Sub
    Private Sub kriter_sil()
        Dim s As String = "..\CARI\cariara.xml"
        Dim dosya As New FileInfo(s)
        If dosya.Exists = True Then
            dosya.Delete()
            XtraMessageBox.Show(Sorgu_sDil("Kriter Silindi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If MenuItem4.Checked = True Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CARI").SetValue("auto_load", False)
            MenuItem4.Checked = False
        ElseIf MenuItem4.Checked = False Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CARI").SetValue("auto_load", True)
            MenuItem4.Checked = True
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        kriter_kaydet()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kriter_yukle()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        kriter_sil()
    End Sub
    Private Sub language_arabic()
        rowKAYITNO.Properties.Caption = "رقم القيد"
        rowFIRMAKODU.Properties.Caption = "رقم كود الشركة"
        rowFIRMAADI.Properties.Caption = "اسم الشركة"
        rowPERSONEL.Properties.Caption = "الموظفين"
        rowKOD1.Properties.Caption = "كود خاص 1"
        rowKOD2.Properties.Caption = "كود خاص 2"
        rowKOD3.Properties.Caption = "كود خاص 3"
        rowKOD4.Properties.Caption = "كود خاص 4"
        rowKOD5.Properties.Caption = "كود خاص 5"
        rowADRES.Properties.Caption = "العنوان"
        rowTELEFON.Properties.Caption = "تليفون"
        rowISTIHBARAT.Properties.Caption = "بيانات"
        rowFIRMATIPI.Properties.Caption = "الشركة"
        SimpleButton1.Text = "موافق"
        SimpleButton2.Text = "الغاء الآمر"
        XtraTabPage1.Text = "بحث"
        Me.Text = "بحث"
    End Sub
    Private Sub language_turkish()
        rowKAYITNO.Properties.Caption = "Kayıt No"
        rowFIRMAKODU.Properties.Caption = "Firma Kodu"
        rowFIRMAADI.Properties.Caption = "Firma Adı"
        rowPERSONEL.Properties.Caption = "Personel"
        rowKOD1.Properties.Caption = "1.ÖzelKod"
        rowKOD2.Properties.Caption = "2.ÖzelKod"
        rowKOD3.Properties.Caption = "3.ÖzelKod"
        rowKOD4.Properties.Caption = "4.ÖzelKod"
        rowKOD5.Properties.Caption = "5.ÖzelKod"
        rowADRES.Properties.Caption = "Adres"
        rowTELEFON.Properties.Caption = "Telefon"
        rowISTIHBARAT.Properties.Caption = "İstihbarat"
        rowFIRMATIPI.Properties.Caption = "FirmaTipi"
        SimpleButton1.Text = "&Tamam"
        SimpleButton2.Text = "&Vazgeç"
        XtraTabPage1.Text = "Ara"
        Me.Text = "Ara"
    End Sub
    Private Sub language_english()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        language_turkish()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        language_english()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        language_arabic()
    End Sub
    Private Sub VGridControl1_FocusedRecordCellChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.IndexChangedEventArgs) Handles VGridControl1.FocusedRecordCellChanged
        Try
            If durum = True Then
                VGridControl1.PostEditor()
                VGridControl1.UpdateFocusedRecord()
                VGridControl1.CloseEditor()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ozelkod_s(ByVal kod As String, ByVal modul As String, ByVal row As String)
        Dim frm As New frm_ozelkod
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.modul = modul
        frm.category = kod
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dr2("" & row & "") = frm_ozelkod.ozelkod.ToString
            frm.DataSet1.Clear()
            frm.DataSet1.Dispose()
            frm.DataSet1 = Nothing
            frm.GridView1.Dispose()
            frm.GridView1 = Nothing
            frm.GridControl1.Dispose()
            frm.GridControl1 = Nothing
            frm.Panel1.Dispose()
            frm.Panel2.Dispose()
            frm.Panel3.Dispose()
            frm.Panel1 = Nothing
            frm.Panel2 = Nothing
            frm.Panel3 = Nothing
            frm.SimpleButton1.Dispose()
            frm.SimpleButton2.Dispose()
            frm.SimpleButton1 = Nothing
            frm.SimpleButton2 = Nothing
            frm.PictureBox1.Dispose()
            frm.PictureBox1 = Nothing
            frm.Label1.Dispose()
            frm.Label1 = Nothing
            frm.Dispose()
            frm.Close()
            frm = Nothing
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
        End If
    End Sub
    Private Sub ozelkod_sec()
        If VGridControl1.FocusedRow.Name = rowBELGEKOD1.Name Then
            ozelkod_s(1, "BELGE", "BELGEKOD1")
        ElseIf VGridControl1.FocusedRow.Name = rowBELGEKOD2.Name Then
            ozelkod_s(2, "BELGE", "BELGEKOD2")
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
        ElseIf VGridControl1.FocusedRow.Name = rowKOD1.Name Then
            ozelkod_s(1, "CARI", "KOD1")
        ElseIf VGridControl1.FocusedRow.Name = rowKOD2.Name Then
            ozelkod_s(2, "CARI", "KOD2")
        ElseIf VGridControl1.FocusedRow.Name = rowKOD3.Name Then
            ozelkod_s(3, "CARI", "KOD3")
        ElseIf VGridControl1.FocusedRow.Name = rowKOD4.Name Then
            ozelkod_s(4, "CARI", "KOD4")
        ElseIf VGridControl1.FocusedRow.Name = rowKOD5.Name Then
            ozelkod_s(5, "CARI", "KOD5")
        End If
    End Sub
    Private Sub sec_ozelkod_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_ozelkod.ButtonClick
        ozelkod_sec()
    End Sub
    Private Sub sec_ozelkod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_ozelkod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kriter_sorgu()
        ElseIf e.KeyCode = Keys.Space Then
            ozelkod_sec()
        End If
    End Sub
End Class
