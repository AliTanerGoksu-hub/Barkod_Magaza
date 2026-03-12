Imports DevExpress.XtraEditors
Public Class Frm_SKKontrol
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
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_detay As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents ds_kapatma As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents colFis_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Tipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Tanimlama_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Kodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Adi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Soyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Fis_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Tarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Tutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlisveris_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri_Taksiti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdeme_tutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeslimatci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIadeAvInf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIslemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokOdeme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKalanTaksit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPesinat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKasaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsYaziIle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink3 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents ContextMenu2 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu3 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_sTarihTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colnAdiSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOdeme_tutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteri_Taksiti As DevExpress.XtraGrid.Columns.GridColumn
    'Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SKKontrol))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colMusteri_Taksiti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_sTarihTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.tarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.tarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeslimatci = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIadeAvInf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIslemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokOdeme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKalanTaksit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu3 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFis_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Tipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Tanimlama_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Kodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Adi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Soyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Fis_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Tarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Tutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlisveris_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdeme_tutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPesinat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYaziIle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAdiSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnOdeme_tutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteri_Taksiti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.ds_detay = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.ds_kapatma = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.sec_sTarihTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kapatma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colMusteri_Taksiti
        '
        Me.colMusteri_Taksiti.Caption = "Kalan"
        Me.colMusteri_Taksiti.DisplayFormat.FormatString = "#,0.00"
        Me.colMusteri_Taksiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMusteri_Taksiti.FieldName = "Musteri_Taksiti"
        Me.colMusteri_Taksiti.Name = "colMusteri_Taksiti"
        Me.colMusteri_Taksiti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Musteri_Taksiti", "{0:#,0.00}")})
        Me.colMusteri_Taksiti.Visible = True
        Me.colMusteri_Taksiti.VisibleIndex = 3
        Me.colMusteri_Taksiti.Width = 55
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.sec_sTarihTipi)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.tarih2)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.tarih1)
        Me.PanelControl1.Controls.Add(Me.SimpleButton5)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1199, 95)
        Me.PanelControl1.TabIndex = 3
        '
        'sec_sTarihTipi
        '
        Me.sec_sTarihTipi.EditValue = "Tarih:"
        Me.sec_sTarihTipi.EnterMoveNextControl = True
        Me.sec_sTarihTipi.Location = New System.Drawing.Point(101, 21)
        Me.sec_sTarihTipi.Name = "sec_sTarihTipi"
        Me.sec_sTarihTipi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sTarihTipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sTarihTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sTarihTipi.Properties.Items.AddRange(New Object() {"Tarih:", "Kayýt Tarihi:", "Valor Tarihi:"})
        Me.sec_sTarihTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sTarihTipi.Size = New System.Drawing.Size(65, 20)
        Me.sec_sTarihTipi.TabIndex = 84
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(415, 21)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl9.TabIndex = 83
        Me.LabelControl9.Text = "Arasýndaki"
        '
        'tarih2
        '
        Me.tarih2.EditValue = Nothing
        Me.tarih2.EnterMoveNextControl = True
        Me.tarih2.Location = New System.Drawing.Point(315, 21)
        Me.tarih2.Name = "tarih2"
        Me.tarih2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarih2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarih2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.tarih2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tarih2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tarih2.Size = New System.Drawing.Size(100, 20)
        Me.tarih2.TabIndex = 81
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(275, 20)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl11.TabIndex = 82
        Me.LabelControl11.Text = "ve"
        '
        'tarih1
        '
        Me.tarih1.EditValue = Nothing
        Me.tarih1.EnterMoveNextControl = True
        Me.tarih1.Location = New System.Drawing.Point(169, 21)
        Me.tarih1.Name = "tarih1"
        Me.tarih1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarih1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarih1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.tarih1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tarih1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tarih1.Size = New System.Drawing.Size(100, 20)
        Me.tarih1.TabIndex = 80
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton5.Location = New System.Drawing.Point(462, 69)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(61, 20)
        Me.SimpleButton5.TabIndex = 79
        Me.SimpleButton5.Text = "&Listele"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1278, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 527)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1199, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(6, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1113, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1038, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl6)
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1199, 432)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.GridControl2)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(446, 2)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(483, 428)
        Me.PanelControl6.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextMenu2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(479, 424)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenu2
        '
        Me.ContextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28})
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Envanter"
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = False
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Model Envanter"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 3
        Me.MenuItem21.Text = "Görünüm Düzenle"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Text = "Görünümü Kaydet"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem23.Text = "Görünümü Yazdýr"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 6
        Me.MenuItem24.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 7
        Me.MenuItem25.Text = "Filtrele"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 8
        Me.MenuItem26.Text = "Gruplandýr"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 9
        Me.MenuItem27.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 10
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem28.Text = "Tam Ekran"
        '
        'GridView2
        '
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collKodu, Me.collMusteriAdi, Me.coldteTarih, Me.colsFisTipi, Me.collNo, Me.colsKodu, Me.colsAciklama, Me.colMiktar, Me.colFiyat, Me.colIskonto, Me.collNetTutar, Me.colOdemeTutar, Me.colOdemeTipi, Me.colSaticiRumuzu, Me.colKasiyerRumuzu, Me.colTeslimatci, Me.colOdemeAciklama, Me.colGirisCikis, Me.colMalBedeli, Me.colIadeAvInf, Me.colsHareketTipi, Me.colnIslemId, Me.colStokOdeme, Me.colSevkAciklama, Me.colKalanTaksit, Me.colKayitTarihi, Me.colsFiyatTipi})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupPanelText = "SatisDetayi..."
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.ViewCaption = "Satýþ Detaylarý"
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        '
        'collMusteriAdi
        '
        Me.collMusteriAdi.Caption = "Müþteri"
        Me.collMusteriAdi.FieldName = "lMusteriAdi"
        Me.collMusteriAdi.Name = "collMusteriAdi"
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Width = 67
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "Ýzahat"
        Me.colsFisTipi.FieldName = "fisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Width = 38
        '
        'collNo
        '
        Me.collNo.Caption = "Fiþ No"
        Me.collNo.FieldName = "lNo"
        Me.collNo.Name = "collNo"
        Me.collNo.Width = 57
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 83
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sStokAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 111
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Miktar"
        Me.colMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.##}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 2
        Me.colMiktar.Width = 46
        '
        'colFiyat
        '
        Me.colFiyat.Caption = "Fiyat"
        Me.colFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 3
        Me.colFiyat.Width = 57
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Ýskonto"
        Me.colIskonto.DisplayFormat.FormatString = "#,0.00"
        Me.colIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        Me.colIskonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.##}")})
        Me.colIskonto.Visible = True
        Me.colIskonto.VisibleIndex = 4
        Me.colIskonto.Width = 50
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
        Me.collNetTutar.VisibleIndex = 5
        Me.collNetTutar.Width = 62
        '
        'colOdemeTutar
        '
        Me.colOdemeTutar.Caption = "Ödenen"
        Me.colOdemeTutar.FieldName = "OdemeTutar"
        Me.colOdemeTutar.Name = "colOdemeTutar"
        Me.colOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OdemeTutar", "{0:#,0.##}")})
        '
        'colOdemeTipi
        '
        Me.colOdemeTipi.Caption = "ÖdemeTipi"
        Me.colOdemeTipi.FieldName = "OdemeTipi"
        Me.colOdemeTipi.Name = "colOdemeTipi"
        '
        'colSaticiRumuzu
        '
        Me.colSaticiRumuzu.Caption = "Satýcý"
        Me.colSaticiRumuzu.FieldName = "SaticiRumuzu"
        Me.colSaticiRumuzu.Name = "colSaticiRumuzu"
        Me.colSaticiRumuzu.Width = 49
        '
        'colKasiyerRumuzu
        '
        Me.colKasiyerRumuzu.Caption = "Kasiyer"
        Me.colKasiyerRumuzu.FieldName = "KasiyerRumuzu"
        Me.colKasiyerRumuzu.Name = "colKasiyerRumuzu"
        Me.colKasiyerRumuzu.Width = 79
        '
        'colTeslimatci
        '
        Me.colTeslimatci.Caption = "Teslimatçý"
        Me.colTeslimatci.FieldName = "Teslimatci"
        Me.colTeslimatci.Name = "colTeslimatci"
        '
        'colOdemeAciklama
        '
        Me.colOdemeAciklama.Caption = "ÖdemeAçýklamasý"
        Me.colOdemeAciklama.FieldName = "OdemeAciklama"
        Me.colOdemeAciklama.Name = "colOdemeAciklama"
        '
        'colGirisCikis
        '
        Me.colGirisCikis.Caption = "GiriþÇýkýþ"
        Me.colGirisCikis.FieldName = "GirisCikis"
        Me.colGirisCikis.Name = "colGirisCikis"
        '
        'colMalBedeli
        '
        Me.colMalBedeli.Caption = "ÜrünBedeli"
        Me.colMalBedeli.FieldName = "MalBedeli"
        Me.colMalBedeli.Name = "colMalBedeli"
        Me.colMalBedeli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MalBedeli", "{0:#,0.##}")})
        '
        'colIadeAvInf
        '
        Me.colIadeAvInf.Caption = "ÝadeÝnfo"
        Me.colIadeAvInf.FieldName = "IadeAvInf"
        Me.colIadeAvInf.Name = "colIadeAvInf"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colnIslemId
        '
        Me.colnIslemId.Caption = "ÝþlemKayýtNo"
        Me.colnIslemId.FieldName = "nIslemId"
        Me.colnIslemId.Name = "colnIslemId"
        '
        'colStokOdeme
        '
        Me.colStokOdeme.Caption = "StokÖdeme"
        Me.colStokOdeme.FieldName = "StokOdeme"
        Me.colStokOdeme.Name = "colStokOdeme"
        '
        'colSevkAciklama
        '
        Me.colSevkAciklama.Caption = "SevkAciklama"
        Me.colSevkAciklama.FieldName = "SevkAciklama"
        Me.colSevkAciklama.Name = "colSevkAciklama"
        '
        'colKalanTaksit
        '
        Me.colKalanTaksit.Caption = "KalanTaksit"
        Me.colKalanTaksit.FieldName = "KalanTaksit"
        Me.colKalanTaksit.Name = "colKalanTaksit"
        '
        'colKayitTarihi
        '
        Me.colKayitTarihi.Caption = "Kayýt Tarihi"
        Me.colKayitTarihi.FieldName = "KayitTarihi"
        Me.colKayitTarihi.Name = "colKayitTarihi"
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Width = 55
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GridControl3)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl5.Location = New System.Drawing.Point(929, 2)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(268, 428)
        Me.PanelControl5.TabIndex = 1
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.ContextMenu3
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(264, 424)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ContextMenu3
        '
        Me.ContextMenu3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem30, Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41, Me.MenuItem42, Me.MenuItem43, Me.MenuItem44})
        '
        'MenuItem29
        '
        Me.MenuItem29.DefaultItem = True
        Me.MenuItem29.Index = 0
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem29.Text = "Tamam"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 1
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem30.Text = "Vazgeç"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 2
        Me.MenuItem32.Text = "-"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        Me.MenuItem33.Text = "Görünümü Düzenle"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 4
        Me.MenuItem34.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 5
        Me.MenuItem35.Text = "Görünümü Kaydet"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 6
        Me.MenuItem36.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem36.Text = "Görünümü Yazdýr"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 7
        Me.MenuItem37.Text = "-"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 8
        Me.MenuItem38.Text = "Filtrele"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 9
        Me.MenuItem39.Text = "Gruplandýr"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 10
        Me.MenuItem40.Text = "-"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 11
        Me.MenuItem41.Text = "Satýrlarý Aç"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 12
        Me.MenuItem42.Text = "Satýrlarý Kapat"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 13
        Me.MenuItem43.Text = "-"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 14
        Me.MenuItem44.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem44.Text = "Ekraný Kapla"
        '
        'GridView3
        '
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
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFis_TanimlamaNo, Me.colFis_Tipi, Me.colFis_Musteri_Tanimlama_No, Me.colFis_Musteri_Kodu, Me.colFis_Musteri_Adi, Me.colFis_Musteri_Soyadi, Me.colTaksit_Fis_TanimlamaNo, Me.colTaksit_Tarihi, Me.colTaksit_Tutari, Me.colAlisveris_TanimlamaNo, Me.colMusteri_Taksiti, Me.colOdeme_tutar})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(556, 305, 208, 170)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colMusteri_Taksiti
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "TaksitDetayi..."
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lToplamMiktar", Nothing, "{0:#,0.##} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lNetTutar", Nothing, "ToplamTutar : {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "Kalan  {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "Tutarý  : {0:#,0.00}")})
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsPrint.ExpandAllGroups = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowIndicator = False
        Me.GridView3.ViewCaption = "Satýþa Yapýlan Taksitler"
        '
        'colFis_TanimlamaNo
        '
        Me.colFis_TanimlamaNo.Caption = "Fiþ No"
        Me.colFis_TanimlamaNo.FieldName = "Fis_TanimlamaNo"
        Me.colFis_TanimlamaNo.Name = "colFis_TanimlamaNo"
        Me.colFis_TanimlamaNo.Width = 67
        '
        'colFis_Tipi
        '
        Me.colFis_Tipi.Caption = "Fiþ Tipi"
        Me.colFis_Tipi.FieldName = "Fis_Tipi"
        Me.colFis_Tipi.Name = "colFis_Tipi"
        Me.colFis_Tipi.Width = 34
        '
        'colFis_Musteri_Tanimlama_No
        '
        Me.colFis_Musteri_Tanimlama_No.Caption = "Müþteri No"
        Me.colFis_Musteri_Tanimlama_No.FieldName = "Fis_Musteri_Tanimlama_No"
        Me.colFis_Musteri_Tanimlama_No.Name = "colFis_Musteri_Tanimlama_No"
        '
        'colFis_Musteri_Kodu
        '
        Me.colFis_Musteri_Kodu.Caption = "Müþteri Kodu"
        Me.colFis_Musteri_Kodu.FieldName = "Fis_Musteri_Kodu"
        Me.colFis_Musteri_Kodu.Name = "colFis_Musteri_Kodu"
        Me.colFis_Musteri_Kodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fis_Musteri_Kodu", "{0} Kayýt")})
        Me.colFis_Musteri_Kodu.Width = 67
        '
        'colFis_Musteri_Adi
        '
        Me.colFis_Musteri_Adi.Caption = "Müþteri Adý"
        Me.colFis_Musteri_Adi.FieldName = "Fis_Musteri_Adi"
        Me.colFis_Musteri_Adi.Name = "colFis_Musteri_Adi"
        Me.colFis_Musteri_Adi.Width = 77
        '
        'colFis_Musteri_Soyadi
        '
        Me.colFis_Musteri_Soyadi.Caption = "MüþteriSoyadý"
        Me.colFis_Musteri_Soyadi.FieldName = "Fis_Musteri_Soyadi"
        Me.colFis_Musteri_Soyadi.Name = "colFis_Musteri_Soyadi"
        Me.colFis_Musteri_Soyadi.Width = 94
        '
        'colTaksit_Fis_TanimlamaNo
        '
        Me.colTaksit_Fis_TanimlamaNo.Caption = "TaksitFiþNo"
        Me.colTaksit_Fis_TanimlamaNo.FieldName = "Taksit_Fis_TanimlamaNo"
        Me.colTaksit_Fis_TanimlamaNo.Name = "colTaksit_Fis_TanimlamaNo"
        '
        'colTaksit_Tarihi
        '
        Me.colTaksit_Tarihi.Caption = "Tarih"
        Me.colTaksit_Tarihi.DisplayFormat.FormatString = "d"
        Me.colTaksit_Tarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTaksit_Tarihi.FieldName = "Taksit_Tarihi"
        Me.colTaksit_Tarihi.Name = "colTaksit_Tarihi"
        Me.colTaksit_Tarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", "{0} Kayýt")})
        Me.colTaksit_Tarihi.Visible = True
        Me.colTaksit_Tarihi.VisibleIndex = 0
        Me.colTaksit_Tarihi.Width = 64
        '
        'colTaksit_Tutari
        '
        Me.colTaksit_Tutari.Caption = "Tutar"
        Me.colTaksit_Tutari.DisplayFormat.FormatString = "#,0.00"
        Me.colTaksit_Tutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTaksit_Tutari.FieldName = "Taksit_Tutari"
        Me.colTaksit_Tutari.Name = "colTaksit_Tutari"
        Me.colTaksit_Tutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Taksit_Tutari", "{0:#,0.00}")})
        Me.colTaksit_Tutari.Visible = True
        Me.colTaksit_Tutari.VisibleIndex = 1
        Me.colTaksit_Tutari.Width = 52
        '
        'colAlisveris_TanimlamaNo
        '
        Me.colAlisveris_TanimlamaNo.Caption = "AlýþVeriþ No"
        Me.colAlisveris_TanimlamaNo.FieldName = "Alisveris_TanimlamaNo"
        Me.colAlisveris_TanimlamaNo.Name = "colAlisveris_TanimlamaNo"
        '
        'colOdeme_tutar
        '
        Me.colOdeme_tutar.Caption = "Ödenen"
        Me.colOdeme_tutar.DisplayFormat.FormatString = "#,0.00"
        Me.colOdeme_tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOdeme_tutar.FieldName = "Odeme_tutar"
        Me.colOdeme_tutar.Name = "colOdeme_tutar"
        Me.colOdeme_tutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odeme_tutar", "{0:#,0.00}")})
        Me.colOdeme_tutar.Visible = True
        Me.colOdeme_tutar.VisibleIndex = 2
        Me.colOdeme_tutar.Width = 53
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GridControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(444, 428)
        Me.PanelControl4.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(440, 424)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem16, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Faturayý Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 6
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 8
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 9
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 10
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 11
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 12
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 13
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 14
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 15
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "kodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TUTAR"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "TAHSILAT"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "KALAN"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "AY"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "YIL"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteTarihi"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sFisTipi"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "dteFaturaTarihi"
        Me.DataColumn10.DataType = GetType(Date)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lFaturaNo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lToplamMiktar"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lPesinat"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lNetTutar"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sYaziIle"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nKasaNo"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "dteKayitTarihi"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nAlisverisID"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sAdi"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sSoyadi"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.coldteFaturaTarihi, Me.colnGirisCikis, Me.collToplamMiktar, Me.collPesinat, Me.GridColumn2, Me.collFaturaNo, Me.colsMagaza, Me.colsKasiyerRumuzu, Me.colnKasaNo, Me.coldteKayitTarihi, Me.colsYaziIle, Me.colnAlisverisID, Me.colnAdiSoyadi, Me.colnOdeme_tutar, Me.colnMusteri_Taksiti})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 421, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Satislar..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.ViewCaption = "Sonradan Kredili Satýþlar"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ýzah"
        Me.GridColumn1.FieldName = "sAlisverisYapanAdi"
        Me.GridColumn1.FieldNameSortGroup = "AY"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 37
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.DisplayFormat.FormatString = "d"
        Me.coldteFaturaTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFaturaTarihi", "{0} Kayýt")})
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 56
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Belge Tipi"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Width = 44
        '
        'collToplamMiktar
        '
        Me.collToplamMiktar.Caption = "Miktar"
        Me.collToplamMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collToplamMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamMiktar.FieldName = "lToplamMiktar"
        Me.collToplamMiktar.Name = "collToplamMiktar"
        Me.collToplamMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamMiktar", "{0:#,0.00}")})
        Me.collToplamMiktar.Width = 81
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
        Me.collPesinat.VisibleIndex = 3
        Me.collPesinat.Width = 49
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tutar"
        Me.GridColumn2.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "lNetTutar"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 48
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "Fiþ No"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 2
        Me.collFaturaNo.Width = 38
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.Width = 46
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Width = 92
        '
        'colnKasaNo
        '
        Me.colnKasaNo.Caption = "KasaNo"
        Me.colnKasaNo.FieldName = "nKasaNo"
        Me.colnKasaNo.Name = "colnKasaNo"
        Me.colnKasaNo.Width = 104
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Saat"
        Me.coldteKayitTarihi.DisplayFormat.FormatString = "hh:mm"
        Me.coldteKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.Width = 108
        '
        'colsYaziIle
        '
        Me.colsYaziIle.Caption = "Yazýyla"
        Me.colsYaziIle.FieldName = "sYaziIle"
        Me.colsYaziIle.Name = "colsYaziIle"
        Me.colsYaziIle.Width = 199
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "Kayýt No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        '
        'colnAdiSoyadi
        '
        Me.colnAdiSoyadi.Caption = "Adý Soyadý"
        Me.colnAdiSoyadi.DisplayFormat.FormatString = "Numeric ""#,0.00"""
        Me.colnAdiSoyadi.FieldName = "sMusteriAdi"
        Me.colnAdiSoyadi.Name = "colnAdiSoyadi"
        Me.colnAdiSoyadi.Visible = True
        Me.colnAdiSoyadi.VisibleIndex = 0
        '
        'colnOdeme_tutar
        '
        Me.colnOdeme_tutar.Caption = "Ödenen"
        Me.colnOdeme_tutar.DisplayFormat.FormatString = "#,0.00"
        Me.colnOdeme_tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnOdeme_tutar.FieldName = "TAHSILAT"
        Me.colnOdeme_tutar.Name = "colnOdeme_tutar"
        Me.colnOdeme_tutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", "{0:#,0.00}")})
        Me.colnOdeme_tutar.Visible = True
        Me.colnOdeme_tutar.VisibleIndex = 5
        '
        'colnMusteri_Taksiti
        '
        Me.colnMusteri_Taksiti.Caption = "Kalan"
        Me.colnMusteri_Taksiti.DisplayFormat.FormatString = "#,0.00"
        Me.colnMusteri_Taksiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnMusteri_Taksiti.FieldName = "KALAN"
        Me.colnMusteri_Taksiti.Name = "colnMusteri_Taksiti"
        Me.colnMusteri_Taksiti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.00}")})
        Me.colnMusteri_Taksiti.Visible = True
        Me.colnMusteri_Taksiti.VisibleIndex = 6
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.printlink3})
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Açýk Faturalar", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.GridControl2
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.Owner = Nothing
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Stok Detayý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'printlink3
        '
        Me.printlink3.Component = Me.GridControl3
        '
        '
        '
        Me.printlink3.ImageCollection.ImageStream = CType(resources.GetObject("printlink3.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink3.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink3.Owner = Nothing
        Me.printlink3.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Taksit Detayý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink3.PrintingSystem = Me.ps
        Me.printlink3.PrintingSystemBase = Me.ps
        '
        'ds_detay
        '
        Me.ds_detay.DataSetName = "NewDataSet"
        Me.ds_detay.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_detay.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "lKodu"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "lMusteriAdi"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "dteTarih"
        Me.DataColumn23.DataType = GetType(Date)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sFisTipi"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "lNo"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sKodu"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sAciklama"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Miktar"
        Me.DataColumn28.DataType = GetType(Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "Fiyat"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "Iskonto"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "lNetTutar"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "OdemeTutar"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "OdemeTipi"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "SaticiRumuzu"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "KasiyerRumuzu"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Teslimatci"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "OdemeAciklama"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "GirisCikis"
        Me.DataColumn38.DataType = GetType(Long)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "MalBedeli"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "IadeAvInf"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "sHareketTipi"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "nIslemId"
        Me.DataColumn42.DataType = GetType(Long)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "StokOdeme"
        Me.DataColumn43.DataType = GetType(Long)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "SevkAciklama"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "KalanTaksit"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "KayitTarihi"
        Me.DataColumn46.DataType = GetType(Date)
        '
        'ds_kapatma
        '
        Me.ds_kapatma.DataSetName = "NewDataSet"
        Me.ds_kapatma.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kapatma.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "Fis_TanimlamaNo"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "Fis_Tipi"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "Fis_Musteri_Tanimlama_No"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "Fis_Musteri_Kodu"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "Fis_Musteri_Adi"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "Fis_Musteri_Soyadi"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "Taksit_Fis_TanimlamaNo"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "Taksit_Tarihi"
        Me.DataColumn54.DataType = GetType(Date)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "Taksit_Tutari"
        Me.DataColumn55.DataType = GetType(Decimal)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "Alisveris_TanimlamaNo"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "Musteri_Taksiti"
        Me.DataColumn57.DataType = GetType(Decimal)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "Odeme_tutar"
        Me.DataColumn58.DataType = GetType(Decimal)
        '
        'Frm_SKKontrol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1199, 575)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_SKKontrol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teslimat Yapýlan Ödeme Raporu"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.sec_sTarihTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kapatma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public musteriID
    Public kullanici
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tarih1.EditValue = dteSistemTarihi
        tarih2.EditValue = dteSistemTarihi
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload(tarih1.EditValue, tarih2.EditValue)
    End Sub

    Public Function sorgu_satislar_detayli(ByVal musterino As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbAlisverisSiparis ON tbAlisVeris.nAlisverisID = tbAlisverisSiparis.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID like '%') and tbAlisVeris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND tbAlisverisSiparis.bTeslimEdildi = '1' GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID like '%') and tbAlisVeris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND tbAlisveris.bTeslimEdildi = '1' GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
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
        ekran_kapla()
    End Sub
    Private Sub ekran_kapla()
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
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Satis")
        GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Detay")
        GridView3.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Tahsilat")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Satis")
        GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Detay")
        GridView3.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Tahsilat")
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
    Public Function stok() As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function satis_detay(ByVal fistipi As String, ByVal stokno As String) As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim sorgu As Boolean
        If fistipi = "K" Then
            sorgu = True
        ElseIf fistipi = "P" Then
            sorgu = True
        ElseIf fistipi = "Ks" Then
            sorgu = True
        ElseIf fistipi = "PD" Then
            sorgu = True
        ElseIf fistipi = "PTX" Then
            sorgu = True
        Else
            sorgu = False
        End If
        If sorgu = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID,tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi,tbStokFisiDetayi.sFiyatTipi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisVeris.nAlisverisID ='" & Trim(stokno) & "'")
        ElseIf sorgu = False Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID,tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lBrutTutar AS lNetTutar, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisverisSiparis.sIadeNedeni AS IadeAvInf, tbAlisverisSiparis.dteTeslimEdilecek AS Termin, tbAlisverisSiparis.dteTeslimEdilen AS Teslimat, tbAlisverisSiparis.bTeslimEdildi AS TeslimEdildi, tbAlisverisSiparis.dteOnayTarihi AS Onay, tbAlisVeris.sMagaza, tbStok.sRenk FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE  tbAlisVeris.nAlisverisID ='" & Trim(stokno) & "'")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function satis_kapatma(ByVal belgeno As String) As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dbo.tbMusteri.nMusteriID AS Fis_TanimlamaNo, dbo.tbAlisVeris.sFisTipi AS Fis_Tipi, dbo.tbMusteri.nMusteriID AS Fis_Musteri_Tanimlama_No, dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu, dbo.tbMusteri.sAdi AS Fis_Musteri_Adi, dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi, dbo.tbTaksit.nTaksitID AS Taksit_Fis_TanimlamaNo, dbo.tbTaksit.dteTarihi AS Taksit_Tarihi, dbo.tbTaksit.lTutari AS Taksit_Tutari, SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Odeme_tutar, dbo.tbAlisVeris.nAlisverisID AS Alisveris_TanimlamaNo, dbo.tbTaksit.lTutari - SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Musteri_Taksiti FROM dbo.tbOdeme RIGHT OUTER JOIN dbo.tbTaksit INNER JOIN dbo.tbAlisVeris ON dbo.tbTaksit.nAlisverisID = dbo.tbAlisVeris.nAlisverisID INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbOdeme.nTaksitID = dbo.tbTaksit.nTaksitID where tbAlisveris.nAlisverisID ='" & belgeno & "' GROUP BY dbo.tbMusteri.nMusteriID, dbo.tbAlisVeris.sFisTipi, dbo.tbMusteri.lKodu, dbo.tbMusteri.sAdi, dbo.tbMusteri.sSoyadi, dbo.tbTaksit.nTaksitID, dbo.tbTaksit.dteTarihi, dbo.tbTaksit.lTutari, dbo.tbAlisVeris.nAlisverisID ")
        cmd.Connection = conn
        conn.Open()
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Dim kriter As String = ""
        If sec_sTarihTipi.SelectedIndex = 0 Then
            kriter += " Where tbAlisVeris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        ElseIf sec_sTarihTipi.SelectedIndex = 1 Then
            tarih1 = Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00"
            tarih2 = Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59"
            kriter += " Where tbAlisVeris.dteKayitTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        End If
        DataSet1 = sorgu_satislar_detayli(musteriID, tarih1, tarih2)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub dataload_detay()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_detay = satis_detay(Trim(dr("sFistipi").ToString), dr("nAlisVerisID"))
            ds_kapatma = satis_kapatma(dr("nAlisVerisID"))
            GridControl2.DataSource = ds_detay.Tables(0)
            GridControl2.DataMember = Nothing
            GridControl3.DataSource = ds_kapatma.Tables(0)
            GridControl3.DataMember = Nothing
            PanelControl3.Select()
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.CollapseAllGroups()
            dr = Nothing
        End If
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        stok_satis_detay()
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        dataload_detay()
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        GridView3.ColumnsCustomization()
    End Sub
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        printlink3.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView3.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        GridView3.OptionsView.ShowGroupPanel = True
        GridView3.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        GridView3.ExpandAllGroups()
    End Sub
    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        GridView3.CollapseAllGroups()
    End Sub
    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        ekran_kapla()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        Me.Close()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Me.Close()
    End Sub
    Private Sub analiz_envanter()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        printlink2.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView2.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        GridView2.OptionsView.ShowGroupPanel = True
        GridView2.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Frm_SKKontrol_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label2 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        ''DataSet1.Clear()
        ''DataSet1.Dispose()
        'DataSet1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem13 = Nothing
        'MenuItem14 = Nothing
        'MenuItem15 = Nothing
        'ps = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn7 = Nothing
        'DataColumn8 = Nothing
        'DataColumn9 = Nothing
        'DataColumn10 = Nothing
        'DataColumn11 = Nothing
        'DataColumn12 = Nothing
        'DataColumn13 = Nothing
        'DataColumn14 = Nothing
        'DataColumn15 = Nothing
        'DataColumn16 = Nothing
        'DataColumn17 = Nothing
        'DataColumn18 = Nothing
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'printlink1 = Nothing
        'MenuItem16 = Nothing
        'PanelControl4 = Nothing
        'PanelControl5 = Nothing
        'PanelControl6 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'GridControl2 = Nothing
        'GridView2 = Nothing
        'GridControl3 = Nothing
        'GridView3 = Nothing
        'ds_detay.Clear()
        'ds_detay.Dispose()
        'ds_detay = Nothing
        'DataTable2 = Nothing
        'DataColumn21 = Nothing
        'DataColumn22 = Nothing
        'DataColumn23 = Nothing
        'DataColumn24 = Nothing
        'DataColumn25 = Nothing
        'DataColumn26 = Nothing
        'DataColumn27 = Nothing
        'DataColumn28 = Nothing
        'DataColumn29 = Nothing
        'DataColumn30 = Nothing
        'DataColumn31 = Nothing
        'DataColumn32 = Nothing
        'DataColumn33 = Nothing
        'DataColumn34 = Nothing
        'DataColumn35 = Nothing
        'DataColumn36 = Nothing
        'DataColumn37 = Nothing
        'DataColumn38 = Nothing
        'DataColumn39 = Nothing
        'DataColumn40 = Nothing
        'DataColumn41 = Nothing
        'DataColumn42 = Nothing
        'DataColumn43 = Nothing
        'DataColumn44 = Nothing
        'DataColumn45 = Nothing
        'DataColumn46 = Nothing
        'ds_kapatma.Clear()
        'ds_kapatma.Dispose()
        'ds_kapatma = Nothing
        'DataTable3 = Nothing
        'DataColumn47 = Nothing
        'DataColumn48 = Nothing
        'DataColumn49 = Nothing
        'DataColumn50 = Nothing
        'DataColumn51 = Nothing
        'DataColumn52 = Nothing
        'DataColumn53 = Nothing
        'DataColumn54 = Nothing
        'DataColumn55 = Nothing
        'DataColumn56 = Nothing
        'DataColumn57 = Nothing
        'DataColumn58 = Nothing
        'colFis_TanimlamaNo = Nothing
        'colFis_Tipi = Nothing
        'colFis_Musteri_Tanimlama_No = Nothing
        'colFis_Musteri_Kodu = Nothing
        'colFis_Musteri_Adi = Nothing
        'colFis_Musteri_Soyadi = Nothing
        'colTaksit_Fis_TanimlamaNo = Nothing
        'colTaksit_Tarihi = Nothing
        'colTaksit_Tutari = Nothing
        'colAlisveris_TanimlamaNo = Nothing
        'colMusteri_Taksiti = Nothing
        'colOdeme_tutar = Nothing
        'collKodu = Nothing
        'collMusteriAdi = Nothing
        'coldteTarih = Nothing
        'colsFisTipi = Nothing
        'collNo = Nothing
        'colsKodu = Nothing
        'colsAciklama = Nothing
        'colMiktar = Nothing
        'colFiyat = Nothing
        'colIskonto = Nothing
        'collNetTutar = Nothing
        'colOdemeTutar = Nothing
        'colOdemeTipi = Nothing
        'colSaticiRumuzu = Nothing
        'colKasiyerRumuzu = Nothing
        'colTeslimatci = Nothing
        'colOdemeAciklama = Nothing
        'colGirisCikis = Nothing
        'colMalBedeli = Nothing
        'colIadeAvInf = Nothing
        'colsHareketTipi = Nothing
        'colnIslemId = Nothing
        'colStokOdeme = Nothing
        'colSevkAciklama = Nothing
        'colKalanTaksit = Nothing
        'colKayitTarihi = Nothing
        'colsFiyatTipi = Nothing
        'GridColumn1 = Nothing
        'coldteFaturaTarihi = Nothing
        'colnGirisCikis = Nothing
        'collToplamMiktar = Nothing
        'collPesinat = Nothing
        'GridColumn2 = Nothing
        'collFaturaNo = Nothing
        'colsMagaza = Nothing
        'colsKasiyerRumuzu = Nothing
        'colnKasaNo = Nothing
        'coldteKayitTarihi = Nothing
        'colsYaziIle = Nothing
        'colnAlisverisID = Nothing
        'printlink2 = Nothing
        'printlink3 = Nothing
        'ContextMenu2 = Nothing
        'MenuItem17 = Nothing
        'MenuItem18 = Nothing
        'MenuItem20 = Nothing
        'MenuItem21 = Nothing
        'MenuItem22 = Nothing
        'MenuItem23 = Nothing
        'MenuItem24 = Nothing
        'MenuItem25 = Nothing
        'MenuItem26 = Nothing
        'MenuItem27 = Nothing
        'MenuItem28 = Nothing
        'ContextMenu3 = Nothing
        'MenuItem29 = Nothing
        'MenuItem30 = Nothing
        'MenuItem32 = Nothing
        'MenuItem33 = Nothing
        'MenuItem34 = Nothing
        'MenuItem35 = Nothing
        'MenuItem36 = Nothing
        'MenuItem37 = Nothing
        'MenuItem38 = Nothing
        'MenuItem39 = Nothing
        'MenuItem40 = Nothing
        'MenuItem41 = Nothing
        'MenuItem42 = Nothing
        'MenuItem43 = Nothing
        'MenuItem44 = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        ara()
    End Sub
    Private Sub ara()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim satir = GridView1.FocusedRowHandle
        dataload(tarih1.EditValue, tarih2.EditValue)
        GridView1.FocusedRowHandle = satir
        satir = Nothing
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
End Class

