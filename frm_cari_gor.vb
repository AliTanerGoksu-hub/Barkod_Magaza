Imports Microsoft.Win32
Imports System.Windows.Forms
Imports FastReport
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_cari_gor
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblstokadi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblstokkodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label27 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_sinif1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sinif5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sinif4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sinif3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sinif2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents Label33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPesinat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKasaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsYaziIle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit24 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit25 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl11 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit26 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit27 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit28 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TextEdit29 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colGEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents ds_ekstre As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
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
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents DataColumn87 As System.Data.DataColumn
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeslimatci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIadeAvInf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIslemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokOdeme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_ekstre_tarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_ekstre_tarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_odeme_tarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_odeme_tarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ds_odeme As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents colMusteri_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Fis_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Tarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Tutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdeme_Tarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdeme_Tutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFarkGecikmis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFarkErken As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKacGun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ps1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents kisayol_ekstre As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari_gor))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit24 = New DevExpress.XtraEditors.TextEdit()
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
        Me.TextEdit25 = New DevExpress.XtraEditors.TextEdit()
        Me.Label42 = New DevExpress.XtraEditors.LabelControl()
        Me.Label41 = New DevExpress.XtraEditors.LabelControl()
        Me.lblstokadi = New DevExpress.XtraEditors.LabelControl()
        Me.lblstokkodu = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit4 = New DevExpress.XtraEditors.SpinEdit()
        Me.Label14 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl11 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit28 = New DevExpress.XtraEditors.TextEdit()
        Me.Label46 = New DevExpress.XtraEditors.LabelControl()
        Me.Label47 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.TextEdit29 = New DevExpress.XtraEditors.TextEdit()
        Me.Label48 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit27 = New DevExpress.XtraEditors.TextEdit()
        Me.Label45 = New DevExpress.XtraEditors.LabelControl()
        Me.Label44 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.TextEdit26 = New DevExpress.XtraEditors.TextEdit()
        Me.Label43 = New DevExpress.XtraEditors.LabelControl()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.Label32 = New DevExpress.XtraEditors.LabelControl()
        Me.Label31 = New DevExpress.XtraEditors.LabelControl()
        Me.Label30 = New DevExpress.XtraEditors.LabelControl()
        Me.Label29 = New DevExpress.XtraEditors.LabelControl()
        Me.Label28 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sinif5 = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sinif4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sinif3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sinif2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sinif1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit19 = New DevExpress.XtraEditors.TextEdit()
        Me.Label27 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit18 = New DevExpress.XtraEditors.TextEdit()
        Me.Label26 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit()
        Me.Label25 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit()
        Me.Label24 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit()
        Me.Label23 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit23 = New DevExpress.XtraEditors.TextEdit()
        Me.Label36 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit22 = New DevExpress.XtraEditors.TextEdit()
        Me.Label35 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit21 = New DevExpress.XtraEditors.TextEdit()
        Me.Label34 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit20 = New DevExpress.XtraEditors.TextEdit()
        Me.Label33 = New DevExpress.XtraEditors.LabelControl()
        Me.Label22 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit()
        Me.Label21 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.Label19 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.Label18 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New DevExpress.XtraEditors.LabelControl()
        Me.Label16 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPesinat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYaziIle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.ds_odeme = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn89 = New System.Data.DataColumn()
        Me.DataColumn90 = New System.Data.DataColumn()
        Me.DataColumn91 = New System.Data.DataColumn()
        Me.DataColumn92 = New System.Data.DataColumn()
        Me.DataColumn93 = New System.Data.DataColumn()
        Me.DataColumn94 = New System.Data.DataColumn()
        Me.DataColumn95 = New System.Data.DataColumn()
        Me.DataColumn96 = New System.Data.DataColumn()
        Me.DataColumn97 = New System.Data.DataColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMusteri_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Fis_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Tarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Tutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdeme_Tarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdeme_Tutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFarkGecikmis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFarkErken = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKacGun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Label37 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label38 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_odeme_tarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_odeme_tarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_ekstre = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.ds_ekstre = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.DataColumn79 = New System.Data.DataColumn()
        Me.DataColumn80 = New System.Data.DataColumn()
        Me.DataColumn81 = New System.Data.DataColumn()
        Me.DataColumn82 = New System.Data.DataColumn()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.DataColumn85 = New System.Data.DataColumn()
        Me.DataColumn86 = New System.Data.DataColumn()
        Me.DataColumn87 = New System.Data.DataColumn()
        Me.DataColumn88 = New System.Data.DataColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeslimatci = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIadeAvInf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIslemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokOdeme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.Label39 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label40 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_ekstre_tarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_ekstre_tarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DateEdit5 = New DevExpress.XtraEditors.DateEdit()
        Me.ps1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl10.SuspendLayout()
        CType(Me.TextEdit24.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit25.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl11.SuspendLayout()
        CType(Me.TextEdit28.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit29.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit27.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit26.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.sec_sinif5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_odeme_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_odeme_tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_odeme_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_odeme_tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_ekstre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl10)
        Me.PanelControl1.Controls.Add(Me.lblstokadi)
        Me.PanelControl1.Controls.Add(Me.lblstokkodu)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.GroupControl5)
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.lbl_ara)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1002, 144)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl10
        '
        Me.GroupControl10.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl10.AppearanceCaption.Options.UseFont = True
        Me.GroupControl10.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl10.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl10.Controls.Add(Me.TextEdit24)
        Me.GroupControl10.Controls.Add(Me.TextEdit25)
        Me.GroupControl10.Controls.Add(Me.Label42)
        Me.GroupControl10.Controls.Add(Me.Label41)
        Me.GroupControl10.Location = New System.Drawing.Point(619, 67)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(157, 63)
        Me.GroupControl10.TabIndex = 15
        Me.GroupControl10.Text = "NetSatýþAnalizi"
        '
        'TextEdit24
        '
        Me.TextEdit24.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TOPLAMSATISTUTARI", True))
        Me.TextEdit24.Location = New System.Drawing.Point(96, 40)
        Me.TextEdit24.Name = "TextEdit24"
        Me.TextEdit24.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit24.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit24.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.TextEdit24.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit24.Properties.NullText = "0"
        Me.TextEdit24.Properties.ReadOnly = True
        Me.TextEdit24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit24.Size = New System.Drawing.Size(56, 20)
        Me.TextEdit24.TabIndex = 9
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61})
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
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "Column1"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "sIsAdresi1"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "sIsAdresi2"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "sIsYeriAdi"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "sIsTelefonu"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "MUSTERI"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "sIsSemt"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "KEFILAD1"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "KEFILADRES1"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "KEFILTELEFON1"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "KEFILAD2"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "KEFILADRES2"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "KEFILTELEFON2"
        '
        'TextEdit25
        '
        Me.TextEdit25.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TOPLAMSATISMIKTARI", True))
        Me.TextEdit25.Location = New System.Drawing.Point(96, 23)
        Me.TextEdit25.Name = "TextEdit25"
        Me.TextEdit25.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit25.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit25.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.TextEdit25.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit25.Properties.NullText = "0"
        Me.TextEdit25.Properties.ReadOnly = True
        Me.TextEdit25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit25.Size = New System.Drawing.Size(56, 20)
        Me.TextEdit25.TabIndex = 8
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(5, 40)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(55, 13)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "SatýþTutarý:"
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(5, 24)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(58, 13)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "SatýþMiktarý:"
        '
        'lblstokadi
        '
        Me.lblstokadi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblstokadi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblstokadi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "Table1.MUSTERI", True))
        Me.lblstokadi.Location = New System.Drawing.Point(80, 35)
        Me.lblstokadi.Name = "lblstokadi"
        Me.lblstokadi.Size = New System.Drawing.Size(7, 13)
        Me.lblstokadi.TabIndex = 14
        Me.lblstokadi.Text = "*"
        '
        'lblstokkodu
        '
        Me.lblstokkodu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblstokkodu.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblstokkodu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "Table1.lKodu", True))
        Me.lblstokkodu.Location = New System.Drawing.Point(80, 19)
        Me.lblstokkodu.Name = "lblstokkodu"
        Me.lblstokkodu.Size = New System.Drawing.Size(7, 13)
        Me.lblstokkodu.TabIndex = 13
        Me.lblstokkodu.Text = "*"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "MüþteriAdý:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "MüþteriKodu:"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl5.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl5.Controls.Add(Me.SpinEdit3)
        Me.GroupControl5.Controls.Add(Me.Label13)
        Me.GroupControl5.Controls.Add(Me.SpinEdit4)
        Me.GroupControl5.Controls.Add(Me.Label14)
        Me.GroupControl5.Controls.Add(Me.SpinEdit2)
        Me.GroupControl5.Controls.Add(Me.Label12)
        Me.GroupControl5.Controls.Add(Me.SpinEdit1)
        Me.GroupControl5.Controls.Add(Me.Label11)
        Me.GroupControl5.Location = New System.Drawing.Point(780, 67)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(218, 64)
        Me.GroupControl5.TabIndex = 7
        Me.GroupControl5.Text = "ÖdemeAnalizi"
        '
        'SpinEdit3
        '
        Me.SpinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TOPLAM", True))
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit3.Location = New System.Drawing.Point(169, 42)
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpinEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit3.Properties.ReadOnly = True
        Me.SpinEdit3.Size = New System.Drawing.Size(48, 20)
        Me.SpinEdit3.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(112, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Toplam:"
        '
        'SpinEdit4
        '
        Me.SpinEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.GUNUNDE", True))
        Me.SpinEdit4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit4.Location = New System.Drawing.Point(169, 23)
        Me.SpinEdit4.Name = "SpinEdit4"
        Me.SpinEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpinEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.SpinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit4.Properties.ReadOnly = True
        Me.SpinEdit4.Size = New System.Drawing.Size(48, 20)
        Me.SpinEdit4.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(112, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Gününde:"
        '
        'SpinEdit2
        '
        Me.SpinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.GECIKMIS", True))
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(63, 42)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpinEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit2.Properties.ReadOnly = True
        Me.SpinEdit2.Size = New System.Drawing.Size(48, 20)
        Me.SpinEdit2.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Gecikmiþ:"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ERKEN", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(63, 23)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpinEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.ReadOnly = True
        Me.SpinEdit1.Size = New System.Drawing.Size(48, 20)
        Me.SpinEdit1.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Erken:"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl4.Controls.Add(Me.Label10)
        Me.GroupControl4.Controls.Add(Me.Label9)
        Me.GroupControl4.Controls.Add(Me.DateEdit2)
        Me.GroupControl4.Controls.Add(Me.DateEdit1)
        Me.GroupControl4.Controls.Add(Me.TextEdit5)
        Me.GroupControl4.Controls.Add(Me.TextEdit6)
        Me.GroupControl4.Controls.Add(Me.Label7)
        Me.GroupControl4.Controls.Add(Me.Label8)
        Me.GroupControl4.Location = New System.Drawing.Point(303, 67)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(311, 64)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Son AlýþVeriþ Bilgileri"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(218, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Tutar:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(218, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Tutar:"
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.SONTAHSILATTARIHI", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(66, 41)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(152, 20)
        Me.DateEdit2.TabIndex = 9
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.SONSATISTARIHI", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(66, 22)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.ReadOnly = True
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(152, 20)
        Me.DateEdit1.TabIndex = 8
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.SONTAHSILATTUTARI", True))
        Me.TextEdit5.Location = New System.Drawing.Point(254, 41)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.NullText = "0"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit5.Size = New System.Drawing.Size(56, 20)
        Me.TextEdit5.TabIndex = 7
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.SONSATISTUTARI", True))
        Me.TextEdit6.Location = New System.Drawing.Point(254, 23)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.NullText = "0"
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit6.Size = New System.Drawing.Size(56, 20)
        Me.TextEdit6.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Tah.Tarihi:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "SatýþTarihi:"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.Controls.Add(Me.TextEdit3)
        Me.GroupControl3.Controls.Add(Me.TextEdit4)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.Label6)
        Me.GroupControl3.Location = New System.Drawing.Point(153, 67)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(146, 63)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "GecikmiþBilgisi"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.GECIKMISKALAN", True))
        Me.TextEdit3.Location = New System.Drawing.Point(80, 40)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.NullText = "0"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit3.Size = New System.Drawing.Size(64, 20)
        Me.TextEdit3.TabIndex = 7
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.GECIKMISTAKSIT", True))
        Me.TextEdit4.Location = New System.Drawing.Point(80, 21)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit4.Properties.NullText = "0"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit4.Size = New System.Drawing.Size(64, 20)
        Me.TextEdit4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TaksitTutarý:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TaksitSayýsý :"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl2.Controls.Add(Me.TextEdit2)
        Me.GroupControl2.Controls.Add(Me.TextEdit1)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 67)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(142, 63)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "KalanÖdemeBilgisi"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TOPLAMKALAN", True))
        Me.TextEdit2.Location = New System.Drawing.Point(80, 40)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.NullText = "0"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit2.Size = New System.Drawing.Size(61, 20)
        Me.TextEdit2.TabIndex = 3
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KALANTAKSITSAYISI", True))
        Me.TextEdit1.Location = New System.Drawing.Point(80, 21)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.NullText = "0"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit1.Size = New System.Drawing.Size(61, 20)
        Me.TextEdit1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TaksitTutarý:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TaksitSayýsý :"
        '
        'lbl_ara
        '
        Me.lbl_ara.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ara.Location = New System.Drawing.Point(594, 31)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(6, 13)
        Me.lbl_ara.TabIndex = 3
        Me.lbl_ara.Text = "*"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Location = New System.Drawing.Point(626, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(368, 48)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Ara"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(275, 22)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Eþittir"
        Me.sec_kriter.Location = New System.Drawing.Point(200, 22)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 1
        '
        'txt_ara
        '
        Me.txt_ara.Location = New System.Drawing.Point(2, 22)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(198, 20)
        Me.txt_ara.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 576)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1002, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(16, 16)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "Yazdýr"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(917, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(842, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 144)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1002, 432)
        Me.PanelControl3.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage6
        Me.XtraTabControl1.Size = New System.Drawing.Size(998, 428)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage6, Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.GroupControl11)
        Me.XtraTabPage6.Controls.Add(Me.Panelstatus)
        Me.XtraTabPage6.Controls.Add(Me.GroupControl9)
        Me.XtraTabPage6.Controls.Add(Me.GroupControl8)
        Me.XtraTabPage6.Controls.Add(Me.GroupControl7)
        Me.XtraTabPage6.Controls.Add(Me.GroupControl6)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage6.Text = "MüþteriBilgileri"
        '
        'GroupControl11
        '
        Me.GroupControl11.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl11.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl11.AppearanceCaption.Options.UseFont = True
        Me.GroupControl11.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl11.Controls.Add(Me.TextEdit28)
        Me.GroupControl11.Controls.Add(Me.Label46)
        Me.GroupControl11.Controls.Add(Me.Label47)
        Me.GroupControl11.Controls.Add(Me.MemoEdit2)
        Me.GroupControl11.Controls.Add(Me.TextEdit29)
        Me.GroupControl11.Controls.Add(Me.Label48)
        Me.GroupControl11.Controls.Add(Me.TextEdit27)
        Me.GroupControl11.Controls.Add(Me.Label45)
        Me.GroupControl11.Controls.Add(Me.Label44)
        Me.GroupControl11.Controls.Add(Me.MemoEdit1)
        Me.GroupControl11.Controls.Add(Me.TextEdit26)
        Me.GroupControl11.Controls.Add(Me.Label43)
        Me.GroupControl11.Location = New System.Drawing.Point(8, 250)
        Me.GroupControl11.Name = "GroupControl11"
        Me.GroupControl11.Size = New System.Drawing.Size(682, 108)
        Me.GroupControl11.TabIndex = 10
        Me.GroupControl11.Text = "Kefil Bilgileri"
        '
        'TextEdit28
        '
        Me.TextEdit28.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KEFILTELEFON2", True))
        Me.TextEdit28.Location = New System.Drawing.Point(443, 85)
        Me.TextEdit28.Name = "TextEdit28"
        Me.TextEdit28.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit28.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit28.Properties.ReadOnly = True
        Me.TextEdit28.Size = New System.Drawing.Size(239, 20)
        Me.TextEdit28.TabIndex = 31
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(368, 85)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(40, 13)
        Me.Label46.TabIndex = 30
        Me.Label46.Text = "Telefon:"
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(368, 48)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(32, 13)
        Me.Label47.TabIndex = 29
        Me.Label47.Text = "Adres:"
        '
        'MemoEdit2
        '
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KEFILADRES2", True))
        Me.MemoEdit2.Location = New System.Drawing.Point(443, 38)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MemoEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.MemoEdit2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MemoEdit2.Size = New System.Drawing.Size(239, 48)
        Me.MemoEdit2.TabIndex = 28
        '
        'TextEdit29
        '
        Me.TextEdit29.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KEFILAD2", True))
        Me.TextEdit29.Location = New System.Drawing.Point(443, 19)
        Me.TextEdit29.Name = "TextEdit29"
        Me.TextEdit29.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit29.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit29.Properties.ReadOnly = True
        Me.TextEdit29.Size = New System.Drawing.Size(239, 20)
        Me.TextEdit29.TabIndex = 27
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(368, 24)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(49, 13)
        Me.Label48.TabIndex = 26
        Me.Label48.Text = "2.KefilAdý:"
        '
        'TextEdit27
        '
        Me.TextEdit27.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KEFILTELEFON1", True))
        Me.TextEdit27.Location = New System.Drawing.Point(80, 85)
        Me.TextEdit27.Name = "TextEdit27"
        Me.TextEdit27.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit27.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit27.Properties.ReadOnly = True
        Me.TextEdit27.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit27.TabIndex = 25
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(8, 84)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(40, 13)
        Me.Label45.TabIndex = 24
        Me.Label45.Text = "Telefon:"
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 48)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 13)
        Me.Label44.TabIndex = 7
        Me.Label44.Text = "Adres:"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KEFILADRES1", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(80, 38)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MemoEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.MemoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MemoEdit1.Size = New System.Drawing.Size(285, 48)
        Me.MemoEdit1.TabIndex = 6
        '
        'TextEdit26
        '
        Me.TextEdit26.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KEFILAD1", True))
        Me.TextEdit26.Location = New System.Drawing.Point(80, 19)
        Me.TextEdit26.Name = "TextEdit26"
        Me.TextEdit26.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit26.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit26.Properties.ReadOnly = True
        Me.TextEdit26.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit26.TabIndex = 5
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 24)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(49, 13)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "1.KefilAdý:"
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
        Me.Panelstatus.Location = New System.Drawing.Point(311, 131)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(372, 106)
        Me.Panelstatus.TabIndex = 9
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(10, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(348, 18)
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
        Me.bar.Size = New System.Drawing.Size(348, 18)
        Me.bar.TabIndex = 0
        '
        'GroupControl9
        '
        Me.GroupControl9.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl9.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl9.AppearanceCaption.Options.UseFont = True
        Me.GroupControl9.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl9.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl9.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl9.Controls.Add(Me.GridControl2)
        Me.GroupControl9.Location = New System.Drawing.Point(701, 10)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(282, 348)
        Me.GroupControl9.TabIndex = 8
        Me.GroupControl9.Text = "KalanÖdemeler"
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 15)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(278, 331)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteTarihi, Me.colKALAN, Me.colGEC})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'coldteTarihi
        '
        Me.coldteTarihi.Caption = "Vade"
        Me.coldteTarihi.DisplayFormat.FormatString = "D"
        Me.coldteTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", "{0} Taksit")})
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 0
        Me.coldteTarihi.Width = 133
        '
        'colKALAN
        '
        Me.colKALAN.Caption = "Tutar"
        Me.colKALAN.DisplayFormat.FormatString = "#,0.00"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.00}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 1
        Me.colKALAN.Width = 74
        '
        'colGEC
        '
        Me.colGEC.Caption = "Gün"
        Me.colGEC.DisplayFormat.FormatString = "#,0.##"
        Me.colGEC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGEC.FieldName = "GECIKME"
        Me.colGEC.Name = "colGEC"
        Me.colGEC.Visible = True
        Me.colGEC.VisibleIndex = 2
        Me.colGEC.Width = 67
        '
        'GroupControl8
        '
        Me.GroupControl8.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl8.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl8.Controls.Add(Me.Label32)
        Me.GroupControl8.Controls.Add(Me.Label31)
        Me.GroupControl8.Controls.Add(Me.Label30)
        Me.GroupControl8.Controls.Add(Me.Label29)
        Me.GroupControl8.Controls.Add(Me.Label28)
        Me.GroupControl8.Controls.Add(Me.sec_sinif5)
        Me.GroupControl8.Controls.Add(Me.sec_sinif4)
        Me.GroupControl8.Controls.Add(Me.sec_sinif3)
        Me.GroupControl8.Controls.Add(Me.sec_sinif2)
        Me.GroupControl8.Controls.Add(Me.sec_sinif1)
        Me.GroupControl8.Location = New System.Drawing.Point(377, 129)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(312, 119)
        Me.GroupControl8.TabIndex = 7
        Me.GroupControl8.Text = "Sýnýflandýrma"
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(1, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 13)
        Me.Label32.TabIndex = 21
        Me.Label32.Text = "Sýnýf5:"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(1, 78)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 13)
        Me.Label31.TabIndex = 20
        Me.Label31.Text = "Sýnýf4:"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(1, 60)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 13)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "Sýnýf3:"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(1, 39)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 13)
        Me.Label29.TabIndex = 18
        Me.Label29.Text = "Sýnýf2:"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(1, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 13)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Sýnýf1:"
        '
        'sec_sinif5
        '
        Me.sec_sinif5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD5", True))
        Me.sec_sinif5.Location = New System.Drawing.Point(74, 96)
        Me.sec_sinif5.Name = "sec_sinif5"
        Me.sec_sinif5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif5.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_sinif5.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_sinif5.Properties.NullText = ""
        Me.sec_sinif5.Properties.ValueMember = "IND"
        Me.sec_sinif5.Size = New System.Drawing.Size(238, 20)
        Me.sec_sinif5.TabIndex = 16
        '
        'sec_sinif4
        '
        Me.sec_sinif4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD4", True))
        Me.sec_sinif4.Location = New System.Drawing.Point(74, 77)
        Me.sec_sinif4.Name = "sec_sinif4"
        Me.sec_sinif4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_sinif4.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_sinif4.Properties.NullText = ""
        Me.sec_sinif4.Properties.ValueMember = "IND"
        Me.sec_sinif4.Size = New System.Drawing.Size(238, 20)
        Me.sec_sinif4.TabIndex = 15
        '
        'sec_sinif3
        '
        Me.sec_sinif3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD3", True))
        Me.sec_sinif3.Location = New System.Drawing.Point(74, 58)
        Me.sec_sinif3.Name = "sec_sinif3"
        Me.sec_sinif3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_sinif3.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_sinif3.Properties.NullText = ""
        Me.sec_sinif3.Properties.ValueMember = "IND"
        Me.sec_sinif3.Size = New System.Drawing.Size(238, 20)
        Me.sec_sinif3.TabIndex = 14
        '
        'sec_sinif2
        '
        Me.sec_sinif2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD2", True))
        Me.sec_sinif2.Location = New System.Drawing.Point(74, 39)
        Me.sec_sinif2.Name = "sec_sinif2"
        Me.sec_sinif2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_sinif2.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_sinif2.Properties.NullText = ""
        Me.sec_sinif2.Properties.ValueMember = "IND"
        Me.sec_sinif2.Size = New System.Drawing.Size(238, 20)
        Me.sec_sinif2.TabIndex = 13
        '
        'sec_sinif1
        '
        Me.sec_sinif1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD1", True))
        Me.sec_sinif1.Location = New System.Drawing.Point(74, 20)
        Me.sec_sinif1.Name = "sec_sinif1"
        Me.sec_sinif1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_sinif1.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_sinif1.Properties.NullText = ""
        Me.sec_sinif1.Properties.ValueMember = "IND"
        Me.sec_sinif1.Size = New System.Drawing.Size(238, 20)
        Me.sec_sinif1.TabIndex = 12
        '
        'GroupControl7
        '
        Me.GroupControl7.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl7.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl7.Controls.Add(Me.TextEdit19)
        Me.GroupControl7.Controls.Add(Me.Label27)
        Me.GroupControl7.Controls.Add(Me.TextEdit18)
        Me.GroupControl7.Controls.Add(Me.Label26)
        Me.GroupControl7.Controls.Add(Me.TextEdit17)
        Me.GroupControl7.Controls.Add(Me.Label25)
        Me.GroupControl7.Controls.Add(Me.TextEdit16)
        Me.GroupControl7.Controls.Add(Me.Label24)
        Me.GroupControl7.Controls.Add(Me.TextEdit15)
        Me.GroupControl7.Controls.Add(Me.Label23)
        Me.GroupControl7.Location = New System.Drawing.Point(377, 10)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(312, 116)
        Me.GroupControl7.TabIndex = 6
        Me.GroupControl7.Text = "Açýklamalar"
        '
        'TextEdit19
        '
        Me.TextEdit19.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama5", True))
        Me.TextEdit19.Location = New System.Drawing.Point(75, 94)
        Me.TextEdit19.Name = "TextEdit19"
        Me.TextEdit19.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit19.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit19.Properties.ReadOnly = True
        Me.TextEdit19.Size = New System.Drawing.Size(237, 20)
        Me.TextEdit19.TabIndex = 12
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(3, 94)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 13)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Açýklama5:"
        '
        'TextEdit18
        '
        Me.TextEdit18.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama4", True))
        Me.TextEdit18.Location = New System.Drawing.Point(75, 75)
        Me.TextEdit18.Name = "TextEdit18"
        Me.TextEdit18.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit18.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit18.Properties.ReadOnly = True
        Me.TextEdit18.Size = New System.Drawing.Size(237, 20)
        Me.TextEdit18.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(3, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Açýklama4:"
        '
        'TextEdit17
        '
        Me.TextEdit17.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama3", True))
        Me.TextEdit17.Location = New System.Drawing.Point(75, 57)
        Me.TextEdit17.Name = "TextEdit17"
        Me.TextEdit17.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit17.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit17.Properties.ReadOnly = True
        Me.TextEdit17.Size = New System.Drawing.Size(237, 20)
        Me.TextEdit17.TabIndex = 8
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(3, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Açýklama3:"
        '
        'TextEdit16
        '
        Me.TextEdit16.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama2", True))
        Me.TextEdit16.Location = New System.Drawing.Point(75, 38)
        Me.TextEdit16.Name = "TextEdit16"
        Me.TextEdit16.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit16.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit16.Properties.ReadOnly = True
        Me.TextEdit16.Size = New System.Drawing.Size(237, 20)
        Me.TextEdit16.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(2, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Açýklama2:"
        '
        'TextEdit15
        '
        Me.TextEdit15.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama1", True))
        Me.TextEdit15.Location = New System.Drawing.Point(75, 19)
        Me.TextEdit15.Name = "TextEdit15"
        Me.TextEdit15.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit15.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit15.Properties.ReadOnly = True
        Me.TextEdit15.Size = New System.Drawing.Size(237, 20)
        Me.TextEdit15.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(2, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Açýklama1:"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GroupControl6.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl6.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl6.Controls.Add(Me.TextEdit23)
        Me.GroupControl6.Controls.Add(Me.Label36)
        Me.GroupControl6.Controls.Add(Me.TextEdit22)
        Me.GroupControl6.Controls.Add(Me.Label35)
        Me.GroupControl6.Controls.Add(Me.TextEdit21)
        Me.GroupControl6.Controls.Add(Me.Label34)
        Me.GroupControl6.Controls.Add(Me.TextEdit20)
        Me.GroupControl6.Controls.Add(Me.Label33)
        Me.GroupControl6.Controls.Add(Me.Label22)
        Me.GroupControl6.Controls.Add(Me.TextEdit14)
        Me.GroupControl6.Controls.Add(Me.TextEdit13)
        Me.GroupControl6.Controls.Add(Me.Label21)
        Me.GroupControl6.Controls.Add(Me.TextEdit12)
        Me.GroupControl6.Controls.Add(Me.Label20)
        Me.GroupControl6.Controls.Add(Me.TextEdit11)
        Me.GroupControl6.Controls.Add(Me.Label19)
        Me.GroupControl6.Controls.Add(Me.TextEdit10)
        Me.GroupControl6.Controls.Add(Me.Label18)
        Me.GroupControl6.Controls.Add(Me.TextEdit9)
        Me.GroupControl6.Controls.Add(Me.Label17)
        Me.GroupControl6.Controls.Add(Me.TextEdit7)
        Me.GroupControl6.Controls.Add(Me.TextEdit8)
        Me.GroupControl6.Controls.Add(Me.Label15)
        Me.GroupControl6.Controls.Add(Me.Label16)
        Me.GroupControl6.Location = New System.Drawing.Point(7, 10)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(368, 237)
        Me.GroupControl6.TabIndex = 5
        Me.GroupControl6.Text = "Tanýmlar"
        '
        'TextEdit23
        '
        Me.TextEdit23.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sIsTelefonu", True))
        Me.TextEdit23.Location = New System.Drawing.Point(80, 209)
        Me.TextEdit23.Name = "TextEdit23"
        Me.TextEdit23.Properties.ReadOnly = True
        Me.TextEdit23.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit23.TabIndex = 23
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(8, 209)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(55, 13)
        Me.Label36.TabIndex = 22
        Me.Label36.Text = "ÝþTelefonu:"
        '
        'TextEdit22
        '
        Me.TextEdit22.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sIsAdresi2", True))
        Me.TextEdit22.Location = New System.Drawing.Point(80, 190)
        Me.TextEdit22.Name = "TextEdit22"
        Me.TextEdit22.Properties.ReadOnly = True
        Me.TextEdit22.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit22.TabIndex = 21
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 190)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 13)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "ÝþAdresi2:"
        '
        'TextEdit21
        '
        Me.TextEdit21.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sIsAdresi1", True))
        Me.TextEdit21.Location = New System.Drawing.Point(80, 171)
        Me.TextEdit21.Name = "TextEdit21"
        Me.TextEdit21.Properties.ReadOnly = True
        Me.TextEdit21.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit21.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 171)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(49, 13)
        Me.Label34.TabIndex = 18
        Me.Label34.Text = "ÝþAdresi1:"
        '
        'TextEdit20
        '
        Me.TextEdit20.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sIsYeriAdi", True))
        Me.TextEdit20.Location = New System.Drawing.Point(80, 152)
        Me.TextEdit20.Name = "TextEdit20"
        Me.TextEdit20.Properties.ReadOnly = True
        Me.TextEdit20.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit20.TabIndex = 17
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(8, 152)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 13)
        Me.Label33.TabIndex = 16
        Me.Label33.Text = "ÝþYeri:"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(200, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Gsm :"
        '
        'TextEdit14
        '
        Me.TextEdit14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sGSM", True))
        Me.TextEdit14.Location = New System.Drawing.Point(254, 134)
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Properties.ReadOnly = True
        Me.TextEdit14.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit14.TabIndex = 14
        '
        'TextEdit13
        '
        Me.TextEdit13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sEvTelefonu", True))
        Me.TextEdit13.Location = New System.Drawing.Point(80, 134)
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Properties.ReadOnly = True
        Me.TextEdit13.Size = New System.Drawing.Size(120, 20)
        Me.TextEdit13.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 134)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "EvTelefonu:"
        '
        'TextEdit12
        '
        Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sEvSemt", True))
        Me.TextEdit12.Location = New System.Drawing.Point(80, 115)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.ReadOnly = True
        Me.TextEdit12.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit12.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 115)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Semt :"
        '
        'TextEdit11
        '
        Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sEvAdresi2", True))
        Me.TextEdit11.Location = New System.Drawing.Point(80, 96)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.ReadOnly = True
        Me.TextEdit11.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit11.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "EvAdresi2:"
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sEvAdresi1", True))
        Me.TextEdit10.Location = New System.Drawing.Point(80, 77)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit10.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "EvAdresi1:"
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sSoyadi", True))
        Me.TextEdit9.Location = New System.Drawing.Point(80, 59)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit9.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(7, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Soyadý:"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAdi", True))
        Me.TextEdit7.Location = New System.Drawing.Point(80, 40)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit7.TabIndex = 3
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.lKodu", True))
        Me.TextEdit8.Location = New System.Drawing.Point(80, 21)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Size = New System.Drawing.Size(285, 20)
        Me.TextEdit8.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Adý:"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "MüþteriKodu:"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage1.Text = "Satýþ/Sipariþler"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(996, 395)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFisTipi, Me.coldteFaturaTarihi, Me.colnGirisCikis, Me.collToplamMiktar, Me.collPesinat, Me.collNetTutar, Me.collFaturaNo, Me.colsMagaza, Me.colsKasiyerRumuzu, Me.colnKasaNo, Me.coldteKayitTarihi, Me.colsYaziIle, Me.colnAlisverisID})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 421, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "Ýzahat"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFisTipi", "{0} Kayýt")})
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 0
        Me.colsFisTipi.Width = 50
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.DisplayFormat.FormatString = "D"
        Me.coldteFaturaTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 134
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Belge Tipi"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Visible = True
        Me.colnGirisCikis.VisibleIndex = 3
        Me.colnGirisCikis.Width = 58
        '
        'collToplamMiktar
        '
        Me.collToplamMiktar.Caption = "Miktar"
        Me.collToplamMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collToplamMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamMiktar.FieldName = "lToplamMiktar"
        Me.collToplamMiktar.Name = "collToplamMiktar"
        Me.collToplamMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamMiktar", "{0:#,0.00}")})
        Me.collToplamMiktar.Visible = True
        Me.collToplamMiktar.VisibleIndex = 4
        Me.collToplamMiktar.Width = 70
        '
        'collPesinat
        '
        Me.collPesinat.Caption = "Peþinat"
        Me.collPesinat.DisplayFormat.FormatString = "#,0.00"
        Me.collPesinat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPesinat.FieldName = "lPesinat"
        Me.collPesinat.Name = "collPesinat"
        Me.collPesinat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPesinat", "{0:#,0.00}")})
        Me.collPesinat.Visible = True
        Me.collPesinat.VisibleIndex = 5
        Me.collPesinat.Width = 70
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
        Me.collNetTutar.VisibleIndex = 6
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "Fiþ No"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 2
        Me.collFaturaNo.Width = 54
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "MaðazaKodu"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.Visible = True
        Me.colsMagaza.VisibleIndex = 7
        Me.colsMagaza.Width = 72
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Visible = True
        Me.colsKasiyerRumuzu.VisibleIndex = 8
        Me.colsKasiyerRumuzu.Width = 43
        '
        'colnKasaNo
        '
        Me.colnKasaNo.Caption = "KasaNo"
        Me.colnKasaNo.FieldName = "nKasaNo"
        Me.colnKasaNo.Name = "colnKasaNo"
        Me.colnKasaNo.Visible = True
        Me.colnKasaNo.VisibleIndex = 9
        Me.colnKasaNo.Width = 48
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Saat"
        Me.coldteKayitTarihi.DisplayFormat.FormatString = "hh:mm"
        Me.coldteKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.Visible = True
        Me.coldteKayitTarihi.VisibleIndex = 10
        Me.coldteKayitTarihi.Width = 38
        '
        'colsYaziIle
        '
        Me.colsYaziIle.Caption = "YazýÝle"
        Me.colsYaziIle.FieldName = "sYaziIle"
        Me.colsYaziIle.Name = "colsYaziIle"
        Me.colsYaziIle.Visible = True
        Me.colsYaziIle.VisibleIndex = 11
        Me.colsYaziIle.Width = 199
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "Kayýt No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl3)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage2.Text = "Ödemeler"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = Nothing
        Me.GridControl3.DataSource = Me.ds_odeme
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 40)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(996, 355)
        Me.GridControl3.TabIndex = 1
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ds_odeme
        '
        Me.ds_odeme.DataSetName = "NewDataSet"
        Me.ds_odeme.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_odeme.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn96, Me.DataColumn97})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "Musteri_TanimlamaNo"
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "Taksit_Fis_TanimlamaNo"
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "Taksit_Tarihi"
        Me.DataColumn91.DataType = GetType(Date)
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "Taksit_Tutari"
        Me.DataColumn92.DataType = GetType(Decimal)
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "Odeme_Tarihi"
        Me.DataColumn93.DataType = GetType(Date)
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "Odeme_Tutar"
        Me.DataColumn94.DataType = GetType(Decimal)
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "nFarkGecikmis"
        Me.DataColumn95.DataType = GetType(Long)
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "nFarkErken"
        Me.DataColumn96.DataType = GetType(Long)
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "nKacGun"
        Me.DataColumn97.DataType = GetType(Long)
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMusteri_TanimlamaNo, Me.colTaksit_Fis_TanimlamaNo, Me.colTaksit_Tarihi, Me.colTaksit_Tutari, Me.colOdeme_Tarihi, Me.colOdeme_Tutar, Me.colnFarkGecikmis, Me.colnFarkErken, Me.colnKacGun})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(806, 484, 208, 170)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colMusteri_TanimlamaNo
        '
        Me.colMusteri_TanimlamaNo.Caption = "MüþteriKayýtNo"
        Me.colMusteri_TanimlamaNo.FieldName = "Musteri_TanimlamaNo"
        Me.colMusteri_TanimlamaNo.Name = "colMusteri_TanimlamaNo"
        '
        'colTaksit_Fis_TanimlamaNo
        '
        Me.colTaksit_Fis_TanimlamaNo.Caption = "FiþKayýtNo"
        Me.colTaksit_Fis_TanimlamaNo.FieldName = "Taksit_Fis_TanimlamaNo"
        Me.colTaksit_Fis_TanimlamaNo.Name = "colTaksit_Fis_TanimlamaNo"
        '
        'colTaksit_Tarihi
        '
        Me.colTaksit_Tarihi.Caption = "Taksit Tarihi"
        Me.colTaksit_Tarihi.DisplayFormat.FormatString = "D"
        Me.colTaksit_Tarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTaksit_Tarihi.FieldName = "Taksit_Tarihi"
        Me.colTaksit_Tarihi.Name = "colTaksit_Tarihi"
        Me.colTaksit_Tarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", "{0} Kayýt")})
        Me.colTaksit_Tarihi.Visible = True
        Me.colTaksit_Tarihi.VisibleIndex = 0
        '
        'colTaksit_Tutari
        '
        Me.colTaksit_Tutari.Caption = "Taksit Tutarý"
        Me.colTaksit_Tutari.DisplayFormat.FormatString = "#,0.00"
        Me.colTaksit_Tutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTaksit_Tutari.FieldName = "Taksit_Tutari"
        Me.colTaksit_Tutari.Name = "colTaksit_Tutari"
        Me.colTaksit_Tutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Taksit_Tutari", "{0:#,0.00}")})
        Me.colTaksit_Tutari.Visible = True
        Me.colTaksit_Tutari.VisibleIndex = 1
        '
        'colOdeme_Tarihi
        '
        Me.colOdeme_Tarihi.Caption = "ÖdemeTarihi"
        Me.colOdeme_Tarihi.DisplayFormat.FormatString = "D"
        Me.colOdeme_Tarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOdeme_Tarihi.FieldName = "Odeme_Tarihi"
        Me.colOdeme_Tarihi.Name = "colOdeme_Tarihi"
        Me.colOdeme_Tarihi.Visible = True
        Me.colOdeme_Tarihi.VisibleIndex = 2
        '
        'colOdeme_Tutar
        '
        Me.colOdeme_Tutar.Caption = "ÖdemeTutarý"
        Me.colOdeme_Tutar.DisplayFormat.FormatString = "#,0.00"
        Me.colOdeme_Tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOdeme_Tutar.FieldName = "Odeme_tutar"
        Me.colOdeme_Tutar.Name = "colOdeme_Tutar"
        Me.colOdeme_Tutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odeme_tutar", "{0:#,0.00}")})
        Me.colOdeme_Tutar.Visible = True
        Me.colOdeme_Tutar.VisibleIndex = 3
        '
        'colnFarkGecikmis
        '
        Me.colnFarkGecikmis.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colnFarkGecikmis.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.colnFarkGecikmis.AppearanceCell.Options.UseFont = True
        Me.colnFarkGecikmis.AppearanceCell.Options.UseForeColor = True
        Me.colnFarkGecikmis.Caption = "GecikenGün"
        Me.colnFarkGecikmis.DisplayFormat.FormatString = "#,#.##"
        Me.colnFarkGecikmis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnFarkGecikmis.FieldName = "nFarkGecikmis"
        Me.colnFarkGecikmis.Name = "colnFarkGecikmis"
        Me.colnFarkGecikmis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nFarkGecikmis", "Toplam {0:#,0.##} Gün")})
        Me.colnFarkGecikmis.Visible = True
        Me.colnFarkGecikmis.VisibleIndex = 4
        '
        'colnFarkErken
        '
        Me.colnFarkErken.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colnFarkErken.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colnFarkErken.AppearanceCell.Options.UseFont = True
        Me.colnFarkErken.AppearanceCell.Options.UseForeColor = True
        Me.colnFarkErken.Caption = "ErkenÖdenenGün"
        Me.colnFarkErken.DisplayFormat.FormatString = "#,#.##"
        Me.colnFarkErken.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnFarkErken.FieldName = "nFarkErken"
        Me.colnFarkErken.Name = "colnFarkErken"
        Me.colnFarkErken.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nFarkErken", "Toplam {0:#,0.##} Gün")})
        Me.colnFarkErken.Visible = True
        Me.colnFarkErken.VisibleIndex = 5
        '
        'colnKacGun
        '
        Me.colnKacGun.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colnKacGun.AppearanceCell.ForeColor = System.Drawing.Color.Lime
        Me.colnKacGun.AppearanceCell.Options.UseFont = True
        Me.colnKacGun.AppearanceCell.Options.UseForeColor = True
        Me.colnKacGun.Caption = "KalanÖdemeGünü"
        Me.colnKacGun.DisplayFormat.FormatString = "#,#.##"
        Me.colnKacGun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKacGun.FieldName = "nKacGun"
        Me.colnKacGun.Name = "colnKacGun"
        Me.colnKacGun.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nKacGun", "Toplam {0:#,0.##} Gün")})
        Me.colnKacGun.Visible = True
        Me.colnKacGun.VisibleIndex = 6
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.Label37)
        Me.PanelControl4.Controls.Add(Me.SimpleButton5)
        Me.PanelControl4.Controls.Add(Me.Label38)
        Me.PanelControl4.Controls.Add(Me.sec_odeme_tarih2)
        Me.PanelControl4.Controls.Add(Me.sec_odeme_tarih1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(996, 40)
        Me.PanelControl4.TabIndex = 0
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(160, 8)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(12, 13)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "ve"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(528, 8)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 4
        Me.SimpleButton5.Text = "&Oku"
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(360, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(141, 13)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Tarihleri Arasýndaki Ödemeleri"
        '
        'sec_odeme_tarih2
        '
        Me.sec_odeme_tarih2.EditValue = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.sec_odeme_tarih2.Location = New System.Drawing.Point(192, 8)
        Me.sec_odeme_tarih2.Name = "sec_odeme_tarih2"
        Me.sec_odeme_tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_odeme_tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_odeme_tarih2.Size = New System.Drawing.Size(160, 20)
        Me.sec_odeme_tarih2.TabIndex = 1
        '
        'sec_odeme_tarih1
        '
        Me.sec_odeme_tarih1.EditValue = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.sec_odeme_tarih1.Location = New System.Drawing.Point(8, 8)
        Me.sec_odeme_tarih1.Name = "sec_odeme_tarih1"
        Me.sec_odeme_tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_odeme_tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_odeme_tarih1.Size = New System.Drawing.Size(152, 20)
        Me.sec_odeme_tarih1.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl4)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage3.Text = "Hesap Ekstresi"
        '
        'GridControl4
        '
        Me.GridControl4.ContextMenu = Me.kisayol_ekstre
        Me.GridControl4.DataMember = Nothing
        Me.GridControl4.DataSource = Me.ds_ekstre
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 40)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(996, 355)
        Me.GridControl4.TabIndex = 1
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'kisayol_ekstre
        '
        Me.kisayol_ekstre.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem8, Me.MenuItem4, Me.MenuItem5, Me.MenuItem9, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Görünümü Kaydet"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Görünümü Yazdýr"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Filtrele"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "Gruplandýr"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 6
        Me.MenuItem9.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "Satýrlarý Aç"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        Me.MenuItem7.Text = "Satýrlarý Kapat"
        '
        'ds_ekstre
        '
        Me.ds_ekstre.DataSetName = "NewDataSet"
        Me.ds_ekstre.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_ekstre.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "lKodu"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "sMusteriAdi"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "dteTarih"
        Me.DataColumn64.DataType = GetType(Date)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "fisTipi"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "lNo"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "sKodu"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "sStokAciklama"
        '
        'DataColumn69
        '
        Me.DataColumn69.Caption = "Miktar"
        Me.DataColumn69.ColumnName = "Miktar"
        Me.DataColumn69.DataType = GetType(Decimal)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "Fiyat"
        Me.DataColumn70.DataType = GetType(Decimal)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "Iskonto"
        Me.DataColumn71.DataType = GetType(Decimal)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "lNetTutar"
        Me.DataColumn72.DataType = GetType(Decimal)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "OdemeTutar"
        Me.DataColumn73.DataType = GetType(Decimal)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "OdemeTipi"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "SaticiRumuzu"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "KasiyerRumuzu"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "Teslimatci"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "Id"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "OdemeAciklama"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "Tipi"
        Me.DataColumn80.DataType = GetType(Long)
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "GirisCikis"
        Me.DataColumn81.DataType = GetType(Long)
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "IadeAvInf"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "lMalBedeli"
        Me.DataColumn83.DataType = GetType(Decimal)
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "sHareketTipi"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "nIslemId"
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "StokOdeme"
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "SevkAciklama"
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "KayitTarihi"
        Me.DataColumn88.DataType = GetType(Date)
        '
        'GridView4
        '
        Me.GridView4.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.Empty.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView4.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collKodu, Me.colsMusteriAdi, Me.coldteTarih, Me.colfisTipi, Me.collNo, Me.colsKodu, Me.colsStokAciklama, Me.colMiktar, Me.colFiyat, Me.colIskonto, Me.collNetTutar1, Me.colOdemeTutar, Me.colOdemeTipi, Me.colSaticiRumuzu, Me.colKasiyerRumuzu, Me.colTeslimatci, Me.colId, Me.colOdemeAciklama, Me.colTipi, Me.colGirisCikis, Me.colIadeAvInf, Me.collMalBedeli, Me.colsHareketTipi, Me.colnIslemId, Me.colStokOdeme, Me.colSevkAciklama, Me.colKayitTarihi})
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(477, 314, 208, 170)
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.IndicatorWidth = 12
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsDetail.ShowDetailTabs = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri No"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        '
        'colsMusteriAdi
        '
        Me.colsMusteriAdi.Caption = "Müþteri"
        Me.colsMusteriAdi.FieldName = "sMusteriAdi"
        Me.colsMusteriAdi.Name = "colsMusteriAdi"
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Visible = True
        Me.coldteTarih.VisibleIndex = 0
        Me.coldteTarih.Width = 74
        '
        'colfisTipi
        '
        Me.colfisTipi.Caption = "Fiþ Tipi"
        Me.colfisTipi.FieldName = "fisTipi"
        Me.colfisTipi.Name = "colfisTipi"
        Me.colfisTipi.Visible = True
        Me.colfisTipi.VisibleIndex = 1
        Me.colfisTipi.Width = 53
        '
        'collNo
        '
        Me.collNo.Caption = "Fiþ No"
        Me.collNo.FieldName = "lNo"
        Me.collNo.Name = "collNo"
        Me.collNo.Visible = True
        Me.collNo.VisibleIndex = 2
        Me.collNo.Width = 57
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 3
        Me.colsKodu.Width = 115
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Açýklama"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 4
        Me.colsStokAciklama.Width = 220
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Miktar"
        Me.colMiktar.DisplayFormat.FormatString = "#,#.##"
        Me.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.##}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 5
        Me.colMiktar.Width = 60
        '
        'colFiyat
        '
        Me.colFiyat.Caption = "Fiyat"
        Me.colFiyat.DisplayFormat.FormatString = "#,#.##"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 6
        Me.colFiyat.Width = 50
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Iskonto"
        Me.colIskonto.DisplayFormat.FormatString = "#,#.##"
        Me.colIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        Me.colIskonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.##}")})
        Me.colIskonto.Visible = True
        Me.colIskonto.VisibleIndex = 7
        Me.colIskonto.Width = 54
        '
        'collNetTutar1
        '
        Me.collNetTutar1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collNetTutar1.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.collNetTutar1.AppearanceCell.Options.UseFont = True
        Me.collNetTutar1.AppearanceCell.Options.UseForeColor = True
        Me.collNetTutar1.Caption = "SatýþTutarý"
        Me.collNetTutar1.DisplayFormat.FormatString = "#,#.##"
        Me.collNetTutar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar1.FieldName = "lNetTutar"
        Me.collNetTutar1.Name = "collNetTutar1"
        Me.collNetTutar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.##}")})
        Me.collNetTutar1.Visible = True
        Me.collNetTutar1.VisibleIndex = 8
        Me.collNetTutar1.Width = 64
        '
        'colOdemeTutar
        '
        Me.colOdemeTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colOdemeTutar.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colOdemeTutar.AppearanceCell.Options.UseFont = True
        Me.colOdemeTutar.AppearanceCell.Options.UseForeColor = True
        Me.colOdemeTutar.Caption = "OdemeTutarý"
        Me.colOdemeTutar.DisplayFormat.FormatString = "#,#.##"
        Me.colOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOdemeTutar.FieldName = "OdemeTutar"
        Me.colOdemeTutar.Name = "colOdemeTutar"
        Me.colOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OdemeTutar", "{0:#,0.##}")})
        Me.colOdemeTutar.Visible = True
        Me.colOdemeTutar.VisibleIndex = 9
        Me.colOdemeTutar.Width = 88
        '
        'colOdemeTipi
        '
        Me.colOdemeTipi.Caption = "ÖdemeTipi"
        Me.colOdemeTipi.FieldName = "OdemeTipi"
        Me.colOdemeTipi.Name = "colOdemeTipi"
        Me.colOdemeTipi.Visible = True
        Me.colOdemeTipi.VisibleIndex = 10
        Me.colOdemeTipi.Width = 74
        '
        'colSaticiRumuzu
        '
        Me.colSaticiRumuzu.Caption = "Satýcý"
        Me.colSaticiRumuzu.FieldName = "SaticiRumuzu"
        Me.colSaticiRumuzu.Name = "colSaticiRumuzu"
        Me.colSaticiRumuzu.Width = 58
        '
        'colKasiyerRumuzu
        '
        Me.colKasiyerRumuzu.Caption = "Kasiyer"
        Me.colKasiyerRumuzu.FieldName = "KasiyerRumuzu"
        Me.colKasiyerRumuzu.Name = "colKasiyerRumuzu"
        Me.colKasiyerRumuzu.Visible = True
        Me.colKasiyerRumuzu.VisibleIndex = 11
        Me.colKasiyerRumuzu.Width = 76
        '
        'colTeslimatci
        '
        Me.colTeslimatci.Caption = "Teslimatçý"
        Me.colTeslimatci.FieldName = "Teslimatci"
        Me.colTeslimatci.Name = "colTeslimatci"
        '
        'colId
        '
        Me.colId.Caption = "Kayýt No"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colOdemeAciklama
        '
        Me.colOdemeAciklama.Caption = "Açýklama"
        Me.colOdemeAciklama.FieldName = "OdemeAciklama"
        Me.colOdemeAciklama.Name = "colOdemeAciklama"
        '
        'colTipi
        '
        Me.colTipi.Caption = "Tipi"
        Me.colTipi.FieldName = "Tipi"
        Me.colTipi.Name = "colTipi"
        '
        'colGirisCikis
        '
        Me.colGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.colGirisCikis.FieldName = "GirisCikis"
        Me.colGirisCikis.Name = "colGirisCikis"
        '
        'colIadeAvInf
        '
        Me.colIadeAvInf.Caption = "IadeAvInf"
        Me.colIadeAvInf.FieldName = "IadeAvInf"
        Me.colIadeAvInf.Name = "colIadeAvInf"
        '
        'collMalBedeli
        '
        Me.collMalBedeli.Caption = "Mal Bedeli"
        Me.collMalBedeli.FieldName = "lMalBedeli"
        Me.collMalBedeli.Name = "collMalBedeli"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colnIslemId
        '
        Me.colnIslemId.Caption = "SatýrKayýtNo"
        Me.colnIslemId.FieldName = "nIslemId"
        Me.colnIslemId.Name = "colnIslemId"
        '
        'colStokOdeme
        '
        Me.colStokOdeme.Caption = "StokOdeme"
        Me.colStokOdeme.FieldName = "StokOdeme"
        Me.colStokOdeme.Name = "colStokOdeme"
        '
        'colSevkAciklama
        '
        Me.colSevkAciklama.Caption = "SevkAciklama"
        Me.colSevkAciklama.FieldName = "SevkAciklama"
        Me.colSevkAciklama.Name = "colSevkAciklama"
        '
        'colKayitTarihi
        '
        Me.colKayitTarihi.Caption = "Saat"
        Me.colKayitTarihi.DisplayFormat.FormatString = "hh:mm"
        Me.colKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKayitTarihi.FieldName = "KayitTarihi"
        Me.colKayitTarihi.Name = "colKayitTarihi"
        Me.colKayitTarihi.Width = 76
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.Label39)
        Me.PanelControl5.Controls.Add(Me.SimpleButton6)
        Me.PanelControl5.Controls.Add(Me.Label40)
        Me.PanelControl5.Controls.Add(Me.sec_ekstre_tarih2)
        Me.PanelControl5.Controls.Add(Me.sec_ekstre_tarih1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(996, 40)
        Me.PanelControl5.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(160, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(12, 13)
        Me.Label39.TabIndex = 17
        Me.Label39.Text = "ve"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(528, 8)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton6.TabIndex = 16
        Me.SimpleButton6.Text = "&Oku"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(360, 8)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(145, 13)
        Me.Label40.TabIndex = 15
        Me.Label40.Text = "Tarihleri Arasýndaki Hareketleri"
        '
        'sec_ekstre_tarih2
        '
        Me.sec_ekstre_tarih2.EditValue = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.sec_ekstre_tarih2.Location = New System.Drawing.Point(192, 8)
        Me.sec_ekstre_tarih2.Name = "sec_ekstre_tarih2"
        Me.sec_ekstre_tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih2.Size = New System.Drawing.Size(160, 20)
        Me.sec_ekstre_tarih2.TabIndex = 14
        '
        'sec_ekstre_tarih1
        '
        Me.sec_ekstre_tarih1.EditValue = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.sec_ekstre_tarih1.Location = New System.Drawing.Point(8, 8)
        Me.sec_ekstre_tarih1.Name = "sec_ekstre_tarih1"
        Me.sec_ekstre_tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih1.Size = New System.Drawing.Size(152, 20)
        Me.sec_ekstre_tarih1.TabIndex = 13
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage4.Text = "Mektuplar"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage5.Text = "Ýstihbarat"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage7.Text = "Servis"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(996, 395)
        Me.XtraTabPage8.Text = "Ýade/Deðiþim"
        '
        'DateEdit5
        '
        Me.DateEdit5.EditValue = New Date(2007, 1, 18, 0, 0, 0, 0)
        Me.DateEdit5.Location = New System.Drawing.Point(0, 0)
        Me.DateEdit5.Name = "DateEdit5"
        Me.DateEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit5.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit5.Size = New System.Drawing.Size(160, 20)
        Me.DateEdit5.TabIndex = 1
        '
        'ps1
        '
        Me.ps1.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl4
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Müþteri Hesap Ekstresi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"UÐURLU ÇEYÝZ MAÐAZALARI", "Müþteri Ýliþkileri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps1
        Me.printlink1.PrintingSystemBase = Me.ps1
        '
        'printlink2
        '
        Me.printlink2.Component = Me.GridControl2
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Kalan Ödemelir Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"UÐURLU ÇEYÝZ MAÐAZALARI", "Müþteri Ýliþkileri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps1
        Me.printlink2.PrintingSystemBase = Me.ps1
        '
        'PrintableComponentLink1
        '
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PrintingSystem = Me.ps1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.ps1
        '
        'frm_cari_gor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1002, 624)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cari_gor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MüþteriGör"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl10.ResumeLayout(False)
        Me.GroupControl10.PerformLayout()
        CType(Me.TextEdit24.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit25.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl11.ResumeLayout(False)
        Me.GroupControl11.PerformLayout()
        CType(Me.TextEdit28.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit29.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit27.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit26.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        Me.GroupControl8.PerformLayout()
        CType(Me.sec_sinif5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.sec_odeme_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_odeme_tarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_odeme_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_odeme_tarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_ekstre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kullanici
    Public firmakodu
    Public qfirmakodu
    Public carino As Int64 = 0
    Public tarih1
    Public tarih2
    Public qtarih
    Public limit
    Public qlimit
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim ds_taksit_kalan As DataSet
    Dim ds_taksitler As DataSet
    Dim ds_satislar As DataSet
    Dim ds_satislar_detayli As DataSet
    Dim ds_tahsilatlar As DataSet
    Dim ds_odemeler As DataSet
    Public frf_islem As String = "mektup"
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
    End Sub
    Private Sub cari(Optional ByVal islem As Integer = 0)
        Dim kriter As String
        kriter = ""
        If carino <> 0 Then
            kriter += " WHERE ( tbMusteri.nMusteriID = " & carino & ") "
        Else
            kriter += " WHERE ( tbMusteri.nMusteriID >= 0) "
            If firmakodu <> "" Then
                kriter += " AND ( tbMusteri.lKodu " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
            End If
            'If firmaadi <> "" Then
            '    kriter += " AND (  (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) " & sorgu_kriter_string(firmaadi, qfirmaadi) & ")"
            'End If
            'If adres <> "" Then
            '    kriter += " AND ( tbMusteri.sEvAdresi1  " & sorgu_kriter_string(adres, qadres) & " )"
            'End If
            'If telefon <> "" Then
            '    kriter += " and ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(telefon, qtelefon) & " )"
            'End If
            'If kod1 <> "" Then
            '    kriter += " and ( tbMusteri.sAciklama1 " & sorgu_kriter_string(kod1, qkod1) & " )"
            'End If
            'If kod2 <> "" Then
            '    kriter += " and (tbMusteri.sAciklama2 " & sorgu_kriter_string(kod2, qkod2) & " )"
            'End If
            'If kod3 <> "" Then
            '    kriter += " and (tbMusteri.sAciklama3 " & sorgu_kriter_string(kod3, qkod3) & " )"
            'End If
            'If kod4 <> "" Then
            '    kriter += " and (tbMusteri.sAciklama4 " & sorgu_kriter_string(kod4, qkod4) & " )"
            'End If
            'If kod5 <> "" Then
            '    kriter += " and (tbMusteri.sAciklama5 " & sorgu_kriter_string(kod5, qkod5) & " )"
            'End If
            'If istihbarat <> "" Then
            '    kriter += " and (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(istihbarat, qistihbarat) & " )"
            'End If
            'If firmatipi <> "" Then
            '    kriter += " and (FIRMATIPI " & sorgu_kriter_string(firmatipi, qfirmatipi) & " )"
            'End If
            'If aktif <> "" Then
            '    kriter += " and (STATUS " & sorgu_kriter_string(aktif, qaktif) & " )"
            'End If
            'If kayitno <> "" Then
            '    kriter += " and (tbMusteri.nMusteriID " & sorgu_kriter_string(kayitno, qkayitno) & " )"
            'End If
            'If personel <> "" Then
            '    kriter += " and (TBLCARI.PERSONELNO " & sorgu_kriter_string(personel, qpersonel) & " )"
            'End If
            'If islem = 1 Then
            '    kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT * FROM (SELECT nMusteriID FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "' GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar BETWEEN 0 AND 999999999999.99) AND (Tutar " & sorgu_kriter_string(limit, qlimit) & " ) GROUP BY nMusteriID , kodu) GECIKME ) ) "
            'ElseIf islem = 2 Then
            '    kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT nMusteriID FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY nMusteriID HAVING (SUM(lNetTutar) > =  " & limit & ") ))"
            'ElseIf islem = 3 Then
            '    kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi HAVING (SUM(tbOdeme.lOdemeTutar) > =  " & limit & " ) ) )"
            'ElseIf islem = 4 Then
            '    kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT nMusteriID FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY nMusteriID HAVING (SUM(lNetTutar) > =  0) ))"
            '    'kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT nMusteriID FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY nMusteriID HAVING (SUM(lNetTutar) > =  " & limit & ") ))"
            '    kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT * FROM (SELECT nMusteriID FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi  <  '" & tarih1.ToString.Substring(0, 10) & "' GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar BETWEEN 0 AND 999999999999.99) AND (Tutar " & sorgu_kriter_string(limit, qlimit) & ") GROUP BY nMusteriID , kodu) GECIKME ) ) "
            'ElseIf islem = 5 Then
            '    kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi HAVING (SUM(tbOdeme.lOdemeTutar) > =  0 ) ) )"
            '    'kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "') GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi HAVING (SUM(tbOdeme.lOdemeTutar) > =  " & limit & " ) ) )"
            '    kriter += " AND ( tbMusteri.nMusteriID IN ( SELECT * FROM (SELECT nMusteriID FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbTaksit.DteTarihi <   '" & tarih1.ToString.Substring(0, 10) & "'  GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar BETWEEN 0 AND 999999999999.99) AND (Tutar " & sorgu_kriter_string(limit, qlimit) & ") GROUP BY nMusteriID , kodu) GECIKME ) ) "
            'End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERI, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1, tbMusteri.sIsAdresi2, tbMusteri.sIsSemt, tbMusteri.sIsTelefonu, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteriSinifi.sSinifKodu1 AS KOD1, tbMusteriSinifi.sSinifKodu2 AS KOD2, tbMusteriSinifi.sSinifKodu3 AS KOD3, tbMusteriSinifi.sSinifKodu4 AS KOD4, tbMusteriSinifi.sSinifKodu5 AS KOD5, tbMusteriKefil1.sAdi + ' ' + tbMusteriKefil1.sSoyadi AS KEFILAD1, tbMusteriKefil1.sEvAdresi1 + ' ' + tbMusteriKefil1.sEvAdresi2 AS KEFILADRES1, tbMusteriKefil1.sEvTelefonu AS KEFILTELEFON1, tbMusteriKefil2.sAdi + ' ' + tbMusteriKefil2.sSoyadi AS KEFILAD2, tbMusteriKefil2.sEvAdresi1 + ' ' + tbMusteriKefil2.sEvAdresi2 AS KEFILADRES2, tbMusteriKefil2.sEvTelefonu AS KEFILTELEFON2 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID LEFT OUTER JOIN tbMusteriKefil2 ON tbMusteri.nMusteriID = tbMusteriKefil2.nMusteriID LEFT OUTER JOIN tbMusteriKefil1 ON tbMusteri.nMusteriID = tbMusteriKefil1.nMusteriID " & kriter & " ORDER BY tbMusteri.lKodu")
        kriter = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        N = Nothing
    End Sub
    Private Sub dataload_depo()
        sec_sinif1.Properties.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif1")).Tables(0) 'DataSet2.Tables(0)
        sec_sinif2.Properties.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif2")).Tables(0) 'DataSet2.Tables(0)
        sec_sinif3.Properties.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif3")).Tables(0)  'DataSet2.Tables(0)
        sec_sinif4.Properties.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif4")).Tables(0) 'DataSet2.Tables(0)
        sec_sinif5.Properties.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif5")).Tables(0) 'DataSet2.Tables(0)
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
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub gor()
        DataSet1.Clear()
        lblstokkodu.Text = "*"
        lblstokadi.Text = "*"
        firmakodu = txt_ara.EditValue.ToString
        qfirmakodu = sec_kriter.EditValue.ToString
        ds_odeme.Tables(0).Clear()
        ds_ekstre.Tables(0).Clear()
        sec_ekstre_tarih2.EditValue = dteSistemTarihi
        sec_odeme_tarih2.EditValue = dteSistemTarihi
        dataload()
    End Sub
    Private Sub dataload(Optional ByVal islem As Integer = 0)
        DataSet1.Clear()
        cari(islem)
        If DataSet1.Tables(0).Rows.Count > 0 Then
        Else
            XtraMessageBox.Show(Sorgu_sDil("Müþteri Hesabý Bulunumadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Refresh()
        If DataSet1.Tables(0).Rows.Count > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Müþteri Analizi Hesaplamasýna Baþlamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                taksit_kontrol()
            End If
        End If
    End Sub
    Private Sub taksit_kontrol()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        For Each dr In DataSet1.Tables(0).Rows
            'Satýr Oku
            barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("MUSTERI").ToString
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
            bar2.Properties.Maximum = ds_taksitler.Tables(0).Rows.Count
            barlabel2.Text = "Taksitler Okunuyor...Toplam Satýr Sayýsý : " & ds_taksitler.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            GridControl2.DataSource = ds_taksitler.Tables(0)
            GridControl2.DataMember = Nothing
            GridControl2.Refresh()
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
                dr("GECIKENILKTAKSITTUTARI") = ilktaksittutar
            Catch ex As Exception
            End Try
            dr("GECIKMISTAKSIT") = gecikmistaksitsayisi
            dr("GECIKMISKALAN") = gecikmistaksittutari
            dr("KALANTAKSITSAYISI") = kalantaksitsayisi
            'Satýþlar
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
            barlabel2.Text = "Satýþlar Okunuyor...Toplam Satýr Sayýsý : " & ds_satislar_detayli.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
            GridControl1.DataSource = ds_satislar_detayli.Tables(0)
            GridControl1.DataMember = Nothing
            GridControl1.Refresh()
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
            Dim sontahsilattarihi As DateTime
            Dim sontahsilattutari As Decimal = 0
            bar2.Properties.Maximum = ds_tahsilatlar.Tables(0).Rows.Count
            barlabel2.Text = "Tahsilatlar Okunuyor...Toplam Satýr Sayýsý : " & ds_tahsilatlar.Tables(0).Rows.Count
            bar2.Position = 0
            barlabel2.Refresh()
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
                barlabel2.Text = "ÖdemeAnalizi Okunuyor...Toplam Satýr Sayýsý : " & ds_odemeler.Tables(0).Rows.Count
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
            'Satýr Bitir
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = 35265) GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu")
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi, ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
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
    Public Function sorgu_satislar_detayli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nAlisverisID,sFisTipi, dteFaturaTarihi, nGirisCikis, lToplamMiktar, lNetTutar,lPesinat, lFaturaNo, sMagaza, sKasiyerRumuzu, nKasaNo, dteKayitTarihi, sYaziIle  FROM         tbAlisVeris  WHERE     (nMusteriID = " & musterino & ") ORDER BY dteFaturaTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_ekstre_detayli(ByVal musterino As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND lKodu = '" & musterino & "'  UNION ALL SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbalisverisSiparis.lGCMiktar, 0) AS Miktar, isnull(tbalisverisSiparis.lBrutFiyat, 0) AS Fiyat, isnull(tbalisverisSiparis.lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefaturaTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbalisverisSiparis.lBrutTutar - tbalisverisSiparis.lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, tbAlisverisSiparis.sIadeNedeni AS OdemeTipi, rtrim(tbalisverisSiparis.sSaticiRumuzu) + (CASE WHEN rtrim(tbalisverisSiparis.sSaticiRumuzu) <> '' THEN ' - ' ELSE '' END) + (CASE bTeslimEdildi WHEN 0 THEN CONVERT(char(10), dteTeslimEdilecek, 103) ELSE CONVERT(char(10), dteTeslimEdilen, 103) END) AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, bTeslimEdildi * (CASE bEkAlan2 WHEN '' THEN 1 ELSE 0 END) AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, 0 AS nIslemID, tbalisverisSiparis.sOdemeKodu AS StokOdeme, isnull(CONVERT(char(10), dteFisTarihi, 103) + ' - ' + ltrim(tbStokFisiDetayi.sFisTipi) + ' - ' + ltrim(str(tbStokFisiDetayi.lFisNo)), '') AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbalisverisSiparis ON tbalisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbalisverisSiparis.nStokID LEFT OUTER JOIN tbStokFisiDetayi ON tbalisverisSiparis.nStokIslemID = tbStokFisiDetayi.nIslemID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND lKodu = '" & musterino & "' UNION ALL SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, lNetTutar = CASE WHEN sFistipi = 'Pad' THEN lNetTutar ELSE lVadeFarki END, 0 AS OdemeTutar, '' AS OdemeTipi, '' AS SaticiRumuzu, sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi AS OdemeAciklama, 1 AS Tipi, tbAlisVeris.nGirisCikis AS nGirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi FROM tbAlisVeris, tbMusteri WHERE tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'PAD' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND lKodu = '" & musterino & "' UNION ALL SELECT lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, SUM(OdemeTutar), OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, Id, TaksitTarihi, SUM(TaksitTutari), OdemeAciklama, Tipi, GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dteOdemeTarihi AS dteTarih, FisTipi = CASE WHEN nOdemekodu <> 1 THEN 'Z' ELSE tbAlisVeris.sFisTipi END, lNo = CASE WHEN nOdemekodu <> 1 THEN 0 ELSE tbalisveris.lFaturaNo END, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, 0 AS lNetTutar, lOdemeTutar AS OdemeTutar, tbOdeme.sOdemeSekli AS OdemeTipi, '' AS SaticiRumuzu, tbOdeme.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, '' AS AlisverisiYapan, Id = CASE WHEN nOdemekodu <> 1 THEN '0' ELSE tbOdeme.nAlisVerisId END, '01/01/2078' AS TaksitTarihi, cast(nOdemeKodu AS int) AS TaksitTutari, CONVERT(char(10), dteOdemeTarihi, 103) AS OdemeAciklama, 2 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi FROM tbAlisVeris, tbMusteri, tbOdeme, tbOdemeSekli WHERE tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli AND TbOdeme.nAlisverisId = TbAlisveris.nAlisverisId AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND (nOdemeKodu < 3) AND dteOdemeTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'PAD' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND lKodu = '" & musterino & "') AS a GROUP BY GirisCikis, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, Id, TaksitTarihi, OdemeAciklama, Tipi UNION ALL SELECT lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, '0' Id, TaksitTarihi, SUM(TaksitTutari), OdemeAciklama, Tipi, 5 AS GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, '31/12/2078' AS dteTarih, '' AS fisTipi, 0 AS lNo, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, 0 AS lNetTutar, 0 AS OdemeTutar, '' AS OdemeTipi, '' AS SaticiRumuzu, '' AS KasiyerRumuzu, '' AS Teslimatci, '' AS AlisverisiYapan, tbTaksit.nTaksitId AS Id, dteTarihi AS TaksitTarihi, lTutari - SUM(Isnull(lOdemeTutar, 0)) AS TaksitTutari, '' AS OdemeAciklama, 3 AS Tipi, 5 AS GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi FROM tbMusteri INNER JOIN (SELECT DISTINCT tbAlisVeris.nMusteriID FROM tbAlisVeris, tbMusteri WHERE dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078 ' AND tbMusteri.nMusteriID = tbAlisVeris.nMusteriID AND lKodu = '" & musterino & "') AS tbTemp ON tbMusteri.nMusteriID = tbTemp.nMusteriID, tbAlisVeris, tbTaksit LEFT OUTER JOIN tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbMusteri.nMusteriID = tbAlisVeris.nMusteriID AND lKodu = '" & musterino & "' GROUP BY tbTaksit.nTaksitId, tbAlisVeris.nGirisCikis, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, dteTarihi, lTutari HAVING lTutari - IsNull(SUM(tbOdeme.lOdemeTutar), 0) <> 0) AS a GROUP BY GirisCikis, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, TaksitTarihi, OdemeAciklama, Tipi) AS TT WHERE     dteTarih <> '31.12.2078'  and dteTarih Between '" & tarih1 & "' and '" & tarih2 & "' ORDER BY lKodu, dteTarih, GirisCikis, fisTipi, lno, Tipi, TaksitTarihi, Id, nIslemId")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_odemeler_detayli(ByVal musterino As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwMusteriOdemeleri WHERE     (Musteri_TanimlamaNo = '" & musterino & "') and Odeme_Tarihi between '" & tarih1 & "' and '" & tarih2 & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub raporla(ByVal islem As Integer)
        Dim file As String
        Dim dr As DataRow
        Dim musterino As Int64
        Dim sontahsilattarihi As DateTime
        Dim sontahsilattutari As Decimal
        Dim sonsatistarihi As DateTime
        Dim sonsatistutari As Decimal
        Dim gecikmistaksitsayisi As Int64
        Dim gecikmistaksittutari As Int64
        Dim toplamkalantaksitsayisi As Int64
        Dim toplamkalantaksittutari As Decimal = 0
        Dim gecikmisodeme As Int64 = 0
        Dim gunundeodeme As Int64 = 0
        Dim erkenodeme As Int64 = 0
        Dim odemesayisi As Int64 = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Ekstre"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            dr = DataSet1.Tables(0).Rows(0)
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
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal musterino As Int64, ByVal sontahsilattarihi As DateTime, ByVal sontahsilattutari As Decimal, ByVal sonsatistarihi As DateTime, ByVal sonsatistutari As Decimal, ByVal gecikmistaksitsayisi As Int64, ByVal gecikmistaksittutari As Decimal, ByVal kalantaksitsayisi As Int64, ByVal kalantaksittutari As Decimal, ByVal gecikmisodeme As Int64, ByVal gunundeodeme As Int64, ByVal erkenodeme As Int64, ByVal toplamodeme As Int64)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'frx.PrintOptions.Copies = dr("MIKTAR")
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
            Dim qr_hareket As New TfrxADOQuery
            qr_hareket = frx.FindObject("qr_musteri")
            qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu, (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) AS MUSTERI,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteriSinifi.sSinifKodu1 AS KOD1, tbMusteriSinifi.sSinifKodu2 AS KOD2, tbMusteriSinifi.sSinifKodu3 AS KOD3, tbMusteriSinifi.sSinifKodu4 AS KOD4, tbMusteriSinifi.sSinifKodu5 AS KOD5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID Where TbMusteri.nMusteriID =" & musterino & " Order By TbMusteri.lKodu")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
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
            qr_connection = Nothing
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
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Function satir_kontrol()
        Dim dr As DataRow
        dr = DataSet1.Tables(0).Rows(0)
        Dim satir As String = "WHERE tbMusteri.nMusteriId IN ( " & dr("nMusteriID") & " ) "
        'Dim s As String
        'Dim arr As Integer()
        'Dim i As Integer
        'Dim toplamsayi = GridView1.SelectedRowsCount
        'Dim sayi = 0
        'arr = GridView1.GetSelectedRows()
        'Dim dr1 As DataRow
        'If arr Is Nothing Then
        'Else
        '    arr.Sort(arr)
        '    For Each i In arr
        '        s = i.ToString
        '        dr = DataSet1.Tables(0).NewRow
        '        dr1 = GridView1.GetDataRow(s)
        '        satir += dr1("nMusteriID").ToString
        '        sayi += 1
        '        If sayi < toplamsayi Then
        '            satir += ","
        '        ElseIf sayi = toplamsayi Then
        '            satir += ")"
        '        End If
        '    Next
        'End If
        Return satir
    End Function
    Private Sub stok_satis_detay()
        Dim frm As New frm_stok_cari_satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.stokno = dr("nAlisVerisID")
        frm.fistipi = Trim(dr("sFistipi").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        If Len(txt_ara.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_ara.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub frm_Cari_Gor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            gor()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_Cari_Gor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU")
        'If connection = "" Then
        '    connection = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=BARKOD;Data Source=(local)"
        '    Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection)
        'End If
        firmano = 100
        donemno = 1
        dataload_depo()
    End Sub
    Private Sub XtraTabPage6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles XtraTabPage6.Paint
    End Sub
    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click
    End Sub
    Private Sub TextEdit23_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit23.EditValueChanged
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If DataSet1.Tables(0).Rows.Count > 0 Then
            raporla(0)
        End If
    End Sub
    Private Sub GroupControl8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl8.Paint
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If GridView1.RowCount > 0 Then
            stok_satis_detay()
        End If
    End Sub
    Friend WithEvents DateEdit5 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label38 As DevExpress.XtraEditors.LabelControl
    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged
    End Sub
    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If GridView1.RowCount > 0 Then
                stok_satis_detay()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            If GridView1.RowCount > 0 Then
                stok_satis_detay()
            End If
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If DataSet1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow
            Dim musterino As String
            dr = DataSet1.Tables(0).Rows(0)
            musterino = dr("lKodu")
            ds_ekstre = sorgu_ekstre_detayli(musterino, sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue)
            For Each dr In ds_ekstre.Tables(0).Rows
                If dr("Tipi") <> 2 Then
                    dr("OdemeTutar") = 0
                Else
                    Dim fistipi As String = Trim(dr("fisTipi").ToString)
                    If fistipi = "P" Then
                        dr("sKodu") = "Peþin Satýþ"
                        dr("sStokAciklama") = "Peþinat"
                    ElseIf fistipi = "Z" Then
                        dr("sKodu") = "Taksit"
                        dr("sStokAciklama") = "Ödeme"
                    ElseIf fistipi = "K" Then
                        dr("sKodu") = "Kredili Satýþ"
                        dr("sStokAciklama") = "Peþinat"
                    End If
                End If
            Next
            GridControl4.DataSource = ds_ekstre.Tables(0)
            GridControl4.DataMember = Nothing
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If DataSet1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow
            Dim musterino As String
            dr = DataSet1.Tables(0).Rows(0)
            musterino = dr("nMusteriID")
            ds_odeme = sorgu_odemeler_detayli(musterino, sec_odeme_tarih1.EditValue, sec_odeme_tarih2.EditValue)
            'For Each dr In ds_ekstre.Tables(0).Rows
            '    If dr("Tipi") <> 2 Then
            '        dr("OdemeTutar") = 0
            '    Else
            '        Dim fistipi As String = Trim(dr("fisTipi").ToString)
            '        If fistipi = "P" Then
            '            dr("sKodu") = "Peþin Satýþ"
            '            dr("sStokAciklama") = "Peþinat"
            '        ElseIf fistipi = "Z" Then
            '            dr("sKodu") = "Taksit"
            '            dr("sStokAciklama") = "Ödeme"
            '        ElseIf fistipi = "K" Then
            '            dr("sKodu") = "Kredili Satýþ"
            '            dr("sStokAciklama") = "Peþinat"
            '        End If
            '    End If
            'Next
            GridControl3.DataSource = ds_odeme.Tables(0)
            GridControl3.DataMember = Nothing
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        printlink1.CreateDocument(ps1)
        'printlink2.CreateDocument(ps1)
        ps1.PreviewFormEx.Show()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
    End Sub
End Class
