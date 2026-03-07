Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_fatura_kalemleri
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
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lNetTutar2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lNetTutar1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sFisTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_nGirisCikis As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sDepo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sHareketTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents coldtefisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikisMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSiparisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIrsaliyeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIrsaliyeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnDipIskontoYuzdesi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnDipIskontoYuzdesi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDipIskontoTutari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDipIskontoTutari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDipIskontoTutari3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdv1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdv2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdv3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdv4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdv5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collEkmaliyet1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collEkmaliyet2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collEkmaliyet3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbFisTamamlandimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvMatrahi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvMatrahi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvMatrahi3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvMatrahi4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvMatrahi5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGERCEKFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGERCEKTOPLAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDahilBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDahilBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasterKullanici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasterTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetayKullanici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetayTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_resmi1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents colFIYAT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyatFirma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTransferDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKisaAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHacim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikisAgirlik As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fatura_kalemleri))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_resmi1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sHareketTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteFisTarihi2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteFisTarihi1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lFisNo2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lFisNo1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sDepo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_nGirisCikis = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sFisTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lNetTutar2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lNetTutar1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldtefisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTransferDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikisMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSiparisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIrsaliyeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIrsaliyeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnDipIskontoYuzdesi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnDipIskontoYuzdesi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDipIskontoTutari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDipIskontoTutari2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDipIskontoTutari3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdv1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdv2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdv3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdv4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdv5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collEkmaliyet1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collEkmaliyet2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collEkmaliyet3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbFisTamamlandimi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvMatrahi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvMatrahi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvMatrahi3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvMatrahi4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvMatrahi5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGERCEKFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGERCEKTOPLAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDahilBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDahilBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasterKullanici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasterTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetayKullanici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetayTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyatFirma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKisaAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnHacim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikisAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.colnGirisAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nGirisCikis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lNetTutar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lNetTutar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 150)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_resmi1)
        Me.GroupControl1.Controls.Add(Me.sec_resmi)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.sec_sHareketTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.sec_sDepo)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.sec_nGirisCikis)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sec_sFisTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_lNetTutar2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_lNetTutar1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(681, 146)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_resmi1
        '
        Me.sec_resmi1.Location = New System.Drawing.Point(429, 93)
        Me.sec_resmi1.Name = "sec_resmi1"
        Me.sec_resmi1.Properties.Caption = "R1"
        Me.sec_resmi1.Size = New System.Drawing.Size(48, 19)
        Me.sec_resmi1.TabIndex = 55
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(397, 93)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 54
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Location = New System.Drawing.Point(172, 98)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(41, 20)
        Me.LabelControl15.TabIndex = 43
        Me.LabelControl15.Text = "Hareket"
        '
        'sec_sHareketTipi
        '
        Me.sec_sHareketTipi.EnterMoveNextControl = True
        Me.sec_sHareketTipi.Location = New System.Drawing.Point(215, 99)
        Me.sec_sHareketTipi.Name = "sec_sHareketTipi"
        Me.sec_sHareketTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sHareketTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sHareketTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sHareketTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sHareketTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sHareketTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sHareketTipi.Properties.DisplayMember = "sHareketTipi"
        Me.sec_sHareketTipi.Properties.NullText = "[Hareket]"
        Me.sec_sHareketTipi.Properties.ValueMember = "sHareketTipi"
        Me.sec_sHareketTipi.Size = New System.Drawing.Size(100, 20)
        Me.sec_sHareketTipi.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(317, 42)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl9.TabIndex = 41
        Me.LabelControl9.Text = "Arasýndaki"
        '
        'txt_dteFisTarihi2
        '
        Me.txt_dteFisTarihi2.EditValue = Nothing
        Me.txt_dteFisTarihi2.EnterMoveNextControl = True
        Me.txt_dteFisTarihi2.Location = New System.Drawing.Point(215, 42)
        Me.txt_dteFisTarihi2.Name = "txt_dteFisTarihi2"
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteFisTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteFisTarihi2.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteFisTarihi2.TabIndex = 3
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(177, 42)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl11.TabIndex = 40
        Me.LabelControl11.Text = "ve"
        '
        'txt_dteFisTarihi1
        '
        Me.txt_dteFisTarihi1.EditValue = Nothing
        Me.txt_dteFisTarihi1.EnterMoveNextControl = True
        Me.txt_dteFisTarihi1.Location = New System.Drawing.Point(71, 42)
        Me.txt_dteFisTarihi1.Name = "txt_dteFisTarihi1"
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteFisTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteFisTarihi1.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteFisTarihi1.TabIndex = 2
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Location = New System.Drawing.Point(0, 42)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl13.TabIndex = 39
        Me.LabelControl13.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(317, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Arasýndaki"
        '
        'txt_lFisNo2
        '
        Me.txt_lFisNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lFisNo2.EnterMoveNextControl = True
        Me.txt_lFisNo2.Location = New System.Drawing.Point(215, 61)
        Me.txt_lFisNo2.Name = "txt_lFisNo2"
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lFisNo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo2.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(177, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "ve"
        '
        'txt_lFisNo1
        '
        Me.txt_lFisNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_lFisNo1.EnterMoveNextControl = True
        Me.txt_lFisNo1.Location = New System.Drawing.Point(71, 61)
        Me.txt_lFisNo1.Name = "txt_lFisNo1"
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lFisNo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo1.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(0, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "FiþNo:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.Location = New System.Drawing.Point(317, 101)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl14.TabIndex = 31
        Me.LabelControl14.Text = "Eþittir"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(0, 99)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "Depo"
        '
        'sec_sDepo
        '
        Me.sec_sDepo.EnterMoveNextControl = True
        Me.sec_sDepo.Location = New System.Drawing.Point(71, 99)
        Me.sec_sDepo.Name = "sec_sDepo"
        Me.sec_sDepo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sDepo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sDepo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sDepo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sDepo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sDepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDepo.Properties.DisplayMember = "sDepo"
        Me.sec_sDepo.Properties.NullText = "[Depolar]"
        Me.sec_sDepo.Properties.ValueMember = "sDepo"
        Me.sec_sDepo.Size = New System.Drawing.Size(100, 20)
        Me.sec_sDepo.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(174, 23)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 20)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Ýþlem:"
        '
        'sec_nGirisCikis
        '
        Me.sec_nGirisCikis.Enabled = False
        Me.sec_nGirisCikis.EnterMoveNextControl = True
        Me.sec_nGirisCikis.Location = New System.Drawing.Point(215, 23)
        Me.sec_nGirisCikis.Name = "sec_nGirisCikis"
        Me.sec_nGirisCikis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_nGirisCikis.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_nGirisCikis.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_nGirisCikis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_nGirisCikis.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_nGirisCikis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nGirisCikis.Properties.DisplayMember = "sAciklama"
        Me.sec_nGirisCikis.Properties.NullText = "[Islem]"
        Me.sec_nGirisCikis.Properties.ValueMember = "nGirisCikis"
        Me.sec_nGirisCikis.Size = New System.Drawing.Size(100, 20)
        Me.sec_nGirisCikis.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(0, 23)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "FiþTipi:"
        '
        'sec_sFisTipi
        '
        Me.sec_sFisTipi.Enabled = False
        Me.sec_sFisTipi.EnterMoveNextControl = True
        Me.sec_sFisTipi.Location = New System.Drawing.Point(71, 23)
        Me.sec_sFisTipi.Name = "sec_sFisTipi"
        Me.sec_sFisTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFisTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFisTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sFisTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sFisTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sFisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFisTipi.Properties.DisplayMember = "sAciklama"
        Me.sec_sFisTipi.Properties.NullText = "[FiþTipleri]"
        Me.sec_sFisTipi.Properties.ValueMember = "sFisTipi"
        Me.sec_sFisTipi.Size = New System.Drawing.Size(100, 20)
        Me.sec_sFisTipi.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(0, 118)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Firma:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(317, 79)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasýndaki"
        '
        'txt_lNetTutar2
        '
        Me.txt_lNetTutar2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lNetTutar2.EnterMoveNextControl = True
        Me.txt_lNetTutar2.Location = New System.Drawing.Point(215, 80)
        Me.txt_lNetTutar2.Name = "txt_lNetTutar2"
        Me.txt_lNetTutar2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lNetTutar2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lNetTutar2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lNetTutar2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lNetTutar2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lNetTutar2.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(177, 80)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lNetTutar1
        '
        Me.txt_lNetTutar1.EditValue = New Decimal(New Integer() {999999999, 0, 0, -2147483648})
        Me.txt_lNetTutar1.EnterMoveNextControl = True
        Me.txt_lNetTutar1.Location = New System.Drawing.Point(71, 80)
        Me.txt_lNetTutar1.Name = "txt_lNetTutar1"
        Me.txt_lNetTutar1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lNetTutar1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lNetTutar1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lNetTutar1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lNetTutar1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lNetTutar1.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(0, 80)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Tutar:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(215, 118)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adý"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 11
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(402, 118)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 13
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(317, 118)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 12
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(71, 118)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_ara.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(146, 20)
        Me.txt_ara.TabIndex = 10
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(777, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(45, 13)
        Me.lbl_istihbarat.TabIndex = 40
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.label3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'label3
        '
        Me.label3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label3.Location = New System.Drawing.Point(2, 33)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(7, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 9)
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
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 150)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 209)
        Me.PanelControl3.TabIndex = 0
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 205)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem23, Me.MenuItem18, Me.MenuItem13, Me.MenuItem15, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem22, Me.MenuItem24, Me.MenuItem25, Me.MenuItem14, Me.MenuItem26, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem28, Me.MenuItem10, Me.MenuItem27, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem21.Text = "Ara"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem23.Text = "Ekle"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Düzelt"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "Faturalaþtýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlF5
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 6
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 7
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem17.Text = "Firma Hareketleri"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.CtrlF6
        Me.MenuItem22.Text = "Firma Bakiyesi"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 9
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem24.Text = "Stok Hareketleri"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 10
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem25.Text = "Stok Envanter"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 11
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem14.Text = "Stok Kartý"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 12
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem26.Text = "Stok Fiyatlandir"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 13
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 14
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 15
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 16
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 17
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 18
        Me.MenuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem30})
        Me.MenuItem28.Text = "Raporla"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 0
        Me.MenuItem29.Text = "Excel"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 1
        Me.MenuItem30.Text = "Text"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 19
        Me.MenuItem10.Text = "-"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 20
        Me.MenuItem27.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 21
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 22
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 23
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 24
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 25
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 26
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 27
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nCekSenetID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lCekSenetNo"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lTutar"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "dteVadeTarihi"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sBankaKodu"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sBankaAciklama"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sOrjinalCekSenetNo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sVerenFirmaKodu"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sVerenFirmaAciklama"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nSonCekSenetIslem"
        Me.DataColumn10.DataType = GetType(Long)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sIslem"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sAlanFirmaKodu"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sAlanFirmaAciklama"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sHareketTipi"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sDovizCinsi1"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lDovizMiktari1"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lDovizKuru1"
        Me.DataColumn17.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldtefisTarihi, Me.coldteValorTarihi, Me.collFisNo, Me.colsFirmaKodu, Me.colsFirmaAciklama, Me.colHT, Me.colsStokKodu, Me.colsModel, Me.colsStokAciklama, Me.colsRenk, Me.colsBeden, Me.colsDepo, Me.colsTransferDepo, Me.colsFiyatTipi, Me.collCikisMiktar1, Me.collGirisMiktar1, Me.collBrutFiyat, Me.collBrutTutar, Me.colnIskontoYuzdesi, Me.colnKdvOrani, Me.colsStokIslem, Me.collSiparisNo, Me.collIrsaliyeNo, Me.coldteIrsaliyeTarihi, Me.colsAciklama, Me.collToplamMiktar, Me.collMalBedeli, Me.collMalIskontoTutari, Me.colnDipIskontoYuzdesi1, Me.colnDipIskontoYuzdesi2, Me.collDipIskontoTutari1, Me.collDipIskontoTutari2, Me.collDipIskontoTutari3, Me.colnKdvOrani1, Me.colnKdvOrani2, Me.colnKdvOrani3, Me.colnKdvOrani4, Me.colnKdvOrani5, Me.collKdv1, Me.collKdv2, Me.collKdv3, Me.collKdv4, Me.collKdv5, Me.collEkmaliyet1, Me.collEkmaliyet2, Me.collEkmaliyet3, Me.collKdv, Me.collNetTutar, Me.colsAciklama1, Me.colsAciklama2, Me.colsAciklama3, Me.colsAciklama4, Me.colsAciklama5, Me.colbFisTamamlandimi, Me.collKdvMatrahi1, Me.collKdvMatrahi2, Me.collKdvMatrahi3, Me.collKdvMatrahi4, Me.collKdvMatrahi5, Me.collKdvMatrahi, Me.colsBarkod, Me.colISK1, Me.colISK2, Me.colISK3, Me.colISK4, Me.colGERCEKFIYAT, Me.colGERCEKTOPLAM, Me.collKdvTutari, Me.collDahilBrutFiyat, Me.collDahilBrutTutar, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.colnStokFisiId, Me.colMasterKullanici, Me.colMasterTarih, Me.colDetayKullanici, Me.colDetayTarih, Me.collIskontoTutari, Me.colFIYAT1, Me.colFIYAT2, Me.colFIYAT3, Me.colFiyatFirma, Me.colsSaticiRumuzu, Me.colsKisaAdi, Me.colnHacim, Me.colnCikisAgirlik, Me.collEvrakNo, Me.colnGirisAgirlik})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(565, 289, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sStokKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", Nothing, "Giren:{0:#,0.###}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", Nothing, "Çýkan:{0:#,0.###}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sStokKodu", Me.colsStokKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", Me.collGirisMiktar1, "{0:#,0.###}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", Me.collCikisMiktar1, "{0:#,0.###}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", Me.collBrutTutar, "{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
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
        'coldtefisTarihi
        '
        Me.coldtefisTarihi.Caption = "Fiþ Tarihi"
        Me.coldtefisTarihi.FieldName = "dtefisTarihi"
        Me.coldtefisTarihi.Name = "coldtefisTarihi"
        Me.coldtefisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dtefisTarihi", "{0} Kayýt")})
        Me.coldtefisTarihi.Visible = True
        Me.coldtefisTarihi.VisibleIndex = 0
        Me.coldtefisTarihi.Width = 71
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valor"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Width = 126
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 1
        Me.collFisNo.Width = 56
        '
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Firma Kodu"
        Me.colsFirmaKodu.FieldName = "sFirmaKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        Me.colsFirmaKodu.Width = 61
        '
        'colsFirmaAciklama
        '
        Me.colsFirmaAciklama.Caption = "Firma Adý"
        Me.colsFirmaAciklama.FieldName = "sFirmaAciklama"
        Me.colsFirmaAciklama.Name = "colsFirmaAciklama"
        Me.colsFirmaAciklama.Visible = True
        Me.colsFirmaAciklama.VisibleIndex = 2
        Me.colsFirmaAciklama.Width = 74
        '
        'colHT
        '
        Me.colHT.Caption = "HT"
        Me.colHT.FieldName = "HT"
        Me.colHT.Name = "colHT"
        '
        'colsStokKodu
        '
        Me.colsStokKodu.Caption = "Stok Kodu"
        Me.colsStokKodu.FieldName = "sStokKodu"
        Me.colsStokKodu.Name = "colsStokKodu"
        Me.colsStokKodu.Visible = True
        Me.colsStokKodu.VisibleIndex = 3
        Me.colsStokKodu.Width = 89
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Stok Adý"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 4
        Me.colsStokAciklama.Width = 109
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsDepo
        '
        Me.colsDepo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colsDepo.AppearanceCell.Options.UseBackColor = True
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colsTransferDepo
        '
        Me.colsTransferDepo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colsTransferDepo.AppearanceCell.Options.UseBackColor = True
        Me.colsTransferDepo.Caption = "DepoTransfer"
        Me.colsTransferDepo.FieldName = "sTransferDepo"
        Me.colsTransferDepo.Name = "colsTransferDepo"
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "Fiyattipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        '
        'collCikisMiktar1
        '
        Me.collCikisMiktar1.Caption = "Çýkýþ"
        Me.collCikisMiktar1.DisplayFormat.FormatString = "#,0.00##"
        Me.collCikisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikisMiktar1.FieldName = "lCikisMiktar1"
        Me.collCikisMiktar1.Name = "collCikisMiktar1"
        Me.collCikisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", "{0:#,0.00}")})
        Me.collCikisMiktar1.Visible = True
        Me.collCikisMiktar1.VisibleIndex = 6
        Me.collCikisMiktar1.Width = 53
        '
        'collGirisMiktar1
        '
        Me.collGirisMiktar1.Caption = "Giriþ"
        Me.collGirisMiktar1.DisplayFormat.FormatString = "#,0.00##"
        Me.collGirisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar1.FieldName = "lGirisMiktar1"
        Me.collGirisMiktar1.Name = "collGirisMiktar1"
        Me.collGirisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", "{0:#,0.00}")})
        Me.collGirisMiktar1.Visible = True
        Me.collGirisMiktar1.VisibleIndex = 5
        Me.collGirisMiktar1.Width = 53
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Brüt Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 9
        Me.collBrutFiyat.Width = 65
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Brüt Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.00}")})
        Me.collBrutTutar.Visible = True
        Me.collBrutTutar.VisibleIndex = 10
        Me.collBrutTutar.Width = 76
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "% Ýsk."
        Me.colnIskontoYuzdesi.DisplayFormat.FormatString = "#,0.00##"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Visible = True
        Me.colnIskontoYuzdesi.VisibleIndex = 8
        Me.colnIskontoYuzdesi.Width = 65
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv Oraný"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.##"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.Visible = True
        Me.colnKdvOrani.VisibleIndex = 7
        Me.colnKdvOrani.Width = 65
        '
        'colsStokIslem
        '
        Me.colsStokIslem.Caption = "Stok Ýþlem"
        Me.colsStokIslem.FieldName = "sStokIslem"
        Me.colsStokIslem.Name = "colsStokIslem"
        '
        'collSiparisNo
        '
        Me.collSiparisNo.Caption = "Sipariþ No"
        Me.collSiparisNo.FieldName = "lSiparisNo"
        Me.collSiparisNo.Name = "collSiparisNo"
        '
        'collIrsaliyeNo
        '
        Me.collIrsaliyeNo.Caption = "Ýrsaliye No"
        Me.collIrsaliyeNo.FieldName = "lIrsaliyeNo"
        Me.collIrsaliyeNo.Name = "collIrsaliyeNo"
        '
        'coldteIrsaliyeTarihi
        '
        Me.coldteIrsaliyeTarihi.Caption = "Ýrsaliye Tarihi"
        Me.coldteIrsaliyeTarihi.FieldName = "dteIrsaliyeTarihi"
        Me.coldteIrsaliyeTarihi.Name = "coldteIrsaliyeTarihi"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Width = 67
        '
        'collToplamMiktar
        '
        Me.collToplamMiktar.Caption = "Toplam Miktar"
        Me.collToplamMiktar.DisplayFormat.FormatString = "#,0.00##"
        Me.collToplamMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamMiktar.FieldName = "lToplamMiktar"
        Me.collToplamMiktar.Name = "collToplamMiktar"
        '
        'collMalBedeli
        '
        Me.collMalBedeli.Caption = "Mal Bedeli"
        Me.collMalBedeli.DisplayFormat.FormatString = "#,0.00##"
        Me.collMalBedeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalBedeli.FieldName = "lMalBedeli"
        Me.collMalBedeli.Name = "collMalBedeli"
        '
        'collMalIskontoTutari
        '
        Me.collMalIskontoTutari.Caption = "Mal Ýskonto Tutarý"
        Me.collMalIskontoTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collMalIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalIskontoTutari.FieldName = "lMalIskontoTutari"
        Me.collMalIskontoTutari.Name = "collMalIskontoTutari"
        '
        'colnDipIskontoYuzdesi1
        '
        Me.colnDipIskontoYuzdesi1.Caption = "% Dip Ýskonto 1"
        Me.colnDipIskontoYuzdesi1.DisplayFormat.FormatString = "#,0.00##"
        Me.colnDipIskontoYuzdesi1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnDipIskontoYuzdesi1.FieldName = "nDipIskontoYuzdesi1"
        Me.colnDipIskontoYuzdesi1.Name = "colnDipIskontoYuzdesi1"
        '
        'colnDipIskontoYuzdesi2
        '
        Me.colnDipIskontoYuzdesi2.Caption = "% Dip Ýskonto 2"
        Me.colnDipIskontoYuzdesi2.DisplayFormat.FormatString = "#,0.00##"
        Me.colnDipIskontoYuzdesi2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnDipIskontoYuzdesi2.FieldName = "nDipIskontoYuzdesi2"
        Me.colnDipIskontoYuzdesi2.Name = "colnDipIskontoYuzdesi2"
        '
        'collDipIskontoTutari1
        '
        Me.collDipIskontoTutari1.Caption = "Dip Ýskonto"
        Me.collDipIskontoTutari1.DisplayFormat.FormatString = "#,0.00##"
        Me.collDipIskontoTutari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDipIskontoTutari1.FieldName = "lDipIskontoTutari1"
        Me.collDipIskontoTutari1.Name = "collDipIskontoTutari1"
        '
        'collDipIskontoTutari2
        '
        Me.collDipIskontoTutari2.Caption = "Dip Ýskonto 2"
        Me.collDipIskontoTutari2.DisplayFormat.FormatString = "#,0.00##"
        Me.collDipIskontoTutari2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDipIskontoTutari2.FieldName = "lDipIskontoTutari2"
        Me.collDipIskontoTutari2.Name = "collDipIskontoTutari2"
        '
        'collDipIskontoTutari3
        '
        Me.collDipIskontoTutari3.Caption = "Dip Ýskonto 3"
        Me.collDipIskontoTutari3.DisplayFormat.FormatString = "#,0.00##"
        Me.collDipIskontoTutari3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDipIskontoTutari3.FieldName = "lDipIskontoTutari3"
        Me.collDipIskontoTutari3.Name = "collDipIskontoTutari3"
        '
        'colnKdvOrani1
        '
        Me.colnKdvOrani1.Caption = "Kdv Oraný 1"
        Me.colnKdvOrani1.DisplayFormat.FormatString = "#,0.00##"
        Me.colnKdvOrani1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani1.FieldName = "nKdvOrani1"
        Me.colnKdvOrani1.Name = "colnKdvOrani1"
        '
        'colnKdvOrani2
        '
        Me.colnKdvOrani2.Caption = "Kdv Oraný 2"
        Me.colnKdvOrani2.DisplayFormat.FormatString = "#,0.00##"
        Me.colnKdvOrani2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani2.FieldName = "nKdvOrani2"
        Me.colnKdvOrani2.Name = "colnKdvOrani2"
        '
        'colnKdvOrani3
        '
        Me.colnKdvOrani3.Caption = "Kdv Oraný 3"
        Me.colnKdvOrani3.DisplayFormat.FormatString = "#,0.00##"
        Me.colnKdvOrani3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani3.FieldName = "nKdvOrani3"
        Me.colnKdvOrani3.Name = "colnKdvOrani3"
        '
        'colnKdvOrani4
        '
        Me.colnKdvOrani4.Caption = "Kdv Oraný 4"
        Me.colnKdvOrani4.DisplayFormat.FormatString = "#,0.00##"
        Me.colnKdvOrani4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani4.FieldName = "nKdvOrani4"
        Me.colnKdvOrani4.Name = "colnKdvOrani4"
        '
        'colnKdvOrani5
        '
        Me.colnKdvOrani5.Caption = "Kdv Oraný 5"
        Me.colnKdvOrani5.DisplayFormat.FormatString = "#,0.00##"
        Me.colnKdvOrani5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani5.FieldName = "nKdvOrani5"
        Me.colnKdvOrani5.Name = "colnKdvOrani5"
        '
        'collKdv1
        '
        Me.collKdv1.Caption = "Kdv Tutarý 1"
        Me.collKdv1.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdv1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdv1.FieldName = "lKdv1"
        Me.collKdv1.Name = "collKdv1"
        '
        'collKdv2
        '
        Me.collKdv2.Caption = "Kdv Tutarý 2"
        Me.collKdv2.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdv2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdv2.FieldName = "lKdv2"
        Me.collKdv2.Name = "collKdv2"
        '
        'collKdv3
        '
        Me.collKdv3.Caption = "Kdv Tutarý 3"
        Me.collKdv3.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdv3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdv3.FieldName = "lKdv3"
        Me.collKdv3.Name = "collKdv3"
        '
        'collKdv4
        '
        Me.collKdv4.Caption = "Kdv Tutarý 4"
        Me.collKdv4.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdv4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdv4.FieldName = "lKdv4"
        Me.collKdv4.Name = "collKdv4"
        '
        'collKdv5
        '
        Me.collKdv5.Caption = "Kdv Tutarý 5"
        Me.collKdv5.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdv5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdv5.FieldName = "lKdv5"
        Me.collKdv5.Name = "collKdv5"
        '
        'collEkmaliyet1
        '
        Me.collEkmaliyet1.Caption = "Ek Maliyet 1"
        Me.collEkmaliyet1.DisplayFormat.FormatString = "#,0.00##"
        Me.collEkmaliyet1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEkmaliyet1.FieldName = "lEkmaliyet1"
        Me.collEkmaliyet1.Name = "collEkmaliyet1"
        '
        'collEkmaliyet2
        '
        Me.collEkmaliyet2.Caption = "Ek Maliyet 2"
        Me.collEkmaliyet2.DisplayFormat.FormatString = "#,0.00##"
        Me.collEkmaliyet2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEkmaliyet2.FieldName = "lEkmaliyet2"
        Me.collEkmaliyet2.Name = "collEkmaliyet2"
        '
        'collEkmaliyet3
        '
        Me.collEkmaliyet3.Caption = "Ek Maliyet 3"
        Me.collEkmaliyet3.DisplayFormat.FormatString = "#,0.00##"
        Me.collEkmaliyet3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEkmaliyet3.FieldName = "lEkmaliyet3"
        Me.collEkmaliyet3.Name = "collEkmaliyet3"
        '
        'collKdv
        '
        Me.collKdv.Caption = "Kdv Tutarý"
        Me.collKdv.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdv.FieldName = "lKdv"
        Me.collKdv.Name = "collKdv"
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Not 1"
        Me.colsAciklama1.FieldName = "sAciklama1"
        Me.colsAciklama1.Name = "colsAciklama1"
        '
        'colsAciklama2
        '
        Me.colsAciklama2.Caption = "Not 2"
        Me.colsAciklama2.FieldName = "sAciklama2"
        Me.colsAciklama2.Name = "colsAciklama2"
        '
        'colsAciklama3
        '
        Me.colsAciklama3.Caption = "Not 3"
        Me.colsAciklama3.FieldName = "sAciklama3"
        Me.colsAciklama3.Name = "colsAciklama3"
        '
        'colsAciklama4
        '
        Me.colsAciklama4.Caption = "Not 4"
        Me.colsAciklama4.FieldName = "sAciklama4"
        Me.colsAciklama4.Name = "colsAciklama4"
        '
        'colsAciklama5
        '
        Me.colsAciklama5.Caption = "Not 5"
        Me.colsAciklama5.FieldName = "sAciklama5"
        Me.colsAciklama5.Name = "colsAciklama5"
        '
        'colbFisTamamlandimi
        '
        Me.colbFisTamamlandimi.Caption = "Fiþ Tamamlandýmý ?"
        Me.colbFisTamamlandimi.FieldName = "bFisTamamlandimi"
        Me.colbFisTamamlandimi.Name = "colbFisTamamlandimi"
        '
        'collKdvMatrahi1
        '
        Me.collKdvMatrahi1.Caption = "Kdv Matrahý 1"
        Me.collKdvMatrahi1.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdvMatrahi1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvMatrahi1.FieldName = "lKdvMatrahi1"
        Me.collKdvMatrahi1.Name = "collKdvMatrahi1"
        '
        'collKdvMatrahi2
        '
        Me.collKdvMatrahi2.Caption = "Kdv Matrahý 2"
        Me.collKdvMatrahi2.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdvMatrahi2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvMatrahi2.FieldName = "lKdvMatrahi2"
        Me.collKdvMatrahi2.Name = "collKdvMatrahi2"
        '
        'collKdvMatrahi3
        '
        Me.collKdvMatrahi3.Caption = "Kdv Matrahý 3"
        Me.collKdvMatrahi3.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdvMatrahi3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvMatrahi3.FieldName = "lKdvMatrahi3"
        Me.collKdvMatrahi3.Name = "collKdvMatrahi3"
        '
        'collKdvMatrahi4
        '
        Me.collKdvMatrahi4.Caption = "Kdv Matrahý 4"
        Me.collKdvMatrahi4.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdvMatrahi4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvMatrahi4.FieldName = "lKdvMatrahi4"
        Me.collKdvMatrahi4.Name = "collKdvMatrahi4"
        '
        'collKdvMatrahi5
        '
        Me.collKdvMatrahi5.Caption = "Kdv Matrahý 5"
        Me.collKdvMatrahi5.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdvMatrahi5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvMatrahi5.FieldName = "lKdvMatrahi5"
        Me.collKdvMatrahi5.Name = "collKdvMatrahi5"
        '
        'collKdvMatrahi
        '
        Me.collKdvMatrahi.Caption = "Kdv Matrahý"
        Me.collKdvMatrahi.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdvMatrahi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvMatrahi.FieldName = "lKdvMatrahi"
        Me.collKdvMatrahi.Name = "collKdvMatrahi"
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        '
        'colISK1
        '
        Me.colISK1.Caption = "Ýsk.1"
        Me.colISK1.DisplayFormat.FormatString = "#,0.00##"
        Me.colISK1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK1.FieldName = "ISK1"
        Me.colISK1.Name = "colISK1"
        '
        'colISK2
        '
        Me.colISK2.Caption = "Ýsk.2"
        Me.colISK2.DisplayFormat.FormatString = "#,0.00##"
        Me.colISK2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK2.FieldName = "ISK2"
        Me.colISK2.Name = "colISK2"
        '
        'colISK3
        '
        Me.colISK3.Caption = "Ýsk.3"
        Me.colISK3.DisplayFormat.FormatString = "#,0.00##"
        Me.colISK3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK3.FieldName = "ISK3"
        Me.colISK3.Name = "colISK3"
        '
        'colISK4
        '
        Me.colISK4.Caption = "Ýsk.4"
        Me.colISK4.DisplayFormat.FormatString = "#,0.00##"
        Me.colISK4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK4.FieldName = "ISK4"
        Me.colISK4.Name = "colISK4"
        '
        'colGERCEKFIYAT
        '
        Me.colGERCEKFIYAT.Caption = "Gerçek Fiyat"
        Me.colGERCEKFIYAT.DisplayFormat.FormatString = "#,0.00##"
        Me.colGERCEKFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGERCEKFIYAT.FieldName = "GERCEKFIYAT"
        Me.colGERCEKFIYAT.Name = "colGERCEKFIYAT"
        '
        'colGERCEKTOPLAM
        '
        Me.colGERCEKTOPLAM.Caption = "Gerçek Toplam"
        Me.colGERCEKTOPLAM.DisplayFormat.FormatString = "#,0.00##"
        Me.colGERCEKTOPLAM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGERCEKTOPLAM.FieldName = "GERCEKTOPLAM"
        Me.colGERCEKTOPLAM.Name = "colGERCEKTOPLAM"
        '
        'collKdvTutari
        '
        Me.collKdvTutari.Caption = "Kdv Tutarý"
        Me.collKdvTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvTutari.FieldName = "lKdvTutari"
        Me.collKdvTutari.Name = "collKdvTutari"
        '
        'collDahilBrutFiyat
        '
        Me.collDahilBrutFiyat.Caption = "Dahil Fiyat"
        Me.collDahilBrutFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.collDahilBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDahilBrutFiyat.FieldName = "lDahilBrutFiyat"
        Me.collDahilBrutFiyat.Name = "collDahilBrutFiyat"
        '
        'collDahilBrutTutar
        '
        Me.collDahilBrutTutar.Caption = "Dahil Tutar"
        Me.collDahilBrutTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collDahilBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDahilBrutTutar.FieldName = "lDahilBrutTutar"
        Me.collDahilBrutTutar.Name = "collDahilBrutTutar"
        Me.collDahilBrutTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDahilBrutTutar", "{0:#,0.00##}")})
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Pb"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Kur"
        Me.collDovizMiktari1.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        '
        'colnStokFisiId
        '
        Me.colnStokFisiId.Caption = "Kayýt No"
        Me.colnStokFisiId.FieldName = "nStokFisiId"
        Me.colnStokFisiId.Name = "colnStokFisiId"
        '
        'colMasterKullanici
        '
        Me.colMasterKullanici.Caption = "Kaydeden"
        Me.colMasterKullanici.FieldName = "MasterKullanici"
        Me.colMasterKullanici.Name = "colMasterKullanici"
        '
        'colMasterTarih
        '
        Me.colMasterTarih.Caption = "Kayýt Tarihi"
        Me.colMasterTarih.FieldName = "MasterTarih"
        Me.colMasterTarih.Name = "colMasterTarih"
        '
        'colDetayKullanici
        '
        Me.colDetayKullanici.Caption = "Kaydeden Detay"
        Me.colDetayKullanici.FieldName = "DetayKullanici"
        Me.colDetayKullanici.Name = "colDetayKullanici"
        '
        'colDetayTarih
        '
        Me.colDetayTarih.Caption = "Kayýt Tarihi Detay"
        Me.colDetayTarih.FieldName = "DetayTarih"
        Me.colDetayTarih.Name = "colDetayTarih"
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Ýskonto Tutarý"
        Me.collIskontoTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskontoTutari", "{0:#,0.00}")})
        Me.collIskontoTutari.Visible = True
        Me.collIskontoTutari.VisibleIndex = 12
        Me.collIskontoTutari.Width = 73
        '
        'colFIYAT1
        '
        Me.colFIYAT1.Caption = "Fiyat1"
        Me.colFIYAT1.FieldName = "FIYAT1"
        Me.colFIYAT1.Name = "colFIYAT1"
        '
        'colFIYAT2
        '
        Me.colFIYAT2.Caption = "Fiyat2"
        Me.colFIYAT2.FieldName = "FIYAT2"
        Me.colFIYAT2.Name = "colFIYAT2"
        '
        'colFIYAT3
        '
        Me.colFIYAT3.Caption = "Fiyat3"
        Me.colFIYAT3.FieldName = "FIYAT3"
        Me.colFIYAT3.Name = "colFIYAT3"
        '
        'colFiyatFirma
        '
        Me.colFiyatFirma.Caption = "Fiyat Firmaya"
        Me.colFiyatFirma.FieldName = "FiyatFirma"
        Me.colFiyatFirma.Name = "colFiyatFirma"
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satici"
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        '
        'colsKisaAdi
        '
        Me.colsKisaAdi.Caption = "KisaAdi"
        Me.colsKisaAdi.FieldName = "sKisaAdi"
        Me.colsKisaAdi.Name = "colsKisaAdi"
        '
        'colnHacim
        '
        Me.colnHacim.Caption = "Hacim"
        Me.colnHacim.FieldName = "nHacim"
        Me.colnHacim.Name = "colnHacim"
        '
        'colnCikisAgirlik
        '
        Me.colnCikisAgirlik.Caption = "Çýkýþ Aðýrlýk"
        Me.colnCikisAgirlik.FieldName = "nAgirlikCikis"
        Me.colnCikisAgirlik.Name = "colnCikisAgirlik"
        Me.colnCikisAgirlik.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nAgirlikCikis", "{0:#,0.00}")})
        '
        'collEvrakNo
        '
        Me.collEvrakNo.Caption = "Evrak No"
        Me.collEvrakNo.FieldName = "EvrakNo"
        Me.collEvrakNo.Name = "collEvrakNo"
        Me.collEvrakNo.Visible = True
        Me.collEvrakNo.VisibleIndex = 11
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Fiþ Detaylarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Stok Kartý"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Envanter"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Stok Hareketleri"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Firma Kartý"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Firma Hareketleri"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Ýletiþim"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Excel"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Text"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Mail"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
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
        'colnGirisAgirlik
        '
        Me.colnGirisAgirlik.Caption = "Giriþ Aðýrlýk"
        Me.colnGirisAgirlik.FieldName = "nAgirlikGiris"
        Me.colnGirisAgirlik.Name = "colnGirisAgirlik"
        Me.colnGirisAgirlik.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nAgirlikGiris", "{0:#,0.00}")})
        Me.colnGirisAgirlik.Visible = True
        Me.colnGirisAgirlik.VisibleIndex = 13
        '
        'frm_fatura_kalemleri
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_fatura_kalemleri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiþ Detaylari"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nGirisCikis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lNetTutar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lNetTutar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public connection_resmi
    Public connection_orj
    Public connection_resmi1
    Public musterino
    Public kullanici
    Public nFirmaID As Int64 = 0
    Public nStokFisiID As Int64 = 0
    Public islemstatus As Boolean = False
    Dim ds_tbFisTipi As DataSet
    Dim ds_tbGirisCikis As DataSet
    Dim ds_tbDepo As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_satir_firma As DataSet
    Public sFisTipi As String = ""
    Public nGirisCikis As Int64 = 1
    Dim status As Boolean = False
    Public kapla As Boolean = False
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
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
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
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
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
    Private Sub dataload_tbFisTipi()
        ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi,sAciklama FROM         tbFisTipi Where sFisTipi IN ('DG','DC','FS','FA','HA','HS','IA','IS','T')"))
        sec_sFisTipi.Properties.DataSource = ds_tbFisTipi.Tables(0)
        'sec_sFisTipi.EditValue = sFisTipi
        sec_sFisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbGirisCikis(ByVal nGirisCikis As Int64)
        If kapla = False Then
            ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis = '" & nGirisCikis & "'"))
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.ItemIndex = 0
        ElseIf kapla = True Then
            If sec_sFisTipi.EditValue = "FS " Or sec_sFisTipi.EditValue = "HS " Or sec_sFisTipi.EditValue = "DC " Or sec_sFisTipi.EditValue = "IS " Or sec_sFisTipi.EditValue = "T " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (3,4)"))
            ElseIf sec_sFisTipi.EditValue = "FA " Or sec_sFisTipi.EditValue = "HA " Or sec_sFisTipi.EditValue = "DG " Or sec_sFisTipi.EditValue = "IA " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (1,2)"))
            End If
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.EditValue = nGirisCikis
            sec_nGirisCikis.ItemIndex = 0
        End If
        If Trim(sec_sFisTipi.EditValue) = "T" Then
            colsDepo.Visible = True
            colsDepo.Caption = "ÇýkýþDeposu"
            colsTransferDepo.Visible = True
            colsTransferDepo.Caption = "GiriþDeposu"
        Else
            colsDepo.Caption = "Depo"
            colsTransferDepo.Caption = "DepoTransfer"
            colsTransferDepo.Visible = False
        End If
    End Sub
    Private Sub dataload_tbdepo()
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama FROM         tbDepo"))
        sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        If Trim(sDepo) <> "D001" Then
            sec_sDepo.EditValue = sDepo
            sec_sDepo.Properties.ReadOnly = True
        Else
        End If
        'sec_sDepo.ItemIndex = 1
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String) As DataSet
        Dim kriter As String = " AND (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        kriter += " and tbStokFisiMaster.lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'"
        kriter += " and tbStokFisiMaster.lNetTutar between '" & lNetTutar1 & "' and '" & lNetTutar2 & "'"
        If Trim(sDepo) <> "" Then
            kriter += " And tbStokFisiDetayi.sDepo = '" & sDepo & "' "
        End If
        If Trim(sHareketTipi) <> "" Then
            kriter += " And tbStokFisiMaster.sHareketTipi = '" & sHareketTipi & "' "
        End If
        If nGirisCikis > 0 Then
            kriter += " and tbStokFisiMaster.nGirisCikis =" & nGirisCikis & " "
        End If
        If Trim(sFisTipi) = "PF" Then
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        Else
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        End If
        If nStokFisiID > 0 Then
            kriter += " And tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "' "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "T" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.sFisTipi,tbStokFisiMaster.dtefisTarihi, tbStokFisiMaster.dteValorTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis,tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, CASE isnull(tbStokFisiPesinAdres.sAciklama, '') WHEN '' THEN tbFirma.sAciklama ELSE isnull(tbStokFisiPesinAdres.sAciklama, '') END AS sFirmaAciklama, tbHareketTipi.sAciklama AS HT, tbStok.nStokID,tbStok.sKodu AS sStokKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbStok.sKisaAdi,tbstok.sRenk + '-' + tbRenk.sRenkAdi AS sRenk, tbStok.sBeden, tbStok.nHacim,tbStok.nAgirlik,tbStokFisiDetayi.nIslemID,tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sTransferDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lGirisMiktar1, (tbStokFisiDetayi.lBrutFiyat), (tbStokFisiDetayi.lBrutTutar), tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani, rtrim(tbStokFisiDetayi.sStokIslem) + '-' + tbStokIslem.sAciklama AS sStokIslem, '' AS lsiparisNo, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.sAciklama, tbStokFisiMaster.lToplamMiktar, (tbStokFisiMaster.lMalBedeli), (tbStokFisiMaster.lMalIskontoTutari), tbStokFisiMaster.nDipIskontoYuzdesi1, tbStokFisiMaster.nDipIskontoYuzdesi2, (tbStokFisiMaster.lDipIskontoTutari1), (tbStokFisiMaster.lDipIskontoTutari2), (tbStokFisiMaster.lDipIskontoTutari3), tbStokFisiMaster.nKdvOrani1, tbStokFisiMaster.nEvrakNo as EvrakNo, tbStokFisiMaster.nKdvOrani2, tbStokFisiMaster.nKdvOrani3, tbStokFisiMaster.nKdvOrani4, tbStokFisiMaster.nKdvOrani5, (tbStokFisiMaster.lKdv1), (tbStokFisiMaster.lKdv2), (tbStokFisiMaster.lKdv3), (tbStokFisiMaster.lKdv4), (tbStokFisiMaster.lKdv5), tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lEkmaliyet2, tbStokFisiMaster.lEkmaliyet3, ((tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5)) AS lKdv, (((lNetTutar * (1 - bHizmetFaturasiMi)) + ((lMalBedeli - lMalIskontoTutari + lKDV1) * bHizmetFaturasiMi))) AS lNetTutar, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, tbStokFisiMaster.bFisTamamlandimi,bFaturayaDonustumu as sFaturalasti, (tbStokFisiMaster.lKdvMatrahi1), (tbStokFisiMaster.lKdvMatrahi2), (tbStokFisiMaster.lKdvMatrahi3), (tbStokFisiMaster.lKdvMatrahi4), (tbStokFisiMaster.lKdvMatrahi5), ((tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5)) AS lKdvMatrahi, (SELECT TOP 1 ISNULL(sBarkod, '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod, tbStokFisiDetayi.sAciklama,0 AS ISK1, 0 AS ISK2, 0 AS ISK3, 0 AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari, CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat, CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar, tbStokFisiDetayi.sSaticiRumuzu,tbstokFisiDetayi.sDovizCinsi1, tbstokFisiDetayi.lDovizMiktari1, tbStokFisiMaster.nStokFisiId, tbStokFisiMaster.sKullaniciAdi AS MasterKullanici, tbStokFisiMaster.dteKayitTarihi AS MasterTarih, tbStokFisiDetayi.sKullaniciAdi AS DetayKullanici, tbStokFisiDetayi.dteKayitTarihi AS DetayTarih, tbStokFisiDetayi.sSonKullaniciAdi AS DetaySonKullanici, tbStokFisiDetayi.dteSonUpdateTarihi AS DetaySonTarih,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = tbFirma.sFiyatTipi),0) AS FiyatFirma FROM tbFirma, tbHareketTipi, tbStokIslem, tbStokFisiAciklamasi, tbStok, tbStokFisiMaster LEFT OUTER JOIN tbstokFisiPesinAdres ON tbStokFisiMaster.nStokFisiID = tbStokFisipesinAdres.nStokFisiID, tbrenk, tbStokFisiDetayi WHERE tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND tbstok.sRenk = tbrenk.srenk AND tbStokFisiMaster.nFirmaID = tbStokFisiDetayi.nFirmaID AND tbStokFisiDetayi.sStokIslem = tbStokIslem.sStokIslem AND tbHareketTipi.sHareketTipi = tbStokFisiMaster.sHareketTipi AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID AND tbStokFisiMaster.sFisTipi = tbStokFisiDetayi.sFisTipi AND tbStokFisiMaster.dtefisTarihi = tbStokFisiDetayi.dtefisTarihi AND tbStokFisiMaster.nGirisCikis = tbStokFisiDetayi.nGirisCikis AND tbStokFisiMaster.lFisNo = tbStokFisiDetayi.lFisNo " & kriter & " ORDER BY tbStokFisiMaster.dtefisTarihi, tbStokFisiMaster.lFisNo, tbFirma.sKodu,tbStokFisiDetayi.nIslemID")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.sFisTipi,tbStokFisiMaster.dtefisTarihi, tbStokFisiMaster.dteValorTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis,tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, CASE isnull(tbStokFisiPesinAdres.sAciklama, '') WHEN '' THEN tbFirma.sAciklama ELSE isnull(tbStokFisiPesinAdres.sAciklama, '') END AS sFirmaAciklama, tbHareketTipi.sAciklama AS HT, tbStok.nStokID,tbStok.sKodu AS sStokKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbStok.sKisaAdi,tbstok.sRenk + '-' + tbRenk.sRenkAdi AS sRenk, tbStok.sBeden, tbStok.nHacim,tbStok.nAgirlik * isnull (tbStokFisiDetayi.lCikisMiktar1,0) as nAgirlikCikis,tbStok.nAgirlik * isnull (tbStokFisiDetayi.lGirisMiktar1,0) as nAgirlikGiris,tbStokFisiDetayi.nIslemID,tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sTransferDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lGirisMiktar1, (tbStokFisiDetayi.lBrutFiyat), (tbStokFisiDetayi.lBrutTutar), tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani, rtrim(tbStokFisiDetayi.sStokIslem) + '-' + tbStokIslem.sAciklama AS sStokIslem, '' AS lsiparisNo, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.sAciklama, tbStokFisiMaster.lToplamMiktar, (tbStokFisiMaster.lMalBedeli), (tbStokFisiMaster.lMalIskontoTutari), tbStokFisiMaster.nDipIskontoYuzdesi1, tbStokFisiMaster.nDipIskontoYuzdesi2, (tbStokFisiMaster.lDipIskontoTutari1), (tbStokFisiMaster.lDipIskontoTutari2), (tbStokFisiMaster.lDipIskontoTutari3), tbStokFisiMaster.nKdvOrani1, tbStokFisiMaster.nEvrakNo as EvrakNo, tbStokFisiMaster.nKdvOrani2, tbStokFisiMaster.nKdvOrani3, tbStokFisiMaster.nKdvOrani4, tbStokFisiMaster.nKdvOrani5, (tbStokFisiMaster.lKdv1), (tbStokFisiMaster.lKdv2), (tbStokFisiMaster.lKdv3), (tbStokFisiMaster.lKdv4), (tbStokFisiMaster.lKdv5), tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lEkmaliyet2, tbStokFisiMaster.lEkmaliyet3, ((tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5)) AS lKdv, (((lNetTutar * (1 - bHizmetFaturasiMi)) + ((lMalBedeli - lMalIskontoTutari + lKDV1) * bHizmetFaturasiMi))) AS lNetTutar, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, tbStokFisiMaster.bFisTamamlandimi,bFaturayaDonustumu as sFaturalasti, (tbStokFisiMaster.lKdvMatrahi1), (tbStokFisiMaster.lKdvMatrahi2), (tbStokFisiMaster.lKdvMatrahi3), (tbStokFisiMaster.lKdvMatrahi4), (tbStokFisiMaster.lKdvMatrahi5), ((tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5)) AS lKdvMatrahi, (SELECT TOP 1 ISNULL(sBarkod, '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari, CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat, CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar, tbStokFisiDetayi.sSaticiRumuzu,tbstokFisiDetayi.sDovizCinsi1, tbstokFisiDetayi.lDovizMiktari1, tbStokFisiMaster.nStokFisiId, tbStokFisiMaster.sKullaniciAdi AS MasterKullanici, tbStokFisiMaster.dteKayitTarihi AS MasterTarih, tbStokFisiDetayi.sKullaniciAdi AS DetayKullanici, tbStokFisiDetayi.dteKayitTarihi AS DetayTarih, tbStokFisiDetayi.sSonKullaniciAdi AS DetaySonKullanici, tbStokFisiDetayi.dteSonUpdateTarihi AS DetaySonTarih,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = tbFirma.sFiyatTipi),0) AS FiyatFirma FROM tbFirma, tbHareketTipi, tbStokIslem, tbStokFisiAciklamasi, tbStok, tbStokFisiMaster LEFT OUTER JOIN tbstokFisiPesinAdres ON tbStokFisiMaster.nStokFisiID = tbStokFisipesinAdres.nStokFisiID, tbrenk, tbStokFisiDetayi WHERE tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND tbstok.sRenk = tbrenk.srenk AND tbStokFisiMaster.nFirmaID = tbStokFisiDetayi.nFirmaID AND tbStokFisiDetayi.sStokIslem = tbStokIslem.sStokIslem AND tbHareketTipi.sHareketTipi = tbStokFisiMaster.sHareketTipi AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID AND tbStokFisiMaster.sFisTipi = tbStokFisiDetayi.sFisTipi AND tbStokFisiMaster.dtefisTarihi = tbStokFisiDetayi.dtefisTarihi AND tbStokFisiMaster.nGirisCikis = tbStokFisiDetayi.nGirisCikis AND tbStokFisiMaster.lFisNo = tbStokFisiDetayi.lFisNo " & kriter & " ORDER BY tbStokFisiMaster.dtefisTarihi, tbStokFisiMaster.lFisNo, tbFirma.sKodu,tbStokFisiDetayi.nIslemID")
        End If
        'If Trim(sFisTipi) = "PF" Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot, tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5 AS KdvTutari, tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5 AS KdvMatrahi, tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 AS EkMaliyet, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli, CAST(0 AS MONEY) AS ISKONTO, tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI, CAST(0 AS MONEY) AS EkOran, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari3, tbMusteri.nMusteriID, tbMusteri.lKodu AS sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAciklama FROM tbStokFisiMaster INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        'Else
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        'End If
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
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
        Return DS
    End Function
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String)
        status = True
        DataSet1 = stok(ara, konum, ara_kriter, sFisTipi, nGirisCikis, dteFisTarihi1, dteFisTarihi2, lFisNo1, lFisNo2, lNetTutar1, lNetTutar2, sDepo, sHareketTipi)
        'Dim dr1 As DataRow
        'For Each dr1 In DataSet1.Tables(0).Rows
        '    Try
        '        dr1("ISKONTO") = (dr1("lIskontoTutari")) / dr1("lMalBedeli")
        '        If CType(dr1("Ekmaliyet"), Decimal) <> 0 Then
        '            dr1("EkOran") = CType(dr1("Ekmaliyet"), Decimal) / CType(dr1("lMalBedeli") - dr1("lMalIskontoTutari") - dr1("lDipIskontoTutari"), Decimal)
        '        End If
        '    Catch ex As Exception
        '    End Try
        'Next
        'dr1 = Nothing
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        satir_firma_info()
        status = True
        'If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
        '    colsFaturalasti.Visible = True
        'Else
        '    colsFaturalasti.Visible = False
        'End If
    End Sub
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sFisTipi")) = "PF" Then
                Dim frm As New frm_musteri_karti
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.musterino = dr("sFirmaKodu")
                frm.musteriID = dr("nMusteriID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            Else
                Dim frm As New frm_firma_kart
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.sKodu = dr("sFirmaKodu")
                frm.nFirmaID = dr("nFirmaID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub Fis_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        Dim frm_firma As New frm_firma_liste
        frm_firma.firmano = firmano
        frm_firma.donemno = donemno
        frm_firma.connection = connection
        frm_firma.islemstatus = True
        frm_firma.kullanici = kullanici
        If frm_firma.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm_firma.GridView1.GetDataRow(frm_firma.GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nStokFisiID = ""
            frm.nFirmaID = dr1("nFirmaID")
            frm.sFisTipi = sFisTipi
            If sFisTipi = "HS " Or sFisTipi = "HA " Then
                frm.bHizmetFaturasimi = True
            End If
            frm.nGirisCikis = nGirisCikis
            frm.dteFisTarihi = Today
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            ara()
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteFisTarihi")
            frm.sFisTipi = dr("sFisTipi")
            frm.nFirmaID = dr("nFirmaID")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokFisiID = dr("nStokFisiID")
            frm.kullanici = kullanici
            Dim satir = GridView1.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_cari_bakiye()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sFirmaKodu")
            frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub satir_firma_info()
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
                Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
                label3.Text = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
                label3.Refresh()
                dr1 = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sKodu = dr("sStokKodu")
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
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sStokKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
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
            frm.musterino = dr("sStokKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "Çýkýþlar"
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
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sStokKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub irsaliyelestir_kontrol()
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                If dr("sFaturalasti") <> True Then
                    If dr("nFirmaID").ToString <> nFirmaID.ToString Then
                        nFirmaID = dr("nFirmaID").ToString
                        sayi += 1
                    End If
                End If
            Next
        End If
        If sayi = 1 Then
            If sec_sFisTipi.EditValue = "IA" Or sec_sFisTipi.EditValue = "IS" Then
                MenuItem13.Visible = True
                MenuItem13.Enabled = True
            End If
        Else
            MenuItem13.Visible = False
            MenuItem13.Enabled = False
        End If
    End Sub
    Private Sub fis_faturala()
        Dim frm As New frm_stok_cari_alis_aciklama
        frm.txt_tarih.EditValue = dteSistemTarihi
        frm.txt_belgeno.EditValue = 1
        Dim sFisTipi As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim arr As Integer()
            Dim i As Integer
            Dim nFirmaSayi As Integer = 0
            Dim sayi As Integer = 0
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim nFirmaID As String = ""
            Dim sFisNolari As String = ""
            Dim enStokFisiID As String = "("
            Dim nStokFisiID As String = ""
            Dim lFisNo As Int64
            Dim dteFisTarihi As DateTime
            Dim s As String
            Dim dr As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If dr("sFaturalasti") <> True Then
                        If dr("nFirmaID").ToString <> nFirmaID.ToString Then
                            nFirmaID = dr("nFirmaID")
                            nFirmaSayi += 1
                        End If
                        sFisNolari += dr("lFisNo") & vbCrLf
                        enStokFisiID += dr("nStokFisiID").ToString
                        sayi += 1
                        If sayi < toplamsayi Then
                            enStokFisiID += ","
                        ElseIf sayi = toplamsayi Then
                            enStokFisiID += ")"
                        End If
                    End If
                Next
            End If
            sFisTipi = sec_sFisTipi.EditValue
            nGirisCikis = sec_nGirisCikis.EditValue
            If XtraMessageBox.Show(sFisNolari & Sorgu_sDil(" Nolu Fiþleri ", sDil) & frm.txt_tarih.EditValue & Sorgu_sDil(" Tarih ", sDil) & frm.txt_belgeno.EditValue & Sorgu_sDil(" Nolu Faturaya Dönüþtürmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim esFisTipi = sFisTipi
                Dim enGirisCikis = nGirisCikis
                Dim enFirmaID = nFirmaID
                nStokFisiID = sorgu_nStokFisiID()
                nFirmaID = nFirmaID
                lFisNo = frm.txt_belgeno.EditValue
                If Trim(sFisTipi) = "IA" Then
                    sFisTipi = "FA"
                ElseIf Trim(sFisTipi) = "IS" Then
                    sFisTipi = "FS"
                End If
                dteFisTarihi = frm.txt_tarih.EditValue
                'Dim dr As DataRow
                'If sFisTipi = "FS " Or sFisTipi = "DC " Or sFisTipi = "HS " Then
                'ElseIf sFisTipi = "FA " Or sFisTipi = "DG " Or sFisTipi = "HA " Then
                'End If
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, "", dteFisTarihi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", dr("sHareketTipi"), 0, 0, 0, "", "", 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0)
                tbStokFisiMaster_lFisno_degistir(nStokFisiID)
                tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, "", "", "", "", "")
                tbStokFisidetay_kaydet_faturala(sFisTipi, dteFisTarihi, lFisNo, dr("sHareketTipi"), nStokFisiID, enStokFisiID)
                'Fiþi Göster
                Dim fm As New frm_fatura
                fm.firmano = firmano
                fm.donemno = donemno
                fm.connection = connection
                fm.lFisNo = lFisNo
                fm.dteFisTarihi = dteFisTarihi
                fm.sFisTipi = sFisTipi
                fm.nFirmaID = nFirmaID
                fm.nGirisCikis = nGirisCikis
                fm.nStokFisiID = nStokFisiID
                fm.kullanici = kullanici
                fm.aktarim = True
                fm.Text = "Fis#Faturalanmýþ"
                If yetki_kontrol(kullanici, fm.Name) = True Then
                    fm.ShowDialog()
                End If
                fm.Close()
                fm = Nothing
                ara()
            End If
            frm.Close()
            frm = Nothing
        End If
    End Sub
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        
        ' AUDIT LOG: Fatura oluþturuldu
        Try
            LogFatura("YENI", nStokFisiID, lFisNo.ToString(), "Fatura oluþturuldu: " & sFisTipi & ", Tutar: " & lNetTutar)
        Catch
        End Try
        
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisidetay_kaydet_faturala(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal sHareketTipi As String, ByVal nStokFisiID As String, ByVal enStokFisiID As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              bFaturayaDonustumu = 1, sHareketTipi = '" & sHareketTipi & "' WHERE     (nStokFisiID IN " & enStokFisiID & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', nStokFisiID = '" & nStokFisiID & "', lFisNo = " & lFisNo & ", sHareketTipi = '" & sHareketTipi & "' WHERE     (nStokFisiID IN " & enStokFisiID & ") ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (nHareketID IN (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      nStokFisiID IN " & enStokFisiID & "))")
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
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
            SaveFileDialog1.FileName = "Rapor.txt"
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
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lNetTutar1.EditValue, txt_lNetTutar2.EditValue, sec_sDepo.EditValue, sec_sHareketTipi.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If status = True Then
            Try
                satir_firma_info()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        irsaliyelestir_kontrol()
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("sAciklama1").ToString & vbCrLf & dr("sAciklama2").ToString & vbCrLf & dr("sAciklama3").ToString & vbCrLf & dr("sAciklama4").ToString & vbCrLf & dr("sAciklama5").ToString
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        fis_duzelt()
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
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_Firma_karti()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_cari_hareket()
    End Sub
    Private Sub frm_fatura_liste_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If islemstatus = False Then
            Dispose()
        End If
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        connection_resmi1 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi1")
        dataload_tbFisTipi()
        dataload_tbGirisCikis(nGirisCikis)
        dataload_tbdepo()
        dataload_tbHareketTipi()
        sec_sFisTipi.EditValue = sFisTipi
        sec_nGirisCikis.EditValue = nGirisCikis.ToString()
        If nStokFisiID = 0 Then
            txt_dteFisTarihi1.EditValue = dteSistemTarihi
            txt_dteFisTarihi2.EditValue = dteSistemTarihi
        Else
            txt_dteFisTarihi1.EditValue = "01/01/1900"
            txt_dteFisTarihi2.EditValue = "31/12/2078"
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        If kapla = True Then
            sec_sFisTipi.Enabled = True
            sec_nGirisCikis.Enabled = True
        End If
        If Trim(sFisTipi) = "T" Then
            If yetki_kontrol(kullanici, "frm_fatura_kalemleri", False) = False Then
                sec_sFisTipi.Enabled = False
            End If
        End If
        ara()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteFisTarihi1.Focus()
        txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        fis_duzelt()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Fis_ekle(sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue)
    End Sub
    Private Sub sec_sFisTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFisTipi.EditValueChanged
        dataload_tbGirisCikis(nGirisCikis)
    End Sub
    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        fis_faturala()
    End Sub
    Private Sub MenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        analiz_stok_karti()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        analiz_envanter()
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            ara()
            sec_resmi1.Checked = False
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub sec_resmi1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi1.CheckStateChanged
        If sec_resmi1.Checked = True Then
            connection = connection_resmi1
            ara()
            sec_resmi.Checked = False
        ElseIf sec_resmi1.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        If MenuItem27.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem27.Checked = True
        ElseIf MenuItem27.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem27.Checked = False
        End If
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        txt_dteFisTarihi1.Focus()
        txt_dteFisTarihi1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_pdf()
    End Sub
    Friend WithEvents collEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisAgirlik As DevExpress.XtraGrid.Columns.GridColumn

End Class
