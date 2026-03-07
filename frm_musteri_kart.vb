Imports FastReport
Imports System.IO
Imports DevExpress.XtraEditors
Public Class frm_musteri_kart
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit57 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit58 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit60 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit61 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl75 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit62 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit63 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit64 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl76 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl77 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit66 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl78 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit67 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl79 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl80 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit68 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit69 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit70 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl81 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl82 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit3 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl83 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit71 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl84 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl85 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit72 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit73 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl86 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl87 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_tbMusteri As System.Data.DataSet
    Friend WithEvents ds_tbMusteriSinifi As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents ds_tbMusteriKarti As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colnMusteriID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSonKullanmaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage10 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage11 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ds_tbMusteriKredisi As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents GroupControl11 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl88 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl89 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl90 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl91 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSatisYapilamaz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_tbMusteriEkKart As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
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
    Friend WithEvents ds_tbMusteriCocugu As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCinsiyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteDogumTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDogumYeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOzelNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_tbMusteriOzelNot As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents colnMusteriID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteGirisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_bYazismaEvAdresinemi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_sKanGrubu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEhliyetNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nIskontoPesin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nIskontoKredili As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_lAylikGelir As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_sVergiNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sVergiDairesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sDogumYeri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_dteDogumTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_nCinsiyet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sMagaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_dteEvlilikTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_bEvlimi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_sSoyadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsTelefonu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsPostaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsAdres2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_IsAdres1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsyeriAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvPostaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvTelefonu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvAdres2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvAdresi1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sFaks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sGSM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataTable7 As System.Data.DataTable
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
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents DataColumn98 As System.Data.DataColumn
    Friend WithEvents DataColumn99 As System.Data.DataColumn
    Friend WithEvents DataColumn100 As System.Data.DataColumn
    Friend WithEvents DataColumn101 As System.Data.DataColumn
    Friend WithEvents ds_tbMusteriNufusu As System.Data.DataSet
    Friend WithEvents DataTable8 As System.Data.DataTable
    Friend WithEvents DataColumn102 As System.Data.DataColumn
    Friend WithEvents DataColumn103 As System.Data.DataColumn
    Friend WithEvents DataColumn104 As System.Data.DataColumn
    Friend WithEvents DataColumn105 As System.Data.DataColumn
    Friend WithEvents DataColumn106 As System.Data.DataColumn
    Friend WithEvents DataColumn107 As System.Data.DataColumn
    Friend WithEvents DataColumn108 As System.Data.DataColumn
    Friend WithEvents DataColumn109 As System.Data.DataColumn
    Friend WithEvents DataColumn110 As System.Data.DataColumn
    Friend WithEvents DataColumn111 As System.Data.DataColumn
    Friend WithEvents DataColumn112 As System.Data.DataColumn
    Friend WithEvents DataColumn113 As System.Data.DataColumn
    Friend WithEvents DataColumn114 As System.Data.DataColumn
    Friend WithEvents DataColumn115 As System.Data.DataColumn
    Friend WithEvents DataColumn116 As System.Data.DataColumn
    Friend WithEvents DataColumn117 As System.Data.DataColumn
    Friend WithEvents DataColumn118 As System.Data.DataColumn
    Friend WithEvents DataColumn119 As System.Data.DataColumn
    Friend WithEvents DataColumn120 As System.Data.DataColumn
    Friend WithEvents DataColumn121 As System.Data.DataColumn
    Friend WithEvents DataColumn122 As System.Data.DataColumn
    Friend WithEvents ds_tbMusteriKefil1 As System.Data.DataSet
    Friend WithEvents DataTable9 As System.Data.DataTable
    Friend WithEvents DataColumn123 As System.Data.DataColumn
    Friend WithEvents DataColumn124 As System.Data.DataColumn
    Friend WithEvents DataColumn125 As System.Data.DataColumn
    Friend WithEvents DataColumn126 As System.Data.DataColumn
    Friend WithEvents DataColumn127 As System.Data.DataColumn
    Friend WithEvents DataColumn128 As System.Data.DataColumn
    Friend WithEvents DataColumn129 As System.Data.DataColumn
    Friend WithEvents DataColumn130 As System.Data.DataColumn
    Friend WithEvents DataColumn131 As System.Data.DataColumn
    Friend WithEvents DataColumn132 As System.Data.DataColumn
    Friend WithEvents DataColumn133 As System.Data.DataColumn
    Friend WithEvents DataColumn134 As System.Data.DataColumn
    Friend WithEvents DataColumn135 As System.Data.DataColumn
    Friend WithEvents DataColumn136 As System.Data.DataColumn
    Friend WithEvents DataColumn137 As System.Data.DataColumn
    Friend WithEvents DataColumn138 As System.Data.DataColumn
    Friend WithEvents DataColumn139 As System.Data.DataColumn
    Friend WithEvents DataColumn140 As System.Data.DataColumn
    Friend WithEvents DataColumn141 As System.Data.DataColumn
    Friend WithEvents DataColumn142 As System.Data.DataColumn
    Friend WithEvents DataColumn143 As System.Data.DataColumn
    Friend WithEvents DataColumn144 As System.Data.DataColumn
    Friend WithEvents DataColumn145 As System.Data.DataColumn
    Friend WithEvents DataTable10 As System.Data.DataTable
    Friend WithEvents DataColumn146 As System.Data.DataColumn
    Friend WithEvents DataColumn147 As System.Data.DataColumn
    Friend WithEvents DataColumn148 As System.Data.DataColumn
    Friend WithEvents DataColumn149 As System.Data.DataColumn
    Friend WithEvents DataColumn150 As System.Data.DataColumn
    Friend WithEvents DataColumn151 As System.Data.DataColumn
    Friend WithEvents DataColumn152 As System.Data.DataColumn
    Friend WithEvents DataColumn153 As System.Data.DataColumn
    Friend WithEvents DataColumn154 As System.Data.DataColumn
    Friend WithEvents DataColumn155 As System.Data.DataColumn
    Friend WithEvents DataColumn156 As System.Data.DataColumn
    Friend WithEvents DataColumn157 As System.Data.DataColumn
    Friend WithEvents DataColumn158 As System.Data.DataColumn
    Friend WithEvents DataColumn159 As System.Data.DataColumn
    Friend WithEvents DataColumn160 As System.Data.DataColumn
    Friend WithEvents DataColumn161 As System.Data.DataColumn
    Friend WithEvents DataColumn162 As System.Data.DataColumn
    Friend WithEvents DataColumn163 As System.Data.DataColumn
    Friend WithEvents DataColumn164 As System.Data.DataColumn
    Friend WithEvents DataColumn165 As System.Data.DataColumn
    Friend WithEvents DataColumn166 As System.Data.DataColumn
    Friend WithEvents DataColumn167 As System.Data.DataColumn
    Friend WithEvents DataColumn168 As System.Data.DataColumn
    Friend WithEvents ds_tbMusteriKefil2 As System.Data.DataSet
    Friend WithEvents GroupControl12 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_sAileTelefonu As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_sSigortaNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAilePostaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAileSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAileAdresi2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAileAdresi1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sCuzdanKayitNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sCuzdanVerNedeni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sCuzdanVerilenYer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteNufusCuzdanTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukSiraNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukCiltNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukMahalle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukIlce As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukIl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAnneAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sBabaAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sUnvan1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sUnvan3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sHitap1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sHitap2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sHitap3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sHitap5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sSinifKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txt_bOzelMustrimi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_dteSonKullanmaTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_dteKrediAcilisTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_dteKrediLimitiTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_llimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_tbMusteriKarti_sKartNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents sec_tbMusteriKarti_sAciklama As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnEkKartID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsYeriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsAdresi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsAdresi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsPostaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsIl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvPostaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvIl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAylikGelir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSigortaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHitap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kisayol_KartNo As System.Windows.Forms.ContextMenu
    Friend WithEvents kisayol_EkKart As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_cocuk As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_OzelNot As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl93 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_ReferansSec As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbl_Referans As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage12 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ds_tbMusteriResim As System.Data.DataSet
    Friend WithEvents DataTable11 As System.Data.DataTable
    Friend WithEvents DataColumn169 As System.Data.DataColumn
    Friend WithEvents DataColumn170 As System.Data.DataColumn
    Friend WithEvents DataColumn171 As System.Data.DataColumn
    Friend WithEvents DataColumn172 As System.Data.DataColumn
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpResim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtekayitTarihi3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sec_pResim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents DataColumn173 As System.Data.DataColumn
    Friend WithEvents DataColumn174 As System.Data.DataColumn
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn175 As System.Data.DataColumn
    Friend WithEvents colnSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_sIsIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sEvIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sAileIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sKefil2EvIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sKefil2IsIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sSiniflar As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_bMusteriAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn176 As System.Data.DataColumn
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_sKefil1IsIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit56 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit49 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit50 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit52 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit53 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit54 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit55 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_sKefil1EvIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit44 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit45 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit46 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit47 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit48 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_sHitap4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sUnvan2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit42 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit39 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit41 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage13 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage14 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl13 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ds_tbMusteriKefil3 As System.Data.DataSet
    Friend WithEvents DataTable12 As System.Data.DataTable
    Friend WithEvents DataColumn177 As System.Data.DataColumn
    Friend WithEvents DataColumn178 As System.Data.DataColumn
    Friend WithEvents DataColumn179 As System.Data.DataColumn
    Friend WithEvents DataColumn180 As System.Data.DataColumn
    Friend WithEvents DataColumn181 As System.Data.DataColumn
    Friend WithEvents DataColumn182 As System.Data.DataColumn
    Friend WithEvents DataColumn183 As System.Data.DataColumn
    Friend WithEvents DataColumn184 As System.Data.DataColumn
    Friend WithEvents DataColumn185 As System.Data.DataColumn
    Friend WithEvents DataColumn186 As System.Data.DataColumn
    Friend WithEvents DataColumn187 As System.Data.DataColumn
    Friend WithEvents DataColumn188 As System.Data.DataColumn
    Friend WithEvents DataColumn189 As System.Data.DataColumn
    Friend WithEvents DataColumn190 As System.Data.DataColumn
    Friend WithEvents DataColumn191 As System.Data.DataColumn
    Friend WithEvents DataColumn192 As System.Data.DataColumn
    Friend WithEvents DataColumn193 As System.Data.DataColumn
    Friend WithEvents DataColumn194 As System.Data.DataColumn
    Friend WithEvents DataColumn195 As System.Data.DataColumn
    Friend WithEvents DataColumn196 As System.Data.DataColumn
    Friend WithEvents DataColumn197 As System.Data.DataColumn
    Friend WithEvents DataColumn198 As System.Data.DataColumn
    Friend WithEvents DataColumn199 As System.Data.DataColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl94 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl95 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl96 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl97 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl98 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl99 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl100 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl14 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl101 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl102 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl103 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl104 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl105 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl15 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl106 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl107 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl108 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl109 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl110 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl111 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl16 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LookUpEdit5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl112 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl113 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl114 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl115 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl116 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl117 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl118 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl17 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LookUpEdit6 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl119 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl120 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit24 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl121 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl122 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit25 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit26 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit27 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl123 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl18 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit7 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit8 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl124 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit4 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl125 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit28 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl126 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl127 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit29 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit30 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl128 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl129 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_tbMusteriKefil4 As System.Data.DataSet
    Friend WithEvents DataTable13 As System.Data.DataTable
    Friend WithEvents DataColumn200 As System.Data.DataColumn
    Friend WithEvents DataColumn201 As System.Data.DataColumn
    Friend WithEvents DataColumn202 As System.Data.DataColumn
    Friend WithEvents DataColumn203 As System.Data.DataColumn
    Friend WithEvents DataColumn204 As System.Data.DataColumn
    Friend WithEvents DataColumn205 As System.Data.DataColumn
    Friend WithEvents DataColumn206 As System.Data.DataColumn
    Friend WithEvents DataColumn207 As System.Data.DataColumn
    Friend WithEvents DataColumn208 As System.Data.DataColumn
    Friend WithEvents DataColumn209 As System.Data.DataColumn
    Friend WithEvents DataColumn210 As System.Data.DataColumn
    Friend WithEvents DataColumn211 As System.Data.DataColumn
    Friend WithEvents DataColumn212 As System.Data.DataColumn
    Friend WithEvents DataColumn213 As System.Data.DataColumn
    Friend WithEvents DataColumn214 As System.Data.DataColumn
    Friend WithEvents DataColumn215 As System.Data.DataColumn
    Friend WithEvents DataColumn216 As System.Data.DataColumn
    Friend WithEvents DataColumn217 As System.Data.DataColumn
    Friend WithEvents DataColumn218 As System.Data.DataColumn
    Friend WithEvents DataColumn219 As System.Data.DataColumn
    Friend WithEvents DataColumn220 As System.Data.DataColumn
    Friend WithEvents DataColumn221 As System.Data.DataColumn
    Friend WithEvents DataColumn222 As System.Data.DataColumn
    Friend WithEvents txt_sSeriNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn223 As System.Data.DataColumn
    Friend WithEvents LabelControl130 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit31 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn224 As System.Data.DataColumn
    Friend WithEvents LabelControl131 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_tbMusteriCocugu_nCinsiyet As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_kart))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_bMusteriAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.ds_tbMusteri = New System.Data.DataSet()
        Me.DataTable7 = New System.Data.DataTable()
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
        Me.DataColumn89 = New System.Data.DataColumn()
        Me.DataColumn90 = New System.Data.DataColumn()
        Me.DataColumn91 = New System.Data.DataColumn()
        Me.DataColumn92 = New System.Data.DataColumn()
        Me.DataColumn93 = New System.Data.DataColumn()
        Me.DataColumn94 = New System.Data.DataColumn()
        Me.DataColumn95 = New System.Data.DataColumn()
        Me.DataColumn96 = New System.Data.DataColumn()
        Me.DataColumn97 = New System.Data.DataColumn()
        Me.DataColumn98 = New System.Data.DataColumn()
        Me.DataColumn99 = New System.Data.DataColumn()
        Me.DataColumn100 = New System.Data.DataColumn()
        Me.DataColumn101 = New System.Data.DataColumn()
        Me.DataColumn176 = New System.Data.DataColumn()
        Me.lbl_Referans = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl93 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_ReferansSec = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_sHitap1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sUnvan1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_bYazismaEvAdresinemi = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKanGrubu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sEhliyetNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nIskontoPesin = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nIskontoKredili = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lAylikGelir = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sVergiNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sVergiDairesi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sDogumYeri = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteDogumTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nCinsiyet = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sMagaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_dteEvlilikTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_bEvlimi = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSoyadi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sIsIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sIsTelefonu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sIsPostaKodu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sIsSemt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sIsAdres2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_IsAdres1 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sIsyeriAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sEvIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sEvPostaKodu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sEvSemt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sEvTelefonu = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sEvAdres2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sEvAdresi1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sFaks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sGSM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl12 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit31 = New DevExpress.XtraEditors.TextEdit()
        Me.ds_tbMusteriNufusu = New System.Data.DataSet()
        Me.DataTable8 = New System.Data.DataTable()
        Me.DataColumn102 = New System.Data.DataColumn()
        Me.DataColumn103 = New System.Data.DataColumn()
        Me.DataColumn104 = New System.Data.DataColumn()
        Me.DataColumn105 = New System.Data.DataColumn()
        Me.DataColumn106 = New System.Data.DataColumn()
        Me.DataColumn107 = New System.Data.DataColumn()
        Me.DataColumn108 = New System.Data.DataColumn()
        Me.DataColumn109 = New System.Data.DataColumn()
        Me.DataColumn110 = New System.Data.DataColumn()
        Me.DataColumn111 = New System.Data.DataColumn()
        Me.DataColumn112 = New System.Data.DataColumn()
        Me.DataColumn113 = New System.Data.DataColumn()
        Me.DataColumn114 = New System.Data.DataColumn()
        Me.DataColumn115 = New System.Data.DataColumn()
        Me.DataColumn116 = New System.Data.DataColumn()
        Me.DataColumn117 = New System.Data.DataColumn()
        Me.DataColumn118 = New System.Data.DataColumn()
        Me.DataColumn119 = New System.Data.DataColumn()
        Me.DataColumn120 = New System.Data.DataColumn()
        Me.DataColumn121 = New System.Data.DataColumn()
        Me.DataColumn122 = New System.Data.DataColumn()
        Me.DataColumn223 = New System.Data.DataColumn()
        Me.DataColumn224 = New System.Data.DataColumn()
        Me.LabelControl131 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSeriNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl130 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAileIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sHitap3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sHitap2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sAileTelefonu = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_sSigortaNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAilePostaKodu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAileSemt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAileAdresi2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sAileAdresi1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sCuzdanKayitNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sCuzdanVerNedeni = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sCuzdanVerilenYer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteNufusCuzdanTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKutukSiraNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKutukCiltNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKutukMahalle = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKutukIlce = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKutukIl = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAnneAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sBabaAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sKefil1IsIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.ds_tbMusteriKefil1 = New System.Data.DataSet()
        Me.DataTable9 = New System.Data.DataTable()
        Me.DataColumn123 = New System.Data.DataColumn()
        Me.DataColumn124 = New System.Data.DataColumn()
        Me.DataColumn125 = New System.Data.DataColumn()
        Me.DataColumn126 = New System.Data.DataColumn()
        Me.DataColumn127 = New System.Data.DataColumn()
        Me.DataColumn128 = New System.Data.DataColumn()
        Me.DataColumn129 = New System.Data.DataColumn()
        Me.DataColumn130 = New System.Data.DataColumn()
        Me.DataColumn131 = New System.Data.DataColumn()
        Me.DataColumn132 = New System.Data.DataColumn()
        Me.DataColumn133 = New System.Data.DataColumn()
        Me.DataColumn134 = New System.Data.DataColumn()
        Me.DataColumn135 = New System.Data.DataColumn()
        Me.DataColumn136 = New System.Data.DataColumn()
        Me.DataColumn137 = New System.Data.DataColumn()
        Me.DataColumn138 = New System.Data.DataColumn()
        Me.DataColumn139 = New System.Data.DataColumn()
        Me.DataColumn140 = New System.Data.DataColumn()
        Me.DataColumn141 = New System.Data.DataColumn()
        Me.DataColumn142 = New System.Data.DataColumn()
        Me.DataColumn143 = New System.Data.DataColumn()
        Me.DataColumn144 = New System.Data.DataColumn()
        Me.DataColumn145 = New System.Data.DataColumn()
        Me.TextEdit56 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit49 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit50 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit52 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit53 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit54 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit55 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sKefil1EvIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit44 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit45 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit46 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit47 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit48 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_sHitap4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sUnvan2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.CalcEdit2 = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit42 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit39 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit41 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sKefil2IsIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.ds_tbMusteriKefil2 = New System.Data.DataSet()
        Me.DataTable10 = New System.Data.DataTable()
        Me.DataColumn146 = New System.Data.DataColumn()
        Me.DataColumn147 = New System.Data.DataColumn()
        Me.DataColumn148 = New System.Data.DataColumn()
        Me.DataColumn149 = New System.Data.DataColumn()
        Me.DataColumn150 = New System.Data.DataColumn()
        Me.DataColumn151 = New System.Data.DataColumn()
        Me.DataColumn152 = New System.Data.DataColumn()
        Me.DataColumn153 = New System.Data.DataColumn()
        Me.DataColumn154 = New System.Data.DataColumn()
        Me.DataColumn155 = New System.Data.DataColumn()
        Me.DataColumn156 = New System.Data.DataColumn()
        Me.DataColumn157 = New System.Data.DataColumn()
        Me.DataColumn158 = New System.Data.DataColumn()
        Me.DataColumn159 = New System.Data.DataColumn()
        Me.DataColumn160 = New System.Data.DataColumn()
        Me.DataColumn161 = New System.Data.DataColumn()
        Me.DataColumn162 = New System.Data.DataColumn()
        Me.DataColumn163 = New System.Data.DataColumn()
        Me.DataColumn164 = New System.Data.DataColumn()
        Me.DataColumn165 = New System.Data.DataColumn()
        Me.DataColumn166 = New System.Data.DataColumn()
        Me.DataColumn167 = New System.Data.DataColumn()
        Me.DataColumn168 = New System.Data.DataColumn()
        Me.TextEdit57 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit58 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit60 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit61 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl75 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit62 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit63 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit64 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl76 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sKefil2EvIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl77 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit66 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl78 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit67 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl79 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl80 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit68 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit69 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit70 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl81 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_sHitap5 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sUnvan3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl82 = New DevExpress.XtraEditors.LabelControl()
        Me.CalcEdit3 = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl83 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit71 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl84 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl85 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit72 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit73 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl86 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl87 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage13 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl13 = New DevExpress.XtraEditors.GroupControl()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ds_tbMusteriKefil3 = New System.Data.DataSet()
        Me.DataTable12 = New System.Data.DataTable()
        Me.DataColumn177 = New System.Data.DataColumn()
        Me.DataColumn178 = New System.Data.DataColumn()
        Me.DataColumn179 = New System.Data.DataColumn()
        Me.DataColumn180 = New System.Data.DataColumn()
        Me.DataColumn181 = New System.Data.DataColumn()
        Me.DataColumn182 = New System.Data.DataColumn()
        Me.DataColumn183 = New System.Data.DataColumn()
        Me.DataColumn184 = New System.Data.DataColumn()
        Me.DataColumn185 = New System.Data.DataColumn()
        Me.DataColumn186 = New System.Data.DataColumn()
        Me.DataColumn187 = New System.Data.DataColumn()
        Me.DataColumn188 = New System.Data.DataColumn()
        Me.DataColumn189 = New System.Data.DataColumn()
        Me.DataColumn190 = New System.Data.DataColumn()
        Me.DataColumn191 = New System.Data.DataColumn()
        Me.DataColumn192 = New System.Data.DataColumn()
        Me.DataColumn193 = New System.Data.DataColumn()
        Me.DataColumn194 = New System.Data.DataColumn()
        Me.DataColumn195 = New System.Data.DataColumn()
        Me.DataColumn196 = New System.Data.DataColumn()
        Me.DataColumn197 = New System.Data.DataColumn()
        Me.DataColumn198 = New System.Data.DataColumn()
        Me.DataColumn199 = New System.Data.DataColumn()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl94 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl95 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl96 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl97 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl98 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl99 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl100 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl14 = New DevExpress.XtraEditors.GroupControl()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl101 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl102 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl103 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl104 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl105 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl15 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl106 = New DevExpress.XtraEditors.LabelControl()
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl107 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl108 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl109 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl110 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl111 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage14 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl16 = New DevExpress.XtraEditors.GroupControl()
        Me.LookUpEdit5 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ds_tbMusteriKefil4 = New System.Data.DataSet()
        Me.DataTable13 = New System.Data.DataTable()
        Me.DataColumn200 = New System.Data.DataColumn()
        Me.DataColumn201 = New System.Data.DataColumn()
        Me.DataColumn202 = New System.Data.DataColumn()
        Me.DataColumn203 = New System.Data.DataColumn()
        Me.DataColumn204 = New System.Data.DataColumn()
        Me.DataColumn205 = New System.Data.DataColumn()
        Me.DataColumn206 = New System.Data.DataColumn()
        Me.DataColumn207 = New System.Data.DataColumn()
        Me.DataColumn208 = New System.Data.DataColumn()
        Me.DataColumn209 = New System.Data.DataColumn()
        Me.DataColumn210 = New System.Data.DataColumn()
        Me.DataColumn211 = New System.Data.DataColumn()
        Me.DataColumn212 = New System.Data.DataColumn()
        Me.DataColumn213 = New System.Data.DataColumn()
        Me.DataColumn214 = New System.Data.DataColumn()
        Me.DataColumn215 = New System.Data.DataColumn()
        Me.DataColumn216 = New System.Data.DataColumn()
        Me.DataColumn217 = New System.Data.DataColumn()
        Me.DataColumn218 = New System.Data.DataColumn()
        Me.DataColumn219 = New System.Data.DataColumn()
        Me.DataColumn220 = New System.Data.DataColumn()
        Me.DataColumn221 = New System.Data.DataColumn()
        Me.DataColumn222 = New System.Data.DataColumn()
        Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl112 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl113 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit18 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl114 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit19 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl115 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit20 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl116 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl117 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit21 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit22 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl118 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl17 = New DevExpress.XtraEditors.GroupControl()
        Me.LookUpEdit6 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl119 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit23 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl120 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit24 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl121 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl122 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit25 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit26 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit27 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl123 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl18 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton15 = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit7 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit8 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl124 = New DevExpress.XtraEditors.LabelControl()
        Me.CalcEdit4 = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl125 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit28 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl126 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl127 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit29 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit30 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl128 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl129 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSiniflar = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbSatisYapilamaz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinifKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_KartNo = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.ds_tbMusteriKarti = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_tbMusteriKarti_sKartNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteSonKullanmaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_tbMusteriKarti_sAciklama = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl11 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_bOzelMustrimi = New DevExpress.XtraEditors.CheckEdit()
        Me.ds_tbMusteriKredisi = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.txt_dteSonKullanmaTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl91 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteKrediAcilisTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl90 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteKrediLimitiTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl89 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_llimit = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl88 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_EkKart = New System.Windows.Forms.ContextMenu()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.ds_tbMusteriEkKart = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
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
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnEkKartID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsYeriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsAdresi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsAdresi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsSemt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsPostaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsIl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvSemt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvPostaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvIl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAylikGelir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSigortaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHitap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage10 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_cocuk = New System.Windows.Forms.ContextMenu()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.ds_tbMusteriCocugu = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCinsiyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_tbMusteriCocugu_nCinsiyet = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.coldteDogumTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDogumYeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOzelNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage11 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_OzelNot = New System.Windows.Forms.ContextMenu()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.ds_tbMusteriOzelNot = New System.Data.DataSet()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteGirisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage12 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl()
        Me.ds_tbMusteriResim = New System.Data.DataSet()
        Me.DataTable11 = New System.Data.DataTable()
        Me.DataColumn169 = New System.Data.DataColumn()
        Me.DataColumn170 = New System.Data.DataColumn()
        Me.DataColumn171 = New System.Data.DataColumn()
        Me.DataColumn172 = New System.Data.DataColumn()
        Me.DataColumn173 = New System.Data.DataColumn()
        Me.DataColumn174 = New System.Data.DataColumn()
        Me.DataColumn175 = New System.Data.DataColumn()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpResim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pResim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtekayitTarihi3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.ds_tbMusteriSinifi = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl2.SuspendLayout
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl3.SuspendLayout
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabControl1.SuspendLayout
        Me.XtraTabPage1.SuspendLayout
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl10.SuspendLayout
        CType(Me.sec_bMusteriAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteri, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.btn_ReferansSec.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sUnvan1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_bYazismaEvAdresinemi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sKanGrubu.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sEhliyetNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_nIskontoPesin.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_nIskontoKredili.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_lAylikGelir.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sDogumYeri.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteDogumTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteDogumTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_nCinsiyet.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteEvlilikTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteEvlilikTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_bEvlimi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage2.SuspendLayout
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl3.SuspendLayout
        CType(Me.txt_sIsIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sIsTelefonu.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sIsPostaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sIsSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sIsAdres2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_IsAdres1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sIsyeriAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl2.SuspendLayout
        CType(Me.txt_sEvIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sEvPostaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sEvSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sEvTelefonu.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sEvAdres2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sEvAdresi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.txt_sFaks.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage3.SuspendLayout
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl12.SuspendLayout
        CType(Me.TextEdit31.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriNufusu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sSeriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAileIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sHitap3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sHitap2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAileTelefonu.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sSigortaNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAilePostaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAileSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAileAdresi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAileAdresi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sCuzdanKayitNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sCuzdanVerNedeni.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sCuzdanVerilenYer.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteNufusCuzdanTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteNufusCuzdanTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sKutukSiraNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sKutukCiltNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sKutukMahalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sKutukIlce.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sKutukIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sAnneAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sBabaAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage4.SuspendLayout
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl6.SuspendLayout
        CType(Me.txt_sKefil1IsIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriKefil1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit56.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit49.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit50.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit52.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit53.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit54.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit55.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl5.SuspendLayout
        CType(Me.txt_sKefil1EvIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit44.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit45.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit46.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit47.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit48.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl4.SuspendLayout
        CType(Me.txt_sHitap4.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sUnvan2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit42.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit39.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit41.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage5.SuspendLayout
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl7.SuspendLayout
        CType(Me.txt_sKefil2IsIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriKefil2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit57.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit58.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit60.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit61.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit62.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit63.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit64.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl8.SuspendLayout
        CType(Me.txt_sKefil2EvIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit66.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit67.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit68.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit69.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit70.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl9.SuspendLayout
        CType(Me.txt_sHitap5.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_sUnvan3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CalcEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit71.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit72.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit73.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage13.SuspendLayout
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl13.SuspendLayout
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriKefil3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl14, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl14.SuspendLayout
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl15, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl15.SuspendLayout
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage14.SuspendLayout
        CType(Me.GroupControl16, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl16.SuspendLayout
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriKefil4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl17, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl17.SuspendLayout
        CType(Me.LookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit24.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit25.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit26.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit27.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl18, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl18.SuspendLayout
        CType(Me.LookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CalcEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit28.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit29.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit30.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage6.SuspendLayout
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sec_sSiniflar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage7.SuspendLayout
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriKarti, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sec_tbMusteriKarti_sKartNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sec_tbMusteriKarti_sAciklama, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage8.SuspendLayout
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl11.SuspendLayout
        CType(Me.txt_bOzelMustrimi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriKredisi, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteSonKullanmaTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteSonKullanmaTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteKrediAcilisTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteKrediAcilisTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteKrediLimitiTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_dteKrediLimitiTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_llimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage9.SuspendLayout
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriEkKart, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage10.SuspendLayout
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriCocugu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sec_tbMusteriCocugu_nCinsiyet, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage11.SuspendLayout
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriOzelNot, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabPage12.SuspendLayout
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl5.SuspendLayout
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ds_tbMusteriResim, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl4.SuspendLayout
        CType(Me.ds_tbMusteriSinifi, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1310, 80)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Müşteri Kartı Tanımları Aşağıdadır..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton10)
        Me.PanelControl2.Controls.Add(Me.SimpleButton9)
        Me.PanelControl2.Controls.Add(Me.SimpleButton8)
        Me.PanelControl2.Controls.Add(Me.LabelControl92)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 566)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1310, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Image = CType(resources.GetObject("SimpleButton10.Image"), System.Drawing.Image)
        Me.SimpleButton10.Location = New System.Drawing.Point(498, 10)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(166, 33)
        Me.SimpleButton10.TabIndex = 4
        Me.SimpleButton10.Text = "SMS Gönder"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Image = CType(resources.GetObject("SimpleButton9.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(664, 10)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(166, 33)
        Me.SimpleButton9.TabIndex = 5
        Me.SimpleButton9.Text = "Sözleşme Yazdır"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Image = CType(resources.GetObject("SimpleButton8.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(830, 10)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(167, 33)
        Me.SimpleButton8.TabIndex = 6
        Me.SimpleButton8.Text = "Sözleşme Dizayn"
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.Location = New System.Drawing.Point(26, 14)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl92.TabIndex = 56
        Me.LabelControl92.Text = "MüşterNo:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(331, 10)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(167, 33)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "Not"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(141, 10)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(160, 26)
        Me.txt_musteriNo.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1173, 10)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1053, 10)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1310, 486)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1306, 482)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage13, Me.XtraTabPage14, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9, Me.XtraTabPage10, Me.XtraTabPage11, Me.XtraTabPage12})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage1.Text = "Genel"
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.sec_bMusteriAktif)
        Me.GroupControl10.Controls.Add(Me.lbl_Referans)
        Me.GroupControl10.Controls.Add(Me.LabelControl93)
        Me.GroupControl10.Controls.Add(Me.btn_ReferansSec)
        Me.GroupControl10.Controls.Add(Me.txt_sHitap1)
        Me.GroupControl10.Controls.Add(Me.txt_sUnvan1)
        Me.GroupControl10.Controls.Add(Me.txt_bYazismaEvAdresinemi)
        Me.GroupControl10.Controls.Add(Me.LabelControl18)
        Me.GroupControl10.Controls.Add(Me.txt_sKanGrubu)
        Me.GroupControl10.Controls.Add(Me.LabelControl17)
        Me.GroupControl10.Controls.Add(Me.txt_sEhliyetNo)
        Me.GroupControl10.Controls.Add(Me.LabelControl16)
        Me.GroupControl10.Controls.Add(Me.txt_nIskontoPesin)
        Me.GroupControl10.Controls.Add(Me.LabelControl15)
        Me.GroupControl10.Controls.Add(Me.txt_nIskontoKredili)
        Me.GroupControl10.Controls.Add(Me.LabelControl14)
        Me.GroupControl10.Controls.Add(Me.txt_lAylikGelir)
        Me.GroupControl10.Controls.Add(Me.LabelControl13)
        Me.GroupControl10.Controls.Add(Me.txt_sVergiNo)
        Me.GroupControl10.Controls.Add(Me.LabelControl12)
        Me.GroupControl10.Controls.Add(Me.txt_sVergiDairesi)
        Me.GroupControl10.Controls.Add(Me.LabelControl11)
        Me.GroupControl10.Controls.Add(Me.txt_sDogumYeri)
        Me.GroupControl10.Controls.Add(Me.LabelControl10)
        Me.GroupControl10.Controls.Add(Me.txt_dteDogumTarihi)
        Me.GroupControl10.Controls.Add(Me.LabelControl9)
        Me.GroupControl10.Controls.Add(Me.txt_nCinsiyet)
        Me.GroupControl10.Controls.Add(Me.LabelControl8)
        Me.GroupControl10.Controls.Add(Me.txt_sMagaza)
        Me.GroupControl10.Controls.Add(Me.txt_dteEvlilikTarihi)
        Me.GroupControl10.Controls.Add(Me.LabelControl7)
        Me.GroupControl10.Controls.Add(Me.txt_bEvlimi)
        Me.GroupControl10.Controls.Add(Me.LabelControl6)
        Me.GroupControl10.Controls.Add(Me.LabelControl5)
        Me.GroupControl10.Controls.Add(Me.txt_sSoyadi)
        Me.GroupControl10.Controls.Add(Me.LabelControl4)
        Me.GroupControl10.Controls.Add(Me.txt_sAdi)
        Me.GroupControl10.Controls.Add(Me.LabelControl3)
        Me.GroupControl10.Controls.Add(Me.LabelControl2)
        Me.GroupControl10.Controls.Add(Me.LabelControl1)
        Me.GroupControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl10.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(1300, 446)
        Me.GroupControl10.TabIndex = 0
        '
        'sec_bMusteriAktif
        '
        Me.sec_bMusteriAktif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.bMusteriAktif", True))
        Me.sec_bMusteriAktif.Location = New System.Drawing.Point(802, 279)
        Me.sec_bMusteriAktif.Name = "sec_bMusteriAktif"
        Me.sec_bMusteriAktif.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bMusteriAktif.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bMusteriAktif.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_bMusteriAktif.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_bMusteriAktif.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_bMusteriAktif.Properties.Caption = "Hesap Aktif"
        Me.sec_bMusteriAktif.Size = New System.Drawing.Size(132, 24)
        Me.sec_bMusteriAktif.TabIndex = 76
        '
        'ds_tbMusteri
        '
        Me.ds_tbMusteri.DataSetName = "NewDataSet"
        Me.ds_tbMusteri.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteri.Tables.AddRange(New System.Data.DataTable() {Me.DataTable7})
        '
        'DataTable7
        '
        Me.DataTable7.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn96, Me.DataColumn97, Me.DataColumn98, Me.DataColumn99, Me.DataColumn100, Me.DataColumn101, Me.DataColumn176})
        Me.DataTable7.TableName = "Table1"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "nMusteriID"
        Me.DataColumn56.DataType = GetType(Long)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sMagaza"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "lKodu"
        Me.DataColumn58.DataType = GetType(Long)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "sAdi"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "sSoyadi"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "nCinsiyet"
        Me.DataColumn61.DataType = GetType(Long)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "lAylikGelir"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "dteKartAcilisTarihi"
        Me.DataColumn63.DataType = GetType(Date)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "nIskontoPesin"
        Me.DataColumn64.DataType = GetType(Decimal)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "nIskontoKredili"
        Me.DataColumn65.DataType = GetType(Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "sUnvan"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "sVergiDairesi"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "sVergiNo"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "bYazismaEvAdresinemi"
        Me.DataColumn69.DataType = GetType(Boolean)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "sEmail"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "sIsYeriAdi"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "sIsAdresi1"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "sIsAdresi2"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "sIsSemt"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "sIsIl"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "sIsPostaKodu"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "sIsTelefonu"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "sEvAdresi1"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "sEvAdresi2"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "sEvSemt"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "sEvPostaKodu"
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "sEvIl"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "sEvTelefonu"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "sSigortaNo"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "bEvlimi"
        Me.DataColumn85.DataType = GetType(Boolean)
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "dteEvlilikTarihi"
        Me.DataColumn86.DataType = GetType(Date)
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "dteDogumTarihi"
        Me.DataColumn87.DataType = GetType(Date)
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "sDogumYeri"
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "sEhliyetNo"
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "sKanGrubu"
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "sHitap"
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "sKullaniciAdi"
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "dteKayitTarihi"
        Me.DataColumn93.DataType = GetType(Date)
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "sAciklama1"
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "sAciklama2"
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "sAciklama3"
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "sAciklama4"
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "sAciklama5"
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "sGSM"
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "sFax"
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "sResimAdi"
        '
        'DataColumn176
        '
        Me.DataColumn176.Caption = "bMusteriAktif"
        Me.DataColumn176.ColumnName = "bMusteriAktif"
        Me.DataColumn176.DataType = GetType(Boolean)
        '
        'lbl_Referans
        '
        Me.lbl_Referans.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Referans.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Referans.Location = New System.Drawing.Point(1003, 246)
        Me.lbl_Referans.Name = "lbl_Referans"
        Me.lbl_Referans.Size = New System.Drawing.Size(9, 19)
        Me.lbl_Referans.TabIndex = 75
        Me.lbl_Referans.Text = "*"
        '
        'LabelControl93
        '
        Me.LabelControl93.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl93.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl93.Location = New System.Drawing.Point(702, 246)
        Me.LabelControl93.Name = "LabelControl93"
        Me.LabelControl93.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl93.TabIndex = 74
        Me.LabelControl93.Text = "Referans:"
        '
        'btn_ReferansSec
        '
        Me.btn_ReferansSec.Location = New System.Drawing.Point(805, 246)
        Me.btn_ReferansSec.Name = "btn_ReferansSec"
        Me.btn_ReferansSec.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ReferansSec.Properties.Appearance.Options.UseForeColor = True
        Me.btn_ReferansSec.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btn_ReferansSec.Size = New System.Drawing.Size(189, 26)
        Me.btn_ReferansSec.TabIndex = 73
        '
        'txt_sHitap1
        '
        Me.txt_sHitap1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sHitap", True))
        Me.txt_sHitap1.EnterMoveNextControl = True
        Me.txt_sHitap1.Location = New System.Drawing.Point(122, 47)
        Me.txt_sHitap1.Name = "txt_sHitap1"
        Me.txt_sHitap1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap1.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap1.Properties.NullText = "[Hitap]"
        Me.txt_sHitap1.Properties.ValueMember = "sHitap"
        Me.txt_sHitap1.Size = New System.Drawing.Size(160, 26)
        Me.txt_sHitap1.TabIndex = 1
        '
        'txt_sUnvan1
        '
        Me.txt_sUnvan1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sUnvan", True))
        Me.txt_sUnvan1.EnterMoveNextControl = True
        Me.txt_sUnvan1.Location = New System.Drawing.Point(122, 133)
        Me.txt_sUnvan1.Name = "txt_sUnvan1"
        Me.txt_sUnvan1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sUnvan1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sUnvan1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sUnvan1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sUnvan1.Properties.DisplayMember = "sUnvan"
        Me.txt_sUnvan1.Properties.NullText = "[Ünvan]"
        Me.txt_sUnvan1.Properties.ValueMember = "sUnvan"
        Me.txt_sUnvan1.Size = New System.Drawing.Size(160, 26)
        Me.txt_sUnvan1.TabIndex = 72
        '
        'txt_bYazismaEvAdresinemi
        '
        Me.txt_bYazismaEvAdresinemi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.bYazismaEvAdresinemi", True))
        Me.txt_bYazismaEvAdresinemi.Location = New System.Drawing.Point(802, 219)
        Me.txt_bYazismaEvAdresinemi.Name = "txt_bYazismaEvAdresinemi"
        Me.txt_bYazismaEvAdresinemi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bYazismaEvAdresinemi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bYazismaEvAdresinemi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_bYazismaEvAdresinemi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_bYazismaEvAdresinemi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_bYazismaEvAdresinemi.Properties.Caption = "Ev?"
        Me.txt_bYazismaEvAdresinemi.Size = New System.Drawing.Size(120, 24)
        Me.txt_bYazismaEvAdresinemi.TabIndex = 17
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl18.Location = New System.Drawing.Point(715, 219)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(64, 19)
        Me.LabelControl18.TabIndex = 71
        Me.LabelControl18.Text = "Yazışma:"
        '
        'txt_sKanGrubu
        '
        Me.txt_sKanGrubu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sKanGrubu", True))
        Me.txt_sKanGrubu.EnterMoveNextControl = True
        Me.txt_sKanGrubu.Location = New System.Drawing.Point(802, 190)
        Me.txt_sKanGrubu.Name = "txt_sKanGrubu"
        Me.txt_sKanGrubu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKanGrubu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKanGrubu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKanGrubu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKanGrubu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKanGrubu.Properties.MaxLength = 60
        Me.txt_sKanGrubu.Size = New System.Drawing.Size(102, 26)
        Me.txt_sKanGrubu.TabIndex = 16
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.Location = New System.Drawing.Point(701, 190)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl17.TabIndex = 69
        Me.LabelControl17.Text = "KanGrubu:"
        '
        'txt_sEhliyetNo
        '
        Me.txt_sEhliyetNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEhliyetNo", True))
        Me.txt_sEhliyetNo.EnterMoveNextControl = True
        Me.txt_sEhliyetNo.Location = New System.Drawing.Point(802, 161)
        Me.txt_sEhliyetNo.Name = "txt_sEhliyetNo"
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEhliyetNo.Properties.MaxLength = 60
        Me.txt_sEhliyetNo.Size = New System.Drawing.Size(358, 26)
        Me.txt_sEhliyetNo.TabIndex = 15
        Me.txt_sEhliyetNo.ToolTip = "5 Karakterden Küçükse FiyatTipi , 5 Karakterden Büyükise EhliyetNo olarak algılan" &
    "maktadır."
        Me.txt_sEhliyetNo.ToolTipTitle = "FiyatTipi/EhliyetNo"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(634, 161)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(139, 19)
        Me.LabelControl16.TabIndex = 67
        Me.LabelControl16.Text = "FiyatTipi/EhliyetNo:"
        '
        'txt_nIskontoPesin
        '
        Me.txt_nIskontoPesin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.nIskontoPesin", True))
        Me.txt_nIskontoPesin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskontoPesin.EnterMoveNextControl = True
        Me.txt_nIskontoPesin.Location = New System.Drawing.Point(802, 133)
        Me.txt_nIskontoPesin.Name = "txt_nIskontoPesin"
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskontoPesin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskontoPesin.Size = New System.Drawing.Size(102, 26)
        Me.txt_nIskontoPesin.TabIndex = 14
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.Location = New System.Drawing.Point(678, 133)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(96, 19)
        Me.LabelControl15.TabIndex = 65
        Me.LabelControl15.Text = "PeşinIskonto:"
        '
        'txt_nIskontoKredili
        '
        Me.txt_nIskontoKredili.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.nIskontoKredili", True))
        Me.txt_nIskontoKredili.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskontoKredili.EnterMoveNextControl = True
        Me.txt_nIskontoKredili.Location = New System.Drawing.Point(802, 104)
        Me.txt_nIskontoKredili.Name = "txt_nIskontoKredili"
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskontoKredili.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskontoKredili.Size = New System.Drawing.Size(102, 26)
        Me.txt_nIskontoKredili.TabIndex = 13
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(680, 104)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl14.TabIndex = 63
        Me.LabelControl14.Text = "KrediIskonto:"
        '
        'txt_lAylikGelir
        '
        Me.txt_lAylikGelir.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.lAylikGelir", True))
        Me.txt_lAylikGelir.EnterMoveNextControl = True
        Me.txt_lAylikGelir.Location = New System.Drawing.Point(802, 76)
        Me.txt_lAylikGelir.Name = "txt_lAylikGelir"
        Me.txt_lAylikGelir.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAylikGelir.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAylikGelir.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lAylikGelir.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lAylikGelir.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lAylikGelir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lAylikGelir.Size = New System.Drawing.Size(192, 26)
        Me.txt_lAylikGelir.TabIndex = 12
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(707, 76)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl13.TabIndex = 61
        Me.LabelControl13.Text = "AylıkGelir:"
        '
        'txt_sVergiNo
        '
        Me.txt_sVergiNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sVergiNo", True))
        Me.txt_sVergiNo.EnterMoveNextControl = True
        Me.txt_sVergiNo.Location = New System.Drawing.Point(802, 47)
        Me.txt_sVergiNo.Name = "txt_sVergiNo"
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiNo.Properties.MaxLength = 60
        Me.txt_sVergiNo.Size = New System.Drawing.Size(358, 26)
        Me.txt_sVergiNo.TabIndex = 11
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.Location = New System.Drawing.Point(717, 47)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl12.TabIndex = 59
        Me.LabelControl12.Text = "VergiNo:"
        '
        'txt_sVergiDairesi
        '
        Me.txt_sVergiDairesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sVergiDairesi", True))
        Me.txt_sVergiDairesi.EnterMoveNextControl = True
        Me.txt_sVergiDairesi.Location = New System.Drawing.Point(802, 19)
        Me.txt_sVergiDairesi.Name = "txt_sVergiDairesi"
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiDairesi.Properties.MaxLength = 60
        Me.txt_sVergiDairesi.Size = New System.Drawing.Size(358, 26)
        Me.txt_sVergiDairesi.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(686, 19)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl11.TabIndex = 57
        Me.LabelControl11.Text = "VergiDairesi:"
        '
        'txt_sDogumYeri
        '
        Me.txt_sDogumYeri.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sDogumYeri", True))
        Me.txt_sDogumYeri.EnterMoveNextControl = True
        Me.txt_sDogumYeri.Location = New System.Drawing.Point(122, 274)
        Me.txt_sDogumYeri.Name = "txt_sDogumYeri"
        Me.txt_sDogumYeri.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDogumYeri.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDogumYeri.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sDogumYeri.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sDogumYeri.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sDogumYeri.Properties.MaxLength = 60
        Me.txt_sDogumYeri.Size = New System.Drawing.Size(358, 26)
        Me.txt_sDogumYeri.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(24, 274)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl10.TabIndex = 55
        Me.LabelControl10.Text = "DoğumYeri:"
        '
        'txt_dteDogumTarihi
        '
        Me.txt_dteDogumTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.dteDogumTarihi", True))
        Me.txt_dteDogumTarihi.EditValue = Nothing
        Me.txt_dteDogumTarihi.EnterMoveNextControl = True
        Me.txt_dteDogumTarihi.Location = New System.Drawing.Point(122, 246)
        Me.txt_dteDogumTarihi.Name = "txt_dteDogumTarihi"
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteDogumTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteDogumTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteDogumTarihi.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteDogumTarihi.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(11, 246)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl9.TabIndex = 53
        Me.LabelControl9.Text = "DoğumTarihi:"
        '
        'txt_nCinsiyet
        '
        Me.txt_nCinsiyet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.nCinsiyet", True))
        Me.txt_nCinsiyet.EnterMoveNextControl = True
        Me.txt_nCinsiyet.Location = New System.Drawing.Point(122, 217)
        Me.txt_nCinsiyet.Name = "txt_nCinsiyet"
        Me.txt_nCinsiyet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nCinsiyet.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nCinsiyet.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nCinsiyet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nCinsiyet.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nCinsiyet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_nCinsiyet.Properties.DisplayMember = "sAciklama"
        Me.txt_nCinsiyet.Properties.NullText = "[Cinsiyet]"
        Me.txt_nCinsiyet.Properties.ValueMember = "nCinsiyet"
        Me.txt_nCinsiyet.Size = New System.Drawing.Size(160, 26)
        Me.txt_nCinsiyet.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(45, 217)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl8.TabIndex = 51
        Me.LabelControl8.Text = "Cinsiyet:"
        '
        'txt_sMagaza
        '
        Me.txt_sMagaza.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sMagaza", True))
        Me.txt_sMagaza.EnterMoveNextControl = True
        Me.txt_sMagaza.Location = New System.Drawing.Point(122, 19)
        Me.txt_sMagaza.Name = "txt_sMagaza"
        Me.txt_sMagaza.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMagaza.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMagaza.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sMagaza.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sMagaza.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sMagaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sMagaza.Properties.DisplayMember = "sDepo"
        Me.txt_sMagaza.Properties.NullText = "[Mağaza]"
        Me.txt_sMagaza.Properties.ValueMember = "sDepo"
        Me.txt_sMagaza.Size = New System.Drawing.Size(160, 26)
        Me.txt_sMagaza.TabIndex = 0
        '
        'txt_dteEvlilikTarihi
        '
        Me.txt_dteEvlilikTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.dteEvlilikTarihi", True))
        Me.txt_dteEvlilikTarihi.EditValue = Nothing
        Me.txt_dteEvlilikTarihi.EnterMoveNextControl = True
        Me.txt_dteEvlilikTarihi.Location = New System.Drawing.Point(122, 189)
        Me.txt_dteEvlilikTarihi.Name = "txt_dteEvlilikTarihi"
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteEvlilikTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteEvlilikTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteEvlilikTarihi.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteEvlilikTarihi.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(24, 194)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(88, 19)
        Me.LabelControl7.TabIndex = 48
        Me.LabelControl7.Text = "EvlilikTarihi:"
        '
        'txt_bEvlimi
        '
        Me.txt_bEvlimi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.bEvlimi", True))
        Me.txt_bEvlimi.Location = New System.Drawing.Point(118, 161)
        Me.txt_bEvlimi.Name = "txt_bEvlimi"
        Me.txt_bEvlimi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bEvlimi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bEvlimi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_bEvlimi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_bEvlimi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_bEvlimi.Properties.Caption = "Evli"
        Me.txt_bEvlimi.Size = New System.Drawing.Size(120, 24)
        Me.txt_bEvlimi.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(24, 161)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl6.TabIndex = 46
        Me.LabelControl6.Text = "MedeniHali:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(54, 133)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 19)
        Me.LabelControl5.TabIndex = 45
        Me.LabelControl5.Text = "Meslek:"
        '
        'txt_sSoyadi
        '
        Me.txt_sSoyadi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sSoyadi", True))
        Me.txt_sSoyadi.EnterMoveNextControl = True
        Me.txt_sSoyadi.Location = New System.Drawing.Point(122, 104)
        Me.txt_sSoyadi.Name = "txt_sSoyadi"
        Me.txt_sSoyadi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSoyadi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSoyadi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSoyadi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSoyadi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSoyadi.Properties.MaxLength = 60
        Me.txt_sSoyadi.Size = New System.Drawing.Size(358, 26)
        Me.txt_sSoyadi.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(54, 104)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 19)
        Me.LabelControl4.TabIndex = 42
        Me.LabelControl4.Text = "Soyadı:"
        '
        'txt_sAdi
        '
        Me.txt_sAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sAdi", True))
        Me.txt_sAdi.EnterMoveNextControl = True
        Me.txt_sAdi.Location = New System.Drawing.Point(122, 76)
        Me.txt_sAdi.Name = "txt_sAdi"
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdi.Properties.MaxLength = 60
        Me.txt_sAdi.Size = New System.Drawing.Size(358, 26)
        Me.txt_sAdi.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(82, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl3.TabIndex = 40
        Me.LabelControl3.Text = "Adı:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(66, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl2.TabIndex = 39
        Me.LabelControl2.Text = "Hitap:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(46, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Mağaza:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage2.Text = "İletişim"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.txt_sIsIl)
        Me.GroupControl3.Controls.Add(Me.txt_sEmail)
        Me.GroupControl3.Controls.Add(Me.LabelControl32)
        Me.GroupControl3.Controls.Add(Me.LabelControl31)
        Me.GroupControl3.Controls.Add(Me.txt_sIsTelefonu)
        Me.GroupControl3.Controls.Add(Me.LabelControl26)
        Me.GroupControl3.Controls.Add(Me.txt_sIsPostaKodu)
        Me.GroupControl3.Controls.Add(Me.LabelControl27)
        Me.GroupControl3.Controls.Add(Me.txt_sIsSemt)
        Me.GroupControl3.Controls.Add(Me.LabelControl28)
        Me.GroupControl3.Controls.Add(Me.LabelControl29)
        Me.GroupControl3.Controls.Add(Me.txt_sIsAdres2)
        Me.GroupControl3.Controls.Add(Me.txt_IsAdres1)
        Me.GroupControl3.Controls.Add(Me.txt_sIsyeriAdi)
        Me.GroupControl3.Controls.Add(Me.LabelControl30)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 189)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1300, 152)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "İş Adresi"
        '
        'txt_sIsIl
        '
        Me.txt_sIsIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sIsIl", True))
        Me.txt_sIsIl.EnterMoveNextControl = True
        Me.txt_sIsIl.Location = New System.Drawing.Point(882, 89)
        Me.txt_sIsIl.Name = "txt_sIsIl"
        Me.txt_sIsIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sIsIl.Properties.DisplayMember = "sIl"
        Me.txt_sIsIl.Properties.NullText = "[Il]"
        Me.txt_sIsIl.Properties.ValueMember = "sIl"
        Me.txt_sIsIl.Size = New System.Drawing.Size(358, 26)
        Me.txt_sIsIl.TabIndex = 14
        '
        'txt_sEmail
        '
        Me.txt_sEmail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEmail", True))
        Me.txt_sEmail.EnterMoveNextControl = True
        Me.txt_sEmail.Location = New System.Drawing.Point(882, 117)
        Me.txt_sEmail.Name = "txt_sEmail"
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEmail.Size = New System.Drawing.Size(358, 26)
        Me.txt_sEmail.TabIndex = 15
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl32.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl32.Location = New System.Drawing.Point(821, 117)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl32.TabIndex = 36
        Me.LabelControl32.Text = "E-Mail:"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl31.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl31.Location = New System.Drawing.Point(54, 119)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl31.TabIndex = 35
        Me.LabelControl31.Text = "Telefon:"
        '
        'txt_sIsTelefonu
        '
        Me.txt_sIsTelefonu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sIsTelefonu", True))
        Me.txt_sIsTelefonu.EnterMoveNextControl = True
        Me.txt_sIsTelefonu.Location = New System.Drawing.Point(128, 119)
        Me.txt_sIsTelefonu.Name = "txt_sIsTelefonu"
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsTelefonu.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sIsTelefonu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sIsTelefonu.Properties.Mask.SaveLiteral = False
        Me.txt_sIsTelefonu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sIsTelefonu.Properties.MaxLength = 20
        Me.txt_sIsTelefonu.Size = New System.Drawing.Size(230, 26)
        Me.txt_sIsTelefonu.TabIndex = 11
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl26.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl26.Location = New System.Drawing.Point(856, 89)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl26.TabIndex = 32
        Me.LabelControl26.Text = "İl:"
        '
        'txt_sIsPostaKodu
        '
        Me.txt_sIsPostaKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sIsPostaKodu", True))
        Me.txt_sIsPostaKodu.EnterMoveNextControl = True
        Me.txt_sIsPostaKodu.Location = New System.Drawing.Point(882, 60)
        Me.txt_sIsPostaKodu.Name = "txt_sIsPostaKodu"
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsPostaKodu.Properties.MaxLength = 20
        Me.txt_sIsPostaKodu.Size = New System.Drawing.Size(153, 26)
        Me.txt_sIsPostaKodu.TabIndex = 13
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl27.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl27.Location = New System.Drawing.Point(784, 60)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl27.TabIndex = 30
        Me.LabelControl27.Text = "PostaKodu:"
        '
        'txt_sIsSemt
        '
        Me.txt_sIsSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sIsSemt", True))
        Me.txt_sIsSemt.EnterMoveNextControl = True
        Me.txt_sIsSemt.Location = New System.Drawing.Point(882, 31)
        Me.txt_sIsSemt.Name = "txt_sIsSemt"
        Me.txt_sIsSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsSemt.Properties.MaxLength = 60
        Me.txt_sIsSemt.Size = New System.Drawing.Size(358, 26)
        Me.txt_sIsSemt.TabIndex = 12
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl28.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl28.Location = New System.Drawing.Point(827, 31)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl28.TabIndex = 28
        Me.LabelControl28.Text = "Semt:"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl29.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl29.Location = New System.Drawing.Point(67, 61)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl29.TabIndex = 27
        Me.LabelControl29.Text = "Adres:"
        '
        'txt_sIsAdres2
        '
        Me.txt_sIsAdres2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sIsAdresi2", True))
        Me.txt_sIsAdres2.EnterMoveNextControl = True
        Me.txt_sIsAdres2.Location = New System.Drawing.Point(128, 90)
        Me.txt_sIsAdres2.Name = "txt_sIsAdres2"
        Me.txt_sIsAdres2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsAdres2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsAdres2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsAdres2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsAdres2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsAdres2.Properties.MaxLength = 60
        Me.txt_sIsAdres2.Size = New System.Drawing.Size(358, 26)
        Me.txt_sIsAdres2.TabIndex = 10
        '
        'txt_IsAdres1
        '
        Me.txt_IsAdres1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sIsAdresi1", True))
        Me.txt_IsAdres1.EnterMoveNextControl = True
        Me.txt_IsAdres1.Location = New System.Drawing.Point(128, 61)
        Me.txt_IsAdres1.Name = "txt_IsAdres1"
        Me.txt_IsAdres1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_IsAdres1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_IsAdres1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_IsAdres1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_IsAdres1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_IsAdres1.Properties.MaxLength = 60
        Me.txt_IsAdres1.Size = New System.Drawing.Size(358, 26)
        Me.txt_IsAdres1.TabIndex = 9
        '
        'txt_sIsyeriAdi
        '
        Me.txt_sIsyeriAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sIsYeriAdi", True))
        Me.txt_sIsyeriAdi.EnterMoveNextControl = True
        Me.txt_sIsyeriAdi.Location = New System.Drawing.Point(128, 33)
        Me.txt_sIsyeriAdi.Name = "txt_sIsyeriAdi"
        Me.txt_sIsyeriAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsyeriAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsyeriAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsyeriAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsyeriAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsyeriAdi.Properties.MaxLength = 60
        Me.txt_sIsyeriAdi.Size = New System.Drawing.Size(358, 26)
        Me.txt_sIsyeriAdi.TabIndex = 8
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl30.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl30.Location = New System.Drawing.Point(45, 33)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl30.TabIndex = 23
        Me.LabelControl30.Text = "İşYeriAdı:"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txt_sEvIl)
        Me.GroupControl2.Controls.Add(Me.LabelControl25)
        Me.GroupControl2.Controls.Add(Me.txt_sEvPostaKodu)
        Me.GroupControl2.Controls.Add(Me.LabelControl24)
        Me.GroupControl2.Controls.Add(Me.txt_sEvSemt)
        Me.GroupControl2.Controls.Add(Me.LabelControl23)
        Me.GroupControl2.Controls.Add(Me.LabelControl22)
        Me.GroupControl2.Controls.Add(Me.txt_sEvTelefonu)
        Me.GroupControl2.Controls.Add(Me.txt_sEvAdres2)
        Me.GroupControl2.Controls.Add(Me.txt_sEvAdresi1)
        Me.GroupControl2.Controls.Add(Me.LabelControl21)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 64)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1300, 125)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Ev Adresi"
        '
        'txt_sEvIl
        '
        Me.txt_sEvIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEvIl", True))
        Me.txt_sEvIl.EnterMoveNextControl = True
        Me.txt_sEvIl.Location = New System.Drawing.Point(882, 87)
        Me.txt_sEvIl.Name = "txt_sEvIl"
        Me.txt_sEvIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sEvIl.Properties.DisplayMember = "sIl"
        Me.txt_sEvIl.Properties.NullText = "[Il]"
        Me.txt_sEvIl.Properties.ValueMember = "sIl"
        Me.txt_sEvIl.Size = New System.Drawing.Size(358, 26)
        Me.txt_sEvIl.TabIndex = 7
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl25.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl25.Location = New System.Drawing.Point(856, 87)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl25.TabIndex = 32
        Me.LabelControl25.Text = "İl:"
        '
        'txt_sEvPostaKodu
        '
        Me.txt_sEvPostaKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEvPostaKodu", True))
        Me.txt_sEvPostaKodu.EnterMoveNextControl = True
        Me.txt_sEvPostaKodu.Location = New System.Drawing.Point(882, 59)
        Me.txt_sEvPostaKodu.Name = "txt_sEvPostaKodu"
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvPostaKodu.Properties.MaxLength = 20
        Me.txt_sEvPostaKodu.Size = New System.Drawing.Size(153, 26)
        Me.txt_sEvPostaKodu.TabIndex = 6
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl24.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl24.Location = New System.Drawing.Point(784, 59)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl24.TabIndex = 30
        Me.LabelControl24.Text = "PostaKodu:"
        '
        'txt_sEvSemt
        '
        Me.txt_sEvSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEvSemt", True))
        Me.txt_sEvSemt.EnterMoveNextControl = True
        Me.txt_sEvSemt.Location = New System.Drawing.Point(882, 30)
        Me.txt_sEvSemt.Name = "txt_sEvSemt"
        Me.txt_sEvSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvSemt.Properties.MaxLength = 60
        Me.txt_sEvSemt.Size = New System.Drawing.Size(358, 26)
        Me.txt_sEvSemt.TabIndex = 5
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl23.Location = New System.Drawing.Point(827, 30)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl23.TabIndex = 28
        Me.LabelControl23.Text = "Semt:"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl22.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl22.Location = New System.Drawing.Point(54, 89)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl22.TabIndex = 27
        Me.LabelControl22.Text = "Telefon:"
        '
        'txt_sEvTelefonu
        '
        Me.txt_sEvTelefonu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEvTelefonu", True))
        Me.txt_sEvTelefonu.EnterMoveNextControl = True
        Me.txt_sEvTelefonu.Location = New System.Drawing.Point(128, 89)
        Me.txt_sEvTelefonu.Name = "txt_sEvTelefonu"
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvTelefonu.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sEvTelefonu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sEvTelefonu.Properties.Mask.SaveLiteral = False
        Me.txt_sEvTelefonu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sEvTelefonu.Properties.MaxLength = 20
        Me.txt_sEvTelefonu.Size = New System.Drawing.Size(218, 26)
        Me.txt_sEvTelefonu.TabIndex = 4
        '
        'txt_sEvAdres2
        '
        Me.txt_sEvAdres2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEvAdresi2", True))
        Me.txt_sEvAdres2.EnterMoveNextControl = True
        Me.txt_sEvAdres2.Location = New System.Drawing.Point(128, 60)
        Me.txt_sEvAdres2.Name = "txt_sEvAdres2"
        Me.txt_sEvAdres2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdres2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdres2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvAdres2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvAdres2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvAdres2.Properties.MaxLength = 60
        Me.txt_sEvAdres2.Size = New System.Drawing.Size(358, 26)
        Me.txt_sEvAdres2.TabIndex = 3
        '
        'txt_sEvAdresi1
        '
        Me.txt_sEvAdresi1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sEvAdresi1", True))
        Me.txt_sEvAdresi1.EnterMoveNextControl = True
        Me.txt_sEvAdresi1.Location = New System.Drawing.Point(128, 31)
        Me.txt_sEvAdresi1.Name = "txt_sEvAdresi1"
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvAdresi1.Properties.MaxLength = 60
        Me.txt_sEvAdresi1.Size = New System.Drawing.Size(358, 26)
        Me.txt_sEvAdresi1.TabIndex = 2
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl21.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl21.Location = New System.Drawing.Point(67, 31)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl21.TabIndex = 23
        Me.LabelControl21.Text = "Adres:"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txt_sFaks)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.txt_sGSM)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1300, 64)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Genel"
        '
        'txt_sFaks
        '
        Me.txt_sFaks.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sFax", True))
        Me.txt_sFaks.EnterMoveNextControl = True
        Me.txt_sFaks.Location = New System.Drawing.Point(882, 29)
        Me.txt_sFaks.Name = "txt_sFaks"
        Me.txt_sFaks.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sFaks.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sFaks.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sFaks.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sFaks.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sFaks.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sFaks.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sFaks.Properties.Mask.SaveLiteral = False
        Me.txt_sFaks.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sFaks.Properties.MaxLength = 20
        Me.txt_sFaks.Size = New System.Drawing.Size(358, 26)
        Me.txt_sFaks.TabIndex = 1
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl20.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl20.Location = New System.Drawing.Point(837, 29)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl20.TabIndex = 25
        Me.LabelControl20.Text = "Fax:"
        '
        'txt_sGSM
        '
        Me.txt_sGSM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sGSM", True))
        Me.txt_sGSM.EnterMoveNextControl = True
        Me.txt_sGSM.Location = New System.Drawing.Point(128, 29)
        Me.txt_sGSM.Name = "txt_sGSM"
        Me.txt_sGSM.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sGSM.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sGSM.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sGSM.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sGSM.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sGSM.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sGSM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sGSM.Properties.Mask.SaveLiteral = False
        Me.txt_sGSM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sGSM.Properties.MaxLength = 20
        Me.txt_sGSM.Size = New System.Drawing.Size(218, 26)
        Me.txt_sGSM.TabIndex = 0
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl19.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl19.Location = New System.Drawing.Point(80, 29)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl19.TabIndex = 23
        Me.LabelControl19.Text = "Gsm:"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupControl12)
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton5)
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage3.Text = "Kimlik"
        '
        'GroupControl12
        '
        Me.GroupControl12.Controls.Add(Me.TextEdit31)
        Me.GroupControl12.Controls.Add(Me.LabelControl131)
        Me.GroupControl12.Controls.Add(Me.txt_sSeriNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl130)
        Me.GroupControl12.Controls.Add(Me.txt_sAileIl)
        Me.GroupControl12.Controls.Add(Me.txt_sHitap3)
        Me.GroupControl12.Controls.Add(Me.txt_sHitap2)
        Me.GroupControl12.Controls.Add(Me.txt_sAileTelefonu)
        Me.GroupControl12.Controls.Add(Me.txt_sSigortaNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl51)
        Me.GroupControl12.Controls.Add(Me.LabelControl50)
        Me.GroupControl12.Controls.Add(Me.LabelControl49)
        Me.GroupControl12.Controls.Add(Me.txt_sAilePostaKodu)
        Me.GroupControl12.Controls.Add(Me.LabelControl48)
        Me.GroupControl12.Controls.Add(Me.txt_sAileSemt)
        Me.GroupControl12.Controls.Add(Me.LabelControl47)
        Me.GroupControl12.Controls.Add(Me.txt_sAileAdresi2)
        Me.GroupControl12.Controls.Add(Me.txt_sAileAdresi1)
        Me.GroupControl12.Controls.Add(Me.LabelControl46)
        Me.GroupControl12.Controls.Add(Me.txt_sCuzdanKayitNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl45)
        Me.GroupControl12.Controls.Add(Me.txt_sCuzdanVerNedeni)
        Me.GroupControl12.Controls.Add(Me.LabelControl44)
        Me.GroupControl12.Controls.Add(Me.txt_sCuzdanVerilenYer)
        Me.GroupControl12.Controls.Add(Me.LabelControl43)
        Me.GroupControl12.Controls.Add(Me.txt_dteNufusCuzdanTarihi)
        Me.GroupControl12.Controls.Add(Me.LabelControl42)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukSiraNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl41)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukCiltNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl40)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukMahalle)
        Me.GroupControl12.Controls.Add(Me.LabelControl39)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukIlce)
        Me.GroupControl12.Controls.Add(Me.LabelControl38)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukIl)
        Me.GroupControl12.Controls.Add(Me.LabelControl37)
        Me.GroupControl12.Controls.Add(Me.txt_sAnneAdi)
        Me.GroupControl12.Controls.Add(Me.LabelControl35)
        Me.GroupControl12.Controls.Add(Me.LabelControl36)
        Me.GroupControl12.Controls.Add(Me.txt_sBabaAdi)
        Me.GroupControl12.Controls.Add(Me.LabelControl34)
        Me.GroupControl12.Controls.Add(Me.LabelControl33)
        Me.GroupControl12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl12.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl12.Name = "GroupControl12"
        Me.GroupControl12.Size = New System.Drawing.Size(1300, 446)
        Me.GroupControl12.TabIndex = 66
        '
        'TextEdit31
        '
        Me.TextEdit31.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sSeri", True))
        Me.TextEdit31.EnterMoveNextControl = True
        Me.TextEdit31.Location = New System.Drawing.Point(122, 317)
        Me.TextEdit31.Name = "TextEdit31"
        Me.TextEdit31.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit31.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit31.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit31.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit31.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit31.Properties.MaxLength = 60
        Me.TextEdit31.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit31.TabIndex = 103
        '
        'ds_tbMusteriNufusu
        '
        Me.ds_tbMusteriNufusu.DataSetName = "NewDataSet"
        Me.ds_tbMusteriNufusu.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriNufusu.Tables.AddRange(New System.Data.DataTable() {Me.DataTable8})
        '
        'DataTable8
        '
        Me.DataTable8.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn102, Me.DataColumn103, Me.DataColumn104, Me.DataColumn105, Me.DataColumn106, Me.DataColumn107, Me.DataColumn108, Me.DataColumn109, Me.DataColumn110, Me.DataColumn111, Me.DataColumn112, Me.DataColumn113, Me.DataColumn114, Me.DataColumn115, Me.DataColumn116, Me.DataColumn117, Me.DataColumn118, Me.DataColumn119, Me.DataColumn120, Me.DataColumn121, Me.DataColumn122, Me.DataColumn223, Me.DataColumn224})
        Me.DataTable8.TableName = "Table1"
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "nMusteriID"
        Me.DataColumn102.DataType = GetType(Long)
        '
        'DataColumn103
        '
        Me.DataColumn103.ColumnName = "sDin"
        '
        'DataColumn104
        '
        Me.DataColumn104.ColumnName = "sKutukIl"
        '
        'DataColumn105
        '
        Me.DataColumn105.ColumnName = "sKutukIlce"
        '
        'DataColumn106
        '
        Me.DataColumn106.ColumnName = "sKutukMahalle"
        '
        'DataColumn107
        '
        Me.DataColumn107.ColumnName = "sKutukCiltNo"
        '
        'DataColumn108
        '
        Me.DataColumn108.ColumnName = "sKutukSiraNo"
        '
        'DataColumn109
        '
        Me.DataColumn109.ColumnName = "dteNufusCuzdanTarihi"
        Me.DataColumn109.DataType = GetType(Date)
        '
        'DataColumn110
        '
        Me.DataColumn110.ColumnName = "sCuzdanVerilenYer"
        '
        'DataColumn111
        '
        Me.DataColumn111.ColumnName = "sCuzdanVerNedeni"
        '
        'DataColumn112
        '
        Me.DataColumn112.ColumnName = "sCuzdanKayitNo"
        '
        'DataColumn113
        '
        Me.DataColumn113.ColumnName = "sAnneAdi"
        '
        'DataColumn114
        '
        Me.DataColumn114.ColumnName = "sBabaAdi"
        '
        'DataColumn115
        '
        Me.DataColumn115.ColumnName = "sAileAdresi1"
        '
        'DataColumn116
        '
        Me.DataColumn116.ColumnName = "sAileAdresi2"
        '
        'DataColumn117
        '
        Me.DataColumn117.ColumnName = "sAileSemt"
        '
        'DataColumn118
        '
        Me.DataColumn118.ColumnName = "sAilePostaKodu"
        '
        'DataColumn119
        '
        Me.DataColumn119.ColumnName = "sAileIl"
        '
        'DataColumn120
        '
        Me.DataColumn120.ColumnName = "sAileTelefonu"
        '
        'DataColumn121
        '
        Me.DataColumn121.ColumnName = "sHitapAnne"
        '
        'DataColumn122
        '
        Me.DataColumn122.ColumnName = "sHitapBaba"
        '
        'DataColumn223
        '
        Me.DataColumn223.ColumnName = "sSeriNo"
        '
        'DataColumn224
        '
        Me.DataColumn224.Caption = "sSeri"
        Me.DataColumn224.ColumnName = "sSeri"
        '
        'LabelControl131
        '
        Me.LabelControl131.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl131.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl131.Location = New System.Drawing.Point(75, 321)
        Me.LabelControl131.Name = "LabelControl131"
        Me.LabelControl131.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl131.TabIndex = 104
        Me.LabelControl131.Text = "Seri:"
        '
        'txt_sSeriNo
        '
        Me.txt_sSeriNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sSeriNo", True))
        Me.txt_sSeriNo.EnterMoveNextControl = True
        Me.txt_sSeriNo.Location = New System.Drawing.Point(122, 346)
        Me.txt_sSeriNo.Name = "txt_sSeriNo"
        Me.txt_sSeriNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSeriNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSeriNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSeriNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSeriNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSeriNo.Properties.MaxLength = 60
        Me.txt_sSeriNo.Size = New System.Drawing.Size(160, 26)
        Me.txt_sSeriNo.TabIndex = 101
        '
        'LabelControl130
        '
        Me.LabelControl130.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl130.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl130.Location = New System.Drawing.Point(50, 350)
        Me.LabelControl130.Name = "LabelControl130"
        Me.LabelControl130.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl130.TabIndex = 102
        Me.LabelControl130.Text = "Seri No:"
        '
        'txt_sAileIl
        '
        Me.txt_sAileIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sAileIl", True))
        Me.txt_sAileIl.EnterMoveNextControl = True
        Me.txt_sAileIl.Location = New System.Drawing.Point(802, 233)
        Me.txt_sAileIl.Name = "txt_sAileIl"
        Me.txt_sAileIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sAileIl.Properties.DisplayMember = "sIl"
        Me.txt_sAileIl.Properties.NullText = "[Il]"
        Me.txt_sAileIl.Properties.ValueMember = "sIl"
        Me.txt_sAileIl.Size = New System.Drawing.Size(358, 26)
        Me.txt_sAileIl.TabIndex = 80
        '
        'txt_sHitap3
        '
        Me.txt_sHitap3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sHitapAnne", True))
        Me.txt_sHitap3.EnterMoveNextControl = True
        Me.txt_sHitap3.Location = New System.Drawing.Point(122, 89)
        Me.txt_sHitap3.Name = "txt_sHitap3"
        Me.txt_sHitap3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap3.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap3.Properties.NullText = "[Hitap]"
        Me.txt_sHitap3.Properties.ValueMember = "sHitap"
        Me.txt_sHitap3.Size = New System.Drawing.Size(160, 26)
        Me.txt_sHitap3.TabIndex = 64
        '
        'txt_sHitap2
        '
        Me.txt_sHitap2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sHitapBaba", True))
        Me.txt_sHitap2.EnterMoveNextControl = True
        Me.txt_sHitap2.Location = New System.Drawing.Point(122, 31)
        Me.txt_sHitap2.Name = "txt_sHitap2"
        Me.txt_sHitap2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap2.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap2.Properties.NullText = "[Hitap]"
        Me.txt_sHitap2.Properties.ValueMember = "sHitap"
        Me.txt_sHitap2.Size = New System.Drawing.Size(160, 26)
        Me.txt_sHitap2.TabIndex = 62
        '
        'txt_sAileTelefonu
        '
        Me.txt_sAileTelefonu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sAileTelefonu", True))
        Me.txt_sAileTelefonu.EnterMoveNextControl = True
        Me.txt_sAileTelefonu.Location = New System.Drawing.Point(802, 261)
        Me.txt_sAileTelefonu.Name = "txt_sAileTelefonu"
        Me.txt_sAileTelefonu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileTelefonu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileTelefonu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileTelefonu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileTelefonu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileTelefonu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sAileTelefonu.Properties.Items.AddRange(New Object() {"", "SSK", "Bağkur", "EmekliSandığı", "Diğer"})
        Me.txt_sAileTelefonu.Properties.MaxLength = 20
        Me.txt_sAileTelefonu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_sAileTelefonu.Size = New System.Drawing.Size(358, 26)
        Me.txt_sAileTelefonu.TabIndex = 81
        '
        'txt_sSigortaNo
        '
        Me.txt_sSigortaNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteri, "Table1.sSigortaNo", True))
        Me.txt_sSigortaNo.EnterMoveNextControl = True
        Me.txt_sSigortaNo.Location = New System.Drawing.Point(802, 290)
        Me.txt_sSigortaNo.Name = "txt_sSigortaNo"
        Me.txt_sSigortaNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSigortaNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSigortaNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSigortaNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSigortaNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSigortaNo.Properties.MaxLength = 60
        Me.txt_sSigortaNo.Size = New System.Drawing.Size(358, 26)
        Me.txt_sSigortaNo.TabIndex = 82
        '
        'LabelControl51
        '
        Me.LabelControl51.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl51.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl51.Location = New System.Drawing.Point(710, 290)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl51.TabIndex = 100
        Me.LabelControl51.Text = "SigortaNo:"
        '
        'LabelControl50
        '
        Me.LabelControl50.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl50.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl50.Location = New System.Drawing.Point(683, 261)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl50.TabIndex = 99
        Me.LabelControl50.Text = "SigortaKurum:"
        '
        'LabelControl49
        '
        Me.LabelControl49.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl49.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl49.Location = New System.Drawing.Point(776, 233)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl49.TabIndex = 98
        Me.LabelControl49.Text = "İl:"
        '
        'txt_sAilePostaKodu
        '
        Me.txt_sAilePostaKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sAilePostaKodu", True))
        Me.txt_sAilePostaKodu.EnterMoveNextControl = True
        Me.txt_sAilePostaKodu.Location = New System.Drawing.Point(802, 204)
        Me.txt_sAilePostaKodu.Name = "txt_sAilePostaKodu"
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAilePostaKodu.Size = New System.Drawing.Size(128, 26)
        Me.txt_sAilePostaKodu.TabIndex = 79
        '
        'LabelControl48
        '
        Me.LabelControl48.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl48.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl48.Location = New System.Drawing.Point(704, 204)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl48.TabIndex = 97
        Me.LabelControl48.Text = "PostaKodu:"
        '
        'txt_sAileSemt
        '
        Me.txt_sAileSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sAileSemt", True))
        Me.txt_sAileSemt.EnterMoveNextControl = True
        Me.txt_sAileSemt.Location = New System.Drawing.Point(802, 176)
        Me.txt_sAileSemt.Name = "txt_sAileSemt"
        Me.txt_sAileSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileSemt.Properties.MaxLength = 60
        Me.txt_sAileSemt.Size = New System.Drawing.Size(358, 26)
        Me.txt_sAileSemt.TabIndex = 78
        '
        'LabelControl47
        '
        Me.LabelControl47.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl47.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl47.Location = New System.Drawing.Point(747, 176)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl47.TabIndex = 96
        Me.LabelControl47.Text = "Semt:"
        '
        'txt_sAileAdresi2
        '
        Me.txt_sAileAdresi2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sAileAdresi2", True))
        Me.txt_sAileAdresi2.EnterMoveNextControl = True
        Me.txt_sAileAdresi2.Location = New System.Drawing.Point(802, 147)
        Me.txt_sAileAdresi2.Name = "txt_sAileAdresi2"
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileAdresi2.Properties.MaxLength = 60
        Me.txt_sAileAdresi2.Size = New System.Drawing.Size(358, 26)
        Me.txt_sAileAdresi2.TabIndex = 77
        '
        'txt_sAileAdresi1
        '
        Me.txt_sAileAdresi1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sAileAdresi1", True))
        Me.txt_sAileAdresi1.EnterMoveNextControl = True
        Me.txt_sAileAdresi1.Location = New System.Drawing.Point(802, 119)
        Me.txt_sAileAdresi1.Name = "txt_sAileAdresi1"
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileAdresi1.Properties.MaxLength = 60
        Me.txt_sAileAdresi1.Size = New System.Drawing.Size(358, 26)
        Me.txt_sAileAdresi1.TabIndex = 76
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl46.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl46.Location = New System.Drawing.Point(710, 119)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(78, 19)
        Me.LabelControl46.TabIndex = 95
        Me.LabelControl46.Text = "AileAdresi:"
        '
        'txt_sCuzdanKayitNo
        '
        Me.txt_sCuzdanKayitNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sCuzdanKayitNo", True))
        Me.txt_sCuzdanKayitNo.EnterMoveNextControl = True
        Me.txt_sCuzdanKayitNo.Location = New System.Drawing.Point(802, 90)
        Me.txt_sCuzdanKayitNo.Name = "txt_sCuzdanKayitNo"
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sCuzdanKayitNo.Properties.MaxLength = 60
        Me.txt_sCuzdanKayitNo.Size = New System.Drawing.Size(230, 26)
        Me.txt_sCuzdanKayitNo.TabIndex = 75
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl45.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl45.Location = New System.Drawing.Point(691, 90)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl45.TabIndex = 94
        Me.LabelControl45.Text = "T.C.KimlikNo:"
        '
        'txt_sCuzdanVerNedeni
        '
        Me.txt_sCuzdanVerNedeni.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sCuzdanVerNedeni", True))
        Me.txt_sCuzdanVerNedeni.EnterMoveNextControl = True
        Me.txt_sCuzdanVerNedeni.Location = New System.Drawing.Point(802, 61)
        Me.txt_sCuzdanVerNedeni.Name = "txt_sCuzdanVerNedeni"
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sCuzdanVerNedeni.Properties.MaxLength = 60
        Me.txt_sCuzdanVerNedeni.Size = New System.Drawing.Size(358, 26)
        Me.txt_sCuzdanVerNedeni.TabIndex = 74
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl44.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl44.Location = New System.Drawing.Point(690, 61)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl44.TabIndex = 93
        Me.LabelControl44.Text = "VerilişNedeni:"
        '
        'txt_sCuzdanVerilenYer
        '
        Me.txt_sCuzdanVerilenYer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sCuzdanVerilenYer", True))
        Me.txt_sCuzdanVerilenYer.EnterMoveNextControl = True
        Me.txt_sCuzdanVerilenYer.Location = New System.Drawing.Point(802, 33)
        Me.txt_sCuzdanVerilenYer.Name = "txt_sCuzdanVerilenYer"
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sCuzdanVerilenYer.Properties.MaxLength = 60
        Me.txt_sCuzdanVerilenYer.Size = New System.Drawing.Size(358, 26)
        Me.txt_sCuzdanVerilenYer.TabIndex = 73
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl43.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl43.Location = New System.Drawing.Point(709, 33)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl43.TabIndex = 92
        Me.LabelControl43.Text = "VerilenYer:"
        '
        'txt_dteNufusCuzdanTarihi
        '
        Me.txt_dteNufusCuzdanTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.dteNufusCuzdanTarihi", True))
        Me.txt_dteNufusCuzdanTarihi.EditValue = Nothing
        Me.txt_dteNufusCuzdanTarihi.EnterMoveNextControl = True
        Me.txt_dteNufusCuzdanTarihi.Location = New System.Drawing.Point(122, 289)
        Me.txt_dteNufusCuzdanTarihi.Name = "txt_dteNufusCuzdanTarihi"
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteNufusCuzdanTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteNufusCuzdanTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteNufusCuzdanTarihi.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteNufusCuzdanTarihi.TabIndex = 72
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl42.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl42.Location = New System.Drawing.Point(6, 289)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl42.TabIndex = 91
        Me.LabelControl42.Text = "CüzdanTarihi:"
        '
        'txt_sKutukSiraNo
        '
        Me.txt_sKutukSiraNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sKutukSiraNo", True))
        Me.txt_sKutukSiraNo.EnterMoveNextControl = True
        Me.txt_sKutukSiraNo.Location = New System.Drawing.Point(122, 260)
        Me.txt_sKutukSiraNo.Name = "txt_sKutukSiraNo"
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukSiraNo.Properties.MaxLength = 60
        Me.txt_sKutukSiraNo.Size = New System.Drawing.Size(160, 26)
        Me.txt_sKutukSiraNo.TabIndex = 71
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl41.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl41.Location = New System.Drawing.Point(13, 266)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(93, 19)
        Me.LabelControl41.TabIndex = 90
        Me.LabelControl41.Text = "KütükSıraNo:"
        '
        'txt_sKutukCiltNo
        '
        Me.txt_sKutukCiltNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sKutukCiltNo", True))
        Me.txt_sKutukCiltNo.EnterMoveNextControl = True
        Me.txt_sKutukCiltNo.Location = New System.Drawing.Point(122, 231)
        Me.txt_sKutukCiltNo.Name = "txt_sKutukCiltNo"
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukCiltNo.Properties.MaxLength = 60
        Me.txt_sKutukCiltNo.Size = New System.Drawing.Size(160, 26)
        Me.txt_sKutukCiltNo.TabIndex = 70
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl40.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl40.Location = New System.Drawing.Point(18, 231)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(89, 19)
        Me.LabelControl40.TabIndex = 89
        Me.LabelControl40.Text = "KütükCiltNo:"
        '
        'txt_sKutukMahalle
        '
        Me.txt_sKutukMahalle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sKutukMahalle", True))
        Me.txt_sKutukMahalle.EnterMoveNextControl = True
        Me.txt_sKutukMahalle.Location = New System.Drawing.Point(122, 203)
        Me.txt_sKutukMahalle.Name = "txt_sKutukMahalle"
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukMahalle.Properties.MaxLength = 60
        Me.txt_sKutukMahalle.Size = New System.Drawing.Size(256, 26)
        Me.txt_sKutukMahalle.TabIndex = 69
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl39.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl39.Location = New System.Drawing.Point(5, 203)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl39.TabIndex = 88
        Me.LabelControl39.Text = "KütükMahalle:"
        '
        'txt_sKutukIlce
        '
        Me.txt_sKutukIlce.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sKutukIlce", True))
        Me.txt_sKutukIlce.EnterMoveNextControl = True
        Me.txt_sKutukIlce.Location = New System.Drawing.Point(122, 174)
        Me.txt_sKutukIlce.Name = "txt_sKutukIlce"
        Me.txt_sKutukIlce.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIlce.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIlce.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukIlce.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukIlce.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukIlce.Properties.MaxLength = 60
        Me.txt_sKutukIlce.Size = New System.Drawing.Size(256, 26)
        Me.txt_sKutukIlce.TabIndex = 67
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl38.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl38.Location = New System.Drawing.Point(35, 174)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl38.TabIndex = 87
        Me.LabelControl38.Text = "Kütükİlçe:"
        '
        'txt_sKutukIl
        '
        Me.txt_sKutukIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sKutukIl", True))
        Me.txt_sKutukIl.EnterMoveNextControl = True
        Me.txt_sKutukIl.Location = New System.Drawing.Point(122, 146)
        Me.txt_sKutukIl.Name = "txt_sKutukIl"
        Me.txt_sKutukIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukIl.Properties.MaxLength = 60
        Me.txt_sKutukIl.Size = New System.Drawing.Size(256, 26)
        Me.txt_sKutukIl.TabIndex = 66
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl37.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl37.Location = New System.Drawing.Point(53, 146)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl37.TabIndex = 86
        Me.LabelControl37.Text = "Kütükİl:"
        '
        'txt_sAnneAdi
        '
        Me.txt_sAnneAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sAnneAdi", True))
        Me.txt_sAnneAdi.EnterMoveNextControl = True
        Me.txt_sAnneAdi.Location = New System.Drawing.Point(122, 117)
        Me.txt_sAnneAdi.Name = "txt_sAnneAdi"
        Me.txt_sAnneAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAnneAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAnneAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAnneAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAnneAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAnneAdi.Properties.MaxLength = 60
        Me.txt_sAnneAdi.Size = New System.Drawing.Size(358, 26)
        Me.txt_sAnneAdi.TabIndex = 65
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl35.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl35.Location = New System.Drawing.Point(42, 117)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl35.TabIndex = 85
        Me.LabelControl35.Text = "AnneAdı:"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl36.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl36.Location = New System.Drawing.Point(26, 89)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl36.TabIndex = 84
        Me.LabelControl36.Text = "AnneHitap:"
        '
        'txt_sBabaAdi
        '
        Me.txt_sBabaAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriNufusu, "Table1.sBabaAdi", True))
        Me.txt_sBabaAdi.EnterMoveNextControl = True
        Me.txt_sBabaAdi.Location = New System.Drawing.Point(122, 60)
        Me.txt_sBabaAdi.Name = "txt_sBabaAdi"
        Me.txt_sBabaAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBabaAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBabaAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sBabaAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sBabaAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sBabaAdi.Properties.MaxLength = 60
        Me.txt_sBabaAdi.Size = New System.Drawing.Size(358, 26)
        Me.txt_sBabaAdi.TabIndex = 63
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl34.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl34.Location = New System.Drawing.Point(43, 60)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(64, 19)
        Me.LabelControl34.TabIndex = 83
        Me.LabelControl34.Text = "BabaAdı:"
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl33.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl33.Location = New System.Drawing.Point(27, 31)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl33.TabIndex = 68
        Me.LabelControl33.Text = "BabaHitap:"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(674, 379)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(499, 32)
        Me.SimpleButton5.TabIndex = 65
        Me.SimpleButton5.Text = "2.Kefil Nüfus Bilgileri"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(18, 379)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(499, 32)
        Me.SimpleButton4.TabIndex = 64
        Me.SimpleButton4.Text = "1.Kefil Nüfus Bilgileri"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GroupControl6)
        Me.XtraTabPage4.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage4.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage4.Text = "1.Kefil"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl6.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.txt_sKefil1IsIl)
        Me.GroupControl6.Controls.Add(Me.TextEdit56)
        Me.GroupControl6.Controls.Add(Me.TextEdit49)
        Me.GroupControl6.Controls.Add(Me.LabelControl63)
        Me.GroupControl6.Controls.Add(Me.LabelControl64)
        Me.GroupControl6.Controls.Add(Me.TextEdit50)
        Me.GroupControl6.Controls.Add(Me.LabelControl65)
        Me.GroupControl6.Controls.Add(Me.TextEdit52)
        Me.GroupControl6.Controls.Add(Me.LabelControl66)
        Me.GroupControl6.Controls.Add(Me.TextEdit53)
        Me.GroupControl6.Controls.Add(Me.LabelControl67)
        Me.GroupControl6.Controls.Add(Me.LabelControl68)
        Me.GroupControl6.Controls.Add(Me.TextEdit54)
        Me.GroupControl6.Controls.Add(Me.TextEdit55)
        Me.GroupControl6.Controls.Add(Me.LabelControl69)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl6.Location = New System.Drawing.Point(0, 236)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(1300, 165)
        Me.GroupControl6.TabIndex = 3
        Me.GroupControl6.Text = "İş Adresi"
        '
        'txt_sKefil1IsIl
        '
        Me.txt_sKefil1IsIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sIsIl", True))
        Me.txt_sKefil1IsIl.EnterMoveNextControl = True
        Me.txt_sKefil1IsIl.Location = New System.Drawing.Point(870, 87)
        Me.txt_sKefil1IsIl.Name = "txt_sKefil1IsIl"
        Me.txt_sKefil1IsIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil1IsIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil1IsIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil1IsIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil1IsIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil1IsIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sKefil1IsIl.Properties.DisplayMember = "sIl"
        Me.txt_sKefil1IsIl.Properties.LookAndFeel.SkinName = "VS2010"
        Me.txt_sKefil1IsIl.Properties.NullText = "[Il]"
        Me.txt_sKefil1IsIl.Properties.ValueMember = "sIl"
        Me.txt_sKefil1IsIl.Size = New System.Drawing.Size(359, 26)
        Me.txt_sKefil1IsIl.TabIndex = 18
        '
        'ds_tbMusteriKefil1
        '
        Me.ds_tbMusteriKefil1.DataSetName = "NewDataSet"
        Me.ds_tbMusteriKefil1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriKefil1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable9})
        '
        'DataTable9
        '
        Me.DataTable9.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn123, Me.DataColumn124, Me.DataColumn125, Me.DataColumn126, Me.DataColumn127, Me.DataColumn128, Me.DataColumn129, Me.DataColumn130, Me.DataColumn131, Me.DataColumn132, Me.DataColumn133, Me.DataColumn134, Me.DataColumn135, Me.DataColumn136, Me.DataColumn137, Me.DataColumn138, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn145})
        Me.DataTable9.TableName = "Table1"
        '
        'DataColumn123
        '
        Me.DataColumn123.ColumnName = "nMusteriID"
        Me.DataColumn123.DataType = GetType(Long)
        '
        'DataColumn124
        '
        Me.DataColumn124.ColumnName = "sAdi"
        '
        'DataColumn125
        '
        Me.DataColumn125.ColumnName = "sSoyadi"
        '
        'DataColumn126
        '
        Me.DataColumn126.ColumnName = "sUnvan"
        '
        'DataColumn127
        '
        Me.DataColumn127.ColumnName = "sEmail"
        '
        'DataColumn128
        '
        Me.DataColumn128.ColumnName = "sIsYeriAdi"
        '
        'DataColumn129
        '
        Me.DataColumn129.ColumnName = "sIsAdresi1"
        '
        'DataColumn130
        '
        Me.DataColumn130.ColumnName = "sIsAdresi2"
        '
        'DataColumn131
        '
        Me.DataColumn131.ColumnName = "sIsSemt"
        '
        'DataColumn132
        '
        Me.DataColumn132.ColumnName = "sIsPostaKodu"
        '
        'DataColumn133
        '
        Me.DataColumn133.ColumnName = "sIsIl"
        '
        'DataColumn134
        '
        Me.DataColumn134.ColumnName = "sIsTelefonu"
        '
        'DataColumn135
        '
        Me.DataColumn135.ColumnName = "sEvAdresi2"
        '
        'DataColumn136
        '
        Me.DataColumn136.ColumnName = "sEvSemt"
        '
        'DataColumn137
        '
        Me.DataColumn137.ColumnName = "sEvPostaKodu"
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "sEvIl"
        '
        'DataColumn139
        '
        Me.DataColumn139.ColumnName = "sEvTelefonu"
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "lAylikGelir"
        Me.DataColumn140.DataType = GetType(Decimal)
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "sSigortaNo"
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "sHitap"
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "sKullaniciAdi"
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "dteKayitTarihi"
        Me.DataColumn144.DataType = GetType(Date)
        '
        'DataColumn145
        '
        Me.DataColumn145.ColumnName = "sEvAdresi1"
        '
        'TextEdit56
        '
        Me.TextEdit56.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sIsYeriAdi", True))
        Me.TextEdit56.EnterMoveNextControl = True
        Me.TextEdit56.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit56.Name = "TextEdit56"
        Me.TextEdit56.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit56.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit56.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit56.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit56.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit56.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit56.Properties.MaxLength = 60
        Me.TextEdit56.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit56.TabIndex = 12
        '
        'TextEdit49
        '
        Me.TextEdit49.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sEmail", True))
        Me.TextEdit49.EnterMoveNextControl = True
        Me.TextEdit49.Location = New System.Drawing.Point(870, 116)
        Me.TextEdit49.Name = "TextEdit49"
        Me.TextEdit49.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit49.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit49.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit49.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit49.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit49.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit49.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit49.TabIndex = 19
        '
        'LabelControl63
        '
        Me.LabelControl63.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl63.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl63.Location = New System.Drawing.Point(755, 116)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl63.TabIndex = 36
        Me.LabelControl63.Text = "E-Mail:"
        '
        'LabelControl64
        '
        Me.LabelControl64.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl64.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl64.Location = New System.Drawing.Point(13, 116)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl64.TabIndex = 35
        Me.LabelControl64.Text = "Telefon/Gsm:"
        '
        'TextEdit50
        '
        Me.TextEdit50.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sIsTelefonu", True))
        Me.TextEdit50.EnterMoveNextControl = True
        Me.TextEdit50.Location = New System.Drawing.Point(128, 116)
        Me.TextEdit50.Name = "TextEdit50"
        Me.TextEdit50.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit50.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit50.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit50.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit50.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit50.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit50.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit50.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit50.Properties.Mask.SaveLiteral = False
        Me.TextEdit50.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit50.Properties.MaxLength = 20
        Me.TextEdit50.Size = New System.Drawing.Size(230, 26)
        Me.TextEdit50.TabIndex = 15
        '
        'LabelControl65
        '
        Me.LabelControl65.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl65.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl65.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl65.TabIndex = 32
        Me.LabelControl65.Text = "İl:"
        '
        'TextEdit52
        '
        Me.TextEdit52.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sIsPostaKodu", True))
        Me.TextEdit52.EnterMoveNextControl = True
        Me.TextEdit52.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit52.Name = "TextEdit52"
        Me.TextEdit52.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit52.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit52.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit52.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit52.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit52.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit52.Properties.MaxLength = 20
        Me.TextEdit52.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit52.TabIndex = 17
        '
        'LabelControl66
        '
        Me.LabelControl66.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl66.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl66.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl66.TabIndex = 30
        Me.LabelControl66.Text = "PostaKodu:"
        '
        'TextEdit53
        '
        Me.TextEdit53.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sIsSemt", True))
        Me.TextEdit53.EnterMoveNextControl = True
        Me.TextEdit53.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit53.Name = "TextEdit53"
        Me.TextEdit53.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit53.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit53.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit53.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit53.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit53.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit53.Properties.MaxLength = 60
        Me.TextEdit53.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit53.TabIndex = 16
        '
        'LabelControl67
        '
        Me.LabelControl67.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl67.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl67.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl67.TabIndex = 28
        Me.LabelControl67.Text = "Semt:"
        '
        'LabelControl68
        '
        Me.LabelControl68.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl68.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl68.Location = New System.Drawing.Point(13, 59)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl68.TabIndex = 27
        Me.LabelControl68.Text = "Adres:"
        '
        'TextEdit54
        '
        Me.TextEdit54.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sIsAdresi2", True))
        Me.TextEdit54.EnterMoveNextControl = True
        Me.TextEdit54.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit54.Name = "TextEdit54"
        Me.TextEdit54.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit54.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit54.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit54.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit54.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit54.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit54.Properties.MaxLength = 60
        Me.TextEdit54.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit54.TabIndex = 14
        '
        'TextEdit55
        '
        Me.TextEdit55.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sIsAdresi1", True))
        Me.TextEdit55.EnterMoveNextControl = True
        Me.TextEdit55.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit55.Name = "TextEdit55"
        Me.TextEdit55.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit55.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit55.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit55.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit55.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit55.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit55.Properties.MaxLength = 60
        Me.TextEdit55.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit55.TabIndex = 13
        '
        'LabelControl69
        '
        Me.LabelControl69.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl69.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl69.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl69.TabIndex = 23
        Me.LabelControl69.Text = "İşYeriAdı:"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl5.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.txt_sKefil1EvIl)
        Me.GroupControl5.Controls.Add(Me.LabelControl58)
        Me.GroupControl5.Controls.Add(Me.TextEdit44)
        Me.GroupControl5.Controls.Add(Me.LabelControl59)
        Me.GroupControl5.Controls.Add(Me.TextEdit45)
        Me.GroupControl5.Controls.Add(Me.LabelControl60)
        Me.GroupControl5.Controls.Add(Me.LabelControl61)
        Me.GroupControl5.Controls.Add(Me.TextEdit46)
        Me.GroupControl5.Controls.Add(Me.TextEdit47)
        Me.GroupControl5.Controls.Add(Me.TextEdit48)
        Me.GroupControl5.Controls.Add(Me.LabelControl62)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl5.Location = New System.Drawing.Point(0, 99)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1300, 137)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Ev Adresi"
        '
        'txt_sKefil1EvIl
        '
        Me.txt_sKefil1EvIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sEvIl", True))
        Me.txt_sKefil1EvIl.EnterMoveNextControl = True
        Me.txt_sKefil1EvIl.Location = New System.Drawing.Point(870, 87)
        Me.txt_sKefil1EvIl.Name = "txt_sKefil1EvIl"
        Me.txt_sKefil1EvIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil1EvIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil1EvIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil1EvIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil1EvIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil1EvIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sKefil1EvIl.Properties.DisplayMember = "sIl"
        Me.txt_sKefil1EvIl.Properties.LookAndFeel.SkinName = "VS2010"
        Me.txt_sKefil1EvIl.Properties.NullText = "[Il]"
        Me.txt_sKefil1EvIl.Properties.ValueMember = "sIl"
        Me.txt_sKefil1EvIl.Size = New System.Drawing.Size(359, 26)
        Me.txt_sKefil1EvIl.TabIndex = 11
        '
        'LabelControl58
        '
        Me.LabelControl58.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl58.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl58.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl58.TabIndex = 32
        Me.LabelControl58.Text = "İl:"
        '
        'TextEdit44
        '
        Me.TextEdit44.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sEvPostaKodu", True))
        Me.TextEdit44.EnterMoveNextControl = True
        Me.TextEdit44.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit44.Name = "TextEdit44"
        Me.TextEdit44.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit44.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit44.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit44.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit44.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit44.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit44.Properties.MaxLength = 20
        Me.TextEdit44.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit44.TabIndex = 10
        '
        'LabelControl59
        '
        Me.LabelControl59.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl59.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl59.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl59.TabIndex = 30
        Me.LabelControl59.Text = "PostaKodu:"
        '
        'TextEdit45
        '
        Me.TextEdit45.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sEvSemt", True))
        Me.TextEdit45.EnterMoveNextControl = True
        Me.TextEdit45.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit45.Name = "TextEdit45"
        Me.TextEdit45.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit45.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit45.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit45.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit45.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit45.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit45.Properties.MaxLength = 60
        Me.TextEdit45.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit45.TabIndex = 9
        '
        'LabelControl60
        '
        Me.LabelControl60.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl60.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl60.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl60.TabIndex = 28
        Me.LabelControl60.Text = "Semt:"
        '
        'LabelControl61
        '
        Me.LabelControl61.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl61.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl61.Location = New System.Drawing.Point(13, 87)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl61.TabIndex = 27
        Me.LabelControl61.Text = "Telefon:"
        '
        'TextEdit46
        '
        Me.TextEdit46.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sEvTelefonu", True))
        Me.TextEdit46.EnterMoveNextControl = True
        Me.TextEdit46.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit46.Name = "TextEdit46"
        Me.TextEdit46.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit46.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit46.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit46.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit46.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit46.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit46.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit46.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit46.Properties.Mask.SaveLiteral = False
        Me.TextEdit46.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit46.Properties.MaxLength = 20
        Me.TextEdit46.Size = New System.Drawing.Size(218, 26)
        Me.TextEdit46.TabIndex = 8
        '
        'TextEdit47
        '
        Me.TextEdit47.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sEvAdresi2", True))
        Me.TextEdit47.EnterMoveNextControl = True
        Me.TextEdit47.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit47.Name = "TextEdit47"
        Me.TextEdit47.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit47.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit47.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit47.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit47.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit47.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit47.Properties.MaxLength = 60
        Me.TextEdit47.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit47.TabIndex = 7
        '
        'TextEdit48
        '
        Me.TextEdit48.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sEvAdresi1", True))
        Me.TextEdit48.EnterMoveNextControl = True
        Me.TextEdit48.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit48.Name = "TextEdit48"
        Me.TextEdit48.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit48.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit48.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit48.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit48.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit48.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit48.Properties.MaxLength = 60
        Me.TextEdit48.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit48.TabIndex = 6
        '
        'LabelControl62
        '
        Me.LabelControl62.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl62.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl62.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl62.TabIndex = 23
        Me.LabelControl62.Text = "Adres:"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.SimpleButton6)
        Me.GroupControl4.Controls.Add(Me.txt_sHitap4)
        Me.GroupControl4.Controls.Add(Me.txt_sUnvan2)
        Me.GroupControl4.Controls.Add(Me.LabelControl54)
        Me.GroupControl4.Controls.Add(Me.CalcEdit2)
        Me.GroupControl4.Controls.Add(Me.LabelControl57)
        Me.GroupControl4.Controls.Add(Me.TextEdit42)
        Me.GroupControl4.Controls.Add(Me.LabelControl56)
        Me.GroupControl4.Controls.Add(Me.LabelControl55)
        Me.GroupControl4.Controls.Add(Me.TextEdit39)
        Me.GroupControl4.Controls.Add(Me.TextEdit41)
        Me.GroupControl4.Controls.Add(Me.LabelControl53)
        Me.GroupControl4.Controls.Add(Me.LabelControl52)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1300, 99)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Özel Bilgiler"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(496, 60)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(232, 33)
        Me.SimpleButton6.TabIndex = 75
        Me.SimpleButton6.Text = "Kefilin Hesabını Bul"
        '
        'txt_sHitap4
        '
        Me.txt_sHitap4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sHitap", True))
        Me.txt_sHitap4.EnterMoveNextControl = True
        Me.txt_sHitap4.Location = New System.Drawing.Point(128, 29)
        Me.txt_sHitap4.Name = "txt_sHitap4"
        Me.txt_sHitap4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap4.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap4.Properties.LookAndFeel.SkinName = "VS2010"
        Me.txt_sHitap4.Properties.NullText = "[Hitap]"
        Me.txt_sHitap4.Properties.ValueMember = "sHitap"
        Me.txt_sHitap4.Size = New System.Drawing.Size(160, 26)
        Me.txt_sHitap4.TabIndex = 0
        '
        'txt_sUnvan2
        '
        Me.txt_sUnvan2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sUnvan", True))
        Me.txt_sUnvan2.EnterMoveNextControl = True
        Me.txt_sUnvan2.Location = New System.Drawing.Point(870, 31)
        Me.txt_sUnvan2.Name = "txt_sUnvan2"
        Me.txt_sUnvan2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sUnvan2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sUnvan2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sUnvan2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sUnvan2.Properties.DisplayMember = "sUnvan"
        Me.txt_sUnvan2.Properties.LookAndFeel.SkinName = "VS2010"
        Me.txt_sUnvan2.Properties.NullText = "[Ünvan]"
        Me.txt_sUnvan2.Properties.ValueMember = "sUnvan"
        Me.txt_sUnvan2.Size = New System.Drawing.Size(160, 26)
        Me.txt_sUnvan2.TabIndex = 73
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl54.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl54.Location = New System.Drawing.Point(291, 60)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl54.TabIndex = 36
        Me.LabelControl54.Text = "Soyad:"
        '
        'CalcEdit2
        '
        Me.CalcEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.lAylikGelir", True))
        Me.CalcEdit2.EnterMoveNextControl = True
        Me.CalcEdit2.Location = New System.Drawing.Point(1088, 60)
        Me.CalcEdit2.Name = "CalcEdit2"
        Me.CalcEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.CalcEdit2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.CalcEdit2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CalcEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit2.Properties.LookAndFeel.SkinName = "VS2010"
        Me.CalcEdit2.Size = New System.Drawing.Size(141, 26)
        Me.CalcEdit2.TabIndex = 5
        '
        'LabelControl57
        '
        Me.LabelControl57.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl57.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl57.Location = New System.Drawing.Point(1038, 63)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(39, 19)
        Me.LabelControl57.TabIndex = 34
        Me.LabelControl57.Text = "Gelir:"
        '
        'TextEdit42
        '
        Me.TextEdit42.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sSigortaNo", True))
        Me.TextEdit42.EnterMoveNextControl = True
        Me.TextEdit42.Location = New System.Drawing.Point(870, 60)
        Me.TextEdit42.Name = "TextEdit42"
        Me.TextEdit42.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit42.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit42.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit42.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit42.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit42.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit42.Properties.MaxLength = 60
        Me.TextEdit42.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit42.TabIndex = 4
        '
        'LabelControl56
        '
        Me.LabelControl56.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl56.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl56.Location = New System.Drawing.Point(755, 64)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl56.TabIndex = 32
        Me.LabelControl56.Text = "MüşteriNo:"
        '
        'LabelControl55
        '
        Me.LabelControl55.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl55.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl55.Location = New System.Drawing.Point(755, 33)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl55.TabIndex = 31
        Me.LabelControl55.Text = "Ünvan:"
        '
        'TextEdit39
        '
        Me.TextEdit39.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sSoyadi", True))
        Me.TextEdit39.EnterMoveNextControl = True
        Me.TextEdit39.Location = New System.Drawing.Point(346, 60)
        Me.TextEdit39.Name = "TextEdit39"
        Me.TextEdit39.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit39.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit39.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit39.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit39.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit39.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit39.Properties.MaxLength = 60
        Me.TextEdit39.Size = New System.Drawing.Size(140, 26)
        Me.TextEdit39.TabIndex = 2
        '
        'TextEdit41
        '
        Me.TextEdit41.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil1, "Table1.sAdi", True))
        Me.TextEdit41.EnterMoveNextControl = True
        Me.TextEdit41.Location = New System.Drawing.Point(128, 57)
        Me.TextEdit41.Name = "TextEdit41"
        Me.TextEdit41.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit41.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit41.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit41.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit41.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit41.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit41.Properties.MaxLength = 60
        Me.TextEdit41.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit41.TabIndex = 1
        '
        'LabelControl53
        '
        Me.LabelControl53.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl53.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl53.Location = New System.Drawing.Point(13, 60)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl53.TabIndex = 26
        Me.LabelControl53.Text = "Ad:"
        '
        'LabelControl52
        '
        Me.LabelControl52.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl52.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl52.Location = New System.Drawing.Point(13, 29)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl52.TabIndex = 7
        Me.LabelControl52.Text = "Hitap:"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GroupControl7)
        Me.XtraTabPage5.Controls.Add(Me.GroupControl8)
        Me.XtraTabPage5.Controls.Add(Me.GroupControl9)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage5.Text = "2.Kefil"
        '
        'GroupControl7
        '
        Me.GroupControl7.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl7.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl7.AppearanceCaption.Options.UseFont = True
        Me.GroupControl7.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.txt_sKefil2IsIl)
        Me.GroupControl7.Controls.Add(Me.TextEdit57)
        Me.GroupControl7.Controls.Add(Me.LabelControl70)
        Me.GroupControl7.Controls.Add(Me.LabelControl71)
        Me.GroupControl7.Controls.Add(Me.TextEdit58)
        Me.GroupControl7.Controls.Add(Me.LabelControl72)
        Me.GroupControl7.Controls.Add(Me.TextEdit60)
        Me.GroupControl7.Controls.Add(Me.LabelControl73)
        Me.GroupControl7.Controls.Add(Me.TextEdit61)
        Me.GroupControl7.Controls.Add(Me.LabelControl74)
        Me.GroupControl7.Controls.Add(Me.LabelControl75)
        Me.GroupControl7.Controls.Add(Me.TextEdit62)
        Me.GroupControl7.Controls.Add(Me.TextEdit63)
        Me.GroupControl7.Controls.Add(Me.TextEdit64)
        Me.GroupControl7.Controls.Add(Me.LabelControl76)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl7.Location = New System.Drawing.Point(0, 236)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(1300, 165)
        Me.GroupControl7.TabIndex = 6
        Me.GroupControl7.Text = "İş Adresi"
        '
        'txt_sKefil2IsIl
        '
        Me.txt_sKefil2IsIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sIsIl", True))
        Me.txt_sKefil2IsIl.EnterMoveNextControl = True
        Me.txt_sKefil2IsIl.Location = New System.Drawing.Point(870, 87)
        Me.txt_sKefil2IsIl.Name = "txt_sKefil2IsIl"
        Me.txt_sKefil2IsIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil2IsIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil2IsIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil2IsIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil2IsIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil2IsIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sKefil2IsIl.Properties.DisplayMember = "sIl"
        Me.txt_sKefil2IsIl.Properties.NullText = "[Il]"
        Me.txt_sKefil2IsIl.Properties.ValueMember = "sIl"
        Me.txt_sKefil2IsIl.Size = New System.Drawing.Size(359, 26)
        Me.txt_sKefil2IsIl.TabIndex = 37
        '
        'ds_tbMusteriKefil2
        '
        Me.ds_tbMusteriKefil2.DataSetName = "NewDataSet"
        Me.ds_tbMusteriKefil2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriKefil2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable10})
        '
        'DataTable10
        '
        Me.DataTable10.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn146, Me.DataColumn147, Me.DataColumn148, Me.DataColumn149, Me.DataColumn150, Me.DataColumn151, Me.DataColumn152, Me.DataColumn153, Me.DataColumn154, Me.DataColumn155, Me.DataColumn156, Me.DataColumn157, Me.DataColumn158, Me.DataColumn159, Me.DataColumn160, Me.DataColumn161, Me.DataColumn162, Me.DataColumn163, Me.DataColumn164, Me.DataColumn165, Me.DataColumn166, Me.DataColumn167, Me.DataColumn168})
        Me.DataTable10.TableName = "Table1"
        '
        'DataColumn146
        '
        Me.DataColumn146.ColumnName = "nMusteriID"
        Me.DataColumn146.DataType = GetType(Long)
        '
        'DataColumn147
        '
        Me.DataColumn147.ColumnName = "sAdi"
        '
        'DataColumn148
        '
        Me.DataColumn148.ColumnName = "sSoyadi"
        '
        'DataColumn149
        '
        Me.DataColumn149.ColumnName = "sUnvan"
        '
        'DataColumn150
        '
        Me.DataColumn150.ColumnName = "sEmail"
        '
        'DataColumn151
        '
        Me.DataColumn151.ColumnName = "sIsYeriAdi"
        '
        'DataColumn152
        '
        Me.DataColumn152.ColumnName = "sIsAdresi1"
        '
        'DataColumn153
        '
        Me.DataColumn153.ColumnName = "sIsAdresi2"
        '
        'DataColumn154
        '
        Me.DataColumn154.ColumnName = "sIsSemt"
        '
        'DataColumn155
        '
        Me.DataColumn155.ColumnName = "sIsPostaKodu"
        '
        'DataColumn156
        '
        Me.DataColumn156.ColumnName = "sIsIl"
        '
        'DataColumn157
        '
        Me.DataColumn157.ColumnName = "sIsTelefonu"
        '
        'DataColumn158
        '
        Me.DataColumn158.ColumnName = "sEvAdresi2"
        '
        'DataColumn159
        '
        Me.DataColumn159.ColumnName = "sEvSemt"
        '
        'DataColumn160
        '
        Me.DataColumn160.ColumnName = "sEvPostaKodu"
        '
        'DataColumn161
        '
        Me.DataColumn161.ColumnName = "sEvIl"
        '
        'DataColumn162
        '
        Me.DataColumn162.ColumnName = "sEvTelefonu"
        '
        'DataColumn163
        '
        Me.DataColumn163.ColumnName = "lAylikGelir"
        Me.DataColumn163.DataType = GetType(Decimal)
        '
        'DataColumn164
        '
        Me.DataColumn164.ColumnName = "sSigortaNo"
        '
        'DataColumn165
        '
        Me.DataColumn165.ColumnName = "sHitap"
        '
        'DataColumn166
        '
        Me.DataColumn166.ColumnName = "sKullaniciAdi"
        '
        'DataColumn167
        '
        Me.DataColumn167.ColumnName = "dteKayitTarihi"
        Me.DataColumn167.DataType = GetType(Date)
        '
        'DataColumn168
        '
        Me.DataColumn168.ColumnName = "sEvAdresi1"
        '
        'TextEdit57
        '
        Me.TextEdit57.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sEmail", True))
        Me.TextEdit57.EnterMoveNextControl = True
        Me.TextEdit57.Location = New System.Drawing.Point(870, 116)
        Me.TextEdit57.Name = "TextEdit57"
        Me.TextEdit57.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit57.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit57.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit57.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit57.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit57.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit57.TabIndex = 19
        '
        'LabelControl70
        '
        Me.LabelControl70.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl70.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl70.Location = New System.Drawing.Point(755, 116)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl70.TabIndex = 36
        Me.LabelControl70.Text = "E-Mail:"
        '
        'LabelControl71
        '
        Me.LabelControl71.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl71.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl71.Location = New System.Drawing.Point(13, 116)
        Me.LabelControl71.Name = "LabelControl71"
        Me.LabelControl71.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl71.TabIndex = 35
        Me.LabelControl71.Text = "Telefon/Gsm:"
        '
        'TextEdit58
        '
        Me.TextEdit58.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sIsTelefonu", True))
        Me.TextEdit58.EnterMoveNextControl = True
        Me.TextEdit58.Location = New System.Drawing.Point(128, 116)
        Me.TextEdit58.Name = "TextEdit58"
        Me.TextEdit58.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit58.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit58.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit58.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit58.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit58.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit58.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit58.Properties.Mask.SaveLiteral = False
        Me.TextEdit58.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit58.Properties.MaxLength = 20
        Me.TextEdit58.Size = New System.Drawing.Size(230, 26)
        Me.TextEdit58.TabIndex = 15
        '
        'LabelControl72
        '
        Me.LabelControl72.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl72.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl72.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl72.Name = "LabelControl72"
        Me.LabelControl72.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl72.TabIndex = 32
        Me.LabelControl72.Text = "İl:"
        '
        'TextEdit60
        '
        Me.TextEdit60.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sIsPostaKodu", True))
        Me.TextEdit60.EnterMoveNextControl = True
        Me.TextEdit60.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit60.Name = "TextEdit60"
        Me.TextEdit60.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit60.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit60.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit60.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit60.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit60.Properties.MaxLength = 20
        Me.TextEdit60.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit60.TabIndex = 17
        '
        'LabelControl73
        '
        Me.LabelControl73.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl73.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl73.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl73.Name = "LabelControl73"
        Me.LabelControl73.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl73.TabIndex = 30
        Me.LabelControl73.Text = "PostaKodu:"
        '
        'TextEdit61
        '
        Me.TextEdit61.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sIsSemt", True))
        Me.TextEdit61.EnterMoveNextControl = True
        Me.TextEdit61.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit61.Name = "TextEdit61"
        Me.TextEdit61.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit61.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit61.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit61.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit61.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit61.Properties.MaxLength = 60
        Me.TextEdit61.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit61.TabIndex = 16
        '
        'LabelControl74
        '
        Me.LabelControl74.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl74.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl74.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl74.Name = "LabelControl74"
        Me.LabelControl74.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl74.TabIndex = 28
        Me.LabelControl74.Text = "Semt:"
        '
        'LabelControl75
        '
        Me.LabelControl75.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl75.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl75.Location = New System.Drawing.Point(13, 59)
        Me.LabelControl75.Name = "LabelControl75"
        Me.LabelControl75.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl75.TabIndex = 27
        Me.LabelControl75.Text = "Adres:"
        '
        'TextEdit62
        '
        Me.TextEdit62.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sIsAdresi2", True))
        Me.TextEdit62.EnterMoveNextControl = True
        Me.TextEdit62.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit62.Name = "TextEdit62"
        Me.TextEdit62.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit62.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit62.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit62.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit62.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit62.Properties.MaxLength = 60
        Me.TextEdit62.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit62.TabIndex = 14
        '
        'TextEdit63
        '
        Me.TextEdit63.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sIsAdresi1", True))
        Me.TextEdit63.EnterMoveNextControl = True
        Me.TextEdit63.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit63.Name = "TextEdit63"
        Me.TextEdit63.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit63.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit63.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit63.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit63.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit63.Properties.MaxLength = 60
        Me.TextEdit63.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit63.TabIndex = 13
        '
        'TextEdit64
        '
        Me.TextEdit64.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sIsYeriAdi", True))
        Me.TextEdit64.EnterMoveNextControl = True
        Me.TextEdit64.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit64.Name = "TextEdit64"
        Me.TextEdit64.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit64.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit64.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit64.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit64.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit64.Properties.MaxLength = 60
        Me.TextEdit64.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit64.TabIndex = 12
        '
        'LabelControl76
        '
        Me.LabelControl76.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl76.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl76.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl76.Name = "LabelControl76"
        Me.LabelControl76.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl76.TabIndex = 23
        Me.LabelControl76.Text = "İşYeriAdı:"
        '
        'GroupControl8
        '
        Me.GroupControl8.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl8.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl8.AppearanceCaption.Options.UseFont = True
        Me.GroupControl8.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl8.Controls.Add(Me.txt_sKefil2EvIl)
        Me.GroupControl8.Controls.Add(Me.LabelControl77)
        Me.GroupControl8.Controls.Add(Me.TextEdit66)
        Me.GroupControl8.Controls.Add(Me.LabelControl78)
        Me.GroupControl8.Controls.Add(Me.TextEdit67)
        Me.GroupControl8.Controls.Add(Me.LabelControl79)
        Me.GroupControl8.Controls.Add(Me.LabelControl80)
        Me.GroupControl8.Controls.Add(Me.TextEdit68)
        Me.GroupControl8.Controls.Add(Me.TextEdit69)
        Me.GroupControl8.Controls.Add(Me.TextEdit70)
        Me.GroupControl8.Controls.Add(Me.LabelControl81)
        Me.GroupControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl8.Location = New System.Drawing.Point(0, 99)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(1300, 137)
        Me.GroupControl8.TabIndex = 5
        Me.GroupControl8.Text = "Ev Adresi"
        '
        'txt_sKefil2EvIl
        '
        Me.txt_sKefil2EvIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sEvIl", True))
        Me.txt_sKefil2EvIl.EnterMoveNextControl = True
        Me.txt_sKefil2EvIl.Location = New System.Drawing.Point(870, 87)
        Me.txt_sKefil2EvIl.Name = "txt_sKefil2EvIl"
        Me.txt_sKefil2EvIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil2EvIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil2EvIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil2EvIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil2EvIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil2EvIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sKefil2EvIl.Properties.DisplayMember = "sIl"
        Me.txt_sKefil2EvIl.Properties.NullText = "[Il]"
        Me.txt_sKefil2EvIl.Properties.ValueMember = "sIl"
        Me.txt_sKefil2EvIl.Size = New System.Drawing.Size(359, 26)
        Me.txt_sKefil2EvIl.TabIndex = 33
        '
        'LabelControl77
        '
        Me.LabelControl77.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl77.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl77.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl77.Name = "LabelControl77"
        Me.LabelControl77.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl77.TabIndex = 32
        Me.LabelControl77.Text = "İl:"
        '
        'TextEdit66
        '
        Me.TextEdit66.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sEvPostaKodu", True))
        Me.TextEdit66.EnterMoveNextControl = True
        Me.TextEdit66.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit66.Name = "TextEdit66"
        Me.TextEdit66.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit66.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit66.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit66.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit66.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit66.Properties.MaxLength = 20
        Me.TextEdit66.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit66.TabIndex = 10
        '
        'LabelControl78
        '
        Me.LabelControl78.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl78.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl78.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl78.Name = "LabelControl78"
        Me.LabelControl78.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl78.TabIndex = 30
        Me.LabelControl78.Text = "PostaKodu:"
        '
        'TextEdit67
        '
        Me.TextEdit67.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sEvSemt", True))
        Me.TextEdit67.EnterMoveNextControl = True
        Me.TextEdit67.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit67.Name = "TextEdit67"
        Me.TextEdit67.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit67.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit67.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit67.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit67.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit67.Properties.MaxLength = 60
        Me.TextEdit67.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit67.TabIndex = 9
        '
        'LabelControl79
        '
        Me.LabelControl79.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl79.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl79.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl79.Name = "LabelControl79"
        Me.LabelControl79.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl79.TabIndex = 28
        Me.LabelControl79.Text = "Semt:"
        '
        'LabelControl80
        '
        Me.LabelControl80.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl80.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl80.Location = New System.Drawing.Point(13, 87)
        Me.LabelControl80.Name = "LabelControl80"
        Me.LabelControl80.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl80.TabIndex = 27
        Me.LabelControl80.Text = "Telefon:"
        '
        'TextEdit68
        '
        Me.TextEdit68.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sEvTelefonu", True))
        Me.TextEdit68.EnterMoveNextControl = True
        Me.TextEdit68.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit68.Name = "TextEdit68"
        Me.TextEdit68.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit68.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit68.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit68.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit68.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit68.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit68.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit68.Properties.Mask.SaveLiteral = False
        Me.TextEdit68.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit68.Properties.MaxLength = 60
        Me.TextEdit68.Size = New System.Drawing.Size(218, 26)
        Me.TextEdit68.TabIndex = 8
        '
        'TextEdit69
        '
        Me.TextEdit69.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sEvAdresi2", True))
        Me.TextEdit69.EnterMoveNextControl = True
        Me.TextEdit69.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit69.Name = "TextEdit69"
        Me.TextEdit69.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit69.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit69.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit69.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit69.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit69.Properties.MaxLength = 60
        Me.TextEdit69.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit69.TabIndex = 7
        '
        'TextEdit70
        '
        Me.TextEdit70.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sEvAdresi1", True))
        Me.TextEdit70.EnterMoveNextControl = True
        Me.TextEdit70.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit70.Name = "TextEdit70"
        Me.TextEdit70.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit70.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit70.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit70.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit70.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit70.Properties.MaxLength = 60
        Me.TextEdit70.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit70.TabIndex = 6
        '
        'LabelControl81
        '
        Me.LabelControl81.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl81.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl81.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl81.Name = "LabelControl81"
        Me.LabelControl81.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl81.TabIndex = 23
        Me.LabelControl81.Text = "Adres:"
        '
        'GroupControl9
        '
        Me.GroupControl9.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl9.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl9.AppearanceCaption.Options.UseFont = True
        Me.GroupControl9.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl9.Controls.Add(Me.SimpleButton7)
        Me.GroupControl9.Controls.Add(Me.txt_sHitap5)
        Me.GroupControl9.Controls.Add(Me.txt_sUnvan3)
        Me.GroupControl9.Controls.Add(Me.LabelControl82)
        Me.GroupControl9.Controls.Add(Me.CalcEdit3)
        Me.GroupControl9.Controls.Add(Me.LabelControl83)
        Me.GroupControl9.Controls.Add(Me.TextEdit71)
        Me.GroupControl9.Controls.Add(Me.LabelControl84)
        Me.GroupControl9.Controls.Add(Me.LabelControl85)
        Me.GroupControl9.Controls.Add(Me.TextEdit72)
        Me.GroupControl9.Controls.Add(Me.TextEdit73)
        Me.GroupControl9.Controls.Add(Me.LabelControl86)
        Me.GroupControl9.Controls.Add(Me.LabelControl87)
        Me.GroupControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl9.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(1300, 99)
        Me.GroupControl9.TabIndex = 4
        Me.GroupControl9.Text = "Özel Bilgiler"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(496, 60)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(232, 33)
        Me.SimpleButton7.TabIndex = 75
        Me.SimpleButton7.Text = "Kefilin Hesabını Bul"
        '
        'txt_sHitap5
        '
        Me.txt_sHitap5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sHitap", True))
        Me.txt_sHitap5.EnterMoveNextControl = True
        Me.txt_sHitap5.Location = New System.Drawing.Point(128, 29)
        Me.txt_sHitap5.Name = "txt_sHitap5"
        Me.txt_sHitap5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap5.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap5.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap5.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap5.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap5.Properties.NullText = "[Hitap]"
        Me.txt_sHitap5.Properties.ValueMember = "sHitap"
        Me.txt_sHitap5.Size = New System.Drawing.Size(160, 26)
        Me.txt_sHitap5.TabIndex = 0
        '
        'txt_sUnvan3
        '
        Me.txt_sUnvan3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sUnvan", True))
        Me.txt_sUnvan3.EnterMoveNextControl = True
        Me.txt_sUnvan3.Location = New System.Drawing.Point(870, 31)
        Me.txt_sUnvan3.Name = "txt_sUnvan3"
        Me.txt_sUnvan3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sUnvan3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sUnvan3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sUnvan3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sUnvan3.Properties.DisplayMember = "sUnvan"
        Me.txt_sUnvan3.Properties.NullText = "[Ünvan]"
        Me.txt_sUnvan3.Properties.ValueMember = "sUnvan"
        Me.txt_sUnvan3.Size = New System.Drawing.Size(160, 26)
        Me.txt_sUnvan3.TabIndex = 73
        '
        'LabelControl82
        '
        Me.LabelControl82.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl82.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl82.Location = New System.Drawing.Point(291, 60)
        Me.LabelControl82.Name = "LabelControl82"
        Me.LabelControl82.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl82.TabIndex = 36
        Me.LabelControl82.Text = "Soyad:"
        '
        'CalcEdit3
        '
        Me.CalcEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.lAylikGelir", True))
        Me.CalcEdit3.EnterMoveNextControl = True
        Me.CalcEdit3.Location = New System.Drawing.Point(1088, 60)
        Me.CalcEdit3.Name = "CalcEdit3"
        Me.CalcEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.CalcEdit3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.CalcEdit3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CalcEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit3.Size = New System.Drawing.Size(141, 26)
        Me.CalcEdit3.TabIndex = 5
        '
        'LabelControl83
        '
        Me.LabelControl83.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl83.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl83.Location = New System.Drawing.Point(1038, 63)
        Me.LabelControl83.Name = "LabelControl83"
        Me.LabelControl83.Size = New System.Drawing.Size(39, 19)
        Me.LabelControl83.TabIndex = 34
        Me.LabelControl83.Text = "Gelir:"
        '
        'TextEdit71
        '
        Me.TextEdit71.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sSigortaNo", True))
        Me.TextEdit71.EnterMoveNextControl = True
        Me.TextEdit71.Location = New System.Drawing.Point(870, 60)
        Me.TextEdit71.Name = "TextEdit71"
        Me.TextEdit71.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit71.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit71.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit71.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit71.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit71.Properties.MaxLength = 60
        Me.TextEdit71.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit71.TabIndex = 4
        '
        'LabelControl84
        '
        Me.LabelControl84.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl84.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl84.Location = New System.Drawing.Point(755, 64)
        Me.LabelControl84.Name = "LabelControl84"
        Me.LabelControl84.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl84.TabIndex = 32
        Me.LabelControl84.Text = "MüşteriNo:"
        '
        'LabelControl85
        '
        Me.LabelControl85.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl85.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl85.Location = New System.Drawing.Point(755, 33)
        Me.LabelControl85.Name = "LabelControl85"
        Me.LabelControl85.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl85.TabIndex = 31
        Me.LabelControl85.Text = "Ünvan:"
        '
        'TextEdit72
        '
        Me.TextEdit72.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sSoyadi", True))
        Me.TextEdit72.EnterMoveNextControl = True
        Me.TextEdit72.Location = New System.Drawing.Point(346, 60)
        Me.TextEdit72.Name = "TextEdit72"
        Me.TextEdit72.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit72.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit72.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit72.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit72.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit72.Properties.MaxLength = 60
        Me.TextEdit72.Size = New System.Drawing.Size(140, 26)
        Me.TextEdit72.TabIndex = 2
        '
        'TextEdit73
        '
        Me.TextEdit73.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil2, "Table1.sAdi", True))
        Me.TextEdit73.EnterMoveNextControl = True
        Me.TextEdit73.Location = New System.Drawing.Point(128, 57)
        Me.TextEdit73.Name = "TextEdit73"
        Me.TextEdit73.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit73.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit73.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit73.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit73.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit73.Properties.MaxLength = 60
        Me.TextEdit73.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit73.TabIndex = 1
        '
        'LabelControl86
        '
        Me.LabelControl86.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl86.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl86.Location = New System.Drawing.Point(13, 60)
        Me.LabelControl86.Name = "LabelControl86"
        Me.LabelControl86.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl86.TabIndex = 26
        Me.LabelControl86.Text = "Ad:"
        '
        'LabelControl87
        '
        Me.LabelControl87.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl87.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl87.Location = New System.Drawing.Point(13, 29)
        Me.LabelControl87.Name = "LabelControl87"
        Me.LabelControl87.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl87.TabIndex = 7
        Me.LabelControl87.Text = "Hitap:"
        '
        'XtraTabPage13
        '
        Me.XtraTabPage13.Controls.Add(Me.GroupControl13)
        Me.XtraTabPage13.Controls.Add(Me.GroupControl14)
        Me.XtraTabPage13.Controls.Add(Me.GroupControl15)
        Me.XtraTabPage13.Name = "XtraTabPage13"
        Me.XtraTabPage13.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage13.Text = "3.Kefil"
        '
        'GroupControl13
        '
        Me.GroupControl13.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl13.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl13.AppearanceCaption.Options.UseFont = True
        Me.GroupControl13.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl13.Controls.Add(Me.LookUpEdit1)
        Me.GroupControl13.Controls.Add(Me.TextEdit1)
        Me.GroupControl13.Controls.Add(Me.TextEdit2)
        Me.GroupControl13.Controls.Add(Me.LabelControl94)
        Me.GroupControl13.Controls.Add(Me.LabelControl95)
        Me.GroupControl13.Controls.Add(Me.TextEdit3)
        Me.GroupControl13.Controls.Add(Me.LabelControl96)
        Me.GroupControl13.Controls.Add(Me.TextEdit4)
        Me.GroupControl13.Controls.Add(Me.LabelControl97)
        Me.GroupControl13.Controls.Add(Me.TextEdit5)
        Me.GroupControl13.Controls.Add(Me.LabelControl98)
        Me.GroupControl13.Controls.Add(Me.LabelControl99)
        Me.GroupControl13.Controls.Add(Me.TextEdit6)
        Me.GroupControl13.Controls.Add(Me.TextEdit7)
        Me.GroupControl13.Controls.Add(Me.LabelControl100)
        Me.GroupControl13.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl13.Location = New System.Drawing.Point(0, 236)
        Me.GroupControl13.Name = "GroupControl13"
        Me.GroupControl13.Size = New System.Drawing.Size(1300, 165)
        Me.GroupControl13.TabIndex = 6
        Me.GroupControl13.Text = "İş Adresi"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sIsIl", True))
        Me.LookUpEdit1.EnterMoveNextControl = True
        Me.LookUpEdit1.Location = New System.Drawing.Point(870, 87)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DisplayMember = "sIl"
        Me.LookUpEdit1.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit1.Properties.NullText = "[Il]"
        Me.LookUpEdit1.Properties.ValueMember = "sIl"
        Me.LookUpEdit1.Size = New System.Drawing.Size(359, 26)
        Me.LookUpEdit1.TabIndex = 18
        '
        'ds_tbMusteriKefil3
        '
        Me.ds_tbMusteriKefil3.DataSetName = "NewDataSet"
        Me.ds_tbMusteriKefil3.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriKefil3.Tables.AddRange(New System.Data.DataTable() {Me.DataTable12})
        '
        'DataTable12
        '
        Me.DataTable12.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn177, Me.DataColumn178, Me.DataColumn179, Me.DataColumn180, Me.DataColumn181, Me.DataColumn182, Me.DataColumn183, Me.DataColumn184, Me.DataColumn185, Me.DataColumn186, Me.DataColumn187, Me.DataColumn188, Me.DataColumn189, Me.DataColumn190, Me.DataColumn191, Me.DataColumn192, Me.DataColumn193, Me.DataColumn194, Me.DataColumn195, Me.DataColumn196, Me.DataColumn197, Me.DataColumn198, Me.DataColumn199})
        Me.DataTable12.TableName = "Table1"
        '
        'DataColumn177
        '
        Me.DataColumn177.ColumnName = "nMusteriID"
        Me.DataColumn177.DataType = GetType(Long)
        '
        'DataColumn178
        '
        Me.DataColumn178.ColumnName = "sAdi"
        '
        'DataColumn179
        '
        Me.DataColumn179.ColumnName = "sSoyadi"
        '
        'DataColumn180
        '
        Me.DataColumn180.ColumnName = "sUnvan"
        '
        'DataColumn181
        '
        Me.DataColumn181.ColumnName = "sEmail"
        '
        'DataColumn182
        '
        Me.DataColumn182.ColumnName = "sIsYeriAdi"
        '
        'DataColumn183
        '
        Me.DataColumn183.ColumnName = "sIsAdresi1"
        '
        'DataColumn184
        '
        Me.DataColumn184.ColumnName = "sIsAdresi2"
        '
        'DataColumn185
        '
        Me.DataColumn185.ColumnName = "sIsSemt"
        '
        'DataColumn186
        '
        Me.DataColumn186.ColumnName = "sIsPostaKodu"
        '
        'DataColumn187
        '
        Me.DataColumn187.ColumnName = "sIsIl"
        '
        'DataColumn188
        '
        Me.DataColumn188.ColumnName = "sIsTelefonu"
        '
        'DataColumn189
        '
        Me.DataColumn189.ColumnName = "sEvAdresi2"
        '
        'DataColumn190
        '
        Me.DataColumn190.ColumnName = "sEvSemt"
        '
        'DataColumn191
        '
        Me.DataColumn191.ColumnName = "sEvPostaKodu"
        '
        'DataColumn192
        '
        Me.DataColumn192.ColumnName = "sEvIl"
        '
        'DataColumn193
        '
        Me.DataColumn193.ColumnName = "sEvTelefonu"
        '
        'DataColumn194
        '
        Me.DataColumn194.ColumnName = "lAylikGelir"
        Me.DataColumn194.DataType = GetType(Decimal)
        '
        'DataColumn195
        '
        Me.DataColumn195.ColumnName = "sSigortaNo"
        '
        'DataColumn196
        '
        Me.DataColumn196.ColumnName = "sHitap"
        '
        'DataColumn197
        '
        Me.DataColumn197.ColumnName = "sKullaniciAdi"
        '
        'DataColumn198
        '
        Me.DataColumn198.ColumnName = "dteKayitTarihi"
        Me.DataColumn198.DataType = GetType(Date)
        '
        'DataColumn199
        '
        Me.DataColumn199.ColumnName = "sEvAdresi1"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sIsYeriAdi", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit1.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit1.Properties.MaxLength = 60
        Me.TextEdit1.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit1.TabIndex = 12
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sEmail", True))
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(870, 116)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit2.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit2.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit2.TabIndex = 19
        '
        'LabelControl94
        '
        Me.LabelControl94.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl94.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl94.Location = New System.Drawing.Point(755, 116)
        Me.LabelControl94.Name = "LabelControl94"
        Me.LabelControl94.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl94.TabIndex = 36
        Me.LabelControl94.Text = "E-Mail:"
        '
        'LabelControl95
        '
        Me.LabelControl95.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl95.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl95.Location = New System.Drawing.Point(13, 116)
        Me.LabelControl95.Name = "LabelControl95"
        Me.LabelControl95.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl95.TabIndex = 35
        Me.LabelControl95.Text = "Telefon/Gsm:"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sIsTelefonu", True))
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(128, 116)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit3.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit3.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit3.Properties.Mask.SaveLiteral = False
        Me.TextEdit3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit3.Properties.MaxLength = 20
        Me.TextEdit3.Size = New System.Drawing.Size(230, 26)
        Me.TextEdit3.TabIndex = 15
        '
        'LabelControl96
        '
        Me.LabelControl96.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl96.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl96.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl96.Name = "LabelControl96"
        Me.LabelControl96.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl96.TabIndex = 32
        Me.LabelControl96.Text = "İl:"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sIsPostaKodu", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit4.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit4.Properties.MaxLength = 20
        Me.TextEdit4.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit4.TabIndex = 17
        '
        'LabelControl97
        '
        Me.LabelControl97.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl97.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl97.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl97.Name = "LabelControl97"
        Me.LabelControl97.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl97.TabIndex = 30
        Me.LabelControl97.Text = "PostaKodu:"
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sIsSemt", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit5.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit5.Properties.MaxLength = 60
        Me.TextEdit5.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit5.TabIndex = 16
        '
        'LabelControl98
        '
        Me.LabelControl98.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl98.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl98.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl98.Name = "LabelControl98"
        Me.LabelControl98.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl98.TabIndex = 28
        Me.LabelControl98.Text = "Semt:"
        '
        'LabelControl99
        '
        Me.LabelControl99.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl99.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl99.Location = New System.Drawing.Point(13, 59)
        Me.LabelControl99.Name = "LabelControl99"
        Me.LabelControl99.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl99.TabIndex = 27
        Me.LabelControl99.Text = "Adres:"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sIsAdresi2", True))
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit6.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit6.Properties.MaxLength = 60
        Me.TextEdit6.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit6.TabIndex = 14
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sIsAdresi1", True))
        Me.TextEdit7.EnterMoveNextControl = True
        Me.TextEdit7.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit7.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit7.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit7.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit7.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit7.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit7.Properties.MaxLength = 60
        Me.TextEdit7.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit7.TabIndex = 13
        '
        'LabelControl100
        '
        Me.LabelControl100.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl100.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl100.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl100.Name = "LabelControl100"
        Me.LabelControl100.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl100.TabIndex = 23
        Me.LabelControl100.Text = "İşYeriAdı:"
        '
        'GroupControl14
        '
        Me.GroupControl14.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl14.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl14.AppearanceCaption.Options.UseFont = True
        Me.GroupControl14.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl14.Controls.Add(Me.LookUpEdit2)
        Me.GroupControl14.Controls.Add(Me.LabelControl101)
        Me.GroupControl14.Controls.Add(Me.TextEdit8)
        Me.GroupControl14.Controls.Add(Me.LabelControl102)
        Me.GroupControl14.Controls.Add(Me.TextEdit9)
        Me.GroupControl14.Controls.Add(Me.LabelControl103)
        Me.GroupControl14.Controls.Add(Me.LabelControl104)
        Me.GroupControl14.Controls.Add(Me.TextEdit10)
        Me.GroupControl14.Controls.Add(Me.TextEdit11)
        Me.GroupControl14.Controls.Add(Me.TextEdit12)
        Me.GroupControl14.Controls.Add(Me.LabelControl105)
        Me.GroupControl14.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl14.Location = New System.Drawing.Point(0, 99)
        Me.GroupControl14.Name = "GroupControl14"
        Me.GroupControl14.Size = New System.Drawing.Size(1300, 137)
        Me.GroupControl14.TabIndex = 5
        Me.GroupControl14.Text = "Ev Adresi"
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sEvIl", True))
        Me.LookUpEdit2.EnterMoveNextControl = True
        Me.LookUpEdit2.Location = New System.Drawing.Point(870, 87)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.DisplayMember = "sIl"
        Me.LookUpEdit2.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit2.Properties.NullText = "[Il]"
        Me.LookUpEdit2.Properties.ValueMember = "sIl"
        Me.LookUpEdit2.Size = New System.Drawing.Size(359, 26)
        Me.LookUpEdit2.TabIndex = 11
        '
        'LabelControl101
        '
        Me.LabelControl101.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl101.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl101.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl101.Name = "LabelControl101"
        Me.LabelControl101.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl101.TabIndex = 32
        Me.LabelControl101.Text = "İl:"
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sEvPostaKodu", True))
        Me.TextEdit8.EnterMoveNextControl = True
        Me.TextEdit8.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit8.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit8.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit8.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit8.Properties.MaxLength = 20
        Me.TextEdit8.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit8.TabIndex = 10
        '
        'LabelControl102
        '
        Me.LabelControl102.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl102.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl102.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl102.Name = "LabelControl102"
        Me.LabelControl102.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl102.TabIndex = 30
        Me.LabelControl102.Text = "PostaKodu:"
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sEvSemt", True))
        Me.TextEdit9.EnterMoveNextControl = True
        Me.TextEdit9.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit9.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit9.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit9.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit9.Properties.MaxLength = 60
        Me.TextEdit9.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit9.TabIndex = 9
        '
        'LabelControl103
        '
        Me.LabelControl103.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl103.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl103.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl103.Name = "LabelControl103"
        Me.LabelControl103.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl103.TabIndex = 28
        Me.LabelControl103.Text = "Semt:"
        '
        'LabelControl104
        '
        Me.LabelControl104.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl104.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl104.Location = New System.Drawing.Point(13, 87)
        Me.LabelControl104.Name = "LabelControl104"
        Me.LabelControl104.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl104.TabIndex = 27
        Me.LabelControl104.Text = "Telefon:"
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sEvTelefonu", True))
        Me.TextEdit10.EnterMoveNextControl = True
        Me.TextEdit10.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit10.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit10.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit10.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit10.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit10.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit10.Properties.Mask.SaveLiteral = False
        Me.TextEdit10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit10.Properties.MaxLength = 20
        Me.TextEdit10.Size = New System.Drawing.Size(218, 26)
        Me.TextEdit10.TabIndex = 8
        '
        'TextEdit11
        '
        Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sEvAdresi2", True))
        Me.TextEdit11.EnterMoveNextControl = True
        Me.TextEdit11.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit11.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit11.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit11.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit11.Properties.MaxLength = 60
        Me.TextEdit11.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit11.TabIndex = 7
        '
        'TextEdit12
        '
        Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sEvAdresi1", True))
        Me.TextEdit12.EnterMoveNextControl = True
        Me.TextEdit12.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit12.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit12.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit12.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit12.Properties.MaxLength = 60
        Me.TextEdit12.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit12.TabIndex = 6
        '
        'LabelControl105
        '
        Me.LabelControl105.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl105.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl105.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl105.Name = "LabelControl105"
        Me.LabelControl105.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl105.TabIndex = 23
        Me.LabelControl105.Text = "Adres:"
        '
        'GroupControl15
        '
        Me.GroupControl15.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl15.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl15.AppearanceCaption.Options.UseFont = True
        Me.GroupControl15.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl15.Controls.Add(Me.SimpleButton14)
        Me.GroupControl15.Controls.Add(Me.LookUpEdit3)
        Me.GroupControl15.Controls.Add(Me.LookUpEdit4)
        Me.GroupControl15.Controls.Add(Me.LabelControl106)
        Me.GroupControl15.Controls.Add(Me.CalcEdit1)
        Me.GroupControl15.Controls.Add(Me.LabelControl107)
        Me.GroupControl15.Controls.Add(Me.TextEdit13)
        Me.GroupControl15.Controls.Add(Me.LabelControl108)
        Me.GroupControl15.Controls.Add(Me.LabelControl109)
        Me.GroupControl15.Controls.Add(Me.TextEdit14)
        Me.GroupControl15.Controls.Add(Me.TextEdit15)
        Me.GroupControl15.Controls.Add(Me.LabelControl110)
        Me.GroupControl15.Controls.Add(Me.LabelControl111)
        Me.GroupControl15.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl15.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl15.Name = "GroupControl15"
        Me.GroupControl15.Size = New System.Drawing.Size(1300, 99)
        Me.GroupControl15.TabIndex = 4
        Me.GroupControl15.Text = "Özel Bilgiler"
        '
        'SimpleButton14
        '
        Me.SimpleButton14.Image = CType(resources.GetObject("SimpleButton14.Image"), System.Drawing.Image)
        Me.SimpleButton14.Location = New System.Drawing.Point(496, 60)
        Me.SimpleButton14.Name = "SimpleButton14"
        Me.SimpleButton14.Size = New System.Drawing.Size(232, 33)
        Me.SimpleButton14.TabIndex = 75
        Me.SimpleButton14.Text = "Kefilin Hesabını Bul"
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sHitap", True))
        Me.LookUpEdit3.EnterMoveNextControl = True
        Me.LookUpEdit3.Location = New System.Drawing.Point(128, 29)
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.DisplayMember = "sHitap"
        Me.LookUpEdit3.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit3.Properties.NullText = "[Hitap]"
        Me.LookUpEdit3.Properties.ValueMember = "sHitap"
        Me.LookUpEdit3.Size = New System.Drawing.Size(160, 26)
        Me.LookUpEdit3.TabIndex = 0
        '
        'LookUpEdit4
        '
        Me.LookUpEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sUnvan", True))
        Me.LookUpEdit4.EnterMoveNextControl = True
        Me.LookUpEdit4.Location = New System.Drawing.Point(870, 31)
        Me.LookUpEdit4.Name = "LookUpEdit4"
        Me.LookUpEdit4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit4.Properties.DisplayMember = "sUnvan"
        Me.LookUpEdit4.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit4.Properties.NullText = "[Ünvan]"
        Me.LookUpEdit4.Properties.ValueMember = "sUnvan"
        Me.LookUpEdit4.Size = New System.Drawing.Size(160, 26)
        Me.LookUpEdit4.TabIndex = 73
        '
        'LabelControl106
        '
        Me.LabelControl106.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl106.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl106.Location = New System.Drawing.Point(291, 60)
        Me.LabelControl106.Name = "LabelControl106"
        Me.LabelControl106.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl106.TabIndex = 36
        Me.LabelControl106.Text = "Soyad:"
        '
        'CalcEdit1
        '
        Me.CalcEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.lAylikGelir", True))
        Me.CalcEdit1.EnterMoveNextControl = True
        Me.CalcEdit1.Location = New System.Drawing.Point(1088, 60)
        Me.CalcEdit1.Name = "CalcEdit1"
        Me.CalcEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.CalcEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.CalcEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Properties.LookAndFeel.SkinName = "VS2010"
        Me.CalcEdit1.Size = New System.Drawing.Size(141, 26)
        Me.CalcEdit1.TabIndex = 5
        '
        'LabelControl107
        '
        Me.LabelControl107.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl107.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl107.Location = New System.Drawing.Point(1038, 63)
        Me.LabelControl107.Name = "LabelControl107"
        Me.LabelControl107.Size = New System.Drawing.Size(39, 19)
        Me.LabelControl107.TabIndex = 34
        Me.LabelControl107.Text = "Gelir:"
        '
        'TextEdit13
        '
        Me.TextEdit13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sSigortaNo", True))
        Me.TextEdit13.EnterMoveNextControl = True
        Me.TextEdit13.Location = New System.Drawing.Point(870, 60)
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit13.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit13.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit13.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit13.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit13.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit13.Properties.MaxLength = 60
        Me.TextEdit13.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit13.TabIndex = 4
        '
        'LabelControl108
        '
        Me.LabelControl108.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl108.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl108.Location = New System.Drawing.Point(755, 64)
        Me.LabelControl108.Name = "LabelControl108"
        Me.LabelControl108.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl108.TabIndex = 32
        Me.LabelControl108.Text = "MüşteriNo:"
        '
        'LabelControl109
        '
        Me.LabelControl109.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl109.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl109.Location = New System.Drawing.Point(755, 33)
        Me.LabelControl109.Name = "LabelControl109"
        Me.LabelControl109.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl109.TabIndex = 31
        Me.LabelControl109.Text = "Ünvan:"
        '
        'TextEdit14
        '
        Me.TextEdit14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sSoyadi", True))
        Me.TextEdit14.EnterMoveNextControl = True
        Me.TextEdit14.Location = New System.Drawing.Point(346, 60)
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit14.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit14.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit14.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit14.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit14.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit14.Properties.MaxLength = 60
        Me.TextEdit14.Size = New System.Drawing.Size(140, 26)
        Me.TextEdit14.TabIndex = 2
        '
        'TextEdit15
        '
        Me.TextEdit15.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil3, "Table1.sAdi", True))
        Me.TextEdit15.EnterMoveNextControl = True
        Me.TextEdit15.Location = New System.Drawing.Point(128, 57)
        Me.TextEdit15.Name = "TextEdit15"
        Me.TextEdit15.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit15.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit15.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit15.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit15.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit15.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit15.Properties.MaxLength = 60
        Me.TextEdit15.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit15.TabIndex = 1
        '
        'LabelControl110
        '
        Me.LabelControl110.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl110.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl110.Location = New System.Drawing.Point(13, 60)
        Me.LabelControl110.Name = "LabelControl110"
        Me.LabelControl110.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl110.TabIndex = 26
        Me.LabelControl110.Text = "Ad:"
        '
        'LabelControl111
        '
        Me.LabelControl111.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl111.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl111.Location = New System.Drawing.Point(13, 29)
        Me.LabelControl111.Name = "LabelControl111"
        Me.LabelControl111.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl111.TabIndex = 7
        Me.LabelControl111.Text = "Hitap:"
        '
        'XtraTabPage14
        '
        Me.XtraTabPage14.Controls.Add(Me.GroupControl16)
        Me.XtraTabPage14.Controls.Add(Me.GroupControl17)
        Me.XtraTabPage14.Controls.Add(Me.GroupControl18)
        Me.XtraTabPage14.Name = "XtraTabPage14"
        Me.XtraTabPage14.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage14.Text = "4.Kefil"
        '
        'GroupControl16
        '
        Me.GroupControl16.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl16.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl16.AppearanceCaption.Options.UseFont = True
        Me.GroupControl16.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl16.Controls.Add(Me.LookUpEdit5)
        Me.GroupControl16.Controls.Add(Me.TextEdit16)
        Me.GroupControl16.Controls.Add(Me.TextEdit17)
        Me.GroupControl16.Controls.Add(Me.LabelControl112)
        Me.GroupControl16.Controls.Add(Me.LabelControl113)
        Me.GroupControl16.Controls.Add(Me.TextEdit18)
        Me.GroupControl16.Controls.Add(Me.LabelControl114)
        Me.GroupControl16.Controls.Add(Me.TextEdit19)
        Me.GroupControl16.Controls.Add(Me.LabelControl115)
        Me.GroupControl16.Controls.Add(Me.TextEdit20)
        Me.GroupControl16.Controls.Add(Me.LabelControl116)
        Me.GroupControl16.Controls.Add(Me.LabelControl117)
        Me.GroupControl16.Controls.Add(Me.TextEdit21)
        Me.GroupControl16.Controls.Add(Me.TextEdit22)
        Me.GroupControl16.Controls.Add(Me.LabelControl118)
        Me.GroupControl16.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl16.Location = New System.Drawing.Point(0, 236)
        Me.GroupControl16.Name = "GroupControl16"
        Me.GroupControl16.Size = New System.Drawing.Size(1300, 165)
        Me.GroupControl16.TabIndex = 6
        Me.GroupControl16.Text = "İş Adresi"
        '
        'LookUpEdit5
        '
        Me.LookUpEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sIsIl", True))
        Me.LookUpEdit5.EnterMoveNextControl = True
        Me.LookUpEdit5.Location = New System.Drawing.Point(870, 87)
        Me.LookUpEdit5.Name = "LookUpEdit5"
        Me.LookUpEdit5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit5.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit5.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit5.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit5.Properties.DisplayMember = "sIl"
        Me.LookUpEdit5.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit5.Properties.NullText = "[Il]"
        Me.LookUpEdit5.Properties.ValueMember = "sIl"
        Me.LookUpEdit5.Size = New System.Drawing.Size(359, 26)
        Me.LookUpEdit5.TabIndex = 18
        '
        'ds_tbMusteriKefil4
        '
        Me.ds_tbMusteriKefil4.DataSetName = "NewDataSet"
        Me.ds_tbMusteriKefil4.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriKefil4.Tables.AddRange(New System.Data.DataTable() {Me.DataTable13})
        '
        'DataTable13
        '
        Me.DataTable13.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn200, Me.DataColumn201, Me.DataColumn202, Me.DataColumn203, Me.DataColumn204, Me.DataColumn205, Me.DataColumn206, Me.DataColumn207, Me.DataColumn208, Me.DataColumn209, Me.DataColumn210, Me.DataColumn211, Me.DataColumn212, Me.DataColumn213, Me.DataColumn214, Me.DataColumn215, Me.DataColumn216, Me.DataColumn217, Me.DataColumn218, Me.DataColumn219, Me.DataColumn220, Me.DataColumn221, Me.DataColumn222})
        Me.DataTable13.TableName = "Table1"
        '
        'DataColumn200
        '
        Me.DataColumn200.ColumnName = "nMusteriID"
        Me.DataColumn200.DataType = GetType(Long)
        '
        'DataColumn201
        '
        Me.DataColumn201.ColumnName = "sAdi"
        '
        'DataColumn202
        '
        Me.DataColumn202.ColumnName = "sSoyadi"
        '
        'DataColumn203
        '
        Me.DataColumn203.ColumnName = "sUnvan"
        '
        'DataColumn204
        '
        Me.DataColumn204.ColumnName = "sEmail"
        '
        'DataColumn205
        '
        Me.DataColumn205.ColumnName = "sIsYeriAdi"
        '
        'DataColumn206
        '
        Me.DataColumn206.ColumnName = "sIsAdresi1"
        '
        'DataColumn207
        '
        Me.DataColumn207.ColumnName = "sIsAdresi2"
        '
        'DataColumn208
        '
        Me.DataColumn208.ColumnName = "sIsSemt"
        '
        'DataColumn209
        '
        Me.DataColumn209.ColumnName = "sIsPostaKodu"
        '
        'DataColumn210
        '
        Me.DataColumn210.ColumnName = "sIsIl"
        '
        'DataColumn211
        '
        Me.DataColumn211.ColumnName = "sIsTelefonu"
        '
        'DataColumn212
        '
        Me.DataColumn212.ColumnName = "sEvAdresi2"
        '
        'DataColumn213
        '
        Me.DataColumn213.ColumnName = "sEvSemt"
        '
        'DataColumn214
        '
        Me.DataColumn214.ColumnName = "sEvPostaKodu"
        '
        'DataColumn215
        '
        Me.DataColumn215.ColumnName = "sEvIl"
        '
        'DataColumn216
        '
        Me.DataColumn216.ColumnName = "sEvTelefonu"
        '
        'DataColumn217
        '
        Me.DataColumn217.ColumnName = "lAylikGelir"
        Me.DataColumn217.DataType = GetType(Decimal)
        '
        'DataColumn218
        '
        Me.DataColumn218.ColumnName = "sSigortaNo"
        '
        'DataColumn219
        '
        Me.DataColumn219.ColumnName = "sHitap"
        '
        'DataColumn220
        '
        Me.DataColumn220.ColumnName = "sKullaniciAdi"
        '
        'DataColumn221
        '
        Me.DataColumn221.ColumnName = "dteKayitTarihi"
        Me.DataColumn221.DataType = GetType(Date)
        '
        'DataColumn222
        '
        Me.DataColumn222.ColumnName = "sEvAdresi1"
        '
        'TextEdit16
        '
        Me.TextEdit16.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sIsYeriAdi", True))
        Me.TextEdit16.EnterMoveNextControl = True
        Me.TextEdit16.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit16.Name = "TextEdit16"
        Me.TextEdit16.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit16.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit16.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit16.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit16.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit16.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit16.Properties.MaxLength = 60
        Me.TextEdit16.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit16.TabIndex = 12
        '
        'TextEdit17
        '
        Me.TextEdit17.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sEmail", True))
        Me.TextEdit17.EnterMoveNextControl = True
        Me.TextEdit17.Location = New System.Drawing.Point(870, 116)
        Me.TextEdit17.Name = "TextEdit17"
        Me.TextEdit17.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit17.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit17.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit17.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit17.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit17.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit17.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit17.TabIndex = 19
        '
        'LabelControl112
        '
        Me.LabelControl112.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl112.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl112.Location = New System.Drawing.Point(755, 116)
        Me.LabelControl112.Name = "LabelControl112"
        Me.LabelControl112.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl112.TabIndex = 36
        Me.LabelControl112.Text = "E-Mail:"
        '
        'LabelControl113
        '
        Me.LabelControl113.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl113.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl113.Location = New System.Drawing.Point(13, 116)
        Me.LabelControl113.Name = "LabelControl113"
        Me.LabelControl113.Size = New System.Drawing.Size(97, 19)
        Me.LabelControl113.TabIndex = 35
        Me.LabelControl113.Text = "Telefon/Gsm:"
        '
        'TextEdit18
        '
        Me.TextEdit18.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sIsTelefonu", True))
        Me.TextEdit18.EnterMoveNextControl = True
        Me.TextEdit18.Location = New System.Drawing.Point(128, 116)
        Me.TextEdit18.Name = "TextEdit18"
        Me.TextEdit18.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit18.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit18.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit18.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit18.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit18.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit18.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit18.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit18.Properties.Mask.SaveLiteral = False
        Me.TextEdit18.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit18.Properties.MaxLength = 20
        Me.TextEdit18.Size = New System.Drawing.Size(230, 26)
        Me.TextEdit18.TabIndex = 15
        '
        'LabelControl114
        '
        Me.LabelControl114.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl114.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl114.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl114.Name = "LabelControl114"
        Me.LabelControl114.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl114.TabIndex = 32
        Me.LabelControl114.Text = "İl:"
        '
        'TextEdit19
        '
        Me.TextEdit19.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sIsPostaKodu", True))
        Me.TextEdit19.EnterMoveNextControl = True
        Me.TextEdit19.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit19.Name = "TextEdit19"
        Me.TextEdit19.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit19.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit19.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit19.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit19.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit19.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit19.Properties.MaxLength = 20
        Me.TextEdit19.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit19.TabIndex = 17
        '
        'LabelControl115
        '
        Me.LabelControl115.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl115.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl115.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl115.Name = "LabelControl115"
        Me.LabelControl115.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl115.TabIndex = 30
        Me.LabelControl115.Text = "PostaKodu:"
        '
        'TextEdit20
        '
        Me.TextEdit20.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sIsSemt", True))
        Me.TextEdit20.EnterMoveNextControl = True
        Me.TextEdit20.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit20.Name = "TextEdit20"
        Me.TextEdit20.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit20.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit20.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit20.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit20.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit20.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit20.Properties.MaxLength = 60
        Me.TextEdit20.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit20.TabIndex = 16
        '
        'LabelControl116
        '
        Me.LabelControl116.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl116.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl116.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl116.Name = "LabelControl116"
        Me.LabelControl116.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl116.TabIndex = 28
        Me.LabelControl116.Text = "Semt:"
        '
        'LabelControl117
        '
        Me.LabelControl117.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl117.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl117.Location = New System.Drawing.Point(13, 59)
        Me.LabelControl117.Name = "LabelControl117"
        Me.LabelControl117.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl117.TabIndex = 27
        Me.LabelControl117.Text = "Adres:"
        '
        'TextEdit21
        '
        Me.TextEdit21.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sIsAdresi2", True))
        Me.TextEdit21.EnterMoveNextControl = True
        Me.TextEdit21.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit21.Name = "TextEdit21"
        Me.TextEdit21.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit21.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit21.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit21.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit21.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit21.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit21.Properties.MaxLength = 60
        Me.TextEdit21.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit21.TabIndex = 14
        '
        'TextEdit22
        '
        Me.TextEdit22.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sIsAdresi1", True))
        Me.TextEdit22.EnterMoveNextControl = True
        Me.TextEdit22.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit22.Name = "TextEdit22"
        Me.TextEdit22.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit22.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit22.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit22.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit22.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit22.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit22.Properties.MaxLength = 60
        Me.TextEdit22.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit22.TabIndex = 13
        '
        'LabelControl118
        '
        Me.LabelControl118.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl118.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl118.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl118.Name = "LabelControl118"
        Me.LabelControl118.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl118.TabIndex = 23
        Me.LabelControl118.Text = "İşYeriAdı:"
        '
        'GroupControl17
        '
        Me.GroupControl17.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl17.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl17.AppearanceCaption.Options.UseFont = True
        Me.GroupControl17.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl17.Controls.Add(Me.LookUpEdit6)
        Me.GroupControl17.Controls.Add(Me.LabelControl119)
        Me.GroupControl17.Controls.Add(Me.TextEdit23)
        Me.GroupControl17.Controls.Add(Me.LabelControl120)
        Me.GroupControl17.Controls.Add(Me.TextEdit24)
        Me.GroupControl17.Controls.Add(Me.LabelControl121)
        Me.GroupControl17.Controls.Add(Me.LabelControl122)
        Me.GroupControl17.Controls.Add(Me.TextEdit25)
        Me.GroupControl17.Controls.Add(Me.TextEdit26)
        Me.GroupControl17.Controls.Add(Me.TextEdit27)
        Me.GroupControl17.Controls.Add(Me.LabelControl123)
        Me.GroupControl17.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl17.Location = New System.Drawing.Point(0, 99)
        Me.GroupControl17.Name = "GroupControl17"
        Me.GroupControl17.Size = New System.Drawing.Size(1300, 137)
        Me.GroupControl17.TabIndex = 5
        Me.GroupControl17.Text = "Ev Adresi"
        '
        'LookUpEdit6
        '
        Me.LookUpEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sEvIl", True))
        Me.LookUpEdit6.EnterMoveNextControl = True
        Me.LookUpEdit6.Location = New System.Drawing.Point(870, 87)
        Me.LookUpEdit6.Name = "LookUpEdit6"
        Me.LookUpEdit6.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit6.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit6.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit6.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit6.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit6.Properties.DisplayMember = "sIl"
        Me.LookUpEdit6.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit6.Properties.NullText = "[Il]"
        Me.LookUpEdit6.Properties.ValueMember = "sIl"
        Me.LookUpEdit6.Size = New System.Drawing.Size(359, 26)
        Me.LookUpEdit6.TabIndex = 11
        '
        'LabelControl119
        '
        Me.LabelControl119.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl119.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl119.Location = New System.Drawing.Point(755, 87)
        Me.LabelControl119.Name = "LabelControl119"
        Me.LabelControl119.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl119.TabIndex = 32
        Me.LabelControl119.Text = "İl:"
        '
        'TextEdit23
        '
        Me.TextEdit23.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sEvPostaKodu", True))
        Me.TextEdit23.EnterMoveNextControl = True
        Me.TextEdit23.Location = New System.Drawing.Point(870, 59)
        Me.TextEdit23.Name = "TextEdit23"
        Me.TextEdit23.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit23.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit23.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit23.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit23.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit23.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit23.Properties.MaxLength = 20
        Me.TextEdit23.Size = New System.Drawing.Size(154, 26)
        Me.TextEdit23.TabIndex = 10
        '
        'LabelControl120
        '
        Me.LabelControl120.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl120.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl120.Location = New System.Drawing.Point(755, 59)
        Me.LabelControl120.Name = "LabelControl120"
        Me.LabelControl120.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl120.TabIndex = 30
        Me.LabelControl120.Text = "PostaKodu:"
        '
        'TextEdit24
        '
        Me.TextEdit24.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sEvSemt", True))
        Me.TextEdit24.EnterMoveNextControl = True
        Me.TextEdit24.Location = New System.Drawing.Point(870, 30)
        Me.TextEdit24.Name = "TextEdit24"
        Me.TextEdit24.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit24.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit24.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit24.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit24.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit24.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit24.Properties.MaxLength = 60
        Me.TextEdit24.Size = New System.Drawing.Size(359, 26)
        Me.TextEdit24.TabIndex = 9
        '
        'LabelControl121
        '
        Me.LabelControl121.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl121.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl121.Location = New System.Drawing.Point(755, 30)
        Me.LabelControl121.Name = "LabelControl121"
        Me.LabelControl121.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl121.TabIndex = 28
        Me.LabelControl121.Text = "Semt:"
        '
        'LabelControl122
        '
        Me.LabelControl122.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl122.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl122.Location = New System.Drawing.Point(13, 87)
        Me.LabelControl122.Name = "LabelControl122"
        Me.LabelControl122.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl122.TabIndex = 27
        Me.LabelControl122.Text = "Telefon:"
        '
        'TextEdit25
        '
        Me.TextEdit25.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sEvTelefonu", True))
        Me.TextEdit25.EnterMoveNextControl = True
        Me.TextEdit25.Location = New System.Drawing.Point(128, 87)
        Me.TextEdit25.Name = "TextEdit25"
        Me.TextEdit25.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit25.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit25.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit25.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit25.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit25.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit25.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.TextEdit25.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TextEdit25.Properties.Mask.SaveLiteral = False
        Me.TextEdit25.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit25.Properties.MaxLength = 20
        Me.TextEdit25.Size = New System.Drawing.Size(218, 26)
        Me.TextEdit25.TabIndex = 8
        '
        'TextEdit26
        '
        Me.TextEdit26.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sEvAdresi2", True))
        Me.TextEdit26.EnterMoveNextControl = True
        Me.TextEdit26.Location = New System.Drawing.Point(128, 59)
        Me.TextEdit26.Name = "TextEdit26"
        Me.TextEdit26.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit26.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit26.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit26.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit26.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit26.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit26.Properties.MaxLength = 60
        Me.TextEdit26.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit26.TabIndex = 7
        '
        'TextEdit27
        '
        Me.TextEdit27.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sEvAdresi1", True))
        Me.TextEdit27.EnterMoveNextControl = True
        Me.TextEdit27.Location = New System.Drawing.Point(128, 30)
        Me.TextEdit27.Name = "TextEdit27"
        Me.TextEdit27.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit27.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit27.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit27.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit27.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit27.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit27.Properties.MaxLength = 60
        Me.TextEdit27.Size = New System.Drawing.Size(358, 26)
        Me.TextEdit27.TabIndex = 6
        '
        'LabelControl123
        '
        Me.LabelControl123.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl123.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl123.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl123.Name = "LabelControl123"
        Me.LabelControl123.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl123.TabIndex = 23
        Me.LabelControl123.Text = "Adres:"
        '
        'GroupControl18
        '
        Me.GroupControl18.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl18.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl18.AppearanceCaption.Options.UseFont = True
        Me.GroupControl18.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl18.Controls.Add(Me.SimpleButton15)
        Me.GroupControl18.Controls.Add(Me.LookUpEdit7)
        Me.GroupControl18.Controls.Add(Me.LookUpEdit8)
        Me.GroupControl18.Controls.Add(Me.LabelControl124)
        Me.GroupControl18.Controls.Add(Me.CalcEdit4)
        Me.GroupControl18.Controls.Add(Me.LabelControl125)
        Me.GroupControl18.Controls.Add(Me.TextEdit28)
        Me.GroupControl18.Controls.Add(Me.LabelControl126)
        Me.GroupControl18.Controls.Add(Me.LabelControl127)
        Me.GroupControl18.Controls.Add(Me.TextEdit29)
        Me.GroupControl18.Controls.Add(Me.TextEdit30)
        Me.GroupControl18.Controls.Add(Me.LabelControl128)
        Me.GroupControl18.Controls.Add(Me.LabelControl129)
        Me.GroupControl18.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl18.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl18.Name = "GroupControl18"
        Me.GroupControl18.Size = New System.Drawing.Size(1300, 99)
        Me.GroupControl18.TabIndex = 4
        Me.GroupControl18.Text = "Özel Bilgiler"
        '
        'SimpleButton15
        '
        Me.SimpleButton15.Image = CType(resources.GetObject("SimpleButton15.Image"), System.Drawing.Image)
        Me.SimpleButton15.Location = New System.Drawing.Point(496, 60)
        Me.SimpleButton15.Name = "SimpleButton15"
        Me.SimpleButton15.Size = New System.Drawing.Size(232, 33)
        Me.SimpleButton15.TabIndex = 75
        Me.SimpleButton15.Text = "Kefilin Hesabını Bul"
        '
        'LookUpEdit7
        '
        Me.LookUpEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sHitap", True))
        Me.LookUpEdit7.EnterMoveNextControl = True
        Me.LookUpEdit7.Location = New System.Drawing.Point(128, 29)
        Me.LookUpEdit7.Name = "LookUpEdit7"
        Me.LookUpEdit7.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit7.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit7.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit7.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit7.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit7.Properties.DisplayMember = "sHitap"
        Me.LookUpEdit7.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit7.Properties.NullText = "[Hitap]"
        Me.LookUpEdit7.Properties.ValueMember = "sHitap"
        Me.LookUpEdit7.Size = New System.Drawing.Size(160, 26)
        Me.LookUpEdit7.TabIndex = 0
        '
        'LookUpEdit8
        '
        Me.LookUpEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sUnvan", True))
        Me.LookUpEdit8.EnterMoveNextControl = True
        Me.LookUpEdit8.Location = New System.Drawing.Point(870, 31)
        Me.LookUpEdit8.Name = "LookUpEdit8"
        Me.LookUpEdit8.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit8.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEdit8.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit8.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LookUpEdit8.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit8.Properties.DisplayMember = "sUnvan"
        Me.LookUpEdit8.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit8.Properties.NullText = "[Ünvan]"
        Me.LookUpEdit8.Properties.ValueMember = "sUnvan"
        Me.LookUpEdit8.Size = New System.Drawing.Size(160, 26)
        Me.LookUpEdit8.TabIndex = 73
        '
        'LabelControl124
        '
        Me.LabelControl124.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl124.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl124.Location = New System.Drawing.Point(291, 60)
        Me.LabelControl124.Name = "LabelControl124"
        Me.LabelControl124.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl124.TabIndex = 36
        Me.LabelControl124.Text = "Soyad:"
        '
        'CalcEdit4
        '
        Me.CalcEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.lAylikGelir", True))
        Me.CalcEdit4.EnterMoveNextControl = True
        Me.CalcEdit4.Location = New System.Drawing.Point(1088, 60)
        Me.CalcEdit4.Name = "CalcEdit4"
        Me.CalcEdit4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CalcEdit4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.CalcEdit4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.CalcEdit4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CalcEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit4.Properties.LookAndFeel.SkinName = "VS2010"
        Me.CalcEdit4.Size = New System.Drawing.Size(141, 26)
        Me.CalcEdit4.TabIndex = 5
        '
        'LabelControl125
        '
        Me.LabelControl125.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl125.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl125.Location = New System.Drawing.Point(1038, 63)
        Me.LabelControl125.Name = "LabelControl125"
        Me.LabelControl125.Size = New System.Drawing.Size(39, 19)
        Me.LabelControl125.TabIndex = 34
        Me.LabelControl125.Text = "Gelir:"
        '
        'TextEdit28
        '
        Me.TextEdit28.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sSigortaNo", True))
        Me.TextEdit28.EnterMoveNextControl = True
        Me.TextEdit28.Location = New System.Drawing.Point(870, 60)
        Me.TextEdit28.Name = "TextEdit28"
        Me.TextEdit28.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit28.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit28.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit28.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit28.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit28.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit28.Properties.MaxLength = 60
        Me.TextEdit28.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit28.TabIndex = 4
        '
        'LabelControl126
        '
        Me.LabelControl126.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl126.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl126.Location = New System.Drawing.Point(755, 64)
        Me.LabelControl126.Name = "LabelControl126"
        Me.LabelControl126.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl126.TabIndex = 32
        Me.LabelControl126.Text = "MüşteriNo:"
        '
        'LabelControl127
        '
        Me.LabelControl127.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl127.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl127.Location = New System.Drawing.Point(755, 33)
        Me.LabelControl127.Name = "LabelControl127"
        Me.LabelControl127.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl127.TabIndex = 31
        Me.LabelControl127.Text = "Ünvan:"
        '
        'TextEdit29
        '
        Me.TextEdit29.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sSoyadi", True))
        Me.TextEdit29.EnterMoveNextControl = True
        Me.TextEdit29.Location = New System.Drawing.Point(346, 60)
        Me.TextEdit29.Name = "TextEdit29"
        Me.TextEdit29.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit29.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit29.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit29.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit29.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit29.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit29.Properties.MaxLength = 60
        Me.TextEdit29.Size = New System.Drawing.Size(140, 26)
        Me.TextEdit29.TabIndex = 2
        '
        'TextEdit30
        '
        Me.TextEdit30.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKefil4, "Table1.sAdi", True))
        Me.TextEdit30.EnterMoveNextControl = True
        Me.TextEdit30.Location = New System.Drawing.Point(128, 57)
        Me.TextEdit30.Name = "TextEdit30"
        Me.TextEdit30.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit30.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit30.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit30.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit30.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit30.Properties.LookAndFeel.SkinName = "VS2010"
        Me.TextEdit30.Properties.MaxLength = 60
        Me.TextEdit30.Size = New System.Drawing.Size(160, 26)
        Me.TextEdit30.TabIndex = 1
        '
        'LabelControl128
        '
        Me.LabelControl128.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl128.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl128.Location = New System.Drawing.Point(13, 60)
        Me.LabelControl128.Name = "LabelControl128"
        Me.LabelControl128.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl128.TabIndex = 26
        Me.LabelControl128.Text = "Ad:"
        '
        'LabelControl129
        '
        Me.LabelControl129.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl129.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl129.Location = New System.Drawing.Point(13, 29)
        Me.LabelControl129.Name = "LabelControl129"
        Me.LabelControl129.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl129.TabIndex = 7
        Me.LabelControl129.Text = "Hitap:"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.GridControl2)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage6.Text = "Sınıflandırma"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSinifKodu, Me.sec_sSiniflar})
        Me.GridControl2.Size = New System.Drawing.Size(1300, 446)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsSinifTipi, Me.colsSinifKodu, Me.colsAciklama, Me.colbSatisYapilamaz})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müşteri ID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        Me.colnMusteriID.OptionsColumn.AllowFocus = False
        '
        'colsSinifTipi
        '
        Me.colsSinifTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsSinifTipi.AppearanceCell.Options.UseFont = True
        Me.colsSinifTipi.Caption = "Sınıf Tipi"
        Me.colsSinifTipi.FieldName = "sSinifTipi"
        Me.colsSinifTipi.Name = "colsSinifTipi"
        Me.colsSinifTipi.OptionsColumn.AllowEdit = False
        Me.colsSinifTipi.OptionsColumn.AllowFocus = False
        Me.colsSinifTipi.Visible = True
        Me.colsSinifTipi.VisibleIndex = 0
        '
        'colsSinifKodu
        '
        Me.colsSinifKodu.Caption = "Sınıfı"
        Me.colsSinifKodu.ColumnEdit = Me.sec_sSiniflar
        Me.colsSinifKodu.FieldName = "sSinifKodu"
        Me.colsSinifKodu.Name = "colsSinifKodu"
        Me.colsSinifKodu.Visible = True
        Me.colsSinifKodu.VisibleIndex = 1
        '
        'sec_sSiniflar
        '
        Me.sec_sSiniflar.AutoHeight = False
        Me.sec_sSiniflar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSiniflar.DisplayMember = "sSinifKodu"
        Me.sec_sSiniflar.Name = "sec_sSiniflar"
        Me.sec_sSiniflar.NullText = "[Sınıflar]"
        Me.sec_sSiniflar.ValueMember = "sSinifKodu"
        Me.sec_sSiniflar.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açıklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowEdit = False
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colbSatisYapilamaz
        '
        Me.colbSatisYapilamaz.Caption = "Satış Yapılamaz"
        Me.colbSatisYapilamaz.FieldName = "bSatisYapilamaz"
        Me.colbSatisYapilamaz.Name = "colbSatisYapilamaz"
        Me.colbSatisYapilamaz.OptionsColumn.AllowEdit = False
        Me.colbSatisYapilamaz.OptionsColumn.AllowFocus = False
        Me.colbSatisYapilamaz.Visible = True
        Me.colbSatisYapilamaz.VisibleIndex = 3
        '
        'sec_sSinifKodu
        '
        Me.sec_sSinifKodu.AutoHeight = False
        Me.sec_sSinifKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu.DisplayMember = "sSinifKodu"
        Me.sec_sSinifKodu.Name = "sec_sSinifKodu"
        Me.sec_sSinifKodu.NullText = "[Sınıflar]"
        Me.sec_sSinifKodu.ValueMember = "sSinifKodu"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.GridControl1)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage7.Text = "KartNumaraları"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_KartNo
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbMusteriKarti
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_tbMusteriKarti_sKartNo, Me.sec_tbMusteriKarti_sAciklama})
        Me.GridControl1.Size = New System.Drawing.Size(1300, 446)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_KartNo
        '
        Me.kisayol_KartNo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'ds_tbMusteriKarti
        '
        Me.ds_tbMusteriKarti.DataSetName = "NewDataSet"
        Me.ds_tbMusteriKarti.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriKarti.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "nMusteriID"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nKartNo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sAciklama"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dteSonKullanmaTarihi"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sKullaniciAdi"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "dteKayitTarihi"
        Me.DataColumn11.DataType = GetType(Date)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID1, Me.colnKartNo, Me.colsAciklama1, Me.coldteSonKullanmaTarihi, Me.colsKullaniciAdi, Me.coldteKayitTarihi})
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnMusteriID1
        '
        Me.colnMusteriID1.Caption = "Müşteri ID"
        Me.colnMusteriID1.FieldName = "nMusteriID"
        Me.colnMusteriID1.Name = "colnMusteriID1"
        Me.colnMusteriID1.OptionsColumn.AllowEdit = False
        Me.colnMusteriID1.OptionsColumn.AllowFocus = False
        '
        'colnKartNo
        '
        Me.colnKartNo.Caption = "KartNo"
        Me.colnKartNo.ColumnEdit = Me.sec_tbMusteriKarti_sKartNo
        Me.colnKartNo.FieldName = "nKartNo"
        Me.colnKartNo.Name = "colnKartNo"
        Me.colnKartNo.Visible = True
        Me.colnKartNo.VisibleIndex = 0
        '
        'sec_tbMusteriKarti_sKartNo
        '
        Me.sec_tbMusteriKarti_sKartNo.AutoHeight = False
        Me.sec_tbMusteriKarti_sKartNo.MaxLength = 20
        Me.sec_tbMusteriKarti_sKartNo.Name = "sec_tbMusteriKarti_sKartNo"
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Açıklama"
        Me.colsAciklama1.FieldName = "sAciklama"
        Me.colsAciklama1.Name = "colsAciklama1"
        Me.colsAciklama1.Visible = True
        Me.colsAciklama1.VisibleIndex = 1
        '
        'coldteSonKullanmaTarihi
        '
        Me.coldteSonKullanmaTarihi.Caption = "Son Kullanma Tarihi"
        Me.coldteSonKullanmaTarihi.FieldName = "dteSonKullanmaTarihi"
        Me.coldteSonKullanmaTarihi.Name = "coldteSonKullanmaTarihi"
        Me.coldteSonKullanmaTarihi.Visible = True
        Me.coldteSonKullanmaTarihi.VisibleIndex = 2
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "sKullaniciAdi"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        Me.colsKullaniciAdi.OptionsColumn.AllowFocus = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "dteKayitTarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        Me.coldteKayitTarihi.OptionsColumn.AllowFocus = False
        '
        'sec_tbMusteriKarti_sAciklama
        '
        Me.sec_tbMusteriKarti_sAciklama.AutoHeight = False
        Me.sec_tbMusteriKarti_sAciklama.MaxLength = 60
        Me.sec_tbMusteriKarti_sAciklama.Name = "sec_tbMusteriKarti_sAciklama"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.GroupControl11)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage8.Text = "KrediLimiti"
        '
        'GroupControl11
        '
        Me.GroupControl11.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl11.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl11.AppearanceCaption.Options.UseFont = True
        Me.GroupControl11.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl11.Controls.Add(Me.txt_bOzelMustrimi)
        Me.GroupControl11.Controls.Add(Me.txt_dteSonKullanmaTarihi)
        Me.GroupControl11.Controls.Add(Me.LabelControl91)
        Me.GroupControl11.Controls.Add(Me.txt_dteKrediAcilisTarihi)
        Me.GroupControl11.Controls.Add(Me.LabelControl90)
        Me.GroupControl11.Controls.Add(Me.txt_dteKrediLimitiTarihi)
        Me.GroupControl11.Controls.Add(Me.LabelControl89)
        Me.GroupControl11.Controls.Add(Me.txt_llimit)
        Me.GroupControl11.Controls.Add(Me.LabelControl88)
        Me.GroupControl11.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl11.Name = "GroupControl11"
        Me.GroupControl11.Size = New System.Drawing.Size(1297, 448)
        Me.GroupControl11.TabIndex = 0
        Me.GroupControl11.Text = "KrediLimiti"
        '
        'txt_bOzelMustrimi
        '
        Me.txt_bOzelMustrimi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKredisi, "Table1.bOzelMusterimi", True))
        Me.txt_bOzelMustrimi.Location = New System.Drawing.Point(138, 103)
        Me.txt_bOzelMustrimi.Name = "txt_bOzelMustrimi"
        Me.txt_bOzelMustrimi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bOzelMustrimi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bOzelMustrimi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_bOzelMustrimi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_bOzelMustrimi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_bOzelMustrimi.Properties.Caption = "ÖzelMüşteri?"
        Me.txt_bOzelMustrimi.Size = New System.Drawing.Size(217, 24)
        Me.txt_bOzelMustrimi.TabIndex = 4
        '
        'ds_tbMusteriKredisi
        '
        Me.ds_tbMusteriKredisi.DataSetName = "NewDataSet"
        Me.ds_tbMusteriKredisi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriKredisi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "nMusteriID"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lKrediLimiti"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "dteKrediLimitiTarihi"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "dteKrediAcilisTarihi"
        Me.DataColumn15.DataType = GetType(Date)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "dteSonKullanmaTarihi"
        Me.DataColumn16.DataType = GetType(Date)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "bOzelMusterimi"
        Me.DataColumn17.DataType = GetType(Boolean)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sKullaniciAdi"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "dteKayitTarihi"
        Me.DataColumn19.DataType = GetType(Date)
        '
        'txt_dteSonKullanmaTarihi
        '
        Me.txt_dteSonKullanmaTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKredisi, "Table1.dteSonKullanmaTarihi", True))
        Me.txt_dteSonKullanmaTarihi.EditValue = Nothing
        Me.txt_dteSonKullanmaTarihi.EnterMoveNextControl = True
        Me.txt_dteSonKullanmaTarihi.Location = New System.Drawing.Point(525, 74)
        Me.txt_dteSonKullanmaTarihi.Name = "txt_dteSonKullanmaTarihi"
        Me.txt_dteSonKullanmaTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteSonKullanmaTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteSonKullanmaTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteSonKullanmaTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteSonKullanmaTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteSonKullanmaTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteSonKullanmaTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteSonKullanmaTarihi.Size = New System.Drawing.Size(217, 26)
        Me.txt_dteSonKullanmaTarihi.TabIndex = 3
        '
        'LabelControl91
        '
        Me.LabelControl91.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl91.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl91.Location = New System.Drawing.Point(366, 74)
        Me.LabelControl91.Name = "LabelControl91"
        Me.LabelControl91.Size = New System.Drawing.Size(139, 19)
        Me.LabelControl91.TabIndex = 42
        Me.LabelControl91.Text = "SonKullanmaTarihi:"
        '
        'txt_dteKrediAcilisTarihi
        '
        Me.txt_dteKrediAcilisTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKredisi, "Table1.dteKrediAcilisTarihi", True))
        Me.txt_dteKrediAcilisTarihi.EditValue = Nothing
        Me.txt_dteKrediAcilisTarihi.EnterMoveNextControl = True
        Me.txt_dteKrediAcilisTarihi.Location = New System.Drawing.Point(525, 46)
        Me.txt_dteKrediAcilisTarihi.Name = "txt_dteKrediAcilisTarihi"
        Me.txt_dteKrediAcilisTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteKrediAcilisTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteKrediAcilisTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteKrediAcilisTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteKrediAcilisTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteKrediAcilisTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteKrediAcilisTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteKrediAcilisTarihi.Size = New System.Drawing.Size(217, 26)
        Me.txt_dteKrediAcilisTarihi.TabIndex = 2
        '
        'LabelControl90
        '
        Me.LabelControl90.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl90.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl90.Location = New System.Drawing.Point(387, 49)
        Me.LabelControl90.Name = "LabelControl90"
        Me.LabelControl90.Size = New System.Drawing.Size(120, 19)
        Me.LabelControl90.TabIndex = 40
        Me.LabelControl90.Text = "KrediAçılışTarihi:"
        '
        'txt_dteKrediLimitiTarihi
        '
        Me.txt_dteKrediLimitiTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKredisi, "Table1.dteKrediLimitiTarihi", True))
        Me.txt_dteKrediLimitiTarihi.EditValue = Nothing
        Me.txt_dteKrediLimitiTarihi.EnterMoveNextControl = True
        Me.txt_dteKrediLimitiTarihi.Location = New System.Drawing.Point(141, 74)
        Me.txt_dteKrediLimitiTarihi.Name = "txt_dteKrediLimitiTarihi"
        Me.txt_dteKrediLimitiTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteKrediLimitiTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteKrediLimitiTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteKrediLimitiTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteKrediLimitiTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteKrediLimitiTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteKrediLimitiTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteKrediLimitiTarihi.Size = New System.Drawing.Size(217, 26)
        Me.txt_dteKrediLimitiTarihi.TabIndex = 1
        '
        'LabelControl89
        '
        Me.LabelControl89.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl89.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl89.Location = New System.Drawing.Point(10, 74)
        Me.LabelControl89.Name = "LabelControl89"
        Me.LabelControl89.Size = New System.Drawing.Size(122, 19)
        Me.LabelControl89.TabIndex = 38
        Me.LabelControl89.Text = "KrediLimitiTarihi:"
        '
        'txt_llimit
        '
        Me.txt_llimit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriKredisi, "Table1.lKrediLimiti", True))
        Me.txt_llimit.EnterMoveNextControl = True
        Me.txt_llimit.Location = New System.Drawing.Point(141, 46)
        Me.txt_llimit.Name = "txt_llimit"
        Me.txt_llimit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_llimit.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_llimit.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_llimit.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_llimit.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_llimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_llimit.Size = New System.Drawing.Size(217, 26)
        Me.txt_llimit.TabIndex = 0
        '
        'LabelControl88
        '
        Me.LabelControl88.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl88.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl88.Location = New System.Drawing.Point(93, 49)
        Me.LabelControl88.Name = "LabelControl88"
        Me.LabelControl88.Size = New System.Drawing.Size(41, 19)
        Me.LabelControl88.TabIndex = 36
        Me.LabelControl88.Text = "Limit:"
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.GridControl4)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage9.Text = "EkKartlar"
        '
        'GridControl4
        '
        Me.GridControl4.ContextMenu = Me.kisayol_EkKart
        Me.GridControl4.DataMember = "Table1"
        Me.GridControl4.DataSource = Me.ds_tbMusteriEkKart
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView5
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(1300, 446)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'kisayol_EkKart
        '
        Me.kisayol_EkKart.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem4.Text = "Ekle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem5.Text = "Düzelt"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem6.Text = "Sil"
        '
        'ds_tbMusteriEkKart
        '
        Me.ds_tbMusteriEkKart.DataSetName = "NewDataSet"
        Me.ds_tbMusteriEkKart.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriEkKart.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "nEkKartID"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "nMusteriID"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sAdi"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sSoyadi"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sUnvan"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sEmail"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sIsYeriAdi"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sIsAdresi1"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sIsAdresi2"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sIsSemt"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sIsPostaKodu"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sIsIl"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sIsTelefonu"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sEvAdresi1"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sEvAdresi2"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sEvSemt"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sEvPostaKodu"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sEvIl"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sEvTelefonu"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "lAylikGelir"
        Me.DataColumn39.DataType = GetType(Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sSigortaNo"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "sHitap"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "sKullaniciAdi"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "dteKayitTarihi"
        Me.DataColumn43.DataType = GetType(Date)
        '
        'GridView5
        '
        Me.GridView5.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnEkKartID, Me.colnMusteriID3, Me.colsAdi1, Me.colsSoyadi1, Me.colsUnvan, Me.colsEmail, Me.colsIsYeriAdi, Me.colsIsAdresi1, Me.colsIsAdresi2, Me.colsIsSemt, Me.colsIsPostaKodu, Me.colsIsIl, Me.colsIsTelefonu, Me.colsEvAdresi1, Me.colsEvAdresi2, Me.colsEvSemt, Me.colsEvPostaKodu, Me.colsEvIl, Me.colsEvTelefonu, Me.collAylikGelir, Me.colsSigortaNo, Me.colsHitap, Me.colsKullaniciAdi1, Me.coldteKayitTarihi1})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(249, 281, 208, 170)
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.GridControl4
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.IndicatorWidth = 12
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView5.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView5.OptionsNavigation.UseTabKey = False
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colnEkKartID
        '
        Me.colnEkKartID.Caption = "EkKartID"
        Me.colnEkKartID.FieldName = "nEkKartID"
        Me.colnEkKartID.Name = "colnEkKartID"
        '
        'colnMusteriID3
        '
        Me.colnMusteriID3.Caption = "MusteriID"
        Me.colnMusteriID3.FieldName = "nMusteriID"
        Me.colnMusteriID3.Name = "colnMusteriID3"
        '
        'colsAdi1
        '
        Me.colsAdi1.Caption = "Adı"
        Me.colsAdi1.FieldName = "sAdi"
        Me.colsAdi1.Name = "colsAdi1"
        Me.colsAdi1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAdi", "{0} Kayıt")})
        Me.colsAdi1.Visible = True
        Me.colsAdi1.VisibleIndex = 0
        Me.colsAdi1.Width = 91
        '
        'colsSoyadi1
        '
        Me.colsSoyadi1.Caption = "Soyadi"
        Me.colsSoyadi1.FieldName = "sSoyadi"
        Me.colsSoyadi1.Name = "colsSoyadi1"
        Me.colsSoyadi1.Visible = True
        Me.colsSoyadi1.VisibleIndex = 1
        Me.colsSoyadi1.Width = 98
        '
        'colsUnvan
        '
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        Me.colsUnvan.Width = 91
        '
        'colsEmail
        '
        Me.colsEmail.Caption = "Email"
        Me.colsEmail.FieldName = "sEmail"
        Me.colsEmail.Name = "colsEmail"
        Me.colsEmail.Width = 101
        '
        'colsIsYeriAdi
        '
        Me.colsIsYeriAdi.Caption = "İş Yeri Adı"
        Me.colsIsYeriAdi.FieldName = "sIsYeriAdi"
        Me.colsIsYeriAdi.Name = "colsIsYeriAdi"
        Me.colsIsYeriAdi.Width = 325
        '
        'colsIsAdresi1
        '
        Me.colsIsAdresi1.Caption = "İş Adresi 1"
        Me.colsIsAdresi1.FieldName = "sIsAdresi1"
        Me.colsIsAdresi1.Name = "colsIsAdresi1"
        Me.colsIsAdresi1.Width = 235
        '
        'colsIsAdresi2
        '
        Me.colsIsAdresi2.Caption = "İş Adresi 2"
        Me.colsIsAdresi2.FieldName = "sIsAdresi2"
        Me.colsIsAdresi2.Name = "colsIsAdresi2"
        Me.colsIsAdresi2.Width = 184
        '
        'colsIsSemt
        '
        Me.colsIsSemt.Caption = "İş Semt"
        Me.colsIsSemt.FieldName = "sIsSemt"
        Me.colsIsSemt.Name = "colsIsSemt"
        Me.colsIsSemt.Width = 106
        '
        'colsIsPostaKodu
        '
        Me.colsIsPostaKodu.Caption = "İş Posta Kodu"
        Me.colsIsPostaKodu.FieldName = "sIsPostaKodu"
        Me.colsIsPostaKodu.Name = "colsIsPostaKodu"
        Me.colsIsPostaKodu.Width = 105
        '
        'colsIsIl
        '
        Me.colsIsIl.Caption = "İş İl"
        Me.colsIsIl.FieldName = "sIsIl"
        Me.colsIsIl.Name = "colsIsIl"
        Me.colsIsIl.Width = 94
        '
        'colsIsTelefonu
        '
        Me.colsIsTelefonu.Caption = "İş Telefonu"
        Me.colsIsTelefonu.FieldName = "sIsTelefonu"
        Me.colsIsTelefonu.Name = "colsIsTelefonu"
        Me.colsIsTelefonu.Visible = True
        Me.colsIsTelefonu.VisibleIndex = 5
        Me.colsIsTelefonu.Width = 95
        '
        'colsEvAdresi1
        '
        Me.colsEvAdresi1.Caption = "Ev Adresi 1"
        Me.colsEvAdresi1.FieldName = "sEvAdresi1"
        Me.colsEvAdresi1.Name = "colsEvAdresi1"
        Me.colsEvAdresi1.Visible = True
        Me.colsEvAdresi1.VisibleIndex = 2
        Me.colsEvAdresi1.Width = 114
        '
        'colsEvAdresi2
        '
        Me.colsEvAdresi2.Caption = "Ev Adresi 2"
        Me.colsEvAdresi2.FieldName = "sEvAdresi2"
        Me.colsEvAdresi2.Name = "colsEvAdresi2"
        Me.colsEvAdresi2.Visible = True
        Me.colsEvAdresi2.VisibleIndex = 3
        Me.colsEvAdresi2.Width = 117
        '
        'colsEvSemt
        '
        Me.colsEvSemt.Caption = "Ev Semti"
        Me.colsEvSemt.FieldName = "sEvSemt"
        Me.colsEvSemt.Name = "colsEvSemt"
        Me.colsEvSemt.Width = 65
        '
        'colsEvPostaKodu
        '
        Me.colsEvPostaKodu.Caption = "Ev Posta Kodu"
        Me.colsEvPostaKodu.FieldName = "sEvPostaKodu"
        Me.colsEvPostaKodu.Name = "colsEvPostaKodu"
        Me.colsEvPostaKodu.Width = 72
        '
        'colsEvIl
        '
        Me.colsEvIl.Caption = "Ev İl"
        Me.colsEvIl.FieldName = "sEvIl"
        Me.colsEvIl.Name = "colsEvIl"
        Me.colsEvIl.Width = 89
        '
        'colsEvTelefonu
        '
        Me.colsEvTelefonu.Caption = "Ev Telefonu"
        Me.colsEvTelefonu.FieldName = "sEvTelefonu"
        Me.colsEvTelefonu.Name = "colsEvTelefonu"
        Me.colsEvTelefonu.Visible = True
        Me.colsEvTelefonu.VisibleIndex = 4
        Me.colsEvTelefonu.Width = 67
        '
        'collAylikGelir
        '
        Me.collAylikGelir.Caption = "Aylık Gelir"
        Me.collAylikGelir.FieldName = "lAylikGelir"
        Me.collAylikGelir.Name = "collAylikGelir"
        Me.collAylikGelir.Width = 57
        '
        'colsSigortaNo
        '
        Me.colsSigortaNo.Caption = "Sigorta No"
        Me.colsSigortaNo.FieldName = "sSigortaNo"
        Me.colsSigortaNo.Name = "colsSigortaNo"
        Me.colsSigortaNo.Width = 61
        '
        'colsHitap
        '
        Me.colsHitap.Caption = "Hitap"
        Me.colsHitap.FieldName = "sHitap"
        Me.colsHitap.Name = "colsHitap"
        Me.colsHitap.Width = 36
        '
        'colsKullaniciAdi1
        '
        Me.colsKullaniciAdi1.Caption = "Kullanıcı Adı"
        Me.colsKullaniciAdi1.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi1.Name = "colsKullaniciAdi1"
        Me.colsKullaniciAdi1.Width = 41
        '
        'coldteKayitTarihi1
        '
        Me.coldteKayitTarihi1.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi1.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi1.Name = "coldteKayitTarihi1"
        Me.coldteKayitTarihi1.Width = 59
        '
        'XtraTabPage10
        '
        Me.XtraTabPage10.Controls.Add(Me.GridControl3)
        Me.XtraTabPage10.Name = "XtraTabPage10"
        Me.XtraTabPage10.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage10.Text = "Çocuklar"
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.kisayol_cocuk
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.ds_tbMusteriCocugu
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_tbMusteriCocugu_nCinsiyet})
        Me.GridControl3.Size = New System.Drawing.Size(1300, 446)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'kisayol_cocuk
        '
        Me.kisayol_cocuk.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem8, Me.MenuItem9})
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem7.Text = "Ekle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem8.Text = "Düzelt"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem9.Text = "Sil"
        '
        'ds_tbMusteriCocugu
        '
        Me.ds_tbMusteriCocugu.DataSetName = "NewDataSet"
        Me.ds_tbMusteriCocugu.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriCocugu.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "nMusteriID"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "sAdi"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sSoyadi"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "nCinsiyet"
        Me.DataColumn47.DataType = GetType(Long)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "dteDogumTarihi"
        Me.DataColumn48.DataType = GetType(Date)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "sDogumYeri"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "sOzelNot"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID2, Me.colsAdi, Me.colsSoyadi, Me.colnCinsiyet, Me.coldteDogumTarihi, Me.colsDogumYeri, Me.colsOzelNot})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colnMusteriID2
        '
        Me.colnMusteriID2.Caption = "MusteriID"
        Me.colnMusteriID2.FieldName = "nMusteriID"
        Me.colnMusteriID2.Name = "colnMusteriID2"
        Me.colnMusteriID2.OptionsColumn.AllowEdit = False
        Me.colnMusteriID2.OptionsColumn.AllowFocus = False
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adı"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAdi", "{0} Kayıt")})
        Me.colsAdi.Visible = True
        Me.colsAdi.VisibleIndex = 0
        Me.colsAdi.Width = 107
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadi"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Visible = True
        Me.colsSoyadi.VisibleIndex = 1
        Me.colsSoyadi.Width = 107
        '
        'colnCinsiyet
        '
        Me.colnCinsiyet.Caption = "Cinsiyet"
        Me.colnCinsiyet.ColumnEdit = Me.sec_tbMusteriCocugu_nCinsiyet
        Me.colnCinsiyet.FieldName = "nCinsiyet"
        Me.colnCinsiyet.Name = "colnCinsiyet"
        Me.colnCinsiyet.Visible = True
        Me.colnCinsiyet.VisibleIndex = 2
        Me.colnCinsiyet.Width = 55
        '
        'sec_tbMusteriCocugu_nCinsiyet
        '
        Me.sec_tbMusteriCocugu_nCinsiyet.AutoHeight = False
        Me.sec_tbMusteriCocugu_nCinsiyet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tbMusteriCocugu_nCinsiyet.DisplayMember = "sAciklama"
        Me.sec_tbMusteriCocugu_nCinsiyet.Name = "sec_tbMusteriCocugu_nCinsiyet"
        Me.sec_tbMusteriCocugu_nCinsiyet.NullText = "[Cinsiyet]"
        Me.sec_tbMusteriCocugu_nCinsiyet.ValueMember = "nCinsiyet"
        '
        'coldteDogumTarihi
        '
        Me.coldteDogumTarihi.Caption = "Doğum Tarihi"
        Me.coldteDogumTarihi.FieldName = "dteDogumTarihi"
        Me.coldteDogumTarihi.Name = "coldteDogumTarihi"
        Me.coldteDogumTarihi.Visible = True
        Me.coldteDogumTarihi.VisibleIndex = 3
        Me.coldteDogumTarihi.Width = 72
        '
        'colsDogumYeri
        '
        Me.colsDogumYeri.Caption = "Doğum Yeri"
        Me.colsDogumYeri.FieldName = "sDogumYeri"
        Me.colsDogumYeri.Name = "colsDogumYeri"
        Me.colsDogumYeri.Visible = True
        Me.colsDogumYeri.VisibleIndex = 4
        Me.colsDogumYeri.Width = 91
        '
        'colsOzelNot
        '
        Me.colsOzelNot.Caption = "Not"
        Me.colsOzelNot.FieldName = "sOzelNot"
        Me.colsOzelNot.Name = "colsOzelNot"
        Me.colsOzelNot.Visible = True
        Me.colsOzelNot.VisibleIndex = 5
        Me.colsOzelNot.Width = 215
        '
        'XtraTabPage11
        '
        Me.XtraTabPage11.Controls.Add(Me.GridControl5)
        Me.XtraTabPage11.Name = "XtraTabPage11"
        Me.XtraTabPage11.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage11.Text = "Notlar"
        '
        'GridControl5
        '
        Me.GridControl5.ContextMenu = Me.kisayol_OzelNot
        Me.GridControl5.DataMember = "Table1"
        Me.GridControl5.DataSource = Me.ds_tbMusteriOzelNot
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(0, 0)
        Me.GridControl5.MainView = Me.GridView4
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(1300, 446)
        Me.GridControl5.TabIndex = 0
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'kisayol_OzelNot
        '
        Me.kisayol_OzelNot.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem14, Me.MenuItem13})
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem10.Text = "Ekle"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem11.Text = "Düzelt"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem12.Text = "Sil"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Text = "Hızlı Filtre"
        '
        'ds_tbMusteriOzelNot
        '
        Me.ds_tbMusteriOzelNot.DataSetName = "NewDataSet"
        Me.ds_tbMusteriOzelNot.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriOzelNot.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "nMusteriID"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "dteGirisTarihi"
        Me.DataColumn52.DataType = GetType(Date)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "sText"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "sKullaniciAdi"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "dteKayitTarihi"
        Me.DataColumn55.DataType = GetType(Date)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID4, Me.coldteGirisTarihi, Me.colsText, Me.colsKullaniciAdi2, Me.coldteKayitTarihi2})
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl5
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.IndicatorWidth = 12
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsDetail.ShowDetailTabs = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colnMusteriID4
        '
        Me.colnMusteriID4.Caption = "Müşteri ID"
        Me.colnMusteriID4.FieldName = "nMusteriID"
        Me.colnMusteriID4.Name = "colnMusteriID4"
        Me.colnMusteriID4.OptionsColumn.AllowEdit = False
        Me.colnMusteriID4.OptionsColumn.AllowFocus = False
        '
        'coldteGirisTarihi
        '
        Me.coldteGirisTarihi.Caption = "GirisTarihi"
        Me.coldteGirisTarihi.FieldName = "dteGirisTarihi"
        Me.coldteGirisTarihi.Name = "coldteGirisTarihi"
        Me.coldteGirisTarihi.OptionsColumn.AllowEdit = False
        Me.coldteGirisTarihi.OptionsColumn.AllowFocus = False
        Me.coldteGirisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteGirisTarihi", "{0} Kayıt")})
        Me.coldteGirisTarihi.Visible = True
        Me.coldteGirisTarihi.VisibleIndex = 0
        Me.coldteGirisTarihi.Width = 95
        '
        'colsText
        '
        Me.colsText.Caption = "Not"
        Me.colsText.FieldName = "sText"
        Me.colsText.Name = "colsText"
        Me.colsText.Visible = True
        Me.colsText.VisibleIndex = 1
        Me.colsText.Width = 552
        '
        'colsKullaniciAdi2
        '
        Me.colsKullaniciAdi2.Caption = "sKullaniciAdi"
        Me.colsKullaniciAdi2.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi2.Name = "colsKullaniciAdi2"
        Me.colsKullaniciAdi2.OptionsColumn.AllowEdit = False
        Me.colsKullaniciAdi2.OptionsColumn.AllowFocus = False
        '
        'coldteKayitTarihi2
        '
        Me.coldteKayitTarihi2.Caption = "dteKayitTarihi"
        Me.coldteKayitTarihi2.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi2.Name = "coldteKayitTarihi2"
        Me.coldteKayitTarihi2.OptionsColumn.AllowEdit = False
        Me.coldteKayitTarihi2.OptionsColumn.AllowFocus = False
        '
        'XtraTabPage12
        '
        Me.XtraTabPage12.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage12.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage12.Name = "XtraTabPage12"
        Me.XtraTabPage12.Size = New System.Drawing.Size(1300, 446)
        Me.XtraTabPage12.Text = "Dökümanlar"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GridControl6)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1300, 388)
        Me.PanelControl5.TabIndex = 1
        '
        'GridControl6
        '
        Me.GridControl6.DataMember = "Table1"
        Me.GridControl6.DataSource = Me.ds_tbMusteriResim
        Me.GridControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl6.Location = New System.Drawing.Point(2, 2)
        Me.GridControl6.MainView = Me.GridView6
        Me.GridControl6.MenuManager = Me.BarManager1
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_pResim})
        Me.GridControl6.Size = New System.Drawing.Size(1296, 384)
        Me.GridControl6.TabIndex = 0
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'ds_tbMusteriResim
        '
        Me.ds_tbMusteriResim.DataSetName = "NewDataSet"
        Me.ds_tbMusteriResim.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriResim.Tables.AddRange(New System.Data.DataTable() {Me.DataTable11})
        '
        'DataTable11
        '
        Me.DataTable11.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn169, Me.DataColumn170, Me.DataColumn171, Me.DataColumn172, Me.DataColumn173, Me.DataColumn174, Me.DataColumn175})
        Me.DataTable11.TableName = "Table1"
        '
        'DataColumn169
        '
        Me.DataColumn169.ColumnName = "nMusteriID"
        Me.DataColumn169.DataType = GetType(Long)
        '
        'DataColumn170
        '
        Me.DataColumn170.ColumnName = "pResim"
        Me.DataColumn170.DataType = GetType(Byte())
        '
        'DataColumn171
        '
        Me.DataColumn171.ColumnName = "sAciklama"
        '
        'DataColumn172
        '
        Me.DataColumn172.ColumnName = "dteKayitTarihi"
        Me.DataColumn172.DataType = GetType(Date)
        '
        'DataColumn173
        '
        Me.DataColumn173.AutoIncrement = True
        Me.DataColumn173.ColumnName = "nMusteriResimID"
        Me.DataColumn173.DataType = GetType(Long)
        '
        'DataColumn174
        '
        Me.DataColumn174.ColumnName = "sKullaniciAdi"
        '
        'DataColumn175
        '
        Me.DataColumn175.ColumnName = "nSira"
        Me.DataColumn175.DataType = GetType(Short)
        Me.DataColumn175.DefaultValue = CType(0, Short)
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID5, Me.colpResim, Me.colsAciklama2, Me.coldtekayitTarihi3, Me.colnSira})
        Me.GridView6.GridControl = Me.GridControl6
        Me.GridView6.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView6.IndicatorWidth = 35
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.RowHeight = 100
        '
        'colnMusteriID5
        '
        Me.colnMusteriID5.Caption = "MusteriID"
        Me.colnMusteriID5.FieldName = "nMusteriID"
        Me.colnMusteriID5.Name = "colnMusteriID5"
        Me.colnMusteriID5.OptionsColumn.AllowEdit = False
        Me.colnMusteriID5.OptionsColumn.AllowFocus = False
        Me.colnMusteriID5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nMusteriID", "{0} Kayıt")})
        Me.colnMusteriID5.Width = 109
        '
        'colpResim
        '
        Me.colpResim.Caption = "Resim"
        Me.colpResim.ColumnEdit = Me.sec_pResim
        Me.colpResim.FieldName = "pResim"
        Me.colpResim.Name = "colpResim"
        Me.colpResim.OptionsColumn.AllowEdit = False
        Me.colpResim.OptionsColumn.AllowFocus = False
        Me.colpResim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "pResim", "{0} Kayıt")})
        Me.colpResim.Visible = True
        Me.colpResim.VisibleIndex = 0
        Me.colpResim.Width = 350
        '
        'sec_pResim
        '
        Me.sec_pResim.Name = "sec_pResim"
        Me.sec_pResim.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'colsAciklama2
        '
        Me.colsAciklama2.Caption = "Açıklama"
        Me.colsAciklama2.FieldName = "sAciklama"
        Me.colsAciklama2.Name = "colsAciklama2"
        Me.colsAciklama2.Visible = True
        Me.colsAciklama2.VisibleIndex = 2
        Me.colsAciklama2.Width = 367
        '
        'coldtekayitTarihi3
        '
        Me.coldtekayitTarihi3.Caption = "KayıtTarihi"
        Me.coldtekayitTarihi3.FieldName = "dteKayitTarihi"
        Me.coldtekayitTarihi3.Name = "coldtekayitTarihi3"
        Me.coldtekayitTarihi3.OptionsColumn.AllowEdit = False
        Me.coldtekayitTarihi3.OptionsColumn.AllowFocus = False
        Me.coldtekayitTarihi3.Width = 222
        '
        'colnSira
        '
        Me.colnSira.Caption = "Sira"
        Me.colnSira.FieldName = "nSira"
        Me.colnSira.Name = "colnSira"
        Me.colnSira.Visible = True
        Me.colnSira.VisibleIndex = 1
        Me.colnSira.Width = 36
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Müşteri Kartı"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Satışlar"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Ödemeler"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Kalan Taksitler"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Kalan Ödemeler"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Bekleyen"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Notlar"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Ekstre"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Karlılık ,Ctrl+Z"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Sınıflar"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Tamam"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Vazgeç"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1310, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 614)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1310, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 614)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1310, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 614)
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.SimpleButton13)
        Me.PanelControl4.Controls.Add(Me.SimpleButton11)
        Me.PanelControl4.Controls.Add(Me.SimpleButton12)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 388)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1300, 58)
        Me.PanelControl4.TabIndex = 0
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton13.Image = CType(resources.GetObject("SimpleButton13.Image"), System.Drawing.Image)
        Me.SimpleButton13.Location = New System.Drawing.Point(255, 9)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton13.TabIndex = 16
        Me.SimpleButton13.Text = "&Yazdır"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton11.Image = CType(resources.GetObject("SimpleButton11.Image"), System.Drawing.Image)
        Me.SimpleButton11.Location = New System.Drawing.Point(135, 9)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton11.TabIndex = 15
        Me.SimpleButton11.Text = "&Sil"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton12.Image = CType(resources.GetObject("SimpleButton12.Image"), System.Drawing.Image)
        Me.SimpleButton12.Location = New System.Drawing.Point(15, 9)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton12.TabIndex = 14
        Me.SimpleButton12.Text = "&Ekle"
        '
        'ds_tbMusteriSinifi
        '
        Me.ds_tbMusteriSinifi.DataSetName = "NewDataSet"
        Me.ds_tbMusteriSinifi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriSinifi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sSinifTipi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sSinifKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sAciklama"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "bSatisYapilamaz"
        Me.DataColumn5.DataType = GetType(Boolean)
        '
        'frm_musteri_kart
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1310, 649)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_musteri_kart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Kartı"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl10.ResumeLayout(False)
        Me.GroupControl10.PerformLayout
        CType(Me.sec_bMusteriAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteri, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.btn_ReferansSec.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sUnvan1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_bYazismaEvAdresinemi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sKanGrubu.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sEhliyetNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_nIskontoPesin.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_nIskontoKredili.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_lAylikGelir.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sDogumYeri.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteDogumTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteDogumTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_nCinsiyet.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteEvlilikTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteEvlilikTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_bEvlimi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout
        CType(Me.txt_sIsIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sIsTelefonu.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sIsPostaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sIsSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sIsAdres2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_IsAdres1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sIsyeriAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout
        CType(Me.txt_sEvIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sEvPostaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sEvSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sEvTelefonu.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sEvAdres2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sEvAdresi1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout
        CType(Me.txt_sFaks.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl12.ResumeLayout(False)
        Me.GroupControl12.PerformLayout
        CType(Me.TextEdit31.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriNufusu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sSeriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAileIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sHitap3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sHitap2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAileTelefonu.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sSigortaNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAilePostaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAileSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAileAdresi2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAileAdresi1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sCuzdanKayitNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sCuzdanVerNedeni.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sCuzdanVerilenYer.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteNufusCuzdanTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteNufusCuzdanTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sKutukSiraNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sKutukCiltNo.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sKutukMahalle.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sKutukIlce.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sKutukIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sAnneAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sBabaAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout
        CType(Me.txt_sKefil1IsIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriKefil1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit56.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit49.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit50.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit52.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit53.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit54.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit55.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout
        CType(Me.txt_sKefil1EvIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit44.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit45.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit46.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit47.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit48.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout
        CType(Me.txt_sHitap4.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sUnvan2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit42.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit39.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit41.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout
        CType(Me.txt_sKefil2IsIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriKefil2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit57.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit58.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit60.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit61.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit62.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit63.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit64.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl8.ResumeLayout(False)
        Me.GroupControl8.PerformLayout
        CType(Me.txt_sKefil2EvIl.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit66.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit67.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit68.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit69.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit70.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl9.ResumeLayout(False)
        Me.GroupControl9.PerformLayout
        CType(Me.txt_sHitap5.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_sUnvan3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CalcEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit71.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit72.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit73.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage13.ResumeLayout(False)
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl13.ResumeLayout(False)
        Me.GroupControl13.PerformLayout
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriKefil3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl14, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl14.ResumeLayout(False)
        Me.GroupControl14.PerformLayout
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl15, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl15.ResumeLayout(False)
        Me.GroupControl15.PerformLayout
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage14.ResumeLayout(False)
        CType(Me.GroupControl16, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl16.ResumeLayout(False)
        Me.GroupControl16.PerformLayout
        CType(Me.LookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriKefil4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl17, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl17.ResumeLayout(False)
        Me.GroupControl17.PerformLayout
        CType(Me.LookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit24.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit25.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit26.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit27.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl18, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl18.ResumeLayout(False)
        Me.GroupControl18.PerformLayout
        CType(Me.LookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CalcEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit28.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit29.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit30.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sec_sSiniflar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage7.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriKarti, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sec_tbMusteriKarti_sKartNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sec_tbMusteriKarti_sAciklama, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage8.ResumeLayout(False)
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl11.ResumeLayout(False)
        Me.GroupControl11.PerformLayout
        CType(Me.txt_bOzelMustrimi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriKredisi, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteSonKullanmaTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteSonKullanmaTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteKrediAcilisTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteKrediAcilisTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteKrediLimitiTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_dteKrediLimitiTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_llimit.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriEkKart, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage10.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriCocugu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sec_tbMusteriCocugu_nCinsiyet, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage11.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriOzelNot, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabPage12.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ds_tbMusteriResim, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.ds_tbMusteriSinifi, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nMusteriID
    Public lKodu
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Dim ds_tbUnvan As DataSet
    Dim ds_tbHitap As DataSet
    Dim ds_tbIl As DataSet
    Dim ds_tbCinsiyet As DataSet
    Dim sCocukAdi As String
    Dim sCocukSoyadi As String
    Private Sub frm_musteri_kart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If nMusteriID = 0 Then
            'musteri_sec()
            txt_musteriNo.Focus()
            txt_musteriNo.Select()
        Else
            txt_musteriNo.EditValue = lKodu
            dataload(nMusteriID)
            PanelControl3.Focus()
            PanelControl3.Select()
            XtraTabControl1.Focus()
            XtraTabControl1.Select()
            XtraTabControl1.SelectedTabPageIndex = 0
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        End If
        dataload_tbDepo()
        dataload_tbCinsiyet()
        dataload_tbUnvan()
        dataload_tbHitap()
        dataload_tbIl()
        txt_sMagaza.Focus()
        txt_sMagaza.SelectAll()
        'dataload_tbMSinif(1)
    End Sub
    Private Sub dataload_tbDepo()
        txt_sMagaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDepo, sAciklama FROM tbDepo Where sDepo <> '' ")).Tables(0)
    End Sub
    Private Sub dataload_tbCinsiyet()
        ds_tbCinsiyet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbCinsiyet"))
        txt_nCinsiyet.Properties.DataSource = ds_tbCinsiyet.Tables(0)
        sec_tbMusteriCocugu_nCinsiyet.DataSource = ds_tbCinsiyet.Tables(0)
    End Sub
    Private Sub dataload_tbUnvan()
        ds_tbUnvan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbUnvan"))
        txt_sUnvan1.Properties.DataSource = ds_tbUnvan.Tables(0)
        txt_sUnvan2.Properties.DataSource = ds_tbUnvan.Tables(0)
        txt_sUnvan3.Properties.DataSource = ds_tbUnvan.Tables(0)
        LookUpEdit4.Properties.DataSource = ds_tbUnvan.Tables(0)
        LookUpEdit8.Properties.DataSource = ds_tbUnvan.Tables(0)
    End Sub
    Private Sub dataload_tbHitap()
        ds_tbHitap = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbHitap"))
        txt_sHitap1.Properties.DataSource = ds_tbHitap.Tables(0)
        txt_sHitap2.Properties.DataSource = ds_tbHitap.Tables(0)
        txt_sHitap3.Properties.DataSource = ds_tbHitap.Tables(0)
        txt_sHitap4.Properties.DataSource = ds_tbHitap.Tables(0)
        txt_sHitap5.Properties.DataSource = ds_tbHitap.Tables(0)
        LookUpEdit3.Properties.DataSource = ds_tbHitap.Tables(0)
        LookUpEdit7.Properties.DataSource = ds_tbHitap.Tables(0)
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbIl"))
        txt_sEvIl.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sIsIl.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sAileIl.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sKefil1EvIl.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sKefil1IsIl.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sKefil2EvIl.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sKefil2IsIl.Properties.DataSource = ds_tbIl.Tables(0)
        LookUpEdit6.Properties.DataSource = ds_tbIl.Tables(0)
        LookUpEdit5.Properties.DataSource = ds_tbIl.Tables(0)
        LookUpEdit2.Properties.DataSource = ds_tbIl.Tables(0)
        LookUpEdit1.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbMSinif(Optional ByVal sSinifNo As Integer = 1)
        'sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMSinif" & sSinifNo & "")).Tables(0)
        sec_sSiniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMSinif" & sSinifNo & "")).Tables(0)
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView4.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView5.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        LabelControl6.Text = Sorgu_sDil(LabelControl6.Text, sDil)
        LabelControl7.Text = Sorgu_sDil(LabelControl7.Text, sDil)
        LabelControl8.Text = Sorgu_sDil(LabelControl8.Text, sDil)
        LabelControl9.Text = Sorgu_sDil(LabelControl9.Text, sDil)
        LabelControl10.Text = Sorgu_sDil(LabelControl10.Text, sDil)
        LabelControl11.Text = Sorgu_sDil(LabelControl11.Text, sDil)
        LabelControl12.Text = Sorgu_sDil(LabelControl12.Text, sDil)
        LabelControl13.Text = Sorgu_sDil(LabelControl13.Text, sDil)
        LabelControl14.Text = Sorgu_sDil(LabelControl14.Text, sDil)
        LabelControl15.Text = Sorgu_sDil(LabelControl15.Text, sDil)
        LabelControl16.Text = Sorgu_sDil(LabelControl16.Text, sDil)
        LabelControl17.Text = Sorgu_sDil(LabelControl17.Text, sDil)
        LabelControl18.Text = Sorgu_sDil(LabelControl18.Text, sDil)
        LabelControl19.Text = Sorgu_sDil(LabelControl19.Text, sDil)
        LabelControl20.Text = Sorgu_sDil(LabelControl20.Text, sDil)
        LabelControl21.Text = Sorgu_sDil(LabelControl21.Text, sDil)
        LabelControl22.Text = Sorgu_sDil(LabelControl22.Text, sDil)
        LabelControl23.Text = Sorgu_sDil(LabelControl23.Text, sDil)
        LabelControl24.Text = Sorgu_sDil(LabelControl24.Text, sDil)
        LabelControl25.Text = Sorgu_sDil(LabelControl25.Text, sDil)
        LabelControl26.Text = Sorgu_sDil(LabelControl26.Text, sDil)
        LabelControl27.Text = Sorgu_sDil(LabelControl27.Text, sDil)
        LabelControl28.Text = Sorgu_sDil(LabelControl28.Text, sDil)
        LabelControl29.Text = Sorgu_sDil(LabelControl29.Text, sDil)
        LabelControl30.Text = Sorgu_sDil(LabelControl30.Text, sDil)
        LabelControl31.Text = Sorgu_sDil(LabelControl31.Text, sDil)
        LabelControl32.Text = Sorgu_sDil(LabelControl32.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
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
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nMusteriID = dr1("nMusteriID")
            lKodu = dr1("lKodu")
            txt_musteriNo.EditValue = lKodu
            musteri_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub referans_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            btn_ReferansSec.Text = dr1("nMusteriID")
            lbl_Referans.Text = dr1("Musteri")
            tbMusteriRefeerans_kaydet_yeni(nMusteriID, dr1("nMusteriID"))
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    lKodu = dr("MUSTERIKODU")
                    nMusteriID = dr("IND")
                    dataload(nMusteriID)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_acik_faturalar()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = nMusteriID
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
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = nMusteriID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = lKodu
            frm.musteriID = nMusteriID
            frm.kullanici = kullanici
            frm.lbl_Firma.Text = txt_sAdi.Text
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = lKodu
            frm.musteriID = nMusteriID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = lKodu
            frm.musteriID = nMusteriID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_duzenle()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lKodu = lKodu
            frm.nMusteriID = nMusteriID
            frm.kullanici = kullanici
            'If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
            'End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_bekleyen()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_satis_bekleyen_onaysiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.firmakodu = lKodu
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eşittir"
            frm.islemstatus = True
            frm.kullanici = kullanici
            frm.ShowDialog()
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub musteri_notlari()
        Dim frm As New frm_musteri_karti_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = nMusteriID
        frm.kullanici = kullanici
        frm.firma = False
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_musteri_KarlilikAkisTablosu(Optional ByVal islem As Integer = 0)
        If nMusteriID > 0 Then
            Dim frm As New frm_stok_satis_karlilik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = dteSistemTarihi
            frm.txt_ara.Text = ""
            frm.txt_ara_stok.Text = ""
            frm.sec_MaliyetTipi.Text = "Stok Kartından"
            frm.kriter_musteriID = "AND tbMusteri.nMusteriID = " & nMusteriID & " "
            If islem = 3 Then
                frm.kriter_fistipi = "'DC'"
                frm.islem = 2
            Else
                frm.islem = islem
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm = Nothing
        End If
    End Sub
    Private Sub stok_odeme_detay_tumu()
        If nMusteriID >= 0 Then
            Dim frm As New frm_stok_cari_odeme
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.musterikodu = lKodu
            frm.tarih = Today
            frm.belgeno = 1
            frm.tumu = True
            'frm.stokno = dr("ALISVERISNO")
            'frm.fistipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Function GetBooleanSafe(dr As DataRow, columnName As String) As Boolean
        If dr.Table.Columns.Contains(columnName) AndAlso Not IsDBNull(dr(columnName)) Then
            Return Convert.ToBoolean(dr(columnName))
        End If
        Return False
    End Function
    Private Function ParametreVarMi(pr As DataRow, kolonAdi As String) As Boolean
        Return pr.Table.Columns.Contains(kolonAdi) AndAlso Not IsDBNull(pr(kolonAdi)) AndAlso Convert.ToBoolean(pr(kolonAdi)) = True
    End Function
    Private Function ZorunluAlanKontrolu() As Boolean
        Dim dsParam As DataSet = sorgu("SELECT TOP 1 * FROM tbParamMusteri")
        If dsParam Is Nothing OrElse dsParam.Tables.Count = 0 OrElse dsParam.Tables(0).Rows.Count = 0 Then
            MsgBox("Müşteri parametreleri bulunamadı!", MsgBoxStyle.Critical)
            Return False
        End If

        Dim pr As DataRow = dsParam.Tables(0).Rows(0)
        Dim dr_MusteriParam As DataRow = ds_tbMusteri.Tables(0).Rows(0)
        Dim drNufus As DataRow = ds_tbMusteriNufusu.Tables(0).Rows(0)

        If ParametreVarMi(pr, "bAdiZorunlumu") AndAlso Trim(dr_MusteriParam("sAdi") & "") = "" Then MsgBox("Adı zorunludur.") : Return False
        If ParametreVarMi(pr, "bSoyadiZorunlumu") AndAlso Trim(dr_MusteriParam("sSoyadi") & "") = "" Then MsgBox("Soyadı zorunludur.") : Return False
        If ParametreVarMi(pr, "bCinsiyetZorunlumu") AndAlso IsDBNull(dr_MusteriParam("nCinsiyet")) Then MsgBox("Cinsiyet zorunludur.") : Return False
        If ParametreVarMi(pr, "bDogumTarihiZorunlumu") AndAlso IsDBNull(dr_MusteriParam("dteDogumTarihi")) Then MsgBox("Doğum tarihi zorunludur.") : Return False
        If ParametreVarMi(pr, "bDogumYeriZorunlumu") AndAlso Trim(dr_MusteriParam("sDogumYeri") & "") = "" Then MsgBox("Doğum yeri zorunludur.") : Return False
        If ParametreVarMi(pr, "bEvlimiZorunlumu") AndAlso IsDBNull(dr_MusteriParam("bEvlimi")) Then MsgBox("Evli mi bilgisi zorunludur.") : Return False
        If ParametreVarMi(pr, "bEvlilikTarihiZorunlumu") AndAlso IsDBNull(dr_MusteriParam("dteEvlilikTarihi")) Then MsgBox("Evlilik tarihi zorunludur.") : Return False
        If ParametreVarMi(pr, "bVergiDairesiZorunlumu") AndAlso Trim(dr_MusteriParam("sVergiDairesi") & "") = "" Then MsgBox("Vergi dairesi zorunludur.") : Return False
        If ParametreVarMi(pr, "bVergiNoZorunlumu") AndAlso Trim(dr_MusteriParam("sVergiNo") & "") = "" Then MsgBox("Vergi no zorunludur.") : Return False
        If ParametreVarMi(pr, "bEmailZorunlumu") AndAlso Trim(dr_MusteriParam("sEmail") & "") = "" Then MsgBox("E-mail zorunludur.") : Return False
        If ParametreVarMi(pr, "bEvAdres1Zorunlumu") AndAlso Trim(dr_MusteriParam("sEvAdresi1") & "") = "" Then MsgBox("Ev adresi 1 zorunludur.") : Return False
        If ParametreVarMi(pr, "bEvSemtZorunlumu") AndAlso Trim(dr_MusteriParam("sEvSemt") & "") = "" Then MsgBox("Ev semt zorunludur.") : Return False
        If ParametreVarMi(pr, "bEvIlZorunlumu") AndAlso Trim(dr_MusteriParam("sEvIl") & "") = "" Then MsgBox("Ev il zorunludur.") : Return False
        If ParametreVarMi(pr, "bEvTelefonZorunlumu") AndAlso Trim(dr_MusteriParam("sEvTelefonu") & "") = "" Then MsgBox("Ev telefonu zorunludur.") : Return False
        If ParametreVarMi(pr, "bIsAdresi1Zorunlumu") AndAlso Trim(dr_MusteriParam("sIsAdresi1") & "") = "" Then MsgBox("İş adresi 1 zorunludur.") : Return False
        If ParametreVarMi(pr, "bIsTelefonZorunlumu") AndAlso Trim(dr_MusteriParam("sIsTelefonu") & "") = "" Then MsgBox("İş telefonu zorunludur.") : Return False
        If ParametreVarMi(pr, "bGSMZorunlumu") AndAlso Trim(dr_MusteriParam("sGSM") & "") = "" Then MsgBox("GSM zorunludur.") : Return False
        If ParametreVarMi(pr, "bSigortaNoZorunlumu") AndAlso Trim(dr_MusteriParam("sSigortaNo") & "") = "" Then MsgBox("Sigorta No zorunludur.") : Return False
        If ParametreVarMi(pr, "bUnvanZorunlumu") AndAlso Trim(dr_MusteriParam("sUnvan") & "") = "" Then MsgBox("Unvan zorunludur.") : Return False
        If ParametreVarMi(pr, "bHitapZorunlumu") AndAlso Trim(dr_MusteriParam("sHitap") & "") = "" Then MsgBox("Hitap zorunludur.") : Return False
        If ParametreVarMi(pr, "bTCZorunlumu") AndAlso Trim(drNufus("sCuzdanKayitNo") & "") = "" Then MsgBox("TC Kimlik No zorunludur.") : Return False

        Return True
    End Function
    Private Sub kaydet_tumu()
        Dim frm As New frm_musteri_liste
        Dim dr As DataRow
        Dim dr_Musteri As DataRow = ds_tbMusteri.Tables(0).Rows(0)
        dr_Musteri.BeginEdit()
        If dr_Musteri("bEvlimi") = False Then
            dr_Musteri("dteEvlilikTarihi") = "01/01/1900"
        End If
        dr_Musteri.EndEdit()

        tbMusteri_kaydet_duzelt(nMusteriID, dr_Musteri("sMagaza"), dr_Musteri("lKodu"), dr_Musteri("sAdi"), dr_Musteri("sSoyadi"), dr_Musteri("nCinsiyet"), dr_Musteri("lAylikGelir"), dr_Musteri("dteKartAcilisTarihi"), dr_Musteri("nIskontoPesin"), dr_Musteri("nIskontoKredili"), dr_Musteri("sUnvan"), dr_Musteri("sVergiDairesi"), dr_Musteri("sVergiNo"), dr_Musteri("bYazismaEvAdresinemi"), dr_Musteri("bMusteriAktif"), dr_Musteri("sEmail"), dr_Musteri("sIsYeriAdi"), dr_Musteri("sIsAdresi1"), dr_Musteri("sIsAdresi2"), dr_Musteri("sIsSemt"), dr_Musteri("sIsIl"), dr_Musteri("sIsPostaKodu"), dr_Musteri("sIsTelefonu"), dr_Musteri("sEvAdresi1"), dr_Musteri("sEvAdresi2"), dr_Musteri("sEvSemt"), dr_Musteri("sEvPostaKodu"), dr_Musteri("sEvIl"), dr_Musteri("sEvTelefonu"), dr_Musteri("sSigortaNo"), dr_Musteri("bEvlimi"), dr_Musteri("dteEvlilikTarihi"), dr_Musteri("dteDogumTarihi"), dr_Musteri("sDogumYeri"), dr_Musteri("sEhliyetNo"), dr_Musteri("sKanGrubu"), dr_Musteri("sHitap"), dr_Musteri("sKullaniciAdi"), dr_Musteri("dteKayitTarihi"), dr_Musteri("sAciklama1"), dr_Musteri("sAciklama2"), dr_Musteri("sAciklama3"), dr_Musteri("sAciklama4"), dr_Musteri("sAciklama5"), dr_Musteri("sGSM"), dr_Musteri("sFax"), dr_Musteri("sResimAdi"))

        dr = ds_tbMusteriKredisi.Tables(0).Rows(0)
                tbMusteriKredisi_kaydet_duzelt(nMusteriID, dr("lKrediLimiti"), dr("dteKrediLimitiTarihi"), dr("dteKrediAcilisTarihi"), dr("dteSonKullanmaTarihi"), dr("bOzelMusterimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))

        dr = ds_tbMusteriKefil1.Tables(0).Rows(0)
        tbMusteriKefil_kaydet_duzelt("tbMusteriKefil1", nMusteriID, dr("sAdi"), dr("sSoyadi"), dr("sUnvan"), dr("sEmail"), dr("sIsYeriAdi"), dr("sIsAdresi1"), dr("sIsAdresi2"), dr("sIsSemt"), dr("sIsPostaKodu"), dr("sIsIl"), dr("sIsTelefonu"), dr("sEvAdresi1"), dr("sEvAdresi2"), dr("sEvSemt"), dr("sEvPostaKodu"), dr("sEvIl"), dr("sEvTelefonu"), dr("lAylikGelir"), dr("sSigortaNo"), dr("sHitap"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))

        dr = ds_tbMusteriKefil2.Tables(0).Rows(0)
        tbMusteriKefil_kaydet_duzelt("tbMusteriKefil2", nMusteriID, dr("sAdi"), dr("sSoyadi"), dr("sUnvan"), dr("sEmail"), dr("sIsYeriAdi"), dr("sIsAdresi1"), dr("sIsAdresi2"), dr("sIsSemt"), dr("sIsPostaKodu"), dr("sIsIl"), dr("sIsTelefonu"), dr("sEvAdresi1"), dr("sEvAdresi2"), dr("sEvSemt"), dr("sEvPostaKodu"), dr("sEvIl"), dr("sEvTelefonu"), dr("lAylikGelir"), dr("sSigortaNo"), dr("sHitap"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))

        dr = ds_tbMusteriKefil3.Tables(0).Rows(0)
        tbMusteriKefil_kaydet_duzelt("tbMusteriKefil3", nMusteriID, dr("sAdi"), dr("sSoyadi"), dr("sUnvan"), dr("sEmail"), dr("sIsYeriAdi"), dr("sIsAdresi1"), dr("sIsAdresi2"), dr("sIsSemt"), dr("sIsPostaKodu"), dr("sIsIl"), dr("sIsTelefonu"), dr("sEvAdresi1"), dr("sEvAdresi2"), dr("sEvSemt"), dr("sEvPostaKodu"), dr("sEvIl"), dr("sEvTelefonu"), dr("lAylikGelir"), dr("sSigortaNo"), dr("sHitap"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))

        dr = ds_tbMusteriKefil4.Tables(0).Rows(0)
        tbMusteriKefil_kaydet_duzelt("tbMusteriKefil4", nMusteriID, dr("sAdi"), dr("sSoyadi"), dr("sUnvan"), dr("sEmail"), dr("sIsYeriAdi"), dr("sIsAdresi1"), dr("sIsAdresi2"), dr("sIsSemt"), dr("sIsPostaKodu"), dr("sIsIl"), dr("sIsTelefonu"), dr("sEvAdresi1"), dr("sEvAdresi2"), dr("sEvSemt"), dr("sEvPostaKodu"), dr("sEvIl"), dr("sEvTelefonu"), dr("lAylikGelir"), dr("sSigortaNo"), dr("sHitap"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))

        dr = ds_tbMusteriNufusu.Tables(0).Rows(0)
        tbMusteriNufusu_kaydet_duzelt(nMusteriID, dr("sDin"), dr("sKutukIl"), dr("sKutukIlce"), dr("sKutukMahalle"), dr("sKutukCiltNo"), dr("sKutukSiraNo"), dr("dteNufusCuzdanTarihi"), dr("sCuzdanVerilenYer"), dr("sCuzdanVerNedeni"), dr("sCuzdanKayitNo"), dr("sAnneAdi"), dr("sBabaAdi"), dr("sAileAdresi1"), dr("sAileAdresi2"), dr("sAileSemt"), dr("sAilePostaKodu"), dr("sAileIl"), dr("sAileTelefonu"), dr("sHitapAnne"), dr("sHitapBaba"), cevirDBNULL(dr("sSeriNo").ToString()), cevirDBNULL(dr("sSeri").ToString()))

        Me.Close()
    End Sub

    Private Function cevirDBNULL(ByVal a) As String
        If IsDBNull(a) = True Then
            a = ""
        End If
        Return a
    End Function
    Private Function tbMusteri_kaydet_yeni(ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal bMusteriAktif As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteri (sMagaza, lKodu, sAdi, sSoyadi, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, bMusteriAktif, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsIl, sIsPostaKodu, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, sHitap, sKullaniciAdi, dteKayitTarihi, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sGSM, sFax, sResimAdi) VALUES     ('" & sMagaza & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", " & lAylikGelir & ", '" & dteKartAcilisTarihi & "', " & nIskontoPesin & ", " & nIskontoKredili & ", '" & sUnvan & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bYazismaEvAdresinemi & ", " & bMusteriAktif & ", '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsIl & "', '" & sIsPostaKodu & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sSigortaNo & "', " & bEvlimi & ", '" & dteEvlilikTarihi & "', '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sEhliyetNo & "', '" & sKanGrubu & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sGSM & "', '" & sFax & "', '" & sResimAdi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbMusteri_kaydet_duzelt(ByVal nMusteriID As String, ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal bMusteriAktif As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteri SET              sMagaza = '" & sMagaza & "', lKodu = '" & lKodu & "', sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', nCinsiyet = " & nCinsiyet & ", lAylikGelir = " & lAylikGelir & ", dteKartAcilisTarihi = '" & dteKartAcilisTarihi & "', nIskontoPesin = " & nIskontoPesin & ", nIskontoKredili = " & nIskontoKredili & ", sUnvan = '" & sUnvan & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', bYazismaEvAdresinemi = " & bYazismaEvAdresinemi & ", bMusteriAktif = " & bMusteriAktif & ", sEmail = '" & sEmail & "', sIsYeriAdi = '" & sIsYeriAdi & "', sIsAdresi1 = '" & sIsAdresi1 & "', sIsAdresi2 = '" & sIsAdresi2 & "', sIsSemt = '" & sIsSemt & "', sIsIl = '" & sIsIl & "', sIsPostaKodu = '" & sIsPostaKodu & "', sIsTelefonu = '" & sIsTelefonu & "', sEvAdresi1 = '" & sEvAdresi1 & "', sEvAdresi2 = '" & sEvAdresi2 & "', sEvSemt = '" & sEvSemt & "', sEvPostaKodu = '" & sEvPostaKodu & "', sEvIl = '" & sEvIl & "', sEvTelefonu = '" & sEvTelefonu & "', sSigortaNo = '" & sSigortaNo & "', bEvlimi = " & bEvlimi & ", dteEvlilikTarihi = '" & dteEvlilikTarihi & "', dteDogumTarihi = '" & dteDogumTarihi & "', sDogumYeri = '" & sDogumYeri & "', sEhliyetNo = '" & sEhliyetNo & "', sKanGrubu = '" & sKanGrubu & "', sHitap = '" & sHitap & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sGSM = '" & sGSM & "', sFax = '" & sFax & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriSinifi_kaydet_yeni(ByVal nMusteriID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriSinifi (nMusteriID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nMusteriID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriSinifi_kaydet_duzelt(ByVal nMusteriID As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriSinifi SET              sSinifKodu" & sSinifNo & " = '" & sSinifKodu & "' where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKefil_kaydet_yeni(ByVal Tablo As String, ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sUnvan As String, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsPostaKodu As String, ByVal sIsIl As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal lAylikGelir As Decimal, ByVal sSigortaNo As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO " & Tablo & " (nMusteriID, sAdi, sSoyadi, sUnvan, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsPostaKodu, sIsIl, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, lAylikGelir, sSigortaNo, sHitap, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "', '" & sAdi & "', '" & sSoyadi & "', '" & sUnvan & "', '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsPostaKodu & "', '" & sIsIl & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', " & lAylikGelir & ", '" & sSigortaNo & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKefil_kaydet_duzelt(ByVal Tablo As String, ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sUnvan As String, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsPostaKodu As String, ByVal sIsIl As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal lAylikGelir As Decimal, ByVal sSigortaNo As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    " & Tablo & " SET              sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', sUnvan = '" & sUnvan & "', sEmail = '" & sEmail & "', sIsYeriAdi = '" & sIsYeriAdi & "', sIsAdresi1 = '" & sIsAdresi1 & "', sIsAdresi2 = '" & sIsAdresi2 & "', sIsSemt = '" & sIsSemt & "', sIsPostaKodu = '" & sIsPostaKodu & "', sIsIl = '" & sIsIl & "', sIsTelefonu = '" & sIsTelefonu & "', sEvAdresi1 = '" & sEvAdresi1 & "', sEvAdresi2 = '" & sEvAdresi2 & "', sEvSemt = '" & sEvSemt & "', sEvPostaKodu = '" & sEvPostaKodu & "', sEvIl = '" & sEvIl & "', sEvTelefonu = '" & sEvTelefonu & "', lAylikGelir = " & lAylikGelir & ", sSigortaNo = '" & sSigortaNo & "', sHitap = '" & sHitap & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriNufusu_kaydet_yeni(ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String, ByVal sSeriNo As String, ByVal sSeri As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriNufusu (nMusteriID, sDin, sKutukIl, sKutukIlce, sKutukMahalle, sKutukCiltNo, sKutukSiraNo, dteNufusCuzdanTarihi, sCuzdanVerilenYer, sCuzdanVerNedeni, sCuzdanKayitNo, sAnneAdi, sBabaAdi, sAileAdresi1, sAileAdresi2, sAileSemt, sAilePostaKodu, sAileIl, sAileTelefonu, sHitapAnne, sHitapBaba, sSeriNo, sSeri) VALUES ('" & nMusteriID & "', '" & sDin & "', '" & sKutukIl & "', '" & sKutukIlce & "', '" & sKutukMahalle & "', '" & sKutukCiltNo & "', '" & sKutukSiraNo & "', '" & dteNufusCuzdanTarihi & "','" & sCuzdanVerilenYer & "', '" & sCuzdanVerNedeni & "', '" & sCuzdanKayitNo & "', '" & sAnneAdi & "', '" & sBabaAdi & "', '" & sAileAdresi1 & "', '" & sAileAdresi2 & "', '" & sAileSemt & "', '" & sAilePostaKodu & "', '" & sAileIl & "', '" & sAileTelefonu & "', '" & sHitapAnne & "', '" & sHitapBaba & "', '" & sSeriNo & "', '" & sSeri & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriNufusu_kaydet_duzelt(ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String, ByVal sSeriNo As String, ByVal sSeri As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriNufusu SET sDin = '" & sDin & "', sKutukIl = '" & sKutukIl & "', sKutukIlce = '" & sKutukIlce & "', sKutukMahalle = '" & sKutukMahalle & "', sKutukCiltNo = '" & sKutukCiltNo & "', sKutukSiraNo = '" & sKutukSiraNo & "', dteNufusCuzdanTarihi = '" & dteNufusCuzdanTarihi & "', sCuzdanVerilenYer = '" & sCuzdanVerilenYer & "', sCuzdanVerNedeni = '" & sCuzdanVerNedeni & "', sCuzdanKayitNo = '" & sCuzdanKayitNo & "', sAnneAdi = '" & sAnneAdi & "', sBabaAdi = '" & sBabaAdi & "', sAileAdresi1 = '" & sAileAdresi1 & "', sAileAdresi2 = '" & sAileAdresi2 & "', sAileSemt = '" & sAileSemt & "', sAilePostaKodu = '" & sAilePostaKodu & "', sAileIl = '" & sAileIl & "', sAileTelefonu = '" & sAileTelefonu & "', sHitapAnne = '" & sHitapAnne & "', sHitapBaba = '" & sHitapBaba & "', sSeriNo = '" & sSeriNo & "', sSeri = '" & sSeri & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKredisi_kaydet_yeni(ByVal nMusteriID As String, ByVal lKrediLimiti As String, ByVal dteKrediLimitiTarihi As DateTime, ByVal dteKrediAcilisTarihi As DateTime, ByVal dteSonKullanmaTarihi As DateTime, ByVal bOzelMusterimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        If lKrediLimiti = 0 Then
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            cmd.Connection = con
            con.ConnectionString = connection
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriKredisi (nMusteriID, lKrediLimiti, dteKrediLimitiTarihi, dteKrediAcilisTarihi, dteSonKullanmaTarihi, bOzelMusterimi, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "', " & lKrediLimiti & ", '" & dteKrediLimitiTarihi & "', '" & dteKrediAcilisTarihi & "', '" & dteSonKullanmaTarihi & "', " & bOzelMusterimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub
    Private Sub tbMusteriKredisi_kaydet_duzelt(ByVal nMusteriID As String, ByVal lKrediLimiti As String, ByVal dteKrediLimitiTarihi As DateTime, ByVal dteKrediAcilisTarihi As DateTime, ByVal dteSonKullanmaTarihi As DateTime, ByVal bOzelMusterimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim frm As New frm_musteri_liste
        If yetki_kontrol(kullanici, "frm_musteri_karti_limiti") = True Then

            Dim cmd As New OleDb.OleDbCommand
                Dim con As New OleDb.OleDbConnection
                cmd.Connection = con
                con.ConnectionString = connection
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriKredisi SET              lKrediLimiti = " & lKrediLimiti & ", dteKrediLimitiTarihi = '" & dteKrediLimitiTarihi & "', dteKrediAcilisTarihi = '" & dteKrediAcilisTarihi & "', dteSonKullanmaTarihi = '" & dteSonKullanmaTarihi & "', bOzelMusterimi = " & bOzelMusterimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "' Where nMusteriID = '" & nMusteriID & "' ")
                cmd.ExecuteNonQuery()
                con.Close()

        End If
    End Sub
    Private Sub tbMusteriKarti_kaydet_yeni(ByVal nMusteriID As String, ByVal nKartNo As String, ByVal sAciklama As String, ByVal dteSonKullanmaTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriKarti (nMusteriID, nKartNo, sAciklama, dteSonKullanmaTarihi, sKullaniciAdi, dteKayitTarihi, sozlesmeNoDuzenleme) VALUES('" & nMusteriID & "',  SUBSTRING(CAST(NEWID() AS NVARCHAR(36)), 0, 9), N'" & sAciklama & "', '" & dteSonKullanmaTarihi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', 0)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKarti_kaydet_duzelt(ByVal nMusteriID As String, ByVal nKartNo As String, ByVal sAciklama As String, ByVal dteSonKullanmaTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sKartID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriKarti SET nKartNo = '" & nKartNo & "', sAciklama = N'" & sAciklama & "', dteSonKullanmaTarihi = '" & dteSonKullanmaTarihi & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriKarti SET nKartNo = '" & nKartNo & "', sAciklama = N'" & sAciklama & "', sozlesmeNoDuzenleme = 1 Where (nMusteriID = '" & nMusteriID & "') and (sKartID = '" & sKartID & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKarti_kaydet_sil(ByVal nMusteriID As String, ByVal nKartNo As String, ByVal sAciklama As String, ByVal dteSonKullanmaTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbMusteriKarti  Where nMusteriID = '" & nMusteriID & "' and dteKayitTarihi = '" & dteKayitTarihi & "' and nKartNo = '" & nKartNo & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriEkKart_kaydet_sil(ByVal nEkKartID As String, ByVal nMusteriID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete From tbMusteriEkKart Where nMusteriID = '" & nMusteriID & "' and nEkKartID = '" & nEkKartID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriOzelNot_kaydet_yeni(ByVal nMusteriID As String, ByVal dteGirisTarihi As DateTime, ByVal sText As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriOzelNot (nMusteriID, dteGirisTarihi, sText, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "', '" & dteGirisTarihi & "', '" & sText & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriOzelNot_kaydet_duzelt(ByVal nMusteriID As String, ByVal dteGirisTarihi As DateTime, ByVal sText As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriOzelNot SET              sText = '" & sText & "' Where nMusteriID = '" & nMusteriID & "' and dteKayitTarihi = '" & dteKayitTarihi & "' and dteGirisTarihi ='" & dteGirisTarihi & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriOzelNot_kaydet_sil(ByVal nMusteriID As String, ByVal dteGirisTarihi As DateTime, ByVal sText As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete From    tbMusteriOzelNot Where nMusteriID = '" & nMusteriID & "' and dteKayitTarihi = '" & dteKayitTarihi & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriRefeerans_kaydet_yeni(ByVal nMusteriID As String, ByVal nRefID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from  tbMusteriReferans Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriReferans (nMusteriID, nRefID) VALUES     ('" & nMusteriID & "', '" & nRefID & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriRefeerans_kaydet_duzelt(ByVal nMusteriID As String, ByVal nRefID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE  tbMusteriCocugu Set nRefID = '" & nRefID & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriReferans_kaydet_Sil(ByVal nMusteriID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete From    tbMusteriReferans  Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriCocugu_kaydet_yeni(ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sOzelNot As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriCocugu (nMusteriID, sAdi, sSoyadi, nCinsiyet, dteDogumTarihi, sDogumYeri, sOzelNot) VALUES     ('" & nMusteriID & "', SUBSTRING(CAST(NEWID() AS NVARCHAR(36)), 0, 9), SUBSTRING(CAST(NEWID() AS NVARCHAR(36)), 0, 9), " & nCinsiyet & ", '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sOzelNot & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriCocugu_kaydet_duzelt(ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sOzelNot As String, ByVal sCocukAdi As String, ByVal sCocukSoyadi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriCocugu SET              sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', nCinsiyet = '" & nCinsiyet & "', dteDogumTarihi = '" & dteDogumTarihi & "', sDogumYeri = '" & sDogumYeri & "', sOzelNot = '" & sOzelNot & "' Where nMusteriID = '" & nMusteriID & "' and sAdi = '" & sCocukAdi & "' and sSoyadi = '" & sCocukSoyadi & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriCocugu_kaydet_Sil(ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sOzelNot As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete From    tbMusteriCocugu  Where nMusteriID = '" & nMusteriID & "' and sAdi = '" & sAdi & "' and sSoyadi = '" & sSoyadi & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriResim_kaydet_duzelt(ByVal nMusteriResimID As Int64, ByVal nMusteriID As String, ByVal sAciklama As String, ByVal nSira As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriResim SET              sAciklama = N'" & sAciklama & "',nSira = " & nSira & " Where nMusteriID = '" & nMusteriID & "' and nMusteriResimID = '" & nMusteriResimID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriResim_kaydet_Sil(ByVal nMusteriID As String, ByVal nMusteriResimID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete From    tbMusteriResim  Where nMusteriID = '" & nMusteriID & "' and nMusteriResimID = " & nMusteriResimID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriCocugu_satir_info()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            sCocukAdi = dr("sAdi")
            sCocukSoyadi = dr("sSoyadi")
            dr = Nothing
        End If
    End Sub
    Private Sub tbMusteriCocugu_Satir_sil()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            If XtraMessageBox.Show(dr("sAdi") & vbTab & dr("sSoyadi") & Sorgu_sDil(" İsimli Çocuk Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbMusteriCocugu_kaydet_Sil(nMusteriID, dr("sAdi"), dr("sSoyadi"), dr("nCinsiyet"), dr("dteDogumTarihi"), dr("sDogumYeri"), dr("sOzelNot"))
            End If
            ds_tbMusteriCocugu = Dataload_tbMusteriCocugu(nMusteriID)
            GridControl3.DataSource = ds_tbMusteriCocugu.Tables(0)
            GridControl3.DataMember = Nothing
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbMusteriOzelNot_Satir_sil()
        If GridView4.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView4.GetDataRow(GridView4.FocusedRowHandle)
            satir = GridView4.FocusedRowHandle
            If XtraMessageBox.Show(dr("dteKayitTarihi") & vbTab & Sorgu_sDil(" Tarihli Notu Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbMusteriOzelNot_kaydet_sil(nMusteriID, dr("dteGirisTarihi"), dr("sText"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            End If
            ds_tbMusteriOzelNot = Dataload_tbMusteriOzelNot(nMusteriID)
            GridControl5.DataSource = ds_tbMusteriOzelNot.Tables(0)
            GridControl5.DataMember = Nothing
            GridView4.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbMusteriResim_Satir_sil()
        If GridView6.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            satir = GridView6.FocusedRowHandle
            If XtraMessageBox.Show(dr("dteKayitTarihi") & vbTab & Sorgu_sDil(" Tarihli Resmi Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbMusteriResim_kaydet_Sil(nMusteriID, dr("nMusteriResimID"))
            End If
            ds_tbMusteriResim = Dataload_tbMusteriResim(nMusteriID)
            GridControl6.DataSource = ds_tbMusteriResim.Tables(0)
            GridControl6.DataMember = Nothing
            GridView6.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbMuseriKarti_Satir_sil()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            If XtraMessageBox.Show(dr("nKartNo") & vbTab & Sorgu_sDil("Nolu Kart Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbMusteriKarti_kaydet_sil(nMusteriID, dr("nKartNo"), dr("sAciklama"), dr("dteSonKullanmaTarihi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            End If
            ds_tbMusteriKarti = Dataload_tbMusteriKarti(nMusteriID)
            GridControl1.DataSource = ds_tbMusteriKarti.Tables(0)
            GridControl1.DataMember = Nothing
            GridView1.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbMusteriEkKart_ekle()
        Dim frm As New frm_musteri_ekkart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.nMusteriID = nMusteriID
        frm.lKodu = lKodu
        frm.txt_musteriNo.Text = lKodu
        frm.nEkKartID = ""
        frm.connection = connection
        frm.ShowDialog()
        ds_tbMusteriEkKart = Dataload_tbMusteriEkKart(nMusteriID)
        GridControl4.DataSource = ds_tbMusteriEkKart.Tables(0)
        GridControl4.DataMember = Nothing
        GridView5.FocusedRowHandle = GridView5.RowCount - 1
    End Sub
    Private Sub tbMusteriEkKart_duzelt()
        If GridView5.RowCount > 0 Then
            Dim dr As DataRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            Dim satir = GridView5.FocusedRowHandle
            Dim frm As New frm_musteri_ekkart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.nMusteriID = nMusteriID
            frm.lKodu = lKodu
            frm.txt_musteriNo.Text = lKodu
            frm.nEkKartID = dr("nEkKartID")
            frm.connection = connection
            frm.ShowDialog()
            ds_tbMusteriEkKart = Dataload_tbMusteriEkKart(nMusteriID)
            GridControl4.DataSource = ds_tbMusteriEkKart.Tables(0)
            GridControl4.DataMember = Nothing
            GridView5.FocusedRowHandle = satir
            dr = Nothing
        End If
    End Sub
    Private Sub tbMuseriEkKart_Satir_sil()
        If GridView5.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            satir = GridView5.FocusedRowHandle
            If XtraMessageBox.Show(dr("sAdi") & vbTab & dr("sSoyadi") & vbTab & Sorgu_sDil("İsimli EkKart Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbMusteriEkKart_kaydet_sil(dr("nEkKartID"), nMusteriID)
            End If
            ds_tbMusteriEkKart = Dataload_tbMusteriEkKart(nMusteriID)
            GridControl4.DataSource = ds_tbMusteriEkKart.Tables(0)
            GridControl4.DataMember = Nothing
            GridView5.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbKefilNufusu_duzelt(ByVal Tablo As String)
        Dim frm As New frm_musteri_kefil_nufusu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.nMusteriID = nMusteriID
        frm.lKodu = lKodu
        frm.txt_musteriNo.Text = lKodu
        frm.tablo = Tablo
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_tbMusteriTablo_kontrol(ByVal nMusteriID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nMusteriID = '" & nMusteriID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nMusteriID AS IND, lKodu AS MUSTERIKODU, sAdi + ' ' + sSoyadi AS MUSTERI FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal nMusteriID As Int64)
        'Müşteri  Kontrol
        Dataload_tbMusteri(nMusteriID)
        'Müşteri Sınıflandırma Kontrol
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriSinifi") = 0 Then
            tbMusteriSinifi_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        End If
        Dataload_tbMusteriSinifi(nMusteriID)
        ds_tbMusteriKarti = Dataload_tbMusteriKarti(nMusteriID)
        GridControl1.DataSource = ds_tbMusteriKarti.Tables(0)
        GridControl1.DataMember = Nothing
        'Müşteri Kredisi Kontrol
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriKredisi") = 0 Then
            tbMusteriKredisi_kaydet_yeni(nMusteriID, 0, Today, Today, "31/12/2048", 0, kullanici, Now)
        End If
        Dataload_tbMusteriKredisi(nMusteriID)
        'Müşteri Kefilleri Kontrol
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriKefil1") = 0 Then
            tbMusteriKefil_kaydet_yeni("tbMusteriKefil1", nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, "", "", kullanici, Now)
        End If
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriKefil2") = 0 Then
            tbMusteriKefil_kaydet_yeni("tbMusteriKefil2", nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, "", "", kullanici, Now)
        End If
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriKefil3") = 0 Then
            tbMusteriKefil_kaydet_yeni("tbMusteriKefil3", nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, "", "", kullanici, Now)
        End If
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriKefil4") = 0 Then
            tbMusteriKefil_kaydet_yeni("tbMusteriKefil4", nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, "", "", kullanici, Now)
        End If
        Dataload_tbMusteriKefil1(nMusteriID)
        Dataload_tbMusteriKefil2(nMusteriID)
        Dataload_tbMusteriKefil3(nMusteriID)
        Dataload_tbMusteriKefil4(nMusteriID)
        ds_tbMusteriCocugu = Dataload_tbMusteriCocugu(nMusteriID)
        GridControl3.DataSource = ds_tbMusteriCocugu.Tables(0)
        GridControl3.DataMember = Nothing
        ds_tbMusteriOzelNot = Dataload_tbMusteriOzelNot(nMusteriID)
        GridControl5.DataSource = ds_tbMusteriOzelNot.Tables(0)
        GridControl5.DataMember = Nothing
        'Müşteri Nüfusu Kontrol
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriNufusu") = 0 Then
            tbMusteriNufusu_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "01/01/1900", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        End If
        Dataload_tbMusteriNufusu(nMusteriID)
        ds_tbMusteriEkKart = Dataload_tbMusteriEkKart(nMusteriID)
        GridControl4.DataSource = ds_tbMusteriEkKart.Tables(0)
        GridControl4.DataMember = Nothing
        ds_tbMusteriResim = Dataload_tbMusteriResim(nMusteriID)
        GridControl6.DataSource = ds_tbMusteriResim.Tables(0)
        GridControl6.DataMember = Nothing
        btn_ReferansSec.Text = sorgu_nDeger("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Select nRefID from tbMusteriReferans Where nMusteriID ='" & nMusteriID & "'")
        Try
            lbl_Referans.Text = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Select sAdi + ' ' + sSoyadi from tbMusteri Where nMusteriID ='" & btn_ReferansSec.Text & "'")
        Catch ex As Exception
        End Try
        tbMusteriCocugu_satir_info()
    End Sub
    Public Sub Dataload_tbMusteri(ByVal nMusteriID As String)
        Try
            ds_tbMusteri.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbMusteri WHERE nMusteriID ='" & nMusteriID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteri, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbMusteriKefil1(ByVal nMusteriID As String)
        Try
            ds_tbMusteriKefil1.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteriKefil1 WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteriKefil1, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbMusteriKefil2(ByVal nMusteriID As String)
        Try
            ds_tbMusteriKefil2.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteriKefil2 WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteriKefil2, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbMusteriKefil3(ByVal nMusteriID As String)
        Try
            ds_tbMusteriKefil3.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMusteriKefil3 WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteriKefil3, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbMusteriKefil4(ByVal nMusteriID As String)
        Try
            ds_tbMusteriKefil4.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMusteriKefil4 WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteriKefil4, "Table1")
        conn.Close()
    End Sub
    Private Sub Dataload_tbMusteriSinifi(ByVal nMusteriID As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT 1 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi01 FROM tbParamMusteri) AS sSinifTipi, tbMSinif1.sSinifKodu, tbMSinif1.sAciklama, tbMSinif1.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 2 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi02 FROM tbParamMusteri) AS sSinifTipi, tbMSinif2.sSinifKodu, tbMSinif2.sAciklama, tbMSinif2.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 3 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi03 FROM tbParamMusteri) AS sSinifTipi, tbMSinif3.sSinifKodu, tbMSinif3.sAciklama, tbMSinif3.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 4 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi04 FROM tbParamMusteri) AS sSinifTipi, tbMSinif4.sSinifKodu, tbMSinif4.sAciklama, tbMSinif4.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 5 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi05 FROM tbParamMusteri) AS sSinifTipi, tbMSinif5.sSinifKodu, tbMSinif5.sAciklama, tbMSinif5.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5= tbMSinif5.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 6 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi06 FROM tbParamMusteri) AS sSinifTipi, tbMSinif6.sSinifKodu, tbMSinif6.sAciklama, tbMSinif6.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif6 ON tbMusteriSinifi.sSinifKodu6 = tbMSinif6.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 7 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi07 FROM tbParamMusteri) AS sSinifTipi, tbMSinif7.sSinifKodu, tbMSinif7.sAciklama, tbMSinif7.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif7 ON tbMusteriSinifi.sSinifKodu7 = tbMSinif7.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 8 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi08 FROM tbParamMusteri) AS sSinifTipi, tbMSinif8.sSinifKodu, tbMSinif8.sAciklama, tbMSinif8.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif8 ON tbMusteriSinifi.sSinifKodu8 = tbMSinif8.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 9 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi09 FROM tbParamMusteri) AS sSinifTipi, tbMSinif9.sSinifKodu, tbMSinif9.sAciklama, tbMSinif9.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif9 ON tbMusteriSinifi.sSinifKodu9 = tbMSinif9.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 10 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi10 FROM tbParamMusteri) AS sSinifTipi, tbMSinif10.sSinifKodu, tbMSinif10.sAciklama, tbMSinif10.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif10 ON tbMusteriSinifi.sSinifKodu10 = tbMSinif10.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 11 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi11 FROM tbParamMusteri) AS sSinifTipi, tbMSinif11.sSinifKodu, tbMSinif11.sAciklama, tbMSinif11.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif11 ON tbMusteriSinifi.sSinifKodu11 = tbMSinif11.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 12 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi12 FROM tbParamMusteri) AS sSinifTipi, tbMSinif12.sSinifKodu, tbMSinif12.sAciklama, tbMSinif12.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif12 ON tbMusteriSinifi.sSinifKodu12 = tbMSinif12.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 13 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi13 FROM tbParamMusteri) AS sSinifTipi, tbMSinif13.sSinifKodu, tbMSinif13.sAciklama, tbMSinif13.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif13 ON tbMusteriSinifi.sSinifKodu13 = tbMSinif13.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 14 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi14 FROM tbParamMusteri) AS sSinifTipi, tbMSinif14.sSinifKodu, tbMSinif14.sAciklama, tbMSinif14.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif14 ON tbMusteriSinifi.sSinifKodu14 = tbMSinif14.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT 15 as sSinifNo,tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi15 FROM tbParamMusteri) AS sSinifTipi, tbMSinif15.sSinifKodu, tbMSinif15.sAciklama, tbMSinif15.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif15 ON tbMusteriSinifi.sSinifKodu15 = tbMSinif15.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        ds_tbMusteriSinifi = sorgu(sorgu_query("" & kriter & ""))
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_tbMusteriSinifi.Tables(0)
    End Sub
    Public Function Dataload_tbMusteriKarti(ByVal nMusteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteriKarti WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Sub Dataload_tbMusteriNufusu(ByVal nMusteriID As String)
        Try
            ds_tbMusteriNufusu.Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteriNufusu WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteriNufusu, "Table1")
        conn.Close()
    End Sub
    Public Function Dataload_tbMusteriOzelNot(ByVal nMusteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteriOzelNot WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Sub Dataload_tbMusteriKredisi(ByVal nMusteriID As String)
        Try
            ds_tbMusteriKredisi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM          tbMusteriKredisi WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(ds_tbMusteriKredisi, "Table1")
        conn.Close()
    End Sub
    Public Function Dataload_tbMusteriCocugu(ByVal nMusteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM          tbMusteriCocugu WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbMusteriEkKart(ByVal nMusteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMusteriEkKart WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbMusteriResim(ByVal nMusteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMusteriResim WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_sCuzdanKayitNo_kontrol(ByVal sGSM As String, ByVal nMusteriID As Integer) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sCuzdanKayitNo), 0) AS nKayit FROM tbMusteriNufusu WHERE (sCuzdanKayitNo = '" & sGSM & "') and nMusteriID <> " & nMusteriID & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        End If
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        musteri_sec()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Not ZorunluAlanKontrolu() Then
            MsgBox("Zorunlu alanlar doldurulmadan çıkış yapılamaz!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Not ZorunluAlanKontrolu() Then
            MsgBox("Zorunlu alanlar doldurulmadan kayıt yapılamaz!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        kaydet_tumu()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        musteri_notlari()
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dataload_tbMSinif(dr("sSinifNo"))
            dr = Nothing
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            Dim satir = GridView2.FocusedRowHandle
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            GridView2.PostEditor()
            dr.EndEdit()
            tbMusteriSinifi_kaydet_duzelt(nMusteriID, dr("sSinifKodu"), dr("sSinifNo"))
            Dataload_tbMusteriSinifi(nMusteriID)
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            txt_sMagaza.Focus()
            txt_sMagaza.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            txt_sGSM.Focus()
            txt_sGSM.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            txt_sHitap2.Focus()
            txt_sHitap2.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            txt_sHitap4.Focus()
            txt_sHitap4.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 4 Then
            txt_sHitap5.Focus()
            txt_sHitap5.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 5 Then
            GridControl2.Focus()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 6 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 7 Then
            txt_llimit.Focus()
            txt_llimit.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 8 Then
            GridControl4.Focus()
            GridControl4.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 9 Then
            GridControl3.Focus()
            GridControl3.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 10 Then
            GridControl5.Focus()
            GridControl5.Select()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        tbMusteriKarti_kaydet_yeni(nMusteriID, "", "", "31/12/2048", kullanici, Now)
        ds_tbMusteriKarti = Dataload_tbMusteriKarti(nMusteriID)
        GridControl1.DataSource = ds_tbMusteriKarti.Tables(0)
        GridControl1.DataMember = Nothing
        GridView1.FocusedRowHandle = GridView1.RowCount - 1
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If (Integer.Parse(MusteriSozlesmeNoDuzenle(nMusteriID, dr("sKartID"))) > 0) Then
                If Trim(dr("nKartNo")) <> "" Then
                    If yetki_kontrol(kullanici, "frm_musteri_karti_sozlesmeNo_duzenleme") = True Then
                        GridView1.PostEditor()
                        dr.EndEdit()
                        Try
                            tbMusteriKarti_kaydet_duzelt(nMusteriID, dr("nKartNo"), dr("sAciklama"), dr("dteSonKullanmaTarihi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sKartID"))
                        Catch ex As Exception
                            XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Try
                        ds_tbMusteriKarti = Dataload_tbMusteriKarti(nMusteriID)
                        GridView1.FocusedRowHandle = satir
                        dr = Nothing
                        satir = Nothing
                    End If
                Else
                    GridView1.PostEditor()
                    dr.EndEdit()
                    Try
                        tbMusteriKarti_kaydet_duzelt(nMusteriID, dr("nKartNo"), dr("sAciklama"), dr("dteSonKullanmaTarihi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sKartID"))
                    Catch ex As Exception
                        XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                    ds_tbMusteriKarti = Dataload_tbMusteriKarti(nMusteriID)
                    GridView1.FocusedRowHandle = satir
                    dr = Nothing
                    satir = Nothing
                End If
            Else
                GridView1.PostEditor()
                dr.EndEdit()
                Try
                    tbMusteriKarti_kaydet_duzelt(nMusteriID, dr("nKartNo"), dr("sAciklama"), dr("dteSonKullanmaTarihi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sKartID"))
                Catch ex As Exception
                    XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
                ds_tbMusteriKarti = Dataload_tbMusteriKarti(nMusteriID)
                GridView1.FocusedRowHandle = satir
                dr = Nothing
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If yetki_kontrol(kullanici, "frm_musteri_karti_sozlesmeNo_duzenleme") = True Then
            tbMuseriKarti_Satir_sil()
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        tbMusteriEkKart_ekle()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        tbMuseriEkKart_Satir_sil()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        tbMusteriEkKart_duzelt()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        tbMusteriCocugu_kaydet_yeni(nMusteriID, "", "", 3, Today, "", "")
        ds_tbMusteriCocugu = Dataload_tbMusteriCocugu(nMusteriID)
        GridControl3.DataSource = ds_tbMusteriCocugu.Tables(0)
        GridControl3.DataMember = Nothing
        GridView3.FocusedRowHandle = 0
        tbMusteriCocugu_satir_info()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        tbMusteriCocugu_Satir_sil()
    End Sub
    Private Sub GridView3_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        tbMusteriCocugu_satir_info()
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            Try
                tbMusteriCocugu_kaydet_duzelt(nMusteriID, dr("sAdi"), dr("sSoyadi"), dr("nCinsiyet"), dr("dteDogumTarihi"), dr("sDogumYeri"), dr("sOzelNot"), sCocukAdi, sCocukSoyadi)
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            tbMusteriCocugu_satir_info()
            ds_tbMusteriCocugu = Dataload_tbMusteriCocugu(nMusteriID)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Try
            tbMusteriOzelNot_kaydet_yeni(nMusteriID, dteSistemTarihi, "", kullanici, Now)
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Kayıt İçerde Var...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        ds_tbMusteriOzelNot = Dataload_tbMusteriOzelNot(nMusteriID)
        GridControl5.DataSource = ds_tbMusteriOzelNot.Tables(0)
        GridControl5.DataMember = Nothing
        colsText.OptionsColumn.ReadOnly = False
        GridView4.FocusedRowHandle = GridView4.RowCount - 1
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        tbMusteriOzelNot_Satir_sil()
    End Sub
    Private Sub GridView4_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView4.CellValueChanged
        If GridView4.RowCount > 0 Then
            Dim satir = GridView4.FocusedRowHandle
            Dim dr As DataRow = GridView4.GetDataRow(GridView4.FocusedRowHandle)
            GridView4.PostEditor()
            dr.EndEdit()
            Try
                tbMusteriOzelNot_kaydet_duzelt(nMusteriID, dr("dteGirisTarihi"), dr("sText"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbMusteriOzelNot = Dataload_tbMusteriOzelNot(nMusteriID)
            GridControl5.DataSource = ds_tbMusteriOzelNot.Tables(0)
            GridControl5.DataMember = Nothing
            GridView4.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView4.OptionsCustomization.AllowFilter = True
        GridView4.OptionsView.ShowAutoFilterRow = True
    End Sub
    Private Sub GridView3_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView3.FocusedColumnChanged
        tbMusteriCocugu_satir_info()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        tbKefilNufusu_duzelt("tbKefil1Nufusu")
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        tbKefilNufusu_duzelt("tbKefil2Nufusu")
    End Sub
    Private Sub txt_bEvlimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bEvlimi.CheckStateChanged
        If txt_bEvlimi.Checked = True Then
            txt_dteEvlilikTarihi.Enabled = True
        ElseIf txt_bEvlimi.Checked = False Then
            txt_dteEvlilikTarihi.EditValue = "01/01/1900"
            txt_dteEvlilikTarihi.Enabled = False
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_odeme_detay_tumu()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_bekleyen()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        musteri_notlari()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If Not ZorunluAlanKontrolu() Then
            MsgBox("Zorunlu alanlar doldurulmadan çıkış yapılamaz!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Me.Close()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If Not ZorunluAlanKontrolu() Then
            MsgBox("Zorunlu alanlar doldurulmadan kayıt yapılamaz!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        kaydet_tumu()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        kefil1()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        kefil2()
    End Sub
    Private Sub kefil1()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = Trim(TextEdit41.Text)
        frm.txt_ara.Text = Trim(TextEdit41.Text) & " " & Trim(TextEdit39.Text)
        frm.kullanici = kullanici
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dr = ds_tbMusteriKefil1.Tables(0).Rows(0)
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("sAdi") = dr1("sAdi")
                dr("sSoyadi") = dr1("sSoyadi")
                dr("sUnvan") = dr1("sUnvan")
                dr("sEmail") = dr1("sEmail")
                dr("sIsYeriAdi") = dr1("sIsYeriAdi")
                dr("sIsAdresi1") = dr1("sIsAdresi1")
                dr("sIsAdresi2") = dr1("sIsAdresi2")
                dr("sIsSemt") = dr1("sIsSemt")
                dr("sIsPostaKodu") = dr1("sIsPostaKodu")
                dr("sIsIl") = dr1("sIsIl")
                dr("sIsTelefonu") = dr1("sGSM")
                dr("sEvAdresi1") = dr1("sEvAdresi1")
                dr("sEvAdresi2") = dr1("sEvAdresi2")
                dr("sEvSemt") = dr1("sEvSemt")
                dr("sEvPostaKodu") = dr1("sEvPostaKodu")
                dr("sEvIl") = dr1("sEvIl")
                dr("sEvTelefonu") = dr1("sEvTelefonu")
                dr("sHitap") = dr1("sHitap")
                dr("sSigortaNo") = dr1("lKodu")
            End If
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub kefil2()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = Trim(TextEdit73.Text)
        frm.txt_ara.Text = Trim(TextEdit73.Text) & " " & Trim(TextEdit72.Text)
        frm.kullanici = kullanici
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dr = ds_tbMusteriKefil2.Tables(0).Rows(0)
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("sAdi") = dr1("sAdi")
                dr("sSoyadi") = dr1("sSoyadi")
                dr("sUnvan") = dr1("sUnvan")
                dr("sEmail") = dr1("sEmail")
                dr("sIsYeriAdi") = dr1("sIsYeriAdi")
                dr("sIsAdresi1") = dr1("sIsAdresi1")
                dr("sIsAdresi2") = dr1("sIsAdresi2")
                dr("sIsSemt") = dr1("sIsSemt")
                dr("sIsPostaKodu") = dr1("sIsPostaKodu")
                dr("sIsIl") = dr1("sIsIl")
                dr("sIsTelefonu") = dr1("sGSM")
                dr("sEvAdresi1") = dr1("sEvAdresi1")
                dr("sEvAdresi2") = dr1("sEvAdresi2")
                dr("sEvSemt") = dr1("sEvSemt")
                dr("sEvPostaKodu") = dr1("sEvPostaKodu")
                dr("sEvIl") = dr1("sEvIl")
                dr("sEvTelefonu") = dr1("sEvTelefonu")
                dr("sHitap") = dr1("sHitap")
                dr("sSigortaNo") = dr1("lKodu")
            End If
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub kefil3()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = Trim(TextEdit15.Text)
        frm.txt_ara.Text = Trim(TextEdit15.Text) & " " & Trim(TextEdit14.Text)
        frm.kullanici = kullanici
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dr = ds_tbMusteriKefil3.Tables(0).Rows(0)
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("sAdi") = dr1("sAdi")
                dr("sSoyadi") = dr1("sSoyadi")
                dr("sUnvan") = dr1("sUnvan")
                dr("sEmail") = dr1("sEmail")
                dr("sIsYeriAdi") = dr1("sIsYeriAdi")
                dr("sIsAdresi1") = dr1("sIsAdresi1")
                dr("sIsAdresi2") = dr1("sIsAdresi2")
                dr("sIsSemt") = dr1("sIsSemt")
                dr("sIsPostaKodu") = dr1("sIsPostaKodu")
                dr("sIsIl") = dr1("sIsIl")
                dr("sIsTelefonu") = dr1("sGSM")
                dr("sEvAdresi1") = dr1("sEvAdresi1")
                dr("sEvAdresi2") = dr1("sEvAdresi2")
                dr("sEvSemt") = dr1("sEvSemt")
                dr("sEvPostaKodu") = dr1("sEvPostaKodu")
                dr("sEvIl") = dr1("sEvIl")
                dr("sEvTelefonu") = dr1("sEvTelefonu")
                dr("sHitap") = dr1("sHitap")
                dr("sSigortaNo") = dr1("lKodu")
            End If
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub kefil4()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = Trim(TextEdit30.Text)
        frm.txt_ara.Text = Trim(TextEdit30.Text) & " " & Trim(TextEdit29.Text)
        frm.kullanici = kullanici
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dr = ds_tbMusteriKefil4.Tables(0).Rows(0)
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("sAdi") = dr1("sAdi")
                dr("sSoyadi") = dr1("sSoyadi")
                dr("sUnvan") = dr1("sUnvan")
                dr("sEmail") = dr1("sEmail")
                dr("sIsYeriAdi") = dr1("sIsYeriAdi")
                dr("sIsAdresi1") = dr1("sIsAdresi1")
                dr("sIsAdresi2") = dr1("sIsAdresi2")
                dr("sIsSemt") = dr1("sIsSemt")
                dr("sIsPostaKodu") = dr1("sIsPostaKodu")
                dr("sIsIl") = dr1("sIsIl")
                dr("sIsTelefonu") = dr1("sGSM")
                dr("sEvAdresi1") = dr1("sEvAdresi1")
                dr("sEvAdresi2") = dr1("sEvAdresi2")
                dr("sEvSemt") = dr1("sEvSemt")
                dr("sEvPostaKodu") = dr1("sEvPostaKodu")
                dr("sEvIl") = dr1("sEvIl")
                dr("sEvTelefonu") = dr1("sEvTelefonu")
                dr("sHitap") = dr1("sHitap")
                dr("sSigortaNo") = dr1("lKodu")
            End If
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        raporla_faaliyet(0, 2)
    End Sub
    Private Sub raporla_faaliyet(ByVal rapor As Integer, ByVal nislem As Integer, Optional ByVal bTumu As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (FormSozlesme*.fr*) |FormSozlesme*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\NakitKasa\FormSozlesme.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\NakitKasa"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel)
                report.RegisterData(ds_tbMusteri, "tbMusteri")
                report.RegisterData(ds_tbMusteriCocugu, "tbMusteriCocugu")
                report.RegisterData(ds_tbMusteriEkKart, "tbMusteriEkKart")
                report.RegisterData(ds_tbMusteriKarti, "tbMusteriKarti")
                report.RegisterData(ds_tbMusteriKefil1, "tbMusteriKefil1")
                report.RegisterData(ds_tbMusteriKefil2, "tbMusteriKefil2")
                report.RegisterData(ds_tbMusteriKefil3, "tbMusteriKefil3")
                report.RegisterData(ds_tbMusteriKefil4, "tbMusteriKefil4")
                report.RegisterData(ds_tbMusteriKredisi, "tbMusteriKredisi")
                report.RegisterData(ds_tbMusteriNufusu, "tbMusteriNufusu")
                report.RegisterData(ds_tbMusteriOzelNot, "tbMusteriOzelnOT")
                report.RegisterData(ds_tbMusteriSinifi, "tbMusteriSinifi")
                'report.SetParameterValue("sMagaza", txt_sMagaza.Text)
                report.ScriptLanguage = Language.Vb
                If nislem = 0 Then
                    report.Show()
                ElseIf nislem = 2 Then
                    report.Design()
                ElseIf nislem = 1 Then
                    report.Print()
                End If
                report.Dispose()
                report = Nothing
                'ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                '    report_create_stok(sFile, " WHERE nKasaIslemID = " & dr("nKasaIslemID") & "", nislem, dr("lTahsilTutar"), dr("lTediyeTutar"))
            End If
        End If
    End Sub
    Private Sub SMS_Gonder()
        If XtraMessageBox.Show(Sorgu_sDil("SMS Göndermek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            If Trim(txt_sGSM.EditValue.ToString) <> "" Then
                Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                dr1("nIslemID") = 0
                dr1("sSMSID") = 0
                dr1("dteGonderimTarihi") = Today
                dr1("sMesaj") = ""
                dr1("nMusteriID") = nMusteriID
                dr1("lKodu") = txt_musteriNo.Text
                dr1("sAdi") = txt_sAdi.Text
                dr1("sSoyadi") = txt_sSoyadi.Text
                dr1("sTelefon") = txt_sGSM.EditValue
                dr1("dteUpdateTarihi") = Now
                dr1("lDurum") = 0
                dr1("lBakiye") = 0
                frm.DataSet1.Tables(0).Rows.Add(dr1)
            End If
            'MsgBox(Sorgu_sDil("İşlem Tamamlandı...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            frm.ShowDialog()
        End If
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        raporla_faaliyet(0, 0)
    End Sub
    Private Sub btn_ReferansSec_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_ReferansSec.ButtonPressed
        referans_sec()
    End Sub
    Private Sub btn_ReferansSec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_ReferansSec.KeyDown
        If e.KeyCode = Keys.Space Then
            referans_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If btn_ReferansSec.Text = "" Or btn_ReferansSec.Text = "0" Then
                tbMusteriReferans_kaydet_Sil(nMusteriID)
                lbl_Referans.Text = ""
            End If
        End If
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        SMS_Gonder()
    End Sub
    Private Sub txt_sCuzdanKayitNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sCuzdanKayitNo.Validating
        txt_sCuzdanKayitNo.EditValue = Trim(txt_sCuzdanKayitNo.EditValue)
        If Trim(txt_sCuzdanKayitNo.EditValue) <> "" Then
            If sorgu_sCuzdanKayitNo_kontrol(txt_sCuzdanKayitNo.EditValue, nMusteriID) = False Then
                'txt_sSoyadi.ErrorText = txt_sSoyadi.Text & vbTab & "Kaydı Daha Önce Kullanılmış"
                If XtraMessageBox.Show(txt_sCuzdanKayitNo.Text & Sorgu_sDil(" TC Kimlik No Daha Once Kayit Yapilmis...", sDil) & vbCrLf & Sorgu_sDil("Kayıtları Görmek İster misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                    Dim frm As New frm_musteri_liste
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_ara.Text = txt_sCuzdanKayitNo.EditValue
                    frm.sec_konum.Text = "TCNO"
                    frm.sec_kriter.Text = "Eşittir"
                    frm.ShowDialog()
                    'e.Cancel = True
                    'txt_sSoyadi.Focus()
                    'txt_sSoyadi.SelectAll()
                End If
            End If
        End If
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        Dim dr As DataRow
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fs As New FileStream(OpenFileDialog1.FileName.ToString, FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)
            fs.Close()
            dr = ds_tbMusteriResim.Tables(0).NewRow
            dr("nMusteriID") = nMusteriID
            dr("pResim") = MyData
            dr("sAciklama") = ""
            dr("nSira") = 0
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            ds_tbMusteriResim.Tables(0).Rows.Add(dr)
            'ds_tbMusteriResim.AcceptChanges()
            Dim ds As New DataSet
            ds = ds_tbMusteriResim
            Dim da As New OleDb.OleDbDataAdapter
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            da.InsertCommand = cmd
            cmd.Connection = con
            con.ConnectionString = connection
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriResim                       (nMusteriID,pResim,sAciklama,nSira,sKullaniciAdi,dteKayitTarihi) VALUES     (?,?,?,?,?,?) "
            cmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("nMusteriID", System.Data.OleDb.OleDbType.[Integer], 0, "nMusteriID"), New System.Data.OleDb.OleDbParameter("pResim", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "pResim"), New System.Data.OleDb.OleDbParameter("sAciklama", System.Data.OleDb.OleDbType.[Char], 0, "sAciklama"), New System.Data.OleDb.OleDbParameter("nSira", System.Data.OleDb.OleDbType.[Integer], 0, "nSira"), New System.Data.OleDb.OleDbParameter("sKullaniciAdi", System.Data.OleDb.OleDbType.[Char], 0, "sKullaniciAdi"), New System.Data.OleDb.OleDbParameter("dteKayitTarihi", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "dteKayitTarihi")})
            da.Update(ds_tbMusteriResim.Tables(0))
            da = Nothing
        End If
        dr = Nothing
    End Sub
    Private Sub GridView6_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView6.CellValueChanged
        If GridView6.RowCount > 0 Then
            Dim satir = GridView6.FocusedRowHandle
            Dim dr As DataRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            GridView6.PostEditor()
            dr.EndEdit()
            Try
                tbMusteriResim_kaydet_duzelt(dr("nMusteriResimID"), dr("nMusteriID"), dr("sAciklama"), dr("nSira"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbMusteriResim = Dataload_tbMusteriResim(nMusteriID)
            GridControl6.DataSource = ds_tbMusteriResim.Tables(0)
            GridControl6.DataMember = Nothing
            GridView6.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        tbMusteriResim_Satir_sil()
    End Sub
    Private Sub GridView6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView6.DoubleClick
        If GridView6.RowCount > 0 Then
            Dim satir = GridView6.FocusedRowHandle
            Dim dr As DataRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            Dim frm As New frm_tbResim
            frm.PictureEdit1.EditValue = dr("pResim")
            frm.ShowDialog()
        End If
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        GridControl6.ShowPrintPreview()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
    Private Sub GridView4_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView4.FocusedRowChanged
        If GridView4.RowCount > 0 Then
            Dim dr As DataRow = GridView4.GetDataRow(GridView4.FocusedRowHandle)
            Try
                If dr("dteGirisTarihi") = dteSistemTarihi Then
                    colsText.OptionsColumn.ReadOnly = False
                Else
                    colsText.OptionsColumn.ReadOnly = True
                End If
            Catch ex As Exception
            End Try
            dr = Nothing
        End If
    End Sub
    Private Sub tbSinif(ByVal tablo As String)
        Dim fr As New frm_tbSinif
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.kullanici = kullanici
        fr.Table = tablo
        If yetki_kontrol(kullanici, fr.Name) = True Then
            fr.ShowDialog()
            Dataload_tbMusteriSinifi(nMusteriID)
        End If
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        tbSinif("tbMSinif")
    End Sub
    Private Sub sec_bMusteriAktif_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles sec_bMusteriAktif.CheckedChanged
        If sec_bMusteriAktif.Checked = True Then
            sec_bMusteriAktif.Text = "Hesap Aktif"
        Else
            sec_bMusteriAktif.Text = "Hesap Pasif"
        End If
    End Sub
    Private Sub SimpleButton14_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton14.Click
        kefil3()
    End Sub
    Private Sub SimpleButton15_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton15.Click
        kefil4()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub frm_musteri_kart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not ZorunluAlanKontrolu() Then
            MsgBox("Zorunlu alanlar doldurulmadan çıkılamaz!", MsgBoxStyle.Critical)
            e.Cancel = True ' 👉 Çıkışı iptal eder
        End If
    End Sub
End Class