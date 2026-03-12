Imports System.Windows.Forms
Imports FastReport
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_cari
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
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbYazismaEvAdresinemi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colMEKTUPSAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONTAHSILATTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONSATISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISTUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISMIKTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADETUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADEMIKTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMSATISTUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMSATISMIKTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMPESINAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMTAKSIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECIKENILKTAKSITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECIKENILKTAKSITTUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMTAHSILAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents colGECIKMISKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents colGECIKMISTAKSIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents colKALANTAKSITSAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents colSATISSAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADESAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents colSONSATISTUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONTAHSILATTUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sinif1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sinif2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sinif3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sinif4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sinif5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents colGUNUNDEODEME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERKENODEME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECIKMIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMODEME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
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
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbYazismaEvAdresinemi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvSemt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sinif1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colKOD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sinif2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colKOD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sinif3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colKOD4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sinif4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colKOD5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sinif5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEKTUPSAYISI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONTAHSILATTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONSATISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISTUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISMIKTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADETUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADEMIKTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMSATISTUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMSATISMIKTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMPESINAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMTAKSIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECIKENILKTAKSITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECIKENILKTAKSITTUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMTAHSILAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECIKMISKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECIKMISTAKSIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALANTAKSITSAYISI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISSAYISI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADESAYISI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONSATISTUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONTAHSILATTUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGUNUNDEODEME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERKENODEME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECIKMIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMODEME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
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
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(830, 52)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(866, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Aşağıda Cari Hesapların Listesini Görmektesiniz.İşlem Yapmak istediğiniz Cari hes" & _
    "abı seçmek için [Tamam] butonuna tıklayınız, yeniden Arama yapmak için ise [Ara]" & _
    " butonuna tıklayınız."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton8)
        Me.PanelControl2.Controls.Add(Me.SimpleButton7)
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 386)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(830, 43)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Image = CType(resources.GetObject("SimpleButton8.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(251, 9)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton8.TabIndex = 9
        Me.SimpleButton8.Text = "Tahsilatlar"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(171, 9)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton7.TabIndex = 8
        Me.SimpleButton7.Text = "Satışlar"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(91, 9)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton6.TabIndex = 7
        Me.SimpleButton6.Text = "Gecikmişler"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(440, 8)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(40, 24)
        Me.SimpleButton5.TabIndex = 6
        Me.SimpleButton5.Text = "Yazdır"
        Me.SimpleButton5.Visible = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(400, 8)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(40, 24)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "Dizayn"
        Me.SimpleButton4.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(16, 9)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Ara F3"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(659, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 52)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(830, 334)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(826, 330)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panelstatus)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(820, 302)
        Me.XtraTabPage1.Text = "Kartlar..."
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panelstatus.Appearance.Options.UseBackColor = True
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(175, 100)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(468, 106)
        Me.Panelstatus.TabIndex = 3
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(10, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(444, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 49)
        Me.barlabel2.Name = "barlabel2"
        Me.barlabel2.Size = New System.Drawing.Size(53, 13)
        Me.barlabel2.TabIndex = 2
        Me.barlabel2.Text = "barlabel2"
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 3)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 22)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(444, 18)
        Me.bar.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sinif1, Me.sec_sinif2, Me.sec_sinif3, Me.sec_sinif4, Me.sec_sinif5})
        Me.GridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GridControl1.Size = New System.Drawing.Size(820, 302)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lKodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAdi"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sSoyadi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "bYazismaEvAdresinemi"
        Me.DataColumn5.DataType = GetType(Boolean)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sEvAdresi1"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sEvAdresi2"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sEvSemt"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sEvTelefonu"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sGSM"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sAciklama1"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sAciklama2"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sAciklama3"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sAciklama4"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sAciklama5"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "dteKayitTarihi"
        Me.DataColumn16.DataType = GetType(Date)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "ISTIHBARAT"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "KOD1"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "KOD2"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "KOD3"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "KOD4"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "KOD5"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "MEKTUPSAYISI"
        Me.DataColumn23.DataType = GetType(Long)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "SONSATISTARIHI"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "SONTAHSILATTARIHI"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "SATISTUTARI"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "SATISMIKTARI"
        Me.DataColumn27.DataType = GetType(Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "IADETUTARI"
        Me.DataColumn28.DataType = GetType(Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "IADEMIKTARI"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "TOPLAMSATISTUTARI"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "TOPLAMSATISMIKTARI"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "TOPLAMPESINAT"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "TOPLAMTAKSIT"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "GECIKENILKTAKSITTARIHI"
        Me.DataColumn34.DataType = GetType(Date)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "GECIKENILKTAKSITTUTARI"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "TOPLAMTAHSILAT"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "TOPLAMKALAN"
        Me.DataColumn37.DataType = GetType(Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "GECIKMISKALAN"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "GECIKMISTAKSIT"
        Me.DataColumn39.DataType = GetType(Long)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "KALANTAKSITSAYISI"
        Me.DataColumn40.DataType = GetType(Long)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "SATISSAYISI"
        Me.DataColumn41.DataType = GetType(Long)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "IADESAYISI"
        Me.DataColumn42.DataType = GetType(Long)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "SONSATISTUTARI"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "SONTAHSILATTUTARI"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "GUNUNDE"
        Me.DataColumn45.DataType = GetType(Long)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "ERKEN"
        Me.DataColumn46.DataType = GetType(Long)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "GECIKMIS"
        Me.DataColumn47.DataType = GetType(Long)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "TOPLAM"
        Me.DataColumn48.DataType = GetType(Long)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colbYazismaEvAdresinemi, Me.colsEvAdresi1, Me.colsEvAdresi2, Me.colsEvSemt, Me.colsEvTelefonu, Me.colsGSM, Me.colsAciklama1, Me.colsAciklama2, Me.colsAciklama3, Me.colsAciklama4, Me.colsAciklama5, Me.coldteKayitTarihi, Me.colISTIHBARAT, Me.colKOD1, Me.colKOD2, Me.colKOD3, Me.colKOD4, Me.colKOD5, Me.colMUSTERI, Me.colMEKTUPSAYISI, Me.colSONTAHSILATTARIHI, Me.colSONSATISTARIHI, Me.colSATISTUTARI, Me.colSATISMIKTARI, Me.colIADETUTARI, Me.colIADEMIKTARI, Me.colTOPLAMSATISTUTARI, Me.colTOPLAMSATISMIKTARI, Me.colTOPLAMPESINAT, Me.colTOPLAMTAKSIT, Me.colGECIKENILKTAKSITTARIHI, Me.colGECIKENILKTAKSITTUTARI, Me.colTOPLAMTAHSILAT, Me.colTOPLAMKALAN, Me.colGECIKMISKALAN, Me.colGECIKMISTAKSIT, Me.colKALANTAKSITSAYISI, Me.colSATISSAYISI, Me.colIADESAYISI, Me.colSONSATISTUTARI, Me.colSONTAHSILATTUTARI, Me.colGUNUNDEODEME, Me.colERKENODEME, Me.colGECIKMIS, Me.colTOPLAMODEME})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(274, 242, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Kayıt No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.Visible = True
        Me.colnMusteriID.VisibleIndex = 0
        Me.colnMusteriID.Width = 42
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müşteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayıt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 1
        Me.collKodu.Width = 71
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Müşteri Adı"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Width = 112
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "MüşteriSoyadı"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Width = 112
        '
        'colbYazismaEvAdresinemi
        '
        Me.colbYazismaEvAdresinemi.Caption = "YazışmaEvemi?"
        Me.colbYazismaEvAdresinemi.FieldName = "bYazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.Name = "colbYazismaEvAdresinemi"
        '
        'colsEvAdresi1
        '
        Me.colsEvAdresi1.Caption = "EvAdres1"
        Me.colsEvAdresi1.FieldName = "sEvAdresi1"
        Me.colsEvAdresi1.Name = "colsEvAdresi1"
        Me.colsEvAdresi1.Width = 56
        '
        'colsEvAdresi2
        '
        Me.colsEvAdresi2.Caption = "EvAdres2"
        Me.colsEvAdresi2.FieldName = "sEvAdresi2"
        Me.colsEvAdresi2.Name = "colsEvAdresi2"
        '
        'colsEvSemt
        '
        Me.colsEvSemt.Caption = "Semt"
        Me.colsEvSemt.FieldName = "sEvSemt"
        Me.colsEvSemt.Name = "colsEvSemt"
        Me.colsEvSemt.Width = 35
        '
        'colsEvTelefonu
        '
        Me.colsEvTelefonu.Caption = "Ev Telefonu"
        Me.colsEvTelefonu.FieldName = "sEvTelefonu"
        Me.colsEvTelefonu.Name = "colsEvTelefonu"
        Me.colsEvTelefonu.Width = 45
        '
        'colsGSM
        '
        Me.colsGSM.Caption = "Gsm"
        Me.colsGSM.FieldName = "sGSM"
        Me.colsGSM.Name = "colsGSM"
        Me.colsGSM.Width = 49
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
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.DisplayFormat.FormatString = "D"
        Me.coldteKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.Width = 54
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "İstihbarat"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        '
        'colKOD1
        '
        Me.colKOD1.Caption = "Kod 1"
        Me.colKOD1.ColumnEdit = Me.sec_sinif1
        Me.colKOD1.FieldName = "KOD1"
        Me.colKOD1.Name = "colKOD1"
        '
        'sec_sinif1
        '
        Me.sec_sinif1.AutoHeight = False
        Me.sec_sinif1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif1.DisplayMember = "ACIKLAMA"
        Me.sec_sinif1.Name = "sec_sinif1"
        Me.sec_sinif1.NullText = ""
        Me.sec_sinif1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sinif1.ShowFooter = False
        Me.sec_sinif1.ShowHeader = False
        Me.sec_sinif1.ShowLines = False
        Me.sec_sinif1.ValueMember = "IND"
        '
        'colKOD2
        '
        Me.colKOD2.Caption = "Kod 2"
        Me.colKOD2.ColumnEdit = Me.sec_sinif2
        Me.colKOD2.FieldName = "KOD2"
        Me.colKOD2.Name = "colKOD2"
        '
        'sec_sinif2
        '
        Me.sec_sinif2.AutoHeight = False
        Me.sec_sinif2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif2.DisplayMember = "ACIKLAMA"
        Me.sec_sinif2.Name = "sec_sinif2"
        Me.sec_sinif2.NullText = ""
        Me.sec_sinif2.ShowFooter = False
        Me.sec_sinif2.ShowHeader = False
        Me.sec_sinif2.ShowLines = False
        Me.sec_sinif2.ValueMember = "IND"
        '
        'colKOD3
        '
        Me.colKOD3.Caption = "Kod3"
        Me.colKOD3.ColumnEdit = Me.sec_sinif3
        Me.colKOD3.FieldName = "KOD3"
        Me.colKOD3.Name = "colKOD3"
        '
        'sec_sinif3
        '
        Me.sec_sinif3.AutoHeight = False
        Me.sec_sinif3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif3.DisplayMember = "ACIKLAMA"
        Me.sec_sinif3.Name = "sec_sinif3"
        Me.sec_sinif3.NullText = ""
        Me.sec_sinif3.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sinif3.ShowFooter = False
        Me.sec_sinif3.ShowHeader = False
        Me.sec_sinif3.ShowLines = False
        Me.sec_sinif3.ValueMember = "IND"
        '
        'colKOD4
        '
        Me.colKOD4.Caption = "Kod4"
        Me.colKOD4.ColumnEdit = Me.sec_sinif4
        Me.colKOD4.FieldName = "KOD4"
        Me.colKOD4.Name = "colKOD4"
        '
        'sec_sinif4
        '
        Me.sec_sinif4.AutoHeight = False
        Me.sec_sinif4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif4.DisplayMember = "ACIKLAMA"
        Me.sec_sinif4.Name = "sec_sinif4"
        Me.sec_sinif4.NullText = ""
        Me.sec_sinif4.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sinif4.ShowFooter = False
        Me.sec_sinif4.ShowHeader = False
        Me.sec_sinif4.ShowLines = False
        Me.sec_sinif4.ValueMember = "IND"
        '
        'colKOD5
        '
        Me.colKOD5.Caption = "Kod5"
        Me.colKOD5.ColumnEdit = Me.sec_sinif5
        Me.colKOD5.FieldName = "KOD5"
        Me.colKOD5.Name = "colKOD5"
        '
        'sec_sinif5
        '
        Me.sec_sinif5.AutoHeight = False
        Me.sec_sinif5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif5.DisplayMember = "ACIKLAMA"
        Me.sec_sinif5.Name = "sec_sinif5"
        Me.sec_sinif5.NullText = ""
        Me.sec_sinif5.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sinif5.ShowFooter = False
        Me.sec_sinif5.ShowHeader = False
        Me.sec_sinif5.ShowLines = False
        Me.sec_sinif5.ValueMember = "IND"
        '
        'colMUSTERI
        '
        Me.colMUSTERI.Caption = "Müşteri"
        Me.colMUSTERI.FieldName = "MUSTERI"
        Me.colMUSTERI.Name = "colMUSTERI"
        Me.colMUSTERI.Visible = True
        Me.colMUSTERI.VisibleIndex = 2
        Me.colMUSTERI.Width = 108
        '
        'colMEKTUPSAYISI
        '
        Me.colMEKTUPSAYISI.Caption = "MektupSayısı"
        Me.colMEKTUPSAYISI.FieldName = "MEKTUPSAYISI"
        Me.colMEKTUPSAYISI.Name = "colMEKTUPSAYISI"
        Me.colMEKTUPSAYISI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MEKTUPSAYISI", "{0:#,0.##}")})
        '
        'colSONTAHSILATTARIHI
        '
        Me.colSONTAHSILATTARIHI.Caption = "Son Tahsilat Tarihi"
        Me.colSONTAHSILATTARIHI.FieldName = "SONTAHSILATTARIHI"
        Me.colSONTAHSILATTARIHI.Name = "colSONTAHSILATTARIHI"
        Me.colSONTAHSILATTARIHI.Visible = True
        Me.colSONTAHSILATTARIHI.VisibleIndex = 4
        Me.colSONTAHSILATTARIHI.Width = 88
        '
        'colSONSATISTARIHI
        '
        Me.colSONSATISTARIHI.Caption = "Son Satış Tarihi"
        Me.colSONSATISTARIHI.FieldName = "SONSATISTARIHI"
        Me.colSONSATISTARIHI.Name = "colSONSATISTARIHI"
        Me.colSONSATISTARIHI.Visible = True
        Me.colSONSATISTARIHI.VisibleIndex = 3
        Me.colSONSATISTARIHI.Width = 81
        '
        'colSATISTUTARI
        '
        Me.colSATISTUTARI.Caption = "SatışTutarı"
        Me.colSATISTUTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colSATISTUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSATISTUTARI.FieldName = "SATISTUTARI"
        Me.colSATISTUTARI.Name = "colSATISTUTARI"
        Me.colSATISTUTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SATISTUTARI", "{0:#,0.00}")})
        Me.colSATISTUTARI.Width = 68
        '
        'colSATISMIKTARI
        '
        Me.colSATISMIKTARI.Caption = "SatışMiktarı"
        Me.colSATISMIKTARI.FieldName = "SATISMIKTARI"
        Me.colSATISMIKTARI.Name = "colSATISMIKTARI"
        Me.colSATISMIKTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SATISMIKTARI", "{0:#,0.##}")})
        '
        'colIADETUTARI
        '
        Me.colIADETUTARI.Caption = "İadeTutarı"
        Me.colIADETUTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colIADETUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIADETUTARI.FieldName = "IADETUTARI"
        Me.colIADETUTARI.Name = "colIADETUTARI"
        Me.colIADETUTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADETUTARI", "{0:#,0.00}")})
        '
        'colIADEMIKTARI
        '
        Me.colIADEMIKTARI.Caption = "İadeMiktarı"
        Me.colIADEMIKTARI.FieldName = "IADEMIKTARI"
        Me.colIADEMIKTARI.Name = "colIADEMIKTARI"
        Me.colIADEMIKTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADEMIKTARI", "{0:#,0.##}")})
        '
        'colTOPLAMSATISTUTARI
        '
        Me.colTOPLAMSATISTUTARI.Caption = "NetSatışTutarı"
        Me.colTOPLAMSATISTUTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colTOPLAMSATISTUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMSATISTUTARI.FieldName = "TOPLAMSATISTUTARI"
        Me.colTOPLAMSATISTUTARI.Name = "colTOPLAMSATISTUTARI"
        Me.colTOPLAMSATISTUTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMSATISTUTARI", "{0:#,0.00}")})
        Me.colTOPLAMSATISTUTARI.Visible = True
        Me.colTOPLAMSATISTUTARI.VisibleIndex = 5
        Me.colTOPLAMSATISTUTARI.Width = 79
        '
        'colTOPLAMSATISMIKTARI
        '
        Me.colTOPLAMSATISMIKTARI.Caption = "NetSatışMiktarı"
        Me.colTOPLAMSATISMIKTARI.FieldName = "TOPLAMSATISMIKTARI"
        Me.colTOPLAMSATISMIKTARI.Name = "colTOPLAMSATISMIKTARI"
        Me.colTOPLAMSATISMIKTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMSATISMIKTARI", "{0:#,0.##}")})
        '
        'colTOPLAMPESINAT
        '
        Me.colTOPLAMPESINAT.Caption = "ToplamAlınanPeşinat"
        Me.colTOPLAMPESINAT.DisplayFormat.FormatString = "#,0.00"
        Me.colTOPLAMPESINAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMPESINAT.FieldName = "TOPLAMPESINAT"
        Me.colTOPLAMPESINAT.Name = "colTOPLAMPESINAT"
        Me.colTOPLAMPESINAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMPESINAT", "{0:#,0.00}")})
        '
        'colTOPLAMTAKSIT
        '
        Me.colTOPLAMTAKSIT.Caption = "ToplamTaksit"
        Me.colTOPLAMTAKSIT.DisplayFormat.FormatString = "#,0.00"
        Me.colTOPLAMTAKSIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMTAKSIT.FieldName = "TOPLAMTAKSIT"
        Me.colTOPLAMTAKSIT.Name = "colTOPLAMTAKSIT"
        Me.colTOPLAMTAKSIT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMTAKSIT", "{0:#,0.00}")})
        Me.colTOPLAMTAKSIT.Width = 50
        '
        'colGECIKENILKTAKSITTARIHI
        '
        Me.colGECIKENILKTAKSITTARIHI.Caption = "KalanİlkTaksitTarihi"
        Me.colGECIKENILKTAKSITTARIHI.FieldName = "GECIKENILKTAKSITTARIHI"
        Me.colGECIKENILKTAKSITTARIHI.Name = "colGECIKENILKTAKSITTARIHI"
        '
        'colGECIKENILKTAKSITTUTARI
        '
        Me.colGECIKENILKTAKSITTUTARI.Caption = "KalanİlkTaksitTutarı"
        Me.colGECIKENILKTAKSITTUTARI.FieldName = "GECIKENILKTAKSITTUTARI"
        Me.colGECIKENILKTAKSITTUTARI.Name = "colGECIKENILKTAKSITTUTARI"
        '
        'colTOPLAMTAHSILAT
        '
        Me.colTOPLAMTAHSILAT.Caption = "ToplamTahsilat"
        Me.colTOPLAMTAHSILAT.DisplayFormat.FormatString = "#,0.00"
        Me.colTOPLAMTAHSILAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMTAHSILAT.FieldName = "TOPLAMTAHSILAT"
        Me.colTOPLAMTAHSILAT.Name = "colTOPLAMTAHSILAT"
        Me.colTOPLAMTAHSILAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMTAHSILAT", "{0:#,0.00}")})
        Me.colTOPLAMTAHSILAT.Width = 68
        '
        'colTOPLAMKALAN
        '
        Me.colTOPLAMKALAN.Caption = "ToplamKalan"
        Me.colTOPLAMKALAN.DisplayFormat.FormatString = "#,0.00"
        Me.colTOPLAMKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMKALAN.FieldName = "TOPLAMKALAN"
        Me.colTOPLAMKALAN.Name = "colTOPLAMKALAN"
        Me.colTOPLAMKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMKALAN", "{0:#,0.00}")})
        Me.colTOPLAMKALAN.Visible = True
        Me.colTOPLAMKALAN.VisibleIndex = 6
        Me.colTOPLAMKALAN.Width = 79
        '
        'colGECIKMISKALAN
        '
        Me.colGECIKMISKALAN.Caption = "GecikmişTaksit"
        Me.colGECIKMISKALAN.DisplayFormat.FormatString = "#,0.00"
        Me.colGECIKMISKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGECIKMISKALAN.FieldName = "GECIKMISKALAN"
        Me.colGECIKMISKALAN.Name = "colGECIKMISKALAN"
        Me.colGECIKMISKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GECIKMISKALAN", "{0:#,0.00}")})
        '
        'colGECIKMISTAKSIT
        '
        Me.colGECIKMISTAKSIT.Caption = "GecikmişTaksitSayısı"
        Me.colGECIKMISTAKSIT.FieldName = "GECIKMISTAKSIT"
        Me.colGECIKMISTAKSIT.Name = "colGECIKMISTAKSIT"
        Me.colGECIKMISTAKSIT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GECIKMISTAKSIT", "{0:#,0.##}")})
        '
        'colKALANTAKSITSAYISI
        '
        Me.colKALANTAKSITSAYISI.Caption = "KalanTaksitSayısı"
        Me.colKALANTAKSITSAYISI.FieldName = "KALANTAKSITSAYISI"
        Me.colKALANTAKSITSAYISI.Name = "colKALANTAKSITSAYISI"
        Me.colKALANTAKSITSAYISI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALANTAKSITSAYISI", "{0:#,0.##}")})
        Me.colKALANTAKSITSAYISI.Visible = True
        Me.colKALANTAKSITSAYISI.VisibleIndex = 7
        Me.colKALANTAKSITSAYISI.Width = 94
        '
        'colSATISSAYISI
        '
        Me.colSATISSAYISI.Caption = "SatışSayısı"
        Me.colSATISSAYISI.FieldName = "SATISSAYISI"
        Me.colSATISSAYISI.Name = "colSATISSAYISI"
        '
        'colIADESAYISI
        '
        Me.colIADESAYISI.Caption = "İadeSayısı"
        Me.colIADESAYISI.FieldName = "IADESAYISI"
        Me.colIADESAYISI.Name = "colIADESAYISI"
        '
        'colSONSATISTUTARI
        '
        Me.colSONSATISTUTARI.Caption = "SonSatışTutarı"
        Me.colSONSATISTUTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colSONSATISTUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSONSATISTUTARI.FieldName = "SONSATISTUTARI"
        Me.colSONSATISTUTARI.Name = "colSONSATISTUTARI"
        Me.colSONSATISTUTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SONSATISTUTARI", "{0:#,0.00}")})
        '
        'colSONTAHSILATTUTARI
        '
        Me.colSONTAHSILATTUTARI.Caption = "SonTahsilatTutarı"
        Me.colSONTAHSILATTUTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colSONTAHSILATTUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSONTAHSILATTUTARI.FieldName = "SONTAHSILATTUTARI"
        Me.colSONTAHSILATTUTARI.Name = "colSONTAHSILATTUTARI"
        Me.colSONTAHSILATTUTARI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SONTAHSILATTUTARI", "{0:#,0.00}")})
        '
        'colGUNUNDEODEME
        '
        Me.colGUNUNDEODEME.Caption = "GünündeÖdeme"
        Me.colGUNUNDEODEME.DisplayFormat.FormatString = "#,0.##"
        Me.colGUNUNDEODEME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGUNUNDEODEME.FieldName = "GUNUNDEN"
        Me.colGUNUNDEODEME.Name = "colGUNUNDEODEME"
        Me.colGUNUNDEODEME.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GUNUNDEN", "{0:#,0.##}")})
        '
        'colERKENODEME
        '
        Me.colERKENODEME.Caption = "ErkenÖdeme"
        Me.colERKENODEME.DisplayFormat.FormatString = "#,0.##"
        Me.colERKENODEME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colERKENODEME.FieldName = "ERKEN"
        Me.colERKENODEME.Name = "colERKENODEME"
        Me.colERKENODEME.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ERKEN", "{0:#,0.##}")})
        '
        'colGECIKMIS
        '
        Me.colGECIKMIS.Caption = "Gecikmiş"
        Me.colGECIKMIS.DisplayFormat.FormatString = "#,0.##"
        Me.colGECIKMIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGECIKMIS.FieldName = "GECIKMIS"
        Me.colGECIKMIS.Name = "colGECIKMIS"
        Me.colGECIKMIS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GECIKMIS", "{0:#,0.##}")})
        '
        'colTOPLAMODEME
        '
        Me.colTOPLAMODEME.Caption = "ToplamÖdeme"
        Me.colTOPLAMODEME.DisplayFormat.FormatString = "#,0.##"
        Me.colTOPLAMODEME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMODEME.FieldName = "TOPLAM"
        Me.colTOPLAMODEME.Name = "colTOPLAMODEME"
        Me.colTOPLAMODEME.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAM", "{0:#,0.##}")})
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Cari Hesap Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Cari İşlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem3, Me.MenuItem34, Me.MenuItem28, Me.MenuItem16, Me.MenuItem26, Me.MenuItem25, Me.MenuItem27, Me.MenuItem1, Me.MenuItem36, Me.MenuItem12, Me.MenuItem37, Me.MenuItem5, Me.MenuItem39, Me.MenuItem6, Me.MenuItem38, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem19, Me.MenuItem18, Me.MenuItem24, Me.MenuItem20})
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem17.Text = "Ara"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 3
        Me.MenuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32, Me.MenuItem33})
        Me.MenuItem28.Text = "Gelişmiş Ara"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 0
        Me.MenuItem29.Text = "Gecikmiş Tahsilatlardan"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 1
        Me.MenuItem30.Text = "Satışlardan"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 2
        Me.MenuItem31.Text = "Tahsilatlardan"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 3
        Me.MenuItem32.Text = "Gecikmiş Borçlulara Satışlardan"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 4
        Me.MenuItem33.Text = "Gecikmiş Borçlu Tahsilatlarından"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 5
        Me.MenuItem26.Text = "Tümünü Hesapla"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 6
        Me.MenuItem25.Text = "Seçilmişleri Hesapla"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 7
        Me.MenuItem27.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 8
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem4, Me.MenuItem15, Me.MenuItem35})
        Me.MenuItem1.Text = "Yazdır"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Önizle"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Dizayn"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "Yazdır"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 3
        Me.MenuItem35.Text = "Tümünü Direkt Yazdır"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 9
        Me.MenuItem36.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 10
        Me.MenuItem12.Text = "Mektup Gönder"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 11
        Me.MenuItem37.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 12
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem5.Text = "Kalan Taksitler"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 13
        Me.MenuItem39.Text = "Kalan Satışlar"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 14
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem6.Text = "Satışlar"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 15
        Me.MenuItem38.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem38.Text = "Müşteri Kartı"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 16
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 17
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 18
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 19
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdır"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 20
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 21
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 22
        Me.MenuItem11.Text = "Gruplandır"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 23
        Me.MenuItem19.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 24
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem18.Text = "Tam Ekran"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 25
        Me.MenuItem24.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 26
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem20.Text = "Dil Değiştir"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "Turkish"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "English"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "Arabic"
        '
        'frm_cari
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(830, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Hesap Listesi"
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
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean
    Dim kriter
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
    Public tarih1
    Public tarih2
    Public limit
    Public stokkod1
    Public stokkod2
    Public stokkod3
    Public stokkod4
    Public stokkod5
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
    Public qtarih
    Public qlimit
    Public qstokkod1
    Public qstokkod2
    Public qstokkod3
    Public qstokkod4
    Public qstokkod5
    Public carino
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim count
    Public language
    Public frf_islem As String = "mektup"
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim ds_taksit_kalan As DataSet
    Dim ds_taksitler As DataSet
    Dim ds_satislar As DataSet
    Dim ds_satislar_detayli As DataSet
    Dim ds_tahsilatlar As DataSet
    Dim ds_odemeler As DataSet
    Private Sub frm_cari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)

        If language = "turkish" Then
            language_turkish()
        ElseIf language = "arabic" Then
            language_arabic()
        End If
        'If status = False Then
        '    Me.Hide()
        '    count = ""
        '    Dim frm As New frm_cari_ara
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    If frm.ShowDialog(Me) = DialogResult.OK Then
        '        kayitno = frm.kayitno
        '        firmakodu = frm.firmakodu
        '        firmaadi = frm.firmaadi
        '        adres = frm.adres
        '        personel = frm.personel
        '        kod1 = frm.kod1
        '        kod2 = frm.kod2
        '        kod3 = frm.kod3
        '        kod4 = frm.kod4
        '        kod5 = frm.kod5
        '        istihbarat = frm.istihbarat
        '        telefon = frm.telefon
        '        firmatipi = frm.firmatipi
        '        aktif = frm.aktif
        '        tarih1 = frm.tarih2
        '        tarih2 = frm.tarih2
        '        limit = frm.limit
        '        qkayitno = frm.qkayitno
        '        qfirmakodu = frm.qfirmakodu
        '        qfirmaadi = frm.qfirmaadi
        '        qadres = frm.qadres
        '        qpersonel = frm.qpersonel
        '        qkod1 = frm.qkod1
        '        qkod2 = frm.qkod2
        '        qkod3 = frm.qkod3
        '        qkod4 = frm.qkod4
        '        qkod5 = frm.qkod5
        '        qistihbarat = frm.qistihbarat
        '        qtelefon = frm.qtelefon
        '        qfirmatipi = frm.qfirmatipi
        '        qaktif = frm.qaktif
        '        qtarih = frm.qtarih
        '        qlimit = frm.qlimit
        '        dataload()
        '        Me.Show()
        '        frm.DataSet1.Clear()
        '        frm.DataSet1.Dispose()
        '        frm.DataSet1 = Nothing
        '        frm.DataSet2.Clear()
        '        frm.DataSet2.Dispose()
        '        frm.DataSet2 = Nothing
        '        frm.DataSet3.Clear()
        '        frm.DataSet3.Dispose()
        '        frm.DataSet3 = Nothing
        '        frm.VGridControl1.Dispose()
        '        frm.VGridControl1 = Nothing
        '        frm.Dispose()
        '        frm = Nothing
        '    Else
        '        Me.Close()
        '    End If
        '    dataload_depo()
        'Else
        '    count = "TOP 1000"
        '    dataload()
        'End If
        dataload_depo()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ara()
        Dim frm As New frm_cari_ara
        carino = 0
        frm.language = language
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.kayitno
            firmakodu = frm.firmakodu
            firmaadi = frm.firmaadi
            adres = frm.adres
            personel = frm.personel
            kod1 = frm.kod1
            kod2 = frm.kod2
            kod3 = frm.kod3
            kod4 = frm.kod4
            kod5 = frm.kod5
            istihbarat = frm.istihbarat
            telefon = frm.telefon
            firmatipi = frm.firmatipi
            aktif = frm.aktif
            tarih1 = frm.tarih2
            tarih2 = frm.tarih2
            limit = frm.limit
            stokkod1 = frm.stokkod1
            stokkod2 = frm.stokkod2
            stokkod3 = frm.stokkod3
            stokkod4 = frm.stokkod4
            stokkod5 = frm.stokkod5
            qkayitno = frm.qkayitno
            qfirmakodu = frm.qfirmakodu
            qfirmaadi = frm.qfirmaadi
            qadres = frm.qadres
            qpersonel = frm.qpersonel
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkod3 = frm.qkod3
            qkod4 = frm.qkod4
            qkod5 = frm.qkod5
            qistihbarat = frm.qistihbarat
            qtelefon = frm.qtelefon
            qfirmatipi = frm.qfirmatipi
            qaktif = frm.qaktif
            qtarih = frm.qtarih
            qlimit = frm.qlimit
            qstokkod1 = frm.qstokkod1
            qstokkod2 = frm.qstokkod2
            qstokkod3 = frm.qstokkod3
            qstokkod4 = frm.qstokkod4
            qstokkod5 = frm.qstokkod5
            dataload()
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub ara_kriter(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_cari_ara
        carino = 0
        frm.language = language
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.rowTARIH.Visible = True
        frm.rowLIMIT.Visible = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.kayitno
            firmakodu = frm.firmakodu
            firmaadi = frm.firmaadi
            adres = frm.adres
            personel = frm.personel
            kod1 = frm.kod1
            kod2 = frm.kod2
            kod3 = frm.kod3
            kod4 = frm.kod4
            kod5 = frm.kod5
            istihbarat = frm.istihbarat
            telefon = frm.telefon
            firmatipi = frm.firmatipi
            aktif = frm.aktif
            tarih1 = frm.tarih1
            tarih2 = frm.tarih2
            limit = frm.limit
            stokkod1 = frm.stokkod1
            stokkod2 = frm.stokkod2
            stokkod3 = frm.stokkod3
            stokkod4 = frm.stokkod4
            stokkod5 = frm.stokkod5
            qkayitno = frm.qkayitno
            qfirmakodu = frm.qfirmakodu
            qfirmaadi = frm.qfirmaadi
            qadres = frm.qadres
            qpersonel = frm.qpersonel
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkod3 = frm.qkod3
            qkod4 = frm.qkod4
            qkod5 = frm.qkod5
            qistihbarat = frm.qistihbarat
            qtelefon = frm.qtelefon
            qfirmatipi = frm.qfirmatipi
            qaktif = frm.qaktif
            qtarih = frm.qtarih
            qlimit = frm.qlimit
            qstokkod1 = frm.qstokkod1
            qstokkod2 = frm.qstokkod2
            qstokkod3 = frm.qstokkod3
            qstokkod4 = frm.qstokkod4
            qstokkod5 = frm.qstokkod5
            dataload(islem)
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
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
        SimpleButton7.Text = Sorgu_sDil(SimpleButton7.Text, sDil)
        SimpleButton8.Text = Sorgu_sDil(SimpleButton8.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload(Optional ByVal islem As Integer = 0)
        DataSet1.Clear()
        cari(islem)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        If carino > 0 And carino < 100 Then
            sorgu()
        End If
        Me.Refresh()
        'If XtraMessageBox.Show(Sorgu_sDil("Müşteri Analizi Hesaplamasına Başlamak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
        '    taksit_kontrol()
        'End If
    End Sub
    Private Sub dataload_depo()
        sec_sinif1.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif1")).Tables(0) 'DataSet2.Tables(0)
        sec_sinif2.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif2")).Tables(0) 'DataSet2.Tables(0)
        sec_sinif3.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif3")).Tables(0) 'DataSet2.Tables(0)
        sec_sinif4.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif4")).Tables(0) 'DataSet2.Tables(0)
        sec_sinif5.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif5")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
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
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub taksit_kontrol()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satır Sayısı : " & GridView1.RowCount
        bar.Position = 0
        For Each dr In DataSet1.Tables(0).Rows
            'Satır Oku
            barlabel.Text = "MüşteriKodu:" & dr("lKodu").ToString & vbTab & "Adı:" & dr("MUSTERI").ToString
            barlabel.Refresh()
            ds_taksit_kalan = sorgu_taksitler_kalanli(dr("nMusteriId"))
            For Each dr1 In ds_taksit_kalan.Tables(0).Rows
                dr("TOPLAMTAKSIT") = sorgu_sayi(dr1("TUTAR"), 0)
                dr("TOPLAMTAHSILAT") = sorgu_sayi(dr1("TAHSILAT"), 0)
                dr("TOPLAMKALAN") = sorgu_sayi(dr1("KALAN"), 0)
            Next
            ds_taksitler = sorgu_taksitler(dr("nMusteriID"))
            Dim ilktaksit As DateTime
            Dim ilktaksittutar As Decimal
            Dim gecikmistaksitsayisi As Int64 = 0
            Dim gecikmistaksittutari As Decimal = 0
            Dim kalantaksitsayisi As Int64 = 0
            Dim sayi As Integer = 0
            bar2.Properties.Maximum = ds_taksitler.Tables(0).Rows.Count
            barlabel2.Text = "Taksitler Okunuyor...Toplam Satır Sayısı : " & ds_taksitler.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            sayi = 0
            For Each dr1 In ds_taksitler.Tables(0).Rows
                sayi += 1
                If sayi = 1 Then
                    ilktaksit = dr1("dteTarihi")
                    ilktaksittutar = dr1("KALAN")
                End If
                If dr1("dteTarihi") <= Today Then
                    gecikmistaksitsayisi += 1
                    gecikmistaksittutari += dr1("KALAN")
                End If
                kalantaksitsayisi += 1
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            Try
                dr("GECIKENILKTAKSITTARIHI") = ilktaksit
                dr("GECIKENILKTAKSITTUTARI") = sorgu_sayi(ilktaksittutar, 2)
            Catch ex As Exception
            End Try
            dr("GECIKMISTAKSIT") = sorgu_sayi(gecikmistaksitsayisi, 0)
            dr("GECIKMISKALAN") = sorgu_sayi(gecikmistaksittutari, 0)
            dr("KALANTAKSITSAYISI") = sorgu_sayi(kalantaksitsayisi, 0)
            'Satışlar
            ds_satislar_detayli = sorgu_satislar_detayli(dr("nMusteriID"))
            Dim toplammiktar As Decimal = 0
            Dim toplamsatistutari As Decimal = 0
            Dim toplampesinattutari As Decimal = 0
            Dim iademiktar As Decimal = 0
            Dim iadetutari As Decimal = 0
            Dim satissayisi As Int64 = 0
            Dim satismiktar As Decimal = 0
            Dim satistutari As Decimal = 0
            Dim iadesayisi As Int64 = 0
            Dim sonsatistutari As Decimal = 0
            Dim sonsatistarihi As DateTime
            sayi = 0
            bar2.Properties.Maximum = ds_satislar_detayli.Tables(0).Rows.Count
            barlabel2.Text = "Satışlar Okunuyor...Toplam Satır Sayısı : " & ds_satislar_detayli.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            For Each dr1 In ds_satislar_detayli.Tables(0).Rows
                If dr1("nGirisCikis") = 3 Then
                    satismiktar += dr1("lToplamMiktar")
                    satistutari += dr1("lNetTutar")
                    toplampesinattutari = dr1("lPesinat")
                    satissayisi += 1
                    sayi += 1
                    If sayi = 1 Then
                        sonsatistutari += dr1("lNetTutar")
                        sonsatistarihi = dr1("dteFaturaTarihi")
                    End If
                ElseIf dr1("nGirisCikis") = 4 Then
                    iademiktar += Math.Abs(dr1("lToplamMiktar"))
                    iadetutari += Math.Abs(dr1("lNetTutar"))
                    iadesayisi += 1
                End If
                toplammiktar += dr1("lToplamMiktar")
                toplamsatistutari += dr1("lNetTutar")
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            dr("SATISSAYISI") = sorgu_sayi(satissayisi, 0)
            dr("IADESAYISI") = sorgu_sayi(iadesayisi, 0)
            dr("SATISTUTARI") = sorgu_sayi(satistutari, 0)
            dr("SATISMIKTARI") = sorgu_sayi(satismiktar, 0)
            dr("IADETUTARI") = sorgu_sayi(iadetutari, 0)
            dr("IADEMIKTARI") = sorgu_sayi(iademiktar, 0)
            dr("TOPLAMSATISTUTARI") = sorgu_sayi(toplamsatistutari, 0)
            dr("TOPLAMSATISMIKTARI") = sorgu_sayi(toplammiktar, 0)
            dr("TOPLAMPESINAT") = sorgu_sayi(toplampesinattutari, 0)
            dr("SONSATISTUTARI") = sorgu_sayi(sonsatistutari, 0)
            dr("SONSATISTARIHI") = sonsatistarihi
            'Tahsilatlar
            ds_tahsilatlar = sorgu_tahsilatlar_toplam(dr("nMusteriID"))
            Dim sontahsilattarihi As DateTime
            Dim sontahsilattutari As Decimal = 0
            bar2.Properties.Maximum = ds_tahsilatlar.Tables(0).Rows.Count
            barlabel2.Text = "Tahsilatlar Okunuyor...Toplam Satır Sayısı : " & ds_tahsilatlar.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            For Each dr1 In ds_tahsilatlar.Tables(0).Rows
                sontahsilattarihi = dr1("dteOdemeTarihi")
                sontahsilattutari = dr1("TAHSILAT")
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            dr("SONTAHSILATTARIHI") = sontahsilattarihi
            dr("SONTAHSILATTUTARI") = sorgu_sayi(sontahsilattutari, 0)
            Try
                ds_odemeler = sorgu_odemeler_sayi(dr("nMusteriID"))
                Dim gununde As Int64 = 0
                Dim erken As Int64 = 0
                Dim gecikmis As Int64 = 0
                Dim toplam As Int64 = 0
                bar2.Properties.Maximum = ds_odemeler.Tables(0).Rows.Count
                barlabel2.Text = "ÖdemeAnalizi Okunuyor...Toplam Satır Sayısı : " & ds_odemeler.Tables(0).Rows.Count
                bar2.Position = 0
                barlabel2.Refresh()
                For Each dr1 In ds_odemeler.Tables(0).Rows
                    gecikmis = sorgu_sayi(dr1("GECIKMIS"), 0)
                    erken = sorgu_sayi(dr1("ERKEN"), 0)
                    gununde = sorgu_sayi(dr1("GUNUNDE"), 0)
                    bar2.Position = bar2.Position + 1
                    bar2.Refresh()
                Next
                dr("GUNUNDE") = gununde
                dr("GECIKMIS") = gecikmis
                dr("ERKEN") = erken
                dr("TOPLAM") = gununde + gecikmis + erken
            Catch ex As Exception
                dr("GUNUNDE") = 0
                dr("GECIKMIS") = 0
                dr("ERKEN") = 0
                dr("TOPLAM") = 0
            End Try
            'Satır Bitir
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub taksit_kontrol_satir()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satır Sayısı : " & GridView1.RowCount
        bar.Position = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'Satır Oku
        barlabel.Text = "MüşteriKodu:" & dr("lKodu").ToString & vbTab & "Adı:" & dr("MUSTERI").ToString
        barlabel.Refresh()
        ds_taksit_kalan = sorgu_taksitler_kalanli(dr("nMusteriId"))
        For Each dr1 In ds_taksit_kalan.Tables(0).Rows
            dr("TOPLAMTAKSIT") = dr1("TUTAR")
            dr("TOPLAMTAHSILAT") = dr1("TAHSILAT")
            dr("TOPLAMKALAN") = dr1("KALAN")
        Next
        ds_taksitler = sorgu_taksitler(dr("nMusteriID"))
        Dim ilktaksit As DateTime
        Dim ilktaksittutar As Decimal
        Dim gecikmistaksitsayisi As Int64 = 0
        Dim gecikmistaksittutari As Decimal = 0
        Dim kalantaksitsayisi As Int64 = 0
        Dim sayi As Integer = 0
        For Each dr1 In ds_taksitler.Tables(0).Rows
            sayi += 1
            If sayi = 1 Then
                ilktaksit = dr1("dteTarihi")
                ilktaksittutar = dr1("KALAN")
            End If
            If dr1("dteTarihi") <= Today Then
                gecikmistaksitsayisi += 1
                gecikmistaksittutari += dr1("KALAN")
            End If
            kalantaksitsayisi += 1
        Next
        Try
            dr("GECIKENILKTAKSITTARIHI") = ilktaksit
            dr("GECIKENILKTAKSITTUTARI") = ilktaksittutar
        Catch ex As Exception
        End Try
        dr("GECIKMISTAKSIT") = gecikmistaksitsayisi
        dr("GECIKMISKALAN") = gecikmistaksittutari
        dr("KALANTAKSITSAYISI") = kalantaksitsayisi
        'Satışlar
        ds_satislar_detayli = sorgu_satislar_detayli(dr("nMusteriID"))
        Dim toplammiktar As Decimal = 0
        Dim toplamsatistutari As Decimal = 0
        Dim toplampesinattutari As Decimal = 0
        Dim iademiktar As Decimal = 0
        Dim iadetutari As Decimal = 0
        Dim satissayisi As Int64 = 0
        Dim satismiktar As Decimal = 0
        Dim satistutari As Decimal = 0
        Dim iadesayisi As Int64 = 0
        Dim sonsatistutari As Decimal = 0
        Dim sonsatistarihi As DateTime
        sayi = 0
        For Each dr1 In ds_satislar_detayli.Tables(0).Rows
            If dr1("nGirisCikis") = 3 Then
                satismiktar += dr1("lToplamMiktar")
                satistutari += dr1("lNetTutar")
                toplampesinattutari = dr1("lPesinat")
                satissayisi += 1
                sayi += 1
                If sayi = 1 Then
                    sonsatistutari += dr1("lNetTutar")
                    sonsatistarihi = dr1("dteFaturaTarihi")
                End If
            ElseIf dr1("nGirisCikis") = 4 Then
                iademiktar += Math.Abs(dr1("lToplamMiktar"))
                iadetutari += Math.Abs(dr1("lNetTutar"))
                iadesayisi += 1
            End If
            toplammiktar += dr1("lToplamMiktar")
            toplamsatistutari += dr1("lNetTutar")
        Next
        dr("SATISSAYISI") = satissayisi
        dr("IADESAYISI") = iadesayisi
        dr("SATISTUTARI") = satistutari
        dr("SATISMIKTARI") = satismiktar
        dr("IADETUTARI") = iadetutari
        dr("IADEMIKTARI") = iademiktar
        dr("TOPLAMSATISTUTARI") = toplamsatistutari
        dr("TOPLAMSATISMIKTARI") = toplammiktar
        dr("TOPLAMPESINAT") = toplampesinattutari
        dr("SONSATISTUTARI") = sonsatistutari
        dr("SONSATISTARIHI") = sonsatistarihi
        'Tahsilatlar
        ds_tahsilatlar = sorgu_tahsilatlar_toplam(dr("nMusteriID"))
        Dim sontahsilattarihi As DateTime
        Dim sontahsilattutari As Decimal = 0
        For Each dr1 In ds_tahsilatlar.Tables(0).Rows
            sontahsilattarihi = dr1("dteOdemeTarihi")
            sontahsilattutari = dr1("TAHSILAT")
        Next
        dr("SONTAHSILATTARIHI") = sontahsilattarihi
        dr("SONTAHSILATTUTARI") = sontahsilattutari
        'Satır Bitir
        bar.Position = bar.Position + 1
        bar.Refresh()
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Sub taksit_kontrol_satirlar()
        Dim dr As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            Panelstatus.Visible = True
            bar.Properties.Maximum = GridView1.SelectedRowsCount
            barlabel.Text = "Toplam Satır Sayısı : " & GridView1.SelectedRowsCount
            bar.Position = 0
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                'Panelstatus.Visible = True
                'bar.Properties.Maximum = GridView1.SelectedRowsCount
                'barlabel.Text = "Toplam Satır Sayısı : " & GridView1.SelectedRowsCount
                'bar.Position = 0
                'Satır Oku
                barlabel.Text = "MüşteriKodu:" & dr("lKodu").ToString & vbTab & "Adı:" & dr("MUSTERI").ToString
                barlabel.Refresh()
                ds_taksit_kalan = sorgu_taksitler_kalanli(dr("nMusteriId"))
                For Each dr1 In ds_taksit_kalan.Tables(0).Rows
                    dr("TOPLAMTAKSIT") = dr1("TUTAR")
                    dr("TOPLAMTAHSILAT") = dr1("TAHSILAT")
                    dr("TOPLAMKALAN") = dr1("KALAN")
                Next
                ds_taksitler = sorgu_taksitler(dr("nMusteriID"))
                Dim ilktaksit As DateTime
                Dim ilktaksittutar As Decimal
                Dim gecikmistaksitsayisi As Int64 = 0
                Dim gecikmistaksittutari As Decimal = 0
                Dim kalantaksitsayisi As Int64 = 0
                barlabel2.Text = "Taksitler Okunuyor...Toplam Satır Sayısı : " & ds_taksitler.Tables(0).Rows.Count
                bar2.Properties.Maximum = ds_taksitler.Tables(0).Rows.Count
                bar2.Position = 0
                barlabel2.Refresh()
                sayi = 0
                For Each dr1 In ds_taksitler.Tables(0).Rows
                    sayi += 1
                    If sayi = 1 Then
                        ilktaksit = dr1("dteTarihi")
                        ilktaksittutar = dr1("KALAN")
                    End If
                    If dr1("dteTarihi") <= Today Then
                        gecikmistaksitsayisi += 1
                        gecikmistaksittutari += dr1("KALAN")
                    End If
                    kalantaksitsayisi += 1
                    bar2.Position = bar2.Position + 1
                    bar2.Refresh()
                Next
                dr("GECIKENILKTAKSITTARIHI") = ilktaksit
                dr("GECIKENILKTAKSITTUTARI") = ilktaksittutar
                dr("GECIKMISTAKSIT") = gecikmistaksitsayisi
                dr("GECIKMISKALAN") = gecikmistaksittutari
                dr("KALANTAKSITSAYISI") = kalantaksitsayisi
                'Satışlar
                ds_satislar_detayli = sorgu_satislar_detayli(dr("nMusteriID"))
                Dim toplammiktar As Decimal = 0
                Dim toplamsatistutari As Decimal = 0
                Dim toplampesinattutari As Decimal = 0
                Dim iademiktar As Decimal = 0
                Dim iadetutari As Decimal = 0
                Dim satissayisi As Int64 = 0
                Dim satismiktar As Decimal = 0
                Dim satistutari As Decimal = 0
                Dim iadesayisi As Int64 = 0
                Dim sonsatistutari As Decimal = 0
                Dim sonsatistarihi As DateTime
                sayi = 0
                barlabel2.Text = "Satışlar Okunuyor...Toplam Satır Sayısı : " & ds_satislar_detayli.Tables(0).Rows.Count
                bar2.Position = 0
                barlabel2.Refresh()
                For Each dr1 In ds_satislar_detayli.Tables(0).Rows
                    If dr1("nGirisCikis") = 3 Then
                        satismiktar += dr1("lToplamMiktar")
                        satistutari += dr1("lNetTutar")
                        toplampesinattutari = dr1("lPesinat")
                        satissayisi += 1
                        sayi += 1
                        If sayi = 1 Then
                            sonsatistutari += dr1("lNetTutar")
                            sonsatistarihi = dr1("dteFaturaTarihi")
                        End If
                    ElseIf dr1("nGirisCikis") = 4 Then
                        iademiktar += Math.Abs(dr1("lToplamMiktar"))
                        iadetutari += Math.Abs(dr1("lNetTutar"))
                        iadesayisi += 1
                    End If
                    toplammiktar += dr1("lToplamMiktar")
                    toplamsatistutari += dr1("lNetTutar")
                    bar2.Position = bar2.Position + 1
                    bar2.Refresh()
                Next
                dr("SATISSAYISI") = satissayisi
                dr("IADESAYISI") = iadesayisi
                dr("SATISTUTARI") = satistutari
                dr("SATISMIKTARI") = satismiktar
                dr("IADETUTARI") = iadetutari
                dr("IADEMIKTARI") = iademiktar
                dr("TOPLAMSATISTUTARI") = toplamsatistutari
                dr("TOPLAMSATISMIKTARI") = toplammiktar
                dr("TOPLAMPESINAT") = toplampesinattutari
                dr("SONSATISTUTARI") = sonsatistutari
                dr("SONSATISTARIHI") = sonsatistarihi
                'Tahsilatlar
                ds_tahsilatlar = sorgu_tahsilatlar_toplam(dr("nMusteriID"))
                bar2.Properties.Maximum = ds_tahsilatlar.Tables(0).Rows.Count
                barlabel2.Text = "Tahsilatlar Okunuyor...Toplam Satır Sayısı : " & ds_tahsilatlar.Tables(0).Rows.Count
                bar2.Position = 0
                barlabel2.Refresh()
                Dim sontahsilattarihi As DateTime
                Dim sontahsilattutari As Decimal = 0
                For Each dr1 In ds_tahsilatlar.Tables(0).Rows
                    sontahsilattarihi = dr1("dteOdemeTarihi")
                    sontahsilattutari = dr1("TAHSILAT")
                    bar2.Position = bar2.Position + 1
                    bar2.Refresh()
                Next
                dr("SONTAHSILATTARIHI") = sontahsilattarihi
                dr("SONTAHSILATTUTARI") = sontahsilattutari
                Try
                    ds_odemeler = sorgu_odemeler_sayi(dr("nMusteriID"))
                    Dim gununde As Int64 = 0
                    Dim erken As Int64 = 0
                    Dim gecikmis As Int64 = 0
                    Dim toplam As Int64 = 0
                    bar2.Properties.Maximum = ds_odemeler.Tables(0).Rows.Count
                    barlabel2.Text = "ÖdemeAnalizi Okunuyor...Toplam Satır Sayısı : " & ds_odemeler.Tables(0).Rows.Count
                    bar2.Position = 0
                    barlabel2.Refresh()
                    For Each dr1 In ds_odemeler.Tables(0).Rows
                        gecikmis = dr1("GECIKMIS")
                        erken = dr1("ERKEN")
                        gununde = dr1("GUNUNDE")
                        bar2.Position = bar2.Position + 1
                        bar2.Refresh()
                    Next
                    dr("GUNUNDE") = gununde
                    dr("GECIKMIS") = gecikmis
                    dr("ERKEN") = erken
                    dr("TOPLAM") = gununde + gecikmis + erken
                Catch ex As Exception
                    dr("GUNUNDE") = 0
                    dr("GECIKMIS") = 0
                    dr("ERKEN") = 0
                    dr("TOPLAM") = 0
                End Try
                'Satır Bitir
                bar.Position = bar.Position + 1
                bar.Refresh()
            Next
        End If
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Sub cari(Optional ByVal islem As Integer = 0)
        kriter = ""
        If carino <> 0 Then
            kriter += " WHERE ( tbMusteri.nMusteriID = " & carino & ") "
        Else
            kriter += " WHERE ( tbMusteri.nMusteriID >= 0) "
            If firmakodu <> "" Then
                kriter += " AND ( tbMusteri.lKodu " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
            End If
            If firmaadi <> "" Then
                kriter += " AND (  (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) " & sorgu_kriter_string(firmaadi, qfirmaadi) & ")"
            End If
            If adres <> "" Then
                kriter += " AND ( tbMusteri.sEvAdresi1  " & sorgu_kriter_string(adres, qadres) & " )"
            End If
            If telefon <> "" Then
                kriter += " and ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(telefon, qtelefon) & " )"
            End If
            'Açıklama Kontrol
            If stokkod1 <> "" Then
                kriter += " and ( tbMusteri.sAciklama1 " & sorgu_kriter_string(stokkod1, qstokkod1) & " )"
            End If
            If stokkod2 <> "" Then
                kriter += " and (tbMusteri.sAciklama2 " & sorgu_kriter_string(stokkod2, qstokkod2) & " )"
            End If
            If stokkod3 <> "" Then
                kriter += " and (tbMusteri.sAciklama3 " & sorgu_kriter_string(stokkod3, qstokkod3) & " )"
            End If
            If stokkod4 <> "" Then
                kriter += " and (tbMusteri.sAciklama4 " & sorgu_kriter_string(stokkod4, qstokkod4) & " )"
            End If
            If stokkod5 <> "" Then
                kriter += " and (tbMusteri.sAciklama5 " & sorgu_kriter_string(stokkod5, qstokkod5) & " )"
            End If
            If istihbarat <> "" Then
                kriter += " and (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(istihbarat, qistihbarat) & " )"
            End If
            'Sınıf Kontrol
            If kod1 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu1 " & sorgu_kriter_string(kod1, qkod1) & " )"
            End If
            If kod2 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu2 " & sorgu_kriter_string(kod2, qkod2) & " )"
            End If
            If kod3 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu3 " & sorgu_kriter_string(kod3, qkod3) & " )"
            End If
            If kod4 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu4 " & sorgu_kriter_string(kod4, qkod4) & " )"
            End If
            If kod5 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu5 " & sorgu_kriter_string(kod5, qkod5) & " )"
            End If
            'If firmatipi <> "" Then
            '    kriter += " and (FIRMATIPI " & sorgu_kriter_string(firmatipi, qfirmatipi) & " )"
            'End If
            'If aktif <> "" Then
            '    kriter += " and (STATUS " & sorgu_kriter_string(aktif, qaktif) & " )"
            'End If
            If kayitno <> "" Then
                kriter += " and (tbMusteri.nMusteriID " & sorgu_kriter_string(kayitno, qkayitno) & " )"
            End If
            'If personel <> "" Then
            '    kriter += " and (TBLCARI.PERSONELNO " & sorgu_kriter_string(personel, qpersonel) & " )"
            'End If
            If islem = 1 Then
                kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT * FROM (SELECT nMusteriID FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "' GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar BETWEEN 0 AND 999999999999.99) AND (Tutar " & sorgu_kriter_string(limit, qlimit) & " ) GROUP BY nMusteriID , kodu) GECIKME ) ) "
            ElseIf islem = 2 Then
                kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT nMusteriID FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY nMusteriID HAVING (SUM(lNetTutar) > =  " & limit & ") ))"
            ElseIf islem = 3 Then
                kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi HAVING (SUM(tbOdeme.lOdemeTutar) > =  " & limit & " ) ) )"
            ElseIf islem = 4 Then
                kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT nMusteriID FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY nMusteriID HAVING (SUM(lNetTutar) > =  0) ))"
                'kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT nMusteriID FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY nMusteriID HAVING (SUM(lNetTutar) > =  " & limit & ") ))"
                kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT * FROM (SELECT nMusteriID FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi  <  '" & tarih1.ToString.Substring(0, 10) & "' GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar BETWEEN 0 AND 999999999999.99) AND (Tutar " & sorgu_kriter_string(limit, qlimit) & ") GROUP BY nMusteriID , kodu) GECIKME ) ) "
            ElseIf islem = 5 Then
                kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi HAVING (SUM(tbOdeme.lOdemeTutar) > =  0 ) ) )"
                'kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi HAVING (SUM(tbOdeme.lOdemeTutar) > =  " & limit & " ) ) )"
                kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT * FROM (SELECT nMusteriID FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi <   '" & tarih1.ToString.Substring(0, 10) & "'  GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar BETWEEN 0 AND 999999999999.99) AND (Tutar " & sorgu_kriter_string(limit, qlimit) & ") GROUP BY nMusteriID , kodu) GECIKME ) ) "
            End If
        End If
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbMusteri.nMusteriID, tbMusteri.lKodu, (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) AS MUSTERI,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteriSinifi.sSinifKodu1 AS KOD1, tbMusteriSinifi.sSinifKodu2 AS KOD2, tbMusteriSinifi.sSinifKodu3 AS KOD3, tbMusteriSinifi.sSinifKodu4 AS KOD4, tbMusteriSinifi.sSinifKodu5 AS KOD5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID " & kriter & " Order By TbMusteri.lKodu")
        kriter = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        N = Nothing
    End Sub
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "İçermez" Then
            sorgu_kriter = "  NOT LIKE '%" & deger & "%' "
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu_kalan_taksit(ByVal musterino As Int64) As Decimal
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     isnull(Tutar,0)  FROM         vwMusteriKalan  Where nMusteriId = " & musterino & "")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = 35265) GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu")
        Dim tutar As Decimal = cmd.ExecuteScalar
        con.Close()
        Return tutar
    End Function
    Public Function sorgu_taksitler_kalanli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_taksitler(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_satislar_toplam(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     SUM(lToplamMiktar) AS MIKTAR, SUM(lNetTutar) AS TUTAR, SUM(lPesinat) AS PESINAT FROM         tbAlisVeris WHERE     (nMusteriID = " & musterino & ")")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_tahsilatlar_toplam(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 SUM(tbOdeme.lOdemeTutar) AS TAHSILAT, tbOdeme.dteOdemeTarihi, tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & musterino & ") GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi ORDER BY tbOdeme.dteOdemeTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_odemeler_sayi(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nMusteriID, SUM(GECIKMIS) AS GECIKMIS, SUM(ERKEN) AS ERKEN, SUM(GUNUNDE) AS GUNUNDE FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkGecikmis > 0) GROUP BY Musteri_TanimlamaNo UNION SELECT Musteri_TanimlamaNo AS nMusteriID , 0 AS GECIKMIS , COUNT(*) AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken > 0) GROUP BY Musteri_TanimlamaNo UNION SELECT Musteri_TanimlamaNo AS nMusteriID , 0 AS GECIKMIS , 0 AS ERKEN , COUNT(*) AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken = 0) AND (NFarkGecikmis = 0) GROUP BY Musteri_TanimlamaNo) T GROUP BY nMusteriID")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_satislar_detayli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi, dteFaturaTarihi, nGirisCikis, lToplamMiktar, lNetTutar,lPesinat  FROM         tbAlisVeris  WHERE     (nMusteriID = " & musterino & ") ORDER BY dteFaturaTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        printlink1.CreateDocument(ps)
        ps.PreviewFormEx.ShowDialog()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        ara()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'If BarButtonItem6.Down = False Then
        '    GridView1.OptionsCustomization.AllowFilter = True
        '    GridView1.OptionsView.ShowFilterPanel = True
        '    BarButtonItem6.Down = True
        'ElseIf BarButtonItem6.Down = False Then
        '    GridView1.OptionsCustomization.AllowFilter = False
        '    GridView1.OptionsView.ShowFilterPanel = False
        '    BarButtonItem6.Down = False
        'End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'If BarButtonItem7.Down = False Then
        '    GridView1.OptionsCustomization.AllowGroup = True
        '    GridView1.OptionsView.ShowGroupPanel = True
        '    BarButtonItem7.Down = True
        'ElseIf BarButtonItem7.Down = True Then
        '    GridView1.OptionsCustomization.AllowGroup = False
        '    GridView1.OptionsView.ShowGroupPanel = False
        '    BarButtonItem7.Down = False
        'End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        ara()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If MenuItem10.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem10.Checked = True
        ElseIf MenuItem10.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem10.Checked = False
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If MenuItem11.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem11.Checked = True
        ElseIf MenuItem11.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem11.Checked = False
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cari_duzelt()
    End Sub
    Private Sub cari_yeni()
        'cari_islemleri.kart_yeni()
        'If cari_islemleri.sonucstatus = True Then
        '    carino = cari_islemleri.carino
        '    dataload()
        'End If
    End Sub
    Private Sub cari_duzelt()
        If GridView1.RowCount > 0 Then
            'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'cari_islemleri.kart_duzelt(dr("IND"))
            'Dim satir = GridView1.FocusedRowHandle
            'dataload()
            'GridView1.FocusedRowHandle = satir
            'satir = Nothing
            'dr = Nothing
        End If
    End Sub
    Private Sub cari_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satırı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                DataSet1.Tables(0).Rows.Remove(dr)
                GridControl1.Select()
                GridControl1.Focus()
            End If
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Satırları Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView1.DeleteSelectedRows()
            'Try
            '    dr.AcceptChanges()
            'Catch ex As Exception
            'End Try
            Try
                DataSet1.AcceptChanges()
            Catch ex As Exception
            End Try
            'Dim s As String
            'Dim arr As Integer()
            'Dim i As Integer
            'Dim dr1 As DataRow
            'arr = GridView1.GetSelectedRows()
            'If arr Is Nothing Then
            'Else
            '    'arr.Sort(arr)
            '    For Each i In arr
            '        s = i.ToString
            '        dr1 = GridView1.GetDataRow(s)
            '        GridView1.DeleteSelectedRows()
            '        Try
            '            dr1.AcceptChanges()
            '        Catch ex As Exception
            '        End Try
            '        Try
            '            DataSet1.AcceptChanges()
            '        Catch ex As Exception
            '        End Try
            '        'DataSet1.Tables(0).Rows.Remove(dr1)
            '        'DataSet1.AcceptChanges()
            '        GridControl1.Select()
            '        GridControl1.Focus()
            '    Next
            'End If
            's = Nothing
            'arr = Nothing
            'i = Nothing
            'dr1 = Nothing
            'MsgBox(Sorgu_sDil("İşlem Tamamlandı...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        stok_sil()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cari_yeni()
    End Sub
    Private Sub frm_cari_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
        'PanelControl1.Dispose()
        'PanelControl2.Dispose()
        'SimpleButton1.Dispose()
        'SimpleButton2.Dispose()
        'SimpleButton3.Dispose()
        'ContextMenu1.Dispose()
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton3 = Nothing
        'ContextMenu1 = Nothing
        'firmakodu = Nothing
        'firmaadi = Nothing
        'adres = Nothing
        'personel = Nothing
        'kod1 = Nothing
        'kod2 = Nothing
        'kod3 = Nothing
        'kod4 = Nothing
        'kod5 = Nothing
        'telefon = Nothing
        'istihbarat = Nothing
        'firmatipi = Nothing
        'kayitno = Nothing
        'qfirmakodu = Nothing
        'qfirmaadi = Nothing
        'qadres = Nothing
        'qpersonel = Nothing
        'qkod1 = Nothing
        'qkod2 = Nothing
        'qkod3 = Nothing
        'qkod4 = Nothing
        'qkod5 = Nothing
        'qtelefon = Nothing
        'qistihbarat = Nothing
        'qfirmatipi = Nothing
        'qkayitno = Nothing
        'carino = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'connection = Nothing
        'count = Nothing
        'ps.ClearContent()
        'ps.Dispose()
        'ps = Nothing
        'printlink1.Dispose()
        'printlink1 = Nothing
        'Me.Dispose()
        'Me.Close()
        'System.GC.Collect()
        'System.GC.GetTotalMemory(True)
        'System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        language_arabic()
        language = "arabic"
    End Sub
    Private Sub language_arabic()
    End Sub
    Private Sub language_turkish()
    End Sub
    Private Sub language_english()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        language_turkish()
        language = "turkish"
    End Sub
    Private Sub report_create_cari(ByVal dosya As String, ByVal status As Integer)
        'FileOpen(1, dosya, OpenMode.Input)
        'Dim oku() As Byte
        'Dim z = "..\DESIGN\Temp\" + sorgu() + ".fr3"
        'Dim sw As StreamWriter = File.AppendText(z)
        'Do Until EOF(1)
        '    s = LineInput(1)
        '    oku = System.Text.Encoding.UTF8.GetBytes(s)
        '    s = System.Text.Encoding.UTF8.GetString(oku)
        '    'MsgBox(sorgu_query(s.ToString))
        '    sw.WriteLine(sorgu_query(s))
        'Loop
        'FileClose(1)
        'sw.Close()
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            'frx.SetVariable("FIRMA", "'" & firma & "'")
            frx.SetVariable("FIRMANO", "" & firmano & "")
            'frx.SetVariable("DONEM", "'" & donem & "'")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            'frx.SetVariable("USERNO", "" & userno & "")
            'frx.SetVariable("USERNAME", "'" & username & "'")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            'frx.SetVariable("TARIH", "'" & tarih1.ToString.Substring(0, 10) & "'")
            'frx.SetVariable("EVRAKNO", "" & evrakno & "")
            'frx.SetVariable("IZAHAT", "'" & belge.ToString & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query(kriter)
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            frx.PrintOptions.Collate = False
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            End If
            qr_hareket = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query(kriter) & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "4"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 13
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal musterino As Int64, ByVal sontahsilattarihi As DateTime, ByVal sontahsilattutari As Decimal, ByVal sonsatistarihi As DateTime, ByVal sonsatistutari As Decimal, ByVal gecikmistaksitsayisi As Int64, ByVal gecikmistaksittutari As Decimal, ByVal kalantaksitsayisi As Int64, ByVal kalantaksittutari As Decimal, ByVal gecikmisodeme As Int64, ByVal gunundeodeme As Int64, ByVal erkenodeme As Int64, ByVal toplamodeme As Int64)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'frx.PrintOptions.Copies = dr("MIKTAR")
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("GecikmisTaksitSayisi", "" & gecikmistaksitsayisi & "")
            frx.SetVariable("GecikmisTaksitTutari", "" & gecikmistaksittutari & "")
            frx.SetVariable("SonTahsilatTutari", "" & sontahsilattutari & "")
            frx.SetVariable("SonSatisTutari", "" & sonsatistutari & "")
            frx.SetVariable("SonTahsilatTarihi", "'" & sontahsilattarihi & "'")
            frx.SetVariable("SonSatisTarihi", "'" & sonsatistarihi & "'")
            frx.SetVariable("KalanTaksitSayisi", "" & kalantaksitsayisi & "")
            frx.SetVariable("KalanTaksitTutari", "" & kalantaksittutari & "")
            frx.SetVariable("GecikmisOdeme", "" & gecikmisodeme & "")
            frx.SetVariable("GunundeOdeme", "" & gunundeodeme & "")
            frx.SetVariable("ErkenOdeme", "" & erkenodeme & "")
            frx.SetVariable("ToplamOdeme", "" & toplamodeme & "")
            qr_hareket = frx.FindObject("qr_musteri")
            qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu, (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) AS MUSTERI,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteriSinifi.sSinifKodu1 AS KOD1, tbMusteriSinifi.sSinifKodu2 AS KOD2, tbMusteriSinifi.sSinifKodu3 AS KOD3, tbMusteriSinifi.sSinifKodu4 AS KOD4, tbMusteriSinifi.sSinifKodu5 AS KOD5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID Where TbMusteri.nMusteriID =" & musterino & " Order By TbMusteri.lKodu")
            frx.PrintOptions.Collate = False
            If status = 0 Then
                frx.PrepareReport(True)
                frx.DisableDialogs = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.ShowDialog = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            End If
            qr_hareket = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu, (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) AS MUSTERI,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteriSinifi.sSinifKodu1 AS KOD1, tbMusteriSinifi.sSinifKodu2 AS KOD2, tbMusteriSinifi.sSinifKodu3 AS KOD3, tbMusteriSinifi.sSinifKodu4 AS KOD4, tbMusteriSinifi.sSinifKodu5 AS KOD5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID Where TbMusteri.nMusteriID =" & musterino & " Order By TbMusteri.lKodu") & ""
            args(3) = "qr_musteri"
            args(4) = "" & status.ToString() & ""
            args(5) = "16"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "GecikmisTaksitSayisi"
            args(15) = "" & gecikmistaksitsayisi.ToString() & ""
            args(16) = "GecikmisTaksitTutari"
            args(17) = "" & gecikmistaksittutari.ToString() & ""
            args(18) = "SonTahsilatTutari"
            args(19) = "" & sontahsilattutari.ToString() & ""
            args(20) = "SonSatisTutari"
            args(21) = "" & sonsatistutari.ToString() & ""
            args(22) = "SonTahsilatTarihi"
            args(23) = "'" & sontahsilattarihi.ToString() & "'"
            args(24) = "SonSatisTarihi"
            args(25) = "'" & sonsatistarihi.ToString() & "'"
            args(26) = "KalanTaksitSayisi"
            args(27) = "" & kalantaksitsayisi.ToString() & ""
            args(28) = "KalanTaksitTutari"
            args(29) = "" & kalantaksittutari.ToString() & ""
            args(30) = "GecikmisOdeme"
            args(31) = "" & gecikmisodeme.ToString() & ""
            args(32) = "GunundeOdeme"
            args(33) = "" & gunundeodeme.ToString() & ""
            args(34) = "ErkenOdeme"
            args(35) = "" & erkenodeme.ToString() & ""
            args(36) = "ToplamOdeme"
            args(37) = "" & toplamodeme.ToString() & ""
            processYol = args(0)
            For i As Integer = 1 To 37
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Function satir_kontrol()
        Dim dr As DataRow
        Dim satir As String = "WHERE tbMusteri.nMusteriId IN ("
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = DataSet1.Tables(0).NewRow
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("nMusteriID").ToString
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
    End Function
    Private Sub raporla_tumu(ByVal islem As Integer)
        Dim file As String
        Dim dr As DataRow
        Dim musterino As Int64
        Dim sontahsilattarihi As DateTime
        Dim sontahsilattutari As Decimal
        Dim sonsatistarihi As DateTime
        Dim sonsatistutari As Decimal
        Dim gecikmistaksitsayisi As Int64
        Dim gecikmistaksittutari As Decimal
        Dim toplamkalantaksitsayisi As Int64
        Dim toplamkalantaksittutari As Decimal = 0
        Dim gecikmisodeme As Int64 = 0
        Dim gunundeodeme As Int64 = 0
        Dim erkenodeme As Int64 = 0
        Dim odemesayisi As Int64 = 0
        OpenFileDialog1.Filter = "EtiketDosyaları(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Ekstre"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            For Each dr In DataSet1.Tables(0).Rows
                musterino = dr("nMusteriID")
                gecikmistaksitsayisi = sorgu_sayi(dr("GECIKMISTAKSIT"), 0)
                gecikmistaksittutari = sorgu_sayi(dr("GECIKMISKALAN"), 0)
                sonsatistutari = sorgu_sayi(dr("SONSATISTUTARI"), 0)
                sonsatistarihi = dr("SONSATISTARIHI")
                sontahsilattarihi = dr("SONTAHSILATTARIHI")
                sontahsilattutari = sorgu_sayi(dr("SONTAHSILATTUTARI"), 0)
                toplamkalantaksitsayisi = sorgu_sayi(dr("KALANTAKSITSAYISI"), 0)
                toplamkalantaksittutari = sorgu_sayi(dr("TOPLAMKALAN"), 0)
                Try
                    gecikmisodeme = dr("GECIKMIS")
                    gunundeodeme = dr("GUNUNDE")
                    erkenodeme = dr("ERKEN")
                    odemesayisi = dr("TOPLAM")
                Catch ex As Exception
                    gecikmisodeme = 0
                    gunundeodeme = 0
                    erkenodeme = 0
                    odemesayisi = 0
                End Try
                report_create_stok(file, satir_kontrol, islem, musterino, sontahsilattarihi, sontahsilattutari, sonsatistarihi, sonsatistutari, gecikmistaksitsayisi, gecikmistaksittutari, toplamkalantaksitsayisi, toplamkalantaksittutari, gecikmisodeme, gunundeodeme, erkenodeme, odemesayisi)
            Next
        End If
        dr = Nothing
    End Sub
    Private Sub raporla(ByVal islem As Integer)
        Dim file As String
        Dim dr As DataRow
        Dim musterino As Int64
        Dim sontahsilattarihi As DateTime
        Dim sontahsilattutari As Decimal
        Dim sonsatistarihi As DateTime
        Dim sonsatistutari As Decimal
        Dim gecikmistaksitsayisi As Int64
        Dim gecikmistaksittutari As Decimal
        Dim toplamkalantaksitsayisi As Int64
        Dim toplamkalantaksittutari As Decimal = 0
        Dim gecikmisodeme As Int64 = 0
        Dim gunundeodeme As Int64 = 0
        Dim erkenodeme As Int64 = 0
        Dim odemesayisi As Int64 = 0
        OpenFileDialog1.Filter = "EtiketDosyaları(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Ekstre"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            musterino = dr("nMusteriID")
            gecikmistaksitsayisi = sorgu_sayi(dr("GECIKMISTAKSIT"), 0)
            gecikmistaksittutari = sorgu_sayi(dr("GECIKMISKALAN"), 0)
            sonsatistutari = sorgu_sayi(dr("SONSATISTUTARI"), 0)
            sonsatistarihi = dr("SONSATISTARIHI")
            sontahsilattarihi = dr("SONTAHSILATTARIHI")
            sontahsilattutari = sorgu_sayi(dr("SONTAHSILATTUTARI"), 0)
            toplamkalantaksitsayisi = sorgu_sayi(dr("KALANTAKSITSAYISI"), 0)
            toplamkalantaksittutari = sorgu_sayi(dr("TOPLAMKALAN"), 0)
            Try
                gecikmisodeme = dr("GECIKMIS")
                gunundeodeme = dr("GUNUNDE")
                erkenodeme = dr("ERKEN")
                odemesayisi = dr("TOPLAM")
            Catch ex As Exception
                gecikmisodeme = 0
                gunundeodeme = 0
                erkenodeme = 0
                odemesayisi = 0
            End Try
            report_create_stok(file, satir_kontrol, islem, musterino, sontahsilattarihi, sontahsilattutari, sonsatistarihi, sonsatistutari, gecikmistaksitsayisi, gecikmistaksittutari, toplamkalantaksitsayisi, toplamkalantaksittutari, gecikmisodeme, gunundeodeme, erkenodeme, odemesayisi)
        End If
        dr = Nothing
    End Sub
    Private Sub gonder_mektup()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_cari_mektup
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.txt_musterino.EditValue = dr("nMusteriID")
            frm.txt_musterikodu.EditValue = dr("lKodu")
            frm.txt_musteriadi.EditValue = dr("MUSTERI")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        report_create_cari("..\design\" & frf_islem & ".fr3", 2)
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        report_create_cari("..\design\" & frf_islem & ".fr3", 0)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If XtraMessageBox.Show(Sorgu_sDil("Müşteri Analizi Hesaplamasına Başlamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            taksit_kontrol_satirlar()
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If XtraMessageBox.Show(Sorgu_sDil("Müşteri Analizi Hesaplamasına Başlamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            taksit_kontrol()
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_kaydet()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        ara_kriter(1)
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        ara_kriter(2)
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        ara_kriter(3)
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        ara_kriter(1)
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        ara_kriter(2)
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        ara_kriter(3)
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        ara_kriter(4)
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        ara_kriter(5)
    End Sub
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            raporla(0)
        Catch ex As Exception
            taksit_kontrol_satirlar()
            raporla(0)
        End Try
    End Sub
    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Try
            raporla(2)
        Catch ex As Exception
            taksit_kontrol_satirlar()
            raporla(2)
        End Try
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        gonder_mektup()
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Try
            raporla_tumu(3)
        Catch ex As Exception
            'taksit_kontrol_satirlar()
            'raporla(3)
            XtraMessageBox.Show(Sorgu_sDil("Satır Analiz Hesaplamasında Hata Oluştu, Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        analiz_musteri_karti()
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
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        analiz_musteri_satislar()
    End Sub
End Class
